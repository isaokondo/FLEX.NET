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
        Me.LosZeroOpposeManualSV = New FLEX.NET.ucnNumEdit()
        Me.MomentRdductionRateOnReduce = New FLEX.NET.ucnNumEdit()
        Me.ReduceReachStrokeDiff = New FLEX.NET.ucnNumEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpposeJackExcep = New FLEX.NET.ucnRdBtn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AssemblyPieceNumber = New FLEX.NET.ucnNumEdit()
        Me.LoszeroRollingTolerance = New FLEX.NET.ucnNumEdit()
        Me.TargetStrokeOverRate = New FLEX.NET.ucnNumEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTargetStrokeOverStoke = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(548, 527)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(672, 527)
        '
        'LosZeroOpposeControl
        '
        Me.LosZeroOpposeControl.BackColor = System.Drawing.Color.Transparent
        Me.LosZeroOpposeControl.FieldName = "対抗圧制御"
        Me.LosZeroOpposeControl.Location = New System.Drawing.Point(16, 127)
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
        Me.LosZeroOpposeJack.Location = New System.Drawing.Point(16, 93)
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
        Me.ReduceJudgePress.Location = New System.Drawing.Point(441, 208)
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
        Me.ReduceTime.Location = New System.Drawing.Point(441, 159)
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
        Me.NextPieceConfirm.Location = New System.Drawing.Point(436, 11)
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
        Me.LosZeroNlp.Location = New System.Drawing.Point(442, 341)
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
        Me.LosZeroEmp.Location = New System.Drawing.Point(442, 384)
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
        Me.LoszerorStep.Location = New System.Drawing.Point(442, 427)
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
        Me.RectangleShape2.Location = New System.Drawing.Point(428, 321)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(419, 147)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(887, 599)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 313)
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
        Me.NextPieceConfirmTime.Location = New System.Drawing.Point(441, 108)
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
        Me.LosZeroOpposeGroupNumber.Location = New System.Drawing.Point(19, 176)
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
        'LosZeroOpposeManualSV
        '
        Me.LosZeroOpposeManualSV.DataDspWidth = 110
        Me.LosZeroOpposeManualSV.DecimalPlaces = CType(1, Short)
        Me.LosZeroOpposeManualSV.DspFieldName = True
        Me.LosZeroOpposeManualSV.FieldName = "対抗グループ手動圧力設定"
        Me.LosZeroOpposeManualSV.Increment = 1.0!
        Me.LosZeroOpposeManualSV.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LosZeroOpposeManualSV.Location = New System.Drawing.Point(19, 214)
        Me.LosZeroOpposeManualSV.Margin = New System.Windows.Forms.Padding(2)
        Me.LosZeroOpposeManualSV.MaxValue = "50"
        Me.LosZeroOpposeManualSV.MinValue = "0"
        Me.LosZeroOpposeManualSV.Name = "LosZeroOpposeManualSV"
        Me.LosZeroOpposeManualSV.SelectItem = Nothing
        Me.LosZeroOpposeManualSV.Size = New System.Drawing.Size(405, 39)
        Me.LosZeroOpposeManualSV.TabIndex = 139
        Me.LosZeroOpposeManualSV.ttMsg = ""
        Me.LosZeroOpposeManualSV.ttTile = ""
        Me.LosZeroOpposeManualSV.Unit = "MPa"
        Me.LosZeroOpposeManualSV.Value = 0R
        '
        'MomentRdductionRateOnReduce
        '
        Me.MomentRdductionRateOnReduce.DataDspWidth = 110
        Me.MomentRdductionRateOnReduce.DecimalPlaces = CType(0, Short)
        Me.MomentRdductionRateOnReduce.DspFieldName = True
        Me.MomentRdductionRateOnReduce.FieldName = "減圧時モーメント低減率"
        Me.MomentRdductionRateOnReduce.Increment = 1.0!
        Me.MomentRdductionRateOnReduce.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MomentRdductionRateOnReduce.Location = New System.Drawing.Point(442, 251)
        Me.MomentRdductionRateOnReduce.Margin = New System.Windows.Forms.Padding(2)
        Me.MomentRdductionRateOnReduce.MaxValue = "100"
        Me.MomentRdductionRateOnReduce.MinValue = "0"
        Me.MomentRdductionRateOnReduce.Name = "MomentRdductionRateOnReduce"
        Me.MomentRdductionRateOnReduce.SelectItem = Nothing
        Me.MomentRdductionRateOnReduce.Size = New System.Drawing.Size(409, 39)
        Me.MomentRdductionRateOnReduce.TabIndex = 140
        Me.MomentRdductionRateOnReduce.ttMsg = ""
        Me.MomentRdductionRateOnReduce.ttTile = ""
        Me.MomentRdductionRateOnReduce.Unit = "%"
        Me.MomentRdductionRateOnReduce.Value = 0R
        '
        'ReduceReachStrokeDiff
        '
        Me.ReduceReachStrokeDiff.DataDspWidth = 110
        Me.ReduceReachStrokeDiff.DecimalPlaces = CType(0, Short)
        Me.ReduceReachStrokeDiff.DspFieldName = True
        Me.ReduceReachStrokeDiff.FieldName = "減圧開始可能ストローク設定"
        Me.ReduceReachStrokeDiff.Increment = 1.0!
        Me.ReduceReachStrokeDiff.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ReduceReachStrokeDiff.Location = New System.Drawing.Point(19, 441)
        Me.ReduceReachStrokeDiff.Margin = New System.Windows.Forms.Padding(2)
        Me.ReduceReachStrokeDiff.MaxValue = "1000"
        Me.ReduceReachStrokeDiff.MinValue = "-1000"
        Me.ReduceReachStrokeDiff.Name = "ReduceReachStrokeDiff"
        Me.ReduceReachStrokeDiff.SelectItem = Nothing
        Me.ReduceReachStrokeDiff.Size = New System.Drawing.Size(386, 39)
        Me.ReduceReachStrokeDiff.TabIndex = 141
        Me.ReduceReachStrokeDiff.ttMsg = ""
        Me.ReduceReachStrokeDiff.ttTile = ""
        Me.ReduceReachStrokeDiff.Unit = "mm"
        Me.ReduceReachStrokeDiff.Value = 0R
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(16, 393)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 44)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "ジャッキストロークがセグメント幅＋下記設定値で減圧可能（ボイスアナウンス)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpposeJackExcep
        '
        Me.OpposeJackExcep.BackColor = System.Drawing.Color.Transparent
        Me.OpposeJackExcep.FieldName = "対抗ｼﾞｬｯｷのｽﾄﾛｰｸ除外"
        Me.OpposeJackExcep.Location = New System.Drawing.Point(16, 527)
        Me.OpposeJackExcep.Margin = New System.Windows.Forms.Padding(2)
        Me.OpposeJackExcep.Name = "OpposeJackExcep"
        Me.OpposeJackExcep.rdbtnValue = False
        Me.OpposeJackExcep.Selectable = True
        Me.OpposeJackExcep.Size = New System.Drawing.Size(389, 34)
        Me.OpposeJackExcep.SlectNoName = "する"
        Me.OpposeJackExcep.SlectYesName = "しない"
        Me.OpposeJackExcep.TabIndex = 143
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(16, 496)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 29)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "平均ストローク算出"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AssemblyPieceNumber
        '
        Me.AssemblyPieceNumber.DataDspWidth = 160
        Me.AssemblyPieceNumber.DecimalPlaces = CType(0, Short)
        Me.AssemblyPieceNumber.DspFieldName = True
        Me.AssemblyPieceNumber.FieldName = "組立ピース数"
        Me.AssemblyPieceNumber.Increment = 1.0!
        Me.AssemblyPieceNumber.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.AssemblyPieceNumber.Location = New System.Drawing.Point(441, 54)
        Me.AssemblyPieceNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.AssemblyPieceNumber.MaxValue = "30"
        Me.AssemblyPieceNumber.MinValue = "1"
        Me.AssemblyPieceNumber.Name = "AssemblyPieceNumber"
        Me.AssemblyPieceNumber.SelectItem = Nothing
        Me.AssemblyPieceNumber.Size = New System.Drawing.Size(391, 37)
        Me.AssemblyPieceNumber.TabIndex = 153
        Me.AssemblyPieceNumber.ttMsg = ""
        Me.AssemblyPieceNumber.ttTile = ""
        Me.AssemblyPieceNumber.Unit = ""
        Me.AssemblyPieceNumber.Value = 1.0R
        '
        'LoszeroRollingTolerance
        '
        Me.LoszeroRollingTolerance.DataDspWidth = 110
        Me.LoszeroRollingTolerance.DecimalPlaces = CType(2, Short)
        Me.LoszeroRollingTolerance.DspFieldName = True
        Me.LoszeroRollingTolerance.FieldName = "ピース端部の余裕許容値"
        Me.LoszeroRollingTolerance.Increment = 0.01!
        Me.LoszeroRollingTolerance.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.LoszeroRollingTolerance.Location = New System.Drawing.Point(16, 52)
        Me.LoszeroRollingTolerance.Margin = New System.Windows.Forms.Padding(2)
        Me.LoszeroRollingTolerance.MaxValue = "3"
        Me.LoszeroRollingTolerance.MinValue = "0"
        Me.LoszeroRollingTolerance.Name = "LoszeroRollingTolerance"
        Me.LoszeroRollingTolerance.SelectItem = Nothing
        Me.LoszeroRollingTolerance.Size = New System.Drawing.Size(405, 39)
        Me.LoszeroRollingTolerance.TabIndex = 154
        Me.LoszeroRollingTolerance.ttMsg = ""
        Me.LoszeroRollingTolerance.ttTile = ""
        Me.LoszeroRollingTolerance.Unit = "deg"
        Me.LoszeroRollingTolerance.Value = 0R
        '
        'TargetStrokeOverRate
        '
        Me.TargetStrokeOverRate.DataDspWidth = 110
        Me.TargetStrokeOverRate.DecimalPlaces = CType(0, Short)
        Me.TargetStrokeOverRate.DspFieldName = True
        Me.TargetStrokeOverRate.FieldName = "ﾘﾝｸﾞ更新ﾒｯｾｰｼﾞﾀｲﾐﾝｸﾞ"
        Me.TargetStrokeOverRate.Increment = 1.0!
        Me.TargetStrokeOverRate.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.TargetStrokeOverRate.Location = New System.Drawing.Point(19, 305)
        Me.TargetStrokeOverRate.Margin = New System.Windows.Forms.Padding(2)
        Me.TargetStrokeOverRate.MaxValue = "200"
        Me.TargetStrokeOverRate.MinValue = "0"
        Me.TargetStrokeOverRate.Name = "TargetStrokeOverRate"
        Me.TargetStrokeOverRate.SelectItem = Nothing
        Me.TargetStrokeOverRate.Size = New System.Drawing.Size(386, 39)
        Me.TargetStrokeOverRate.TabIndex = 155
        Me.TargetStrokeOverRate.ttMsg = ""
        Me.TargetStrokeOverRate.ttTile = ""
        Me.TargetStrokeOverRate.Unit = "%"
        Me.TargetStrokeOverRate.Value = 0R
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(16, 259)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 44)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "目標推進量にこの割合を掛けたものを超えると更新メッセージ出力"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTargetStrokeOverStoke
        '
        Me.lblTargetStrokeOverStoke.BackColor = System.Drawing.Color.Silver
        Me.lblTargetStrokeOverStoke.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTargetStrokeOverStoke.ForeColor = System.Drawing.Color.Crimson
        Me.lblTargetStrokeOverStoke.Location = New System.Drawing.Point(131, 336)
        Me.lblTargetStrokeOverStoke.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTargetStrokeOverStoke.Name = "lblTargetStrokeOverStoke"
        Me.lblTargetStrokeOverStoke.Size = New System.Drawing.Size(140, 36)
        Me.lblTargetStrokeOverStoke.TabIndex = 157
        Me.lblTargetStrokeOverStoke.Text = "リング更新推進量" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12345mm"
        Me.lblTargetStrokeOverStoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLosZeroSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 599)
        Me.Controls.Add(Me.lblTargetStrokeOverStoke)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TargetStrokeOverRate)
        Me.Controls.Add(Me.LoszeroRollingTolerance)
        Me.Controls.Add(Me.AssemblyPieceNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OpposeJackExcep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReduceReachStrokeDiff)
        Me.Controls.Add(Me.MomentRdductionRateOnReduce)
        Me.Controls.Add(Me.LosZeroOpposeManualSV)
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
        Me.Controls.SetChildIndex(Me.LosZeroOpposeGroupNumber, 0)
        Me.Controls.SetChildIndex(Me.LosZeroOpposeManualSV, 0)
        Me.Controls.SetChildIndex(Me.MomentRdductionRateOnReduce, 0)
        Me.Controls.SetChildIndex(Me.ReduceReachStrokeDiff, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.OpposeJackExcep, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.AssemblyPieceNumber, 0)
        Me.Controls.SetChildIndex(Me.LoszeroRollingTolerance, 0)
        Me.Controls.SetChildIndex(Me.TargetStrokeOverRate, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblTargetStrokeOverStoke, 0)
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
    Friend WithEvents LosZeroOpposeManualSV As ucnNumEdit
    Friend WithEvents MomentRdductionRateOnReduce As ucnNumEdit
    Friend WithEvents ReduceReachStrokeDiff As ucnNumEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents OpposeJackExcep As ucnRdBtn
    Friend WithEvents Label3 As Label
    Friend WithEvents AssemblyPieceNumber As ucnNumEdit
    Friend WithEvents LoszeroRollingTolerance As ucnNumEdit
    Friend WithEvents TargetStrokeOverRate As ucnNumEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTargetStrokeOverStoke As Label
End Class
