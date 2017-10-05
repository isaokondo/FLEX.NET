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
        Me.numCopyCutEnableStroke = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RightStrokeDiff = New FLEX.NET.ucnRdBtn()
        CType(Me.numCopyNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCopyCutEnableStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(197, 327)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(331, 327)
        '
        'DistanceLoc
        '
        Me.DistanceLoc.BackColor = System.Drawing.Color.Transparent
        Me.DistanceLoc.Enabled = False
        Me.DistanceLoc.FieldName = "総距離の位置"
        Me.DistanceLoc.Location = New System.Drawing.Point(25, 82)
        Me.DistanceLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.DistanceLoc.Name = "DistanceLoc"
        Me.DistanceLoc.rdbtnValue = False
        Me.DistanceLoc.Selectable = True
        Me.DistanceLoc.Size = New System.Drawing.Size(408, 34)
        Me.DistanceLoc.SlectNoName = "しない"
        Me.DistanceLoc.SlectYesName = "する"
        Me.DistanceLoc.TabIndex = 36
        '
        'VerticalUnit
        '
        Me.VerticalUnit.BackColor = System.Drawing.Color.Transparent
        Me.VerticalUnit.Enabled = False
        Me.VerticalUnit.FieldName = "鉛直角の単位"
        Me.VerticalUnit.Location = New System.Drawing.Point(25, 27)
        Me.VerticalUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.VerticalUnit.Name = "VerticalUnit"
        Me.VerticalUnit.rdbtnValue = False
        Me.VerticalUnit.Selectable = True
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
        Me.numCopyNo.Location = New System.Drawing.Point(255, 143)
        Me.numCopyNo.Margin = New System.Windows.Forms.Padding(2)
        Me.numCopyNo.Name = "numCopyNo"
        Me.numCopyNo.Size = New System.Drawing.Size(107, 26)
        Me.numCopyNo.TabIndex = 38
        Me.numCopyNo.TabStop = False
        Me.numCopyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCopyCutEnableStroke
        '
        Me.numCopyCutEnableStroke.BackColor = System.Drawing.Color.Black
        Me.numCopyCutEnableStroke.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.numCopyCutEnableStroke.ForeColor = System.Drawing.Color.White
        Me.numCopyCutEnableStroke.Location = New System.Drawing.Point(255, 206)
        Me.numCopyCutEnableStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.numCopyCutEnableStroke.Name = "numCopyCutEnableStroke"
        Me.numCopyCutEnableStroke.Size = New System.Drawing.Size(107, 26)
        Me.numCopyCutEnableStroke.TabIndex = 40
        Me.numCopyCutEnableStroke.TabStop = False
        Me.numCopyCutEnableStroke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "コピーカッタ有効ストローク"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(378, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "mm"
        '
        'RightStrokeDiff
        '
        Me.RightStrokeDiff.BackColor = System.Drawing.Color.Transparent
        Me.RightStrokeDiff.FieldName = "ストローク差"
        Me.RightStrokeDiff.Location = New System.Drawing.Point(25, 256)
        Me.RightStrokeDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.RightStrokeDiff.Name = "RightStrokeDiff"
        Me.RightStrokeDiff.rdbtnValue = False
        Me.RightStrokeDiff.Selectable = True
        Me.RightStrokeDiff.Size = New System.Drawing.Size(408, 34)
        Me.RightStrokeDiff.SlectNoName = "左勝ち"
        Me.RightStrokeDiff.SlectYesName = "右勝ち"
        Me.RightStrokeDiff.TabIndex = 42
        '
        'frmDspSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 382)
        Me.Controls.Add(Me.RightStrokeDiff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numCopyCutEnableStroke)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.numCopyCutEnableStroke, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.RightStrokeDiff, 0)
        CType(Me.numCopyNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCopyCutEnableStroke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DistanceLoc As ucnRdBtn
    Friend WithEvents VerticalUnit As ucnRdBtn
    Private WithEvents lblFieldName As Label
    Friend WithEvents numCopyNo As NumericUpDown
    Friend WithEvents numCopyCutEnableStroke As NumericUpDown
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents RightStrokeDiff As ucnRdBtn
End Class
