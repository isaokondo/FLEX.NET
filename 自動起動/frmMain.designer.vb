<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.Bt_Sendmes = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Tm_Protocol = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bt_Endmes = New System.Windows.Forms.Button()
        Me.Bt_Fine = New System.Windows.Forms.Button()
        Me.Lb_vd = New System.Windows.Forms.Label()
        Me.Tb_vad = New System.Windows.Forms.TextBox()
        Me.Tb_vam = New System.Windows.Forms.TextBox()
        Me.Tb_vas = New System.Windows.Forms.TextBox()
        Me.Tb_has = New System.Windows.Forms.TextBox()
        Me.Tb_ham = New System.Windows.Forms.TextBox()
        Me.Tb_had = New System.Windows.Forms.TextBox()
        Me.Lb_hd = New System.Windows.Forms.Label()
        Me.Tb_ts = New System.Windows.Forms.TextBox()
        Me.Tb_tm = New System.Windows.Forms.TextBox()
        Me.Lb_til = New System.Windows.Forms.Label()
        Me.Tb_batt = New System.Windows.Forms.TextBox()
        Me.Lb_batt = New System.Windows.Forms.Label()
        Me.Lb_edm = New System.Windows.Forms.Label()
        Me.Tb_edm = New System.Windows.Forms.TextBox()
        Me.Tb_sea = New System.Windows.Forms.TextBox()
        Me.Tb_fac = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_sea = New System.Windows.Forms.Label()
        Me.Lb_fac = New System.Windows.Forms.Label()
        Me.Lb_th = New System.Windows.Forms.Label()
        Me.Tb_th = New System.Windows.Forms.TextBox()
        Me.Lb_sl = New System.Windows.Forms.Label()
        Me.Tb_sl = New System.Windows.Forms.TextBox()
        Me.Lb_hl = New System.Windows.Forms.Label()
        Me.Tb_hl = New System.Windows.Forms.TextBox()
        Me.Tb_vl = New System.Windows.Forms.TextBox()
        Me.Lb_vl = New System.Windows.Forms.Label()
        Me.Lb_prism = New System.Windows.Forms.Label()
        Me.Tb_prism = New System.Windows.Forms.TextBox()
        Me.Lb_weath = New System.Windows.Forms.Label()
        Me.Lb_light = New System.Windows.Forms.Label()
        Me.Tb_weath = New System.Windows.Forms.TextBox()
        Me.Tb_light = New System.Windows.Forms.TextBox()
        Me.Tm_Interval = New System.Windows.Forms.Timer(Me.components)
        Me.Bt_Crs1 = New System.Windows.Forms.Button()
        Me.Tb_interval = New System.Windows.Forms.TextBox()
        Me.Lb_interval = New System.Windows.Forms.Label()
        Me.Bt_serch = New System.Windows.Forms.Button()
        Me.Tb_count = New System.Windows.Forms.TextBox()
        Me.Bt_Weit = New System.Windows.Forms.Button()
        Me.Bt_stop = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_hos = New System.Windows.Forms.TextBox()
        Me.Tb_hom = New System.Windows.Forms.TextBox()
        Me.Tb_hod = New System.Windows.Forms.TextBox()
        Me.Lb_ho = New System.Windows.Forms.Label()
        Me.Tb_vos = New System.Windows.Forms.TextBox()
        Me.Tb_vom = New System.Windows.Forms.TextBox()
        Me.Tb_vod = New System.Windows.Forms.TextBox()
        Me.Lb_vo = New System.Windows.Forms.Label()
        Me.Bt_circleab = New System.Windows.Forms.Button()
        Me.Bt_circlerl = New System.Windows.Forms.Button()
        Me.Tb_Shs = New System.Windows.Forms.TextBox()
        Me.Tb_Shm = New System.Windows.Forms.TextBox()
        Me.Tb_Shd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bt_SetAng = New System.Windows.Forms.Button()
        Me.Bt_Tron = New System.Windows.Forms.Button()
        Me.Bt_Troff = New System.Windows.Forms.Button()
        Me.Bt_Lzoff = New System.Windows.Forms.Button()
        Me.Bt_Lzon = New System.Windows.Forms.Button()
        Me.Tb_rtcnt = New System.Windows.Forms.TextBox()
        Me.Tm_Search = New System.Windows.Forms.Timer(Me.components)
        Me.Lb_rtry = New System.Windows.Forms.Label()
        Me.Tb_rtry = New System.Windows.Forms.TextBox()
        Me.Cb_safe = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_wait = New System.Windows.Forms.TextBox()
        Me.Tb_waititv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_RinNo = New System.Windows.Forms.Label()
        Me.lb_RealSt = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lb_frDir = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_rrDir = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lb_rrPitch = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lb_frPitch = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lb_rrRolling = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lb_NkRDSt = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lb_NkRUSt = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lb_NkLDSt = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lb_NkLUSt = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lb_NkUD = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lb_NkLR = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lb_ExecSts = New System.Windows.Forms.Label()
        Me.Tm_PlcCom = New System.Windows.Forms.Timer(Me.components)
        Me.lb_ResltR0C0 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C1 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C2 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C2 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C1 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C0 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C2 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C1 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C0 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C2 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C1 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C0 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C2 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C1 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C0 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C7 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C6 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C4 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C7 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C6 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C4 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C7 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C6 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C4 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C7 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C6 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C4 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C7 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C6 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C4 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C8 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C8 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C8 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C8 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C8 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C9 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C9 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C9 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C9 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C9 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C11 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C11 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C11 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C11 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C11 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C20 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C20 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C20 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C20 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C20 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C35 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C35 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C35 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C35 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C35 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.lb_ResltR6C33 = New System.Windows.Forms.Label()
        Me.lb_ResltR5C33 = New System.Windows.Forms.Label()
        Me.lb_ResltR4C33 = New System.Windows.Forms.Label()
        Me.lb_ResltR3C33 = New System.Windows.Forms.Label()
        Me.lb_ResltR0C33 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.lb_TgmZ = New System.Windows.Forms.Label()
        Me.lb_TgmY = New System.Windows.Forms.Label()
        Me.lb_TgmX = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lb_PlcComDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(201, 43)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(75, 23)
        Me.EraseButton.TabIndex = 0
        Me.EraseButton.Text = "消去"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'Bt_Sendmes
        '
        Me.Bt_Sendmes.Location = New System.Drawing.Point(201, 11)
        Me.Bt_Sendmes.Name = "Bt_Sendmes"
        Me.Bt_Sendmes.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Sendmes.TabIndex = 2
        Me.Bt_Sendmes.Text = "送信"
        Me.Bt_Sendmes.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 5000
        Me.SerialPort1.WriteTimeout = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(33, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "受信"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(35, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(241, 23)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(35, 189)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(241, 26)
        Me.TextBox2.TabIndex = 7
        '
        'Tm_Protocol
        '
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(35, 221)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(241, 28)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(35, 255)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(241, 43)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(35, 302)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(241, 102)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(35, 101)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(241, 58)
        Me.TextBox6.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(33, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "送信"
        '
        'Bt_Endmes
        '
        Me.Bt_Endmes.Location = New System.Drawing.Point(475, 213)
        Me.Bt_Endmes.Name = "Bt_Endmes"
        Me.Bt_Endmes.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Endmes.TabIndex = 13
        Me.Bt_Endmes.Text = "停止"
        Me.Bt_Endmes.UseVisualStyleBackColor = True
        '
        'Bt_Fine
        '
        Me.Bt_Fine.Location = New System.Drawing.Point(311, 213)
        Me.Bt_Fine.Name = "Bt_Fine"
        Me.Bt_Fine.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Fine.TabIndex = 14
        Me.Bt_Fine.Text = "ﾌｧｲﾝ連続"
        Me.Bt_Fine.UseVisualStyleBackColor = True
        '
        'Lb_vd
        '
        Me.Lb_vd.AutoSize = True
        Me.Lb_vd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_vd.Location = New System.Drawing.Point(311, 21)
        Me.Lb_vd.Name = "Lb_vd"
        Me.Lb_vd.Size = New System.Drawing.Size(43, 14)
        Me.Lb_vd.TabIndex = 15
        Me.Lb_vd.Text = "鉛直角"
        '
        'Tb_vad
        '
        Me.Tb_vad.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vad.Location = New System.Drawing.Point(381, 18)
        Me.Tb_vad.Name = "Tb_vad"
        Me.Tb_vad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vad.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vad.TabIndex = 16
        Me.Tb_vad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_vam
        '
        Me.Tb_vam.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vam.Location = New System.Drawing.Point(426, 18)
        Me.Tb_vam.Name = "Tb_vam"
        Me.Tb_vam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vam.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vam.TabIndex = 17
        Me.Tb_vam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_vas
        '
        Me.Tb_vas.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vas.Location = New System.Drawing.Point(471, 18)
        Me.Tb_vas.Name = "Tb_vas"
        Me.Tb_vas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vas.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vas.TabIndex = 18
        Me.Tb_vas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_has
        '
        Me.Tb_has.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_has.Location = New System.Drawing.Point(471, 42)
        Me.Tb_has.Name = "Tb_has"
        Me.Tb_has.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_has.Size = New System.Drawing.Size(40, 19)
        Me.Tb_has.TabIndex = 22
        Me.Tb_has.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_ham
        '
        Me.Tb_ham.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_ham.Location = New System.Drawing.Point(426, 42)
        Me.Tb_ham.Name = "Tb_ham"
        Me.Tb_ham.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_ham.Size = New System.Drawing.Size(40, 19)
        Me.Tb_ham.TabIndex = 21
        Me.Tb_ham.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_had
        '
        Me.Tb_had.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_had.Location = New System.Drawing.Point(381, 42)
        Me.Tb_had.Name = "Tb_had"
        Me.Tb_had.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_had.Size = New System.Drawing.Size(40, 19)
        Me.Tb_had.TabIndex = 20
        Me.Tb_had.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_hd
        '
        Me.Lb_hd.AutoSize = True
        Me.Lb_hd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_hd.Location = New System.Drawing.Point(311, 45)
        Me.Lb_hd.Name = "Lb_hd"
        Me.Lb_hd.Size = New System.Drawing.Size(43, 14)
        Me.Lb_hd.TabIndex = 19
        Me.Lb_hd.Text = "水平角"
        '
        'Tb_ts
        '
        Me.Tb_ts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_ts.Location = New System.Drawing.Point(471, 67)
        Me.Tb_ts.Name = "Tb_ts"
        Me.Tb_ts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_ts.Size = New System.Drawing.Size(40, 19)
        Me.Tb_ts.TabIndex = 26
        Me.Tb_ts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_tm
        '
        Me.Tb_tm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_tm.Location = New System.Drawing.Point(426, 67)
        Me.Tb_tm.Name = "Tb_tm"
        Me.Tb_tm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_tm.Size = New System.Drawing.Size(40, 19)
        Me.Tb_tm.TabIndex = 25
        Me.Tb_tm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_til
        '
        Me.Lb_til.AutoSize = True
        Me.Lb_til.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_til.Location = New System.Drawing.Point(312, 70)
        Me.Lb_til.Name = "Lb_til"
        Me.Lb_til.Size = New System.Drawing.Size(58, 14)
        Me.Lb_til.TabIndex = 23
        Me.Lb_til.Text = "チルト補正"
        '
        'Tb_batt
        '
        Me.Tb_batt.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_batt.Location = New System.Drawing.Point(606, 17)
        Me.Tb_batt.Name = "Tb_batt"
        Me.Tb_batt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_batt.Size = New System.Drawing.Size(40, 19)
        Me.Tb_batt.TabIndex = 27
        Me.Tb_batt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_batt
        '
        Me.Lb_batt.AutoSize = True
        Me.Lb_batt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_batt.Location = New System.Drawing.Point(534, 20)
        Me.Lb_batt.Name = "Lb_batt"
        Me.Lb_batt.Size = New System.Drawing.Size(43, 14)
        Me.Lb_batt.TabIndex = 28
        Me.Lb_batt.Text = "battery"
        '
        'Lb_edm
        '
        Me.Lb_edm.AutoSize = True
        Me.Lb_edm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_edm.Location = New System.Drawing.Point(534, 45)
        Me.Lb_edm.Name = "Lb_edm"
        Me.Lb_edm.Size = New System.Drawing.Size(55, 14)
        Me.Lb_edm.TabIndex = 29
        Me.Lb_edm.Text = "EDMﾓｰﾄﾞ"
        '
        'Tb_edm
        '
        Me.Tb_edm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_edm.Location = New System.Drawing.Point(606, 42)
        Me.Tb_edm.Name = "Tb_edm"
        Me.Tb_edm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_edm.Size = New System.Drawing.Size(60, 19)
        Me.Tb_edm.TabIndex = 30
        Me.Tb_edm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_sea
        '
        Me.Tb_sea.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_sea.Location = New System.Drawing.Point(426, 167)
        Me.Tb_sea.Name = "Tb_sea"
        Me.Tb_sea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_sea.Size = New System.Drawing.Size(85, 19)
        Me.Tb_sea.TabIndex = 31
        Me.Tb_sea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_fac
        '
        Me.Tb_fac.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_fac.Location = New System.Drawing.Point(606, 67)
        Me.Tb_fac.Name = "Tb_fac"
        Me.Tb_fac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_fac.Size = New System.Drawing.Size(60, 19)
        Me.Tb_fac.TabIndex = 32
        Me.Tb_fac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 12)
        Me.Label5.TabIndex = 33
        '
        'Lb_sea
        '
        Me.Lb_sea.AutoSize = True
        Me.Lb_sea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_sea.Location = New System.Drawing.Point(311, 170)
        Me.Lb_sea.Name = "Lb_sea"
        Me.Lb_sea.Size = New System.Drawing.Size(55, 14)
        Me.Lb_sea.TabIndex = 34
        Me.Lb_sea.Text = "追尾ﾓｰﾄﾞ"
        '
        'Lb_fac
        '
        Me.Lb_fac.AutoSize = True
        Me.Lb_fac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_fac.Location = New System.Drawing.Point(534, 70)
        Me.Lb_fac.Name = "Lb_fac"
        Me.Lb_fac.Size = New System.Drawing.Size(35, 14)
        Me.Lb_fac.TabIndex = 35
        Me.Lb_fac.Text = "ﾌｪｲｽ"
        '
        'Lb_th
        '
        Me.Lb_th.AutoSize = True
        Me.Lb_th.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_th.Location = New System.Drawing.Point(534, 95)
        Me.Lb_th.Name = "Lb_th"
        Me.Lb_th.Size = New System.Drawing.Size(52, 14)
        Me.Lb_th.TabIndex = 37
        Me.Lb_th.Text = "ﾁﾙﾄ補正"
        '
        'Tb_th
        '
        Me.Tb_th.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_th.Location = New System.Drawing.Point(606, 92)
        Me.Tb_th.Name = "Tb_th"
        Me.Tb_th.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_th.Size = New System.Drawing.Size(60, 19)
        Me.Tb_th.TabIndex = 36
        Me.Tb_th.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_sl
        '
        Me.Lb_sl.AutoSize = True
        Me.Lb_sl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_sl.Location = New System.Drawing.Point(311, 95)
        Me.Lb_sl.Name = "Lb_sl"
        Me.Lb_sl.Size = New System.Drawing.Size(43, 14)
        Me.Lb_sl.TabIndex = 38
        Me.Lb_sl.Text = "斜距離"
        '
        'Tb_sl
        '
        Me.Tb_sl.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_sl.Location = New System.Drawing.Point(426, 92)
        Me.Tb_sl.Name = "Tb_sl"
        Me.Tb_sl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_sl.Size = New System.Drawing.Size(85, 19)
        Me.Tb_sl.TabIndex = 39
        Me.Tb_sl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_hl
        '
        Me.Lb_hl.AutoSize = True
        Me.Lb_hl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_hl.Location = New System.Drawing.Point(311, 120)
        Me.Lb_hl.Name = "Lb_hl"
        Me.Lb_hl.Size = New System.Drawing.Size(55, 14)
        Me.Lb_hl.TabIndex = 40
        Me.Lb_hl.Text = "水平距離"
        '
        'Tb_hl
        '
        Me.Tb_hl.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_hl.Location = New System.Drawing.Point(426, 117)
        Me.Tb_hl.Name = "Tb_hl"
        Me.Tb_hl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_hl.Size = New System.Drawing.Size(85, 19)
        Me.Tb_hl.TabIndex = 41
        Me.Tb_hl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_vl
        '
        Me.Tb_vl.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vl.Location = New System.Drawing.Point(426, 142)
        Me.Tb_vl.Name = "Tb_vl"
        Me.Tb_vl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vl.Size = New System.Drawing.Size(85, 19)
        Me.Tb_vl.TabIndex = 42
        Me.Tb_vl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_vl
        '
        Me.Lb_vl.AutoSize = True
        Me.Lb_vl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_vl.Location = New System.Drawing.Point(312, 145)
        Me.Lb_vl.Name = "Lb_vl"
        Me.Lb_vl.Size = New System.Drawing.Size(59, 14)
        Me.Lb_vl.TabIndex = 43
        Me.Lb_vl.Text = "比高データ"
        '
        'Lb_prism
        '
        Me.Lb_prism.AutoSize = True
        Me.Lb_prism.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_prism.Location = New System.Drawing.Point(534, 170)
        Me.Lb_prism.Name = "Lb_prism"
        Me.Lb_prism.Size = New System.Drawing.Size(66, 14)
        Me.Lb_prism.TabIndex = 49
        Me.Lb_prism.Text = "ﾌﾟﾘｽﾞﾑ定数"
        '
        'Tb_prism
        '
        Me.Tb_prism.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_prism.Location = New System.Drawing.Point(606, 167)
        Me.Tb_prism.Name = "Tb_prism"
        Me.Tb_prism.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_prism.Size = New System.Drawing.Size(60, 19)
        Me.Tb_prism.TabIndex = 48
        Me.Tb_prism.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_weath
        '
        Me.Lb_weath.AutoSize = True
        Me.Lb_weath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_weath.Location = New System.Drawing.Point(534, 145)
        Me.Lb_weath.Name = "Lb_weath"
        Me.Lb_weath.Size = New System.Drawing.Size(55, 14)
        Me.Lb_weath.TabIndex = 47
        Me.Lb_weath.Text = "気象補正"
        '
        'Lb_light
        '
        Me.Lb_light.AutoSize = True
        Me.Lb_light.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_light.Location = New System.Drawing.Point(534, 120)
        Me.Lb_light.Name = "Lb_light"
        Me.Lb_light.Size = New System.Drawing.Size(56, 14)
        Me.Lb_light.TabIndex = 46
        Me.Lb_light.Text = "光量ﾚﾍﾞﾙ"
        '
        'Tb_weath
        '
        Me.Tb_weath.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_weath.Location = New System.Drawing.Point(606, 142)
        Me.Tb_weath.Name = "Tb_weath"
        Me.Tb_weath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_weath.Size = New System.Drawing.Size(60, 19)
        Me.Tb_weath.TabIndex = 45
        Me.Tb_weath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_light
        '
        Me.Tb_light.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_light.Location = New System.Drawing.Point(606, 117)
        Me.Tb_light.Name = "Tb_light"
        Me.Tb_light.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_light.Size = New System.Drawing.Size(60, 19)
        Me.Tb_light.TabIndex = 44
        Me.Tb_light.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tm_Interval
        '
        '
        'Bt_Crs1
        '
        Me.Bt_Crs1.Location = New System.Drawing.Point(394, 213)
        Me.Bt_Crs1.Name = "Bt_Crs1"
        Me.Bt_Crs1.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Crs1.TabIndex = 50
        Me.Bt_Crs1.Text = "CRS1連続"
        Me.Bt_Crs1.UseVisualStyleBackColor = True
        '
        'Tb_interval
        '
        Me.Tb_interval.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_interval.Location = New System.Drawing.Point(623, 198)
        Me.Tb_interval.Name = "Tb_interval"
        Me.Tb_interval.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_interval.Size = New System.Drawing.Size(43, 19)
        Me.Tb_interval.TabIndex = 51
        Me.Tb_interval.Text = "10"
        Me.Tb_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_interval
        '
        Me.Lb_interval.AutoSize = True
        Me.Lb_interval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_interval.Location = New System.Drawing.Point(570, 201)
        Me.Lb_interval.Name = "Lb_interval"
        Me.Lb_interval.Size = New System.Drawing.Size(47, 14)
        Me.Lb_interval.TabIndex = 52
        Me.Lb_interval.Text = "間隔 秒"
        '
        'Bt_serch
        '
        Me.Bt_serch.Location = New System.Drawing.Point(311, 272)
        Me.Bt_serch.Name = "Bt_serch"
        Me.Bt_serch.Size = New System.Drawing.Size(55, 23)
        Me.Bt_serch.TabIndex = 53
        Me.Bt_serch.Text = "ｻｰﾁ"
        Me.Bt_serch.UseVisualStyleBackColor = True
        '
        'Tb_count
        '
        Me.Tb_count.Location = New System.Drawing.Point(606, 380)
        Me.Tb_count.Name = "Tb_count"
        Me.Tb_count.Size = New System.Drawing.Size(60, 19)
        Me.Tb_count.TabIndex = 54
        Me.Tb_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Bt_Weit
        '
        Me.Bt_Weit.Location = New System.Drawing.Point(311, 301)
        Me.Bt_Weit.Name = "Bt_Weit"
        Me.Bt_Weit.Size = New System.Drawing.Size(55, 23)
        Me.Bt_Weit.TabIndex = 55
        Me.Bt_Weit.Text = "ｳｪｲﾄ"
        Me.Bt_Weit.UseVisualStyleBackColor = True
        '
        'Bt_stop
        '
        Me.Bt_stop.Location = New System.Drawing.Point(311, 330)
        Me.Bt_stop.Name = "Bt_stop"
        Me.Bt_stop.Size = New System.Drawing.Size(55, 23)
        Me.Bt_stop.TabIndex = 56
        Me.Bt_stop.Text = "停止"
        Me.Bt_stop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(311, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "追尾指令"
        '
        'Tb_hos
        '
        Me.Tb_hos.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_hos.Location = New System.Drawing.Point(527, 279)
        Me.Tb_hos.Name = "Tb_hos"
        Me.Tb_hos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_hos.Size = New System.Drawing.Size(40, 19)
        Me.Tb_hos.TabIndex = 65
        Me.Tb_hos.Text = "0"
        Me.Tb_hos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_hom
        '
        Me.Tb_hom.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_hom.Location = New System.Drawing.Point(482, 279)
        Me.Tb_hom.Name = "Tb_hom"
        Me.Tb_hom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_hom.Size = New System.Drawing.Size(40, 19)
        Me.Tb_hom.TabIndex = 64
        Me.Tb_hom.Text = "0"
        Me.Tb_hom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_hod
        '
        Me.Tb_hod.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_hod.Location = New System.Drawing.Point(437, 279)
        Me.Tb_hod.Name = "Tb_hod"
        Me.Tb_hod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_hod.Size = New System.Drawing.Size(40, 19)
        Me.Tb_hod.TabIndex = 63
        Me.Tb_hod.Text = "0"
        Me.Tb_hod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_ho
        '
        Me.Lb_ho.AutoSize = True
        Me.Lb_ho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_ho.Location = New System.Drawing.Point(388, 282)
        Me.Lb_ho.Name = "Lb_ho"
        Me.Lb_ho.Size = New System.Drawing.Size(43, 14)
        Me.Lb_ho.TabIndex = 62
        Me.Lb_ho.Text = "水平角"
        '
        'Tb_vos
        '
        Me.Tb_vos.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vos.Location = New System.Drawing.Point(527, 255)
        Me.Tb_vos.Name = "Tb_vos"
        Me.Tb_vos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vos.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vos.TabIndex = 61
        Me.Tb_vos.Text = "0"
        Me.Tb_vos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_vom
        '
        Me.Tb_vom.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vom.Location = New System.Drawing.Point(482, 255)
        Me.Tb_vom.Name = "Tb_vom"
        Me.Tb_vom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vom.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vom.TabIndex = 60
        Me.Tb_vom.Text = "0"
        Me.Tb_vom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_vod
        '
        Me.Tb_vod.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_vod.Location = New System.Drawing.Point(437, 255)
        Me.Tb_vod.Name = "Tb_vod"
        Me.Tb_vod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_vod.Size = New System.Drawing.Size(40, 19)
        Me.Tb_vod.TabIndex = 59
        Me.Tb_vod.Text = "0"
        Me.Tb_vod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_vo
        '
        Me.Lb_vo.AutoSize = True
        Me.Lb_vo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_vo.Location = New System.Drawing.Point(388, 258)
        Me.Lb_vo.Name = "Lb_vo"
        Me.Lb_vo.Size = New System.Drawing.Size(43, 14)
        Me.Lb_vo.TabIndex = 58
        Me.Lb_vo.Text = "鉛直角"
        '
        'Bt_circleab
        '
        Me.Bt_circleab.Location = New System.Drawing.Point(591, 252)
        Me.Bt_circleab.Name = "Bt_circleab"
        Me.Bt_circleab.Size = New System.Drawing.Size(75, 23)
        Me.Bt_circleab.TabIndex = 66
        Me.Bt_circleab.Text = "絶対角旋回"
        Me.Bt_circleab.UseVisualStyleBackColor = True
        '
        'Bt_circlerl
        '
        Me.Bt_circlerl.Location = New System.Drawing.Point(591, 277)
        Me.Bt_circlerl.Name = "Bt_circlerl"
        Me.Bt_circlerl.Size = New System.Drawing.Size(75, 23)
        Me.Bt_circlerl.TabIndex = 67
        Me.Bt_circlerl.Text = "相対角旋回"
        Me.Bt_circlerl.UseVisualStyleBackColor = True
        '
        'Tb_Shs
        '
        Me.Tb_Shs.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_Shs.Location = New System.Drawing.Point(527, 314)
        Me.Tb_Shs.Name = "Tb_Shs"
        Me.Tb_Shs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_Shs.Size = New System.Drawing.Size(40, 19)
        Me.Tb_Shs.TabIndex = 71
        Me.Tb_Shs.Text = "0"
        Me.Tb_Shs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_Shm
        '
        Me.Tb_Shm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_Shm.Location = New System.Drawing.Point(482, 314)
        Me.Tb_Shm.Name = "Tb_Shm"
        Me.Tb_Shm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_Shm.Size = New System.Drawing.Size(40, 19)
        Me.Tb_Shm.TabIndex = 70
        Me.Tb_Shm.Text = "0"
        Me.Tb_Shm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tb_Shd
        '
        Me.Tb_Shd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_Shd.Location = New System.Drawing.Point(437, 314)
        Me.Tb_Shd.Name = "Tb_Shd"
        Me.Tb_Shd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_Shd.Size = New System.Drawing.Size(40, 19)
        Me.Tb_Shd.TabIndex = 69
        Me.Tb_Shd.Text = "0"
        Me.Tb_Shd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(388, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 14)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "水平角"
        '
        'Bt_SetAng
        '
        Me.Bt_SetAng.Location = New System.Drawing.Point(591, 312)
        Me.Bt_SetAng.Name = "Bt_SetAng"
        Me.Bt_SetAng.Size = New System.Drawing.Size(75, 23)
        Me.Bt_SetAng.TabIndex = 72
        Me.Bt_SetAng.Text = "水平角設定"
        Me.Bt_SetAng.UseVisualStyleBackColor = True
        '
        'Bt_Tron
        '
        Me.Bt_Tron.Location = New System.Drawing.Point(381, 351)
        Me.Bt_Tron.Name = "Bt_Tron"
        Me.Bt_Tron.Size = New System.Drawing.Size(55, 23)
        Me.Bt_Tron.TabIndex = 73
        Me.Bt_Tron.Text = "Tr ON"
        Me.Bt_Tron.UseVisualStyleBackColor = True
        '
        'Bt_Troff
        '
        Me.Bt_Troff.Location = New System.Drawing.Point(381, 380)
        Me.Bt_Troff.Name = "Bt_Troff"
        Me.Bt_Troff.Size = New System.Drawing.Size(55, 23)
        Me.Bt_Troff.TabIndex = 74
        Me.Bt_Troff.Text = "Tr OFF"
        Me.Bt_Troff.UseVisualStyleBackColor = True
        '
        'Bt_Lzoff
        '
        Me.Bt_Lzoff.Location = New System.Drawing.Point(442, 380)
        Me.Bt_Lzoff.Name = "Bt_Lzoff"
        Me.Bt_Lzoff.Size = New System.Drawing.Size(55, 23)
        Me.Bt_Lzoff.TabIndex = 76
        Me.Bt_Lzoff.Text = "Lz OFF"
        Me.Bt_Lzoff.UseVisualStyleBackColor = True
        '
        'Bt_Lzon
        '
        Me.Bt_Lzon.Location = New System.Drawing.Point(442, 351)
        Me.Bt_Lzon.Name = "Bt_Lzon"
        Me.Bt_Lzon.Size = New System.Drawing.Size(55, 23)
        Me.Bt_Lzon.TabIndex = 75
        Me.Bt_Lzon.Text = "Lz ON"
        Me.Bt_Lzon.UseVisualStyleBackColor = True
        '
        'Tb_rtcnt
        '
        Me.Tb_rtcnt.Location = New System.Drawing.Point(606, 351)
        Me.Tb_rtcnt.Name = "Tb_rtcnt"
        Me.Tb_rtcnt.Size = New System.Drawing.Size(60, 19)
        Me.Tb_rtcnt.TabIndex = 77
        Me.Tb_rtcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tm_Search
        '
        '
        'Lb_rtry
        '
        Me.Lb_rtry.AutoSize = True
        Me.Lb_rtry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_rtry.Location = New System.Drawing.Point(570, 224)
        Me.Lb_rtry.Name = "Lb_rtry"
        Me.Lb_rtry.Size = New System.Drawing.Size(45, 14)
        Me.Lb_rtry.TabIndex = 79
        Me.Lb_rtry.Text = "ﾘﾄﾗｲ数"
        '
        'Tb_rtry
        '
        Me.Tb_rtry.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_rtry.Location = New System.Drawing.Point(623, 221)
        Me.Tb_rtry.Name = "Tb_rtry"
        Me.Tb_rtry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_rtry.Size = New System.Drawing.Size(43, 19)
        Me.Tb_rtry.TabIndex = 78
        Me.Tb_rtry.Text = "10"
        Me.Tb_rtry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cb_safe
        '
        Me.Cb_safe.AutoSize = True
        Me.Cb_safe.Checked = True
        Me.Cb_safe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Cb_safe.Location = New System.Drawing.Point(312, 415)
        Me.Cb_safe.Name = "Cb_safe"
        Me.Cb_safe.Size = New System.Drawing.Size(72, 16)
        Me.Cb_safe.TabIndex = 80
        Me.Cb_safe.Text = "保護機能"
        Me.Cb_safe.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(388, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "ウェイト時間[sec]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(387, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 14)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "ｲﾝﾀｰﾊﾞﾙ時間[sec]"
        '
        'Tb_wait
        '
        Me.Tb_wait.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_wait.Location = New System.Drawing.Point(501, 413)
        Me.Tb_wait.Name = "Tb_wait"
        Me.Tb_wait.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_wait.Size = New System.Drawing.Size(85, 19)
        Me.Tb_wait.TabIndex = 31
        Me.Tb_wait.Text = "60"
        Me.Tb_wait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_waititv
        '
        Me.Tb_waititv.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Tb_waititv.Location = New System.Drawing.Point(501, 439)
        Me.Tb_waititv.Name = "Tb_waititv"
        Me.Tb_waititv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tb_waititv.Size = New System.Drawing.Size(85, 19)
        Me.Tb_waititv.TabIndex = 31
        Me.Tb_waititv.Text = "60"
        Me.Tb_waititv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "設定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(755, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 14)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "リングNo."
        '
        'lb_RinNo
        '
        Me.lb_RinNo.BackColor = System.Drawing.SystemColors.Window
        Me.lb_RinNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_RinNo.Location = New System.Drawing.Point(870, 65)
        Me.lb_RinNo.Name = "lb_RinNo"
        Me.lb_RinNo.Size = New System.Drawing.Size(40, 19)
        Me.lb_RinNo.TabIndex = 83
        Me.lb_RinNo.Text = "9999"
        Me.lb_RinNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_RealSt
        '
        Me.lb_RealSt.BackColor = System.Drawing.SystemColors.Window
        Me.lb_RealSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_RealSt.Location = New System.Drawing.Point(1062, 65)
        Me.lb_RealSt.Name = "lb_RealSt"
        Me.lb_RealSt.Size = New System.Drawing.Size(40, 19)
        Me.lb_RealSt.TabIndex = 85
        Me.lb_RealSt.Text = "9999"
        Me.lb_RealSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(951, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 14)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "推進量(mm)"
        '
        'lb_frDir
        '
        Me.lb_frDir.BackColor = System.Drawing.SystemColors.Window
        Me.lb_frDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_frDir.Location = New System.Drawing.Point(870, 120)
        Me.lb_frDir.Name = "lb_frDir"
        Me.lb_frDir.Size = New System.Drawing.Size(40, 19)
        Me.lb_frDir.TabIndex = 87
        Me.lb_frDir.Text = "9999"
        Me.lb_frDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(755, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 14)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "前胴方位(度)"
        '
        'lb_rrDir
        '
        Me.lb_rrDir.BackColor = System.Drawing.SystemColors.Window
        Me.lb_rrDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_rrDir.Location = New System.Drawing.Point(870, 142)
        Me.lb_rrDir.Name = "lb_rrDir"
        Me.lb_rrDir.Size = New System.Drawing.Size(40, 19)
        Me.lb_rrDir.TabIndex = 89
        Me.lb_rrDir.Text = "9999"
        Me.lb_rrDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(755, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 14)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "後胴方位(度)"
        '
        'lb_rrPitch
        '
        Me.lb_rrPitch.BackColor = System.Drawing.SystemColors.Window
        Me.lb_rrPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_rrPitch.Location = New System.Drawing.Point(1062, 143)
        Me.lb_rrPitch.Name = "lb_rrPitch"
        Me.lb_rrPitch.Size = New System.Drawing.Size(40, 19)
        Me.lb_rrPitch.TabIndex = 95
        Me.lb_rrPitch.Text = "9999"
        Me.lb_rrPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(951, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 14)
        Me.Label19.TabIndex = 94
        Me.Label19.Text = "後胴ピッチング(度)"
        '
        'lb_frPitch
        '
        Me.lb_frPitch.BackColor = System.Drawing.SystemColors.Window
        Me.lb_frPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_frPitch.Location = New System.Drawing.Point(1062, 120)
        Me.lb_frPitch.Name = "lb_frPitch"
        Me.lb_frPitch.Size = New System.Drawing.Size(40, 19)
        Me.lb_frPitch.TabIndex = 93
        Me.lb_frPitch.Text = "9999"
        Me.lb_frPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Location = New System.Drawing.Point(951, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 14)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "前胴ピッチング(度)"
        '
        'lb_rrRolling
        '
        Me.lb_rrRolling.BackColor = System.Drawing.SystemColors.Window
        Me.lb_rrRolling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_rrRolling.Location = New System.Drawing.Point(1062, 167)
        Me.lb_rrRolling.Name = "lb_rrRolling"
        Me.lb_rrRolling.Size = New System.Drawing.Size(40, 19)
        Me.lb_rrRolling.TabIndex = 97
        Me.lb_rrRolling.Text = "9999"
        Me.lb_rrRolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Location = New System.Drawing.Point(951, 169)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(95, 14)
        Me.Label23.TabIndex = 96
        Me.Label23.Text = "後胴ローリング(度)"
        '
        'lb_NkRDSt
        '
        Me.lb_NkRDSt.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkRDSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkRDSt.Location = New System.Drawing.Point(1063, 227)
        Me.lb_NkRDSt.Name = "lb_NkRDSt"
        Me.lb_NkRDSt.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkRDSt.TabIndex = 105
        Me.lb_NkRDSt.Text = "9999"
        Me.lb_NkRDSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(952, 229)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 14)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "中折st（右下)(mm)"
        '
        'lb_NkRUSt
        '
        Me.lb_NkRUSt.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkRUSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkRUSt.Location = New System.Drawing.Point(1063, 204)
        Me.lb_NkRUSt.Name = "lb_NkRUSt"
        Me.lb_NkRUSt.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkRUSt.TabIndex = 103
        Me.lb_NkRUSt.Text = "9999"
        Me.lb_NkRUSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Location = New System.Drawing.Point(952, 206)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 14)
        Me.Label25.TabIndex = 102
        Me.Label25.Text = "中折st（右上)(mm)"
        '
        'lb_NkLDSt
        '
        Me.lb_NkLDSt.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkLDSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkLDSt.Location = New System.Drawing.Point(871, 226)
        Me.lb_NkLDSt.Name = "lb_NkLDSt"
        Me.lb_NkLDSt.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkLDSt.TabIndex = 101
        Me.lb_NkLDSt.Text = "9999"
        Me.lb_NkLDSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Location = New System.Drawing.Point(756, 228)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 14)
        Me.Label27.TabIndex = 100
        Me.Label27.Text = "中折st（左下)(mm)"
        '
        'lb_NkLUSt
        '
        Me.lb_NkLUSt.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkLUSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkLUSt.Location = New System.Drawing.Point(871, 204)
        Me.lb_NkLUSt.Name = "lb_NkLUSt"
        Me.lb_NkLUSt.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkLUSt.TabIndex = 99
        Me.lb_NkLUSt.Text = "9999"
        Me.lb_NkLUSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Location = New System.Drawing.Point(756, 206)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(101, 14)
        Me.Label29.TabIndex = 98
        Me.Label29.Text = "中折st（左上)(mm)"
        '
        'lb_NkUD
        '
        Me.lb_NkUD.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkUD.Location = New System.Drawing.Point(1063, 264)
        Me.lb_NkUD.Name = "lb_NkUD"
        Me.lb_NkUD.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkUD.TabIndex = 109
        Me.lb_NkUD.Text = "9999"
        Me.lb_NkUD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Location = New System.Drawing.Point(959, 263)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 14)
        Me.Label31.TabIndex = 108
        Me.Label31.Text = "上下中折角(度)"
        '
        'lb_NkLR
        '
        Me.lb_NkLR.BackColor = System.Drawing.SystemColors.Window
        Me.lb_NkLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_NkLR.Location = New System.Drawing.Point(871, 263)
        Me.lb_NkLR.Name = "lb_NkLR"
        Me.lb_NkLR.Size = New System.Drawing.Size(40, 19)
        Me.lb_NkLR.TabIndex = 107
        Me.lb_NkLR.Text = "9999"
        Me.lb_NkLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Location = New System.Drawing.Point(756, 265)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(87, 14)
        Me.Label33.TabIndex = 106
        Me.Label33.Text = "左右中折角(度)"
        '
        'lb_ExecSts
        '
        Me.lb_ExecSts.BackColor = System.Drawing.Color.Red
        Me.lb_ExecSts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ExecSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lb_ExecSts.Location = New System.Drawing.Point(756, 21)
        Me.lb_ExecSts.Name = "lb_ExecSts"
        Me.lb_ExecSts.Size = New System.Drawing.Size(78, 26)
        Me.lb_ExecSts.TabIndex = 110
        Me.lb_ExecSts.Text = "掘進"
        Me.lb_ExecSts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tm_PlcCom
        '
        Me.Tm_PlcCom.Enabled = True
        Me.Tm_PlcCom.Interval = 1000
        '
        'lb_ResltR0C0
        '
        Me.lb_ResltR0C0.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C0.Location = New System.Drawing.Point(162, 593)
        Me.lb_ResltR0C0.Name = "lb_ResltR0C0"
        Me.lb_ResltR0C0.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR0C0.TabIndex = 111
        Me.lb_ResltR0C0.Text = "99999999.999"
        Me.lb_ResltR0C0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C1
        '
        Me.lb_ResltR0C1.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C1.Location = New System.Drawing.Point(268, 593)
        Me.lb_ResltR0C1.Name = "lb_ResltR0C1"
        Me.lb_ResltR0C1.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR0C1.TabIndex = 112
        Me.lb_ResltR0C1.Text = "99999999.999"
        Me.lb_ResltR0C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C2
        '
        Me.lb_ResltR0C2.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C2.Location = New System.Drawing.Point(374, 593)
        Me.lb_ResltR0C2.Name = "lb_ResltR0C2"
        Me.lb_ResltR0C2.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR0C2.TabIndex = 113
        Me.lb_ResltR0C2.Text = "99999999.999"
        Me.lb_ResltR0C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C2
        '
        Me.lb_ResltR3C2.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C2.Location = New System.Drawing.Point(374, 654)
        Me.lb_ResltR3C2.Name = "lb_ResltR3C2"
        Me.lb_ResltR3C2.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR3C2.TabIndex = 119
        Me.lb_ResltR3C2.Text = "99999999.999"
        Me.lb_ResltR3C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C1
        '
        Me.lb_ResltR3C1.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C1.Location = New System.Drawing.Point(268, 654)
        Me.lb_ResltR3C1.Name = "lb_ResltR3C1"
        Me.lb_ResltR3C1.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR3C1.TabIndex = 118
        Me.lb_ResltR3C1.Text = "99999999.999"
        Me.lb_ResltR3C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C0
        '
        Me.lb_ResltR3C0.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C0.Location = New System.Drawing.Point(162, 654)
        Me.lb_ResltR3C0.Name = "lb_ResltR3C0"
        Me.lb_ResltR3C0.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR3C0.TabIndex = 117
        Me.lb_ResltR3C0.Text = "99999999.999"
        Me.lb_ResltR3C0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR6C2
        '
        Me.lb_ResltR6C2.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C2.Location = New System.Drawing.Point(374, 750)
        Me.lb_ResltR6C2.Name = "lb_ResltR6C2"
        Me.lb_ResltR6C2.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR6C2.TabIndex = 128
        Me.lb_ResltR6C2.Text = "99999999.999"
        Me.lb_ResltR6C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR6C1
        '
        Me.lb_ResltR6C1.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C1.Location = New System.Drawing.Point(268, 750)
        Me.lb_ResltR6C1.Name = "lb_ResltR6C1"
        Me.lb_ResltR6C1.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR6C1.TabIndex = 127
        Me.lb_ResltR6C1.Text = "99999999.999"
        Me.lb_ResltR6C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR6C0
        '
        Me.lb_ResltR6C0.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C0.Location = New System.Drawing.Point(162, 750)
        Me.lb_ResltR6C0.Name = "lb_ResltR6C0"
        Me.lb_ResltR6C0.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR6C0.TabIndex = 126
        Me.lb_ResltR6C0.Text = "99999999.999"
        Me.lb_ResltR6C0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C2
        '
        Me.lb_ResltR5C2.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C2.Location = New System.Drawing.Point(374, 718)
        Me.lb_ResltR5C2.Name = "lb_ResltR5C2"
        Me.lb_ResltR5C2.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR5C2.TabIndex = 125
        Me.lb_ResltR5C2.Text = "99999999.999"
        Me.lb_ResltR5C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C1
        '
        Me.lb_ResltR5C1.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C1.Location = New System.Drawing.Point(268, 718)
        Me.lb_ResltR5C1.Name = "lb_ResltR5C1"
        Me.lb_ResltR5C1.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR5C1.TabIndex = 124
        Me.lb_ResltR5C1.Text = "99999999.999"
        Me.lb_ResltR5C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C0
        '
        Me.lb_ResltR5C0.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C0.Location = New System.Drawing.Point(162, 718)
        Me.lb_ResltR5C0.Name = "lb_ResltR5C0"
        Me.lb_ResltR5C0.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR5C0.TabIndex = 123
        Me.lb_ResltR5C0.Text = "99999999.999"
        Me.lb_ResltR5C0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C2
        '
        Me.lb_ResltR4C2.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C2.Location = New System.Drawing.Point(374, 689)
        Me.lb_ResltR4C2.Name = "lb_ResltR4C2"
        Me.lb_ResltR4C2.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR4C2.TabIndex = 122
        Me.lb_ResltR4C2.Text = "99999999.999"
        Me.lb_ResltR4C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C1
        '
        Me.lb_ResltR4C1.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C1.Location = New System.Drawing.Point(268, 689)
        Me.lb_ResltR4C1.Name = "lb_ResltR4C1"
        Me.lb_ResltR4C1.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR4C1.TabIndex = 121
        Me.lb_ResltR4C1.Text = "99999999.999"
        Me.lb_ResltR4C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C0
        '
        Me.lb_ResltR4C0.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C0.Location = New System.Drawing.Point(162, 689)
        Me.lb_ResltR4C0.Name = "lb_ResltR4C0"
        Me.lb_ResltR4C0.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR4C0.TabIndex = 120
        Me.lb_ResltR4C0.Text = "99999999.999"
        Me.lb_ResltR4C0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label39.Location = New System.Drawing.Point(166, 554)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(104, 30)
        Me.Label39.TabIndex = 129
        Me.Label39.Text = "X座標(m)　"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label40.Location = New System.Drawing.Point(268, 554)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 30)
        Me.Label40.TabIndex = 130
        Me.Label40.Text = "Y座標(m)　"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label41.Location = New System.Drawing.Point(374, 554)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(104, 30)
        Me.Label41.TabIndex = 131
        Me.Label41.Text = "Z座標(m)"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.Control
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(7, 593)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 19)
        Me.Label42.TabIndex = 132
        Me.Label42.Text = "ターゲット"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(117, 593)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(39, 19)
        Me.Label43.TabIndex = 133
        Me.Label43.Text = "T"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.Control
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(117, 654)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(39, 19)
        Me.Label46.TabIndex = 137
        Me.Label46.Text = "P1"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(7, 654)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(104, 19)
        Me.Label47.TabIndex = 136
        Me.Label47.Text = "先端"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(117, 689)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(39, 19)
        Me.Label48.TabIndex = 139
        Me.Label48.Text = "P2"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label49.ForeColor = System.Drawing.Color.Red
        Me.Label49.Location = New System.Drawing.Point(7, 689)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(104, 19)
        Me.Label49.TabIndex = 138
        Me.Label49.Text = "前胴後端"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(117, 718)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(39, 19)
        Me.Label50.TabIndex = 141
        Me.Label50.Text = "P3"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.Control
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(7, 718)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 19)
        Me.Label51.TabIndex = 140
        Me.Label51.Text = "後胴先端"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(117, 750)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(39, 19)
        Me.Label52.TabIndex = 143
        Me.Label52.Text = "P4"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.Control
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label53.ForeColor = System.Drawing.Color.Red
        Me.Label53.Location = New System.Drawing.Point(7, 750)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(104, 19)
        Me.Label53.TabIndex = 142
        Me.Label53.Text = "後端"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(653, 554)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 30)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "線形状"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(612, 554)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 30)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "ｿﾞｰﾝ"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(510, 554)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 30)
        Me.Label18.TabIndex = 159
        Me.Label18.Text = "発進からの" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "累積距離（m）"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C7
        '
        Me.lb_ResltR6C7.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C7.Location = New System.Drawing.Point(653, 750)
        Me.lb_ResltR6C7.Name = "lb_ResltR6C7"
        Me.lb_ResltR6C7.Size = New System.Drawing.Size(49, 19)
        Me.lb_ResltR6C7.TabIndex = 158
        Me.lb_ResltR6C7.Text = "1"
        Me.lb_ResltR6C7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR6C6
        '
        Me.lb_ResltR6C6.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C6.Location = New System.Drawing.Point(612, 750)
        Me.lb_ResltR6C6.Name = "lb_ResltR6C6"
        Me.lb_ResltR6C6.Size = New System.Drawing.Size(42, 19)
        Me.lb_ResltR6C6.TabIndex = 157
        Me.lb_ResltR6C6.Text = "1"
        Me.lb_ResltR6C6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR6C4
        '
        Me.lb_ResltR6C4.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C4.Location = New System.Drawing.Point(506, 750)
        Me.lb_ResltR6C4.Name = "lb_ResltR6C4"
        Me.lb_ResltR6C4.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR6C4.TabIndex = 156
        Me.lb_ResltR6C4.Text = "99999999.999"
        Me.lb_ResltR6C4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C7
        '
        Me.lb_ResltR5C7.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C7.Location = New System.Drawing.Point(653, 718)
        Me.lb_ResltR5C7.Name = "lb_ResltR5C7"
        Me.lb_ResltR5C7.Size = New System.Drawing.Size(49, 19)
        Me.lb_ResltR5C7.TabIndex = 155
        Me.lb_ResltR5C7.Text = "1"
        Me.lb_ResltR5C7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C6
        '
        Me.lb_ResltR5C6.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C6.Location = New System.Drawing.Point(612, 718)
        Me.lb_ResltR5C6.Name = "lb_ResltR5C6"
        Me.lb_ResltR5C6.Size = New System.Drawing.Size(42, 19)
        Me.lb_ResltR5C6.TabIndex = 154
        Me.lb_ResltR5C6.Text = "1"
        Me.lb_ResltR5C6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C4
        '
        Me.lb_ResltR5C4.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C4.Location = New System.Drawing.Point(506, 718)
        Me.lb_ResltR5C4.Name = "lb_ResltR5C4"
        Me.lb_ResltR5C4.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR5C4.TabIndex = 153
        Me.lb_ResltR5C4.Text = "99999999.999"
        Me.lb_ResltR5C4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C7
        '
        Me.lb_ResltR4C7.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C7.Location = New System.Drawing.Point(653, 689)
        Me.lb_ResltR4C7.Name = "lb_ResltR4C7"
        Me.lb_ResltR4C7.Size = New System.Drawing.Size(49, 19)
        Me.lb_ResltR4C7.TabIndex = 152
        Me.lb_ResltR4C7.Text = "1"
        Me.lb_ResltR4C7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C6
        '
        Me.lb_ResltR4C6.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C6.Location = New System.Drawing.Point(612, 689)
        Me.lb_ResltR4C6.Name = "lb_ResltR4C6"
        Me.lb_ResltR4C6.Size = New System.Drawing.Size(42, 19)
        Me.lb_ResltR4C6.TabIndex = 151
        Me.lb_ResltR4C6.Text = "1"
        Me.lb_ResltR4C6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C4
        '
        Me.lb_ResltR4C4.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C4.Location = New System.Drawing.Point(506, 689)
        Me.lb_ResltR4C4.Name = "lb_ResltR4C4"
        Me.lb_ResltR4C4.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR4C4.TabIndex = 150
        Me.lb_ResltR4C4.Text = "99999999.999"
        Me.lb_ResltR4C4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C7
        '
        Me.lb_ResltR3C7.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C7.Location = New System.Drawing.Point(653, 654)
        Me.lb_ResltR3C7.Name = "lb_ResltR3C7"
        Me.lb_ResltR3C7.Size = New System.Drawing.Size(49, 19)
        Me.lb_ResltR3C7.TabIndex = 149
        Me.lb_ResltR3C7.Text = "1"
        Me.lb_ResltR3C7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C6
        '
        Me.lb_ResltR3C6.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C6.Location = New System.Drawing.Point(612, 654)
        Me.lb_ResltR3C6.Name = "lb_ResltR3C6"
        Me.lb_ResltR3C6.Size = New System.Drawing.Size(42, 19)
        Me.lb_ResltR3C6.TabIndex = 148
        Me.lb_ResltR3C6.Text = "1"
        Me.lb_ResltR3C6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C4
        '
        Me.lb_ResltR3C4.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C4.Location = New System.Drawing.Point(506, 654)
        Me.lb_ResltR3C4.Name = "lb_ResltR3C4"
        Me.lb_ResltR3C4.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR3C4.TabIndex = 147
        Me.lb_ResltR3C4.Text = "99999999.999"
        Me.lb_ResltR3C4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C7
        '
        Me.lb_ResltR0C7.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C7.Location = New System.Drawing.Point(653, 593)
        Me.lb_ResltR0C7.Name = "lb_ResltR0C7"
        Me.lb_ResltR0C7.Size = New System.Drawing.Size(49, 19)
        Me.lb_ResltR0C7.TabIndex = 146
        Me.lb_ResltR0C7.Text = "1"
        Me.lb_ResltR0C7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C6
        '
        Me.lb_ResltR0C6.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C6.Location = New System.Drawing.Point(612, 593)
        Me.lb_ResltR0C6.Name = "lb_ResltR0C6"
        Me.lb_ResltR0C6.Size = New System.Drawing.Size(42, 19)
        Me.lb_ResltR0C6.TabIndex = 145
        Me.lb_ResltR0C6.Text = "1"
        Me.lb_ResltR0C6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C4
        '
        Me.lb_ResltR0C4.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C4.Location = New System.Drawing.Point(506, 593)
        Me.lb_ResltR0C4.Name = "lb_ResltR0C4"
        Me.lb_ResltR0C4.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR0C4.TabIndex = 144
        Me.lb_ResltR0C4.Text = "99999999.999"
        Me.lb_ResltR0C4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label67
        '
        Me.Label67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label67.Location = New System.Drawing.Point(705, 554)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(104, 30)
        Me.Label67.TabIndex = 167
        Me.Label67.Text = "半径（ｍ）"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C8
        '
        Me.lb_ResltR6C8.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C8.Location = New System.Drawing.Point(701, 750)
        Me.lb_ResltR6C8.Name = "lb_ResltR6C8"
        Me.lb_ResltR6C8.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR6C8.TabIndex = 166
        Me.lb_ResltR6C8.Text = "99999999.999"
        Me.lb_ResltR6C8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C8
        '
        Me.lb_ResltR5C8.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C8.Location = New System.Drawing.Point(701, 718)
        Me.lb_ResltR5C8.Name = "lb_ResltR5C8"
        Me.lb_ResltR5C8.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR5C8.TabIndex = 165
        Me.lb_ResltR5C8.Text = "99999999.999"
        Me.lb_ResltR5C8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C8
        '
        Me.lb_ResltR4C8.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C8.Location = New System.Drawing.Point(701, 689)
        Me.lb_ResltR4C8.Name = "lb_ResltR4C8"
        Me.lb_ResltR4C8.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR4C8.TabIndex = 164
        Me.lb_ResltR4C8.Text = "99999999.999"
        Me.lb_ResltR4C8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C8
        '
        Me.lb_ResltR3C8.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C8.Location = New System.Drawing.Point(701, 654)
        Me.lb_ResltR3C8.Name = "lb_ResltR3C8"
        Me.lb_ResltR3C8.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR3C8.TabIndex = 163
        Me.lb_ResltR3C8.Text = "99999999.999"
        Me.lb_ResltR3C8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C8
        '
        Me.lb_ResltR0C8.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C8.Location = New System.Drawing.Point(701, 593)
        Me.lb_ResltR0C8.Name = "lb_ResltR0C8"
        Me.lb_ResltR0C8.Size = New System.Drawing.Size(108, 19)
        Me.lb_ResltR0C8.TabIndex = 162
        Me.lb_ResltR0C8.Text = "99999999.999"
        Me.lb_ResltR0C8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label73
        '
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label73.Location = New System.Drawing.Point(812, 554)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(87, 30)
        Me.Label73.TabIndex = 173
        Me.Label73.Text = "ｿﾞｰﾝ距離（ｍ）"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C9
        '
        Me.lb_ResltR6C9.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C9.Location = New System.Drawing.Point(808, 750)
        Me.lb_ResltR6C9.Name = "lb_ResltR6C9"
        Me.lb_ResltR6C9.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR6C9.TabIndex = 172
        Me.lb_ResltR6C9.Text = "99999999.999"
        Me.lb_ResltR6C9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C9
        '
        Me.lb_ResltR5C9.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C9.Location = New System.Drawing.Point(808, 718)
        Me.lb_ResltR5C9.Name = "lb_ResltR5C9"
        Me.lb_ResltR5C9.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR5C9.TabIndex = 171
        Me.lb_ResltR5C9.Text = "99999999.999"
        Me.lb_ResltR5C9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C9
        '
        Me.lb_ResltR4C9.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C9.Location = New System.Drawing.Point(808, 689)
        Me.lb_ResltR4C9.Name = "lb_ResltR4C9"
        Me.lb_ResltR4C9.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR4C9.TabIndex = 170
        Me.lb_ResltR4C9.Text = "99999999.999"
        Me.lb_ResltR4C9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C9
        '
        Me.lb_ResltR3C9.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C9.Location = New System.Drawing.Point(808, 654)
        Me.lb_ResltR3C9.Name = "lb_ResltR3C9"
        Me.lb_ResltR3C9.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR3C9.TabIndex = 169
        Me.lb_ResltR3C9.Text = "99999999.999"
        Me.lb_ResltR3C9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C9
        '
        Me.lb_ResltR0C9.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C9.Location = New System.Drawing.Point(808, 593)
        Me.lb_ResltR0C9.Name = "lb_ResltR0C9"
        Me.lb_ResltR0C9.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR0C9.TabIndex = 168
        Me.lb_ResltR0C9.Text = "99999999.999"
        Me.lb_ResltR0C9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label79
        '
        Me.Label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label79.Location = New System.Drawing.Point(902, 554)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(87, 30)
        Me.Label79.TabIndex = 179
        Me.Label79.Text = "方位(度）"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C11
        '
        Me.lb_ResltR6C11.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C11.Location = New System.Drawing.Point(898, 750)
        Me.lb_ResltR6C11.Name = "lb_ResltR6C11"
        Me.lb_ResltR6C11.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR6C11.TabIndex = 178
        Me.lb_ResltR6C11.Text = "99999999.999"
        Me.lb_ResltR6C11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C11
        '
        Me.lb_ResltR5C11.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C11.Location = New System.Drawing.Point(898, 718)
        Me.lb_ResltR5C11.Name = "lb_ResltR5C11"
        Me.lb_ResltR5C11.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR5C11.TabIndex = 177
        Me.lb_ResltR5C11.Text = "99999999.999"
        Me.lb_ResltR5C11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C11
        '
        Me.lb_ResltR4C11.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C11.Location = New System.Drawing.Point(898, 689)
        Me.lb_ResltR4C11.Name = "lb_ResltR4C11"
        Me.lb_ResltR4C11.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR4C11.TabIndex = 176
        Me.lb_ResltR4C11.Text = "99999999.999"
        Me.lb_ResltR4C11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C11
        '
        Me.lb_ResltR3C11.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C11.Location = New System.Drawing.Point(898, 654)
        Me.lb_ResltR3C11.Name = "lb_ResltR3C11"
        Me.lb_ResltR3C11.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR3C11.TabIndex = 175
        Me.lb_ResltR3C11.Text = "99999999.999"
        Me.lb_ResltR3C11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C11
        '
        Me.lb_ResltR0C11.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C11.Location = New System.Drawing.Point(898, 593)
        Me.lb_ResltR0C11.Name = "lb_ResltR0C11"
        Me.lb_ResltR0C11.Size = New System.Drawing.Size(91, 19)
        Me.lb_ResltR0C11.TabIndex = 174
        Me.lb_ResltR0C11.Text = "99999999.999"
        Me.lb_ResltR0C11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label85
        '
        Me.Label85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label85.Location = New System.Drawing.Point(992, 554)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(48, 30)
        Me.Label85.TabIndex = 185
        Me.Label85.Text = "偏差(mm)"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C20
        '
        Me.lb_ResltR6C20.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C20.Location = New System.Drawing.Point(988, 750)
        Me.lb_ResltR6C20.Name = "lb_ResltR6C20"
        Me.lb_ResltR6C20.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR6C20.TabIndex = 184
        Me.lb_ResltR6C20.Text = "999"
        Me.lb_ResltR6C20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C20
        '
        Me.lb_ResltR5C20.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C20.Location = New System.Drawing.Point(988, 718)
        Me.lb_ResltR5C20.Name = "lb_ResltR5C20"
        Me.lb_ResltR5C20.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR5C20.TabIndex = 183
        Me.lb_ResltR5C20.Text = "999"
        Me.lb_ResltR5C20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C20
        '
        Me.lb_ResltR4C20.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C20.Location = New System.Drawing.Point(988, 689)
        Me.lb_ResltR4C20.Name = "lb_ResltR4C20"
        Me.lb_ResltR4C20.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR4C20.TabIndex = 182
        Me.lb_ResltR4C20.Text = "999"
        Me.lb_ResltR4C20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C20
        '
        Me.lb_ResltR3C20.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C20.Location = New System.Drawing.Point(988, 654)
        Me.lb_ResltR3C20.Name = "lb_ResltR3C20"
        Me.lb_ResltR3C20.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR3C20.TabIndex = 181
        Me.lb_ResltR3C20.Text = "999"
        Me.lb_ResltR3C20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C20
        '
        Me.lb_ResltR0C20.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C20.Location = New System.Drawing.Point(988, 593)
        Me.lb_ResltR0C20.Name = "lb_ResltR0C20"
        Me.lb_ResltR0C20.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR0C20.TabIndex = 180
        Me.lb_ResltR0C20.Text = "999"
        Me.lb_ResltR0C20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label91
        '
        Me.Label91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label91.Location = New System.Drawing.Point(1133, 554)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(48, 30)
        Me.Label91.TabIndex = 197
        Me.Label91.Text = "偏差(mm)"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C35
        '
        Me.lb_ResltR6C35.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C35.Location = New System.Drawing.Point(1129, 750)
        Me.lb_ResltR6C35.Name = "lb_ResltR6C35"
        Me.lb_ResltR6C35.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR6C35.TabIndex = 196
        Me.lb_ResltR6C35.Text = "999"
        Me.lb_ResltR6C35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C35
        '
        Me.lb_ResltR5C35.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C35.Location = New System.Drawing.Point(1129, 718)
        Me.lb_ResltR5C35.Name = "lb_ResltR5C35"
        Me.lb_ResltR5C35.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR5C35.TabIndex = 195
        Me.lb_ResltR5C35.Text = "999"
        Me.lb_ResltR5C35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C35
        '
        Me.lb_ResltR4C35.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C35.Location = New System.Drawing.Point(1129, 689)
        Me.lb_ResltR4C35.Name = "lb_ResltR4C35"
        Me.lb_ResltR4C35.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR4C35.TabIndex = 194
        Me.lb_ResltR4C35.Text = "999"
        Me.lb_ResltR4C35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C35
        '
        Me.lb_ResltR3C35.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C35.Location = New System.Drawing.Point(1129, 654)
        Me.lb_ResltR3C35.Name = "lb_ResltR3C35"
        Me.lb_ResltR3C35.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR3C35.TabIndex = 193
        Me.lb_ResltR3C35.Text = "999"
        Me.lb_ResltR3C35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C35
        '
        Me.lb_ResltR0C35.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C35.Location = New System.Drawing.Point(1129, 593)
        Me.lb_ResltR0C35.Name = "lb_ResltR0C35"
        Me.lb_ResltR0C35.Size = New System.Drawing.Size(52, 19)
        Me.lb_ResltR0C35.TabIndex = 192
        Me.lb_ResltR0C35.Text = "999"
        Me.lb_ResltR0C35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label97
        '
        Me.Label97.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label97.Location = New System.Drawing.Point(1067, 554)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(65, 30)
        Me.Label97.TabIndex = 191
        Me.Label97.Text = "勾配(度）"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ResltR6C33
        '
        Me.lb_ResltR6C33.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR6C33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR6C33.Location = New System.Drawing.Point(1063, 750)
        Me.lb_ResltR6C33.Name = "lb_ResltR6C33"
        Me.lb_ResltR6C33.Size = New System.Drawing.Size(69, 19)
        Me.lb_ResltR6C33.TabIndex = 190
        Me.lb_ResltR6C33.Text = "99.999"
        Me.lb_ResltR6C33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR5C33
        '
        Me.lb_ResltR5C33.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR5C33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR5C33.Location = New System.Drawing.Point(1063, 718)
        Me.lb_ResltR5C33.Name = "lb_ResltR5C33"
        Me.lb_ResltR5C33.Size = New System.Drawing.Size(69, 19)
        Me.lb_ResltR5C33.TabIndex = 189
        Me.lb_ResltR5C33.Text = "99.999"
        Me.lb_ResltR5C33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR4C33
        '
        Me.lb_ResltR4C33.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR4C33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR4C33.Location = New System.Drawing.Point(1063, 689)
        Me.lb_ResltR4C33.Name = "lb_ResltR4C33"
        Me.lb_ResltR4C33.Size = New System.Drawing.Size(69, 19)
        Me.lb_ResltR4C33.TabIndex = 188
        Me.lb_ResltR4C33.Text = "99.999"
        Me.lb_ResltR4C33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR3C33
        '
        Me.lb_ResltR3C33.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR3C33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR3C33.Location = New System.Drawing.Point(1063, 654)
        Me.lb_ResltR3C33.Name = "lb_ResltR3C33"
        Me.lb_ResltR3C33.Size = New System.Drawing.Size(69, 19)
        Me.lb_ResltR3C33.TabIndex = 187
        Me.lb_ResltR3C33.Text = "99.999"
        Me.lb_ResltR3C33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_ResltR0C33
        '
        Me.lb_ResltR0C33.BackColor = System.Drawing.SystemColors.Window
        Me.lb_ResltR0C33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_ResltR0C33.Location = New System.Drawing.Point(1063, 593)
        Me.lb_ResltR0C33.Name = "lb_ResltR0C33"
        Me.lb_ResltR0C33.Size = New System.Drawing.Size(69, 19)
        Me.lb_ResltR0C33.TabIndex = 186
        Me.lb_ResltR0C33.Text = "99.999"
        Me.lb_ResltR0C33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label103
        '
        Me.Label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label103.Location = New System.Drawing.Point(510, 529)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(530, 25)
        Me.Label103.TabIndex = 198
        Me.Label103.Text = "平面計画線"
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label104
        '
        Me.Label104.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label104.Location = New System.Drawing.Point(1067, 529)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(114, 25)
        Me.Label104.TabIndex = 199
        Me.Label104.Text = "縦断計画線"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.SystemColors.Control
        Me.Label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label105.ForeColor = System.Drawing.Color.Red
        Me.Label105.Location = New System.Drawing.Point(841, 390)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(39, 19)
        Me.Label105.TabIndex = 207
        Me.Label105.Text = "T"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label106
        '
        Me.Label106.BackColor = System.Drawing.SystemColors.Control
        Me.Label106.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label106.ForeColor = System.Drawing.Color.Red
        Me.Label106.Location = New System.Drawing.Point(731, 390)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(104, 19)
        Me.Label106.TabIndex = 206
        Me.Label106.Text = "ターゲット"
        Me.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label107
        '
        Me.Label107.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label107.Location = New System.Drawing.Point(1098, 351)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(104, 30)
        Me.Label107.TabIndex = 205
        Me.Label107.Text = "Z座標(m)"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label108
        '
        Me.Label108.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label108.Location = New System.Drawing.Point(992, 351)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(104, 30)
        Me.Label108.TabIndex = 204
        Me.Label108.Text = "Y座標(m)　"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label109
        '
        Me.Label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label109.Location = New System.Drawing.Point(890, 351)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(104, 30)
        Me.Label109.TabIndex = 203
        Me.Label109.Text = "X座標(m)　"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_TgmZ
        '
        Me.lb_TgmZ.BackColor = System.Drawing.SystemColors.Window
        Me.lb_TgmZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_TgmZ.Location = New System.Drawing.Point(1098, 390)
        Me.lb_TgmZ.Name = "lb_TgmZ"
        Me.lb_TgmZ.Size = New System.Drawing.Size(108, 19)
        Me.lb_TgmZ.TabIndex = 202
        Me.lb_TgmZ.Text = "99999999.999"
        Me.lb_TgmZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_TgmY
        '
        Me.lb_TgmY.BackColor = System.Drawing.SystemColors.Window
        Me.lb_TgmY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_TgmY.Location = New System.Drawing.Point(992, 390)
        Me.lb_TgmY.Name = "lb_TgmY"
        Me.lb_TgmY.Size = New System.Drawing.Size(108, 19)
        Me.lb_TgmY.TabIndex = 201
        Me.lb_TgmY.Text = "99999999.999"
        Me.lb_TgmY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_TgmX
        '
        Me.lb_TgmX.BackColor = System.Drawing.SystemColors.Window
        Me.lb_TgmX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_TgmX.Location = New System.Drawing.Point(886, 390)
        Me.lb_TgmX.Name = "lb_TgmX"
        Me.lb_TgmX.Size = New System.Drawing.Size(108, 19)
        Me.lb_TgmX.TabIndex = 200
        Me.lb_TgmX.Text = "99999999.999"
        Me.lb_TgmX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label113
        '
        Me.Label113.BackColor = System.Drawing.SystemColors.Control
        Me.Label113.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label113.ForeColor = System.Drawing.Color.Red
        Me.Label113.Location = New System.Drawing.Point(756, 362)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(104, 19)
        Me.Label113.TabIndex = 208
        Me.Label113.Text = "m座標系"
        Me.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(778, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 23)
        Me.Button2.TabIndex = 209
        Me.Button2.Text = "EXCEL マクロ実行"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lb_PlcComDate
        '
        Me.lb_PlcComDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_PlcComDate.Location = New System.Drawing.Point(1062, 9)
        Me.lb_PlcComDate.Name = "lb_PlcComDate"
        Me.lb_PlcComDate.Size = New System.Drawing.Size(162, 25)
        Me.lb_PlcComDate.TabIndex = 210
        Me.lb_PlcComDate.Text = "yyyy/mm/dd hh:mm:ss"
        Me.lb_PlcComDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 805)
        Me.Controls.Add(Me.lb_PlcComDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label113)
        Me.Controls.Add(Me.Label105)
        Me.Controls.Add(Me.Label106)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.lb_TgmZ)
        Me.Controls.Add(Me.lb_TgmY)
        Me.Controls.Add(Me.lb_TgmX)
        Me.Controls.Add(Me.Label104)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.Label91)
        Me.Controls.Add(Me.lb_ResltR6C35)
        Me.Controls.Add(Me.lb_ResltR5C35)
        Me.Controls.Add(Me.lb_ResltR4C35)
        Me.Controls.Add(Me.lb_ResltR3C35)
        Me.Controls.Add(Me.lb_ResltR0C35)
        Me.Controls.Add(Me.Label97)
        Me.Controls.Add(Me.lb_ResltR6C33)
        Me.Controls.Add(Me.lb_ResltR5C33)
        Me.Controls.Add(Me.lb_ResltR4C33)
        Me.Controls.Add(Me.lb_ResltR3C33)
        Me.Controls.Add(Me.lb_ResltR0C33)
        Me.Controls.Add(Me.Label85)
        Me.Controls.Add(Me.lb_ResltR6C20)
        Me.Controls.Add(Me.lb_ResltR5C20)
        Me.Controls.Add(Me.lb_ResltR4C20)
        Me.Controls.Add(Me.lb_ResltR3C20)
        Me.Controls.Add(Me.lb_ResltR0C20)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.lb_ResltR6C11)
        Me.Controls.Add(Me.lb_ResltR5C11)
        Me.Controls.Add(Me.lb_ResltR4C11)
        Me.Controls.Add(Me.lb_ResltR3C11)
        Me.Controls.Add(Me.lb_ResltR0C11)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.lb_ResltR6C9)
        Me.Controls.Add(Me.lb_ResltR5C9)
        Me.Controls.Add(Me.lb_ResltR4C9)
        Me.Controls.Add(Me.lb_ResltR3C9)
        Me.Controls.Add(Me.lb_ResltR0C9)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.lb_ResltR6C8)
        Me.Controls.Add(Me.lb_ResltR5C8)
        Me.Controls.Add(Me.lb_ResltR4C8)
        Me.Controls.Add(Me.lb_ResltR3C8)
        Me.Controls.Add(Me.lb_ResltR0C8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lb_ResltR6C7)
        Me.Controls.Add(Me.lb_ResltR6C6)
        Me.Controls.Add(Me.lb_ResltR6C4)
        Me.Controls.Add(Me.lb_ResltR5C7)
        Me.Controls.Add(Me.lb_ResltR5C6)
        Me.Controls.Add(Me.lb_ResltR5C4)
        Me.Controls.Add(Me.lb_ResltR4C7)
        Me.Controls.Add(Me.lb_ResltR4C6)
        Me.Controls.Add(Me.lb_ResltR4C4)
        Me.Controls.Add(Me.lb_ResltR3C7)
        Me.Controls.Add(Me.lb_ResltR3C6)
        Me.Controls.Add(Me.lb_ResltR3C4)
        Me.Controls.Add(Me.lb_ResltR0C7)
        Me.Controls.Add(Me.lb_ResltR0C6)
        Me.Controls.Add(Me.lb_ResltR0C4)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lb_ResltR6C2)
        Me.Controls.Add(Me.lb_ResltR6C1)
        Me.Controls.Add(Me.lb_ResltR6C0)
        Me.Controls.Add(Me.lb_ResltR5C2)
        Me.Controls.Add(Me.lb_ResltR5C1)
        Me.Controls.Add(Me.lb_ResltR5C0)
        Me.Controls.Add(Me.lb_ResltR4C2)
        Me.Controls.Add(Me.lb_ResltR4C1)
        Me.Controls.Add(Me.lb_ResltR4C0)
        Me.Controls.Add(Me.lb_ResltR3C2)
        Me.Controls.Add(Me.lb_ResltR3C1)
        Me.Controls.Add(Me.lb_ResltR3C0)
        Me.Controls.Add(Me.lb_ResltR0C2)
        Me.Controls.Add(Me.lb_ResltR0C1)
        Me.Controls.Add(Me.lb_ResltR0C0)
        Me.Controls.Add(Me.lb_ExecSts)
        Me.Controls.Add(Me.lb_NkUD)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lb_NkLR)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lb_NkRDSt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lb_NkRUSt)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lb_NkLDSt)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lb_NkLUSt)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lb_rrRolling)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lb_rrPitch)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lb_frPitch)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lb_rrDir)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lb_frDir)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lb_RealSt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lb_RinNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cb_safe)
        Me.Controls.Add(Me.Lb_rtry)
        Me.Controls.Add(Me.Tb_rtry)
        Me.Controls.Add(Me.Tb_rtcnt)
        Me.Controls.Add(Me.Bt_Lzoff)
        Me.Controls.Add(Me.Bt_Lzon)
        Me.Controls.Add(Me.Bt_Troff)
        Me.Controls.Add(Me.Bt_Tron)
        Me.Controls.Add(Me.Bt_SetAng)
        Me.Controls.Add(Me.Tb_Shs)
        Me.Controls.Add(Me.Tb_Shm)
        Me.Controls.Add(Me.Tb_Shd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bt_circlerl)
        Me.Controls.Add(Me.Bt_circleab)
        Me.Controls.Add(Me.Tb_hos)
        Me.Controls.Add(Me.Tb_hom)
        Me.Controls.Add(Me.Tb_hod)
        Me.Controls.Add(Me.Lb_ho)
        Me.Controls.Add(Me.Tb_vos)
        Me.Controls.Add(Me.Tb_vom)
        Me.Controls.Add(Me.Tb_vod)
        Me.Controls.Add(Me.Lb_vo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bt_stop)
        Me.Controls.Add(Me.Bt_Weit)
        Me.Controls.Add(Me.Tb_count)
        Me.Controls.Add(Me.Bt_serch)
        Me.Controls.Add(Me.Lb_interval)
        Me.Controls.Add(Me.Tb_interval)
        Me.Controls.Add(Me.Bt_Crs1)
        Me.Controls.Add(Me.Lb_prism)
        Me.Controls.Add(Me.Tb_prism)
        Me.Controls.Add(Me.Lb_weath)
        Me.Controls.Add(Me.Lb_light)
        Me.Controls.Add(Me.Tb_weath)
        Me.Controls.Add(Me.Tb_light)
        Me.Controls.Add(Me.Lb_vl)
        Me.Controls.Add(Me.Tb_vl)
        Me.Controls.Add(Me.Tb_hl)
        Me.Controls.Add(Me.Lb_hl)
        Me.Controls.Add(Me.Tb_sl)
        Me.Controls.Add(Me.Lb_sl)
        Me.Controls.Add(Me.Lb_th)
        Me.Controls.Add(Me.Tb_th)
        Me.Controls.Add(Me.Lb_fac)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lb_sea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tb_fac)
        Me.Controls.Add(Me.Tb_waititv)
        Me.Controls.Add(Me.Tb_wait)
        Me.Controls.Add(Me.Tb_sea)
        Me.Controls.Add(Me.Tb_edm)
        Me.Controls.Add(Me.Lb_edm)
        Me.Controls.Add(Me.Lb_batt)
        Me.Controls.Add(Me.Tb_batt)
        Me.Controls.Add(Me.Tb_ts)
        Me.Controls.Add(Me.Tb_tm)
        Me.Controls.Add(Me.Lb_til)
        Me.Controls.Add(Me.Tb_has)
        Me.Controls.Add(Me.Tb_ham)
        Me.Controls.Add(Me.Tb_had)
        Me.Controls.Add(Me.Lb_hd)
        Me.Controls.Add(Me.Tb_vas)
        Me.Controls.Add(Me.Tb_vam)
        Me.Controls.Add(Me.Tb_vad)
        Me.Controls.Add(Me.Lb_vd)
        Me.Controls.Add(Me.Bt_Fine)
        Me.Controls.Add(Me.Bt_Endmes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Sendmes)
        Me.Controls.Add(Me.EraseButton)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "TSコントロール Ver1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EraseButton As Button
    Friend WithEvents Bt_Sendmes As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Tm_Protocol As Timer
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Bt_Endmes As Button
    Friend WithEvents Bt_Fine As Button
    Friend WithEvents Lb_vd As Label
    Friend WithEvents Tb_vad As TextBox
    Friend WithEvents Tb_vam As TextBox
    Friend WithEvents Tb_vas As TextBox
    Friend WithEvents Tb_has As TextBox
    Friend WithEvents Tb_ham As TextBox
    Friend WithEvents Tb_had As TextBox
    Friend WithEvents Lb_hd As Label
    Friend WithEvents Tb_ts As TextBox
    Friend WithEvents Tb_tm As TextBox
    Friend WithEvents Lb_til As Label
    Friend WithEvents Tb_batt As TextBox
    Friend WithEvents Lb_batt As Label
    Friend WithEvents Lb_edm As Label
    Friend WithEvents Tb_edm As TextBox
    Friend WithEvents Tb_sea As TextBox
    Friend WithEvents Tb_fac As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_sea As Label
    Friend WithEvents Lb_fac As Label
    Friend WithEvents Lb_th As Label
    Friend WithEvents Tb_th As TextBox
    Friend WithEvents Lb_sl As Label
    Friend WithEvents Tb_sl As TextBox
    Friend WithEvents Lb_hl As Label
    Friend WithEvents Tb_hl As TextBox
    Friend WithEvents Tb_vl As TextBox
    Friend WithEvents Lb_vl As Label
    Friend WithEvents Lb_prism As Label
    Friend WithEvents Tb_prism As TextBox
    Friend WithEvents Lb_weath As Label
    Friend WithEvents Lb_light As Label
    Friend WithEvents Tb_weath As TextBox
    Friend WithEvents Tb_light As TextBox
    Friend WithEvents Tm_Interval As Timer
    Friend WithEvents Bt_Crs1 As Button
    Friend WithEvents Tb_interval As TextBox
    Friend WithEvents Lb_interval As Label
    Friend WithEvents Bt_serch As Button
    Friend WithEvents Tb_count As TextBox
    Friend WithEvents Bt_Weit As Button
    Friend WithEvents Label4 As Label
    Private WithEvents Bt_stop As Button
    Friend WithEvents Tb_hos As TextBox
    Friend WithEvents Tb_hom As TextBox
    Friend WithEvents Tb_hod As TextBox
    Friend WithEvents Lb_ho As Label
    Friend WithEvents Tb_vos As TextBox
    Friend WithEvents Tb_vom As TextBox
    Friend WithEvents Tb_vod As TextBox
    Friend WithEvents Lb_vo As Label
    Friend WithEvents Bt_circleab As Button
    Friend WithEvents Bt_circlerl As Button
    Friend WithEvents Tb_Shs As TextBox
    Friend WithEvents Tb_Shm As TextBox
    Friend WithEvents Tb_Shd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Bt_SetAng As Button
    Private WithEvents Bt_Tron As Button
    Private WithEvents Bt_Troff As Button
    Private WithEvents Bt_Lzoff As Button
    Private WithEvents Bt_Lzon As Button
    Friend WithEvents Tb_rtcnt As TextBox
    Friend WithEvents Tm_Search As Timer
    Friend WithEvents Lb_rtry As Label
    Friend WithEvents Tb_rtry As TextBox
    Friend WithEvents Cb_safe As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tb_wait As TextBox
    Friend WithEvents Tb_waititv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_RinNo As Label
    Friend WithEvents lb_RealSt As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lb_frDir As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lb_rrDir As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lb_rrPitch As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lb_frPitch As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lb_rrRolling As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lb_NkRDSt As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lb_NkRUSt As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lb_NkLDSt As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lb_NkLUSt As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lb_NkUD As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lb_NkLR As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lb_ExecSts As Label
    Friend WithEvents Tm_PlcCom As Timer
    Friend WithEvents lb_ResltR0C0 As Label
    Friend WithEvents lb_ResltR0C1 As Label
    Friend WithEvents lb_ResltR0C2 As Label
    Friend WithEvents lb_ResltR3C2 As Label
    Friend WithEvents lb_ResltR3C1 As Label
    Friend WithEvents lb_ResltR3C0 As Label
    Friend WithEvents lb_ResltR6C2 As Label
    Friend WithEvents lb_ResltR6C1 As Label
    Friend WithEvents lb_ResltR6C0 As Label
    Friend WithEvents lb_ResltR5C2 As Label
    Friend WithEvents lb_ResltR5C1 As Label
    Friend WithEvents lb_ResltR5C0 As Label
    Friend WithEvents lb_ResltR4C2 As Label
    Friend WithEvents lb_ResltR4C1 As Label
    Friend WithEvents lb_ResltR4C0 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lb_ResltR6C7 As Label
    Friend WithEvents lb_ResltR6C6 As Label
    Friend WithEvents lb_ResltR6C4 As Label
    Friend WithEvents lb_ResltR5C7 As Label
    Friend WithEvents lb_ResltR5C6 As Label
    Friend WithEvents lb_ResltR5C4 As Label
    Friend WithEvents lb_ResltR4C7 As Label
    Friend WithEvents lb_ResltR4C6 As Label
    Friend WithEvents lb_ResltR4C4 As Label
    Friend WithEvents lb_ResltR3C7 As Label
    Friend WithEvents lb_ResltR3C6 As Label
    Friend WithEvents lb_ResltR3C4 As Label
    Friend WithEvents lb_ResltR0C7 As Label
    Friend WithEvents lb_ResltR0C6 As Label
    Friend WithEvents lb_ResltR0C4 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents lb_ResltR6C8 As Label
    Friend WithEvents lb_ResltR5C8 As Label
    Friend WithEvents lb_ResltR4C8 As Label
    Friend WithEvents lb_ResltR3C8 As Label
    Friend WithEvents lb_ResltR0C8 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents lb_ResltR6C9 As Label
    Friend WithEvents lb_ResltR5C9 As Label
    Friend WithEvents lb_ResltR4C9 As Label
    Friend WithEvents lb_ResltR3C9 As Label
    Friend WithEvents lb_ResltR0C9 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents lb_ResltR6C11 As Label
    Friend WithEvents lb_ResltR5C11 As Label
    Friend WithEvents lb_ResltR4C11 As Label
    Friend WithEvents lb_ResltR3C11 As Label
    Friend WithEvents lb_ResltR0C11 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents lb_ResltR6C20 As Label
    Friend WithEvents lb_ResltR5C20 As Label
    Friend WithEvents lb_ResltR4C20 As Label
    Friend WithEvents lb_ResltR3C20 As Label
    Friend WithEvents lb_ResltR0C20 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents lb_ResltR6C35 As Label
    Friend WithEvents lb_ResltR5C35 As Label
    Friend WithEvents lb_ResltR4C35 As Label
    Friend WithEvents lb_ResltR3C35 As Label
    Friend WithEvents lb_ResltR0C35 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents lb_ResltR6C33 As Label
    Friend WithEvents lb_ResltR5C33 As Label
    Friend WithEvents lb_ResltR4C33 As Label
    Friend WithEvents lb_ResltR3C33 As Label
    Friend WithEvents lb_ResltR0C33 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents lb_TgmZ As Label
    Friend WithEvents lb_TgmY As Label
    Friend WithEvents lb_TgmX As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lb_PlcComDate As Label
End Class
