<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnSpredCompnent
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
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.White
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFieldName.Location = New System.Drawing.Point(1, 0)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFieldName.Size = New System.Drawing.Size(240, 22)
        Me.lblFieldName.TabIndex = 9
        Me.lblFieldName.Text = "確認リングの先端距離"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.White
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.Location = New System.Drawing.Point(240, 0)
        Me.lblData.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lblData.Size = New System.Drawing.Size(128, 22)
        Me.lblData.TabIndex = 10
        Me.lblData.Text = "12345"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.White
        Me.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(367, 0)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(76, 22)
        Me.lblUnit.TabIndex = 11
        Me.lblUnit.Text = "mm"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucnSpredCompnent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblFieldName)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ucnSpredCompnent"
        Me.Size = New System.Drawing.Size(448, 26)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label

End Class
