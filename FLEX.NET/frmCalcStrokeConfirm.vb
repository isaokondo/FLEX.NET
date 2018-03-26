''' <summary>
''' 計算ストローク確認画面
''' </summary>
Public Class frmCalcStrokeConfirm
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub frmCalcStrokeConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load
        '計測ジャッキ番号でソート
        '計測ジャッキ番号と取付角度を表示
        For Each i In InitPara.MesureJackAngle
            DgvJackStroke.Rows.Add(i.Key, 0, 0, 0, 0, 0, i.Value, "", Not CtlPara.ExceptMesureJackNo.Contains(i.Key))
        Next
        OpposeJackExcep.rdbtnValue = CtlPara.LosZeroOpposeJackExcept
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick, Me.Load
        'リアルタイムに表示
        For Each dv As DataGridViewRow In DgvJackStroke.Rows
            Dim jkNo As Short = dv.Cells(JackNo.Index).Value
            dv.Cells(RealStrokeLen.Index).Value = PlcIf.MesureJackStroke(jkNo) '計測実ストローク
            dv.Cells(CalcLogcalStroke.Index).Value = CalcStroke.MesureCalcLogicalStroke(jkNo)
            dv.Cells(StartStroke.Index).Value = CtlPara.StartJackStroke(jkNo)
            dv.Cells(JackSpeed.Index).Value = PlcIf.MesureJackSpeed(jkNo)    '計測ジャッキスピード
            dv.Cells(CalcStrokeLen.Index).Value = CalcStroke.MesureCalcJackStroke(jkNo)  '計算計測ジャッキストローク
            dv.Cells(JackState.Index).Value = CalcStroke.JackState(jkNo) 'ジャッキステータス
            Select Case CalcStroke.JackState(jkNo)
                Case "掘進モード"
                    dv.DefaultCellStyle.BackColor = Color.LightGreen
                Case "組立完了"
                    dv.DefaultCellStyle.BackColor = Color.LightCyan
                Case "組立中"
                    dv.DefaultCellStyle.BackColor = Color.LightGray
            End Select
        Next


        DspAveStroke.Value = CalcStroke.MesureCalcAveJackStroke '平均ストローク表示
        DspCenterWidth.Value = CalcStroke.SegnebtCenterWidth    'セグメント幅
        DspMaxTaperLoc.Value = CalcStroke.SegmentMaxTaperLoc '最大テーパー位置
        DspTaperValue.Value = CalcStroke.SegmentTaperValue    'テーパー量

        DspAveLogocalStroke.Value = CalcStroke.CalcAveLogicalStroke
        DspAveSpeed.Value = CalcStroke.MesureAveSpeed


    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        CtlPara.LosZeroOpposeJackExcept = OpposeJackExcep.rdbtnValue

    End Sub
End Class