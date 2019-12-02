<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNextPieceConfirm
    Inherits frmSettingBase

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblNextPieceNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK.Location = New System.Drawing.Point(448, 269)
        Me.btnOK.Size = New System.Drawing.Size(149, 45)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(639, 38)
        Me.btnCancel.Text = "閉じる"
        Me.btnCancel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(676, 64)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "同時施工継続しますか？"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(626, 269)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 45)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblNextPieceNo
        '
        Me.lblNextPieceNo.AutoSize = True
        Me.lblNextPieceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNextPieceNo.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNextPieceNo.ForeColor = System.Drawing.Color.Black
        Me.lblNextPieceNo.Location = New System.Drawing.Point(68, 50)
        Me.lblNextPieceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNextPieceNo.Name = "lblNextPieceNo"
        Me.lblNextPieceNo.Size = New System.Drawing.Size(304, 64)
        Me.lblNextPieceNo.TabIndex = 11
        Me.lblNextPieceNo.Text = "＿＿ピース"
        '
        'frmNextPieceConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(796, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNextPieceNo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNextPieceConfirm"
        Me.Text = "同時施工継続"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.lblNextPieceNo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Protected WithEvents btnClose As Button
    Friend WithEvents lblNextPieceNo As Label
End Class
