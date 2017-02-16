

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


        dgv.Top = lblRealJackPress.Top + lblRealJackPress.Height + 10
        dgv.ScrollBars = ScrollBars.None
        dgv.RowHeadersVisible = False
        Dim NarrowCell As Integer() = {0, 1, 6}
        For i As Short = 0 To ColumName.Count - 1
            dgv.Columns(i).Width = 70
        Next
        dgv.RowTemplate.Height = 15
        '行数設定
        dgv.RowCount = InitPara.NumberJack

        dgv.Height = InitPara.NumberJack * dgv.RowTemplate.Height + dgv.ColumnHeadersHeight


        For JkNo As Integer = 0 To InitPara.NumberJack - 1

            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))

            dSet.setData(0, JkNo + 1) 'ジャッキ番号
            Dim GpNp As Short = InitPara.JackGroupPos(JkNo)
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

        lblPointX.Text = CtlPara.PointX.ToString("F5")
        lblPointY.Text = CtlPara.PointY.ToString("F5")


        'lblRealJackPress.Text = PlcIf.JkPress.ToString("F1")
        lblRealJackPress.Text = DivCul.PujMax.ToString("F1")
        lblRealThrustPower.Text = CulcMoment.Thrust.ToString("F0") '推力
        'lblMomentX.Text = CulcMoment.MomentX.ToString("F0")
        'lblMomentY.Text = CulcMoment.MomentY.ToString("F0")
        lblMomentX.Text = DivCul.MomentX.ToString("F0")
        lblMomentY.Text = DivCul.MomentY.ToString("F0")



        For JkNo As Integer = 0 To InitPara.NumberJack - 1
            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))
            dSet.setData(2, IIf(DivCul.OnJack(JkNo), 1, 0))

            dSet.setData(4, DivCul.PjDash(JkNo).ToString("F2"))
            dSet.setData(5, DivCul.Pjmax1(JkNo).ToString("F0"))
            dSet.setData(6, DivCul.Pjmax2(JkNo).ToString("F0"))
            dSet.setData(7, DivCul.Pj1(JkNo).ToString("F0"))
            dSet.setData(8, DivCul.Pj2(JkNo).ToString("F0"))
            dSet.setData(9, DivCul.Puj1(JkNo).ToString("F2"))
            dSet.setData(10, DivCul.Puj2(JkNo).ToString("F2"))


        Next




    End Sub
    ''' <summary>
    ''' コラムのセット
    ''' </summary>
    ''' <param name="ColumName"></param>
    Friend Sub SetColum(ColumName As String())
        For Each cName As String In ColumName
            Dim textColumn As New DataGridViewTextBoxColumn
            textColumn.SortMode = DataGridViewColumnSortMode.NotSortable
            textColumn.Name = cName
            textColumn.HeaderText = cName.Replace(" ", vbCrLf)
            textColumn.ReadOnly = False
            dgv.Columns.Add(textColumn)

        Next
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.ColumnIndex = 3 Then
            Dim cell As DataGridViewCell = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If IsNumeric(cell.Value) Then
                cell.Value += 1
            Else
                cell.Value = 1
            End If



        End If
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

    End Sub

    Friend Class clsDgvSet
        Private dgvR As DataGridViewRow
        Public Sub New(r As DataGridViewRow)
            dgvR = r
        End Sub
        Public Sub setData(Col As Integer, DspData As Object)
            Dim Dspformt As String = ""
            If TypeOf DspData Is Double Then
                Dspformt = DirectCast(DspData, Double).ToString("F3")
            End If
            If TypeOf DspData Is Integer Or TypeOf DspData Is Short Then
                Dspformt = DspData.ToString
            End If
            If TypeOf DspData Is String Then
                Dspformt = DirectCast(DspData, String)
            End If
            If IsNumeric(DspData) AndAlso DspData < 0 Then
                dgvR.Cells(Col).Style.ForeColor = Color.Red
            End If

            'ゼロは非表示　ゾーンNo以外
            If TypeOf DspData IsNot String And Col <> 0 AndAlso DspData = 0 Then
                Dspformt = ""
            End If

            dgvR.Cells(Col).Value = Dspformt
        End Sub


    End Class














End Class