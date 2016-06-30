Option Strict Off
Option Explicit On
Friend Class clsCulMoment
    ' @(h) clsCulMoment.cls               ver 1.0 ( '01.03.29 近藤　勲 )
    ' @(h) clsCulMoment.cls               ver 1.1 ( '01.09.04 近藤　勲 )
    ' @(h) clsCulMoment.cls               ver 1.2 ( '01.09.11 近藤　勲 )
    '   推力演算パラメータを変更
    ' @(s) モーメントを求めるクラス
    '
    '

    Private mbln掘進ステータス As Boolean ''掘進中かどうか？
    Private mdblMomentX As Double ''Ｘ軸方向モーメント
    Private mdblMomentY As Double ''Ｙ軸方向モーメント
    Private mdblMomentR As Double ''合成モーメント
    Private mdblSuiryoku As Double ''推力
    Private msngGpPv() As Single ''グループ圧

    Public WriteOnly Property PressData(ByVal Index As Short) As Single
        Set(ByVal Value As Single)
            ''グループ圧入力
            msngGpPv(Index) = Value
            Call sbCul() ''モーメント、推力の計算
        End Set
    End Property

    Public WriteOnly Property 掘進ステータス() As Boolean
        Set(ByVal Value As Boolean)
            mbln掘進ステータス = Value
            Call sbCul() ''モーメント、推力の計算
        End Set
    End Property
    Public ReadOnly Property MomentX() As Double
        Get
            MomentX = mdblMomentX
        End Get
    End Property
    Public ReadOnly Property MomentY() As Double
        Get
            MomentY = mdblMomentY
        End Get
    End Property
    Public ReadOnly Property MomentR() As Double
        Get
            MomentR = mdblMomentR
        End Get
    End Property
    Public ReadOnly Property 推力() As Double
        Get
            推力 = mdblSuiryoku
        End Get
    End Property




    Private Sub sbCul()
        ' @(f)
        '
        ' 機能      :モーメント、推力の計算
        '
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :
        mdblMomentX = 0
        mdblMomentY = 0
        mdblMomentR = 0

        mdblSuiryoku = 0

        ''掘進中以外は０に
        If Not mbln掘進ステータス Then Exit Sub


        Dim intCnt As Short
        With InitParameter
            For intCnt = 1 To .NumberJack
                If PlcIf.JackSel(intCnt) Then
                    ''水平方向のモーメントの演算    01/09/11 変更
                    mdblMomentX = mdblMomentX + System.Math.Cos(.FaiJack(intCnt) / 180 * cPI) * msngGpPv(.JackGroupPos(intCnt)) / .JackMaxOilPres * .JackPower * .JackRadius
                    ''鉛直方向のモーメントの演算    01/09/11 変更
                    mdblMomentY = mdblMomentY + System.Math.Sin(.FaiJack(intCnt) / 180 * cPI) * msngGpPv(.JackGroupPos(intCnt)) / .JackMaxOilPres * .JackPower * .JackRadius
                    ''推力の演算
                    If PlcIf.FlexControlOn Then

                        '' 01/09/04 変更    神谷部長指摘による
                        mdblSuiryoku = msngGpPv(.JackGroupPos(intCnt)) / .JackMaxOilPres * .JackPower + mdblSuiryoku
                        ' Debug.Print intCnt, mdblSuiryoku
                    Else
                        ''04/05/11 FLEXモードでないときの推力演算追加
                        If PlcIf.JackSel(intCnt) Then mdblSuiryoku = mdblSuiryoku + .JackPower * PlcIf.JkPress / .JackMaxOilPres

                    End If
                End If
            Next intCnt
            '方向を掘削管理のデータと合わせる
            mdblMomentX = -mdblMomentX
            mdblMomentY = -mdblMomentY

        End With
        ''合成値の演算
        mdblMomentR = System.Math.Sqrt(mdblMomentX ^ 2 + mdblMomentY ^ 2)


    End Sub

    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()

        'UPGRADE_WARNING: 配列 msngGpPv の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim msngGpPv(InitParameter.NumberGroup)
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class