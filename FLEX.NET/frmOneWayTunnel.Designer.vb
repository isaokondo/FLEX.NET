<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOneWayTunnel
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
        Me.HorPID_D = New FLEX.NET.ucnNumEdit()
        Me.HorPID_I = New FLEX.NET.ucnNumEdit()
        Me.HorPID_P = New FLEX.NET.ucnNumEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VerPID_D = New FLEX.NET.ucnNumEdit()
        Me.VerPID_I = New FLEX.NET.ucnNumEdit()
        Me.VerPID_P = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(209, 461)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(339, 461)
        '
        'HorPID_D
        '
        Me.HorPID_D.DataDspWidth = 110
        Me.HorPID_D.DecimalPlaces = CType(0, Short)
        Me.HorPID_D.DspFieldName = True
        Me.HorPID_D.FieldName = "D"
        Me.HorPID_D.Increment = 1.0!
        Me.HorPID_D.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.HorPID_D.Location = New System.Drawing.Point(41, 133)
        Me.HorPID_D.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPID_D.MaxValue = "200"
        Me.HorPID_D.MinValue = "0"
        Me.HorPID_D.Name = "HorPID_D"
        Me.HorPID_D.SelectItem = Nothing
        Me.HorPID_D.Size = New System.Drawing.Size(384, 39)
        Me.HorPID_D.TabIndex = 20
        Me.HorPID_D.Unit = "sec"
        Me.HorPID_D.Value = 0R
        '
        'HorPID_I
        '
        Me.HorPID_I.DataDspWidth = 110
        Me.HorPID_I.DecimalPlaces = CType(0, Short)
        Me.HorPID_I.DspFieldName = True
        Me.HorPID_I.FieldName = "I"
        Me.HorPID_I.Increment = 1.0!
        Me.HorPID_I.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.HorPID_I.Location = New System.Drawing.Point(41, 88)
        Me.HorPID_I.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPID_I.MaxValue = "200"
        Me.HorPID_I.MinValue = "0"
        Me.HorPID_I.Name = "HorPID_I"
        Me.HorPID_I.SelectItem = Nothing
        Me.HorPID_I.Size = New System.Drawing.Size(384, 39)
        Me.HorPID_I.TabIndex = 19
        Me.HorPID_I.Unit = "sec"
        Me.HorPID_I.Value = 0R
        '
        'HorPID_P
        '
        Me.HorPID_P.DataDspWidth = 110
        Me.HorPID_P.DecimalPlaces = CType(0, Short)
        Me.HorPID_P.DspFieldName = True
        Me.HorPID_P.FieldName = "P"
        Me.HorPID_P.Increment = 1.0!
        Me.HorPID_P.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.HorPID_P.Location = New System.Drawing.Point(41, 43)
        Me.HorPID_P.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPID_P.MaxValue = "200"
        Me.HorPID_P.MinValue = "0"
        Me.HorPID_P.Name = "HorPID_P"
        Me.HorPID_P.SelectItem = Nothing
        Me.HorPID_P.Size = New System.Drawing.Size(384, 39)
        Me.HorPID_P.TabIndex = 18
        Me.HorPID_P.Unit = "%"
        Me.HorPID_P.Value = 0R
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 524)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(18, 13)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(428, 170)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(22, 214)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(428, 170)
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ForeColor = System.Drawing.Color.White
        Me.lblFieldName.Location = New System.Drawing.Point(29, 17)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(39, 15)
        Me.lblFieldName.TabIndex = 25
        Me.lblFieldName.Text = "水平"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "鉛直"
        '
        'VerPID_D
        '
        Me.VerPID_D.DataDspWidth = 110
        Me.VerPID_D.DecimalPlaces = CType(0, Short)
        Me.VerPID_D.DspFieldName = True
        Me.VerPID_D.FieldName = "D"
        Me.VerPID_D.Increment = 1.0!
        Me.VerPID_D.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.VerPID_D.Location = New System.Drawing.Point(41, 342)
        Me.VerPID_D.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPID_D.MaxValue = "200"
        Me.VerPID_D.MinValue = "0"
        Me.VerPID_D.Name = "VerPID_D"
        Me.VerPID_D.SelectItem = Nothing
        Me.VerPID_D.Size = New System.Drawing.Size(384, 39)
        Me.VerPID_D.TabIndex = 28
        Me.VerPID_D.Unit = "sec"
        Me.VerPID_D.Value = 0R
        '
        'VerPID_I
        '
        Me.VerPID_I.DataDspWidth = 110
        Me.VerPID_I.DecimalPlaces = CType(0, Short)
        Me.VerPID_I.DspFieldName = True
        Me.VerPID_I.FieldName = "I"
        Me.VerPID_I.Increment = 1.0!
        Me.VerPID_I.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.VerPID_I.Location = New System.Drawing.Point(41, 305)
        Me.VerPID_I.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPID_I.MaxValue = "200"
        Me.VerPID_I.MinValue = "0"
        Me.VerPID_I.Name = "VerPID_I"
        Me.VerPID_I.SelectItem = Nothing
        Me.VerPID_I.Size = New System.Drawing.Size(384, 39)
        Me.VerPID_I.TabIndex = 27
        Me.VerPID_I.Unit = "sec"
        Me.VerPID_I.Value = 0R
        '
        'VerPID_P
        '
        Me.VerPID_P.DataDspWidth = 110
        Me.VerPID_P.DecimalPlaces = CType(0, Short)
        Me.VerPID_P.DspFieldName = True
        Me.VerPID_P.FieldName = "P"
        Me.VerPID_P.Increment = 1.0!
        Me.VerPID_P.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.VerPID_P.Location = New System.Drawing.Point(41, 262)
        Me.VerPID_P.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPID_P.MaxValue = "200"
        Me.VerPID_P.MinValue = "0"
        Me.VerPID_P.Name = "VerPID_P"
        Me.VerPID_P.SelectItem = Nothing
        Me.VerPID_P.Size = New System.Drawing.Size(384, 39)
        Me.VerPID_P.TabIndex = 26
        Me.VerPID_P.Unit = "%"
        Me.VerPID_P.Value = 0R
        '
        'frmOneWayTunnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VerPID_D)
        Me.Controls.Add(Me.VerPID_I)
        Me.Controls.Add(Me.VerPID_P)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.HorPID_D)
        Me.Controls.Add(Me.HorPID_I)
        Me.Controls.Add(Me.HorPID_P)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmOneWayTunnel"
        Me.Text = "片押しパラメータ"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.HorPID_P, 0)
        Me.Controls.SetChildIndex(Me.HorPID_I, 0)
        Me.Controls.SetChildIndex(Me.HorPID_D, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.Controls.SetChildIndex(Me.VerPID_P, 0)
        Me.Controls.SetChildIndex(Me.VerPID_I, 0)
        Me.Controls.SetChildIndex(Me.VerPID_D, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HorPID_D As ucnNumEdit
    Friend WithEvents HorPID_I As ucnNumEdit
    Friend WithEvents HorPID_P As ucnNumEdit
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Private WithEvents lblFieldName As Label
    Private WithEvents Label1 As Label
    Friend WithEvents VerPID_D As ucnNumEdit
    Friend WithEvents VerPID_I As ucnNumEdit
    Friend WithEvents VerPID_P As ucnNumEdit
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
End Class
