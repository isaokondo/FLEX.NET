<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPressBlock
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
        Me.MinimumFullPowerBlock = New FLEX.NET.ucnNumEdit()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.MaxContorolPress = New FLEX.NET.ucnNumEdit()
        Me.MinimumContorolPress = New FLEX.NET.ucnNumEdit()
        Me.FullPowerRange = New FLEX.NET.ucnNumEdit()
        Me.FullPowerValue = New FLEX.NET.ucnNumEdit()
        Me.picPressBlock = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picPressBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 363)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(339, 364)
        '
        'MinimumFullPowerBlock
        '
        Me.MinimumFullPowerBlock.DataDspWidth = 110
        Me.MinimumFullPowerBlock.DecimalPlaces = CType(0, Short)
        Me.MinimumFullPowerBlock.DspFieldName = True
        Me.MinimumFullPowerBlock.FieldName = "全開ブロック最小数"
        Me.MinimumFullPowerBlock.Increment = 1.0!
        Me.MinimumFullPowerBlock.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MinimumFullPowerBlock.Location = New System.Drawing.Point(37, 40)
        Me.MinimumFullPowerBlock.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumFullPowerBlock.MaxValue = "10"
        Me.MinimumFullPowerBlock.MinValue = "1"
        Me.MinimumFullPowerBlock.Name = "MinimumFullPowerBlock"
        Me.MinimumFullPowerBlock.SelectItem = Nothing
        Me.MinimumFullPowerBlock.Size = New System.Drawing.Size(421, 30)
        Me.MinimumFullPowerBlock.TabIndex = 22
        Me.MinimumFullPowerBlock.ttMsg = ""
        Me.MinimumFullPowerBlock.ttTile = ""
        Me.MinimumFullPowerBlock.Unit = ""
        Me.MinimumFullPowerBlock.Value = 1.0R
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(21, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(443, 144)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1132, 665)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'MaxContorolPress
        '
        Me.MaxContorolPress.DataDspWidth = 110
        Me.MaxContorolPress.DecimalPlaces = CType(1, Short)
        Me.MaxContorolPress.DspFieldName = True
        Me.MaxContorolPress.FieldName = "最高制御圧力"
        Me.MaxContorolPress.Increment = 1.0!
        Me.MaxContorolPress.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MaxContorolPress.Location = New System.Drawing.Point(40, 287)
        Me.MaxContorolPress.Margin = New System.Windows.Forms.Padding(2)
        Me.MaxContorolPress.MaxValue = "50"
        Me.MaxContorolPress.MinValue = "0"
        Me.MaxContorolPress.Name = "MaxContorolPress"
        Me.MaxContorolPress.SelectItem = Nothing
        Me.MaxContorolPress.Size = New System.Drawing.Size(421, 39)
        Me.MaxContorolPress.TabIndex = 28
        Me.MaxContorolPress.ttMsg = ""
        Me.MaxContorolPress.ttTile = ""
        Me.MaxContorolPress.Unit = "MPa"
        Me.MaxContorolPress.Value = 0R
        '
        'MinimumContorolPress
        '
        Me.MinimumContorolPress.DataDspWidth = 110
        Me.MinimumContorolPress.DecimalPlaces = CType(1, Short)
        Me.MinimumContorolPress.DspFieldName = True
        Me.MinimumContorolPress.FieldName = "最低制御圧力"
        Me.MinimumContorolPress.Increment = 1.0!
        Me.MinimumContorolPress.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MinimumContorolPress.Location = New System.Drawing.Point(40, 244)
        Me.MinimumContorolPress.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumContorolPress.MaxValue = "50"
        Me.MinimumContorolPress.MinValue = "0"
        Me.MinimumContorolPress.Name = "MinimumContorolPress"
        Me.MinimumContorolPress.SelectItem = Nothing
        Me.MinimumContorolPress.Size = New System.Drawing.Size(421, 39)
        Me.MinimumContorolPress.TabIndex = 27
        Me.MinimumContorolPress.ttMsg = ""
        Me.MinimumContorolPress.ttTile = ""
        Me.MinimumContorolPress.Unit = "MPa"
        Me.MinimumContorolPress.Value = 0R
        '
        'FullPowerRange
        '
        Me.FullPowerRange.DataDspWidth = 110
        Me.FullPowerRange.DecimalPlaces = CType(1, Short)
        Me.FullPowerRange.DspFieldName = True
        Me.FullPowerRange.FieldName = "全開指令の作動範囲"
        Me.FullPowerRange.Increment = 1.0!
        Me.FullPowerRange.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.FullPowerRange.Location = New System.Drawing.Point(39, 180)
        Me.FullPowerRange.Margin = New System.Windows.Forms.Padding(2)
        Me.FullPowerRange.MaxValue = "10"
        Me.FullPowerRange.MinValue = "0"
        Me.FullPowerRange.Name = "FullPowerRange"
        Me.FullPowerRange.SelectItem = Nothing
        Me.FullPowerRange.Size = New System.Drawing.Size(421, 39)
        Me.FullPowerRange.TabIndex = 26
        Me.FullPowerRange.ttMsg = ""
        Me.FullPowerRange.ttTile = ""
        Me.FullPowerRange.Unit = "%"
        Me.FullPowerRange.Value = 0R
        '
        'FullPowerValue
        '
        Me.FullPowerValue.DataDspWidth = 110
        Me.FullPowerValue.DecimalPlaces = CType(0, Short)
        Me.FullPowerValue.DspFieldName = True
        Me.FullPowerValue.FieldName = "全開指令の中央値"
        Me.FullPowerValue.Increment = 1.0!
        Me.FullPowerValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.FullPowerValue.Location = New System.Drawing.Point(39, 92)
        Me.FullPowerValue.Margin = New System.Windows.Forms.Padding(2)
        Me.FullPowerValue.MaxValue = "100"
        Me.FullPowerValue.MinValue = "90"
        Me.FullPowerValue.Name = "FullPowerValue"
        Me.FullPowerValue.SelectItem = Nothing
        Me.FullPowerValue.Size = New System.Drawing.Size(421, 39)
        Me.FullPowerValue.TabIndex = 25
        Me.FullPowerValue.ttMsg = ""
        Me.FullPowerValue.ttTile = ""
        Me.FullPowerValue.Unit = "%"
        Me.FullPowerValue.Value = 90.0R
        '
        'picPressBlock
        '
        Me.picPressBlock.BackColor = System.Drawing.Color.Transparent
        Me.picPressBlock.Location = New System.Drawing.Point(472, 14)
        Me.picPressBlock.Margin = New System.Windows.Forms.Padding(2)
        Me.picPressBlock.Name = "picPressBlock"
        Me.picPressBlock.Size = New System.Drawing.Size(653, 640)
        Me.picPressBlock.TabIndex = 139
        Me.picPressBlock.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(507, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 25)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "低圧推進ブロックの設定"
        '
        'frmPressBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1132, 665)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPressBlock)
        Me.Controls.Add(Me.MaxContorolPress)
        Me.Controls.Add(Me.MinimumContorolPress)
        Me.Controls.Add(Me.FullPowerRange)
        Me.Controls.Add(Me.FullPowerValue)
        Me.Controls.Add(Me.MinimumFullPowerBlock)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmPressBlock"
        Me.Text = "圧力ブロック"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.MinimumFullPowerBlock, 0)
        Me.Controls.SetChildIndex(Me.FullPowerValue, 0)
        Me.Controls.SetChildIndex(Me.FullPowerRange, 0)
        Me.Controls.SetChildIndex(Me.MinimumContorolPress, 0)
        Me.Controls.SetChildIndex(Me.MaxContorolPress, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.picPressBlock, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.picPressBlock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MinimumFullPowerBlock As ucnNumEdit
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents MaxContorolPress As ucnNumEdit
    Friend WithEvents MinimumContorolPress As ucnNumEdit
    Friend WithEvents FullPowerRange As ucnNumEdit
    Friend WithEvents FullPowerValue As ucnNumEdit
    Friend WithEvents picPressBlock As PictureBox
    Friend WithEvents Label1 As Label
End Class
