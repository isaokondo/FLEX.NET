<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnNumEdit
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.numUD = New System.Windows.Forms.NumericUpDown()
        Me.lblFieldName = New System.Windows.Forms.Label()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.numUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUnit
        '
        Me.lblUnit.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUnit.ForeColor = System.Drawing.Color.White
        Me.lblUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnit.Location = New System.Drawing.Point(115, 3)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(75, 30)
        Me.lblUnit.TabIndex = 6
        Me.lblUnit.Text = "リング"
        '
        'numUD
        '
        Me.numUD.BackColor = System.Drawing.Color.Black
        Me.numUD.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.numUD.ForeColor = System.Drawing.Color.White
        Me.numUD.Location = New System.Drawing.Point(2, 2)
        Me.numUD.Margin = New System.Windows.Forms.Padding(2)
        Me.numUD.Name = "numUD"
        Me.numUD.Size = New System.Drawing.Size(107, 26)
        Me.numUD.TabIndex = 5
        Me.numUD.TabStop = False
        Me.numUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFieldName
        '
        Me.lblFieldName.BackColor = System.Drawing.Color.White
        Me.lblFieldName.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFieldName.Location = New System.Drawing.Point(1, 37)
        Me.lblFieldName.Margin = New System.Windows.Forms.Padding(1, 0, 4, 0)
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Size = New System.Drawing.Size(225, 26)
        Me.lblFieldName.TabIndex = 8
        Me.lblFieldName.Text = "ストロークの取得方法"
        Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFieldName.Visible = False
        '
        'ComboBox
        '
        Me.ComboBox.BackColor = System.Drawing.Color.Black
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox.ForeColor = System.Drawing.Color.White
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(170, 2)
        Me.ComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(150, 27)
        Me.ComboBox.TabIndex = 9
        Me.ComboBox.Visible = False
        '
        'ucnNumEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.numUD)
        Me.Controls.Add(Me.lblFieldName)
        Me.Controls.Add(Me.lblUnit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ucnNumEdit"
        Me.Size = New System.Drawing.Size(321, 113)
        CType(Me.numUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Public WithEvents ComboBox As ComboBox
    Public WithEvents lblFieldName As Label
    Friend WithEvents numUD As NumericUpDown
End Class
