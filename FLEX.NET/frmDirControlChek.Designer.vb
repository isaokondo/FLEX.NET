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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(1350, 627)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeight = 46
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(65, 136)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowTemplate.Height = 18
        Me.dgv.RowTemplate.ReadOnly = True
        Me.dgv.ShowCellErrors = False
        Me.dgv.Size = New System.Drawing.Size(1267, 486)
        Me.dgv.TabIndex = 35
        '
        'btnMomentOptimize
        '
        Me.btnMomentOptimize.BackColor = System.Drawing.Color.DarkGray
        Me.btnMomentOptimize.Location = New System.Drawing.Point(65, 51)
        Me.btnMomentOptimize.Name = "btnMomentOptimize"
        Me.btnMomentOptimize.Size = New System.Drawing.Size(108, 38)
        Me.btnMomentOptimize.TabIndex = 36
        Me.btnMomentOptimize.Text = "モーメント最適化"
        Me.btnMomentOptimize.UseVisualStyleBackColor = False
        '
        'frmDirControlChek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1463, 673)
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
        Me.Controls.SetChildIndex(Me.btnOK, 0)
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
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
