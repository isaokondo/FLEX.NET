<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherSetting
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
        Me.StartPowerPointPosition = New FLEX.NET.ucnRdBtn()
        Me.JackCullControl = New FLEX.NET.ucnRdBtn()
        Me.ClearanceMeterExist = New FLEX.NET.ucnRdBtn()
        Me.PitchingSelect = New FLEX.NET.ucnRdBtn()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(187, 275)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(324, 276)
        '
        'StartPowerPointPosition
        '
        Me.StartPowerPointPosition.BackColor = System.Drawing.Color.Transparent
        Me.StartPowerPointPosition.FieldName = "開始時の力点位置"
        Me.StartPowerPointPosition.Location = New System.Drawing.Point(18, 86)
        Me.StartPowerPointPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.StartPowerPointPosition.Name = "StartPowerPointPosition"
        Me.StartPowerPointPosition.rdbtnValue = False
        Me.StartPowerPointPosition.Size = New System.Drawing.Size(408, 34)
        Me.StartPowerPointPosition.SlectNoName = "前回保持"
        Me.StartPowerPointPosition.SlectYesName = "全押し"
        Me.StartPowerPointPosition.TabIndex = 31
        '
        'JackCullControl
        '
        Me.JackCullControl.BackColor = System.Drawing.Color.Transparent
        Me.JackCullControl.FieldName = "ジャッキの間引き制御"
        Me.JackCullControl.Location = New System.Drawing.Point(18, 195)
        Me.JackCullControl.Margin = New System.Windows.Forms.Padding(2)
        Me.JackCullControl.Name = "JackCullControl"
        Me.JackCullControl.rdbtnValue = False
        Me.JackCullControl.Size = New System.Drawing.Size(408, 34)
        Me.JackCullControl.SlectNoName = "しない"
        Me.JackCullControl.SlectYesName = "する"
        Me.JackCullControl.TabIndex = 34
        Me.JackCullControl.Visible = False
        '
        'ClearanceMeterExist
        '
        Me.ClearanceMeterExist.BackColor = System.Drawing.Color.Transparent
        Me.ClearanceMeterExist.FieldName = "クリアランス計"
        Me.ClearanceMeterExist.Location = New System.Drawing.Point(18, 141)
        Me.ClearanceMeterExist.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearanceMeterExist.Name = "ClearanceMeterExist"
        Me.ClearanceMeterExist.rdbtnValue = False
        Me.ClearanceMeterExist.Size = New System.Drawing.Size(408, 34)
        Me.ClearanceMeterExist.SlectNoName = "なし"
        Me.ClearanceMeterExist.SlectYesName = "あり"
        Me.ClearanceMeterExist.TabIndex = 35
        Me.ClearanceMeterExist.Visible = False
        '
        'PitchingSelect
        '
        Me.PitchingSelect.BackColor = System.Drawing.Color.Transparent
        Me.PitchingSelect.FieldName = "ピッチングの選択"
        Me.PitchingSelect.Location = New System.Drawing.Point(18, 32)
        Me.PitchingSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.PitchingSelect.Name = "PitchingSelect"
        Me.PitchingSelect.rdbtnValue = False
        Me.PitchingSelect.Size = New System.Drawing.Size(425, 34)
        Me.PitchingSelect.SlectNoName = "ジャイロ"
        Me.PitchingSelect.SlectYesName = "シールドマシン"
        Me.PitchingSelect.TabIndex = 36
        '
        'frmOtherSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(454, 339)
        Me.Controls.Add(Me.PitchingSelect)
        Me.Controls.Add(Me.ClearanceMeterExist)
        Me.Controls.Add(Me.JackCullControl)
        Me.Controls.Add(Me.StartPowerPointPosition)
        Me.Name = "frmOtherSetting"
        Me.Text = "その他"
        Me.Controls.SetChildIndex(Me.StartPowerPointPosition, 0)
        Me.Controls.SetChildIndex(Me.JackCullControl, 0)
        Me.Controls.SetChildIndex(Me.ClearanceMeterExist, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.PitchingSelect, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartPowerPointPosition As ucnRdBtn
    Friend WithEvents JackCullControl As ucnRdBtn
    Friend WithEvents ClearanceMeterExist As ucnRdBtn
    Friend WithEvents PitchingSelect As ucnRdBtn
End Class
