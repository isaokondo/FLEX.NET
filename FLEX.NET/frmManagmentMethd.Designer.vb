<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagmentMethd
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
        Me.HorTargetVal = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn2 = New FLEX.NET.ucnRdBtn()
        Me.HorAngleDetection = New FLEX.NET.ucnRdBtn()
        Me.VerTargetVal = New FLEX.NET.ucnRdBtn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(240, 142)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(361, 142)
        '
        'HorTargetVal
        '
        Me.HorTargetVal.BackColor = System.Drawing.Color.Transparent
        Me.HorTargetVal.FieldName = "水平目標値の設定"
        Me.HorTargetVal.Location = New System.Drawing.Point(24, 95)
        Me.HorTargetVal.Margin = New System.Windows.Forms.Padding(2)
        Me.HorTargetVal.Name = "HorTargetVal"
        Me.HorTargetVal.rdbtnValue = False
        Me.HorTargetVal.Selectable = True
        Me.HorTargetVal.Size = New System.Drawing.Size(419, 34)
        Me.HorTargetVal.SlectNoName = "リング終値"
        Me.HorTargetVal.SlectYesName = "補正値"
        Me.HorTargetVal.TabIndex = 37
        Me.HorTargetVal.Visible = False
        '
        'UcnRdBtn2
        '
        Me.UcnRdBtn2.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn2.FieldName = "補正値の自動更新"
        Me.UcnRdBtn2.Location = New System.Drawing.Point(24, 193)
        Me.UcnRdBtn2.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn2.Name = "UcnRdBtn2"
        Me.UcnRdBtn2.rdbtnValue = False
        Me.UcnRdBtn2.Selectable = True
        Me.UcnRdBtn2.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn2.SlectNoName = "しない"
        Me.UcnRdBtn2.SlectYesName = "する"
        Me.UcnRdBtn2.TabIndex = 39
        Me.UcnRdBtn2.Visible = False
        '
        'HorAngleDetection
        '
        Me.HorAngleDetection.BackColor = System.Drawing.Color.Transparent
        Me.HorAngleDetection.FieldName = "水平角検出"
        Me.HorAngleDetection.Location = New System.Drawing.Point(24, 36)
        Me.HorAngleDetection.Margin = New System.Windows.Forms.Padding(2)
        Me.HorAngleDetection.Name = "HorAngleDetection"
        Me.HorAngleDetection.rdbtnValue = False
        Me.HorAngleDetection.Selectable = True
        Me.HorAngleDetection.Size = New System.Drawing.Size(419, 34)
        Me.HorAngleDetection.SlectNoName = "ジャイロ"
        Me.HorAngleDetection.SlectYesName = "ストローク計"
        Me.HorAngleDetection.TabIndex = 42
        '
        'VerTargetVal
        '
        Me.VerTargetVal.BackColor = System.Drawing.Color.Transparent
        Me.VerTargetVal.FieldName = "鉛直目標値の設定"
        Me.VerTargetVal.Location = New System.Drawing.Point(24, 144)
        Me.VerTargetVal.Margin = New System.Windows.Forms.Padding(2)
        Me.VerTargetVal.Name = "VerTargetVal"
        Me.VerTargetVal.rdbtnValue = False
        Me.VerTargetVal.Selectable = True
        Me.VerTargetVal.Size = New System.Drawing.Size(419, 34)
        Me.VerTargetVal.SlectNoName = "リング終値"
        Me.VerTargetVal.SlectYesName = "補正値"
        Me.VerTargetVal.TabIndex = 43
        Me.VerTargetVal.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"方向分析", "自動測量"})
        Me.ComboBox1.Location = New System.Drawing.Point(293, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.Visible = False
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.BackColor = System.Drawing.Color.Gray
        Me.lblFieldName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ForeColor = System.Drawing.Color.White
        Me.lblFieldName.Location = New System.Drawing.Point(206, 234)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(82, 16)
        Me.lblFieldName.TabIndex = 45
        Me.lblFieldName.Text = "採用データ"
        Me.lblFieldName.Visible = False
        '
        'frmManagmentMethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(483, 273)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.VerTargetVal)
        Me.Controls.Add(Me.HorAngleDetection)
        Me.Controls.Add(Me.UcnRdBtn2)
        Me.Controls.Add(Me.HorTargetVal)
        Me.Name = "frmManagmentMethd"
        Me.Text = "管理方法"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.HorTargetVal, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn2, 0)
        Me.Controls.SetChildIndex(Me.HorAngleDetection, 0)
        Me.Controls.SetChildIndex(Me.VerTargetVal, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HorTargetVal As ucnRdBtn
    Friend WithEvents UcnRdBtn2 As ucnRdBtn
    Friend WithEvents HorAngleDetection As ucnRdBtn
    Friend WithEvents VerTargetVal As ucnRdBtn
    Friend WithEvents ComboBox1 As ComboBox
    Private WithEvents lblFieldName As Label
End Class
