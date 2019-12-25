<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNetStrokeChange
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
        Me.NetStrokeEdt = New FLEX.NET.ucnNumEdit()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(163, 140)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(289, 142)
        '
        'NetStrokeEdt
        '
        Me.NetStrokeEdt.DataDspWidth = 110
        Me.NetStrokeEdt.DecimalPlaces = CType(0, Short)
        Me.NetStrokeEdt.DspFieldName = False
        Me.NetStrokeEdt.FieldName = Nothing
        Me.NetStrokeEdt.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.NetStrokeEdt.Increment = 1.0!
        Me.NetStrokeEdt.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.NetStrokeEdt.Location = New System.Drawing.Point(89, 91)
        Me.NetStrokeEdt.Margin = New System.Windows.Forms.Padding(7)
        Me.NetStrokeEdt.MaxValue = "10000"
        Me.NetStrokeEdt.MinValue = "0"
        Me.NetStrokeEdt.Name = "NetStrokeEdt"
        Me.NetStrokeEdt.SelectItem = Nothing
        Me.NetStrokeEdt.Size = New System.Drawing.Size(256, 40)
        Me.NetStrokeEdt.TabIndex = 9
        Me.NetStrokeEdt.ttMsg = ""
        Me.NetStrokeEdt.ttTile = ""
        Me.NetStrokeEdt.Unit = "mm"
        Me.NetStrokeEdt.Value = 0R
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.Yellow
        Me.lblText.Location = New System.Drawing.Point(11, 13)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(413, 71)
        Me.lblText.TabIndex = 10
        Me.lblText.Text = "このリングのセグメント幅が600mmから1200mmに" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "変更になります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "推進量が異なる場合は、変更してください。"
        '
        'frmNetStrokeChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 198)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.NetStrokeEdt)
        Me.Name = "frmNetStrokeChange"
        Me.Text = "目標推進量の変更"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.NetStrokeEdt, 0)
        Me.Controls.SetChildIndex(Me.lblText, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NetStrokeEdt As ucnNumEdit
    Friend WithEvents lblText As Label
End Class
