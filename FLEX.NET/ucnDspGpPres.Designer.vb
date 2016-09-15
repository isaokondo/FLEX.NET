<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnDspGpPres
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
        Me.lblData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Black
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Yellow
        Me.lblData.Location = New System.Drawing.Point(0, 0)
        Me.lblData.Margin = New System.Windows.Forms.Padding(0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(38, 16)
        Me.lblData.TabIndex = 8
        Me.lblData.Text = "99.9"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucnDspGpPres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblData)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ucnDspGpPres"
        Me.Size = New System.Drawing.Size(50, 24)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblData As System.Windows.Forms.Label

End Class
