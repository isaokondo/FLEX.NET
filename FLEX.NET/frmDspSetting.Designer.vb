<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDspSetting
    Inherits frmSettingBase

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
        Me.DistanceLoc = New FLEX.NET.ucnRdBtn()
        Me.VerticalUnit = New FLEX.NET.ucnRdBtn()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.numCopyNo = New System.Windows.Forms.NumericUpDown()
        CType(Me.numCopyNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(190, 213)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(316, 215)
        '
        'DistanceLoc
        '
        Me.DistanceLoc.BackColor = System.Drawing.Color.Transparent
        Me.DistanceLoc.FieldName = "総距離の位置"
        Me.DistanceLoc.Location = New System.Drawing.Point(25, 82)
        Me.DistanceLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.DistanceLoc.Name = "DistanceLoc"
        Me.DistanceLoc.rdbtnValue = False
        Me.DistanceLoc.Size = New System.Drawing.Size(408, 34)
        Me.DistanceLoc.SlectNoName = "しない"
        Me.DistanceLoc.SlectYesName = "する"
        Me.DistanceLoc.TabIndex = 36
        '
        'VerticalUnit
        '
        Me.VerticalUnit.BackColor = System.Drawing.Color.Transparent
        Me.VerticalUnit.FieldName = "鉛直角の単位"
        Me.VerticalUnit.Location = New System.Drawing.Point(25, 27)
        Me.VerticalUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.VerticalUnit.Name = "VerticalUnit"
        Me.VerticalUnit.rdbtnValue = False
        Me.VerticalUnit.Size = New System.Drawing.Size(408, 34)
        Me.VerticalUnit.SlectNoName = "deg"
        Me.VerticalUnit.SlectYesName = "‰"
        Me.VerticalUnit.TabIndex = 35
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ForeColor = System.Drawing.Color.White
        Me.lblFieldName.Location = New System.Drawing.Point(32, 147)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(101, 16)
        Me.lblFieldName.TabIndex = 37
        Me.lblFieldName.Text = "コピー表示No"
        '
        'numCopyNo
        '
        Me.numCopyNo.BackColor = System.Drawing.Color.Black
        Me.numCopyNo.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.numCopyNo.ForeColor = System.Drawing.Color.White
        Me.numCopyNo.Location = New System.Drawing.Point(189, 143)
        Me.numCopyNo.Margin = New System.Windows.Forms.Padding(2)
        Me.numCopyNo.Name = "numCopyNo"
        Me.numCopyNo.Size = New System.Drawing.Size(107, 26)
        Me.numCopyNo.TabIndex = 38
        Me.numCopyNo.TabStop = False
        Me.numCopyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmDspSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 285)
        Me.Controls.Add(Me.numCopyNo)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.DistanceLoc)
        Me.Controls.Add(Me.VerticalUnit)
        Me.Name = "frmDspSetting"
        Me.Text = "各種表示"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.VerticalUnit, 0)
        Me.Controls.SetChildIndex(Me.DistanceLoc, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.Controls.SetChildIndex(Me.numCopyNo, 0)
        CType(Me.numCopyNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DistanceLoc As ucnRdBtn
    Friend WithEvents VerticalUnit As ucnRdBtn
    Private WithEvents lblFieldName As Label
    Friend WithEvents numCopyNo As NumericUpDown
End Class
