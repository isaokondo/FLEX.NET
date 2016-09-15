Public Class frmSettingBase
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmSettingBase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = Color.Gray
    End Sub
End Class