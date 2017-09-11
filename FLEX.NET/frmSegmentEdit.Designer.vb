<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegmentEdit
    Inherits frmSettingBase

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvSegAssign = New System.Windows.Forms.DataGridView()
        Me.RingNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegmentType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SegWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssemblyPtnName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TransferSet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SheetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPtternPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvSegSim = New System.Windows.Forms.DataGridView()
        Me.TrasferEnabl = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RingNoSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegmentTypeSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssemblyPtnNameSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SheetIDSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripSim = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnAllSelect = New System.Windows.Forms.Button()
        Me.btnSelectCancel = New System.Windows.Forms.Button()
        CType(Me.DgvSegAssign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.DgvSegSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripSim.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(385, 684)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(511, 686)
        '
        'DgvSegAssign
        '
        Me.DgvSegAssign.AllowUserToAddRows = False
        Me.DgvSegAssign.AllowUserToDeleteRows = False
        Me.DgvSegAssign.AllowUserToResizeColumns = False
        Me.DgvSegAssign.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvSegAssign.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSegAssign.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DgvSegAssign.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSegAssign.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSegAssign.ColumnHeadersHeight = 40
        Me.DgvSegAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSegAssign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RingNo, Me.SegmentType, Me.SegWidth, Me.AssemblyPtnName, Me.TransferSet, Me.SheetID})
        Me.DgvSegAssign.ContextMenuStrip = Me.ContextMenuStrip
        Me.DgvSegAssign.Location = New System.Drawing.Point(11, 38)
        Me.DgvSegAssign.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvSegAssign.Name = "DgvSegAssign"
        Me.DgvSegAssign.RowHeadersVisible = False
        Me.DgvSegAssign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvSegAssign.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvSegAssign.RowTemplate.Height = 24
        Me.DgvSegAssign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSegAssign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSegAssign.Size = New System.Drawing.Size(691, 631)
        Me.DgvSegAssign.TabIndex = 18
        '
        'RingNo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.RingNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.RingNo.Frozen = True
        Me.RingNo.HeaderText = "リングNo"
        Me.RingNo.Name = "RingNo"
        Me.RingNo.ReadOnly = True
        Me.RingNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RingNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RingNo.Width = 60
        '
        'SegmentType
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SegmentType.DefaultCellStyle = DataGridViewCellStyle4
        Me.SegmentType.Frozen = True
        Me.SegmentType.HeaderText = "セグメント種類"
        Me.SegmentType.Name = "SegmentType"
        Me.SegmentType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegmentType.Width = 200
        '
        'SegWidth
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SegWidth.DefaultCellStyle = DataGridViewCellStyle5
        Me.SegWidth.Frozen = True
        Me.SegWidth.HeaderText = "セグメント幅(mm)"
        Me.SegWidth.Name = "SegWidth"
        Me.SegWidth.ReadOnly = True
        Me.SegWidth.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SegWidth.Width = 120
        '
        'AssemblyPtnName
        '
        Me.AssemblyPtnName.AutoComplete = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AssemblyPtnName.DefaultCellStyle = DataGridViewCellStyle6
        Me.AssemblyPtnName.Frozen = True
        Me.AssemblyPtnName.HeaderText = "組立パターン"
        Me.AssemblyPtnName.Name = "AssemblyPtnName"
        Me.AssemblyPtnName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssemblyPtnName.Width = 200
        '
        'TransferSet
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TransferSet.DefaultCellStyle = DataGridViewCellStyle7
        Me.TransferSet.FillWeight = 80.0!
        Me.TransferSet.Frozen = True
        Me.TransferSet.HeaderText = "転送済"
        Me.TransferSet.Name = "TransferSet"
        Me.TransferSet.ReadOnly = True
        Me.TransferSet.Width = 80
        '
        'SheetID
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SheetID.DefaultCellStyle = DataGridViewCellStyle8
        Me.SheetID.Frozen = True
        Me.SheetID.HeaderText = "SheetID"
        Me.SheetID.Name = "SheetID"
        Me.SheetID.ReadOnly = True
        Me.SheetID.Visible = False
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCopy, Me.tsmPaste, Me.tsmPtternPaste})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(150, 70)
        '
        'tsmCopy
        '
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.Size = New System.Drawing.Size(149, 22)
        Me.tsmCopy.Text = "コピー"
        '
        'tsmPaste
        '
        Me.tsmPaste.Enabled = False
        Me.tsmPaste.Name = "tsmPaste"
        Me.tsmPaste.Size = New System.Drawing.Size(149, 22)
        Me.tsmPaste.Text = "貼り付け"
        '
        'tsmPtternPaste
        '
        Me.tsmPtternPaste.Enabled = False
        Me.tsmPtternPaste.Name = "tsmPtternPaste"
        Me.tsmPtternPaste.Size = New System.Drawing.Size(149, 22)
        Me.tsmPtternPaste.Text = "パターン貼り付け"
        '
        'DgvSegSim
        '
        Me.DgvSegSim.AllowUserToAddRows = False
        Me.DgvSegSim.AllowUserToDeleteRows = False
        Me.DgvSegSim.AllowUserToResizeColumns = False
        Me.DgvSegSim.AllowUserToResizeRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvSegSim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvSegSim.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DgvSegSim.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSegSim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvSegSim.ColumnHeadersHeight = 40
        Me.DgvSegSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSegSim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrasferEnabl, Me.RingNoSim, Me.SegmentTypeSim, Me.AssemblyPtnNameSim, Me.TransferDate, Me.SheetIDSim})
        Me.DgvSegSim.ContextMenuStrip = Me.ContextMenuStripSim
        Me.DgvSegSim.Location = New System.Drawing.Point(790, 101)
        Me.DgvSegSim.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvSegSim.Name = "DgvSegSim"
        Me.DgvSegSim.RowHeadersVisible = False
        Me.DgvSegSim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvSegSim.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DgvSegSim.RowTemplate.Height = 24
        Me.DgvSegSim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSegSim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSegSim.Size = New System.Drawing.Size(668, 568)
        Me.DgvSegSim.TabIndex = 19
        '
        'TrasferEnabl
        '
        Me.TrasferEnabl.FillWeight = 60.0!
        Me.TrasferEnabl.Frozen = True
        Me.TrasferEnabl.HeaderText = "転送有効"
        Me.TrasferEnabl.Name = "TrasferEnabl"
        Me.TrasferEnabl.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TrasferEnabl.Width = 80
        '
        'RingNoSim
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = Nothing
        Me.RingNoSim.DefaultCellStyle = DataGridViewCellStyle12
        Me.RingNoSim.Frozen = True
        Me.RingNoSim.HeaderText = "リングNo"
        Me.RingNoSim.Name = "RingNoSim"
        Me.RingNoSim.ReadOnly = True
        Me.RingNoSim.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RingNoSim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RingNoSim.Width = 60
        '
        'SegmentTypeSim
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SegmentTypeSim.DefaultCellStyle = DataGridViewCellStyle13
        Me.SegmentTypeSim.Frozen = True
        Me.SegmentTypeSim.HeaderText = "セグメント種類"
        Me.SegmentTypeSim.Name = "SegmentTypeSim"
        Me.SegmentTypeSim.ReadOnly = True
        Me.SegmentTypeSim.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegmentTypeSim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SegmentTypeSim.Width = 200
        '
        'AssemblyPtnNameSim
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AssemblyPtnNameSim.DefaultCellStyle = DataGridViewCellStyle14
        Me.AssemblyPtnNameSim.Frozen = True
        Me.AssemblyPtnNameSim.HeaderText = "組立パターン"
        Me.AssemblyPtnNameSim.Name = "AssemblyPtnNameSim"
        Me.AssemblyPtnNameSim.ReadOnly = True
        Me.AssemblyPtnNameSim.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AssemblyPtnNameSim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AssemblyPtnNameSim.Width = 200
        '
        'TransferDate
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TransferDate.DefaultCellStyle = DataGridViewCellStyle15
        Me.TransferDate.Frozen = True
        Me.TransferDate.HeaderText = "転送日"
        Me.TransferDate.Name = "TransferDate"
        Me.TransferDate.ReadOnly = True
        Me.TransferDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransferDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SheetIDSim
        '
        Me.SheetIDSim.Frozen = True
        Me.SheetIDSim.HeaderText = "SheetID"
        Me.SheetIDSim.Name = "SheetIDSim"
        Me.SheetIDSim.ReadOnly = True
        Me.SheetIDSim.Visible = False
        '
        'ContextMenuStripSim
        '
        Me.ContextMenuStripSim.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSelect, Me.tsmCancel})
        Me.ContextMenuStripSim.Name = "ContextMenuStrip"
        Me.ContextMenuStripSim.Size = New System.Drawing.Size(95, 48)
        '
        'tsmSelect
        '
        Me.tsmSelect.Name = "tsmSelect"
        Me.tsmSelect.Size = New System.Drawing.Size(94, 22)
        Me.tsmSelect.Text = "選択"
        '
        'tsmCancel
        '
        Me.tsmCancel.Name = "tsmCancel"
        Me.tsmCancel.Size = New System.Drawing.Size(94, 22)
        Me.tsmCancel.Text = "解除"
        '
        'btnTransfer
        '
        Me.btnTransfer.BackColor = System.Drawing.Color.Silver
        Me.btnTransfer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTransfer.Location = New System.Drawing.Point(706, 327)
        Me.btnTransfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(71, 35)
        Me.btnTransfer.TabIndex = 20
        Me.btnTransfer.Text = "←転送"
        Me.btnTransfer.UseVisualStyleBackColor = False
        '
        'btnAllSelect
        '
        Me.btnAllSelect.BackColor = System.Drawing.Color.Silver
        Me.btnAllSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAllSelect.Location = New System.Drawing.Point(763, 38)
        Me.btnAllSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAllSelect.Name = "btnAllSelect"
        Me.btnAllSelect.Size = New System.Drawing.Size(91, 35)
        Me.btnAllSelect.TabIndex = 21
        Me.btnAllSelect.Text = "全選択"
        Me.btnAllSelect.UseVisualStyleBackColor = False
        '
        'btnSelectCancel
        '
        Me.btnSelectCancel.BackColor = System.Drawing.Color.Silver
        Me.btnSelectCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSelectCancel.Location = New System.Drawing.Point(858, 38)
        Me.btnSelectCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectCancel.Name = "btnSelectCancel"
        Me.btnSelectCancel.Size = New System.Drawing.Size(91, 35)
        Me.btnSelectCancel.TabIndex = 22
        Me.btnSelectCancel.Text = "選択解除"
        Me.btnSelectCancel.UseVisualStyleBackColor = False
        '
        'frmSegmentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 732)
        Me.Controls.Add(Me.btnSelectCancel)
        Me.Controls.Add(Me.btnAllSelect)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.DgvSegSim)
        Me.Controls.Add(Me.DgvSegAssign)
        Me.Name = "frmSegmentEdit"
        Me.Text = "セグメント割付"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DgvSegAssign, 0)
        Me.Controls.SetChildIndex(Me.DgvSegSim, 0)
        Me.Controls.SetChildIndex(Me.btnTransfer, 0)
        Me.Controls.SetChildIndex(Me.btnAllSelect, 0)
        Me.Controls.SetChildIndex(Me.btnSelectCancel, 0)
        CType(Me.DgvSegAssign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.DgvSegSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripSim.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvSegAssign As DataGridView
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents tsmCopy As ToolStripMenuItem
    Friend WithEvents tsmPaste As ToolStripMenuItem
    Friend WithEvents tsmPtternPaste As ToolStripMenuItem
    Friend WithEvents DgvSegSim As DataGridView
    Protected WithEvents btnTransfer As Button
    Protected WithEvents btnAllSelect As Button
    Protected WithEvents btnSelectCancel As Button
    Friend WithEvents ContextMenuStripSim As ContextMenuStrip
    Friend WithEvents tsmSelect As ToolStripMenuItem
    Friend WithEvents tsmCancel As ToolStripMenuItem
    Friend WithEvents RingNo As DataGridViewTextBoxColumn
    Friend WithEvents SegmentType As DataGridViewComboBoxColumn
    Friend WithEvents SegWidth As DataGridViewTextBoxColumn
    Friend WithEvents AssemblyPtnName As DataGridViewComboBoxColumn
    Friend WithEvents TransferSet As DataGridViewTextBoxColumn
    Friend WithEvents SheetID As DataGridViewTextBoxColumn
    Friend WithEvents TrasferEnabl As DataGridViewCheckBoxColumn
    Friend WithEvents RingNoSim As DataGridViewTextBoxColumn
    Friend WithEvents SegmentTypeSim As DataGridViewTextBoxColumn
    Friend WithEvents AssemblyPtnNameSim As DataGridViewTextBoxColumn
    Friend WithEvents TransferDate As DataGridViewTextBoxColumn
    Friend WithEvents SheetIDSim As DataGridViewTextBoxColumn
End Class
