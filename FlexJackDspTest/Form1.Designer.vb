<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Public InitParameter As New FLEX.NET.clsInitParameter '初期値パラメータ


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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UcnJackDsp1 = New FLEX.NET.ucnJackDsp()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.Location = New System.Drawing.Point(43, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 365)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UcnJackDsp1
        '
        Me.UcnJackDsp1.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp1.FaiJack = Nothing
        Me.UcnJackDsp1.FlexAutoManual = False
        Me.UcnJackDsp1.FlexPointR = 0!
        Me.UcnJackDsp1.FlexPointSeater = 0!
        Me.UcnJackDsp1.FlexPointX = 0!
        Me.UcnJackDsp1.FlexPointY = 0!
        Me.UcnJackDsp1.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UcnJackDsp1.GroupPV = New Single() {0!}
        Me.UcnJackDsp1.JackGroupPos = Nothing
        Me.UcnJackDsp1.JackStatus = New Short() {CType(0, Short)}
        Me.UcnJackDsp1.Location = New System.Drawing.Point(643, 154)
        Me.UcnJackDsp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcnJackDsp1.Name = "UcnJackDsp1"
        Me.UcnJackDsp1.NumberGroup = CType(0, Short)
        Me.UcnJackDsp1.NumberJack = CType(0, Short)
        Me.UcnJackDsp1.Size = New System.Drawing.Size(779, 697)
        Me.UcnJackDsp1.TabIndex = 73
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(750, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 22)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1575, 766)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UcnJackDsp1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UcnJackDsp1 As FLEX.NET.ucnJackDsp
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
