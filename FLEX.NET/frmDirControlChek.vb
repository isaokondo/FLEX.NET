

Public Class frmDirControlChek
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Dim ColumName As String() =
             {"ｼﾞｬｯｷ №", "ｸﾞﾙｰﾌﾟ№", "開始時", "変更時", "Pjdash(i)", "Pjmax1(I)",
        "分担率P(%)", "	Pj1(I)", "推力前 P(kN)", "puj1(1)", "圧力前 Pu(Mpu)",
        "Pjdash(i)", "Pjmax1(I)", "分担率P (%)", "Pj1(I)", "推力後 P(kN)", "puj1(1)", "圧力後 Pu(Mpu)"}

        SetColum(ColumName)

        dgv.Top -= lblRealJackPress.Top + lblRealJackPress.Height + 10
        dgv.ScrollBars = ScrollBars.None
        dgv.RowHeadersVisible = False
        Dim NarrowCell As Integer() = {0, 1, 6}
        For i As Short = 0 To ColumName.Count - 1
            dgv.Columns(i).Width = 70
        Next

        dgv.RowTemplate.Height = 15
        '行数設定
        dgv.RowCount = InitParameter.NumberJack

        dgv.Height = InitParameter.NumberJack * dgv.RowTemplate.Height + dgv.ColumnHeadersHeight


        For JkNo As Integer = 0 To InitParameter.NumberJack - 1

            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))

            dSet.setData(0, JkNo + 1) 'ジャッキ番号
            Dim GpNp As Short = InitParameter.JackGroupPos(JkNo)
            dSet.setData(1, GpNp) 'グループ番号
            'グループで色分け
            If GpNp Mod 2 = 0 Then
                dgv.Rows(JkNo).DefaultCellStyle.BackColor = Color.AntiqueWhite
            End If

        Next

        Me.Height = dgv.Top + dgv.Height + btnOK.Height + 30

        '現在値取得
        GetNowData()

    End Sub

    Private Sub btnGetNowData_Click(sender As Object, e As EventArgs) Handles btnGetNowData.Click
        '現在値取得
        GetNowData()
    End Sub

    ''' <summary>
    ''' 現在地取得
    ''' </summary>
    Private Sub GetNowData()



        lblR.Text = DivCul.操作強.ToString("F3")
        lblTheater.Text = DivCul.操作角.ToString("F2")

        lblPointX.Text = CtlParameter.PointX.ToString("F3")
        lblPointY.Text = CtlParameter.PointY.ToString("F3")


        lblRealJackPress.Text = PlcIf.JkPress.ToString("F1")
        lblRealThrustPower.Text = CulcMoment.Thrust.ToString("F0") '推力
        lblMomentX.Text = CulcMoment.MomentX.ToString("F0")
        lblMomentY.Text = CulcMoment.MomentY.ToString("F0")



        For JkNo As Integer = 0 To InitParameter.NumberJack - 1
            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))
            dSet.setData(4, DivCul.分担率計算値(InitParameter.JackGroupPos(JkNo) - 1))

        Next




    End Sub

















End Class