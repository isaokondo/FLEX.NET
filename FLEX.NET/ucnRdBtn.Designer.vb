<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnRdBtn
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
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.rdbtnNo = New System.Windows.Forms.RadioButton()
        Me.rdbtnYes = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.BackColor = System.Drawing.Color.Gray
        Me.lblFieldName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ForeColor = System.Drawing.Color.White
        Me.lblFieldName.Location = New System.Drawing.Point(5, 12)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(139, 16)
        Me.lblFieldName.TabIndex = 0
        Me.lblFieldName.Text = "ダイレクト指令制御"
        '
        'rdbtnNo
        '
        Me.rdbtnNo.AutoSize = True
        Me.rdbtnNo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbtnNo.ForeColor = System.Drawing.Color.White
        Me.rdbtnNo.Location = New System.Drawing.Point(189, 10)
        Me.rdbtnNo.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnNo.Name = "rdbtnNo"
        Me.rdbtnNo.Size = New System.Drawing.Size(68, 20)
        Me.rdbtnNo.TabIndex = 1
        Me.rdbtnNo.Text = "しない"
        Me.rdbtnNo.UseVisualStyleBackColor = True
        '
        'rdbtnYes
        '
        Me.rdbtnYes.AutoSize = True
        Me.rdbtnYes.Checked = True
        Me.rdbtnYes.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbtnYes.ForeColor = System.Drawing.Color.White
        Me.rdbtnYes.Location = New System.Drawing.Point(300, 10)
        Me.rdbtnYes.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnYes.Name = "rdbtnYes"
        Me.rdbtnYes.Size = New System.Drawing.Size(54, 20)
        Me.rdbtnYes.TabIndex = 2
        Me.rdbtnYes.TabStop = True
        Me.rdbtnYes.Text = "する"
        Me.rdbtnYes.UseVisualStyleBackColor = True
        '
        'ucnRdBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.rdbtnYes)
        Me.Controls.Add(Me.rdbtnNo)
        Me.Controls.Add(Me.lblFieldName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ucnRdBtn"
        Me.Size = New System.Drawing.Size(425, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblFieldName As Label
    Friend WithEvents rdbtnNo As RadioButton
    Friend WithEvents rdbtnYes As RadioButton
End Class
