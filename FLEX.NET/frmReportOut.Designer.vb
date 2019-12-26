<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportOut
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
        Me.cmbRingSel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvReportItemSet = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintOutItem = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.gpxPtnSelect = New System.Windows.Forms.GroupBox()
        Me.rtnPt3 = New System.Windows.Forms.RadioButton()
        Me.rtnPt2 = New System.Windows.Forms.RadioButton()
        Me.rtnPt1 = New System.Windows.Forms.RadioButton()
        Me.btnPrintOut = New System.Windows.Forms.Button()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpxAutoPrtPtn = New System.Windows.Forms.GroupBox()
        Me.cbxPtn3 = New System.Windows.Forms.CheckBox()
        Me.cbxPtn2 = New System.Windows.Forms.CheckBox()
        Me.cbxPtn1 = New System.Windows.Forms.CheckBox()
        CType(Me.DgvReportItemSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPtnSelect.SuspendLayout()
        Me.gpxAutoPrtPtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(527, 617)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(653, 619)
        '
        'cmbRingSel
        '
        Me.cmbRingSel.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbRingSel.FormattingEnabled = True
        Me.cmbRingSel.Location = New System.Drawing.Point(126, 46)
        Me.cmbRingSel.MaxDropDownItems = 30
        Me.cmbRingSel.Name = "cmbRingSel"
        Me.cmbRingSel.Size = New System.Drawing.Size(263, 24)
        Me.cmbRingSel.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "リング番号"
        '
        'DgvReportItemSet
        '
        Me.DgvReportItemSet.AllowUserToAddRows = False
        Me.DgvReportItemSet.AllowUserToDeleteRows = False
        Me.DgvReportItemSet.AllowUserToResizeColumns = False
        Me.DgvReportItemSet.AllowUserToResizeRows = False
        Me.DgvReportItemSet.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReportItemSet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvReportItemSet.ColumnHeadersHeight = 40
        Me.DgvReportItemSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvReportItemSet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PrintOutItem})
        Me.DgvReportItemSet.Location = New System.Drawing.Point(288, 94)
        Me.DgvReportItemSet.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvReportItemSet.MultiSelect = False
        Me.DgvReportItemSet.Name = "DgvReportItemSet"
        Me.DgvReportItemSet.RowHeadersVisible = False
        Me.DgvReportItemSet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvReportItemSet.RowTemplate.Height = 24
        Me.DgvReportItemSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvReportItemSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvReportItemSet.Size = New System.Drawing.Size(436, 402)
        Me.DgvReportItemSet.TabIndex = 19
        '
        'ID
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID.DefaultCellStyle = DataGridViewCellStyle5
        Me.ID.Frozen = True
        Me.ID.HeaderText = "No"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'PrintOutItem
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrintOutItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrintOutItem.HeaderText = "項目名称"
        Me.PrintOutItem.Name = "PrintOutItem"
        Me.PrintOutItem.Width = 300
        '
        'gpxPtnSelect
        '
        Me.gpxPtnSelect.Controls.Add(Me.rtnPt3)
        Me.gpxPtnSelect.Controls.Add(Me.rtnPt2)
        Me.gpxPtnSelect.Controls.Add(Me.rtnPt1)
        Me.gpxPtnSelect.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gpxPtnSelect.ForeColor = System.Drawing.Color.White
        Me.gpxPtnSelect.Location = New System.Drawing.Point(126, 94)
        Me.gpxPtnSelect.Name = "gpxPtnSelect"
        Me.gpxPtnSelect.Size = New System.Drawing.Size(148, 129)
        Me.gpxPtnSelect.TabIndex = 21
        Me.gpxPtnSelect.TabStop = False
        Me.gpxPtnSelect.Text = "パターン選択"
        '
        'rtnPt3
        '
        Me.rtnPt3.AutoSize = True
        Me.rtnPt3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rtnPt3.ForeColor = System.Drawing.Color.White
        Me.rtnPt3.Location = New System.Drawing.Point(32, 83)
        Me.rtnPt3.Name = "rtnPt3"
        Me.rtnPt3.Size = New System.Drawing.Size(101, 23)
        Me.rtnPt3.TabIndex = 23
        Me.rtnPt3.Text = "パターン3"
        Me.rtnPt3.UseVisualStyleBackColor = True
        '
        'rtnPt2
        '
        Me.rtnPt2.AutoSize = True
        Me.rtnPt2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rtnPt2.ForeColor = System.Drawing.Color.White
        Me.rtnPt2.Location = New System.Drawing.Point(32, 54)
        Me.rtnPt2.Name = "rtnPt2"
        Me.rtnPt2.Size = New System.Drawing.Size(101, 23)
        Me.rtnPt2.TabIndex = 22
        Me.rtnPt2.Text = "パターン2"
        Me.rtnPt2.UseVisualStyleBackColor = True
        '
        'rtnPt1
        '
        Me.rtnPt1.AutoSize = True
        Me.rtnPt1.Checked = True
        Me.rtnPt1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rtnPt1.ForeColor = System.Drawing.Color.White
        Me.rtnPt1.Location = New System.Drawing.Point(32, 25)
        Me.rtnPt1.Name = "rtnPt1"
        Me.rtnPt1.Size = New System.Drawing.Size(101, 23)
        Me.rtnPt1.TabIndex = 21
        Me.rtnPt1.TabStop = True
        Me.rtnPt1.Text = "パターン1"
        Me.rtnPt1.UseVisualStyleBackColor = True
        '
        'btnPrintOut
        '
        Me.btnPrintOut.BackColor = System.Drawing.Color.Silver
        Me.btnPrintOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrintOut.Location = New System.Drawing.Point(516, 42)
        Me.btnPrintOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintOut.Name = "btnPrintOut"
        Me.btnPrintOut.Size = New System.Drawing.Size(102, 35)
        Me.btnPrintOut.TabIndex = 22
        Me.btnPrintOut.Text = "印刷"
        Me.btnPrintOut.UseVisualStyleBackColor = False
        '
        'btnFileSave
        '
        Me.btnFileSave.BackColor = System.Drawing.Color.Silver
        Me.btnFileSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFileSave.Location = New System.Drawing.Point(622, 42)
        Me.btnFileSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(102, 35)
        Me.btnFileSave.TabIndex = 23
        Me.btnFileSave.Text = "ファイル保存"
        Me.btnFileSave.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Silver
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(410, 42)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(102, 35)
        Me.btnPreview.TabIndex = 24
        Me.btnPreview.Text = "プレビュー"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(74, 561)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "自動印字"
        '
        'gpxAutoPrtPtn
        '
        Me.gpxAutoPrtPtn.Controls.Add(Me.cbxPtn3)
        Me.gpxAutoPrtPtn.Controls.Add(Me.cbxPtn2)
        Me.gpxAutoPrtPtn.Controls.Add(Me.cbxPtn1)
        Me.gpxAutoPrtPtn.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gpxAutoPrtPtn.ForeColor = System.Drawing.Color.White
        Me.gpxAutoPrtPtn.Location = New System.Drawing.Point(196, 537)
        Me.gpxAutoPrtPtn.Name = "gpxAutoPrtPtn"
        Me.gpxAutoPrtPtn.Size = New System.Drawing.Size(409, 63)
        Me.gpxAutoPrtPtn.TabIndex = 24
        Me.gpxAutoPrtPtn.TabStop = False
        Me.gpxAutoPrtPtn.Text = "パターン選択"
        '
        'cbxPtn3
        '
        Me.cbxPtn3.AutoSize = True
        Me.cbxPtn3.Location = New System.Drawing.Point(286, 25)
        Me.cbxPtn3.Name = "cbxPtn3"
        Me.cbxPtn3.Size = New System.Drawing.Size(102, 23)
        Me.cbxPtn3.TabIndex = 26
        Me.cbxPtn3.Text = "パターン3"
        Me.cbxPtn3.UseVisualStyleBackColor = True
        '
        'cbxPtn2
        '
        Me.cbxPtn2.AutoSize = True
        Me.cbxPtn2.Location = New System.Drawing.Point(153, 25)
        Me.cbxPtn2.Name = "cbxPtn2"
        Me.cbxPtn2.Size = New System.Drawing.Size(102, 23)
        Me.cbxPtn2.TabIndex = 25
        Me.cbxPtn2.Text = "パターン2"
        Me.cbxPtn2.UseVisualStyleBackColor = True
        '
        'cbxPtn1
        '
        Me.cbxPtn1.AutoSize = True
        Me.cbxPtn1.Location = New System.Drawing.Point(20, 25)
        Me.cbxPtn1.Name = "cbxPtn1"
        Me.cbxPtn1.Size = New System.Drawing.Size(102, 23)
        Me.cbxPtn1.TabIndex = 24
        Me.cbxPtn1.Text = "パターン1"
        Me.cbxPtn1.UseVisualStyleBackColor = True
        '
        'frmReportOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 676)
        Me.Controls.Add(Me.gpxAutoPrtPtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnFileSave)
        Me.Controls.Add(Me.btnPrintOut)
        Me.Controls.Add(Me.gpxPtnSelect)
        Me.Controls.Add(Me.DgvReportItemSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRingSel)
        Me.Name = "frmReportOut"
        Me.Text = "帳票出力"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.cmbRingSel, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.DgvReportItemSet, 0)
        Me.Controls.SetChildIndex(Me.gpxPtnSelect, 0)
        Me.Controls.SetChildIndex(Me.btnPrintOut, 0)
        Me.Controls.SetChildIndex(Me.btnFileSave, 0)
        Me.Controls.SetChildIndex(Me.btnPreview, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.gpxAutoPrtPtn, 0)
        CType(Me.DgvReportItemSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPtnSelect.ResumeLayout(False)
        Me.gpxPtnSelect.PerformLayout()
        Me.gpxAutoPrtPtn.ResumeLayout(False)
        Me.gpxAutoPrtPtn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbRingSel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvReportItemSet As DataGridView
    Friend WithEvents gpxPtnSelect As GroupBox
    Friend WithEvents rtnPt3 As RadioButton
    Friend WithEvents rtnPt2 As RadioButton
    Friend WithEvents rtnPt1 As RadioButton
    Protected WithEvents btnPrintOut As Button
    Protected WithEvents btnFileSave As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents PrintOutItem As DataGridViewComboBoxColumn
    Protected WithEvents btnPreview As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents gpxAutoPrtPtn As GroupBox
    Friend WithEvents cbxPtn3 As CheckBox
    Friend WithEvents cbxPtn2 As CheckBox
    Friend WithEvents cbxPtn1 As CheckBox
End Class
