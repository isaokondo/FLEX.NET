Option Strict Off
Option Explicit On
Friend Class clsThrustDiv
    ' @(h) clsThrustDiv                ver 1.0 ( '01.03.06 近藤　勲 )

    ' @(s)推力分担率の演算
    '
    '

    Private mint最低全開グループ数 As Short
    Private mint全開作動指令値 As Short
    Private mint全開作動範囲 As Short
    Private mbln全開制御フラグ As Boolean
    Private mdbl操作角 As Double
    Private mdbl操作強 As Double

    Private mdbl分担率指令値() As Double
    Private mdbl分担率計算値() As Double

    Private mbln設定値全開調整フラグ As Boolean
    Private mbln最小数全開調整フラグ As Boolean



    Public Property 分担率指令値(ByVal Index As Short) As Double
        Get
            分担率指令値 = mdbl分担率指令値(Index)
        End Get
        Set(ByVal Value As Double)
            mdbl分担率指令値(Index) = Value
        End Set
    End Property

    Public Property 分担率計算値(ByVal Index As Short) As Double
        Get
            分担率計算値 = mdbl分担率計算値(Index)
        End Get
        Set(ByVal Value As Double)
            mdbl分担率計算値(Index) = Value
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

    Public Property 全開制御フラグ() As Boolean
        Get
            全開制御フラグ = mbln全開制御フラグ
        End Get
        Set(ByVal Value As Boolean)
            mbln全開制御フラグ = Value
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


    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()
        ''配列の初期化
        'UPGRADE_WARNING: 配列 mdbl分担率計算値 の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim mdbl分担率計算値(InitParameter.NumberGroup)
        'UPGRADE_WARNING: 配列 mdbl分担率指令値 の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim mdbl分担率指令値(InitParameter.NumberGroup)
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub



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

        Dim intCnt As Short

        Dim intIg() As Short
        Dim intJg() As Short
        Dim dblPj() As Double

        Dim dblPgMax As Double

        'UPGRADE_WARNING: 配列 intIg の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim intIg(InitParameter.NumberGroup)
        'UPGRADE_WARNING: 配列 intJg の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim intJg(InitParameter.NumberGroup)
        'UPGRADE_WARNING: 配列 dblPj の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim dblPj(InitParameter.NumberJack)


        '============================= page Ⅲ－２８ ===============================
        mbln最小数全開調整フラグ = False
        mbln設定値全開調整フラグ = False

        For intCnt = 1 To InitParameter.NumberGroup
            mdbl分担率計算値(intCnt) = 0
            intIg(intCnt) = 0
            intJg(intCnt) = intCnt
        Next intCnt


        ''極座標演算
        For intCnt = 1 To InitParameter.NumberJack
            If mdbl操作強 <= 1 Then
                dblPj(intCnt) = 1 + ((System.Math.Cos((InitParameter.FaiJack(intCnt) - mdbl操作角) * cPI / 180) + 1) / 2 - 1) * mdbl操作強
            Else
                dblPj(intCnt) = ((System.Math.Cos((InitParameter.FaiJack(intCnt) - mdbl操作角) * cPI / 180) + 1) / 2) ^ mdbl操作強
            End If
        Next intCnt

        '============================= page Ⅲ－２９ ===============================

        For intCnt = 1 To InitParameter.NumberJack
            mdbl分担率計算値(InitParameter.JackGroupPos(intCnt)) = mdbl分担率計算値(InitParameter.JackGroupPos(intCnt)) + dblPj(intCnt)
            intIg(InitParameter.JackGroupPos(intCnt)) = intIg(InitParameter.JackGroupPos(intCnt)) + 1
        Next intCnt

        For intCnt = 1 To InitParameter.NumberGroup
            mdbl分担率計算値(intCnt) = mdbl分担率計算値(intCnt) / intIg(intCnt)
        Next intCnt

        ''最大値を求める
        dblPgMax = mdbl分担率計算値(1)

        For intCnt = 2 To InitParameter.NumberGroup
            If mdbl分担率計算値(intCnt) > dblPgMax Then dblPgMax = mdbl分担率計算値(intCnt)
        Next intCnt

        For intCnt = 1 To InitParameter.NumberGroup
            mdbl分担率計算値(intCnt) = mdbl分担率計算値(intCnt) / dblPgMax * 100
        Next intCnt

        '============================= page Ⅲ－３０ ===============================

        ''全開調整
        For intCnt = 1 To InitParameter.NumberGroup

            If mdbl分担率指令値(intCnt) < 100 Then
                If mdbl分担率計算値(intCnt) > mint全開作動指令値 + mint全開作動範囲 Then
                    mdbl分担率指令値(intCnt) = 100
                    mbln設定値全開調整フラグ = True
                Else
                    mdbl分担率指令値(intCnt) = mdbl分担率計算値(intCnt)
                End If
            Else
                If mdbl分担率計算値(intCnt) > mint全開作動指令値 - mint全開作動範囲 Then
                    mdbl分担率指令値(intCnt) = 100
                    mbln設定値全開調整フラグ = True
                Else
                    mdbl分担率指令値(intCnt) = mdbl分担率計算値(intCnt)
                End If
            End If

        Next intCnt

        Dim dblD() As Double
        'UPGRADE_WARNING: 配列 dblD の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim dblD(InitParameter.NumberGroup)

        For intCnt = 1 To InitParameter.NumberGroup
            dblD(intCnt) = mdbl分担率計算値(intCnt)
        Next intCnt


        Dim intCntI, intCntJ As Short
        Dim dblSt As Double
        Dim intSt As Short

        For intCntI = 1 To InitParameter.NumberGroup - 1
            For intCntJ = intCntI + 1 To InitParameter.NumberGroup
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
        If mbln全開制御フラグ Then

            dblWork = 100

            For intCnt = 1 To mint最低全開グループ数
                If mdbl分担率指令値(intJg(intCnt)) <> 100 Then
                    dblWork = mdbl分担率指令値(intJg(intCnt))
                    mdbl分担率指令値(intJg(intCnt)) = 100
                    mbln最小数全開調整フラグ = True
                End If
            Next intCnt

            For intCnt = mint最低全開グループ数 + 1 To InitParameter.NumberGroup
                If mdbl分担率指令値(intJg(intCnt)) = dblWork Then
                    mdbl分担率指令値(intJg(intCnt)) = 100
                End If
            Next intCnt

        End If

    End Sub
End Class