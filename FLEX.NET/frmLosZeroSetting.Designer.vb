<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLosZeroSetting
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
        Me.LosZeroOpposeControl = New FLEX.NET.ucnRdBtn()
        Me.LosZeroOpposeJack = New FLEX.NET.ucnRdBtn()
        Me.LosZeroRollingTake = New FLEX.NET.ucnRdBtn()
        Me.ReduceJudgePress = New FLEX.NET.ucnNumEdit()
        Me.ReduceTime = New FLEX.NET.ucnNumEdit()
        Me.NextPieceConfirm = New FLEX.NET.ucnRdBtn()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(181, 373)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(315, 374)
        '
        'LosZeroOpposeControl
        '
        Me.LosZeroOpposeControl.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroOpposeControl.FieldName = "対抗圧制御"
        Me.LosZeroOpposeControl.Location = New System.Drawing.Point(21, 112)
        Me.LosZeroOpposeControl.Name = "LosZeroOpposeControl"
        Me.LosZeroOpposeControl.rdbtnValue = False
        Me.LosZeroOpposeControl.Size = New System.Drawing.Size(403, 42)
        Me.LosZeroOpposeControl.SlectNoName = "する"
        Me.LosZeroOpposeControl.SlectYesName = "しない"
        Me.LosZeroOpposeControl.TabIndex = 38
        '
        'LosZeroOpposeJack
        '
        Me.LosZeroOpposeJack.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroOpposeJack.FieldName = "対抗ジャッキ選択"
        Me.LosZeroOpposeJack.Location = New System.Drawing.Point(21, 62)
        Me.LosZeroOpposeJack.Name = "LosZeroOpposeJack"
        Me.LosZeroOpposeJack.rdbtnValue = False
        Me.LosZeroOpposeJack.Size = New System.Drawing.Size(403, 42)
        Me.LosZeroOpposeJack.SlectNoName = "する"
        Me.LosZeroOpposeJack.SlectYesName = "しない"
        Me.LosZeroOpposeJack.TabIndex = 37
        '
        'LosZeroRollingTake
        '
        Me.LosZeroRollingTake.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroRollingTake.FieldName = "ローリングの考慮"
        Me.LosZeroRollingTake.Location = New System.Drawing.Point(21, 12)
        Me.LosZeroRollingTake.Name = "LosZeroRollingTake"
        Me.LosZeroRollingTake.rdbtnValue = False
        Me.LosZeroRollingTake.Size = New System.Drawing.Size(403, 42)
        Me.LosZeroRollingTake.SlectNoName = "する"
        Me.LosZeroRollingTake.SlectYesName = "しない"
        Me.LosZeroRollingTake.TabIndex = 36
        '
        'ReduceJudgePress
        '
        Me.ReduceJudgePress.DataDspWidth = 120
        Me.ReduceJudgePress.DecimalPlaces = CType(1, Short)
        Me.ReduceJudgePress.DspFieldName = True
        Me.ReduceJudgePress.FieldName = "減圧完了判断圧力"
        Me.ReduceJudgePress.Increment = 1.0!
        Me.ReduceJudgePress.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ReduceJudgePress.Location = New System.Drawing.Point(16, 302)
        Me.ReduceJudgePress.MaxValue = "50"
        Me.ReduceJudgePress.MinValue = "0"
        Me.ReduceJudgePress.Name = "ReduceJudgePress"
        Me.ReduceJudgePress.SelectItem = Nothing
        Me.ReduceJudgePress.Size = New System.Drawing.Size(414, 49)
        Me.ReduceJudgePress.TabIndex = 40
        Me.ReduceJudgePress.Unit = "MPa"
        Me.ReduceJudgePress.Value = 0R
        '
        'ReduceTime
        '
        Me.ReduceTime.DataDspWidth = 120
        Me.ReduceTime.DecimalPlaces = CType(0, Short)
        Me.ReduceTime.DspFieldName = True
        Me.ReduceTime.FieldName = "減圧時間"
        Me.ReduceTime.Increment = 1.0!
        Me.ReduceTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ReduceTime.Location = New System.Drawing.Point(16, 244)
        Me.ReduceTime.MaxValue = "60"
        Me.ReduceTime.MinValue = "0"
        Me.ReduceTime.Name = "ReduceTime"
        Me.ReduceTime.SelectItem = Nothing
        Me.ReduceTime.Size = New System.Drawing.Size(414, 49)
        Me.ReduceTime.TabIndex = 39
        Me.ReduceTime.Unit = "sec"
        Me.ReduceTime.Value = 0R
        '
        'NextPieceConfirm
        '
        Me.NextPieceConfirm.BackColor = System.Drawing.Color.Transparent
        Me.NextPieceConfirm.FieldName = "次ピース組立確認"
        Me.NextPieceConfirm.Location = New System.Drawing.Point(21, 162)
        Me.NextPieceConfirm.Name = "NextPieceConfirm"
        Me.NextPieceConfirm.rdbtnValue = False
        Me.NextPieceConfirm.Size = New System.Drawing.Size(403, 42)
        Me.NextPieceConfirm.SlectNoName = "する"
        Me.NextPieceConfirm.SlectYesName = "しない"
        Me.NextPieceConfirm.TabIndex = 41
        '
        'frmLosZeroSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 451)
        Me.Controls.Add(Me.ReduceTime)
        Me.Controls.Add(Me.NextPieceConfirm)
        Me.Controls.Add(Me.ReduceJudgePress)
        Me.Controls.Add(Me.LosZeroOpposeControl)
        Me.Controls.Add(Me.LosZeroOpposeJack)
        Me.Controls.Add(Me.LosZeroRollingTake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLosZeroSetting"
        Me.Text = "同時施工関連"
        Me.Controls.SetChildIndex(Me.LosZeroRollingTake, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeJack, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeControl, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.ReduceJudgePress, 0)
        Me.Controls.SetChildIndex(Me.NextPieceConfirm, 0)
        Me.Controls.SetChildIndex(Me.ReduceTime, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LosZeroOpposeControl As ucnRdBtn
    Friend WithEvents LosZeroOpposeJack As ucnRdBtn
    Friend WithEvents LosZeroRollingTake As ucnRdBtn
    Friend WithEvents ReduceJudgePress As ucnNumEdit
    Friend WithEvents ReduceTime As ucnNumEdit
    Friend WithEvents NextPieceConfirm As ucnRdBtn
End Class
