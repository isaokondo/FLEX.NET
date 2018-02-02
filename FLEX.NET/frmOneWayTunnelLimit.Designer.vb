<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOneWayTunnelLimit
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
        Me.OneWayRLimit = New FLEX.NET.ucnNumEdit()
        Me.MomentPermitValue = New FLEX.NET.ucnNumEdit()
        Me.PressPermitValue = New FLEX.NET.ucnNumEdit()
        Me.DirectDirectionControl = New FLEX.NET.ucnRdBtn()
        Me.OneReduceTime = New FLEX.NET.ucnNumEdit()
        Me.OneReduceValue = New FLEX.NET.ucnNumEdit()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.MomentRdductionRateOnOnewayLimit = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(219, 389)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(343, 390)
        '
        'OneWayRLimit
        '
        Me.OneWayRLimit.DataDspWidth = 110
        Me.OneWayRLimit.DecimalPlaces = CType(1, Short)
        Me.OneWayRLimit.DspFieldName = True
        Me.OneWayRLimit.FieldName = "片押R制限値"
        Me.OneWayRLimit.Increment = 0.1!
        Me.OneWayRLimit.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneWayRLimit.Location = New System.Drawing.Point(29, 205)
        Me.OneWayRLimit.Margin = New System.Windows.Forms.Padding(2)
        Me.OneWayRLimit.MaxValue = "10"
        Me.OneWayRLimit.MinValue = "0"
        Me.OneWayRLimit.Name = "OneWayRLimit"
        Me.OneWayRLimit.SelectItem = Nothing
        Me.OneWayRLimit.Size = New System.Drawing.Size(409, 39)
        Me.OneWayRLimit.TabIndex = 28
        Me.OneWayRLimit.ttMsg = ""
        Me.OneWayRLimit.ttTile = ""
        Me.OneWayRLimit.Unit = ""
        Me.OneWayRLimit.Value = 0R
        '
        'MomentPermitValue
        '
        Me.MomentPermitValue.DataDspWidth = 110
        Me.MomentPermitValue.DecimalPlaces = CType(0, Short)
        Me.MomentPermitValue.DspFieldName = True
        Me.MomentPermitValue.FieldName = "ジャッキモーメント許容値"
        Me.MomentPermitValue.Increment = 100.0!
        Me.MomentPermitValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MomentPermitValue.Location = New System.Drawing.Point(29, 103)
        Me.MomentPermitValue.Margin = New System.Windows.Forms.Padding(2)
        Me.MomentPermitValue.MaxValue = "1000000"
        Me.MomentPermitValue.MinValue = "0"
        Me.MomentPermitValue.Name = "MomentPermitValue"
        Me.MomentPermitValue.SelectItem = Nothing
        Me.MomentPermitValue.Size = New System.Drawing.Size(423, 39)
        Me.MomentPermitValue.TabIndex = 27
        Me.MomentPermitValue.ttMsg = ""
        Me.MomentPermitValue.ttTile = ""
        Me.MomentPermitValue.Unit = "kN・m"
        Me.MomentPermitValue.Value = 0R
        '
        'PressPermitValue
        '
        Me.PressPermitValue.DataDspWidth = 110
        Me.PressPermitValue.DecimalPlaces = CType(1, Short)
        Me.PressPermitValue.DspFieldName = True
        Me.PressPermitValue.FieldName = "シールド圧力許容値"
        Me.PressPermitValue.Increment = 0.1!
        Me.PressPermitValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PressPermitValue.Location = New System.Drawing.Point(29, 67)
        Me.PressPermitValue.Margin = New System.Windows.Forms.Padding(2)
        Me.PressPermitValue.MaxValue = "200"
        Me.PressPermitValue.MinValue = "0"
        Me.PressPermitValue.Name = "PressPermitValue"
        Me.PressPermitValue.SelectItem = Nothing
        Me.PressPermitValue.Size = New System.Drawing.Size(409, 39)
        Me.PressPermitValue.TabIndex = 26
        Me.PressPermitValue.ttMsg = ""
        Me.PressPermitValue.ttTile = ""
        Me.PressPermitValue.Unit = "MPa"
        Me.PressPermitValue.Value = 0R
        '
        'DirectDirectionControl
        '
        Me.DirectDirectionControl.BackColor = System.Drawing.Color.Transparent
        Me.DirectDirectionControl.FieldName = "片押し制限"
        Me.DirectDirectionControl.Location = New System.Drawing.Point(39, 27)
        Me.DirectDirectionControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectDirectionControl.Name = "DirectDirectionControl"
        Me.DirectDirectionControl.rdbtnValue = False
        Me.DirectDirectionControl.Selectable = True
        Me.DirectDirectionControl.Size = New System.Drawing.Size(399, 34)
        Me.DirectDirectionControl.SlectNoName = "する"
        Me.DirectDirectionControl.SlectYesName = "しない"
        Me.DirectDirectionControl.TabIndex = 30
        '
        'OneReduceTime
        '
        Me.OneReduceTime.DataDspWidth = 110
        Me.OneReduceTime.DecimalPlaces = CType(0, Short)
        Me.OneReduceTime.DspFieldName = True
        Me.OneReduceTime.FieldName = "実施間隔"
        Me.OneReduceTime.Increment = 1.0!
        Me.OneReduceTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneReduceTime.Location = New System.Drawing.Point(29, 282)
        Me.OneReduceTime.Margin = New System.Windows.Forms.Padding(2)
        Me.OneReduceTime.MaxValue = "200"
        Me.OneReduceTime.MinValue = "0"
        Me.OneReduceTime.Name = "OneReduceTime"
        Me.OneReduceTime.SelectItem = Nothing
        Me.OneReduceTime.Size = New System.Drawing.Size(409, 39)
        Me.OneReduceTime.TabIndex = 34
        Me.OneReduceTime.ttMsg = ""
        Me.OneReduceTime.ttTile = ""
        Me.OneReduceTime.Unit = "sec"
        Me.OneReduceTime.Value = 0R
        '
        'OneReduceValue
        '
        Me.OneReduceValue.DataDspWidth = 110
        Me.OneReduceValue.DecimalPlaces = CType(2, Short)
        Me.OneReduceValue.DspFieldName = True
        Me.OneReduceValue.FieldName = "１回のr引き戻し量"
        Me.OneReduceValue.Increment = 0.05!
        Me.OneReduceValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneReduceValue.Location = New System.Drawing.Point(29, 244)
        Me.OneReduceValue.Margin = New System.Windows.Forms.Padding(2)
        Me.OneReduceValue.MaxValue = "200"
        Me.OneReduceValue.MinValue = "0"
        Me.OneReduceValue.Name = "OneReduceValue"
        Me.OneReduceValue.SelectItem = Nothing
        Me.OneReduceValue.Size = New System.Drawing.Size(409, 39)
        Me.OneReduceValue.TabIndex = 33
        Me.OneReduceValue.ttMsg = ""
        Me.OneReduceValue.ttTile = ""
        Me.OneReduceValue.Unit = ""
        Me.OneReduceValue.Value = 0R
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(11, 8)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(449, 347)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(485, 466)
        Me.ShapeContainer1.TabIndex = 35
        Me.ShapeContainer1.TabStop = False
        '
        'MomentRdductionRateOnOnewayLimit
        '
        Me.MomentRdductionRateOnOnewayLimit.DataDspWidth = 110
        Me.MomentRdductionRateOnOnewayLimit.DecimalPlaces = CType(0, Short)
        Me.MomentRdductionRateOnOnewayLimit.DspFieldName = True
        Me.MomentRdductionRateOnOnewayLimit.FieldName = "片押し時モーメント低減率"
        Me.MomentRdductionRateOnOnewayLimit.Increment = 1.0!
        Me.MomentRdductionRateOnOnewayLimit.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MomentRdductionRateOnOnewayLimit.Location = New System.Drawing.Point(29, 145)
        Me.MomentRdductionRateOnOnewayLimit.Margin = New System.Windows.Forms.Padding(2)
        Me.MomentRdductionRateOnOnewayLimit.MaxValue = "100"
        Me.MomentRdductionRateOnOnewayLimit.MinValue = "0"
        Me.MomentRdductionRateOnOnewayLimit.Name = "MomentRdductionRateOnOnewayLimit"
        Me.MomentRdductionRateOnOnewayLimit.SelectItem = Nothing
        Me.MomentRdductionRateOnOnewayLimit.Size = New System.Drawing.Size(409, 39)
        Me.MomentRdductionRateOnOnewayLimit.TabIndex = 36
        Me.MomentRdductionRateOnOnewayLimit.ttMsg = ""
        Me.MomentRdductionRateOnOnewayLimit.ttTile = ""
        Me.MomentRdductionRateOnOnewayLimit.Unit = "%"
        Me.MomentRdductionRateOnOnewayLimit.Value = 0R
        '
        'frmOneWayTunnelLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(485, 466)
        Me.Controls.Add(Me.MomentRdductionRateOnOnewayLimit)
        Me.Controls.Add(Me.OneReduceTime)
        Me.Controls.Add(Me.OneReduceValue)
        Me.Controls.Add(Me.DirectDirectionControl)
        Me.Controls.Add(Me.OneWayRLimit)
        Me.Controls.Add(Me.MomentPermitValue)
        Me.Controls.Add(Me.PressPermitValue)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmOneWayTunnelLimit"
        Me.Text = "片押し制限"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.PressPermitValue, 0)
        Me.Controls.SetChildIndex(Me.MomentPermitValue, 0)
        Me.Controls.SetChildIndex(Me.OneWayRLimit, 0)
        Me.Controls.SetChildIndex(Me.DirectDirectionControl, 0)
        Me.Controls.SetChildIndex(Me.OneReduceValue, 0)
        Me.Controls.SetChildIndex(Me.OneReduceTime, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.MomentRdductionRateOnOnewayLimit, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OneWayRLimit As ucnNumEdit
    Friend WithEvents MomentPermitValue As ucnNumEdit
    Friend WithEvents PressPermitValue As ucnNumEdit
    Friend WithEvents DirectDirectionControl As ucnRdBtn
    Friend WithEvents OneReduceTime As ucnNumEdit
    Friend WithEvents OneReduceValue As ucnNumEdit
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents MomentRdductionRateOnOnewayLimit As ucnNumEdit
End Class
