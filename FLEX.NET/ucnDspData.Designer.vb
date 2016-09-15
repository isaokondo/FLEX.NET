<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnDspData
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.tmrBlink = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.LightGray
        Me.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnit.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(236, 0)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(70, 32)
        Me.lblUnit.TabIndex = 6
        Me.lblUnit.Text = "mm/min"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Black
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Yellow
        Me.lblData.Location = New System.Drawing.Point(146, 0)
        Me.lblData.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(91, 32)
        Me.lblData.TabIndex = 5
        Me.lblData.Text = "123.45 "
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.LightGray
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(1, 0)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(146, 32)
        Me.lblFieldName.TabIndex = 4
        Me.lblFieldName.Text = " 押込推進ｼﾞｬｯｷ"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrBlink
        '
        Me.tmrBlink.Interval = 1000
        '
        'ucnDspData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblFieldName)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "ucnDspData"
        Me.Size = New System.Drawing.Size(317, 33)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblFieldName As System.Windows.Forms.Label
    Friend WithEvents tmrBlink As Timer
End Class
