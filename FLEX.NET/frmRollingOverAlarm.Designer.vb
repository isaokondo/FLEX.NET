<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRollingOverAlarm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblRollingAlarm = New System.Windows.Forms.Label()
        Me.tmrBlink = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoszeroRollingTolerance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Silver
        Me.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfirm.Location = New System.Drawing.Point(356, 114)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(102, 35)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "確認"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'lblRollingAlarm
        '
        Me.lblRollingAlarm.BackColor = System.Drawing.Color.Transparent
        Me.lblRollingAlarm.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblRollingAlarm.ForeColor = System.Drawing.Color.Red
        Me.lblRollingAlarm.Location = New System.Drawing.Point(20, 9)
        Me.lblRollingAlarm.Name = "lblRollingAlarm"
        Me.lblRollingAlarm.Size = New System.Drawing.Size(438, 103)
        Me.lblRollingAlarm.TabIndex = 164
        Me.lblRollingAlarm.Text = "マシンローリングの余裕限界を超えました。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "セグメントピースとジャッキスプレッダーが" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "干渉する恐れがあります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "注意してください！!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrBlink
        '
        Me.tmrBlink.Enabled = True
        Me.tmrBlink.Interval = 1000
        '
        'lblLoszeroRollingTolerance
        '
        Me.lblLoszeroRollingTolerance.AutoSize = True
        Me.lblLoszeroRollingTolerance.BackColor = System.Drawing.Color.Transparent
        Me.lblLoszeroRollingTolerance.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblLoszeroRollingTolerance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLoszeroRollingTolerance.Location = New System.Drawing.Point(35, 125)
        Me.lblLoszeroRollingTolerance.Name = "lblLoszeroRollingTolerance"
        Me.lblLoszeroRollingTolerance.Size = New System.Drawing.Size(144, 19)
        Me.lblLoszeroRollingTolerance.TabIndex = 166
        Me.lblLoszeroRollingTolerance.Text = "ローリング許容値"
        '
        'frmRollingOverAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(476, 163)
        Me.Controls.Add(Me.lblLoszeroRollingTolerance)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblRollingAlarm)
        Me.MinimizeBox = False
        Me.Name = "frmRollingOverAlarm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "マシンローリング注意！"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents btnConfirm As Button
    Friend WithEvents tmrBlink As Timer
    Protected WithEvents lblRollingAlarm As Label
    Friend WithEvents lblLoszeroRollingTolerance As Label
End Class
