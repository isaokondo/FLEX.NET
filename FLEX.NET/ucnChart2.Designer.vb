<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnChart2
    Inherits ucnChart

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
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblReal = New System.Windows.Forms.Label()
        Me.lblCorrection = New System.Windows.Forms.Label()
        Me.lblPlan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChart
        '
        Me.picChart.BackColor = System.Drawing.Color.Gray
        Me.picChart.Location = New System.Drawing.Point(47, 45)
        Me.picChart.Size = New System.Drawing.Size(405, 101)
        '
        'lblData
        '
        Me.lblData.Location = New System.Drawing.Point(90, 2)
        Me.lblData.Visible = False
        '
        'lblLegend
        '
        Me.lblLegend.Location = New System.Drawing.Point(45, 26)
        Me.lblLegend.Size = New System.Drawing.Size(77, 12)
        Me.lblLegend.Text = "ピッチ角(deg)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 89)
        Me.Label1.Visible = False
        '
        'lblGraphHigh
        '
        Me.lblGraphHigh.Location = New System.Drawing.Point(-8, 41)
        Me.lblGraphHigh.Visible = False
        '
        'lblGraphLow
        '
        Me.lblGraphLow.Location = New System.Drawing.Point(-13, 134)
        Me.lblGraphLow.Visible = False
        '
        'lblTarget
        '
        Me.lblTarget.BackColor = System.Drawing.Color.Black
        Me.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTarget.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.Yellow
        Me.lblTarget.Location = New System.Drawing.Point(315, 20)
        Me.lblTarget.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(61, 22)
        Me.lblTarget.TabIndex = 14
        Me.lblTarget.Text = "360.00"
        Me.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReal
        '
        Me.lblReal.BackColor = System.Drawing.Color.Black
        Me.lblReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReal.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReal.ForeColor = System.Drawing.Color.Yellow
        Me.lblReal.Location = New System.Drawing.Point(389, 20)
        Me.lblReal.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReal.Name = "lblReal"
        Me.lblReal.Size = New System.Drawing.Size(61, 22)
        Me.lblReal.TabIndex = 15
        Me.lblReal.Text = "360.00"
        Me.lblReal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorrection
        '
        Me.lblCorrection.BackColor = System.Drawing.Color.Black
        Me.lblCorrection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorrection.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCorrection.ForeColor = System.Drawing.Color.Yellow
        Me.lblCorrection.Location = New System.Drawing.Point(241, 20)
        Me.lblCorrection.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCorrection.Name = "lblCorrection"
        Me.lblCorrection.Size = New System.Drawing.Size(61, 22)
        Me.lblCorrection.TabIndex = 16
        Me.lblCorrection.Text = "360.00"
        Me.lblCorrection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlan
        '
        Me.lblPlan.BackColor = System.Drawing.Color.Black
        Me.lblPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlan.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPlan.ForeColor = System.Drawing.Color.Yellow
        Me.lblPlan.Location = New System.Drawing.Point(167, 20)
        Me.lblPlan.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPlan.Name = "lblPlan"
        Me.lblPlan.Size = New System.Drawing.Size(61, 22)
        Me.lblPlan.TabIndex = 17
        Me.lblPlan.Text = "360.00"
        Me.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "設計"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(257, 7)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "補正"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(324, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "目標"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "実測"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucnChart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPlan)
        Me.Controls.Add(Me.lblCorrection)
        Me.Controls.Add(Me.lblReal)
        Me.Controls.Add(Me.lblTarget)
        Me.FieldName = "ピッチ角(deg)"
        Me.Name = "ucnChart2"
        Me.Size = New System.Drawing.Size(470, 162)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblGraphHigh, 0)
        Me.Controls.SetChildIndex(Me.lblGraphLow, 0)
        Me.Controls.SetChildIndex(Me.lblData, 0)
        Me.Controls.SetChildIndex(Me.lblLegend, 0)
        Me.Controls.SetChildIndex(Me.picChart, 0)
        Me.Controls.SetChildIndex(Me.lblTarget, 0)
        Me.Controls.SetChildIndex(Me.lblReal, 0)
        Me.Controls.SetChildIndex(Me.lblCorrection, 0)
        Me.Controls.SetChildIndex(Me.lblPlan, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTarget As Label
    Friend WithEvents lblReal As Label
    Friend WithEvents lblCorrection As Label
    Friend WithEvents lblPlan As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label9 As Label
End Class
