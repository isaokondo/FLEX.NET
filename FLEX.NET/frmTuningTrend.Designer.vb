<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTuningTrend
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
        Me.GroupSelect = New FLEX.NET.ucnNumEdit()
        Me.DspGroupSV = New FLEX.NET.ucnDspData()
        Me.DspGroupPV = New FLEX.NET.ucnDspData()
        Me.DspGroupMV = New FLEX.NET.ucnDspData()
        Me.DspJackPress = New FLEX.NET.ucnDspData()
        Me.picChart = New System.Windows.Forms.PictureBox()
        Me.lblHighPress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNowTime = New System.Windows.Forms.Label()
        Me.lbl5minBefore = New System.Windows.Forms.Label()
        Me.barSv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.barPv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.barMv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(643, 644)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(576, 650)
        Me.btnCancel.Visible = False
        '
        'GroupSelect
        '
        Me.GroupSelect.DataDspWidth = 50
        Me.GroupSelect.DecimalPlaces = CType(0, Short)
        Me.GroupSelect.DspFieldName = True
        Me.GroupSelect.FieldName = "グループ選択"
        Me.GroupSelect.Increment = 1.0!
        Me.GroupSelect.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.GroupSelect.Location = New System.Drawing.Point(11, 11)
        Me.GroupSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupSelect.MaxValue = "200"
        Me.GroupSelect.MinValue = "1"
        Me.GroupSelect.Name = "GroupSelect"
        Me.GroupSelect.SelectItem = Nothing
        Me.GroupSelect.Size = New System.Drawing.Size(292, 39)
        Me.GroupSelect.TabIndex = 27
        Me.GroupSelect.Unit = ""
        Me.GroupSelect.Value = 1.0R
        '
        'DspGroupSV
        '
        Me.DspGroupSV.BackColor = System.Drawing.Color.Transparent
        Me.DspGroupSV.Blink = False
        Me.DspGroupSV.BlinkColor = System.Drawing.Color.Red
        Me.DspGroupSV.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspGroupSV.DataWidth = 93
        Me.DspGroupSV.DecimalPlaces = CType(1, Short)
        Me.DspGroupSV.FieldName = "グループ圧設定値"
        Me.DspGroupSV.FieldNameWidth = 146
        Me.DspGroupSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspGroupSV.Location = New System.Drawing.Point(11, 53)
        Me.DspGroupSV.Margin = New System.Windows.Forms.Padding(1)
        Me.DspGroupSV.Name = "DspGroupSV"
        Me.DspGroupSV.Size = New System.Drawing.Size(305, 32)
        Me.DspGroupSV.TabIndex = 31
        Me.DspGroupSV.Unit = "MPa"
        Me.DspGroupSV.UnitVisible = True
        Me.DspGroupSV.Value = "123.45 "
        Me.DspGroupSV.ValueType = False
        '
        'DspGroupPV
        '
        Me.DspGroupPV.BackColor = System.Drawing.Color.Transparent
        Me.DspGroupPV.Blink = False
        Me.DspGroupPV.BlinkColor = System.Drawing.Color.Red
        Me.DspGroupPV.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspGroupPV.DataWidth = 93
        Me.DspGroupPV.DecimalPlaces = CType(1, Short)
        Me.DspGroupPV.FieldName = "グループ圧実測値"
        Me.DspGroupPV.FieldNameWidth = 146
        Me.DspGroupPV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspGroupPV.Location = New System.Drawing.Point(11, 87)
        Me.DspGroupPV.Margin = New System.Windows.Forms.Padding(1)
        Me.DspGroupPV.Name = "DspGroupPV"
        Me.DspGroupPV.Size = New System.Drawing.Size(305, 32)
        Me.DspGroupPV.TabIndex = 32
        Me.DspGroupPV.Unit = "MPa"
        Me.DspGroupPV.UnitVisible = True
        Me.DspGroupPV.Value = "123.45 "
        Me.DspGroupPV.ValueType = False
        '
        'DspGroupMV
        '
        Me.DspGroupMV.BackColor = System.Drawing.Color.Transparent
        Me.DspGroupMV.Blink = False
        Me.DspGroupMV.BlinkColor = System.Drawing.Color.Red
        Me.DspGroupMV.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspGroupMV.DataWidth = 93
        Me.DspGroupMV.DecimalPlaces = CType(1, Short)
        Me.DspGroupMV.FieldName = "グループ圧出力"
        Me.DspGroupMV.FieldNameWidth = 146
        Me.DspGroupMV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspGroupMV.Location = New System.Drawing.Point(11, 121)
        Me.DspGroupMV.Margin = New System.Windows.Forms.Padding(1)
        Me.DspGroupMV.Name = "DspGroupMV"
        Me.DspGroupMV.Size = New System.Drawing.Size(305, 32)
        Me.DspGroupMV.TabIndex = 33
        Me.DspGroupMV.Unit = "%"
        Me.DspGroupMV.UnitVisible = True
        Me.DspGroupMV.Value = "123.45 "
        Me.DspGroupMV.ValueType = False
        '
        'DspJackPress
        '
        Me.DspJackPress.BackColor = System.Drawing.Color.Transparent
        Me.DspJackPress.Blink = False
        Me.DspJackPress.BlinkColor = System.Drawing.Color.Red
        Me.DspJackPress.DataTextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DspJackPress.DataWidth = 93
        Me.DspJackPress.DecimalPlaces = CType(1, Short)
        Me.DspJackPress.FieldName = "シールド圧"
        Me.DspJackPress.FieldNameWidth = 146
        Me.DspJackPress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DspJackPress.Location = New System.Drawing.Point(452, 53)
        Me.DspJackPress.Margin = New System.Windows.Forms.Padding(1)
        Me.DspJackPress.Name = "DspJackPress"
        Me.DspJackPress.Size = New System.Drawing.Size(305, 32)
        Me.DspJackPress.TabIndex = 34
        Me.DspJackPress.Unit = "MPa"
        Me.DspJackPress.UnitVisible = True
        Me.DspJackPress.Value = "123.45 "
        Me.DspJackPress.ValueType = False
        '
        'picChart
        '
        Me.picChart.BackColor = System.Drawing.Color.Black
        Me.picChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChart.Location = New System.Drawing.Point(71, 175)
        Me.picChart.Margin = New System.Windows.Forms.Padding(2)
        Me.picChart.Name = "picChart"
        Me.picChart.Size = New System.Drawing.Size(674, 438)
        Me.picChart.TabIndex = 36
        Me.picChart.TabStop = False
        '
        'lblHighPress
        '
        Me.lblHighPress.BackColor = System.Drawing.Color.Transparent
        Me.lblHighPress.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblHighPress.ForeColor = System.Drawing.Color.Black
        Me.lblHighPress.Location = New System.Drawing.Point(750, 169)
        Me.lblHighPress.Name = "lblHighPress"
        Me.lblHighPress.Size = New System.Drawing.Size(78, 23)
        Me.lblHighPress.TabIndex = 37
        Me.lblHighPress.Text = "35.0 MPa"
        Me.lblHighPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(750, 599)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "0.0 MPa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 598)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "0 %"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "100%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNowTime
        '
        Me.lblNowTime.BackColor = System.Drawing.Color.Transparent
        Me.lblNowTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblNowTime.ForeColor = System.Drawing.Color.DarkViolet
        Me.lblNowTime.Location = New System.Drawing.Point(680, 616)
        Me.lblNowTime.Name = "lblNowTime"
        Me.lblNowTime.Size = New System.Drawing.Size(88, 15)
        Me.lblNowTime.TabIndex = 41
        Me.lblNowTime.Text = "hh:mm:ss"
        Me.lblNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl5minBefore
        '
        Me.lbl5minBefore.BackColor = System.Drawing.Color.Transparent
        Me.lbl5minBefore.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl5minBefore.ForeColor = System.Drawing.Color.DarkViolet
        Me.lbl5minBefore.Location = New System.Drawing.Point(23, 616)
        Me.lbl5minBefore.Name = "lbl5minBefore"
        Me.lbl5minBefore.Size = New System.Drawing.Size(88, 15)
        Me.lbl5minBefore.TabIndex = 42
        Me.lbl5minBefore.Text = "hh:mm:ss"
        Me.lbl5minBefore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'barSv
        '
        Me.barSv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barSv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barSv.Location = New System.Drawing.Point(320, 56)
        Me.barSv.Name = "barSv"
        Me.barSv.Size = New System.Drawing.Size(43, 28)
        '
        'barPv
        '
        Me.barPv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barPv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barPv.Location = New System.Drawing.Point(320, 89)
        Me.barPv.Name = "barPv"
        Me.barPv.Size = New System.Drawing.Size(43, 28)
        '
        'barMv
        '
        Me.barMv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barMv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barMv.Location = New System.Drawing.Point(320, 123)
        Me.barMv.Name = "barMv"
        Me.barMv.Size = New System.Drawing.Size(43, 28)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.barMv, Me.barPv, Me.barSv})
        Me.ShapeContainer1.Size = New System.Drawing.Size(832, 681)
        Me.ShapeContainer1.TabIndex = 43
        Me.ShapeContainer1.TabStop = False
        '
        'frmTuningTrend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 681)
        Me.Controls.Add(Me.lbl5minBefore)
        Me.Controls.Add(Me.lblNowTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHighPress)
        Me.Controls.Add(Me.picChart)
        Me.Controls.Add(Me.DspJackPress)
        Me.Controls.Add(Me.DspGroupMV)
        Me.Controls.Add(Me.DspGroupPV)
        Me.Controls.Add(Me.DspGroupSV)
        Me.Controls.Add(Me.GroupSelect)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmTuningTrend"
        Me.Text = "frmTuningTrend"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.GroupSelect, 0)
        Me.Controls.SetChildIndex(Me.DspGroupSV, 0)
        Me.Controls.SetChildIndex(Me.DspGroupPV, 0)
        Me.Controls.SetChildIndex(Me.DspGroupMV, 0)
        Me.Controls.SetChildIndex(Me.DspJackPress, 0)
        Me.Controls.SetChildIndex(Me.picChart, 0)
        Me.Controls.SetChildIndex(Me.lblHighPress, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblNowTime, 0)
        Me.Controls.SetChildIndex(Me.lbl5minBefore, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        CType(Me.picChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupSelect As ucnNumEdit
    Friend WithEvents DspGroupSV As ucnDspData
    Friend WithEvents DspGroupPV As ucnDspData
    Friend WithEvents DspGroupMV As ucnDspData
    Friend WithEvents DspJackPress As ucnDspData
    Protected WithEvents picChart As PictureBox
    Friend WithEvents lblHighPress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNowTime As Label
    Friend WithEvents lbl5minBefore As Label
    Friend WithEvents barSv As PowerPacks.RectangleShape
    Friend WithEvents barPv As PowerPacks.RectangleShape
    Friend WithEvents barMv As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
End Class
