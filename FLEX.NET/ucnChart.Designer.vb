﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblCenter = New System.Windows.Forms.Label()
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
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.LightGreen
        Me.lblData.Location = New System.Drawing.Point(227, 3)
        Me.lblData.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(67, 18)
        Me.lblData.TabIndex = 8
        Me.lblData.Text = "1234"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLegend
        '
        Me.lblLegend.AutoSize = True
        Me.lblLegend.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLegend.Location = New System.Drawing.Point(50, 8)
        Me.lblLegend.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.Size = New System.Drawing.Size(158, 13)
        Me.lblLegend.TabIndex = 10
        Me.lblLegend.Text = "水平ｼﾞｬｯｷﾓｰﾒﾝﾄ(kN･m)"
        '
        'lblCenter
        '
        Me.lblCenter.Location = New System.Drawing.Point(-23, 68)
        Me.lblCenter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(62, 18)
        Me.lblCenter.TabIndex = 11
        Me.lblCenter.Text = "0"
        Me.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGraphHigh
        '
        Me.lblGraphHigh.Location = New System.Drawing.Point(-23, 15)
        Me.lblGraphHigh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphHigh.Name = "lblGraphHigh"
        Me.lblGraphHigh.Size = New System.Drawing.Size(62, 13)
        Me.lblGraphHigh.TabIndex = 12
        Me.lblGraphHigh.Text = "10000"
        Me.lblGraphHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGraphLow
        '
        Me.lblGraphLow.Location = New System.Drawing.Point(-23, 122)
        Me.lblGraphLow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphLow.Name = "lblGraphLow"
        Me.lblGraphLow.Size = New System.Drawing.Size(62, 27)
        Me.lblGraphLow.TabIndex = 13
        Me.lblGraphLow.Text = "-10000"
        Me.lblGraphLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picChart
        '
        Me.picChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChart.Location = New System.Drawing.Point(38, 22)
        Me.picChart.Margin = New System.Windows.Forms.Padding(2)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(315, 107)
        Me.picChart.TabIndex = 9
        Me.picChart.TabStop = False
        '
        'ucnChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.lblGraphLow)
        Me.Controls.Add(Me.lblGraphHigh)
        Me.Controls.Add(Me.lblCenter)
        Me.Controls.Add(Me.lblLegend)
        Me.Controls.Add(Me.lblData)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ucnChart"
        Me.Size = New System.Drawing.Size(435, 158)
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents picChart As PictureBox
    Protected WithEvents lblData As Label
    Protected WithEvents lblLegend As Label
    Protected WithEvents lblCenter As Label
    Protected WithEvents lblGraphHigh As Label
    Protected WithEvents lblGraphLow As Label
End Class
