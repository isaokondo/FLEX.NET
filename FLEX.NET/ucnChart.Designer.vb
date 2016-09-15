<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnChart
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
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGraphHigh = New System.Windows.Forms.Label()
        Me.lblGraphLow = New System.Windows.Forms.Label()
        Me.picChart = New System.Windows.Forms.PictureBox()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Black
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Yellow
        Me.lblData.Location = New System.Drawing.Point(242, 4)
        Me.lblData.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(67, 23)
        Me.lblData.TabIndex = 8
        Me.lblData.Text = "1234"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLegend.Location = New System.Drawing.Point(54, 9)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(181, 15)
        Me.lblLegend.TabIndex = 10
        Me.lblLegend.Text = "水平ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGraphHigh
        '
        Me.lblGraphHigh.Location = New System.Drawing.Point(-20, 19)
        Me.lblGraphHigh.Name = "lblGraphHigh"
        Me.lblGraphHigh.Size = New System.Drawing.Size(73, 16)
        Me.lblGraphHigh.TabIndex = 12
        Me.lblGraphHigh.Text = "10000"
        Me.lblGraphHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGraphLow
        '
        Me.lblGraphLow.Location = New System.Drawing.Point(-13, 123)
        Me.lblGraphLow.Name = "lblGraphLow"
        Me.lblGraphLow.Size = New System.Drawing.Size(66, 28)
        Me.lblGraphLow.TabIndex = 13
        Me.lblGraphLow.Text = "-10000"
        Me.lblGraphLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picChart
        '
        Me.picChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChart.Location = New System.Drawing.Point(51, 27)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(336, 107)
        Me.picChart.TabIndex = 9
        Me.picChart.TabStop = False
        '
        'ucnChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.lblGraphLow)
        Me.Controls.Add(Me.lblGraphHigh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLegend)
        Me.Controls.Add(Me.lblData)
        Me.Name = "ucnChart"
        Me.Size = New System.Drawing.Size(464, 197)
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents picChart As PictureBox
    Public WithEvents lblData As Label
    Public WithEvents lblLegend As Label
    Public WithEvents Label1 As Label
    Public WithEvents lblGraphHigh As Label
    Public WithEvents lblGraphLow As Label
End Class
