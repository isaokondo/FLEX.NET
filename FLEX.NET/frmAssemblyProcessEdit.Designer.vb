﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssemblyProcessEdit
    Inherits frmSettingBase

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
        Me.DspAssemblyPattern = New FLEX.NET.ucnDspData()
        Me.DspNextPieceName = New FLEX.NET.ucnDspData()
        Me.UcnDspData24 = New FLEX.NET.ucnDspData()
        Me.DspAddClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspClosetThrustJack = New FLEX.NET.ucnDspData()
        Me.DspClosetJack = New FLEX.NET.ucnDspData()
        Me.DspPullBackJack = New FLEX.NET.ucnDspData()
        Me.UcnDspData17 = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPieace = New FLEX.NET.ucnDspData()
        Me.DspBoltPitch = New FLEX.NET.ucnDspData()
        Me.UcnDspData1 = New FLEX.NET.ucnDspData()
        Me.AssemblyBoltPitchSel = New FLEX.NET.ucnNumEdit()
        Me.AssemblySegmentSel = New FLEX.NET.ucnNumEdit()
        Me.ConfirmRingNo = New FLEX.NET.ucnNumEdit()
        Me.AssemblyPatternSel = New FLEX.NET.ucnNumEdit()
        Me.LastJackNo = New FLEX.NET.ucnNumEdit()
        Me.StartJackNo = New FLEX.NET.ucnNumEdit()
        Me.OperattionJackSel = New FLEX.NET.ucnNumEdit()
        Me.AssemblyPieceNo = New FLEX.NET.ucnNumEdit()
        Me.picAssemblySeg = New System.Windows.Forms.PictureBox()
        CType(Me.picAssemblySeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(150, 401)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(284, 402)
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
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(486, 65)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(496, 32)
        Me.DspAssemblyPattern.TabIndex = 122
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
        Me.DspNextPieceName.Location = New System.Drawing.Point(724, 205)
        Me.DspNextPieceName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspNextPieceName.Name = "DspNextPieceName"
        Me.DspNextPieceName.Size = New System.Drawing.Size(247, 32)
        Me.DspNextPieceName.TabIndex = 121
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
        Me.UcnDspData24.Location = New System.Drawing.Point(486, 205)
        Me.UcnDspData24.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData24.Name = "UcnDspData24"
        Me.UcnDspData24.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData24.TabIndex = 120
        Me.UcnDspData24.Unit = "deg"
        Me.UcnDspData24.UnitVisible = False
        Me.UcnDspData24.Value = "-"
        Me.UcnDspData24.ValueType = True
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
        Me.DspAddClosetThrustJack.Location = New System.Drawing.Point(724, 170)
        Me.DspAddClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAddClosetThrustJack.Name = "DspAddClosetThrustJack"
        Me.DspAddClosetThrustJack.Size = New System.Drawing.Size(247, 32)
        Me.DspAddClosetThrustJack.TabIndex = 119
        Me.DspAddClosetThrustJack.Unit = "deg"
        Me.DspAddClosetThrustJack.UnitVisible = False
        Me.DspAddClosetThrustJack.Value = "24"
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
        Me.DspClosetThrustJack.Location = New System.Drawing.Point(486, 170)
        Me.DspClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetThrustJack.Name = "DspClosetThrustJack"
        Me.DspClosetThrustJack.Size = New System.Drawing.Size(244, 32)
        Me.DspClosetThrustJack.TabIndex = 118
        Me.DspClosetThrustJack.Unit = "deg"
        Me.DspClosetThrustJack.UnitVisible = False
        Me.DspClosetThrustJack.Value = "-"
        Me.DspClosetThrustJack.ValueType = True
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
        Me.DspClosetJack.Location = New System.Drawing.Point(724, 135)
        Me.DspClosetJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetJack.Name = "DspClosetJack"
        Me.DspClosetJack.Size = New System.Drawing.Size(247, 32)
        Me.DspClosetJack.TabIndex = 117
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
        Me.DspPullBackJack.Location = New System.Drawing.Point(486, 135)
        Me.DspPullBackJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPullBackJack.Name = "DspPullBackJack"
        Me.DspPullBackJack.Size = New System.Drawing.Size(244, 32)
        Me.DspPullBackJack.TabIndex = 116
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
        Me.UcnDspData17.Location = New System.Drawing.Point(724, 100)
        Me.UcnDspData17.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData17.Name = "UcnDspData17"
        Me.UcnDspData17.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData17.TabIndex = 115
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
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(486, 100)
        Me.DspAssemblyPieace.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPieace.Name = "DspAssemblyPieace"
        Me.DspAssemblyPieace.Size = New System.Drawing.Size(244, 32)
        Me.DspAssemblyPieace.TabIndex = 114
        Me.DspAssemblyPieace.Unit = "deg"
        Me.DspAssemblyPieace.UnitVisible = False
        Me.DspAssemblyPieace.Value = "A2-1"
        Me.DspAssemblyPieace.ValueType = True
        '
        'DspBoltPitch
        '
        Me.DspBoltPitch.BackColor = System.Drawing.Color.Transparent
        Me.DspBoltPitch.Blink = False
        Me.DspBoltPitch.BlinkColor = System.Drawing.Color.Red
        Me.DspBoltPitch.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspBoltPitch.DataWidth = 91
        Me.DspBoltPitch.DecimalPlaces = CType(1, Short)
        Me.DspBoltPitch.FieldName = "組立ﾎﾞﾙﾄﾋﾟｯﾁ"
        Me.DspBoltPitch.FieldNameWidth = 146
        Me.DspBoltPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspBoltPitch.Location = New System.Drawing.Point(724, 30)
        Me.DspBoltPitch.Margin = New System.Windows.Forms.Padding(1)
        Me.DspBoltPitch.Name = "DspBoltPitch"
        Me.DspBoltPitch.Size = New System.Drawing.Size(247, 32)
        Me.DspBoltPitch.TabIndex = 113
        Me.DspBoltPitch.Unit = "deg"
        Me.DspBoltPitch.UnitVisible = False
        Me.DspBoltPitch.Value = "3"
        Me.DspBoltPitch.ValueType = False
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
        Me.UcnDspData1.Location = New System.Drawing.Point(486, 30)
        Me.UcnDspData1.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData1.Name = "UcnDspData1"
        Me.UcnDspData1.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData1.TabIndex = 112
        Me.UcnDspData1.Unit = "deg"
        Me.UcnDspData1.UnitVisible = False
        Me.UcnDspData1.Value = "RC20ST"
        Me.UcnDspData1.ValueType = True
        '
        'AssemblyBoltPitchSel
        '
        Me.AssemblyBoltPitchSel.DataDspWidth = 114
        Me.AssemblyBoltPitchSel.DecimalPlaces = CType(0, Short)
        Me.AssemblyBoltPitchSel.DspFieldName = True
        Me.AssemblyBoltPitchSel.FieldName = "組立ボルトピッチ"
        Me.AssemblyBoltPitchSel.Increment = 1.0!
        Me.AssemblyBoltPitchSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.AssemblyBoltPitchSel.Location = New System.Drawing.Point(23, 107)
        Me.AssemblyBoltPitchSel.MaxValue = "10"
        Me.AssemblyBoltPitchSel.MinValue = "1"
        Me.AssemblyBoltPitchSel.Name = "AssemblyBoltPitchSel"
        Me.AssemblyBoltPitchSel.SelectItem = Nothing
        Me.AssemblyBoltPitchSel.Size = New System.Drawing.Size(417, 38)
        Me.AssemblyBoltPitchSel.TabIndex = 125
        Me.AssemblyBoltPitchSel.Unit = ""
        Me.AssemblyBoltPitchSel.Value = 10.0R
        '
        'AssemblySegmentSel
        '
        Me.AssemblySegmentSel.DataDspWidth = 114
        Me.AssemblySegmentSel.DecimalPlaces = CType(3, Short)
        Me.AssemblySegmentSel.DspFieldName = True
        Me.AssemblySegmentSel.FieldName = "組立セグメント"
        Me.AssemblySegmentSel.Increment = 0.01!
        Me.AssemblySegmentSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.AssemblySegmentSel.Location = New System.Drawing.Point(23, 69)
        Me.AssemblySegmentSel.MaxValue = "10000"
        Me.AssemblySegmentSel.MinValue = "-100"
        Me.AssemblySegmentSel.Name = "AssemblySegmentSel"
        Me.AssemblySegmentSel.SelectItem = Nothing
        Me.AssemblySegmentSel.Size = New System.Drawing.Size(417, 38)
        Me.AssemblySegmentSel.TabIndex = 124
        Me.AssemblySegmentSel.Unit = ""
        Me.AssemblySegmentSel.Value = -1.0R
        '
        'ConfirmRingNo
        '
        Me.ConfirmRingNo.DataDspWidth = 114
        Me.ConfirmRingNo.DecimalPlaces = CType(0, Short)
        Me.ConfirmRingNo.DspFieldName = True
        Me.ConfirmRingNo.FieldName = "リング"
        Me.ConfirmRingNo.Increment = 1.0!
        Me.ConfirmRingNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ConfirmRingNo.Location = New System.Drawing.Point(23, 31)
        Me.ConfirmRingNo.MaxValue = "10000"
        Me.ConfirmRingNo.MinValue = "-100"
        Me.ConfirmRingNo.Name = "ConfirmRingNo"
        Me.ConfirmRingNo.SelectItem = Nothing
        Me.ConfirmRingNo.Size = New System.Drawing.Size(417, 38)
        Me.ConfirmRingNo.TabIndex = 123
        Me.ConfirmRingNo.Unit = "リング"
        Me.ConfirmRingNo.Value = 10.0R
        '
        'AssemblyPatternSel
        '
        Me.AssemblyPatternSel.DataDspWidth = 114
        Me.AssemblyPatternSel.DecimalPlaces = CType(3, Short)
        Me.AssemblyPatternSel.DspFieldName = True
        Me.AssemblyPatternSel.FieldName = "組立パターン"
        Me.AssemblyPatternSel.Increment = 0.01!
        Me.AssemblyPatternSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.AssemblyPatternSel.Location = New System.Drawing.Point(23, 145)
        Me.AssemblyPatternSel.MaxValue = "10000"
        Me.AssemblyPatternSel.MinValue = "1"
        Me.AssemblyPatternSel.Name = "AssemblyPatternSel"
        Me.AssemblyPatternSel.SelectItem = Nothing
        Me.AssemblyPatternSel.Size = New System.Drawing.Size(417, 38)
        Me.AssemblyPatternSel.TabIndex = 126
        Me.AssemblyPatternSel.Unit = ""
        Me.AssemblyPatternSel.Value = -1.0R
        '
        'LastJackNo
        '
        Me.LastJackNo.DataDspWidth = 114
        Me.LastJackNo.DecimalPlaces = CType(0, Short)
        Me.LastJackNo.DspFieldName = True
        Me.LastJackNo.FieldName = "終点ジャッキ番号"
        Me.LastJackNo.Increment = 1.0!
        Me.LastJackNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LastJackNo.Location = New System.Drawing.Point(23, 330)
        Me.LastJackNo.MaxValue = "10000"
        Me.LastJackNo.MinValue = "0"
        Me.LastJackNo.Name = "LastJackNo"
        Me.LastJackNo.SelectItem = Nothing
        Me.LastJackNo.Size = New System.Drawing.Size(417, 38)
        Me.LastJackNo.TabIndex = 130
        Me.LastJackNo.Unit = ""
        Me.LastJackNo.Value = 1.0R
        '
        'StartJackNo
        '
        Me.StartJackNo.DataDspWidth = 114
        Me.StartJackNo.DecimalPlaces = CType(0, Short)
        Me.StartJackNo.DspFieldName = True
        Me.StartJackNo.FieldName = "始点ジャッキ番号"
        Me.StartJackNo.Increment = 1.0!
        Me.StartJackNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.StartJackNo.Location = New System.Drawing.Point(23, 292)
        Me.StartJackNo.MaxValue = "10"
        Me.StartJackNo.MinValue = "0"
        Me.StartJackNo.Name = "StartJackNo"
        Me.StartJackNo.SelectItem = Nothing
        Me.StartJackNo.Size = New System.Drawing.Size(417, 38)
        Me.StartJackNo.TabIndex = 129
        Me.StartJackNo.Unit = ""
        Me.StartJackNo.Value = 10.0R
        '
        'OperattionJackSel
        '
        Me.OperattionJackSel.DataDspWidth = 114
        Me.OperattionJackSel.DecimalPlaces = CType(3, Short)
        Me.OperattionJackSel.DspFieldName = True
        Me.OperattionJackSel.FieldName = "作動ジャッキの種類"
        Me.OperattionJackSel.Increment = 0.01!
        Me.OperattionJackSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.OperattionJackSel.Location = New System.Drawing.Point(23, 254)
        Me.OperattionJackSel.MaxValue = "10000"
        Me.OperattionJackSel.MinValue = "-100"
        Me.OperattionJackSel.Name = "OperattionJackSel"
        Me.OperattionJackSel.SelectItem = Nothing
        Me.OperattionJackSel.Size = New System.Drawing.Size(417, 38)
        Me.OperattionJackSel.TabIndex = 128
        Me.OperattionJackSel.Unit = ""
        Me.OperattionJackSel.Value = -1.0R
        '
        'AssemblyPieceNo
        '
        Me.AssemblyPieceNo.DataDspWidth = 114
        Me.AssemblyPieceNo.DecimalPlaces = CType(0, Short)
        Me.AssemblyPieceNo.DspFieldName = True
        Me.AssemblyPieceNo.FieldName = "組立ピース番号"
        Me.AssemblyPieceNo.Increment = 1.0!
        Me.AssemblyPieceNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.AssemblyPieceNo.Location = New System.Drawing.Point(23, 216)
        Me.AssemblyPieceNo.MaxValue = "30"
        Me.AssemblyPieceNo.MinValue = "1"
        Me.AssemblyPieceNo.Name = "AssemblyPieceNo"
        Me.AssemblyPieceNo.SelectItem = Nothing
        Me.AssemblyPieceNo.Size = New System.Drawing.Size(417, 38)
        Me.AssemblyPieceNo.TabIndex = 127
        Me.AssemblyPieceNo.Unit = ""
        Me.AssemblyPieceNo.Value = 1.0R
        '
        'picAssemblySeg
        '
        Me.picAssemblySeg.BackColor = System.Drawing.Color.Transparent
        Me.picAssemblySeg.Location = New System.Drawing.Point(486, 254)
        Me.picAssemblySeg.Name = "picAssemblySeg"
        Me.picAssemblySeg.Size = New System.Drawing.Size(496, 496)
        Me.picAssemblySeg.TabIndex = 138
        Me.picAssemblySeg.TabStop = False
        '
        'frmAssemblyProcessEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 762)
        Me.Controls.Add(Me.picAssemblySeg)
        Me.Controls.Add(Me.LastJackNo)
        Me.Controls.Add(Me.StartJackNo)
        Me.Controls.Add(Me.OperattionJackSel)
        Me.Controls.Add(Me.AssemblyPieceNo)
        Me.Controls.Add(Me.AssemblyPatternSel)
        Me.Controls.Add(Me.AssemblyBoltPitchSel)
        Me.Controls.Add(Me.AssemblySegmentSel)
        Me.Controls.Add(Me.ConfirmRingNo)
        Me.Controls.Add(Me.DspAssemblyPattern)
        Me.Controls.Add(Me.DspNextPieceName)
        Me.Controls.Add(Me.UcnDspData24)
        Me.Controls.Add(Me.DspAddClosetThrustJack)
        Me.Controls.Add(Me.DspClosetThrustJack)
        Me.Controls.Add(Me.DspClosetJack)
        Me.Controls.Add(Me.DspPullBackJack)
        Me.Controls.Add(Me.UcnDspData17)
        Me.Controls.Add(Me.DspAssemblyPieace)
        Me.Controls.Add(Me.DspBoltPitch)
        Me.Controls.Add(Me.UcnDspData1)
        Me.Name = "frmAssemblyProcessEdit"
        Me.Text = "組立工程の編集"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData1, 0)
        Me.Controls.SetChildIndex(Me.DspBoltPitch, 0)
        Me.Controls.SetChildIndex(Me.DspAssemblyPieace, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData17, 0)
        Me.Controls.SetChildIndex(Me.DspPullBackJack, 0)
        Me.Controls.SetChildIndex(Me.DspClosetJack, 0)
        Me.Controls.SetChildIndex(Me.DspClosetThrustJack, 0)
        Me.Controls.SetChildIndex(Me.DspAddClosetThrustJack, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData24, 0)
        Me.Controls.SetChildIndex(Me.DspNextPieceName, 0)
        Me.Controls.SetChildIndex(Me.DspAssemblyPattern, 0)
        Me.Controls.SetChildIndex(Me.ConfirmRingNo, 0)
        Me.Controls.SetChildIndex(Me.AssemblySegmentSel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyBoltPitchSel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyPatternSel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyPieceNo, 0)
        Me.Controls.SetChildIndex(Me.OperattionJackSel, 0)
        Me.Controls.SetChildIndex(Me.StartJackNo, 0)
        Me.Controls.SetChildIndex(Me.LastJackNo, 0)
        Me.Controls.SetChildIndex(Me.picAssemblySeg, 0)
        CType(Me.picAssemblySeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DspAssemblyPattern As ucnDspData
    Friend WithEvents DspNextPieceName As ucnDspData
    Friend WithEvents UcnDspData24 As ucnDspData
    Friend WithEvents DspAddClosetThrustJack As ucnDspData
    Friend WithEvents DspClosetThrustJack As ucnDspData
    Friend WithEvents DspClosetJack As ucnDspData
    Friend WithEvents DspPullBackJack As ucnDspData
    Friend WithEvents UcnDspData17 As ucnDspData
    Friend WithEvents DspAssemblyPieace As ucnDspData
    Friend WithEvents DspBoltPitch As ucnDspData
    Friend WithEvents UcnDspData1 As ucnDspData
    Friend WithEvents AssemblyBoltPitchSel As ucnNumEdit
    Friend WithEvents AssemblySegmentSel As ucnNumEdit
    Friend WithEvents ConfirmRingNo As ucnNumEdit
    Friend WithEvents AssemblyPatternSel As ucnNumEdit
    Friend WithEvents LastJackNo As ucnNumEdit
    Friend WithEvents StartJackNo As ucnNumEdit
    Friend WithEvents OperattionJackSel As ucnNumEdit
    Friend WithEvents AssemblyPieceNo As ucnNumEdit
    Friend WithEvents picAssemblySeg As PictureBox
End Class
