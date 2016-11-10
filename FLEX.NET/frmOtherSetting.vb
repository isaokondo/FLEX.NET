Public Class frmOtherSetting
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        With CtlParameter
            StartPowerPointPosition.rdbtnValue = .全開グループ制限
            JackCullControl.rdbtnValue = .ジャッキの間引き制御
            ClearanceMeterExist.rdbtnValue = .クリアランス計
        End With

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        With CtlParameter
            'TODO:前回保持のフラグ　未処理
            .全開グループ制限 = StartPowerPointPosition.rdbtnValue
            .ジャッキの間引き制御 = JackCullControl.rdbtnValue
            .クリアランス計 = ClearanceMeterExist.rdbtnValue
        End With


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class