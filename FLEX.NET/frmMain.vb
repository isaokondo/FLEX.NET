﻿Class frmMain
    Inherits Windows.Forms.Form
    ''' <summary>
    ''' 姿勢トレンドデータ
    ''' </summary>
    Public Shared DirectionChartD As New DirectionChartData

    Private DspGp() As ucnDspGpPres 'グループ圧PV数値表示用
    Private BlinkFlg As Boolean '点滅フラグ
    ''' <summary>
    ''' イベントログのID
    ''' </summary>
    Private EventID As Long
    ''' <summary>
    ''' バックアップした日付
    ''' </summary>
    Private BackUpDate As Date

    'Private WideUse As New List(Of ucnDspData) '汎用データ表示用
    'Private WideUseDsp() As ucnDspData
    ''' <summary>
    ''' 画面のちらつきをなくす
    ''' </summary>
    ''' <returns></returns>
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            '拡張ウィンドウスタイルにWS_EX_COMPOSITEDを追加する
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        'TODO:My.Forms.frmMainを使うとNewが呼び出される？ので、以下をloadに移動　なぜか？
        'InitParameter = New clsInitParameter '初期値パラメータ
        'ControlParameter = New clsControlParameter  '制御パラメータ

        'HorPlan = New clsHorPanData '平面掘進計画線
        'VerPlan = New clsVerPlanData '縦断掘進計画線

        'MachineSpec = New clsMachinSpec

        'SegmentAssembly = New clsSegmentAssembly ''セグメント組立データ


        'CulcMoment = New clsCulMoment ''モーメント、推力の演算

        'JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        'DivCul = New clsThrustDiv ''
        'RefernceDirection = New clsCulKijun
        'JackManual = New clsJkManualOut

        ''PLCインターフェース
        'PlcIf = New clsPlcIf

        'Reduce = New clsReducePress
        ' NonMsgNet初期化


    End Sub

    Private Sub tmrDataDsp_Tick(sender As Object, e As EventArgs) Handles tmrDataDsp.Tick



        'PLCからの読込表示
        'With PlcIf

        DspMachinComErr.Visible = PlcIf.MachineComErr 'マシン伝送異常
        DspMachinComErr.BitStatus = BlinkFlg

        DspGyiroError.Visible = PlcIf.GyiroError
        DspGyiroError.BitStatus = BlinkFlg
        DspDirection.Blink = PlcIf.GyiroError



        DspRingNo.Text = PlcIf.RingNo 'リングNo


        If InitPara.bottomStrokeEnable Then
            DspBottomRealStroke.Value = CalcStroke.BottomCalcStroke '下ｽﾄﾛｰｸ
            DspBottomRawStroke.Value = PlcIf.BotomStroke '下ｽﾄﾛｰｸ
            DspBottomSpeed.Value = PlcIf.BotomSpeed      '下ｽﾋﾟｰﾄﾞ
        End If

        If InitPara.topStrokeEnable Then
            DspUpRealStroke.Value = CalcStroke.TopCalcStroke      '上ｽﾄﾛｰｸ
            DspUpRawStroke.Value = PlcIf.TopStroke      '上ｽﾄﾛｰｸ
            DspUpSpeed.Value = PlcIf.TopSpeed            '上ｽﾋﾟｰﾄﾞ
        End If


        DspRightRealStroke.Value = CalcStroke.RightCalcStroke '右ｽﾄﾛｰｸ
        DspRightRawStroke.Value = PlcIf.RightStroke '右ｽﾄﾛｰｸ
        DspRightSpeed.Value = PlcIf.RightSpeed       '右ｽﾋﾟｰﾄﾞ

        DspLeftRealStroke.Value = CalcStroke.LeftCalcStroke   '左ｽﾄﾛｰｸ
        DspLeftRawStroke.Value = PlcIf.LeftStroke   '左ｽﾄﾛｰｸ
        DspLeftSpeed.Value = PlcIf.LeftSpeed         '左ｽﾋﾟｰﾄﾞ

        DspJackPress.Value = PlcIf.JkPress           'ジャッキ圧力
        DspPitching.Value = PlcIf.Pitching           'ピッチング
        DspHorBroken.Value = PlcIf.NakaoreLR         '中折左右
        DspVerBroken.Value = PlcIf.NakaoreTB         '中折上下

        'Select Case CtlPara.CopySelect
        '    Case 1
        DspCopyStroke1.Value = PlcIf.CopyStroke1 'コピーストローク
        'Case 2
        If CtlPara.CopyNumber = 2 Then
            DspCopyStroke2.Value = PlcIf.CopyStroke2 'コピーストローク
        Else
            DspCopyStroke2.Visible = False
        End If

        'End Select

        If CtlPara.MachineRearRollingExist And InitPara.LosZeroEquip Then
            DspRealMRRolling.Value = PlcIf.MashineRearRolling  'マシンローリング
            '転送時マシンローリング
            If SegAsmblyData.rollingMindEnable(PlcIf.RingNo) Then
                DspTransMRRolling.Value = SegAsmblyData.MachineRearRolling(PlcIf.RingNo)
                DspChangeMRRolling.Value = PlcIf.rollingChange 'マシンローリング変化量
            Else
                DspTransMRRolling.Text = "---"
                DspChangeMRRolling.Text = "---"
            End If
        End If

        'テールクリアランス
        DspBottomClearance.Value = PlcIf.botomClearance
        DspTopClearance.Value = PlcIf.topClearance
        DspRightClearance.Value = PlcIf.rightClearance
        DspLeftClearance.Value = PlcIf.leftClearance

        DspThrust.Value = CulcMoment.Thrust '推力
        DspMoment.Value = CulcMoment.MomentR 'モーメント
        'FLEXの制御ON/OFF
        DspFlexControlOn.BitStatus = PlcIf.FlexControlOn
        '常時表示に変更
        'UcnJackDsp.FlexOn = PlcIf.FlexControlOn

        '掘進ステータス　掘進中、中断中、待機中
        DspExcavingOn.BitStatus = (PlcIf.ExcaStatus = cKussin)
        DspExcavingStop.BitStatus = (PlcIf.ExcaStatus = cChudan)
        DspExcaWaiting.BitStatus = (PlcIf.ExcaStatus = cTaiki)
        'ジャッキステータス表示
        UcnJackDsp.JackStatus = PlcIf.JackStatus
        'グループ圧PV
        UcnJackDsp.GroupPV = PlcIf.GroupPv
        UcnJackDsp.JackOrgPress = PlcIf.JkPress
        'コピー角度、ストローク
        UcnJackDsp.CopyAngle = PlcIf.CopyAngle1

        UcnJackDsp.CopyCutEnableStroke = CtlPara.CopyCutEnableStroke

        Dim d As New ucnJackDsp.StCopyAgSt
        d.angle = PlcIf.CopyAngle1
        d.Stroke = PlcIf.CopyStroke1

        UcnJackDsp.CopyAngleStroke1 = d

        If CtlPara.CopyNumber = 2 Then
            d.angle = PlcIf.CopyAngle2
            d.Stroke = PlcIf.CopyStroke2

            UcnJackDsp.CopyAngleStroke2 = d


        End If



        'グループ圧バーグラフ
        UcnGpPvBarGraph.GpFlg = PlcIf.GroupFlg
        UcnGpPvBarGraph.GpPv = PlcIf.GroupPv

        '力点座標数値表示
        UcnJackDsp.FlexPointX = PlcIf.PointX
        UcnJackDsp.FlexPointY = PlcIf.PointY

        UcnJackDsp.FlexPointR = PlcIf.操作強
        UcnJackDsp.FlexPointSeater = PlcIf.操作角


        '掘進モード／セグメントモードの表示
        lblMachineMode.Text = If(PlcIf.ExcavMode, "掘進", "セグメント") & "モード"
        lblMachineMode.BackColor = If(PlcIf.ExcavMode, Color.Magenta, Color.Aqua)
        'End With
        If PlcIf.assembleSegFinish Then
            lblMachineMode.BackColor = Color.Yellow
        End If


        UcnJackDsp.MakeBmp()


        DspAveStartStroke.Value = CtlPara.StartAveStroke '平均開始ストローク
        DspAveStroke.Value = CalcStroke.CalcAveLogicalStroke '計算平均ストローク
        DspExcvSpeed.Value = CalcStroke.MesureAveSpeed '計測ジャッキ平均スピード

        '左右のストローク差（ストローク制御とは無関係） 実ストローク
        DspLRRealStrokeDiff.Value = CalcStroke.RightCalcStroke - CalcStroke.LeftCalcStroke 'StrokeDev.ControlStrokeDiff             'ストローク差 '左右ｽﾄﾛｰｸ差
        If Not CtlPara.RightStrokeDiff Then
            DspLRRealStrokeDiff.Value = -DspLRRealStrokeDiff.Value
        End If
        DspLRRealStrokeDiff.FieldName = $"実ｽﾄﾛｰｸ差(mm){If(CtlPara.RightStrokeDiff, "右", "左")}勝"
        '読みストロークの差
        DspLRStrokeDiff.Value = PlcIf.RightStroke - PlcIf.LeftStroke
        If Not CtlPara.RightStrokeDiff Then
            DspLRStrokeDiff.Value = -DspLRStrokeDiff.Value
        End If
        DspLRStrokeDiff.FieldName = $"ｽﾄﾛｰｸ差(mm){If(CtlPara.RightStrokeDiff, "右", "左")}勝"

        If DspUDStrokeDiff.Visible Then
            If DspUDRealStrokeDiff.Visible Then
                '上下のストローク差（ストローク制御とは無関係） 実ストローク
                DspUDRealStrokeDiff.Value = CalcStroke.TopCalcStroke - CalcStroke.BottomCalcStroke 'StrokeDev.ControlStrokeDiff             'ストローク差 '左右ｽﾄﾛｰｸ差
                DspUDRealStrokeDiff.FieldName = "実ｽﾄﾛｰｸ差(mm)上勝"
            End If
            '読みストロークの差
            DspUDStrokeDiff.Value = PlcIf.TopStroke - PlcIf.BotomStroke
            DspUDStrokeDiff.FieldName = "ｽﾄﾛｰｸ差(mm)上勝"

        End If





        '汎用データ表示
        For Each wu In CtlPara.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If dd.FieldName <> "" Then
                dd.Value = PlcIf.EngValue(dd.FieldName)
            Else
                dd.Value = "-------"
            End If
        Next

        With CtlPara
            UcnJackDsp.SemiAuto = .SemiAuto
            '自動方向制御ON／OFF
            UcnJackDsp.FlexAutoManual = .AutoDirectionControl
            DspFlexAuto.BitStatus = .AutoDirectionControl
        End With

        '圧力調整用フラグ
        DspJackPress.Blink = JackMvAuto.圧力超
        DspMoment.Blink = JackMvAuto.モーメント上限超
        UcnJackDsp.PointRLimitOver = JackMvAuto.片押しR上限超

        Select Case CtlPara.horAngleDetection

            Case GyroDetciotn
                DspHorDev.Blink = RefernceDirection.HorDevLimitOver
                DspHorDev.FieldName = "水平偏角"
                DspHorDev.Unit = "deg"
                DspHorDev.DecimalPlaces = 2

                DspDirection.Blink = PlcIf.GyiroError
                DspDirection.FieldName = "方位角"
                DspDirection.Value = PlcIf.Gyro              '方位角
                DspRingTargetDir.FieldName = "リング目標方向角"
                DspRingTargetDir.DecimalPlaces = 2

                DspTargetDirection.FieldName = "目標方位角"

                ucnHorLineChart.Visible = True

                pnlStrokeDiffContorol.Visible = False

                DspFlexHorControl.FieldName = "ジャイロ"

                '

            Case StrokeDiffDetciotn
                DspHorDev.Blink = False
                DspHorDev.FieldName = "ｽﾄﾛｰｸ差偏差"
                DspHorDev.Unit = "mm"
                DspHorDev.DecimalPlaces = 1
                DspDirection.FieldName = "ｽﾄﾛｰｸ差"
                DspDirection.Blink = False
                DspDirection.Value = StrokeDev.ControlStrokeDiff             'ストローク差
                DspTargetDirection.FieldName = "目標ストローク差"

                DspRingTargetDir.FieldName = "目標ｽﾄﾛｰｸ差"
                DspRingTargetDir.DecimalPlaces = 0
                DspRingTargetDir.Value = CtlPara.HorTargerStrokeDev '目標ストローク差
                DspRingTargetDir.ToolTipText = $"目標達成ストローク{CtlPara.TargetAchStroke}(mm)"
                DspTargetDirection.ToolTipText = DspRingTargetDir.ToolTipText
                ucnHorLineChart.Visible = False

                pnlStrokeDiffContorol.Visible = True
                Call DspStrokeDiffControlInfo()
                DspFlexHorControl.FieldName = "ｽﾄﾛｰｸ差"

        End Select


        ucnHorDevChart.FieldName = DspHorDev.FieldName & "(" & DspHorDev.Unit & ")"
        ucnHorDevChart.DecimalPlaces = DspHorDev.DecimalPlaces
        '水平チャートのスケール
        ucnHorDevChart.ChartHighScale =
            If(CtlPara.horAngleDetection = GyroDetciotn, CtlPara.HorDevDegTrendWidth, CtlPara.HorDevDiffTrendWidth)


        ucnHorDevChart2.ChartHighScale = CtlPara.HorDevDegTrendWidth



        DspDirection.Unit = DspHorDev.Unit
        DspDirection.DecimalPlaces = DspHorDev.DecimalPlaces

        DspRingTargetDir.Unit = DspHorDev.Unit

        DspTargetDirection.Unit = DspHorDev.Unit


        DspVerDev.Blink = RefernceDirection.VerDevLimitOver

        DspClockwiseMargin.Blink = PlcIf.rollingClockWiseOver
        DspAntiClockwiseMargin.Blink = PlcIf.rollingAntiClockWiseOver



        'チャートの更新
        If PlcIf.ExcaStatus = cKussin Then
            'ﾓｰﾒﾝﾄ
            ucnHorMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentX)
            ucnVerMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentY)
            If CtlPara.horAngleDetection = GyroDetciotn Then
                ucnHorDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.平面偏角)
            Else
                ucnHorDevChart.ChartDataAdd(PlcIf.RealStroke, StrokeDev.StrokeDiffDeflection)
            End If


            ucnHorDevChart2.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.平面偏角)
            ucnVerDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.縦断偏角)
        End If

        '計測ジャッキ更新数
        If InitPara.LosZeroEquip Then
            MeasuerJPullNum.Value = $"{CalcStroke.MesuerJPullNum}／{InitPara.MesureJackAngle.Count - CtlPara.ExceptMesureJackNo.Count}"
            MeasuerJPullNum.Blink = CalcStroke.AllMesJackUp
        End If


        '同時施工用
        ucnLosZeroMode.BitStatus = PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        ucnLosZeroMode.Blink = Not PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        '対抗ジャッキ
        UcnOpposeJackControl.BitStatus = CtlPara.LosZeroOpposeControl
        UcnOpposeJackSelect.BitStatus = CtlPara.LosZeroOpposeJack

        If Not PlcIf.LosZeroEnable Then btnLoszeroContinu.Enabled = False

        '同時施工ピース確認ボタンブリンク
        btnPieceConfirm.Enabled = ucnLosZeroMode.Blink
        If btnPieceConfirm.Enabled Then
            btnPieceConfirm.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
        End If
        '同時施工キャンセルボタン有効／無効
        btnLossZerooCancel.Enabled = ucnLosZeroMode.BitStatus

        '組立ピース番号
        If ucnLosZeroMode.BitStatus Then
            ucnAssemblyPieceNo.FieldName = PlcIf.AssemblyPieceNo & "ピース目"
        Else
            ucnAssemblyPieceNo.FieldName = "-------"
        End If

        '減圧中
        ucnReduceFinish.Blink = (LosZeroSts = 1)
        '減圧完了
        ucnReduceFinish.BitStatus = (LosZeroSts >= 2)
        '引戻し中
        ucnPullBackFinish.Blink = (LosZeroSts = 3)
        '引戻完了
        ucnPullBackFinish.BitStatus = (LosZeroSts >= 4)
        '組立中
        ucnAssemblyFinish.Blink = (LosZeroSts = 5)
        '組立完了
        ucnAssemblyFinish.BitStatus = (LosZeroSts >= 6)

        If ucnReduceFinish.Blink Then
            ucnReduceFinish.FieldName = "減圧中"
        Else
            ucnReduceFinish.FieldName = "減圧完了"
        End If

        '減圧中から組立中は次ピース確認ボタン無効
        If (LosZeroSts >= 1 And LosZeroSts <= 5) Or Not PlcIf.LosZeroMode Then
            btnLoszeroContinu.Enabled = False
        End If
        If btnLoszeroContinu.Enabled Then
            btnLoszeroContinu.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
        End If


        btnNoOpJk.Text = If(PlcIf.NoOpJackOn, "不動作ｼﾞｬｯｷON", "全ｼﾞｬｯｷ推進")
        'btnNoOpJk.Enabled = PlcIf.LosZeroEnable


        If ucnPullBackFinish.Blink Then
            ucnPullBackFinish.FieldName = "引戻し中"
        Else
            ucnPullBackFinish.FieldName = "引戻完了"
        End If


        If ucnAssemblyFinish.Blink Then
            ucnAssemblyFinish.FieldName = "組立中"
        Else
            ucnAssemblyFinish.FieldName = "組立完了"
        End If

        '点滅用フラグ
        BlinkFlg = Not BlinkFlg
        'ロスゼロ工程表示
        For Each cControl As Control In pnlLosZero.Controls
            If TypeOf cControl Is ucnDspBit Then
                Dim u As ucnDspBit = DirectCast(cControl, ucnDspBit)
                If u.Blink Then
                    u.BitStatus = BlinkFlg
                End If
            End If
        Next

        DspSegmentW.Value = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
        DspTargetNetStroke.Value = If(CtlPara.TargetNetStroke = 0, DspSegmentW.Value, CtlPara.TargetNetStroke)


        '経過時間の表示
        DspExcationElapsedTime.Value = ElapsedTime.ExcavationTime
        DspLosZeroElapsedTime.Value = ElapsedTime.LozeroExcavationTime
        DspWatingElapsedTime.Value = ElapsedTime.WatingTime
        DspInterruptTime.Value = ElapsedTime.InterruptTime
        'DspIterruptTime.Value == ElapsedTime.InterruptTime
        'DspCycleTime.Value = ElapsedTime.CycleTime
        'モニターモードの時はデータベースより
        If InitPara.MonitorMode Then
            lblNowDate.Text = PlcIf.DataGetTime.ToString("yyyy/MM/dd HH:mm:ss")
        Else
            lblNowDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        End If

        '同時施工実績表示
        If InitPara.LosZeroEquip Then
            DspAveAsmPiece.Value = LosZeroPerform.AveAsmPiece
            DspSumAsmPiece.Value = LosZeroPerform.SumAsmPiece
            DspAveLoszeroTime.Value = LosZeroPerform.AveLoszeroTime
            DspSumLoszeroTime.Value = LosZeroPerform.SumLoszeroTime

            If SegAsmblyData.rollingMindEnable(PlcIf.RingNo) Then
                '反時計端余裕度 表示のみマイナス
                DspAntiClockwiseMargin.Value = -(SegAsmblyData.AntiClockWiseSegMargin(PlcIf.RingNo) - PlcIf.rollingChange)
                DspClockwiseMargin.Value = SegAsmblyData.ClockWiseSegMargin(PlcIf.RingNo) - PlcIf.rollingChange '時計端余裕度
                DspSegmentRolling.Value = SegAsmblyData.SegmentRolling(PlcIf.RingNo) ' - PlcIf.rollingChange
            Else
                DspAntiClockwiseMargin.Value = "-" '反時計端余裕度
                DspClockwiseMargin.Value = "-" '時計端余裕度
                DspSegmentRolling.Value = "-"

            End If


        End If


        '定期バックアップの実行
        If InitPara.ServerMode AndAlso Date.Compare(DateTime.Now.Date, BackUpDate.Date) <> 0 AndAlso
            TimeSpan.Parse(DateTime.Now.ToLongTimeString).TotalMinutes = InitPara.BackUpTime.TotalMinutes Then
            BackUpDate = DateTime.Now
            Dim DailyBackup = New clsDBBackUp
            DailyBackup.DailyBackup()
        End If

        'TODO:線形データ画面更新　LineDistanceChage に記述したい
        'Call LineDataUpdate()

        EventlogUpdate()

        'リング更新ボタンの表示、点滅
        If PlcIf.ExcaStatus = cTaiki Or PlcIf.assembleSegFinish Then
            btnRingUpdate.Visible = False
        End If
        If btnRingUpdate.Visible Then
            btnRingUpdate.BackColor = If(BlinkFlg, Color.GreenYellow, Color.DarkGray)
        End If


        '全計測ｼﾞｬｯｷ引戻のメッセージを20秒で消去
        Dim MsgCap As String = "全計測ｼﾞｬｯｷ引戻"
        Static MsgCapPtTm As Integer '表示経過時間
        If WindowsExist(MsgCap) Then
            If MsgCapPtTm > 20 Then
                WindowsClose(MsgCap)
            Else
                MsgCapPtTm += 1
            End If
        Else
            MsgCapPtTm = 0
        End If



    End Sub



    ''' <summary>
    ''' 偏角、モーメントのチャート初期化
    ''' 待機中から掘進中の時に実行
    ''' </summary>
    Public Sub ChartClear()
        ucnHorMomentChart.ChartList.Clear()
        ucnVerMomentChart.ChartList.Clear()
        ucnHorDevChart.ChartList.Clear()
        ucnVerDevChart.ChartList.Clear()
        ucnHorDevChart2.ChartList.Clear()
    End Sub

    ''' <summary>
    ''' ストローク差制御　情報表示
    ''' </summary>
    Private Sub DspStrokeDiffControlInfo()
        '上半ｽﾄﾛｰｸ----------------------------------------------------
        '開始ストローク
        If InitPara.StrokeNoTopRight <> 0 And InitPara.StrokeNoTopLeft <> 0 Then
            lblTopRightStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoTopRight) '開始ストローク
            lblTopLeftStartSt.Text = CtlPara.StartJackStroke(InitPara.StrokeNoTopLeft)
            lblTopRightRealSt.Text = StrokeDev.TopRighttStroke '現在のストローク
            lblTopLeftRealSt.Text = StrokeDev.TopLeftStroke
            '推進量
            lblTopNetSt.Text =
                If(StrokeDev.TopStrokeControlEnable, ((StrokeDev.TopRighttStroke + StrokeDev.TopLeftStroke - lblTopLeftStartSt.Text - lblTopRightStartSt.Text) / 2).ToString("F1"), "-----")
            lblConvertTopStrokeDiff.Text = If(StrokeDev.TopStrokeControlEnable, -StrokeDev.ConVertTopStrokeDiff.ToString("F1"), "------") '換算ストローク差
            lblConvertTopStartStrokeDiff.Text = -StrokeDev.ConVertTopStartStrokeDiff.ToString("F1")
            lblTopRingTargetSt.Text = (-(StrokeDev.ConVertTopStartStrokeDiff + StrokeDev.RingUpStroke)).ToString("F2")

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
                If(StrokeDev.HorStrokeControlEnable, ((StrokeDev.HorizonRighttStroke + StrokeDev.HorizonLefttStroke - lblHorLeftStartSt.Text - lblHorRightStartSt.Text) / 2).ToString("F1"), "------")
        lblConvertHorStrokeDiff.Text = If(StrokeDev.HorStrokeControlEnable, -StrokeDev.ConVertHorStrokeDiff.ToString("F1"), "------")
        lblConvertHorStartStrokeDiff.Text = -StrokeDev.ConVertHorStartStrokeDiff.ToString("F1")
        lblHorRingTargetSt.Text = (-(StrokeDev.ConVertHorStartStrokeDiff + StrokeDev.RingUpStroke)).ToString("F2")
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
                      If(StrokeDev.BtmStrokeControlEnable, ((StrokeDev.BottomLefttStroke + StrokeDev.BottomRighttStroke - lblBtmLeftStartSt.Text - lblBtmRightStartSt.Text) / 2).ToString("F1"), "-----")
            lblConvertBtmStrokeDiff.Text = If(StrokeDev.BtmStrokeControlEnable, -StrokeDev.ConVertBottomStrokeDiff.ToString("F1"), "----")
            lblConvertBtmStartStrokeDiff.Text = -StrokeDev.ConVertBottomStartStrokeDiff.ToString("F1")
            lblBtmRingTargetSt.Text = (-(StrokeDev.ConVertBottomStartStrokeDiff + StrokeDev.RingUpStroke)).ToString("F2")
            ' 掘進モード、セグメントモードで背景色を変更
            Call ModeColorSet(lblBtmRightStNo, InitPara.StrokeNoBtmRight)
            Call ModeColorSet(lblBtmLeftStNo, InitPara.StrokeNoBtmLeft)

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
        Dim ExecModeColor As Color = Color.Magenta
        Dim SegModeColor As Color = Color.Aqua

        lblSt.BackColor = If(PlcIf.JackStatus(StNo - 1) And 2, ExecModeColor, SegModeColor)

    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MYSQLのバージョン取得
        clsDataBase.GetMySQKVersion()


        'インスタンス作成
        InitPara = New clsInitParameter '初期値パラメータ
        CtlPara = New clsControlParameter  '制御パラメータ
        HorPlan = New clsHorPanData '平面掘進計画線
        Dim Kant As New clsLineMake
        Kant.CulcZoneKant()

        VerPlan = New clsVerPlanData '縦断掘進計画線
        MachineSpec = New clsMachinSpec
        SegAsmblyData = New clsSegmentAssembly ''セグメント組立データ
        DataSave = New clsDataSave 'データ保存
        CulcMoment = New clsCulMoment ''モーメント、推力の演算
        JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        DivCul = New clsThrustDiv ''推力分担
        RefernceDirection = New clsCulKijun '基準方位演算
        PlcIf = New clsPlcIf 'PLCインターフェース
        CalcStroke = New clsCalcuStroke   'ロスゼロ時の計算ストローク
        JackManual = New clsJkManualOut 'ジャッキ手動操作出力
        Reduce = New clsReducePress 'ロスゼロ減圧処理
        TableUpdateConfirm = New clsTableUpdateConfirm    'テーブル更新によるパラメータ再取得

        StrokeDev = New clsStrokeDevi

        CalcStroke.MesureJackStroke = PlcIf.MesureJackStroke
        CalcStroke.CalcAveLogicalStroke = PlcIf.RealStroke
        'CalcStroke.MesureCalcAveJackStroke = PlcIf.MesureCalcAveJackStroke '平均ジャッキストロークのセット

        'TODO:画面ナロータイプを作成したい
        'If InitPara.DisplayNarrowMode Then
        '    Me.WindowState = FormWindowState.Normal
        '    Me.Size = New Size(1280, 1078)
        'End If
        JackMvAuto.PointX = PlcIf.PointX
        JackMvAuto.PointY = PlcIf.PointY
        JackMvAuto.水平P定数 = CtlPara.水平ジャッキ制御P定数
        JackMvAuto.水平I定数 = CtlPara.水平ジャッキ制御I定数
        JackMvAuto.水平D定数 = CtlPara.水平ジャッキ制御D定数
        JackMvAuto.鉛直P定数 = CtlPara.鉛直ジャッキ制御P定数
        JackMvAuto.鉛直I定数 = CtlPara.鉛直ジャッキ制御I定数
        JackMvAuto.鉛直D定数 = CtlPara.鉛直ジャッキ制御D定数

        'ストローク差制御の制御ストロークNoの表示
        lblTopRightStNo.Text &= InitPara.StrokeNoTopRight
        lblTopLefttStNo.Text &= InitPara.StrokeNoTopLeft
        lblHorRightStNo.Text &= InitPara.StrokeNoHorRight
        lblHorLefttStNo.Text &= InitPara.StrokeNoHorLeft
        lblBtmRightStNo.Text &= InitPara.StrokeNoBtmRight
        lblBtmLeftStNo.Text &= InitPara.StrokeNoBtmLeft


        '管理方法の有効無効
        ManagmentMethd.Enabled = InitPara.StrokeDiffControlEnable



    End Sub
    ''' <summary>
    ''' 汎用データ表示項目セット
    ''' </summary>
    Public Sub WideDataFldSet()
        For Each wu In CtlPara.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If wu.Value <> "" Then
                If PlcIf.AnalogTag.TagExist(wu.Value) Then
                    dd.FieldName = wu.Value
                    dd.Unit = PlcIf.AnalogTag.TagData(wu.Value).Unit
                    dd.DecimalPlaces = PlcIf.AnalogTag.TagData(wu.Value).DigitLoc
                End If
            End If
        Next

    End Sub

    Private Function getExcecStartTime() As Date
        Dim db As New clsDataBase
        Dim tb As DataTable =
             db.GetDtfmSQL($"SELECT 時間 FROM flex掘削データ 
            WHERE リング番号='{PlcIf.RingNo}' ORDER BY 時間  LIMIT 0,1")
        If tb.Rows.Count = 0 Then
            Return DateTime.Now
        Else
            Return tb.Rows(0).Item(0)
        End If

    End Function


    ''' <summary>
    ''' 線形データ画面更新
    ''' </summary>
    Public Sub LineDataUpdate()
        With RefernceDirection
            '中心の総距離
            DspDistance.Value = .HorZendoKijun.掘進累積距離 - .toStartDistance
            '平面線形データ
            If .HorZendoKijun.平面線形 = 1 Then
                DspHorLine.Value = "-------"
            Else
                DspHorLine.Value = .HorZendoKijun.軌道中心平面半径
            End If

            DspHorFChangePoint.Value = .HorZendoKijun.平面ゾーン内残距離
            DspHorRChangePoint.Value = .HorZendoKijun.平面ゾーン掘進距離
            If CtlPara.horAngleDetection = GyroDetciotn Then
                DspHorDev.Value = .平面偏角
                DspTargetDirection.Value = .平面基準方位
                DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.平面計画方位) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
                UcnDspDevImg.HorDev = .平面偏角

            End If

            ucnHorLineChart.PlanNumData = .平面計画方位




            '縦断線形データ
            If .VerZendoKijun.縦断線形 = 1 Then
                DspVerLine.Value = "-------"
            Else
                DspVerLine.Value = .VerZendoKijun.縦断半径

            End If
            DspVerFChangePoint.Value = .VerZendoKijun.縦断ゾーン内残距離
            DspVerRChangePoint.Value = .VerZendoKijun.縦断ゾーン内掘進距離
            DspTargetPitching.Value = .縦断基準方位
            DspVerDev.Value = .縦断偏角

            ucnVerLineChart.PlanNumData = .縦断計画方位

            UcnDspDevImg.VerDev = .縦断偏角




        End With

        'ストローク差制御
        If CtlPara.horAngleDetection = StrokeDiffDetciotn Then
            DspHorDev.Value = StrokeDev.StrokeDiffDeflection
            DspTargetDirection.Value = StrokeDev.TargetStrokeRealDiff '目標ストローク差
            UcnDspDevImg.HorDev = StrokeDev.ConvertHorDeflection

        End If


        '姿勢角トレンドトレンド　データセット
        ucnHorLineChart.PlanData = DirectionChartD.HorPData
        ucnHorLineChart.ExecData = DirectionChartD.HorRData
        ucnHorLineChart.CorrectData = CtlPara.水平入力補正値
        ucnHorLineChart.TargetData = DspTargetDirection.Value
        ucnHorLineChart.RealData = DspDirection.Value


        ucnVerLineChart.PlanData = DirectionChartD.VerPData
        ucnVerLineChart.ExecData = DirectionChartD.VerRData
        ucnVerLineChart.CorrectData = CtlPara.鉛直入力補正値
        ucnVerLineChart.TargetData = DspTargetPitching.Value
        ucnVerLineChart.RealData = DspPitching.Value

        'DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.軌道中心方位角) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
    End Sub
    ''' <summary>
    ''' 同時施工組立パターン情報表示
    ''' </summary>
    Public Sub SegmentDataDsp()
        '組立パターン

        If Not InitPara.LosZeroEquip Then Exit Sub


        lblTransfer.Text = If(SegAsmblyData.TransferFmSim, "転送済", "未転送")
        lblTransfer.BackColor = If(SegAsmblyData.TransferFmSim, Color.Yellow, Color.Cyan)


        'Dim p As Short = 0
        If PlcIf.AssemblyPieceNo <= 0 Then PlcIf.AssemblyPieceNo = 1

        DspTypeName.Value = SegAsmblyData.TypeData(PlcIf.RingNo).TypeName 'セグメント種類
        DspAssemblyPattern.Value = SegAsmblyData.AssemblyPtnName(PlcIf.RingNo) '組立パターン名

        If PlcIf.AnalogTag.TagExist("ｾｸﾞﾒﾝﾄの種類信号") And InitPara.ServerMode Then
            PlcIf.AnalogPlcWrite("ｾｸﾞﾒﾝﾄの種類信号", SegAsmblyData.TypeData(PlcIf.RingNo).TypeNameID) 'セグメント種類
        End If

        If SegAsmblyData.ProcessData.Count <> 0 Then





            With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                'TODO:組立セグメント、組立ﾎﾞﾙﾄﾋﾟｯﾁの取込
                DspBoltPitch.Value = .BoltPitch '組立ボルトピッチ
                DspAssemblyPieace.Value = .PieceName  '組立ピース名称
                DspPullBackJack.Value = SegAsmblyData.JackListDsp(.PullBackJack) '引戻しジャッキ
                DspClosetJack.Value = SegAsmblyData.JackListDsp(.ClosetJack) '押込みジャッキ
                DspClosetThrustJack.Value = SegAsmblyData.JackListDsp(.ClosetThrustJack) '押込み推進ジャッキ
                DspAddClosetThrustJack.Value = SegAsmblyData.JackListDsp(.AddClosetJack) '追加押込みジャッキ




                If PlcIf.AnalogTag.TagExist("甲乙表示用信号") And InitPara.ServerMode Then
                    PlcIf.AnalogPlcWrite("甲乙表示用信号", .PatternKouOtuID)
                End If

            End With


        Else
            DspBoltPitch.Value = "-" '組立ボルトピッチ
            DspAssemblyPieace.Value = "-----"  '組立ピース名称
            DspPullBackJack.Value = "-" '引戻しジャッキ
            DspClosetJack.Value = "-" '押込みジャッキ
            DspAddClosetThrustJack.Value = "-" '追加押込みジャッキ


        End If
        'MAXのピース番号内で表示
        If SegAsmblyData.AssemblyPlanPieceNumber > PlcIf.AssemblyPieceNo AndAlso SegAsmblyData.ProcessData.Count <> 0 Then
            DspNextPieceName.Value =
            SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo + 1).PieceName '組立次ピース名称
        Else
            DspNextPieceName.Value = "-------"
        End If
        '全ピース　名称表示
        UcnJackDsp.PieceAngle.Clear()
        UcnJackDsp.PieceCenterAngle.Clear()
        UcnJackDsp.PieceName.Clear()
        UcnJackDsp.AssemblyOrder.Clear()

        For Each pca As clsSegmentAssembly.AsseblyProcess
                                        In SegAsmblyData.ProcessData.Values
            UcnJackDsp.PieceName.Add(pca.PieceName)
            UcnJackDsp.PieceAngle.Add(pca.PieceAngle)
            UcnJackDsp.PieceCenterAngle.Add(pca.PieceCenterAngle)
            UcnJackDsp.AssemblyOrder.Add(pca.AssemblyOrder)

            '同時施工モード時のみ　同時施工に関係なしに
            'If PlcIf.LosZeroMode Then
            'TODO:ローリングの考慮なし　マシンメーカーへ出力
            '天を０度で時計回りに
            If PlcIf.AnalogTag.TagExist(pca.AssemblyOrder & "ピースセグメント位置角度") Then
                Dim angle As Single
                angle = 90 - pca.PieceCenterAngle
                If angle < 0 Then angle += 360
                If InitPara.ServerMode Then
                    PlcIf.AnalogPlcWrite(pca.AssemblyOrder & "ピースセグメント位置角度", angle)
                End If
            End If

            'End If


        Next
        UcnJackDsp.AssemblyPieceNo = PlcIf.AssemblyPieceNo

        UcnJackDsp.SegmentPieceDsp() 'ｾｸﾞﾒﾝﾄピース表示



    End Sub



    ''' <summary>
    ''' リング番号変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoChange_Click(sender As Object, e As EventArgs) Handles RingNoChange.Click, DspRingNo.Click
        frmRingNoChange.Show()
    End Sub


    ''' <summary>
    ''' リング更新設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoUpdate_Click(sender As Object, e As EventArgs) Handles RingNoUpdateSetting.Click,
        DspAveStartStroke.DoubleClick, DspAveStroke.DoubleClick, DspExcvSpeed.DoubleClick
        frmRinguUpdateSetting.Show()
    End Sub

    Private Sub OperationRight_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitialSetting_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportOut_Click(sender As Object, e As EventArgs) Handles ReportOut.Click
        '帳票出力
        frmReportOut.Show()

    End Sub

    Private Sub ExcavEnforceStart_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStart.Click

    End Sub

    Private Sub ExcavEnforceStop_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStop.Click

    End Sub

    Private Sub SystemEnd_Click(sender As Object, e As EventArgs) Handles SystemEnd.Click
        If MessageBox.Show("FLEXシステムを終了します。", "FLEX", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
            Me.Close()
        End If

    End Sub

    Private Sub DspSetting_Click(sender As Object, e As EventArgs) Handles DspSetting.Click
        My.Forms.frmDspSetting.Show()
    End Sub

    Private Sub ScaleSetting_Click(sender As Object, e As EventArgs) Handles ScaleSetting.Click
        My.Forms.frmScaleSet.Show()
    End Sub

    Private Sub PressParameter_Click(sender As Object, e As EventArgs) Handles PressParameter.Click
        My.Forms.frmPressParameterSet.Show()
    End Sub
    ''' <summary>
    ''' 片押しパラメータ　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OneDirectionParameter_Click(sender As Object, e As EventArgs) Handles OneDirectionParameter.Click
        My.Forms.frmOneWayTunnel.Show()
    End Sub
    ''' <summary>
    ''' 片押し制限パラメータ　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OneDirectionLimit_Click(sender As Object, e As EventArgs) Handles OneDirectionLimit.Click
        My.Forms.frmOneWayTunnelLimit.Show()
    End Sub
    ''' <summary>
    ''' 圧力ブロック　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PresBlock_Click(sender As Object, e As EventArgs) Handles PresBlock.Click
        My.Forms.frmPressBlock.Show()
    End Sub
    ''' <summary>
    ''' 管理方法
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ManagmentMethd_Click(sender As Object, e As EventArgs) Handles ManagmentMethd.Click, DspFlexHorControl.DoubleClick
        My.Forms.frmManagmentMethd.Show()
    End Sub

    Private Sub LossZeroConcern_Click(sender As Object, e As EventArgs) Handles LossZeroConcern.Click
        My.Forms.frmLosZeroSetting.Show()

    End Sub
    ''' <summary>
    ''' その他の設定サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OterSetting_Click(sender As Object, e As EventArgs) Handles OterSetting.Click
        My.Forms.frmOtherSetting.Show()
    End Sub

    Private Sub ReloadPlanData_Click(sender As Object, e As EventArgs) Handles PlanDataView.Click
        My.Forms.frmHorPlanData.Show()
    End Sub

    Private Sub SegmentEdit_Click(sender As Object, e As EventArgs) Handles SegmentEdit.Click, DspSegmentW.DoubleClick
        My.Forms.frmSegmentEdit.Show()

    End Sub
    ''' <summary>
    ''' セグメント組立の編集
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AssemblyProcessEdit_Click(sender As Object, e As EventArgs) Handles AssemblyProcessEdit.Click, DspTypeName.DoubleClick,
        DspAssemblyPattern.DoubleClick, DspAssemblyPieace.DoubleClick, DspPullBackJack.DoubleClick,
        DspClosetJack.DoubleClick, DspClosetThrustJack.DoubleClick, DspAddClosetThrustJack.DoubleClick, DspNextPieceName.DoubleClick
        If InitPara.LosZeroEquip Then
            My.Forms.frmAssemblyProcessEdit.Show()
        End If

    End Sub
    ''' <summary>
    ''' 補正値管理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CorrectionValMng_Click(sender As Object, e As EventArgs) Handles CorrectionValMng.Click, DspTargetDirection.DoubleClick,
        DspTargetPitching.DoubleClick, DspHorFChangePoint.DoubleClick, DspDistance.DoubleClick, DspHorLine.DoubleClick, DspHorFChangePoint.DoubleClick,
        DspHorRChangePoint.DoubleClick, DspVerLine.DoubleClick, DspVerFChangePoint.DoubleClick, DspVerRChangePoint.DoubleClick

        frmCorrectionValueManagement.Show()

    End Sub

    Private Sub RingCloseValueMng_Click(sender As Object, e As EventArgs) Handles RingCloseValueMng.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Call UcnJackDsp.DspBaseJack()
    End Sub
    ''' <summary>
    ''' ポイント座標が入力され演算完了したイベント
    ''' </summary>
    Private Sub UcnJackDsp_ManualPointChange() Handles UcnJackDsp.ManualPointChange
        PlcIf.PointX = UcnJackDsp.FlexPointX
        PlcIf.PointY = UcnJackDsp.FlexPointY

        'JackManual.PutPointXY(PlcIf.PointX, PlcIf.PointY)

        PlcIf.PointWrite()

        '自動方向制御でも力点の操作が可能とする
        If CtlPara.AutoDirectionControl Then
            JackMvAuto.MvAutoStop()
            JackMvAuto.PointX = PlcIf.PointX
            JackMvAuto.PointY = PlcIf.PointY
            JackMvAuto.sbMnToAutTracking()
            ''自動演算開始
            JackMvAuto.MvAutoStart()



        End If


    End Sub
    ''' <summary>
    ''' 掘進強制終了、強制開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExcavingStatusEnfoce(sender As Object, e As EventArgs) Handles ExcavEnforceStart.Click, ExcavEnforceStop.Click
        Dim MsgText As String = ""
        Select Case sender.Name
            Case "ExcavEnforceStart"
                MsgText = "掘進強制開始"
            Case "ExcavEnforceStop"
                MsgText = "掘進強制終了"
        End Select

        If MessageBox.Show($"{MsgText}よろしいですか?", MsgText, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = MsgBoxResult.Ok Then
            PlcIf.DigtalPlcWrite(MsgText, True) 'PLC書込
            WriteEventData(MsgText & "されました。", Color.BlueViolet)
        End If

    End Sub

    Private Sub TuningMonitorClicｋ_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.Click
        If (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
            My.Forms.frmTuningTrend.Show() 'シフトキーが押されてたときは、チューニングトレンド画面を出す
        ElseIf (Control.ModifierKeys And Keys.Control) = Keys.Control Then
            My.Forms.frmDirControlChek.Show() 'コントロールキーが押されてたときは、姿勢制御確認画面を出す
        Else

            My.Forms.frmTuningMonitor.Show()
            My.Forms.frmTuningMonitor.TopMost = True
        End If
    End Sub

    Private Sub TuningTrend_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.DoubleClick

    End Sub



    ''' <summary>
    ''' FLEX自動方向制御ON/OFF
    ''' </summary>
    Private Sub UcnJackDsp_FlexAutoManualChange() Handles UcnJackDsp.FlexAutoManualChange
        CtlPara.AutoDirectionControl = Not CtlPara.AutoDirectionControl
    End Sub
    ''' <summary>
    ''' イベントログ更新
    ''' </summary>
    Private Sub EventlogUpdate()
        '最新のIDを比較
        Dim DB As New clsDataBase
        Dim tbEvID As DataTable = DB.GetDtfmSQL _
            ($"SELECT ID FROM FLEXイベントデータ 
             ORDER BY ID DESC LIMIT 0,1")
        'IDが更新されてれば表示更
        If tbEvID.Rows.Count <> 0 Then
            If EventID <> tbEvID.Rows(0).Item(0) Then
                rtbEventLog.Clear()
                Dim tb As DataTable = DB.GetDtfmSQL _
            ($"SELECT TIME,イベントデータ,イベント種類 FROM FLEXイベントデータ 
            WHERE イベント種類 <> '{ColorTranslator.ToOle(Color.White)}' ORDER BY TIME DESC LIMIT 0,50")

                For Each t As DataRow In tb.Rows
                    rtbEventLog.SelectionColor =
                ColorTranslator.FromOle(t.Item(2))
                    rtbEventLog.AppendText(CDate(t.Item(0)).ToString("yyyy/MM/dd HH:mm:ss") & Space(2) & t.Item(1).ToString & vbCrLf)

                Next

            End If
            EventID = tbEvID.Rows(0).Item(0)
        End If

    End Sub
    ''' <summary>
    ''' 掘進開始日時表示
    ''' </summary>
    Public Sub DspExcavStartDay(t As Date)
        DspExcavStartDate.Value = t.ToString("yyyy/MM/dd")
        DspExcavStartTime.Value = t.ToString("HH:mm:ss")
    End Sub


    Private Sub UcnJackDsp_Load(sender As Object, e As EventArgs) Handles UcnJackDsp.Load

    End Sub

    Private Sub btnPieceConfirm_Click(sender As Object, e As EventArgs) Handles btnPieceConfirm.Click

        If SegAsmblyData.ProcessData.Count = 0 Then
            MessageBox.Show($"{PlcIf.RingNo}リングの'{SegAsmblyData.AssemblyPtnName(PlcIf.RingNo)}'の、組立順序が設定されてません'", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not SegAsmblyData.TransferFmSim Then
            MessageBox.Show("セグメント割付シュミレーションより転送処理を行ってください'", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            My.Forms.frmSegmentEdit.Show()
        Else
            PlcIf.LosZeroEnable = True '同時施工可　信号出力
            '組立ピース確認
            WriteEventData("同時施工　組立ピース確認しました。", Color.Blue)
            '同時組立中にセグメントモードにして同時施工OFFとなった場合の工程継続対応
            If PlcIf.ExcaStatus <> cTaiki AndAlso PlcIf.LosZeroSts_M = 5 And PlcIf.AssemblyPieceNo < SegAsmblyData.AssemblyPlanPieceNumber Then
                btnLoszeroContinu.Enabled = True
            End If



        End If


    End Sub

    Private Sub ｂｔｎLossZerooCancel_Click(sender As Object, e As EventArgs) Handles btnLossZerooCancel.Click
        If MessageBox.Show("同時施工キャンセルしますか？", "同時施工", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            PlcIf.DigtalPlcWrite("同時施工キャンセル", True)
            PlcIf.LosZeroEnable = False '同時施工キャンセル
            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
        End If
    End Sub

    Private Sub StrokeMonitor_Click(sender As Object, e As EventArgs) Handles StrokeMonitor.Click
        My.Forms.frmCalcStrokeConfirm.Show()
    End Sub

    ''' <summary>
    ''' 姿勢トレンドのデータ取得
    ''' </summary>
    Public Class DirectionChartData
        Inherits clsDataBase
        '掘進データ
        Private _HorRData As New List(Of ucnChart2.gData)
        Private _VerRData As New List(Of ucnChart2.gData)
        '計画データ
        Private _HorPData As New Dictionary(Of Integer, Single)
        Private _VerPData As New Dictionary(Of Integer, Single)

        ''' <summary>
        ''' 平面掘進データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HorRData As List(Of ucnChart2.gData)
            Get
                Return _HorRData
            End Get
        End Property
        ''' <summary>
        ''' 縦断掘進データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property VerRData As List(Of ucnChart2.gData)
            Get
                Return _VerRData
            End Get
        End Property
        ''' <summary>
        ''' これから掘進する平面計画データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HorPData As Dictionary(Of Integer, Single)
            Get
                Return _HorPData
            End Get
        End Property
        ''' <summary>
        ''' これから掘進する縦断計画データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property VerPData As Dictionary(Of Integer, Single)
            Get
                Return _VerPData
            End Get
        End Property

        ''' <summary>
        ''' チャートデータ更新
        ''' </summary>
        Public Sub DataUp()
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT リング番号,平面起点から発旋回中心までの距離,前胴方位角,水平偏角,
                平面姿勢角管理値,縦断起点から発旋回中心までの距離,前胴鉛直角,縦断姿勢角管理値,鉛直偏角 
                FROM flex掘削データ WHERE リング番号 =
               '{PlcIf.RingNo}' ORDER BY 掘進ストローク DESC LIMIT 0,1")

            Dim g As ucnChart2.gData

            If rsData.Rows.Count <> 0 Then
                Dim t As DataRow = rsData.Rows(0)
                g.RingNo = t("リング番号")
                g.Distance = t.Item("平面起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴方位角")
                g.TargetDr = t.Item("平面姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("水平偏角") ' t.Item("ジャイロ方位角")
                _HorRData.Add(g)

                g.Distance = t.Item("縦断起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴鉛直角")
                g.TargetDr = t.Item("縦断姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("鉛直偏角") '  t.Item("ジャイロピッチング")
                _VerRData.Add(g)

            End If

        End Sub




        ''' <summary>
        ''' 平面と縦断のチャートデータを取得
        ''' </summary>
        Public Sub DataGet()
            '過去の掘進データ 10mm毎
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT リング番号,平面起点から発旋回中心までの距離,前胴方位角,水平偏角,
                平面姿勢角管理値, 縦断起点から発旋回中心までの距離, 前胴鉛直角, 縦断姿勢角管理値, 鉛直偏角  FROM flex掘削データ WHERE リング番号 >=
                '{PlcIf.RingNo - CtlPara.LineDevStartRing}'
                AND リング番号<='{PlcIf.RingNo}' AND 掘進ストローク%10 =0;")

            _HorRData.Clear()
            _VerRData.Clear()

            If rsData.Rows.Count = 0 Then Exit Sub

            Dim RingNo As Integer = Nothing
            Dim g As ucnChart2.gData

            For Each t As DataRow In rsData.Rows

                g.RingNo = t("リング番号")
                g.Distance = t.Item("平面起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴方位角")
                g.TargetDr = t.Item("平面姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("水平偏角") ' t.Item("ジャイロ方位角")
                _HorRData.Add(g)

                g.Distance = t.Item("縦断起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴鉛直角")
                g.TargetDr = t.Item("縦断姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("鉛直偏角") '  t.Item("ジャイロピッチング")
                _VerRData.Add(g)
                RingNo = g.RingNo

            Next

            'これから掘削する計画方位データ
            _HorPData.Clear()
            _VerPData.Clear()

            Dim Distance As Integer = 0 '掘進距離（単位mm)　リング分のセグメント幅を加算
            For i As Integer = PlcIf.RingNo To PlcIf.RingNo + CtlPara.LineDevLastRing
                Distance += SegAsmblyData.TypeData(i).CenterWidth * 1000
            Next
            '線形
            Dim dis As New clsLineMake

            For i As Integer = 0 To Distance Step 10
                dis.掘進累積距離 = (i + _HorRData.Last.Distance) / 1000
                'todo:軌道中心方位角でなく平面計画方位を演算　中折演算を加味
                _HorPData.Add(i, Hoko2Hoi(dis.軌道中心方位角 + HorPlan.X軸方位角))
                _VerPData.Add(i, dis.鉛直角)
            Next

        End Sub
    End Class

    ''' <summary>
    ''' 偏角、モーメントのトレンドグラフのデータを取得
    ''' 立ち上げ時の表示用
    ''' </summary>
    Private Class ChartDataGet
        Inherits clsDataBase

        Public Shared RingNo As Integer
        Private _DList As Dictionary(Of Integer, Single)
        Sub New(FldName As String)
            '_DList = New Dictionary(Of Integer, Single)
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT 掘進ストローク,{FldName} FROM flex掘削データ WHERE リング番号='{RingNo}';")
            _DList =
                rsData.AsEnumerable.ToDictionary(Function(n) CInt(n.Item(0)), Function(n) CSng(n.Item(1)))

        End Sub

        Sub New()
            Dim rsData As DataTable =
                GetDtfmSQL("SELECT リング番号 FROM flex掘削データ ORDER BY 時間 DESC LIMIT 0,1")

            If rsData.Rows.Count <> 0 Then
                RingNo = rsData.Rows(0).Item(0)
            End If

        End Sub

        Public ReadOnly Property DList As Dictionary(Of Integer, Single)
            Get
                Return _DList
            End Get
        End Property


    End Class

    ''' <summary>
    ''' 汎用データ項目変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DspWideUse0_DoubleClick(sender As ucnDspData, e As EventArgs) _
        Handles DspWideUse0.DoubleClick, DspWideUse1.DoubleClick, DspWideUse2.DoubleClick,
        DspWideUse3.DoubleClick, DspWideUse4.DoubleClick, DspWideUse5.DoubleClick,
        DspWideUse6.DoubleClick, DspWideUse7.DoubleClick, DspWideUse8.DoubleClick,
        DspWideUse9.DoubleClick, DspWideUse10.DoubleClick, DspWideUse11.DoubleClick, DspWideUse12.DoubleClick

        cmbWideSelct.Tag = sender
        cmbWideSelct.Visible = True
        '選択用アイテムをセット
        cmbWideSelct.Items.Clear()
        'アナログtagより項目名を列挙
        cmbWideSelct.Items.AddRange((From n In PlcIf.AnalogTag.Tag Select n.FieldName).ToArray)
        cmbWideSelct.Text = sender.FieldName
        '位置を調整
        cmbWideSelct.Top = sender.Top + 5


    End Sub
    ''' <summary>
    ''' 項目名が変更された時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbWideSelct_Click(sender As Object, e As EventArgs) Handles cmbWideSelct.SelectionChangeCommitted
        cmbWideSelct.Visible = False
        Dim WideUse As ucnDspData = DirectCast(cmbWideSelct.Tag, ucnDspData)
        WideUse.FieldName = cmbWideSelct.SelectedItem
        CtlPara.WideUseUpdate(CShort(WideUse.Name.Replace("DspWideUse", "")), WideUse.FieldName)
        WideDataFldSet() '汎用データ・セット
    End Sub

    Private Sub DspWideUse0_DoubleClick(sender As Object, e As EventArgs) Handles DspWideUse9.DoubleClick, DspWideUse8.DoubleClick, DspWideUse7.DoubleClick, DspWideUse6.DoubleClick, DspWideUse5.DoubleClick, DspWideUse4.DoubleClick, DspWideUse3.DoubleClick, DspWideUse2.DoubleClick, DspWideUse11.DoubleClick, DspWideUse10.DoubleClick, DspWideUse1.DoubleClick, DspWideUse0.DoubleClick, DspWideUse12.DoubleClick

    End Sub

    Private Sub 平面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 平面ToolStripMenuItem.Click
        frmHorPlanData.Show()
    End Sub

    Private Sub 縦断ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 縦断ToolStripMenuItem.Click
        frmVerPlanData.Show()
    End Sub

    Private Sub ｌｂｌMachineMode_Click(sender As Object, e As EventArgs) Handles lblMachineMode.Click

    End Sub


    ''' <summary>
    ''' 閉じるボタンを無効　Win32 APIによる方法
    ''' </summary>
    ''' <param name="hWnd"></param>
    ''' <param name="bRevert"></param>
    ''' <returns></returns>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function GetSystemMenu(ByVal hWnd As IntPtr,
        ByVal bRevert As Boolean) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function GetMenuItemCount(ByVal hMenu As IntPtr) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function DrawMenuBar(ByVal hWnd As IntPtr) As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function RemoveMenu(ByVal hMenu As IntPtr,
        ByVal uPosition As Integer,
        ByVal uFlags As Integer) As Boolean
    End Function

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        Const MF_BYPOSITION As Int32 = &H400
        Const MF_REMOVE As Int32 = &H1000

        Dim menu As IntPtr = GetSystemMenu(Me.Handle, False)
        Dim menuCount As Integer = GetMenuItemCount(menu)
        If menuCount > 1 Then
            'メニューの「閉じる」とセパレータを削除
            RemoveMenu(menu, menuCount - 1, MF_BYPOSITION Or MF_REMOVE)
            RemoveMenu(menu, menuCount - 2, MF_BYPOSITION Or MF_REMOVE)
            DrawMenuBar(Me.Handle)
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim ReportTbl As New clsRingReport
        '        ReportTbl.CheckRingItem()
        'フォームのタイトル
        Me.Text += $"{GetVersionNo()} [{InitPara.ConstructionName}] "

        Me.Text += InitPara.ModeName


        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
            .NumberGroup = InitPara.NumberGroup
            .FirstJackLoc = InitPara.FirstJackLoc
            .FaiJack = InitPara.FaiJack
            .JackGroupPos = InitPara.JackGroupPos
            .NumberJack = InitPara.NumberJack
            .MeasureJkNo = InitPara.MesureJackAngle.Keys.ToList

            .CopyNumber = CtlPara.CopyNumber

            .FlexPointX = PlcIf.PointX
            .FlexPointY = PlcIf.PointY

            .FlexPointR = PlcIf.操作強
            .FlexPointSeater = PlcIf.操作角

            .DspInitBaseImg()

            .SegmentDspEnable = InitPara.LosZeroEquip
            .MaxCopyStroke = PlcIf.AnalogTag.TagData("コピーストローク1").EngHight
        End With

        lblTransfer.Visible = InitPara.LosZeroEquip

        '---------------チャートの設定------------------------
        '偏角、モーメントグラフ
        Dim LastRingNoGet As New ChartDataGet   '最終のリング番号を取得

        Dim HorMomentData As New ChartDataGet("水平モーメント")
        Dim VerMomentData As New ChartDataGet("鉛直モーメント")
        Dim HorDevData As New ChartDataGet("水平偏角")
        Dim VerDevData As New ChartDataGet("鉛直偏角")


        '水平モーメント
        ucnHorMomentChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnHorMomentChart.ChartHighScale = CtlPara.HorMomentTrendWidth
        ucnHorMomentChart.ChartList = HorMomentData.DList
        ucnHorMomentChart.ChartClear()

        '鉛直モーメント
        ucnVerMomentChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnVerMomentChart.ChartHighScale = CtlPara.HorMomentTrendWidth
        ucnVerMomentChart.ChartList = VerMomentData.DList
        ucnVerMomentChart.ChartClear()
        '水平偏角(ストローク偏差)
        ucnHorDevChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnHorDevChart.ChartHighScale =
            If(CtlPara.horAngleDetection = GyroDetciotn, CtlPara.HorDevDegTrendWidth, CtlPara.HorDevDiffTrendWidth)
        ucnHorDevChart.ChartList = HorDevData.DList
        ucnHorDevChart.ChartClear()

        '水平偏角
        ucnHorDevChart2.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnHorDevChart2.ChartHighScale = CtlPara.HorDevDegTrendWidth
        'ucnHorDevChart2.ChartList = HorDevData.DList
        ucnHorDevChart2.ChartClear()
        'チャート切り替えボタン有効無効
        btnChartChange.Visible = (CtlPara.horAngleDetection = StrokeDiffDetciotn)

        '鉛直偏角
        ucnVerDevChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnVerDevChart.ChartHighScale = CtlPara.HorDevDegTrendWidth
        ucnVerDevChart.ChartList = VerDevData.DList
        ucnVerDevChart.ChartClear()
        '
        UcnGpPvBarGraph.PresBarGraphWidt = CtlPara.PresBarGraphWidt

        'フォームの大きさを画面
        ReDim DspGp(InitPara.NumberGroup)

        'イベントログ更新
        EventlogUpdate()

        'PLCにグループ数、ジャッキ本数書込
        If InitPara.ServerMode Then
            PlcIf.ParameterWrite("グループ数", InitPara.NumberGroup)
            PlcIf.ParameterWrite("ジャッキ本数", InitPara.NumberJack)
        End If

        '汎用データ表示項目セット
        WideDataFldSet()

        '基準方位の算出
        RefernceDirection.sbCulKijun()

        DirectionChartD.DataGet()

        '線形データ画面更新
        LineDataUpdate()
        If InitPara.LosZeroEquip Then
            '組立パターンの情報を取得
            SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)
            '組み立てピースがゼロの場合は初期化
            If CtlPara.AssemblyPieceNumber = 0 Then
                CtlPara.AssemblyPieceNumber = SegAsmblyData.AssemblyPlanPieceNumber
            End If
            '同時施工組立パターン情報表示
            SegmentDataDsp()
        End If
        '同時施工モードのメニュー有効
        LossZeroConcern.Enabled = InitPara.LosZeroEquip
        AssemblyProcessEdit.Enabled = InitPara.LosZeroEquip

        btnLoszeroContinu.Visible = InitPara.LosZeroEquip
        btnPieceConfirm.Visible = InitPara.LosZeroEquip
        btnLossZerooCancel.Visible = InitPara.LosZeroEquip

        '不動作推進のボタン
        btnNoOpJk.Visible = InitPara.NoOpJkExist


        DspUpRealStroke.Visible = InitPara.LosZeroEquip
        DspRightRealStroke.Visible = InitPara.LosZeroEquip
        DspLeftRealStroke.Visible = InitPara.LosZeroEquip
        DspBottomRealStroke.Visible = InitPara.LosZeroEquip

        DspUpRawStroke.FieldName = "上ストローク"
        DspRightRawStroke.FieldName = "右ストローク"
        DspLeftRawStroke.FieldName = "左ストローク"
        DspBottomRawStroke.FieldName = "下ストローク"




        DspWideUse12.Visible = Not InitPara.LosZeroEquip

        '掘削開始時刻の取得
        DspExcavStartDay(getExcecStartTime)
        '姿勢制御自動手動の切替時の処理
        FlexAutoManualChange()


        '上下ストローク計の有無で表示設定

        DspBottomRawStroke.Visible = InitPara.bottomStrokeEnable
        DspBottomRealStroke.Visible = InitPara.bottomStrokeEnable And InitPara.LosZeroEquip
        DspBottomSpeed.Visible = InitPara.bottomStrokeEnable


        DspUpRawStroke.Visible = InitPara.topStrokeEnable
        DspUpRealStroke.Visible = InitPara.topStrokeEnable And InitPara.LosZeroEquip
        DspUpSpeed.Visible = InitPara.topStrokeEnable

        DspUDStrokeDiff.Visible = (InitPara.topStrokeEnable And InitPara.bottomStrokeEnable)
        DspUDRealStrokeDiff.Visible = DspUDStrokeDiff.Visible And InitPara.LosZeroEquip


        DspLRRealStrokeDiff.Visible = InitPara.LosZeroEquip

        'テールクリアランスの表示
        DspTopClearance.Visible = CtlPara.TaleClrMeasurUExist
        DspLeftClearance.Visible = CtlPara.TaleClrMeasurLExist
        DspRightClearance.Visible = CtlPara.TaleClrMeasurRExist
        DspBottomClearance.Visible = CtlPara.TaleClrMeasurBExist

        '後胴ローリングの表示
        '同時組立　および　後胴ローリング装備時
        lblMRRolling.Visible = CtlPara.MachineRearRollingExist And InitPara.LosZeroEquip
        DspRealMRRolling.Visible = lblMRRolling.Visible
        DspTransMRRolling.Visible = lblMRRolling.Visible
        DspChangeMRRolling.Visible = lblMRRolling.Visible

        ParameterCheck()

        'ロスゼロ実績
        LosZeroPerform.Caluc()
        'ロスゼロで掘進途中に立ち上げたときのストローク処理
        StrokeSet()

        If PlcIf.ExcaStatus <> cTaiki Then
            '計算ストローク演算
            PlcIf_MesureStrokeChange()
        End If

        '立ち上がったイベントをログに

        WriteEventData($"Flex Start [{System.Net.Dns.GetHostName()}] [{InitPara.ModeName}]", Color.White)



    End Sub
    ''' <summary>
    ''' ロスゼロで掘進途中に立ち上げたときのストローク処理
    ''' </summary>
    Private Sub StrokeSet()
        If PlcIf.ExcaStatus <> cTaiki AndAlso PlcIf.LosZeroEnable Then
            'TODO:最大テーパーの算出
            CalcStroke.SegmentTaperValue = SegAsmblyData.TypeData(PlcIf.RingNo).ETTaper
            '最大テーパー位置
            'CalcStroke.SegmentMaxTaperLoc = SegAsmblyData.TypeData(PlcIf.RingNo).TaperAngle
            If SegAsmblyData.TaperLoc.ContainsKey(PlcIf.RingNo) Then
                CalcStroke.SegmentMaxTaperLoc = SegAsmblyData.TaperLoc(PlcIf.RingNo)
            End If
            'セグメント幅
            CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
            '引き戻し中から押込み中の間は引き戻しｼﾞｬｯｷをセット
            If PlcIf.LosZeroSts_M >= 2 And PlcIf.LosZeroSts_M <= 4 Then
                CalcStroke.PullBackJack = SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo).PullBackJack
            End If

            For Pieace As Short = 1 To PlcIf.AssemblyPieceNo
                If Pieace < PlcIf.AssemblyPieceNo Or (Pieace = PlcIf.AssemblyPieceNo And PlcIf.LosZeroSts_M = 5) Then
                    CalcStroke.asembleFinishedJack = SegAsmblyData.ProcessData(Pieace).ClosetJack
                    CalcStroke.asembleFinishedJack = SegAsmblyData.ProcessData(Pieace).AddClosetJack
                    'CalcStroke.MesureCalcAveJackStroke = PlcIf.MesureCalcAveJackStroke
                End If
            Next
            '計測ジャッキオフセットストロークの読込
            CalcStroke.mesureOffsetJackStroke = CtlPara.mesureOffsetJackStroke

        End If

    End Sub




    ''' <summary>
    ''' パラメータのチェック
    ''' </summary>
    Private Sub ParameterCheck()

        If PlcIf.DirectControlCoefficient = 0 Then
            PlcIf.DirectControlCoefficient = 1
        End If
        If InitPara.ServerMode Then
            If PlcIf.減圧弁制御P定数 = 0 Then
                PlcIf.減圧弁制御P定数 = 100
            End If
            If PlcIf.減圧弁制御I定数 = 0 Then
                PlcIf.減圧弁制御I定数 = 10
            End If
            If PlcIf.終了判定引きストローク <= 0 Then
                PlcIf.終了判定引きストローク = 300
            End If


        End If
    End Sub

    Private Sub RingDataViewer_Click(sender As Object, e As EventArgs) Handles RingDataViewer.Click

        frmRingDataView.Show()

    End Sub
    ''' <summary>
    ''' 次ピース確認画面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoszeroContinu_Click(sender As Object, e As EventArgs) Handles btnLoszeroContinu.Click
        frmNextPieceConfirm.Show()
        btnLoszeroContinu.Enabled = False 'ボタン無効
    End Sub

    Private Sub DspExcationElapsedTime_Load(sender As Object, e As EventArgs) Handles DspExcationElapsedTime.Load

    End Sub

    Private Sub DspRingTargetDir_Load(sender As Object, e As EventArgs) Handles DspRingTargetDir.Load

    End Sub

    ''' <summary>
    ''' 目標推進量の入力
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NetStrokeChange_Click(sender As Object, e As EventArgs) Handles NetStrokeChange.Click, DspTargetNetStroke.DoubleClick, DspRingTargetDir.DoubleClick
        frmNetStrokeChange.Show()
    End Sub
    ''' <summary>
    ''' 不動作ジャッキ／全ジャッキ推進の切り替え
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNoOpJk_Click(sender As Object, e As EventArgs) Handles btnNoOpJk.Click
        If InitPara.ServerMode Then
            Dim msg As String = If(PlcIf.NoOpJackOn, "全ジャッキ", "不動作ジャッキ")
            Dim ret As DialogResult = MessageBox.Show($"{msg}に切り替えますか？", "全ジャッキ推進、不動作ジャッキ切り替え", MessageBoxButtons.YesNo)
            If ret = DialogResult.Yes Then
                PlcIf.NoOpJackOn = Not PlcIf.NoOpJackOn
            End If

        End If
    End Sub

    Private Sub btnChartChange_Click(sender As Object, e As EventArgs) Handles btnChartChange.Click
        ucnHorDevChart2.Visible = Not ucnHorDevChart2.Visible
        ucnVerLineChart.Visible = Not ucnHorDevChart2.Visible
    End Sub
    ''' <summary>
    ''' リング更新　同時施工の場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRingUpdate_Click(sender As Object, e As EventArgs) Handles btnRingUpdate.Click
        'Dim ret As DialogResult = MessageBox.Show("リング更新を行いますか？", "リング更新処理", MessageBoxButtons.YesNo)
        'If ret = DialogResult.Yes Then
        PlcIf.DigtalPlcWrite("掘進強制終了", True) 'PLC書込
            If PlcIf.SegmentMode Then
            'MessageBox.Show("掘進モードにて待機中となります。", "リング更新処理", MessageBoxButtons.OK)
            WriteEventData("リング更新されました,掘進モードにて待機中となります", Color.Magenta)
        End If
            btnRingUpdate.Visible = False
        'End If

    End Sub
End Class