Public Class frmPlanView

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
            dgv.Columns.Add(textColumn)

        Next
    End Sub

    Private Sub dgv_Click(sender As Object, e As EventArgs) Handles dgv.Click

    End Sub

    Protected Overridable Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

    End Sub

    Private Sub frmPlanView_Load(sender As Object, e As EventArgs) Handles Me.Load
        'マイナス表示は赤文字に
        For Each c As Control In Me.Controls
            If (TypeOf c Is Label) AndAlso IsNumeric(DirectCast(c, Label).Text) Then
                If c.Text < 0 Then c.ForeColor = Color.Red
            End If
        Next

        'ゾーンNoの列のみ固定
        'dgv.Columns(0).Frozen = True

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