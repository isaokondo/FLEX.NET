Public Class frmOneWayTunnel
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        With ControlParameter
            HorPID_P.Value = .水平ジャッキ制御P定数
            HorPID_I.Value = .水平ジャッキ制御I定数
            HorPID_D.Value = .水平ジャッキ制御I定数
            VerPID_P.Value = .鉛直ジャッキ制御P定数
            VerPID_I.Value = .鉛直ジャッキ制御I定数
            VerPID_D.Value = .鉛直ジャッキ制御I定数
        End With


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With ControlParameter
            .水平ジャッキ制御P定数 = HorPID_P.Value
            .水平ジャッキ制御I定数 = HorPID_I.Value
            .水平ジャッキ制御I定数 = HorPID_D.Value
            .鉛直ジャッキ制御P定数 = VerPID_P.Value
            .鉛直ジャッキ制御I定数 = VerPID_I.Value
            .鉛直ジャッキ制御I定数 = VerPID_D.Value
        End With


        '    Me.Close()

    End Sub

    Private Sub frmOneWayTunnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class