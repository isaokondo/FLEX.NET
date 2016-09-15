Public Class frmNextPieceConfirm
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PlcIf.LosZeroSts_FLEX = 1 '減圧開始
    End Sub
End Class