Public Class frmNetStrokeChange
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        CtlPara.TargetNetStroke = NetStrokeEdt.Value
        Me.Close()

    End Sub


    Private Sub frmNetStrokeChange_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim ThisRingSegmentW As Integer, PreRingSegmentW As Integer
        '現リングのセグメント幅
        ThisRingSegmentW = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
        '前リングのセグメント幅
        PreRingSegmentW = SegAsmblyData.TypeData(PlcIf.RingNo - 1).CenterWidth * 1000

        If ThisRingSegmentW <> PreRingSegmentW Then
            lblText.Text =
            $"{PlcIf.RingNo}リングのセグメント幅が{PreRingSegmentW}mmから{ThisRingSegmentW}mmに{vbCrLf}変更になります。{vbCrLf}推進量が異なる場合は、変更してください。"
        Else
            lblText.Text =
           $"{vbCrLf}目標推進量が異なる場合は、変更してください。"
        End If


        NetStrokeEdt.Value = If(CtlPara.TargetNetStroke = 0, ThisRingSegmentW, CtlPara.TargetNetStroke)
    End Sub
End Class