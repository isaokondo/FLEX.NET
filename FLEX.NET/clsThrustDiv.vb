Option Strict Off
Option Explicit On
Imports System.Math

Public Class clsThrustDiv
    ' @(h) clsThrustDiv                ver 1.0 ( '01.03.06 近藤　勲 )

    ' @(s)推力分担率の演算
    '
    '

    Private _最低全開グループ数 As Short
    Private _全開作動指令値 As Short
    Private _全開作動範囲 As Short

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

    Private _FullOpenGruop As List(Of Short) '全開グループ
    ''' <summa_pointy>
    ''' 強制低圧推進および対抗ジャッキ
    ''' </summa_pointy>
    Private _OptinalGroup As New Dictionary(Of Integer, Single)


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


    Public Property 操作強() As Single
        Get
            Return _操作強
        End Get
        Set(ByVal Value As Single)
            _操作強 = Value
        End Set
    End Property

    Public Property 操作角() As Single
        Get
            Return _操作角
        End Get
        Set(ByVal Value As Single)
            _操作角 = Value
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
    ''' <summa_pointy>
    ''' 全開グループ番号リスト
    ''' </summa_pointy>
    ''' <returns></returns>
    Public ReadOnly Property FullOpenGruop As List(Of Short)
        Get
            Return _FullOpenGruop
        End Get
    End Property




    Public ReadOnly Property PjDash As Double()
        Get
            Return _PjDash
        End Get
    End Property
    ''' <summa_pointy>
    ''' '元圧MAX時の当該ジャッキの推力
    ''' </summa_pointy>
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
    ''' <summa_pointy>
    ''' 推進ジャッキ
    ''' </summa_pointy>
    ''' <returns></returns>
    Public Property OnJack As Boolean()
        Get
            Return _OnJack
        End Get
        Set(value As Boolean())
            _OnJack = value
        End Set
    End Property

    ''' <summa_pointy>
    ''' 強制低圧推進および対抗ジャッキ
    ''' </summa_pointy>
    ''' <returns></returns>
    Public Property OptinalGroup As Dictionary(Of Integer, Single)
        Get
            Return _OptinalGroup
        End Get
        Set(value As Dictionary(Of Integer, Single))
            _OptinalGroup = value
        End Set
    End Property


    Public Sub New()
        MyBase.New()
    End Sub


    ''' <summa_pointy>
    ''' 推力分担率の演算
    ''' </summa_pointy>
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

        Dim IgNum(InitPara.NumberGroup - 1) As Short    '各グループのジャッキ本数
        Dim KgNum(InitPara.NumberGroup - 1) As Short    '各グループの有効ジャッキ本数
        'Dim intJg(.NumberGroup - 1) As Short

        '============================= page Ⅲ－２８ ===============================
        For i = 0 To InitPara.NumberGroup - 1
            _分担率計算値(i) = 0
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
            IgNum(InitPara.JackGroupPos(i) - 1) += 1 '各グループのジャッキ本数加算
            'If _OnJack(i) Then
            _分担率計算値(InitPara.JackGroupPos(i) - 1) += _PjDash(i)
                KgNum(InitPara.JackGroupPos(i) - 1) += 1 '各グループの有効ジャッキ本数加算
            'End If
        Next i
        '各グループのジャッキ本数で割る
        For i = 0 To InitPara.NumberGroup - 1
            If IgNum(i) <> 0 Then
                _分担率計算値(i) /= IgNum(i)
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

        Dim buntang As New Dictionary(Of Short, Double)

        For i = 0 To InitPara.NumberGroup - 1
            Dim DisenFullOpn As Boolean = _OptinalGroup.ContainsKey(i + 1) Or KgNum(i) / IgNum(i) < 0.5
            buntang.Add(i, If(DisenFullOpn, 0, _分担率計算値(i)))
        Next i
        '分担率計算値を降順に並べ変え,最低全開グループ数分の番号を取得
        _FullOpenGruop =
                    (From q In buntang Order By q.Value Descending Select q.Key).Take(_最低全開グループ数).ToList
        '分担率　100%も追加
        _FullOpenGruop.AddRange(From q In buntang Where q.Value = 100 Select q.Key)
        '全開にセット
        For Each g In _FullOpenGruop
            _分担率指令値(g) = 100
        Next


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
                '                Pj1(i) = Pjmax1(i) * CulcMoment.Thrust / Pj1sum '全ジャッキ時の当該ジャッキ推力（あんまり意味ないじゃん）
                _Pj1(i) = _Pjmax1(i) * CulcMoment.ThrustOnTime / Pj1sum '全ジャッキ時の当該ジャッキ推力（あんまり意味ないじゃん）
                _Pj2(i) = _PjMax2(i) * PC '選択ジャッキ時の当該ジャッキ推力（低圧推進は考慮しない）

                '任意圧に設定されてるグループのジャッキ
                'If CtlPara.optGpEn.Contains(i + 1) AndAlso
                '    Pj2(i) > InitPara.JackPower * CtlPara.optGpSv(i) / InitPara.JackMaxOilPres Then
                '    '任意圧に設定されてるグループのジャッキ
                If _OptinalGroup.ContainsKey(i + 1) AndAlso
                        Pj2(i) > InitPara.JackPower * _OptinalGroup(i + 1) / InitPara.JackMaxOilPres Then
                    '任意設定圧の加減圧ｼﾞｬｯｷとして選択され、さらに当該ジャッキ推力が設定圧１を越えているとき
                    Dim Pj2Dash As Single =
                        Pj2(i) - InitPara.JackPower * _OptinalGroup(i + 1) / InitPara.JackMaxOilPres
                    Pj2(i) =
                        InitPara.JackPower * _OptinalGroup(i + 1) / InitPara.JackMaxOilPres '当該ジャッキ推力を任意設定圧の推力にする
                    Pj2sumdash += Pj2Dash '任意設定圧の調整による低下推力を積算（不要）
                End If

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
            If Pj2sum > CulcMoment.ThrustOnTime Then
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
            '_MomentX -= Pj1(i) * InitPara.JackRadius * Cos(InitPara.FaiJack(i) / 180 * PI)
            '_MomentY -= Pj1(i) * InitPara.JackRadius * Sin(InitPara.FaiJack(i) / 180 * PI)
            _MomentX -= Pj2(i) * InitPara.JackRadius * Cos(InitPara.FaiJack(i) / 180 * PI)
            _MomentY -= Pj2(i) * InitPara.JackRadius * Sin(InitPara.FaiJack(i) / 180 * PI)
        Next

    End Sub
End Class




''' <summa_pointy>
''' 減圧中処理
''' </summa_pointy>
Friend Class clsReducePress

    Private _MvOut() As Short
    ''' <summa_pointy>
    ''' 1秒ごとの減圧量(%)
    ''' </summa_pointy>
    Private ReduceDev() As Short
    ''' <summa_pointy>
    ''' 減圧グループ
    ''' </summa_pointy>
    Private _LstRd As New List(Of Short)
    ''' <summa_pointy>
    ''' 減圧処理タイマ
    ''' </summa_pointy>
    Private timer As Timer
    Private tCount As Short = 0

    Public Sub New()
        ReDim _MvOut(InitPara.NumberGroup - 1)
        ReDim ReduceDev(InitPara.NumberGroup - 1)
        timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf Reduce)
        timer.Interval = 1000   '1秒ごとの処理
    End Sub

    ''' <summa_pointy>
    ''' 減圧処理　１秒毎
    ''' </summa_pointy>
    Public Event ReduceOn()

    ''' <summa_pointy>
    ''' 操作出力
    ''' </summa_pointy>
    ''' <returns></returns>
    Public ReadOnly Property MvOut As Short()
        Get
            Return _MvOut
        End Get
    End Property
    ''' <summa_pointy>
    ''' 現在の減圧グループ
    ''' </summa_pointy>
    ''' <returns></returns>
    Public ReadOnly Property LstR As List(Of Short)
        Get
            Return _LstRd
        End Get
    End Property



    ''' <summa_pointy>
    ''' 減圧開始
    ''' </summa_pointy>
    Public Sub Start()


        '減圧グループ
        _LstRd = SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo).ReduceGroup

        For Each GpNo As Short In _LstRd
            '減圧開始時の操作出力
            _MvOut(GpNo - 1) = PlcIf.GroupMV(GpNo - 1)
            '１秒毎の減圧量を算出
            ReduceDev(GpNo - 1) = _MvOut(GpNo - 1) / CtlPara.ReduceTime
            If ReduceDev(GpNo - 1) = 0 Then ReduceDev(GpNo - 1) = 1
        Next


        timer.Enabled = True ' timer.Start()と同じ
        tCount = 0
    End Sub
    ''' <summa_pointy>
    ''' 減圧処理
    ''' </summa_pointy>
    Private Sub Reduce()
        '操作出力0%まで、減圧
        For i As Short = 0 To InitPara.NumberGroup - 1
            _MvOut(i) -= ReduceDev(i)
            If _MvOut(i) < 0 Then _MvOut(i) = 0
        Next
        Dim ReduceFlg As Boolean = True
        Dim MvZero As Short = 0
        '5秒間は減圧中フラグを保持
        If tCount < 5 Then
            tCount += 1
        End If
        For Each GpNp As Short In _LstRd
            '減圧判断
            ReduceFlg = ReduceFlg And (PlcIf.GroupPv(GpNp - 1) < CtlPara.ReduceJudgePress)
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
    ''' <summa_pointy>
    ''' 減圧キャンセル
    ''' </summa_pointy>
    Public Sub Cancel()
        timer.Stop()
        _LstRd.Clear()
    End Sub


End Class

''' <summa_pointy>
''' モーメント最適化
''' </summa_pointy>
Public Class clsMomentOptimize
    '目標モーメント
    Private _TargetMomentX As Double, _TargetMomentY As Double
    '力点の初期値
    Private _InitPointX As Double, _InitPointY As Double
    '算出した力点
    Private _CulPointX As Double, _CulPointY As Double
    '力点変化量
    Private _rStep As Single = 0.5
    '規定ループ回数
    Private _Nlp As Integer
    'モーメント偏差許容値
    Private _Epm As Double

    Public DivCul0 As New clsThrustDiv

    ''' <summary>
    ''' 1ループの演算の力点変化量
    ''' </summary>
    ''' <returns></returns>
    Public Property rStep As Single
        Get
            Return _rStep
        End Get
        Set(value As Single)
            _rStep = value
        End Set
    End Property

    ''' <summary>
    ''' 規定ループ回数
    ''' </summary>
    ''' <returns></returns>
    Public Property Nlp As Integer
        Get
            Return _Nlp
        End Get
        Set(value As Integer)
            _Nlp = value
        End Set
    End Property

    ''' <summary>
    ''' モーメント偏差許容値
    ''' </summary>
    ''' <returns></returns>
    Public Property Epm As Double
        Get
            Return _Epm
        End Get
        Set(value As Double)
            _Epm = value
        End Set
    End Property

    ''' <summary>
    ''' 力点の初期値X
    ''' </summary>
    Public WriteOnly Property InitPointX As Double
        Set(value As Double)
            _InitPointX = value
        End Set
    End Property
    ''' <summary>
    ''' 力点の初期値Y
    ''' </summary>
    Public WriteOnly Property InitPointY As Double
        Set(value As Double)
            _InitPointY = value
        End Set
    End Property
    ''' <summary>
    ''' 目標モーメントX
    ''' </summary>
    Public WriteOnly Property TargetMomentX As Double
        Set(value As Double)
            _TargetMomentX = value
        End Set
    End Property
    ''' <summary>
    ''' 目標モーメントY
    ''' </summary>
    Public WriteOnly Property TargetMomentY As Double
        Set(value As Double)
            _TargetMomentY = value
        End Set
    End Property
    ''' <summary>
    ''' 算出した力点X
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CulPointX As Double
        Get
            Return _CulPointX
        End Get
    End Property
    ''' <summary>
    ''' 算出した力点Y
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CulPointY As Double
        Get
            Return _CulPointY
        End Get
    End Property


    Public Sub New()
        'パラメータセット
        DivCul0.最低全開グループ数 = CtlPara.最低全開グループ数
        DivCul0.全開作動指令値 = CtlPara.全開作動指令値
        DivCul0.全開作動範囲 = CtlPara.全開作動範囲

    End Sub


    Public Sub Optimize()


        Dim JkM As New clsXyToRs(_InitPointX, _InitPointY)


        _CulPointX = _InitPointX
        _CulPointY = _InitPointY

        DivCul0.操作角 = JkM.OpTheta
        DivCul0.操作強 = JkM.OpRc
        DivCul0.sbCul()
        'モーメント偏差
        Dim EMx As Double = DivCul0.MomentX - _TargetMomentX
        Dim EMy As Double = DivCul0.MomentY - _TargetMomentY

        Dim FlagS As Short = 0   '算出フラグ　－2:推力調整　－1:元圧上限超　0:計算ループ超過　1:有効
        Dim k As Integer = 0
        Dim kx As Integer = 0
        Dim ky As Integer = 0

        Dim rxdash As Double = _CulPointX
        Dim rydash As Double = _CulPointY
        Dim kxdash As Double = 0
        Dim kydash As Double = 0
        Dim rstx As Single = _rStep
        Dim rsty As Single = _rStep

        Do
            If FlagS <> -2 Then
                '通常処理
                If Abs(EMx) >= Abs(EMy) Then
                    'Xのモーメント偏差のほうが大きい
                    rxdash = _CulPointX '前の値を保存 ＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    kxdash = kx '前の値を保存 ＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    'Xのモーメント偏差がプラスorマイナスで移動
                    _CulPointX += rstx * Sign(EMx)
                    kx += 1
                Else
                    'Yのモーメント偏差のほうが大きい
                    rydash = _CulPointY '前の値を保存 ＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    kydash = ky '前の値を保存 ＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                    'Yのモーメント偏差がプラスorマイナスで移動
                    _CulPointY += rsty * Sign(EMy)
                    ky += 1
                End If
                k += 1
            Else
                '推力低下時の処理（１回戻す）
                _CulPointX = rxdash
                _CulPointY = rydash
                kx = kxdash
                ky = kydash
                k -= 1
            End If
            'XY座標系のｼﾞｬｯｷ操作点を極座標系に変換する
            Dim JkM2 As New clsXyToRs(_CulPointX, _CulPointY)

            'xytors _CulPointX, _CulPointY, rc, sheatc 'XY座標系のｼﾞｬｯｷ操作点を極座標系に変換する
            'Retsu = Retsu + 1
            'Cul_J3 rc, sheatc, Mx, My, pujmax 'ｼﾞｬｯｷ推力を計算してﾓｰﾒﾝﾄ、元圧を計算するルーチン　＜＜設定圧３に関する修正(2003/01/30)
            'xytors Mx, My, Mc, sheatM
            DivCul0.操作角 = JkM2.OpTheta
            DivCul0.操作強 = JkM2.OpRc
            DivCul0.sbCul()



            'Exdash = Mx - Mxp
            'Eydash = My - Myp
            Dim Exdash As Double = DivCul0.MomentX - _TargetMomentX '- MxD 'ﾓｰﾒﾝﾄ偏差（ｘ)　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
            Dim Eydash As Double = DivCul0.MomentY - _TargetMomentY '- MyD 'ﾓｰﾒﾝﾄ偏差（ｙ)　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)

            If EMx * Exdash < 0 Then '符号が反転したら操作点移動ｽﾃｯﾌﾟを1/2
                rstx = rstx / 2
            End If
            If EMy * Eydash < 0 Then
                rsty = rsty / 2
            End If

            EMx = Exdash
            EMy = Eydash



            'Dim Pj2sum As Single = 0 '総推力を計算　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
            'For i = 1 To InitPara.NumberJack
            '    Pj2sum += divCul0.Pj2(i)
            'Next
            Dim Pj2sum As Double = DivCul0.Pj2.Sum '総推力を計算　
            If FlagS = -2 Then '総推力低下を検知したので終了　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                '異常終了（推力低下を検知）
                Exit Do
            End If

            If Abs(EMx) <= _Epm And Abs(EMy) <= _Epm Then 'ﾓｰﾒﾝﾄの偏差が許容値以下になったら終了　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                '正常終了
                FlagS = 1
                Exit Do
            End If

            If k >= _Nlp Then 'ﾙｰﾌﾟ回数が規定回数以上になったら終了　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                '異常終了（ループ回数既定値以上）
                FlagS = 0
                Exit Do
            End If

            'If pujmax >= Limpu Then 'ｼﾞｬｯｷの元圧が規定値以上になったら終了　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
            If DivCul0.PujMax >= CtlPara.圧力許容値 Then 'ｼﾞｬｯｷの元圧が規定値以上になったら終了　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
                '異常終了（元圧が既定値以上）
                FlagS = -1
                Exit Do
            End If

            'If Fp = 1 And Abs(Pj2sum - Nowp) >= 1 Then '総推力ﾁｪｯｸがONで、総推力の規定値との差が1kN以上になったら１回戻し　＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)
            '    FlagS = -2
            'End If

        Loop  '＜＜2ﾋﾟｰｽ目以降計算に関する修正(2005/09/25)




    End Sub

    ''' <summa_pointy>
    ''' XYの座標を極座標系　操作角、操作強に変換
    ''' </summa_pointy>
    Private Class clsXyToRs

        Private _pointX As Double, _pointY As Double 'XY座標
        Private _OpRc As Double, _OpTheta As Double '操作強、操作角
        Public Sub New(px As Double, py As Double)
            _pointX = px
            _pointY = py
            Cul()
        End Sub
        ''' <summary>
        ''' 操作強
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property OpRc As Double
            Get
                Return _OpRc
            End Get
        End Property
        ''' <summary>
        ''' 操作角
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property OpTheta As Double
            Get
                Return _OpTheta
            End Get
        End Property


        Private Sub Cul()
            _OpRc = Math.Sqrt(_pointX ^ 2 + _pointY ^ 2)
            If _pointX = 0 Then
                If _pointY = 0 Then
                    _OpTheta = 0
                    Exit Sub
                Else
                    If _pointY > 0 Then
                        _OpTheta = 90
                        Exit Sub
                    Else
                        _OpTheta = 270
                        Exit Sub
                    End If
                End If
            End If
            If _pointX > 0 Then
                If _pointY = 0 Then
                    _OpTheta = 0
                    Exit Sub
                Else
                    If _pointY > 0 Then
                        _OpTheta = Abs(Math.Atan(_pointY / _pointX) / Math.PI * 180)
                        Exit Sub
                    Else
                        _OpTheta = 360 - Abs(Atan(_pointY / _pointX) / Math.PI * 180)
                        Exit Sub
                    End If
                End If
            End If
            If _pointX < 0 Then
                If _pointY = 0 Then
                    _OpTheta = 180
                    Exit Sub
                Else
                    If _pointY > 0 Then
                        _OpTheta = 180 - Abs(Atan(_pointY / _pointX) / Math.PI * 180)
                        Exit Sub
                    Else
                        _OpTheta = 180 + Abs(Atan(_pointY / _pointX) / Math.PI * 180)
                        Exit Sub
                    End If
                End If
            End If

        End Sub


    End Class





End Class


