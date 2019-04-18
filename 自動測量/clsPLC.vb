Public Class clsPLC
    Inherits clsDataBase


    Private mblnComOk As Boolean            ''通信フラグ

    Private mblnBlink As Boolean 'ブリンク


    Private _EngValue As Dictionary(Of String, Single) 'アナログの工業値

    Private _gyro As Single                 'ジャイロ方位角
    Private _gyroPitching As Single         'ジャイロピッチング
    Private _gyroRolling As Single              'ジャイロローリング
    Private _machinePitching As Single         ''マシンピッチング
    Private _mashineRolling As Single          ''マシンローリング
    Private _mashineRearRolling As Single   'マシン後胴ローリング
    Private _realStroke As Integer       ''掘進実ストローク
    Private _excaStatus As Integer     ''掘進ステータス

    Private _RightUpNkStroke As Integer         '右上中折ストローク
    Private _RightDownNkStroke As Integer         '右下中折ストローク
    Private _LeftDownNkStroke As Integer         '左下中折ストローク
    Private _LeftUpNkStroke As Integer         '左上中折ストローク

    Private _RingNo As Integer           ''リング番号

    Public AnalogTag As clsTag
    Public ParameterTag As clsTag

    'DB保存用データ変数
    Private AnalogComData() As Short
    Private ParmterComData() As Short
    Private sharrDeviceValue() As Short         'デバイス値

    ''' <summary>
    ''' 待機中になった
    ''' </summary>
    Public Event ToWaiting()




    Public ReadOnly Property gyro As Single
        Get
            Return _gyro
        End Get
    End Property

    Public ReadOnly Property gyroPitching As Single
        Get
            Return _gyroPitching
        End Get
    End Property

    Public ReadOnly Property machinePitching As Single
        Get
            Return _machinePitching
        End Get
    End Property

    Public ReadOnly Property mashineRolling As Single
        Get
            Return _mashineRolling
        End Get
    End Property
    Public ReadOnly Property mashineRearRolling As Single
        Get
            Return _mashineRearRolling
        End Get
    End Property
    Public ReadOnly Property realStroke As Integer
        Get
            Return _realStroke
        End Get
    End Property
    Public ReadOnly Property excaStatus As Integer
        Get
            Return _excaStatus
        End Get
    End Property

    Public ReadOnly Property RingNo As Integer
        Get
            Return _RingNo
        End Get
    End Property


    Public ReadOnly Property RightDownNkStroke As Integer
        Get
            Return _RightDownNkStroke
        End Get
    End Property

    Public ReadOnly Property RightUpNkStroke As Integer
        Get
            Return _RightUpNkStroke
        End Get
    End Property
    Public ReadOnly Property LeftDownNkStroke As Integer
        Get
            Return _LeftDownNkStroke
        End Get
    End Property
    Public ReadOnly Property LeftUpNkStroke As Integer
        Get
            Return _LeftUpNkStroke
        End Get
    End Property






    Public Sub New()
        AnalogTag = New clsTag("FLEXアナログtag", "D")
        ParameterTag = New clsTag("FLEXアナログtag", "R")

        _EngValue = New Dictionary(Of String, Single)
        '工業値のDictionary 初期化
        For Each an In AnalogTag.Tag
            _EngValue.Add(an.FieldName, 0)
        Next

        PLC_Read()

        TimerRun()

    End Sub
    ''' <summary>
    ''' データを取得した時間
    ''' </summary>
    Public ReadOnly Property DataGetTime As DateTime


    Public Sub TimerRun()

        'RaiseEvent ExcavationStatusChange(0, 0)
        'RaiseEvent LineDistanceChage()

        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf PLC_Read)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ
        '計算ジャッキストロークの演算
        'RaiseEvent MesureStrokeChange()
    End Sub

    ''' <summary>
    ''' シーケンサ読込　１秒毎
    ''' </summary>
    Public Sub PLC_Read()

        'Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Dim szDeviceName As String = ""         'デバイス名称
        Dim iNumberOfDeviceName As Integer = 0  'デバイス・サイズ

        'モニタモード時は、DBよびPLC通信データを読込
        Dim tb As DataTable = GetDtfmSQL("SELECT * FROM plccomdata ORDER BY TIME DESC LIMIT 0,1")
            If tb.Rows.Count > 0 Then
                'アナログデータ
                AnalogComData =
                (From i In tb.Rows(0).Item("Analog").ToString.Split(",") Select Int16.Parse(i)).ToArray
                'パラメータ
                ParmterComData =
                (From i In tb.Rows(0).Item("Parameter").ToString.Split(",") Select CShort(i)).ToArray
            'データを取得した時刻　フォームに表示
            _DataGetTime = DateTime.Parse(tb.Rows(0).Item("TIME")).AddSeconds(tb.Rows(0).Item("SEC"))
            End If


        '==============================================================================================================
        'モニタモード時は無条件に実施
        '保存用データ保持

        sharrDeviceValue = AnalogComData


        For Each at In AnalogTag.Tag
            _EngValue(at.FieldName) = GetAnalogData(at.FieldName, AnalogTag)
        Next

        _gyro = _EngValue("ジャイロ方位")
        _gyroPitching = _EngValue("ジャイロピッチング")
        _gyroRolling = _EngValue("ジャイロローリング")
        _machinePitching = _EngValue("マシンピッチング")
        _mashineRolling = _EngValue("マシンローリング")
        _mashineRearRolling = _EngValue("後胴ローリング")

        _realStroke = _EngValue("掘進ストローク")

        Dim excaStsPre As Integer = _excaStatus
        _excaStatus = _EngValue("掘進ステータス")
        '待機中に変わったか
        If excaStsPre <> cTaiki And _excaStatus = cTaiki Then
            RaiseEvent ToWaiting()
        End If


        _RightUpNkStroke = _EngValue("右上中折ストローク")
        _RightDownNkStroke = _EngValue("右下中折ストローク")
        _LeftDownNkStroke = _EngValue("左下中折ストローク")
        _LeftUpNkStroke = _EngValue("左上中折ストローク")





        sharrDeviceValue = ParmterComData

        _RingNo = GetAnalogData("RingNo", ParameterTag)



    End Sub


    Private Function GetAnalogData(ByVal FieldName As String, Tag As clsTag) As Single
        'アナログデータのスケール変換
        Try
            With Tag.TagData(FieldName)
                If .ScaleHigh - .ScaleLow = 0 Then
                    Return 0
                End If
                Dim tData As Single
                If .ScaleHigh > 32767 Then  '2wordの時
                    Dim TmpHigh As Single = sharrDeviceValue(.OffsetAddress + 1)
                    tData = sharrDeviceValue(.OffsetAddress)
                    If tData < 0 Then tData = 65536 + tData
                    tData = TmpHigh * 65536 + tData     ' HI*&h10000 + LO (16->32Bit)
                    If tData >= 2 ^ 31 Then
                        tData = tData - (2 ^ 32)
                    End If

                Else
                    tData = sharrDeviceValue(.OffsetAddress)
                End If

                'スケール変換
                Return (tData - Tag.TagData(FieldName).ScaleLow) * (Tag.TagData(FieldName).EngHight - Tag.TagData(FieldName).EngLow) / (Tag.TagData(FieldName).ScaleHigh - Tag.TagData(FieldName).ScaleLow) + Tag.TagData(FieldName).EngLow  ' + .EngLow


            End With
        Catch ex As Exception
            MsgBox($"GetAnalogDataでエラー{vbCrLf}{ex.Message}{vbCrLf}フィールド名:{FieldName}{vbCrLf}{Environment.StackTrace.ToString}")
            Return 0
        End Try
    End Function

End Class
