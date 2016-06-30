'Public Structure Group
'    Public Pv As Single ''グループ圧PV
'    Public Sv As Single ''グループ圧SV
'    Public Mv As Single ''グループ圧MV
'    Public Flg As Short ''グループ圧制御フラグ
'End Structure
Public Class clsPlcIf

    Private mblnComOk As Boolean            ''通信フラグ

    'Private _group() As Group       'グループ圧力データ

    Private _groupPv() As Single 'グループ圧力データ
    Private _groupSv() As Single
    Private _groupMv() As Single
    Private _groupFlg() As Short

    Private _gyro As Single           ''ジャイロ方位角
    Private _gyroPitching As Single         ''ジャイロピッチング
    Private _gyroRolling As Single          ''ジャイロローリング
    Private _machinePitching As Single         ''マシンピッチング
    Private _mashineRolling As Single          ''マシンローリング
    Private _nakaoreLR As Single           ''中折左右角
    Private _nakaoreTB As Single           ''中折上下角
    Private _jkPress As Single           ''シールド元圧
    Private _rightStroke As Integer          ''右ストローク
    Private _leftStroke As Integer          ''左ストローク
    Private _topStroke As Integer          ''上ストローク
    Private _botomStroke As Integer          ''下ストローク
    Private _rightSpeed As Integer           ''右スピード
    Private _leftSpeed As Integer           ''左スピード
    Private _topSpeed As Integer           ''上スピード
    Private _botomSpeed As Integer           ''下スピード
    Private _realStroke As Integer       ''掘進実ストローク
    Private _beforeStroke As Integer       ''前スキャンの掘進実ストローク
    Private _jackSelect() As Boolean         ''稼働ジャッキ

    Private _JackStatus() As Short      ''ジャッキのステータス

    Private _flexControlOn As Boolean         ''FLEX制御ON
    '    Private _autoDirectionContorolFLG As Boolean ''自動方向制御フラグ
    Private _contorolModeFLG As Boolean ''制御モードフラグ
    Private _excaStatus As Integer     ''掘進ステータス

    Private mint掘進中最大ストローク As Short

    Private _gyiroError As Boolean ''ジャイロエラー

    Private _mint元圧フィルタ係数 As Integer

    Private _msngFilterJkPress As Single     ''フィルター後のシールド圧

    Private _mintIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）

    'Private _mdbl測量ポイントリング番号 As Double ''測量ポイントリング番号
    'Private _mdbl測量ポイント総距離 As Double     ''測量ポイント総距離
    'Private _mdbl鉛直入力補正値 As Double        ''鉛直入力補正値
    'Private _mdbl水平入力補正値 As Double        ''水平入力補正値
    'Private _mdblジャッキモーメント上限値 As Double        ''ジャッキモーメント上限値
    'Private _mdbl最大全開出力時の目標圧力 As Single        ''最大全開出力時の目標圧力
    'Private _msng偏差角許容値 As Single        ''偏差角許容値
    ' ''01/09/20 追加
    'Private _mdbl圧力制御開始推力値 As Double        ''圧力制御開始推力値
    'Private _mbln圧力制御開始推力値有効フラグ As Boolean        ''圧力制御開始推力値有効フラグ
    'Private _mbln全押しスタート As Boolean        ''全押しスタート


    ' ''力点座標
    'Private _mdblPointX As Double        ''Ｘ座標
    'Private _mdblPointY As Double        ''Ｙ座標
    ''操作強、角
    'Private _mdbl操作強 As Double
    'Private _mdbl操作角 As Double

    'パラメータ　Rレジスタ
    Private _リング番号 As Integer           ''リング番号

    Private _ストローク管理法 As Integer    'ストローク管理法0:MAX 1:右 2:左 3:左右平均
    Private _掘進判定ストローク As Integer
    Private _終了判定ストローク As Integer
    Private _終了判定引きストローク As Integer
    Private _中断判定速度 As Single
    Private _終了判定時間 As Integer

    Private _減圧弁制御P定数 As Integer
    Private _減圧弁制御I定数 As Integer
    Private _減圧弁制御D定数 As Integer

    ''偏差過大の時の設定値　
    Private _感度調整減圧弁制御Ｐ定数 As Integer
    Private _感度調整減圧弁制御Ｉ定数 As Integer
    Private _GaingSetReducingValveContDConst As Integer
    Private _感度調整設定圧力偏差 As Single

    'Private _mblnピッチロールIN As Integer


    'Private _mintHorJackContPConst As Integer
    'Private _mintHorJackContIConst As Integer
    'Private _mintVerJackContPConst As Integer
    'Private _mintVerJackContIConst As Integer
    'Private _msngContMode切替作動範囲 As Single
    'Private _mint全開作動範囲 As Integer
    'Private _mint全開作動指令値 As Integer
    'Private _msng圧力許容値 As Single
    'Private _mbln片押し制限Flag As Boolean
    'Private _mint最低全開グループ数 As Integer
    'Private _mbln全開ContFlag As Boolean
    'Private _mintExca中最大Stroke As Integer
    'Private _mintExca開始Stroke As Integer
    'Private _msng片押しR制限 As Single


    ' ''前回の値を保持するレジスタ(イベントを起こすため）
    Private _msngPreGpPv() As Single            ''グループ圧PV
    Private _msngPreGpSv() As Single            ''グループ圧SV
    Private _msngPreGpMv() As Single            ''グループ圧MV
    Private _mintPreGpFlg() As Integer          ''グループ圧制御フラグ
    Private _mintPreRingNo As Integer           ''リング番号
    Private _msngPreJyairo As Single           ''ジャイロ方位角
    Private _msngPrePitching As Single         ''ピッチング
    Private _mintPreRealStroke As Integer       ''掘進実ストローク
    Private _mintPreExcaStatus As Integer     ''掘進ステータス
    'Private _mdblPreSurveyPointRingNo As Double ''測量ポイントリング番号
    'Private _mdblPreSurveyPointDistance As Double     ''測量ポイント総距離
    'Private _mdblPreVerCorrectionValue As Double        ''鉛直入力補正値
    'Private _mdblPreHorCorrectionValue As Double        ''水平入力補正値
    Private _mintPreIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）
    Private _mblnPreContModeFlag As Boolean ''制御モードフラグ
    Private _mvarPressWrData() As Object    ''圧力シーケンサ書き込み用
    Private _mblnPre自動方向ContFlag As Boolean ''自動方向制御フラグ

    'Private _mdblPrePointX As Double        ''ポイント座標Ｘ
    'Private _mdblPrePointY As Double        ''ポイント座標Ｙ



    Private WithEvents com_ReferencesEasyIF As ACTMULTILib.ActEasyIF

    Public Event PLCRead(ByVal sender As Object, ByVale As EventArgs) 'PLC読込イベント
    Public Event PLCErrOccur(ByVal sender As Object, ByVale As EventArgs, ByVal ErrMsg As String) 'PLC読込イベント

    Private AnalogTag As New clsTag("アナログtag", "D")
    Public ParameterTag As New clsTag("アナログtag", "R")
    Private DigtalTag As New clsTag("デジタルtag", "M")
    Private sharrDeviceValue() As Short         'デバイス値


    Public ReadOnly Property Gyro() As Single
        Get
            Return _gyro
        End Get
    End Property
    ''' <summary>
    ''' グループ圧PV
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GroupPv() As Single()
        Get
            Return _groupPv
        End Get
    End Property
    ''' <summary>
    ''' グループ圧SV（設定値)
    ''' </summary>
    ''' <returns></returns>
    Public Property GroupSV As Single()
        Get
            Return _groupSv
        End Get
        Set(value As Single())
            _groupSv = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' グループ圧MV（操作出力)
    ''' </summary>
    ''' <returns></returns>
    Public Property GroupMV As Single()
        Get
            Return _groupMv
        End Get
        Set(value As Single())
            _groupMv = value
        End Set
    End Property
    ''' <summary>
    ''' グループ圧フラグ
    ''' </summary>
    ''' <returns></returns>
    Public Property GroupFlg As Short()
        Get
            Return _groupFlg
        End Get
        Set(value As Short())
            _groupFlg = value
        End Set
    End Property

    ''' <summary>
    ''' ピッチング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Pitching As Single
        Get
            Return _gyroPitching
        End Get
    End Property

    Public ReadOnly Property Rolling As Single
        Get
            Return _gyroRolling
        End Get
    End Property
    Public ReadOnly Property NakaoreLR As Single
        Get
            Return _nakaoreLR
        End Get
    End Property
    Public ReadOnly Property NakaoreTB As Single
        Get
            Return _nakaoreTB
        End Get
    End Property
    Public ReadOnly Property JkPress As Single
        Get
            Return _jkPress
        End Get
    End Property
    Public ReadOnly Property RightStroke As Single
        Get
            Return _rightStroke
        End Get
    End Property
    Public ReadOnly Property LeftStroke As Single
        Get
            Return _leftStroke
        End Get
    End Property
    Public ReadOnly Property TopStroke As Single
        Get
            Return _topStroke
        End Get
    End Property
    Public ReadOnly Property BotomStroke As Single
        Get
            Return _botomStroke
        End Get
    End Property
    Public ReadOnly Property RightSpeed As Single
        Get
            Return _rightSpeed
        End Get
    End Property
    Public ReadOnly Property LeftSpeed As Single
        Get
            Return _leftSpeed
        End Get
    End Property
    Public ReadOnly Property TopSpeed As Single
        Get
            Return _topSpeed
        End Get
    End Property
    Public ReadOnly Property BotomSpeed As Single
        Get
            Return _botomSpeed
        End Get
    End Property
    Public ReadOnly Property RealStroke As Integer
        Get
            Return _realStroke
        End Get
    End Property
    Public ReadOnly Property JackSel() As Boolean()
        Get
            Return _jackSelect
        End Get
    End Property

    Public ReadOnly Property JackStatus() As Short()
        Get
            Return _JackStatus

        End Get
    End Property

    Public ReadOnly Property FlexControlOn As Boolean
        Get
            Return _flexControlOn
        End Get
    End Property
    Public ReadOnly Property ExcaStatus As Integer
        Get
            Return _excaStatus
        End Get
    End Property
    Public ReadOnly Property GyiroError As Boolean
        Get
            Return _gyiroError
        End Get
    End Property

    Public ReadOnly Property 掘進中最大ストローク As Short
        Get
            Return mint掘進中最大ストローク
        End Get
    End Property

    Public Property リング番号 As Integer
        Get
            Return _リング番号
        End Get
        Set(value As Integer)
            _リング番号 = value
            Call ParameterWrite(value)
        End Set
    End Property

    Public Property ストローク管理法 As Integer
        Get
            Return _ストローク管理法
        End Get
        Set(value As Integer)
            _ストローク管理法 = value
        End Set
    End Property

    Public Property 掘進判定ストローク As Integer
        Get
            Return _掘進判定ストローク
        End Get
        Set(value As Integer)
            _掘進判定ストローク = value
        End Set
    End Property

    Public Property 終了判定ストローク As Integer
        Get
            Return _終了判定ストローク
        End Get
        Set(value As Integer)
            _終了判定ストローク = value
        End Set
    End Property
    Public Property 終了判定引きストローク As Integer
        Get
            Return _終了判定引きストローク
        End Get
        Set(value As Integer)
            _終了判定引きストローク = value
        End Set
    End Property

    Public Property 中断判定速度 As Integer
        Get
            Return _中断判定速度
        End Get
        Set(value As Integer)
            _中断判定速度 = value
        End Set
    End Property

    Public Property 終了判定時間 As Integer
        Get
            Return _終了判定時間
        End Get
        Set(value As Integer)
            _終了判定時間 = value
        End Set
    End Property

    Public Property 減圧弁制御p定数 As Integer
        Get
            Return _減圧弁制御P定数
        End Get
        Set(value As Integer)
            _減圧弁制御P定数 = value
        End Set
    End Property

    Public Property 減圧弁制御i定数 As Integer
        Get
            Return _減圧弁制御I定数
        End Get
        Set(value As Integer)
            _減圧弁制御I定数 = value
        End Set
    End Property

    Public Property 減圧弁制御D定数 As Integer
        Get
            Return _減圧弁制御D定数
        End Get
        Set(value As Integer)
            _減圧弁制御D定数 = value
        End Set
    End Property

    Public Property 感度調整減圧弁制御Ｐ定数 As Integer
        Get
            Return _感度調整減圧弁制御Ｐ定数
        End Get
        Set(value As Integer)
            _感度調整減圧弁制御Ｐ定数 = value
        End Set
    End Property

    Public Property 感度調整減圧弁制御Ｉ定数 As Integer
        Get
            Return _感度調整減圧弁制御Ｉ定数
        End Get
        Set(value As Integer)
            _感度調整減圧弁制御Ｉ定数 = value
        End Set
    End Property

    Public Property GaingSetReducingValveContDConst As Integer
        Get
            Return _GaingSetReducingValveContDConst
        End Get
        Set(value As Integer)
            _GaingSetReducingValveContDConst = value
        End Set
    End Property

    Public Property 感度調整設定圧力偏差 As Single
        Get
            Return _感度調整設定圧力偏差
        End Get
        Set(value As Single)
            _感度調整設定圧力偏差 = value
        End Set
    End Property


    Public Sub New()
        '* ACTコントロール用インスタンスの生成*************************************/
        com_ReferencesEasyIF = New ACTMULTILib.ActEasyIF
        com_ReferencesEasyIF.ActLogicalStationNumber = InitParameter.ActLogicalStationNumber   'PLC論理局

        'ReDim _group(InitParameter.NumberGroup - 1) 'グループ圧力
        ReDim _groupPv(InitParameter.NumberGroup - 1) 'グループ圧力Pv
        ReDim _groupSv(InitParameter.NumberGroup - 1) 'グループ圧力Sv
        ReDim _groupMv(InitParameter.NumberGroup - 1) 'グループ圧力Mv
        ReDim _groupFlg(InitParameter.NumberGroup - 1) 'グループ圧力Flg
        ReDim _jackSelect(InitParameter.NumberJack - 1) 'ジャッキ選択
        ReDim _JackStatus(InitParameter.NumberJack - 1)

        Dim iRet As Long = PLC_Open() 'オープン処理
        If iRet <> 0 Then
            MsgBox("シーケンサと通信出来ません！" & vbCrLf & "論理局番：" & com_ReferencesEasyIF.ActLogicalStationNumber.ToString, MsgBoxStyle.Exclamation)
            End
        End If
        TimerRun()

    End Sub


    Public Sub TimerRun()


        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf PLC_Read)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ

    End Sub
 
    Public Sub PLC_Read(sender As Object, e As EventArgs)
        Console.WriteLine(DateTime.Now)

        'Call PLC_Open() 'オープン処理

        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Dim szDeviceName As String = ""         'デバイス名称
        Dim iNumberOfDeviceName As Integer = 0  'デバイス・サイズ


        Try
            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(AnalogTag.DeviceSize)
            'ReadDeviceBlock2関数処理の実行 アナログの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(AnalogTag.StartAddress, _
                                                        AnalogTag.DeviceSize, _
                                                        sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信OK
                _gyro = GetAnalogData("ジャイロ方位", AnalogTag)
                _gyroPitching = GetAnalogData("ジャイロピッチング", AnalogTag)
                _gyroRolling = GetAnalogData("ジャイロローリング", AnalogTag)

                _machinePitching = GetAnalogData("マシンピッチング", AnalogTag)
                _mashineRolling = GetAnalogData("マシンローリング", AnalogTag)

                _jkPress = GetAnalogData("ジャッキ圧力", AnalogTag)
                _nakaoreLR = GetAnalogData("中折左右角", AnalogTag)
                _nakaoreTB = GetAnalogData("中折上下角", AnalogTag)
                _leftStroke = GetAnalogData("左ストローク", AnalogTag)
                _rightStroke = GetAnalogData("右ストローク", AnalogTag)
                _topStroke = GetAnalogData("上ストローク", AnalogTag)
                _botomStroke = GetAnalogData("下ストローク", AnalogTag)
                _leftSpeed = GetAnalogData("左ジャッキ速度", AnalogTag)
                _rightSpeed = GetAnalogData("右ジャッキ速度", AnalogTag)
                _topSpeed = GetAnalogData("上ジャッキ速度", AnalogTag)
                _botomSpeed = GetAnalogData("下ジャッキ速度", AnalogTag)
                _realStroke = GetAnalogData("掘進ストローク", AnalogTag)
                _excaStatus = GetAnalogData("掘進ステータス", AnalogTag)
                'mint掘進中最大ストローク = GetAnalogData("掘進中最大ストローク", AnalogTag)


                Dim i As Integer
                For i = 0 To InitParameter.NumberGroup - 1
                    _groupPv(i) = GetAnalogData("グループ" & (i + 1) & "圧力", AnalogTag)
                    _groupMv(i) = GetAnalogData("グループ" & (i + 1) & "圧力MV", AnalogTag)
                    _groupSv(i) = GetAnalogData("グループ" & (i + 1) & "圧力SV", AnalogTag)
                    _groupFlg(i) = GetAnalogData("グループ" & (i + 1) & "制御フラグ", AnalogTag)
                Next
                frmMain.tmrDataDsp.Enabled = True
            Else    'エラー発生
                RaiseEvent PLCErrOccur(sender, e, "")
            End If



            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(ParameterTag.DeviceSize)
            'ReadDeviceBlock2関数処理の実行 パラメータの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(ParameterTag.StartAddress, _
                                                        ParameterTag.DeviceSize, _
                                                        sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信OK


                _リング番号 = GetAnalogData("リング番号", ParameterTag)

                _ストローク管理法 = GetAnalogData("ストローク管理法", ParameterTag)   'ストローク管理方法
                _掘進判定ストローク = GetAnalogData("掘進判定ストローク", ParameterTag)
                _終了判定ストローク = GetAnalogData("終了判定ストローク", ParameterTag)
                _終了判定引きストローク = GetAnalogData("終了判定引きストローク", ParameterTag)
                _終了判定時間 = GetAnalogData("終了判定時間", ParameterTag)

                _減圧弁制御P定数 = GetAnalogData("減圧弁制御Ｐ定数", ParameterTag)
                _減圧弁制御I定数 = GetAnalogData("減圧弁制御Ｉ定数", ParameterTag)
                _減圧弁制御D定数 = GetAnalogData("減圧弁制御Ｄ定数", ParameterTag)
                _中断判定速度 = GetAnalogData("中断判定速度", ParameterTag)

                ''偏差過大の時の設定値　
                _感度調整減圧弁制御Ｐ定数 = GetAnalogData("感度調整減圧弁制御Ｐ定数", ParameterTag)
                _感度調整減圧弁制御Ｉ定数 = GetAnalogData("感度調整減圧弁制御Ｉ定数", ParameterTag)
                '_GaingSetReducingValveContDConst = GetAnalogData("", ParameterTag)
                _感度調整設定圧力偏差 = GetAnalogData("感度調整設定圧力偏差", ParameterTag)


            Else    'エラー発生
                RaiseEvent PLCErrOccur(sender, e, "")
            End If



            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(DigtalTag.DeviceSize \ 16 + 1)
            'デジタルの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(DigtalTag.StartAddress, _
                                                        DigtalTag.DeviceSize \ 16 + 1, _
                                                    sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信成功
                Dim bit() As Boolean = WordToBit(sharrDeviceValue)

                'ジャッキ選択の取込
                For i = 0 To _jackSelect.Length - 1
                    _jackSelect(i) = bit(DigtalTag.TagData("ジャッキ選択" & (i + 1)).OffsetAddress)
                Next

                'TODO:待機中、同時施工時の表示も追加
                'ジャッキステータス表示
                For i = 0 To _jackSelect.Length - 1
                    If _jackSelect(i) Then
                        _JackStatus(i) = 1
                    Else
                        _JackStatus(i) = 0
                    End If
                Next




                'FLEXON（圧力制御中)
                _flexControlOn = bit(DigtalTag.TagData("圧力制御").OffsetAddress)
                _gyiroError = bit(DigtalTag.TagData("ジャイロ異常").OffsetAddress)
            Else    'エラー発生
                RaiseEvent PLCErrOccur(sender, e, "")
            End If
        Catch exException As Exception
            '例外処理	
            MessageBox.Show(exException.Message, "PLC_READ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        RaiseEvent PLCRead(Me, New EventArgs)

        ' ……
    End Sub

    Private Function GetAnalogData(ByVal FieldName As String, Tag As clsTag) As Single
        'アナログデータのスケール変換
        With Tag.TagData(FieldName)
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
            Return (tData - .ScaleLow) * (.EngHight - .EngLow) / (.ScaleHigh - .ScaleLow) + .EngLow  ' + .EngLow


        End With
    End Function


    Private Function WordToBit(sData() As Short) As Boolean()
        'ワードデータの配列をビットデータの配列に変換
        Dim Bit(sData.Length * 16) As Boolean
        Dim i, j As Integer
        For i = 0 To sData.Length - 1
            For j = 0 To 15
                Bit(i * 16 + j) = sData(i) And 2 ^ j
            Next
        Next
        Return Bit





    End Function


    Private Sub ParameterWrite(value As Double)
        '読み出し元の書込項目名を取得
        Dim TagName As String = New StackFrame(1).GetMethod.Name.Substring(4)
        With ParameterTag.TagData(TagName)
            'アナログデータをPLC書込データに変換
            Dim wD As Integer = (value - .EngLow) / (.EngHight - .EngLow) * (.ScaleHigh - .ScaleLow) + .ScaleLow
            'PLC書込
            Call PLC_Write(.Address, wD)
        End With




    End Sub










    ''' <summary>
    ''' PLCに書込
    ''' パラメータ　Rレジスタ
    ''' </summary>
    ''' <param name="PlcAdress">アドレス</param>
    ''' <param name="Value">書き込むデータ</param>
    ''' <remarks></remarks>
    Private Sub PLC_Write(PlcAdress As String, Value As Integer)
        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Try
            iReturnCode = com_ReferencesEasyIF.SetDevice(PlcAdress, Value)
        Catch exException As Exception
            '例外処理	
            MessageBox.Show(exException.Message, "PLC_Write", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub



#Region " Open処理 "

    Private Function PLC_Open() As Long

        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値

        'Open関数処理
        '
        Try
            'Open関数処理の実行
            iReturnCode = com_ReferencesEasyIF.Open()

            If iReturnCode <> 0 Then
                RaiseEvent PLCErrOccur(Me, New EventArgs, "PLC_OpenError! " & String.Format("0x{0:x8} [HEX]", iReturnCode))
            End If


            '例外処理
        Catch exception As Exception
            MessageBox.Show(exception.Message, "PLC_OPEN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
            Exit Function
        End Try

        'Actコントロールのメソッドの戻り値の表示(8桁の16進数)
        '        txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode)
        Return iReturnCode
    End Function

#End Region

End Class



