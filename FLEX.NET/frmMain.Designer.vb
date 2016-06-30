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
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.DspRingNo = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcnDspData15 = New FLEX.NET.ucnDspData()
        Me.UcnDspData16 = New FLEX.NET.ucnDspData()
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
        Me.DspFlexGyiroControl = New FLEX.NET.ucnDspBit()
        Me.DspFlexAutoAzurControl = New FLEX.NET.ucnDspBit()
        Me.DspExcavingStop = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit2 = New FLEX.NET.ucnDspBit()
        Me.UcnDspBit3 = New FLEX.NET.ucnDspBit()
        Me.DspExcavingOn = New FLEX.NET.ucnDspBit()
        Me.DspFlexAuto = New FLEX.NET.ucnDspBit()
        Me.DspFlexControlOn = New FLEX.NET.ucnDspBit()
        Me.DspExcaWaiting = New FLEX.NET.ucnDspBit()
        Me.DspRightSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspRightRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspBottomSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspRealBottomStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspLeftRealStroke = New FLEX.NET.ucnDspDataMin()
        Me.DspUpSpeed = New FLEX.NET.ucnDspDataMin()
        Me.DspUpRealStroke = New FLEX.NET.ucnDspDataMin()
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
        Me.UcnDspData2 = New FLEX.NET.ucnDspData()
        Me.UcnDspData1 = New FLEX.NET.ucnDspData()
        Me.MenuSystem.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuSystem.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
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
        Me.ウインドウToolStripMenuItem.Name = "ウインドウToolStripMenuItem"
        Me.ウインドウToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ウインドウToolStripMenuItem.Text = "ウインドウ(&W)"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.Silver
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(334, 30)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(628, 72)
        Me.lblFieldName.TabIndex = 53
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspRingNo
        '
        Me.DspRingNo.BackColor = System.Drawing.Color.Black
        Me.DspRingNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DspRingNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspRingNo.ForeColor = System.Drawing.Color.Yellow
        Me.DspRingNo.Location = New System.Drawing.Point(1477, 822)
        Me.DspRingNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DspRingNo.Name = "DspRingNo"
        Me.DspRingNo.Size = New System.Drawing.Size(107, 38)
        Me.DspRingNo.TabIndex = 66
        Me.DspRingNo.Text = "1234"
        Me.DspRingNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(1587, 828)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(93, 32)
        Me.lblUnit.TabIndex = 67
        Me.lblUnit.Text = "リング"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Location = New System.Drawing.Point(966, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 220)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'UcnDspData15
        '
        Me.UcnDspData15.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData15.DecimalPlaces = CType(2, Short)
        Me.UcnDspData15.FieldName = ""
        Me.UcnDspData15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData15.Location = New System.Drawing.Point(1564, 462)
        Me.UcnDspData15.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData15.Name = "UcnDspData15"
        Me.UcnDspData15.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData15.TabIndex = 82
        Me.UcnDspData15.Unit = ""
        Me.UcnDspData15.Value = 123.45R
        '
        'UcnDspData16
        '
        Me.UcnDspData16.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData16.DecimalPlaces = CType(2, Short)
        Me.UcnDspData16.FieldName = ""
        Me.UcnDspData16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData16.Location = New System.Drawing.Point(1564, 428)
        Me.UcnDspData16.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData16.Name = "UcnDspData16"
        Me.UcnDspData16.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData16.TabIndex = 81
        Me.UcnDspData16.Unit = ""
        Me.UcnDspData16.Value = 123.45R
        '
        'UcnDspData9
        '
        Me.UcnDspData9.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData9.DecimalPlaces = CType(2, Short)
        Me.UcnDspData9.FieldName = ""
        Me.UcnDspData9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData9.Location = New System.Drawing.Point(1564, 394)
        Me.UcnDspData9.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData9.Name = "UcnDspData9"
        Me.UcnDspData9.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData9.TabIndex = 80
        Me.UcnDspData9.Unit = ""
        Me.UcnDspData9.Value = 123.45R
        '
        'UcnDspData10
        '
        Me.UcnDspData10.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData10.DecimalPlaces = CType(2, Short)
        Me.UcnDspData10.FieldName = ""
        Me.UcnDspData10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData10.Location = New System.Drawing.Point(1564, 360)
        Me.UcnDspData10.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData10.Name = "UcnDspData10"
        Me.UcnDspData10.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData10.TabIndex = 79
        Me.UcnDspData10.Unit = ""
        Me.UcnDspData10.Value = 123.45R
        '
        'UcnDspData11
        '
        Me.UcnDspData11.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData11.DecimalPlaces = CType(2, Short)
        Me.UcnDspData11.FieldName = ""
        Me.UcnDspData11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData11.Location = New System.Drawing.Point(1564, 330)
        Me.UcnDspData11.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData11.Name = "UcnDspData11"
        Me.UcnDspData11.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData11.TabIndex = 78
        Me.UcnDspData11.Unit = ""
        Me.UcnDspData11.Value = 123.45R
        '
        'UcnDspData12
        '
        Me.UcnDspData12.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData12.DecimalPlaces = CType(2, Short)
        Me.UcnDspData12.FieldName = ""
        Me.UcnDspData12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData12.Location = New System.Drawing.Point(1564, 296)
        Me.UcnDspData12.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData12.Name = "UcnDspData12"
        Me.UcnDspData12.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData12.TabIndex = 77
        Me.UcnDspData12.Unit = ""
        Me.UcnDspData12.Value = 123.45R
        '
        'UcnDspData13
        '
        Me.UcnDspData13.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData13.DecimalPlaces = CType(2, Short)
        Me.UcnDspData13.FieldName = ""
        Me.UcnDspData13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData13.Location = New System.Drawing.Point(1564, 262)
        Me.UcnDspData13.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData13.Name = "UcnDspData13"
        Me.UcnDspData13.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData13.TabIndex = 76
        Me.UcnDspData13.Unit = ""
        Me.UcnDspData13.Value = 123.45R
        '
        'UcnDspData14
        '
        Me.UcnDspData14.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData14.DecimalPlaces = CType(2, Short)
        Me.UcnDspData14.FieldName = ""
        Me.UcnDspData14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData14.Location = New System.Drawing.Point(1564, 228)
        Me.UcnDspData14.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData14.Name = "UcnDspData14"
        Me.UcnDspData14.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData14.TabIndex = 75
        Me.UcnDspData14.Unit = ""
        Me.UcnDspData14.Value = 123.45R
        '
        'UcnDspData7
        '
        Me.UcnDspData7.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData7.DecimalPlaces = CType(2, Short)
        Me.UcnDspData7.FieldName = ""
        Me.UcnDspData7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData7.Location = New System.Drawing.Point(1564, 196)
        Me.UcnDspData7.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData7.Name = "UcnDspData7"
        Me.UcnDspData7.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData7.TabIndex = 74
        Me.UcnDspData7.Unit = ""
        Me.UcnDspData7.Value = 123.45R
        '
        'UcnDspData8
        '
        Me.UcnDspData8.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData8.DecimalPlaces = CType(2, Short)
        Me.UcnDspData8.FieldName = ""
        Me.UcnDspData8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData8.Location = New System.Drawing.Point(1564, 162)
        Me.UcnDspData8.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData8.Name = "UcnDspData8"
        Me.UcnDspData8.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData8.TabIndex = 73
        Me.UcnDspData8.Unit = ""
        Me.UcnDspData8.Value = 123.45R
        '
        'UcnDspData5
        '
        Me.UcnDspData5.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData5.DecimalPlaces = CType(2, Short)
        Me.UcnDspData5.FieldName = ""
        Me.UcnDspData5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData5.Location = New System.Drawing.Point(1564, 132)
        Me.UcnDspData5.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData5.Name = "UcnDspData5"
        Me.UcnDspData5.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData5.TabIndex = 72
        Me.UcnDspData5.Unit = ""
        Me.UcnDspData5.Value = 123.45R
        '
        'UcnDspData6
        '
        Me.UcnDspData6.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData6.DecimalPlaces = CType(2, Short)
        Me.UcnDspData6.FieldName = ""
        Me.UcnDspData6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData6.Location = New System.Drawing.Point(1564, 98)
        Me.UcnDspData6.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData6.Name = "UcnDspData6"
        Me.UcnDspData6.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData6.TabIndex = 71
        Me.UcnDspData6.Unit = ""
        Me.UcnDspData6.Value = 123.45R
        '
        'UcnDspData4
        '
        Me.UcnDspData4.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData4.DecimalPlaces = CType(2, Short)
        Me.UcnDspData4.FieldName = ""
        Me.UcnDspData4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData4.Location = New System.Drawing.Point(1564, 64)
        Me.UcnDspData4.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData4.Name = "UcnDspData4"
        Me.UcnDspData4.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData4.TabIndex = 70
        Me.UcnDspData4.Unit = ""
        Me.UcnDspData4.Value = 123.45R
        '
        'UcnDspData3
        '
        Me.UcnDspData3.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData3.DecimalPlaces = CType(2, Short)
        Me.UcnDspData3.FieldName = ""
        Me.UcnDspData3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData3.Location = New System.Drawing.Point(1564, 30)
        Me.UcnDspData3.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData3.Name = "UcnDspData3"
        Me.UcnDspData3.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData3.TabIndex = 69
        Me.UcnDspData3.Unit = ""
        Me.UcnDspData3.Value = 123.45R
        '
        'UcnJackDsp
        '
        Me.UcnJackDsp.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp.FaiJack = Nothing
        Me.UcnJackDsp.GroupPV = New Single() {0!}
        Me.UcnJackDsp.JackGroupPos = Nothing
        Me.UcnJackDsp.JackStatus = New Short() {CType(0, Short)}
        Me.UcnJackDsp.Location = New System.Drawing.Point(258, 116)
        Me.UcnJackDsp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcnJackDsp.Name = "UcnJackDsp"
        Me.UcnJackDsp.NumberGroup = CType(0, Short)
        Me.UcnJackDsp.NumberJack = CType(0, Short)
        Me.UcnJackDsp.Size = New System.Drawing.Size(779, 698)
        Me.UcnJackDsp.TabIndex = 68
        '
        'DspFlexGyiroControl
        '
        Me.DspFlexGyiroControl.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexGyiroControl.BitStatus = True
        Me.DspFlexGyiroControl.FieldName = "ジャイロ"
        Me.DspFlexGyiroControl.Location = New System.Drawing.Point(854, 69)
        Me.DspFlexGyiroControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspFlexGyiroControl.Name = "DspFlexGyiroControl"
        Me.DspFlexGyiroControl.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexGyiroControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexGyiroControl.Size = New System.Drawing.Size(96, 30)
        Me.DspFlexGyiroControl.TabIndex = 64
        '
        'DspFlexAutoAzurControl
        '
        Me.DspFlexAutoAzurControl.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexAutoAzurControl.BitStatus = False
        Me.DspFlexAutoAzurControl.FieldName = "自動測量"
        Me.DspFlexAutoAzurControl.Location = New System.Drawing.Point(753, 69)
        Me.DspFlexAutoAzurControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspFlexAutoAzurControl.Name = "DspFlexAutoAzurControl"
        Me.DspFlexAutoAzurControl.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexAutoAzurControl.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexAutoAzurControl.Size = New System.Drawing.Size(96, 30)
        Me.DspFlexAutoAzurControl.TabIndex = 63
        '
        'DspExcavingStop
        '
        Me.DspExcavingStop.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingStop.BitStatus = False
        Me.DspExcavingStop.FieldName = "中　断"
        Me.DspExcavingStop.Location = New System.Drawing.Point(752, 36)
        Me.DspExcavingStop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspExcavingStop.Name = "DspExcavingStop"
        Me.DspExcavingStop.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingStop.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingStop.Size = New System.Drawing.Size(200, 30)
        Me.DspExcavingStop.TabIndex = 62
        '
        'UcnDspBit2
        '
        Me.UcnDspBit2.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit2.BitStatus = False
        Me.UcnDspBit2.FieldName = "自動更新"
        Me.UcnDspBit2.Location = New System.Drawing.Point(649, 69)
        Me.UcnDspBit2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcnDspBit2.Name = "UcnDspBit2"
        Me.UcnDspBit2.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit2.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit2.Size = New System.Drawing.Size(96, 30)
        Me.UcnDspBit2.TabIndex = 61
        '
        'UcnDspBit3
        '
        Me.UcnDspBit3.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspBit3.BitStatus = True
        Me.UcnDspBit3.FieldName = "補正値管"
        Me.UcnDspBit3.Location = New System.Drawing.Point(546, 69)
        Me.UcnDspBit3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcnDspBit3.Name = "UcnDspBit3"
        Me.UcnDspBit3.OffBackColor = System.Drawing.Color.LightGray
        Me.UcnDspBit3.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnDspBit3.Size = New System.Drawing.Size(96, 30)
        Me.UcnDspBit3.TabIndex = 60
        '
        'DspExcavingOn
        '
        Me.DspExcavingOn.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingOn.BitStatus = True
        Me.DspExcavingOn.FieldName = "掘　進"
        Me.DspExcavingOn.Location = New System.Drawing.Point(545, 36)
        Me.DspExcavingOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspExcavingOn.Name = "DspExcavingOn"
        Me.DspExcavingOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingOn.Size = New System.Drawing.Size(200, 30)
        Me.DspExcavingOn.TabIndex = 59
        '
        'DspFlexAuto
        '
        Me.DspFlexAuto.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexAuto.BitStatus = False
        Me.DspFlexAuto.FieldName = "自動運転"
        Me.DspFlexAuto.Location = New System.Drawing.Point(444, 69)
        Me.DspFlexAuto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspFlexAuto.Name = "DspFlexAuto"
        Me.DspFlexAuto.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexAuto.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexAuto.Size = New System.Drawing.Size(96, 30)
        Me.DspFlexAuto.TabIndex = 58
        '
        'DspFlexControlOn
        '
        Me.DspFlexControlOn.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexControlOn.BitStatus = True
        Me.DspFlexControlOn.FieldName = "FLEX制御"
        Me.DspFlexControlOn.Location = New System.Drawing.Point(341, 69)
        Me.DspFlexControlOn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspFlexControlOn.Name = "DspFlexControlOn"
        Me.DspFlexControlOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexControlOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexControlOn.Size = New System.Drawing.Size(96, 30)
        Me.DspFlexControlOn.TabIndex = 57
        '
        'DspExcaWaiting
        '
        Me.DspExcaWaiting.BackColor = System.Drawing.Color.Transparent
        Me.DspExcaWaiting.BitStatus = False
        Me.DspExcaWaiting.FieldName = "待　機"
        Me.DspExcaWaiting.Location = New System.Drawing.Point(340, 36)
        Me.DspExcaWaiting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspExcaWaiting.Name = "DspExcaWaiting"
        Me.DspExcaWaiting.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcaWaiting.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcaWaiting.Size = New System.Drawing.Size(200, 30)
        Me.DspExcaWaiting.TabIndex = 54
        '
        'DspRightSpeed
        '
        Me.DspRightSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspRightSpeed.DecimalPlaces = CType(0, Short)
        Me.DspRightSpeed.FieldName = "右速度"
        Me.DspRightSpeed.Location = New System.Drawing.Point(1017, 353)
        Me.DspRightSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspRightSpeed.Name = "DspRightSpeed"
        Me.DspRightSpeed.Size = New System.Drawing.Size(159, 46)
        Me.DspRightSpeed.TabIndex = 49
        Me.DspRightSpeed.Unit = "mm/min"
        Me.DspRightSpeed.Value = 1234.0R
        '
        'DspRightRealStroke
        '
        Me.DspRightRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRightRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspRightRealStroke.FieldName = "右ST実"
        Me.DspRightRealStroke.Location = New System.Drawing.Point(1017, 301)
        Me.DspRightRealStroke.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspRightRealStroke.Name = "DspRightRealStroke"
        Me.DspRightRealStroke.Size = New System.Drawing.Size(159, 46)
        Me.DspRightRealStroke.TabIndex = 48
        Me.DspRightRealStroke.Unit = "mm"
        Me.DspRightRealStroke.Value = 1234.0R
        '
        'DspBottomSpeed
        '
        Me.DspBottomSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspBottomSpeed.DecimalPlaces = CType(0, Short)
        Me.DspBottomSpeed.FieldName = "下速度"
        Me.DspBottomSpeed.Location = New System.Drawing.Point(109, 584)
        Me.DspBottomSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspBottomSpeed.Name = "DspBottomSpeed"
        Me.DspBottomSpeed.Size = New System.Drawing.Size(159, 46)
        Me.DspBottomSpeed.TabIndex = 47
        Me.DspBottomSpeed.Unit = "mm/min"
        Me.DspBottomSpeed.Value = 1234.0R
        '
        'DspRealBottomStroke
        '
        Me.DspRealBottomStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRealBottomStroke.DecimalPlaces = CType(0, Short)
        Me.DspRealBottomStroke.FieldName = "下ST実"
        Me.DspRealBottomStroke.Location = New System.Drawing.Point(109, 532)
        Me.DspRealBottomStroke.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspRealBottomStroke.Name = "DspRealBottomStroke"
        Me.DspRealBottomStroke.Size = New System.Drawing.Size(159, 46)
        Me.DspRealBottomStroke.TabIndex = 46
        Me.DspRealBottomStroke.Unit = "mm"
        Me.DspRealBottomStroke.Value = 1234.0R
        '
        'DspLeftSpeed
        '
        Me.DspLeftSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftSpeed.DecimalPlaces = CType(0, Short)
        Me.DspLeftSpeed.FieldName = "左速度"
        Me.DspLeftSpeed.Location = New System.Drawing.Point(93, 362)
        Me.DspLeftSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspLeftSpeed.Name = "DspLeftSpeed"
        Me.DspLeftSpeed.Size = New System.Drawing.Size(159, 46)
        Me.DspLeftSpeed.TabIndex = 45
        Me.DspLeftSpeed.Unit = "mm/min"
        Me.DspLeftSpeed.Value = 1234.0R
        '
        'DspLeftRealStroke
        '
        Me.DspLeftRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspLeftRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspLeftRealStroke.FieldName = "左ST実"
        Me.DspLeftRealStroke.Location = New System.Drawing.Point(93, 311)
        Me.DspLeftRealStroke.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspLeftRealStroke.Name = "DspLeftRealStroke"
        Me.DspLeftRealStroke.Size = New System.Drawing.Size(159, 46)
        Me.DspLeftRealStroke.TabIndex = 44
        Me.DspLeftRealStroke.Unit = "mm"
        Me.DspLeftRealStroke.Value = 1234.0R
        '
        'DspUpSpeed
        '
        Me.DspUpSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspUpSpeed.DecimalPlaces = CType(0, Short)
        Me.DspUpSpeed.FieldName = "上速度"
        Me.DspUpSpeed.Location = New System.Drawing.Point(93, 214)
        Me.DspUpSpeed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspUpSpeed.Name = "DspUpSpeed"
        Me.DspUpSpeed.Size = New System.Drawing.Size(159, 46)
        Me.DspUpSpeed.TabIndex = 43
        Me.DspUpSpeed.Unit = "mm/min"
        Me.DspUpSpeed.Value = 1234.0R
        '
        'DspUpRealStroke
        '
        Me.DspUpRealStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspUpRealStroke.DecimalPlaces = CType(0, Short)
        Me.DspUpRealStroke.FieldName = "上ST実"
        Me.DspUpRealStroke.Location = New System.Drawing.Point(93, 162)
        Me.DspUpRealStroke.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DspUpRealStroke.Name = "DspUpRealStroke"
        Me.DspUpRealStroke.Size = New System.Drawing.Size(159, 46)
        Me.DspUpRealStroke.TabIndex = 42
        Me.DspUpRealStroke.Unit = "mm"
        Me.DspUpRealStroke.Value = 1234.0R
        '
        'DspExcvSpeed
        '
        Me.DspExcvSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspExcvSpeed.DecimalPlaces = CType(0, Short)
        Me.DspExcvSpeed.FieldName = "掘進速度"
        Me.DspExcvSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcvSpeed.Location = New System.Drawing.Point(4, 68)
        Me.DspExcvSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcvSpeed.Name = "DspExcvSpeed"
        Me.DspExcvSpeed.Size = New System.Drawing.Size(328, 35)
        Me.DspExcvSpeed.TabIndex = 41
        Me.DspExcvSpeed.Unit = "mm/min"
        Me.DspExcvSpeed.Value = 123.0R
        '
        'DspAveStroke
        '
        Me.DspAveStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStroke.FieldName = "平均ｽﾄﾛｰｸ"
        Me.DspAveStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStroke.Location = New System.Drawing.Point(4, 34)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(328, 32)
        Me.DspAveStroke.TabIndex = 40
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.Value = 123.0R
        '
        'DspTargetPitching
        '
        Me.DspTargetPitching.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetPitching.DecimalPlaces = CType(2, Short)
        Me.DspTargetPitching.FieldName = "目標ピッチ角"
        Me.DspTargetPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetPitching.Location = New System.Drawing.Point(1219, 678)
        Me.DspTargetPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetPitching.Name = "DspTargetPitching"
        Me.DspTargetPitching.Size = New System.Drawing.Size(365, 36)
        Me.DspTargetPitching.TabIndex = 39
        Me.DspTargetPitching.Unit = "deg"
        Me.DspTargetPitching.Value = 123.45R
        '
        'DspTargetDirection
        '
        Me.DspTargetDirection.BackColor = System.Drawing.Color.Transparent
        Me.DspTargetDirection.DecimalPlaces = CType(2, Short)
        Me.DspTargetDirection.FieldName = "目標方位角"
        Me.DspTargetDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTargetDirection.Location = New System.Drawing.Point(1219, 644)
        Me.DspTargetDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTargetDirection.Name = "DspTargetDirection"
        Me.DspTargetDirection.Size = New System.Drawing.Size(365, 33)
        Me.DspTargetDirection.TabIndex = 38
        Me.DspTargetDirection.Unit = "deg"
        Me.DspTargetDirection.Value = 123.45R
        '
        'DspVerRChangePoint
        '
        Me.DspVerRChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspVerRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerRChangePoint.FieldName = "後方変化点"
        Me.DspVerRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerRChangePoint.Location = New System.Drawing.Point(1219, 597)
        Me.DspVerRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerRChangePoint.Name = "DspVerRChangePoint"
        Me.DspVerRChangePoint.Size = New System.Drawing.Size(365, 36)
        Me.DspVerRChangePoint.TabIndex = 37
        Me.DspVerRChangePoint.Unit = "m"
        Me.DspVerRChangePoint.Value = 1234.567R
        '
        'DspVerFChangePoint
        '
        Me.DspVerFChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspVerFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspVerFChangePoint.FieldName = "前方変化点"
        Me.DspVerFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerFChangePoint.Location = New System.Drawing.Point(1219, 564)
        Me.DspVerFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerFChangePoint.Name = "DspVerFChangePoint"
        Me.DspVerFChangePoint.Size = New System.Drawing.Size(365, 33)
        Me.DspVerFChangePoint.TabIndex = 36
        Me.DspVerFChangePoint.Unit = "m"
        Me.DspVerFChangePoint.Value = 1234.567R
        '
        'DspVerLine
        '
        Me.DspVerLine.BackColor = System.Drawing.Color.Transparent
        Me.DspVerLine.DecimalPlaces = CType(3, Short)
        Me.DspVerLine.FieldName = "縦断線形"
        Me.DspVerLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerLine.Location = New System.Drawing.Point(1219, 526)
        Me.DspVerLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerLine.Name = "DspVerLine"
        Me.DspVerLine.Size = New System.Drawing.Size(365, 36)
        Me.DspVerLine.TabIndex = 35
        Me.DspVerLine.Unit = "m"
        Me.DspVerLine.Value = 1234.567R
        '
        'DspHorRChangePoint
        '
        Me.DspHorRChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspHorRChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorRChangePoint.FieldName = "後方変化点"
        Me.DspHorRChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorRChangePoint.Location = New System.Drawing.Point(1219, 478)
        Me.DspHorRChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorRChangePoint.Name = "DspHorRChangePoint"
        Me.DspHorRChangePoint.Size = New System.Drawing.Size(365, 36)
        Me.DspHorRChangePoint.TabIndex = 34
        Me.DspHorRChangePoint.Unit = "m"
        Me.DspHorRChangePoint.Value = 1234.567R
        '
        'DspHorFChangePoint
        '
        Me.DspHorFChangePoint.BackColor = System.Drawing.Color.Transparent
        Me.DspHorFChangePoint.DecimalPlaces = CType(3, Short)
        Me.DspHorFChangePoint.FieldName = "前方変化点"
        Me.DspHorFChangePoint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorFChangePoint.Location = New System.Drawing.Point(1219, 445)
        Me.DspHorFChangePoint.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorFChangePoint.Name = "DspHorFChangePoint"
        Me.DspHorFChangePoint.Size = New System.Drawing.Size(365, 33)
        Me.DspHorFChangePoint.TabIndex = 33
        Me.DspHorFChangePoint.Unit = "m"
        Me.DspHorFChangePoint.Value = 1234.567R
        '
        'DspHorLine
        '
        Me.DspHorLine.BackColor = System.Drawing.Color.Transparent
        Me.DspHorLine.DecimalPlaces = CType(3, Short)
        Me.DspHorLine.FieldName = "平面線形"
        Me.DspHorLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorLine.Location = New System.Drawing.Point(1219, 408)
        Me.DspHorLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorLine.Name = "DspHorLine"
        Me.DspHorLine.Size = New System.Drawing.Size(365, 36)
        Me.DspHorLine.TabIndex = 32
        Me.DspHorLine.Unit = "m"
        Me.DspHorLine.Value = 1234.567R
        '
        'DspDistance
        '
        Me.DspDistance.BackColor = System.Drawing.Color.Transparent
        Me.DspDistance.DecimalPlaces = CType(3, Short)
        Me.DspDistance.FieldName = "中心の総距離"
        Me.DspDistance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDistance.Location = New System.Drawing.Point(1219, 365)
        Me.DspDistance.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDistance.Name = "DspDistance"
        Me.DspDistance.Size = New System.Drawing.Size(365, 36)
        Me.DspDistance.TabIndex = 31
        Me.DspDistance.Unit = "m"
        Me.DspDistance.Value = 1234.567R
        '
        'DspMoment
        '
        Me.DspMoment.BackColor = System.Drawing.Color.Transparent
        Me.DspMoment.DecimalPlaces = CType(0, Short)
        Me.DspMoment.FieldName = "ｼﾞｬｯｷﾓｰﾒﾝﾄ"
        Me.DspMoment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspMoment.Location = New System.Drawing.Point(1219, 328)
        Me.DspMoment.Margin = New System.Windows.Forms.Padding(1)
        Me.DspMoment.Name = "DspMoment"
        Me.DspMoment.Size = New System.Drawing.Size(365, 36)
        Me.DspMoment.TabIndex = 30
        Me.DspMoment.Unit = "kN･m"
        Me.DspMoment.Value = 123.0R
        '
        'DspThrust
        '
        Me.DspThrust.BackColor = System.Drawing.Color.Transparent
        Me.DspThrust.DecimalPlaces = CType(0, Short)
        Me.DspThrust.FieldName = "推力"
        Me.DspThrust.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspThrust.Location = New System.Drawing.Point(1219, 294)
        Me.DspThrust.Margin = New System.Windows.Forms.Padding(1)
        Me.DspThrust.Name = "DspThrust"
        Me.DspThrust.Size = New System.Drawing.Size(365, 33)
        Me.DspThrust.TabIndex = 29
        Me.DspThrust.Unit = "ｋN"
        Me.DspThrust.Value = 123.0R
        '
        'DspJackPress
        '
        Me.DspJackPress.BackColor = System.Drawing.Color.Transparent
        Me.DspJackPress.DecimalPlaces = CType(2, Short)
        Me.DspJackPress.FieldName = "シールド圧"
        Me.DspJackPress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspJackPress.Location = New System.Drawing.Point(1219, 257)
        Me.DspJackPress.Margin = New System.Windows.Forms.Padding(1)
        Me.DspJackPress.Name = "DspJackPress"
        Me.DspJackPress.Size = New System.Drawing.Size(365, 36)
        Me.DspJackPress.TabIndex = 28
        Me.DspJackPress.Unit = "Mpa"
        Me.DspJackPress.Value = 123.45R
        '
        'DspVerBroken
        '
        Me.DspVerBroken.BackColor = System.Drawing.Color.Transparent
        Me.DspVerBroken.DecimalPlaces = CType(2, Short)
        Me.DspVerBroken.FieldName = "鉛直中折角"
        Me.DspVerBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspVerBroken.Location = New System.Drawing.Point(1219, 216)
        Me.DspVerBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerBroken.Name = "DspVerBroken"
        Me.DspVerBroken.Size = New System.Drawing.Size(365, 36)
        Me.DspVerBroken.TabIndex = 27
        Me.DspVerBroken.Unit = "deg"
        Me.DspVerBroken.Value = 123.45R
        '
        'DspHorBroken
        '
        Me.DspHorBroken.BackColor = System.Drawing.Color.Transparent
        Me.DspHorBroken.DecimalPlaces = CType(2, Short)
        Me.DspHorBroken.FieldName = "水平中折角"
        Me.DspHorBroken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorBroken.Location = New System.Drawing.Point(1219, 182)
        Me.DspHorBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorBroken.Name = "DspHorBroken"
        Me.DspHorBroken.Size = New System.Drawing.Size(365, 33)
        Me.DspHorBroken.TabIndex = 26
        Me.DspHorBroken.Unit = "deg"
        Me.DspHorBroken.Value = 123.45R
        '
        'DspPitching
        '
        Me.DspPitching.BackColor = System.Drawing.Color.Transparent
        Me.DspPitching.DecimalPlaces = CType(2, Short)
        Me.DspPitching.FieldName = "ピッチング"
        Me.DspPitching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPitching.Location = New System.Drawing.Point(1219, 145)
        Me.DspPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPitching.Name = "DspPitching"
        Me.DspPitching.Size = New System.Drawing.Size(365, 36)
        Me.DspPitching.TabIndex = 25
        Me.DspPitching.Unit = "deg"
        Me.DspPitching.Value = 123.45R
        '
        'DspDirection
        '
        Me.DspDirection.BackColor = System.Drawing.Color.Transparent
        Me.DspDirection.DecimalPlaces = CType(2, Short)
        Me.DspDirection.FieldName = "方位角"
        Me.DspDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspDirection.Location = New System.Drawing.Point(1219, 111)
        Me.DspDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDirection.Name = "DspDirection"
        Me.DspDirection.Size = New System.Drawing.Size(365, 33)
        Me.DspDirection.TabIndex = 24
        Me.DspDirection.Unit = "deg"
        Me.DspDirection.Value = 123.45R
        '
        'UcnDspData2
        '
        Me.UcnDspData2.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData2.DecimalPlaces = CType(2, Short)
        Me.UcnDspData2.FieldName = "鉛直偏角"
        Me.UcnDspData2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData2.Location = New System.Drawing.Point(1219, 64)
        Me.UcnDspData2.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData2.Name = "UcnDspData2"
        Me.UcnDspData2.Size = New System.Drawing.Size(365, 36)
        Me.UcnDspData2.TabIndex = 23
        Me.UcnDspData2.Unit = "deg"
        Me.UcnDspData2.Value = 123.45R
        '
        'UcnDspData1
        '
        Me.UcnDspData1.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData1.DecimalPlaces = CType(2, Short)
        Me.UcnDspData1.FieldName = "水平偏角"
        Me.UcnDspData1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData1.Location = New System.Drawing.Point(1219, 30)
        Me.UcnDspData1.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData1.Name = "UcnDspData1"
        Me.UcnDspData1.Size = New System.Drawing.Size(365, 33)
        Me.UcnDspData1.TabIndex = 22
        Me.UcnDspData1.Unit = "deg"
        Me.UcnDspData1.Value = 123.45R
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1914, 1060)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UcnDspData15)
        Me.Controls.Add(Me.UcnDspData16)
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
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.DspRingNo)
        Me.Controls.Add(Me.DspFlexGyiroControl)
        Me.Controls.Add(Me.DspFlexAutoAzurControl)
        Me.Controls.Add(Me.DspExcavingStop)
        Me.Controls.Add(Me.UcnDspBit2)
        Me.Controls.Add(Me.UcnDspBit3)
        Me.Controls.Add(Me.DspExcavingOn)
        Me.Controls.Add(Me.DspFlexAuto)
        Me.Controls.Add(Me.DspFlexControlOn)
        Me.Controls.Add(Me.DspExcaWaiting)
        Me.Controls.Add(Me.DspRightSpeed)
        Me.Controls.Add(Me.DspRightRealStroke)
        Me.Controls.Add(Me.DspBottomSpeed)
        Me.Controls.Add(Me.DspRealBottomStroke)
        Me.Controls.Add(Me.DspLeftSpeed)
        Me.Controls.Add(Me.DspLeftRealStroke)
        Me.Controls.Add(Me.DspUpSpeed)
        Me.Controls.Add(Me.DspUpRealStroke)
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
        Me.Controls.Add(Me.UcnDspData2)
        Me.Controls.Add(Me.UcnDspData1)
        Me.Controls.Add(Me.MenuSystem)
        Me.Controls.Add(Me.lblFieldName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuSystem
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "FLEX.NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuSystem.ResumeLayout(False)
        Me.MenuSystem.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuSystem As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RingNoChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UcnDspData1 As FLEX.NET.ucnDspData
    Friend WithEvents UcnDspData2 As FLEX.NET.ucnDspData
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
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents DspExcaWaiting As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexControlOn As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexAuto As FLEX.NET.ucnDspBit
    Friend WithEvents UcnDspBit2 As FLEX.NET.ucnDspBit
    Friend WithEvents UcnDspBit3 As FLEX.NET.ucnDspBit
    Friend WithEvents DspExcavingOn As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexGyiroControl As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexAutoAzurControl As FLEX.NET.ucnDspBit
    Friend WithEvents DspExcavingStop As FLEX.NET.ucnDspBit
    Public WithEvents tmrDataDsp As System.Windows.Forms.Timer
    Friend WithEvents DspRingNo As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
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
    Friend WithEvents UcnDspData15 As ucnDspData
    Friend WithEvents UcnDspData16 As ucnDspData
    Friend WithEvents PictureBox1 As PictureBox
    'Friend WithEvents UcDspAnalog2 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog1 As FLEX.NET.DspAnalog
    'Friend WithEvents UcDspAnalog3 As FLEX.NET.DspAnalog
End Class
