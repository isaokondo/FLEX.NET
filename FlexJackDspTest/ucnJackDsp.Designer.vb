<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucnJackDsp
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.tmrCenter = New System.Windows.Forms.Timer(Me.components)
        Me.imgPoint = New System.Windows.Forms.PictureBox()
        Me.lblPointDspRate = New System.Windows.Forms.Label()
        Me.picPoint = New System.Windows.Forms.PictureBox()
        Me.tmrBlink = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCenter
        '
        Me.tmrCenter.Interval = 2000
        '
        'imgPoint
        '
        Me.imgPoint.BackColor = System.Drawing.Color.Transparent
        Me.imgPoint.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPoint.InitialImage = Nothing
        Me.imgPoint.Location = New System.Drawing.Point(392, 311)
        Me.imgPoint.Name = "imgPoint"
        Me.imgPoint.Size = New System.Drawing.Size(32, 32)
        Me.imgPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPoint.TabIndex = 126
        Me.imgPoint.TabStop = False
        '
        'lblPointDspRate
        '
        Me.lblPointDspRate.BackColor = System.Drawing.Color.Transparent
        Me.lblPointDspRate.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointDspRate.ForeColor = System.Drawing.Color.White
        Me.lblPointDspRate.Location = New System.Drawing.Point(302, 379)
        Me.lblPointDspRate.Name = "lblPointDspRate"
        Me.lblPointDspRate.Size = New System.Drawing.Size(37, 15)
        Me.lblPointDspRate.TabIndex = 136
        Me.lblPointDspRate.Text = "X"
        '
        'picPoint
        '
        Me.picPoint.BackColor = System.Drawing.Color.Transparent
        Me.picPoint.Location = New System.Drawing.Point(326, 244)
        Me.picPoint.Name = "picPoint"
        Me.picPoint.Size = New System.Drawing.Size(166, 166)
        Me.picPoint.TabIndex = 137
        Me.picPoint.TabStop = False
        '
        'tmrBlink
        '
        Me.tmrBlink.Enabled = True
        Me.tmrBlink.Interval = 1000
        '
        'ucnJackDsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.lblPointDspRate)
        Me.Controls.Add(Me.imgPoint)
        Me.Controls.Add(Me.picPoint)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucnJackDsp"
        Me.Size = New System.Drawing.Size(1020, 812)
        CType(Me.imgPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrCenter As Timer
    Public WithEvents imgPoint As PictureBox
    Friend WithEvents lblPointDspRate As Label
    Friend WithEvents picPoint As PictureBox
    Friend WithEvents tmrBlink As Timer
End Class
