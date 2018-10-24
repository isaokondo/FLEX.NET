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
        Me.pnlLosZero = New System.Windows.Forms.Panel()
        Me.ucnLosZeroSts = New FLEX.NET.ucnDspBit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ucnAssemblyPieceNo12 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo11 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo10 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo09 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo08 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo07 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo06 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo05 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo04 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo03 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo02 = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyStart = New FLEX.NET.ucnDspBit()
        Me.ucnPullBackStart = New FLEX.NET.ucnDspBit()
        Me.ucnReduceStart = New FLEX.NET.ucnDspBit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucnAssemblyFinish = New FLEX.NET.ucnDspBit()
        Me.ucnPullBackFinish = New FLEX.NET.ucnDspBit()
        Me.ucnReduceFinish = New FLEX.NET.ucnDspBit()
        Me.ucnAssemblyPieceNo01 = New FLEX.NET.ucnDspBit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblGpPvColor0 = New System.Windows.Forms.Label()
        Me.lblGpPvColor1 = New System.Windows.Forms.Label()
        Me.lblGpPvColor2 = New System.Windows.Forms.Label()
        Me.lblGpPvColor3 = New System.Windows.Forms.Label()
        Me.lblGpPvColor4 = New System.Windows.Forms.Label()
        Me.lblGpPvColor5 = New System.Windows.Forms.Label()
        Me.lblGpPvColor6 = New System.Windows.Forms.Label()
        Me.lblGpPvColor7 = New System.Windows.Forms.Label()
        Me.lblGpPvColor8 = New System.Windows.Forms.Label()
        Me.lblGpPvColor9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
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
        Me.DspWideUse12 = New FLEX.NET.ucnDspData()
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
        Me.DspAveStartStroke = New FLEX.NET.ucnDspData()
        Me.DspExcvSpeed = New FLEX.NET.ucnDspData()
        Me.DspAveStroke = New FLEX.NET.ucnDspData()
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
        Me.UcnJackDsp = New FLEX.NET.ucnJackDsp()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlLosZero.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(669, 82)
        Me.Panel2.TabIndex = 155
        '
        'DspExcavingStop
        '
        Me.DspExcavingStop.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingStop.BitStatus = False
        Me.DspExcavingStop.Blink = False
        Me.DspExcavingStop.FieldName = "中　断　　"
        Me.DspExcavingStop.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspExcavingStop.Location = New System.Drawing.Point(449, 6)
        Me.DspExcavingStop.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcavingStop.Name = "DspExcavingStop"
        Me.DspExcavingStop.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingStop.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingStop.Size = New System.Drawing.Size(213, 38)
        Me.DspExcavingStop.TabIndex = 71
        '
        'DspExcavingOn
        '
        Me.DspExcavingOn.BackColor = System.Drawing.Color.Transparent
        Me.DspExcavingOn.BitStatus = True
        Me.DspExcavingOn.Blink = False
        Me.DspExcavingOn.FieldName = "掘   進 "
        Me.DspExcavingOn.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspExcavingOn.Location = New System.Drawing.Point(228, 6)
        Me.DspExcavingOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcavingOn.Name = "DspExcavingOn"
        Me.DspExcavingOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcavingOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcavingOn.Size = New System.Drawing.Size(213, 38)
        Me.DspExcavingOn.TabIndex = 68
        '
        'DspFlexAuto
        '
        Me.DspFlexAuto.BackColor = System.Drawing.Color.Transparent
        Me.DspFlexAuto.BitStatus = False
        Me.DspFlexAuto.Blink = False
        Me.DspFlexAuto.FieldName = "自動運転　"
        Me.DspFlexAuto.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspFlexAuto.Location = New System.Drawing.Point(130, 45)
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
        Me.DspFlexControlOn.FieldName = "単体圧力制御"
        Me.DspFlexControlOn.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspFlexControlOn.Location = New System.Drawing.Point(7, 45)
        Me.DspFlexControlOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DspFlexControlOn.Name = "DspFlexControlOn"
        Me.DspFlexControlOn.OffBackColor = System.Drawing.Color.LightGray
        Me.DspFlexControlOn.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspFlexControlOn.Size = New System.Drawing.Size(119, 30)
        Me.DspFlexControlOn.TabIndex = 66
        '
        'DspExcaWaiting
        '
        Me.DspExcaWaiting.BackColor = System.Drawing.Color.Transparent
        Me.DspExcaWaiting.BitStatus = False
        Me.DspExcaWaiting.Blink = False
        Me.DspExcaWaiting.FieldName = "待  機    "
        Me.DspExcaWaiting.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspExcaWaiting.Location = New System.Drawing.Point(7, 6)
        Me.DspExcaWaiting.Margin = New System.Windows.Forms.Padding(2)
        Me.DspExcaWaiting.Name = "DspExcaWaiting"
        Me.DspExcaWaiting.OffBackColor = System.Drawing.Color.LightGray
        Me.DspExcaWaiting.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DspExcaWaiting.Size = New System.Drawing.Size(213, 38)
        Me.DspExcaWaiting.TabIndex = 65
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(900, 47)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(91, 26)
        Me.lblUnit.TabIndex = 157
        Me.lblUnit.Text = "リング"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspRingNo
        '
        Me.DspRingNo.BackColor = System.Drawing.Color.Black
        Me.DspRingNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DspRingNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DspRingNo.ForeColor = System.Drawing.Color.LightGreen
        Me.DspRingNo.Location = New System.Drawing.Point(742, 31)
        Me.DspRingNo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.DspRingNo.Name = "DspRingNo"
        Me.DspRingNo.Size = New System.Drawing.Size(156, 45)
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
        Me.Panel1.Location = New System.Drawing.Point(1324, 656)
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
        'pnlLosZero
        '
        Me.pnlLosZero.BackColor = System.Drawing.Color.Silver
        Me.pnlLosZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLosZero.Controls.Add(Me.ucnLosZeroSts)
        Me.pnlLosZero.Controls.Add(Me.Label7)
        Me.pnlLosZero.Controls.Add(Me.Label6)
        Me.pnlLosZero.Controls.Add(Me.Label5)
        Me.pnlLosZero.Controls.Add(Me.Label4)
        Me.pnlLosZero.Controls.Add(Me.Label3)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo12)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo11)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo10)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo09)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo08)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo07)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo06)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo05)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo04)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo03)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo02)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyStart)
        Me.pnlLosZero.Controls.Add(Me.ucnPullBackStart)
        Me.pnlLosZero.Controls.Add(Me.ucnReduceStart)
        Me.pnlLosZero.Controls.Add(Me.Label2)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnPullBackFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnReduceFinish)
        Me.pnlLosZero.Controls.Add(Me.ucnAssemblyPieceNo01)
        Me.pnlLosZero.Location = New System.Drawing.Point(1492, 47)
        Me.pnlLosZero.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLosZero.Name = "pnlLosZero"
        Me.pnlLosZero.Size = New System.Drawing.Size(407, 587)
        Me.pnlLosZero.TabIndex = 184
        '
        'ucnLosZeroSts
        '
        Me.ucnLosZeroSts.BackColor = System.Drawing.Color.Transparent
        Me.ucnLosZeroSts.BitStatus = True
        Me.ucnLosZeroSts.Blink = False
        Me.ucnLosZeroSts.FieldName = "同時組立中"
        Me.ucnLosZeroSts.Location = New System.Drawing.Point(124, 48)
        Me.ucnLosZeroSts.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnLosZeroSts.Name = "ucnLosZeroSts"
        Me.ucnLosZeroSts.OffBackColor = System.Drawing.Color.LightGray
        Me.ucnLosZeroSts.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnLosZeroSts.Size = New System.Drawing.Size(131, 37)
        Me.ucnLosZeroSts.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 376)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 26)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "↓"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 315)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "↓"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 26)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "↓"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 26)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "↓"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 26)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "↓"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucnAssemblyPieceNo12
        '
        Me.ucnAssemblyPieceNo12.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo12.BitStatus = True
        Me.ucnAssemblyPieceNo12.Blink = False
        Me.ucnAssemblyPieceNo12.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo12.Location = New System.Drawing.Point(241, 538)
        Me.ucnAssemblyPieceNo12.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo12.Name = "ucnAssemblyPieceNo12"
        Me.ucnAssemblyPieceNo12.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo12.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo12.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo12.TabIndex = 152
        '
        'ucnAssemblyPieceNo11
        '
        Me.ucnAssemblyPieceNo11.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo11.BitStatus = True
        Me.ucnAssemblyPieceNo11.Blink = False
        Me.ucnAssemblyPieceNo11.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo11.Location = New System.Drawing.Point(241, 499)
        Me.ucnAssemblyPieceNo11.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo11.Name = "ucnAssemblyPieceNo11"
        Me.ucnAssemblyPieceNo11.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo11.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo11.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo11.TabIndex = 151
        '
        'ucnAssemblyPieceNo10
        '
        Me.ucnAssemblyPieceNo10.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo10.BitStatus = True
        Me.ucnAssemblyPieceNo10.Blink = False
        Me.ucnAssemblyPieceNo10.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo10.Location = New System.Drawing.Point(241, 460)
        Me.ucnAssemblyPieceNo10.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo10.Name = "ucnAssemblyPieceNo10"
        Me.ucnAssemblyPieceNo10.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo10.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo10.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo10.TabIndex = 150
        '
        'ucnAssemblyPieceNo09
        '
        Me.ucnAssemblyPieceNo09.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo09.BitStatus = True
        Me.ucnAssemblyPieceNo09.Blink = False
        Me.ucnAssemblyPieceNo09.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo09.Location = New System.Drawing.Point(241, 421)
        Me.ucnAssemblyPieceNo09.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo09.Name = "ucnAssemblyPieceNo09"
        Me.ucnAssemblyPieceNo09.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo09.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo09.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo09.TabIndex = 149
        '
        'ucnAssemblyPieceNo08
        '
        Me.ucnAssemblyPieceNo08.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo08.BitStatus = True
        Me.ucnAssemblyPieceNo08.Blink = False
        Me.ucnAssemblyPieceNo08.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo08.Location = New System.Drawing.Point(241, 382)
        Me.ucnAssemblyPieceNo08.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo08.Name = "ucnAssemblyPieceNo08"
        Me.ucnAssemblyPieceNo08.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo08.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo08.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo08.TabIndex = 148
        '
        'ucnAssemblyPieceNo07
        '
        Me.ucnAssemblyPieceNo07.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo07.BitStatus = True
        Me.ucnAssemblyPieceNo07.Blink = False
        Me.ucnAssemblyPieceNo07.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo07.Location = New System.Drawing.Point(241, 343)
        Me.ucnAssemblyPieceNo07.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo07.Name = "ucnAssemblyPieceNo07"
        Me.ucnAssemblyPieceNo07.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo07.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo07.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo07.TabIndex = 147
        '
        'ucnAssemblyPieceNo06
        '
        Me.ucnAssemblyPieceNo06.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo06.BitStatus = True
        Me.ucnAssemblyPieceNo06.Blink = False
        Me.ucnAssemblyPieceNo06.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo06.Location = New System.Drawing.Point(241, 304)
        Me.ucnAssemblyPieceNo06.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo06.Name = "ucnAssemblyPieceNo06"
        Me.ucnAssemblyPieceNo06.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo06.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo06.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo06.TabIndex = 146
        '
        'ucnAssemblyPieceNo05
        '
        Me.ucnAssemblyPieceNo05.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo05.BitStatus = True
        Me.ucnAssemblyPieceNo05.Blink = False
        Me.ucnAssemblyPieceNo05.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo05.Location = New System.Drawing.Point(241, 265)
        Me.ucnAssemblyPieceNo05.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo05.Name = "ucnAssemblyPieceNo05"
        Me.ucnAssemblyPieceNo05.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo05.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo05.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo05.TabIndex = 145
        '
        'ucnAssemblyPieceNo04
        '
        Me.ucnAssemblyPieceNo04.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo04.BitStatus = True
        Me.ucnAssemblyPieceNo04.Blink = False
        Me.ucnAssemblyPieceNo04.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo04.Location = New System.Drawing.Point(241, 226)
        Me.ucnAssemblyPieceNo04.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo04.Name = "ucnAssemblyPieceNo04"
        Me.ucnAssemblyPieceNo04.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo04.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo04.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo04.TabIndex = 144
        '
        'ucnAssemblyPieceNo03
        '
        Me.ucnAssemblyPieceNo03.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo03.BitStatus = True
        Me.ucnAssemblyPieceNo03.Blink = False
        Me.ucnAssemblyPieceNo03.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo03.Location = New System.Drawing.Point(241, 187)
        Me.ucnAssemblyPieceNo03.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo03.Name = "ucnAssemblyPieceNo03"
        Me.ucnAssemblyPieceNo03.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo03.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo03.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo03.TabIndex = 143
        '
        'ucnAssemblyPieceNo02
        '
        Me.ucnAssemblyPieceNo02.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo02.BitStatus = True
        Me.ucnAssemblyPieceNo02.Blink = False
        Me.ucnAssemblyPieceNo02.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo02.Location = New System.Drawing.Point(241, 148)
        Me.ucnAssemblyPieceNo02.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo02.Name = "ucnAssemblyPieceNo02"
        Me.ucnAssemblyPieceNo02.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo02.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo02.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo02.TabIndex = 142
        '
        'ucnAssemblyStart
        '
        Me.ucnAssemblyStart.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyStart.BitStatus = True
        Me.ucnAssemblyStart.Blink = False
        Me.ucnAssemblyStart.FieldName = "組立開始"
        Me.ucnAssemblyStart.Location = New System.Drawing.Point(50, 345)
        Me.ucnAssemblyStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyStart.Name = "ucnAssemblyStart"
        Me.ucnAssemblyStart.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyStart.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyStart.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyStart.TabIndex = 141
        '
        'ucnPullBackStart
        '
        Me.ucnPullBackStart.BackColor = System.Drawing.Color.Transparent
        Me.ucnPullBackStart.BitStatus = True
        Me.ucnPullBackStart.Blink = False
        Me.ucnPullBackStart.FieldName = "引戻開始"
        Me.ucnPullBackStart.Location = New System.Drawing.Point(50, 227)
        Me.ucnPullBackStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnPullBackStart.Name = "ucnPullBackStart"
        Me.ucnPullBackStart.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnPullBackStart.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnPullBackStart.Size = New System.Drawing.Size(131, 37)
        Me.ucnPullBackStart.TabIndex = 140
        '
        'ucnReduceStart
        '
        Me.ucnReduceStart.BackColor = System.Drawing.Color.Transparent
        Me.ucnReduceStart.BitStatus = True
        Me.ucnReduceStart.Blink = False
        Me.ucnReduceStart.FieldName = "減圧開始"
        Me.ucnReduceStart.Location = New System.Drawing.Point(50, 109)
        Me.ucnReduceStart.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnReduceStart.Name = "ucnReduceStart"
        Me.ucnReduceStart.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnReduceStart.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnReduceStart.Size = New System.Drawing.Size(131, 37)
        Me.ucnReduceStart.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 26)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "同時施工状況"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucnAssemblyFinish
        '
        Me.ucnAssemblyFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyFinish.BitStatus = True
        Me.ucnAssemblyFinish.Blink = False
        Me.ucnAssemblyFinish.FieldName = "組立完了"
        Me.ucnAssemblyFinish.Location = New System.Drawing.Point(50, 404)
        Me.ucnAssemblyFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyFinish.Name = "ucnAssemblyFinish"
        Me.ucnAssemblyFinish.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyFinish.TabIndex = 137
        '
        'ucnPullBackFinish
        '
        Me.ucnPullBackFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnPullBackFinish.BitStatus = True
        Me.ucnPullBackFinish.Blink = False
        Me.ucnPullBackFinish.FieldName = "引戻完了"
        Me.ucnPullBackFinish.Location = New System.Drawing.Point(50, 286)
        Me.ucnPullBackFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnPullBackFinish.Name = "ucnPullBackFinish"
        Me.ucnPullBackFinish.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnPullBackFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnPullBackFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnPullBackFinish.TabIndex = 136
        '
        'ucnReduceFinish
        '
        Me.ucnReduceFinish.BackColor = System.Drawing.Color.Transparent
        Me.ucnReduceFinish.BitStatus = True
        Me.ucnReduceFinish.Blink = False
        Me.ucnReduceFinish.FieldName = "減圧完了"
        Me.ucnReduceFinish.Location = New System.Drawing.Point(50, 168)
        Me.ucnReduceFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnReduceFinish.Name = "ucnReduceFinish"
        Me.ucnReduceFinish.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnReduceFinish.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnReduceFinish.Size = New System.Drawing.Size(131, 37)
        Me.ucnReduceFinish.TabIndex = 135
        '
        'ucnAssemblyPieceNo01
        '
        Me.ucnAssemblyPieceNo01.BackColor = System.Drawing.Color.Transparent
        Me.ucnAssemblyPieceNo01.BitStatus = True
        Me.ucnAssemblyPieceNo01.Blink = False
        Me.ucnAssemblyPieceNo01.FieldName = "2ピース目"
        Me.ucnAssemblyPieceNo01.Location = New System.Drawing.Point(241, 109)
        Me.ucnAssemblyPieceNo01.Margin = New System.Windows.Forms.Padding(2)
        Me.ucnAssemblyPieceNo01.Name = "ucnAssemblyPieceNo01"
        Me.ucnAssemblyPieceNo01.OffBackColor = System.Drawing.Color.DimGray
        Me.ucnAssemblyPieceNo01.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ucnAssemblyPieceNo01.Size = New System.Drawing.Size(131, 37)
        Me.ucnAssemblyPieceNo01.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(1215, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 587)
        Me.Panel3.TabIndex = 199
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label29.Location = New System.Drawing.Point(35, 507)
        Me.Label29.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 30)
        Me.Label29.TabIndex = 160
        Me.Label29.Text = "組立完了"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label28.Location = New System.Drawing.Point(35, 461)
        Me.Label28.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(123, 30)
        Me.Label28.TabIndex = 159
        Me.Label28.Text = "組立中"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label27.Location = New System.Drawing.Point(35, 419)
        Me.Label27.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 30)
        Me.Label27.TabIndex = 158
        Me.Label27.Text = "未組立"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label26.Location = New System.Drawing.Point(175, 422)
        Me.Label26.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 25)
        Me.Label26.TabIndex = 157
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Silver
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label25.Location = New System.Drawing.Point(175, 510)
        Me.Label25.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 25)
        Me.Label25.TabIndex = 156
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Yellow
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label24.Location = New System.Drawing.Point(175, 466)
        Me.Label24.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 25)
        Me.Label24.TabIndex = 155
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(35, 360)
        Me.Label23.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(161, 30)
        Me.Label23.TabIndex = 154
        Me.Label23.Text = "組立順序＋ピース名"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.OldLace
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.Location = New System.Drawing.Point(34, 315)
        Me.Label22.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(162, 26)
        Me.Label22.TabIndex = 153
        Me.Label22.Text = "セグメント凡例"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Yellow
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(175, 200)
        Me.Label19.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 25)
        Me.Label19.TabIndex = 152
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.YellowGreen
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.Location = New System.Drawing.Point(156, 200)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 25)
        Me.Label20.TabIndex = 151
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Location = New System.Drawing.Point(31, 197)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 30)
        Me.Label21.TabIndex = 150
        Me.Label21.Text = "押込み推進"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.MediumPurple
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(175, 163)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 25)
        Me.Label16.TabIndex = 149
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Purple
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(156, 163)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 25)
        Me.Label17.TabIndex = 148
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(31, 160)
        Me.Label18.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(123, 30)
        Me.Label18.TabIndex = 147
        Me.Label18.Text = "引戻し中"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Orange
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(175, 126)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 25)
        Me.Label15.TabIndex = 146
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(156, 126)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 25)
        Me.Label13.TabIndex = 145
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(31, 123)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 30)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "減圧中"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(156, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 25)
        Me.Label11.TabIndex = 143
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(31, 86)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 30)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "ジャッキ非稼働"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(156, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 25)
        Me.Label10.TabIndex = 141
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(30, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 30)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "ジャッキ稼働"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.OldLace
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 26)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "ジャッキ　判例　"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.lblGpPvColor0)
        Me.Panel4.Controls.Add(Me.lblGpPvColor1)
        Me.Panel4.Controls.Add(Me.lblGpPvColor2)
        Me.Panel4.Controls.Add(Me.lblGpPvColor3)
        Me.Panel4.Controls.Add(Me.lblGpPvColor4)
        Me.Panel4.Controls.Add(Me.lblGpPvColor5)
        Me.Panel4.Controls.Add(Me.lblGpPvColor6)
        Me.Panel4.Controls.Add(Me.lblGpPvColor7)
        Me.Panel4.Controls.Add(Me.lblGpPvColor8)
        Me.Panel4.Controls.Add(Me.lblGpPvColor9)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Location = New System.Drawing.Point(383, 259)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(110, 343)
        Me.Panel4.TabIndex = 200
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label33.Location = New System.Drawing.Point(37, 184)
        Me.Label33.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 30)
        Me.Label33.TabIndex = 165
        Me.Label33.Text = "50%"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label32.Location = New System.Drawing.Point(37, 60)
        Me.Label32.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 30)
        Me.Label32.TabIndex = 164
        Me.Label32.Text = "100%"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label31.Location = New System.Drawing.Point(37, 305)
        Me.Label31.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 30)
        Me.Label31.TabIndex = 163
        Me.Label31.Text = "0%"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGpPvColor0
        '
        Me.lblGpPvColor0.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor0.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor0.Location = New System.Drawing.Point(15, 299)
        Me.lblGpPvColor0.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor0.Name = "lblGpPvColor0"
        Me.lblGpPvColor0.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor0.TabIndex = 162
        Me.lblGpPvColor0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor1
        '
        Me.lblGpPvColor1.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor1.Location = New System.Drawing.Point(15, 274)
        Me.lblGpPvColor1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor1.Name = "lblGpPvColor1"
        Me.lblGpPvColor1.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor1.TabIndex = 161
        Me.lblGpPvColor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor2
        '
        Me.lblGpPvColor2.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor2.Location = New System.Drawing.Point(15, 249)
        Me.lblGpPvColor2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor2.Name = "lblGpPvColor2"
        Me.lblGpPvColor2.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor2.TabIndex = 160
        Me.lblGpPvColor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor3
        '
        Me.lblGpPvColor3.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor3.Location = New System.Drawing.Point(15, 224)
        Me.lblGpPvColor3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor3.Name = "lblGpPvColor3"
        Me.lblGpPvColor3.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor3.TabIndex = 159
        Me.lblGpPvColor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor4
        '
        Me.lblGpPvColor4.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor4.Location = New System.Drawing.Point(15, 199)
        Me.lblGpPvColor4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor4.Name = "lblGpPvColor4"
        Me.lblGpPvColor4.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor4.TabIndex = 158
        Me.lblGpPvColor4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor5
        '
        Me.lblGpPvColor5.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor5.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor5.Location = New System.Drawing.Point(15, 174)
        Me.lblGpPvColor5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor5.Name = "lblGpPvColor5"
        Me.lblGpPvColor5.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor5.TabIndex = 157
        Me.lblGpPvColor5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor6
        '
        Me.lblGpPvColor6.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor6.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor6.Location = New System.Drawing.Point(15, 149)
        Me.lblGpPvColor6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor6.Name = "lblGpPvColor6"
        Me.lblGpPvColor6.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor6.TabIndex = 156
        Me.lblGpPvColor6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor7
        '
        Me.lblGpPvColor7.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor7.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor7.Location = New System.Drawing.Point(15, 124)
        Me.lblGpPvColor7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor7.Name = "lblGpPvColor7"
        Me.lblGpPvColor7.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor7.TabIndex = 155
        Me.lblGpPvColor7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor8
        '
        Me.lblGpPvColor8.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor8.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor8.Location = New System.Drawing.Point(15, 99)
        Me.lblGpPvColor8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor8.Name = "lblGpPvColor8"
        Me.lblGpPvColor8.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor8.TabIndex = 154
        Me.lblGpPvColor8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGpPvColor9
        '
        Me.lblGpPvColor9.BackColor = System.Drawing.Color.YellowGreen
        Me.lblGpPvColor9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGpPvColor9.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblGpPvColor9.Location = New System.Drawing.Point(15, 74)
        Me.lblGpPvColor9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGpPvColor9.Name = "lblGpPvColor9"
        Me.lblGpPvColor9.Size = New System.Drawing.Size(20, 25)
        Me.lblGpPvColor9.TabIndex = 153
        Me.lblGpPvColor9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.OldLace
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label30.Location = New System.Drawing.Point(1, 14)
        Me.Label30.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 44)
        Me.Label30.TabIndex = 140
        Me.Label30.Text = "グループ圧" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "判例　"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DspWideUse11.Location = New System.Drawing.Point(10, 960)
        Me.DspWideUse11.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse11.Name = "DspWideUse11"
        Me.DspWideUse11.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse11.TabIndex = 196
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
        Me.DspWideUse10.Location = New System.Drawing.Point(10, 928)
        Me.DspWideUse10.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse10.Name = "DspWideUse10"
        Me.DspWideUse10.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse10.TabIndex = 195
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
        Me.DspWideUse9.Location = New System.Drawing.Point(10, 896)
        Me.DspWideUse9.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse9.Name = "DspWideUse9"
        Me.DspWideUse9.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse9.TabIndex = 194
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
        Me.DspWideUse8.Location = New System.Drawing.Point(10, 864)
        Me.DspWideUse8.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse8.Name = "DspWideUse8"
        Me.DspWideUse8.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse8.TabIndex = 193
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
        Me.DspWideUse7.Location = New System.Drawing.Point(10, 832)
        Me.DspWideUse7.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse7.Name = "DspWideUse7"
        Me.DspWideUse7.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse7.TabIndex = 192
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
        Me.DspWideUse6.Location = New System.Drawing.Point(10, 800)
        Me.DspWideUse6.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse6.Name = "DspWideUse6"
        Me.DspWideUse6.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse6.TabIndex = 191
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
        Me.DspWideUse5.Location = New System.Drawing.Point(10, 768)
        Me.DspWideUse5.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse5.Name = "DspWideUse5"
        Me.DspWideUse5.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse5.TabIndex = 190
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
        Me.DspWideUse4.Location = New System.Drawing.Point(10, 736)
        Me.DspWideUse4.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse4.Name = "DspWideUse4"
        Me.DspWideUse4.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse4.TabIndex = 189
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
        Me.DspWideUse3.Location = New System.Drawing.Point(10, 704)
        Me.DspWideUse3.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse3.Name = "DspWideUse3"
        Me.DspWideUse3.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse3.TabIndex = 188
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
        Me.DspWideUse2.Location = New System.Drawing.Point(10, 672)
        Me.DspWideUse2.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse2.Name = "DspWideUse2"
        Me.DspWideUse2.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse2.TabIndex = 187
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
        Me.DspWideUse1.Location = New System.Drawing.Point(10, 640)
        Me.DspWideUse1.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse1.Name = "DspWideUse1"
        Me.DspWideUse1.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse1.TabIndex = 186
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
        Me.DspWideUse0.Location = New System.Drawing.Point(10, 608)
        Me.DspWideUse0.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse0.Name = "DspWideUse0"
        Me.DspWideUse0.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse0.TabIndex = 185
        Me.DspWideUse0.Unit = ""
        Me.DspWideUse0.UnitVisible = True
        Me.DspWideUse0.Value = "123.45 "
        Me.DspWideUse0.ValueType = False
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
        Me.DspWideUse12.Location = New System.Drawing.Point(10, 994)
        Me.DspWideUse12.Margin = New System.Windows.Forms.Padding(1)
        Me.DspWideUse12.Name = "DspWideUse12"
        Me.DspWideUse12.Size = New System.Drawing.Size(320, 32)
        Me.DspWideUse12.TabIndex = 198
        Me.DspWideUse12.Unit = ""
        Me.DspWideUse12.UnitVisible = True
        Me.DspWideUse12.Value = "123.45 "
        Me.DspWideUse12.ValueType = False
        Me.DspWideUse12.Visible = False
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
        Me.UcnDspData24.Location = New System.Drawing.Point(905, 994)
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
        Me.DspClosetJack.Location = New System.Drawing.Point(904, 930)
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
        Me.DspBoltPitch.Location = New System.Drawing.Point(670, 995)
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
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(670, 867)
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
        Me.DspNextPieceName.Location = New System.Drawing.Point(905, 898)
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
        Me.DspAddClosetThrustJack.Location = New System.Drawing.Point(904, 962)
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
        Me.DspClosetThrustJack.Location = New System.Drawing.Point(670, 963)
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
        Me.DspPullBackJack.Location = New System.Drawing.Point(670, 931)
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
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(670, 899)
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
        Me.DspTypeName.Location = New System.Drawing.Point(670, 835)
        Me.DspTypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTypeName.Name = "DspTypeName"
        Me.DspTypeName.Size = New System.Drawing.Size(475, 32)
        Me.DspTypeName.TabIndex = 174
        Me.DspTypeName.Unit = "deg"
        Me.DspTypeName.UnitVisible = False
        Me.DspTypeName.Value = "-------"
        Me.DspTypeName.ValueType = True
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
        Me.DspAveStartStroke.Location = New System.Drawing.Point(10, 102)
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
        Me.DspExcvSpeed.Location = New System.Drawing.Point(11, 166)
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
        Me.DspAveStroke.Location = New System.Drawing.Point(11, 134)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(320, 32)
        Me.DspAveStroke.TabIndex = 171
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.UnitVisible = True
        Me.DspAveStroke.Value = "9999"
        Me.DspAveStroke.ValueType = False
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
        Me.DspVerLine.Location = New System.Drawing.Point(10, 561)
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
        Me.DspHorLine.Location = New System.Drawing.Point(10, 529)
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
        Me.DspDistance.Location = New System.Drawing.Point(10, 497)
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
        Me.DspMoment.Location = New System.Drawing.Point(10, 465)
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
        Me.DspThrust.Location = New System.Drawing.Point(10, 429)
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
        Me.DspJackPress.Location = New System.Drawing.Point(10, 397)
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
        Me.DspVerBroken.Location = New System.Drawing.Point(10, 365)
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
        Me.DspHorBroken.Location = New System.Drawing.Point(10, 333)
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
        Me.DspPitching.Location = New System.Drawing.Point(10, 301)
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
        Me.DspDirection.Location = New System.Drawing.Point(10, 269)
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
        Me.DspVerDev.Location = New System.Drawing.Point(10, 234)
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
        Me.DspHorDev.Location = New System.Drawing.Point(10, 202)
        Me.DspHorDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorDev.Name = "DspHorDev"
        Me.DspHorDev.Size = New System.Drawing.Size(320, 32)
        Me.DspHorDev.TabIndex = 159
        Me.DspHorDev.Unit = "deg"
        Me.DspHorDev.UnitVisible = True
        Me.DspHorDev.Value = "123.45 "
        Me.DspHorDev.ValueType = False
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1912, 1051)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
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
        Me.Controls.Add(Me.DspWideUse12)
        Me.Controls.Add(Me.pnlLosZero)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "同時施工モニタ　単体圧力制御"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlLosZero.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
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
    Friend WithEvents pnlLosZero As Panel
    Friend WithEvents ucnLosZeroSts As FLEX.NET.ucnDspBit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ucnAssemblyPieceNo12 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo11 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo10 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo09 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo08 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo07 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo06 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo05 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo04 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo03 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo02 As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyStart As FLEX.NET.ucnDspBit
    Friend WithEvents ucnPullBackStart As FLEX.NET.ucnDspBit
    Friend WithEvents ucnReduceStart As FLEX.NET.ucnDspBit
    Friend WithEvents Label2 As Label
    Friend WithEvents ucnAssemblyFinish As FLEX.NET.ucnDspBit
    Friend WithEvents ucnPullBackFinish As FLEX.NET.ucnDspBit
    Friend WithEvents ucnReduceFinish As FLEX.NET.ucnDspBit
    Friend WithEvents ucnAssemblyPieceNo01 As FLEX.NET.ucnDspBit
    Friend WithEvents DspWideUse11 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse10 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse9 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse8 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse7 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse6 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse5 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse4 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse3 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse2 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse1 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse0 As FLEX.NET.ucnDspData
    Friend WithEvents DspWideUse12 As FLEX.NET.ucnDspData
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblGpPvColor1 As Label
    Friend WithEvents lblGpPvColor2 As Label
    Friend WithEvents lblGpPvColor3 As Label
    Friend WithEvents lblGpPvColor4 As Label
    Friend WithEvents lblGpPvColor5 As Label
    Friend WithEvents lblGpPvColor6 As Label
    Friend WithEvents lblGpPvColor7 As Label
    Friend WithEvents lblGpPvColor8 As Label
    Friend WithEvents lblGpPvColor9 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblGpPvColor0 As Label
End Class
