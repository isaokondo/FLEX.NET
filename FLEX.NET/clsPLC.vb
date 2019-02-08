Imports System.Convert

Public Class clsPlcIf


    Inherits clsDataBase


    Private mblnComOk As Boolean            ''通信フラグ

    Private mblnBlink As Boolean 'ブリンク


    Private _EngValue As Dictionary(Of String, Single) 'アナログの工業値


    Private _groupPv() As Single 'グループ圧力データ
    Private _groupSv() As Single
    Private _groupMv() As Single
    Private _groupFlg() As Short

    Private _gyro As Single                 'ジャイロ方位角
    Private _gyroPitching As Single         'ジャイロピッチング
    Private _gyroRolling As Single              'ジャイロローリング
    Private _machinePitching As Single         ''マシンピッチング
    Private _mashineRolling As Single          ''マシンローリング
    Private _mashineRearRolling As Single   'マシン後胴ローリング
    Private _rollingChange As Single 'ローリング変化量
    Private _rollingClockWiseOver As Boolean 'ローリング許容値超 時計端
    Private _rollingAntiClockWiseOver As Boolean 'ローリング許容値超 時計端
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
    '0bit:ジャッキ選択
    '1bit:掘進モード／セグメントモード（ただし、鹿島外環は異なる）
    '2bit:減圧中
    '3bit:引き戻し指令
    '4bit:引戻しANS
    '5bit:引き戻し中
    '6bit:押込み指令
    '7bit:押込みANS
    '8bit:押込み中
    '9bit:対抗ジャッキ
    '10bit:押込み推進中



    Private _excavMode As Boolean    'マシン掘進モード
    Private _segmentMode As Boolean 'マシンセグメントモード

    Private _flexControlOn As Boolean         ''FLEX制御ON
    '    Private _autoDirectionContorolFLG As Boolean ''自動方向制御フラグ
    Private _contorolModeFLG As Boolean ''制御モードフラグ
    Private _excaStatus As Integer     ''掘進ステータス
    '計測ジャッキ番号、値　Dictionary
    Private _mesureJackStroke As Dictionary(Of Short, Integer) '計測ジャッキストローク
    Private _mesureJackSpeed As Dictionary(Of Short, Integer) '計測ジャッキスピード
    ''' <summary>
    ''' '異常ストローク番号
    ''' </summary>
    Private FailStrokeNo As Integer
    ''' <summary>
    ''' 目標推進量超えたか
    ''' </summary>
    Private TargetStrokeOver As Boolean
    ''' <summary>
    ''' 掘進ストローク
    ''' </summary>
    Private _MaxExcavingStroke As Integer

    Private _gyiroError As Boolean ''ジャイロエラー

    Private _MesureCalcAveJackStroke As Single

    'Private _mint元圧フィルタ係数 As Integer

    Private _FilterJkPress As Single     ''フィルター後のシールド圧

    Private _mintIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）

    Private _CopyAngle As Integer   'コピー角度
    Private _CopyStroke1 As Integer 'コピーストローク1
    Private _CopyStroke2 As Integer 'コピーストローク1

    ''力点座標
    Private _PointX As Single = 0 ''Ｘ座標
    Private _PointY As Single = 0 ''Ｙ座標

    Private _操作角 As Single
    Private _操作強 As Single



    '速度割合　減圧ジャッキ、引きジャッキ本数に応じて速度の割合を算出
    Private _SpeedRate As Single = 100


    'パラメータ　Rレジスタ
    Private _RingNo As Integer           ''リング番号

    'リング更新は、各ジャッキの平均（選択式）とする
    'Private _ストローク管理法 As Integer    'ストローク管理法0:MAX 1:右 2:左 3:左右平均
    'Private _掘進判定ストローク As Integer
    'Private _終了判定ストローク As Integer
    Private _終了判定引きストローク As Integer
    'Private _中断判定速度 As Single
    'Private _終了判定時間 As Integer

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

    'ダイレクト制御パラメータ
    Private _DirectControlCoefficient As Single '係数
    Private _DirectControlOffset As Integer 'オフセット



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
    Private _PrePitching As Single         ''ジャイロピッチング
    Private _PremachinePitching As Single   'マシンピッチング
    Private PreRealStroke As Integer       ''掘進実ストローク
    Private PreExcaStatus As Integer = -1     ''掘進ステータス
    Private _mintPreIPAdress As Integer         ''操作権のあるＩＰアドレス（下位）
    Private _mblnPreContModeFlag As Boolean ''制御モードフラグ
    Private _mvarPressWrData() As Object    ''圧力シーケンサ書き込み用

    Private LosZeroCancel As Boolean ''同時施工キャンセル

    Private _assembleSegFinish As Boolean   '組立完了

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
    ''' FLEX手動時作用点が変化したイベント
    ''' </summary>
    Public Event PointChange()

    ''' <summary>
    ''' FLEX手動時に掘進中にジャッキ圧力が変化したイベント
    ''' </summary>
    Public Event JkPressFilterChange()

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

    ''' <summary>
    ''' セグメントローリング許容値オーバー
    ''' </summary>
    Public Event RollingOverAlarm()
    ''' <summary>
    ''' Kｾｸﾞﾒﾝﾄ組み立て後
    ''' 目標推進量超えた
    ''' </summary>
    Public Event TargetStrokeOverEv()


    ''' <summary>
    ''' 次ピース組立開始
    ''' 組立完了後のタイマ
    ''' </summary>
    Public Event NextPieceStart()
    ''' <summary>
    ''' 組立完了後の経過時間（秒)
    ''' </summary>
    Private AsmbledPastTime As Integer = 0

    ''' <summary>
    ''' 掘進モード／セグメントモードの切り替え
    ''' </summary>
    ''' <param name="Mode">TRUE:掘進モード　FALSE：セグメントモード</param>
    Public Event ExcavModeChange(Mode As Boolean)

    ''' <summary>
    ''' ジャイロ異常発生
    ''' </summary>
    Public Event GyiroErrOccuerd()


    Public AnalogTag As clsTag
    Public ParameterTag As clsTag
    Private DigtalTag As clsTag

    'DB保存用データ変数
    Private AnalogComData() As Short
    Private ParmterComData() As Short
    Private DigtalComData() As Boolean
    Private DigtalComPlcData() As Short 'デジタルデータのDB書き込み用
    'TODO:アナログ、パラメータ、デジタルの変数を分けたほうがいい！
    Private sharrDeviceValue() As Short         'デバイス値


    Private TimeOutErrCount As Integer = 0


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
    Public ReadOnly Property EngValue As Dictionary(Of String, Single)
        Get
            Return _EngValue
        End Get
    End Property



    Public Property PointX As Single
        Get
            Return _PointX
        End Get
        Set(value As Single)
            If value <> _PointX Then
                _PointX = value
                AnalogPlcWrite("ポイントＸ", _PointX)
            End If
        End Set
    End Property
    Public Property PointY As Single
        Get
            Return _PointY
        End Get
        Set(value As Single)
            If value <> _PointY Then
                _PointY = value
                AnalogPlcWrite("ポイントＹ", _PointY)
            End If
        End Set
    End Property

    Public Property 操作角 As Single
        Get
            Return _操作角
        End Get
        Set(value As Single)
            If value <> _操作角 Then
                _操作角 = value
                AnalogPlcWrite("操作角", _操作角)
            End If
        End Set
    End Property

    Public Property 操作強 As Single
        Get
            Return _操作強
        End Get
        Set(value As Single)
            If value <> _操作強 Then
                _操作強 = value
                AnalogPlcWrite("操作強", _操作強)
            End If
        End Set
    End Property
    ''' <summary>
    ''' 偏角のPLC書込
    ''' </summary>
    ''' <param name="HorDev"></param>
    ''' <param name="VerDev"></param>
    Public Sub LineDatalePlcWrite(HorDev As Single, VerDev As Single, HorCorrention As Single, VerCorrentionValue As Single)
        If _EngValue.ContainsKey("水平偏角") Then
            AnalogPlcWrite("水平偏角", HorDev)

        End If

        If _EngValue.ContainsKey("鉛直偏角") Then
            AnalogPlcWrite("鉛直偏角", VerDev)
        End If

        If _EngValue.ContainsKey("水平入力補正値") Then
            AnalogPlcWrite("水平入力補正値", HorCorrention)

        End If

        If _EngValue.ContainsKey("鉛直入力補正値") Then
            AnalogPlcWrite("鉛直入力補正値", VerCorrentionValue)
        End If



    End Sub

    ''' <summary>
    ''' 組立完了　リング更新条件
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property assembleSegFinish As Boolean
        Get
            Return _assembleSegFinish
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
    ''' ジャイロピッチング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GyroPitching As Single
        Get
            Return _gyroPitching
        End Get
    End Property
    ''' <summary>
    ''' 選択されたピッチング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Pitching As Single
        Get
            If CtlPara.PitchingSel = 0 Then
                Return _gyroPitching
            Else
                Return _machinePitching
            End If
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

    ''' <summary>
    ''' 後胴ローリング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MashineRearRolling As Single
        Get
            Return _mashineRearRolling
        End Get
    End Property

    ''' <summary>
    ''' ローリング変化量
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property rollingChange As Single
        Get
            Return _rollingChange
        End Get
    End Property
    ''' <summary>
    ''' 時計端許容値オーバー
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property rollingClockWiseOver As Boolean
        Get
            Return _rollingClockWiseOver
        End Get
    End Property
    ''' <summary>
    ''' 反時計端許容値オーバー
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property rollingAntiClockWiseOver As Boolean
        Get
            Return _rollingAntiClockWiseOver
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



    ''' <summary>
    ''' ジャッキのステータス
    ''' </summary>
    ''' <returns>
    '''0bit:ジャッキ選択
    '''1bit:掘進モード／セグメントモード（ただし、鹿島外環は異なる）
    '''2bit:減圧中
    '''3bit:引き戻し指令
    '''4bit:引戻しANS
    '''5bit:引き戻し中
    '''6bit:押込み指令
    '''7bit:押込みANS
    '''8bit:押込み中
    '''9bit:対抗ジャッキ
    '''10bit:押込み推進中
    ''' </returns>
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
    ''' <summary>
    ''' 掘進ステータス
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ExcaStatus As Integer
        Get
            Return _excaStatus
        End Get
    End Property
    ''' <summary>
    ''' ジャイロ異常
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GyiroError As Boolean
        Get
            Return _gyiroError
        End Get
    End Property

    ''' <summary>
    ''' 掘進モード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ExcavMode As Boolean
        Get
            Return _excavMode
        End Get
    End Property
    ''' <summary>
    ''' セグメントモード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentMode As Boolean
        Get
            Return _segmentMode
        End Get
    End Property
    ''' <summary>
    ''' 掘進中の最大ストローク（保持用）
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MaxExcavingStroke As Short
        Get
            Return _MaxExcavingStroke
        End Get
    End Property

    Public Property MesureCalcAveJackStroke As Single
        Get
            Return _MesureCalcAveJackStroke
        End Get
        Set(value As Single)
            _MesureCalcAveJackStroke = value

        End Set
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

    Public Property 終了判定引きストローク As Integer
        Get
            Return _終了判定引きストローク
        End Get
        Set(value As Integer)
            _終了判定引きストローク = value
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
    ''' ダイレクト制御係数
    ''' </summary>
    ''' <returns></returns>
    Public Property DirectControlCoefficient As Single
        Get
            Return _DirectControlCoefficient
        End Get
        Set(value As Single)
            _DirectControlCoefficient = value
            Call ParameterWrite(value)

        End Set
    End Property
    ''' <summary>
    ''' ダイレクト制御オフセット
    ''' </summary>
    ''' <returns></returns>
    Public Property DirectControlOffset As Integer
        Get
            Return _DirectControlOffset
        End Get
        Set(value As Integer)
            _DirectControlOffset = value
            Call ParameterWrite(value)

        End Set
    End Property

    ''' <summary>
    ''' 引きジャッキ、押込みジャッキの本数により
    ''' 速度の割合を出力
    ''' </summary>
    ''' <returns></returns>
    Public Property SppedRate As Single
        Get
            Return _SpeedRate
        End Get
        Set(value As Single)
            _SpeedRate = value
            If _SpeedRate > 100 Then _SpeedRate = 100
            If _SpeedRate < 70 Then _SpeedRate = 70
            SpeedRateWrite() '速度PLCに書き込み
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
            If InitPara.LosZeroEquip Then
                AnalogPlcWrite("組立ピース", _AssemblyPieceNo)
            End If
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
            '_LosZeroEnable = value
            If InitPara.LosZeroEquip Then
                DigtalPlcWrite("同時施工可", value)
            End If
        End Set
    End Property
    ''' <summary>
    ''' 同時施工ステータス　from マシン
    ''' 1:減圧開始指令（1ピース目)
    ''' 2:引き戻し開始
    ''' 3:引き戻し完了
    ''' 4:押込み中
    ''' 5:組立完了
    ''' 
    ''' </summary>
    ''' 
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
            If InitPara.LosZeroEquip Then
                AnalogPlcWrite("同時施工ステータス_FLEX", value)
            End If
            '_LosZeroSts_FLEX = value
        End Set
    End Property

    Public ReadOnly Property MachineComErr As Boolean

    ''' <summary>
    ''' モニタモードでデータを取得した時間
    ''' </summary>
    Public ReadOnly Property DataGetTime As DateTime


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
        _EngValue = New Dictionary(Of String, Single)
        '工業値のDictionary 初期化
        For Each an In AnalogTag.Tag
            _EngValue.Add(an.FieldName, 0)
        Next

        CtlPara.TaleClrMeasurRExist = _EngValue.ContainsKey("クリアランス右")
        CtlPara.TaleClrMeasurLExist = _EngValue.ContainsKey("クリアランス左")
        CtlPara.TaleClrMeasurUExist = _EngValue.ContainsKey("クリアランス上")
        CtlPara.TaleClrMeasurBExist = _EngValue.ContainsKey("クリアランス下")

        CtlPara.SpeedRateExist = _EngValue.ContainsKey("速度割合")

        CtlPara.MachineRearRollingExist = _EngValue.ContainsKey("後胴ローリング")


        If Not InitPara.MonitorMode Then
            Dim iRet As Long = PLC_Open() 'オープン処理
            If iRet <> 0 Then
                MsgBox($"シーケンサと通信出来ません！{vbCrLf}論理局番：{com_ReferencesEasyIF.ActLogicalStationNumber.ToString}",
                       MsgBoxStyle.Exclamation)
                End
            End If

            '初期状態読込 イベントを発生させないため
            If InitPara.LosZeroEquip Then
                _LosZeroSts_FLEX = AnalogPlcRead("同時施工ステータス_FLEX")
                _LosZeroSts_M = AnalogPlcRead("同時施工ステータス_Machine")
                _AssemblyPieceNo = AnalogPlcRead("組立ピース")
                _LosZeroMode = DigtalPlcRead("同時施工モード")
            End If

            _excaStatus = AnalogPlcRead("掘進ステータス")
            _RingNo = ParameterPlcRead("RingNo")
            PreRealStroke = AnalogPlcRead("掘進ストローク")
            PreExcaStatus = _excaStatus

            _excavMode = DigtalPlcRead("掘進モード")

            If _excaStatus <> cTaiki Then
                _MesureCalcAveJackStroke = AnalogPlcRead("平均ジャッキストローク")
                RaiseEvent MesureStrokeChange()
                'PlcIf_MesureStrokeChange()

            End If

            '
            For i = 0 To InitPara.NumberJack - 1
                _JackStatus(i) = AnalogPlcRead("ジャッキステータス" & (i + 1))
                _jackSelect(i) = (_JackStatus(i) And 1)
            Next


            If _LosZeroSts_FLEX <= 2 Then LosZeroSts = _LosZeroSts_FLEX '減圧開始or完了
            If _LosZeroSts_M = 2 Then LosZeroSts = 3    '引き戻し中
            If _LosZeroSts_FLEX = 3 Then LosZeroSts = 6 '組立完了
            '減圧中で掘進してない時は減圧完了とする
            If _excaStatus <> cKussin And LosZeroSts = 1 Then
                LosZeroSts = 2
                LosZeroSts_FLEX = 2
            End If



        Else
            'モニターモードでもPLC書き込み可能か
            InitPara.MonitorModePlcCom = (PLC_Open() = 0)
        End If

        'スピード割合初期値（100%)書き込み
        SpeedRateWrite()

        PLC_Read()



        'TODO:操作権なしの時は、タイマで常時読み込み
        _PointX = _EngValue("ポイントＸ")
        _PointY = _EngValue("ポイントＹ")
        _操作強 = _EngValue("操作強")
        _操作角 = _EngValue("操作角")

        TimerRun()

    End Sub


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



        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
        Dim szDeviceName As String = ""         'デバイス名称
        Dim iNumberOfDeviceName As Integer = 0  'デバイス・サイズ

        '計測ジャッキ取込 '前スキャンの読込
        Dim st As New Dictionary(Of Short, Integer)(_mesureJackStroke)

        If InitPara.MonitorMode Then
            'モニタモード時は、DBよびPLC通信データを読込
            Dim tb As DataTable = GetDtfmSQL("SELECT * FROM plccomdata ORDER BY TIME DESC LIMIT 0,1")
            If tb.Rows.Count > 0 Then
                'アナログデータ
                AnalogComData =
                (From i In tb.Rows(0).Item("Analog").ToString.Split(",") Select Int16.Parse(i)).ToArray
                'パラメータ
                ParmterComData =
                (From i In tb.Rows(0).Item("Parameter").ToString.Split(",") Select CShort(i)).ToArray
                'デジタルデータ
                DigtalComPlcData =
                (From i In tb.Rows(0).Item("Digtal").ToString.Split(",") Select CShort(i)).ToArray
                'データを取得した時刻　フォームに表示
                _DataGetTime = DateTime.Parse(tb.Rows(0).Item("TIME")).AddSeconds(tb.Rows(0).Item("SEC"))
            End If

        End If

        '==============================================================================================================
        Try
            'デバイス値用の領域を割り当て　
            ReDim sharrDeviceValue(AnalogTag.DeviceSize)

            If InitPara.MonitorMode Then
                sharrDeviceValue = AnalogComData
                iReturnCode = 0
            Else
                'ReadDeviceBlock2関数処理の実行 アナログの読込
                iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(AnalogTag.StartAddress,
                                                       AnalogTag.DeviceSize + 1,
                                                      sharrDeviceValue(0))
            End If

            If iReturnCode = 0 Then '通信OK
                'モニタモード時は無条件に実施
                If InitPara.MonitorMode OrElse Not IsNothing(sharrDeviceValue) Then 'OrElse Not sharrDeviceValue.SequenceEqual(AnalogComData) Then
                    Try
                        '保存用データ保持
                        AnalogComData = sharrDeviceValue.Clone

                        For Each at In AnalogTag.Tag
                            _EngValue(at.FieldName) = GetAnalogData(at.FieldName, AnalogTag)
                        Next


                        _gyro = _EngValue("ジャイロ方位")
                        _gyroPitching = _EngValue("ジャイロピッチング")
                        _gyroRolling = _EngValue("ジャイロローリング")

                        _machinePitching = _EngValue("マシンピッチング")
                        _mashineRolling = _EngValue("マシンローリング")
                        If CtlPara.MachineRearRollingExist Then
                            _mashineRearRolling = _EngValue("後胴ローリング")

                        End If
                        If CtlPara.MachineRearRollingExist AndAlso SegAsmblyData.rollingMindEnable(_RingNo) Then
                            Dim blnPreOver As Boolean = (_rollingClockWiseOver Or _rollingAntiClockWiseOver) And _LosZeroEnable
                            _rollingChange =
                                _mashineRearRolling - SegAsmblyData.MachineRearRolling(_RingNo) 'ローリング変化量
                            'ローリング許容値超
                            '時計端 時計端差異ーローリング変化量　＜　ピース端部の余裕許容値
                            _rollingClockWiseOver =
                            ((SegAsmblyData.ClockWiseSegMargin(_RingNo) - _rollingChange) < CtlPara.LoszeroRollingTolerance)
                            '反時計端 ー（反時計端差異ーローリング変化量）　＜　ピース端部の余裕許容値
                            _rollingAntiClockWiseOver =
                            (-(SegAsmblyData.AntiClockWiseSegMargin(_RingNo) - _rollingChange) < CtlPara.LoszeroRollingTolerance)
                            '許容値オーバーがOFF→ONでイベント発生
                            If Not blnPreOver And ((_rollingClockWiseOver Or _rollingAntiClockWiseOver) And _LosZeroEnable) Then
                                RaiseEvent RollingOverAlarm()
                            End If



                        Else
                            _rollingClockWiseOver = False
                            _rollingAntiClockWiseOver = False
                        End If


                        _jkPress = _EngValue("ジャッキ圧力")

                        For i As Short = 0 To InitPara.NumberGroup - 1
                            _groupPv(i) = _EngValue("グループ" & (i + 1) & "圧力")
                            _groupMv(i) = _EngValue("グループ" & (i + 1) & "圧力MV")
                            _groupSv(i) = _EngValue("グループ" & (i + 1) & "圧力SV")
                            _groupFlg(i) = _EngValue("グループ" & (i + 1) & "制御フラグ")
                        Next

                        Dim JkPs As Single = _FilterJkPress
                        _FilterJkPress = _jkPress + CtlPara.元圧フィルタ係数 / 100 * (_FilterJkPress - _jkPress)
                        If _FilterJkPress < 0 Then _FilterJkPress = 0
                        'FLEX手動時に掘進中にジャッキ圧力が変化したイベント
                        If _excaStatus = cKussin AndAlso _flexControlOn And
                            Not CtlPara.AutoDirectionControl And JkPs <> _jkPress Then
                            RaiseEvent JkPressFilterChange()
                        End If

                        _nakaoreLR = _EngValue("中折左右角")
                        _nakaoreTB = _EngValue("中折上下角")
                        _realStroke = _EngValue("掘進ストローク")
                        _excaStatus = _EngValue("掘進ステータス")
                        _CopyAngle = _EngValue("コピー角度")
                        _CopyStroke1 = _EngValue("コピーストローク1")
                        If _EngValue.ContainsKey("コピーストローク2") Then
                            _CopyStroke2 = _EngValue("コピーストローク2")
                        End If
                        _MesureCalcAveJackStroke = _EngValue("平均ジャッキストローク")

                        If CtlPara.TaleClrMeasurUExist Then
                            _topClearance = _EngValue("クリアランス上")
                        End If

                        If CtlPara.TaleClrMeasurLExist Then
                            _leftClearance = _EngValue("クリアランス左")
                        End If
                        If CtlPara.TaleClrMeasurBExist Then
                            _botomClearance = _EngValue("クリアランス下")
                        End If
                        If CtlPara.TaleClrMeasurRExist Then
                            _rightClearance = _EngValue("クリアランス右")
                        End If

                        For Each mj In InitPara.MesureJackAngle.Keys
                            _mesureJackStroke(mj) = _EngValue("ジャッキストローク" & mj)
                            _mesureJackSpeed(mj) = _EngValue("ジャッキスピード" & mj)
                        Next

                        If _EngValue.ContainsKey("異常ストローク番号") Then
                            Dim FailStrokeBf As Integer = FailStrokeNo
                            FailStrokeNo = _EngValue("異常ストローク番号")
                            If FailStrokeNo <> FailStrokeBf Then
                                WriteEventData($"No.{FailStrokeNo}ストローク計の異常が検知されました。", Color.Red)
                                MessageBox.Show($"ストローク計の故障の疑い。{vbCrLf}No.{FailStrokeNo}ストローク計の異常が検知されました。{vbCrLf}確認してください！", "ストローク計故障",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If


                        If InitPara.LosZeroEquip Then '同時施工あり


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
                            '組立完了後の経過時間カウント
                            If _LosZeroSts_M = 5 And _LosZeroSts_FLEX = 3 And _LosZeroEnable Then
                                AsmbledPastTime += 1 'カウントアップ
                                If AsmbledPastTime = CtlPara.NextPieceConfirmTime Then
                                    'カウントアップ後次ピース確認イベント
                                    RaiseEvent NextPieceStart()
                                End If
                            Else
                                AsmbledPastTime = 0 'リセット
                            End If

                            '減圧中のステータスがONだけど、実際減圧してないときの処理　立ち上げ時
                            If _LosZeroSts_FLEX = 1 And Not Reduce.ReduceNow Then
                                Reduce.Start()
                            End If


                            'モニターモードではPLCより組立ピース読込
                            If InitPara.MonitorMode Then
                                    _AssemblyPieceNo = _EngValue("組立ピース")
                                End If
                            'Kセグメント完了で目標推進量(割合を掛けたもの)を超えたときにリング更新するかどうかの判断
                            If _LosZeroSts_FLEX = 3 AndAlso SegAsmblyData.AssemblyPlanPieceNumber = _AssemblyPieceNo AndAlso CtlPara.TargetNetStroke <> 0 AndAlso
                                CalcStroke.CalcAveLogicalStroke > (CtlPara.TargetStrokeOverRate * CtlPara.TargetNetStroke / 100) And Not TargetStrokeOver Then
                                TargetStrokeOver = True
                                RaiseEvent TargetStrokeOverEv()
                            End If
                            '値保持
                            TargetStrokeOver = (CalcStroke.CalcAveLogicalStroke > CtlPara.TargetNetStroke)


                            End If

                            '掘進中でダイレクト制御ONでFLEX手動モード時
                            If _excaStatus = cKussin AndAlso _flexControlOn And
                            CtlPara.DirectControl And Not CtlPara.AutoDirectionControl Then
                            'PID偏差がダイレクト制御偏差より変化
                            For i As Short = 0 To InitPara.NumberGroup - 1
                                If _groupFlg(i) = cDirect And Math.Abs(_groupPv(i) - _groupSv(i)) < CtlPara.PIDShiftDefl Then
                                    RaiseEvent JkPressFilterChange()
                                    Exit For
                                End If
                                If _groupFlg(i) = cPIDOut And Math.Abs(_groupPv(i) - _groupSv(i)) > CtlPara.PIDShiftDefl Then
                                    RaiseEvent JkPressFilterChange()
                                    Exit For
                                End If
                            Next
                        End If


                        For i = 0 To InitPara.NumberJack - 1
                            _JackStatus(i) = _EngValue("ジャッキステータス" & (i + 1))
                            _jackSelect(i) = (_JackStatus(i) And 1)
                        Next

                        '作用点
                        Dim Px As Single = _PointX
                        Dim Py As Single = _PointY
                        _PointX = _EngValue("ポイントＸ")
                        _PointY = _EngValue("ポイントＹ")
                        _操作強 = _EngValue("操作強")
                        _操作角 = _EngValue("操作角")


                        'FLEXモードで手動時に作用点が変化したとき
                        If _flexControlOn And (Px <> _PointX Or Py <> _PointY) AndAlso Not CtlPara.AutoDirectionControl Then
                            JackManual.PutPointXY(_PointX, _PointY)
                        End If

                        TimeOutErrCount = 0

                    Catch ex As Exception

                        If IsNothing(sharrDeviceValue) Then
                        Else

                            'MsgBox($"PLCアナログ読込エラー{vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace.ToString}")
                            RaiseEvent PLCErrOccur(Me, New EventArgs, $"PLC ReadErr {ex.Message}{vbCrLf}{ex.StackTrace.ToString}", 0)
                        End If

                    End Try

                End If


            Else    'エラー発生
                RaiseEvent PLCErrOccur(Me, New EventArgs, "アナログ読込エラー", iReturnCode)
            End If


            '==============================================================================================================
            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(ParameterTag.DeviceSize)

            If InitPara.MonitorMode Then
                sharrDeviceValue = ParmterComData
                ParmterComData = Nothing
                iReturnCode = 0
            Else
                'ReadDeviceBlock2関数処理の実行 パラメータの読込
                iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(ParameterTag.StartAddress,
                                                        ParameterTag.DeviceSize + 1,
                                                        sharrDeviceValue(0))
            End If


            If iReturnCode = 0 Then '通信OK
                'モニタモード時は無条件に実施
                If InitPara.MonitorMode OrElse IsNothing(ParmterComData) OrElse Not ParmterComData.SequenceEqual(sharrDeviceValue) Then

                    '保存用データ保持
                    ParmterComData = sharrDeviceValue.Clone


                    _終了判定引きストローク = GetAnalogData("終了判定引きストローク", ParameterTag)

                    _減圧弁制御P定数 = GetAnalogData("減圧弁制御P定数", ParameterTag)
                    _減圧弁制御I定数 = GetAnalogData("減圧弁制御I定数", ParameterTag)
                    _減圧弁制御D定数 = GetAnalogData("減圧弁制御D定数", ParameterTag)
                    _減圧弁特性増減時間 = GetAnalogData("減圧弁特性増減時間", ParameterTag)


                    ''偏差過大の時の設定値　
                    _感度調整減圧弁制御Ｐ定数 = GetAnalogData("感度調整減圧弁制御P定数", ParameterTag)
                    _感度調整減圧弁制御Ｉ定数 = GetAnalogData("感度調整減圧弁制御I定数", ParameterTag)
                    '_GaingSetReducingValveContDConst = GetAnalogData("", ParameterTag)
                    _感度調整設定圧力偏差 = GetAnalogData("感度調整設定圧力偏差", ParameterTag)
                    'TODO:同時施工で考慮
                    _MaxExcavingStroke = GetAnalogData("掘進中最大ストローク", ParameterTag)

                    _DirectControlCoefficient = GetAnalogData("DirectControlCoefficient", ParameterTag)
                    _DirectControlOffset = GetAnalogData("DirectControlOffset", ParameterTag)


                    Dim rno As Integer = _RingNo
                    _RingNo = GetAnalogData("RingNo", ParameterTag)
                    If rno <> _RingNo Then
                        If _excaStatus = cTaiki Then
                            RaiseEvent ExcavationStatusChange(-1, cTaiki)

                        Else
                            RaiseEvent ExcavationStatusChange(0, 0)
                        End If


                        RaiseEvent LineDistanceChage()

                    End If

                End If

            Else    'エラー発生
                RaiseEvent PLCErrOccur(Me, New EventArgs, "パラメータ読込エラー", iReturnCode)
            End If


            '==============================================================================================================え

            'デバイス値用の領域を割り当て
            ReDim sharrDeviceValue(DigtalTag.DeviceSize \ 16 + 1)


            If InitPara.MonitorMode Then
                sharrDeviceValue = DigtalComPlcData
                iReturnCode = 0
            Else
                'デジタルの読込
                iReturnCode = com_ReferencesEasyIF.ReadDeviceBlock2(DigtalTag.StartAddress,
                                                        DigtalTag.DeviceSize \ 16 + 1,
                                                    sharrDeviceValue(0))
            End If


            DigtalComPlcData = sharrDeviceValue.Clone

            If iReturnCode = 0 Then '通信成功
                Dim bit() As Boolean = WordToBit(sharrDeviceValue)

                If IsNothing(DigtalComData) Then
                    ReDim DigtalComData(bit.Count - 1)
                End If

                Dim ComFlgAdr As Integer =
                    DigtalTag.TagData("伝送フラグ").OffsetAddress

                DigtalComData(ComFlgAdr) = bit(ComFlgAdr)
                'モニタモード時は無条件に実施 データに変更があった時
                If InitPara.MonitorMode OrElse Not bit.SequenceEqual(DigtalComData) Then

                    '保存用データ保持
                    DigtalComData = bit.Clone

                    'FLEXON（圧力制御中)
                    _flexControlOn = bit(DigtalTag.TagData("圧力制御").OffsetAddress)

                    Dim prgyiroError As Boolean = _gyiroError
                    _gyiroError = bit(DigtalTag.TagData("ジャイロ異常").OffsetAddress)
                    If _gyiroError And Not prgyiroError Then 'ジャイロ異常発生
                        RaiseEvent GyiroErrOccuerd()
                    End If

                    '掘進モード、セグメントモード 
                    Dim bf_excvMode As Boolean = _excavMode
                    _excavMode = bit(DigtalTag.TagData("掘進モード").OffsetAddress)
                    If _excavMode And Not bf_excvMode Then
                        '掘進モードに変わったとき
                        RaiseEvent ExcavModeChange(True)
                    End If

                    If DigtalTag.TagExist("組立完了") Then
                        _assembleSegFinish = bit(DigtalTag.TagData("組立完了").OffsetAddress)
                    End If


                    Dim bf_segmentoMode As Boolean = _segmentMode
                    _segmentMode = bit(DigtalTag.TagData("セグメントモード").OffsetAddress)
                    If _segmentMode And Not bf_segmentoMode Then


                        'セグメントモードに変わったとき
                        RaiseEvent ExcavModeChange(False)





                    End If

                    Dim tmp As Boolean

                    tmp = _MachineComErr


                    _MachineComErr = bit(DigtalTag.TagData("マシン伝送異常").OffsetAddress)
                    If tmp = False And _MachineComErr Then
                        WriteEventData("シールドマシン伝送異常が発生しました。", Color.Red)
                    End If

                    If InitPara.LosZeroEquip Then
                        '同時施工モード
                        tmp = _LosZeroMode
                        _LosZeroMode = bit(DigtalTag.TagData("同時施工モード").OffsetAddress)
                        If tmp <> _LosZeroMode Then RaiseEvent LosZeroModeChange()


                        tmp = LosZeroCancel
                        LosZeroCancel = bit(DigtalTag.TagData("同時施工キャンセル").OffsetAddress)
                        If tmp = False And LosZeroCancel Then RaiseEvent LosZeroCancelOn()


                        Dim LosZeroEn As Boolean = _LosZeroEnable
                        _LosZeroEnable = bit(DigtalTag.TagData("同時施工可").OffsetAddress)

                        If Not LosZeroEn And _LosZeroEnable AndAlso (_rollingAntiClockWiseOver Or _rollingClockWiseOver) Then
                            RaiseEvent RollingOverAlarm()
                        End If


                    End If

                End If

            Else    'エラー発生
                RaiseEvent PLCErrOccur(Me, New EventArgs, "デジタル読込エラー", iReturnCode)
            End If
        Catch exException As Exception
            '例外処理	
            'MessageBox.Show(exException.Message & vbCrLf & exException.StackTrace, "PLC_READ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RaiseEvent PLCErrOccur(Me, New EventArgs, $"PLC デジタル読込エラー {exException.Message}{exException.StackTrace.ToString}", 0)
            Exit Sub
        End Try

        If InitPara.ServerMode Then
            'PLCデータをテーブルに書き込む　
            'データは1秒毎に更新、保存は1分毎
            Try
                Dim Tm As String = DateTime.Now.ToString("yyyy/MM/dd HH:") & "00:00"

                ExecuteSqlCmd($"REPLACE INTO PlcComData VALUES 
                        ('{Tm}','{DateTime.Now.ToString("ss").ToNum + DateTime.Now.ToString("mm").ToNum * 60}',
                            '{String.Join(",", AnalogComData)}',
                            '{String.Join(",", DigtalComPlcData)}',
                            '{String.Join(",", ParmterComData)}')")

            Catch ex As Exception

            End Try
        End If



        '計測ストロークのいずれかが変化した時のイベント
        For Each mj In InitPara.MesureJackAngle.Keys
            If _mesureJackStroke(mj) <> st(mj) Then
                RaiseEvent MesureStrokeChange()
                Exit For
            End If
        Next

        '掘進スロトーク、ステータスの変化　基準方向の変更
        If _realStroke <> PreRealStroke Or _excaStatus <> PreExcaStatus _
            Or _gyro <> _PreJyairo Or _PrePitching <> _gyroPitching Or _PremachinePitching <> _machinePitching Then
            RaiseEvent LineDistanceChage()
        End If
        '掘進ステータスの変化
        If _excaStatus <> PreExcaStatus Then
            RaiseEvent ExcavationStatusChange(PreExcaStatus, _excaStatus)
        End If
        '掘削データ保存　ストロークが掘進中に伸びたとき(クライアントモードでないとき）
        If InitPara.ServerMode And _realStroke > PreRealStroke And _excaStatus = cKussin Then
            DataSave.Save()
        End If

        '掘進ストローク保持
        PreRealStroke = _realStroke
        '掘進ステータスの保持
        PreExcaStatus = _excaStatus

        _PreJyairo = _gyro
        _PrePitching = _gyroPitching
        _PremachinePitching = _machinePitching


        '伝送フラグの送出
        'デジタルの読込
        Dim t As Long = 0
        mblnBlink = Not mblnBlink
        t = t Or mblnBlink

        If InitPara.ServerMode Then
            iReturnCode =
            com_ReferencesEasyIF.SetDevice(DigtalTag.TagData("伝送フラグ").Address, t)

            Anlog2WordWite("水平モーメント", CulcMoment.MomentX)
            Anlog2WordWite("鉛直モーメント", CulcMoment.MomentY)
            '作用点追加
            AnlogPlcWriteIfTagExit("作用点Ｘ", CulcMoment.ActivePointX)
            AnlogPlcWriteIfTagExit("作用点Ｙ", CulcMoment.ActivePointY)


        End If

        'モーメント推力の演算
        CulcMoment.ExcaStatus = _excaStatus
        CulcMoment.FlexControlOn = _flexControlOn
        CulcMoment.GroupPv = _groupPv
        CulcMoment.JackSel = _jackSelect
        CulcMoment.JkPress = _jkPress
        CulcMoment.MomentCul()

        frmMain.tmrDataDsp.Enabled = True


        ' ……
    End Sub
    ''' <summary>
    ''' 同時施工用の設定データをPLCへ書込
    ''' </summary>
    ''' <param name="TagName">書込種類　引戻しジャッキ等</param>
    ''' <param name="WrData">書込データ</param>
    Public Sub LosZeroDataWrite(ByVal TagName As String, ByVal WrData As List(Of Short))
        If InitPara.LosZeroEquip Then
            Dim PlcAdress As String = DigtalTag.TagData(TagName & "1").Address  'PLC書込アドレス
            Dim Bit(InitPara.NumberJack - 1) As Boolean
            If Not IsNothing(WrData) Then
                For Each i As Short In WrData
                    Bit(i - 1) = True
                Next
            End If
            Dim PlcWrData() As Integer = BitToWord(Bit)
            Dim iReturnCode As Long = com_ReferencesEasyIF.WriteDeviceBlock(PlcAdress, PlcWrData.Length, PlcWrData(0))

        End If
        'todo:通信エラー時の処理
    End Sub
    ''' <summary>
    ''' 速度割合PLC書き込み
    ''' </summary>
    Public Sub SpeedRateWrite()
        If InitPara.ServerMode And CtlPara.SpeedRateExist Then
            AnalogPlcWrite("速度割合", CInt(_SpeedRate))
        End If

    End Sub

    Const ELEMENT_SIZE_32BITINTEGER = 2 '32bit整数の書込み/読出し時、シーケンサ格納データ用配列の使用要素数

    ''' <summary>
    ''' アナログ２Word書込　モーメント等
    ''' </summary>
    ''' <param name="TagName"></param>
    ''' <param name="Value"></param>
    Public Sub Anlog2WordWite(TagName As String, ByVal Value As Single)


        If _EngValue.ContainsKey(TagName) Then
            _EngValue(TagName) = Value
            Dim wD As Integer
            Dim PlcAdress As String

            With AnalogTag.TagData(TagName)
                PlcAdress = .Address
                'アナログデータをPLC書込データに変換
                wD =
                (Value - .EngLow) / (.EngHight - .EngLow) * (.ScaleHigh - .ScaleLow) + .ScaleLow
                'PLC書込
            End With

            Dim byarrBufferByte() As Byte                                           '編集用バイトバッファの宣言
            Dim sharrBufferForDeviceValue(ELEMENT_SIZE_32BITINTEGER - 1) As Short   'シーケンサ用バッファの宣言

            '入力されたデータを32bit整数に変換し、バイト配列に代入(データ量は4バイト固定)
            byarrBufferByte = BitConverter.GetBytes(CInt(wD))

            'バイト配列からシーケンサ用データバッファに代入
            sharrBufferForDeviceValue(0) = BitConverter.ToInt16(byarrBufferByte, 0)
            sharrBufferForDeviceValue(1) = BitConverter.ToInt16(byarrBufferByte, 2)


            Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値
            Try
                iReturnCode = com_ReferencesEasyIF.WriteDeviceBlock2(PlcAdress, ELEMENT_SIZE_32BITINTEGER,
                                                     sharrBufferForDeviceValue(0))
            Catch exException As Exception
                '例外処理	
                MessageBox.Show(exException.Message, "Anlog2WordWite", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If


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
        _EngValue(TagName) = Value
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
    ''' アナログtag存在チェック後書き込む
    ''' </summary>
    ''' <param name="TagName"></param>
    ''' <param name="Value"></param>
    Public Sub AnlogPlcWriteIfTagExit(TagName As String, ByVal Value As Single)
        If _EngValue.ContainsKey(TagName) Then
            AnalogPlcWrite(TagName, Value)
        End If


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
    ''' パラメータデータ　PLC読込
    ''' </summary>
    ''' <param name="TagNmae"></param>
    ''' <returns></returns>
    Public Function ParameterPlcRead(TagNmae As String) As Integer
        Return PLC_Read(ParameterTag.TagData(TagNmae).Address)
    End Function
    ''' <summary>
    ''' 作用点情報書き込み
    ''' </summary>
    Public Sub PointWrite()
        'AnalogPlcWrite("ポイントＸ", _PointX)
        'AnalogPlcWrite("ポイントＹ", _PointY)
        'AnalogPlcWrite("操作強", _操作強)
        'AnalogPlcWrite("操作角", _操作角)
        ''Debug.WriteLine($"{Now} {_PointX}")
    End Sub



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
            MessageBox.Show(exException.Message, "PLC_Read", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If CtlPara.最大全開出力時の目標圧力 <> 0 Then
                '' PLCに0-4000でSVを出力

                intPressWrData(i) = Int(sngPres(i) / CtlPara.最大全開出力時の目標圧力 * 4000)

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



