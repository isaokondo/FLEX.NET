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



        OpposeJackExcep.Visible = InitPara.LosZeroEquip 'ロスゼロのときのみ表示
        OpposeJackExcep.rdbtnValue = CtlPara.LosZeroOpposeJackExcept
        DspCenterWidth.Visible = InitPara.LosZeroEquip    'セグメント幅
        DspMaxTaperLoc.Visible = InitPara.LosZeroEquip '最大テーパー位置
        DspTaperValue.Visible = InitPara.LosZeroEquip    'テーパー量
        RectangleShape2.Visible = InitPara.LosZeroEquip

        DspAveStroke.Value = CalcStroke.MesureCalcAveJackStroke '平均ストローク表示


        If pnlStrokeDiffContorol.Visible Then
            'ストロークNo
            lblTopRightStNo.Text &= InitPara.StrokeNoTopRight
            lblTopLefttStNo.Text &= InitPara.StrokeNoTopLeft
            lblHorRightStNo.Text &= InitPara.StrokeNoHorRight
            lblHorLefttStNo.Text &= InitPara.StrokeNoHorLeft
            lblBtmRightStNo.Text &= InitPara.StrokeNoBtmRight
            lblBtmLeftStNo.Text &= InitPara.StrokeNoBtmLeft
        End If





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
            dv.Cells(SegmentWidth.Index).Value = CalcStroke.JackLocSegmentWd(jkNo).ToString("F0")
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
        DspHorTargerNowStrokeDev.Value = StrokeDev.TargetStrokeRealDiff '目標ストローク差
        DspRingUpStroke.Value = StrokeDev.RingUpStroke 'リング内発生ストローク量


        If pnlStrokeDiffContorol.Visible Then
            '上半ｽﾄﾛｰｸ----------------------------------------------------
            '開始ストローク
            If InitPara.StrokeNoTopRight <> 0 And InitPara.StrokeNoTopLeft <> 0 Then
                lblTopRightStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoTopRight) '開始ストローク
                lblTopLeftStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoTopLeft)
                lblTopRightRealSt.Text = StrokeDev.TopRighttStroke '現在のストローク
                lblTopLeftRealSt.Text = StrokeDev.TopLeftStroke
                '推進量
                lblTopNetSt.Text =
                    ((StrokeDev.TopRighttStroke + StrokeDev.TopLeftStroke - lblTopLeftStartSt.Text - lblTopRightStartSt.Text) / 2).ToString("F1")
                lblConvertTopStrokeDiff.Text = -StrokeDev.ConVertTopStrokeDiff.ToString("F1") '換算ストローク差
                lblConvertTopStartStrokeDiff.Text = -StrokeDev.ConVertTopStartStrokeDiff.ToString("F1")
                lblTopRingTargetSt.Text = (StrokeDev.ConVertTopStartStrokeDiff + StrokeDev.RingUpStroke).ToString("F2")

                ' 掘進モード、セグメントモードで背景色を変更
                Call ModeColorSet(lblTopRightStNo, InitPara.StrokeNoTopRight)
                Call ModeColorSet(lblTopLefttStNo, InitPara.StrokeNoTopLeft)


            End If


            '水平部ｽﾄﾛｰｸ----------------------------------------------------
            lblHorRightStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoHorRight)
            lblHorLeftStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoHorLeft)
            lblHorRightRealSt.Text = StrokeDev.HorizonRighttStroke
            lblHorLeftRealSt.Text = StrokeDev.HorizonLefttStroke
            '推進量
            lblHorNetSt.Text =
                ((StrokeDev.HorizonRighttStroke + StrokeDev.HorizonLefttStroke - lblHorLeftStartSt.Text - lblHorRightStartSt.Text) / 2).ToString("F1")
            lblConvertHorStrokeDiff.Text = -StrokeDev.ConVertHorStrokeDiff.ToString("F1")
            lblConvertHorStartStrokeDiff.Text = -StrokeDev.ConVertHorStartStrokeDiff.ToString("F1")
            lblHorRingTargetSt.Text = (StrokeDev.ConVertHorStartStrokeDiff + StrokeDev.RingUpStroke).ToString("F2")
            ' 掘進モード、セグメントモードで背景色を変更
            Call ModeColorSet(lblHorLefttStNo, InitPara.StrokeNoHorLeft)
            Call ModeColorSet(lblHorRightStNo, InitPara.StrokeNoHorRight)

            '下半ｽﾄﾛｰｸ----------------------------------------------------
            If InitPara.StrokeNoBtmRight <> 0 And InitPara.StrokeNoBtmLeft <> 0 Then
                lblBtmRightStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoBtmRight)
                lblBtmLeftStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoBtmLeft)
                lblBtmRightRealSt.Text = StrokeDev.BottomRighttStroke
                lblBtmLeftRealSt.Text = StrokeDev.BottomLefttStroke
                '推進量
                lblBtmNetSt.Text =
                    ((StrokeDev.BottomLefttStroke + StrokeDev.BottomRighttStroke - lblBtmLeftStartSt.Text - lblBtmRightStartSt.Text) / 2).ToString("F1")
                lblConvertBtmStrokeDiff.Text = StrokeDev.ConVertBottomStrokeDiff.ToString("F1")
                lblConvertBtmStartStrokeDiff.Text = StrokeDev.ConVertBottomStartStrokeDiff.ToString("F1")
                lblBtmRingTargetSt.Text = (StrokeDev.ConVertBottomStartStrokeDiff + StrokeDev.RingUpStroke).ToString("F2")
                ' 掘進モード、セグメントモードで背景色を変更
                Call ModeColorSet(lblBtmRightStNo, InitPara.StrokeNoBtmRight)
                Call ModeColorSet(lblBtmLeftStNo, InitPara.StrokeNoBtmLeft)

            End If

        End If

        ' 制御ストロークをハイライト表示
        Dim SelectColor As Color = Color.DodgerBlue
        Dim NotSelectColor As Color = Color.LightGray

        lblHorStItem.BackColor = NotSelectColor
        lblBtmStItem.BackColor = NotSelectColor
        lblTopStItem.BackColor = NotSelectColor

        Select Case StrokeDev.StrokeSelect
            Case clsStrokeDevi.SelectHor
                lblHorStItem.BackColor = Color.DodgerBlue
            Case clsStrokeDevi.SelectBtm
                lblBtmStItem.BackColor = Color.DodgerBlue
            Case clsStrokeDevi.SelectTop
                lblTopStItem.BackColor = Color.DodgerBlue
        End Select





    End Sub
    ''' <summary>
    ''' 掘進モード、セグメントモードで背景色を変更
    ''' </summary>
    ''' <param name="lblSt">背景色を変更するラベル</param>
    ''' <param name="StNo">ジャッキ番号</param>
    Private Sub ModeColorSet(lblSt As Label, StNo As Integer)
        Dim ExecModeColor As Color = Color.Red
        Dim SegModeColor As Color = Color.Cyan

        lblSt.BackColor = If(PlcIf.JackStatus(StNo - 1) And 2, ExecModeColor, SegModeColor)

    End Sub


    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        If InitPara.LosZeroEquip Then
            CtlPara.LosZeroOpposeJackExcept = OpposeJackExcep.rdbtnValue
        End If

    End Sub
End Class