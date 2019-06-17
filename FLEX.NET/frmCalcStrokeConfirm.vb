﻿''' <summary>
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

        DgvStrokeDev.Rows.Add("上")
        DgvStrokeDev.Rows.Add("水平")
        DgvStrokeDev.Rows.Add("下")



        OpposeJackExcep.Visible = InitPara.LosZeroEquip 'ロスゼロのときのみ表示
        OpposeJackExcep.rdbtnValue = CtlPara.LosZeroOpposeJackExcept
        DspCenterWidth.Visible = InitPara.LosZeroEquip    'セグメント幅
        DspMaxTaperLoc.Visible = InitPara.LosZeroEquip '最大テーパー位置
        DspTaperValue.Visible = InitPara.LosZeroEquip    'テーパー量
        RectangleShape2.Visible = InitPara.LosZeroEquip

        DspAveStroke.Value = CalcStroke.MesureCalcAveJackStroke '平均ストローク表示



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

        If InitPara.LosZeroEquip Then
            DspAveStroke.Value = CalcStroke.MesureCalcAveJackStroke '平均ストローク表示
            DspCenterWidth.Value = CalcStroke.SegnebtCenterWidth    'セグメント幅
            DspMaxTaperLoc.Value = CalcStroke.SegmentMaxTaperLoc '最大テーパー位置
            DspTaperValue.Value = CalcStroke.SegmentTaperValue    'テーパー量
        End If

        DspAveLogocalStroke.Value = CalcStroke.CalcAveLogicalStroke
        DspAveSpeed.Value = CalcStroke.MesureAveSpeed


        DspHorTargerStrokeDev.Value = CtlPara.HorTargerStrokeDev '目標ストローク差
        DspHorTargerNowStrokeDev.Value = StrokeDev.現在目標ストローク差 '目標ストローク差


        DgvStrokeDev.Rows(0).Cells(LeftStroke.Index).Value = StrokeDev.TopLeftStroke
        DgvStrokeDev.Rows(0).Cells(RightStroke.Index).Value = StrokeDev.TopRighttStroke
        DgvStrokeDev.Rows(1).Cells(LeftStroke.Index).Value = StrokeDev.HorizonLefttStroke
        DgvStrokeDev.Rows(1).Cells(RightStroke.Index).Value = StrokeDev.HorizonRighttStroke
        DgvStrokeDev.Rows(2).Cells(LeftStroke.Index).Value = StrokeDev.BottomLefttStroke
        DgvStrokeDev.Rows(2).Cells(RightStroke.Index).Value = StrokeDev.BottomRighttStroke



    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        If InitPara.LosZeroEquip Then
            CtlPara.LosZeroOpposeJackExcept = OpposeJackExcep.rdbtnValue
        End If

    End Sub
End Class