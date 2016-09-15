Public Class frmScaleSet
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        With ControlParameter
            nudHorMomentTrendWidth.Value = .HorMomentTrendWidth
            nudVerMomentTrendWidth.Value = .VerMomentTrendWidth
            nudHorDevDegTrendWidth.Value = .HorDevDegTrendWidth
            nudVerDevDegTrendWidth.Value = .VerDevDegTrendWidth
            nudLineDevStartRing.Value = .LineDevStartRing
            nudLineDevLastRing.Value = .LineDevLastRing
            nudPresBarGraphWidt.Value = .PresBarGraphWidt
            nudDevTolerance.Value = .DevTolerance

        End With

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        With ControlParameter
            .HorMomentTrendWidth = nudHorMomentTrendWidth.Value
            .VerMomentTrendWidth = nudVerMomentTrendWidth.Value
            .HorDevDegTrendWidth = nudHorDevDegTrendWidth.Value
            .VerDevDegTrendWidth = nudVerDevDegTrendWidth.Value
            .LineDevStartRing = nudLineDevStartRing.Value
            .LineDevLastRing = nudLineDevLastRing.Value
            .PresBarGraphWidt = nudPresBarGraphWidt.Value
            .DevTolerance = nudDevTolerance.Value
        End With

        'チャートの設定
        With My.Forms.frmMain.ucnHorMomentChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorMomentTrendWidth
        End With
        With My.Forms.frmMain.ucnVerMomentChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorMomentTrendWidth
        End With
        With My.Forms.frmMain.ucnHorDevChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorDevDegTrendWidth
        End With
        With My.Forms.frmMain.ucnVerDevChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorDevDegTrendWidth
        End With

        My.Forms.frmMain.UcnGpPvBarGraph.PresBarGraphWidt = ControlParameter.PresBarGraphWidt

    End Sub
End Class