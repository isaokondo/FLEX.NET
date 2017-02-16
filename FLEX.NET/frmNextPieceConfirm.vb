Public Class frmNextPieceConfirm
    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        PlcIf.LosZeroSts_FLEX = 1 '減圧開始
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class