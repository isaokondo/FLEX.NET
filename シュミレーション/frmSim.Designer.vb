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
        CType(Me.nudSoucePressure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLeftStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRightStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRightSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLeftSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlcWR
        '
        '
        'chkExcavOn
        '
        Me.chkExcavOn.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.chkExcavOn.Location = New System.Drawing.Point(390, 304)
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
        Me.chkFlexOn.Location = New System.Drawing.Point(390, 334)
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
        'frmSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(975, 869)
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
End Class
