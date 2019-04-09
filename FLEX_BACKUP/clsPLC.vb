Imports System.Convert

Public Class clsPlcIf

    Inherits clsDataBase


    Public AnalogTag As clsTag
    Private AnalogComData() As Short

    Private _EngValue As Dictionary(Of String, Single) 'アナログの工業値

    Private _excaStatus As Integer     ''掘進ステータス

    ''' <summary>
    ''' モニタモードでデータを取得した時間
    ''' </summary>
    Public ReadOnly Property DataGetTime As DateTime

    Private sharrDeviceValue() As Short         'デバイス値


    ''' <summary>
    ''' 掘進ステータス
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ExcaStatus As Integer
        Get
            Return _excaStatus
        End Get
    End Property



    Public Sub New()
        AnalogTag = New clsTag("FLEXアナログtag", "D")

        _EngValue = New Dictionary(Of String, Single)
        '工業値のDictionary 初期化
        For Each an In AnalogTag.Tag
            _EngValue.Add(an.FieldName, 0)
        Next

        TimerRun()

    End Sub
    Public Sub TimerRun()


        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf PLC_Read)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ
    End Sub



    Public Sub PLC_Read()
        Dim szDeviceName As String = ""         'デバイス名称
        Dim iNumberOfDeviceName As Integer = 0  'デバイス・サイズ


        'モニタモード時は、DBよびPLC通信データを読込
        Dim tb As DataTable = GetDtfmSQL("SELECT * FROM plccomdata ORDER BY TIME DESC LIMIT 0,1")
            If tb.Rows.Count > 0 Then
                'アナログデータ
                AnalogComData =
                (From i In tb.Rows(0).Item("Analog").ToString.Split(",") Select Int16.Parse(i)).ToArray
                'データを取得した時刻　フォームに表示
                _DataGetTime = DateTime.Parse(tb.Rows(0).Item("TIME")).AddSeconds(tb.Rows(0).Item("SEC"))
            End If

        sharrDeviceValue = AnalogComData


        'For Each at In AnalogTag.Tag
        '    _EngValue(at.FieldName) = GetAnalogData(at.FieldName, AnalogTag)
        'Next

        _excaStatus = GetAnalogData("掘進ステータス", AnalogTag)

        '==============================================================================================================

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

