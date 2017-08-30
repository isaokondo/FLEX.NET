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
        Me.LosZeroNlp = New FLEX.NET.ucnNumEdit()
        Me.LosZeroEmp = New FLEX.NET.ucnNumEdit()
        Me.LoszerorStep = New FLEX.NET.ucnNumEdit()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NextPieceConfirmTime = New FLEX.NET.ucnNumEdit()
        Me.LosZeroOpposeGroupNumber = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(204, 625)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(328, 625)
        '
        'LosZeroOpposeControl
        '
        Me.LosZeroOpposeControl.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroOpposeControl.FieldName = "対抗圧制御"
        Me.LosZeroOpposeControl.Location = New System.Drawing.Point(16, 116)
        Me.LosZeroOpposeControl.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroOpposeControl.Name = "LosZeroOpposeControl"
        Me.LosZeroOpposeControl.rdbtnValue = False
        Me.LosZeroOpposeControl.Selectable = True
        Me.LosZeroOpposeControl.Size = New System.Drawing.Size(389, 34)
        Me.LosZeroOpposeControl.SlectNoName = "する"
        Me.LosZeroOpposeControl.SlectYesName = "しない"
        Me.LosZeroOpposeControl.TabIndex = 38
        '
        'LosZeroOpposeJack
        '
        Me.LosZeroOpposeJack.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroOpposeJack.FieldName = "対抗ジャッキ選択"
        Me.LosZeroOpposeJack.Location = New System.Drawing.Point(16, 63)
        Me.LosZeroOpposeJack.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroOpposeJack.Name = "LosZeroOpposeJack"
        Me.LosZeroOpposeJack.rdbtnValue = False
        Me.LosZeroOpposeJack.Selectable = True
        Me.LosZeroOpposeJack.Size = New System.Drawing.Size(389, 34)
        Me.LosZeroOpposeJack.SlectNoName = "する"
        Me.LosZeroOpposeJack.SlectYesName = "しない"
        Me.LosZeroOpposeJack.TabIndex = 37
        '
        'LosZeroRollingTake
        '
        Me.LosZeroRollingTake.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroRollingTake.FieldName = "ローリングの考慮"
        Me.LosZeroRollingTake.Location = New System.Drawing.Point(16, 10)
        Me.LosZeroRollingTake.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroRollingTake.Name = "LosZeroRollingTake"
        Me.LosZeroRollingTake.rdbtnValue = False
        Me.LosZeroRollingTake.Selectable = True
        Me.LosZeroRollingTake.Size = New System.Drawing.Size(389, 34)
        Me.LosZeroRollingTake.SlectNoName = "する"
        Me.LosZeroRollingTake.SlectYesName = "しない"
        Me.LosZeroRollingTake.TabIndex = 36
        '
        'ReduceJudgePress
        '
        Me.ReduceJudgePress.DataDspWidth = 110
        Me.ReduceJudgePress.DecimalPlaces = CType(1, Short)
        Me.ReduceJudgePress.DspFieldName = True
        Me.ReduceJudgePress.FieldName = "減圧完了判断圧力"
        Me.ReduceJudgePress.Increment = 1.0!
        Me.ReduceJudgePress.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ReduceJudgePress.Location = New System.Drawing.Point(16, 369)
        Me.ReduceJudgePress.Margin = New System.Windows.Forms.Padding(2)
        Me.ReduceJudgePress.MaxValue = "50"
        Me.ReduceJudgePress.MinValue = "0"
        Me.ReduceJudgePress.Name = "ReduceJudgePress"
        Me.ReduceJudgePress.SelectItem = Nothing
        Me.ReduceJudgePress.Size = New System.Drawing.Size(405, 39)
        Me.ReduceJudgePress.TabIndex = 40
        Me.ReduceJudgePress.ttMsg = ""
        Me.ReduceJudgePress.ttTile = ""
        Me.ReduceJudgePress.Unit = "MPa"
        Me.ReduceJudgePress.Value = 0R
        '
        'ReduceTime
        '
        Me.ReduceTime.DataDspWidth = 110
        Me.ReduceTime.DecimalPlaces = CType(0, Short)
        Me.ReduceTime.DspFieldName = True
        Me.ReduceTime.FieldName = "減圧時間"
        Me.ReduceTime.Increment = 1.0!
        Me.ReduceTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ReduceTime.Location = New System.Drawing.Point(16, 320)
        Me.ReduceTime.Margin = New System.Windows.Forms.Padding(2)
        Me.ReduceTime.MaxValue = "60"
        Me.ReduceTime.MinValue = "0"
        Me.ReduceTime.Name = "ReduceTime"
        Me.ReduceTime.SelectItem = Nothing
        Me.ReduceTime.Size = New System.Drawing.Size(405, 39)
        Me.ReduceTime.TabIndex = 39
        Me.ReduceTime.ttMsg = ""
        Me.ReduceTime.ttTile = ""
        Me.ReduceTime.Unit = "sec"
        Me.ReduceTime.Value = 0R
        '
        'NextPieceConfirm
        '
        Me.NextPieceConfirm.BackColor = System.Drawing.Color.Transparent
        Me.NextPieceConfirm.FieldName = "次ピース組立確認"
        Me.NextPieceConfirm.Location = New System.Drawing.Point(11, 223)
        Me.NextPieceConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.NextPieceConfirm.Name = "NextPieceConfirm"
        Me.NextPieceConfirm.rdbtnValue = False
        Me.NextPieceConfirm.Selectable = True
        Me.NextPieceConfirm.Size = New System.Drawing.Size(389, 34)
        Me.NextPieceConfirm.SlectNoName = "する"
        Me.NextPieceConfirm.SlectYesName = "しない"
        Me.NextPieceConfirm.TabIndex = 41
        '
        'LosZeroNlp
        '
        Me.LosZeroNlp.DataDspWidth = 110
        Me.LosZeroNlp.DecimalPlaces = CType(0, Short)
        Me.LosZeroNlp.DspFieldName = True
        Me.LosZeroNlp.FieldName = "最適化ループ回数"
        Me.LosZeroNlp.Increment = 1.0!
        Me.LosZeroNlp.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LosZeroNlp.Location = New System.Drawing.Point(16, 457)
        Me.LosZeroNlp.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroNlp.MaxValue = "200"
        Me.LosZeroNlp.MinValue = "0"
        Me.LosZeroNlp.Name = "LosZeroNlp"
        Me.LosZeroNlp.SelectItem = Nothing
        Me.LosZeroNlp.Size = New System.Drawing.Size(405, 39)
        Me.LosZeroNlp.TabIndex = 42
        Me.LosZeroNlp.ttMsg = ""
        Me.LosZeroNlp.ttTile = ""
        Me.LosZeroNlp.Unit = "回"
        Me.LosZeroNlp.Value = 0R
        '
        'LosZeroEmp
        '
        Me.LosZeroEmp.DataDspWidth = 110
        Me.LosZeroEmp.DecimalPlaces = CType(1, Short)
        Me.LosZeroEmp.DspFieldName = True
        Me.LosZeroEmp.FieldName = "モーメント偏差許容値"
        Me.LosZeroEmp.Increment = 0.1!
        Me.LosZeroEmp.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LosZeroEmp.Location = New System.Drawing.Point(16, 500)
        Me.LosZeroEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroEmp.MaxValue = "300"
        Me.LosZeroEmp.MinValue = "0"
        Me.LosZeroEmp.Name = "LosZeroEmp"
        Me.LosZeroEmp.SelectItem = Nothing
        Me.LosZeroEmp.Size = New System.Drawing.Size(405, 39)
        Me.LosZeroEmp.TabIndex = 43
        Me.LosZeroEmp.ttMsg = ""
        Me.LosZeroEmp.ttTile = ""
        Me.LosZeroEmp.Unit = "kN"
        Me.LosZeroEmp.Value = 0R
        '
        'LoszerorStep
        '
        Me.LoszerorStep.DataDspWidth = 110
        Me.LoszerorStep.DecimalPlaces = CType(2, Short)
        Me.LoszerorStep.DspFieldName = True
        Me.LoszerorStep.FieldName = "1ループの演算の力点変化量"
        Me.LoszerorStep.Increment = 0.01!
        Me.LoszerorStep.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LoszerorStep.Location = New System.Drawing.Point(16, 543)
        Me.LoszerorStep.Margin = New System.Windows.Forms.Padding(2)
        Me.LoszerorStep.MaxValue = "1"
        Me.LoszerorStep.MinValue = "0"
        Me.LoszerorStep.Name = "LoszerorStep"
        Me.LoszerorStep.SelectItem = Nothing
        Me.LoszerorStep.Size = New System.Drawing.Size(405, 39)
        Me.LoszerorStep.TabIndex = 44
        Me.LoszerorStep.ttMsg = ""
        Me.LoszerorStep.ttTile = ""
        Me.LoszerorStep.Unit = ""
        Me.LoszerorStep.Value = 0R
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(4, 440)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(419, 147)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(441, 679)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 429)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 26)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "モーメント最適化のパラメータ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextPieceConfirmTime
        '
        Me.NextPieceConfirmTime.DataDspWidth = 110
        Me.NextPieceConfirmTime.DecimalPlaces = CType(0, Short)
        Me.NextPieceConfirmTime.DspFieldName = True
        Me.NextPieceConfirmTime.FieldName = "次ピース組立確認タイマ"
        Me.NextPieceConfirmTime.Increment = 1.0!
        Me.NextPieceConfirmTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.NextPieceConfirmTime.Location = New System.Drawing.Point(16, 277)
        Me.NextPieceConfirmTime.Margin = New System.Windows.Forms.Padding(2)
        Me.NextPieceConfirmTime.MaxValue = "60"
        Me.NextPieceConfirmTime.MinValue = "0"
        Me.NextPieceConfirmTime.Name = "NextPieceConfirmTime"
        Me.NextPieceConfirmTime.SelectItem = Nothing
        Me.NextPieceConfirmTime.Size = New System.Drawing.Size(405, 39)
        Me.NextPieceConfirmTime.TabIndex = 137
        Me.NextPieceConfirmTime.ttMsg = ""
        Me.NextPieceConfirmTime.ttTile = ""
        Me.NextPieceConfirmTime.Unit = "sec"
        Me.NextPieceConfirmTime.Value = 0R
        '
        'LosZeroOpposeGroupNumber
        '
        Me.LosZeroOpposeGroupNumber.DataDspWidth = 110
        Me.LosZeroOpposeGroupNumber.DecimalPlaces = CType(0, Short)
        Me.LosZeroOpposeGroupNumber.DspFieldName = True
        Me.LosZeroOpposeGroupNumber.FieldName = "対抗グループ数"
        Me.LosZeroOpposeGroupNumber.Increment = 1.0!
        Me.LosZeroOpposeGroupNumber.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LosZeroOpposeGroupNumber.Location = New System.Drawing.Point(19, 167)
        Me.LosZeroOpposeGroupNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroOpposeGroupNumber.MaxValue = "5"
        Me.LosZeroOpposeGroupNumber.MinValue = "0"
        Me.LosZeroOpposeGroupNumber.Name = "LosZeroOpposeGroupNumber"
        Me.LosZeroOpposeGroupNumber.SelectItem = Nothing
        Me.LosZeroOpposeGroupNumber.Size = New System.Drawing.Size(405, 39)
        Me.LosZeroOpposeGroupNumber.TabIndex = 138
        Me.LosZeroOpposeGroupNumber.ttMsg = ""
        Me.LosZeroOpposeGroupNumber.ttTile = ""
        Me.LosZeroOpposeGroupNumber.Unit = ""
        Me.LosZeroOpposeGroupNumber.Value = 0R
        '
        'frmLosZeroSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 679)
        Me.Controls.Add(Me.LosZeroOpposeGroupNumber)
        Me.Controls.Add(Me.NextPieceConfirmTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoszerorStep)
        Me.Controls.Add(Me.LosZeroEmp)
        Me.Controls.Add(Me.LosZeroNlp)
        Me.Controls.Add(Me.ReduceTime)
        Me.Controls.Add(Me.NextPieceConfirm)
        Me.Controls.Add(Me.ReduceJudgePress)
        Me.Controls.Add(Me.LosZeroOpposeControl)
        Me.Controls.Add(Me.LosZeroOpposeJack)
        Me.Controls.Add(Me.LosZeroRollingTake)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLosZeroSetting"
        Me.Text = "同時施工関連"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.LosZeroRollingTake, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeJack, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeControl, 0)
        Me.Controls.SetChildIndex(Me.ReduceJudgePress, 0)
        Me.Controls.SetChildIndex(Me.NextPieceConfirm, 0)
        Me.Controls.SetChildIndex(Me.ReduceTime, 0)
        Me.Controls.SetChildIndex(Me.LosZeroNlp, 0)
        Me.Controls.SetChildIndex(Me.LosZeroEmp, 0)
        Me.Controls.SetChildIndex(Me.LoszerorStep, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.NextPieceConfirmTime, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeGroupNumber, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LosZeroOpposeControl As ucnRdBtn
    Friend WithEvents LosZeroOpposeJack As ucnRdBtn
    Friend WithEvents LosZeroRollingTake As ucnRdBtn
    Friend WithEvents ReduceJudgePress As ucnNumEdit
    Friend WithEvents ReduceTime As ucnNumEdit
    Friend WithEvents NextPieceConfirm As ucnRdBtn
    Friend WithEvents LosZeroNlp As ucnNumEdit
    Friend WithEvents LosZeroEmp As ucnNumEdit
    Friend WithEvents LoszerorStep As ucnNumEdit
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents NextPieceConfirmTime As ucnNumEdit
    Friend WithEvents LosZeroOpposeGroupNumber As ucnNumEdit
End Class
