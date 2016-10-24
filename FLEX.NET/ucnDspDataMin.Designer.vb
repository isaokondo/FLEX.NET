<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnDspDataMin
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
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Black
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Yellow
        Me.lblData.Location = New System.Drawing.Point(58, 18)
        Me.lblData.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(70, 24)
        Me.lblData.TabIndex = 7
        Me.lblData.Text = "1234"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.Transparent
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(17, 0)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(111, 18)
        Me.lblFieldName.TabIndex = 6
        Me.lblFieldName.Text = "上ST実(mm/min)"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucnDspDataMin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblFieldName)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ucnDspDataMin"
        Me.Size = New System.Drawing.Size(166, 51)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblFieldName As System.Windows.Forms.Label

End Class
