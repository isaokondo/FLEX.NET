<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRinguUpdateSetting
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.StrokeManag = New FLEX.NET.ucnNumEdit()
        Me.StopJudgeSpeed = New FLEX.NET.ucnNumEdit()
        Me.CloseJudgeTime = New FLEX.NET.ucnNumEdit()
        Me.CloseJudgePullStroke = New FLEX.NET.ucnNumEdit()
        Me.CloseStokeEdt = New FLEX.NET.ucnNumEdit()
        Me.StartStokeEdt = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(317, 376)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Silver
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(184, 375)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(109, 35)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'StrokeManag
        '
        Me.StrokeManag.DecimalPlaces = CType(0, Short)
        Me.StrokeManag.DspFieldName = True
        Me.StrokeManag.FieldName = "ストローク取得方法"
        Me.StrokeManag.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.SelectType
        Me.StrokeManag.Location = New System.Drawing.Point(33, 21)
        Me.StrokeManag.MaxValue = "0"
        Me.StrokeManag.MinValue = "0"
        Me.StrokeManag.Name = "StrokeManag"
        Me.StrokeManag.SelectItem = "MAX,右,左,左右平均"
        Me.StrokeManag.Size = New System.Drawing.Size(414, 49)
        Me.StrokeManag.TabIndex = 11
        Me.StrokeManag.Unit = "mm"
        Me.StrokeManag.Value = 0.0R
        '
        'StopJudgeSpeed
        '
        Me.StopJudgeSpeed.DecimalPlaces = CType(0, Short)
        Me.StopJudgeSpeed.DspFieldName = True
        Me.StopJudgeSpeed.FieldName = "中断判定速度"
        Me.StopJudgeSpeed.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.StopJudgeSpeed.Location = New System.Drawing.Point(33, 296)
        Me.StopJudgeSpeed.MaxValue = "100"
        Me.StopJudgeSpeed.MinValue = "0"
        Me.StopJudgeSpeed.Name = "StopJudgeSpeed"
        Me.StopJudgeSpeed.SelectItem = Nothing
        Me.StopJudgeSpeed.Size = New System.Drawing.Size(455, 49)
        Me.StopJudgeSpeed.TabIndex = 9
        Me.StopJudgeSpeed.Unit = "mm/min"
        Me.StopJudgeSpeed.Value = 0.0R
        '
        'CloseJudgeTime
        '
        Me.CloseJudgeTime.DecimalPlaces = CType(0, Short)
        Me.CloseJudgeTime.DspFieldName = True
        Me.CloseJudgeTime.FieldName = "終了判定時間"
        Me.CloseJudgeTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.CloseJudgeTime.Location = New System.Drawing.Point(33, 241)
        Me.CloseJudgeTime.MaxValue = "100"
        Me.CloseJudgeTime.MinValue = "0"
        Me.CloseJudgeTime.Name = "CloseJudgeTime"
        Me.CloseJudgeTime.SelectItem = Nothing
        Me.CloseJudgeTime.Size = New System.Drawing.Size(414, 49)
        Me.CloseJudgeTime.TabIndex = 8
        Me.CloseJudgeTime.Unit = "分"
        Me.CloseJudgeTime.Value = 0.0R
        '
        'CloseJudgePullStroke
        '
        Me.CloseJudgePullStroke.DecimalPlaces = CType(0, Short)
        Me.CloseJudgePullStroke.DspFieldName = True
        Me.CloseJudgePullStroke.FieldName = "終了判定引きストローク"
        Me.CloseJudgePullStroke.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.CloseJudgePullStroke.Location = New System.Drawing.Point(33, 186)
        Me.CloseJudgePullStroke.MaxValue = "0"
        Me.CloseJudgePullStroke.MinValue = "0"
        Me.CloseJudgePullStroke.Name = "CloseJudgePullStroke"
        Me.CloseJudgePullStroke.SelectItem = Nothing
        Me.CloseJudgePullStroke.Size = New System.Drawing.Size(414, 49)
        Me.CloseJudgePullStroke.TabIndex = 7
        Me.CloseJudgePullStroke.Unit = "mm"
        Me.CloseJudgePullStroke.Value = 0.0R
        '
        'CloseStokeEdt
        '
        Me.CloseStokeEdt.DecimalPlaces = CType(0, Short)
        Me.CloseStokeEdt.DspFieldName = True
        Me.CloseStokeEdt.FieldName = "終了ストローク"
        Me.CloseStokeEdt.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.CloseStokeEdt.Location = New System.Drawing.Point(33, 131)
        Me.CloseStokeEdt.MaxValue = "0"
        Me.CloseStokeEdt.MinValue = "0"
        Me.CloseStokeEdt.Name = "CloseStokeEdt"
        Me.CloseStokeEdt.SelectItem = Nothing
        Me.CloseStokeEdt.Size = New System.Drawing.Size(414, 49)
        Me.CloseStokeEdt.TabIndex = 6
        Me.CloseStokeEdt.Unit = "mm"
        Me.CloseStokeEdt.Value = 0.0R
        '
        'StartStokeEdt
        '
        Me.StartStokeEdt.DecimalPlaces = CType(0, Short)
        Me.StartStokeEdt.DspFieldName = True
        Me.StartStokeEdt.FieldName = "開始ストローク"
        Me.StartStokeEdt.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.StartStokeEdt.Location = New System.Drawing.Point(33, 76)
        Me.StartStokeEdt.MaxValue = "0"
        Me.StartStokeEdt.MinValue = "0"
        Me.StartStokeEdt.Name = "StartStokeEdt"
        Me.StartStokeEdt.SelectItem = Nothing
        Me.StartStokeEdt.Size = New System.Drawing.Size(414, 49)
        Me.StartStokeEdt.TabIndex = 5
        Me.StartStokeEdt.Unit = "mm"
        Me.StartStokeEdt.Value = 0.0R
        '
        'frmRinguUpdateSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(489, 451)
        Me.Controls.Add(Me.StrokeManag)
        Me.Controls.Add(Me.StopJudgeSpeed)
        Me.Controls.Add(Me.CloseJudgeTime)
        Me.Controls.Add(Me.CloseJudgePullStroke)
        Me.Controls.Add(Me.CloseStokeEdt)
        Me.Controls.Add(Me.StartStokeEdt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRinguUpdateSetting"
        Me.Text = "リング更新設定"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents StartStokeEdt As FLEX.NET.ucnNumEdit
    Friend WithEvents CloseStokeEdt As FLEX.NET.ucnNumEdit
    Friend WithEvents CloseJudgePullStroke As FLEX.NET.ucnNumEdit
    Friend WithEvents CloseJudgeTime As FLEX.NET.ucnNumEdit
    Friend WithEvents StopJudgeSpeed As FLEX.NET.ucnNumEdit
    Friend WithEvents StrokeManag As FLEX.NET.ucnNumEdit
End Class
