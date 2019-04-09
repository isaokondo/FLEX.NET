Public Class frmMain

    ''掘進ステータス定数
    Public Const cTaiki As Short = 1 ''待機中
    Public Const cKussin As Short = 2 ''掘進中
    Public Const cChudan As Short = 3 ''中断中


    Private WithEvents PlcIf As New clsPlcIf

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub



    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick

        Select Case PlcIf.ExcaStatus
            Case cTaiki
                lblExecStatus.Text = "待機中"
                lblExecStatus.BackColor = Color.Magenta
            Case cKussin
                lblExecStatus.Text = "掘進中"
                lblExecStatus.BackColor = Color.Red
            Case cChudan
                lblExecStatus.Text = "中断中"
                lblExecStatus.BackColor = Color.Yellow
        End Select

        lblNowDate.Text = PlcIf.DataGetTime


    End Sub
End Class
