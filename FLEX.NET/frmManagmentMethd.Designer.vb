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
        Me.LosZeroRollingTake = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn1 = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn2 = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn3 = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn4 = New FLEX.NET.ucnRdBtn()
        Me.UcnRdBtn5 = New FLEX.NET.ucnRdBtn()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(234, 379)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(355, 379)
        '
        'LosZeroRollingTake
        '
        Me.LosZeroRollingTake.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroRollingTake.FieldName = "目標値の設定"
        Me.LosZeroRollingTake.Location = New System.Drawing.Point(25, 24)
        Me.LosZeroRollingTake.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroRollingTake.Name = "LosZeroRollingTake"
        Me.LosZeroRollingTake.rdbtnValue = False
        Me.LosZeroRollingTake.Size = New System.Drawing.Size(419, 34)
        Me.LosZeroRollingTake.SlectNoName = "リング終値"
        Me.LosZeroRollingTake.SlectYesName = "補正値"
        Me.LosZeroRollingTake.TabIndex = 37
        '
        'UcnRdBtn1
        '
        Me.UcnRdBtn1.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn1.FieldName = "自動更新"
        Me.UcnRdBtn1.Location = New System.Drawing.Point(25, 65)
        Me.UcnRdBtn1.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn1.Name = "UcnRdBtn1"
        Me.UcnRdBtn1.rdbtnValue = False
        Me.UcnRdBtn1.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn1.SlectNoName = "する"
        Me.UcnRdBtn1.SlectYesName = "しない"
        Me.UcnRdBtn1.TabIndex = 38
        '
        'UcnRdBtn2
        '
        Me.UcnRdBtn2.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn2.FieldName = "自動測量データ"
        Me.UcnRdBtn2.Location = New System.Drawing.Point(25, 106)
        Me.UcnRdBtn2.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn2.Name = "UcnRdBtn2"
        Me.UcnRdBtn2.rdbtnValue = False
        Me.UcnRdBtn2.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn2.SlectNoName = "採用しない"
        Me.UcnRdBtn2.SlectYesName = "採用"
        Me.UcnRdBtn2.TabIndex = 39
        '
        'UcnRdBtn3
        '
        Me.UcnRdBtn3.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn3.FieldName = "水平角偏差"
        Me.UcnRdBtn3.Location = New System.Drawing.Point(25, 169)
        Me.UcnRdBtn3.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn3.Name = "UcnRdBtn3"
        Me.UcnRdBtn3.rdbtnValue = False
        Me.UcnRdBtn3.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn3.SlectNoName = "ジャイロ"
        Me.UcnRdBtn3.SlectYesName = "ｽﾄﾛｰｸ計"
        Me.UcnRdBtn3.TabIndex = 40
        '
        'UcnRdBtn4
        '
        Me.UcnRdBtn4.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn4.FieldName = "管理方法"
        Me.UcnRdBtn4.Location = New System.Drawing.Point(25, 207)
        Me.UcnRdBtn4.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn4.Name = "UcnRdBtn4"
        Me.UcnRdBtn4.rdbtnValue = False
        Me.UcnRdBtn4.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn4.SlectNoName = "ｽﾄﾛｰｸ差"
        Me.UcnRdBtn4.SlectYesName = "方位角"
        Me.UcnRdBtn4.TabIndex = 41
        '
        'UcnRdBtn5
        '
        Me.UcnRdBtn5.BackColor = System.Drawing.Color.Transparent
        Me.UcnRdBtn5.FieldName = "方位角の基準"
        Me.UcnRdBtn5.Location = New System.Drawing.Point(25, 292)
        Me.UcnRdBtn5.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnRdBtn5.Name = "UcnRdBtn5"
        Me.UcnRdBtn5.rdbtnValue = False
        Me.UcnRdBtn5.Size = New System.Drawing.Size(419, 34)
        Me.UcnRdBtn5.SlectNoName = "ｾｸﾞﾒﾝﾄ面"
        Me.UcnRdBtn5.SlectYesName = "自動測量"
        Me.UcnRdBtn5.TabIndex = 42
        '
        'frmManagmentMethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(483, 436)
        Me.Controls.Add(Me.UcnRdBtn5)
        Me.Controls.Add(Me.UcnRdBtn4)
        Me.Controls.Add(Me.UcnRdBtn3)
        Me.Controls.Add(Me.UcnRdBtn2)
        Me.Controls.Add(Me.UcnRdBtn1)
        Me.Controls.Add(Me.LosZeroRollingTake)
        Me.Name = "frmManagmentMethd"
        Me.Text = "管理方法"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.LosZeroRollingTake, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn1, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn2, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn3, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn4, 0)
        Me.Controls.SetChildIndex(Me.UcnRdBtn5, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LosZeroRollingTake As ucnRdBtn
    Friend WithEvents UcnRdBtn1 As ucnRdBtn
    Friend WithEvents UcnRdBtn2 As ucnRdBtn
    Friend WithEvents UcnRdBtn3 As ucnRdBtn
    Friend WithEvents UcnRdBtn4 As ucnRdBtn
    Friend WithEvents UcnRdBtn5 As ucnRdBtn
End Class
