<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.NetStrokeChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.RingDataViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcavEnforceStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcavEnforceStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SystemEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DspSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrokeMonitor = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PlanDataView = New System.Windows.Forms.ToolStripMenuItem()
        Me.平面ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.縦断ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssemblyProcessEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.目標ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorrectionValMng = New System.Windows.Forms.ToolStripMenuItem()
        Me.RingCloseValueMng = New System.Windows.Forms.ToolStripMenuItem()
        Me.ウインドウToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuningMonitorClicｋ = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MeasuerJPullNum = New FLEX.NET.ucnDspData()
        Me.DspTargetNetStroke = New FLEX.NET.ucnDspData()
        Me.DspSegmentW = New FLEX.NET.ucnDspData()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DspSumLoszeroTime = New FLEX.NET.ucnDspData()
        Me.DspAveLoszeroTime = New FLEX.NET.ucnDspData()
        Me.DspSumAsmPiece = New FLEX.NET.ucnDspData()
        Me.DspAveAsmPiece = New FLEX.NET.ucnDspData()
        Me.DspInterruptTime = New FLEX.NET.ucnDspData()
        Me.DspWatingElapsedTime = New FLEX.NET.ucnDspData()
        Me.DspLosZeroElapsedTime = New FLEX.NET.ucnDspData()
        Me.DspExcationElapsedTime = New FLEX.NET.ucnDspData()
        Me.DspExcavStartTime = New FLEX.NET.ucnDspData()
        Me.DspExcavStartDate = New FLEX.NET.ucnDspData()
        Me.rtbEventLog = New System.Windows.Forms.RichTextBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.DspRingNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DspFlexHorControl = New FLEX.NET.ucnDspBit()
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
        Me.UcnOpposeJackControl = New FLEX.NET.ucnDspBit()
        Me.UcnOpposeJackSelect = New FLEX.NET.ucnDspBit()
        Me.ucnLosZeroMode = New FLEX.NET.ucnDspBit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnLossZerooCancel = New System.Windows.Forms.Button()
        Me.btnPieceConfirm = New System.Windows.Forms.Button()
        Me.lblNowDate = New System.Windows.Forms.Label()
        Me.cmbWideSelct = New System.Windows.Forms.ComboBox()
        Me.lblMachineMode = New System.Windows.Forms.Label()
        Me.btnLoszeroContinu = New System.Windows.Forms.Button()
        Me.lblMRRolling = New System.Windows.Forms.Label()
        Me.DspChangeMRRolling = New FLEX.NET.ucnDspDataMin2()
        Me.DspAntiClockwiseMargin = New FLEX.NET.ucnDspData()
        Me.DspClockwiseMargin = New FLEX.NET.ucnDspData()
        Me.DspGyiroError = New FLEX.NET.ucnDspBit()
        Me.DspLRStrokeDiff = New FLEX.NET.ucnDspDataMin()
        Me.DspRingTargetDir = New FLEX.NET.ucnDspData()
        Me.DspSegmentRolling = New FLEX.NET.ucnDspData()
        Me.DspClosetJack = New FLEX.NET.ucnDspData()
        Me.DspBoltPitch = New FLEX.NET.ucnDspData()
        Me.DspAveStartStroke = New FLEX.NET.ucnDspData()
        Me.DspExcvSpeed = New FLEX.NET.ucnDspData()
        Me.DspAveStroke = New FLEX.NET.ucnDspData()
        Me.UcnGpPvBarGraph = New FLEX.NET.ucnGpPvBarGraph()
        Me.DspCopyStroke1 = New FLEX.NET.ucnDspDataMin2()
        Me.DspTransMRRolling = New FLEX.NET.ucnDspDataMin2()
        Me.DspRealMRRolling = New FLEX.NET.ucnDspDataMin2()
        Me.DspUpRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspRightClearance = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftClearance = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomClearance = New FLEX.NET.ucnDspDataMin()
        Me.DspTopClearance = New FLEX.NET.ucnDspDataMin()
        Me.DspRightRawStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomRawStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftRawStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspUpRawStroke = New FLEX.NET.ucnDspDataMin()
        Me.ucnVerLineChart = New FLEX.NET.ucnChart2()
        Me.ucnHorLineChart = New FLEX.NET.ucnChart2()
        Me.ucnVerDevChart = New FLEX.NET.ucnChart()
        Me.ucnVerMomentChart = New FLEX.NET.ucnChart()
        Me.ucnHorDevChart = New FLEX.NET.ucnChart()
        Me.ucnHorMomentChart = New FLEX.NET.ucnChart()
        Me.DspMachinComErr = New FLEX.NET.ucnDspBit()
        Me.DspAssemblyPattern = New FLEX.NET.ucnDspData()
        Me.DspNextPieceName = New FLEX.NET.ucnDspData()
        Me.DspAddClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspPullBackJack = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPieace = New FLEX.NET.ucnDspData()
        Me.DspTypeName = New FLEX.NET.ucnDspData()
        Me.UcnDspDevImg = New FLEX.NET.ucnDspDevImg()
        Me.DspRightSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspRightRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspUpSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspWideUse11 = New FLEX.NET.ucnDspData()
        Me.DspWideUse10 = New FLEX.NET.ucnDspData()
        Me.DspWideUse9 = New FLEX.NET.ucnDspData()
        Me.DspWideUse8 = New FLEX.NET.ucnDspData()
        Me.DspWideUse7 = New FLEX.NET.ucnDspData()
        Me.DspWideUse6 = New FLEX.NET.ucnDspData()
        Me.DspWideUse5 = New FLEX.NET.ucnDspData()
        Me.DspWideUse4 = New FLEX.NET.ucnDspData()
        Me.DspWideUse3 = New FLEX.NET.ucnDspData()
        Me.DspWideUse2 = New FLEX.NET.ucnDspData()
        Me.DspWideUse1 = New FLEX.NET.ucnDspData()
        Me.DspWideUse0 = New FLEX.NET.ucnDspData()
        Me.UcnJackDsp = New FLEX.NET.ucnJackDsp()
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
        Me.DspWideUse12 = New FLEX.NET.ucnDspData()
        Me.InterruptTime = New FLEX.NET.ucnDspData()
        Me.DspCopyStroke2 = New FLEX.NET.ucnDspDataMin2()
        Me.btnNoOpJk = New System.Windows.Forms.Button()
        Me.pnlStrokeDiffContorol = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblConvertBtmStrokeDiff = New System.Windows.Forms.Label()
        Me.lblConvertBtmStartStrokeDiff = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblConvertHorStrokeDiff = New System.Windows.Forms.Label()
        Me.lblConvertHorStartStrokeDiff = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblConvertTopStrokeDiff = New System.Windows.Forms.Label()
        Me.lblConvertTopStartStrokeDiff = New System.Windows.Forms.Label()
        Me.lblBtmRingTargetSt = New System.Windows.Forms.Label()
        Me.lblBtmLeftStNo = New System.Windows.Forms.Label()
        Me.lblBtmRightStNo = New System.Windows.Forms.Label()
        Me.lblBtmStItem = New System.Windows.Forms.Label()
        Me.lblBtmNetSt = New System.Windows.Forms.Label()
        Me.lblBtmLeftRealSt = New System.Windows.Forms.Label()
        Me.lblBtmRightRealSt = New System.Windows.Forms.Label()
        Me.lblBtmLeftStartSt = New System.Windows.Forms.Label()
        Me.lblBtmRightStartSt = New System.Windows.Forms.Label()
        Me.lblHorRingTargetSt = New System.Windows.Forms.Label()
        Me.lblHorLefttStNo = New System.Windows.Forms.Label()
        Me.lblHorRightStNo = New System.Windows.Forms.Label()
        Me.lblHorStItem = New System.Windows.Forms.Label()
        Me.lblHorNetSt = New System.Windows.Forms.Label()
        Me.lblHorLeftRealSt = New System.Windows.Forms.Label()
        Me.lblHorRightRealSt = New System.Windows.Forms.Label()
        Me.lblHorLeftStartSt = New System.Windows.Forms.Label()
        Me.lblHorRightStartSt = New System.Windows.Forms.Label()
        Me.lblTopRingTargetSt = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTopLefttStNo = New System.Windows.Forms.Label()
        Me.lblTopRightStNo = New System.Windows.Forms.Label()
        Me.lblTopStItem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.lblTopNetSt = New System.Windows.Forms.Label()
        Me.lblTopLeftRealSt = New System.Windows.Forms.Label()
        Me.lblTopRightRealSt = New System.Windows.Forms.Label()
        Me.lblTopLeftStartSt = New System.Windows.Forms.Label()
        Me.lblTopRightStartSt = New System.Windows.Forms.Label()
        Me.DspLRRealStrokeDiff = New FLEX.NET.ucnDspDataMin()
        Me.MenuSystem.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlLosZero.SuspendLayout()
        Me.pnlStrokeDiffContorol.SuspendLayout()
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
        Me.MenuSystem.Size = New System.Drawing.Size(1914, 24)
        Me.MenuSystem.TabIndex = 20
        Me.MenuSystem.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RingNoChange, Me.RingNoUpdateSetting, Me.NetStrokeChange, Me.ToolStripMenuItem1, Me.ReportOut, Me.RingDataViewer, Me.ToolStripMenuItem2, Me.ExcavEnforceStart, Me.ExcavEnforceStop, Me.ToolStripMenuItem3, Me.SystemEnd})
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripMenuItem.Text = "システム(&S)"
        '
        'RingNoChange
        '
        Me.RingNoChange.Name = "RingNoChange"
        Me.RingNoChange.Size = New System.Drawing.Size(188, 22)
        Me.RingNoChange.Text = "リング番号の変更(&C)"
        '
        'RingNoUpdateSetting
        '
        Me.RingNoUpdateSetting.Name = "RingNoUpdateSetting"
        Me.RingNoUpdateSetting.Size = New System.Drawing.Size(188, 22)
        Me.RingNoUpdateSetting.Text = "リング番号更新設定(&U)"
        '
        'NetStrokeChange
        '
        Me.NetStrokeChange.Name = "NetStrokeChange"
        Me.NetStrokeChange.Size = New System.Drawing.Size(188, 22)
        Me.NetStrokeChange.Text = "目標推進量の変更"
        Me.NetStrokeChange.ToolTipText = "リング目標方向角の距離変更"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(185, 6)
        '
        'ReportOut
        '
        Me.ReportOut.Name = "ReportOut"
        Me.ReportOut.Size = New System.Drawing.Size(188, 22)
        Me.ReportOut.Text = "帳票出力(&Y)"
        '
        'RingDataViewer
        '
        Me.RingDataViewer.Name = "RingDataViewer"
        Me.RingDataViewer.Size = New System.Drawing.Size(188, 22)
        Me.RingDataViewer.Text = "リング内ビューワ"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(185, 6)
        '
        'ExcavEnforceStart
        '
        Me.ExcavEnforceStart.Name = "ExcavEnforceStart"
        Me.ExcavEnforceStart.Size = New System.Drawing.Size(188, 22)
        Me.ExcavEnforceStart.Text = "掘進の強制開始(&X)"
        '
        'ExcavEnforceStop
        '
        Me.ExcavEnforceStop.Name = "ExcavEnforceStop"
        Me.ExcavEnforceStop.Size = New System.Drawing.Size(188, 22)
        Me.ExcavEnforceStop.Text = "掘進の強制終了(&B)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(185, 6)
        '
        'SystemEnd
        '
        Me.SystemEnd.Name = "SystemEnd"
        Me.SystemEnd.Size = New System.Drawing.Size(188, 22)
        Me.SystemEnd.Text = "プログラム終了(&E)"
        '
        '表示ToolStripMenuItem
        '
        Me.表示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DspSetting, Me.ScaleSetting, Me.StrokeMonitor})
        Me.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem"
        Me.表示ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.表示ToolStripMenuItem.Text = "表示(&D)"
        '
        'DspSetting
        '
        Me.DspSetting.Name = "DspSetting"
        Me.DspSetting.Size = New System.Drawing.Size(168, 22)
        Me.DspSetting.Text = "各種の表示設定"
        '
        'ScaleSetting
        '
        Me.ScaleSetting.Name = "ScaleSetting"
        Me.ScaleSetting.Size = New System.Drawing.Size(168, 22)
        Me.ScaleSetting.Text = "スケール"
        Me.ScaleSetting.ToolTipText = "モーメント、偏角、線形トレンドのスケール等を設定します"
        '
        'StrokeMonitor
        '
        Me.StrokeMonitor.Name = "StrokeMonitor"
        Me.StrokeMonitor.Size = New System.Drawing.Size(168, 22)
        Me.StrokeMonitor.Text = "計算ストロークモニタ"
        Me.StrokeMonitor.ToolTipText = "計算ストローク、スピードの演算状態を表示します。"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PressParameter, Me.OneDirectionParameter, Me.OneDirectionLimit, Me.ToolStripMenuItem4, Me.PresBlock, Me.ManagmentMethd, Me.LossZeroConcern, Me.OterSetting, Me.ToolStripMenuItem5, Me.PlanDataView, Me.SegmentEdit, Me.AssemblyProcessEdit})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.設定ToolStripMenuItem.Text = "設定(&R)"
        '
        'PressParameter
        '
        Me.PressParameter.Name = "PressParameter"
        Me.PressParameter.Size = New System.Drawing.Size(156, 22)
        Me.PressParameter.Text = "圧力パラメータ"
        Me.PressParameter.ToolTipText = "ダイレクト制御、減圧比例弁の感度調整等のパラメータ変更"
        '
        'OneDirectionParameter
        '
        Me.OneDirectionParameter.Name = "OneDirectionParameter"
        Me.OneDirectionParameter.Size = New System.Drawing.Size(156, 22)
        Me.OneDirectionParameter.Text = "片押パラメータ"
        Me.OneDirectionParameter.ToolTipText = "水平、鉛直偏角の感度調整用パラメータ"
        '
        'OneDirectionLimit
        '
        Me.OneDirectionLimit.Name = "OneDirectionLimit"
        Me.OneDirectionLimit.Size = New System.Drawing.Size(156, 22)
        Me.OneDirectionLimit.Text = "片押し制限"
        Me.OneDirectionLimit.ToolTipText = "圧力、モーメント許容値、ｒ制限値、戻し量の設定"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(153, 6)
        '
        'PresBlock
        '
        Me.PresBlock.Name = "PresBlock"
        Me.PresBlock.Size = New System.Drawing.Size(156, 22)
        Me.PresBlock.Text = "圧力ブロック"
        Me.PresBlock.ToolTipText = "全開ブロックの設定等"
        '
        'ManagmentMethd
        '
        Me.ManagmentMethd.Name = "ManagmentMethd"
        Me.ManagmentMethd.Size = New System.Drawing.Size(156, 22)
        Me.ManagmentMethd.Text = "管理方法"
        Me.ManagmentMethd.ToolTipText = "リング更新のパラメータ"
        '
        'LossZeroConcern
        '
        Me.LossZeroConcern.Name = "LossZeroConcern"
        Me.LossZeroConcern.Size = New System.Drawing.Size(156, 22)
        Me.LossZeroConcern.Text = "同時施工関連"
        '
        'OterSetting
        '
        Me.OterSetting.Name = "OterSetting"
        Me.OterSetting.Size = New System.Drawing.Size(156, 22)
        Me.OterSetting.Text = "その他"
        Me.OterSetting.ToolTipText = "掘削開始時の力点位置、間引き制御、クリアランス計"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(153, 6)
        '
        'PlanDataView
        '
        Me.PlanDataView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.平面ToolStripMenuItem, Me.縦断ToolStripMenuItem})
        Me.PlanDataView.Name = "PlanDataView"
        Me.PlanDataView.Size = New System.Drawing.Size(156, 22)
        Me.PlanDataView.Text = "計画路線表示"
        '
        '平面ToolStripMenuItem
        '
        Me.平面ToolStripMenuItem.Name = "平面ToolStripMenuItem"
        Me.平面ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.平面ToolStripMenuItem.Text = "平面"
        '
        '縦断ToolStripMenuItem
        '
        Me.縦断ToolStripMenuItem.Name = "縦断ToolStripMenuItem"
        Me.縦断ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.縦断ToolStripMenuItem.Text = "縦断"
        '
        'SegmentEdit
        '
        Me.SegmentEdit.Name = "SegmentEdit"
        Me.SegmentEdit.Size = New System.Drawing.Size(156, 22)
        Me.SegmentEdit.Text = "セグメントの割付"
        Me.SegmentEdit.ToolTipText = "各リングのセグメント割り付け情報"
        '
        'AssemblyProcessEdit
        '
        Me.AssemblyProcessEdit.Name = "AssemblyProcessEdit"
        Me.AssemblyProcessEdit.Size = New System.Drawing.Size(156, 22)
        Me.AssemblyProcessEdit.Text = "組立工程の編集"
        '
        '目標ToolStripMenuItem
        '
        Me.目標ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorrectionValMng, Me.RingCloseValueMng})
        Me.目標ToolStripMenuItem.Name = "目標ToolStripMenuItem"
        Me.目標ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.目標ToolStripMenuItem.Text = "目標(&P)"
        '
        'CorrectionValMng
        '
        Me.CorrectionValMng.Name = "CorrectionValMng"
        Me.CorrectionValMng.Size = New System.Drawing.Size(148, 22)
        Me.CorrectionValMng.Text = "補正値管理"
        '
        'RingCloseValueMng
        '
        Me.RingCloseValueMng.Name = "RingCloseValueMng"
        Me.RingCloseValueMng.Size = New System.Drawing.Size(148, 22)
        Me.RingCloseValueMng.Text = "リング終値管理"
        '
        'ウインドウToolStripMenuItem
        '
        Me.ウインドウToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TuningMonitorClicｋ})
        Me.ウインドウToolStripMenuItem.Name = "ウインドウToolStripMenuItem"
        Me.ウインドウToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ウインドウToolStripMenuItem.Text = "ウインドウ(&W)"
        '
        'TuningMonitorClicｋ
        '
        Me.TuningMonitorClicｋ.Name = "TuningMonitorClicｋ"
        Me.TuningMonitorClicｋ.Size = New System.Drawing.Size(153, 22)
        Me.TuningMonitorClicｋ.Text = "チューニングモニタ"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MeasuerJPullNum)
        Me.Panel1.Controls.Add(Me.DspTargetNetStroke)
        Me.Panel1.Controls.Add(Me.DspSegmentW)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DspSumLoszeroTime)
        Me.Panel1.Controls.Add(Me.DspAveLoszeroTime)
        Me.Panel1.Controls.Add(Me.DspSumAsmPiece)
        Me.Panel1.Controls.Add(Me.DspAveAsmPiece)
        Me.Panel1.Controls.Add(Me.DspInterruptTime)
        Me.Panel1.Controls.Add(Me.DspWatingElapsedTime)
        Me.Panel1.Controls.Add(Me.DspLosZeroElapsedTime)
        Me.Panel1.Controls.Add(Me.DspExcationElapsedTime)
        Me.Panel1.Controls.Add(Me.DspExcavStartTime)
        Me.Panel1.Controls.Add(Me.DspExcavStartDate)
        Me.Panel1.Controls.Add(Me.rtbEventLog)
        Me.Panel1.Controls.Add(Me.lblUnit)
        Me.Panel1.Controls.Add(Me.DspRingNo)
        Me.Panel1.Location = New System.Drawing.Point(1306, 687)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 350)
        Me.Panel1.TabIndex = 119
        '
        'MeasuerJPullNum
        '
        Me.MeasuerJPullNum.BackColor = System.Drawing.Color.Transparent
        Me.MeasuerJPullNum.Blink = False
        Me.MeasuerJPullNum.BlinkColor = System.Drawing.Color.Orange
        Me.MeasuerJPullNum.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MeasuerJPullNum.DataWidth = 91
        Me.MeasuerJPullNum.DecimalPlaces = CType(2, Short)
        Me.MeasuerJPullNum.FieldName = "計測ジャッキ更新数"
        Me.MeasuerJPullNum.FieldNameWidth = 175
        Me.MeasuerJPullNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MeasuerJPullNum.Location = New System.Drawing.Point(301, 53)
        Me.MeasuerJPullNum.Margin = New System.Windows.Forms.Padding(1)
        Me.MeasuerJPullNum.Name = "MeasuerJPullNum"
        Me.MeasuerJPullNum.Size = New System.Drawing.Size(257, 30)
        Me.MeasuerJPullNum.TabIndex = 163
        Me.MeasuerJPullNum.Unit = "deg"
        Me.MeasuerJPullNum.UnitVisible = False
        Me.MeasuerJPullNum.Value = "-----"
        Me.MeasuerJPullNum.ValueType = True
        '
        'DspTargetNetStroke
        '
        Me.DspTargetNetStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetNetStroke.Blink = False
        Me.DspTargetNetStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspTargetNetStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTargetNetStroke.DataWidth = 70
        Me.DspTargetNetStroke.DecimalPlaces = CType(0, Short)
        Me.DspTargetNetStroke.FieldName = "目標推進量(mm)"
        Me.DspTargetNetStroke.FieldNameWidth = 120
        Me.DspTargetNetStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetNetStroke.Location = New System.Drawing.Point(380, 11)
        Me.DspTargetNetStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetNetStroke.Name = "DspTargetNetStroke"
        Me.DspTargetNetStroke.Size = New System.Drawing.Size(189, 32)
        Me.DspTargetNetStroke.TabIndex = 136
        Me.DspTargetNetStroke.Unit = "deg"
        Me.DspTargetNetStroke.UnitVisible = False
        Me.DspTargetNetStroke.Value = "1200"
        Me.DspTargetNetStroke.ValueType = False
        '
        'DspSegmentW
        '
        Me.DspSegmentW.BackColor = System.Drawing.Color.Transparent
        Me.DspSegmentW.Blink = False
        Me.DspSegmentW.BlinkColor = System.Drawing.Color.Red
        Me.DspSegmentW.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspSegmentW.DataWidth = 70
        Me.DspSegmentW.DecimalPlaces = CType(0, Short)
        Me.DspSegmentW.FieldName = "ｾｸﾞﾒﾝﾄ幅(mm)"
        Me.DspSegmentW.FieldNameWidth = 120
        Me.DspSegmentW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspSegmentW.Location = New System.Drawing.Point(184, 11)
        Me.DspSegmentW.Margin = New System.Windows.Forms.Padding(1)
        Me.DspSegmentW.Name = "DspSegmentW"
        Me.DspSegmentW.Size = New System.Drawing.Size(198, 32)
        Me.DspSegmentW.TabIndex = 135
        Me.DspSegmentW.Unit = "deg"
        Me.DspSegmentW.UnitVisible = False
        Me.DspSegmentW.Value = "1200"
        Me.DspSegmentW.ValueType = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 26)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "同時施工実績"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspSumLoszeroTime
        '
        Me.DspSumLoszeroTime.BackColor = System.Drawing.Color.Transparent
        Me.DspSumLoszeroTime.Blink = False
        Me.DspSumLoszeroTime.BlinkColor = System.Drawing.Color.Red
        Me.DspSumLoszeroTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspSumLoszeroTime.DataWidth = 91
        Me.DspSumLoszeroTime.DecimalPlaces = CType(0, Short)
        Me.DspSumLoszeroTime.FieldName = "累計同時掘進(分)"
        Me.DspSumLoszeroTime.FieldNameWidth = 175
        Me.DspSumLoszeroTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspSumLoszeroTime.Location = New System.Drawing.Point(297, 211)
        Me.DspSumLoszeroTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspSumLoszeroTime.Name = "DspSumLoszeroTime"
        Me.DspSumLoszeroTime.Size = New System.Drawing.Size(275, 32)
        Me.DspSumLoszeroTime.TabIndex = 132
        Me.DspSumLoszeroTime.Unit = "deg"
        Me.DspSumLoszeroTime.UnitVisible = False
        Me.DspSumLoszeroTime.Value = "0"
        Me.DspSumLoszeroTime.ValueType = False
        '
        'DspAveLoszeroTime
        '
        Me.DspAveLoszeroTime.BackColor = System.Drawing.Color.Transparent
        Me.DspAveLoszeroTime.Blink = False
        Me.DspAveLoszeroTime.BlinkColor = System.Drawing.Color.Red
        Me.DspAveLoszeroTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveLoszeroTime.DataWidth = 91
        Me.DspAveLoszeroTime.DecimalPlaces = CType(0, Short)
        Me.DspAveLoszeroTime.FieldName = "平均同時掘進(分)"
        Me.DspAveLoszeroTime.FieldNameWidth = 175
        Me.DspAveLoszeroTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveLoszeroTime.Location = New System.Drawing.Point(297, 179)
        Me.DspAveLoszeroTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveLoszeroTime.Name = "DspAveLoszeroTime"
        Me.DspAveLoszeroTime.Size = New System.Drawing.Size(275, 32)
        Me.DspAveLoszeroTime.TabIndex = 131
        Me.DspAveLoszeroTime.Unit = "deg"
        Me.DspAveLoszeroTime.UnitVisible = False
        Me.DspAveLoszeroTime.Value = "0"
        Me.DspAveLoszeroTime.ValueType = False
        '
        'DspSumAsmPiece
        '
        Me.DspSumAsmPiece.BackColor = System.Drawing.Color.Transparent
        Me.DspSumAsmPiece.Blink = False
        Me.DspSumAsmPiece.BlinkColor = System.Drawing.Color.Red
        Me.DspSumAsmPiece.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspSumAsmPiece.DataWidth = 91
        Me.DspSumAsmPiece.DecimalPlaces = CType(0, Short)
        Me.DspSumAsmPiece.FieldName = "累計組立ﾋﾟｰｽ数"
        Me.DspSumAsmPiece.FieldNameWidth = 175
        Me.DspSumAsmPiece.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspSumAsmPiece.Location = New System.Drawing.Point(297, 147)
        Me.DspSumAsmPiece.Margin = New System.Windows.Forms.Padding(1)
        Me.DspSumAsmPiece.Name = "DspSumAsmPiece"
        Me.DspSumAsmPiece.Size = New System.Drawing.Size(275, 32)
        Me.DspSumAsmPiece.TabIndex = 130
        Me.DspSumAsmPiece.Unit = "deg"
        Me.DspSumAsmPiece.UnitVisible = False
        Me.DspSumAsmPiece.Value = "0"
        Me.DspSumAsmPiece.ValueType = False
        '
        'DspAveAsmPiece
        '
        Me.DspAveAsmPiece.BackColor = System.Drawing.Color.Transparent
        Me.DspAveAsmPiece.Blink = False
        Me.DspAveAsmPiece.BlinkColor = System.Drawing.Color.Red
        Me.DspAveAsmPiece.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveAsmPiece.DataWidth = 91
        Me.DspAveAsmPiece.DecimalPlaces = CType(1, Short)
        Me.DspAveAsmPiece.FieldName = "平均組立ﾋﾟｰｽ数"
        Me.DspAveAsmPiece.FieldNameWidth = 175
        Me.DspAveAsmPiece.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveAsmPiece.Location = New System.Drawing.Point(297, 115)
        Me.DspAveAsmPiece.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveAsmPiece.Name = "DspAveAsmPiece"
        Me.DspAveAsmPiece.Size = New System.Drawing.Size(275, 32)
        Me.DspAveAsmPiece.TabIndex = 129
        Me.DspAveAsmPiece.Unit = "deg"
        Me.DspAveAsmPiece.UnitVisible = False
        Me.DspAveAsmPiece.Value = "0"
        Me.DspAveAsmPiece.ValueType = False
        '
        'DspInterruptTime
        '
        Me.DspInterruptTime.BackColor = System.Drawing.Color.Transparent
        Me.DspInterruptTime.Blink = False
        Me.DspInterruptTime.BlinkColor = System.Drawing.Color.Red
        Me.DspInterruptTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspInterruptTime.DataWidth = 91
        Me.DspInterruptTime.DecimalPlaces = CType(0, Short)
        Me.DspInterruptTime.FieldName = "中断時間(分)"
        Me.DspInterruptTime.FieldNameWidth = 175
        Me.DspInterruptTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspInterruptTime.Location = New System.Drawing.Point(21, 179)
        Me.DspInterruptTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspInterruptTime.Name = "DspInterruptTime"
        Me.DspInterruptTime.Size = New System.Drawing.Size(275, 32)
        Me.DspInterruptTime.TabIndex = 127
        Me.DspInterruptTime.Unit = "deg"
        Me.DspInterruptTime.UnitVisible = False
        Me.DspInterruptTime.Value = "20"
        Me.DspInterruptTime.ValueType = False
        '
        'DspWatingElapsedTime
        '
        Me.DspWatingElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.DspWatingElapsedTime.Blink = False
        Me.DspWatingElapsedTime.BlinkColor = System.Drawing.Color.Red
        Me.DspWatingElapsedTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWatingElapsedTime.DataWidth = 91
        Me.DspWatingElapsedTime.DecimalPlaces = CType(0, Short)
        Me.DspWatingElapsedTime.FieldName = "待機時間(分)"
        Me.DspWatingElapsedTime.FieldNameWidth = 175
        Me.DspWatingElapsedTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWatingElapsedTime.Location = New System.Drawing.Point(21, 213)
        Me.DspWatingElapsedTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWatingElapsedTime.Name = "DspWatingElapsedTime"
        Me.DspWatingElapsedTime.Size = New System.Drawing.Size(275, 32)
        Me.DspWatingElapsedTime.TabIndex = 126
        Me.DspWatingElapsedTime.Unit = "deg"
        Me.DspWatingElapsedTime.UnitVisible = False
        Me.DspWatingElapsedTime.Value = "20"
        Me.DspWatingElapsedTime.ValueType = False
        '
        'DspLosZeroElapsedTime
        '
        Me.DspLosZeroElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.DspLosZeroElapsedTime.Blink = False
        Me.DspLosZeroElapsedTime.BlinkColor = System.Drawing.Color.Red
        Me.DspLosZeroElapsedTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspLosZeroElapsedTime.DataWidth = 91
        Me.DspLosZeroElapsedTime.DecimalPlaces = CType(0, Short)
        Me.DspLosZeroElapsedTime.FieldName = "同時掘進時間(分)"
        Me.DspLosZeroElapsedTime.FieldNameWidth = 175
        Me.DspLosZeroElapsedTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspLosZeroElapsedTime.Location = New System.Drawing.Point(21, 147)
        Me.DspLosZeroElapsedTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspLosZeroElapsedTime.Name = "DspLosZeroElapsedTime"
        Me.DspLosZeroElapsedTime.Size = New System.Drawing.Size(275, 32)
        Me.DspLosZeroElapsedTime.TabIndex = 125
        Me.DspLosZeroElapsedTime.Unit = "deg"
        Me.DspLosZeroElapsedTime.UnitVisible = False
        Me.DspLosZeroElapsedTime.Value = "20"
        Me.DspLosZeroElapsedTime.ValueType = False
        '
        'DspExcationElapsedTime
        '
        Me.DspExcationElapsedTime.BackColor = System.Drawing.Color.Transparent
        Me.DspExcationElapsedTime.Blink = False
        Me.DspExcationElapsedTime.BlinkColor = System.Drawing.Color.Red
        Me.DspExcationElapsedTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspExcationElapsedTime.DataWidth = 91
        Me.DspExcationElapsedTime.DecimalPlaces = CType(0, Short)
        Me.DspExcationElapsedTime.FieldName = "掘進時間(分)"
        Me.DspExcationElapsedTime.FieldNameWidth = 175
        Me.DspExcationElapsedTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcationElapsedTime.Location = New System.Drawing.Point(21, 115)
        Me.DspExcationElapsedTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcationElapsedTime.Name = "DspExcationElapsedTime"
        Me.DspExcationElapsedTime.Size = New System.Drawing.Size(275, 32)
        Me.DspExcationElapsedTime.TabIndex = 124
        Me.DspExcationElapsedTime.Unit = "deg"
        Me.DspExcationElapsedTime.UnitVisible = False
        Me.DspExcationElapsedTime.Value = "20"
        Me.DspExcationElapsedTime.ValueType = False
        '
        'DspExcavStartTime
        '
        Me.DspExcavStartTime.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavStartTime.Blink = False
        Me.DspExcavStartTime.BlinkColor = System.Drawing.Color.Red
        Me.DspExcavStartTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspExcavStartTime.DataWidth = 151
        Me.DspExcavStartTime.DecimalPlaces = CType(2, Short)
        Me.DspExcavStartTime.FieldName = "開始時刻"
        Me.DspExcavStartTime.FieldNameWidth = 115
        Me.DspExcavStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcavStartTime.Location = New System.Drawing.Point(21, 83)
        Me.DspExcavStartTime.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcavStartTime.Name = "DspExcavStartTime"
        Me.DspExcavStartTime.Size = New System.Drawing.Size(275, 32)
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
        Me.DspExcavStartDate.DataWidth = 151
        Me.DspExcavStartDate.DecimalPlaces = CType(2, Short)
        Me.DspExcavStartDate.FieldName = "開始日"
        Me.DspExcavStartDate.FieldNameWidth = 115
        Me.DspExcavStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcavStartDate.Location = New System.Drawing.Point(21, 51)
        Me.DspExcavStartDate.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcavStartDate.Name = "DspExcavStartDate"
        Me.DspExcavStartDate.Size = New System.Drawing.Size(275, 32)
        Me.DspExcavStartDate.TabIndex = 122
        Me.DspExcavStartDate.Unit = "deg"
        Me.DspExcavStartDate.UnitVisible = False
        Me.DspExcavStartDate.Value = "2016/05/01"
        Me.DspExcavStartDate.ValueType = True
        '
        'rtbEventLog
        '
        Me.rtbEventLog.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rtbEventLog.Location = New System.Drawing.Point(21, 248)
        Me.rtbEventLog.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbEventLog.Name = "rtbEventLog"
        Me.rtbEventLog.ReadOnly = True
        Me.rtbEventLog.Size = New System.Drawing.Size(537, 96)
        Me.rtbEventLog.TabIndex = 121
        Me.rtbEventLog.Text = ""
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(115, 12)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(64, 26)
        Me.lblUnit.TabIndex = 120
        Me.lblUnit.Text = "リング"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspRingNo
        '
        Me.DspRingNo.BackColor = System.Drawing.Color.Black
        Me.DspRingNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DspRingNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspRingNo.ForeColor = System.Drawing.Color.LightGreen
        Me.DspRingNo.Location = New System.Drawing.Point(21, 6)
        Me.DspRingNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DspRingNo.Name = "DspRingNo"
        Me.DspRingNo.Size = New System.Drawing.Size(92, 41)
        Me.DspRingNo.TabIndex = 119
        Me.DspRingNo.Text = "1234"
        Me.DspRingNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DspFlexHorControl)
        Me.Panel2.Controls.Add(Me.DspFlexAutoAzurControl)
        Me.Panel2.Controls.Add(Me.DspExcavingStop)
        Me.Panel2.Controls.Add(Me.UcnDspBit2)
        Me.Panel2.Controls.Add(Me.UcnDspBit3)
        Me.Panel2.Controls.Add(Me.DspExcavingOn)
        Me.Panel2.Controls.Add(Me.DspFlexAuto)
        Me.Panel2.Controls.Add(Me.DspFlexControlOn)
        Me.Panel2.Controls.Add(Me.DspExcaWaiting)
        Me.Panel2.Location = New System.Drawing.Point(317, 31)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 75)
        Me.Panel2.TabIndex = 120
        '
        'DspFlexHorControl
        '
        Me.DspFlexHorControl.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexHorControl.BitStatus = True
        Me.DspFlexHorControl.Blink = False
        Me.DspFlexHorControl.FieldName = "ジャイロ"
        Me.DspFlexHorControl.Location = New System.Drawing.Point(481, 40)
        Me.DspFlexHorControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexHorControl.Name = "DspFlexHorControl"
        Me.DspFlexHorControl.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexHorControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexHorControl.Size = New System.Drawing.Size(90, 30)
        Me.DspFlexHorControl.TabIndex = 73
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
        Me.UcnDspBit2.Location = New System.Drawing.Point(292, 40)
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
        Me.UcnDspBit3.FieldName = "補正値管理"
        Me.UcnDspBit3.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UcnDspBit3.Location = New System.Drawing.Point(197, 40)
        Me.UcnDspBit3.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit3.Name = "UcnDspBit3"
        Me.UcnDspBit3.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit3.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit3.Size = New System.Drawing.Size(100, 30)
        Me.UcnDspBit3.TabIndex = 70
        '
        'DspExcavingOn
        '
        Me.DspExcavingOn.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingOn.BitStatus = True
        Me.DspExcavingOn.Blink = False
        Me.DspExcavingOn.FieldName = "掘　進"
        Me.DspExcavingOn.Location = New System.Drawing.Point(197, 6)
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
        Me.DspFlexAuto.Location = New System.Drawing.Point(102, 41)
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
        Me.DspFlexControlOn.Location = New System.Drawing.Point(7, 40)
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
        Me.DspExcaWaiting.Location = New System.Drawing.Point(7, 6)
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
        Me.pnlLosZero.Controls.Add(Me.UcnOpposeJackControl)
        Me.pnlLosZero.Controls.Add(Me.UcnOpposeJackSelect)
        Me.pnlLosZero.Controls.Add(Me.ucnLosZeroMode)
        Me.pnlLosZero.Controls.Add(Me.ShapeContainer1)
        Me.pnlLosZero.Location = New System.Drawing.Point(1740, 31)
        Me.pnlLosZero.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLosZero.Name = "pnlLosZero"
        Me.pnlLosZero.Size = New System.Drawing.Size(156, 343)
        Me.pnlLosZero.TabIndex = 121
        '
        'ucnAssemblyFinish
        '
        Me.ucnAssemblyFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyFinish.BitStatus = True
        Me.ucnAssemblyFinish.Blink = False
        Me.ucnAssemblyFinish.FieldName = "組立完了"
        Me.ucnAssemblyFinish.Location = New System.Drawing.Point(10, 296)
        Me.ucnAssemblyFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyFinish.Name = "ucnAssemblyFinish"
        Me.ucnAssemblyFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnAssemblyFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyFinish.TabIndex = 133
        '
        'ucnPullBackFinish
        '
        Me.ucnPullBackFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnPullBackFinish.BitStatus = True
        Me.ucnPullBackFinish.Blink = False
        Me.ucnPullBackFinish.FieldName = "引戻完了"
        Me.ucnPullBackFinish.Location = New System.Drawing.Point(10, 256)
        Me.ucnPullBackFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnPullBackFinish.Name = "ucnPullBackFinish"
        Me.ucnPullBackFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnPullBackFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnPullBackFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnPullBackFinish.TabIndex = 132
        '
        'ucnReduceFinish
        '
        Me.ucnReduceFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnReduceFinish.BitStatus = True
        Me.ucnReduceFinish.Blink = False
        Me.ucnReduceFinish.FieldName = "減圧完了"
        Me.ucnReduceFinish.Location = New System.Drawing.Point(10, 216)
        Me.ucnReduceFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnReduceFinish.Name = "ucnReduceFinish"
        Me.ucnReduceFinish.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnReduceFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnReduceFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnReduceFinish.TabIndex = 131
        '
        'ucnAssemblyPieceNo
        '
        Me.ucnAssemblyPieceNo.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo.BitStatus = True
        Me.ucnAssemblyPieceNo.Blink = False
        Me.ucnAssemblyPieceNo.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo.Location = New System.Drawing.Point(10, 176)
        Me.ucnAssemblyPieceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo.Name = "ucnAssemblyPieceNo"
        Me.ucnAssemblyPieceNo.OffBackColor = System.Drawing.Color.White
        Me.ucnAssemblyPieceNo.OnBackColor = System.Drawing.Color.White
        Me.ucnAssemblyPieceNo.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo.TabIndex = 129
        '
        'UcnDspBit5
        '
        Me.UcnDspBit5.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit5.BitStatus = False
        Me.UcnDspBit5.Blink = False
        Me.UcnDspBit5.FieldName = "ﾛｰﾘﾝｸﾞ考慮"
        Me.UcnDspBit5.Location = New System.Drawing.Point(10, 125)
        Me.UcnDspBit5.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnDspBit5.Name = "UcnDspBit5"
        Me.UcnDspBit5.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit5.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit5.Size = New System.Drawing.Size(131, 37)
        Me.UcnDspBit5.TabIndex = 72
        '
        'UcnOpposeJackControl
        '
        Me.UcnOpposeJackControl.BackColor = System.Drawing.Color.Transparent
        Me.UcnOpposeJackControl.BitStatus = False
        Me.UcnOpposeJackControl.Blink = False
        Me.UcnOpposeJackControl.FieldName = "対抗圧制御"
        Me.UcnOpposeJackControl.Location = New System.Drawing.Point(10, 86)
        Me.UcnOpposeJackControl.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnOpposeJackControl.Name = "UcnOpposeJackControl"
        Me.UcnOpposeJackControl.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnOpposeJackControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnOpposeJackControl.Size = New System.Drawing.Size(131, 37)
        Me.UcnOpposeJackControl.TabIndex = 71
        '
        'UcnOpposeJackSelect
        '
        Me.UcnOpposeJackSelect.BackColor = System.Drawing.Color.Transparent
        Me.UcnOpposeJackSelect.BitStatus = False
        Me.UcnOpposeJackSelect.Blink = False
        Me.UcnOpposeJackSelect.FieldName = "対抗J選択"
        Me.UcnOpposeJackSelect.Location = New System.Drawing.Point(10, 47)
        Me.UcnOpposeJackSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnOpposeJackSelect.Name = "UcnOpposeJackSelect"
        Me.UcnOpposeJackSelect.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnOpposeJackSelect.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnOpposeJackSelect.Size = New System.Drawing.Size(131, 37)
        Me.UcnOpposeJackSelect.TabIndex = 70
        '
        'ucnLosZeroMode
        '
        Me.ucnLosZeroMode.BackColor = System.Drawing.Color.Transparent
        Me.ucnLosZeroMode.BitStatus = True
        Me.ucnLosZeroMode.Blink = False
        Me.ucnLosZeroMode.FieldName = "同時施工"
        Me.ucnLosZeroMode.Location = New System.Drawing.Point(10, 8)
        Me.ucnLosZeroMode.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnLosZeroMode.Name = "ucnLosZeroMode"
        Me.ucnLosZeroMode.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnLosZeroMode.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnLosZeroMode.Size = New System.Drawing.Size(131, 37)
        Me.ucnLosZeroMode.TabIndex = 69
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(154, 341)
        Me.ShapeContainer1.TabIndex = 134
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 150
        Me.LineShape1.Y1 = 165
        Me.LineShape1.Y2 = 165
        '
        'btnLossZerooCancel
        '
        Me.btnLossZerooCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnLossZerooCancel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnLossZerooCancel.Location = New System.Drawing.Point(1746, 424)
        Me.btnLossZerooCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLossZerooCancel.Name = "btnLossZerooCancel"
        Me.btnLossZerooCancel.Size = New System.Drawing.Size(137, 36)
        Me.btnLossZerooCancel.TabIndex = 123
        Me.btnLossZerooCancel.Text = "同時施工ｷｬﾝｾﾙ"
        Me.btnLossZerooCancel.UseVisualStyleBackColor = False
        '
        'btnPieceConfirm
        '
        Me.btnPieceConfirm.BackColor = System.Drawing.Color.DarkGray
        Me.btnPieceConfirm.Enabled = False
        Me.btnPieceConfirm.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPieceConfirm.Location = New System.Drawing.Point(1398, 424)
        Me.btnPieceConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPieceConfirm.Name = "btnPieceConfirm"
        Me.btnPieceConfirm.Size = New System.Drawing.Size(205, 36)
        Me.btnPieceConfirm.TabIndex = 126
        Me.btnPieceConfirm.Text = "同時施工 組立ピース確認"
        Me.btnPieceConfirm.UseVisualStyleBackColor = False
        '
        'lblNowDate
        '
        Me.lblNowDate.BackColor = System.Drawing.Color.Transparent
        Me.lblNowDate.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNowDate.Location = New System.Drawing.Point(1672, 3)
        Me.lblNowDate.Name = "lblNowDate"
        Me.lblNowDate.Size = New System.Drawing.Size(240, 19)
        Me.lblNowDate.TabIndex = 138
        Me.lblNowDate.Text = "9999／99／99　99：99：99"
        Me.lblNowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbWideSelct
        '
        Me.cmbWideSelct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWideSelct.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbWideSelct.FormattingEnabled = True
        Me.cmbWideSelct.Location = New System.Drawing.Point(1404, 36)
        Me.cmbWideSelct.Name = "cmbWideSelct"
        Me.cmbWideSelct.Size = New System.Drawing.Size(145, 21)
        Me.cmbWideSelct.TabIndex = 151
        Me.cmbWideSelct.Visible = False
        '
        'lblMachineMode
        '
        Me.lblMachineMode.BackColor = System.Drawing.Color.HotPink
        Me.lblMachineMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMachineMode.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMachineMode.Location = New System.Drawing.Point(797, 111)
        Me.lblMachineMode.Name = "lblMachineMode"
        Me.lblMachineMode.Size = New System.Drawing.Size(100, 20)
        Me.lblMachineMode.TabIndex = 152
        Me.lblMachineMode.Text = "セグメントモード"
        Me.lblMachineMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLoszeroContinu
        '
        Me.btnLoszeroContinu.BackColor = System.Drawing.Color.DarkGray
        Me.btnLoszeroContinu.Enabled = False
        Me.btnLoszeroContinu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnLoszeroContinu.Location = New System.Drawing.Point(1613, 424)
        Me.btnLoszeroContinu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoszeroContinu.Name = "btnLoszeroContinu"
        Me.btnLoszeroContinu.Size = New System.Drawing.Size(123, 36)
        Me.btnLoszeroContinu.TabIndex = 156
        Me.btnLoszeroContinu.Text = "同時施工継続"
        Me.btnLoszeroContinu.UseVisualStyleBackColor = False
        '
        'lblMRRolling
        '
        Me.lblMRRolling.AutoSize = True
        Me.lblMRRolling.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMRRolling.Location = New System.Drawing.Point(917, 190)
        Me.lblMRRolling.Name = "lblMRRolling"
        Me.lblMRRolling.Size = New System.Drawing.Size(94, 13)
        Me.lblMRRolling.TabIndex = 162
        Me.lblMRRolling.Text = "マシンローリング"
        '
        'DspChangeMRRolling
        '
        Me.DspChangeMRRolling.BackColor = System.Drawing.Color.Transparent
        Me.DspChangeMRRolling.DecimalPlaces = CType(2, Short)
        Me.DspChangeMRRolling.FieldName = "変化量"
        Me.DspChangeMRRolling.Location = New System.Drawing.Point(865, 257)
        Me.DspChangeMRRolling.Margin = New System.Windows.Forms.Padding(2)
        Me.DspChangeMRRolling.Name = "DspChangeMRRolling"
        Me.DspChangeMRRolling.Size = New System.Drawing.Size(193, 30)
        Me.DspChangeMRRolling.TabIndex = 161
        Me.DspChangeMRRolling.Unit = "deg"
        Me.DspChangeMRRolling.Value = 0R
        '
        'DspAntiClockwiseMargin
        '
        Me.DspAntiClockwiseMargin.BackColor = System.Drawing.Color.Transparent
        Me.DspAntiClockwiseMargin.Blink = False
        Me.DspAntiClockwiseMargin.BlinkColor = System.Drawing.Color.Red
        Me.DspAntiClockwiseMargin.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAntiClockwiseMargin.DataWidth = 75
        Me.DspAntiClockwiseMargin.DecimalPlaces = CType(2, Short)
        Me.DspAntiClockwiseMargin.FieldName = "反時計端側の余裕(deg)"
        Me.DspAntiClockwiseMargin.FieldNameWidth = 170
        Me.DspAntiClockwiseMargin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAntiClockwiseMargin.Location = New System.Drawing.Point(1642, 649)
        Me.DspAntiClockwiseMargin.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAntiClockwiseMargin.Name = "DspAntiClockwiseMargin"
        Me.DspAntiClockwiseMargin.Size = New System.Drawing.Size(250, 30)
        Me.DspAntiClockwiseMargin.TabIndex = 160
        Me.DspAntiClockwiseMargin.Unit = "deg"
        Me.DspAntiClockwiseMargin.UnitVisible = False
        Me.DspAntiClockwiseMargin.Value = "-"
        Me.DspAntiClockwiseMargin.ValueType = False
        '
        'DspClockwiseMargin
        '
        Me.DspClockwiseMargin.BackColor = System.Drawing.Color.Transparent
        Me.DspClockwiseMargin.Blink = False
        Me.DspClockwiseMargin.BlinkColor = System.Drawing.Color.Red
        Me.DspClockwiseMargin.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspClockwiseMargin.DataWidth = 75
        Me.DspClockwiseMargin.DecimalPlaces = CType(2, Short)
        Me.DspClockwiseMargin.FieldName = "時計端側の余裕(deg)"
        Me.DspClockwiseMargin.FieldNameWidth = 170
        Me.DspClockwiseMargin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspClockwiseMargin.Location = New System.Drawing.Point(1398, 649)
        Me.DspClockwiseMargin.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClockwiseMargin.Name = "DspClockwiseMargin"
        Me.DspClockwiseMargin.Size = New System.Drawing.Size(250, 30)
        Me.DspClockwiseMargin.TabIndex = 159
        Me.DspClockwiseMargin.Unit = "deg"
        Me.DspClockwiseMargin.UnitVisible = False
        Me.DspClockwiseMargin.Value = "-"
        Me.DspClockwiseMargin.ValueType = False
        '
        'DspGyiroError
        '
        Me.DspGyiroError.BackColor = System.Drawing.Color.Transparent
        Me.DspGyiroError.BitStatus = True
        Me.DspGyiroError.Blink = True
        Me.DspGyiroError.FieldName = "ジャイロ異常"
        Me.DspGyiroError.Location = New System.Drawing.Point(496, 229)
        Me.DspGyiroError.Margin = New System.Windows.Forms.Padding(2)
        Me.DspGyiroError.Name = "DspGyiroError"
        Me.DspGyiroError.OffBackColor = System.Drawing.Color.Yellow
        Me.DspGyiroError.OnBackColor = System.Drawing.Color.Red
        Me.DspGyiroError.Size = New System.Drawing.Size(193, 30)
        Me.DspGyiroError.TabIndex = 158
        Me.DspGyiroError.Visible = False
        '
        'DspLRStrokeDiff
        '
        Me.DspLRStrokeDiff.BackColor = System.Drawing.Color.Transparent
        Me.DspLRStrokeDiff.DecimalPlaces = CType(0, Short)
        Me.DspLRStrokeDiff.FieldName = "左右ｽﾄﾛｰｸ差"
        Me.DspLRStrokeDiff.Location = New System.Drawing.Point(919, 555)
        Me.DspLRStrokeDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLRStrokeDiff.Name = "DspLRStrokeDiff"
        Me.DspLRStrokeDiff.Size = New System.Drawing.Size(138, 51)
        Me.DspLRStrokeDiff.TabIndex = 155
        Me.DspLRStrokeDiff.Unit = "mm"
        Me.DspLRStrokeDiff.Value = 1234.0R
        '
        'DspRingTargetDir
        '
        Me.DspRingTargetDir.BackColor = System.Drawing.Color.Transparent
        Me.DspRingTargetDir.Blink = False
        Me.DspRingTargetDir.BlinkColor = System.Drawing.Color.Red
        Me.DspRingTargetDir.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspRingTargetDir.DataWidth = 75
        Me.DspRingTargetDir.DecimalPlaces = CType(2, Short)
        Me.DspRingTargetDir.FieldName = "リング目標方向角"
        Me.DspRingTargetDir.FieldNameWidth = 155
        Me.DspRingTargetDir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspRingTargetDir.Location = New System.Drawing.Point(1, 127)
        Me.DspRingTargetDir.Margin = New System.Windows.Forms.Padding(1)
        Me.DspRingTargetDir.Name = "DspRingTargetDir"
        Me.DspRingTargetDir.Size = New System.Drawing.Size(300, 35)
        Me.DspRingTargetDir.TabIndex = 154
        Me.DspRingTargetDir.Unit = "deg"
        Me.DspRingTargetDir.UnitVisible = True
        Me.DspRingTargetDir.Value = "999.99"
        Me.DspRingTargetDir.ValueType = False
        '
        'DspSegmentRolling
        '
        Me.DspSegmentRolling.BackColor = System.Drawing.Color.Transparent
        Me.DspSegmentRolling.Blink = False
        Me.DspSegmentRolling.BlinkColor = System.Drawing.Color.Red
        Me.DspSegmentRolling.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspSegmentRolling.DataWidth = 75
        Me.DspSegmentRolling.DecimalPlaces = CType(2, Short)
        Me.DspSegmentRolling.FieldName = "ｾｸﾞﾒﾝﾄﾛｰﾘﾝｸﾞ(deg)"
        Me.DspSegmentRolling.FieldNameWidth = 175
        Me.DspSegmentRolling.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspSegmentRolling.Location = New System.Drawing.Point(1637, 617)
        Me.DspSegmentRolling.Margin = New System.Windows.Forms.Padding(1)
        Me.DspSegmentRolling.Name = "DspSegmentRolling"
        Me.DspSegmentRolling.Size = New System.Drawing.Size(250, 30)
        Me.DspSegmentRolling.TabIndex = 109
        Me.DspSegmentRolling.Unit = "deg"
        Me.DspSegmentRolling.UnitVisible = False
        Me.DspSegmentRolling.Value = "-"
        Me.DspSegmentRolling.ValueType = False
        '
        'DspClosetJack
        '
        Me.DspClosetJack.BackColor = System.Drawing.Color.Transparent
        Me.DspClosetJack.Blink = False
        Me.DspClosetJack.BlinkColor = System.Drawing.Color.Red
        Me.DspClosetJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspClosetJack.DataWidth = 100
        Me.DspClosetJack.DecimalPlaces = CType(0, Short)
        Me.DspClosetJack.FieldName = "押込ｼﾞｬｯｷ"
        Me.DspClosetJack.FieldNameWidth = 146
        Me.DspClosetJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspClosetJack.Location = New System.Drawing.Point(1641, 558)
        Me.DspClosetJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetJack.Name = "DspClosetJack"
        Me.DspClosetJack.Size = New System.Drawing.Size(250, 30)
        Me.DspClosetJack.TabIndex = 106
        Me.DspClosetJack.Unit = "deg"
        Me.DspClosetJack.UnitVisible = False
        Me.DspClosetJack.Value = "-"
        Me.DspClosetJack.ValueType = True
        '
        'DspBoltPitch
        '
        Me.DspBoltPitch.BackColor = System.Drawing.Color.Transparent
        Me.DspBoltPitch.Blink = False
        Me.DspBoltPitch.BlinkColor = System.Drawing.Color.Red
        Me.DspBoltPitch.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspBoltPitch.DataWidth = 75
        Me.DspBoltPitch.DecimalPlaces = CType(1, Short)
        Me.DspBoltPitch.FieldName = "組立ﾎﾞﾙﾄ位置"
        Me.DspBoltPitch.FieldNameWidth = 170
        Me.DspBoltPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspBoltPitch.Location = New System.Drawing.Point(1399, 618)
        Me.DspBoltPitch.Margin = New System.Windows.Forms.Padding(1)
        Me.DspBoltPitch.Name = "DspBoltPitch"
        Me.DspBoltPitch.Size = New System.Drawing.Size(249, 30)
        Me.DspBoltPitch.TabIndex = 102
        Me.DspBoltPitch.Unit = "deg"
        Me.DspBoltPitch.UnitVisible = False
        Me.DspBoltPitch.Value = "-"
        Me.DspBoltPitch.ValueType = False
        '
        'DspAveStartStroke
        '
        Me.DspAveStartStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStartStroke.Blink = False
        Me.DspAveStartStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveStartStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveStartStroke.DataWidth = 75
        Me.DspAveStartStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStartStroke.FieldName = "開始ストローク"
        Me.DspAveStartStroke.FieldNameWidth = 155
        Me.DspAveStartStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStartStroke.Location = New System.Drawing.Point(0, 29)
        Me.DspAveStartStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStartStroke.Name = "DspAveStartStroke"
        Me.DspAveStartStroke.Size = New System.Drawing.Size(313, 32)
        Me.DspAveStartStroke.TabIndex = 153
        Me.DspAveStartStroke.Unit = "mm"
        Me.DspAveStartStroke.UnitVisible = True
        Me.DspAveStartStroke.Value = "9999"
        Me.DspAveStartStroke.ValueType = False
        '
        'DspExcvSpeed
        '
        Me.DspExcvSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspExcvSpeed.Blink = False
        Me.DspExcvSpeed.BlinkColor = System.Drawing.Color.Red
        Me.DspExcvSpeed.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspExcvSpeed.DataWidth = 75
        Me.DspExcvSpeed.DecimalPlaces = CType(0, Short)
        Me.DspExcvSpeed.FieldName = "掘進速度"
        Me.DspExcvSpeed.FieldNameWidth = 155
        Me.DspExcvSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcvSpeed.Location = New System.Drawing.Point(1, 95)
        Me.DspExcvSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcvSpeed.Name = "DspExcvSpeed"
        Me.DspExcvSpeed.Size = New System.Drawing.Size(300, 35)
        Me.DspExcvSpeed.TabIndex = 41
        Me.DspExcvSpeed.Unit = "mm/min"
        Me.DspExcvSpeed.UnitVisible = True
        Me.DspExcvSpeed.Value = "9999"
        Me.DspExcvSpeed.ValueType = False
        '
        'DspAveStroke
        '
        Me.DspAveStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStroke.Blink = False
        Me.DspAveStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveStroke.DataWidth = 75
        Me.DspAveStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStroke.FieldName = "推進量"
        Me.DspAveStroke.FieldNameWidth = 155
        Me.DspAveStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStroke.Location = New System.Drawing.Point(1, 62)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(313, 32)
        Me.DspAveStroke.TabIndex = 40
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.UnitVisible = True
        Me.DspAveStroke.Value = "9999"
        Me.DspAveStroke.ValueType = False
        '
        'UcnGpPvBarGraph
        '
        Me.UcnGpPvBarGraph.AutoSize = True
        Me.UcnGpPvBarGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UcnGpPvBarGraph.GpFlg = Nothing
        Me.UcnGpPvBarGraph.GpPv = Nothing
        Me.UcnGpPvBarGraph.Location = New System.Drawing.Point(27, 167)
        Me.UcnGpPvBarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.UcnGpPvBarGraph.Name = "UcnGpPvBarGraph"
        Me.UcnGpPvBarGraph.NumberGroup = 26
        Me.UcnGpPvBarGraph.PresBarGraphWidt = 50.0!
        Me.UcnGpPvBarGraph.Size = New System.Drawing.Size(78, 555)
        Me.UcnGpPvBarGraph.TabIndex = 96
        '
        'DspCopyStroke1
        '
        Me.DspCopyStroke1.BackColor = System.Drawing.Color.Transparent
        Me.DspCopyStroke1.DecimalPlaces = CType(0, Short)
        Me.DspCopyStroke1.FieldName = "余掘1"
        Me.DspCopyStroke1.Location = New System.Drawing.Point(867, 606)
        Me.DspCopyStroke1.Margin = New System.Windows.Forms.Padding(2)
        Me.DspCopyStroke1.Name = "DspCopyStroke1"
        Me.DspCopyStroke1.Size = New System.Drawing.Size(185, 30)
        Me.DspCopyStroke1.TabIndex = 149
        Me.DspCopyStroke1.Unit = "mm"
        Me.DspCopyStroke1.Value = 0R
        '
        'DspTransMRRolling
        '
        Me.DspTransMRRolling.BackColor = System.Drawing.Color.Transparent
        Me.DspTransMRRolling.DecimalPlaces = CType(2, Short)
        Me.DspTransMRRolling.FieldName = "転送時"
        Me.DspTransMRRolling.Location = New System.Drawing.Point(865, 233)
        Me.DspTransMRRolling.Margin = New System.Windows.Forms.Padding(2)
        Me.DspTransMRRolling.Name = "DspTransMRRolling"
        Me.DspTransMRRolling.Size = New System.Drawing.Size(193, 30)
        Me.DspTransMRRolling.TabIndex = 148
        Me.DspTransMRRolling.Unit = "deg"
        Me.DspTransMRRolling.Value = 0R
        '
        'DspRealMRRolling
        '
        Me.DspRealMRRolling.BackColor = System.Drawing.Color.Transparent
        Me.DspRealMRRolling.DecimalPlaces = CType(2, Short)
        Me.DspRealMRRolling.FieldName = "現在値"
        Me.DspRealMRRolling.Location = New System.Drawing.Point(865, 209)
        Me.DspRealMRRolling.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRealMRRolling.Name = "DspRealMRRolling"
        Me.DspRealMRRolling.Size = New System.Drawing.Size(193, 30)
        Me.DspRealMRRolling.TabIndex = 147
        Me.DspRealMRRolling.Unit = "deg"
        Me.DspRealMRRolling.Value = 0R
        '
        'DspUpRealStroke
        '
        Me.DspUpRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspUpRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspUpRealStroke.FieldName = "上ST実"
        Me.DspUpRealStroke.Location = New System.Drawing.Point(102, 160)
        Me.DspUpRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspUpRealStroke.Name = "DspUpRealStroke"
        Me.DspUpRealStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspUpRealStroke.TabIndex = 42
        Me.DspUpRealStroke.Unit = "mm"
        Me.DspUpRealStroke.Value = 1234.0R
        '
        'DspRightClearance
        '
        Me.DspRightClearance.BackColor = System.Drawing.Color.Transparent
        Me.DspRightClearance.DecimalPlaces = CType(0, Short)
        Me.DspRightClearance.FieldName = "右ｸﾘｱ"
        Me.DspRightClearance.Location = New System.Drawing.Point(919, 465)
        Me.DspRightClearance.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightClearance.Name = "DspRightClearance"
        Me.DspRightClearance.Size = New System.Drawing.Size(138, 46)
        Me.DspRightClearance.TabIndex = 146
        Me.DspRightClearance.Unit = "mm"
        Me.DspRightClearance.Value = 1234.0R
        '
        'DspLeftClearance
        '
        Me.DspLeftClearance.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftClearance.DecimalPlaces = CType(0, Short)
        Me.DspLeftClearance.FieldName = "左ｸﾘｱ"
        Me.DspLeftClearance.Location = New System.Drawing.Point(104, 485)
        Me.DspLeftClearance.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftClearance.Name = "DspLeftClearance"
        Me.DspLeftClearance.Size = New System.Drawing.Size(138, 46)
        Me.DspLeftClearance.TabIndex = 145
        Me.DspLeftClearance.Unit = "mm"
        Me.DspLeftClearance.Value = 1234.0R
        '
        'DspBottomSpeed
        '
        Me.DspBottomSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomSpeed.DecimalPlaces = CType(0, Short)
        Me.DspBottomSpeed.FieldName = "下速度"
        Me.DspBottomSpeed.Location = New System.Drawing.Point(114, 677)
        Me.DspBottomSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspBottomSpeed.Name = "DspBottomSpeed"
        Me.DspBottomSpeed.Size = New System.Drawing.Size(138, 46)
        Me.DspBottomSpeed.TabIndex = 47
        Me.DspBottomSpeed.Unit = "mm/min"
        Me.DspBottomSpeed.Value = 1234.0R
        '
        'DspBottomClearance
        '
        Me.DspBottomClearance.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomClearance.DecimalPlaces = CType(0, Short)
        Me.DspBottomClearance.FieldName = "下ｸﾘｱ"
        Me.DspBottomClearance.Location = New System.Drawing.Point(198, 677)
        Me.DspBottomClearance.Margin = New System.Windows.Forms.Padding(2)
        Me.DspBottomClearance.Name = "DspBottomClearance"
        Me.DspBottomClearance.Size = New System.Drawing.Size(138, 46)
        Me.DspBottomClearance.TabIndex = 144
        Me.DspBottomClearance.Unit = "mm"
        Me.DspBottomClearance.Value = 1234.0R
        '
        'DspTopClearance
        '
        Me.DspTopClearance.BackColor = System.Drawing.Color.Transparent
        Me.DspTopClearance.DecimalPlaces = CType(0, Short)
        Me.DspTopClearance.FieldName = "上ｸﾘｱ"
        Me.DspTopClearance.Location = New System.Drawing.Point(191, 160)
        Me.DspTopClearance.Margin = New System.Windows.Forms.Padding(2)
        Me.DspTopClearance.Name = "DspTopClearance"
        Me.DspTopClearance.Size = New System.Drawing.Size(143, 46)
        Me.DspTopClearance.TabIndex = 143
        Me.DspTopClearance.Unit = "mm"
        Me.DspTopClearance.Value = 1234.0R
        '
        'DspRightRawStroke
        '
        Me.DspRightRawStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRightRawStroke.DecimalPlaces = CType(0, Short)
        Me.DspRightRawStroke.FieldName = "右ST読"
        Me.DspRightRawStroke.Location = New System.Drawing.Point(919, 368)
        Me.DspRightRawStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightRawStroke.Name = "DspRightRawStroke"
        Me.DspRightRawStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspRightRawStroke.TabIndex = 142
        Me.DspRightRawStroke.Unit = "mm"
        Me.DspRightRawStroke.Value = 1234.0R
        '
        'DspBottomRawStroke
        '
        Me.DspBottomRawStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomRawStroke.DecimalPlaces = CType(0, Short)
        Me.DspBottomRawStroke.FieldName = "下ST読"
        Me.DspBottomRawStroke.Location = New System.Drawing.Point(114, 629)
        Me.DspBottomRawStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspBottomRawStroke.Name = "DspBottomRawStroke"
        Me.DspBottomRawStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspBottomRawStroke.TabIndex = 141
        Me.DspBottomRawStroke.Unit = "mm"
        Me.DspBottomRawStroke.Value = 1234.0R
        '
        'DspLeftRawStroke
        '
        Me.DspLeftRawStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftRawStroke.DecimalPlaces = CType(0, Short)
        Me.DspLeftRawStroke.FieldName = "左ST読"
        Me.DspLeftRawStroke.Location = New System.Drawing.Point(104, 383)
        Me.DspLeftRawStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftRawStroke.Name = "DspLeftRawStroke"
        Me.DspLeftRawStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspLeftRawStroke.TabIndex = 140
        Me.DspLeftRawStroke.Unit = "mm"
        Me.DspLeftRawStroke.Value = 1234.0R
        '
        'DspUpRawStroke
        '
        Me.DspUpRawStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspUpRawStroke.DecimalPlaces = CType(0, Short)
        Me.DspUpRawStroke.FieldName = "上ST読"
        Me.DspUpRawStroke.Location = New System.Drawing.Point(102, 210)
        Me.DspUpRawStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspUpRawStroke.Name = "DspUpRawStroke"
        Me.DspUpRawStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspUpRawStroke.TabIndex = 139
        Me.DspUpRawStroke.Unit = "mm"
        Me.DspUpRawStroke.Value = 1234.0R
        '
        'ucnVerLineChart
        '
        Me.ucnVerLineChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerLineChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnVerLineChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnVerLineChart.ChartCenAbsValue = 0.5!
        Me.ucnVerLineChart.ChartCenterValue = 360.0!
        Me.ucnVerLineChart.ChartHeight = 100
        Me.ucnVerLineChart.ChartHighScale = 1000.0!
        Me.ucnVerLineChart.ChartPanPenColor = System.Drawing.Color.RoyalBlue
        Me.ucnVerLineChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnVerLineChart.ChartTargetPenColor = System.Drawing.Color.Lime
        Me.ucnVerLineChart.CorrectData = 360.0!
        Me.ucnVerLineChart.DecimalPlaces = CType(2, Short)
        Me.ucnVerLineChart.FieldName = "ピッチ角(deg)"
        Me.ucnVerLineChart.Location = New System.Drawing.Point(818, 894)
        Me.ucnVerLineChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnVerLineChart.Name = "ucnVerLineChart"
        Me.ucnVerLineChart.PlanNumData = 360.0!
        Me.ucnVerLineChart.RealData = 360.0!
        Me.ucnVerLineChart.Size = New System.Drawing.Size(461, 172)
        Me.ucnVerLineChart.StrokeWidth = 2000
        Me.ucnVerLineChart.TabIndex = 124
        Me.ucnVerLineChart.TargetData = 360.0!
        '
        'ucnHorLineChart
        '
        Me.ucnHorLineChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorLineChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnHorLineChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnHorLineChart.ChartCenAbsValue = 1.0!
        Me.ucnHorLineChart.ChartCenterValue = 360.0!
        Me.ucnHorLineChart.ChartHeight = 180
        Me.ucnHorLineChart.ChartHighScale = 1000.0!
        Me.ucnHorLineChart.ChartPanPenColor = System.Drawing.Color.RoyalBlue
        Me.ucnHorLineChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnHorLineChart.ChartTargetPenColor = System.Drawing.Color.Lime
        Me.ucnHorLineChart.CorrectData = 360.0!
        Me.ucnHorLineChart.DecimalPlaces = CType(2, Short)
        Me.ucnHorLineChart.FieldName = "方位角(deg)"
        Me.ucnHorLineChart.Location = New System.Drawing.Point(818, 659)
        Me.ucnHorLineChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnHorLineChart.Name = "ucnHorLineChart"
        Me.ucnHorLineChart.PlanNumData = 360.0!
        Me.ucnHorLineChart.RealData = 360.0!
        Me.ucnHorLineChart.Size = New System.Drawing.Size(461, 232)
        Me.ucnHorLineChart.StrokeWidth = 2000
        Me.ucnHorLineChart.TabIndex = 125
        Me.ucnHorLineChart.TargetData = 360.0!
        '
        'ucnVerDevChart
        '
        Me.ucnVerDevChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerDevChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnVerDevChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnVerDevChart.ChartHighScale = 2.0!
        Me.ucnVerDevChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnVerDevChart.DecimalPlaces = CType(2, Short)
        Me.ucnVerDevChart.FieldName = "鉛直偏角(deg)"
        Me.ucnVerDevChart.Location = New System.Drawing.Point(416, 904)
        Me.ucnVerDevChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnVerDevChart.Name = "ucnVerDevChart"
        Me.ucnVerDevChart.Size = New System.Drawing.Size(397, 147)
        Me.ucnVerDevChart.StrokeWidth = 1500
        Me.ucnVerDevChart.TabIndex = 100
        '
        'ucnVerMomentChart
        '
        Me.ucnVerMomentChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnVerMomentChart.CenterColor = System.Drawing.Color.Black
        Me.ucnVerMomentChart.ChartBakColor = System.Drawing.Color.White
        Me.ucnVerMomentChart.ChartHighScale = 10000.0!
        Me.ucnVerMomentChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnVerMomentChart.DecimalPlaces = CType(0, Short)
        Me.ucnVerMomentChart.FieldName = "鉛直ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        Me.ucnVerMomentChart.Location = New System.Drawing.Point(19, 904)
        Me.ucnVerMomentChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnVerMomentChart.Name = "ucnVerMomentChart"
        Me.ucnVerMomentChart.Size = New System.Drawing.Size(397, 147)
        Me.ucnVerMomentChart.StrokeWidth = 1500
        Me.ucnVerMomentChart.TabIndex = 98
        '
        'ucnHorDevChart
        '
        Me.ucnHorDevChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorDevChart.CenterColor = System.Drawing.Color.Yellow
        Me.ucnHorDevChart.ChartBakColor = System.Drawing.Color.Black
        Me.ucnHorDevChart.ChartHighScale = 2.0!
        Me.ucnHorDevChart.ChartPenColor = System.Drawing.Color.White
        Me.ucnHorDevChart.DecimalPlaces = CType(2, Short)
        Me.ucnHorDevChart.FieldName = "水平偏角(deg)"
        Me.ucnHorDevChart.Location = New System.Drawing.Point(416, 765)
        Me.ucnHorDevChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnHorDevChart.Name = "ucnHorDevChart"
        Me.ucnHorDevChart.Size = New System.Drawing.Size(397, 143)
        Me.ucnHorDevChart.StrokeWidth = 1500
        Me.ucnHorDevChart.TabIndex = 99
        '
        'ucnHorMomentChart
        '
        Me.ucnHorMomentChart.BackColor = System.Drawing.Color.Transparent
        Me.ucnHorMomentChart.CenterColor = System.Drawing.Color.Black
        Me.ucnHorMomentChart.ChartBakColor = System.Drawing.Color.White
        Me.ucnHorMomentChart.ChartHighScale = 10000.0!
        Me.ucnHorMomentChart.ChartPenColor = System.Drawing.Color.Red
        Me.ucnHorMomentChart.DecimalPlaces = CType(0, Short)
        Me.ucnHorMomentChart.FieldName = "水平ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        Me.ucnHorMomentChart.Location = New System.Drawing.Point(22, 765)
        Me.ucnHorMomentChart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnHorMomentChart.Name = "ucnHorMomentChart"
        Me.ucnHorMomentChart.Size = New System.Drawing.Size(397, 143)
        Me.ucnHorMomentChart.StrokeWidth = 1500
        Me.ucnHorMomentChart.TabIndex = 97
        '
        'DspMachinComErr
        '
        Me.DspMachinComErr.BackColor = System.Drawing.Color.Transparent
        Me.DspMachinComErr.BitStatus = True
        Me.DspMachinComErr.Blink = True
        Me.DspMachinComErr.FieldName = "シールドマシン伝送異常"
        Me.DspMachinComErr.Location = New System.Drawing.Point(496, 195)
        Me.DspMachinComErr.Margin = New System.Windows.Forms.Padding(2)
        Me.DspMachinComErr.Name = "DspMachinComErr"
        Me.DspMachinComErr.OffBackColor = System.Drawing.Color.Yellow
        Me.DspMachinComErr.OnBackColor = System.Drawing.Color.Red
        Me.DspMachinComErr.Size = New System.Drawing.Size(193, 30)
        Me.DspMachinComErr.TabIndex = 74
        Me.DspMachinComErr.Visible = False
        '
        'DspAssemblyPattern
        '
        Me.DspAssemblyPattern.BackColor = System.Drawing.Color.Transparent
        Me.DspAssemblyPattern.Blink = False
        Me.DspAssemblyPattern.BlinkColor = System.Drawing.Color.Red
        Me.DspAssemblyPattern.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAssemblyPattern.DataWidth = 230
        Me.DspAssemblyPattern.DecimalPlaces = CType(0, Short)
        Me.DspAssemblyPattern.FieldName = "組立パターン"
        Me.DspAssemblyPattern.FieldNameWidth = 260
        Me.DspAssemblyPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(1399, 496)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(500, 30)
        Me.DspAssemblyPattern.TabIndex = 111
        Me.DspAssemblyPattern.Unit = "deg"
        Me.DspAssemblyPattern.UnitVisible = False
        Me.DspAssemblyPattern.Value = "-------"
        Me.DspAssemblyPattern.ValueType = True
        '
        'DspNextPieceName
        '
        Me.DspNextPieceName.BackColor = System.Drawing.Color.Transparent
        Me.DspNextPieceName.Blink = False
        Me.DspNextPieceName.BlinkColor = System.Drawing.Color.Red
        Me.DspNextPieceName.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspNextPieceName.DataWidth = 100
        Me.DspNextPieceName.DecimalPlaces = CType(2, Short)
        Me.DspNextPieceName.FieldName = "次の組立ピース"
        Me.DspNextPieceName.FieldNameWidth = 146
        Me.DspNextPieceName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspNextPieceName.Location = New System.Drawing.Point(1642, 526)
        Me.DspNextPieceName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspNextPieceName.Name = "DspNextPieceName"
        Me.DspNextPieceName.Size = New System.Drawing.Size(480, 30)
        Me.DspNextPieceName.TabIndex = 110
        Me.DspNextPieceName.Unit = "deg"
        Me.DspNextPieceName.UnitVisible = False
        Me.DspNextPieceName.Value = "-----"
        Me.DspNextPieceName.ValueType = True
        '
        'DspAddClosetThrustJack
        '
        Me.DspAddClosetThrustJack.BackColor = System.Drawing.Color.Transparent
        Me.DspAddClosetThrustJack.Blink = False
        Me.DspAddClosetThrustJack.BlinkColor = System.Drawing.Color.Red
        Me.DspAddClosetThrustJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAddClosetThrustJack.DataWidth = 100
        Me.DspAddClosetThrustJack.DecimalPlaces = CType(0, Short)
        Me.DspAddClosetThrustJack.FieldName = "追加推進ｼﾞｬｯｷ"
        Me.DspAddClosetThrustJack.FieldNameWidth = 146
        Me.DspAddClosetThrustJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAddClosetThrustJack.Location = New System.Drawing.Point(1641, 588)
        Me.DspAddClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAddClosetThrustJack.Name = "DspAddClosetThrustJack"
        Me.DspAddClosetThrustJack.Size = New System.Drawing.Size(250, 30)
        Me.DspAddClosetThrustJack.TabIndex = 108
        Me.DspAddClosetThrustJack.Unit = "deg"
        Me.DspAddClosetThrustJack.UnitVisible = False
        Me.DspAddClosetThrustJack.Value = "-"
        Me.DspAddClosetThrustJack.ValueType = True
        '
        'DspClosetThrustJack
        '
        Me.DspClosetThrustJack.BackColor = System.Drawing.Color.Transparent
        Me.DspClosetThrustJack.Blink = False
        Me.DspClosetThrustJack.BlinkColor = System.Drawing.Color.Red
        Me.DspClosetThrustJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspClosetThrustJack.DataWidth = 100
        Me.DspClosetThrustJack.DecimalPlaces = CType(2, Short)
        Me.DspClosetThrustJack.FieldName = "押込推進ｼﾞｬｯｷ"
        Me.DspClosetThrustJack.FieldNameWidth = 146
        Me.DspClosetThrustJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspClosetThrustJack.Location = New System.Drawing.Point(1399, 588)
        Me.DspClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetThrustJack.Name = "DspClosetThrustJack"
        Me.DspClosetThrustJack.Size = New System.Drawing.Size(250, 30)
        Me.DspClosetThrustJack.TabIndex = 107
        Me.DspClosetThrustJack.Unit = "deg"
        Me.DspClosetThrustJack.UnitVisible = False
        Me.DspClosetThrustJack.Value = "-"
        Me.DspClosetThrustJack.ValueType = True
        '
        'DspPullBackJack
        '
        Me.DspPullBackJack.BackColor = System.Drawing.Color.Transparent
        Me.DspPullBackJack.Blink = False
        Me.DspPullBackJack.BlinkColor = System.Drawing.Color.Red
        Me.DspPullBackJack.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspPullBackJack.DataWidth = 100
        Me.DspPullBackJack.DecimalPlaces = CType(2, Short)
        Me.DspPullBackJack.FieldName = "引戻ｼﾞｬｯｷ"
        Me.DspPullBackJack.FieldNameWidth = 146
        Me.DspPullBackJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPullBackJack.Location = New System.Drawing.Point(1399, 558)
        Me.DspPullBackJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPullBackJack.Name = "DspPullBackJack"
        Me.DspPullBackJack.Size = New System.Drawing.Size(250, 30)
        Me.DspPullBackJack.TabIndex = 105
        Me.DspPullBackJack.Unit = "deg"
        Me.DspPullBackJack.UnitVisible = False
        Me.DspPullBackJack.Value = "-"
        Me.DspPullBackJack.ValueType = True
        '
        'DspAssemblyPieace
        '
        Me.DspAssemblyPieace.BackColor = System.Drawing.Color.Transparent
        Me.DspAssemblyPieace.Blink = False
        Me.DspAssemblyPieace.BlinkColor = System.Drawing.Color.Red
        Me.DspAssemblyPieace.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAssemblyPieace.DataWidth = 100
        Me.DspAssemblyPieace.DecimalPlaces = CType(2, Short)
        Me.DspAssemblyPieace.FieldName = "組立ピース"
        Me.DspAssemblyPieace.FieldNameWidth = 146
        Me.DspAssemblyPieace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(1399, 526)
        Me.DspAssemblyPieace.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPieace.Name = "DspAssemblyPieace"
        Me.DspAssemblyPieace.Size = New System.Drawing.Size(480, 30)
        Me.DspAssemblyPieace.TabIndex = 103
        Me.DspAssemblyPieace.Unit = "deg"
        Me.DspAssemblyPieace.UnitVisible = False
        Me.DspAssemblyPieace.Value = "-----"
        Me.DspAssemblyPieace.ValueType = True
        '
        'DspTypeName
        '
        Me.DspTypeName.BackColor = System.Drawing.Color.Transparent
        Me.DspTypeName.Blink = False
        Me.DspTypeName.BlinkColor = System.Drawing.Color.Red
        Me.DspTypeName.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspTypeName.DataWidth = 230
        Me.DspTypeName.DecimalPlaces = CType(0, Short)
        Me.DspTypeName.FieldName = "組立セグメント"
        Me.DspTypeName.FieldNameWidth = 260
        Me.DspTypeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTypeName.Location = New System.Drawing.Point(1399, 466)
        Me.DspTypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTypeName.Name = "DspTypeName"
        Me.DspTypeName.Size = New System.Drawing.Size(500, 30)
        Me.DspTypeName.TabIndex = 101
        Me.DspTypeName.Unit = "deg"
        Me.DspTypeName.UnitVisible = False
        Me.DspTypeName.Value = "-------"
        Me.DspTypeName.ValueType = True
        '
        'UcnDspDevImg
        '
        Me.UcnDspDevImg.BackgroundImage = CType(resources.GetObject("UcnDspDevImg.BackgroundImage"), System.Drawing.Image)
        Me.UcnDspDevImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcnDspDevImg.HorDev = 0.3R
        Me.UcnDspDevImg.Location = New System.Drawing.Point(902, 31)
        Me.UcnDspDevImg.Margin = New System.Windows.Forms.Padding(2)
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
        Me.DspRightSpeed.Location = New System.Drawing.Point(917, 415)
        Me.DspRightSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightSpeed.Name = "DspRightSpeed"
        Me.DspRightSpeed.Size = New System.Drawing.Size(138, 46)
        Me.DspRightSpeed.TabIndex = 49
        Me.DspRightSpeed.Unit = "mm/min"
        Me.DspRightSpeed.Value = 1234.0R
        '
        'DspRightRealStroke
        '
        Me.DspRightRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRightRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspRightRealStroke.FieldName = "右ST実"
        Me.DspRightRealStroke.Location = New System.Drawing.Point(917, 318)
        Me.DspRightRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspRightRealStroke.Name = "DspRightRealStroke"
        Me.DspRightRealStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspRightRealStroke.TabIndex = 48
        Me.DspRightRealStroke.Unit = "mm"
        Me.DspRightRealStroke.Value = 1234.0R
        '
        'DspLeftSpeed
        '
        Me.DspLeftSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftSpeed.DecimalPlaces = CType(0, Short)
        Me.DspLeftSpeed.FieldName = "左速度"
        Me.DspLeftSpeed.Location = New System.Drawing.Point(102, 433)
        Me.DspLeftSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftSpeed.Name = "DspLeftSpeed"
        Me.DspLeftSpeed.Size = New System.Drawing.Size(138, 46)
        Me.DspLeftSpeed.TabIndex = 45
        Me.DspLeftSpeed.Unit = "mm/min"
        Me.DspLeftSpeed.Value = 1234.0R
        '
        'DspLeftRealStroke
        '
        Me.DspLeftRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspLeftRealStroke.FieldName = "左ST実"
        Me.DspLeftRealStroke.Location = New System.Drawing.Point(102, 333)
        Me.DspLeftRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLeftRealStroke.Name = "DspLeftRealStroke"
        Me.DspLeftRealStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspLeftRealStroke.TabIndex = 44
        Me.DspLeftRealStroke.Unit = "mm"
        Me.DspLeftRealStroke.Value = 1234.0R
        '
        'DspUpSpeed
        '
        Me.DspUpSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspUpSpeed.DecimalPlaces = CType(0, Short)
        Me.DspUpSpeed.FieldName = "上速度"
        Me.DspUpSpeed.Location = New System.Drawing.Point(102, 260)
        Me.DspUpSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.DspUpSpeed.Name = "DspUpSpeed"
        Me.DspUpSpeed.Size = New System.Drawing.Size(138, 46)
        Me.DspUpSpeed.TabIndex = 43
        Me.DspUpSpeed.Unit = "mm/min"
        Me.DspUpSpeed.Value = 1234.0R
        '
        'DspBottomRealStroke
        '
        Me.DspBottomRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspBottomRealStroke.FieldName = "下ST実"
        Me.DspBottomRealStroke.Location = New System.Drawing.Point(114, 579)
        Me.DspBottomRealStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DspBottomRealStroke.Name = "DspBottomRealStroke"
        Me.DspBottomRealStroke.Size = New System.Drawing.Size(138, 46)
        Me.DspBottomRealStroke.TabIndex = 46
        Me.DspBottomRealStroke.Unit = "mm"
        Me.DspBottomRealStroke.Value = 1234.0R
        '
        'DspWideUse11
        '
        Me.DspWideUse11.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse11.Blink = False
        Me.DspWideUse11.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse11.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse11.DataWidth = 110
        Me.DspWideUse11.DecimalPlaces = CType(2, Short)
        Me.DspWideUse11.FieldName = ""
        Me.DspWideUse11.FieldNameWidth = 146
        Me.DspWideUse11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse11.Location = New System.Drawing.Point(1398, 382)
        Me.DspWideUse11.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse11.Name = "DspWideUse11"
        Me.DspWideUse11.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse11.TabIndex = 80
        Me.DspWideUse11.Unit = ""
        Me.DspWideUse11.UnitVisible = True
        Me.DspWideUse11.Value = "123.45 "
        Me.DspWideUse11.ValueType = False
        '
        'DspWideUse10
        '
        Me.DspWideUse10.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse10.Blink = False
        Me.DspWideUse10.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse10.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse10.DataWidth = 110
        Me.DspWideUse10.DecimalPlaces = CType(2, Short)
        Me.DspWideUse10.FieldName = ""
        Me.DspWideUse10.FieldNameWidth = 146
        Me.DspWideUse10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse10.Location = New System.Drawing.Point(1398, 350)
        Me.DspWideUse10.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse10.Name = "DspWideUse10"
        Me.DspWideUse10.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse10.TabIndex = 79
        Me.DspWideUse10.Unit = ""
        Me.DspWideUse10.UnitVisible = True
        Me.DspWideUse10.Value = "123.45 "
        Me.DspWideUse10.ValueType = False
        '
        'DspWideUse9
        '
        Me.DspWideUse9.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse9.Blink = False
        Me.DspWideUse9.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse9.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse9.DataWidth = 110
        Me.DspWideUse9.DecimalPlaces = CType(2, Short)
        Me.DspWideUse9.FieldName = ""
        Me.DspWideUse9.FieldNameWidth = 146
        Me.DspWideUse9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse9.Location = New System.Drawing.Point(1398, 318)
        Me.DspWideUse9.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse9.Name = "DspWideUse9"
        Me.DspWideUse9.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse9.TabIndex = 78
        Me.DspWideUse9.Unit = ""
        Me.DspWideUse9.UnitVisible = True
        Me.DspWideUse9.Value = "123.45 "
        Me.DspWideUse9.ValueType = False
        '
        'DspWideUse8
        '
        Me.DspWideUse8.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse8.Blink = False
        Me.DspWideUse8.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse8.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse8.DataWidth = 110
        Me.DspWideUse8.DecimalPlaces = CType(2, Short)
        Me.DspWideUse8.FieldName = ""
        Me.DspWideUse8.FieldNameWidth = 146
        Me.DspWideUse8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse8.Location = New System.Drawing.Point(1398, 286)
        Me.DspWideUse8.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse8.Name = "DspWideUse8"
        Me.DspWideUse8.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse8.TabIndex = 77
        Me.DspWideUse8.Unit = ""
        Me.DspWideUse8.UnitVisible = True
        Me.DspWideUse8.Value = "123.45 "
        Me.DspWideUse8.ValueType = False
        '
        'DspWideUse7
        '
        Me.DspWideUse7.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse7.Blink = False
        Me.DspWideUse7.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse7.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse7.DataWidth = 110
        Me.DspWideUse7.DecimalPlaces = CType(2, Short)
        Me.DspWideUse7.FieldName = ""
        Me.DspWideUse7.FieldNameWidth = 146
        Me.DspWideUse7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse7.Location = New System.Drawing.Point(1398, 254)
        Me.DspWideUse7.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse7.Name = "DspWideUse7"
        Me.DspWideUse7.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse7.TabIndex = 76
        Me.DspWideUse7.Unit = ""
        Me.DspWideUse7.UnitVisible = True
        Me.DspWideUse7.Value = "123.45 "
        Me.DspWideUse7.ValueType = False
        '
        'DspWideUse6
        '
        Me.DspWideUse6.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse6.Blink = False
        Me.DspWideUse6.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse6.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse6.DataWidth = 110
        Me.DspWideUse6.DecimalPlaces = CType(2, Short)
        Me.DspWideUse6.FieldName = ""
        Me.DspWideUse6.FieldNameWidth = 146
        Me.DspWideUse6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse6.Location = New System.Drawing.Point(1398, 222)
        Me.DspWideUse6.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse6.Name = "DspWideUse6"
        Me.DspWideUse6.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse6.TabIndex = 75
        Me.DspWideUse6.Unit = ""
        Me.DspWideUse6.UnitVisible = True
        Me.DspWideUse6.Value = "123.45 "
        Me.DspWideUse6.ValueType = False
        '
        'DspWideUse5
        '
        Me.DspWideUse5.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse5.Blink = False
        Me.DspWideUse5.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse5.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse5.DataWidth = 110
        Me.DspWideUse5.DecimalPlaces = CType(2, Short)
        Me.DspWideUse5.FieldName = ""
        Me.DspWideUse5.FieldNameWidth = 146
        Me.DspWideUse5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse5.Location = New System.Drawing.Point(1398, 190)
        Me.DspWideUse5.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse5.Name = "DspWideUse5"
        Me.DspWideUse5.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse5.TabIndex = 74
        Me.DspWideUse5.Unit = ""
        Me.DspWideUse5.UnitVisible = True
        Me.DspWideUse5.Value = "123.45 "
        Me.DspWideUse5.ValueType = False
        '
        'DspWideUse4
        '
        Me.DspWideUse4.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse4.Blink = False
        Me.DspWideUse4.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse4.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse4.DataWidth = 110
        Me.DspWideUse4.DecimalPlaces = CType(2, Short)
        Me.DspWideUse4.FieldName = ""
        Me.DspWideUse4.FieldNameWidth = 146
        Me.DspWideUse4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse4.Location = New System.Drawing.Point(1398, 158)
        Me.DspWideUse4.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse4.Name = "DspWideUse4"
        Me.DspWideUse4.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse4.TabIndex = 73
        Me.DspWideUse4.Unit = ""
        Me.DspWideUse4.UnitVisible = True
        Me.DspWideUse4.Value = "123.45 "
        Me.DspWideUse4.ValueType = False
        '
        'DspWideUse3
        '
        Me.DspWideUse3.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse3.Blink = False
        Me.DspWideUse3.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse3.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse3.DataWidth = 110
        Me.DspWideUse3.DecimalPlaces = CType(2, Short)
        Me.DspWideUse3.FieldName = ""
        Me.DspWideUse3.FieldNameWidth = 146
        Me.DspWideUse3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse3.Location = New System.Drawing.Point(1398, 126)
        Me.DspWideUse3.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse3.Name = "DspWideUse3"
        Me.DspWideUse3.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse3.TabIndex = 72
        Me.DspWideUse3.Unit = ""
        Me.DspWideUse3.UnitVisible = True
        Me.DspWideUse3.Value = "123.45 "
        Me.DspWideUse3.ValueType = False
        '
        'DspWideUse2
        '
        Me.DspWideUse2.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse2.Blink = False
        Me.DspWideUse2.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse2.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse2.DataWidth = 110
        Me.DspWideUse2.DecimalPlaces = CType(2, Short)
        Me.DspWideUse2.FieldName = ""
        Me.DspWideUse2.FieldNameWidth = 146
        Me.DspWideUse2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse2.Location = New System.Drawing.Point(1398, 94)
        Me.DspWideUse2.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse2.Name = "DspWideUse2"
        Me.DspWideUse2.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse2.TabIndex = 71
        Me.DspWideUse2.Unit = ""
        Me.DspWideUse2.UnitVisible = True
        Me.DspWideUse2.Value = "123.45 "
        Me.DspWideUse2.ValueType = False
        '
        'DspWideUse1
        '
        Me.DspWideUse1.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse1.Blink = False
        Me.DspWideUse1.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse1.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse1.DataWidth = 110
        Me.DspWideUse1.DecimalPlaces = CType(2, Short)
        Me.DspWideUse1.FieldName = ""
        Me.DspWideUse1.FieldNameWidth = 146
        Me.DspWideUse1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse1.Location = New System.Drawing.Point(1398, 62)
        Me.DspWideUse1.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse1.Name = "DspWideUse1"
        Me.DspWideUse1.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse1.TabIndex = 70
        Me.DspWideUse1.Unit = ""
        Me.DspWideUse1.UnitVisible = True
        Me.DspWideUse1.Value = "123.45 "
        Me.DspWideUse1.ValueType = False
        '
        'DspWideUse0
        '
        Me.DspWideUse0.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse0.Blink = False
        Me.DspWideUse0.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse0.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse0.DataWidth = 110
        Me.DspWideUse0.DecimalPlaces = CType(2, Short)
        Me.DspWideUse0.FieldName = ""
        Me.DspWideUse0.FieldNameWidth = 146
        Me.DspWideUse0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse0.Location = New System.Drawing.Point(1398, 30)
        Me.DspWideUse0.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse0.Name = "DspWideUse0"
        Me.DspWideUse0.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse0.TabIndex = 69
        Me.DspWideUse0.Unit = ""
        Me.DspWideUse0.UnitVisible = True
        Me.DspWideUse0.Value = "123.45 "
        Me.DspWideUse0.ValueType = False
        '
        'UcnJackDsp
        '
        Me.UcnJackDsp.AssemblyOrder = CType(resources.GetObject("UcnJackDsp.AssemblyOrder"), System.Collections.Generic.List(Of Short))
        Me.UcnJackDsp.AssemblyPieceNo = CType(0, Short)
        Me.UcnJackDsp.AutoSize = True
        Me.UcnJackDsp.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp.BackgroundImage = CType(resources.GetObject("UcnJackDsp.BackgroundImage"), System.Drawing.Image)
        Me.UcnJackDsp.CopyStrechSet = 10
        Me.UcnJackDsp.CopyVisible = True
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
        Me.UcnJackDsp.Location = New System.Drawing.Point(172, 111)
        Me.UcnJackDsp.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnJackDsp.Name = "UcnJackDsp"
        Me.UcnJackDsp.NoOperation = False
        Me.UcnJackDsp.NumberGroup = CType(0, Short)
        Me.UcnJackDsp.NumberJack = CType(0, Short)
        Me.UcnJackDsp.PieceAngle = CType(resources.GetObject("UcnJackDsp.PieceAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceCenterAngle = CType(resources.GetObject("UcnJackDsp.PieceCenterAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceName = CType(resources.GetObject("UcnJackDsp.PieceName"), System.Collections.Generic.List(Of String))
        Me.UcnJackDsp.PointRLimitOver = False
        Me.UcnJackDsp.SegmentDspEnable = False
        Me.UcnJackDsp.SemiAuto = False
        Me.UcnJackDsp.Size = New System.Drawing.Size(795, 731)
        Me.UcnJackDsp.TabIndex = 68
        '
        'DspTargetPitching
        '
        Me.DspTargetPitching.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetPitching.Blink = False
        Me.DspTargetPitching.BlinkColor = System.Drawing.Color.Red
        Me.DspTargetPitching.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTargetPitching.DataWidth = 110
        Me.DspTargetPitching.DecimalPlaces = CType(2, Short)
        Me.DspTargetPitching.FieldName = "目標ピッチ角"
        Me.DspTargetPitching.FieldNameWidth = 146
        Me.DspTargetPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetPitching.Location = New System.Drawing.Point(1070, 625)
        Me.DspTargetPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetPitching.Name = "DspTargetPitching"
        Me.DspTargetPitching.Size = New System.Drawing.Size(320, 32)
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
        Me.DspTargetDirection.DataWidth = 110
        Me.DspTargetDirection.DecimalPlaces = CType(2, Short)
        Me.DspTargetDirection.FieldName = "目標方位角"
        Me.DspTargetDirection.FieldNameWidth = 146
        Me.DspTargetDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetDirection.Location = New System.Drawing.Point(1070, 592)
        Me.DspTargetDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetDirection.Name = "DspTargetDirection"
        Me.DspTargetDirection.Size = New System.Drawing.Size(320, 32)
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
        Me.DspVerRChangePoint.DataWidth = 110
        Me.DspVerRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerRChangePoint.FieldName = "後方変化点"
        Me.DspVerRChangePoint.FieldNameWidth = 146
        Me.DspVerRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerRChangePoint.Location = New System.Drawing.Point(1070, 549)
        Me.DspVerRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerRChangePoint.Name = "DspVerRChangePoint"
        Me.DspVerRChangePoint.Size = New System.Drawing.Size(320, 32)
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
        Me.DspVerFChangePoint.DataWidth = 110
        Me.DspVerFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerFChangePoint.FieldName = "前方変化点"
        Me.DspVerFChangePoint.FieldNameWidth = 146
        Me.DspVerFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerFChangePoint.Location = New System.Drawing.Point(1070, 517)
        Me.DspVerFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerFChangePoint.Name = "DspVerFChangePoint"
        Me.DspVerFChangePoint.Size = New System.Drawing.Size(320, 32)
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
        Me.DspVerLine.DataWidth = 110
        Me.DspVerLine.DecimalPlaces = CType(3, Short)
        Me.DspVerLine.FieldName = "縦断線形"
        Me.DspVerLine.FieldNameWidth = 146
        Me.DspVerLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerLine.Location = New System.Drawing.Point(1070, 485)
        Me.DspVerLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerLine.Name = "DspVerLine"
        Me.DspVerLine.Size = New System.Drawing.Size(320, 32)
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
        Me.DspHorRChangePoint.DataWidth = 110
        Me.DspHorRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorRChangePoint.FieldName = "後方変化点"
        Me.DspHorRChangePoint.FieldNameWidth = 146
        Me.DspHorRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorRChangePoint.Location = New System.Drawing.Point(1070, 445)
        Me.DspHorRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorRChangePoint.Name = "DspHorRChangePoint"
        Me.DspHorRChangePoint.Size = New System.Drawing.Size(320, 32)
        Me.DspHorRChangePoint.TabIndex = 34
        Me.DspHorRChangePoint.Unit = "m"
        Me.DspHorRChangePoint.UnitVisible = True
        Me.DspHorRChangePoint.Value = "9123.45"
        Me.DspHorRChangePoint.ValueType = False
        '
        'DspHorFChangePoint
        '
        Me.DspHorFChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspHorFChangePoint.Blink = False
        Me.DspHorFChangePoint.BlinkColor = System.Drawing.Color.Red
        Me.DspHorFChangePoint.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorFChangePoint.DataWidth = 110
        Me.DspHorFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorFChangePoint.FieldName = "前方変化点"
        Me.DspHorFChangePoint.FieldNameWidth = 146
        Me.DspHorFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorFChangePoint.Location = New System.Drawing.Point(1070, 413)
        Me.DspHorFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorFChangePoint.Name = "DspHorFChangePoint"
        Me.DspHorFChangePoint.Size = New System.Drawing.Size(320, 32)
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
        Me.DspHorLine.DataWidth = 110
        Me.DspHorLine.DecimalPlaces = CType(3, Short)
        Me.DspHorLine.FieldName = "平面線形"
        Me.DspHorLine.FieldNameWidth = 146
        Me.DspHorLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorLine.Location = New System.Drawing.Point(1070, 381)
        Me.DspHorLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorLine.Name = "DspHorLine"
        Me.DspHorLine.Size = New System.Drawing.Size(320, 32)
        Me.DspHorLine.TabIndex = 32
        Me.DspHorLine.Unit = "m"
        Me.DspHorLine.UnitVisible = True
        Me.DspHorLine.Value = "-2123.455"
        Me.DspHorLine.ValueType = False
        '
        'DspDistance
        '
        Me.DspDistance.BackColor = System.Drawing.Color.Transparent
        Me.DspDistance.Blink = False
        Me.DspDistance.BlinkColor = System.Drawing.Color.Red
        Me.DspDistance.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspDistance.DataWidth = 110
        Me.DspDistance.DecimalPlaces = CType(3, Short)
        Me.DspDistance.FieldName = "中心の総距離"
        Me.DspDistance.FieldNameWidth = 146
        Me.DspDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDistance.Location = New System.Drawing.Point(1070, 343)
        Me.DspDistance.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDistance.Name = "DspDistance"
        Me.DspDistance.Size = New System.Drawing.Size(320, 32)
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
        Me.DspMoment.DataWidth = 110
        Me.DspMoment.DecimalPlaces = CType(0, Short)
        Me.DspMoment.FieldName = "ｼﾞｬｯｷﾓｰﾒﾝﾄ"
        Me.DspMoment.FieldNameWidth = 146
        Me.DspMoment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspMoment.Location = New System.Drawing.Point(1070, 301)
        Me.DspMoment.Margin = New System.Windows.Forms.Padding(1)
        Me.DspMoment.Name = "DspMoment"
        Me.DspMoment.Size = New System.Drawing.Size(320, 32)
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
        Me.DspThrust.DataWidth = 110
        Me.DspThrust.DecimalPlaces = CType(0, Short)
        Me.DspThrust.FieldName = "推力"
        Me.DspThrust.FieldNameWidth = 146
        Me.DspThrust.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspThrust.Location = New System.Drawing.Point(1070, 269)
        Me.DspThrust.Margin = New System.Windows.Forms.Padding(1)
        Me.DspThrust.Name = "DspThrust"
        Me.DspThrust.Size = New System.Drawing.Size(320, 32)
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
        Me.DspJackPress.DataWidth = 110
        Me.DspJackPress.DecimalPlaces = CType(1, Short)
        Me.DspJackPress.FieldName = "シールド圧"
        Me.DspJackPress.FieldNameWidth = 146
        Me.DspJackPress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspJackPress.Location = New System.Drawing.Point(1070, 237)
        Me.DspJackPress.Margin = New System.Windows.Forms.Padding(1)
        Me.DspJackPress.Name = "DspJackPress"
        Me.DspJackPress.Size = New System.Drawing.Size(320, 32)
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
        Me.DspVerBroken.DataWidth = 110
        Me.DspVerBroken.DecimalPlaces = CType(2, Short)
        Me.DspVerBroken.FieldName = "鉛直中折角"
        Me.DspVerBroken.FieldNameWidth = 146
        Me.DspVerBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerBroken.Location = New System.Drawing.Point(1070, 200)
        Me.DspVerBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerBroken.Name = "DspVerBroken"
        Me.DspVerBroken.Size = New System.Drawing.Size(320, 32)
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
        Me.DspHorBroken.DataWidth = 110
        Me.DspHorBroken.DecimalPlaces = CType(2, Short)
        Me.DspHorBroken.FieldName = "水平中折角"
        Me.DspHorBroken.FieldNameWidth = 146
        Me.DspHorBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorBroken.Location = New System.Drawing.Point(1070, 168)
        Me.DspHorBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorBroken.Name = "DspHorBroken"
        Me.DspHorBroken.Size = New System.Drawing.Size(320, 32)
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
        Me.DspPitching.DataWidth = 110
        Me.DspPitching.DecimalPlaces = CType(2, Short)
        Me.DspPitching.FieldName = "ピッチング"
        Me.DspPitching.FieldNameWidth = 146
        Me.DspPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPitching.Location = New System.Drawing.Point(1070, 131)
        Me.DspPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPitching.Name = "DspPitching"
        Me.DspPitching.Size = New System.Drawing.Size(320, 32)
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
        Me.DspDirection.DataWidth = 110
        Me.DspDirection.DecimalPlaces = CType(2, Short)
        Me.DspDirection.FieldName = "方位角"
        Me.DspDirection.FieldNameWidth = 146
        Me.DspDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDirection.Location = New System.Drawing.Point(1070, 99)
        Me.DspDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDirection.Name = "DspDirection"
        Me.DspDirection.Size = New System.Drawing.Size(320, 32)
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
        Me.DspVerDev.DataWidth = 110
        Me.DspVerDev.DecimalPlaces = CType(2, Short)
        Me.DspVerDev.FieldName = "鉛直偏角"
        Me.DspVerDev.FieldNameWidth = 146
        Me.DspVerDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerDev.Location = New System.Drawing.Point(1070, 62)
        Me.DspVerDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerDev.Name = "DspVerDev"
        Me.DspVerDev.Size = New System.Drawing.Size(320, 32)
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
        Me.DspHorDev.DataWidth = 110
        Me.DspHorDev.DecimalPlaces = CType(2, Short)
        Me.DspHorDev.FieldName = "水平偏角"
        Me.DspHorDev.FieldNameWidth = 146
        Me.DspHorDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorDev.Location = New System.Drawing.Point(1070, 30)
        Me.DspHorDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorDev.Name = "DspHorDev"
        Me.DspHorDev.Size = New System.Drawing.Size(320, 32)
        Me.DspHorDev.TabIndex = 22
        Me.DspHorDev.Unit = "deg"
        Me.DspHorDev.UnitVisible = True
        Me.DspHorDev.Value = "123.45 "
        Me.DspHorDev.ValueType = False
        '
        'DspWideUse12
        '
        Me.DspWideUse12.BackColor = System.Drawing.Color.Transparent
        Me.DspWideUse12.Blink = False
        Me.DspWideUse12.BlinkColor = System.Drawing.Color.Red
        Me.DspWideUse12.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspWideUse12.DataWidth = 110
        Me.DspWideUse12.DecimalPlaces = CType(2, Short)
        Me.DspWideUse12.FieldName = ""
        Me.DspWideUse12.FieldNameWidth = 146
        Me.DspWideUse12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspWideUse12.Location = New System.Drawing.Point(1398, 416)
        Me.DspWideUse12.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse12.Name = "DspWideUse12"
        Me.DspWideUse12.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse12.TabIndex = 157
        Me.DspWideUse12.Unit = ""
        Me.DspWideUse12.UnitVisible = True
        Me.DspWideUse12.Value = "123.45 "
        Me.DspWideUse12.ValueType = False
        Me.DspWideUse12.Visible = False
        '
        'InterruptTime
        '
        Me.InterruptTime.BackColor = System.Drawing.Color.Transparent
        Me.InterruptTime.Blink = False
        Me.InterruptTime.BlinkColor = System.Drawing.Color.Red
        Me.InterruptTime.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InterruptTime.DataWidth = 91
        Me.InterruptTime.DecimalPlaces = CType(0, Short)
        Me.InterruptTime.FieldName = "中断時間(分)"
        Me.InterruptTime.FieldNameWidth = 175
        Me.InterruptTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InterruptTime.Location = New System.Drawing.Point(21, 179)
        Me.InterruptTime.Margin = New System.Windows.Forms.Padding(1)
        Me.InterruptTime.Name = "InterruptTime"
        Me.InterruptTime.Size = New System.Drawing.Size(275, 32)
        Me.InterruptTime.TabIndex = 127
        Me.InterruptTime.Unit = "deg"
        Me.InterruptTime.UnitVisible = False
        Me.InterruptTime.Value = "20"
        Me.InterruptTime.ValueType = False
        '
        'DspCopyStroke2
        '
        Me.DspCopyStroke2.BackColor = System.Drawing.Color.Transparent
        Me.DspCopyStroke2.DecimalPlaces = CType(0, Short)
        Me.DspCopyStroke2.FieldName = "余掘2"
        Me.DspCopyStroke2.Location = New System.Drawing.Point(866, 629)
        Me.DspCopyStroke2.Margin = New System.Windows.Forms.Padding(2)
        Me.DspCopyStroke2.Name = "DspCopyStroke2"
        Me.DspCopyStroke2.Size = New System.Drawing.Size(185, 30)
        Me.DspCopyStroke2.TabIndex = 163
        Me.DspCopyStroke2.Unit = "mm"
        Me.DspCopyStroke2.Value = 0R
        '
        'btnNoOpJk
        '
        Me.btnNoOpJk.BackColor = System.Drawing.Color.DarkGray
        Me.btnNoOpJk.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNoOpJk.Location = New System.Drawing.Point(1746, 381)
        Me.btnNoOpJk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNoOpJk.Name = "btnNoOpJk"
        Me.btnNoOpJk.Size = New System.Drawing.Size(146, 36)
        Me.btnNoOpJk.TabIndex = 164
        Me.btnNoOpJk.Text = "不動作ｼﾞｬｯｷOFF"
        Me.btnNoOpJk.UseVisualStyleBackColor = False
        '
        'pnlStrokeDiffContorol
        '
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label12)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertBtmStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertBtmStartStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label5)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertHorStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertHorStartStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.label4)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertTopStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblConvertTopStartStrokeDiff)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmRingTargetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmLeftStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmRightStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmStItem)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmNetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmLeftRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmRightRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmLeftStartSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblBtmRightStartSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorRingTargetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorLefttStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorRightStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorStItem)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorNetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorLeftRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorRightRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorLeftStartSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblHorRightStartSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopRingTargetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label13)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopLefttStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopRightStNo)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopStItem)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label9)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label8)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label7)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.Label6)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblFieldName)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopNetSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopLeftRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopRightRealSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopLeftStartSt)
        Me.pnlStrokeDiffContorol.Controls.Add(Me.lblTopRightStartSt)
        Me.pnlStrokeDiffContorol.Location = New System.Drawing.Point(836, 662)
        Me.pnlStrokeDiffContorol.Name = "pnlStrokeDiffContorol"
        Me.pnlStrokeDiffContorol.Size = New System.Drawing.Size(432, 229)
        Me.pnlStrokeDiffContorol.TabIndex = 176
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.LightGray
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 204)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 20)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "下半換算ｽﾄﾛｰｸ差"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConvertBtmStrokeDiff
        '
        Me.lblConvertBtmStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertBtmStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertBtmStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertBtmStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertBtmStrokeDiff.Location = New System.Drawing.Point(209, 204)
        Me.lblConvertBtmStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertBtmStrokeDiff.Name = "lblConvertBtmStrokeDiff"
        Me.lblConvertBtmStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertBtmStrokeDiff.TabIndex = 216
        Me.lblConvertBtmStrokeDiff.Text = "------"
        Me.lblConvertBtmStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConvertBtmStartStrokeDiff
        '
        Me.lblConvertBtmStartStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertBtmStartStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertBtmStartStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertBtmStartStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertBtmStartStrokeDiff.Location = New System.Drawing.Point(149, 204)
        Me.lblConvertBtmStartStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertBtmStartStrokeDiff.Name = "lblConvertBtmStartStrokeDiff"
        Me.lblConvertBtmStartStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertBtmStartStrokeDiff.TabIndex = 215
        Me.lblConvertBtmStartStrokeDiff.Text = "------"
        Me.lblConvertBtmStartStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "水平部ｽﾄﾛｰｸ差"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConvertHorStrokeDiff
        '
        Me.lblConvertHorStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertHorStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertHorStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertHorStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertHorStrokeDiff.Location = New System.Drawing.Point(211, 144)
        Me.lblConvertHorStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertHorStrokeDiff.Name = "lblConvertHorStrokeDiff"
        Me.lblConvertHorStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertHorStrokeDiff.TabIndex = 213
        Me.lblConvertHorStrokeDiff.Text = "1000"
        Me.lblConvertHorStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConvertHorStartStrokeDiff
        '
        Me.lblConvertHorStartStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertHorStartStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertHorStartStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertHorStartStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertHorStartStrokeDiff.Location = New System.Drawing.Point(151, 144)
        Me.lblConvertHorStartStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertHorStartStrokeDiff.Name = "lblConvertHorStartStrokeDiff"
        Me.lblConvertHorStartStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertHorStartStrokeDiff.TabIndex = 212
        Me.lblConvertHorStartStrokeDiff.Text = "1000"
        Me.lblConvertHorStartStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.LightGray
        Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label4.Location = New System.Drawing.Point(4, 84)
        Me.label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(145, 20)
        Me.label4.TabIndex = 211
        Me.label4.Text = "上半換算ｽﾄﾛｰｸ差"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConvertTopStrokeDiff
        '
        Me.lblConvertTopStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertTopStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertTopStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertTopStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertTopStrokeDiff.Location = New System.Drawing.Point(211, 84)
        Me.lblConvertTopStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertTopStrokeDiff.Name = "lblConvertTopStrokeDiff"
        Me.lblConvertTopStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertTopStrokeDiff.TabIndex = 210
        Me.lblConvertTopStrokeDiff.Text = "-----"
        Me.lblConvertTopStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConvertTopStartStrokeDiff
        '
        Me.lblConvertTopStartStrokeDiff.BackColor = System.Drawing.Color.Black
        Me.lblConvertTopStartStrokeDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConvertTopStartStrokeDiff.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblConvertTopStartStrokeDiff.ForeColor = System.Drawing.Color.LightGreen
        Me.lblConvertTopStartStrokeDiff.Location = New System.Drawing.Point(151, 84)
        Me.lblConvertTopStartStrokeDiff.Margin = New System.Windows.Forms.Padding(0)
        Me.lblConvertTopStartStrokeDiff.Name = "lblConvertTopStartStrokeDiff"
        Me.lblConvertTopStartStrokeDiff.Size = New System.Drawing.Size(60, 20)
        Me.lblConvertTopStartStrokeDiff.TabIndex = 209
        Me.lblConvertTopStartStrokeDiff.Text = "-----"
        Me.lblConvertTopStartStrokeDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmRingTargetSt
        '
        Me.lblBtmRingTargetSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmRingTargetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmRingTargetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmRingTargetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmRingTargetSt.Location = New System.Drawing.Point(348, 164)
        Me.lblBtmRingTargetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmRingTargetSt.Name = "lblBtmRingTargetSt"
        Me.lblBtmRingTargetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblBtmRingTargetSt.TabIndex = 207
        Me.lblBtmRingTargetSt.Text = "------"
        Me.lblBtmRingTargetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmLeftStNo
        '
        Me.lblBtmLeftStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblBtmLeftStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBtmLeftStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmLeftStNo.Location = New System.Drawing.Point(97, 184)
        Me.lblBtmLeftStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBtmLeftStNo.Name = "lblBtmLeftStNo"
        Me.lblBtmLeftStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblBtmLeftStNo.TabIndex = 206
        Me.lblBtmLeftStNo.Text = "No."
        Me.lblBtmLeftStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtmRightStNo
        '
        Me.lblBtmRightStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblBtmRightStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBtmRightStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmRightStNo.Location = New System.Drawing.Point(97, 164)
        Me.lblBtmRightStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBtmRightStNo.Name = "lblBtmRightStNo"
        Me.lblBtmRightStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblBtmRightStNo.TabIndex = 205
        Me.lblBtmRightStNo.Text = "No."
        Me.lblBtmRightStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtmStItem
        '
        Me.lblBtmStItem.BackColor = System.Drawing.Color.LightGray
        Me.lblBtmStItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBtmStItem.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmStItem.Location = New System.Drawing.Point(4, 164)
        Me.lblBtmStItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBtmStItem.Name = "lblBtmStItem"
        Me.lblBtmStItem.Size = New System.Drawing.Size(92, 40)
        Me.lblBtmStItem.TabIndex = 204
        Me.lblBtmStItem.Text = "下半" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ｽﾄﾛｰｸ"
        Me.lblBtmStItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtmNetSt
        '
        Me.lblBtmNetSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmNetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmNetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmNetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmNetSt.Location = New System.Drawing.Point(270, 164)
        Me.lblBtmNetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmNetSt.Name = "lblBtmNetSt"
        Me.lblBtmNetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblBtmNetSt.TabIndex = 203
        Me.lblBtmNetSt.Text = "------"
        Me.lblBtmNetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmLeftRealSt
        '
        Me.lblBtmLeftRealSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmLeftRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmLeftRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmLeftRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmLeftRealSt.Location = New System.Drawing.Point(211, 184)
        Me.lblBtmLeftRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmLeftRealSt.Name = "lblBtmLeftRealSt"
        Me.lblBtmLeftRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblBtmLeftRealSt.TabIndex = 202
        Me.lblBtmLeftRealSt.Text = "------"
        Me.lblBtmLeftRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmRightRealSt
        '
        Me.lblBtmRightRealSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmRightRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmRightRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmRightRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmRightRealSt.Location = New System.Drawing.Point(211, 164)
        Me.lblBtmRightRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmRightRealSt.Name = "lblBtmRightRealSt"
        Me.lblBtmRightRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblBtmRightRealSt.TabIndex = 201
        Me.lblBtmRightRealSt.Text = "------"
        Me.lblBtmRightRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmLeftStartSt
        '
        Me.lblBtmLeftStartSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmLeftStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmLeftStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmLeftStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmLeftStartSt.Location = New System.Drawing.Point(151, 184)
        Me.lblBtmLeftStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmLeftStartSt.Name = "lblBtmLeftStartSt"
        Me.lblBtmLeftStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblBtmLeftStartSt.TabIndex = 200
        Me.lblBtmLeftStartSt.Text = "------"
        Me.lblBtmLeftStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBtmRightStartSt
        '
        Me.lblBtmRightStartSt.BackColor = System.Drawing.Color.Black
        Me.lblBtmRightStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBtmRightStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblBtmRightStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblBtmRightStartSt.Location = New System.Drawing.Point(151, 164)
        Me.lblBtmRightStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBtmRightStartSt.Name = "lblBtmRightStartSt"
        Me.lblBtmRightStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblBtmRightStartSt.TabIndex = 199
        Me.lblBtmRightStartSt.Text = "------"
        Me.lblBtmRightStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorRingTargetSt
        '
        Me.lblHorRingTargetSt.BackColor = System.Drawing.Color.Black
        Me.lblHorRingTargetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorRingTargetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorRingTargetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorRingTargetSt.Location = New System.Drawing.Point(348, 104)
        Me.lblHorRingTargetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorRingTargetSt.Name = "lblHorRingTargetSt"
        Me.lblHorRingTargetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblHorRingTargetSt.TabIndex = 198
        Me.lblHorRingTargetSt.Text = "1000"
        Me.lblHorRingTargetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorLefttStNo
        '
        Me.lblHorLefttStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblHorLefttStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorLefttStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorLefttStNo.Location = New System.Drawing.Point(97, 124)
        Me.lblHorLefttStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHorLefttStNo.Name = "lblHorLefttStNo"
        Me.lblHorLefttStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblHorLefttStNo.TabIndex = 197
        Me.lblHorLefttStNo.Text = "No."
        Me.lblHorLefttStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorRightStNo
        '
        Me.lblHorRightStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblHorRightStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorRightStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorRightStNo.Location = New System.Drawing.Point(97, 104)
        Me.lblHorRightStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHorRightStNo.Name = "lblHorRightStNo"
        Me.lblHorRightStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblHorRightStNo.TabIndex = 196
        Me.lblHorRightStNo.Text = "No."
        Me.lblHorRightStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorStItem
        '
        Me.lblHorStItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblHorStItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHorStItem.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorStItem.Location = New System.Drawing.Point(4, 104)
        Me.lblHorStItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHorStItem.Name = "lblHorStItem"
        Me.lblHorStItem.Size = New System.Drawing.Size(92, 40)
        Me.lblHorStItem.TabIndex = 195
        Me.lblHorStItem.Text = "水平部ｽﾄﾛｰｸ"
        Me.lblHorStItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHorNetSt
        '
        Me.lblHorNetSt.BackColor = System.Drawing.Color.Black
        Me.lblHorNetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorNetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorNetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorNetSt.Location = New System.Drawing.Point(270, 104)
        Me.lblHorNetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorNetSt.Name = "lblHorNetSt"
        Me.lblHorNetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblHorNetSt.TabIndex = 194
        Me.lblHorNetSt.Text = "1000"
        Me.lblHorNetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorLeftRealSt
        '
        Me.lblHorLeftRealSt.BackColor = System.Drawing.Color.Black
        Me.lblHorLeftRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorLeftRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorLeftRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorLeftRealSt.Location = New System.Drawing.Point(210, 124)
        Me.lblHorLeftRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorLeftRealSt.Name = "lblHorLeftRealSt"
        Me.lblHorLeftRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblHorLeftRealSt.TabIndex = 193
        Me.lblHorLeftRealSt.Text = "1000"
        Me.lblHorLeftRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorRightRealSt
        '
        Me.lblHorRightRealSt.BackColor = System.Drawing.Color.Black
        Me.lblHorRightRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorRightRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorRightRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorRightRealSt.Location = New System.Drawing.Point(210, 104)
        Me.lblHorRightRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorRightRealSt.Name = "lblHorRightRealSt"
        Me.lblHorRightRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblHorRightRealSt.TabIndex = 192
        Me.lblHorRightRealSt.Text = "1000"
        Me.lblHorRightRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorLeftStartSt
        '
        Me.lblHorLeftStartSt.BackColor = System.Drawing.Color.Black
        Me.lblHorLeftStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorLeftStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorLeftStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorLeftStartSt.Location = New System.Drawing.Point(150, 124)
        Me.lblHorLeftStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorLeftStartSt.Name = "lblHorLeftStartSt"
        Me.lblHorLeftStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblHorLeftStartSt.TabIndex = 191
        Me.lblHorLeftStartSt.Text = "1000"
        Me.lblHorLeftStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHorRightStartSt
        '
        Me.lblHorRightStartSt.BackColor = System.Drawing.Color.Black
        Me.lblHorRightStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorRightStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHorRightStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblHorRightStartSt.Location = New System.Drawing.Point(150, 104)
        Me.lblHorRightStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHorRightStartSt.Name = "lblHorRightStartSt"
        Me.lblHorRightStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblHorRightStartSt.TabIndex = 190
        Me.lblHorRightStartSt.Text = "1000"
        Me.lblHorRightStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopRingTargetSt
        '
        Me.lblTopRingTargetSt.BackColor = System.Drawing.Color.Black
        Me.lblTopRingTargetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopRingTargetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopRingTargetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopRingTargetSt.Location = New System.Drawing.Point(348, 44)
        Me.lblTopRingTargetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopRingTargetSt.Name = "lblTopRingTargetSt"
        Me.lblTopRingTargetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblTopRingTargetSt.TabIndex = 189
        Me.lblTopRingTargetSt.Text = "-----"
        Me.lblTopRingTargetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(348, 1)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 44)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "ﾘﾝｸﾞ目標ｽﾄﾛｰｸ差" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mm)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopLefttStNo
        '
        Me.lblTopLefttStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblTopLefttStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopLefttStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopLefttStNo.Location = New System.Drawing.Point(97, 64)
        Me.lblTopLefttStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTopLefttStNo.Name = "lblTopLefttStNo"
        Me.lblTopLefttStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblTopLefttStNo.TabIndex = 187
        Me.lblTopLefttStNo.Text = "No."
        Me.lblTopLefttStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopRightStNo
        '
        Me.lblTopRightStNo.BackColor = System.Drawing.Color.LightGray
        Me.lblTopRightStNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopRightStNo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopRightStNo.Location = New System.Drawing.Point(97, 44)
        Me.lblTopRightStNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTopRightStNo.Name = "lblTopRightStNo"
        Me.lblTopRightStNo.Size = New System.Drawing.Size(52, 20)
        Me.lblTopRightStNo.TabIndex = 186
        Me.lblTopRightStNo.Text = "No."
        Me.lblTopRightStNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopStItem
        '
        Me.lblTopStItem.BackColor = System.Drawing.Color.LightGray
        Me.lblTopStItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopStItem.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopStItem.Location = New System.Drawing.Point(4, 44)
        Me.lblTopStItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTopStItem.Name = "lblTopStItem"
        Me.lblTopStItem.Size = New System.Drawing.Size(92, 40)
        Me.lblTopStItem.TabIndex = 185
        Me.lblTopStItem.Text = "上半" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ｽﾄﾛｰｸ"
        Me.lblTopStItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 1)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 44)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "制御管理用" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ストローク"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightGray
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 1)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 44)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "推進量" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mm)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 22)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "現在"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 22)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "開始"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.LightGray
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(149, 1)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(120, 22)
        Me.lblFieldName.TabIndex = 180
        Me.lblFieldName.Text = "実ｽﾄﾛｰｸ(mm)"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopNetSt
        '
        Me.lblTopNetSt.BackColor = System.Drawing.Color.Black
        Me.lblTopNetSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopNetSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopNetSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopNetSt.Location = New System.Drawing.Point(270, 44)
        Me.lblTopNetSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopNetSt.Name = "lblTopNetSt"
        Me.lblTopNetSt.Size = New System.Drawing.Size(78, 60)
        Me.lblTopNetSt.TabIndex = 179
        Me.lblTopNetSt.Text = "-----"
        Me.lblTopNetSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopLeftRealSt
        '
        Me.lblTopLeftRealSt.BackColor = System.Drawing.Color.Black
        Me.lblTopLeftRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopLeftRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopLeftRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopLeftRealSt.Location = New System.Drawing.Point(210, 64)
        Me.lblTopLeftRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopLeftRealSt.Name = "lblTopLeftRealSt"
        Me.lblTopLeftRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblTopLeftRealSt.TabIndex = 178
        Me.lblTopLeftRealSt.Text = "-----"
        Me.lblTopLeftRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopRightRealSt
        '
        Me.lblTopRightRealSt.BackColor = System.Drawing.Color.Black
        Me.lblTopRightRealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopRightRealSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopRightRealSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopRightRealSt.Location = New System.Drawing.Point(210, 44)
        Me.lblTopRightRealSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopRightRealSt.Name = "lblTopRightRealSt"
        Me.lblTopRightRealSt.Size = New System.Drawing.Size(60, 20)
        Me.lblTopRightRealSt.TabIndex = 177
        Me.lblTopRightRealSt.Text = "-----"
        Me.lblTopRightRealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopLeftStartSt
        '
        Me.lblTopLeftStartSt.BackColor = System.Drawing.Color.Black
        Me.lblTopLeftStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopLeftStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopLeftStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopLeftStartSt.Location = New System.Drawing.Point(150, 64)
        Me.lblTopLeftStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopLeftStartSt.Name = "lblTopLeftStartSt"
        Me.lblTopLeftStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblTopLeftStartSt.TabIndex = 176
        Me.lblTopLeftStartSt.Text = "-----"
        Me.lblTopLeftStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopRightStartSt
        '
        Me.lblTopRightStartSt.BackColor = System.Drawing.Color.Black
        Me.lblTopRightStartSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTopRightStartSt.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTopRightStartSt.ForeColor = System.Drawing.Color.LightGreen
        Me.lblTopRightStartSt.Location = New System.Drawing.Point(150, 44)
        Me.lblTopRightStartSt.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTopRightStartSt.Name = "lblTopRightStartSt"
        Me.lblTopRightStartSt.Size = New System.Drawing.Size(60, 20)
        Me.lblTopRightStartSt.TabIndex = 175
        Me.lblTopRightStartSt.Text = "-----"
        Me.lblTopRightStartSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DspLRRealStrokeDiff
        '
        Me.DspLRRealStrokeDiff.BackColor = System.Drawing.Color.Transparent
        Me.DspLRRealStrokeDiff.DecimalPlaces = CType(0, Short)
        Me.DspLRRealStrokeDiff.FieldName = "左右ｽﾄﾛｰｸ差"
        Me.DspLRRealStrokeDiff.Location = New System.Drawing.Point(917, 511)
        Me.DspLRRealStrokeDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.DspLRRealStrokeDiff.Name = "DspLRRealStrokeDiff"
        Me.DspLRRealStrokeDiff.Size = New System.Drawing.Size(138, 51)
        Me.DspLRRealStrokeDiff.TabIndex = 177
        Me.DspLRRealStrokeDiff.Unit = "mm"
        Me.DspLRRealStrokeDiff.Value = 1234.0R
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1914, 1053)
        Me.Controls.Add(Me.DspLRStrokeDiff)
        Me.Controls.Add(Me.DspLRRealStrokeDiff)
        Me.Controls.Add(Me.pnlStrokeDiffContorol)
        Me.Controls.Add(Me.btnNoOpJk)
        Me.Controls.Add(Me.DspCopyStroke2)
        Me.Controls.Add(Me.DspBoltPitch)
        Me.Controls.Add(Me.lblMRRolling)
        Me.Controls.Add(Me.DspChangeMRRolling)
        Me.Controls.Add(Me.DspAntiClockwiseMargin)
        Me.Controls.Add(Me.DspClockwiseMargin)
        Me.Controls.Add(Me.DspGyiroError)
        Me.Controls.Add(Me.btnLoszeroContinu)
        Me.Controls.Add(Me.DspRingTargetDir)
        Me.Controls.Add(Me.DspSegmentRolling)
        Me.Controls.Add(Me.DspClosetJack)
        Me.Controls.Add(Me.DspAveStartStroke)
        Me.Controls.Add(Me.DspExcvSpeed)
        Me.Controls.Add(Me.DspAveStroke)
        Me.Controls.Add(Me.lblMachineMode)
        Me.Controls.Add(Me.cmbWideSelct)
        Me.Controls.Add(Me.UcnGpPvBarGraph)
        Me.Controls.Add(Me.DspCopyStroke1)
        Me.Controls.Add(Me.DspTransMRRolling)
        Me.Controls.Add(Me.DspRealMRRolling)
        Me.Controls.Add(Me.DspUpRealStroke)
        Me.Controls.Add(Me.DspRightClearance)
        Me.Controls.Add(Me.DspLeftClearance)
        Me.Controls.Add(Me.DspBottomSpeed)
        Me.Controls.Add(Me.DspBottomClearance)
        Me.Controls.Add(Me.DspTopClearance)
        Me.Controls.Add(Me.DspRightRawStroke)
        Me.Controls.Add(Me.DspBottomRawStroke)
        Me.Controls.Add(Me.DspLeftRawStroke)
        Me.Controls.Add(Me.DspUpRawStroke)
        Me.Controls.Add(Me.lblNowDate)
        Me.Controls.Add(Me.ucnVerLineChart)
        Me.Controls.Add(Me.ucnHorLineChart)
        Me.Controls.Add(Me.ucnVerDevChart)
        Me.Controls.Add(Me.ucnVerMomentChart)
        Me.Controls.Add(Me.ucnHorDevChart)
        Me.Controls.Add(Me.ucnHorMomentChart)
        Me.Controls.Add(Me.btnPieceConfirm)
        Me.Controls.Add(Me.DspMachinComErr)
        Me.Controls.Add(Me.btnLossZerooCancel)
        Me.Controls.Add(Me.pnlLosZero)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DspAssemblyPattern)
        Me.Controls.Add(Me.DspNextPieceName)
        Me.Controls.Add(Me.DspAddClosetThrustJack)
        Me.Controls.Add(Me.DspClosetThrustJack)
        Me.Controls.Add(Me.DspPullBackJack)
        Me.Controls.Add(Me.DspAssemblyPieace)
        Me.Controls.Add(Me.DspTypeName)
        Me.Controls.Add(Me.UcnDspDevImg)
        Me.Controls.Add(Me.DspRightSpeed)
        Me.Controls.Add(Me.DspRightRealStroke)
        Me.Controls.Add(Me.DspLeftSpeed)
        Me.Controls.Add(Me.DspLeftRealStroke)
        Me.Controls.Add(Me.DspUpSpeed)
        Me.Controls.Add(Me.DspBottomRealStroke)
        Me.Controls.Add(Me.DspWideUse11)
        Me.Controls.Add(Me.DspWideUse10)
        Me.Controls.Add(Me.DspWideUse9)
        Me.Controls.Add(Me.DspWideUse8)
        Me.Controls.Add(Me.DspWideUse7)
        Me.Controls.Add(Me.DspWideUse6)
        Me.Controls.Add(Me.DspWideUse5)
        Me.Controls.Add(Me.DspWideUse4)
        Me.Controls.Add(Me.DspWideUse3)
        Me.Controls.Add(Me.DspWideUse2)
        Me.Controls.Add(Me.DspWideUse1)
        Me.Controls.Add(Me.DspWideUse0)
        Me.Controls.Add(Me.UcnJackDsp)
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
        Me.Controls.Add(Me.DspWideUse12)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuSystem
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "FLEX.NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuSystem.ResumeLayout(False)
        Me.MenuSystem.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlLosZero.ResumeLayout(False)
        Me.pnlStrokeDiffContorol.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub ReportOut_DisplayStyleChanged(sender As Object, e As EventArgs) Handles ReportOut.DisplayStyleChanged

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
    Friend WithEvents DspBottomSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspBottomRealStroke As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspRightSpeed As FLEX.NET.ucnDspDataMin
    Friend WithEvents DspRightRealStroke As FLEX.NET.ucnDspDataMin
    Public WithEvents tmrDataDsp As System.Windows.Forms.Timer
    Friend WithEvents RingNoUpdateSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcavEnforceStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcavEnforceStop As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents PlanDataView As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents DspWideUse0 As ucnDspData
    Friend WithEvents DspWideUse1 As ucnDspData
    Friend WithEvents DspWideUse3 As ucnDspData
    Friend WithEvents DspWideUse2 As ucnDspData
    Friend WithEvents DspWideUse5 As ucnDspData
    Friend WithEvents DspWideUse4 As ucnDspData
    Friend WithEvents DspWideUse11 As ucnDspData
    Friend WithEvents DspWideUse10 As ucnDspData
    Friend WithEvents DspWideUse9 As ucnDspData
    Friend WithEvents DspWideUse8 As ucnDspData
    Friend WithEvents DspWideUse7 As ucnDspData
    Friend WithEvents DspWideUse6 As ucnDspData
    Friend WithEvents TuningMonitorClicｋ As ToolStripMenuItem
    Friend WithEvents UcnDspDevImg As ucnDspDevImg
    Friend WithEvents UcnGpPvBarGraph As ucnGpPvBarGraph
    Friend WithEvents ucnHorMomentChart As ucnChart
    Friend WithEvents ucnVerMomentChart As ucnChart
    Friend WithEvents ucnHorDevChart As ucnChart
    Friend WithEvents ucnVerDevChart As ucnChart
    Friend WithEvents DspTypeName As ucnDspData
    Friend WithEvents DspBoltPitch As ucnDspData
    Friend WithEvents DspAssemblyPieace As ucnDspData
    Friend WithEvents DspClosetJack As ucnDspData
    Friend WithEvents DspPullBackJack As ucnDspData
    Friend WithEvents DspAddClosetThrustJack As ucnDspData
    Friend WithEvents DspClosetThrustJack As ucnDspData
    Friend WithEvents DspNextPieceName As ucnDspData
    Friend WithEvents DspSegmentRolling As ucnDspData
    Friend WithEvents DspAssemblyPattern As ucnDspData
    Friend WithEvents Panel1 As Panel
    Friend WithEvents InterruptTime As ucnDspData
    Friend WithEvents DspWatingElapsedTime As ucnDspData
    Friend WithEvents DspLosZeroElapsedTime As ucnDspData
    Friend WithEvents DspExcationElapsedTime As ucnDspData
    Friend WithEvents lblUnit As Label
    Friend WithEvents DspRingNo As Label
    Friend WithEvents DspSumLoszeroTime As ucnDspData
    Friend WithEvents DspAveLoszeroTime As ucnDspData
    Friend WithEvents DspSumAsmPiece As ucnDspData
    Friend WithEvents DspAveAsmPiece As ucnDspData
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DspFlexHorControl As ucnDspBit
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
    Friend WithEvents UcnOpposeJackControl As ucnDspBit
    Friend WithEvents UcnOpposeJackSelect As ucnDspBit
    Friend WithEvents ucnLosZeroMode As ucnDspBit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLossZerooCancel As Button
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
    Friend WithEvents btnPieceConfirm As Button
    Public WithEvents DspLeftRealStroke As ucnDspDataMin
    Public WithEvents rtbEventLog As RichTextBox
    Friend WithEvents lblNowDate As Label
    Friend WithEvents StrokeMonitor As ToolStripMenuItem
    Friend WithEvents DspUpRawStroke As ucnDspDataMin
    Public WithEvents DspLeftRawStroke As ucnDspDataMin
    Friend WithEvents DspBottomRawStroke As ucnDspDataMin
    Friend WithEvents DspRightRawStroke As ucnDspDataMin
    Friend WithEvents DspTopClearance As ucnDspDataMin
    Friend WithEvents DspBottomClearance As ucnDspDataMin
    Friend WithEvents DspLeftClearance As ucnDspDataMin
    Friend WithEvents DspRightClearance As ucnDspDataMin
    Friend WithEvents DspRealMRRolling As ucnDspDataMin2
    Friend WithEvents DspTransMRRolling As ucnDspDataMin2
    Friend WithEvents DspCopyStroke1 As ucnDspDataMin2
    Friend WithEvents cmbWideSelct As ComboBox
    Friend WithEvents 平面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 縦断ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents lblMachineMode As Label
    Friend WithEvents DspAveStartStroke As ucnDspData
    Friend WithEvents RingDataViewer As ToolStripMenuItem
    Friend WithEvents DspRingTargetDir As ucnDspData
    Friend WithEvents DspLRStrokeDiff As ucnDspDataMin
    Friend WithEvents btnLoszeroContinu As Button
    Friend WithEvents DspWideUse12 As ucnDspData
    Friend WithEvents DspGyiroError As ucnDspBit
    Friend WithEvents DspInterruptTime As ucnDspData
    Friend WithEvents NetStrokeChange As ToolStripMenuItem
    Friend WithEvents DspTargetNetStroke As ucnDspData
    Friend WithEvents DspSegmentW As ucnDspData
    Friend WithEvents DspAntiClockwiseMargin As ucnDspData
    Friend WithEvents DspClockwiseMargin As ucnDspData
    Friend WithEvents DspChangeMRRolling As ucnDspDataMin2
    Friend WithEvents lblMRRolling As Label
    Friend WithEvents MeasuerJPullNum As ucnDspData
    Friend WithEvents DspCopyStroke2 As ucnDspDataMin2
    Friend WithEvents btnNoOpJk As Button
    Friend WithEvents pnlStrokeDiffContorol As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblConvertBtmStrokeDiff As Label
    Friend WithEvents lblConvertBtmStartStrokeDiff As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblConvertHorStrokeDiff As Label
    Friend WithEvents lblConvertHorStartStrokeDiff As Label
    Friend WithEvents label4 As Label
    Friend WithEvents lblConvertTopStrokeDiff As Label
    Friend WithEvents lblConvertTopStartStrokeDiff As Label
    Friend WithEvents lblBtmRingTargetSt As Label
    Friend WithEvents lblBtmLeftStNo As Label
    Friend WithEvents lblBtmRightStNo As Label
    Friend WithEvents lblBtmStItem As Label
    Friend WithEvents lblBtmNetSt As Label
    Friend WithEvents lblBtmLeftRealSt As Label
    Friend WithEvents lblBtmRightRealSt As Label
    Friend WithEvents lblBtmLeftStartSt As Label
    Friend WithEvents lblBtmRightStartSt As Label
    Friend WithEvents lblHorRingTargetSt As Label
    Friend WithEvents lblHorLefttStNo As Label
    Friend WithEvents lblHorRightStNo As Label
    Friend WithEvents lblHorStItem As Label
    Friend WithEvents lblHorNetSt As Label
    Friend WithEvents lblHorLeftRealSt As Label
    Friend WithEvents lblHorRightRealSt As Label
    Friend WithEvents lblHorLeftStartSt As Label
    Friend WithEvents lblHorRightStartSt As Label
    Friend WithEvents lblTopRingTargetSt As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTopLefttStNo As Label
    Friend WithEvents lblTopRightStNo As Label
    Friend WithEvents lblTopStItem As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFieldName As Label
    Friend WithEvents lblTopNetSt As Label
    Friend WithEvents lblTopLeftRealSt As Label
    Friend WithEvents lblTopRightRealSt As Label
    Friend WithEvents lblTopLeftStartSt As Label
    Friend WithEvents lblTopRightStartSt As Label
    Friend WithEvents DspLRRealStrokeDiff As ucnDspDataMin
    'Friend WithEvents UcDspAnalog2 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog1 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog3 As FLEX.NET.DspAnalog
End Class
