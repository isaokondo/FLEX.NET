Public Class frmRingNoChange


    Private Sub frmRingNoChange_Load(sender As Object, e As EventArgs) Handles Me.Load
        RingNoEdt.Value = PlcIf.リング番号
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '設定変更を反映
        PlcIf.リング番号 = RingNoEdt.Value
        '画面を閉じる
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '画面を閉じる
        Me.Close()
    End Sub
End Class