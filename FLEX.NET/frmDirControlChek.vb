

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

        Me.Height = dgv.Top + dgv.Height + btnClose.Height + 30





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

        lblPointX.Text = PlcIf.PointX.ToString("F5")
        lblPointY.Text = PlcIf.PointY.ToString("F5")


        'lblRealJackPress.Text = PlcIf.JkPress.ToString("F1")
        lblRealJackPress.Text = DivCul.PujMax.ToString("F1")
        lblRealThrustPower.Text = CulcMoment.ThrustOnTime.ToString("F0") '推力
        'lblMomentX.Text = CulcMoment.MomentX.ToString("F0")
        'lblMomentY.Text = CulcMoment.MomentY.ToString("F0")
        lblMomentX.Text = DivCul.MomentX.ToString("F0")
        lblMomentY.Text = DivCul.MomentY.ToString("F0")



        For JkNo As Integer = 0 To InitPara.NumberJack - 1
            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))
            dSet.setData(2, IIf(DivCul.OnJack(JkNo), "1", "0"))
            dSet.setData(3, IIf(DivCul.OnJack(JkNo), "1", "0"))
            '対抗グループ
            If DivCul.OpposeGpLst.Contains(InitPara.JackGroupPos(JkNo)) Then
                dSet.setData(3, "3")
            End If
            '低圧推進
            If CtlPara.optGpEn.Contains(InitPara.JackGroupPos(JkNo)) Then
                dSet.setData(3, "2")
            End If


            dSet.setData(4, DivCul.PjDash(JkNo).ToString("F2"))
            dSet.setData(5, DivCul.Pjmax1(JkNo).ToString("F0"))
            dSet.setData(6, DivCul.Pjmax2(JkNo).ToString("F0"))
            dSet.setData(7, DivCul.Pj1(JkNo).ToString("F0"))
            dSet.setData(8, DivCul.Pj2(JkNo).ToString("F0"))
            dSet.setData(9, DivCul.Puj1(JkNo).ToString("F2"))
            dSet.setData(10, DivCul.Puj2(JkNo).ToString("F2"))


        Next


        txtOpposeGpSv.Text = CtlPara.LosZeroOpposeManualSV

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
    ''' <summary>
    ''' 変更時のセルの編集
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.ColumnIndex = 3 And e.RowIndex <> -1 Then
            Dim cell As DataGridViewCell = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
                cell.Value += 1
            End If
            If (Control.ModifierKeys And Keys.Control) = Keys.Control And cell.Value <> 0 Then
                cell.Value -= 1
            End If



        End If
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

    End Sub
    ''' <summary>
    ''' モーメント最適
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMomentOptimize_Click(sender As Object, e As EventArgs) Handles btnMomentOptimize.Click
        Dim MomentOpt As New clsMomentOptimize
        MomentOpt.Nlp = txtLpMax.Text '繰り返し回数
        MomentOpt.rStep = txtRst.Text '力点変化ステップ
        MomentOpt.Epm = txtMomnetDev.Text 'モーメント偏差許容値
        MomentOpt.InitPointX = lblPointX.Text '力点初期値
        MomentOpt.InitPointY = lblPointY.Text
        MomentOpt.TargetMomentX = lblMomentX.Text '目標モーメント
        MomentOpt.TargetMomentY = lblMomentY.Text
        '対抗ジャッキのリスト
        Dim OpposeJkLst As New List(Of Short)

        For JkNo As Integer = 0 To InitPara.NumberJack - 1
            MomentOpt.DivCul0.OnJack(JkNo) = (dgv.Rows(JkNo).Cells(3).Value <> 0)
            '低圧推進ジャッキ
            If dgv.Rows(JkNo).Cells(3).Value = 2 Then
                MomentOpt.DivCul0.OptinalJack.Add(JkNo + 1, txtLowOptSv.Text)
            End If
            '対抗ジャッキ
            If dgv.Rows(JkNo).Cells(3).Value = 3 Then
                MomentOpt.DivCul0.OptinalJack.Add(JkNo + 1, txtOpposeGpSv.Text)
                'OpposeJkLst.Add(JkNo + 1)
                MomentOpt.DivCul0.OpposeGpLst.Add(JkNo + 1)
            End If
            MomentOpt.DivCul0.OpposeGroupSv = txtOpposeGpSv.Text
        Next


        '対抗ジャッキ自動制御
        If CtlPara.LosZeroOpposeControl Then

            MomentOpt.OpposeSvAutoCulc()    '対抗グループSV自動算出

        Else
            MomentOpt.Optimize() 'モーメント最適化

        End If





        For JkNo As Integer = 0 To InitPara.NumberJack - 1
            Dim dSet As New clsDgvSet(dgv.Rows(JkNo))

            dSet.setData(11, MomentOpt.DivCul0.PjDash(JkNo).ToString("F2"))
            dSet.setData(12, MomentOpt.DivCul0.Pjmax1(JkNo).ToString("F0"))
            dSet.setData(13, MomentOpt.DivCul0.Pjmax2(JkNo).ToString("F0"))
            dSet.setData(14, MomentOpt.DivCul0.Pj1(JkNo).ToString("F0"))
            dSet.setData(15, MomentOpt.DivCul0.Pj2(JkNo).ToString("F0"))
            dSet.setData(16, MomentOpt.DivCul0.Puj1(JkNo).ToString("F2"))
            dSet.setData(17, MomentOpt.DivCul0.Puj2(JkNo).ToString("F2"))


        Next

        lblOptMomentX.Text = MomentOpt.DivCul0.MomentX.ToString("F0")
        lblOptMomentY.Text = MomentOpt.DivCul0.MomentY.ToString("F0")
        lblOptPointX.Text = MomentOpt.CulPointX.ToString("F5")
        lblOptPointY.Text = MomentOpt.CulPointY.ToString("F5")
        lblOptR.Text = MomentOpt.DivCul0.操作強.ToString("F3")
        lblOptTheater.Text = MomentOpt.DivCul0.操作角.ToString("F2")

        lblOptJackPress.Text = MomentOpt.DivCul0.PujMax.ToString("F1")

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

        ''' <summary>
        ''' セルの列の値をリスト形式で取得
        ''' </summary>
        ''' <param name="col"></param>
        ''' <returns></returns>
        Public Function getData(col As Integer) As String
            Return dgvR.Cells(col).Value
        End Function



    End Class














End Class