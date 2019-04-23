Public Class frmDevImgScaleChange


    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click, btnOK.Click

        My.Settings.DevImgScale = nudHighScale.Value


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnOK.Click
        Me.Close()
    End Sub



    Private Sub frmGraphScaleChange_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        nudHighScale.Value = My.Settings.DevImgScale


    End Sub

End Class