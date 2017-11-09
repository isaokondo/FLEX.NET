Public Class frmLosZeroSetting
    Inherits frmSettingBase

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        LosZeroRollingTake.rdbtnValue = CtlPara.LosZeroRollingTake
        LosZeroOpposeJack.rdbtnValue = CtlPara.LosZeroOpposeJack
        LosZeroOpposeControl.rdbtnValue = CtlPara.LosZeroOpposeControl
        LosZeroOpposeGroupNumber.Value = CtlPara.LosZeroOpposeGroupNumber
        LosZeroOpposeManualSV.Value = CtlPara.LosZeroOpposeManualSV

        NextPieceConfirm.rdbtnValue = CtlPara.NextPieceConfirm

        NextPieceConfirmTime.Value = CtlPara.NextPieceConfirmTime

        ReduceTime.Value = CtlPara.ReduceTime
        ReduceJudgePress.Value = CtlPara.ReduceJudgePress

        LosZeroEmp.Value = CtlPara.LosZeroEmp
        LosZeroNlp.Value = CtlPara.LosZeroNlp
        LoszerorStep.Value = CtlPara.LoszerorStep

        MomentRdductionRateOnReduce.Value = CtlPara.MomentRdductionRateOnReduce
        ReduceReachStrokeDiff.Value = CtlPara.ReduceReachStrokeDiff

        '対抗ジャッキの機能使用可／不可
        LosZeroOpposeJack.Selectable = InitPara.OpposeJackEnable
        LosZeroOpposeControl.Selectable = InitPara.OpposeJackEnable
        LosZeroOpposeGroupNumber.Enabled = InitPara.OpposeJackEnable
        LosZeroOpposeManualSV.Enabled = InitPara.OpposeJackEnable
    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)

        '対抗ジャッキ有効のとき
        If InitPara.OpposeJackEnable Then
            CtlPara.LosZeroRollingTake = LosZeroRollingTake.rdbtnValue
            CtlPara.LosZeroOpposeJack = LosZeroOpposeJack.rdbtnValue
            CtlPara.LosZeroOpposeControl = LosZeroOpposeControl.rdbtnValue
            CtlPara.LosZeroOpposeGroupNumber = LosZeroOpposeGroupNumber.Value
            CtlPara.LosZeroOpposeManualSV = LosZeroOpposeManualSV.Value
        End If

        CtlPara.NextPieceConfirm = NextPieceConfirm.rdbtnValue
        CtlPara.NextPieceConfirmTime = NextPieceConfirmTime.Value

        CtlPara.ReduceTime = ReduceTime.Value
        CtlPara.ReduceJudgePress = ReduceJudgePress.Value

        CtlPara.LosZeroEmp = LosZeroEmp.Value
        CtlPara.LosZeroNlp = LosZeroNlp.Value
        CtlPara.LoszerorStep = LoszerorStep.Value

        CtlPara.MomentRdductionRateOnReduce = MomentRdductionRateOnReduce.Value

        CtlPara.ReduceReachStrokeDiff = ReduceReachStrokeDiff.Value

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class