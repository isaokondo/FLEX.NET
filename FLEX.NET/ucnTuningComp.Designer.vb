<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnTuningComp
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.lblPv = New System.Windows.Forms.Label()
        Me.lblSv = New System.Windows.Forms.Label()
        Me.lblPIDStatus = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.barMv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.barPv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.barSv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblMv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPv
        '
        Me.lblPv.BackColor = System.Drawing.Color.Transparent
        Me.lblPv.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPv.Location = New System.Drawing.Point(34, 17)
        Me.lblPv.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPv.Name = "lblPv"
        Me.lblPv.Size = New System.Drawing.Size(46, 10)
        Me.lblPv.TabIndex = 0
        Me.lblPv.Text = "0.0Mpa"
        Me.lblPv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSv
        '
        Me.lblSv.BackColor = System.Drawing.Color.Transparent
        Me.lblSv.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSv.ForeColor = System.Drawing.Color.Red
        Me.lblSv.Location = New System.Drawing.Point(34, 5)
        Me.lblSv.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSv.Name = "lblSv"
        Me.lblSv.Size = New System.Drawing.Size(46, 10)
        Me.lblSv.TabIndex = 1
        Me.lblSv.Text = "0.0Mpa"
        Me.lblSv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPIDStatus
        '
        Me.lblPIDStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPIDStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPIDStatus.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPIDStatus.Location = New System.Drawing.Point(435, 12)
        Me.lblPIDStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPIDStatus.Name = "lblPIDStatus"
        Me.lblPIDStatus.Size = New System.Drawing.Size(22, 25)
        Me.lblPIDStatus.TabIndex = 2
        Me.lblPIDStatus.Text = "A"
        Me.lblPIDStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.barMv, Me.barPv, Me.barSv, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(467, 37)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 85
        Me.LineShape3.X2 = 0
        Me.LineShape3.Y1 = 37
        Me.LineShape3.Y2 = 37
        '
        'barMv
        '
        Me.barMv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barMv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barMv.Location = New System.Drawing.Point(85, 27)
        Me.barMv.Name = "barMv"
        Me.barMv.Size = New System.Drawing.Size(300, 10)
        '
        'barPv
        '
        Me.barPv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barPv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barPv.Location = New System.Drawing.Point(85, 17)
        Me.barPv.Name = "barPv"
        Me.barPv.Size = New System.Drawing.Size(300, 10)
        '
        'barSv
        '
        Me.barSv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barSv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barSv.Location = New System.Drawing.Point(85, 8)
        Me.barSv.Name = "barSv"
        Me.barSv.Size = New System.Drawing.Size(300, 9)
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 385
        Me.LineShape2.X2 = 385
        Me.LineShape2.Y1 = -12
        Me.LineShape2.Y2 = 94
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 85
        Me.LineShape1.X2 = 85
        Me.LineShape1.Y1 = -16
        Me.LineShape1.Y2 = 78
        '
        'lblNo
        '
        Me.lblNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNo.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNo.Location = New System.Drawing.Point(385, 12)
        Me.lblNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(46, 18)
        Me.lblNo.TabIndex = 4
        Me.lblNo.Text = "No.1"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMv
        '
        Me.lblMv.BackColor = System.Drawing.Color.Transparent
        Me.lblMv.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMv.ForeColor = System.Drawing.Color.Blue
        Me.lblMv.Location = New System.Drawing.Point(25, 27)
        Me.lblMv.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMv.Name = "lblMv"
        Me.lblMv.Size = New System.Drawing.Size(46, 10)
        Me.lblMv.TabIndex = 2
        Me.lblMv.Text = "100.0%"
        Me.lblMv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucnTuningComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.lblPIDStatus)
        Me.Controls.Add(Me.lblSv)
        Me.Controls.Add(Me.lblPv)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblMv)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucnTuningComp"
        Me.Size = New System.Drawing.Size(467, 37)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblPv As Label
    Private WithEvents lblSv As Label
    Private WithEvents lblPIDStatus As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Private WithEvents lblNo As Label
    Friend WithEvents barMv As PowerPacks.RectangleShape
    Friend WithEvents barPv As PowerPacks.RectangleShape
    Friend WithEvents barSv As PowerPacks.RectangleShape
    Private WithEvents lblMv As Label
    Friend WithEvents LineShape3 As PowerPacks.LineShape
End Class
