<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevImgScaleChange
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.nudHighScale = New System.Windows.Forms.NumericUpDown()
        Me.Label109 = New System.Windows.Forms.Label()
        CType(Me.nudHighScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(43, 94)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 72
        Me.btnApply.Text = "適用"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(205, 94)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(124, 94)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 70
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'nudHighScale
        '
        Me.nudHighScale.Location = New System.Drawing.Point(205, 29)
        Me.nudHighScale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudHighScale.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.nudHighScale.Name = "nudHighScale"
        Me.nudHighScale.Size = New System.Drawing.Size(85, 19)
        Me.nudHighScale.TabIndex = 210
        Me.nudHighScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label109
        '
        Me.Label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label109.Location = New System.Drawing.Point(28, 22)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(159, 30)
        Me.Label109.TabIndex = 209
        Me.Label109.Text = "偏差イメージスケール(ｍm)　"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDevImgScaleChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.nudHighScale)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmDevImgScaleChange"
        Me.Text = "偏差イメージスケール変更"
        CType(Me.nudHighScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents nudHighScale As NumericUpDown
    Friend WithEvents Label109 As Label
End Class
