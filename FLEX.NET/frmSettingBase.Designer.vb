﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingBase
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(473, 490)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 35)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Silver
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(339, 489)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(109, 35)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmSettingBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(611, 552)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmSettingBase"
        Me.Text = "frmSettingBase"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents btnOK As Button
    Protected WithEvents btnCancel As Button
End Class
