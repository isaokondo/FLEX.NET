﻿Option Strict Off
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

            Dim intIg(.NumberGroup - 1) As Short
            Dim intJg(.NumberGroup - 1) As Short
            Dim dblPj(.NumberJack - 1) As Double

            Dim dblPgMax As Double

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

            For i = 0 To .NumberJack - 1
                mdbl分担率計算値(.JackGroupPos(i) - 1) = mdbl分担率計算値(.JackGroupPos(i) - 1) + dblPj(i)
                intIg(.JackGroupPos(i) - 1) = intIg(.JackGroupPos(i) - 1) + 1
            Next i

            For i = 0 To .NumberGroup - 1
                mdbl分担率計算値(i) = mdbl分担率計算値(i) / intIg(i)
            Next i

            ''最大値を求める

            dblPgMax = mdbl分担率計算値.Max

            For i = 0 To .NumberGroup - 1
                mdbl分担率計算値(i) = mdbl分担率計算値(i) / dblPgMax * 100
            Next i

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

            Dim dblD(.NumberGroup - 1) As Double

            For i = 0 To .NumberGroup - 1
                dblD(i) = mdbl分担率計算値(i)
            Next i


            Dim intCntI, intCntJ As Short
            Dim dblSt As Double
            Dim intSt As Short

            For intCntI = 0 To .NumberGroup - 2
                For intCntJ = intCntI + 1 To .NumberGroup - 1
                    If dblD(intCntJ) > dblD(intCntI) Then
                        dblSt = dblD(intCntI)
                        dblD(intCntI) = dblD(intCntJ)
                        dblD(intCntJ) = dblSt

                        intSt = intJg(intCntI)
                        intJg(intCntI) = intJg(intCntJ)
                        intJg(intCntJ) = intSt
                    End If
                Next intCntJ
            Next intCntI


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

    Private _MvOut(InitParameter.NumberGroup - 1) As Short
    ''' <summary>
    ''' 1秒ごとの減圧量(%)
    ''' </summary>
    Private ReduceDev(InitParameter.NumberGroup - 1) As Short
    ''' <summary>
    ''' 減圧グループ
    ''' </summary>
    Private LstRd As List(Of Short)

    Private timer As Timer
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
    ''' 減圧開始
    ''' </summary>
    Public Sub Start()
        '減圧グループ
        LstRd = SegmentAssembly.SegmentProcessData(PlcIf.AssemblyPieceNo).ReduceGroup

        For Each GpNo As Short In LstRd
            '減圧開始時の操作出力
            _MvOut(GpNo - 1) = PlcIf.GroupMV(GpNo - 1)
            '１秒毎の減圧量を算出
            ReduceDev(GpNo - 1) = _MvOut(GpNo - 1) / ControlParameter.ReduceTime
        Next

        timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf Reduce)
        timer.Interval = 1000   '1秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ

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
        Dim ReduceOn As Boolean = True
        Dim MvZero As Short = 0
        For Each GpNp As Short In LstRd
            '減圧判断
            ReduceOn = ReduceOn And (PlcIf.GroupPv(GpNp - 1) < ControlParameter.ReduceJudgePress)
            MvZero += _MvOut(GpNp - 1)
        Next
        '減圧完了
        If ReduceOn Then
            PlcIf.LosZeroSts_FLEX = 2
        End If
        '減圧処理停止 MVがすべて０で、減圧判断圧力以下
        If MvZero = 0 And ReduceOn Then
            timer.Stop()
        End If

        RaiseEvent ReduceOn() '減圧処理イベント
    End Sub



End Class





