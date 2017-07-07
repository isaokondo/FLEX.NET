<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPressParameterSet
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
        Me.PIDShiftDefl = New FLEX.NET.ucnNumEdit()
        Me.PID_P = New FLEX.NET.ucnNumEdit()
        Me.PID_I = New FLEX.NET.ucnNumEdit()
        Me.PID_D = New FLEX.NET.ucnNumEdit()
        Me.PresFileterFactor = New FLEX.NET.ucnNumEdit()
        Me.ControlStartThrustData = New FLEX.NET.ucnNumEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DirectControl = New FLEX.NET.ucnRdBtn()
        Me.ControlStartThrustOn = New FLEX.NET.ucnRdBtn()
        Me.DirectControlOffset = New FLEX.NET.ucnNumEdit()
        Me.DirectControlCoefficient = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(228, 568)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(348, 569)
        '
        'PIDShiftDefl
        '
        Me.PIDShiftDefl.DataDspWidth = 110
        Me.PIDShiftDefl.DecimalPlaces = CType(1, Short)
        Me.PIDShiftDefl.DspFieldName = True
        Me.PIDShiftDefl.FieldName = "PID移行偏差"
        Me.PIDShiftDefl.Increment = 0.1!
        Me.PIDShiftDefl.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PIDShiftDefl.Location = New System.Drawing.Point(28, 61)
        Me.PIDShiftDefl.Margin = New System.Windows.Forms.Padding(2)
        Me.PIDShiftDefl.MaxValue = "30"
        Me.PIDShiftDefl.MinValue = "0"
        Me.PIDShiftDefl.Name = "PIDShiftDefl"
        Me.PIDShiftDefl.SelectItem = Nothing
        Me.PIDShiftDefl.Size = New System.Drawing.Size(395, 30)
        Me.PIDShiftDefl.TabIndex = 12
        Me.PIDShiftDefl.ttMsg = ""
        Me.PIDShiftDefl.ttTile = ""
        Me.PIDShiftDefl.Unit = "MPa"
        Me.PIDShiftDefl.Value = 0R
        '
        'PID_P
        '
        Me.PID_P.DataDspWidth = 110
        Me.PID_P.DecimalPlaces = CType(0, Short)
        Me.PID_P.DspFieldName = True
        Me.PID_P.FieldName = "P"
        Me.PID_P.Increment = 1.0!
        Me.PID_P.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PID_P.Location = New System.Drawing.Point(28, 237)
        Me.PID_P.Margin = New System.Windows.Forms.Padding(2)
        Me.PID_P.MaxValue = "200"
        Me.PID_P.MinValue = "0"
        Me.PID_P.Name = "PID_P"
        Me.PID_P.SelectItem = Nothing
        Me.PID_P.Size = New System.Drawing.Size(395, 39)
        Me.PID_P.TabIndex = 15
        Me.PID_P.ttMsg = ""
        Me.PID_P.ttTile = ""
        Me.PID_P.Unit = "%"
        Me.PID_P.Value = 0R
        '
        'PID_I
        '
        Me.PID_I.DataDspWidth = 110
        Me.PID_I.DecimalPlaces = CType(0, Short)
        Me.PID_I.DspFieldName = True
        Me.PID_I.FieldName = "I"
        Me.PID_I.Increment = 1.0!
        Me.PID_I.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PID_I.Location = New System.Drawing.Point(28, 276)
        Me.PID_I.Margin = New System.Windows.Forms.Padding(2)
        Me.PID_I.MaxValue = "200"
        Me.PID_I.MinValue = "0"
        Me.PID_I.Name = "PID_I"
        Me.PID_I.SelectItem = Nothing
        Me.PID_I.Size = New System.Drawing.Size(395, 39)
        Me.PID_I.TabIndex = 16
        Me.PID_I.ttMsg = ""
        Me.PID_I.ttTile = ""
        Me.PID_I.Unit = "sec"
        Me.PID_I.Value = 0R
        '
        'PID_D
        '
        Me.PID_D.DataDspWidth = 110
        Me.PID_D.DecimalPlaces = CType(0, Short)
        Me.PID_D.DspFieldName = True
        Me.PID_D.FieldName = "D"
        Me.PID_D.Increment = 1.0!
        Me.PID_D.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PID_D.Location = New System.Drawing.Point(28, 315)
        Me.PID_D.Margin = New System.Windows.Forms.Padding(2)
        Me.PID_D.MaxValue = "200"
        Me.PID_D.MinValue = "0"
        Me.PID_D.Name = "PID_D"
        Me.PID_D.SelectItem = Nothing
        Me.PID_D.Size = New System.Drawing.Size(395, 39)
        Me.PID_D.TabIndex = 17
        Me.PID_D.ttMsg = ""
        Me.PID_D.ttTile = ""
        Me.PID_D.Unit = "sec"
        Me.PID_D.Value = 0R
        '
        'PresFileterFactor
        '
        Me.PresFileterFactor.DataDspWidth = 110
        Me.PresFileterFactor.DecimalPlaces = CType(0, Short)
        Me.PresFileterFactor.DspFieldName = True
        Me.PresFileterFactor.FieldName = "元圧フィルター係数"
        Me.PresFileterFactor.Increment = 1.0!
        Me.PresFileterFactor.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PresFileterFactor.Location = New System.Drawing.Point(28, 377)
        Me.PresFileterFactor.Margin = New System.Windows.Forms.Padding(2)
        Me.PresFileterFactor.MaxValue = "100"
        Me.PresFileterFactor.MinValue = "0"
        Me.PresFileterFactor.Name = "PresFileterFactor"
        Me.PresFileterFactor.SelectItem = Nothing
        Me.PresFileterFactor.Size = New System.Drawing.Size(395, 39)
        Me.PresFileterFactor.TabIndex = 18
        Me.PresFileterFactor.ttMsg = ""
        Me.PresFileterFactor.ttTile = ""
        Me.PresFileterFactor.Unit = "%"
        Me.PresFileterFactor.Value = 0R
        '
        'ControlStartThrustData
        '
        Me.ControlStartThrustData.DataDspWidth = 110
        Me.ControlStartThrustData.DecimalPlaces = CType(0, Short)
        Me.ControlStartThrustData.DspFieldName = True
        Me.ControlStartThrustData.FieldName = "制御開始推力値"
        Me.ControlStartThrustData.Increment = 1.0!
        Me.ControlStartThrustData.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ControlStartThrustData.Location = New System.Drawing.Point(28, 496)
        Me.ControlStartThrustData.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlStartThrustData.MaxValue = "100000"
        Me.ControlStartThrustData.MinValue = "0"
        Me.ControlStartThrustData.Name = "ControlStartThrustData"
        Me.ControlStartThrustData.SelectItem = Nothing
        Me.ControlStartThrustData.Size = New System.Drawing.Size(395, 29)
        Me.ControlStartThrustData.TabIndex = 19
        Me.ControlStartThrustData.ttMsg = ""
        Me.ControlStartThrustData.ttTile = ""
        Me.ControlStartThrustData.Unit = "kN"
        Me.ControlStartThrustData.Value = 0R
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(464, 634)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(11, 451)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(443, 90)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(10, 11)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(443, 178)
        '
        'DirectControl
        '
        Me.DirectControl.BackColor = System.Drawing.Color.Transparent
        Me.DirectControl.FieldName = "ダイレクト指令制御"
        Me.DirectControl.Location = New System.Drawing.Point(28, 23)
        Me.DirectControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectControl.Name = "DirectControl"
        Me.DirectControl.rdbtnValue = False
        Me.DirectControl.Size = New System.Drawing.Size(395, 34)
        Me.DirectControl.SlectNoName = "する"
        Me.DirectControl.SlectYesName = "しない"
        Me.DirectControl.TabIndex = 21
        '
        'ControlStartThrustOn
        '
        Me.ControlStartThrustOn.BackColor = System.Drawing.Color.Transparent
        Me.ControlStartThrustOn.FieldName = "制御開始推力設定"
        Me.ControlStartThrustOn.Location = New System.Drawing.Point(28, 458)
        Me.ControlStartThrustOn.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlStartThrustOn.Name = "ControlStartThrustOn"
        Me.ControlStartThrustOn.rdbtnValue = False
        Me.ControlStartThrustOn.Size = New System.Drawing.Size(395, 34)
        Me.ControlStartThrustOn.SlectNoName = "しない"
        Me.ControlStartThrustOn.SlectYesName = "する"
        Me.ControlStartThrustOn.TabIndex = 22
        '
        'DirectControlOffset
        '
        Me.DirectControlOffset.DataDspWidth = 110
        Me.DirectControlOffset.DecimalPlaces = CType(0, Short)
        Me.DirectControlOffset.DspFieldName = True
        Me.DirectControlOffset.FieldName = "オフセット"
        Me.DirectControlOffset.Increment = 1.0!
        Me.DirectControlOffset.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.DirectControlOffset.Location = New System.Drawing.Point(28, 143)
        Me.DirectControlOffset.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectControlOffset.MaxValue = "200"
        Me.DirectControlOffset.MinValue = "-50"
        Me.DirectControlOffset.Name = "DirectControlOffset"
        Me.DirectControlOffset.SelectItem = Nothing
        Me.DirectControlOffset.Size = New System.Drawing.Size(395, 39)
        Me.DirectControlOffset.TabIndex = 24
        Me.DirectControlOffset.ttMsg = ""
        Me.DirectControlOffset.ttTile = ""
        Me.DirectControlOffset.Unit = "%"
        Me.DirectControlOffset.Value = 0R
        '
        'DirectControlCoefficient
        '
        Me.DirectControlCoefficient.DataDspWidth = 110
        Me.DirectControlCoefficient.DecimalPlaces = CType(2, Short)
        Me.DirectControlCoefficient.DspFieldName = True
        Me.DirectControlCoefficient.FieldName = "係数"
        Me.DirectControlCoefficient.Increment = 0.1!
        Me.DirectControlCoefficient.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.DirectControlCoefficient.Location = New System.Drawing.Point(28, 104)
        Me.DirectControlCoefficient.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectControlCoefficient.MaxValue = "200"
        Me.DirectControlCoefficient.MinValue = "0"
        Me.DirectControlCoefficient.Name = "DirectControlCoefficient"
        Me.DirectControlCoefficient.SelectItem = Nothing
        Me.DirectControlCoefficient.Size = New System.Drawing.Size(395, 39)
        Me.DirectControlCoefficient.TabIndex = 23
        Me.DirectControlCoefficient.ttMsg = ""
        Me.DirectControlCoefficient.ttTile = ""
        Me.DirectControlCoefficient.Unit = ""
        Me.DirectControlCoefficient.Value = 0R
        '
        'frmPressParameterSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(464, 634)
        Me.Controls.Add(Me.DirectControlOffset)
        Me.Controls.Add(Me.DirectControlCoefficient)
        Me.Controls.Add(Me.ControlStartThrustOn)
        Me.Controls.Add(Me.DirectControl)
        Me.Controls.Add(Me.ControlStartThrustData)
        Me.Controls.Add(Me.PresFileterFactor)
        Me.Controls.Add(Me.PID_D)
        Me.Controls.Add(Me.PID_I)
        Me.Controls.Add(Me.PID_P)
        Me.Controls.Add(Me.PIDShiftDefl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmPressParameterSet"
        Me.Text = "圧力パラメータ"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.PIDShiftDefl, 0)
        Me.Controls.SetChildIndex(Me.PID_P, 0)
        Me.Controls.SetChildIndex(Me.PID_I, 0)
        Me.Controls.SetChildIndex(Me.PID_D, 0)
        Me.Controls.SetChildIndex(Me.PresFileterFactor, 0)
        Me.Controls.SetChildIndex(Me.ControlStartThrustData, 0)
        Me.Controls.SetChildIndex(Me.DirectControl, 0)
        Me.Controls.SetChildIndex(Me.ControlStartThrustOn, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DirectControlCoefficient, 0)
        Me.Controls.SetChildIndex(Me.DirectControlOffset, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PIDShiftDefl As ucnNumEdit
    Friend WithEvents PID_P As ucnNumEdit
    Friend WithEvents PID_I As ucnNumEdit
    Friend WithEvents PID_D As ucnNumEdit
    Friend WithEvents PresFileterFactor As ucnNumEdit
    Friend WithEvents ControlStartThrustData As ucnNumEdit
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents DirectControl As ucnRdBtn
    Friend WithEvents ControlStartThrustOn As ucnRdBtn
    Friend WithEvents DirectControlOffset As ucnNumEdit
    Friend WithEvents DirectControlCoefficient As ucnNumEdit
End Class
