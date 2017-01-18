<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerPlanData
    Inherits frmPlanView

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
        Me.lblReachZ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStartSlope = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStartZ = New System.Windows.Forms.Label()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.lblReachSlope = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(1230, 631)
        '
        'lblReachZ
        '
        Me.lblReachZ.BackColor = System.Drawing.Color.White
        Me.lblReachZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReachZ.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReachZ.Location = New System.Drawing.Point(203, 79)
        Me.lblReachZ.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReachZ.Name = "lblReachZ"
        Me.lblReachZ.Size = New System.Drawing.Size(107, 19)
        Me.lblReachZ.TabIndex = 21
        Me.lblReachZ.Text = "-32353.0934"
        Me.lblReachZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "終点Ｚ座標"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartSlope
        '
        Me.lblStartSlope.BackColor = System.Drawing.Color.White
        Me.lblStartSlope.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartSlope.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStartSlope.Location = New System.Drawing.Point(203, 60)
        Me.lblStartSlope.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStartSlope.Name = "lblStartSlope"
        Me.lblStartSlope.Size = New System.Drawing.Size(107, 19)
        Me.lblStartSlope.TabIndex = 19
        Me.lblStartSlope.Text = "-32353.0934"
        Me.lblStartSlope.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "起点勾配"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartZ
        '
        Me.lblStartZ.BackColor = System.Drawing.Color.White
        Me.lblStartZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartZ.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblStartZ.Location = New System.Drawing.Point(203, 41)
        Me.lblStartZ.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblStartZ.Name = "lblStartZ"
        Me.lblStartZ.Size = New System.Drawing.Size(107, 19)
        Me.lblStartZ.TabIndex = 17
        Me.lblStartZ.Text = "-32353.0934"
        Me.lblStartZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.SystemColors.Control
        Me.lblFieldName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(65, 41)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(137, 19)
        Me.lblFieldName.TabIndex = 16
        Me.lblFieldName.Text = "起点Ｚ座標"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReachSlope
        '
        Me.lblReachSlope.BackColor = System.Drawing.Color.White
        Me.lblReachSlope.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReachSlope.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReachSlope.Location = New System.Drawing.Point(203, 98)
        Me.lblReachSlope.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblReachSlope.Name = "lblReachSlope"
        Me.lblReachSlope.Size = New System.Drawing.Size(107, 19)
        Me.lblReachSlope.TabIndex = 23
        Me.lblReachSlope.Text = "-32353.0934"
        Me.lblReachSlope.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "終点勾配"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVerPlanData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1393, 672)
        Me.Controls.Add(Me.lblReachSlope)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReachZ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStartSlope)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStartZ)
        Me.Controls.Add(Me.lblFieldName)
        Me.Name = "frmVerPlanData"
        Me.Text = "縦断計画路線"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblFieldName, 0)
        Me.Controls.SetChildIndex(Me.lblStartZ, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblStartSlope, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.lblReachZ, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.lblReachSlope, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblReachZ As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStartSlope As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStartZ As Label
    Friend WithEvents lblFieldName As Label
    Friend WithEvents lblReachSlope As Label
    Friend WithEvents Label2 As Label
End Class
