<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcStrokeConfirm
    Inherits frmSettingBase

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.DgvJackStroke = New System.Windows.Forms.DataGridView()
        Me.JackNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealStrokeLen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalcStrokeLen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalcLogcalStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartStroke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JackSpeed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angle = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(317, 512)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(443, 512)
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
        Me.DgvJackStroke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JackNo, Me.RealStrokeLen, Me.CalcStrokeLen, Me.CalcLogcalStroke, Me.StartStroke, Me.JackSpeed, Me.Angle, Me.JackState, Me.JackEnable})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJackStroke.DefaultCellStyle = DataGridViewCellStyle12
        Me.DgvJackStroke.Location = New System.Drawing.Point(14, 250)
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
        Me.DgvJackStroke.Size = New System.Drawing.Size(794, 249)
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
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Angle.DefaultCellStyle = DataGridViewCellStyle9
        Me.Angle.Frozen = True
        Me.Angle.HeaderText = "取付角度(deg)"
        Me.Angle.Name = "Angle"
        Me.Angle.ReadOnly = True
        Me.Angle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JackState
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle10.NullValue = Nothing
        Me.JackState.DefaultCellStyle = DataGridViewCellStyle10
        Me.JackState.Frozen = True
        Me.JackState.HeaderText = "状態"
        Me.JackState.Name = "JackState"
        Me.JackState.ReadOnly = True
        Me.JackState.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JackState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JackEnable
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle11.NullValue = False
        Me.JackEnable.DefaultCellStyle = DataGridViewCellStyle11
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
        Me.DspCenterWidth.Location = New System.Drawing.Point(38, 120)
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
        Me.DspTaperValue.Location = New System.Drawing.Point(38, 154)
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
        Me.DspMaxTaperLoc.Location = New System.Drawing.Point(38, 188)
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
        Me.RectangleShape2.Location = New System.Drawing.Point(24, 103)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(359, 128)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(851, 559)
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
        Me.OpposeJackExcep.Location = New System.Drawing.Point(406, 71)
        Me.OpposeJackExcep.Margin = New System.Windows.Forms.Padding(2)
        Me.OpposeJackExcep.Name = "OpposeJackExcep"
        Me.OpposeJackExcep.rdbtnValue = False
        Me.OpposeJackExcep.Selectable = True
        Me.OpposeJackExcep.Size = New System.Drawing.Size(422, 34)
        Me.OpposeJackExcep.SlectNoName = "する"
        Me.OpposeJackExcep.SlectYesName = "しない"
        Me.OpposeJackExcep.TabIndex = 138
        '
        'frmCalcStrokeConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 559)
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
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DgvJackStroke, 0)
        Me.Controls.SetChildIndex(Me.DspAveStroke, 0)
        Me.Controls.SetChildIndex(Me.DspCenterWidth, 0)
        Me.Controls.SetChildIndex(Me.DspTaperValue, 0)
        Me.Controls.SetChildIndex(Me.DspMaxTaperLoc, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.DspAveLogocalStroke, 0)
        Me.Controls.SetChildIndex(Me.DspAveSpeed, 0)
        Me.Controls.SetChildIndex(Me.OpposeJackExcep, 0)
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents JackNo As DataGridViewTextBoxColumn
    Friend WithEvents RealStrokeLen As DataGridViewTextBoxColumn
    Friend WithEvents CalcStrokeLen As DataGridViewTextBoxColumn
    Friend WithEvents CalcLogcalStroke As DataGridViewTextBoxColumn
    Friend WithEvents StartStroke As DataGridViewTextBoxColumn
    Friend WithEvents JackSpeed As DataGridViewTextBoxColumn
    Friend WithEvents Angle As DataGridViewTextBoxColumn
    Friend WithEvents JackState As DataGridViewTextBoxColumn
    Friend WithEvents JackEnable As DataGridViewCheckBoxColumn
    Friend WithEvents OpposeJackExcep As ucnRdBtn
End Class
