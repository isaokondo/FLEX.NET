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
        Me.UcnJackDsp1 = New FLEX.NET.ucnJackDsp()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UcnJackDsp1
        '
        Me.UcnJackDsp1.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp1.FaiJack = Nothing
        Me.UcnJackDsp1.GroupPV = New Single() {0!}
        Me.UcnJackDsp1.JackGroupPos = Nothing
        Me.UcnJackDsp1.Location = New System.Drawing.Point(275, 92)
        Me.UcnJackDsp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcnJackDsp1.Name = "UcnJackDsp1"
        Me.UcnJackDsp1.NumberGroup = CType(0, Short)
        Me.UcnJackDsp1.NumberJack = CType(0, Short)
        Me.UcnJackDsp1.Size = New System.Drawing.Size(676, 584)
        Me.UcnJackDsp1.TabIndex = 71
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.Location = New System.Drawing.Point(44, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 365)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 766)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UcnJackDsp1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents UcnJackDsp1 As FLEX.NET.ucnJackDsp
    Friend WithEvents PictureBox1 As PictureBox
End Class
