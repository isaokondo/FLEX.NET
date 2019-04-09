<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblExecStatus = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer()
        Me.lblNowDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExecStatus
        '
        Me.lblExecStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblExecStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExecStatus.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExecStatus.Location = New System.Drawing.Point(116, 30)
        Me.lblExecStatus.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblExecStatus.Name = "lblExecStatus"
        Me.lblExecStatus.Size = New System.Drawing.Size(126, 30)
        Me.lblExecStatus.TabIndex = 6
        Me.lblExecStatus.Text = "待 機"
        Me.lblExecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 5000
        '
        'lblNowDate
        '
        Me.lblNowDate.BackColor = System.Drawing.Color.Transparent
        Me.lblNowDate.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNowDate.Location = New System.Drawing.Point(616, 30)
        Me.lblNowDate.Name = "lblNowDate"
        Me.lblNowDate.Size = New System.Drawing.Size(240, 19)
        Me.lblNowDate.TabIndex = 139
        Me.lblNowDate.Text = "9999／99／99　99：99：99"
        Me.lblNowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 528)
        Me.Controls.Add(Me.lblNowDate)
        Me.Controls.Add(Me.lblExecStatus)
        Me.Name = "frmMain"
        Me.Text = "FLEX DataBaseBakup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblExecStatus As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents lblNowDate As Label
End Class
