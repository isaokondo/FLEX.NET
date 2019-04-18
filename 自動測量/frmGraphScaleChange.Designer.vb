<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphScaleChange
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudHighScale = New System.Windows.Forms.NumericUpDown()
        Me.nudLowScale = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudHighScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLowScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(136, 136)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 67
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(217, 136)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(55, 136)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 69
        Me.btnApply.Text = "適用"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label109
        '
        Me.Label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label109.Location = New System.Drawing.Point(39, 33)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(141, 30)
        Me.Label109.TabIndex = 204
        Me.Label109.Text = "グラフ上限スケール(ｍm)　"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(39, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 30)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "グラフ下限スケール(ｍm)　"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudHighScale
        '
        Me.nudHighScale.Location = New System.Drawing.Point(186, 40)
        Me.nudHighScale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudHighScale.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.nudHighScale.Name = "nudHighScale"
        Me.nudHighScale.Size = New System.Drawing.Size(85, 19)
        Me.nudHighScale.TabIndex = 208
        Me.nudHighScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLowScale
        '
        Me.nudLowScale.Location = New System.Drawing.Point(186, 89)
        Me.nudLowScale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudLowScale.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.nudLowScale.Name = "nudLowScale"
        Me.nudLowScale.Size = New System.Drawing.Size(85, 19)
        Me.nudLowScale.TabIndex = 209
        Me.nudLowScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmGraphScaleChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.nudLowScale)
        Me.Controls.Add(Me.nudHighScale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGraphScaleChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "グラフスケール変更"
        CType(Me.nudHighScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLowScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents Label109 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudHighScale As NumericUpDown
    Friend WithEvents nudLowScale As NumericUpDown
End Class
