<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnDevImgDsp
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
        Me.picPoint = New System.Windows.Forms.PictureBox()
        Me.lblGraphHighY = New System.Windows.Forms.Label()
        Me.lblGraphHighX = New System.Windows.Forms.Label()
        Me.lblGraphLowY = New System.Windows.Forms.Label()
        Me.lblGraphLowX = New System.Windows.Forms.Label()
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPoint
        '
        Me.picPoint.Location = New System.Drawing.Point(36, 14)
        Me.picPoint.Name = "picPoint"
        Me.picPoint.Size = New System.Drawing.Size(160, 160)
        Me.picPoint.TabIndex = 0
        Me.picPoint.TabStop = False
        '
        'lblGraphHighY
        '
        Me.lblGraphHighY.Location = New System.Drawing.Point(100, 0)
        Me.lblGraphHighY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphHighY.Name = "lblGraphHighY"
        Me.lblGraphHighY.Size = New System.Drawing.Size(40, 13)
        Me.lblGraphHighY.TabIndex = 13
        Me.lblGraphHighY.Text = "10000"
        Me.lblGraphHighY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGraphHighX
        '
        Me.lblGraphHighX.Location = New System.Drawing.Point(197, 87)
        Me.lblGraphHighX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphHighX.Name = "lblGraphHighX"
        Me.lblGraphHighX.Size = New System.Drawing.Size(40, 13)
        Me.lblGraphHighX.TabIndex = 14
        Me.lblGraphHighX.Text = "10000"
        Me.lblGraphHighX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGraphLowY
        '
        Me.lblGraphLowY.Location = New System.Drawing.Point(-7, 87)
        Me.lblGraphLowY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphLowY.Name = "lblGraphLowY"
        Me.lblGraphLowY.Size = New System.Drawing.Size(40, 13)
        Me.lblGraphLowY.TabIndex = 15
        Me.lblGraphLowY.Text = "10000"
        Me.lblGraphLowY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGraphLowX
        '
        Me.lblGraphLowX.Location = New System.Drawing.Point(91, 175)
        Me.lblGraphLowX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraphLowX.Name = "lblGraphLowX"
        Me.lblGraphLowX.Size = New System.Drawing.Size(40, 13)
        Me.lblGraphLowX.TabIndex = 16
        Me.lblGraphLowX.Text = "10000"
        Me.lblGraphLowX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucnDevImgDsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblGraphLowX)
        Me.Controls.Add(Me.lblGraphLowY)
        Me.Controls.Add(Me.lblGraphHighX)
        Me.Controls.Add(Me.lblGraphHighY)
        Me.Controls.Add(Me.picPoint)
        Me.Name = "ucnDevImgDsp"
        Me.Size = New System.Drawing.Size(256, 226)
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPoint As PictureBox
    Protected WithEvents lblGraphHighY As Label
    Protected WithEvents lblGraphHighX As Label
    Protected WithEvents lblGraphLowY As Label
    Protected WithEvents lblGraphLowX As Label
End Class
