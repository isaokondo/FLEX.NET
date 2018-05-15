<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHorPlanData
    Inherits frmPlanView

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
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.lblStartX = New System.Windows.Forms.Label()
        Me.lblStartY = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStartDir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDepartY = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartX = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblReachDir = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblReachY = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblReachX = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(1221, 152)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1085, 673)
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.SystemColors.Control
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(27, 19)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(137, 19)
        Me.lblFieldName.TabIndex = 10
        Me.lblFieldName.Text = "起点X座標(m)"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartX
        '
        Me.lblStartX.BackColor = System.Drawing.Color.White
        Me.lblStartX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStartX.Location = New System.Drawing.Point(165, 19)
        Me.lblStartX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStartX.Name = "lblStartX"
        Me.lblStartX.Size = New System.Drawing.Size(107, 19)
        Me.lblStartX.TabIndex = 11
        Me.lblStartX.Text = "-32353.0934"
        Me.lblStartX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStartY
        '
        Me.lblStartY.BackColor = System.Drawing.Color.White
        Me.lblStartY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStartY.Location = New System.Drawing.Point(165, 38)
        Me.lblStartY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStartY.Name = "lblStartY"
        Me.lblStartY.Size = New System.Drawing.Size(107, 19)
        Me.lblStartY.TabIndex = 13
        Me.lblStartY.Text = "-32353.0934"
        Me.lblStartY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "起点Ｙ座標(m)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartDir
        '
        Me.lblStartDir.BackColor = System.Drawing.Color.White
        Me.lblStartDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartDir.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStartDir.Location = New System.Drawing.Point(165, 57)
        Me.lblStartDir.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStartDir.Name = "lblStartDir"
        Me.lblStartDir.Size = New System.Drawing.Size(107, 19)
        Me.lblStartDir.TabIndex = 15
        Me.lblStartDir.Text = "-32353.0934"
        Me.lblStartDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "起点方位角(°)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartY
        '
        Me.lblDepartY.BackColor = System.Drawing.Color.White
        Me.lblDepartY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDepartY.Location = New System.Drawing.Point(165, 99)
        Me.lblDepartY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDepartY.Name = "lblDepartY"
        Me.lblDepartY.Size = New System.Drawing.Size(107, 19)
        Me.lblDepartY.TabIndex = 19
        Me.lblDepartY.Text = "-32353.0934"
        Me.lblDepartY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 99)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "発進Ｙ座標(m)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartX
        '
        Me.lblDepartX.BackColor = System.Drawing.Color.White
        Me.lblDepartX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDepartX.Location = New System.Drawing.Point(165, 80)
        Me.lblDepartX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDepartX.Name = "lblDepartX"
        Me.lblDepartX.Size = New System.Drawing.Size(107, 19)
        Me.lblDepartX.TabIndex = 17
        Me.lblDepartX.Text = "-32353.0934"
        Me.lblDepartX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "発進X座標(m)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReachDir
        '
        Me.lblReachDir.BackColor = System.Drawing.Color.White
        Me.lblReachDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReachDir.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReachDir.Location = New System.Drawing.Point(165, 160)
        Me.lblReachDir.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReachDir.Name = "lblReachDir"
        Me.lblReachDir.Size = New System.Drawing.Size(107, 19)
        Me.lblReachDir.TabIndex = 25
        Me.lblReachDir.Text = "-32353.0934"
        Me.lblReachDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 19)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "到達方位角(°)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReachY
        '
        Me.lblReachY.BackColor = System.Drawing.Color.White
        Me.lblReachY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReachY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReachY.Location = New System.Drawing.Point(165, 141)
        Me.lblReachY.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReachY.Name = "lblReachY"
        Me.lblReachY.Size = New System.Drawing.Size(107, 19)
        Me.lblReachY.TabIndex = 23
        Me.lblReachY.Text = "-32353.0934"
        Me.lblReachY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 141)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "到達Ｙ座標(m)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReachX
        '
        Me.lblReachX.BackColor = System.Drawing.Color.White
        Me.lblReachX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReachX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReachX.Location = New System.Drawing.Point(165, 122)
        Me.lblReachX.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReachX.Name = "lblReachX"
        Me.lblReachX.Size = New System.Drawing.Size(107, 19)
        Me.lblReachX.TabIndex = 21
        Me.lblReachX.Text = "-32353.0934"
        Me.lblReachX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(27, 122)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "到達Ｘ座標(m)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHorPlanData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 719)
        Me.Controls.Add(Me.lblReachDir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblReachY)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblReachX)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblDepartY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblDepartX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblStartDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStartY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStartX)
        Me.Controls.Add(Me.lblFieldName)
        Me.Name = "frmHorPlanData"
        Me.Text = "平面掘進計画路線"
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.Controls.SetChildIndex(Me.lblStartX, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblStartY, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.lblStartDir, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.lblDepartX, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.lblDepartY, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.lblReachX, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.lblReachY, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.lblReachDir, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFieldName As Label
    Friend WithEvents lblStartX As Label
    Friend WithEvents lblStartY As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStartDir As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDepartY As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDepartX As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblReachDir As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblReachY As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblReachX As Label
    Friend WithEvents Label15 As Label
End Class
