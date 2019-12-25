<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalcStrokeConfirm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.DgvJackStroke = New System.Windows.Forms.DataGridView()
        Me.JackNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealStrokeLen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalcStrokeLen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalcLogcalStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JackSpeed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegmentWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JackState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JackEnable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DspAveStroke = New FLEX.NET.ucnDspData()
        Me.DspCenterWidth = New FLEX.NET.ucnDspData()
        Me.DspTaperValue = New FLEX.NET.ucnDspData()
        Me.DspMaxTaperLoc = New FLEX.NET.ucnDspData()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DspAveLogocalStroke = New FLEX.NET.ucnDspData()
        Me.DspAveSpeed = New FLEX.NET.ucnDspData()
        Me.OpposeJackExcep = New FLEX.NET.ucnRdBtn()
        Me.DspHorTargerStrokeDev = New FLEX.NET.ucnDspData()
        Me.DspHorTargerNowStrokeDev = New FLEX.NET.ucnDspData()
        Me.lblTopRightStartSt = New System.Windows.Forms.Label()
        Me.lblTopLeftStartSt = New System.Windows.Forms.Label()
        Me.lblTopRightRealSt = New System.Windows.Forms.Label()
        Me.lblTopLeftRealSt = New System.Windows.Forms.Label()
        Me.lblTopNetSt = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTopStItem = New System.Windows.Forms.Label()
        Me.lblTopRightStNo = New System.Windows.Forms.Label()
        Me.lblTopLefttStNo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTopRingTargetSt = New System.Windows.Forms.Label()
        Me.lblHorRightStartSt = New System.Windows.Forms.Label()
        Me.lblHorLeftStartSt = New System.Windows.Forms.Label()
        Me.lblHorRightRealSt = New System.Windows.Forms.Label()
        Me.lblHorLeftRealSt = New System.Windows.Forms.Label()
        Me.lblHorNetSt = New System.Windows.Forms.Label()
        Me.lblHorStItem = New System.Windows.Forms.Label()
        Me.lblHorRightStNo = New System.Windows.Forms.Label()
        Me.lblHorLefttStNo = New System.Windows.Forms.Label()
        Me.lblHorRingTargetSt = New System.Windows.Forms.Label()
        Me.lblBtmRightStartSt = New System.Windows.Forms.Label()
        Me.lblBtmLeftStartSt = New System.Windows.Forms.Label()
        Me.lblBtmRightRealSt = New System.Windows.Forms.Label()
        Me.lblBtmLeftRealSt = New System.Windows.Forms.Label()
        Me.lblBtmNetSt = New System.Windows.Forms.Label()
        Me.lblBtmStItem = New System.Windows.Forms.Label()
        Me.lblBtmRightStNo = New System.Windows.Forms.Label()
        Me.lblBtmLeftStNo = New System.Windows.Forms.Label()
        Me.lblBtmRingTargetSt = New System.Windows.Forms.Label()
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
        Me.DspRingUpStroke = New FLEX.NET.ucnDspData()
        Me.DspTaperCorRate = New FLEX.NET.ucnDspData()
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStrokeDiffContorol.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(537, 769)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(663, 769)
        Me.btnCancel.Visible = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'DgvJackStroke
        '
        Me.DgvJackStroke.AllowUserToAddRows = False
        Me.DgvJackStroke.AllowUserToDeleteRows = False
        Me.DgvJackStroke.AllowUserToResizeColumns = False
        Me.DgvJackStroke.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvJackStroke.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvJackStroke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvJackStroke.ColumnHeadersHeight = 40
        Me.DgvJackStroke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvJackStroke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JackNo, Me.RealStrokeLen, Me.CalcStrokeLen, Me.CalcLogcalStroke, Me.StartStroke, Me.JackSpeed, Me.Angle, Me.SegmentWidth, Me.JackState, Me.JackEnable})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJackStroke.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgvJackStroke.Location = New System.Drawing.Point(11, 252)
        Me.DgvJackStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvJackStroke.MultiSelect = False
        Me.DgvJackStroke.Name = "DgvJackStroke"
        Me.DgvJackStroke.ReadOnly = True
        Me.DgvJackStroke.RowHeadersVisible = False
        Me.DgvJackStroke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvJackStroke.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvJackStroke.RowTemplate.Height = 24
        Me.DgvJackStroke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvJackStroke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvJackStroke.Size = New System.Drawing.Size(895, 249)
        Me.DgvJackStroke.TabIndex = 18
        '
        'JackNo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.JackNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.JackNo.DividerWidth = 1
        Me.JackNo.Frozen = True
        Me.JackNo.HeaderText = "No"
        Me.JackNo.Name = "JackNo"
        Me.JackNo.ReadOnly = True
        Me.JackNo.Width = 30
        '
        'RealStrokeLen
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.NullValue = "0"
        Me.RealStrokeLen.DefaultCellStyle = DataGridViewCellStyle4
        Me.RealStrokeLen.Frozen = True
        Me.RealStrokeLen.HeaderText = "読ストローク"
        Me.RealStrokeLen.Name = "RealStrokeLen"
        Me.RealStrokeLen.ReadOnly = True
        Me.RealStrokeLen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RealStrokeLen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CalcStrokeLen
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CalcStrokeLen.DefaultCellStyle = DataGridViewCellStyle5
        Me.CalcStrokeLen.Frozen = True
        Me.CalcStrokeLen.HeaderText = "実ストローク"
        Me.CalcStrokeLen.Name = "CalcStrokeLen"
        Me.CalcStrokeLen.ReadOnly = True
        Me.CalcStrokeLen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CalcStrokeLen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CalcLogcalStroke
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CalcLogcalStroke.DefaultCellStyle = DataGridViewCellStyle6
        Me.CalcLogcalStroke.Frozen = True
        Me.CalcLogcalStroke.HeaderText = "推進量"
        Me.CalcLogcalStroke.Name = "CalcLogcalStroke"
        Me.CalcLogcalStroke.ReadOnly = True
        Me.CalcLogcalStroke.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CalcLogcalStroke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'StartStroke
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StartStroke.DefaultCellStyle = DataGridViewCellStyle7
        Me.StartStroke.Frozen = True
        Me.StartStroke.HeaderText = "開始ストローク"
        Me.StartStroke.Name = "StartStroke"
        Me.StartStroke.ReadOnly = True
        Me.StartStroke.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StartStroke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JackSpeed
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.JackSpeed.DefaultCellStyle = DataGridViewCellStyle8
        Me.JackSpeed.Frozen = True
        Me.JackSpeed.HeaderText = "速度(mm/min)"
        Me.JackSpeed.Name = "JackSpeed"
        Me.JackSpeed.ReadOnly = True
        Me.JackSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JackSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Angle
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Angle.DefaultCellStyle = DataGridViewCellStyle9
        Me.Angle.Frozen = True
        Me.Angle.HeaderText = "取付角度(deg)"
        Me.Angle.Name = "Angle"
        Me.Angle.ReadOnly = True
        Me.Angle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SegmentWidth
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.NullValue = Nothing
        Me.SegmentWidth.DefaultCellStyle = DataGridViewCellStyle10
        Me.SegmentWidth.Frozen = True
        Me.SegmentWidth.HeaderText = "セグメント幅(mm)"
        Me.SegmentWidth.Name = "SegmentWidth"
        Me.SegmentWidth.ReadOnly = True
        Me.SegmentWidth.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'JackState
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle11.NullValue = Nothing
        Me.JackState.DefaultCellStyle = DataGridViewCellStyle11
        Me.JackState.Frozen = True
        Me.JackState.HeaderText = "状態"
        Me.JackState.Name = "JackState"
        Me.JackState.ReadOnly = True
        Me.JackState.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JackState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JackEnable
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle12.NullValue = False
        Me.JackEnable.DefaultCellStyle = DataGridViewCellStyle12
        Me.JackEnable.HeaderText = "有効"
        Me.JackEnable.Name = "JackEnable"
        Me.JackEnable.ReadOnly = True
        Me.JackEnable.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JackEnable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.JackEnable.Width = 60
        '
        'DspAveStroke
        '
        Me.DspAveStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveStroke.Blink = False
        Me.DspAveStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveStroke.DataWidth = 80
        Me.DspAveStroke.DecimalPlaces = CType(1, Short)
        Me.DspAveStroke.FieldName = "平均ストローク"
        Me.DspAveStroke.FieldNameWidth = 160
        Me.DspAveStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveStroke.Location = New System.Drawing.Point(38, 13)
        Me.DspAveStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveStroke.Name = "DspAveStroke"
        Me.DspAveStroke.Size = New System.Drawing.Size(329, 32)
        Me.DspAveStroke.TabIndex = 41
        Me.DspAveStroke.Unit = "mm"
        Me.DspAveStroke.UnitVisible = True
        Me.DspAveStroke.Value = "123.45 "
        Me.DspAveStroke.ValueType = False
        '
        'DspCenterWidth
        '
        Me.DspCenterWidth.BackColor = System.Drawing.Color.Transparent
        Me.DspCenterWidth.Blink = False
        Me.DspCenterWidth.BlinkColor = System.Drawing.Color.Red
        Me.DspCenterWidth.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspCenterWidth.DataWidth = 80
        Me.DspCenterWidth.DecimalPlaces = CType(0, Short)
        Me.DspCenterWidth.FieldName = "中心幅"
        Me.DspCenterWidth.FieldNameWidth = 160
        Me.DspCenterWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspCenterWidth.Location = New System.Drawing.Point(38, 114)
        Me.DspCenterWidth.Margin = New System.Windows.Forms.Padding(1)
        Me.DspCenterWidth.Name = "DspCenterWidth"
        Me.DspCenterWidth.Size = New System.Drawing.Size(343, 32)
        Me.DspCenterWidth.TabIndex = 42
        Me.DspCenterWidth.Unit = "mm"
        Me.DspCenterWidth.UnitVisible = True
        Me.DspCenterWidth.Value = "123.45 "
        Me.DspCenterWidth.ValueType = False
        '
        'DspTaperValue
        '
        Me.DspTaperValue.BackColor = System.Drawing.Color.Transparent
        Me.DspTaperValue.Blink = False
        Me.DspTaperValue.BlinkColor = System.Drawing.Color.Red
        Me.DspTaperValue.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTaperValue.DataWidth = 80
        Me.DspTaperValue.DecimalPlaces = CType(0, Short)
        Me.DspTaperValue.FieldName = "最大テーパー量"
        Me.DspTaperValue.FieldNameWidth = 160
        Me.DspTaperValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTaperValue.Location = New System.Drawing.Point(38, 148)
        Me.DspTaperValue.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTaperValue.Name = "DspTaperValue"
        Me.DspTaperValue.Size = New System.Drawing.Size(343, 32)
        Me.DspTaperValue.TabIndex = 43
        Me.DspTaperValue.Unit = "mm"
        Me.DspTaperValue.UnitVisible = True
        Me.DspTaperValue.Value = "123.45 "
        Me.DspTaperValue.ValueType = False
        '
        'DspMaxTaperLoc
        '
        Me.DspMaxTaperLoc.BackColor = System.Drawing.Color.Transparent
        Me.DspMaxTaperLoc.Blink = False
        Me.DspMaxTaperLoc.BlinkColor = System.Drawing.Color.Red
        Me.DspMaxTaperLoc.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspMaxTaperLoc.DataWidth = 80
        Me.DspMaxTaperLoc.DecimalPlaces = CType(1, Short)
        Me.DspMaxTaperLoc.FieldName = "最大テーパー位置"
        Me.DspMaxTaperLoc.FieldNameWidth = 160
        Me.DspMaxTaperLoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspMaxTaperLoc.Location = New System.Drawing.Point(38, 182)
        Me.DspMaxTaperLoc.Margin = New System.Windows.Forms.Padding(1)
        Me.DspMaxTaperLoc.Name = "DspMaxTaperLoc"
        Me.DspMaxTaperLoc.Size = New System.Drawing.Size(343, 32)
        Me.DspMaxTaperLoc.TabIndex = 44
        Me.DspMaxTaperLoc.Unit = "deg"
        Me.DspMaxTaperLoc.UnitVisible = True
        Me.DspMaxTaperLoc.Value = "123.45 "
        Me.DspMaxTaperLoc.ValueType = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(24, 108)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(359, 115)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(944, 811)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "セグメント"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DspAveLogocalStroke
        '
        Me.DspAveLogocalStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspAveLogocalStroke.Blink = False
        Me.DspAveLogocalStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspAveLogocalStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveLogocalStroke.DataWidth = 80
        Me.DspAveLogocalStroke.DecimalPlaces = CType(1, Short)
        Me.DspAveLogocalStroke.FieldName = "平均推進量"
        Me.DspAveLogocalStroke.FieldNameWidth = 160
        Me.DspAveLogocalStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveLogocalStroke.Location = New System.Drawing.Point(406, 13)
        Me.DspAveLogocalStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveLogocalStroke.Name = "DspAveLogocalStroke"
        Me.DspAveLogocalStroke.Size = New System.Drawing.Size(329, 32)
        Me.DspAveLogocalStroke.TabIndex = 136
        Me.DspAveLogocalStroke.Unit = "mm"
        Me.DspAveLogocalStroke.UnitVisible = True
        Me.DspAveLogocalStroke.Value = "123.45 "
        Me.DspAveLogocalStroke.ValueType = False
        '
        'DspAveSpeed
        '
        Me.DspAveSpeed.BackColor = System.Drawing.Color.Transparent
        Me.DspAveSpeed.Blink = False
        Me.DspAveSpeed.BlinkColor = System.Drawing.Color.Red
        Me.DspAveSpeed.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspAveSpeed.DataWidth = 80
        Me.DspAveSpeed.DecimalPlaces = CType(0, Short)
        Me.DspAveSpeed.FieldName = "平均スピード"
        Me.DspAveSpeed.FieldNameWidth = 160
        Me.DspAveSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspAveSpeed.Location = New System.Drawing.Point(38, 53)
        Me.DspAveSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.DspAveSpeed.Name = "DspAveSpeed"
        Me.DspAveSpeed.Size = New System.Drawing.Size(343, 32)
        Me.DspAveSpeed.TabIndex = 137
        Me.DspAveSpeed.Unit = "mm/min"
        Me.DspAveSpeed.UnitVisible = True
        Me.DspAveSpeed.Value = "123.45 "
        Me.DspAveSpeed.ValueType = False
        '
        'OpposeJackExcep
        '
        Me.OpposeJackExcep.BackColor = System.Drawing.Color.Transparent
        Me.OpposeJackExcep.FieldName = "対抗ｼﾞｬｯｷのｽﾄﾛｰｸ除外"
        Me.OpposeJackExcep.Location = New System.Drawing.Point(406, 53)
        Me.OpposeJackExcep.Margin = New System.Windows.Forms.Padding(2)
        Me.OpposeJackExcep.Name = "OpposeJackExcep"
        Me.OpposeJackExcep.rdbtnValue = False
        Me.OpposeJackExcep.Selectable = True
        Me.OpposeJackExcep.Size = New System.Drawing.Size(422, 34)
        Me.OpposeJackExcep.SlectNoName = "する"
        Me.OpposeJackExcep.SlectYesName = "しない"
        Me.OpposeJackExcep.TabIndex = 138
        '
        'DspHorTargerStrokeDev
        '
        Me.DspHorTargerStrokeDev.BackColor = System.Drawing.Color.Transparent
        Me.DspHorTargerStrokeDev.Blink = False
        Me.DspHorTargerStrokeDev.BlinkColor = System.Drawing.Color.Red
        Me.DspHorTargerStrokeDev.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorTargerStrokeDev.DataWidth = 80
        Me.DspHorTargerStrokeDev.DecimalPlaces = CType(2, Short)
        Me.DspHorTargerStrokeDev.FieldName = "リング目標ストローク差"
        Me.DspHorTargerStrokeDev.FieldNameWidth = 160
        Me.DspHorTargerStrokeDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorTargerStrokeDev.Location = New System.Drawing.Point(24, 505)
        Me.DspHorTargerStrokeDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorTargerStrokeDev.Name = "DspHorTargerStrokeDev"
        Me.DspHorTargerStrokeDev.Size = New System.Drawing.Size(318, 32)
        Me.DspHorTargerStrokeDev.TabIndex = 139
        Me.DspHorTargerStrokeDev.Unit = "mm"
        Me.DspHorTargerStrokeDev.UnitVisible = True
        Me.DspHorTargerStrokeDev.Value = "123.45 "
        Me.DspHorTargerStrokeDev.ValueType = False
        '
        'DspHorTargerNowStrokeDev
        '
        Me.DspHorTargerNowStrokeDev.BackColor = System.Drawing.Color.Transparent
        Me.DspHorTargerNowStrokeDev.Blink = False
        Me.DspHorTargerNowStrokeDev.BlinkColor = System.Drawing.Color.Red
        Me.DspHorTargerNowStrokeDev.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspHorTargerNowStrokeDev.DataWidth = 80
        Me.DspHorTargerNowStrokeDev.DecimalPlaces = CType(2, Short)
        Me.DspHorTargerNowStrokeDev.FieldName = "現在目標ストローク差"
        Me.DspHorTargerNowStrokeDev.FieldNameWidth = 160
        Me.DspHorTargerNowStrokeDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspHorTargerNowStrokeDev.Location = New System.Drawing.Point(24, 539)
        Me.DspHorTargerNowStrokeDev.Margin = New System.Windows.Forms.Padding(1)
        Me.DspHorTargerNowStrokeDev.Name = "DspHorTargerNowStrokeDev"
        Me.DspHorTargerNowStrokeDev.Size = New System.Drawing.Size(318, 32)
        Me.DspHorTargerNowStrokeDev.TabIndex = 140
        Me.DspHorTargerNowStrokeDev.Unit = "mm"
        Me.DspHorTargerNowStrokeDev.UnitVisible = True
        Me.DspHorTargerNowStrokeDev.Value = "0"
        Me.DspHorTargerNowStrokeDev.ValueType = False
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
        Me.pnlStrokeDiffContorol.Location = New System.Drawing.Point(346, 504)
        Me.pnlStrokeDiffContorol.Name = "pnlStrokeDiffContorol"
        Me.pnlStrokeDiffContorol.Size = New System.Drawing.Size(432, 229)
        Me.pnlStrokeDiffContorol.TabIndex = 175
        Me.pnlStrokeDiffContorol.Visible = False
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
        'DspRingUpStroke
        '
        Me.DspRingUpStroke.BackColor = System.Drawing.Color.Transparent
        Me.DspRingUpStroke.Blink = False
        Me.DspRingUpStroke.BlinkColor = System.Drawing.Color.Red
        Me.DspRingUpStroke.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspRingUpStroke.DataWidth = 60
        Me.DspRingUpStroke.DecimalPlaces = CType(0, Short)
        Me.DspRingUpStroke.FieldName = "リング内発生ストローク量"
        Me.DspRingUpStroke.FieldNameWidth = 180
        Me.DspRingUpStroke.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspRingUpStroke.Location = New System.Drawing.Point(24, 573)
        Me.DspRingUpStroke.Margin = New System.Windows.Forms.Padding(1)
        Me.DspRingUpStroke.Name = "DspRingUpStroke"
        Me.DspRingUpStroke.Size = New System.Drawing.Size(318, 32)
        Me.DspRingUpStroke.TabIndex = 209
        Me.DspRingUpStroke.Unit = "mm"
        Me.DspRingUpStroke.UnitVisible = True
        Me.DspRingUpStroke.Value = "184"
        Me.DspRingUpStroke.ValueType = False
        '
        'DspTaperCorRate
        '
        Me.DspTaperCorRate.BackColor = System.Drawing.Color.Transparent
        Me.DspTaperCorRate.Blink = False
        Me.DspTaperCorRate.BlinkColor = System.Drawing.Color.Red
        Me.DspTaperCorRate.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspTaperCorRate.DataWidth = 80
        Me.DspTaperCorRate.DecimalPlaces = CType(0, Short)
        Me.DspTaperCorRate.FieldName = "ストローク加算時のテーパー量の補正率(%)"
        Me.DspTaperCorRate.FieldNameWidth = 270
        Me.DspTaperCorRate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspTaperCorRate.Location = New System.Drawing.Point(406, 182)
        Me.DspTaperCorRate.Margin = New System.Windows.Forms.Padding(1)
        Me.DspTaperCorRate.Name = "DspTaperCorRate"
        Me.DspTaperCorRate.Size = New System.Drawing.Size(434, 32)
        Me.DspTaperCorRate.TabIndex = 210
        Me.DspTaperCorRate.Unit = "％"
        Me.DspTaperCorRate.UnitVisible = True
        Me.DspTaperCorRate.Value = "100"
        Me.DspTaperCorRate.ValueType = False
        '
        'frmCalcStrokeConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 811)
        Me.Controls.Add(Me.DspTaperCorRate)
        Me.Controls.Add(Me.DspRingUpStroke)
        Me.Controls.Add(Me.pnlStrokeDiffContorol)
        Me.Controls.Add(Me.DspHorTargerNowStrokeDev)
        Me.Controls.Add(Me.DspHorTargerStrokeDev)
        Me.Controls.Add(Me.OpposeJackExcep)
        Me.Controls.Add(Me.DspAveSpeed)
        Me.Controls.Add(Me.DspAveLogocalStroke)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DspMaxTaperLoc)
        Me.Controls.Add(Me.DspTaperValue)
        Me.Controls.Add(Me.DspCenterWidth)
        Me.Controls.Add(Me.DspAveStroke)
        Me.Controls.Add(Me.DgvJackStroke)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmCalcStrokeConfirm"
        Me.Text = "計算ストローク　モニタ"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.DgvJackStroke, 0)
        Me.Controls.SetChildIndex(Me.DspAveStroke, 0)
        Me.Controls.SetChildIndex(Me.DspCenterWidth, 0)
        Me.Controls.SetChildIndex(Me.DspTaperValue, 0)
        Me.Controls.SetChildIndex(Me.DspMaxTaperLoc, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.DspAveLogocalStroke, 0)
        Me.Controls.SetChildIndex(Me.DspAveSpeed, 0)
        Me.Controls.SetChildIndex(Me.OpposeJackExcep, 0)
        Me.Controls.SetChildIndex(Me.DspHorTargerStrokeDev, 0)
        Me.Controls.SetChildIndex(Me.DspHorTargerNowStrokeDev, 0)
        Me.Controls.SetChildIndex(Me.pnlStrokeDiffContorol, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DspRingUpStroke, 0)
        Me.Controls.SetChildIndex(Me.DspTaperCorRate, 0)
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStrokeDiffContorol.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents DgvJackStroke As DataGridView
    Friend WithEvents DspAveStroke As ucnDspData
    Friend WithEvents DspCenterWidth As ucnDspData
    Friend WithEvents DspTaperValue As ucnDspData
    Friend WithEvents DspMaxTaperLoc As ucnDspData
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents DspAveLogocalStroke As ucnDspData
    Friend WithEvents DspAveSpeed As ucnDspData
    Friend WithEvents OpposeJackExcep As ucnRdBtn
    Friend WithEvents DspHorTargerStrokeDev As ucnDspData
    Friend WithEvents DspHorTargerNowStrokeDev As ucnDspData
    Friend WithEvents lblTopRightStartSt As Label
    Friend WithEvents lblTopLeftStartSt As Label
    Friend WithEvents lblTopRightRealSt As Label
    Friend WithEvents lblTopLeftRealSt As Label
    Friend WithEvents lblTopNetSt As Label
    Friend WithEvents lblFieldName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTopStItem As Label
    Friend WithEvents lblTopRightStNo As Label
    Friend WithEvents lblTopLefttStNo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTopRingTargetSt As Label
    Friend WithEvents lblHorRightStartSt As Label
    Friend WithEvents lblHorLeftStartSt As Label
    Friend WithEvents lblHorRightRealSt As Label
    Friend WithEvents lblHorLeftRealSt As Label
    Friend WithEvents lblHorNetSt As Label
    Friend WithEvents lblHorStItem As Label
    Friend WithEvents lblHorRightStNo As Label
    Friend WithEvents lblHorLefttStNo As Label
    Friend WithEvents lblHorRingTargetSt As Label
    Friend WithEvents lblBtmRightStartSt As Label
    Friend WithEvents lblBtmLeftStartSt As Label
    Friend WithEvents lblBtmRightRealSt As Label
    Friend WithEvents lblBtmLeftRealSt As Label
    Friend WithEvents lblBtmStItem As Label
    Friend WithEvents lblBtmRightStNo As Label
    Friend WithEvents lblBtmLeftStNo As Label
    Friend WithEvents lblBtmRingTargetSt As Label
    Friend WithEvents pnlStrokeDiffContorol As Panel
    Friend WithEvents lblBtmNetSt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblConvertBtmStrokeDiff As Label
    Friend WithEvents lblConvertBtmStartStrokeDiff As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblConvertHorStrokeDiff As Label
    Friend WithEvents lblConvertHorStartStrokeDiff As Label
    Friend WithEvents label4 As Label
    Friend WithEvents lblConvertTopStrokeDiff As Label
    Friend WithEvents lblConvertTopStartStrokeDiff As Label
    Friend WithEvents DspRingUpStroke As ucnDspData
    Friend WithEvents JackNo As DataGridViewTextBoxColumn
    Friend WithEvents RealStrokeLen As DataGridViewTextBoxColumn
    Friend WithEvents CalcStrokeLen As DataGridViewTextBoxColumn
    Friend WithEvents CalcLogcalStroke As DataGridViewTextBoxColumn
    Friend WithEvents StartStroke As DataGridViewTextBoxColumn
    Friend WithEvents JackSpeed As DataGridViewTextBoxColumn
    Friend WithEvents Angle As DataGridViewTextBoxColumn
    Friend WithEvents SegmentWidth As DataGridViewTextBoxColumn
    Friend WithEvents JackState As DataGridViewTextBoxColumn
    Friend WithEvents JackEnable As DataGridViewCheckBoxColumn
    Friend WithEvents DspTaperCorRate As ucnDspData
End Class
