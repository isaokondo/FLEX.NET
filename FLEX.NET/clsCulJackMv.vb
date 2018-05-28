'Option Strict On
Option Explicit On
Imports System.Math

Friend Class clsCulJackMv
    ' @(h) clsCulJackMv.cls                ver 1.0 ( '01.02.28 近藤　勲 )
    ' @(h) clsCulJackMv.cls                ver 1.1 ( '01.07.12 近藤　勲 )
    ' @(h) clsCulJackMv.cls                ver 1.2 ( '02.11.05 近藤　勲 )
    ' 他現場も反映の事
    ''手動→自動トラッキング時は片押しが効かないようにセット

    ' @(h) clsCulJackMv.cls                ver 2.0 ( '04.09.22 近藤　勲 )
    ' 同時施工用　減圧時、低圧推進開始時にモーメントによる制御を行う


    ' @(s)ジャッキ操作量の演算
    '
    '
    'ver 1.1　片押し限界の調整を計測値から予測値に変更する。（計測値では制御遅れによりさらに増加する可能性があるため）

    '自動制御のタイマー
    Private TimerAuto As New System.Timers.Timer

    Private EstValue As New clsEstmateValeu ''元圧とモーメントの予測値 04/09/21



    ''微分時間、ゲイン(1に固定）
    Private Const cHorKd As Double = 1
    Private Const cVerKd As Double = 1
    Private Const cHorDg As Double = 1
    Private Const cVerDg As Double = 1

    'TODO:微分定数は固定から入力値に変更　JS市川で対応か？

    ''-----入力値-----
    Private _水平P定数 As Double
    Private _水平I定数 As Double
    Private _水平D定数 As Double

    Private _鉛直P定数 As Double
    Private _鉛直I定数 As Double
    Private _鉛直D定数 As Double

    Private mdblジャッキ圧 As Double

    ''目標姿勢に対する偏差角
    Private mdbl水平偏差角 As Double
    Private mdbl鉛直偏差角 As Double

    ''設定値
    Private _圧力許容値 As Double
    Private _作動範囲 As Double
    Private _片押制御Flg As Boolean ''True：片押し制限あり　False:なし
    Private _モーメント上限 As Double

    ''------出力値-----
    Private mdbl操作強 As Double
    Private mdbl操作角 As Double

    '圧力操作点の座標
    Private mdblPointX As Double
    Private mdblPointY As Double


    ''クラス内モジュール変数
    Private _HorDev As Double
    Private _VerDev As Double

    Private mbln制御モード As Boolean ''True：PID　False:圧力制御


    Private _圧力超 As Boolean ''True：範囲外　False:範囲内
    Private _モーメント上限超 As Boolean ''True：範囲外　False:範囲内
    Private _片押しR上限超 As Boolean ''True：範囲外　False:範囲内

    Private _圧力調整中 As Boolean

    '' 04/09/22 追加
    Private mblnモーメント制御 As Boolean ''True：範囲外　False:範囲内

    Private _水平モーメントP定数 As Double
    Private _水平モーメントI定数 As Double

    Private _鉛直モーメントP定数 As Double
    Private _鉛直モーメントI定数 As Double

    Private _水平モーメント偏差 As Double
    Private _鉛直モーメント偏差 As Double



    ''02/11/05 追加
    ''手動→自動トラッキング時は片押しが効かないようにセット
    Private mblnStartTraking As Boolean


    ''' <summary>
    '''前回（一秒前に算出した強さ） 
    ''' </summary>
    Private mdblRcDash As Double
    '_圧力超 Or _モーメント上限超 Or _片押しR上限超


    Public Event OneWayLimitModeChanges(ByVal 圧力flg As Boolean, ByVal モーメント上限flg As Boolean, ByVal 片押しR上限flg As Boolean)

    ''' <summary>
    ''' 自動方向制御演算完
    ''' </summary>
    Public Event AutoDirectionCulc()

    Public Property 圧力調整中 As Boolean
        Get
            Return _圧力調整中
        End Get
        Set(value As Boolean)
            _圧力調整中 = value
        End Set
    End Property


    Public ReadOnly Property 圧力超() As Boolean
        Get
            Return _圧力超 And _圧力調整中
        End Get
    End Property

    Public ReadOnly Property モーメント上限超() As Boolean
        Get
            Return _モーメント上限超 And _圧力調整中
        End Get
    End Property

    Public ReadOnly Property 片押しR上限超 As Boolean
        Get
            Return _片押しR上限超 And _圧力調整中
        End Get
    End Property


    ''04/09/22 追加
    ''-----------------------------------------------------------
    Public Property モーメント制御() As Boolean
        Get
            Return mblnモーメント制御
        End Get
        Set(ByVal Value As Boolean)

            If mblnモーメント制御 <> Value Then ''値が変化したとき
                If Value Then
                    Call sbSiseiToMomentTracking()
                    'frmFLEX.sbPutEventWrite("モーメント制御に変わりました", System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Magenta))
                Else
                    ''モーメント制御から姿勢制御へのトラッキング処理
                    Call sbMnToAutTracking()
                    'frmFLEX.sbPutEventWrite("姿勢制御に戻りました。", System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black))
                End If
            End If
            mblnモーメント制御 = Value

        End Set
    End Property

    Public Property 水平モーメント偏差() As Double
        Get
            Return _水平モーメント偏差
        End Get
        Set(ByVal Value As Double)
            _水平モーメント偏差 = Value
        End Set
    End Property
    Public Property 鉛直モーメント偏差() As Double
        Get
            Return _鉛直モーメント偏差
        End Get
        Set(ByVal Value As Double)
            _鉛直モーメント偏差 = Value
        End Set
    End Property

    ''-----------------------------------------------------------


    Public Property 水平偏差角() As Double
        Get
            Return mdbl水平偏差角
        End Get
        Set(ByVal Value As Double)
            mdbl水平偏差角 = Value
        End Set
    End Property
    Public Property 鉛直偏差角() As Double
        Get
            Return mdbl鉛直偏差角
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直偏差角 = Value
        End Set
    End Property

    Public WriteOnly Property ジャッキ圧() As Double
        Set(ByVal Value As Double)
            mdblジャッキ圧 = Value
        End Set
    End Property


    Public Property 片押制御Flg() As Boolean
        Get
            Return _片押制御Flg
        End Get
        Set(ByVal Value As Boolean)
            _片押制御Flg = Value
        End Set
    End Property


    Public WriteOnly Property 水平I定数() As Double
        Set(ByVal Value As Double)
            _水平I定数 = Value
        End Set
    End Property

    Public WriteOnly Property 水平P定数() As Double
        Set(ByVal Value As Double)
            _水平P定数 = Value
        End Set
    End Property
    Public WriteOnly Property 水平D定数() As Double

        Set(ByVal Value As Double)
            _水平D定数 = Value
        End Set
    End Property

    Public WriteOnly Property 鉛直I定数() As Double
        Set(ByVal Value As Double)
            _鉛直I定数 = Value
        End Set
    End Property


    Public WriteOnly Property 鉛直P定数() As Double

        Set(ByVal Value As Double)
            _鉛直P定数 = Value
        End Set
    End Property

    Public WriteOnly Property 鉛直D定数() As Double

        Set(value As Double)
            _鉛直D定数 = value
        End Set
    End Property


    ''04/09/22 追加
    Public Property 水平モーメントI定数() As Double
        Get
            Return _水平モーメントI定数
        End Get
        Set(ByVal Value As Double)
            _水平モーメントI定数 = Value
        End Set
    End Property


    Public Property 水平モーメントP定数() As Double
        Get
            Return _水平モーメントP定数
        End Get
        Set(ByVal Value As Double)
            _水平モーメントP定数 = Value
        End Set
    End Property


    Public Property 鉛直モーメントI定数() As Double
        Get
            Return _鉛直モーメントI定数
        End Get
        Set(ByVal Value As Double)
            _鉛直モーメントI定数 = Value
        End Set
    End Property


    Public Property 鉛直モーメントP定数() As Double
        Get
            Return _鉛直モーメントP定数
        End Get
        Set(ByVal Value As Double)
            _鉛直モーメントP定数 = Value
        End Set
    End Property


    ''03/01/20追加 同時施工用
    Public Property 操作角() As Single
        Get
            Return mdbl操作角
        End Get
        Set(ByVal Value As Single)
            mdbl操作角 = Value
        End Set
    End Property


    ''02/11/04追加
    Public Property 操作強() As Single
        Get
            Return mdbl操作強
        End Get
        Set(ByVal Value As Single)
            mdbl操作強 = Value
        End Set
    End Property


    Public Property PointX() As Single
        Get
            Return mdblPointX
        End Get
        Set(ByVal Value As Single)
            mdblPointX = Value
        End Set
    End Property



    Public Property PointY() As Single
        Get
            Return mdblPointY
        End Get
        Set(ByVal Value As Single)
            mdblPointY = Value
        End Set
    End Property

    Public Property HorDev() As Double
        Get
            Return _HorDev
        End Get
        Set(ByVal Value As Double)
            _HorDev = Value
        End Set
    End Property



    Public Property VerDev() As Double
        Get
            Return _VerDev
        End Get
        Set(ByVal Value As Double)
            _VerDev = Value
        End Set
    End Property


    Private Sub Class_Initialize_Renamed()

        ''偏差の初期化
        _HorDev = 0 ''水平
        _VerDev = 0 ''鉛直

        ''01/07/12 追加
        EstValue = New clsEstmateValeu

    End Sub
    ''' <summary>
    ''' 自動方向制御開始
    ''' </summary>
    Public Sub MvAutoStart()


        '自動制御開始時は、力点位置より偏差の重みを計算

        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double

        dblHorKp = 100 / _水平P定数
        dblVerKp = 100 / _鉛直P定数

        dblHorGp = 1 + (_水平D定数 / _水平I定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (_鉛直D定数 / _鉛直I定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / _水平I定数
        dblVerGi = cVerDg / _鉛直I定数

        '力点位置はPLCより取得
        _HorDev = (PlcIf.PointX / dblHorKp - dblHorGp * mdbl水平偏差角) / dblHorGi
        _VerDev = (PlcIf.PointY / dblVerKp - dblVerGp * mdbl鉛直偏差角) / dblVerGi

        TimerAuto.Start()
    End Sub
    ''' <summary>
    ''' 自動方向制御停止
    ''' </summary>
    Public Sub MvAutoStop()
        TimerAuto.Stop()
        _圧力調整中 = False
    End Sub

    Public ReadOnly Property MvAutoOn As Boolean
        Get
            Return TimerAuto.Enabled
        End Get
    End Property



    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
        '自動制御用のタイマー設定
        TimerAuto.Interval = 1000 '一秒間隔
        AddHandler TimerAuto.Elapsed, New Timers.ElapsedEventHandler(AddressOf sbCulc)


    End Sub

    ''' <summary>
    ''' ジャッキ操作量の算出
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub sbCulc(sender As Object, e As Timers.ElapsedEventArgs)
        ' @(f)
        '
        ' 機能      :ジャッキ操作量の算出
        '
        ' 備考      :自動方向制御の時に一秒ごとに呼び出される

        'TODO:エラー処理検討

        If PlcIf.ExcaStatus <> cKussin Then Exit Sub

        TimerAuto.Enabled = False


        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double

        ''圧力操作点座標
        Dim dblX As Double
        Dim dblY As Double

        ''姿勢制御
        ''ＰＩＤ演算

        _HorDev += mdbl水平偏差角
        _VerDev += mdbl鉛直偏差角


        ''比例常数→比例帯
        dblHorKp = 100 / _水平P定数
        dblVerKp = 100 / _鉛直P定数

        dblHorGp = 1 + (_水平D定数 / _水平I定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (_鉛直D定数 / _鉛直I定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / _水平I定数
        dblVerGi = cVerDg / _鉛直I定数

        dblX = dblHorKp * (dblHorGp * mdbl水平偏差角 + dblHorGi * _HorDev)
        dblY = dblVerKp * (dblVerGp * mdbl鉛直偏差角 + dblVerGi * _VerDev)



        mdblRcDash = Sqrt(dblX ^ 2 + dblY ^ 2)
        'オーバーフロー防止
        If mdblRcDash > 20 Then mdblRcDash = 20
        If mdblRcDash < -20 Then mdblRcDash = -20

        If fnNearZero(dblX) And fnNearZero(dblY) Then
            mdbl操作角 = 0

        Else
            If dblX > 0 And dblY >= 0 Then
                mdbl操作角 = Atan(dblY / dblX) * 180 / PI
            ElseIf dblX > 0 And dblY < 0 Then
                mdbl操作角 = Atan(dblY / dblX) * 180 / PI + 360
            Else
                mdbl操作角 = Atan(dblY / dblX) * 180 / PI + 180
            End If
        End If
        '

        'Debug.Print($"{Now.ToLocalTime}  dblx={dblX} ,dlbY={dblY}    PLCX={PlcIf.PointX} PLCY={PlcIf.PointY}")


        EstValue.sbCulc() ''予測値の演算
        '予測値は使わない！　.netより

        ''制御モードの判定
        _圧力超 = PlcIf.JkPress > CtlPara.圧力許容値

        _モーメント上限超 = (CulcMoment.MomentR > CtlPara.ジャッキモーメント上限値) And mblnモーメント制御 = False

        ''半径がある一定値を越えたらロックする。
        _片押しR上限超 = mdblRcDash > CtlPara.片押しR制限値

        ''片押制御フラグをすべてに反映
        ''モーメント上限超えを変数に
        Dim LimitOn As Boolean = _圧力調整中
        _圧力調整中 = ((_圧力超 Or _モーメント上限超 Or _片押しR上限超)
            ) And CtlPara.片押し制限フラグ And Not mblnStartTraking
        If CtlPara.AutoDirectionControl AndAlso LimitOn <> _圧力調整中 Then
            RaiseEvent OneWayLimitModeChanges(_圧力超, _モーメント上限超, _片押しR上限超)
        End If


        If _片押しR上限超 And mdblRcDash > mdbl操作強 Then

            ''圧力調整モード
            dblX = mdbl操作強 * Cos(mdbl操作角.ToRad)
            dblY = mdbl操作強 * Sin(mdbl操作角.ToRad)

            _HorDev = 1 / (dblHorKp * dblHorGi) * dblX - dblHorGp / dblHorGi * mdbl水平偏差角
            _VerDev = 1 / (dblVerKp * dblVerGi) * dblY - dblVerGp / dblVerGi * mdbl鉛直偏差角
            mdblRcDash = mdbl操作強

            mdblRcDash -= CtlPara.単位当r引き戻し量 / CtlPara.引き戻し実施間隔

            If mdblRcDash < 0 Then mdblRcDash = 0

        End If

        'モーメント上限超 と　圧力超 は、モーメント低減率により力点移動
        If _モーメント上限超 Or _圧力超 Then
            'モーメント最適化
            Dim MomentOpt As New clsMomentOptimize

            '最適化パラメータのセット
            MomentOpt.Nlp = CtlPara.LosZeroNlp '繰り返し回数
            MomentOpt.rStep = CtlPara.LoszerorStep '力点変化ステップ
            MomentOpt.Epm = CtlPara.LosZeroEmp 'モーメント偏差許容値
            MomentOpt.InitPointX = dblX '力点初期値
            MomentOpt.InitPointY = dblY
            '目標モーメント に　モーメント低減率をかける
            MomentOpt.TargetMomentX = CulcMoment.MomentX * CtlPara.MomentRdductionRateOnOnewayLimit / 100
            MomentOpt.TargetMomentY = CulcMoment.MomentY * CtlPara.MomentRdductionRateOnOnewayLimit / 100
            '掘進モード & 稼働ジャッキをセット
            For i As Short = 0 To InitPara.NumberJack - 1
                MomentOpt.DivCul0.OnJack(i) =
                    PlcIf.JackExecMode(i) And PlcIf.JackSel(i)
            Next
            '最適化
            MomentOpt.Optimize()

            dblX = MomentOpt.CulPointX
            dblY = MomentOpt.CulPointY

            _HorDev = 1 / (dblHorKp * dblHorGi) * dblX - dblHorGp / dblHorGi * mdbl水平偏差角
            _VerDev = 1 / (dblVerKp * dblVerGi) * dblY - dblVerGp / dblVerGi * mdbl鉛直偏差角

            mdblRcDash = Sqrt(dblX ^ 2 + dblY ^ 2)

        End If


        ''手動→自動トラッキング時は片押しが効かないようにセット

        mblnStartTraking = False

        mdblPointX = dblX
        mdblPointY = dblY
        mdbl操作強 = mdblRcDash

        RaiseEvent AutoDirectionCulc()

        TimerAuto.Enabled = True


    End Sub

    Public Sub sbMnToAutTracking()
        ' @(f)
        '
        ' 機能      :手動から自動時のトラッキング処理
        '
        ' 備考      :

        ''モーメント制御の時は行わないようにする 04/09/22 追加
        'If mblnモーメント制御 Then Exit Sub

        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double


        ''比例常数→比例帯
        dblHorKp = 100 / _水平P定数
        dblVerKp = 100 / _鉛直P定数

        dblHorGp = 1 + (cHorKd / _水平I定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (cVerKd / _鉛直I定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / _水平I定数
        dblVerGi = cVerDg / _鉛直I定数

        _HorDev = 1 / (dblHorKp * dblHorGi) * mdblPointX - dblHorGp / dblHorGi * mdbl水平偏差角
        _VerDev = 1 / (dblVerKp * dblVerGi) * mdblPointY - dblVerGp / dblVerGi * mdbl鉛直偏差角

        ''手動→自動トラッキング時は片押しが効かないようにセット
        mblnStartTraking = True

    End Sub

    Public Sub sbSiseiToMomentTracking()
        ' @(f)
        '
        ' 機能      :姿勢制御からモーメント制御のトラッキング処理
        '
        ' 備考      :

        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double


        ''比例常数→比例帯
        dblHorKp = 100 / _水平モーメントP定数
        dblVerKp = 100 / _鉛直モーメントP定数

        dblHorGp = 1 + (cHorKd / _水平モーメントI定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (cVerKd / _鉛直モーメントI定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / _水平モーメントI定数
        dblVerGi = cVerDg / _鉛直モーメントI定数

        _HorDev = 1 / (dblHorKp * dblHorGi) * mdblPointX
        _VerDev = 1 / (dblVerKp * dblVerGi) * mdblPointY

        ''手動→自動トラッキング時は片押しが効かないようにセット
        mblnStartTraking = True


    End Sub


    ''' <summary>
    ''' モーメントの予測値
    ''' </summary>
    Private Class clsEstmateValeu
        ' @(h) clsEstmateValeu              ver 1.0 ( '01.07.11 近藤　勲 )
        ' @(h) clsEstmateValeu              ver 1.1 ( '01.09.18 近藤　勲 )
        'mdbl元圧予測の予測値の演算修正
        ' @(h) clsEstmateValeu              ver 1.2 ( '01.09.19 近藤　勲 )
        'mdblモーメントの予測値の演算修正
        ' @(s)
        'mdblモーメントの予測値の演算修正　　　ver 1.3('02.05.31 近藤　勲）
        ' @(s)
        '１グループのジャッキが一番ジャッキより前の番号の場合グループの中心角度の
        '算出方法にバグがあった。そのためモーメント予測値が正しく演算されなかった。
        '南住吉で発見！！！
        '
        'mdblモーメントの予測値の演算修正　　　ver 1.4('02.11.05 近藤　勲）
        ' @(s)
        ' グループの中心角度を求める個所にバグあり。
        '次回よりFEXL.INIに記述するぞ！

        'mdblモーメントの予測値の演算修正　　　ver 1.5('04.10.26 近藤　勲）

        '稼働ジャッキのみの条件を追加

        Private mdbl分担率指令値() As Double

        Private mdblジャッキ圧 As Double
        Private mdbl元圧予測 As Double
        Private mdblモーメント予測 As Double

        Public ReadOnly Property 元圧予測() As Double
            Get
                元圧予測 = mdbl元圧予測
            End Get
        End Property

        Public ReadOnly Property モーメント予測() As Double
            Get
                モーメント予測 = mdblモーメント予測
            End Get
        End Property



        Private Sub Class_Initialize_Renamed()
            ''配列の初期化

            'ReDim mdbl分担率指令値(InitParameter.NumberGroup)
        End Sub
        Public Sub New()
            MyBase.New()
            Class_Initialize_Renamed()
        End Sub


        Public Sub sbCulc()
            ' @(f)
            '
            ' 機能      :予測値の演算
            '
            ' 返り値    :なし
            ' 　　　    :
            '
            ' 機能説明  :元圧、ﾓｰﾒﾝﾄの予測値の演算
            '
            ' 備考      :


            Dim i As Short ''カウンター

            ''分担率の最大値を求める

            mdbl分担率指令値 = DivCul.分担率指令値.Clone
            '分担率最大値
            Dim dblMaxBuntan As Double = mdbl分担率指令値.Max

            ''各グループ毎のジャッキ本数を求める
            Dim intGpJk(InitPara.NumberGroup - 1) As Integer '各グループ毎のジャッキ本数

            '稼働ジャッキのみの条件を追加
            For i = 0 To InitPara.NumberJack - 1
                If PlcIf.JackSel(i) Then
                    intGpJk(InitPara.JackGroupPos(i) - 1) += 1
                End If
            Next i
            If dblMaxBuntan = 0 Then Exit Sub

            ''②その分担率の最大推力を計算する。
            Dim dblEachThrust(InitPara.NumberGroup - 1) As Double ''各グループの推力
            For i = 0 To InitPara.NumberGroup - 1
                mdbl分担率指令値(i) = mdbl分担率指令値(i) / dblMaxBuntan
                dblEachThrust(i) = mdbl分担率指令値(i) * InitPara.JackPower * intGpJk(i)
            Next i

            Dim dblMaxThrust As Double = dblEachThrust.Sum ''最大推力

            ''01/09/18 修正
            mdbl元圧予測 = CulcMoment.Thrust / dblMaxThrust * InitPara.JackMaxOilPres

            ''圧力補正の算出
            ''⑤最低ジャッキ圧力を考慮してI欄の圧力を補正する｡
            ''⑥圧力補正から各ジャッキ推力を計算する。
            ''⑦このジャッキ推力からﾓｰﾒﾝﾄを計算する。
            'TODO:各グループの中心角度の求め方をLINQで対応　現状ではバグあり！
            Dim dblMomentX As Single
            Dim dblMomentY As Single
            'グループの終了角度 ''グループの開始角度
            With InitPara

                Dim dblHosePres(InitPara.NumberGroup - 1) As Double
                Dim dblEachJkThrust(InitPara.NumberGroup - 1) As Double

                For i = 0 To InitPara.NumberGroup - 1
                    ''圧力補正を求める
                    dblHosePres(i) = mdbl元圧予測 * mdbl分担率指令値(i)
                    ''最低ジャッキ圧力を考慮
                    'TODO:最低ジャッキ圧力の設定より取込
                    If dblHosePres(i) <= 2 Then dblHosePres(i) = 2
                    ''各ジャッキ推力を計算する。
                    '        dblEachJkThrust(intCnt) = _
                    dblEachJkThrust(i) =
                        dblHosePres(i) / InitPara.JackMaxOilPres * InitPara.JackPower * intGpJk(i)

                    ''X方向モーメント計算,各グループ毎の加算
                    dblMomentX -=
                        dblEachJkThrust(i) * InitPara.JackRadius * Math.Cos(.FaiGroup(i) * PI / 180)
                    ''Y方向モーメント計算,各グループ毎の加算
                    dblMomentY +=
                        dblEachJkThrust(i) * InitPara.JackRadius * Math.Sin(.FaiGroup(i) * PI / 180)
                Next i
            End With

            mdblモーメント予測 = Math.Sqrt(dblMomentX ^ 2 + dblMomentY ^ 2)

        End Sub
    End Class


End Class


