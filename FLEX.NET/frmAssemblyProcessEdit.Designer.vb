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
        Me.AssemblyBoltPitchSel = New FLEX.NET.ucnNumEdit()
        Me.DspSegmentTypeName = New FLEX.NET.ucnNumEdit()
        Me.ConfirmRingNo = New FLEX.NET.ucnNumEdit()
        Me.AssemblyPatternSel = New FLEX.NET.ucnNumEdit()
        Me.LastJackNo = New FLEX.NET.ucnNumEdit()
        Me.StartJackNo = New FLEX.NET.ucnNumEdit()
        Me.OperattionJackSel = New FLEX.NET.ucnNumEdit()
        Me.AssemblyPieceNo = New FLEX.NET.ucnNumEdit()
        Me.picAssemblySeg = New System.Windows.Forms.PictureBox()
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
        Me.DspReduceGroup = New FLEX.NET.ucnDspData()
        Me.btnApply = New System.Windows.Forms.Button()
        CType(Me.picAssemblySeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(140, 401)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(350, 401)
        '
        'AssemblyBoltPitchSel
        '
        Me.AssemblyBoltPitchSel.DataDspWidth = 160
        Me.AssemblyBoltPitchSel.DecimalPlaces = CType(1, Short)
        Me.AssemblyBoltPitchSel.DspFieldName = True
        Me.AssemblyBoltPitchSel.FieldName = "組立ボルトピッチ"
        Me.AssemblyBoltPitchSel.Increment = 1.0!
        Me.AssemblyBoltPitchSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.AssemblyBoltPitchSel.Location = New System.Drawing.Point(26, 110)
        Me.AssemblyBoltPitchSel.Margin = New System.Windows.Forms.Padding(2)
        Me.AssemblyBoltPitchSel.MaxValue = "10"
        Me.AssemblyBoltPitchSel.MinValue = "1"
        Me.AssemblyBoltPitchSel.Name = "AssemblyBoltPitchSel"
        Me.AssemblyBoltPitchSel.SelectItem = Nothing
        Me.AssemblyBoltPitchSel.Size = New System.Drawing.Size(391, 37)
        Me.AssemblyBoltPitchSel.TabIndex = 125
        Me.AssemblyBoltPitchSel.ttMsg = ""
        Me.AssemblyBoltPitchSel.ttTile = ""
        Me.AssemblyBoltPitchSel.Unit = ""
        Me.AssemblyBoltPitchSel.Value = 10.0R
        '
        'DspSegmentTypeName
        '
        Me.DspSegmentTypeName.DataDspWidth = 160
        Me.DspSegmentTypeName.DecimalPlaces = CType(3, Short)
        Me.DspSegmentTypeName.DspFieldName = True
        Me.DspSegmentTypeName.FieldName = "組立セグメント"
        Me.DspSegmentTypeName.Increment = 0.01!
        Me.DspSegmentTypeName.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.DspSegmentTypeName.Location = New System.Drawing.Point(26, 75)
        Me.DspSegmentTypeName.Margin = New System.Windows.Forms.Padding(2)
        Me.DspSegmentTypeName.MaxValue = "10000"
        Me.DspSegmentTypeName.MinValue = "-100"
        Me.DspSegmentTypeName.Name = "DspSegmentTypeName"
        Me.DspSegmentTypeName.SelectItem = Nothing
        Me.DspSegmentTypeName.Size = New System.Drawing.Size(391, 37)
        Me.DspSegmentTypeName.TabIndex = 124
        Me.DspSegmentTypeName.ttMsg = ""
        Me.DspSegmentTypeName.ttTile = ""
        Me.DspSegmentTypeName.Unit = ""
        Me.DspSegmentTypeName.Value = -1.0R
        '
        'ConfirmRingNo
        '
        Me.ConfirmRingNo.DataDspWidth = 160
        Me.ConfirmRingNo.DecimalPlaces = CType(0, Short)
        Me.ConfirmRingNo.DspFieldName = True
        Me.ConfirmRingNo.FieldName = "リング"
        Me.ConfirmRingNo.Increment = 1.0!
        Me.ConfirmRingNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ConfirmRingNo.Location = New System.Drawing.Point(26, 33)
        Me.ConfirmRingNo.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmRingNo.MaxValue = "10000"
        Me.ConfirmRingNo.MinValue = "-100"
        Me.ConfirmRingNo.Name = "ConfirmRingNo"
        Me.ConfirmRingNo.SelectItem = Nothing
        Me.ConfirmRingNo.Size = New System.Drawing.Size(426, 37)
        Me.ConfirmRingNo.TabIndex = 123
        Me.ConfirmRingNo.ttMsg = ""
        Me.ConfirmRingNo.ttTile = ""
        Me.ConfirmRingNo.Unit = "リング"
        Me.ConfirmRingNo.Value = 10.0R
        '
        'AssemblyPatternSel
        '
        Me.AssemblyPatternSel.DataDspWidth = 160
        Me.AssemblyPatternSel.DecimalPlaces = CType(3, Short)
        Me.AssemblyPatternSel.DspFieldName = True
        Me.AssemblyPatternSel.FieldName = "組立パターン"
        Me.AssemblyPatternSel.Increment = 0.01!
        Me.AssemblyPatternSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.AssemblyPatternSel.Location = New System.Drawing.Point(26, 145)
        Me.AssemblyPatternSel.Margin = New System.Windows.Forms.Padding(2)
        Me.AssemblyPatternSel.MaxValue = "10000"
        Me.AssemblyPatternSel.MinValue = "1"
        Me.AssemblyPatternSel.Name = "AssemblyPatternSel"
        Me.AssemblyPatternSel.SelectItem = Nothing
        Me.AssemblyPatternSel.Size = New System.Drawing.Size(391, 37)
        Me.AssemblyPatternSel.TabIndex = 126
        Me.AssemblyPatternSel.ttMsg = ""
        Me.AssemblyPatternSel.ttTile = ""
        Me.AssemblyPatternSel.Unit = ""
        Me.AssemblyPatternSel.Value = -1.0R
        '
        'LastJackNo
        '
        Me.LastJackNo.DataDspWidth = 160
        Me.LastJackNo.DecimalPlaces = CType(0, Short)
        Me.LastJackNo.DspFieldName = True
        Me.LastJackNo.FieldName = "終点ジャッキ番号"
        Me.LastJackNo.Increment = 1.0!
        Me.LastJackNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LastJackNo.Location = New System.Drawing.Point(21, 330)
        Me.LastJackNo.Margin = New System.Windows.Forms.Padding(2)
        Me.LastJackNo.MaxValue = "10000"
        Me.LastJackNo.MinValue = "0"
        Me.LastJackNo.Name = "LastJackNo"
        Me.LastJackNo.SelectItem = Nothing
        Me.LastJackNo.Size = New System.Drawing.Size(391, 37)
        Me.LastJackNo.TabIndex = 130
        Me.LastJackNo.Tag = "s"
        Me.LastJackNo.ttMsg = ""
        Me.LastJackNo.ttTile = ""
        Me.LastJackNo.Unit = ""
        Me.LastJackNo.Value = 1.0R
        '
        'StartJackNo
        '
        Me.StartJackNo.DataDspWidth = 160
        Me.StartJackNo.DecimalPlaces = CType(0, Short)
        Me.StartJackNo.DspFieldName = True
        Me.StartJackNo.FieldName = "始点ジャッキ番号"
        Me.StartJackNo.Increment = 1.0!
        Me.StartJackNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.StartJackNo.Location = New System.Drawing.Point(21, 291)
        Me.StartJackNo.Margin = New System.Windows.Forms.Padding(2)
        Me.StartJackNo.MaxValue = "10"
        Me.StartJackNo.MinValue = "0"
        Me.StartJackNo.Name = "StartJackNo"
        Me.StartJackNo.SelectItem = Nothing
        Me.StartJackNo.Size = New System.Drawing.Size(391, 37)
        Me.StartJackNo.TabIndex = 129
        Me.StartJackNo.ttMsg = ""
        Me.StartJackNo.ttTile = ""
        Me.StartJackNo.Unit = ""
        Me.StartJackNo.Value = 10.0R
        '
        'OperattionJackSel
        '
        Me.OperattionJackSel.DataDspWidth = 160
        Me.OperattionJackSel.DecimalPlaces = CType(3, Short)
        Me.OperattionJackSel.DspFieldName = True
        Me.OperattionJackSel.FieldName = "作動ジャッキの種類"
        Me.OperattionJackSel.Increment = 0.01!
        Me.OperattionJackSel.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.OperattionJackSel.Location = New System.Drawing.Point(21, 253)
        Me.OperattionJackSel.Margin = New System.Windows.Forms.Padding(2)
        Me.OperattionJackSel.MaxValue = "10000"
        Me.OperattionJackSel.MinValue = "-100"
        Me.OperattionJackSel.Name = "OperattionJackSel"
        Me.OperattionJackSel.SelectItem = Nothing
        Me.OperattionJackSel.Size = New System.Drawing.Size(391, 37)
        Me.OperattionJackSel.TabIndex = 128
        Me.OperattionJackSel.ttMsg = ""
        Me.OperattionJackSel.ttTile = ""
        Me.OperattionJackSel.Unit = ""
        Me.OperattionJackSel.Value = -1.0R
        '
        'AssemblyPieceNo
        '
        Me.AssemblyPieceNo.DataDspWidth = 160
        Me.AssemblyPieceNo.DecimalPlaces = CType(0, Short)
        Me.AssemblyPieceNo.DspFieldName = True
        Me.AssemblyPieceNo.FieldName = "組立ピース番号"
        Me.AssemblyPieceNo.Increment = 1.0!
        Me.AssemblyPieceNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.AssemblyPieceNo.Location = New System.Drawing.Point(21, 216)
        Me.AssemblyPieceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.AssemblyPieceNo.MaxValue = "30"
        Me.AssemblyPieceNo.MinValue = "1"
        Me.AssemblyPieceNo.Name = "AssemblyPieceNo"
        Me.AssemblyPieceNo.SelectItem = Nothing
        Me.AssemblyPieceNo.Size = New System.Drawing.Size(391, 37)
        Me.AssemblyPieceNo.TabIndex = 127
        Me.AssemblyPieceNo.ttMsg = ""
        Me.AssemblyPieceNo.ttTile = ""
        Me.AssemblyPieceNo.Unit = ""
        Me.AssemblyPieceNo.Value = 1.0R
        '
        'picAssemblySeg
        '
        Me.picAssemblySeg.BackColor = System.Drawing.Color.Transparent
        Me.picAssemblySeg.Location = New System.Drawing.Point(504, 271)
        Me.picAssemblySeg.Margin = New System.Windows.Forms.Padding(2)
        Me.picAssemblySeg.Name = "picAssemblySeg"
        Me.picAssemblySeg.Size = New System.Drawing.Size(465, 496)
        Me.picAssemblySeg.TabIndex = 138
        Me.picAssemblySeg.TabStop = False
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
        Me.UcnDspData24.Location = New System.Drawing.Point(740, 192)
        Me.UcnDspData24.Margin = New System.Windows.Forms.Padding(1)
        Me.UcnDspData24.Name = "UcnDspData24"
        Me.UcnDspData24.Size = New System.Drawing.Size(243, 32)
        Me.UcnDspData24.TabIndex = 146
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
        Me.DspClosetJack.Location = New System.Drawing.Point(739, 128)
        Me.DspClosetJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetJack.Name = "DspClosetJack"
        Me.DspClosetJack.Size = New System.Drawing.Size(243, 32)
        Me.DspClosetJack.TabIndex = 143
        Me.DspClosetJack.Unit = "deg"
        Me.DspClosetJack.UnitVisible = False
        Me.DspClosetJack.Value = "20"
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
        Me.DspBoltPitch.Location = New System.Drawing.Point(505, 193)
        Me.DspBoltPitch.Margin = New System.Windows.Forms.Padding(1)
        Me.DspBoltPitch.Name = "DspBoltPitch"
        Me.DspBoltPitch.Size = New System.Drawing.Size(242, 32)
        Me.DspBoltPitch.TabIndex = 140
        Me.DspBoltPitch.Unit = "deg"
        Me.DspBoltPitch.UnitVisible = False
        Me.DspBoltPitch.Value = "3"
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
        Me.DspAssemblyPattern.Location = New System.Drawing.Point(505, 65)
        Me.DspAssemblyPattern.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPattern.Name = "DspAssemblyPattern"
        Me.DspAssemblyPattern.Size = New System.Drawing.Size(472, 32)
        Me.DspAssemblyPattern.TabIndex = 148
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
        Me.DspNextPieceName.FieldName = "次の組立ピース"
        Me.DspNextPieceName.FieldNameWidth = 146
        Me.DspNextPieceName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspNextPieceName.Location = New System.Drawing.Point(740, 96)
        Me.DspNextPieceName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspNextPieceName.Name = "DspNextPieceName"
        Me.DspNextPieceName.Size = New System.Drawing.Size(243, 32)
        Me.DspNextPieceName.TabIndex = 147
        Me.DspNextPieceName.Unit = "deg"
        Me.DspNextPieceName.UnitVisible = False
        Me.DspNextPieceName.Value = "A1-3"
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
        Me.DspAddClosetThrustJack.Location = New System.Drawing.Point(739, 160)
        Me.DspAddClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAddClosetThrustJack.Name = "DspAddClosetThrustJack"
        Me.DspAddClosetThrustJack.Size = New System.Drawing.Size(243, 32)
        Me.DspAddClosetThrustJack.TabIndex = 145
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
        Me.DspClosetThrustJack.Location = New System.Drawing.Point(505, 161)
        Me.DspClosetThrustJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspClosetThrustJack.Name = "DspClosetThrustJack"
        Me.DspClosetThrustJack.Size = New System.Drawing.Size(243, 32)
        Me.DspClosetThrustJack.TabIndex = 144
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
        Me.DspPullBackJack.Location = New System.Drawing.Point(505, 129)
        Me.DspPullBackJack.Margin = New System.Windows.Forms.Padding(1)
        Me.DspPullBackJack.Name = "DspPullBackJack"
        Me.DspPullBackJack.Size = New System.Drawing.Size(243, 32)
        Me.DspPullBackJack.TabIndex = 142
        Me.DspPullBackJack.Unit = "deg"
        Me.DspPullBackJack.UnitVisible = False
        Me.DspPullBackJack.Value = "19-23"
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
        Me.DspAssemblyPieace.Location = New System.Drawing.Point(505, 97)
        Me.DspAssemblyPieace.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAssemblyPieace.Name = "DspAssemblyPieace"
        Me.DspAssemblyPieace.Size = New System.Drawing.Size(243, 32)
        Me.DspAssemblyPieace.TabIndex = 141
        Me.DspAssemblyPieace.Unit = "deg"
        Me.DspAssemblyPieace.UnitVisible = False
        Me.DspAssemblyPieace.Value = "A2-1"
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
        Me.DspTypeName.Location = New System.Drawing.Point(505, 33)
        Me.DspTypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTypeName.Name = "DspTypeName"
        Me.DspTypeName.Size = New System.Drawing.Size(475, 32)
        Me.DspTypeName.TabIndex = 139
        Me.DspTypeName.Unit = "deg"
        Me.DspTypeName.UnitVisible = False
        Me.DspTypeName.Value = "RC20ST"
        Me.DspTypeName.ValueType = True
        '
        'DspReduceGroup
        '
        Me.DspReduceGroup.BackColor = System.Drawing.Color.Transparent
        Me.DspReduceGroup.Blink = False
        Me.DspReduceGroup.BlinkColor = System.Drawing.Color.Red
        Me.DspReduceGroup.DataTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DspReduceGroup.DataWidth = 91
        Me.DspReduceGroup.DecimalPlaces = CType(2, Short)
        Me.DspReduceGroup.FieldName = "減圧ｸﾞﾙｰﾌﾟ"
        Me.DspReduceGroup.FieldNameWidth = 146
        Me.DspReduceGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspReduceGroup.Location = New System.Drawing.Point(504, 226)
        Me.DspReduceGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.DspReduceGroup.Name = "DspReduceGroup"
        Me.DspReduceGroup.Size = New System.Drawing.Size(243, 32)
        Me.DspReduceGroup.TabIndex = 149
        Me.DspReduceGroup.Unit = "deg"
        Me.DspReduceGroup.UnitVisible = False
        Me.DspReduceGroup.Value = "19-23"
        Me.DspReduceGroup.ValueType = True
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Silver
        Me.btnApply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnApply.Location = New System.Drawing.Point(246, 401)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(102, 35)
        Me.btnApply.TabIndex = 150
        Me.btnApply.Text = "適用"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'frmAssemblyProcessEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 769)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.DspReduceGroup)
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
        Me.Controls.Add(Me.picAssemblySeg)
        Me.Controls.Add(Me.LastJackNo)
        Me.Controls.Add(Me.StartJackNo)
        Me.Controls.Add(Me.OperattionJackSel)
        Me.Controls.Add(Me.AssemblyPieceNo)
        Me.Controls.Add(Me.AssemblyPatternSel)
        Me.Controls.Add(Me.AssemblyBoltPitchSel)
        Me.Controls.Add(Me.DspSegmentTypeName)
        Me.Controls.Add(Me.ConfirmRingNo)
        Me.Name = "frmAssemblyProcessEdit"
        Me.Text = "組立工程の編集"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.ConfirmRingNo, 0)
        Me.Controls.SetChildIndex(Me.DspSegmentTypeName, 0)
        Me.Controls.SetChildIndex(Me.AssemblyBoltPitchSel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyPatternSel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyPieceNo, 0)
        Me.Controls.SetChildIndex(Me.OperattionJackSel, 0)
        Me.Controls.SetChildIndex(Me.StartJackNo, 0)
        Me.Controls.SetChildIndex(Me.LastJackNo, 0)
        Me.Controls.SetChildIndex(Me.picAssemblySeg, 0)
        Me.Controls.SetChildIndex(Me.DspTypeName, 0)
        Me.Controls.SetChildIndex(Me.DspAssemblyPieace, 0)
        Me.Controls.SetChildIndex(Me.DspPullBackJack, 0)
        Me.Controls.SetChildIndex(Me.DspClosetThrustJack, 0)
        Me.Controls.SetChildIndex(Me.DspAddClosetThrustJack, 0)
        Me.Controls.SetChildIndex(Me.DspNextPieceName, 0)
        Me.Controls.SetChildIndex(Me.DspAssemblyPattern, 0)
        Me.Controls.SetChildIndex(Me.DspBoltPitch, 0)
        Me.Controls.SetChildIndex(Me.DspClosetJack, 0)
        Me.Controls.SetChildIndex(Me.UcnDspData24, 0)
        Me.Controls.SetChildIndex(Me.DspReduceGroup, 0)
        Me.Controls.SetChildIndex(Me.btnApply, 0)
        CType(Me.picAssemblySeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AssemblyBoltPitchSel As ucnNumEdit
    Friend WithEvents DspSegmentTypeName As ucnNumEdit
    Friend WithEvents ConfirmRingNo As ucnNumEdit
    Friend WithEvents AssemblyPatternSel As ucnNumEdit
    Friend WithEvents LastJackNo As ucnNumEdit
    Friend WithEvents StartJackNo As ucnNumEdit
    Friend WithEvents OperattionJackSel As ucnNumEdit
    Friend WithEvents AssemblyPieceNo As ucnNumEdit
    Friend WithEvents picAssemblySeg As PictureBox
    Friend WithEvents UcnDspData24 As ucnDspData
    Friend WithEvents DspClosetJack As ucnDspData
    Friend WithEvents DspBoltPitch As ucnDspData
    Friend WithEvents DspAssemblyPattern As ucnDspData
    Friend WithEvents DspNextPieceName As ucnDspData
    Friend WithEvents DspAddClosetThrustJack As ucnDspData
    Friend WithEvents DspClosetThrustJack As ucnDspData
    Friend WithEvents DspPullBackJack As ucnDspData
    Friend WithEvents DspAssemblyPieace As ucnDspData
    Friend WithEvents DspTypeName As ucnDspData
    Friend WithEvents DspReduceGroup As ucnDspData
    Protected WithEvents btnApply As Button
End Class
