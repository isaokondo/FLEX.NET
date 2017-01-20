
Public Class clsPlcIf

    Private mblnComOk As Boolean            ''通信フラグ

    Private mblnBlink As Boolean 'ブリンク


    Private _EngValue As Dictionary(Of String, Double) 'アナログの工業値


    Private _groupPv() As Single 'グループ圧力データ
    Private _groupSv() As Single
    Private _groupMv() As Single
    Private _groupFlg() As Short

    Private _gyro As Single                 'ジャイロ方位角
    Private _gyroPitching As Single         'ジャイロピッチング
    Private _gyroRolling As Single              'ジャイロローリング
    Private _machinePitching As Single         ''マシンピッチング
    Private _mashineRolling As Single          ''マシンローリング
    Private _nakaoreLR As Single           '中折左右角
    Private _nakaoreTB As Single           '中折上下角
    Private _jkPress As Single           'シールド元圧
    Private _rightClearance As Integer         '右ｸﾘｱﾗﾝｽ
    Private _leftClearance As Integer          '左ｸﾘｱﾗﾝｽ
    Private _topClearance As Integer          '上ｸﾘｱﾗﾝｽ
    Private _botomClearance As Integer         '下ｸﾘｱﾗﾝｽ
    Private _realStroke As Integer       ''掘進実ストローク
    Private _beforeStroke As Integer       ''前スキャンの掘進実ストローク
    Private _jackSelect() As Boolean         ''稼働ジャッキ

    Private _JackStatus() As Short      ''ジャッキのステータス

    Private _flexControlOn As Boolean         ''FLEX制御ON
    '    Private _autoDirectionContorolFLG As Boolean ''自動方向制御フラグ
    Private _contorolModeFLG As Boolean ''制御モードフラグ
    Private _excaStatus As Integer     ''掘進ステータス
    '計測ジャッキ番号、値　Dictionary
    Private _mesureJackStroke As Dictionary(Of Short, Integer) '計測ジャッキストローク
    Private _mesureJackSpeed As Dictionary(Of Short, Integer) '計測ジャッキスピード

    ''' <summary>
    ''' 掘進ストローク
    ''' </summary>
    Private _MaxExcavingStroke As Integer

    Private _gyiroError As Boolean ''ジャイロエラー

    'Private _mint元圧フィルタ係数 As Integer

    Private _FilterJkPress As Single     ''フィルター後のシールド圧

    Private _mintIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）

    Private _CopyAngle As Integer   'コピー角度
    Private _CopyStroke1 As Integer 'コピーストローク1
    Private _CopyStroke2 As Integer 'コピーストローク1


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

    '減圧弁の特性値取得テスト用
    Private _減圧弁特性増減時間 As Integer

    ''偏差過大の時の設定値　
    Private _感度調整減圧弁制御Ｐ定数 As Integer
    Private _感度調整減圧弁制御Ｉ定数 As Integer
    Private _GaingSetReducingValveContDConst As Integer
    Private _感度調整設定圧力偏差 As Single

    'グループ数、ジャッキ本数
    Private _numberGroup As Short
    Private _numberJack As Short

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
    ''' 計測ジャッキが変化
    ''' </summary>
    Public Event MesureStrokeChange()

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


    Public AnalogTag As clsTag
    Public ParameterTag As clsTag
    Private DigtalTag As clsTag

    Private sharrDeviceValue() As Short         'デバイス値
    ''' <summary>
    ''' TAGの読込
    ''' </summary>
    Public Sub TagRead()
        AnalogTag = New clsTag("FLEXアナログtag", "D")
        ParameterTag = New clsTag("FLEXアナログtag", "R")
        DigtalTag = New clsTag("FLEXデジタルtag", "M")
    End Sub
    ''' <summary>
    ''' アナログ入力（工業値)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property EngValue As Dictionary(Of String, Double)
        Get
            Return _EngValue
        End Get
    End Property




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

    Public ReadOnly Property MashineRolling As Single
        Get
            Return _mashineRolling
        End Get
    End Property

    Public ReadOnly Property MachinePitching As Single
        Get
            Return _machinePitching
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
            Return _mesureJackStroke(InitPara.mesureJackNo(1))
            'Return _rightStroke
        End Get
    End Property
    Public ReadOnly Property LeftStroke As Single
        Get
            Return _mesureJackStroke(InitPara.mesureJackNo(3))
            'Return _leftStroke
        End Get
    End Property
    Public ReadOnly Property TopStroke As Single
        Get
            Return _mesureJackStroke(InitPara.mesureJackNo(0))
            'Return _topStroke
        End Get
    End Property
    Public ReadOnly Property BotomStroke As Single
        Get
            Return _mesureJackStroke(InitPara.mesureJackNo(2))
            'Return _botomStroke
        End Get
    End Property
    Public ReadOnly Property RightSpeed As Single
        Get
            Return _mesureJackSpeed(InitPara.mesureJackNo(1))
            'Return _rightSpeed
        End Get
    End Property
    Public ReadOnly Property LeftSpeed As Single
        Get
            Return _mesureJackSpeed(InitPara.mesureJackNo(3))
            'Return _leftSpeed
        End Get
    End Property
    Public ReadOnly Property TopSpeed As Single
        Get
            Return _mesureJackSpeed(InitPara.mesureJackNo(0))
            'Return _topSpeed
        End Get
    End Property
    Public ReadOnly Property BotomSpeed As Single
        Get
            Return _mesureJackSpeed(InitPara.mesureJackNo(2))
            'Return _botomSpeed
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

    Public ReadOnly Property CopyStroke1 As Integer
        Get
            Return _CopyStroke1
        End Get
    End Property
    Public ReadOnly Property CopyStroke2 As Integer
        Get
            Return _CopyStroke2
        End Get
    End Property




    Public ReadOnly Property JackStatus() As Short()
        Get
            Return _JackStatus

        End Get
    End Property
    ''' <summary>
    ''' 各ジャッキの掘進モード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property JackExecMode As Boolean()
        Get
            Dim JkEx As Boolean() = _JackStatus.Select(Of Boolean)(Function(i) i And 2).ToArray
            Return JkEx
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


    Public ReadOnly Property rightClearance As Integer
        Get
            Return _rightClearance
        End Get
    End Property
    Public ReadOnly Property leftClearance As Integer
        Get
            Return _leftClearance
        End Get
    End Property
    Public ReadOnly Property topClearance As Integer
        Get
            Return _topClearance
        End Get
    End Property
    Public ReadOnly Property botomClearance As Integer
        Get
            Return _botomClearance
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

    Public Property 減圧弁特性増減時間 As Integer
        Get
            Return _減圧弁特性増減時間
        End Get
        Set(value As Integer)
            _減圧弁特性増減時間 = value
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
    ''' 計測ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureJackStroke As Dictionary(Of Short, Integer)
        Get
            Return _mesureJackStroke
        End Get
    End Property
    ''' <summary>
    ''' 計測ジャッキスピード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureJackSpeed As Dictionary(Of Short, Integer)
        Get
            Return _mesureJackSpeed
        End Get
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

        TagRead() 'tagの読込
        '* ACTコントロール用インスタンスの生成*************************************/
        com_ReferencesEasyIF = New ACTMULTILib.ActEasyIF
        com_ReferencesEasyIF.ActLogicalStationNumber = InitPara.ActLogicalStationNumber   'PLC論理局

        ReDim _groupPv(InitPara.NumberGroup - 1) 'グループ圧力Pv
        ReDim _groupSv(InitPara.NumberGroup - 1) 'グループ圧力Sv
        ReDim _groupMv(InitPara.NumberGroup - 1) 'グループ圧力Mv
        ReDim _groupFlg(InitPara.NumberGroup - 1) 'グループ圧力Flg
        ReDim _jackSelect(InitPara.NumberJack - 1) 'ジャッキ選択
        ReDim _JackStatus(InitPara.NumberJack - 1)
        '計測ジャッキのDictionary 初期化
        _mesureJackStroke = New Dictionary(Of Short, Integer)
        _mesureJackSpeed = New Dictionary(Of Short, Integer)
        For Each i As KeyValuePair(Of Short, Single) In InitPara.MesureJackAngle
            _mesureJackStroke.Add(i.Key, 0)
            _mesureJackSpeed.Add(i.Key, 0)
        Next
        _EngValue = New Dictionary(Of String, Double)
        '工業値のDictionary 初期化
        For Each an In AnalogTag.Tag
            _EngValue.Add(an.FieldName, 0)
        Next

        Dim iRet As Long = PLC_Open() 'オープン処理
        If iRet <> 0 Then
            MsgBox("シーケンサと通信出来ません！" & vbCrLf & "論理局番：" & com_ReferencesEasyIF.ActLogicalStationNumber.ToString, MsgBoxStyle.Exclamation)
            End
        End If

        '初期状態読込 イベントを発生させないため
        _LosZeroSts_FLEX = AnalogPlcRead("同時施工ステータス_FLEX")
        _LosZeroSts_M = AnalogPlcRead("同時施工ステータス_Machine")
        _excaStatus = AnalogPlcRead("掘進ステータス")
        _AssemblyPieceNo = AnalogPlcRead("組立ピース")

        PreExcaStatus = _excaStatus
        _LosZeroMode = DigtalPlcRead("同時施工モード")
        '計測ジャッキ読込
        'For Each mj In InitParameter.MesureJackAngle.Keys
        '    _mesureJackStroke(mj) = AnalogPlcRead("ジャッキストローク" & mj)
        'Next

        TimerRun()

    End Sub


    Public Sub TimerRun()

        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf PLC_Read)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ
        '計算ジャッキストロークの演算
        'RaiseEvent MesureStrokeChange()
    End Sub

    Public Sub PLC_Read(sender As Object, e As EventArgs)
        'Console.WriteLine(DateTime.Now)

        'Call PLC_Open() 'オープン処理

        'Debug.Write(System.DateTime.Now.ToString("HH:mm:ss.fff  "))

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
                For Each at In AnalogTag.Tag
                    _EngValue(at.FieldName) = GetAnalogData(at.FieldName, AnalogTag)
                Next


                _gyro = _EngValue("ジャイロ方位")
                _gyroPitching = _EngValue("ジャイロピッチング")
                _gyroRolling = _EngValue("ジャイロローリング")

                _machinePitching = _EngValue("マシンピッチング")
                _mashineRolling = _EngValue("マシンローリング")

                _jkPress = _EngValue("ジャッキ圧力")

                _FilterJkPress = _jkPress + CtlParameter.元圧フィルタ係数 / 100 * (_FilterJkPress - _jkPress)

                _nakaoreLR = _EngValue("中折左右角")
                _nakaoreTB = _EngValue("中折上下角")
                _realStroke = _EngValue("掘進ストローク")
                _excaStatus = _EngValue("掘進ステータス")
                _CopyAngle = _EngValue("コピー角度")
                _CopyStroke1 = _EngValue("コピーストローク1")
                _CopyStroke2 = _EngValue("コピーストローク2")

                _leftClearance = _EngValue("クリアランス左")
                _topClearance = _EngValue("クリアランス上")
                _rightClearance = _EngValue("クリアランス右")
                _botomClearance = _EngValue("クリアランス下")

                '計測ジャッキ取込
                Dim st As New Dictionary(Of Short, Integer)(_mesureJackStroke)
                'st = New Dictionary(Of Short, Integer)(_mesureJackStroke) '前スキャンの読込
                For Each mj In InitPara.MesureJackAngle.Keys
                    _mesureJackStroke(mj) = _EngValue("ジャッキストローク" & mj)
                    _mesureJackSpeed(mj) = _EngValue("ジャッキスピード" & mj)
                Next
                '計測ストロークのいずれかが変化した時のイベント
                For Each mj In InitPara.MesureJackAngle.Keys
                    If _mesureJackStroke(mj) <> st(mj) Then
                        RaiseEvent MesureStrokeChange()
                        Exit For
                    End If
                Next

                '同時施工ステータス読込
                Dim p As Short
                p = _LosZeroSts_FLEX
                _LosZeroSts_FLEX = _EngValue("同時施工ステータス_FLEX")
                '同時施工モードでステータス変化時
                If _LosZeroMode And p <> _LosZeroSts_FLEX Then
                    RaiseEvent LosZeroStsChange(p, _LosZeroSts_FLEX, False)
                End If

                p = _LosZeroSts_M
                _LosZeroSts_M = _EngValue("同時施工ステータス_Machine")
                '同時施工モードでステータス変化時
                If _LosZeroMode And p <> _LosZeroSts_M Then
                    RaiseEvent LosZeroStsChange(p, _LosZeroSts_M, True)
                End If

                Dim i As Integer
                For i = 0 To InitPara.NumberGroup - 1
                    _groupPv(i) = _EngValue("グループ" & (i + 1) & "圧力")
                    _groupMv(i) = _EngValue("グループ" & (i + 1) & "圧力MV")
                    _groupSv(i) = _EngValue("グループ" & (i + 1) & "圧力SV")
                    _groupFlg(i) = _EngValue("グループ" & (i + 1) & "制御フラグ")
                Next

                For i = 0 To InitPara.NumberJack - 1
                    _JackStatus(i) = _EngValue("ジャッキステータス" & (i + 1))
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
                    RaiseEvent LineDistanceChage()

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
                _減圧弁特性増減時間 = GetAnalogData("減圧弁特性増減時間", ParameterTag)


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
        '掘削データ保存　ストロークが掘進中に伸びたとき
        If (_realStroke > PreRealStroke Or _excaStatus <> PreExcaStatus) And _excaStatus = cKussin Then
            DataSave.Save()
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

        'Debug.WriteLine(System.DateTime.Now.ToString("HH:mm:ss.fff"))


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
        Dim Bit(InitPara.NumberJack - 1) As Boolean
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
            PLC_Write(.Address, wD)
        End With
    End Sub

    ''' <summary>
    ''' パラメータをPLCに書込
    ''' </summary>
    ''' <param name="TagName"></param>
    ''' <param name="Value"></param>
    Public Sub ParameterWrite(TagName As String, ByVal Value As Short)
        Dim PlcAdress As String = ParameterTag.TagData(TagName).Address
        PLC_Write(PlcAdress, Value)
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
    Public Sub AnalogPlcWrite(TagName As String, ByVal Value As Single)
        With AnalogTag.TagData(TagName)
            Dim PlcAdress As String = .Address
            'アナログデータをPLC書込データに変換
            Dim wD As Integer =
                (Value - .EngLow) / (.EngHight - .EngLow) * (.ScaleHigh - .ScaleLow) + .ScaleLow
            'PLC書込
            PLC_Write(PlcAdress, wD)
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
            Return 0
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

        Dim intPressWrData(InitPara.NumberGroup - 1) As Short
        Dim intPressWrFlg(InitPara.NumberGroup - 1) As Short
        For i As Short = 0 To InitPara.NumberGroup - 1
            If CtlParameter.最大全開出力時の目標圧力 <> 0 Then
                '' PLCに0-4000でSVを出力

                intPressWrData(i) = Int(sngPres(i) / CtlParameter.最大全開出力時の目標圧力 * 4000)

            End If

        Next i

        Dim iReturnCode As Long = com_ReferencesEasyIF.WriteDeviceBlock2(AnalogTag.TagData("グループ1圧力SV").Address,
                                                        InitPara.NumberGroup,
                                                        intPressWrData(0))
        iReturnCode = com_ReferencesEasyIF.WriteDeviceBlock2(AnalogTag.TagData("グループ1制御フラグ").Address,
                                                        InitPara.NumberGroup,
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



