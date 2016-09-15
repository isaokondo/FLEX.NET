Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UcnJackDsp1.JackStatus = {1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        'Call UcnJackDsp1.DspJackStatus()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ジャッキ画面の初期設定
        With UcnJackDsp1
            .FirstJackLoc = InitParameter.FirstJackLoc
            .FaiJack = InitParameter.FaiJack
            .JackGroupPos = InitParameter.JackGroupPos
            .NumberJack = InitParameter.NumberJack
            .NumberGroup = InitParameter.NumberGroup
            Call .DspInitBaseImg()
        End With


    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Call UcnJackDsp1.DspInitBaseImg()

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Call UcnJackDsp1.DspBaseJack()

    End Sub

    Private Sub UcnJackDsp1_Load(sender As Object, e As EventArgs) Handles UcnJackDsp1.Load

    End Sub

    Private Sub UcnJackDsp1_ManualPointChange() Handles UcnJackDsp1.ManualPointChange

    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class