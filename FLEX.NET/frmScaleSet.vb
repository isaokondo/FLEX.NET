Public Class frmScaleSet
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        With CtlPara
            nudHorMomentTrendWidth.Value = .HorMomentTrendWidth
            nudVerMomentTrendWidth.Value = .VerMomentTrendWidth
            nudHorDevDegTrendWidth.Value = .HorDevDegTrendWidth
            nudVerDevDegTrendWidth.Value = .VerDevDegTrendWidth
            nudLineDevStartRing.Value = .LineDevStartRing
            nudLineDevLastRing.Value = .LineDevLastRing
            nudPresBarGraphWidt.Value = .PresBarGraphWidt
            nudDevTolerance.Value = .DevTolerance
            nudHorDevDiffTrendWidth.Value = .HorDevDiffTrendWidth
        End With

    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)

        With CtlPara
            .HorMomentTrendWidth = nudHorMomentTrendWidth.Value
            .VerMomentTrendWidth = nudVerMomentTrendWidth.Value
            .HorDevDegTrendWidth = nudHorDevDegTrendWidth.Value
            .VerDevDegTrendWidth = nudVerDevDegTrendWidth.Value
            .LineDevStartRing = nudLineDevStartRing.Value
            .LineDevLastRing = nudLineDevLastRing.Value
            .PresBarGraphWidt = nudPresBarGraphWidt.Value
            .DevTolerance = nudDevTolerance.Value
            .HorDevDiffTrendWidth = nudHorDevDiffTrendWidth.Value

        End With

        'チャートの設定
        With My.Forms.frmMain.ucnHorMomentChart
            .StrokeWidth = CtlPara.GraphStrokeWidth
            .ChartHighScale = CtlPara.HorMomentTrendWidth
        End With
        With My.Forms.frmMain.ucnVerMomentChart
            .StrokeWidth = CtlPara.GraphStrokeWidth
            .ChartHighScale = CtlPara.VerMomentTrendWidth
        End With
        With My.Forms.frmMain.ucnHorDevChart
            .StrokeWidth = CtlPara.GraphStrokeWidth
            .ChartHighScale = If(CtlPara.horAngleDetection = GyroDetciotn, CtlPara.HorDevDegTrendWidth, CtlPara.HorDevDiffTrendWidth)
        End With
        With My.Forms.frmMain.ucnVerDevChart
            .StrokeWidth = CtlPara.GraphStrokeWidth
            .ChartHighScale = CtlPara.VerDevDegTrendWidth
        End With

        My.Forms.frmMain.UcnGpPvBarGraph.PresBarGraphWidt = CtlPara.PresBarGraphWidt

        Me.Close()

    End Sub
End Class