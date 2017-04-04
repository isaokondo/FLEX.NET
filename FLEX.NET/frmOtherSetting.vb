Public Class frmOtherSetting
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        With CtlPara
            StartPowerPointPosition.rdbtnValue = Not .全押しスタート
            JackCullControl.rdbtnValue = .ジャッキの間引き制御
            ClearanceMeterExist.rdbtnValue = .クリアランス計
        End With

    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)

        With CtlPara
            'TODO:前回保持のフラグ　未処理
            .全押しスタート = Not StartPowerPointPosition.rdbtnValue
            .ジャッキの間引き制御 = JackCullControl.rdbtnValue
            .クリアランス計 = ClearanceMeterExist.rdbtnValue
        End With
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub frmOtherSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class