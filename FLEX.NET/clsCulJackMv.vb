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
    Private mdblHorHensa As Double
    Private mdblVerHensa As Double

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


    ''前回（一秒前に算出した強さ）
    Private mdblRcDash As Double

    ''' <summary>
    ''' 圧力調整中フラグ変化時
    ''' </summary>
    ''' <param name="Flg"></param>
    Public Event OneWayLimitModeChanges(ByVal Flg As Boolean)

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
    Public Property 操作角() As Double
        Get
            Return mdbl操作角
        End Get
        Set(ByVal Value As Double)
            mdbl操作角 = Value
        End Set
    End Property


    ''02/11/04追加
    Public Property 操作強() As Double
        Get
            Return mdbl操作強
        End Get
        Set(ByVal Value As Double)
            mdbl操作強 = Value
        End Set
    End Property


    Public Property PointX() As Double
        Get
            Return mdblPointX
        End Get
        Set(ByVal Value As Double)
            mdblPointX = Value
        End Set
    End Property



    Public Property PointY() As Double
        Get
            Return mdblPointY
        End Get
        Set(ByVal Value As Double)
            mdblPointY = Value
        End Set
    End Property

    Public Property HorHensa() As Double
        Get
            Return mdblHorHensa
        End Get
        Set(ByVal Value As Double)
            mdblHorHensa = Value
        End Set
    End Property



    Public Property VerHensa() As Double
        Get
            Return mdblVerHensa
        End Get
        Set(ByVal Value As Double)
            mdblVerHensa = Value
        End Set
    End Property


    Private Sub Class_Initialize_Renamed()

        ''偏差の初期化
        mdblHorHensa = 0 ''水平
        mdblVerHensa = 0 ''鉛直

        ''01/07/12 追加
        EstValue = New clsEstmateValeu

    End Sub
    ''' <summary>
    ''' 自動方向制御開始
    ''' </summary>
    Public Sub MvAutoStart()
        TimerAuto.Start()
    End Sub
    ''' <summary>
    ''' 自動方向制御停止
    ''' </summary>
    Public Sub MvAutoStop()
        TimerAuto.Stop()
        _圧力調整中 = False
    End Sub


    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
        '自動制御用のタイマー設定
        TimerAuto.Interval = 1000 '一秒間隔
        AddHandler TimerAuto.Elapsed, New Timers.ElapsedEventHandler(AddressOf sbCulc)


    End Sub


    Public Sub sbCulc(sender As Object, e As Timers.ElapsedEventArgs)
        ' @(f)
        '
        ' 機能      :ジャッキ操作量の算出
        '
        ' 備考      :自動方向制御の時に一秒ごとに呼び出される
        'TODO:エラー処理検討
        'On Error GoTo ErrTrap

        If PlcIf.ExcaStatus <> cKussin Then Exit Sub

        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double

        ''圧力操作点座標
        Dim dblX As Double
        Dim dblY As Double


        If mblnモーメント制御 Then
            ''モーメント制御
            ''ＰＩＤ演算
            'TODO:モーメント制御
            mdblHorHensa += mdblHorHensa
            mdblVerHensa += mdblVerHensa

            ''比例常数→比例帯
            dblHorKp = 100 / _水平モーメントP定数
            dblVerKp = 100 / _鉛直モーメントP定数

            dblHorGp = 1 + (cHorKd / _水平モーメントI定数) * (1 - 1 / cHorDg)
            dblVerGp = 1 + (cVerKd / _鉛直モーメントI定数) * (1 - 1 / cVerDg)

            dblHorGi = cHorDg / _水平モーメントI定数
            dblVerGi = cVerDg / _鉛直モーメントI定数

            dblX = dblHorKp * (dblHorGp * _水平モーメント偏差 + dblHorGi * mdblHorHensa)
            dblY = dblVerKp * (dblVerGp * _鉛直モーメント偏差 + dblVerGi * mdblVerHensa)

            '    Debug.Print "偏差", mdbl水平モーメント偏差, mdbl鉛直モーメント偏差
            ''変化率を制限する
            If Abs(dblX - mdblPointX) > 0.1 Then
                dblX = CDbl(IIf(dblX > mdblPointX, mdblPointX + 0.1, mdblPointX - 0.1))
            End If

            If Abs(dblY - mdblPointY) > 0.1 Then
                dblY = CDbl(IIf(dblY > mdblPointY, mdblPointY + 0.1, mdblPointY - 0.1))
            End If


        Else

            ''姿勢制御
            ''ＰＩＤ演算

            mdblHorHensa += mdbl水平偏差角
            mdblVerHensa += mdbl鉛直偏差角

            ''比例常数→比例帯
            dblHorKp = 100 / _水平P定数
            dblVerKp = 100 / _鉛直P定数

            dblHorGp = 1 + (_水平D定数 / _水平I定数) * (1 - 1 / cHorDg)
            dblVerGp = 1 + (_鉛直D定数 / _鉛直I定数) * (1 - 1 / cVerDg)

            dblHorGi = cHorDg / _水平I定数
            dblVerGi = cVerDg / _鉛直I定数

            dblX = dblHorKp * (dblHorGp * mdbl水平偏差角 + dblHorGi * mdblHorHensa)
            dblY = dblVerKp * (dblVerGp * mdbl鉛直偏差角 + dblVerGi * mdblVerHensa)

        End If

        mdblRcDash = Sqrt(dblX ^ 2 + dblY ^ 2)


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

        EstValue.sbCulc() ''予測値の演算
        '予測値は使わない！　.netより

        ''制御モードの判定

        ''ver 1.1でこのコメントを外す
        _圧力超 = PlcIf.JkPress > CtlPara.圧力許容値

        _モーメント上限超 = (CulcMoment.MomentR > CtlPara.ジャッキモーメント上限値) _
            And mblnモーメント制御 = False

        ''半径がある一定値を越えたらロックする。
        ''片押し制限
        _片押しR上限超 = mdblRcDash > CtlPara.片押しR制限

        ''片押制御フラグをすべてに反映
        ''モーメント上限超えを変数に
        Dim LimitOn As Boolean = _圧力調整中
        _圧力調整中 = ((_圧力超 Or _モーメント上限超 Or _片押しR上限超)
            ) And CtlPara.片押し制限フラグ And Not mblnStartTraking
        If LimitOn <> _圧力調整中 Then
            RaiseEvent OneWayLimitModeChanges(_圧力調整中)
        End If


        If _圧力調整中 And mdblRcDash > mdbl操作強 Then

            ''圧力調整モード
            dblX = mdbl操作強 * Cos(mdbl操作角 / 180 * PI)
            dblY = mdbl操作強 * Sin(mdbl操作角 / 180 * PI)

            If mblnモーメント制御 Then
                mdblHorHensa = 1 / (dblHorKp * dblHorGi) * dblX - dblHorGp / dblHorGi * _水平モーメント偏差
                mdblVerHensa = 1 / (dblVerKp * dblVerGi) * dblY - dblVerGp / dblVerGi * _鉛直モーメント偏差
            Else
                mdblHorHensa = 1 / (dblHorKp * dblHorGi) * dblX - dblHorGp / dblHorGi * mdbl水平偏差角
                mdblVerHensa = 1 / (dblVerKp * dblVerGi) * dblY - dblVerGp / dblVerGi * mdbl鉛直偏差角
            End If
            mdblRcDash = mdbl操作強


            ''制御モードがＰＩＤ→圧力調整に切り替わったとき
            '    If mbln制御モード Then RaiseEvent 制御モードChanges(False)
            '
            '    mbln制御モード = False

        Else
            ''制御モードが圧力調整→ＰＩＤに切り替わったとき
            ' If Not mbln制御モード Then RaiseEvent 制御モードChanges(True)

            ''ＰＩＤモード
            ' mbln制御モード = True

        End If

        ''手動→自動トラッキング時は片押しが効かないようにセット

        mblnStartTraking = False

        mdblPointX = dblX
        mdblPointY = dblY
        mdbl操作強 = mdblRcDash

        RaiseEvent AutoDirectionCulc()

        'Debug.Print mdblPointX, mdblPointY
        Exit Sub

ErrTrap:
        ''立ち上げ時に掘進してる場合の処理
        If Err.Number = 11 Then Exit Sub
        Resume Next

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

        mdblHorHensa = 1 / (dblHorKp * dblHorGi) * mdblPointX - dblHorGp / dblHorGi * mdbl水平偏差角
        mdblVerHensa = 1 / (dblVerKp * dblVerGi) * mdblPointY - dblVerGp / dblVerGi * mdbl鉛直偏差角

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

        mdblHorHensa = 1 / (dblHorKp * dblHorGi) * mdblPointX
        mdblVerHensa = 1 / (dblVerKp * dblVerGi) * mdblPointY

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


