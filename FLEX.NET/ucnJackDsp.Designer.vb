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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnJackDsp))
        Me.tmrCenter = New System.Windows.Forms.Timer(Me.components)
        Me.lblPointX = New System.Windows.Forms.Label()
        Me.lblPointY = New System.Windows.Forms.Label()
        Me.lblPointR = New System.Windows.Forms.Label()
        Me.lblSeater = New System.Windows.Forms.Label()
        Me.btnPointCenter = New System.Windows.Forms.Button()
        Me.btnPointAutoMan = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.imgPoint = New System.Windows.Forms.PictureBox()
        Me.imgPointYUP = New System.Windows.Forms.PictureBox()
        Me.imgPointXDOWN = New System.Windows.Forms.PictureBox()
        Me.imgPointXUP = New System.Windows.Forms.PictureBox()
        Me.lblPointDspRate = New System.Windows.Forms.Label()
        Me.picPoint = New System.Windows.Forms.PictureBox()
        Me.tmrBlink = New System.Windows.Forms.Timer(Me.components)
        Me.imgPointYDOWN = New System.Windows.Forms.PictureBox()
        CType(Me.imgPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPointYUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPointXDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPointXUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPointYDOWN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCenter
        '
        Me.tmrCenter.Interval = 2000
        '
        'lblPointX
        '
        Me.lblPointX.BackColor = System.Drawing.Color.Black
        Me.lblPointX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointX.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointX.ForeColor = System.Drawing.Color.LightGreen
        Me.lblPointX.Location = New System.Drawing.Point(337, 220)
        Me.lblPointX.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPointX.Name = "lblPointX"
        Me.lblPointX.Size = New System.Drawing.Size(50, 24)
        Me.lblPointX.TabIndex = 111
        Me.lblPointX.Text = "10.45"
        Me.lblPointX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPointY
        '
        Me.lblPointY.BackColor = System.Drawing.Color.Black
        Me.lblPointY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointY.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointY.ForeColor = System.Drawing.Color.LightGreen
        Me.lblPointY.Location = New System.Drawing.Point(433, 219)
        Me.lblPointY.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPointY.Name = "lblPointY"
        Me.lblPointY.Size = New System.Drawing.Size(50, 25)
        Me.lblPointY.TabIndex = 112
        Me.lblPointY.Text = "0.45"
        Me.lblPointY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPointR
        '
        Me.lblPointR.BackColor = System.Drawing.Color.Black
        Me.lblPointR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPointR.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointR.ForeColor = System.Drawing.Color.LightGreen
        Me.lblPointR.Location = New System.Drawing.Point(279, 267)
        Me.lblPointR.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPointR.Name = "lblPointR"
        Me.lblPointR.Size = New System.Drawing.Size(50, 24)
        Me.lblPointR.TabIndex = 113
        Me.lblPointR.Text = "0.45"
        Me.lblPointR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSeater
        '
        Me.lblSeater.BackColor = System.Drawing.Color.Black
        Me.lblSeater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeater.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSeater.ForeColor = System.Drawing.Color.LightGreen
        Me.lblSeater.Location = New System.Drawing.Point(491, 267)
        Me.lblSeater.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSeater.Name = "lblSeater"
        Me.lblSeater.Size = New System.Drawing.Size(50, 25)
        Me.lblSeater.TabIndex = 114
        Me.lblSeater.Text = "245.4"
        Me.lblSeater.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPointCenter
        '
        Me.btnPointCenter.BackColor = System.Drawing.Color.Silver
        Me.btnPointCenter.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPointCenter.Location = New System.Drawing.Point(304, 397)
        Me.btnPointCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPointCenter.Name = "btnPointCenter"
        Me.btnPointCenter.Size = New System.Drawing.Size(47, 33)
        Me.btnPointCenter.TabIndex = 119
        Me.btnPointCenter.Text = "C"
        Me.btnPointCenter.UseVisualStyleBackColor = False
        '
        'btnPointAutoMan
        '
        Me.btnPointAutoMan.BackColor = System.Drawing.Color.Silver
        Me.btnPointAutoMan.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPointAutoMan.Location = New System.Drawing.Point(466, 394)
        Me.btnPointAutoMan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPointAutoMan.Name = "btnPointAutoMan"
        Me.btnPointAutoMan.Size = New System.Drawing.Size(53, 24)
        Me.btnPointAutoMan.TabIndex = 120
        Me.btnPointAutoMan.Text = "手動"
        Me.btnPointAutoMan.UseVisualStyleBackColor = False
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.White
        Me.lblX.Location = New System.Drawing.Point(342, 203)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(12, 12)
        Me.lblX.TabIndex = 121
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblY.ForeColor = System.Drawing.Color.White
        Me.lblY.Location = New System.Drawing.Point(448, 202)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(12, 12)
        Me.lblY.TabIndex = 122
        Me.lblY.Text = "Y"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblr.ForeColor = System.Drawing.Color.White
        Me.lblr.Location = New System.Drawing.Point(297, 249)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(17, 12)
        Me.lblr.TabIndex = 123
        Me.lblr.Text = "γ"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblS.ForeColor = System.Drawing.Color.White
        Me.lblS.Location = New System.Drawing.Point(497, 246)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(17, 12)
        Me.lblS.TabIndex = 124
        Me.lblS.Text = "θ"
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
        'imgPointYUP
        '
        Me.imgPointYUP.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPointYUP.Image = CType(resources.GetObject("imgPointYUP.Image"), System.Drawing.Image)
        Me.imgPointYUP.Location = New System.Drawing.Point(392, 205)
        Me.imgPointYUP.Name = "imgPointYUP"
        Me.imgPointYUP.Size = New System.Drawing.Size(32, 32)
        Me.imgPointYUP.TabIndex = 135
        Me.imgPointYUP.TabStop = False
        '
        'imgPointXDOWN
        '
        Me.imgPointXDOWN.BackColor = System.Drawing.Color.DarkGray
        Me.imgPointXDOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgPointXDOWN.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPointXDOWN.Image = CType(resources.GetObject("imgPointXDOWN.Image"), System.Drawing.Image)
        Me.imgPointXDOWN.Location = New System.Drawing.Point(283, 309)
        Me.imgPointXDOWN.Name = "imgPointXDOWN"
        Me.imgPointXDOWN.Size = New System.Drawing.Size(32, 32)
        Me.imgPointXDOWN.TabIndex = 134
        Me.imgPointXDOWN.TabStop = False
        '
        'imgPointXUP
        '
        Me.imgPointXUP.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPointXUP.Image = CType(resources.GetObject("imgPointXUP.Image"), System.Drawing.Image)
        Me.imgPointXUP.Location = New System.Drawing.Point(500, 310)
        Me.imgPointXUP.Name = "imgPointXUP"
        Me.imgPointXUP.Size = New System.Drawing.Size(32, 32)
        Me.imgPointXUP.TabIndex = 132
        Me.imgPointXUP.TabStop = False
        Me.imgPointXUP.Visible = False
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
        'imgPointYDOWN
        '
        Me.imgPointYDOWN.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPointYDOWN.Image = CType(resources.GetObject("imgPointYDOWN.Image"), System.Drawing.Image)
        Me.imgPointYDOWN.Location = New System.Drawing.Point(392, 417)
        Me.imgPointYDOWN.Name = "imgPointYDOWN"
        Me.imgPointYDOWN.Size = New System.Drawing.Size(32, 32)
        Me.imgPointYDOWN.TabIndex = 133
        Me.imgPointYDOWN.TabStop = False
        '
        'ucnJackDsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.lblPointDspRate)
        Me.Controls.Add(Me.imgPointXUP)
        Me.Controls.Add(Me.imgPointYDOWN)
        Me.Controls.Add(Me.imgPointXDOWN)
        Me.Controls.Add(Me.imgPointYUP)
        Me.Controls.Add(Me.imgPoint)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnPointAutoMan)
        Me.Controls.Add(Me.btnPointCenter)
        Me.Controls.Add(Me.lblSeater)
        Me.Controls.Add(Me.lblPointR)
        Me.Controls.Add(Me.lblPointY)
        Me.Controls.Add(Me.lblPointX)
        Me.Controls.Add(Me.picPoint)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucnJackDsp"
        Me.Size = New System.Drawing.Size(1020, 812)
        CType(Me.imgPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPointYUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPointXDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPointXUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPointYDOWN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrCenter As Timer
    Friend WithEvents lblPointX As Label
    Friend WithEvents lblPointY As Label
    Friend WithEvents lblPointR As Label
    Friend WithEvents lblSeater As Label
    Friend WithEvents btnPointCenter As Button
    Friend WithEvents btnPointAutoMan As Button
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblr As Label
    Friend WithEvents lblS As Label
    Public WithEvents imgPoint As PictureBox
    Public WithEvents imgPointYUP As PictureBox
    Private WithEvents imgPointXDOWN As PictureBox
    Public WithEvents imgPointXUP As PictureBox
    Friend WithEvents lblPointDspRate As Label
    Friend WithEvents picPoint As PictureBox
    Friend WithEvents tmrBlink As Timer
    Public WithEvents imgPointYDOWN As PictureBox
End Class
