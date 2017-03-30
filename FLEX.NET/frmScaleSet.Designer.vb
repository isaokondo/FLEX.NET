<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScaleSet
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
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.nudHorMomentTrendWidth = New FLEX.NET.ucnNumEdit()
        Me.nudVerMomentTrendWidth = New FLEX.NET.ucnNumEdit()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.nudHorDevDegTrendWidth = New FLEX.NET.ucnNumEdit()
        Me.nudVerDevDegTrendWidth = New FLEX.NET.ucnNumEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudLineDevStartRing = New FLEX.NET.ucnNumEdit()
        Me.nudLineDevLastRing = New FLEX.NET.ucnNumEdit()
        Me.nudPresBarGraphWidt = New FLEX.NET.ucnNumEdit()
        Me.nudDevTolerance = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(250, 606)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(376, 606)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(18, 23)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(460, 130)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(507, 664)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.White
        Me.RectangleShape3.CornerRadius = 10
        Me.RectangleShape3.Location = New System.Drawing.Point(15, 343)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(460, 130)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(16, 183)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(460, 130)
        '
        'nudHorMomentTrendWidth
        '
        Me.nudHorMomentTrendWidth.DataDspWidth = 110
        Me.nudHorMomentTrendWidth.DecimalPlaces = CType(0, Short)
        Me.nudHorMomentTrendWidth.DspFieldName = True
        Me.nudHorMomentTrendWidth.FieldName = "水平　　　　　　　　　　±"
        Me.nudHorMomentTrendWidth.Increment = 100.0!
        Me.nudHorMomentTrendWidth.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudHorMomentTrendWidth.Location = New System.Drawing.Point(35, 66)
        Me.nudHorMomentTrendWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.nudHorMomentTrendWidth.MaxValue = "100000"
        Me.nudHorMomentTrendWidth.MinValue = "0"
        Me.nudHorMomentTrendWidth.Name = "nudHorMomentTrendWidth"
        Me.nudHorMomentTrendWidth.SelectItem = Nothing
        Me.nudHorMomentTrendWidth.Size = New System.Drawing.Size(424, 30)
        Me.nudHorMomentTrendWidth.TabIndex = 27
        Me.nudHorMomentTrendWidth.ttMsg = ""
        Me.nudHorMomentTrendWidth.ttTile = ""
        Me.nudHorMomentTrendWidth.Unit = "ｋN・m"
        Me.nudHorMomentTrendWidth.Value = 0R
        '
        'nudVerMomentTrendWidth
        '
        Me.nudVerMomentTrendWidth.DataDspWidth = 110
        Me.nudVerMomentTrendWidth.DecimalPlaces = CType(0, Short)
        Me.nudVerMomentTrendWidth.DspFieldName = True
        Me.nudVerMomentTrendWidth.FieldName = "鉛直　　　　　　　　　　±"
        Me.nudVerMomentTrendWidth.Increment = 100.0!
        Me.nudVerMomentTrendWidth.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudVerMomentTrendWidth.Location = New System.Drawing.Point(34, 100)
        Me.nudVerMomentTrendWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.nudVerMomentTrendWidth.MaxValue = "100000"
        Me.nudVerMomentTrendWidth.MinValue = "0"
        Me.nudVerMomentTrendWidth.Name = "nudVerMomentTrendWidth"
        Me.nudVerMomentTrendWidth.SelectItem = Nothing
        Me.nudVerMomentTrendWidth.Size = New System.Drawing.Size(424, 30)
        Me.nudVerMomentTrendWidth.TabIndex = 28
        Me.nudVerMomentTrendWidth.ttMsg = ""
        Me.nudVerMomentTrendWidth.ttTile = ""
        Me.nudVerMomentTrendWidth.Unit = "ｋN・m"
        Me.nudVerMomentTrendWidth.Value = 0R
        '
        'lblFieldName
        '
        Me.lblFieldName.AutoSize = True
        Me.lblFieldName.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.ForeColor = System.Drawing.Color.White
        Me.lblFieldName.Location = New System.Drawing.Point(32, 39)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(115, 15)
        Me.lblFieldName.TabIndex = 29
        Me.lblFieldName.Text = "モーメントトレンド"
        '
        'nudHorDevDegTrendWidth
        '
        Me.nudHorDevDegTrendWidth.DataDspWidth = 110
        Me.nudHorDevDegTrendWidth.DecimalPlaces = CType(2, Short)
        Me.nudHorDevDegTrendWidth.DspFieldName = True
        Me.nudHorDevDegTrendWidth.FieldName = "水平　　　　　　　　　　±"
        Me.nudHorDevDegTrendWidth.Increment = 0.01!
        Me.nudHorDevDegTrendWidth.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudHorDevDegTrendWidth.Location = New System.Drawing.Point(35, 223)
        Me.nudHorDevDegTrendWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.nudHorDevDegTrendWidth.MaxValue = "10"
        Me.nudHorDevDegTrendWidth.MinValue = "0"
        Me.nudHorDevDegTrendWidth.Name = "nudHorDevDegTrendWidth"
        Me.nudHorDevDegTrendWidth.SelectItem = Nothing
        Me.nudHorDevDegTrendWidth.Size = New System.Drawing.Size(424, 30)
        Me.nudHorDevDegTrendWidth.TabIndex = 30
        Me.nudHorDevDegTrendWidth.ttMsg = ""
        Me.nudHorDevDegTrendWidth.ttTile = ""
        Me.nudHorDevDegTrendWidth.Unit = "deg"
        Me.nudHorDevDegTrendWidth.Value = 0R
        '
        'nudVerDevDegTrendWidth
        '
        Me.nudVerDevDegTrendWidth.DataDspWidth = 110
        Me.nudVerDevDegTrendWidth.DecimalPlaces = CType(2, Short)
        Me.nudVerDevDegTrendWidth.DspFieldName = True
        Me.nudVerDevDegTrendWidth.FieldName = "鉛直　　　　　　　　　　±"
        Me.nudVerDevDegTrendWidth.Increment = 0.01!
        Me.nudVerDevDegTrendWidth.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudVerDevDegTrendWidth.Location = New System.Drawing.Point(35, 258)
        Me.nudVerDevDegTrendWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.nudVerDevDegTrendWidth.MaxValue = "10"
        Me.nudVerDevDegTrendWidth.MinValue = "0"
        Me.nudVerDevDegTrendWidth.Name = "nudVerDevDegTrendWidth"
        Me.nudVerDevDegTrendWidth.SelectItem = Nothing
        Me.nudVerDevDegTrendWidth.Size = New System.Drawing.Size(424, 30)
        Me.nudVerDevDegTrendWidth.TabIndex = 31
        Me.nudVerDevDegTrendWidth.ttMsg = ""
        Me.nudVerDevDegTrendWidth.ttTile = ""
        Me.nudVerDevDegTrendWidth.Unit = "deg"
        Me.nudVerDevDegTrendWidth.Value = 0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 194)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "偏角トレンド"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 358)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "姿勢角トレンド（補正値管理表示時）"
        '
        'nudLineDevStartRing
        '
        Me.nudLineDevStartRing.DataDspWidth = 110
        Me.nudLineDevStartRing.DecimalPlaces = CType(0, Short)
        Me.nudLineDevStartRing.DspFieldName = True
        Me.nudLineDevStartRing.FieldName = "表示始点リング   　　　   －"
        Me.nudLineDevStartRing.Increment = 1.0!
        Me.nudLineDevStartRing.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudLineDevStartRing.Location = New System.Drawing.Point(35, 387)
        Me.nudLineDevStartRing.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLineDevStartRing.MaxValue = "10"
        Me.nudLineDevStartRing.MinValue = "1"
        Me.nudLineDevStartRing.Name = "nudLineDevStartRing"
        Me.nudLineDevStartRing.SelectItem = Nothing
        Me.nudLineDevStartRing.Size = New System.Drawing.Size(424, 30)
        Me.nudLineDevStartRing.TabIndex = 34
        Me.nudLineDevStartRing.ttMsg = ""
        Me.nudLineDevStartRing.ttTile = ""
        Me.nudLineDevStartRing.Unit = "リング"
        Me.nudLineDevStartRing.Value = 10.0R
        '
        'nudLineDevLastRing
        '
        Me.nudLineDevLastRing.DataDspWidth = 110
        Me.nudLineDevLastRing.DecimalPlaces = CType(0, Short)
        Me.nudLineDevLastRing.DspFieldName = True
        Me.nudLineDevLastRing.FieldName = "表示終点リング　　　　　　＋"
        Me.nudLineDevLastRing.Increment = 1.0!
        Me.nudLineDevLastRing.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudLineDevLastRing.Location = New System.Drawing.Point(35, 422)
        Me.nudLineDevLastRing.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLineDevLastRing.MaxValue = "10"
        Me.nudLineDevLastRing.MinValue = "1"
        Me.nudLineDevLastRing.Name = "nudLineDevLastRing"
        Me.nudLineDevLastRing.SelectItem = Nothing
        Me.nudLineDevLastRing.Size = New System.Drawing.Size(424, 30)
        Me.nudLineDevLastRing.TabIndex = 35
        Me.nudLineDevLastRing.ttMsg = ""
        Me.nudLineDevLastRing.ttTile = ""
        Me.nudLineDevLastRing.Unit = "リング"
        Me.nudLineDevLastRing.Value = 10.0R
        '
        'nudPresBarGraphWidt
        '
        Me.nudPresBarGraphWidt.DataDspWidth = 110
        Me.nudPresBarGraphWidt.DecimalPlaces = CType(0, Short)
        Me.nudPresBarGraphWidt.DspFieldName = True
        Me.nudPresBarGraphWidt.FieldName = "圧力バーグラフ"
        Me.nudPresBarGraphWidt.Increment = 1.0!
        Me.nudPresBarGraphWidt.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudPresBarGraphWidt.Location = New System.Drawing.Point(35, 504)
        Me.nudPresBarGraphWidt.Margin = New System.Windows.Forms.Padding(2)
        Me.nudPresBarGraphWidt.MaxValue = "100"
        Me.nudPresBarGraphWidt.MinValue = "0"
        Me.nudPresBarGraphWidt.Name = "nudPresBarGraphWidt"
        Me.nudPresBarGraphWidt.SelectItem = Nothing
        Me.nudPresBarGraphWidt.Size = New System.Drawing.Size(424, 30)
        Me.nudPresBarGraphWidt.TabIndex = 36
        Me.nudPresBarGraphWidt.ttMsg = ""
        Me.nudPresBarGraphWidt.ttTile = ""
        Me.nudPresBarGraphWidt.Unit = "Mpa"
        Me.nudPresBarGraphWidt.Value = 100.0R
        '
        'nudDevTolerance
        '
        Me.nudDevTolerance.DataDspWidth = 110
        Me.nudDevTolerance.DecimalPlaces = CType(1, Short)
        Me.nudDevTolerance.DspFieldName = True
        Me.nudDevTolerance.FieldName = "偏角許容値　　　　　　±"
        Me.nudDevTolerance.Increment = 0.1!
        Me.nudDevTolerance.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.nudDevTolerance.Location = New System.Drawing.Point(35, 548)
        Me.nudDevTolerance.Margin = New System.Windows.Forms.Padding(2)
        Me.nudDevTolerance.MaxValue = "10"
        Me.nudDevTolerance.MinValue = "0"
        Me.nudDevTolerance.Name = "nudDevTolerance"
        Me.nudDevTolerance.SelectItem = Nothing
        Me.nudDevTolerance.Size = New System.Drawing.Size(424, 30)
        Me.nudDevTolerance.TabIndex = 37
        Me.nudDevTolerance.ttMsg = ""
        Me.nudDevTolerance.ttTile = ""
        Me.nudDevTolerance.Unit = "deg"
        Me.nudDevTolerance.Value = 0R
        '
        'frmScaleSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 664)
        Me.Controls.Add(Me.nudDevTolerance)
        Me.Controls.Add(Me.nudPresBarGraphWidt)
        Me.Controls.Add(Me.nudLineDevLastRing)
        Me.Controls.Add(Me.nudLineDevStartRing)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudVerDevDegTrendWidth)
        Me.Controls.Add(Me.nudHorDevDegTrendWidth)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.nudVerMomentTrendWidth)
        Me.Controls.Add(Me.nudHorMomentTrendWidth)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmScaleSet"
        Me.Text = "frmScaleSet"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.nudHorMomentTrendWidth, 0)
        Me.Controls.SetChildIndex(Me.nudVerMomentTrendWidth, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.nudHorDevDegTrendWidth, 0)
        Me.Controls.SetChildIndex(Me.nudVerDevDegTrendWidth, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.nudLineDevStartRing, 0)
        Me.Controls.SetChildIndex(Me.nudLineDevLastRing, 0)
        Me.Controls.SetChildIndex(Me.nudPresBarGraphWidt, 0)
        Me.Controls.SetChildIndex(Me.nudDevTolerance, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents nudHorMomentTrendWidth As ucnNumEdit
    Friend WithEvents nudVerMomentTrendWidth As ucnNumEdit
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Private WithEvents lblFieldName As Label
    Friend WithEvents nudHorDevDegTrendWidth As ucnNumEdit
    Private WithEvents Label1 As Label
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Private WithEvents Label2 As Label
    Friend WithEvents nudLineDevStartRing As ucnNumEdit
    Friend WithEvents nudLineDevLastRing As ucnNumEdit
    Friend WithEvents nudPresBarGraphWidt As ucnNumEdit
    Friend WithEvents nudVerDevDegTrendWidth As ucnNumEdit
    Friend WithEvents nudDevTolerance As ucnNumEdit
End Class
