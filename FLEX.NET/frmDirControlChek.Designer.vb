<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDirControlChek
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblPointX = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblPointY = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTheater = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRealThrustPower = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRealJackPress = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGetNowData = New System.Windows.Forms.Button()
        Me.lblMomentY = New System.Windows.Forms.Label()
        Me.label999 = New System.Windows.Forms.Label()
        Me.lblMomentX = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnMomentOptimize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLowOptSv = New System.Windows.Forms.TextBox()
        Me.txtOpposeGpSv = New System.Windows.Forms.TextBox()
        Me.lblOptMomentY = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblOptMomentX = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblOptTheater = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblOptR = New System.Windows.Forms.Label()
        Me.lblOptPointY = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblOptPointX = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblOptJackPress = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRst = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLpMax = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMomnetDev = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnClose.Location = New System.Drawing.Point(1350, 627)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1350, 570)
        '
        'lblPointX
        '
        Me.lblPointX.BackColor = System.Drawing.Color.White
        Me.lblPointX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPointX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointX.Location = New System.Drawing.Point(241, 7)
        Me.lblPointX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPointX.Name = "lblPointX"
        Me.lblPointX.Size = New System.Drawing.Size(75, 19)
        Me.lblPointX.TabIndex = 19
        Me.lblPointX.Text = "-32353.09"
        Me.lblPointX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.SystemColors.Control
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblX.Location = New System.Drawing.Point(177, 7)
        Me.lblX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(64, 19)
        Me.lblX.TabIndex = 18
        Me.lblX.Text = "X"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPointY
        '
        Me.lblPointY.BackColor = System.Drawing.Color.White
        Me.lblPointY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPointY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPointY.Location = New System.Drawing.Point(241, 26)
        Me.lblPointY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPointY.Name = "lblPointY"
        Me.lblPointY.Size = New System.Drawing.Size(75, 19)
        Me.lblPointY.TabIndex = 21
        Me.lblPointY.Text = "-32353.09"
        Me.lblPointY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Y"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblR
        '
        Me.lblR.BackColor = System.Drawing.Color.White
        Me.lblR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblR.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblR.Location = New System.Drawing.Point(241, 45)
        Me.lblR.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(75, 19)
        Me.lblR.TabIndex = 23
        Me.lblR.Text = "-32353.09"
        Me.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "推力"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTheater
        '
        Me.lblTheater.BackColor = System.Drawing.Color.White
        Me.lblTheater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTheater.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTheater.Location = New System.Drawing.Point(241, 64)
        Me.lblTheater.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTheater.Name = "lblTheater"
        Me.lblTheater.Size = New System.Drawing.Size(75, 19)
        Me.lblTheater.TabIndex = 25
        Me.lblTheater.Text = "-32353.09"
        Me.lblTheater.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSalmon
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "RC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRealThrustPower
        '
        Me.lblRealThrustPower.BackColor = System.Drawing.Color.White
        Me.lblRealThrustPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealThrustPower.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblRealThrustPower.Location = New System.Drawing.Point(241, 83)
        Me.lblRealThrustPower.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRealThrustPower.Name = "lblRealThrustPower"
        Me.lblRealThrustPower.Size = New System.Drawing.Size(75, 19)
        Me.lblRealThrustPower.TabIndex = 27
        Me.lblRealThrustPower.Text = "-32353.09"
        Me.lblRealThrustPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSalmon
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(177, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "θ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRealJackPress
        '
        Me.lblRealJackPress.BackColor = System.Drawing.Color.White
        Me.lblRealJackPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRealJackPress.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblRealJackPress.Location = New System.Drawing.Point(241, 102)
        Me.lblRealJackPress.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRealJackPress.Name = "lblRealJackPress"
        Me.lblRealJackPress.Size = New System.Drawing.Size(75, 19)
        Me.lblRealJackPress.TabIndex = 29
        Me.lblRealJackPress.Text = "-32353.09"
        Me.lblRealJackPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(177, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "元圧"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGetNowData
        '
        Me.btnGetNowData.BackColor = System.Drawing.Color.DarkGray
        Me.btnGetNowData.Location = New System.Drawing.Point(65, 7)
        Me.btnGetNowData.Name = "btnGetNowData"
        Me.btnGetNowData.Size = New System.Drawing.Size(108, 38)
        Me.btnGetNowData.TabIndex = 30
        Me.btnGetNowData.Text = "現在値取得"
        Me.btnGetNowData.UseVisualStyleBackColor = False
        '
        'lblMomentY
        '
        Me.lblMomentY.BackColor = System.Drawing.Color.White
        Me.lblMomentY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMomentY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMomentY.Location = New System.Drawing.Point(389, 26)
        Me.lblMomentY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMomentY.Name = "lblMomentY"
        Me.lblMomentY.Size = New System.Drawing.Size(75, 19)
        Me.lblMomentY.TabIndex = 34
        Me.lblMomentY.Text = "-32353.09"
        Me.lblMomentY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label999
        '
        Me.label999.BackColor = System.Drawing.SystemColors.Control
        Me.label999.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label999.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label999.Location = New System.Drawing.Point(325, 26)
        Me.label999.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.label999.Name = "label999"
        Me.label999.Size = New System.Drawing.Size(64, 19)
        Me.label999.TabIndex = 33
        Me.label999.Text = "MomentY"
        Me.label999.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMomentX
        '
        Me.lblMomentX.BackColor = System.Drawing.Color.White
        Me.lblMomentX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMomentX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblMomentX.Location = New System.Drawing.Point(389, 7)
        Me.lblMomentX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMomentX.Name = "lblMomentX"
        Me.lblMomentX.Size = New System.Drawing.Size(75, 19)
        Me.lblMomentX.TabIndex = 32
        Me.lblMomentX.Text = "-32353.09"
        Me.lblMomentX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 7)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "MomentX"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.ColumnHeadersHeight = 46
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Location = New System.Drawing.Point(65, 136)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.RowTemplate.Height = 18
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.ShowCellErrors = False
        Me.dgv.Size = New System.Drawing.Size(1267, 486)
        Me.dgv.TabIndex = 35
        '
        'btnMomentOptimize
        '
        Me.btnMomentOptimize.BackColor = System.Drawing.Color.DarkGray
        Me.btnMomentOptimize.Location = New System.Drawing.Point(576, 7)
        Me.btnMomentOptimize.Name = "btnMomentOptimize"
        Me.btnMomentOptimize.Size = New System.Drawing.Size(108, 38)
        Me.btnMomentOptimize.TabIndex = 36
        Me.btnMomentOptimize.Text = "モーメント最適化"
        Me.btnMomentOptimize.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 52)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "0:非稼働（引き、非選択、セグメントモード)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1:通常FLEXジャッキ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2:低圧推進" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3:対抗ジャッキ"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "対抗G圧力(Mpa)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "低圧推進圧力(Mpa)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLowOptSv
        '
        Me.txtLowOptSv.Location = New System.Drawing.Point(576, 82)
        Me.txtLowOptSv.Name = "txtLowOptSv"
        Me.txtLowOptSv.Size = New System.Drawing.Size(47, 19)
        Me.txtLowOptSv.TabIndex = 40
        Me.txtLowOptSv.Text = "4.5"
        Me.txtLowOptSv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpposeGpSv
        '
        Me.txtOpposeGpSv.Location = New System.Drawing.Point(576, 102)
        Me.txtOpposeGpSv.Name = "txtOpposeGpSv"
        Me.txtOpposeGpSv.Size = New System.Drawing.Size(47, 19)
        Me.txtOpposeGpSv.TabIndex = 41
        Me.txtOpposeGpSv.Text = "0.0"
        Me.txtOpposeGpSv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOptMomentY
        '
        Me.lblOptMomentY.BackColor = System.Drawing.Color.White
        Me.lblOptMomentY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptMomentY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptMomentY.Location = New System.Drawing.Point(918, 26)
        Me.lblOptMomentY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptMomentY.Name = "lblOptMomentY"
        Me.lblOptMomentY.Size = New System.Drawing.Size(75, 19)
        Me.lblOptMomentY.TabIndex = 53
        Me.lblOptMomentY.Text = "0"
        Me.lblOptMomentY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(854, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 19)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "MomentY"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptMomentX
        '
        Me.lblOptMomentX.BackColor = System.Drawing.Color.White
        Me.lblOptMomentX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptMomentX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptMomentX.Location = New System.Drawing.Point(918, 7)
        Me.lblOptMomentX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptMomentX.Name = "lblOptMomentX"
        Me.lblOptMomentX.Size = New System.Drawing.Size(75, 19)
        Me.lblOptMomentX.TabIndex = 51
        Me.lblOptMomentX.Text = "0"
        Me.lblOptMomentX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(854, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "MomentX"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSalmon
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(706, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "θ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptTheater
        '
        Me.lblOptTheater.BackColor = System.Drawing.Color.White
        Me.lblOptTheater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptTheater.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptTheater.Location = New System.Drawing.Point(770, 64)
        Me.lblOptTheater.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptTheater.Name = "lblOptTheater"
        Me.lblOptTheater.Size = New System.Drawing.Size(75, 19)
        Me.lblOptTheater.TabIndex = 48
        Me.lblOptTheater.Text = "0"
        Me.lblOptTheater.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSalmon
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.Location = New System.Drawing.Point(706, 45)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 19)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "RC"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptR
        '
        Me.lblOptR.BackColor = System.Drawing.Color.White
        Me.lblOptR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptR.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptR.Location = New System.Drawing.Point(770, 45)
        Me.lblOptR.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptR.Name = "lblOptR"
        Me.lblOptR.Size = New System.Drawing.Size(75, 19)
        Me.lblOptR.TabIndex = 46
        Me.lblOptR.Text = "0"
        Me.lblOptR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOptPointY
        '
        Me.lblOptPointY.BackColor = System.Drawing.Color.White
        Me.lblOptPointY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptPointY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptPointY.Location = New System.Drawing.Point(770, 26)
        Me.lblOptPointY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptPointY.Name = "lblOptPointY"
        Me.lblOptPointY.Size = New System.Drawing.Size(75, 19)
        Me.lblOptPointY.TabIndex = 45
        Me.lblOptPointY.Text = "0"
        Me.lblOptPointY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(706, 26)
        Me.Label19.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 19)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Y"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptPointX
        '
        Me.lblOptPointX.BackColor = System.Drawing.Color.White
        Me.lblOptPointX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptPointX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptPointX.Location = New System.Drawing.Point(770, 7)
        Me.lblOptPointX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptPointX.Name = "lblOptPointX"
        Me.lblOptPointX.Size = New System.Drawing.Size(75, 19)
        Me.lblOptPointX.TabIndex = 43
        Me.lblOptPointX.Text = "0"
        Me.lblOptPointX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.Location = New System.Drawing.Point(706, 7)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 19)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "X"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptJackPress
        '
        Me.lblOptJackPress.BackColor = System.Drawing.Color.White
        Me.lblOptJackPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptJackPress.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblOptJackPress.Location = New System.Drawing.Point(770, 101)
        Me.lblOptJackPress.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOptJackPress.Name = "lblOptJackPress"
        Me.lblOptJackPress.Size = New System.Drawing.Size(75, 19)
        Me.lblOptJackPress.TabIndex = 55
        Me.lblOptJackPress.Text = "-32353.09"
        Me.lblOptJackPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(706, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "元圧"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRst
        '
        Me.txtRst.Location = New System.Drawing.Point(1124, 8)
        Me.txtRst.Name = "txtRst"
        Me.txtRst.Size = New System.Drawing.Size(47, 19)
        Me.txtRst.TabIndex = 57
        Me.txtRst.Text = "0.05"
        Me.txtRst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(1031, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 19)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "力点変化"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLpMax
        '
        Me.txtLpMax.Location = New System.Drawing.Point(1124, 29)
        Me.txtLpMax.Name = "txtLpMax"
        Me.txtLpMax.Size = New System.Drawing.Size(47, 19)
        Me.txtLpMax.TabIndex = 59
        Me.txtLpMax.Text = "100"
        Me.txtLpMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(1031, 30)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 19)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "繰返回数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMomnetDev
        '
        Me.txtMomnetDev.Location = New System.Drawing.Point(1124, 50)
        Me.txtMomnetDev.Name = "txtMomnetDev"
        Me.txtMomnetDev.Size = New System.Drawing.Size(47, 19)
        Me.txtMomnetDev.TabIndex = 61
        Me.txtMomnetDev.Text = "0.5"
        Me.txtMomnetDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(1031, 51)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 19)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "ﾓｰﾒﾝﾄ許容偏差"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDirControlChek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1463, 673)
        Me.Controls.Add(Me.txtMomnetDev)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLpMax)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRst)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblOptJackPress)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblOptMomentY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblOptMomentX)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblOptTheater)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblOptR)
        Me.Controls.Add(Me.lblOptPointY)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblOptPointX)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtOpposeGpSv)
        Me.Controls.Add(Me.txtLowOptSv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMomentOptimize)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblMomentY)
        Me.Controls.Add(Me.label999)
        Me.Controls.Add(Me.lblMomentX)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnGetNowData)
        Me.Controls.Add(Me.lblRealJackPress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblRealThrustPower)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTheater)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPointY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPointX)
        Me.Controls.Add(Me.lblX)
        Me.Name = "frmDirControlChek"
        Me.Text = "姿勢制御チェック"
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblX, 0)
        Me.Controls.SetChildIndex(Me.lblPointX, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblPointY, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblR, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.lblTheater, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.lblRealThrustPower, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.lblRealJackPress, 0)
        Me.Controls.SetChildIndex(Me.btnGetNowData, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.lblMomentX, 0)
        Me.Controls.SetChildIndex(Me.label999, 0)
        Me.Controls.SetChildIndex(Me.lblMomentY, 0)
        Me.Controls.SetChildIndex(Me.dgv, 0)
        Me.Controls.SetChildIndex(Me.btnMomentOptimize, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtLowOptSv, 0)
        Me.Controls.SetChildIndex(Me.txtOpposeGpSv, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.lblOptPointX, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.lblOptPointY, 0)
        Me.Controls.SetChildIndex(Me.lblOptR, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.lblOptTheater, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.lblOptMomentX, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.lblOptMomentY, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.lblOptJackPress, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtRst, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtLpMax, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txtMomnetDev, 0)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPointX As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblPointY As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTheater As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRealThrustPower As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRealJackPress As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGetNowData As Button
    Friend WithEvents lblMomentY As Label
    Friend WithEvents label999 As Label
    Friend WithEvents lblMomentX As Label
    Friend WithEvents Label7 As Label
    Private WithEvents dgv As DataGridView
    Friend WithEvents btnMomentOptimize As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLowOptSv As TextBox
    Friend WithEvents txtOpposeGpSv As TextBox
    Friend WithEvents lblOptMomentY As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblOptMomentX As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblOptTheater As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblOptR As Label
    Friend WithEvents lblOptPointY As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblOptPointX As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblOptJackPress As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRst As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLpMax As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMomnetDev As TextBox
    Friend WithEvents Label17 As Label
End Class
