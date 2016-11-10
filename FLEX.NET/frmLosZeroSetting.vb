Public Class frmLosZeroSetting
    Inherits frmSettingBase

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        With CtlParameter
            LosZeroRollingTake.rdbtnValue = .LosZeroRollingTake
            LosZeroOpposeJack.rdbtnValue = .LosZeroOpposeJack
            LosZeroOpposeControl.rdbtnValue = .LosZeroOpposeControl
            NextPieceConfirm.rdbtnValue = .NextPieceConfirm

            ReduceTime.Value = .ReduceTime
            ReduceJudgePress.Value = .ReduceJudgePress


        End With



    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        With CtlParameter

            .LosZeroRollingTake = LosZeroRollingTake.rdbtnValue
            .LosZeroOpposeJack = LosZeroOpposeJack.rdbtnValue
            .LosZeroOpposeControl = LosZeroOpposeControl.rdbtnValue
            .NextPieceConfirm = NextPieceConfirm.rdbtnValue

            .ReduceTime = ReduceTime.Value
            .ReduceJudgePress = ReduceJudgePress.Value
        End With


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class