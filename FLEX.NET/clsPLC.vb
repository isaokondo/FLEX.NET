
Public Class clsPlcIf

    Private mblnComOk As Boolean            ''通信フラグ

    Private mblnBlink As Boolean 'ブリンク

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
    ''' <summary>
    ''' 掘進ストローク
    ''' </summary>
    Private _MaxExcavingStroke As Integer

    Private _gyiroError As Boolean ''ジャイロエラー

    'Private _mint元圧フィルタ係数 As Integer

    Private _FilterJkPress As Single     ''フィルター後のシールド圧

    Private _mintIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）

    Private _CopyAngle As Integer   'コピー角度
    Private _CopyStroke As Integer 'コピーストローク


    'パラメータ　Rレジスタ
    Private _RingNo As Integer           ''リング番号

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


    ' ''前回の値を保持するレジスタ(イベントを起こすため）
    Private _PreGpPv() As Single            ''グループ圧PV
    Private _PreGpSv() As Single            ''グループ圧SV
    Private _PreGpMv() As Single            ''グループ圧MV
    Private _PreGpFlg() As Integer          ''グループ圧制御フラグ
    Private _PreRingNo As Integer           ''リング番号
    Private _PreJyairo As Single           ''ジャイロ方位角
    Private _PrePitching As Single         ''ピッチング
    Private PreRealStroke As Integer       ''掘進実ストローク
    Private PreExcaStatus As Integer = -1     ''掘進ステータス
    Private _mintPreIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）
    Private _mblnPreContModeFlag As Boolean ''制御モードフラグ
    Private _mvarPressWrData() As Object    ''圧力シーケンサ書き込み用

    Private LosZeroCancel As Boolean ''同時施工キャンセル

    'ロスゼロデータ
    ''' <summary>
    ''' 組立ピース番号
    ''' </summary>
    Private _AssemblyPieceNo As Short = 1
    ''' <summary>
    ''' 同時施工可
    ''' </summary>
    Private _LosZeroEnable As Boolean

    ''' <summary>
    ''' 同時施工ステータス　from FLEX
    ''' </summary>
    Private _LosZeroSts_FLEX As Short








    Private WithEvents com_ReferencesEasyIF As ACTMULTILib.ActEasyIF

    Public Event PLCRead() 'PLC読込イベント
    Public Event PLCErrOccur(ByVal sender As Object, ByVale As EventArgs, ByVal ErrMsg As String, ByVal ErrCode As Long) 'PLC読込イベント
    ''' <summary>
    ''' 掘進ステータスの変化時
    ''' </summary>
    ''' <param name="PreStatus">変化前の値</param>
    ''' <param name="NowStatus">変化後の値</param>
    Public Event ExcavationStatusChange(PreStatus As Integer, NowStatus As Integer)

    ''' <summary>
    ''' 基準値が変化　掘進ステータス、掘進ストローク
    ''' </summary>
    Public Event LineDistanceChage()

    ''' <summary>
    ''' 同時施工ステータス変化
    ''' </summary>
    ''' <param name="PreSts">変化前のステータス</param>
    ''' <param name="NowSts">変化後のステータス</param>
    ''' <param name="FromDev">True:マシン　False：FLEX</param>
    Public Event LosZeroStsChange(PreSts As Short, NowSts As Short, FromDev As Boolean)
    ''' <summary>
    ''' 同時施工キャンセル
    ''' </summary>
    Public Event LosZeroCancelOn()
    ''' <summary>
    ''' 同時施工モード変換
    ''' </summary>
    Public Event LosZeroModeChange()


    Private AnalogTag As New clsTag("FLEXアナログtag", "D")
    Public ParameterTag As New clsTag("FLEXアナログtag", "R")
    Private DigtalTag As New clsTag("FLEXデジタルtag", "M")
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
    ''' <summary>
    ''' ''シールド元圧
    ''' </summary>
    ''' <returns></returns>
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

    Public ReadOnly Property CopyAngle As Integer
        Get
            Return _CopyAngle
        End Get
    End Property

    Public ReadOnly Property CopyStroke As Integer
        Get
            Return _CopyStroke
        End Get
    End Property

    Public ReadOnly Property JackStatus() As Short()
        Get
            Return _JackStatus

        End Get
    End Property
    ''' <summary>
    ''' FLEX姿勢制御自動
    ''' </summary>
    ''' <returns></returns>
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
    ''' <summary>
    ''' 掘進ストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MaxExcavingStroke As Short
        Get
            Return _MaxExcavingStroke
        End Get
    End Property
    ''' <summary>
    ''' フィルタ後のジャッキ元圧
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property FilterJkPress As Single
        Get
            Return _FilterJkPress
        End Get
    End Property



    Public Property RingNo As Integer
        Get
            Return _RingNo
        End Get
        Set(value As Integer)
            '_RingNo = value
            Call ParameterWrite(value)
        End Set
    End Property

    Public Property ストローク管理法 As Integer
        Get
            Return _ストローク管理法
        End Get
        Set(value As Integer)
            _ストローク管理法 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 掘進判定ストローク As Integer
        Get
            Return _掘進判定ストローク
        End Get
        Set(value As Integer)
            _掘進判定ストローク = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 終了判定ストローク As Integer
        Get
            Return _終了判定ストローク
        End Get
        Set(value As Integer)
            _終了判定ストローク = value
            Call ParameterWrite(value)

        End Set
    End Property
    Public Property 終了判定引きストローク As Integer
        Get
            Return _終了判定引きストローク
        End Get
        Set(value As Integer)
            _終了判定引きストローク = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 中断判定速度 As Integer
        Get
            Return _中断判定速度
        End Get
        Set(value As Integer)
            _中断判定速度 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 終了判定時間 As Integer
        Get
            Return _終了判定時間
        End Get
        Set(value As Integer)
            _終了判定時間 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 減圧弁制御P定数 As Integer
        Get
            Return _減圧弁制御P定数
        End Get
        Set(value As Integer)
            _減圧弁制御P定数 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 減圧弁制御I定数 As Integer
        Get
            Return _減圧弁制御I定数
        End Get
        Set(value As Integer)
            _減圧弁制御I定数 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 減圧弁制御D定数 As Integer
        Get
            Return _減圧弁制御D定数
        End Get
        Set(value As Integer)
            _減圧弁制御D定数 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 感度調整減圧弁制御Ｐ定数 As Integer
        Get
            Return _感度調整減圧弁制御Ｐ定数
        End Get
        Set(value As Integer)
            _感度調整減圧弁制御Ｐ定数 = value
            Call ParameterWrite(value)

        End Set
    End Property

    Public Property 感度調整減圧弁制御Ｉ定数 As Integer
        Get
            Return _感度調整減圧弁制御Ｉ定数
        End Get
        Set(value As Integer)
            _感度調整減圧弁制御Ｉ定数 = value
            Call ParameterWrite(value)

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

    ''' <summary>
    ''' 組立ピース番号
    ''' </summary>
    ''' <returns></returns>
    Public Property AssemblyPieceNo As Short
        Get
            Return _AssemblyPieceNo
        End Get
        Set(value As Short)
            _AssemblyPieceNo = value
            AnalogPlcWrite("組立ピース", _AssemblyPieceNo)
        End Set
    End Property

    ''' <summary>
    ''' 同時施工モード　マシンからの信号
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LosZeroMode() As Boolean
    ''' <summary>
    ''' 同時施工可　FLEXより
    '''     ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroEnable() As Boolean
        Get
            Return _LosZeroEnable
        End Get
        Set(value As Boolean)
            _LosZeroEnable = value
            DigtalPlcWrite("同時施工可", value)
        End Set
    End Property
    ''' <summary>
    ''' 同時施工ステータス　from マシン
    ''' </summary>
    Public ReadOnly Property LosZeroSts_M As Short
    ''' <summary>
    ''' 同時施工ステータス　from FLEX
    ''' 1:減圧中 2:減圧完了 3:組立完了確認
    ''' 4:押し付け完了確認
    ''' </summary>
    Public Property LosZeroSts_FLEX As Short
        Get
            Return _LosZeroSts_FLEX
        End Get
        Set(value As Short)
            '_LosZeroSts_FLEX = value
            AnalogPlcWrite("同時施工ステータス_FLEX", value)
        End Set
    End Property

    Public ReadOnly Property MachineComErr As Boolean


    Public Sub New()
        '* ACTコントロール用インスタンスの生成*************************************/
        com_ReferencesEasyIF = New ACTMULTILib.ActEasyIF
        com_ReferencesEasyIF.ActLogicalStationNumber = InitParameter.ActLogicalStationNumber   'PLC論理局

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

        '初期状態読込
        _LosZeroSts_FLEX = AnalogPlcRead("同時施工ステータス_FLEX")
        _LosZeroSts_M = AnalogPlcRead("同時施工ステータス_Machine")
        _excaStatus = AnalogPlcRead("掘進ステータス")
        PreExcaStatus = _excaStatus
        _LosZeroMode = DigtalPlcRead("同時施工モード")

        TimerRun()

    End Sub


    Public Sub TimerRun()


        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf PLC_Read)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ

    End Sub

    Public Sub PLC_Read(sender As Object, e As EventArgs)
        'Console.WriteLine(DateTime.Now)

        'Call PLC_Open() 'オープン処理

        Debug.Write(System.DateTime.Now.ToString("HH:mm:ss.fff  "))

        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Dim szDeviceName As String = ""         'デバイス名称
        Dim iNumberOfDeviceName As Integer = 0  'デバイス・サイズ


        Try
            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(AnalogTag.DeviceSize)
            'ReadDeviceBlock2関数処理の実行 アナログの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(AnalogTag.StartAddress,
                                                        AnalogTag.DeviceSize + 1,
                                                        sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信OK
                _gyro = GetAnalogData("ジャイロ方位", AnalogTag)
                _gyroPitching = GetAnalogData("ジャイロピッチング", AnalogTag)
                _gyroRolling = GetAnalogData("ジャイロローリング", AnalogTag)

                _machinePitching = GetAnalogData("マシンピッチング", AnalogTag)
                _mashineRolling = GetAnalogData("マシンローリング", AnalogTag)

                _jkPress = GetAnalogData("ジャッキ圧力", AnalogTag)

                _FilterJkPress = _jkPress + ControlParameter.元圧フィルタ係数 / 100 * (_FilterJkPress - _jkPress)

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
                _CopyAngle = GetAnalogData("コピー角度", AnalogTag)
                _CopyStroke = GetAnalogData("コピーストローク", AnalogTag)

                '同時施工ステータス読込
                Dim p As Short
                p = _LosZeroSts_FLEX
                _LosZeroSts_FLEX = GetAnalogData("同時施工ステータス_FLEX", AnalogTag)
                '同時施工モードでステータス変化時
                If _LosZeroMode And p <> _LosZeroSts_FLEX Then
                    RaiseEvent LosZeroStsChange(p, _LosZeroSts_FLEX, False)
                End If

                p = _LosZeroSts_M
                _LosZeroSts_M = GetAnalogData("同時施工ステータス_Machine", AnalogTag)
                '同時施工モードでステータス変化時
                If _LosZeroMode And p <> _LosZeroSts_M Then
                    RaiseEvent LosZeroStsChange(p, _LosZeroSts_M, True)
                End If





                Dim i As Integer
                For i = 0 To InitParameter.NumberGroup - 1
                    _groupPv(i) = GetAnalogData("グループ" & (i + 1) & "圧力", AnalogTag)
                    _groupMv(i) = GetAnalogData("グループ" & (i + 1) & "圧力MV", AnalogTag)
                    _groupSv(i) = GetAnalogData("グループ" & (i + 1) & "圧力SV", AnalogTag)
                    _groupFlg(i) = GetAnalogData("グループ" & (i + 1) & "制御フラグ", AnalogTag)
                Next

                For i = 0 To InitParameter.NumberJack - 1
                    _JackStatus(i) = GetAnalogData("ジャッキステータス" & (i + 1), AnalogTag)
                    _jackSelect(i) = (_JackStatus(i) And 1)
                Next



                frmMain.tmrDataDsp.Enabled = True
            Else    'エラー発生
                RaiseEvent PLCErrOccur(sender, e, "アナログ読込エラー", iReturnCode)
            End If



            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(ParameterTag.DeviceSize)
            'ReadDeviceBlock2関数処理の実行 パラメータの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(ParameterTag.StartAddress,
                                                        ParameterTag.DeviceSize + 1,
                                                        sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信OK

                Dim rno As Integer = _RingNo
                _RingNo = GetAnalogData("RingNo", ParameterTag)
                If rno <> _RingNo Then
                    RaiseEvent ExcavationStatusChange(0, 0)
                End If

                _ストローク管理法 = GetAnalogData("ストローク管理法", ParameterTag)   'ストローク管理方法
                _掘進判定ストローク = GetAnalogData("掘進判定ストローク", ParameterTag)
                _終了判定ストローク = GetAnalogData("終了判定ストローク", ParameterTag)
                _終了判定引きストローク = GetAnalogData("終了判定引きストローク", ParameterTag)
                _終了判定時間 = GetAnalogData("終了判定時間", ParameterTag)

                _減圧弁制御P定数 = GetAnalogData("減圧弁制御P定数", ParameterTag)
                _減圧弁制御I定数 = GetAnalogData("減圧弁制御I定数", ParameterTag)
                _減圧弁制御D定数 = GetAnalogData("減圧弁制御D定数", ParameterTag)
                _中断判定速度 = GetAnalogData("中断判定速度", ParameterTag)

                ''偏差過大の時の設定値　
                _感度調整減圧弁制御Ｐ定数 = GetAnalogData("感度調整減圧弁制御P定数", ParameterTag)
                _感度調整減圧弁制御Ｉ定数 = GetAnalogData("感度調整減圧弁制御I定数", ParameterTag)
                '_GaingSetReducingValveContDConst = GetAnalogData("", ParameterTag)
                _感度調整設定圧力偏差 = GetAnalogData("感度調整設定圧力偏差", ParameterTag)
                'TODO:同時施工で考慮
                _MaxExcavingStroke = GetAnalogData("掘進中最大ストローク", ParameterTag)


            Else    'エラー発生
                RaiseEvent PLCErrOccur(sender, e, "パラメータ読込エラー", iReturnCode)
            End If



            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(DigtalTag.DeviceSize \ 16 + 1)
            'デジタルの読込
            iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(DigtalTag.StartAddress,
                                                        DigtalTag.DeviceSize \ 16 + 1,
                                                    sharrDeviceValue(0))
            If iReturnCode = 0 Then '通信成功
                Dim bit() As Boolean = WordToBit(sharrDeviceValue)

                ''ジャッキ選択の取込
                'For i = 0 To _jackSelect.Length - 1
                '    _jackSelect(i) = bit(DigtalTag.TagData("ジャッキ選択" & (i + 1)).OffsetAddress)
                'Next



                'FLEXON（圧力制御中)
                _flexControlOn = bit(DigtalTag.TagData("圧力制御").OffsetAddress)
                _gyiroError = bit(DigtalTag.TagData("ジャイロ異常").OffsetAddress)

                Dim tmp As Boolean
                '同時施工モード
                tmp = _LosZeroMode
                _LosZeroMode = bit(DigtalTag.TagData("同時施工モード").OffsetAddress)
                If tmp <> _LosZeroMode Then RaiseEvent LosZeroModeChange()
                _LosZeroEnable = bit(DigtalTag.TagData("同時施工可").OffsetAddress)
                tmp = _MachineComErr
                _MachineComErr = bit(DigtalTag.TagData("マシン伝送異常").OffsetAddress)
                If tmp = False And _MachineComErr Then RaiseEvent PLCErrOccur(sender, e, "シールドマシン伝送異常が発生しました。", 0)

                tmp = LosZeroCancel
                LosZeroCancel = bit(DigtalTag.TagData("同時施工キャンセル").OffsetAddress)
                If tmp = False And LosZeroCancel Then RaiseEvent LosZeroCancelOn()

            Else    'エラー発生
                    RaiseEvent PLCErrOccur(sender, e, "デジタル読込エラー", iReturnCode)
            End If
        Catch exException As Exception
            '例外処理	
            MessageBox.Show(exException.Message, "PLC_READ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        '掘進スロトーク、ステータスの変化　基準方向の変更
        If _realStroke <> PreRealStroke Or _excaStatus <> PreExcaStatus _
            Or _gyro <> _PreJyairo Or _PrePitching <> _gyroPitching Then
            RaiseEvent LineDistanceChage()
        End If
        '掘進ステータスの変化
        If _excaStatus <> PreExcaStatus Then
            RaiseEvent ExcavationStatusChange(PreExcaStatus, _excaStatus)
        End If




        '掘進ストローク保持
        PreRealStroke = _realStroke
        '掘進ステータスの保持
        PreExcaStatus = _excaStatus

        _PreJyairo = _gyro
        _PrePitching = _gyroPitching

        '伝送フラグの送出
        'デジタルの読込
        Dim t As Long = 0
        mblnBlink = Not mblnBlink
        t = t Or mblnBlink
        iReturnCode = com_ReferencesEasyIF.SetDevice(DigtalTag.TagData("伝送フラグ").Address, t)

        Debug.WriteLine(System.DateTime.Now.ToString("HH:mm:ss.fff"))


        'PLC読込イベント
        RaiseEvent PLCRead()

        ' ……
    End Sub
    ''' <summary>
    ''' 同時施工用の設定データをPLCへ書込
    ''' </summary>
    ''' <param name="TagName">書込種類　引戻しジャッキ等</param>
    ''' <param name="WrData">書込データ</param>
    Public Sub LosZeroDataWrite(ByVal TagName As String, ByVal WrData As List(Of Short))
        Dim PlcAdress As String = DigtalTag.TagData(TagName & "1").Address  'PLC書込アドレス
        Dim Bit(InitParameter.NumberJack - 1) As Boolean
        If Not IsNothing(WrData) Then
            For Each i As Short In WrData
                Bit(i - 1) = True
            Next
        End If
        Dim PlcWrData() As Integer = BitToWord(Bit)
        Dim iReturnCode As Long = com_ReferencesEasyIF.WriteDeviceBlock(PlcAdress, PlcWrData.Length, PlcWrData(0))
        'todo:通信エラー時の処理
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
    ''' <summary>
    ''' ビットデータをPLC書き込み用にワードデータに変換
    ''' </summary>
    ''' <param name="sBit"></param>
    ''' <returns></returns>
    Private Function BitToWord(ByVal sBit() As Boolean) As Integer()
        Dim sData(Math.Ceiling(sBit.Length / 16)) As Integer
        Dim i, j As Short
        For i = 0 To sData.Length - 1
            Dim S As String = vbNullString
            For j = 0 To 15
                If i * 16 + j > sBit.Length - 1 Then Exit For
                S = IIf(sBit(i * 16 + j), "1", "0") & S
            Next
            sData(i) = Convert.ToInt32(S, 2)
        Next
        Return sData
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

    ''' <summary>
    ''' パラメータをPLCに書込
    ''' </summary>
    ''' <param name="value"></param>
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
    ''' デジタル（ビット）データのPLC書込
    ''' </summary>
    ''' <param name="TagName">TAG名</param>
    ''' <param name="Value">書込値</param>
    Public Sub DigtalPlcWrite(TagName As String, ByVal Value As Boolean)
        Dim PlcAdress As String = DigtalTag.TagData(TagName).Address
        PLC_Write(PlcAdress, Value)
    End Sub
    ''' <summary>
    ''' アナログデータ　PLC書込
    ''' </summary>
    ''' <param name="TagName"></param>
    ''' <param name="Value"></param>
    Public Sub AnalogPlcWrite(TagName As String, ByVal Value As Short)
        Dim PlcAdress As String = AnalogTag.TagData(TagName).Address
        PLC_Write(PlcAdress, Value)
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

    ''' <summary>
    ''' デジタル（ビット）データのPLC読込
    ''' </summary>
    ''' <param name="TagName">TAG名</param>
    Public Function DigtalPlcRead(TagName As String) As Boolean
        Dim PlcAdress As String = DigtalTag.TagData(TagName).Address
        Return PLC_Read(PlcAdress)
    End Function
    ''' <summary>
    ''' アナログデータ　PLC読込
    ''' </summary>
    ''' <param name="TagName"></param>
    Public Function AnalogPlcRead(TagName As String) As Integer
        Dim PlcAdress As String = AnalogTag.TagData(TagName).Address
        Return PLC_Read(PlcAdress)
    End Function
    ''' <summary>
    ''' PLCから読込
    ''' </summary>
    ''' <param name="PlcAdress">アドレス</param>
    ''' <remarks></remarks>
    Private Function PLC_Read(PlcAdress As String) As Integer
        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Dim Value As Integer
        Try
            iReturnCode = com_ReferencesEasyIF.GetDevice(PlcAdress, Value)
            Return Value
        Catch exException As Exception
            '例外処理	
            MessageBox.Show(exException.Message, "PLC_Write", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try
    End Function

    Public Sub PutSvPress(ByVal sngPres As Single(), ByRef intPresFLg As Short())
        ' @(f)
        '
        ' 機能      :グループ圧設定値と制御フラグを一度に出力
        '
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :

        Dim intPressWrData(InitParameter.NumberGroup - 1) As Short
        Dim intPressWrFlg(InitParameter.NumberGroup - 1) As Short
        For i As Short = 0 To InitParameter.NumberGroup - 1
            If ControlParameter.最大全開出力時の目標圧力 <> 0 Then
                '' PLCに0-4000でSVを出力

                intPressWrData(i) = Int(sngPres(i) / ControlParameter.最大全開出力時の目標圧力 * 4000)

            End If

        Next i

        Dim iReturnCode As Long = com_ReferencesEasyIF.WriteDeviceBlock2(AnalogTag.TagData("グループ1圧力SV").Address,
                                                        InitParameter.NumberGroup,
                                                        intPressWrData(0))
        iReturnCode = com_ReferencesEasyIF.WriteDeviceBlock2(AnalogTag.TagData("グループ1制御フラグ").Address,
                                                        InitParameter.NumberGroup,
                                                        intPresFLg(0))
        _groupSv = sngPres
        _groupFlg = intPresFLg

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
                RaiseEvent PLCErrOccur(Me, New EventArgs, "PLC_OpenError! " & String.Format("0x{0:x8} [HEX]", iReturnCode), iReturnCode)
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



