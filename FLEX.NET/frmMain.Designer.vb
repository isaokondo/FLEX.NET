﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tmrDataDsp = New System.Windows.Forms.Timer(Me.components)
        Me.MenuSystem = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RingNoChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.RingNoUpdateSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanDataSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcavEnforceStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcavEnforceStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SystemEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DspSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PressParameter = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneDirectionParameter = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneDirectionLimit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PresBlock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagmentMethd = New System.Windows.Forms.ToolStripMenuItem()
        Me.LossZeroConcern = New System.Windows.Forms.ToolStripMenuItem()
        Me.OterSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadPlanData = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssemblyProcessEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.目標ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorrectionValMng = New System.Windows.Forms.ToolStripMenuItem()
        Me.RingCloseValueMng = New System.Windows.Forms.ToolStripMenuItem()
        Me.ウインドウToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuningMonitorClicｋ = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcnDspData15 = New FLEX.NET.ucnDspData()
        Me.UcnDspData16 = New FLEX.NET.ucnDspData()
        Me.UcnDspData32 = New FLEX.NET.ucnDspData()
        Me.UcnDspData33 = New FLEX.NET.ucnDspData()
        Me.UcnDspData34 = New FLEX.NET.ucnDspData()
        Me.UcnDspData35 = New FLEX.NET.ucnDspData()
        Me.UcnDspData30 = New FLEX.NET.ucnDspData()
        Me.UcnDspData31 = New FLEX.NET.ucnDspData()
        Me.UcnDspData29 = New FLEX.NET.ucnDspData()
        Me.UcnDspData28 = New FLEX.NET.ucnDspData()
        Me.DspExcavStartTime = New FLEX.NET.ucnDspData()
        Me.DspExcavStartDate = New FLEX.NET.ucnDspData()
        Me.rtbEventLog = New System.Windows.Forms.RichTextBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.DspRingNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DspFlexGyiroControl = New FLEX.NET.ucnDspBit()
        Me.DspFlexAutoAzurControl = New FLEX.NET.ucnDspBit()
        Me.DspExcavingStop = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit2 = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit3 = New FLEX.NET.ucnDspBit()
        Me.DspExcavingOn = New FLEX.NET.ucnDspBit()
        Me.DspFlexAuto = New FLEX.NET.ucnDspBit()
        Me.DspFlexControlOn = New FLEX.NET.ucnDspBit()
        Me.DspExcaWaiting = New FLEX.NET.ucnDspBit()
        Me.pnlLosZero = New System.Windows.Forms.Panel()
        Me.ucnAssemblyFinish = New FLEX.NET.ucnDspBit()
        Me.ucnPullBackFinish = New FLEX.NET.ucnDspBit()
        Me.ucnReduceFinish = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit5 = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit4 = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit1 = New FLEX.NET.ucnDspBit()
        Me.ucnLosZeroMode = New FLEX.NET.ucnDspBit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ｂｔｎLossZerooCancel = New System.Windows.Forms.Button()
        Me.ucnVerLineChart = New FLEX.NET.ucnChart2()
        Me.ucnHorLineChart = New FLEX.NET.ucnChart2()
        Me.ucnHorDevChart = New FLEX.NET.ucnChart()
        Me.ucnHorMomentChart = New FLEX.NET.ucnChart()
        Me.DspAssemblyPattern = New FLEX.NET.ucnDspData()
        Me.DspNextPieceName = New FLEX.NET.ucnDspData()
        Me.UcnDspData24 = New FLEX.NET.ucnDspData()
        Me.UcnDspData21 = New FLEX.NET.ucnDspData()
        Me.UcnDspData22 = New FLEX.NET.ucnDspData()
        Me.DspClosetJack = New FLEX.NET.ucnDspData()
        Me.DspPullBackJack = New FLEX.NET.ucnDspData()
        Me.UcnDspData17 = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPieace = New FLEX.NET.ucnDspData()
        Me.UcnDspData2 = New FLEX.NET.ucnDspData()
        Me.UcnDspData1 = New FLEX.NET.ucnDspData()
        Me.ucnVerDevChart = New FLEX.NET.ucnChart()
        Me.ucnVerMomentChart = New FLEX.NET.ucnChart()
        Me.UcnGpPvBarGraph = New FLEX.NET.ucnGpPvBarGraph()
        Me.UcnDspDevImg = New FLEX.NET.ucnDspDevImg()
        Me.DspRightSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspRightRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspUpSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspUpRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspRealBottomStroke = New FLEX.NET.ucnDspDataMin()
        Me.UcnDspData9 = New FLEX.NET.ucnDspData()
        Me.UcnDspData10 = New FLEX.NET.ucnDspData()
        Me.UcnDspData11 = New FLEX.NET.ucnDspData()
        Me.UcnDspData12 = New FLEX.NET.ucnDspData()
        Me.UcnDspData13 = New FLEX.NET.ucnDspData()
        Me.UcnDspData14 = New FLEX.NET.ucnDspData()
        Me.UcnDspData7 = New FLEX.NET.ucnDspData()
        Me.UcnDspData8 = New FLEX.NET.ucnDspData()
        Me.UcnDspData5 = New FLEX.NET.ucnDspData()
        Me.UcnDspData6 = New FLEX.NET.ucnDspData()
        Me.UcnDspData4 = New FLEX.NET.ucnDspData()
        Me.UcnDspData3 = New FLEX.NET.ucnDspData()
        Me.UcnJackDsp = New FLEX.NET.ucnJackDsp()
        Me.DspExcvSpeed = New FLEX.NET.ucnDspData()
        Me.DspAveStroke = New FLEX.NET.ucnDspData()
        Me.DspTargetPitching = New FLEX.NET.ucnDspData()
        Me.DspTargetDirection = New FLEX.NET.ucnDspData()
        Me.DspVerRChangePoint = New FLEX.NET.ucnDspData()
        Me.DspVerFChangePoint = New FLEX.NET.ucnDspData()
        Me.DspVerLine = New FLEX.NET.ucnDspData()
        Me.DspHorRChangePoint = New FLEX.NET.ucnDspData()
        Me.DspHorFChangePoint = New FLEX.NET.ucnDspData()
        Me.DspHorLine = New FLEX.NET.ucnDspData()
        Me.DspDistance = New FLEX.NET.ucnDspData()
        Me.DspMoment = New FLEX.NET.ucnDspData()
        Me.DspThrust = New FLEX.NET.ucnDspData()
        Me.DspJackPress = New FLEX.NET.ucnDspData()
        Me.DspVerBroken = New FLEX.NET.ucnDspData()
        Me.DspHorBroken = New FLEX.NET.ucnDspData()
        Me.DspPitching = New FLEX.NET.ucnDspData()
        Me.DspDirection = New FLEX.NET.ucnDspData()
        Me.DspVerDev = New FLEX.NET.ucnDspData()
        Me.DspHorDev = New FLEX.NET.ucnDspData()
        Me.DspMachinComErr = New FLEX.NET.ucnDspBit()
        Me.MenuSystem.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlLosZero.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrDataDsp
        '
        Me.tmrDataDsp.Interval = 500
        '
        'MenuSystem
        '
        Me.MenuSystem.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuSystem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem, Me.表示ToolStripMenuItem, Me.設定ToolStripMenuItem, Me.目標ToolStripMenuItem, Me.ウインドウToolStripMenuItem, Me.ヘルプToolStripMenuItem})
        Me.MenuSystem.Location = New System.Drawing.Point(0, 0)
        Me.MenuSystem.Name = "MenuSystem"
        Me.MenuSystem.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuSystem.Size = New System.Drawing.Size(1914, 24)
        Me.MenuSystem.TabIndex = 20
        Me.MenuSystem.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RingNoChange, Me.RingNoUpdateSetting, Me.InitialSetting, Me.PlanDataSetting, Me.ToolStripMenuItem1, Me.ReportOut, Me.ToolStripMenuItem2, Me.ExcavEnforceStart, Me.ExcavEnforceStop, Me.OperationRight, Me.ToolStripMenuItem3, Me.SystemEnd})
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ToolStripMenuItem.Text = "システム(&S)"
        '
        'RingNoChange
        '
        Me.RingNoChange.Name = "RingNoChange"
        Me.RingNoChange.Size = New System.Drawing.Size(222, 26)
        Me.RingNoChange.Text = "リング番号の変更(&C)"
        '
        'RingNoUpdateSetting
        '
        Me.RingNoUpdateSetting.Name = "RingNoUpdateSetting"
        Me.RingNoUpdateSetting.Size = New System.Drawing.Size(222, 26)
        Me.RingNoUpdateSetting.Text = "リング番号更新設定(&U)"
        '
        'InitialSetting
        '
        Me.InitialSetting.Name = "InitialSetting"
        Me.InitialSetting.Size = New System.Drawing.Size(222, 26)
        Me.InitialSetting.Text = "初期設定(&I)"
        '
        'PlanDataSetting
        '
        Me.PlanDataSetting.Name = "PlanDataSetting"
        Me.PlanDataSetting.Size = New System.Drawing.Size(222, 26)
        Me.PlanDataSetting.Text = "計画路線の設定(&P)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 6)
        '
        'ReportOut
        '
        Me.ReportOut.Name = "ReportOut"
        Me.ReportOut.Size = New System.Drawing.Size(222, 26)
        Me.ReportOut.Text = "帳票出力(&Y)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 6)
        '
        'ExcavEnforceStart
        '
        Me.ExcavEnforceStart.Name = "ExcavEnforceStart"
        Me.ExcavEnforceStart.Size = New System.Drawing.Size(222, 26)
        Me.ExcavEnforceStart.Text = "掘進の強制開始(&X)"
        '
        'ExcavEnforceStop
        '
        Me.ExcavEnforceStop.Name = "ExcavEnforceStop"
        Me.ExcavEnforceStop.Size = New System.Drawing.Size(222, 26)
        Me.ExcavEnforceStop.Text = "掘進の強制終了(&B)"
        '
        'OperationRight
        '
        Me.OperationRight.Name = "OperationRight"
        Me.OperationRight.Size = New System.Drawing.Size(222, 26)
        Me.OperationRight.Text = "操作権(&O)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(219, 6)
        '
        'SystemEnd
        '
        Me.SystemEnd.Name = "SystemEnd"
        Me.SystemEnd.Size = New System.Drawing.Size(222, 26)
        Me.SystemEnd.Text = "プログラム終了(&E)"
        '
        '表示ToolStripMenuItem
        '
        Me.表示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DspSetting, Me.ScaleSetting})
        Me.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem"
        Me.表示ToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.表示ToolStripMenuItem.Text = "表示(&D)"
        '
        'DspSetting
        '
        Me.DspSetting.Name = "DspSetting"
        Me.DspSetting.Size = New System.Drawing.Size(182, 26)
        Me.DspSetting.Text = "各種の表示設定"
        '
        'ScaleSetting
        '
        Me.ScaleSetting.Name = "ScaleSetting"
        Me.ScaleSetting.Size = New System.Drawing.Size(182, 26)
        Me.ScaleSetting.Text = "スケール"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PressParameter, Me.OneDirectionParameter, Me.OneDirectionLimit, Me.ToolStripMenuItem4, Me.PresBlock, Me.ManagmentMethd, Me.LossZeroConcern, Me.OterSetting, Me.ToolStripMenuItem5, Me.ReloadPlanData, Me.SegmentEdit, Me.AssemblyProcessEdit})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.設定ToolStripMenuItem.Text = "設定(&R)"
        '
        'PressParameter
        '
        Me.PressParameter.Name = "PressParameter"
        Me.PressParameter.Size = New System.Drawing.Size(197, 26)
        Me.PressParameter.Text = "圧力パラメータ"
        '
        'OneDirectionParameter
        '
        Me.OneDirectionParameter.Name = "OneDirectionParameter"
        Me.OneDirectionParameter.Size = New System.Drawing.Size(197, 26)
        Me.OneDirectionParameter.Text = "片押パラメータ"
        '
        'OneDirectionLimit
        '
        Me.OneDirectionLimit.Name = "OneDirectionLimit"
        Me.OneDirectionLimit.Size = New System.Drawing.Size(197, 26)
        Me.OneDirectionLimit.Text = "片押し制限"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(194, 6)
        '
        'PresBlock
        '
        Me.PresBlock.Name = "PresBlock"
        Me.PresBlock.Size = New System.Drawing.Size(197, 26)
        Me.PresBlock.Text = "圧力ブロック"
        '
        'ManagmentMethd
        '
        Me.ManagmentMethd.Name = "ManagmentMethd"
        Me.ManagmentMethd.Size = New System.Drawing.Size(197, 26)
        Me.ManagmentMethd.Text = "管理方法"
        '
        'LossZeroConcern
        '
        Me.LossZeroConcern.Name = "LossZeroConcern"
        Me.LossZeroConcern.Size = New System.Drawing.Size(197, 26)
        Me.LossZeroConcern.Text = "同時施工関連"
        '
        'OterSetting
        '
        Me.OterSetting.Name = "OterSetting"
        Me.OterSetting.Size = New System.Drawing.Size(197, 26)
        Me.OterSetting.Text = "その他"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(194, 6)
        '
        'ReloadPlanData
        '
        Me.ReloadPlanData.Name = "ReloadPlanData"
        Me.ReloadPlanData.Size = New System.Drawing.Size(197, 26)
        Me.ReloadPlanData.Text = "計画路線の再読込"
        '
        'SegmentEdit
        '
        Me.SegmentEdit.Name = "SegmentEdit"
        Me.SegmentEdit.Size = New System.Drawing.Size(197, 26)
        Me.SegmentEdit.Text = "セグメントの割付"
        '
        'AssemblyProcessEdit
        '
        Me.AssemblyProcessEdit.Name = "AssemblyProcessEdit"
        Me.AssemblyProcessEdit.Size = New System.Drawing.Size(197, 26)
        Me.AssemblyProcessEdit.Text = "組立工程の編集"
        '
        '目標ToolStripMenuItem
        '
        Me.目標ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorrectionValMng, Me.RingCloseValueMng})
        Me.目標ToolStripMenuItem.Name = "目標ToolStripMenuItem"
        Me.目標ToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.目標ToolStripMenuItem.Text = "目標(&P)"
        '
        'CorrectionValMng
        '
        Me.CorrectionValMng.Name = "CorrectionValMng"
        Me.CorrectionValMng.Size = New System.Drawing.Size(172, 26)
        Me.CorrectionValMng.Text = "補正値管理"
        '
        'RingCloseValueMng
        '
        Me.RingCloseValueMng.Name = "RingCloseValueMng"
        Me.RingCloseValueMng.Size = New System.Drawing.Size(172, 26)
        Me.RingCloseValueMng.Text = "リング終値管理"
        '
        'ウインドウToolStripMenuItem
        '
        Me.ウインドウToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TuningMonitorClicｋ})
        Me.ウインドウToolStripMenuItem.Name = "ウインドウToolStripMenuItem"
        Me.ウインドウToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ウインドウToolStripMenuItem.Text = "ウインドウ(&W)"
        '
        'TuningMonitorClicｋ
        '
        Me.TuningMonitorClicｋ.Name = "TuningMonitorClicｋ"
        Me.TuningMonitorClicｋ.Size = New System.Drawing.Size(180, 26)
        Me.TuningMonitorClicｋ.Text = "チューニングモニタ"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UcnDspData15)
        Me.Panel1.Controls.Add(Me.UcnDspData16)
        Me.Panel1.Controls.Add(Me.UcnDspData32)
        Me.Panel1.Controls.Add(Me.UcnDspData33)
        Me.Panel1.Controls.Add(Me.UcnDspData34)
        Me.Panel1.Controls.Add(Me.UcnDspData35)
        Me.Panel1.Controls.Add(Me.UcnDspData30)
        Me.Panel1.Controls.Add(Me.UcnDspData31)
        Me.Panel1.Controls.Add(Me.UcnDspData29)
        Me.Panel1.Controls.Add(Me.UcnDspData28)
        Me.Panel1.Controls.Add(Me.DspExcavStartTime)
        Me.Panel1.Controls.Add(Me.DspExcavStartDate)
        Me.Panel1.Controls.Add(Me.rtbEventLog)
        Me.Panel1.Controls.Add(Me.lblUnit)
        Me.Panel1.Controls.Add(Me.DspRingNo)
        Me.Panel1.Location = New System.Drawing.Point(1306, 679)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 369)
        Me.Panel1.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 32)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "同時施工実績"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcnDspData15
        '
        Me.UcnDspData15.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData15.Blink = False
        Me.UcnDspData15.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData15.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData15.DataWidth = 91
        Me.UcnDspData15.DecimalPlaces = CType(0, Short)
        Me.UcnDspData15.FieldName = "短縮効果(日)"
        Me.UcnDspData15.FieldNameWidth = 175
        Me.UcnDspData15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData15.Location = New System.Drawing.Point(298, 213)
        Me.UcnDspData15.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData15.Name = "UcnDspData15"
        Me.UcnDspData15.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData15.TabIndex = 133
        Me.UcnDspData15.Unit = "deg"
        Me.UcnDspData15.UnitVisible = False
        Me.UcnDspData15.Value = "20"
        Me.UcnDspData15.ValueType = False
        '
        'UcnDspData16
        '
        Me.UcnDspData16.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData16.Blink = False
        Me.UcnDspData16.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData16.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData16.DataWidth = 91
        Me.UcnDspData16.DecimalPlaces = CType(0, Short)
        Me.UcnDspData16.FieldName = "累計同時掘進(分)"
        Me.UcnDspData16.FieldNameWidth = 175
        Me.UcnDspData16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData16.Location = New System.Drawing.Point(298, 181)
        Me.UcnDspData16.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData16.Name = "UcnDspData16"
        Me.UcnDspData16.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData16.TabIndex = 132
        Me.UcnDspData16.Unit = "deg"
        Me.UcnDspData16.UnitVisible = False
        Me.UcnDspData16.Value = "20"
        Me.UcnDspData16.ValueType = False
        '
        'UcnDspData32
        '
        Me.UcnDspData32.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData32.Blink = False
        Me.UcnDspData32.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData32.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData32.DataWidth = 91
        Me.UcnDspData32.DecimalPlaces = CType(0, Short)
        Me.UcnDspData32.FieldName = "平均同時掘進(分)"
        Me.UcnDspData32.FieldNameWidth = 175
        Me.UcnDspData32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData32.Location = New System.Drawing.Point(298, 149)
        Me.UcnDspData32.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData32.Name = "UcnDspData32"
        Me.UcnDspData32.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData32.TabIndex = 131
        Me.UcnDspData32.Unit = "deg"
        Me.UcnDspData32.UnitVisible = False
        Me.UcnDspData32.Value = "20"
        Me.UcnDspData32.ValueType = False
        '
        'UcnDspData33
        '
        Me.UcnDspData33.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData33.Blink = False
        Me.UcnDspData33.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData33.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData33.DataWidth = 91
        Me.UcnDspData33.DecimalPlaces = CType(0, Short)
        Me.UcnDspData33.FieldName = "累計組立ﾋﾟｰｽ数"
        Me.UcnDspData33.FieldNameWidth = 175
        Me.UcnDspData33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData33.Location = New System.Drawing.Point(298, 117)
        Me.UcnDspData33.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData33.Name = "UcnDspData33"
        Me.UcnDspData33.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData33.TabIndex = 130
        Me.UcnDspData33.Unit = "deg"
        Me.UcnDspData33.UnitVisible = False
        Me.UcnDspData33.Value = "20"
        Me.UcnDspData33.ValueType = False
        '
        'UcnDspData34
        '
        Me.UcnDspData34.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData34.Blink = False
        Me.UcnDspData34.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData34.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData34.DataWidth = 91
        Me.UcnDspData34.DecimalPlaces = CType(0, Short)
        Me.UcnDspData34.FieldName = "平均組立ﾋﾟｰｽ数"
        Me.UcnDspData34.FieldNameWidth = 175
        Me.UcnDspData34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData34.Location = New System.Drawing.Point(298, 85)
        Me.UcnDspData34.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData34.Name = "UcnDspData34"
        Me.UcnDspData34.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData34.TabIndex = 129
        Me.UcnDspData34.Unit = "deg"
        Me.UcnDspData34.UnitVisible = False
        Me.UcnDspData34.Value = "20"
        Me.UcnDspData34.ValueType = False
        '
        'UcnDspData35
        '
        Me.UcnDspData35.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData35.Blink = False
        Me.UcnDspData35.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData35.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData35.DataWidth = 91
        Me.UcnDspData35.DecimalPlaces = CType(0, Short)
        Me.UcnDspData35.FieldName = "平均ｻｲｸﾙ(分)"
        Me.UcnDspData35.FieldNameWidth = 175
        Me.UcnDspData35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData35.Location = New System.Drawing.Point(298, 51)
        Me.UcnDspData35.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData35.Name = "UcnDspData35"
        Me.UcnDspData35.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData35.TabIndex = 128
        Me.UcnDspData35.Unit = "deg"
        Me.UcnDspData35.UnitVisible = False
        Me.UcnDspData35.Value = "20"
        Me.UcnDspData35.ValueType = False
        '
        'UcnDspData30
        '
        Me.UcnDspData30.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData30.Blink = False
        Me.UcnDspData30.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData30.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData30.DataWidth = 91
        Me.UcnDspData30.DecimalPlaces = CType(0, Short)
        Me.UcnDspData30.FieldName = "ｻｲｸﾙ時間(分)"
        Me.UcnDspData30.FieldNameWidth = 175
        Me.UcnDspData30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData30.Location = New System.Drawing.Point(21, 213)
        Me.UcnDspData30.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData30.Name = "UcnDspData30"
        Me.UcnDspData30.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData30.TabIndex = 127
        Me.UcnDspData30.Unit = "deg"
        Me.UcnDspData30.UnitVisible = False
        Me.UcnDspData30.Value = "20"
        Me.UcnDspData30.ValueType = False
        '
        'UcnDspData31
        '
        Me.UcnDspData31.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData31.Blink = False
        Me.UcnDspData31.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData31.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData31.DataWidth = 91
        Me.UcnDspData31.DecimalPlaces = CType(0, Short)
        Me.UcnDspData31.FieldName = "待機時間(分)"
        Me.UcnDspData31.FieldNameWidth = 175
        Me.UcnDspData31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData31.Location = New System.Drawing.Point(21, 181)
        Me.UcnDspData31.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData31.Name = "UcnDspData31"
        Me.UcnDspData31.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData31.TabIndex = 126
        Me.UcnDspData31.Unit = "deg"
        Me.UcnDspData31.UnitVisible = False
        Me.UcnDspData31.Value = "20"
        Me.UcnDspData31.ValueType = False
        '
        'UcnDspData29
        '
        Me.UcnDspData29.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData29.Blink = False
        Me.UcnDspData29.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData29.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData29.DataWidth = 91
        Me.UcnDspData29.DecimalPlaces = CType(0, Short)
        Me.UcnDspData29.FieldName = "同時掘進時間(分)"
        Me.UcnDspData29.FieldNameWidth = 175
        Me.UcnDspData29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData29.Location = New System.Drawing.Point(21, 149)
        Me.UcnDspData29.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData29.Name = "UcnDspData29"
        Me.UcnDspData29.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData29.TabIndex = 125
        Me.UcnDspData29.Unit = "deg"
        Me.UcnDspData29.UnitVisible = False
        Me.UcnDspData29.Value = "20"
        Me.UcnDspData29.ValueType = False
        '
        'UcnDspData28
        '
        Me.UcnDspData28.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData28.Blink = False
        Me.UcnDspData28.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData28.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData28.DataWidth = 91
        Me.UcnDspData28.DecimalPlaces = CType(0, Short)
        Me.UcnDspData28.FieldName = "掘進時間(分)"
        Me.UcnDspData28.FieldNameWidth = 175
        Me.UcnDspData28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData28.Location = New System.Drawing.Point(21, 117)
        Me.UcnDspData28.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData28.Name = "UcnDspData28"
        Me.UcnDspData28.Size = New System.Drawing.Size(284, 32)
        Me.UcnDspData28.TabIndex = 124
        Me.UcnDspData28.Unit = "deg"
        Me.UcnDspData28.UnitVisible = False
        Me.UcnDspData28.Value = "20"
        Me.UcnDspData28.ValueType = False
        '
        'DspExcavStartTime
        '
        Me.DspExcavStartTime.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavStartTime.Blink = False
        Me.DspExcavStartTime.BlinkColor = System.Drawing.Color.Red
        Me.DspExcavStartTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspExcavStartTime.DataWidth = 141
        Me.DspExcavStartTime.DecimalPlaces = CType(2, Short)
        Me.DspExcavStartTime.FieldName = "開始時刻"
        Me.DspExcavStartTime.FieldNameWidth = 125
        Me.DspExcavStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcavStartTime.Location = New System.Drawing.Point(21, 85)
        Me.DspExcavStartTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcavStartTime.Name = "DspExcavStartTime"
        Me.DspExcavStartTime.Size = New System.Drawing.Size(284, 32)
        Me.DspExcavStartTime.TabIndex = 123
        Me.DspExcavStartTime.Unit = "deg"
        Me.DspExcavStartTime.UnitVisible = False
        Me.DspExcavStartTime.Value = "23:01:01"
        Me.DspExcavStartTime.ValueType = True
        '
        'DspExcavStartDate
        '
        Me.DspExcavStartDate.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavStartDate.Blink = False
        Me.DspExcavStartDate.BlinkColor = System.Drawing.Color.Red
        Me.DspExcavStartDate.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspExcavStartDate.DataWidth = 141
        Me.DspExcavStartDate.DecimalPlaces = CType(2, Short)
        Me.DspExcavStartDate.FieldName = "開始日"
        Me.DspExcavStartDate.FieldNameWidth = 125
        Me.DspExcavStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcavStartDate.Location = New System.Drawing.Point(21, 51)
        Me.DspExcavStartDate.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcavStartDate.Name = "DspExcavStartDate"
        Me.DspExcavStartDate.Size = New System.Drawing.Size(275, 32)
        Me.DspExcavStartDate.TabIndex = 122
        Me.DspExcavStartDate.Unit = "deg"
        Me.DspExcavStartDate.UnitVisible = False
        Me.DspExcavStartDate.Value = "216/05/01"
        Me.DspExcavStartDate.ValueType = True
        '
        'rtbEventLog
        '
        Me.rtbEventLog.Location = New System.Drawing.Point(21, 249)
        Me.rtbEventLog.Name = "rtbEventLog"
        Me.rtbEventLog.ReadOnly = True
        Me.rtbEventLog.Size = New System.Drawing.Size(536, 107)
        Me.rtbEventLog.TabIndex = 121
        Me.rtbEventLog.Text = ""
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(133, 12)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(92, 32)
        Me.lblUnit.TabIndex = 120
        Me.lblUnit.Text = "リング"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspRingNo
        '
        Me.DspRingNo.BackColor = System.Drawing.Color.Black
        Me.DspRingNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DspRingNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspRingNo.ForeColor = System.Drawing.Color.Yellow
        Me.DspRingNo.Location = New System.Drawing.Point(23, 9)
        Me.DspRingNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DspRingNo.Name = "DspRingNo"
        Me.DspRingNo.Size = New System.Drawing.Size(108, 38)
        Me.DspRingNo.TabIndex = 119
        Me.DspRingNo.Text = "1234"
        Me.DspRingNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DspMachinComErr)
        Me.Panel2.Controls.Add(Me.DspFlexGyiroControl)
        Me.Panel2.Controls.Add(Me.DspFlexAutoAzurControl)
        Me.Panel2.Controls.Add(Me.DspExcavingStop)
        Me.Panel2.Controls.Add(Me.UcnDspBit2)
        Me.Panel2.Controls.Add(Me.UcnDspBit3)
        Me.Panel2.Controls.Add(Me.DspExcavingOn)
        Me.Panel2.Controls.Add(Me.DspFlexAuto)
        Me.Panel2.Controls.Add(Me.DspFlexControlOn)
        Me.Panel2.Controls.Add(Me.DspExcaWaiting)
        Me.Panel2.Location = New System.Drawing.Point(317, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 75)
        Me.Panel2.TabIndex = 120
        '
        'DspFlexGyiroControl
        '
        Me.DspFlexGyiroControl.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexGyiroControl.BitStatus = True
        Me.DspFlexGyiroControl.Blink = False
        Me.DspFlexGyiroControl.FieldName = "ジャイロ"
        Me.DspFlexGyiroControl.Location = New System.Drawing.Point(481, 40)
        Me.DspFlexGyiroControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexGyiroControl.Name = "DspFlexGyiroControl"
        Me.DspFlexGyiroControl.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexGyiroControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexGyiroControl.Size = New System.Drawing.Size(90, 30)
        Me.DspFlexGyiroControl.TabIndex = 73
        '
        'DspFlexAutoAzurControl
        '
        Me.DspFlexAutoAzurControl.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexAutoAzurControl.BitStatus = False
        Me.DspFlexAutoAzurControl.Blink = False
        Me.DspFlexAutoAzurControl.FieldName = "自動測量"
        Me.DspFlexAutoAzurControl.Location = New System.Drawing.Point(387, 40)
        Me.DspFlexAutoAzurControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexAutoAzurControl.Name = "DspFlexAutoAzurControl"
        Me.DspFlexAutoAzurControl.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexAutoAzurControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexAutoAzurControl.Size = New System.Drawing.Size(90, 30)
        Me.DspFlexAutoAzurControl.TabIndex = 72
        '
        'DspExcavingStop
        '
        Me.DspExcavingStop.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingStop.BitStatus = False
        Me.DspExcavingStop.Blink = False
        Me.DspExcavingStop.FieldName = "中　断"
        Me.DspExcavingStop.Location = New System.Drawing.Point(387, 7)
        Me.DspExcavingStop.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcavingStop.Name = "DspExcavingStop"
        Me.DspExcavingStop.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingStop.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingStop.Size = New System.Drawing.Size(185, 30)
        Me.DspExcavingStop.TabIndex = 71
        '
        'UcnDspBit2
        '
        Me.UcnDspBit2.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit2.BitStatus = False
        Me.UcnDspBit2.Blink = False
        Me.UcnDspBit2.FieldName = "自動更新"
        Me.UcnDspBit2.Location = New System.Drawing.Point(293, 40)
        Me.UcnDspBit2.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit2.Name = "UcnDspBit2"
        Me.UcnDspBit2.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit2.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit2.Size = New System.Drawing.Size(90, 30)
        Me.UcnDspBit2.TabIndex = 70
        '
        'UcnDspBit3
        '
        Me.UcnDspBit3.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit3.BitStatus = True
        Me.UcnDspBit3.Blink = False
        Me.UcnDspBit3.FieldName = "補正値管"
        Me.UcnDspBit3.Location = New System.Drawing.Point(199, 40)
        Me.UcnDspBit3.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit3.Name = "UcnDspBit3"
        Me.UcnDspBit3.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit3.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit3.Size = New System.Drawing.Size(90, 30)
        Me.UcnDspBit3.TabIndex = 69
        '
        'DspExcavingOn
        '
        Me.DspExcavingOn.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingOn.BitStatus = True
        Me.DspExcavingOn.Blink = False
        Me.DspExcavingOn.FieldName = "掘　進"
        Me.DspExcavingOn.Location = New System.Drawing.Point(198, 7)
        Me.DspExcavingOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcavingOn.Name = "DspExcavingOn"
        Me.DspExcavingOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingOn.Size = New System.Drawing.Size(185, 30)
        Me.DspExcavingOn.TabIndex = 68
        '
        'DspFlexAuto
        '
        Me.DspFlexAuto.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexAuto.BitStatus = False
        Me.DspFlexAuto.Blink = False
        Me.DspFlexAuto.FieldName = "自動運転"
        Me.DspFlexAuto.Location = New System.Drawing.Point(104, 40)
        Me.DspFlexAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexAuto.Name = "DspFlexAuto"
        Me.DspFlexAuto.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexAuto.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexAuto.Size = New System.Drawing.Size(90, 30)
        Me.DspFlexAuto.TabIndex = 67
        '
        'DspFlexControlOn
        '
        Me.DspFlexControlOn.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexControlOn.BitStatus = True
        Me.DspFlexControlOn.Blink = False
        Me.DspFlexControlOn.FieldName = "FLEX制御"
        Me.DspFlexControlOn.Location = New System.Drawing.Point(10, 40)
        Me.DspFlexControlOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexControlOn.Name = "DspFlexControlOn"
        Me.DspFlexControlOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexControlOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexControlOn.Size = New System.Drawing.Size(90, 30)
        Me.DspFlexControlOn.TabIndex = 66
        '
        'DspExcaWaiting
        '
        Me.DspExcaWaiting.BackColor = System.Drawing.Color.Transparent
        Me.DspExcaWaiting.BitStatus = False
        Me.DspExcaWaiting.Blink = False
        Me.DspExcaWaiting.FieldName = "待　機"
        Me.DspExcaWaiting.Location = New System.Drawing.Point(9, 7)
        Me.DspExcaWaiting.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcaWaiting.Name = "DspExcaWaiting"
        Me.DspExcaWaiting.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcaWaiting.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcaWaiting.Size = New System.Drawing.Size(185, 30)
        Me.DspExcaWaiting.TabIndex = 65
        '
        'pnlLosZero
        '
        Me.pnlLosZero.BackColor = System.Drawing.Color.DarkGray
        Me.pnlLosZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnPullBackFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnReduceFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo)
        Me.pnlLosZero.Controls.Add(Me.UcnDspBit5)
        Me.pnlLosZero.Controls.Add(Me.UcnDspBit4)
        Me.pnlLosZero.Controls.Add(Me.UcnDspBit1)
        Me.pnlLosZero.Controls.Add(Me.ucnLosZeroMode)
        Me.pnlLosZero.Controls.Add(Me.ShapeContainer1)
        Me.pnlLosZero.Location = New System.Drawing.Point(1751, 30)
        Me.pnlLosZero.Name = "pnlLosZero"
        Me.pnlLosZero.Size = New System.Drawing.Size(129, 326)
        Me.pnlLosZero.TabIndex = 121
        '
        'ucnAssemblyFinish
        '
        Me.ucnAssemblyFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyFinish.BitStatus = True
        Me.ucnAssemblyFinish.Blink = False
        Me.ucnAssemblyFinish.FieldName = "組立完了"
        Me.ucnAssemblyFinish.Location = New System.Drawing.Point(11, 277)
        Me.ucnAssemblyFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyFinish.Name = "ucnAssemblyFinish"
        Me.ucnAssemblyFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnAssemblyFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyFinish.Size = New System.Drawing.Size(105, 30)
        Me.ucnAssemblyFinish.TabIndex = 133
        '
        'ucnPullBackFinish
        '
        Me.ucnPullBackFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnPullBackFinish.BitStatus = True
        Me.ucnPullBackFinish.Blink = False
        Me.ucnPullBackFinish.FieldName = "引戻完了"
        Me.ucnPullBackFinish.Location = New System.Drawing.Point(11, 242)
        Me.ucnPullBackFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnPullBackFinish.Name = "ucnPullBackFinish"
        Me.ucnPullBackFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnPullBackFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnPullBackFinish.Size = New System.Drawing.Size(105, 30)
        Me.ucnPullBackFinish.TabIndex = 132
        '
        'ucnReduceFinish
        '
        Me.ucnReduceFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnReduceFinish.BitStatus = True
        Me.ucnReduceFinish.Blink = False
        Me.ucnReduceFinish.FieldName = "減圧完了"
        Me.ucnReduceFinish.Location = New System.Drawing.Point(11, 207)
        Me.ucnReduceFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnReduceFinish.Name = "ucnReduceFinish"
        Me.ucnReduceFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnReduceFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnReduceFinish.Size = New System.Drawing.Size(105, 30)
        Me.ucnReduceFinish.TabIndex = 131
        '
        'ucnAssemblyPieceNo
        '
        Me.ucnAssemblyPieceNo.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo.BitStatus = True
        Me.ucnAssemblyPieceNo.Blink = False
        Me.ucnAssemblyPieceNo.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo.Location = New System.Drawing.Point(11, 173)
        Me.ucnAssemblyPieceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo.Name = "ucnAssemblyPieceNo"
        Me.ucnAssemblyPieceNo.OffBackColor = System.Drawing.Color.White
        Me.ucnAssemblyPieceNo.OnBackColor = System.Drawing.Color.White
        Me.ucnAssemblyPieceNo.Size = New System.Drawing.Size(105, 30)
        Me.ucnAssemblyPieceNo.TabIndex = 129
        '
        'UcnDspBit5
        '
        Me.UcnDspBit5.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit5.BitStatus = True
        Me.UcnDspBit5.Blink = False
        Me.UcnDspBit5.FieldName = "ﾛｰﾘﾝｸﾞ考慮"
        Me.UcnDspBit5.Location = New System.Drawing.Point(12, 113)
        Me.UcnDspBit5.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit5.Name = "UcnDspBit5"
        Me.UcnDspBit5.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit5.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit5.Size = New System.Drawing.Size(105, 30)
        Me.UcnDspBit5.TabIndex = 72
        '
        'UcnDspBit4
        '
        Me.UcnDspBit4.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit4.BitStatus = True
        Me.UcnDspBit4.Blink = False
        Me.UcnDspBit4.FieldName = "対抗圧制御"
        Me.UcnDspBit4.Location = New System.Drawing.Point(12, 78)
        Me.UcnDspBit4.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit4.Name = "UcnDspBit4"
        Me.UcnDspBit4.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit4.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit4.Size = New System.Drawing.Size(105, 30)
        Me.UcnDspBit4.TabIndex = 71
        '
        'UcnDspBit1
        '
        Me.UcnDspBit1.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit1.BitStatus = True
        Me.UcnDspBit1.Blink = False
        Me.UcnDspBit1.FieldName = "対抗J選択"
        Me.UcnDspBit1.Location = New System.Drawing.Point(12, 43)
        Me.UcnDspBit1.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit1.Name = "UcnDspBit1"
        Me.UcnDspBit1.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit1.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit1.Size = New System.Drawing.Size(105, 30)
        Me.UcnDspBit1.TabIndex = 70
        '
        'ucnLosZeroMode
        '
        Me.ucnLosZeroMode.BackColor = System.Drawing.Color.Transparent
        Me.ucnLosZeroMode.BitStatus = True
        Me.ucnLosZeroMode.Blink = False
        Me.ucnLosZeroMode.FieldName = "同時施工"
        Me.ucnLosZeroMode.Location = New System.Drawing.Point(12, 8)
        Me.ucnLosZeroMode.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnLosZeroMode.Name = "ucnLosZeroMode"
        Me.ucnLosZeroMode.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnLosZeroMode.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnLosZeroMode.Size = New System.Drawing.Size(105, 30)
        Me.ucnLosZeroMode.TabIndex = 69
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(127, 324)
        Me.ShapeContainer1.TabIndex = 134
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 126
        Me.LineShape1.Y1 = 160
        Me.LineShape1.Y2 = 161
        '
        'ｂｔｎLossZerooCancel
        '
        Me.ｂｔｎLossZerooCancel.BackColor = System.Drawing.Color.DarkGray
        Me.ｂｔｎLossZerooCancel.Font = New System.Drawing.Font("MS UI Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ｂｔｎLossZerooCancel.Location = New System.Drawing.Point(1755, 390)
        Me.ｂｔｎLossZerooCancel.Name = "ｂｔｎLossZerooCancel"
        Me.ｂｔｎLossZerooCancel.Size = New System.Drawing.Size(125, 36)
        Me.ｂｔｎLossZerooCancel.TabIndex = 123
        Me.ｂｔｎLossZerooCancel.Text = "同時施工" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "キャンセル"
        Me.ｂｔｎLossZerooCancel.UseVisualStyleBackColor = False
        '
        'ucnVerLineChart
        '
        Me.ucnVerLineChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerLineChart.CenterColor = System.Drawing.Color.MistyRose
        Me.ucnVerLineChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnVerLineChart.ChartHeight = 100
        Me.ucnVerLineChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnVerLineChart.CorrectData = 360.0!
        Me.ucnVerLineChart.DecimalPlaces = CType(2, Short)
        Me.ucnVerLineChart.FieldName = "ピッチ角(deg)"
        Me.ucnVerLineChart.GraphHeight = 2.0!
        Me.ucnVerLineChart.Location = New System.Drawing.Point(799, 886)
        Me.ucnVerLineChart.Name = "ucnVerLineChart"
        Me.ucnVerLineChart.PlanData = 360.0!
        Me.ucnVerLineChart.RealData = 360.0!
        Me.ucnVerLineChart.Size = New System.Drawing.Size(489, 172)
        Me.ucnVerLineChart.StrokeWidth = 2000
        Me.ucnVerLineChart.TabIndex = 124
        Me.ucnVerLineChart.TargetData = 360.0!
        '
        'ucnHorLineChart
        '
        Me.ucnHorLineChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorLineChart.CenterColor = System.Drawing.Color.Silver
        Me.ucnHorLineChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnHorLineChart.ChartHeight = 180
        Me.ucnHorLineChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnHorLineChart.CorrectData = 360.0!
        Me.ucnHorLineChart.DecimalPlaces = CType(2, Short)
        Me.ucnHorLineChart.FieldName = "方位角(deg)"
        Me.ucnHorLineChart.GraphHeight = 2.0!
        Me.ucnHorLineChart.Location = New System.Drawing.Point(802, 676)
        Me.ucnHorLineChart.Name = "ucnHorLineChart"
        Me.ucnHorLineChart.PlanData = 360.0!
        Me.ucnHorLineChart.RealData = 360.0!
        Me.ucnHorLineChart.Size = New System.Drawing.Size(489, 232)
        Me.ucnHorLineChart.StrokeWidth = 2000
        Me.ucnHorLineChart.TabIndex = 125
        Me.ucnHorLineChart.TargetData = 360.0!
        '
        'ucnHorDevChart
        '
        Me.ucnHorDevChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorDevChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnHorDevChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnHorDevChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnHorDevChart.DecimalPlaces = CType(2, Short)
        Me.ucnHorDevChart.FieldName = "水平偏角(deg)"
        Me.ucnHorDevChart.GraphHeight = 2.0!
        Me.ucnHorDevChart.Location = New System.Drawing.Point(398, 765)
        Me.ucnHorDevChart.Name = "ucnHorDevChart"
        Me.ucnHorDevChart.Size = New System.Drawing.Size(398, 143)
        Me.ucnHorDevChart.StrokeWidth = 1500
        Me.ucnHorDevChart.TabIndex = 99
        '
        'ucnHorMomentChart
        '
        Me.ucnHorMomentChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorMomentChart.CenterColor = System.Drawing.Color.Black
        Me.ucnHorMomentChart.ChartBakColor = System.Drawing.Color.White
        Me.ucnHorMomentChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnHorMomentChart.DecimalPlaces = CType(0, Short)
        Me.ucnHorMomentChart.FieldName = "水平ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        Me.ucnHorMomentChart.GraphHeight = 10000.0!
        Me.ucnHorMomentChart.Location = New System.Drawing.Point(4, 765)
        Me.ucnHorMomentChart.Name = "ucnHorMomentChart"
        Me.ucnHorMomentChart.Size = New System.Drawing.Size(398, 144)
        Me.ucnHorMomentChart.StrokeWidth = 1500
        Me.ucnHorMomentChart.TabIndex = 97
        '
        'DspAssemblyPattern
        '
        Me.DspAssemblyPattern.BackColor = System.Drawing.Color.Transparent
        Me.DspAssemblyPattern.Blink = False
        Me.DspAssemblyPattern.BlinkColor = System.Drawing.Color.Red
        Me.DspAssemblyPattern.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAssemblyPattern.DataWidth = 182
        Me.DspAssemblyPattern.DecimalPlaces = CType(0, Short)
        Me.DspAssemblyPattern.FieldName = "組立パターン"
        Me.DspAssemblyPattern.FieldNameWidth = 292
        Me.DspAssemblyPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(1409, 501)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(505, 32)
        Me.DspAssemblyPattern.TabIndex = 111
        Me.DspAssemblyPattern.Unit = "deg"
        Me.DspAssemblyPattern.UnitVisible = False
        Me.DspAssemblyPattern.Value = "RC甲1"
        Me.DspAssemblyPattern.ValueType = True
        '
        'DspNextPieceName
        '
        Me.DspNextPieceName.BackColor = System.Drawing.Color.Transparent
        Me.DspNextPieceName.Blink = False
        Me.DspNextPieceName.BlinkColor = System.Drawing.Color.Red
        Me.DspNextPieceName.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspNextPieceName.DataWidth = 91
        Me.DspNextPieceName.DecimalPlaces = CType(2, Short)
        Me.DspNextPieceName.FieldName = "次の組立ﾋﾟｰｽ"
        Me.DspNextPieceName.FieldNameWidth = 146
        Me.DspNextPieceName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspNextPieceName.Location = New System.Drawing.Point(1643, 637)
        Me.DspNextPieceName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspNextPieceName.Name = "DspNextPieceName"
        Me.DspNextPieceName.Size = New System.Drawing.Size(247, 32)
        Me.DspNextPieceName.TabIndex = 110
        Me.DspNextPieceName.Unit = "deg"
        Me.DspNextPieceName.UnitVisible = False
        Me.DspNextPieceName.Value = "A1-3"
        Me.DspNextPieceName.ValueType = True
        '
        'UcnDspData24
        '
        Me.UcnDspData24.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData24.Blink = False
        Me.UcnDspData24.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData24.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcnDspData24.DataWidth = 91
        Me.UcnDspData24.DecimalPlaces = CType(2, Short)
        Me.UcnDspData24.FieldName = "RL考慮ｼﾞｬｯｷ"
        Me.UcnDspData24.FieldNameWidth = 146
        Me.UcnDspData24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData24.Location = New System.Drawing.Point(1409, 637)
        Me.UcnDspData24.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData24.Name = "UcnDspData24"
        Me.UcnDspData24.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData24.TabIndex = 109
        Me.UcnDspData24.Unit = "deg"
        Me.UcnDspData24.UnitVisible = False
        Me.UcnDspData24.Value = "-"
        Me.UcnDspData24.ValueType = True
        '
        'UcnDspData21
        '
        Me.UcnDspData21.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData21.Blink = False
        Me.UcnDspData21.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData21.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcnDspData21.DataWidth = 91
        Me.UcnDspData21.DecimalPlaces = CType(0, Short)
        Me.UcnDspData21.FieldName = "追加推進ｼﾞｬｯｷ"
        Me.UcnDspData21.FieldNameWidth = 146
        Me.UcnDspData21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData21.Location = New System.Drawing.Point(1643, 603)
        Me.UcnDspData21.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData21.Name = "UcnDspData21"
        Me.UcnDspData21.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData21.TabIndex = 108
        Me.UcnDspData21.Unit = "deg"
        Me.UcnDspData21.UnitVisible = False
        Me.UcnDspData21.Value = "24"
        Me.UcnDspData21.ValueType = True
        '
        'UcnDspData22
        '
        Me.UcnDspData22.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData22.Blink = False
        Me.UcnDspData22.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData22.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcnDspData22.DataWidth = 91
        Me.UcnDspData22.DecimalPlaces = CType(2, Short)
        Me.UcnDspData22.FieldName = "押込推進ｼﾞｬｯｷ"
        Me.UcnDspData22.FieldNameWidth = 146
        Me.UcnDspData22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData22.Location = New System.Drawing.Point(1409, 603)
        Me.UcnDspData22.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData22.Name = "UcnDspData22"
        Me.UcnDspData22.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData22.TabIndex = 107
        Me.UcnDspData22.Unit = "deg"
        Me.UcnDspData22.UnitVisible = False
        Me.UcnDspData22.Value = "21-23"
        Me.UcnDspData22.ValueType = True
        '
        'DspClosetJack
        '
        Me.DspClosetJack.BackColor = System.Drawing.Color.Transparent
        Me.DspClosetJack.Blink = False
        Me.DspClosetJack.BlinkColor = System.Drawing.Color.Red
        Me.DspClosetJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspClosetJack.DataWidth = 91
        Me.DspClosetJack.DecimalPlaces = CType(0, Short)
        Me.DspClosetJack.FieldName = "押込ｼﾞｬｯｷ"
        Me.DspClosetJack.FieldNameWidth = 146
        Me.DspClosetJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspClosetJack.Location = New System.Drawing.Point(1643, 568)
        Me.DspClosetJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetJack.Name = "DspClosetJack"
        Me.DspClosetJack.Size = New System.Drawing.Size(247, 32)
        Me.DspClosetJack.TabIndex = 106
        Me.DspClosetJack.Unit = "deg"
        Me.DspClosetJack.UnitVisible = False
        Me.DspClosetJack.Value = "20"
        Me.DspClosetJack.ValueType = True
        '
        'DspPullBackJack
        '
        Me.DspPullBackJack.BackColor = System.Drawing.Color.Transparent
        Me.DspPullBackJack.Blink = False
        Me.DspPullBackJack.BlinkColor = System.Drawing.Color.Red
        Me.DspPullBackJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspPullBackJack.DataWidth = 91
        Me.DspPullBackJack.DecimalPlaces = CType(2, Short)
        Me.DspPullBackJack.FieldName = "引戻ｼﾞｬｯｷ"
        Me.DspPullBackJack.FieldNameWidth = 146
        Me.DspPullBackJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPullBackJack.Location = New System.Drawing.Point(1409, 568)
        Me.DspPullBackJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPullBackJack.Name = "DspPullBackJack"
        Me.DspPullBackJack.Size = New System.Drawing.Size(244, 32)
        Me.DspPullBackJack.TabIndex = 105
        Me.DspPullBackJack.Unit = "deg"
        Me.DspPullBackJack.UnitVisible = False
        Me.DspPullBackJack.Value = "19-23"
        Me.DspPullBackJack.ValueType = True
        '
        'UcnDspData17
        '
        Me.UcnDspData17.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData17.Blink = False
        Me.UcnDspData17.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData17.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData17.DataWidth = 91
        Me.UcnDspData17.DecimalPlaces = CType(2, Short)
        Me.UcnDspData17.FieldName = "ﾛｰﾘﾝｸﾞ偏差"
        Me.UcnDspData17.FieldNameWidth = 146
        Me.UcnDspData17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData17.Location = New System.Drawing.Point(1643, 535)
        Me.UcnDspData17.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData17.Name = "UcnDspData17"
        Me.UcnDspData17.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData17.TabIndex = 104
        Me.UcnDspData17.Unit = "deg"
        Me.UcnDspData17.UnitVisible = False
        Me.UcnDspData17.Value = "0.1"
        Me.UcnDspData17.ValueType = False
        '
        'DspAssemblyPieace
        '
        Me.DspAssemblyPieace.BackColor = System.Drawing.Color.Transparent
        Me.DspAssemblyPieace.Blink = False
        Me.DspAssemblyPieace.BlinkColor = System.Drawing.Color.Red
        Me.DspAssemblyPieace.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAssemblyPieace.DataWidth = 91
        Me.DspAssemblyPieace.DecimalPlaces = CType(2, Short)
        Me.DspAssemblyPieace.FieldName = "組立ﾋﾟｰｽ"
        Me.DspAssemblyPieace.FieldNameWidth = 146
        Me.DspAssemblyPieace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(1409, 535)
        Me.DspAssemblyPieace.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPieace.Name = "DspAssemblyPieace"
        Me.DspAssemblyPieace.Size = New System.Drawing.Size(244, 32)
        Me.DspAssemblyPieace.TabIndex = 103
        Me.DspAssemblyPieace.Unit = "deg"
        Me.DspAssemblyPieace.UnitVisible = False
        Me.DspAssemblyPieace.Value = "A2-1"
        Me.DspAssemblyPieace.ValueType = True
        '
        'UcnDspData2
        '
        Me.UcnDspData2.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData2.Blink = False
        Me.UcnDspData2.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData2.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData2.DataWidth = 91
        Me.UcnDspData2.DecimalPlaces = CType(0, Short)
        Me.UcnDspData2.FieldName = "組立ﾎﾞﾙﾄﾋﾟｯﾁ"
        Me.UcnDspData2.FieldNameWidth = 146
        Me.UcnDspData2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData2.Location = New System.Drawing.Point(1643, 466)
        Me.UcnDspData2.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData2.Name = "UcnDspData2"
        Me.UcnDspData2.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData2.TabIndex = 102
        Me.UcnDspData2.Unit = "deg"
        Me.UcnDspData2.UnitVisible = False
        Me.UcnDspData2.Value = "3"
        Me.UcnDspData2.ValueType = False
        '
        'UcnDspData1
        '
        Me.UcnDspData1.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData1.Blink = False
        Me.UcnDspData1.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData1.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcnDspData1.DataWidth = 91
        Me.UcnDspData1.DecimalPlaces = CType(0, Short)
        Me.UcnDspData1.FieldName = "組立ｾｸﾞﾒﾝﾄ"
        Me.UcnDspData1.FieldNameWidth = 146
        Me.UcnDspData1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData1.Location = New System.Drawing.Point(1409, 466)
        Me.UcnDspData1.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData1.Name = "UcnDspData1"
        Me.UcnDspData1.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData1.TabIndex = 101
        Me.UcnDspData1.Unit = "deg"
        Me.UcnDspData1.UnitVisible = False
        Me.UcnDspData1.Value = "RC20ST"
        Me.UcnDspData1.ValueType = True
        '
        'ucnVerDevChart
        '
        Me.ucnVerDevChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerDevChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnVerDevChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnVerDevChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnVerDevChart.DecimalPlaces = CType(2, Short)
        Me.ucnVerDevChart.FieldName = "鉛直偏角(deg)"
        Me.ucnVerDevChart.GraphHeight = 2.0!
        Me.ucnVerDevChart.Location = New System.Drawing.Point(398, 901)
        Me.ucnVerDevChart.Name = "ucnVerDevChart"
        Me.ucnVerDevChart.Size = New System.Drawing.Size(398, 148)
        Me.ucnVerDevChart.StrokeWidth = 1500
        Me.ucnVerDevChart.TabIndex = 100
        '
        'ucnVerMomentChart
        '
        Me.ucnVerMomentChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerMomentChart.CenterColor = System.Drawing.Color.Black
        Me.ucnVerMomentChart.ChartBakColor = System.Drawing.Color.White
        Me.ucnVerMomentChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnVerMomentChart.DecimalPlaces = CType(0, Short)
        Me.ucnVerMomentChart.FieldName = "鉛直ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        Me.ucnVerMomentChart.GraphHeight = 10000.0!
        Me.ucnVerMomentChart.Location = New System.Drawing.Point(0, 901)
        Me.ucnVerMomentChart.Name = "ucnVerMomentChart"
        Me.ucnVerMomentChart.Size = New System.Drawing.Size(398, 148)
        Me.ucnVerMomentChart.StrokeWidth = 1500
        Me.ucnVerMomentChart.TabIndex = 98
        '
        'UcnGpPvBarGraph
        '
        Me.UcnGpPvBarGraph.AutoSize = True
        Me.UcnGpPvBarGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UcnGpPvBarGraph.GpFlg = Nothing
        Me.UcnGpPvBarGraph.GpPv = Nothing
        Me.UcnGpPvBarGraph.Location = New System.Drawing.Point(12, 145)
        Me.UcnGpPvBarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.UcnGpPvBarGraph.Name = "UcnGpPvBarGraph"
        Me.UcnGpPvBarGraph.NumberGroup = 26
        Me.UcnGpPvBarGraph.PresBarGraphWidt = 50.0!
        Me.UcnGpPvBarGraph.Size = New System.Drawing.Size(79, 555)
        Me.UcnGpPvBarGraph.TabIndex = 96
        '
        'UcnDspDevImg
        '
        Me.UcnDspDevImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcnDspDevImg.HorDev = 0.3R
        Me.UcnDspDevImg.Location = New System.Drawing.Point(903, 31)
        Me.UcnDspDevImg.Name = "UcnDspDevImg"
        Me.UcnDspDevImg.Size = New System.Drawing.Size(150, 150)
        Me.UcnDspDevImg.TabIndex = 95
        Me.UcnDspDevImg.VerDev = -0.1R
        '
        'DspRightSpeed
        '
        Me.DspRightSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspRightSpeed.DecimalPlaces = CType(0, Short)
        Me.DspRightSpeed.FieldName = "右速度"
        Me.DspRightSpeed.Location = New System.Drawing.Point(908, 362)
        Me.DspRightSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightSpeed.Name = "DspRightSpeed"
        Me.DspRightSpeed.Size = New System.Drawing.Size(150, 46)
        Me.DspRightSpeed.TabIndex = 49
        Me.DspRightSpeed.Unit = "mm/min"
        Me.DspRightSpeed.Value = 1234.0R
        '
        'DspRightRealStroke
        '
        Me.DspRightRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRightRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspRightRealStroke.FieldName = "右ST実"
        Me.DspRightRealStroke.Location = New System.Drawing.Point(913, 311)
        Me.DspRightRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightRealStroke.Name = "DspRightRealStroke"
        Me.DspRightRealStroke.Size = New System.Drawing.Size(145, 46)
        Me.DspRightRealStroke.TabIndex = 48
        Me.DspRightRealStroke.Unit = "mm"
        Me.DspRightRealStroke.Value = 1234.0R
        '
        'DspLeftSpeed
        '
        Me.DspLeftSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftSpeed.DecimalPlaces = CType(0, Short)
        Me.DspLeftSpeed.FieldName = "左速度"
        Me.DspLeftSpeed.Location = New System.Drawing.Point(112, 362)
        Me.DspLeftSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftSpeed.Name = "DspLeftSpeed"
        Me.DspLeftSpeed.Size = New System.Drawing.Size(139, 46)
        Me.DspLeftSpeed.TabIndex = 45
        Me.DspLeftSpeed.Unit = "mm/min"
        Me.DspLeftSpeed.Value = 1234.0R
        '
        'DspLeftRealStroke
        '
        Me.DspLeftRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspLeftRealStroke.FieldName = "左ST実"
        Me.DspLeftRealStroke.Location = New System.Drawing.Point(112, 311)
        Me.DspLeftRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftRealStroke.Name = "DspLeftRealStroke"
        Me.DspLeftRealStroke.Size = New System.Drawing.Size(139, 46)
        Me.DspLeftRealStroke.TabIndex = 44
        Me.DspLeftRealStroke.Unit = "mm"
        Me.DspLeftRealStroke.Value = 1234.0R
        '
        'DspUpSpeed
        '
        Me.DspUpSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspUpSpeed.DecimalPlaces = CType(0, Short)
        Me.DspUpSpeed.FieldName = "上速度"
        Me.DspUpSpeed.Location = New System.Drawing.Point(112, 214)
        Me.DspUpSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspUpSpeed.Name = "DspUpSpeed"
        Me.DspUpSpeed.Size = New System.Drawing.Size(139, 46)
        Me.DspUpSpeed.TabIndex = 43
        Me.DspUpSpeed.Unit = "mm/min"
        Me.DspUpSpeed.Value = 1234.0R
        '
        'DspUpRealStroke
        '
        Me.DspUpRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspUpRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspUpRealStroke.FieldName = "上ST実"
        Me.DspUpRealStroke.Location = New System.Drawing.Point(112, 162)
        Me.DspUpRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspUpRealStroke.Name = "DspUpRealStroke"
        Me.DspUpRealStroke.Size = New System.Drawing.Size(139, 46)
        Me.DspUpRealStroke.TabIndex = 42
        Me.DspUpRealStroke.Unit = "mm"
        Me.DspUpRealStroke.Value = 1234.0R
        '
        'DspBottomSpeed
        '
        Me.DspBottomSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomSpeed.DecimalPlaces = CType(0, Short)
        Me.DspBottomSpeed.FieldName = "下速度"
        Me.DspBottomSpeed.Location = New System.Drawing.Point(112, 584)
        Me.DspBottomSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspBottomSpeed.Name = "DspBottomSpeed"
        Me.DspBottomSpeed.Size = New System.Drawing.Size(140, 46)
        Me.DspBottomSpeed.TabIndex = 47
        Me.DspBottomSpeed.Unit = "mm/min"
        Me.DspBottomSpeed.Value = 1234.0R
        '
        'DspRealBottomStroke
        '
        Me.DspRealBottomStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRealBottomStroke.DecimalPlaces = CType(0, Short)
        Me.DspRealBottomStroke.FieldName = "下ST実"
        Me.DspRealBottomStroke.Location = New System.Drawing.Point(112, 532)
        Me.DspRealBottomStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRealBottomStroke.Name = "DspRealBottomStroke"
        Me.DspRealBottomStroke.Size = New System.Drawing.Size(140, 46)
        Me.DspRealBottomStroke.TabIndex = 46
        Me.DspRealBottomStroke.Unit = "mm"
        Me.DspRealBottomStroke.Value = 1234.0R
        '
        'UcnDspData9
        '
        Me.UcnDspData9.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData9.Blink = False
        Me.UcnDspData9.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData9.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData9.DataWidth = 91
        Me.UcnDspData9.DecimalPlaces = CType(2, Short)
        Me.UcnDspData9.FieldName = ""
        Me.UcnDspData9.FieldNameWidth = 146
        Me.UcnDspData9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData9.Location = New System.Drawing.Point(1409, 394)
        Me.UcnDspData9.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData9.Name = "UcnDspData9"
        Me.UcnDspData9.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData9.TabIndex = 80
        Me.UcnDspData9.Unit = ""
        Me.UcnDspData9.UnitVisible = True
        Me.UcnDspData9.Value = "123.45 "
        Me.UcnDspData9.ValueType = False
        '
        'UcnDspData10
        '
        Me.UcnDspData10.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData10.Blink = False
        Me.UcnDspData10.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData10.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData10.DataWidth = 91
        Me.UcnDspData10.DecimalPlaces = CType(2, Short)
        Me.UcnDspData10.FieldName = ""
        Me.UcnDspData10.FieldNameWidth = 146
        Me.UcnDspData10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData10.Location = New System.Drawing.Point(1409, 360)
        Me.UcnDspData10.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData10.Name = "UcnDspData10"
        Me.UcnDspData10.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData10.TabIndex = 79
        Me.UcnDspData10.Unit = ""
        Me.UcnDspData10.UnitVisible = True
        Me.UcnDspData10.Value = "123.45 "
        Me.UcnDspData10.ValueType = False
        '
        'UcnDspData11
        '
        Me.UcnDspData11.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData11.Blink = False
        Me.UcnDspData11.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData11.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData11.DataWidth = 91
        Me.UcnDspData11.DecimalPlaces = CType(2, Short)
        Me.UcnDspData11.FieldName = ""
        Me.UcnDspData11.FieldNameWidth = 146
        Me.UcnDspData11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData11.Location = New System.Drawing.Point(1409, 330)
        Me.UcnDspData11.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData11.Name = "UcnDspData11"
        Me.UcnDspData11.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData11.TabIndex = 78
        Me.UcnDspData11.Unit = ""
        Me.UcnDspData11.UnitVisible = True
        Me.UcnDspData11.Value = "123.45 "
        Me.UcnDspData11.ValueType = False
        '
        'UcnDspData12
        '
        Me.UcnDspData12.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData12.Blink = False
        Me.UcnDspData12.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData12.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData12.DataWidth = 91
        Me.UcnDspData12.DecimalPlaces = CType(2, Short)
        Me.UcnDspData12.FieldName = ""
        Me.UcnDspData12.FieldNameWidth = 146
        Me.UcnDspData12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData12.Location = New System.Drawing.Point(1409, 296)
        Me.UcnDspData12.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData12.Name = "UcnDspData12"
        Me.UcnDspData12.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData12.TabIndex = 77
        Me.UcnDspData12.Unit = ""
        Me.UcnDspData12.UnitVisible = True
        Me.UcnDspData12.Value = "123.45 "
        Me.UcnDspData12.ValueType = False
        '
        'UcnDspData13
        '
        Me.UcnDspData13.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData13.Blink = False
        Me.UcnDspData13.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData13.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData13.DataWidth = 91
        Me.UcnDspData13.DecimalPlaces = CType(2, Short)
        Me.UcnDspData13.FieldName = ""
        Me.UcnDspData13.FieldNameWidth = 146
        Me.UcnDspData13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData13.Location = New System.Drawing.Point(1409, 262)
        Me.UcnDspData13.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData13.Name = "UcnDspData13"
        Me.UcnDspData13.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData13.TabIndex = 76
        Me.UcnDspData13.Unit = ""
        Me.UcnDspData13.UnitVisible = True
        Me.UcnDspData13.Value = "123.45 "
        Me.UcnDspData13.ValueType = False
        '
        'UcnDspData14
        '
        Me.UcnDspData14.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData14.Blink = False
        Me.UcnDspData14.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData14.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData14.DataWidth = 91
        Me.UcnDspData14.DecimalPlaces = CType(2, Short)
        Me.UcnDspData14.FieldName = ""
        Me.UcnDspData14.FieldNameWidth = 146
        Me.UcnDspData14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData14.Location = New System.Drawing.Point(1409, 228)
        Me.UcnDspData14.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData14.Name = "UcnDspData14"
        Me.UcnDspData14.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData14.TabIndex = 75
        Me.UcnDspData14.Unit = ""
        Me.UcnDspData14.UnitVisible = True
        Me.UcnDspData14.Value = "123.45 "
        Me.UcnDspData14.ValueType = False
        '
        'UcnDspData7
        '
        Me.UcnDspData7.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData7.Blink = False
        Me.UcnDspData7.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData7.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData7.DataWidth = 91
        Me.UcnDspData7.DecimalPlaces = CType(2, Short)
        Me.UcnDspData7.FieldName = ""
        Me.UcnDspData7.FieldNameWidth = 146
        Me.UcnDspData7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData7.Location = New System.Drawing.Point(1409, 196)
        Me.UcnDspData7.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData7.Name = "UcnDspData7"
        Me.UcnDspData7.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData7.TabIndex = 74
        Me.UcnDspData7.Unit = ""
        Me.UcnDspData7.UnitVisible = True
        Me.UcnDspData7.Value = "123.45 "
        Me.UcnDspData7.ValueType = False
        '
        'UcnDspData8
        '
        Me.UcnDspData8.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData8.Blink = False
        Me.UcnDspData8.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData8.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData8.DataWidth = 91
        Me.UcnDspData8.DecimalPlaces = CType(2, Short)
        Me.UcnDspData8.FieldName = ""
        Me.UcnDspData8.FieldNameWidth = 146
        Me.UcnDspData8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData8.Location = New System.Drawing.Point(1409, 162)
        Me.UcnDspData8.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData8.Name = "UcnDspData8"
        Me.UcnDspData8.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData8.TabIndex = 73
        Me.UcnDspData8.Unit = ""
        Me.UcnDspData8.UnitVisible = True
        Me.UcnDspData8.Value = "123.45 "
        Me.UcnDspData8.ValueType = False
        '
        'UcnDspData5
        '
        Me.UcnDspData5.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData5.Blink = False
        Me.UcnDspData5.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData5.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData5.DataWidth = 91
        Me.UcnDspData5.DecimalPlaces = CType(2, Short)
        Me.UcnDspData5.FieldName = ""
        Me.UcnDspData5.FieldNameWidth = 146
        Me.UcnDspData5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData5.Location = New System.Drawing.Point(1409, 132)
        Me.UcnDspData5.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData5.Name = "UcnDspData5"
        Me.UcnDspData5.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData5.TabIndex = 72
        Me.UcnDspData5.Unit = ""
        Me.UcnDspData5.UnitVisible = True
        Me.UcnDspData5.Value = "123.45 "
        Me.UcnDspData5.ValueType = False
        '
        'UcnDspData6
        '
        Me.UcnDspData6.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData6.Blink = False
        Me.UcnDspData6.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData6.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData6.DataWidth = 91
        Me.UcnDspData6.DecimalPlaces = CType(2, Short)
        Me.UcnDspData6.FieldName = ""
        Me.UcnDspData6.FieldNameWidth = 146
        Me.UcnDspData6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData6.Location = New System.Drawing.Point(1409, 98)
        Me.UcnDspData6.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData6.Name = "UcnDspData6"
        Me.UcnDspData6.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData6.TabIndex = 71
        Me.UcnDspData6.Unit = ""
        Me.UcnDspData6.UnitVisible = True
        Me.UcnDspData6.Value = "123.45 "
        Me.UcnDspData6.ValueType = False
        '
        'UcnDspData4
        '
        Me.UcnDspData4.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData4.Blink = False
        Me.UcnDspData4.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData4.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData4.DataWidth = 91
        Me.UcnDspData4.DecimalPlaces = CType(2, Short)
        Me.UcnDspData4.FieldName = ""
        Me.UcnDspData4.FieldNameWidth = 146
        Me.UcnDspData4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData4.Location = New System.Drawing.Point(1409, 64)
        Me.UcnDspData4.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData4.Name = "UcnDspData4"
        Me.UcnDspData4.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData4.TabIndex = 70
        Me.UcnDspData4.Unit = ""
        Me.UcnDspData4.UnitVisible = True
        Me.UcnDspData4.Value = "123.45 "
        Me.UcnDspData4.ValueType = False
        '
        'UcnDspData3
        '
        Me.UcnDspData3.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData3.Blink = False
        Me.UcnDspData3.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData3.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UcnDspData3.DataWidth = 91
        Me.UcnDspData3.DecimalPlaces = CType(2, Short)
        Me.UcnDspData3.FieldName = ""
        Me.UcnDspData3.FieldNameWidth = 146
        Me.UcnDspData3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData3.Location = New System.Drawing.Point(1409, 30)
        Me.UcnDspData3.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData3.Name = "UcnDspData3"
        Me.UcnDspData3.Size = New System.Drawing.Size(365, 32)
        Me.UcnDspData3.TabIndex = 69
        Me.UcnDspData3.Unit = ""
        Me.UcnDspData3.UnitVisible = True
        Me.UcnDspData3.Value = "123.45 "
        Me.UcnDspData3.ValueType = False
        '
        'UcnJackDsp
        '
        Me.UcnJackDsp.AutoSize = True
        Me.UcnJackDsp.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp.CopyStrechSet = 100
        Me.UcnJackDsp.FaiJack = Nothing
        Me.UcnJackDsp.FlexAutoManual = False
        Me.UcnJackDsp.FlexPointR = 0!
        Me.UcnJackDsp.FlexPointSeater = 0!
        Me.UcnJackDsp.FlexPointX = 0!
        Me.UcnJackDsp.FlexPointY = 0!
        Me.UcnJackDsp.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UcnJackDsp.GroupPV = New Single() {0!}
        Me.UcnJackDsp.JackAutoOneWayLimit = False
        Me.UcnJackDsp.JackAutoPid = False
        Me.UcnJackDsp.JackGroupPos = Nothing
        Me.UcnJackDsp.JackOrgPress = 0!
        Me.UcnJackDsp.JackStatus = New Short() {CType(0, Short)}
        Me.UcnJackDsp.Location = New System.Drawing.Point(173, 111)
        Me.UcnJackDsp.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnJackDsp.Name = "UcnJackDsp"
        Me.UcnJackDsp.NumberGroup = CType(0, Short)
        Me.UcnJackDsp.NumberJack = CType(0, Short)
        Me.UcnJackDsp.PieceAngle = CType(resources.GetObject("UcnJackDsp.PieceAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceCenterAngle = CType(resources.GetObject("UcnJackDsp.PieceCenterAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceName = CType(resources.GetObject("UcnJackDsp.PieceName"), System.Collections.Generic.List(Of String))
        Me.UcnJackDsp.Size = New System.Drawing.Size(795, 731)
        Me.UcnJackDsp.TabIndex = 68
        '
        'DspExcvSpeed
        '
        Me.DspExcvSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspExcvSpeed.Blink = False
        Me.DspExcvSpeed.BlinkColor = System.Drawing.Color.Red
        Me.DspExcvSpeed.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspExcvSpeed.DataWidth = 91
        Me.DspExcvSpeed.DecimalPlaces = CType(0, Short)
        Me.DspExcvSpeed.FieldName = "掘進速度"
        Me.DspExcvSpeed.FieldNameWidth = 146
        Me.DspExcvSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcvSpeed.Location = New System.Drawing.Point(4, 72)
        Me.DspExcvSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcvSpeed.Name = "DspExcvSpeed"
        Me.DspExcvSpeed.Size = New System.Drawing.Size(314, 35)
        Me.DspExcvSpeed.TabIndex = 41
        Me.DspExcvSpeed.Unit = "mm/min"
        Me.DspExcvSpeed.UnitVisible = True
        Me.DspExcvSpeed.Value = "123.45 "
        Me.DspExcvSpeed.ValueType = False
        '
        'DspAveStroke
        '
        Me.DspAveStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStroke.Blink = False
        Me.DspAveStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveStroke.DataWidth = 91
        Me.DspAveStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStroke.FieldName = "平均ｽﾄﾛｰｸ"
        Me.DspAveStroke.FieldNameWidth = 146
        Me.DspAveStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStroke.Location = New System.Drawing.Point(4, 39)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(314, 32)
        Me.DspAveStroke.TabIndex = 40
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.UnitVisible = True
        Me.DspAveStroke.Value = "123.45 "
        Me.DspAveStroke.ValueType = False
        '
        'DspTargetPitching
        '
        Me.DspTargetPitching.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetPitching.Blink = False
        Me.DspTargetPitching.BlinkColor = System.Drawing.Color.Red
        Me.DspTargetPitching.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTargetPitching.DataWidth = 91
        Me.DspTargetPitching.DecimalPlaces = CType(2, Short)
        Me.DspTargetPitching.FieldName = "目標ピッチ角"
        Me.DspTargetPitching.FieldNameWidth = 146
        Me.DspTargetPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetPitching.Location = New System.Drawing.Point(1072, 639)
        Me.DspTargetPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetPitching.Name = "DspTargetPitching"
        Me.DspTargetPitching.Size = New System.Drawing.Size(365, 36)
        Me.DspTargetPitching.TabIndex = 39
        Me.DspTargetPitching.Unit = "deg"
        Me.DspTargetPitching.UnitVisible = True
        Me.DspTargetPitching.Value = "123.45 "
        Me.DspTargetPitching.ValueType = False
        '
        'DspTargetDirection
        '
        Me.DspTargetDirection.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetDirection.Blink = False
        Me.DspTargetDirection.BlinkColor = System.Drawing.Color.Red
        Me.DspTargetDirection.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTargetDirection.DataWidth = 91
        Me.DspTargetDirection.DecimalPlaces = CType(2, Short)
        Me.DspTargetDirection.FieldName = "目標方位角"
        Me.DspTargetDirection.FieldNameWidth = 146
        Me.DspTargetDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetDirection.Location = New System.Drawing.Point(1072, 605)
        Me.DspTargetDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetDirection.Name = "DspTargetDirection"
        Me.DspTargetDirection.Size = New System.Drawing.Size(365, 32)
        Me.DspTargetDirection.TabIndex = 38
        Me.DspTargetDirection.Unit = "deg"
        Me.DspTargetDirection.UnitVisible = True
        Me.DspTargetDirection.Value = "123.45 "
        Me.DspTargetDirection.ValueType = False
        '
        'DspVerRChangePoint
        '
        Me.DspVerRChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspVerRChangePoint.Blink = False
        Me.DspVerRChangePoint.BlinkColor = System.Drawing.Color.Red
        Me.DspVerRChangePoint.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspVerRChangePoint.DataWidth = 91
        Me.DspVerRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerRChangePoint.FieldName = "後方変化点"
        Me.DspVerRChangePoint.FieldNameWidth = 146
        Me.DspVerRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerRChangePoint.Location = New System.Drawing.Point(1072, 565)
        Me.DspVerRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerRChangePoint.Name = "DspVerRChangePoint"
        Me.DspVerRChangePoint.Size = New System.Drawing.Size(365, 36)
        Me.DspVerRChangePoint.TabIndex = 37
        Me.DspVerRChangePoint.Unit = "m"
        Me.DspVerRChangePoint.UnitVisible = True
        Me.DspVerRChangePoint.Value = "123.45 "
        Me.DspVerRChangePoint.ValueType = False
        '
        'DspVerFChangePoint
        '
        Me.DspVerFChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspVerFChangePoint.Blink = False
        Me.DspVerFChangePoint.BlinkColor = System.Drawing.Color.Red
        Me.DspVerFChangePoint.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspVerFChangePoint.DataWidth = 91
        Me.DspVerFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerFChangePoint.FieldName = "前方変化点"
        Me.DspVerFChangePoint.FieldNameWidth = 146
        Me.DspVerFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerFChangePoint.Location = New System.Drawing.Point(1072, 531)
        Me.DspVerFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerFChangePoint.Name = "DspVerFChangePoint"
        Me.DspVerFChangePoint.Size = New System.Drawing.Size(365, 32)
        Me.DspVerFChangePoint.TabIndex = 36
        Me.DspVerFChangePoint.Unit = "m"
        Me.DspVerFChangePoint.UnitVisible = True
        Me.DspVerFChangePoint.Value = "123.45 "
        Me.DspVerFChangePoint.ValueType = False
        '
        'DspVerLine
        '
        Me.DspVerLine.BackColor = System.Drawing.Color.Transparent
        Me.DspVerLine.Blink = False
        Me.DspVerLine.BlinkColor = System.Drawing.Color.Red
        Me.DspVerLine.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspVerLine.DataWidth = 91
        Me.DspVerLine.DecimalPlaces = CType(3, Short)
        Me.DspVerLine.FieldName = "縦断線形"
        Me.DspVerLine.FieldNameWidth = 146
        Me.DspVerLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerLine.Location = New System.Drawing.Point(1072, 499)
        Me.DspVerLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerLine.Name = "DspVerLine"
        Me.DspVerLine.Size = New System.Drawing.Size(365, 36)
        Me.DspVerLine.TabIndex = 35
        Me.DspVerLine.Unit = "m"
        Me.DspVerLine.UnitVisible = True
        Me.DspVerLine.Value = "123.45 "
        Me.DspVerLine.ValueType = False
        '
        'DspHorRChangePoint
        '
        Me.DspHorRChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspHorRChangePoint.Blink = False
        Me.DspHorRChangePoint.BlinkColor = System.Drawing.Color.Red
        Me.DspHorRChangePoint.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorRChangePoint.DataWidth = 91
        Me.DspHorRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorRChangePoint.FieldName = "後方変化点"
        Me.DspHorRChangePoint.FieldNameWidth = 146
        Me.DspHorRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorRChangePoint.Location = New System.Drawing.Point(1072, 456)
        Me.DspHorRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorRChangePoint.Name = "DspHorRChangePoint"
        Me.DspHorRChangePoint.Size = New System.Drawing.Size(365, 36)
        Me.DspHorRChangePoint.TabIndex = 34
        Me.DspHorRChangePoint.Unit = "m"
        Me.DspHorRChangePoint.UnitVisible = True
        Me.DspHorRChangePoint.Value = "123.45 "
        Me.DspHorRChangePoint.ValueType = False
        '
        'DspHorFChangePoint
        '
        Me.DspHorFChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspHorFChangePoint.Blink = False
        Me.DspHorFChangePoint.BlinkColor = System.Drawing.Color.Red
        Me.DspHorFChangePoint.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorFChangePoint.DataWidth = 91
        Me.DspHorFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorFChangePoint.FieldName = "前方変化点"
        Me.DspHorFChangePoint.FieldNameWidth = 146
        Me.DspHorFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorFChangePoint.Location = New System.Drawing.Point(1072, 423)
        Me.DspHorFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorFChangePoint.Name = "DspHorFChangePoint"
        Me.DspHorFChangePoint.Size = New System.Drawing.Size(365, 32)
        Me.DspHorFChangePoint.TabIndex = 33
        Me.DspHorFChangePoint.Unit = "m"
        Me.DspHorFChangePoint.UnitVisible = True
        Me.DspHorFChangePoint.Value = "123.45 "
        Me.DspHorFChangePoint.ValueType = False
        '
        'DspHorLine
        '
        Me.DspHorLine.BackColor = System.Drawing.Color.Transparent
        Me.DspHorLine.Blink = False
        Me.DspHorLine.BlinkColor = System.Drawing.Color.Red
        Me.DspHorLine.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorLine.DataWidth = 91
        Me.DspHorLine.DecimalPlaces = CType(3, Short)
        Me.DspHorLine.FieldName = "平面線形"
        Me.DspHorLine.FieldNameWidth = 146
        Me.DspHorLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorLine.Location = New System.Drawing.Point(1072, 391)
        Me.DspHorLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorLine.Name = "DspHorLine"
        Me.DspHorLine.Size = New System.Drawing.Size(365, 36)
        Me.DspHorLine.TabIndex = 32
        Me.DspHorLine.Unit = "m"
        Me.DspHorLine.UnitVisible = True
        Me.DspHorLine.Value = "123.45 "
        Me.DspHorLine.ValueType = False
        '
        'DspDistance
        '
        Me.DspDistance.BackColor = System.Drawing.Color.Transparent
        Me.DspDistance.Blink = False
        Me.DspDistance.BlinkColor = System.Drawing.Color.Red
        Me.DspDistance.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspDistance.DataWidth = 91
        Me.DspDistance.DecimalPlaces = CType(3, Short)
        Me.DspDistance.FieldName = "中心の総距離"
        Me.DspDistance.FieldNameWidth = 146
        Me.DspDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDistance.Location = New System.Drawing.Point(1072, 353)
        Me.DspDistance.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDistance.Name = "DspDistance"
        Me.DspDistance.Size = New System.Drawing.Size(365, 36)
        Me.DspDistance.TabIndex = 31
        Me.DspDistance.Unit = "m"
        Me.DspDistance.UnitVisible = True
        Me.DspDistance.Value = "123.45 "
        Me.DspDistance.ValueType = False
        '
        'DspMoment
        '
        Me.DspMoment.BackColor = System.Drawing.Color.Transparent
        Me.DspMoment.Blink = False
        Me.DspMoment.BlinkColor = System.Drawing.Color.Red
        Me.DspMoment.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspMoment.DataWidth = 91
        Me.DspMoment.DecimalPlaces = CType(0, Short)
        Me.DspMoment.FieldName = "ｼﾞｬｯｷﾓｰﾒﾝﾄ"
        Me.DspMoment.FieldNameWidth = 146
        Me.DspMoment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspMoment.Location = New System.Drawing.Point(1072, 316)
        Me.DspMoment.Margin = New System.Windows.Forms.Padding(1)
        Me.DspMoment.Name = "DspMoment"
        Me.DspMoment.Size = New System.Drawing.Size(365, 36)
        Me.DspMoment.TabIndex = 30
        Me.DspMoment.Unit = "kN･m"
        Me.DspMoment.UnitVisible = True
        Me.DspMoment.Value = "123.45 "
        Me.DspMoment.ValueType = False
        '
        'DspThrust
        '
        Me.DspThrust.BackColor = System.Drawing.Color.Transparent
        Me.DspThrust.Blink = False
        Me.DspThrust.BlinkColor = System.Drawing.Color.Red
        Me.DspThrust.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspThrust.DataWidth = 91
        Me.DspThrust.DecimalPlaces = CType(0, Short)
        Me.DspThrust.FieldName = "推力"
        Me.DspThrust.FieldNameWidth = 146
        Me.DspThrust.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspThrust.Location = New System.Drawing.Point(1072, 282)
        Me.DspThrust.Margin = New System.Windows.Forms.Padding(1)
        Me.DspThrust.Name = "DspThrust"
        Me.DspThrust.Size = New System.Drawing.Size(365, 32)
        Me.DspThrust.TabIndex = 29
        Me.DspThrust.Unit = "ｋN"
        Me.DspThrust.UnitVisible = True
        Me.DspThrust.Value = "123.45 "
        Me.DspThrust.ValueType = False
        '
        'DspJackPress
        '
        Me.DspJackPress.BackColor = System.Drawing.Color.Transparent
        Me.DspJackPress.Blink = False
        Me.DspJackPress.BlinkColor = System.Drawing.Color.Red
        Me.DspJackPress.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspJackPress.DataWidth = 91
        Me.DspJackPress.DecimalPlaces = CType(1, Short)
        Me.DspJackPress.FieldName = "シールド圧"
        Me.DspJackPress.FieldNameWidth = 146
        Me.DspJackPress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspJackPress.Location = New System.Drawing.Point(1072, 246)
        Me.DspJackPress.Margin = New System.Windows.Forms.Padding(1)
        Me.DspJackPress.Name = "DspJackPress"
        Me.DspJackPress.Size = New System.Drawing.Size(365, 36)
        Me.DspJackPress.TabIndex = 28
        Me.DspJackPress.Unit = "MPa"
        Me.DspJackPress.UnitVisible = True
        Me.DspJackPress.Value = "123.45 "
        Me.DspJackPress.ValueType = False
        '
        'DspVerBroken
        '
        Me.DspVerBroken.BackColor = System.Drawing.Color.Transparent
        Me.DspVerBroken.Blink = False
        Me.DspVerBroken.BlinkColor = System.Drawing.Color.Red
        Me.DspVerBroken.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspVerBroken.DataWidth = 91
        Me.DspVerBroken.DecimalPlaces = CType(2, Short)
        Me.DspVerBroken.FieldName = "鉛直中折角"
        Me.DspVerBroken.FieldNameWidth = 146
        Me.DspVerBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerBroken.Location = New System.Drawing.Point(1072, 208)
        Me.DspVerBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerBroken.Name = "DspVerBroken"
        Me.DspVerBroken.Size = New System.Drawing.Size(365, 36)
        Me.DspVerBroken.TabIndex = 27
        Me.DspVerBroken.Unit = "deg"
        Me.DspVerBroken.UnitVisible = True
        Me.DspVerBroken.Value = "123.45 "
        Me.DspVerBroken.ValueType = False
        '
        'DspHorBroken
        '
        Me.DspHorBroken.BackColor = System.Drawing.Color.Transparent
        Me.DspHorBroken.Blink = False
        Me.DspHorBroken.BlinkColor = System.Drawing.Color.Red
        Me.DspHorBroken.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorBroken.DataWidth = 91
        Me.DspHorBroken.DecimalPlaces = CType(2, Short)
        Me.DspHorBroken.FieldName = "水平中折角"
        Me.DspHorBroken.FieldNameWidth = 146
        Me.DspHorBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorBroken.Location = New System.Drawing.Point(1072, 174)
        Me.DspHorBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorBroken.Name = "DspHorBroken"
        Me.DspHorBroken.Size = New System.Drawing.Size(365, 32)
        Me.DspHorBroken.TabIndex = 26
        Me.DspHorBroken.Unit = "deg"
        Me.DspHorBroken.UnitVisible = True
        Me.DspHorBroken.Value = "123.45 "
        Me.DspHorBroken.ValueType = False
        '
        'DspPitching
        '
        Me.DspPitching.BackColor = System.Drawing.Color.Transparent
        Me.DspPitching.Blink = False
        Me.DspPitching.BlinkColor = System.Drawing.Color.Red
        Me.DspPitching.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspPitching.DataWidth = 91
        Me.DspPitching.DecimalPlaces = CType(2, Short)
        Me.DspPitching.FieldName = "ピッチング"
        Me.DspPitching.FieldNameWidth = 146
        Me.DspPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPitching.Location = New System.Drawing.Point(1072, 137)
        Me.DspPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPitching.Name = "DspPitching"
        Me.DspPitching.Size = New System.Drawing.Size(365, 36)
        Me.DspPitching.TabIndex = 25
        Me.DspPitching.Unit = "deg"
        Me.DspPitching.UnitVisible = True
        Me.DspPitching.Value = "123.45 "
        Me.DspPitching.ValueType = False
        '
        'DspDirection
        '
        Me.DspDirection.BackColor = System.Drawing.Color.Transparent
        Me.DspDirection.Blink = False
        Me.DspDirection.BlinkColor = System.Drawing.Color.Red
        Me.DspDirection.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspDirection.DataWidth = 91
        Me.DspDirection.DecimalPlaces = CType(2, Short)
        Me.DspDirection.FieldName = "方位角"
        Me.DspDirection.FieldNameWidth = 146
        Me.DspDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDirection.Location = New System.Drawing.Point(1072, 103)
        Me.DspDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDirection.Name = "DspDirection"
        Me.DspDirection.Size = New System.Drawing.Size(365, 32)
        Me.DspDirection.TabIndex = 24
        Me.DspDirection.Unit = "deg"
        Me.DspDirection.UnitVisible = True
        Me.DspDirection.Value = "123.45 "
        Me.DspDirection.ValueType = False
        '
        'DspVerDev
        '
        Me.DspVerDev.BackColor = System.Drawing.Color.Transparent
        Me.DspVerDev.Blink = False
        Me.DspVerDev.BlinkColor = System.Drawing.Color.Red
        Me.DspVerDev.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspVerDev.DataWidth = 91
        Me.DspVerDev.DecimalPlaces = CType(2, Short)
        Me.DspVerDev.FieldName = "鉛直偏角"
        Me.DspVerDev.FieldNameWidth = 146
        Me.DspVerDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerDev.Location = New System.Drawing.Point(1072, 64)
        Me.DspVerDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerDev.Name = "DspVerDev"
        Me.DspVerDev.Size = New System.Drawing.Size(365, 36)
        Me.DspVerDev.TabIndex = 23
        Me.DspVerDev.Unit = "deg"
        Me.DspVerDev.UnitVisible = True
        Me.DspVerDev.Value = "123.45 "
        Me.DspVerDev.ValueType = False
        '
        'DspHorDev
        '
        Me.DspHorDev.BackColor = System.Drawing.Color.Transparent
        Me.DspHorDev.Blink = False
        Me.DspHorDev.BlinkColor = System.Drawing.Color.Red
        Me.DspHorDev.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorDev.DataWidth = 91
        Me.DspHorDev.DecimalPlaces = CType(2, Short)
        Me.DspHorDev.FieldName = "水平偏角"
        Me.DspHorDev.FieldNameWidth = 146
        Me.DspHorDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorDev.Location = New System.Drawing.Point(1072, 30)
        Me.DspHorDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorDev.Name = "DspHorDev"
        Me.DspHorDev.Size = New System.Drawing.Size(365, 32)
        Me.DspHorDev.TabIndex = 22
        Me.DspHorDev.Unit = "deg"
        Me.DspHorDev.UnitVisible = True
        Me.DspHorDev.Value = "123.45 "
        Me.DspHorDev.ValueType = False
        '
        'DspMachinComErr
        '
        Me.DspMachinComErr.BackColor = System.Drawing.Color.Transparent
        Me.DspMachinComErr.BitStatus = True
        Me.DspMachinComErr.Blink = True
        Me.DspMachinComErr.FieldName = "シールドマシン伝送異常"
        Me.DspMachinComErr.Location = New System.Drawing.Point(80, 20)
        Me.DspMachinComErr.Margin = New System.Windows.Forms.Padding(2)
        Me.DspMachinComErr.Name = "DspMachinComErr"
        Me.DspMachinComErr.OffBackColor = System.Drawing.Color.LightGray
        Me.DspMachinComErr.OnBackColor = System.Drawing.Color.Red
        Me.DspMachinComErr.Size = New System.Drawing.Size(409, 30)
        Me.DspMachinComErr.TabIndex = 74
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1914, 1060)
        Me.ControlBox = False
        Me.Controls.Add(Me.ucnVerLineChart)
        Me.Controls.Add(Me.ucnHorLineChart)
        Me.Controls.Add(Me.ucnHorDevChart)
        Me.Controls.Add(Me.ucnHorMomentChart)
        Me.Controls.Add(Me.ｂｔｎLossZerooCancel)
        Me.Controls.Add(Me.pnlLosZero)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DspAssemblyPattern)
        Me.Controls.Add(Me.DspNextPieceName)
        Me.Controls.Add(Me.UcnDspData24)
        Me.Controls.Add(Me.UcnDspData21)
        Me.Controls.Add(Me.UcnDspData22)
        Me.Controls.Add(Me.DspClosetJack)
        Me.Controls.Add(Me.DspPullBackJack)
        Me.Controls.Add(Me.UcnDspData17)
        Me.Controls.Add(Me.DspAssemblyPieace)
        Me.Controls.Add(Me.UcnDspData2)
        Me.Controls.Add(Me.UcnDspData1)
        Me.Controls.Add(Me.ucnVerDevChart)
        Me.Controls.Add(Me.ucnVerMomentChart)
        Me.Controls.Add(Me.UcnGpPvBarGraph)
        Me.Controls.Add(Me.UcnDspDevImg)
        Me.Controls.Add(Me.DspRightSpeed)
        Me.Controls.Add(Me.DspRightRealStroke)
        Me.Controls.Add(Me.DspLeftSpeed)
        Me.Controls.Add(Me.DspLeftRealStroke)
        Me.Controls.Add(Me.DspUpSpeed)
        Me.Controls.Add(Me.DspUpRealStroke)
        Me.Controls.Add(Me.DspBottomSpeed)
        Me.Controls.Add(Me.DspRealBottomStroke)
        Me.Controls.Add(Me.UcnDspData9)
        Me.Controls.Add(Me.UcnDspData10)
        Me.Controls.Add(Me.UcnDspData11)
        Me.Controls.Add(Me.UcnDspData12)
        Me.Controls.Add(Me.UcnDspData13)
        Me.Controls.Add(Me.UcnDspData14)
        Me.Controls.Add(Me.UcnDspData7)
        Me.Controls.Add(Me.UcnDspData8)
        Me.Controls.Add(Me.UcnDspData5)
        Me.Controls.Add(Me.UcnDspData6)
        Me.Controls.Add(Me.UcnDspData4)
        Me.Controls.Add(Me.UcnDspData3)
        Me.Controls.Add(Me.UcnJackDsp)
        Me.Controls.Add(Me.DspExcvSpeed)
        Me.Controls.Add(Me.DspAveStroke)
        Me.Controls.Add(Me.DspTargetPitching)
        Me.Controls.Add(Me.DspTargetDirection)
        Me.Controls.Add(Me.DspVerRChangePoint)
        Me.Controls.Add(Me.DspVerFChangePoint)
        Me.Controls.Add(Me.DspVerLine)
        Me.Controls.Add(Me.DspHorRChangePoint)
        Me.Controls.Add(Me.DspHorFChangePoint)
        Me.Controls.Add(Me.DspHorLine)
        Me.Controls.Add(Me.DspDistance)
        Me.Controls.Add(Me.DspMoment)
        Me.Controls.Add(Me.DspThrust)
        Me.Controls.Add(Me.DspJackPress)
        Me.Controls.Add(Me.DspVerBroken)
        Me.Controls.Add(Me.DspHorBroken)
        Me.Controls.Add(Me.DspPitching)
        Me.Controls.Add(Me.DspDirection)
        Me.Controls.Add(Me.DspVerDev)
        Me.Controls.Add(Me.DspHorDev)
        Me.Controls.Add(Me.MenuSystem)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuSystem
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "FLEX.NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuSystem.ResumeLayout(False)
        Me.MenuSystem.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlLosZero.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuSystem As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RingNoChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DspHorDev As FLEX.NET.ucnDspData
    Friend WithEvents DspVerDev As FLEX.NET.ucnDspData
    Friend WithEvents DspPitching As FLEX.NET.ucnDspData
    Friend WithEvents DspDirection As FLEX.NET.ucnDspData
    Friend WithEvents DspVerBroken As FLEX.NET.ucnDspData
    Friend WithEvents DspHorBroken As FLEX.NET.ucnDspData
    Friend WithEvents DspMoment As FLEX.NET.ucnDspData
    Friend WithEvents DspThrust As FLEX.NET.ucnDspData
    Friend WithEvents DspJackPress As FLEX.NET.ucnDspData
    Friend WithEvents DspDistance As FLEX.NET.ucnDspData
    Friend WithEvents DspHorRChangePoint As FLEX.NET.ucnDspData
    Friend WithEvents DspHorFChangePoint As FLEX.NET.ucnDspData
    Friend WithEvents DspHorLine As FLEX.NET.ucnDspData
    Friend WithEvents DspVerRChangePoint As FLEX.NET.ucnDspData
    Friend WithEvents DspVerFChangePoint As FLEX.NET.ucnDspData
    Friend WithEvents DspVerLine As FLEX.NET.ucnDspData
    Friend WithEvents DspTargetPitching As FLEX.NET.ucnDspData
    Friend WithEvents DspTargetDirection As FLEX.NET.ucnDspData
    Friend WithEvents DspExcvSpeed As FLEX.NET.ucnDspData
    Friend WithEvents DspAveStroke As FLEX.NET.ucnDspData
    Friend WithEvents DspUpRealStroke As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspUpSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspLeftSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspLeftRealStroke As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspBottomSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspRealBottomStroke As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspRightSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspRightRealStroke As FLEX.NET.ucnDspDataMin
    Public WithEvents tmrDataDsp As System.Windows.Forms.Timer
    Friend WithEvents RingNoUpdateSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InitialSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanDataSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcavEnforceStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcavEnforceStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperationRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DspSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScaleSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PressParameter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneDirectionParameter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneDirectionLimit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresBlock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagmentMethd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LossZeroConcern As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OterSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadPlanData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SegmentEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssemblyProcessEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 目標ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorrectionValMng As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RingCloseValueMng As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ウインドウToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UcnJackDsp As FLEX.NET.ucnJackDsp
    Friend WithEvents UcnDspData3 As ucnDspData
    Friend WithEvents UcnDspData4 As ucnDspData
    Friend WithEvents UcnDspData5 As ucnDspData
    Friend WithEvents UcnDspData6 As ucnDspData
    Friend WithEvents UcnDspData7 As ucnDspData
    Friend WithEvents UcnDspData8 As ucnDspData
    Friend WithEvents UcnDspData9 As ucnDspData
    Friend WithEvents UcnDspData10 As ucnDspData
    Friend WithEvents UcnDspData11 As ucnDspData
    Friend WithEvents UcnDspData12 As ucnDspData
    Friend WithEvents UcnDspData13 As ucnDspData
    Friend WithEvents UcnDspData14 As ucnDspData
    Friend WithEvents TuningMonitorClicｋ As ToolStripMenuItem
    Friend WithEvents UcnDspDevImg As ucnDspDevImg
    Friend WithEvents UcnGpPvBarGraph As ucnGpPvBarGraph
    Friend WithEvents ucnHorMomentChart As ucnChart
    Friend WithEvents ucnVerMomentChart As ucnChart
    Friend WithEvents ucnHorDevChart As ucnChart
    Friend WithEvents ucnVerDevChart As ucnChart
    Friend WithEvents UcnDspData1 As ucnDspData
    Friend WithEvents UcnDspData2 As ucnDspData
    Friend WithEvents UcnDspData17 As ucnDspData
    Friend WithEvents DspAssemblyPieace As ucnDspData
    Friend WithEvents DspClosetJack As ucnDspData
    Friend WithEvents DspPullBackJack As ucnDspData
    Friend WithEvents UcnDspData21 As ucnDspData
    Friend WithEvents UcnDspData22 As ucnDspData
    Friend WithEvents DspNextPieceName As ucnDspData
    Friend WithEvents UcnDspData24 As ucnDspData
    Friend WithEvents DspAssemblyPattern As ucnDspData
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UcnDspData30 As ucnDspData
    Friend WithEvents UcnDspData31 As ucnDspData
    Friend WithEvents UcnDspData29 As ucnDspData
    Friend WithEvents UcnDspData28 As ucnDspData
    Friend WithEvents rtbEventLog As RichTextBox
    Friend WithEvents lblUnit As Label
    Friend WithEvents DspRingNo As Label
    Friend WithEvents UcnDspData15 As ucnDspData
    Friend WithEvents UcnDspData16 As ucnDspData
    Friend WithEvents UcnDspData32 As ucnDspData
    Friend WithEvents UcnDspData33 As ucnDspData
    Friend WithEvents UcnDspData34 As ucnDspData
    Friend WithEvents UcnDspData35 As ucnDspData
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DspFlexGyiroControl As ucnDspBit
    Friend WithEvents DspFlexAutoAzurControl As ucnDspBit
    Friend WithEvents DspExcavingStop As ucnDspBit
    Friend WithEvents UcnDspBit2 As ucnDspBit
    Friend WithEvents UcnDspBit3 As ucnDspBit
    Friend WithEvents DspExcavingOn As ucnDspBit
    Friend WithEvents DspFlexAuto As ucnDspBit
    Friend WithEvents DspFlexControlOn As ucnDspBit
    Friend WithEvents DspExcaWaiting As ucnDspBit
    Friend WithEvents pnlLosZero As Panel
    Friend WithEvents UcnDspBit5 As ucnDspBit
    Friend WithEvents UcnDspBit4 As ucnDspBit
    Friend WithEvents UcnDspBit1 As ucnDspBit
    Friend WithEvents ucnLosZeroMode As ucnDspBit
    Friend WithEvents Label1 As Label
    Friend WithEvents ｂｔｎLossZerooCancel As Button
    Private WithEvents DspExcavStartTime As ucnDspData
    Private WithEvents DspExcavStartDate As ucnDspData
    Friend WithEvents ucnAssemblyFinish As ucnDspBit
    Friend WithEvents ucnPullBackFinish As ucnDspBit
    Friend WithEvents ucnReduceFinish As ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo As ucnDspBit
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents ucnVerLineChart As ucnChart2
    Friend WithEvents ucnHorLineChart As ucnChart2
    Friend WithEvents DspMachinComErr As ucnDspBit
    'Friend WithEvents UcDspAnalog2 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog1 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog3 As FLEX.NET.DspAnalog
End Class
