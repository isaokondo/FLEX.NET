<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.UcnJackDsp = New FLEX.NET.ucnJackDsp()
        Me.tmrDataDsp = New System.Windows.Forms.Timer(Me.components)
        Me.lblNowDate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DspExcavingStop = New FLEX.NET.ucnDspBit()
        Me.DspExcavingOn = New FLEX.NET.ucnDspBit()
        Me.DspFlexAuto = New FLEX.NET.ucnDspBit()
        Me.DspFlexControlOn = New FLEX.NET.ucnDspBit()
        Me.DspExcaWaiting = New FLEX.NET.ucnDspBit()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.DspRingNo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.DspVerLine = New FLEX.NET.ucnDspData()
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
        Me.DspAveStartStroke = New FLEX.NET.ucnDspData()
        Me.DspExcvSpeed = New FLEX.NET.ucnDspData()
        Me.DspAveStroke = New FLEX.NET.ucnDspData()
        Me.UcnDspData24 = New FLEX.NET.ucnDspData()
        Me.DspClosetJack = New FLEX.NET.ucnDspData()
        Me.DspBoltPitch = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPattern = New FLEX.NET.ucnDspData()
        Me.DspNextPieceName = New FLEX.NET.ucnDspData()
        Me.DspAddClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspPullBackJack = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPieace = New FLEX.NET.ucnDspData()
        Me.DspTypeName = New FLEX.NET.ucnDspData()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.UcnJackDsp.Location = New System.Drawing.Point(441, 119)
        Me.UcnJackDsp.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnJackDsp.Name = "UcnJackDsp"
        Me.UcnJackDsp.NoOperation = False
        Me.UcnJackDsp.NumberGroup = CType(0, Short)
        Me.UcnJackDsp.NumberJack = CType(0, Short)
        Me.UcnJackDsp.PieceAngle = CType(resources.GetObject("UcnJackDsp.PieceAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceCenterAngle = CType(resources.GetObject("UcnJackDsp.PieceCenterAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceName = CType(resources.GetObject("UcnJackDsp.PieceName"), System.Collections.Generic.List(Of String))
        Me.UcnJackDsp.PointRLimitOver = False
        Me.UcnJackDsp.SegmentDspEnable = True
        Me.UcnJackDsp.Size = New System.Drawing.Size(795, 731)
        Me.UcnJackDsp.TabIndex = 69
        '
        'tmrDataDsp
        '
        Me.tmrDataDsp.Interval = 500
        '
        'lblNowDate
        '
        Me.lblNowDate.BackColor = System.Drawing.Color.Transparent
        Me.lblNowDate.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNowDate.Location = New System.Drawing.Point(1646, 9)
        Me.lblNowDate.Name = "lblNowDate"
        Me.lblNowDate.Size = New System.Drawing.Size(240, 19)
        Me.lblNowDate.TabIndex = 139
        Me.lblNowDate.Text = "9999／99／99　99：99：99"
        Me.lblNowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DspExcavingStop)
        Me.Panel2.Controls.Add(Me.DspExcavingOn)
        Me.Panel2.Controls.Add(Me.DspFlexAuto)
        Me.Panel2.Controls.Add(Me.DspFlexControlOn)
        Me.Panel2.Controls.Add(Me.DspExcaWaiting)
        Me.Panel2.Location = New System.Drawing.Point(11, 11)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 75)
        Me.Panel2.TabIndex = 155
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
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(854, 47)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(64, 26)
        Me.lblUnit.TabIndex = 157
        Me.lblUnit.Text = "リング"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspRingNo
        '
        Me.DspRingNo.BackColor = System.Drawing.Color.Black
        Me.DspRingNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DspRingNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspRingNo.ForeColor = System.Drawing.Color.LightGreen
        Me.DspRingNo.Location = New System.Drawing.Point(760, 41)
        Me.DspRingNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DspRingNo.Name = "DspRingNo"
        Me.DspRingNo.Size = New System.Drawing.Size(92, 41)
        Me.DspRingNo.TabIndex = 156
        Me.DspRingNo.Text = "1234"
        Me.DspRingNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel1.Location = New System.Drawing.Point(1326, 670)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 370)
        Me.Panel1.TabIndex = 158
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 72)
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
        Me.DspVerLine.Location = New System.Drawing.Point(11, 584)
        Me.DspVerLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerLine.Name = "DspVerLine"
        Me.DspVerLine.Size = New System.Drawing.Size(320, 32)
        Me.DspVerLine.TabIndex = 170
        Me.DspVerLine.Unit = "m"
        Me.DspVerLine.UnitVisible = True
        Me.DspVerLine.Value = "123.45 "
        Me.DspVerLine.ValueType = False
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
        Me.DspHorLine.Location = New System.Drawing.Point(11, 550)
        Me.DspHorLine.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorLine.Name = "DspHorLine"
        Me.DspHorLine.Size = New System.Drawing.Size(320, 32)
        Me.DspHorLine.TabIndex = 169
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
        Me.DspDistance.Location = New System.Drawing.Point(11, 512)
        Me.DspDistance.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDistance.Name = "DspDistance"
        Me.DspDistance.Size = New System.Drawing.Size(320, 32)
        Me.DspDistance.TabIndex = 168
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
        Me.DspMoment.Location = New System.Drawing.Point(11, 470)
        Me.DspMoment.Margin = New System.Windows.Forms.Padding(1)
        Me.DspMoment.Name = "DspMoment"
        Me.DspMoment.Size = New System.Drawing.Size(320, 32)
        Me.DspMoment.TabIndex = 167
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
        Me.DspThrust.Location = New System.Drawing.Point(11, 438)
        Me.DspThrust.Margin = New System.Windows.Forms.Padding(1)
        Me.DspThrust.Name = "DspThrust"
        Me.DspThrust.Size = New System.Drawing.Size(320, 32)
        Me.DspThrust.TabIndex = 166
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
        Me.DspJackPress.Location = New System.Drawing.Point(11, 406)
        Me.DspJackPress.Margin = New System.Windows.Forms.Padding(1)
        Me.DspJackPress.Name = "DspJackPress"
        Me.DspJackPress.Size = New System.Drawing.Size(320, 32)
        Me.DspJackPress.TabIndex = 165
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
        Me.DspVerBroken.Location = New System.Drawing.Point(11, 369)
        Me.DspVerBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerBroken.Name = "DspVerBroken"
        Me.DspVerBroken.Size = New System.Drawing.Size(320, 32)
        Me.DspVerBroken.TabIndex = 164
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
        Me.DspHorBroken.Location = New System.Drawing.Point(11, 337)
        Me.DspHorBroken.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorBroken.Name = "DspHorBroken"
        Me.DspHorBroken.Size = New System.Drawing.Size(320, 32)
        Me.DspHorBroken.TabIndex = 163
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
        Me.DspPitching.Location = New System.Drawing.Point(11, 300)
        Me.DspPitching.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPitching.Name = "DspPitching"
        Me.DspPitching.Size = New System.Drawing.Size(320, 32)
        Me.DspPitching.TabIndex = 162
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
        Me.DspDirection.Location = New System.Drawing.Point(11, 268)
        Me.DspDirection.Margin = New System.Windows.Forms.Padding(1)
        Me.DspDirection.Name = "DspDirection"
        Me.DspDirection.Size = New System.Drawing.Size(320, 32)
        Me.DspDirection.TabIndex = 161
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
        Me.DspVerDev.Location = New System.Drawing.Point(11, 231)
        Me.DspVerDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspVerDev.Name = "DspVerDev"
        Me.DspVerDev.Size = New System.Drawing.Size(320, 32)
        Me.DspVerDev.TabIndex = 160
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
        Me.DspHorDev.Location = New System.Drawing.Point(11, 199)
        Me.DspHorDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorDev.Name = "DspHorDev"
        Me.DspHorDev.Size = New System.Drawing.Size(320, 32)
        Me.DspHorDev.TabIndex = 159
        Me.DspHorDev.Unit = "deg"
        Me.DspHorDev.UnitVisible = True
        Me.DspHorDev.Value = "123.45 "
        Me.DspHorDev.ValueType = False
        '
        'DspAveStartStroke
        '
        Me.DspAveStartStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStartStroke.Blink = False
        Me.DspAveStartStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveStartStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveStartStroke.DataWidth = 110
        Me.DspAveStartStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStartStroke.FieldName = "開始ストローク"
        Me.DspAveStartStroke.FieldNameWidth = 146
        Me.DspAveStartStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStartStroke.Location = New System.Drawing.Point(10, 96)
        Me.DspAveStartStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStartStroke.Name = "DspAveStartStroke"
        Me.DspAveStartStroke.Size = New System.Drawing.Size(320, 32)
        Me.DspAveStartStroke.TabIndex = 173
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
        Me.DspExcvSpeed.DataWidth = 110
        Me.DspExcvSpeed.DecimalPlaces = CType(0, Short)
        Me.DspExcvSpeed.FieldName = "掘進速度"
        Me.DspExcvSpeed.FieldNameWidth = 146
        Me.DspExcvSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspExcvSpeed.Location = New System.Drawing.Point(11, 162)
        Me.DspExcvSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.DspExcvSpeed.Name = "DspExcvSpeed"
        Me.DspExcvSpeed.Size = New System.Drawing.Size(320, 32)
        Me.DspExcvSpeed.TabIndex = 172
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
        Me.DspAveStroke.DataWidth = 110
        Me.DspAveStroke.DecimalPlaces = CType(0, Short)
        Me.DspAveStroke.FieldName = "推進量"
        Me.DspAveStroke.FieldNameWidth = 146
        Me.DspAveStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStroke.Location = New System.Drawing.Point(11, 129)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(320, 32)
        Me.DspAveStroke.TabIndex = 171
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.UnitVisible = True
        Me.DspAveStroke.Value = "9999"
        Me.DspAveStroke.ValueType = False
        '
        'UcnDspData24
        '
        Me.UcnDspData24.BackColor = System.Drawing.Color.Transparent
        Me.UcnDspData24.Blink = False
        Me.UcnDspData24.BlinkColor = System.Drawing.Color.Red
        Me.UcnDspData24.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UcnDspData24.DataWidth = 91
        Me.UcnDspData24.DecimalPlaces = CType(2, Short)
        Me.UcnDspData24.FieldName = "ローリング偏差"
        Me.UcnDspData24.FieldNameWidth = 146
        Me.UcnDspData24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UcnDspData24.Location = New System.Drawing.Point(829, 998)
        Me.UcnDspData24.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData24.Name = "UcnDspData24"
        Me.UcnDspData24.Size = New System.Drawing.Size(243, 32)
        Me.UcnDspData24.TabIndex = 181
        Me.UcnDspData24.Unit = "deg"
        Me.UcnDspData24.UnitVisible = False
        Me.UcnDspData24.Value = "-"
        Me.UcnDspData24.ValueType = True
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
        Me.DspClosetJack.Location = New System.Drawing.Point(828, 934)
        Me.DspClosetJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetJack.Name = "DspClosetJack"
        Me.DspClosetJack.Size = New System.Drawing.Size(243, 32)
        Me.DspClosetJack.TabIndex = 178
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
        Me.DspBoltPitch.DataWidth = 91
        Me.DspBoltPitch.DecimalPlaces = CType(1, Short)
        Me.DspBoltPitch.FieldName = "組立ﾎﾞﾙﾄ位置"
        Me.DspBoltPitch.FieldNameWidth = 146
        Me.DspBoltPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspBoltPitch.Location = New System.Drawing.Point(594, 999)
        Me.DspBoltPitch.Margin = New System.Windows.Forms.Padding(1)
        Me.DspBoltPitch.Name = "DspBoltPitch"
        Me.DspBoltPitch.Size = New System.Drawing.Size(242, 32)
        Me.DspBoltPitch.TabIndex = 175
        Me.DspBoltPitch.Unit = "deg"
        Me.DspBoltPitch.UnitVisible = False
        Me.DspBoltPitch.Value = "-"
        Me.DspBoltPitch.ValueType = False
        '
        'DspAssemblyPattern
        '
        Me.DspAssemblyPattern.BackColor = System.Drawing.Color.Transparent
        Me.DspAssemblyPattern.Blink = False
        Me.DspAssemblyPattern.BlinkColor = System.Drawing.Color.Red
        Me.DspAssemblyPattern.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspAssemblyPattern.DataWidth = 216
        Me.DspAssemblyPattern.DecimalPlaces = CType(0, Short)
        Me.DspAssemblyPattern.FieldName = "組立パターン"
        Me.DspAssemblyPattern.FieldNameWidth = 260
        Me.DspAssemblyPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(594, 871)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(472, 32)
        Me.DspAssemblyPattern.TabIndex = 183
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
        Me.DspNextPieceName.DataWidth = 91
        Me.DspNextPieceName.DecimalPlaces = CType(2, Short)
        Me.DspNextPieceName.FieldName = "次の組立ピース"
        Me.DspNextPieceName.FieldNameWidth = 146
        Me.DspNextPieceName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspNextPieceName.Location = New System.Drawing.Point(829, 902)
        Me.DspNextPieceName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspNextPieceName.Name = "DspNextPieceName"
        Me.DspNextPieceName.Size = New System.Drawing.Size(243, 32)
        Me.DspNextPieceName.TabIndex = 182
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
        Me.DspAddClosetThrustJack.DataWidth = 91
        Me.DspAddClosetThrustJack.DecimalPlaces = CType(0, Short)
        Me.DspAddClosetThrustJack.FieldName = "追加推進ｼﾞｬｯｷ"
        Me.DspAddClosetThrustJack.FieldNameWidth = 146
        Me.DspAddClosetThrustJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAddClosetThrustJack.Location = New System.Drawing.Point(828, 966)
        Me.DspAddClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAddClosetThrustJack.Name = "DspAddClosetThrustJack"
        Me.DspAddClosetThrustJack.Size = New System.Drawing.Size(243, 32)
        Me.DspAddClosetThrustJack.TabIndex = 180
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
        Me.DspClosetThrustJack.DataWidth = 91
        Me.DspClosetThrustJack.DecimalPlaces = CType(2, Short)
        Me.DspClosetThrustJack.FieldName = "押込推進ｼﾞｬｯｷ"
        Me.DspClosetThrustJack.FieldNameWidth = 146
        Me.DspClosetThrustJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspClosetThrustJack.Location = New System.Drawing.Point(594, 967)
        Me.DspClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetThrustJack.Name = "DspClosetThrustJack"
        Me.DspClosetThrustJack.Size = New System.Drawing.Size(243, 32)
        Me.DspClosetThrustJack.TabIndex = 179
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
        Me.DspPullBackJack.DataWidth = 91
        Me.DspPullBackJack.DecimalPlaces = CType(2, Short)
        Me.DspPullBackJack.FieldName = "引戻ｼﾞｬｯｷ"
        Me.DspPullBackJack.FieldNameWidth = 146
        Me.DspPullBackJack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspPullBackJack.Location = New System.Drawing.Point(594, 935)
        Me.DspPullBackJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPullBackJack.Name = "DspPullBackJack"
        Me.DspPullBackJack.Size = New System.Drawing.Size(243, 32)
        Me.DspPullBackJack.TabIndex = 177
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
        Me.DspAssemblyPieace.DataWidth = 91
        Me.DspAssemblyPieace.DecimalPlaces = CType(2, Short)
        Me.DspAssemblyPieace.FieldName = "組立ピース"
        Me.DspAssemblyPieace.FieldNameWidth = 146
        Me.DspAssemblyPieace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(594, 903)
        Me.DspAssemblyPieace.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPieace.Name = "DspAssemblyPieace"
        Me.DspAssemblyPieace.Size = New System.Drawing.Size(243, 32)
        Me.DspAssemblyPieace.TabIndex = 176
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
        Me.DspTypeName.DataWidth = 216
        Me.DspTypeName.DecimalPlaces = CType(0, Short)
        Me.DspTypeName.FieldName = "組立セグメント"
        Me.DspTypeName.FieldNameWidth = 260
        Me.DspTypeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTypeName.Location = New System.Drawing.Point(594, 839)
        Me.DspTypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTypeName.Name = "DspTypeName"
        Me.DspTypeName.Size = New System.Drawing.Size(475, 32)
        Me.DspTypeName.TabIndex = 174
        Me.DspTypeName.Unit = "deg"
        Me.DspTypeName.UnitVisible = False
        Me.DspTypeName.Value = "-------"
        Me.DspTypeName.ValueType = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1912, 1051)
        Me.Controls.Add(Me.UcnDspData24)
        Me.Controls.Add(Me.DspClosetJack)
        Me.Controls.Add(Me.DspBoltPitch)
        Me.Controls.Add(Me.DspAssemblyPattern)
        Me.Controls.Add(Me.DspNextPieceName)
        Me.Controls.Add(Me.DspAddClosetThrustJack)
        Me.Controls.Add(Me.DspClosetThrustJack)
        Me.Controls.Add(Me.DspPullBackJack)
        Me.Controls.Add(Me.DspAssemblyPieace)
        Me.Controls.Add(Me.DspTypeName)
        Me.Controls.Add(Me.DspAveStartStroke)
        Me.Controls.Add(Me.DspExcvSpeed)
        Me.Controls.Add(Me.DspAveStroke)
        Me.Controls.Add(Me.DspVerLine)
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.DspRingNo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblNowDate)
        Me.Controls.Add(Me.UcnJackDsp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcnJackDsp As FLEX.NET.ucnJackDsp
    Public WithEvents tmrDataDsp As Timer
    Friend WithEvents lblNowDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DspExcavingStop As FLEX.NET.ucnDspBit
    Friend WithEvents DspExcavingOn As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexAuto As FLEX.NET.ucnDspBit
    Friend WithEvents DspFlexControlOn As FLEX.NET.ucnDspBit
    Friend WithEvents DspExcaWaiting As FLEX.NET.ucnDspBit
    Friend WithEvents lblUnit As Label
    Friend WithEvents DspRingNo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DspSumLoszeroTime As FLEX.NET.ucnDspData
    Friend WithEvents DspAveLoszeroTime As FLEX.NET.ucnDspData
    Friend WithEvents DspSumAsmPiece As FLEX.NET.ucnDspData
    Friend WithEvents DspAveAsmPiece As FLEX.NET.ucnDspData
    Friend WithEvents DspInterruptTime As FLEX.NET.ucnDspData
    Friend WithEvents DspWatingElapsedTime As FLEX.NET.ucnDspData
    Friend WithEvents DspLosZeroElapsedTime As FLEX.NET.ucnDspData
    Friend WithEvents DspExcationElapsedTime As FLEX.NET.ucnDspData
    Private WithEvents DspExcavStartTime As FLEX.NET.ucnDspData
    Private WithEvents DspExcavStartDate As FLEX.NET.ucnDspData
    Public WithEvents rtbEventLog As RichTextBox
    Friend WithEvents DspVerLine As FLEX.NET.ucnDspData
    Friend WithEvents DspHorLine As FLEX.NET.ucnDspData
    Friend WithEvents DspDistance As FLEX.NET.ucnDspData
    Friend WithEvents DspMoment As FLEX.NET.ucnDspData
    Friend WithEvents DspThrust As FLEX.NET.ucnDspData
    Friend WithEvents DspJackPress As FLEX.NET.ucnDspData
    Friend WithEvents DspVerBroken As FLEX.NET.ucnDspData
    Friend WithEvents DspHorBroken As FLEX.NET.ucnDspData
    Friend WithEvents DspPitching As FLEX.NET.ucnDspData
    Friend WithEvents DspDirection As FLEX.NET.ucnDspData
    Friend WithEvents DspVerDev As FLEX.NET.ucnDspData
    Friend WithEvents DspHorDev As FLEX.NET.ucnDspData
    Friend WithEvents DspAveStartStroke As FLEX.NET.ucnDspData
    Friend WithEvents DspExcvSpeed As FLEX.NET.ucnDspData
    Friend WithEvents DspAveStroke As FLEX.NET.ucnDspData
    Friend WithEvents UcnDspData24 As FLEX.NET.ucnDspData
    Friend WithEvents DspClosetJack As FLEX.NET.ucnDspData
    Friend WithEvents DspBoltPitch As FLEX.NET.ucnDspData
    Friend WithEvents DspAssemblyPattern As FLEX.NET.ucnDspData
    Friend WithEvents DspNextPieceName As FLEX.NET.ucnDspData
    Friend WithEvents DspAddClosetThrustJack As FLEX.NET.ucnDspData
    Friend WithEvents DspClosetThrustJack As FLEX.NET.ucnDspData
    Friend WithEvents DspPullBackJack As FLEX.NET.ucnDspData
    Friend WithEvents DspAssemblyPieace As FLEX.NET.ucnDspData
    Friend WithEvents DspTypeName As FLEX.NET.ucnDspData
End Class
