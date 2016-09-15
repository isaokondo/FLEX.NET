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
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(218, 325)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(352, 326)
        '
        'OneWayRLimit
        '
        Me.OneWayRLimit.DecimalPlaces = CType(1, Short)
        Me.OneWayRLimit.DspFieldName = True
        Me.OneWayRLimit.FieldName = "片押R制限値"
        Me.OneWayRLimit.Increment = 0.1!
        Me.OneWayRLimit.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneWayRLimit.Location = New System.Drawing.Point(26, 146)
        Me.OneWayRLimit.MaxValue = "10"
        Me.OneWayRLimit.MinValue = "0"
        Me.OneWayRLimit.Name = "OneWayRLimit"
        Me.OneWayRLimit.SelectItem = Nothing
        Me.OneWayRLimit.Size = New System.Drawing.Size(414, 49)
        Me.OneWayRLimit.TabIndex = 28
        Me.OneWayRLimit.Unit = ""
        Me.OneWayRLimit.Value = 0R
        '
        'MomentPermitValue
        '
        Me.MomentPermitValue.DecimalPlaces = CType(0, Short)
        Me.MomentPermitValue.DspFieldName = True
        Me.MomentPermitValue.FieldName = "ジャッキモーメント許容値"
        Me.MomentPermitValue.Increment = 100.0!
        Me.MomentPermitValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.MomentPermitValue.Location = New System.Drawing.Point(26, 104)
        Me.MomentPermitValue.MaxValue = "100000"
        Me.MomentPermitValue.MinValue = "0"
        Me.MomentPermitValue.Name = "MomentPermitValue"
        Me.MomentPermitValue.SelectItem = Nothing
        Me.MomentPermitValue.Size = New System.Drawing.Size(432, 49)
        Me.MomentPermitValue.TabIndex = 27
        Me.MomentPermitValue.Unit = "kN・m"
        Me.MomentPermitValue.Value = 0R
        '
        'PressPermitValue
        '
        Me.PressPermitValue.DecimalPlaces = CType(1, Short)
        Me.PressPermitValue.DspFieldName = True
        Me.PressPermitValue.FieldName = "シールド圧力許容値"
        Me.PressPermitValue.Increment = 0.1!
        Me.PressPermitValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PressPermitValue.Location = New System.Drawing.Point(26, 61)
        Me.PressPermitValue.MaxValue = "200"
        Me.PressPermitValue.MinValue = "0"
        Me.PressPermitValue.Name = "PressPermitValue"
        Me.PressPermitValue.SelectItem = Nothing
        Me.PressPermitValue.Size = New System.Drawing.Size(414, 49)
        Me.PressPermitValue.TabIndex = 26
        Me.PressPermitValue.Unit = "MPa"
        Me.PressPermitValue.Value = 0R
        '
        'DirectDirectionControl
        '
        Me.DirectDirectionControl.BackColor = System.Drawing.Color.Transparent
        Me.DirectDirectionControl.FieldName = "片押し制限"
        Me.DirectDirectionControl.Location = New System.Drawing.Point(40, 13)
        Me.DirectDirectionControl.Name = "DirectDirectionControl"
        Me.DirectDirectionControl.rdbtnValue = False
        Me.DirectDirectionControl.Size = New System.Drawing.Size(403, 42)
        Me.DirectDirectionControl.SlectNoName = "する"
        Me.DirectDirectionControl.SlectYesName = "しない"
        Me.DirectDirectionControl.TabIndex = 30
        '
        'OneReduceTime
        '
        Me.OneReduceTime.DecimalPlaces = CType(0, Short)
        Me.OneReduceTime.DspFieldName = True
        Me.OneReduceTime.FieldName = "実施間隔"
        Me.OneReduceTime.Increment = 1.0!
        Me.OneReduceTime.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneReduceTime.Location = New System.Drawing.Point(26, 266)
        Me.OneReduceTime.MaxValue = "200"
        Me.OneReduceTime.MinValue = "0"
        Me.OneReduceTime.Name = "OneReduceTime"
        Me.OneReduceTime.SelectItem = Nothing
        Me.OneReduceTime.Size = New System.Drawing.Size(414, 49)
        Me.OneReduceTime.TabIndex = 34
        Me.OneReduceTime.Unit = "sec"
        Me.OneReduceTime.Value = 0R
        '
        'OneReduceValue
        '
        Me.OneReduceValue.DecimalPlaces = CType(2, Short)
        Me.OneReduceValue.DspFieldName = True
        Me.OneReduceValue.FieldName = "１回のr引き戻し量"
        Me.OneReduceValue.Increment = 1.0!
        Me.OneReduceValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OneReduceValue.Location = New System.Drawing.Point(26, 224)
        Me.OneReduceValue.MaxValue = "200"
        Me.OneReduceValue.MinValue = "0"
        Me.OneReduceValue.Name = "OneReduceValue"
        Me.OneReduceValue.SelectItem = Nothing
        Me.OneReduceValue.Size = New System.Drawing.Size(414, 49)
        Me.OneReduceValue.TabIndex = 33
        Me.OneReduceValue.Unit = ""
        Me.OneReduceValue.Value = 0R
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(14, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(449, 184)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(520, 393)
        Me.ShapeContainer1.TabIndex = 35
        Me.ShapeContainer1.TabStop = False
        '
        'frmOneWayTunnelLimit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(520, 393)
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
End Class
