Option Strict Off
Option Explicit On
Imports System.Math

Friend Class clsThrustDiv
    ' @(h) clsThrustDiv                ver 1.0 ( '01.03.06 近藤　勲 )

    ' @(s)推力分担率の演算
    '
    '

    Private mint最低全開グループ数 As Short
    Private mint全開作動指令値 As Short
    Private mint全開作動範囲 As Short
    Private mbln全開グループ制限 As Boolean
    Private mdbl操作角 As Double
    Private mdbl操作強 As Double

    Private mdbl分担率指令値() As Double
    Private mdbl分担率計算値() As Double

    Private mbln設定値全開調整フラグ As Boolean
    Private mbln最小数全開調整フラグ As Boolean



    Public Property 分担率指令値 As Double()
        Get
            Return mdbl分担率指令値
        End Get
        Set(ByVal Value As Double())
            mdbl分担率指令値 = Value
        End Set
    End Property

    Public Property 分担率計算値 As Double()
        Get
            Return mdbl分担率計算値
        End Get
        Set(ByVal Value As Double())
            mdbl分担率計算値 = Value
        End Set
    End Property


    Public Property 操作強() As Double
        Get
            Return mdbl操作強
        End Get
        Set(ByVal Value As Double)
            mdbl操作強 = Value
        End Set
    End Property

    Public Property 操作角() As Double
        Get
            Return mdbl操作角
        End Get
        Set(ByVal Value As Double)
            mdbl操作角 = Value
        End Set
    End Property

    Public Property 全開グループ制限() As Boolean
        Get
            全開グループ制限 = mbln全開グループ制限
        End Get
        Set(ByVal Value As Boolean)
            mbln全開グループ制限 = Value
        End Set
    End Property

    Public Property 全開作動範囲() As Short
        Get
            全開作動範囲 = mint全開作動範囲
        End Get
        Set(ByVal Value As Short)
            mint全開作動範囲 = Value
        End Set
    End Property

    Public Property 全開作動指令値() As Short
        Get
            全開作動指令値 = mint全開作動指令値
        End Get
        Set(ByVal Value As Short)
            mint全開作動指令値 = Value
        End Set
    End Property

    Public Property 最低全開グループ数() As Short
        Get
            最低全開グループ数 = mint最低全開グループ数
        End Get
        Set(ByVal Value As Short)
            mint最低全開グループ数 = Value
        End Set
    End Property

    Public ReadOnly Property 最小数全開調整フラグ() As Boolean
        Get
            最小数全開調整フラグ = mbln最小数全開調整フラグ
        End Get
    End Property

    Private Sub Class_Initialize_Renamed()
        ''配列の初期化
        ReDim mdbl分担率計算値(InitParameter.NumberGroup - 1)
        ReDim mdbl分担率指令値(InitParameter.NumberGroup - 1)
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
        ' 返り値    :なし
        ' 　　　    :
        '
        ' 機能説明  :各グループの推力分担率指令値及び計算値をジャッキ操作量より求める
        '
        ' 備考      :

        Dim i As Short

        With InitParameter

            Dim intIg(.NumberGroup - 1) As Short    '各グループの有効ジャッキ本数
            Dim intJg(.NumberGroup - 1) As Short
            Dim dblPj(.NumberJack - 1) As Double    '各ジャッキの圧力分布率

            '============================= page Ⅲ－２８ ===============================
            mbln最小数全開調整フラグ = False
            mbln設定値全開調整フラグ = False
            For i = 0 To .NumberGroup - 1
                mdbl分担率計算値(i) = 0
                intIg(i) = 0
                intJg(i) = i
            Next i


            ''極座標演算
            For i = 0 To .NumberJack - 1
                If mdbl操作強 <= 1 Then
                    dblPj(i) = 1 + ((Cos((.FaiJack(i) - mdbl操作角) * PI / 180) + 1) / 2 - 1) * mdbl操作強
                Else
                    dblPj(i) = ((Cos((.FaiJack(i) - mdbl操作角) * PI / 180) + 1) / 2) ^ mdbl操作強
                End If
            Next i

            '============================= page Ⅲ－２９ ===============================
            'ジャッキ掘進モード　AND 減圧中でない
            '同時施工のみ
            For i = 0 To .NumberJack - 1
                If Not PlcIf.LosZeroMode Or (PlcIf.JackExecMode(i) And
                    Not Reduce.LstR.Contains(InitParameter.JackGroupPos(i))) Then
                    mdbl分担率計算値(.JackGroupPos(i) - 1) += dblPj(i)
                    intIg(.JackGroupPos(i) - 1) += 1
                End If
            Next i

            For i = 0 To .NumberGroup - 1
                If intIg(i) <> 0 Then
                    mdbl分担率計算値(i) = mdbl分担率計算値(i) / intIg(i)
                End If
            Next i

            ''最大値を求める
            Dim dblPgMax As Double = mdbl分担率計算値.Max

            'mdbl分担率計算値を0-100（百分率)
            If dblPgMax <> 0 Then
                mdbl分担率計算値 = (From ti In mdbl分担率計算値 Select ti / dblPgMax * 100).ToArray
            End If

            '============================= page Ⅲ－３０ ===============================

            ''全開調整
            For i = 0 To .NumberGroup - 1

                If mdbl分担率指令値(i) < 100 Then
                    If mdbl分担率計算値(i) > mint全開作動指令値 + mint全開作動範囲 Then
                        mdbl分担率指令値(i) = 100
                        mbln設定値全開調整フラグ = True
                    Else
                        mdbl分担率指令値(i) = mdbl分担率計算値(i)
                    End If
                Else
                    If mdbl分担率計算値(i) > mint全開作動指令値 - mint全開作動範囲 Then
                        mdbl分担率指令値(i) = 100
                        mbln設定値全開調整フラグ = True
                    Else
                        mdbl分担率指令値(i) = mdbl分担率計算値(i)
                    End If
                End If

            Next i

            Dim dblD() As Double = mdbl分担率計算値.Clone


            Dim buntang As New Dictionary(Of Short, Double)

            For i = 0 To .NumberGroup - 1
                buntang.Add(i, mdbl分担率計算値(i))
            Next i
            '分担率計算値を降順に並べ変え
            Dim ttt = From qqq In buntang Select qqq.Key, qqq.Value Order By Value Descending
            i = 0
            For Each jj In ttt
                intJg(i) = jj.Key
                i += 1
            Next



            'Dim intCntI, intCntJ As Short
            'Dim dblSt As Double
            'Dim intSt As Short

            'For intCntI = 0 To .NumberGroup - 2
            '    For intCntJ = intCntI + 1 To .NumberGroup - 1
            '        If dblD(intCntJ) > dblD(intCntI) Then
            '            dblSt = dblD(intCntI)
            '            dblD(intCntI) = dblD(intCntJ)
            '            dblD(intCntJ) = dblSt

            '            intSt = intJg(intCntI)
            '            intJg(intCntI) = intJg(intCntJ)
            '            intJg(intCntJ) = intSt
            '        End If
            '    Next intCntJ
            'Next intCntI


            '============================= page Ⅲ－３１===============================
            ''全開グループ制御
            Dim dblWork As Double
            If mbln全開グループ制限 Then

                dblWork = 100

                For i = 0 To mint最低全開グループ数 - 1
                    If mdbl分担率指令値(intJg(i)) <> 100 Then
                        dblWork = mdbl分担率指令値(intJg(i))
                        mdbl分担率指令値(intJg(i)) = 100
                        mbln最小数全開調整フラグ = True
                    End If
                Next i

                For i = mint最低全開グループ数 To .NumberGroup - 1
                    If mdbl分担率指令値(intJg(i)) = dblWork Then
                        mdbl分担率指令値(intJg(i)) = 100
                    End If
                Next i

            End If
        End With
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
        ReDim _MvOut(InitParameter.NumberGroup - 1)
        ReDim ReduceDev(InitParameter.NumberGroup - 1)
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
        For i As Short = 0 To InitParameter.NumberGroup - 1
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





