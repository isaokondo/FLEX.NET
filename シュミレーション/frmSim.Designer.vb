<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSim
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmrPlcWR = New System.Windows.Forms.Timer(Me.components)
        Me.chkExcavOn = New System.Windows.Forms.CheckBox()
        Me.chkFlexOn = New System.Windows.Forms.CheckBox()
        Me.nudSoucePressure = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudLeftStroke = New System.Windows.Forms.NumericUpDown()
        Me.nudRightStroke = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnJackAllSelect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudRightSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudLeftSpeed = New System.Windows.Forms.NumericUpDown()
        Me.tmrRightJack = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeftJack = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAuto = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudGyairo = New System.Windows.Forms.NumericUpDown()
        Me.label22 = New System.Windows.Forms.Label()
        Me.nudPitching = New System.Windows.Forms.NumericUpDown()
        Me.DgvLosZero = New System.Windows.Forms.DataGridView()
        Me.nudLosZeroStatusMachin = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudLosZeroStsFlex = New System.Windows.Forms.NumericUpDown()
        Me.chkLosZeroEnable = New System.Windows.Forms.CheckBox()
        Me.chkLosZeroMode = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.JackNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcavOrSegment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PullBakOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PullBackAns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosetOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosetAns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PullBackCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosetCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddClosetCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nudSoucePressure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLeftStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRightStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRightSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLeftSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGyairo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPitching, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvLosZero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLosZeroStatusMachin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLosZeroStsFlex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlcWR
        '
        '
        'chkExcavOn
        '
        Me.chkExcavOn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkExcavOn.Location = New System.Drawing.Point(330, 304)
        Me.chkExcavOn.Margin = New System.Windows.Forms.Padding(2)
        Me.chkExcavOn.Name = "chkExcavOn"
        Me.chkExcavOn.Size = New System.Drawing.Size(98, 24)
        Me.chkExcavOn.TabIndex = 0
        Me.chkExcavOn.Text = "掘進中"
        Me.chkExcavOn.UseVisualStyleBackColor = True
        '
        'chkFlexOn
        '
        Me.chkFlexOn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkFlexOn.Location = New System.Drawing.Point(330, 334)
        Me.chkFlexOn.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFlexOn.Name = "chkFlexOn"
        Me.chkFlexOn.Size = New System.Drawing.Size(98, 24)
        Me.chkFlexOn.TabIndex = 1
        Me.chkFlexOn.Text = "FLEX ON"
        Me.chkFlexOn.UseVisualStyleBackColor = True
        '
        'nudSoucePressure
        '
        Me.nudSoucePressure.DecimalPlaces = 1
        Me.nudSoucePressure.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudSoucePressure.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudSoucePressure.Location = New System.Drawing.Point(404, 408)
        Me.nudSoucePressure.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSoucePressure.Name = "nudSoucePressure"
        Me.nudSoucePressure.Size = New System.Drawing.Size(83, 27)
        Me.nudSoucePressure.TabIndex = 2
        Me.nudSoucePressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 385)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "シールド圧（MPa）"
        '
        'nudLeftStroke
        '
        Me.nudLeftStroke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudLeftStroke.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudLeftStroke.Location = New System.Drawing.Point(261, 408)
        Me.nudLeftStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLeftStroke.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudLeftStroke.Name = "nudLeftStroke"
        Me.nudLeftStroke.Size = New System.Drawing.Size(83, 27)
        Me.nudLeftStroke.TabIndex = 4
        Me.nudLeftStroke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudRightStroke
        '
        Me.nudRightStroke.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudRightStroke.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRightStroke.Location = New System.Drawing.Point(552, 408)
        Me.nudRightStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.nudRightStroke.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudRightStroke.Name = "nudRightStroke"
        Me.nudRightStroke.Size = New System.Drawing.Size(83, 27)
        Me.nudRightStroke.TabIndex = 5
        Me.nudRightStroke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 385)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "左ストローク(mm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(530, 385)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "右ストローク(mm)"
        '
        'btnJackAllSelect
        '
        Me.btnJackAllSelect.Location = New System.Drawing.Point(11, 12)
        Me.btnJackAllSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJackAllSelect.Name = "btnJackAllSelect"
        Me.btnJackAllSelect.Size = New System.Drawing.Size(125, 39)
        Me.btnJackAllSelect.TabIndex = 8
        Me.btnJackAllSelect.Text = "ジャッキ全選択"
        Me.btnJackAllSelect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(530, 452)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "右ｽﾋﾟｰﾄﾞ(mm/min)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 452)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "左ｽﾋﾟｰﾄﾞ(mm/min)"
        '
        'nudRightSpeed
        '
        Me.nudRightSpeed.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudRightSpeed.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRightSpeed.Location = New System.Drawing.Point(552, 475)
        Me.nudRightSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.nudRightSpeed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudRightSpeed.Name = "nudRightSpeed"
        Me.nudRightSpeed.Size = New System.Drawing.Size(83, 27)
        Me.nudRightSpeed.TabIndex = 10
        Me.nudRightSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLeftSpeed
        '
        Me.nudLeftSpeed.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudLeftSpeed.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudLeftSpeed.Location = New System.Drawing.Point(261, 475)
        Me.nudLeftSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLeftSpeed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudLeftSpeed.Name = "nudLeftSpeed"
        Me.nudLeftSpeed.Size = New System.Drawing.Size(83, 27)
        Me.nudLeftSpeed.TabIndex = 9
        Me.nudLeftSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tmrRightJack
        '
        '
        'tmrLeftJack
        '
        '
        'tmrAuto
        '
        Me.tmrAuto.Enabled = True
        Me.tmrAuto.Interval = 2000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 531)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ジャイロ（deg)"
        '
        'nudGyairo
        '
        Me.nudGyairo.DecimalPlaces = 2
        Me.nudGyairo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudGyairo.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudGyairo.Location = New System.Drawing.Point(300, 554)
        Me.nudGyairo.Margin = New System.Windows.Forms.Padding(2)
        Me.nudGyairo.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudGyairo.Name = "nudGyairo"
        Me.nudGyairo.Size = New System.Drawing.Size(110, 27)
        Me.nudGyairo.TabIndex = 13
        Me.nudGyairo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label22.Location = New System.Drawing.Point(450, 531)
        Me.label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(185, 20)
        Me.label22.TabIndex = 16
        Me.label22.Text = "ジャイロピッチング（deg)"
        '
        'nudPitching
        '
        Me.nudPitching.DecimalPlaces = 2
        Me.nudPitching.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudPitching.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudPitching.Location = New System.Drawing.Point(483, 554)
        Me.nudPitching.Margin = New System.Windows.Forms.Padding(2)
        Me.nudPitching.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPitching.Name = "nudPitching"
        Me.nudPitching.Size = New System.Drawing.Size(110, 27)
        Me.nudPitching.TabIndex = 15
        Me.nudPitching.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvLosZero
        '
        Me.DgvLosZero.AllowUserToAddRows = False
        Me.DgvLosZero.AllowUserToDeleteRows = False
        Me.DgvLosZero.AllowUserToResizeColumns = False
        Me.DgvLosZero.AllowUserToResizeRows = False
        Me.DgvLosZero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLosZero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JackNo, Me.ExcavOrSegment, Me.PullBakOn, Me.PullBackAns, Me.ClosetOn, Me.ClosetAns, Me.PullBackCommand, Me.ClosetCommand, Me.AddClosetCommand})
        Me.DgvLosZero.Location = New System.Drawing.Point(1123, 12)
        Me.DgvLosZero.MultiSelect = False
        Me.DgvLosZero.Name = "DgvLosZero"
        Me.DgvLosZero.ReadOnly = True
        Me.DgvLosZero.RowHeadersVisible = False
        Me.DgvLosZero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvLosZero.RowTemplate.Height = 24
        Me.DgvLosZero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvLosZero.Size = New System.Drawing.Size(432, 845)
        Me.DgvLosZero.TabIndex = 17
        '
        'nudLosZeroStatusMachin
        '
        Me.nudLosZeroStatusMachin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudLosZeroStatusMachin.Location = New System.Drawing.Point(993, 63)
        Me.nudLosZeroStatusMachin.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLosZeroStatusMachin.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLosZeroStatusMachin.Name = "nudLosZeroStatusMachin"
        Me.nudLosZeroStatusMachin.Size = New System.Drawing.Size(83, 27)
        Me.nudLosZeroStatusMachin.TabIndex = 18
        Me.nudLosZeroStatusMachin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(940, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 40)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "同時施工ステータス" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "マシンより"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(940, 304)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 40)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "同時施工ステータス" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FLEXより"
        '
        'nudLosZeroStsFlex
        '
        Me.nudLosZeroStsFlex.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudLosZeroStsFlex.Location = New System.Drawing.Point(993, 355)
        Me.nudLosZeroStsFlex.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLosZeroStsFlex.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLosZeroStsFlex.Name = "nudLosZeroStsFlex"
        Me.nudLosZeroStsFlex.Size = New System.Drawing.Size(83, 27)
        Me.nudLosZeroStsFlex.TabIndex = 20
        Me.nudLosZeroStsFlex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkLosZeroEnable
        '
        Me.chkLosZeroEnable.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkLosZeroEnable.Location = New System.Drawing.Point(454, 334)
        Me.chkLosZeroEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLosZeroEnable.Name = "chkLosZeroEnable"
        Me.chkLosZeroEnable.Size = New System.Drawing.Size(220, 24)
        Me.chkLosZeroEnable.TabIndex = 23
        Me.chkLosZeroEnable.Text = "同時施工可"
        Me.chkLosZeroEnable.UseVisualStyleBackColor = True
        '
        'chkLosZeroMode
        '
        Me.chkLosZeroMode.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkLosZeroMode.Location = New System.Drawing.Point(454, 304)
        Me.chkLosZeroMode.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLosZeroMode.Name = "chkLosZeroMode"
        Me.chkLosZeroMode.Size = New System.Drawing.Size(220, 24)
        Me.chkLosZeroMode.TabIndex = 22
        Me.chkLosZeroMode.Text = "同時施工／通常モード"
        Me.chkLosZeroMode.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(903, 105)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 136)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "1" & Global.Microsoft.VisualBasic.ChrW(9) & "減圧開始指令（1ピースのみ）" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "引き戻し開始" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "引き戻し完了" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "押し込み中①" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(9) & "組立完了" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(9) & "押し込み中②" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(9) & "押し付け①②完" &
    "了" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(9) & "Kセグメント組立完了" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(913, 398)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 68)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "1" & Global.Microsoft.VisualBasic.ChrW(9) & "減圧開始" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "減圧完了" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "組立完了確認" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "押し付け完了確認" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'JackNo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.JackNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.JackNo.Frozen = True
        Me.JackNo.HeaderText = "No"
        Me.JackNo.Name = "JackNo"
        Me.JackNo.ReadOnly = True
        Me.JackNo.Width = 30
        '
        'ExcavOrSegment
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ExcavOrSegment.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExcavOrSegment.Frozen = True
        Me.ExcavOrSegment.HeaderText = "推進／組立"
        Me.ExcavOrSegment.Name = "ExcavOrSegment"
        Me.ExcavOrSegment.ReadOnly = True
        Me.ExcavOrSegment.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExcavOrSegment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExcavOrSegment.Width = 50
        '
        'PullBakOn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PullBakOn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PullBakOn.Frozen = True
        Me.PullBakOn.HeaderText = "引き戻し中"
        Me.PullBakOn.Name = "PullBakOn"
        Me.PullBakOn.ReadOnly = True
        Me.PullBakOn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PullBakOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PullBakOn.Width = 50
        '
        'PullBackAns
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PullBackAns.DefaultCellStyle = DataGridViewCellStyle4
        Me.PullBackAns.Frozen = True
        Me.PullBackAns.HeaderText = "引き戻しAns"
        Me.PullBackAns.Name = "PullBackAns"
        Me.PullBackAns.ReadOnly = True
        Me.PullBackAns.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PullBackAns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PullBackAns.Width = 50
        '
        'ClosetOn
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClosetOn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClosetOn.Frozen = True
        Me.ClosetOn.HeaderText = "押込み中"
        Me.ClosetOn.Name = "ClosetOn"
        Me.ClosetOn.ReadOnly = True
        Me.ClosetOn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClosetOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ClosetOn.Width = 50
        '
        'ClosetAns
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClosetAns.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClosetAns.Frozen = True
        Me.ClosetAns.HeaderText = "押込みAns"
        Me.ClosetAns.Name = "ClosetAns"
        Me.ClosetAns.ReadOnly = True
        Me.ClosetAns.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClosetAns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ClosetAns.Width = 50
        '
        'PullBackCommand
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PullBackCommand.DefaultCellStyle = DataGridViewCellStyle7
        Me.PullBackCommand.Frozen = True
        Me.PullBackCommand.HeaderText = "引戻し指令"
        Me.PullBackCommand.Name = "PullBackCommand"
        Me.PullBackCommand.ReadOnly = True
        Me.PullBackCommand.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PullBackCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PullBackCommand.Width = 50
        '
        'ClosetCommand
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClosetCommand.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClosetCommand.Frozen = True
        Me.ClosetCommand.HeaderText = "押込み指令"
        Me.ClosetCommand.Name = "ClosetCommand"
        Me.ClosetCommand.ReadOnly = True
        Me.ClosetCommand.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClosetCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ClosetCommand.Width = 50
        '
        'AddClosetCommand
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AddClosetCommand.DefaultCellStyle = DataGridViewCellStyle9
        Me.AddClosetCommand.Frozen = True
        Me.AddClosetCommand.HeaderText = "追加押込み指令"
        Me.AddClosetCommand.Name = "AddClosetCommand"
        Me.AddClosetCommand.ReadOnly = True
        Me.AddClosetCommand.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AddClosetCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AddClosetCommand.Width = 50
        '
        'frmSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1593, 869)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkLosZeroEnable)
        Me.Controls.Add(Me.chkLosZeroMode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.nudLosZeroStsFlex)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudLosZeroStatusMachin)
        Me.Controls.Add(Me.DgvLosZero)
        Me.Controls.Add(Me.label22)
        Me.Controls.Add(Me.nudPitching)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudGyairo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudRightSpeed)
        Me.Controls.Add(Me.nudLeftSpeed)
        Me.Controls.Add(Me.btnJackAllSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudRightStroke)
        Me.Controls.Add(Me.nudLeftStroke)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudSoucePressure)
        Me.Controls.Add(Me.chkFlexOn)
        Me.Controls.Add(Me.chkExcavOn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSim"
        Me.Text = "シュミレーション"
        CType(Me.nudSoucePressure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLeftStroke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRightStroke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRightSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLeftSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGyairo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPitching, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvLosZero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLosZeroStatusMachin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLosZeroStsFlex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrPlcWR As Timer
    Friend WithEvents chkExcavOn As CheckBox
    Friend WithEvents chkFlexOn As CheckBox
    Friend WithEvents nudSoucePressure As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudLeftStroke As NumericUpDown
    Friend WithEvents nudRightStroke As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnJackAllSelect As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudRightSpeed As NumericUpDown
    Friend WithEvents nudLeftSpeed As NumericUpDown
    Friend WithEvents tmrRightJack As Timer
    Friend WithEvents tmrLeftJack As Timer
    Friend WithEvents tmrAuto As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents nudGyairo As NumericUpDown
    Friend WithEvents label22 As Label
    Friend WithEvents nudPitching As NumericUpDown
    Friend WithEvents DgvLosZero As DataGridView
    Friend WithEvents nudLosZeroStatusMachin As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudLosZeroStsFlex As NumericUpDown
    Friend WithEvents chkLosZeroEnable As CheckBox
    Friend WithEvents chkLosZeroMode As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents JackNo As DataGridViewTextBoxColumn
    Friend WithEvents ExcavOrSegment As DataGridViewTextBoxColumn
    Friend WithEvents PullBakOn As DataGridViewTextBoxColumn
    Friend WithEvents PullBackAns As DataGridViewTextBoxColumn
    Friend WithEvents ClosetOn As DataGridViewTextBoxColumn
    Friend WithEvents ClosetAns As DataGridViewTextBoxColumn
    Friend WithEvents PullBackCommand As DataGridViewTextBoxColumn
    Friend WithEvents ClosetCommand As DataGridViewTextBoxColumn
    Friend WithEvents AddClosetCommand As DataGridViewTextBoxColumn
End Class
