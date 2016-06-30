Public Class frmRinguUpdateSetting
    Private NumEditCon As New Collection
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        With PlcIf.ParameterTag.TagData("掘進判定ストローク")
            StartStokeEdt.MinValue = .EngLow
            StartStokeEdt.MaxValue = .EngHight

            CloseJudgePullStroke.MinValue = .EngLow
            CloseJudgePullStroke.MaxValue = .EngHight

            CloseStokeEdt.MinValue = .EngLow
            CloseStokeEdt.MaxValue = .EngHight

        End With



        With PlcIf
            StrokeManag.Value = .ストローク管理法
            StartStokeEdt.Value = .掘進判定ストローク
            CloseJudgePullStroke.Value = .終了判定引きストローク
            CloseJudgeTime.Value = .終了判定時間
            CloseStokeEdt.Value = .終了判定ストローク
            StopJudgeSpeed.Value = .中断判定速度
        End With

    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With PlcIf
            .掘進判定ストローク = StartStokeEdt.Value
            .終了判定引きストローク = CloseJudgePullStroke.Value
            .終了判定時間 = CloseJudgeTime.Value
            .終了判定ストローク = CloseStokeEdt.Value
            .中断判定速度 = StopJudgeSpeed.Value
        End With

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
End Class