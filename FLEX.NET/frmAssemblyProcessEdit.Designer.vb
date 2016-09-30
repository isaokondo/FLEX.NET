<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.UcnDspData21 = New FLEX.NET.ucnDspData()
        Me.UcnDspData22 = New FLEX.NET.ucnDspData()
        Me.DspClosetJack = New FLEX.NET.ucnDspData()
        Me.DspPullBackJack = New FLEX.NET.ucnDspData()
        Me.UcnDspData17 = New FLEX.NET.ucnDspData()
        Me.DspAssemblyPieace = New FLEX.NET.ucnDspData()
        Me.UcnDspData2 = New FLEX.NET.ucnDspData()
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
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(486, 66)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(505, 32)
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
        Me.DspNextPieceName.Location = New System.Drawing.Point(735, 202)
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
        Me.UcnDspData24.Location = New System.Drawing.Point(486, 202)
        Me.UcnDspData24.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData24.Name = "UcnDspData24"
        Me.UcnDspData24.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData24.TabIndex = 120
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
        Me.UcnDspData21.Location = New System.Drawing.Point(735, 168)
        Me.UcnDspData21.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData21.Name = "UcnDspData21"
        Me.UcnDspData21.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData21.TabIndex = 119
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
        Me.UcnDspData22.Location = New System.Drawing.Point(486, 168)
        Me.UcnDspData22.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData22.Name = "UcnDspData22"
        Me.UcnDspData22.Size = New System.Drawing.Size(244, 32)
        Me.UcnDspData22.TabIndex = 118
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
        Me.DspClosetJack.Location = New System.Drawing.Point(735, 133)
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
        Me.DspPullBackJack.Location = New System.Drawing.Point(486, 133)
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
        Me.UcnDspData17.Location = New System.Drawing.Point(735, 100)
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
        Me.UcnDspData2.Location = New System.Drawing.Point(735, 31)
        Me.UcnDspData2.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData2.Name = "UcnDspData2"
        Me.UcnDspData2.Size = New System.Drawing.Size(247, 32)
        Me.UcnDspData2.TabIndex = 113
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
        Me.UcnDspData1.Location = New System.Drawing.Point(486, 31)
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
        'Me.AssemblySegmentSel.Value = 1000.0R
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
        Me.AssemblyPatternSel.MinValue = "-100"
        Me.AssemblyPatternSel.Name = "AssemblyPatternSel"
        Me.AssemblyPatternSel.SelectItem = Nothing
        Me.AssemblyPatternSel.Size = New System.Drawing.Size(417, 38)
        Me.AssemblyPatternSel.TabIndex = 126
        Me.AssemblyPatternSel.Unit = ""
        'Me.AssemblyPatternSel.Value = 1000.0R
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
        'Me.OperattionJackSel.Value = 1000.0R
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
        Me.Controls.Add(Me.UcnDspData21)
        Me.Controls.Add(Me.UcnDspData22)
        Me.Controls.Add(Me.DspClosetJack)
        Me.Controls.Add(Me.DspPullBackJack)
        Me.Controls.Add(Me.UcnDspData17)
        Me.Controls.Add(Me.DspAssemblyPieace)
        Me.Controls.Add(Me.UcnDspData2)
        Me.Controls.Add(Me.UcnDspData1)
        Me.Name = "frmAssemblyProcessEdit"
        Me.Text = "組立工程の編集"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData1, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData2, 0)
        Me.Controls.SetChildIndex(Me.DspAssemblyPieace, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData17, 0)
        Me.Controls.SetChildIndex(Me.DspPullBackJack, 0)
        Me.Controls.SetChildIndex(Me.DspClosetJack, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData22, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData21, 0)
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
    Friend WithEvents UcnDspData21 As ucnDspData
    Friend WithEvents UcnDspData22 As ucnDspData
    Friend WithEvents DspClosetJack As ucnDspData
    Friend WithEvents DspPullBackJack As ucnDspData
    Friend WithEvents UcnDspData17 As ucnDspData
    Friend WithEvents DspAssemblyPieace As ucnDspData
    Friend WithEvents UcnDspData2 As ucnDspData
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
