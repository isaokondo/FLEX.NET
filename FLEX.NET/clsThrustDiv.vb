Option Strict Off
Option Explicit On
Imports System.Math

Friend Class clsThrustDiv
    ' @(h) clsThrustDiv                ver 1.0 ( '01.03.06 近藤　勲 )

    ' @(s)推力分担率の演算
    '
    '

    Private _最低全開グループ数 As Short
    Private _全開作動指令値 As Short
    Private _全開作動範囲 As Short
    Private _全開グループ制限 As Boolean

    Private _操作角 As Double
    Private _操作強 As Double

    Private _分担率指令値(InitPara.NumberGroup - 1) As Double
    Private _分担率計算値(InitPara.NumberGroup - 1) As Double

    Private _PjDash(InitPara.NumberJack - 1) As Double    '各ジャッキの圧力分布率
    Private _Pjmax1(InitPara.NumberJack - 1) As Double    '元圧MAX時の当該ジャッキの推力
    Private _PjMax2(InitPara.NumberJack - 1) As Double
    Private _Pj1(InitPara.NumberJack - 1) As Double 'ｼﾞｬｯｷ推力
    Private _Pj2(InitPara.NumberJack - 1) As Double 'ｼﾞｬｯｷ選択を考慮した時のｼﾞｬｯｷ推力
    Private _Puj1() As Double, _Puj2() As Double 'ｼﾞｬｯｷ圧力
    Private _PujMax As Double   ''計算上のｼﾞｬｯｷ元圧
    Private _MomentX As Double, _MomentY As Double '計算上のモーメント
    Private _OnJack(InitPara.NumberJack - 1) As Boolean  '推進ジャッキ


    Public Property 分担率指令値 As Double()
        Get
            Return _分担率指令値
        End Get
        Set(ByVal Value As Double())
            _分担率指令値 = Value
        End Set
    End Property

    Public Property 分担率計算値 As Double()
        Get
            Return _分担率計算値
        End Get
        Set(ByVal Value As Double())
            _分担率計算値 = Value
        End Set
    End Property


    Public Property 操作強() As Double
        Get
            Return _操作強
        End Get
        Set(ByVal Value As Double)
            _操作強 = Value
        End Set
    End Property

    Public Property 操作角() As Double
        Get
            Return _操作角
        End Get
        Set(ByVal Value As Double)
            _操作角 = Value
        End Set
    End Property

    Public Property 全開グループ制限() As Boolean
        Get
            全開グループ制限 = _全開グループ制限
        End Get
        Set(ByVal Value As Boolean)
            _全開グループ制限 = Value
        End Set
    End Property

    Public Property 全開作動範囲() As Short
        Get
            全開作動範囲 = _全開作動範囲
        End Get
        Set(ByVal Value As Short)
            _全開作動範囲 = Value
        End Set
    End Property

    Public Property 全開作動指令値() As Short
        Get
            全開作動指令値 = _全開作動指令値
        End Get
        Set(ByVal Value As Short)
            _全開作動指令値 = Value
        End Set
    End Property

    Public Property 最低全開グループ数() As Short
        Get
            最低全開グループ数 = _最低全開グループ数
        End Get
        Set(ByVal Value As Short)
            _最低全開グループ数 = Value
        End Set
    End Property

    Public ReadOnly Property PjDash As Double()
        Get
            Return _PjDash
        End Get
    End Property
    ''' <summary>
    ''' '元圧MAX時の当該ジャッキの推力
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Pjmax1 As Double()
        Get
            Return _Pjmax1
        End Get
    End Property
    Public ReadOnly Property Pjmax2 As Double()
        Get
            Return _PjMax2
        End Get
    End Property

    Public ReadOnly Property Pj1 As Double()
        Get
            Return _Pj1
        End Get
    End Property
    Public ReadOnly Property Pj2 As Double()
        Get
            Return _Pj2
        End Get
    End Property


    Public ReadOnly Property Puj1 As Double()
        Get
            Return _Puj1
        End Get
    End Property
    Public ReadOnly Property Puj2 As Double()
        Get
            Return _Puj2
        End Get
    End Property

    Public ReadOnly Property PujMax As Double
        Get
            Return _PujMax
        End Get
    End Property
    Public ReadOnly Property MomentX As Double
        Get
            Return _MomentX
        End Get
    End Property
    Public ReadOnly Property MomentY As Double
        Get
            Return _MomentY
        End Get
    End Property
    ''' <summary>
    ''' 推進ジャッキ
    ''' </summary>
    ''' <returns></returns>
    Public Property OnJack As Boolean()
        Get
            Return _OnJack
        End Get
        Set(value As Boolean())
            _OnJack = value
        End Set
    End Property


    Private Sub Class_Initialize_Renamed()
        ''配列の初期化
        'ReDim _分担率計算値(InitPara.NumberGroup - 1)
        'ReDim _分担率指令値(InitPara.NumberGroup - 1)
        'ReDim _PjDash(InitPara.NumberJack - 1)
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub


    ''' <summary>
    ''' 推力分担率の演算
    ''' </summary>
    Public Sub sbCul()
        ' @(f)
        '
        ' 機能      :推力分担率の計算
        '
        '
        ' 機能説明  :各グループの推力分担率指令値及び計算値をジャッキ操作量より求める
        '
        ' 備考      :

        Dim i As Short

        Dim Ig(InitPara.NumberGroup - 1) As Short    '各グループの有効ジャッキ本数
        'Dim intJg(.NumberGroup - 1) As Short

        '============================= page Ⅲ－２８ ===============================
        For i = 0 To InitPara.NumberGroup - 1
            _分担率計算値(i) = 0
            Ig(i) = 0
        Next i

        ''極座標演算 各ジャッキの推力勾配の値
        For i = 0 To InitPara.NumberJack - 1
            If _操作強 <= 1 Then
                _PjDash(i) = 1 + ((Cos((InitPara.FaiJack(i) - _操作角) * PI / 180) + 1) / 2 - 1) * _操作強
            Else
                _PjDash(i) = ((Cos((InitPara.FaiJack(i) - _操作角) * PI / 180) + 1) / 2) ^ _操作強
            End If
        Next i

        '============================= page Ⅲ－２９ ===============================
        'ジャッキ掘進モード　AND 減圧中でない
        '同時施工のみ
        For i = 0 To InitPara.NumberJack - 1
            '_OnJack(i) = Not PlcIf.LosZeroMode Or (PlcIf.JackExecMode(i) And
            '        Not Reduce.LstR.Contains(InitPara.JackGroupPos(i)))
            If _OnJack(i) Then
                _分担率計算値(InitPara.JackGroupPos(i) - 1) += _PjDash(i)
                Ig(InitPara.JackGroupPos(i) - 1) += 1
            End If
        Next i
        '各グループの有効ジャッキ本数で割る
        For i = 0 To InitPara.NumberGroup - 1
            If Ig(i) <> 0 Then
                _分担率計算値(i) /= Ig(i)
            End If
        Next i

        ''最大値を求める
        Dim PgMax As Double = _分担率計算値.Max

        'mdbl分担率計算値を0-100（百分率)
        If PgMax <> 0 Then
            _分担率計算値 = (From ti In _分担率計算値 Select ti / PgMax * 100).ToArray
        End If
        '============================= page Ⅲ－３０ ===============================
        ''全開調整
        For i = 0 To InitPara.NumberGroup - 1

            If _分担率指令値(i) < 100 Then
                If _分担率計算値(i) > _全開作動指令値 + _全開作動範囲 Then
                    _分担率指令値(i) = 100
                Else
                    _分担率指令値(i) = _分担率計算値(i)
                End If
            Else
                If _分担率計算値(i) > _全開作動指令値 - _全開作動範囲 Then
                    _分担率指令値(i) = 100
                Else
                    _分担率指令値(i) = _分担率計算値(i)
                End If
            End If

        Next i
        'LINQに置き換え　(全開作動指令値 -全開作動範囲)以上は全開
        '_分担率指令値 =
        '_分担率計算値.Select(Function(n) If(n > _全開作動指令値 - _全開作動範囲, 100, n)).ToArray

        '============================= page Ⅲ－３１===============================
        ''全開グループ制御
        'Dim dblWork As Double
        If _全開グループ制限 Then


            Dim buntang As New Dictionary(Of Short, Double)

            For i = 0 To InitPara.NumberGroup - 1
                buntang.Add(i, _分担率計算値(i))
            Next i
            '分担率計算値を降順に並べ変え,最低全開グループ数分の番号を取得
            Dim MaxOrderGp =
                    (From q In buntang Order By q.Value Descending Select q.Key).Take(_最低全開グループ数).ToArray
            '全開にセット
            For Each g In MaxOrderGp
                _分担率指令値(g) = 100
            Next

        End If

        Dim Pj1sum As Double = 0

        '全ジャッキの推力積算（元圧がMAX圧力時）
        For i = 0 To InitPara.NumberJack - 1
            _Pjmax1(i) =
                    InitPara.JackPower * _分担率指令値(InitPara.JackGroupPos(i) - 1) / 100
            Pj1sum += _Pjmax1(i)
            _PjMax2(i) = IIf(_OnJack(i), _Pjmax1(i), 0)
        Next

        '--------------------------------最適化-------------------------------------------------
        Dim Pj2sum As Double
            Dim Pj2sumdash As Double

            Dim j As Integer = 0
            Dim Ep As Single = 0.5 '推力最適化判定（推力の誤差 0.5Mpaに設定）

            Dim P0 As Single = 0 '推力最適化変数（最低値（35Mpaの割合））
            Dim P1 As Single = 10 '推力最適化変数（最高値（35Mpaの割合））350Mpa最大まで対応

        Do
            j += 1

            Dim PC As Double = (P0 + P1) * 0.5 'P0とP1の半分とする
                Dim pujmax As Double = 0    'ジャッキ圧力（元圧）の予測値

            Pj2sum = 0 '選択ジャッキの推力積算（元圧がMAX圧力時）
                Pj2sumdash = 0 '設定圧３により低下した推力

                For i = 0 To InitPara.NumberJack - 1

                    PC = (P0 + P1) * 0.5 'P0とP1の半分とする
                    Pj1(i) = Pjmax1(i) * CulcMoment.Thrust / Pj1sum '全ジャッキ時の当該ジャッキ推力（あんまり意味ないじゃん）
                    Pj2(i) = Pjmax2(i) * PC '選択ジャッキ時の当該ジャッキ推力（低圧推進は考慮しない）

                    ''設定圧１の処理　＜＜以下７行は2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)　修正内容はコメントのみ
                    ''If OnjT(i) = 2 And Pj2(i) > InitPara.JackPower * Lowpu / InitPara.JackMaxOilPres Then
                    'If Onj(i) = 2 And Pj2(i) > InitPara.JackPower * Lowpu / InitPara.JackMaxOilPres Then
                    '    '設定圧１の加減圧ｼﾞｬｯｷとして選択され、さらに当該ジャッキ推力が設定圧１を越えているとき
                    '    Pj2Dash = Pj2(i) - InitPara.JackPower * Lowpu / InitPara.JackMaxOilPres
                    '    Pj2(i) = InitPara.JackPower * Lowpu / InitPara.JackMaxOilPres '当該ジャッキ推力を設定圧１の推力にする
                    '    Pj2sumdash = Pj2sumdash + Pj2Dash '設定圧１の調整による低下推力を積算（不要）
                    'End If

                    ''設定圧２の処理　＜＜以下６行は2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    'If Onj(i) = 3 And Pj2(i) > InitPara.JackPower * Lowpu2 / InitPara.JackMaxOilPres Then
                    '    '設定圧２の加減圧ｼﾞｬｯｷとして選択され、さらに当該ジャッキ推力が設定圧２を越えているとき
                    '    Pj2Dash = Pj2(i) - InitPara.JackPower * Lowpu2 / InitPara.JackMaxOilPres
                    '    Pj2(i) = InitPara.JackPower * Lowpu2 / InitPara.JackMaxOilPres '当該ジャッキ推力を設定圧２の推力にする
                    '    Pj2sumdash = Pj2sumdash + Pj2Dash '設定圧２の調整による低下推力を積算（不要）
                    'End If

                    ''設定圧３の処理　＜＜以下６行は2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    'If Onj(i) = 4 And Pj2(i) > InitPara.JackPower * Lowpu3 / InitPara.JackMaxOilPres Then
                    '    '設定圧３の加減圧ｼﾞｬｯｷとして選択され、さらに当該ジャッキ推力が設定圧３を越えているとき
                    '    Pj2Dash = Pj2(i) - InitPara.JackPower * Lowpu3 / InitPara.JackMaxOilPres
                    '    Pj2(i) = InitPara.JackPower * Lowpu3 / InitPara.JackMaxOilPres '当該ジャッキ推力を設定圧３の推力にする
                    '    Pj2sumdash = Pj2sumdash + Pj2Dash '設定圧３の調整による低下推力を積算（不要）
                    'End If

                    ''最低制御圧力の処理　＜＜以下６行は2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)　＜＜対抗ジャッキ圧力調整機能　2016/01/22
                    'If (Onj(i) = 1 Or Onj(i) = 9) And Pj2(i) < InitPara.JackPower * Minpu / InitPara.JackMaxOilPres Then  '＜＜ここを修正
                    '    '当該ジャッキ推力が最低制御圧力以下のとき
                    '    Pj2Dash = Pj2(i) - InitPara.JackPower * Minpu / InitPara.JackMaxOilPres
                    '    Pj2(i) = InitPara.JackPower * Minpu / InitPara.JackMaxOilPres '当該ジャッキ推力を最低制御圧力の推力にする
                    '    Pj2sumdash = Pj2sumdash + Pj2Dash '最低制御圧力の調整による上昇推力を積算（不要）
                    'End If

                    ''対抗ジャッキ圧自動設定の処理　＜＜以下６行は2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)　＜＜対抗ジャッキ圧力調整機能　2016/01/22
                    'If Ftj = 1 And Onj(i) = 9 And Pj2(i) > InitPara.JackPower * LowpuX / InitPara.JackMaxOilPres Then
                    '    '対抗ジャッキの加減圧ｼﾞｬｯｷとして選択され、さらに当該ジャッキ推力が対抗ジャッキ設定圧を越えているとき
                    '    Pj2Dash = Pj2(i) - InitPara.JackPower * LowpuX / InitPara.JackMaxOilPres
                    '    Pj2(i) = InitPara.JackPower * LowpuX / InitPara.JackMaxOilPres '当該ジャッキ推力を対抗ジャッキ設定圧の推力にする
                    '    Pj2sumdash = Pj2sumdash + Pj2Dash '設定圧３の調整による低下推力を積算（不要）
                    'End If

                Next

                'ｼﾞｬｯｷ圧力の演算
                _Puj1 =
                    _Pj1.Select(Function(n) n / InitPara.JackPower * InitPara.JackMaxOilPres).ToArray
                _Puj2 =
                    _Pj2.Select(Function(n) n / InitPara.JackPower * InitPara.JackMaxOilPres).ToArray

                '推力を積算
                Pj2sum = _Pj2.Sum
                '圧力最大値を検索
                _PujMax = _Puj2.Max


                '最適化処理
                If Pj2sum > CulcMoment.Thrust Then
                    '計算値が大きいとき
                    P1 = PC '最大値にPC代入
                Else
                    '計算値が小さいとき
                    P0 = PC '最小値にPC代入
                End If
            Loop While (j < 100 And Abs(Pj2sum - CulcMoment.Thrust) > Ep)

        'モーメントの演算
        _MomentX = 0
        _MomentY = 0
        For i = 0 To InitPara.NumberJack - 1
            _MomentX -= Pj1(i) * InitPara.JackRadius * Cos(InitPara.FaiJack(i) / 180 * PI)
            _MomentY -= Pj1(i) * InitPara.JackRadius * Sin(InitPara.FaiJack(i) / 180 * PI)
        Next

    End Sub
End Class

''' <summary>
''' 減圧中処理
''' </summary>
Friend Class clsReducePress

    Private _MvOut() As Short
    ''' <summary>
    ''' 1秒ごとの減圧量(%)
    ''' </summary>
    Private ReduceDev() As Short
    ''' <summary>
    ''' 減圧グループ
    ''' </summary>
    Private _LstRd As New List(Of Short)
    ''' <summary>
    ''' 減圧処理タイマ
    ''' </summary>
    Private timer As Timer
    Private tCount As Short = 0

    Public Sub New()
        ReDim _MvOut(InitPara.NumberGroup - 1)
        ReDim ReduceDev(InitPara.NumberGroup - 1)
        timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf Reduce)
        timer.Interval = 1000   '1秒ごとの処理
    End Sub

    ''' <summary>
    ''' 減圧処理　１秒毎
    ''' </summary>
    Public Event ReduceOn()

    ''' <summary>
    ''' 操作出力
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MvOut As Short()
        Get
            Return _MvOut
        End Get
    End Property
    ''' <summary>
    ''' 現在の減圧グループ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LstR As List(Of Short)
        Get
            Return _LstRd
        End Get
    End Property



    ''' <summary>
    ''' 減圧開始
    ''' </summary>
    Public Sub Start()


        '減圧グループ
        _LstRd = SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo).ReduceGroup

        For Each GpNo As Short In _LstRd
            '減圧開始時の操作出力
            _MvOut(GpNo - 1) = PlcIf.GroupMV(GpNo - 1)
            '１秒毎の減圧量を算出
            ReduceDev(GpNo - 1) = _MvOut(GpNo - 1) / CtlParameter.ReduceTime
            If ReduceDev(GpNo - 1) = 0 Then ReduceDev(GpNo - 1) = 1
        Next


        timer.Enabled = True ' timer.Start()と同じ
        tCount = 0
    End Sub
    ''' <summary>
    ''' 減圧処理
    ''' </summary>
    Private Sub Reduce()
        '操作出力0%まで、減圧
        For i As Short = 0 To InitPara.NumberGroup - 1
            _MvOut(i) -= ReduceDev(i)
            If _MvOut(i) < 0 Then _MvOut(i) = 0
        Next
        'Console.WriteLine("MV" & String.Join(",", _MvOut))
        Dim ReduceFlg As Boolean = True
        Dim MvZero As Short = 0
        '5秒間は減圧中フラグを保持
        If tCount < 5 Then
            tCount += 1
        End If
        For Each GpNp As Short In _LstRd
            '減圧判断
            ReduceFlg = ReduceFlg And (PlcIf.GroupPv(GpNp - 1) < CtlParameter.ReduceJudgePress)
            MvZero += _MvOut(GpNp - 1)
        Next
        '減圧完了
        If ReduceFlg And tCount = 5 Then
            PlcIf.LosZeroSts_FLEX = 2
        End If
        '減圧処理停止 MVがすべて０で、減圧判断圧力以下
        If MvZero = 0 And ReduceFlg And tCount = 5 Then
            timer.Stop()
        End If
        '掘進停止時は、減圧完了とする
        If PlcIf.ExcaStatus <> cKussin Then
            PlcIf.LosZeroSts_FLEX = 2
            timer.Stop()
        End If

        RaiseEvent ReduceOn() '減圧処理イベント
    End Sub
    ''' <summary>
    ''' 減圧キャンセル
    ''' </summary>
    Public Sub Cancel()
        timer.Stop()
        _LstRd.Clear()
    End Sub


End Class





