Public Class frmOneWayTunnelLimit
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        With CtlPara
            DirectDirectionControl.rdbtnValue = .片押し制限フラグ
            PressPermitValue.Value = .圧力許容値
            MomentPermitValue.Value = .ジャッキモーメント上限値
            OneWayRLimit.Value = .片押しR制限値
            OneReduceValue.Value = .単位当r引き戻し量
            OneReduceTime.Value = .引き戻し実施間隔
        End With


    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        With CtlPara
            .片押し制限フラグ = DirectDirectionControl.rdbtnValue
            .圧力許容値 = PressPermitValue.Value
            .ジャッキモーメント上限値 = MomentPermitValue.Value
            .片押しR制限値 = OneWayRLimit.Value
            .単位当r引き戻し量 = OneReduceValue.Value
            .引き戻し実施間隔 = OneReduceTime.Value
        End With

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub
End Class