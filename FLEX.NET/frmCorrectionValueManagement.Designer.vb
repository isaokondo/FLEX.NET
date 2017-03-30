<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorrectionValueManagement
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.NowRing = New FLEX.NET.ucnSpredCompnent()
        Me.PlanCommon2 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan15 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan14 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan13 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan12 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan11 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan10 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan9 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan8 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan7 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan6 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan5 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan4 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan3 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan2 = New FLEX.NET.ucnSpredCompnent()
        Me.VerPlan1 = New FLEX.NET.ucnSpredCompnent()
        Me.UcnSpredCompnent29 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan16 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan15 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan14 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan13 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan12 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan11 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan10 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan9 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan8 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan7 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan6 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan5 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan4 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan3 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan2 = New FLEX.NET.ucnSpredCompnent()
        Me.HorPlan1 = New FLEX.NET.ucnSpredCompnent()
        Me.UcnSpredCompnent4 = New FLEX.NET.ucnSpredCompnent()
        Me.PlanCommon4 = New FLEX.NET.ucnSpredCompnent()
        Me.PlanCommon3 = New FLEX.NET.ucnSpredCompnent()
        Me.PlanCommon1 = New FLEX.NET.ucnSpredCompnent()
        Me.UcnSpredCompnent14 = New FLEX.NET.ucnSpredCompnent()
        Me.VerCorrentionValue = New FLEX.NET.ucnNumEdit()
        Me.HorCorrentionValue = New FLEX.NET.ucnNumEdit()
        Me.PuchUpStroke = New FLEX.NET.ucnNumEdit()
        Me.TipDistance = New FLEX.NET.ucnNumEdit()
        Me.ConfirmRingNo = New FLEX.NET.ucnNumEdit()
        Me.tmrLineUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(168, 276)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 35)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Silver
        Me.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOK.Location = New System.Drawing.Point(39, 276)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(102, 35)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.Silver
        Me.btnCLose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCLose.Location = New System.Drawing.Point(39, 327)
        Me.btnCLose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(102, 35)
        Me.btnCLose.TabIndex = 58
        Me.btnCLose.Text = "閉じる"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'NowRing
        '
        Me.NowRing.DecimalPlaces = CType(0, Short)
        Me.NowRing.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.NowRing.FieldName = "現在のリング"
        Me.NowRing.ForeColor = System.Drawing.Color.Black
        Me.NowRing.HeaderColor = System.Drawing.Color.Empty
        Me.NowRing.Location = New System.Drawing.Point(471, 60)
        Me.NowRing.Margin = New System.Windows.Forms.Padding(2)
        Me.NowRing.Name = "NowRing"
        Me.NowRing.Size = New System.Drawing.Size(420, 21)
        Me.NowRing.TabIndex = 59
        Me.NowRing.Unit = "Ring"
        Me.NowRing.Value = 12345.0R
        '
        'PlanCommon2
        '
        Me.PlanCommon2.DecimalPlaces = CType(3, Short)
        Me.PlanCommon2.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.PlanCommon2.FieldName = "セグメント幅の追加距離"
        Me.PlanCommon2.ForeColor = System.Drawing.Color.Black
        Me.PlanCommon2.HeaderColor = System.Drawing.Color.Empty
        Me.PlanCommon2.Location = New System.Drawing.Point(471, 102)
        Me.PlanCommon2.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCommon2.Name = "PlanCommon2"
        Me.PlanCommon2.Size = New System.Drawing.Size(420, 21)
        Me.PlanCommon2.TabIndex = 57
        Me.PlanCommon2.Unit = "m"
        Me.PlanCommon2.Value = 12345.0R
        '
        'VerPlan15
        '
        Me.VerPlan15.DecimalPlaces = CType(3, Short)
        Me.VerPlan15.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan15.FieldName = "姿勢角管理値"
        Me.VerPlan15.ForeColor = System.Drawing.Color.Black
        Me.VerPlan15.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan15.Location = New System.Drawing.Point(471, 837)
        Me.VerPlan15.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan15.Name = "VerPlan15"
        Me.VerPlan15.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan15.TabIndex = 56
        Me.VerPlan15.Unit = "deg"
        Me.VerPlan15.Value = 12345.0R
        '
        'VerPlan14
        '
        Me.VerPlan14.DecimalPlaces = CType(3, Short)
        Me.VerPlan14.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan14.FieldName = "後胴部の鉛直角"
        Me.VerPlan14.ForeColor = System.Drawing.Color.Black
        Me.VerPlan14.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan14.Location = New System.Drawing.Point(471, 816)
        Me.VerPlan14.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan14.Name = "VerPlan14"
        Me.VerPlan14.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan14.TabIndex = 55
        Me.VerPlan14.Unit = "deg"
        Me.VerPlan14.Value = 12345.0R
        '
        'VerPlan13
        '
        Me.VerPlan13.DecimalPlaces = CType(3, Short)
        Me.VerPlan13.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan13.FieldName = "前胴部の鉛直角"
        Me.VerPlan13.ForeColor = System.Drawing.Color.Black
        Me.VerPlan13.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan13.Location = New System.Drawing.Point(471, 795)
        Me.VerPlan13.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan13.Name = "VerPlan13"
        Me.VerPlan13.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan13.TabIndex = 54
        Me.VerPlan13.Unit = "deg"
        Me.VerPlan13.Value = 12345.0R
        '
        'VerPlan12
        '
        Me.VerPlan12.DecimalPlaces = CType(3, Short)
        Me.VerPlan12.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan12.FieldName = "鉛直中折角"
        Me.VerPlan12.ForeColor = System.Drawing.Color.Black
        Me.VerPlan12.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan12.Location = New System.Drawing.Point(471, 774)
        Me.VerPlan12.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan12.Name = "VerPlan12"
        Me.VerPlan12.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan12.TabIndex = 53
        Me.VerPlan12.Unit = "deg"
        Me.VerPlan12.Value = 12345.0R
        '
        'VerPlan11
        '
        Me.VerPlan11.DecimalPlaces = CType(3, Short)
        Me.VerPlan11.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan11.FieldName = "シフト追加角"
        Me.VerPlan11.ForeColor = System.Drawing.Color.Black
        Me.VerPlan11.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan11.Location = New System.Drawing.Point(471, 753)
        Me.VerPlan11.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan11.Name = "VerPlan11"
        Me.VerPlan11.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan11.TabIndex = 52
        Me.VerPlan11.Unit = "deg"
        Me.VerPlan11.Value = 12345.0R
        '
        'VerPlan10
        '
        Me.VerPlan10.DecimalPlaces = CType(0, Short)
        Me.VerPlan10.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan10.FieldName = "シフト"
        Me.VerPlan10.ForeColor = System.Drawing.Color.Black
        Me.VerPlan10.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan10.Location = New System.Drawing.Point(471, 732)
        Me.VerPlan10.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan10.Name = "VerPlan10"
        Me.VerPlan10.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan10.TabIndex = 51
        Me.VerPlan10.Unit = "mm"
        Me.VerPlan10.Value = 12345.0R
        '
        'VerPlan9
        '
        Me.VerPlan9.DecimalPlaces = CType(3, Short)
        Me.VerPlan9.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan9.FieldName = "Z座標"
        Me.VerPlan9.ForeColor = System.Drawing.Color.Black
        Me.VerPlan9.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan9.Location = New System.Drawing.Point(471, 711)
        Me.VerPlan9.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan9.Name = "VerPlan9"
        Me.VerPlan9.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan9.TabIndex = 50
        Me.VerPlan9.Unit = "m"
        Me.VerPlan9.Value = 12345.0R
        '
        'VerPlan8
        '
        Me.VerPlan8.DecimalPlaces = CType(3, Short)
        Me.VerPlan8.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan8.FieldName = "後方変化点距離"
        Me.VerPlan8.ForeColor = System.Drawing.Color.Black
        Me.VerPlan8.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan8.Location = New System.Drawing.Point(471, 690)
        Me.VerPlan8.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan8.Name = "VerPlan8"
        Me.VerPlan8.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan8.TabIndex = 49
        Me.VerPlan8.Unit = "m"
        Me.VerPlan8.Value = 12345.0R
        '
        'VerPlan7
        '
        Me.VerPlan7.DecimalPlaces = CType(3, Short)
        Me.VerPlan7.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan7.FieldName = "前方変化点距離"
        Me.VerPlan7.ForeColor = System.Drawing.Color.Black
        Me.VerPlan7.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan7.Location = New System.Drawing.Point(471, 669)
        Me.VerPlan7.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan7.Name = "VerPlan7"
        Me.VerPlan7.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan7.TabIndex = 48
        Me.VerPlan7.Unit = "m"
        Me.VerPlan7.Value = 12345.0R
        '
        'VerPlan6
        '
        Me.VerPlan6.DecimalPlaces = CType(3, Short)
        Me.VerPlan6.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan6.FieldName = "曲率半径"
        Me.VerPlan6.ForeColor = System.Drawing.Color.Black
        Me.VerPlan6.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan6.Location = New System.Drawing.Point(471, 648)
        Me.VerPlan6.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan6.Name = "VerPlan6"
        Me.VerPlan6.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan6.TabIndex = 47
        Me.VerPlan6.Unit = "m"
        Me.VerPlan6.Value = 12345.0R
        '
        'VerPlan5
        '
        Me.VerPlan5.DecimalPlaces = CType(0, Short)
        Me.VerPlan5.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan5.FieldName = "線形(1:直線　２：単曲線)"
        Me.VerPlan5.ForeColor = System.Drawing.Color.Black
        Me.VerPlan5.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan5.Location = New System.Drawing.Point(471, 627)
        Me.VerPlan5.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan5.Name = "VerPlan5"
        Me.VerPlan5.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan5.TabIndex = 46
        Me.VerPlan5.Unit = Nothing
        Me.VerPlan5.Value = 12345.0R
        '
        'VerPlan4
        '
        Me.VerPlan4.DecimalPlaces = CType(0, Short)
        Me.VerPlan4.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan4.FieldName = "ゾーン"
        Me.VerPlan4.ForeColor = System.Drawing.Color.Black
        Me.VerPlan4.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan4.Location = New System.Drawing.Point(471, 606)
        Me.VerPlan4.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan4.Name = "VerPlan4"
        Me.VerPlan4.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan4.TabIndex = 45
        Me.VerPlan4.Unit = Nothing
        Me.VerPlan4.Value = 12345.0R
        '
        'VerPlan3
        '
        Me.VerPlan3.DecimalPlaces = CType(3, Short)
        Me.VerPlan3.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan3.FieldName = "起点から旋回中心までの距離"
        Me.VerPlan3.ForeColor = System.Drawing.Color.Black
        Me.VerPlan3.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan3.Location = New System.Drawing.Point(471, 585)
        Me.VerPlan3.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan3.Name = "VerPlan3"
        Me.VerPlan3.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan3.TabIndex = 44
        Me.VerPlan3.Unit = "m"
        Me.VerPlan3.Value = 12345.0R
        '
        'VerPlan2
        '
        Me.VerPlan2.DecimalPlaces = CType(3, Short)
        Me.VerPlan2.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan2.FieldName = "発進から旋回中心までの距離"
        Me.VerPlan2.ForeColor = System.Drawing.Color.Black
        Me.VerPlan2.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan2.Location = New System.Drawing.Point(471, 564)
        Me.VerPlan2.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan2.Name = "VerPlan2"
        Me.VerPlan2.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan2.TabIndex = 43
        Me.VerPlan2.Unit = "m"
        Me.VerPlan2.Value = 12345.0R
        '
        'VerPlan1
        '
        Me.VerPlan1.DecimalPlaces = CType(3, Short)
        Me.VerPlan1.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.VerPlan1.FieldName = "旋回中心"
        Me.VerPlan1.ForeColor = System.Drawing.Color.Black
        Me.VerPlan1.HeaderColor = System.Drawing.Color.Empty
        Me.VerPlan1.Location = New System.Drawing.Point(471, 543)
        Me.VerPlan1.Margin = New System.Windows.Forms.Padding(2)
        Me.VerPlan1.Name = "VerPlan1"
        Me.VerPlan1.Size = New System.Drawing.Size(420, 21)
        Me.VerPlan1.TabIndex = 42
        Me.VerPlan1.Unit = "m"
        Me.VerPlan1.Value = 12345.0R
        '
        'UcnSpredCompnent29
        '
        Me.UcnSpredCompnent29.DecimalPlaces = CType(3, Short)
        Me.UcnSpredCompnent29.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.SubHeadDspType
        Me.UcnSpredCompnent29.FieldName = "鉛直方向"
        Me.UcnSpredCompnent29.ForeColor = System.Drawing.Color.Black
        Me.UcnSpredCompnent29.HeaderColor = System.Drawing.Color.Yellow
        Me.UcnSpredCompnent29.Location = New System.Drawing.Point(471, 524)
        Me.UcnSpredCompnent29.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnSpredCompnent29.Name = "UcnSpredCompnent29"
        Me.UcnSpredCompnent29.Size = New System.Drawing.Size(420, 21)
        Me.UcnSpredCompnent29.TabIndex = 41
        Me.UcnSpredCompnent29.Unit = Nothing
        Me.UcnSpredCompnent29.Value = 0R
        '
        'HorPlan16
        '
        Me.HorPlan16.DecimalPlaces = CType(3, Short)
        Me.HorPlan16.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan16.FieldName = "姿勢角管理値"
        Me.HorPlan16.ForeColor = System.Drawing.Color.Black
        Me.HorPlan16.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan16.Location = New System.Drawing.Point(471, 501)
        Me.HorPlan16.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan16.Name = "HorPlan16"
        Me.HorPlan16.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan16.TabIndex = 40
        Me.HorPlan16.Unit = "deg"
        Me.HorPlan16.Value = 12345.0R
        '
        'HorPlan15
        '
        Me.HorPlan15.DecimalPlaces = CType(3, Short)
        Me.HorPlan15.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan15.FieldName = "後胴部の方位角"
        Me.HorPlan15.ForeColor = System.Drawing.Color.Black
        Me.HorPlan15.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan15.Location = New System.Drawing.Point(471, 480)
        Me.HorPlan15.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan15.Name = "HorPlan15"
        Me.HorPlan15.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan15.TabIndex = 39
        Me.HorPlan15.Unit = "deg"
        Me.HorPlan15.Value = 12345.0R
        '
        'HorPlan14
        '
        Me.HorPlan14.DecimalPlaces = CType(3, Short)
        Me.HorPlan14.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan14.FieldName = "前胴部の方位角"
        Me.HorPlan14.ForeColor = System.Drawing.Color.Black
        Me.HorPlan14.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan14.Location = New System.Drawing.Point(471, 459)
        Me.HorPlan14.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan14.Name = "HorPlan14"
        Me.HorPlan14.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan14.TabIndex = 38
        Me.HorPlan14.Unit = "deg"
        Me.HorPlan14.Value = 12345.0R
        '
        'HorPlan13
        '
        Me.HorPlan13.DecimalPlaces = CType(3, Short)
        Me.HorPlan13.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan13.FieldName = "水平中折角"
        Me.HorPlan13.ForeColor = System.Drawing.Color.Black
        Me.HorPlan13.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan13.Location = New System.Drawing.Point(471, 438)
        Me.HorPlan13.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan13.Name = "HorPlan13"
        Me.HorPlan13.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan13.TabIndex = 37
        Me.HorPlan13.Unit = "deg"
        Me.HorPlan13.Value = 12345.0R
        '
        'HorPlan12
        '
        Me.HorPlan12.DecimalPlaces = CType(3, Short)
        Me.HorPlan12.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan12.FieldName = "シフト追加角"
        Me.HorPlan12.ForeColor = System.Drawing.Color.Black
        Me.HorPlan12.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan12.Location = New System.Drawing.Point(471, 417)
        Me.HorPlan12.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan12.Name = "HorPlan12"
        Me.HorPlan12.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan12.TabIndex = 36
        Me.HorPlan12.Unit = "deg"
        Me.HorPlan12.Value = 12345.0R
        '
        'HorPlan11
        '
        Me.HorPlan11.DecimalPlaces = CType(0, Short)
        Me.HorPlan11.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan11.FieldName = "シフト"
        Me.HorPlan11.ForeColor = System.Drawing.Color.Black
        Me.HorPlan11.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan11.Location = New System.Drawing.Point(471, 396)
        Me.HorPlan11.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan11.Name = "HorPlan11"
        Me.HorPlan11.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan11.TabIndex = 35
        Me.HorPlan11.Unit = "mm"
        Me.HorPlan11.Value = 12345.0R
        '
        'HorPlan10
        '
        Me.HorPlan10.DecimalPlaces = CType(3, Short)
        Me.HorPlan10.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan10.FieldName = "Y座標"
        Me.HorPlan10.ForeColor = System.Drawing.Color.Black
        Me.HorPlan10.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan10.Location = New System.Drawing.Point(471, 375)
        Me.HorPlan10.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan10.Name = "HorPlan10"
        Me.HorPlan10.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan10.TabIndex = 34
        Me.HorPlan10.Unit = "m"
        Me.HorPlan10.Value = 12345.0R
        '
        'HorPlan9
        '
        Me.HorPlan9.DecimalPlaces = CType(3, Short)
        Me.HorPlan9.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan9.FieldName = "X座標"
        Me.HorPlan9.ForeColor = System.Drawing.Color.Black
        Me.HorPlan9.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan9.Location = New System.Drawing.Point(471, 354)
        Me.HorPlan9.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan9.Name = "HorPlan9"
        Me.HorPlan9.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan9.TabIndex = 33
        Me.HorPlan9.Unit = "m"
        Me.HorPlan9.Value = 12345.0R
        '
        'HorPlan8
        '
        Me.HorPlan8.DecimalPlaces = CType(3, Short)
        Me.HorPlan8.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan8.FieldName = "後方変化点距離"
        Me.HorPlan8.ForeColor = System.Drawing.Color.Black
        Me.HorPlan8.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan8.Location = New System.Drawing.Point(471, 333)
        Me.HorPlan8.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan8.Name = "HorPlan8"
        Me.HorPlan8.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan8.TabIndex = 32
        Me.HorPlan8.Unit = "m"
        Me.HorPlan8.Value = 12345.0R
        '
        'HorPlan7
        '
        Me.HorPlan7.DecimalPlaces = CType(3, Short)
        Me.HorPlan7.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan7.FieldName = "前方変化点距離"
        Me.HorPlan7.ForeColor = System.Drawing.Color.Black
        Me.HorPlan7.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan7.Location = New System.Drawing.Point(471, 312)
        Me.HorPlan7.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan7.Name = "HorPlan7"
        Me.HorPlan7.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan7.TabIndex = 31
        Me.HorPlan7.Unit = "m"
        Me.HorPlan7.Value = 12345.0R
        '
        'HorPlan6
        '
        Me.HorPlan6.DecimalPlaces = CType(3, Short)
        Me.HorPlan6.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan6.FieldName = "曲率半径"
        Me.HorPlan6.ForeColor = System.Drawing.Color.Black
        Me.HorPlan6.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan6.Location = New System.Drawing.Point(471, 291)
        Me.HorPlan6.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan6.Name = "HorPlan6"
        Me.HorPlan6.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan6.TabIndex = 30
        Me.HorPlan6.Unit = "m"
        Me.HorPlan6.Value = 12345.0R
        '
        'HorPlan5
        '
        Me.HorPlan5.DecimalPlaces = CType(0, Short)
        Me.HorPlan5.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan5.FieldName = "線形(1:直線　２：単曲線　3:緩和)"
        Me.HorPlan5.ForeColor = System.Drawing.Color.Black
        Me.HorPlan5.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan5.Location = New System.Drawing.Point(471, 270)
        Me.HorPlan5.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan5.Name = "HorPlan5"
        Me.HorPlan5.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan5.TabIndex = 29
        Me.HorPlan5.Unit = Nothing
        Me.HorPlan5.Value = 0R
        '
        'HorPlan4
        '
        Me.HorPlan4.DecimalPlaces = CType(0, Short)
        Me.HorPlan4.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan4.FieldName = "ゾーン"
        Me.HorPlan4.ForeColor = System.Drawing.Color.Black
        Me.HorPlan4.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan4.Location = New System.Drawing.Point(471, 249)
        Me.HorPlan4.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan4.Name = "HorPlan4"
        Me.HorPlan4.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan4.TabIndex = 28
        Me.HorPlan4.Unit = Nothing
        Me.HorPlan4.Value = 12345.0R
        '
        'HorPlan3
        '
        Me.HorPlan3.DecimalPlaces = CType(3, Short)
        Me.HorPlan3.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan3.FieldName = "起点から旋回中心までの距離"
        Me.HorPlan3.ForeColor = System.Drawing.Color.Black
        Me.HorPlan3.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan3.Location = New System.Drawing.Point(471, 228)
        Me.HorPlan3.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan3.Name = "HorPlan3"
        Me.HorPlan3.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan3.TabIndex = 27
        Me.HorPlan3.Unit = "m"
        Me.HorPlan3.Value = 12345.0R
        '
        'HorPlan2
        '
        Me.HorPlan2.DecimalPlaces = CType(3, Short)
        Me.HorPlan2.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan2.FieldName = "発進から旋回中心までの距離"
        Me.HorPlan2.ForeColor = System.Drawing.Color.Black
        Me.HorPlan2.HeaderColor = System.Drawing.Color.Empty
        Me.HorPlan2.Location = New System.Drawing.Point(471, 207)
        Me.HorPlan2.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan2.Name = "HorPlan2"
        Me.HorPlan2.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan2.TabIndex = 26
        Me.HorPlan2.Unit = "m"
        Me.HorPlan2.Value = 12345.0R
        '
        'HorPlan1
        '
        Me.HorPlan1.DecimalPlaces = CType(3, Short)
        Me.HorPlan1.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.HorPlan1.FieldName = "旋回中心"
        Me.HorPlan1.ForeColor = System.Drawing.Color.Black
        Me.HorPlan1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HorPlan1.Location = New System.Drawing.Point(471, 186)
        Me.HorPlan1.Margin = New System.Windows.Forms.Padding(2)
        Me.HorPlan1.Name = "HorPlan1"
        Me.HorPlan1.Size = New System.Drawing.Size(420, 21)
        Me.HorPlan1.TabIndex = 25
        Me.HorPlan1.Unit = "m"
        Me.HorPlan1.Value = 12345.0R
        '
        'UcnSpredCompnent4
        '
        Me.UcnSpredCompnent4.DecimalPlaces = CType(3, Short)
        Me.UcnSpredCompnent4.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.SubHeadDspType
        Me.UcnSpredCompnent4.FieldName = "水平方向"
        Me.UcnSpredCompnent4.ForeColor = System.Drawing.Color.Black
        Me.UcnSpredCompnent4.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UcnSpredCompnent4.Location = New System.Drawing.Point(471, 166)
        Me.UcnSpredCompnent4.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnSpredCompnent4.Name = "UcnSpredCompnent4"
        Me.UcnSpredCompnent4.Size = New System.Drawing.Size(420, 21)
        Me.UcnSpredCompnent4.TabIndex = 24
        Me.UcnSpredCompnent4.Unit = Nothing
        Me.UcnSpredCompnent4.Value = 0R
        '
        'PlanCommon4
        '
        Me.PlanCommon4.DecimalPlaces = CType(3, Short)
        Me.PlanCommon4.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.PlanCommon4.FieldName = "現在の先端距離"
        Me.PlanCommon4.ForeColor = System.Drawing.Color.Black
        Me.PlanCommon4.HeaderColor = System.Drawing.Color.Empty
        Me.PlanCommon4.Location = New System.Drawing.Point(471, 144)
        Me.PlanCommon4.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCommon4.Name = "PlanCommon4"
        Me.PlanCommon4.Size = New System.Drawing.Size(420, 21)
        Me.PlanCommon4.TabIndex = 23
        Me.PlanCommon4.Unit = "m"
        Me.PlanCommon4.Value = 12345.0R
        '
        'PlanCommon3
        '
        Me.PlanCommon3.DecimalPlaces = CType(3, Short)
        Me.PlanCommon3.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.PlanCommon3.FieldName = "押し上がりストロークの差"
        Me.PlanCommon3.ForeColor = System.Drawing.Color.Black
        Me.PlanCommon3.HeaderColor = System.Drawing.Color.Empty
        Me.PlanCommon3.Location = New System.Drawing.Point(471, 123)
        Me.PlanCommon3.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCommon3.Name = "PlanCommon3"
        Me.PlanCommon3.Size = New System.Drawing.Size(420, 21)
        Me.PlanCommon3.TabIndex = 22
        Me.PlanCommon3.Unit = "m"
        Me.PlanCommon3.Value = 12345.0R
        '
        'PlanCommon1
        '
        Me.PlanCommon1.DecimalPlaces = CType(3, Short)
        Me.PlanCommon1.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.DataDspType
        Me.PlanCommon1.FieldName = "確認リングの先端総距離"
        Me.PlanCommon1.ForeColor = System.Drawing.Color.Black
        Me.PlanCommon1.HeaderColor = System.Drawing.Color.Empty
        Me.PlanCommon1.Location = New System.Drawing.Point(471, 81)
        Me.PlanCommon1.Margin = New System.Windows.Forms.Padding(2)
        Me.PlanCommon1.Name = "PlanCommon1"
        Me.PlanCommon1.Size = New System.Drawing.Size(420, 21)
        Me.PlanCommon1.TabIndex = 21
        Me.PlanCommon1.Unit = "m"
        Me.PlanCommon1.Value = 12345.0R
        '
        'UcnSpredCompnent14
        '
        Me.UcnSpredCompnent14.DecimalPlaces = CType(3, Short)
        Me.UcnSpredCompnent14.Dsp_Style = FLEX.NET.ucnSpredCompnent.DspStyle.HeadDspType
        Me.UcnSpredCompnent14.FieldName = "項目"
        Me.UcnSpredCompnent14.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UcnSpredCompnent14.ForeColor = System.Drawing.Color.Black
        Me.UcnSpredCompnent14.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcnSpredCompnent14.Location = New System.Drawing.Point(471, 39)
        Me.UcnSpredCompnent14.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnSpredCompnent14.Name = "UcnSpredCompnent14"
        Me.UcnSpredCompnent14.Size = New System.Drawing.Size(420, 21)
        Me.UcnSpredCompnent14.TabIndex = 20
        Me.UcnSpredCompnent14.Unit = Nothing
        Me.UcnSpredCompnent14.Value = 0R
        '
        'VerCorrentionValue
        '
        Me.VerCorrentionValue.DataDspWidth = 110
        Me.VerCorrentionValue.DecimalPlaces = CType(3, Short)
        Me.VerCorrentionValue.DspFieldName = True
        Me.VerCorrentionValue.FieldName = "鉛直補正値"
        Me.VerCorrentionValue.Increment = 0.01!
        Me.VerCorrentionValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.VerCorrentionValue.Location = New System.Drawing.Point(16, 205)
        Me.VerCorrentionValue.Margin = New System.Windows.Forms.Padding(2)
        Me.VerCorrentionValue.MaxValue = "5"
        Me.VerCorrentionValue.MinValue = "-5"
        Me.VerCorrentionValue.Name = "VerCorrentionValue"
        Me.VerCorrentionValue.SelectItem = Nothing
        Me.VerCorrentionValue.Size = New System.Drawing.Size(415, 30)
        Me.VerCorrentionValue.TabIndex = 4
        Me.VerCorrentionValue.ttMsg = ""
        Me.VerCorrentionValue.ttTile = ""
        Me.VerCorrentionValue.Unit = "deg"
        Me.VerCorrentionValue.Value = 0R
        '
        'HorCorrentionValue
        '
        Me.HorCorrentionValue.DataDspWidth = 110
        Me.HorCorrentionValue.DecimalPlaces = CType(3, Short)
        Me.HorCorrentionValue.DspFieldName = True
        Me.HorCorrentionValue.FieldName = "水平補正値"
        Me.HorCorrentionValue.Increment = 0.01!
        Me.HorCorrentionValue.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.HorCorrentionValue.Location = New System.Drawing.Point(16, 172)
        Me.HorCorrentionValue.Margin = New System.Windows.Forms.Padding(2)
        Me.HorCorrentionValue.MaxValue = "5"
        Me.HorCorrentionValue.MinValue = "-5"
        Me.HorCorrentionValue.Name = "HorCorrentionValue"
        Me.HorCorrentionValue.SelectItem = Nothing
        Me.HorCorrentionValue.Size = New System.Drawing.Size(415, 30)
        Me.HorCorrentionValue.TabIndex = 3
        Me.HorCorrentionValue.ttMsg = ""
        Me.HorCorrentionValue.ttTile = ""
        Me.HorCorrentionValue.Unit = "deg"
        Me.HorCorrentionValue.Value = 0R
        '
        'PuchUpStroke
        '
        Me.PuchUpStroke.DataDspWidth = 110
        Me.PuchUpStroke.DecimalPlaces = CType(0, Short)
        Me.PuchUpStroke.DspFieldName = True
        Me.PuchUpStroke.FieldName = "押し上がりストローク"
        Me.PuchUpStroke.Increment = 1.0!
        Me.PuchUpStroke.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.PuchUpStroke.Location = New System.Drawing.Point(20, 116)
        Me.PuchUpStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.PuchUpStroke.MaxValue = "10000"
        Me.PuchUpStroke.MinValue = "-100"
        Me.PuchUpStroke.Name = "PuchUpStroke"
        Me.PuchUpStroke.SelectItem = Nothing
        Me.PuchUpStroke.Size = New System.Drawing.Size(425, 30)
        Me.PuchUpStroke.TabIndex = 2
        Me.PuchUpStroke.ttMsg = ""
        Me.PuchUpStroke.ttTile = ""
        Me.PuchUpStroke.Unit = "mm"
        Me.PuchUpStroke.Value = 1000.0R
        '
        'TipDistance
        '
        Me.TipDistance.DataDspWidth = 110
        Me.TipDistance.DecimalPlaces = CType(3, Short)
        Me.TipDistance.DspFieldName = True
        Me.TipDistance.FieldName = "先端の総距離"
        Me.TipDistance.Increment = 0.01!
        Me.TipDistance.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.TipDistance.Location = New System.Drawing.Point(20, 81)
        Me.TipDistance.Margin = New System.Windows.Forms.Padding(2)
        Me.TipDistance.MaxValue = "10000"
        Me.TipDistance.MinValue = "-100"
        Me.TipDistance.Name = "TipDistance"
        Me.TipDistance.SelectItem = Nothing
        Me.TipDistance.Size = New System.Drawing.Size(425, 30)
        Me.TipDistance.TabIndex = 1
        Me.TipDistance.ttMsg = ""
        Me.TipDistance.ttTile = ""
        Me.TipDistance.Unit = "m"
        Me.TipDistance.Value = 1000.0R
        '
        'ConfirmRingNo
        '
        Me.ConfirmRingNo.DataDspWidth = 110
        Me.ConfirmRingNo.DecimalPlaces = CType(0, Short)
        Me.ConfirmRingNo.DspFieldName = True
        Me.ConfirmRingNo.FieldName = "確認リング"
        Me.ConfirmRingNo.Increment = 1.0!
        Me.ConfirmRingNo.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.ConfirmRingNo.Location = New System.Drawing.Point(20, 46)
        Me.ConfirmRingNo.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmRingNo.MaxValue = "10000"
        Me.ConfirmRingNo.MinValue = "-100"
        Me.ConfirmRingNo.Name = "ConfirmRingNo"
        Me.ConfirmRingNo.SelectItem = Nothing
        Me.ConfirmRingNo.Size = New System.Drawing.Size(425, 30)
        Me.ConfirmRingNo.TabIndex = 0
        Me.ConfirmRingNo.ttMsg = "測量で距離を確認したシールド機の押し上がりリング番号"
        Me.ConfirmRingNo.ttTile = "補正値管理"
        Me.ConfirmRingNo.Unit = "リング"
        Me.ConfirmRingNo.Value = 10.0R
        '
        'tmrLineUpdate
        '
        Me.tmrLineUpdate.Enabled = True
        Me.tmrLineUpdate.Interval = 1000
        '
        'frmCorrectionValueManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(932, 869)
        Me.ControlBox = False
        Me.Controls.Add(Me.NowRing)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.PlanCommon2)
        Me.Controls.Add(Me.VerPlan15)
        Me.Controls.Add(Me.VerPlan14)
        Me.Controls.Add(Me.VerPlan13)
        Me.Controls.Add(Me.VerPlan12)
        Me.Controls.Add(Me.VerPlan11)
        Me.Controls.Add(Me.VerPlan10)
        Me.Controls.Add(Me.VerPlan9)
        Me.Controls.Add(Me.VerPlan8)
        Me.Controls.Add(Me.VerPlan7)
        Me.Controls.Add(Me.VerPlan6)
        Me.Controls.Add(Me.VerPlan5)
        Me.Controls.Add(Me.VerPlan4)
        Me.Controls.Add(Me.VerPlan3)
        Me.Controls.Add(Me.VerPlan2)
        Me.Controls.Add(Me.VerPlan1)
        Me.Controls.Add(Me.UcnSpredCompnent29)
        Me.Controls.Add(Me.HorPlan16)
        Me.Controls.Add(Me.HorPlan15)
        Me.Controls.Add(Me.HorPlan14)
        Me.Controls.Add(Me.HorPlan13)
        Me.Controls.Add(Me.HorPlan12)
        Me.Controls.Add(Me.HorPlan11)
        Me.Controls.Add(Me.HorPlan10)
        Me.Controls.Add(Me.HorPlan9)
        Me.Controls.Add(Me.HorPlan8)
        Me.Controls.Add(Me.HorPlan7)
        Me.Controls.Add(Me.HorPlan6)
        Me.Controls.Add(Me.HorPlan5)
        Me.Controls.Add(Me.HorPlan4)
        Me.Controls.Add(Me.HorPlan3)
        Me.Controls.Add(Me.HorPlan2)
        Me.Controls.Add(Me.HorPlan1)
        Me.Controls.Add(Me.UcnSpredCompnent4)
        Me.Controls.Add(Me.PlanCommon4)
        Me.Controls.Add(Me.PlanCommon3)
        Me.Controls.Add(Me.PlanCommon1)
        Me.Controls.Add(Me.UcnSpredCompnent14)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.VerCorrentionValue)
        Me.Controls.Add(Me.HorCorrentionValue)
        Me.Controls.Add(Me.PuchUpStroke)
        Me.Controls.Add(Me.TipDistance)
        Me.Controls.Add(Me.ConfirmRingNo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCorrectionValueManagement"
        Me.Text = "補正値管理"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConfirmRingNo As FLEX.NET.ucnNumEdit
    Friend WithEvents TipDistance As FLEX.NET.ucnNumEdit
    Friend WithEvents PuchUpStroke As FLEX.NET.ucnNumEdit
    Friend WithEvents VerCorrentionValue As FLEX.NET.ucnNumEdit
    Friend WithEvents HorCorrentionValue As FLEX.NET.ucnNumEdit
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents UcnSpredCompnent14 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents PlanCommon1 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents PlanCommon3 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents PlanCommon4 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents UcnSpredCompnent4 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan1 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan2 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan3 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan4 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan5 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan6 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan7 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan8 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan9 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan10 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan11 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan12 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan13 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan14 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan15 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents HorPlan16 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan7 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan6 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan5 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan4 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan3 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan2 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan1 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents UcnSpredCompnent29 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan15 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan14 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan13 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan12 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan11 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan10 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan9 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents VerPlan8 As FLEX.NET.ucnSpredCompnent
    Friend WithEvents PlanCommon2 As ucnSpredCompnent
    Friend WithEvents btnCLose As Button
    Friend WithEvents NowRing As ucnSpredCompnent
    Friend WithEvents tmrLineUpdate As Timer
End Class
