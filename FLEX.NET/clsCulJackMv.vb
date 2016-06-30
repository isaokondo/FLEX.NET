Option Strict On
Option Explicit On
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


    ''01/07/12 追加
    'Private clsEstValue As New clsEstmateValeu  ''元圧とモーメントの予測値

    ''微分時間、ゲイン(1に固定）
    Private Const cHorKd As Double = 1
    Private Const cVerKd As Double = 1
    Private Const cHorDg As Double = 1
    Private Const cVerDg As Double = 1


    ''-----入力値-----
    Private mdbl水平P定数 As Double
    Private mdbl水平I定数 As Double

    Private mdbl鉛直P定数 As Double
    Private mdbl鉛直I定数 As Double

    Private mdblジャッキ圧 As Double

    Private mdbl合成モーメント As Double

    ''目標姿勢に対する偏差角
    Private mdbl水平偏差角 As Double
    Private mdbl鉛直偏差角 As Double

    ''設定値
    Private mdbl圧力許容値 As Double
    Private mdbl作動範囲 As Double
    Private mbln片押制御Flg As Boolean ''True：片押し制限あり　False:なし
    Private mdblモーメント上限 As Double

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

    'Private mbln制御モード As Boolean   ''True：PID　False:圧力制御
    Private mint制御モードフラグ As Short ''制御モードフラグ 2015/11/15 変更
    '1:PID制御
    '2:圧力判定超
    '3:モーメント超
    '4:片押しR上限超




    Private mbln圧力判定 As Boolean ''True：範囲外　False:範囲内
    Private mblnモーメント上限超 As Boolean ''True：範囲外　False:範囲内

    Private mbln片押しR上限超 As Boolean ''True：範囲外　False:範囲内


    '' 04/09/22 追加
    Private mblnモーメント制御 As Boolean ''True：範囲外　False:範囲内

    Private mdbl水平モーメントP定数 As Double
    Private mdbl水平モーメントI定数 As Double

    Private mdbl鉛直モーメントP定数 As Double
    Private mdbl鉛直モーメントI定数 As Double

    Private mdbl水平モーメント偏差 As Double
    Private mdbl鉛直モーメント偏差 As Double



    ''02/11/05 追加
    ''手動→自動トラッキング時は片押しが効かないようにセット
    Private mblnStartTraking As Boolean


    ''前回（一秒前に算出した強さ）
    Private mdblRcDash As Double

    ''制御モードが切り替わったときのイベント
    'Public Event 制御モードChanges(ByVal blnMode As Boolean)
    Public Event 制御モードフラグChanges(ByVal intMode As Short)





    Public Property 圧力判定() As Boolean
        Get
            Return mbln圧力判定
        End Get
        Set(ByVal Value As Boolean)
            mbln圧力判定 = Value
        End Set
    End Property

    Public ReadOnly Property モーメント上限超() As Boolean
        Get
            Return mblnモーメント上限超
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
            Return mdbl水平モーメント偏差
        End Get
        Set(ByVal Value As Double)
            mdbl水平モーメント偏差 = Value
        End Set
    End Property
    Public Property 鉛直モーメント偏差() As Double
        Get
            Return mdbl鉛直モーメント偏差
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直モーメント偏差 = Value
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


    Public Property 合成モーメント() As Double
        Get
            Return mdbl合成モーメント
        End Get
        Set(ByVal Value As Double)
            mdbl合成モーメント = Value
        End Set
    End Property

    Public Property モーメント上限() As Double
        Get
            Return mdblモーメント上限
        End Get
        Set(ByVal Value As Double)
            mdblモーメント上限 = Value
        End Set
    End Property



    Public Property 制御モードフラグ() As Short
        Get
            Return mint制御モードフラグ
        End Get
        Set(ByVal Value As Short)
            mint制御モードフラグ = Value
        End Set
    End Property

    Public Property 片押制御Flg() As Boolean
        Get
            Return mbln片押制御Flg
        End Get
        Set(ByVal Value As Boolean)
            mbln片押制御Flg = Value
        End Set
    End Property


    Public Property 作動範囲() As Double
        Get
            Return mdbl作動範囲
        End Get
        Set(ByVal Value As Double)
            mdbl作動範囲 = Value
        End Set
    End Property


    Public Property 圧力許容値() As Double
        Get
            Return mdbl圧力許容値
        End Get
        Set(ByVal Value As Double)
            mdbl圧力許容値 = Value
        End Set
    End Property



    Public Property 水平I定数() As Double
        Get
            Return mdbl水平I定数
        End Get
        Set(ByVal Value As Double)
            mdbl水平I定数 = Value
        End Set
    End Property


    Public Property 水平P定数() As Double
        Get
            Return mdbl水平P定数
        End Get
        Set(ByVal Value As Double)
            mdbl水平P定数 = Value
        End Set
    End Property


    Public Property 鉛直I定数() As Double
        Get
            Return mdbl鉛直I定数
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直I定数 = Value
        End Set
    End Property


    Public Property 鉛直P定数() As Double
        Get
            Return mdbl鉛直P定数
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直P定数 = Value
        End Set
    End Property


    ''04/09/22 追加
    Public Property 水平モーメントI定数() As Double
        Get
            Return mdbl水平モーメントI定数
        End Get
        Set(ByVal Value As Double)
            mdbl水平モーメントI定数 = Value
        End Set
    End Property


    Public Property 水平モーメントP定数() As Double
        Get
            Return mdbl水平モーメントP定数
        End Get
        Set(ByVal Value As Double)
            mdbl水平モーメントP定数 = Value
        End Set
    End Property


    Public Property 鉛直モーメントI定数() As Double
        Get
            Return mdbl鉛直モーメントI定数
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直モーメントI定数 = Value
        End Set
    End Property


    Public Property 鉛直モーメントP定数() As Double
        Get
            Return mdbl鉛直モーメントP定数
        End Get
        Set(ByVal Value As Double)
            mdbl鉛直モーメントP定数 = Value
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


    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()

        ''偏差の初期化
        mdblHorHensa = 0 ''水平
        mdblVerHensa = 0 ''鉛直

        ''01/07/12 追加
        clsEstValue = New clsEstmateValeu

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub


    Public Sub sbCulc()
        ' @(f)
        '
        ' 機能      :ジャッキ操作量の算出
        '
        ' 備考      :自動方向制御の時に一秒ごとに呼び出される

        On Error GoTo ErrTrap




        Dim dblHorKp As Double ''水平P定数
        Dim dblVerKp As Double ''鉛直P定数

        Dim dblHorGp As Double
        Dim dblVerGp As Double

        Dim dblHorGi As Double
        Dim dblVerGi As Double

        ''圧力操作点座標
        Dim dblX As Double
        Dim dblY As Double

        mint制御モードフラグ = 1

        If mblnモーメント制御 Then
            ''モーメント制御
            ''ＰＩＤ演算

            mdblHorHensa = mdblHorHensa + mdbl水平モーメント偏差
            mdblVerHensa = mdblVerHensa + mdbl鉛直モーメント偏差

            ''比例常数→比例帯
            dblHorKp = 100 / mdbl水平モーメントP定数
            dblVerKp = 100 / mdbl鉛直モーメントP定数

            dblHorGp = 1 + (cHorKd / mdbl水平モーメントI定数) * (1 - 1 / cHorDg)
            dblVerGp = 1 + (cVerKd / mdbl鉛直モーメントI定数) * (1 - 1 / cVerDg)

            dblHorGi = cHorDg / mdbl水平モーメントI定数
            dblVerGi = cVerDg / mdbl鉛直モーメントI定数

            dblX = dblHorKp * (dblHorGp * mdbl水平モーメント偏差 + dblHorGi * mdblHorHensa)
            dblY = dblVerKp * (dblVerGp * mdbl鉛直モーメント偏差 + dblVerGi * mdblVerHensa)

            '    Debug.Print "偏差", mdbl水平モーメント偏差, mdbl鉛直モーメント偏差
            ''変化率を制限する
            If System.Math.Abs(dblX - mdblPointX) > 0.1 Then
                dblX = CDbl(IIf(dblX > mdblPointX, mdblPointX + 0.1, mdblPointX - 0.1))
            End If

            If System.Math.Abs(dblY - mdblPointY) > 0.1 Then
                dblY = CDbl(IIf(dblY > mdblPointY, mdblPointY + 0.1, mdblPointY - 0.1))
            End If


        Else

            ''姿勢制御
            ''ＰＩＤ演算

            mdblHorHensa = mdblHorHensa + mdbl水平偏差角
            mdblVerHensa = mdblVerHensa + mdbl鉛直偏差角

            ''比例常数→比例帯
            dblHorKp = 100 / mdbl水平P定数
            dblVerKp = 100 / mdbl鉛直P定数

            dblHorGp = 1 + (cHorKd / mdbl水平I定数) * (1 - 1 / cHorDg)
            dblVerGp = 1 + (cVerKd / mdbl鉛直I定数) * (1 - 1 / cVerDg)

            dblHorGi = cHorDg / mdbl水平I定数
            dblVerGi = cVerDg / mdbl鉛直I定数

            dblX = dblHorKp * (dblHorGp * mdbl水平偏差角 + dblHorGi * mdblHorHensa)
            dblY = dblVerKp * (dblVerGp * mdbl鉛直偏差角 + dblVerGi * mdblVerHensa)

        End If

        mdblRcDash = System.Math.Sqrt(dblX ^ 2 + dblY ^ 2)


        If fnNearZero(dblX) And fnNearZero(dblY) Then
            mdbl操作角 = 0
            'ElseIf fnNearZero(dblX) And dblY > 0 Then '05/06/08 削除　ほんとは270でなく90だと思うが
            '必要ないと思うのでここは削除する
            '           mdbl操作角 = 270
        Else
            If dblX > 0 And dblY >= 0 Then
                mdbl操作角 = System.Math.Atan(dblY / dblX) * 180 / cPI
            ElseIf dblX > 0 And dblY < 0 Then
                mdbl操作角 = System.Math.Atan(dblY / dblX) * 180 / cPI + 360
            Else
                mdbl操作角 = System.Math.Atan(dblY / dblX) * 180 / cPI + 180
            End If
        End If
        '

        clsEstValue.sbCulc() ''予測値の演算

        ''デバッグ用に
        'frmFLEX.ToolTip1.SetToolTip(frmFLEX.pnlKomoku(8), "元圧予測 =" & VB6.Format(clsEstValue.元圧予測, "0#.##"))
        'frmFLEX.ToolTip1.SetToolTip(frmFLEX.pnlKomoku(9), "モーメント予測 =" & VB6.Format(clsEstValue.モーメント予測, "0#"))




        ''制御モードの判定

        'If mbln圧力判定 Then
        '    mbln圧力判定 = (mdblジャッキ圧 < (mdbl圧力許容値 + mdbl作動範囲))
        'Else
        '    mbln圧力判定 = (mdblジャッキ圧 < (mdbl圧力許容値 - mdbl作動範囲))
        'End If

        ''ver 1.1でこのコメントを外す
        If mbln圧力判定 Then
            mbln圧力判定 = (clsEstValue.元圧予測 < (mdbl圧力許容値 + mdbl作動範囲))
        Else
            mbln圧力判定 = (clsEstValue.元圧予測 < (mdbl圧力許容値 - mdbl作動範囲))
        End If
        If Not mbln圧力判定 Then mint制御モードフラグ = 2

        ''半径がある一定値を越えたらロックする。
        ''片押し制限

        ''前回の操作強より強くなったとき
        'If ((Not mbln圧力判定 And mbln片押制御Flg) Or mdbl合成モーメント > mdblモーメント上限) _
        ''                    And mdblRcDash > mdbl操作強 Then

        ''ver 1.1でこのコメントを外す
        'If ((Not mbln圧力判定 And mbln片押制御Flg) Or clsEstValue.モーメント予測 > mdblモーメント上限) _
        'And mdblRcDash > mdbl操作強 Then
        'mblnモーメント上限超 = (clsEstValue.モーメント予測 > mdblモーメント上限 Or mdblRcDash > PlcIf.片押しR制限) And mblnモーメント制御 = False
        mblnモーメント上限超 = (clsEstValue.モーメント予測 > mdblモーメント上限) And mblnモーメント制御 = False
        If mblnモーメント上限超 Then mint制御モードフラグ = 3
        mbln片押しR上限超 = mdblRcDash > ControlParameter.片押しR制限
        If mbln片押しR上限超 Then mint制御モードフラグ = 4


        ''片押制御フラグをすべてに反映
        ''手動→自動トラッキング時は片押しが効かないようにセット
        'If ((Not mbln圧力判定 Or clsEstValue.モーメント予測 > mdblモーメント上限) _
        'And mdblRcDash > mdbl操作強) And mbln片押制御Flg And Not mblnStartTraking Then
        ''モーメント上限超えを変数に
        If ((Not mbln圧力判定 Or モーメント上限超 Or mbln片押しR上限超) And mdblRcDash > mdbl操作強) And mbln片押制御Flg And Not mblnStartTraking Then


            ''圧力調整モード
            '    dblX = mdblRcDash * Cos(mdbl操作角 / 180 * cPI)
            '    dblY = mdblRcDash * Sin(mdbl操作角 / 180 * cPI)
            dblX = mdbl操作強 * System.Math.Cos(mdbl操作角 / 180 * cPI)
            dblY = mdbl操作強 * System.Math.Sin(mdbl操作角 / 180 * cPI)

            If mblnモーメント制御 Then
                mdblHorHensa = 1 / (dblHorKp * dblHorGi) * dblX - dblHorGp / dblHorGi * mdbl水平モーメント偏差
                mdblVerHensa = 1 / (dblVerKp * dblVerGi) * dblY - dblVerGp / dblVerGi * mdbl鉛直モーメント偏差
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
        dblHorKp = 100 / mdbl水平P定数
        dblVerKp = 100 / mdbl鉛直P定数

        dblHorGp = 1 + (cHorKd / mdbl水平I定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (cVerKd / mdbl鉛直I定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / mdbl水平I定数
        dblVerGi = cVerDg / mdbl鉛直I定数

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
        dblHorKp = 100 / mdbl水平モーメントP定数
        dblVerKp = 100 / mdbl鉛直モーメントP定数

        dblHorGp = 1 + (cHorKd / mdbl水平モーメントI定数) * (1 - 1 / cHorDg)
        dblVerGp = 1 + (cVerKd / mdbl鉛直モーメントI定数) * (1 - 1 / cVerDg)

        dblHorGi = cHorDg / mdbl水平モーメントI定数
        dblVerGi = cVerDg / mdbl鉛直モーメントI定数

        mdblHorHensa = 1 / (dblHorKp * dblHorGi) * mdblPointX
        mdblVerHensa = 1 / (dblVerKp * dblVerGi) * mdblPointY

        ''手動→自動トラッキング時は片押しが効かないようにセット
        mblnStartTraking = True


    End Sub
End Class