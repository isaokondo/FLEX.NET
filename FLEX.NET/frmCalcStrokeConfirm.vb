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
        Dim MsJk As IOrderedEnumerable(Of KeyValuePair(Of Short, Single)) = InitParameter.MesureJack.OrderBy(Function(pair) pair.Key)

        '計測ジャッキ番号と取付角度を表示
        For Each i In MsJk
            DgvJackStroke.Rows.Add(i.Key, 0, 0, 0, i.Value)
        Next

        DgvJackStroke.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        For i As Short = 0 To DgvJackStroke.Rows.Count - 1
            Dim JkNo As Short = DgvJackStroke.Rows(i).Cells(JackNo.Index).Value '計測ジャッキ番号
            DgvJackStroke.Rows(i).Cells(RealStrokeLen.Index).Value = PlcIf.MesureJackStroke(JkNo) '計測実ストローク
            DgvJackStroke.Rows(i).Cells(CalcLogcalStroke.Index).Value = CalcStroke.MesureCalcLOgocalStroke(JkNo)
            DgvJackStroke.Rows(i).Cells(StartStroke.Index).Value = CalcStroke.StartMesureStroke(JkNo)
            DgvJackStroke.Rows(i).Cells(JackSpeed.Index).Value = PlcIf.MesureJackSpeed(JkNo)    '計測ジャッキスピード
            DgvJackStroke.Rows(i).Cells(CalcStrokeLen.Index).Value = CalcStroke.MesureCalcJackStroke(JkNo)  '計算計測ジャッキストローク
        Next

        DspAveStroke.Value = CalcStroke.MesureCalcAveJackStroke '平均ストローク表示
        DspCenterWidth.Value = CalcStroke.SegnebtCenterWidth    'セグメント幅
        DspMaxTaperLoc.Value = CalcStroke.SegmentMaxTaperLoc '最大テーパー位置
        DspTaperValue.Value = CalcStroke.SegmentTaperValue    'テーパー量
        DspAveLogocalStroke.Value = CalcStroke.CalcAveLogicalStroke
        DspAveSpeed.Value = CalcStroke.MesureAveSpeed


    End Sub
End Class