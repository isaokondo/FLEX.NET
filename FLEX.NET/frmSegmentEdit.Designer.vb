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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvSegAssign = New System.Windows.Forms.DataGridView()
        Me.RingNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegmentType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SegWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegmentAssembly = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DgvSegAssign, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DgvSegAssign.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvSegAssign.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSegAssign.ColumnHeadersHeight = 40
        Me.DgvSegAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvSegAssign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RingNo, Me.SegmentType, Me.SegWidth, Me.SegmentAssembly})
        Me.DgvSegAssign.Location = New System.Drawing.Point(28, 39)
        Me.DgvSegAssign.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvSegAssign.MultiSelect = False
        Me.DgvSegAssign.Name = "DgvSegAssign"
        Me.DgvSegAssign.ReadOnly = True
        Me.DgvSegAssign.RowHeadersVisible = False
        Me.DgvSegAssign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvSegAssign.RowTemplate.Height = 24
        Me.DgvSegAssign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvSegAssign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvSegAssign.Size = New System.Drawing.Size(448, 631)
        Me.DgvSegAssign.TabIndex = 18
        '
        'RingNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RingNo.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SegmentType.DefaultCellStyle = DataGridViewCellStyle3
        Me.SegmentType.Frozen = True
        Me.SegmentType.HeaderText = "セグメント種類"
        Me.SegmentType.Name = "SegmentType"
        Me.SegmentType.ReadOnly = True
        Me.SegmentType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegmentType.Width = 120
        '
        'SegWidth
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SegWidth.DefaultCellStyle = DataGridViewCellStyle4
        Me.SegWidth.Frozen = True
        Me.SegWidth.HeaderText = "セグメント幅(mm)"
        Me.SegWidth.Name = "SegWidth"
        Me.SegWidth.ReadOnly = True
        Me.SegWidth.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SegWidth.Width = 120
        '
        'SegmentAssembly
        '
        Me.SegmentAssembly.AutoComplete = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SegmentAssembly.DefaultCellStyle = DataGridViewCellStyle5
        Me.SegmentAssembly.Frozen = True
        Me.SegmentAssembly.HeaderText = "組立パターン"
        Me.SegmentAssembly.Items.AddRange(New Object() {"１", "２", "３", "４"})
        Me.SegmentAssembly.Name = "SegmentAssembly"
        Me.SegmentAssembly.ReadOnly = True
        Me.SegmentAssembly.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SegmentAssembly.Width = 120
        '
        'frmSegmentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 732)
        Me.Controls.Add(Me.DgvSegAssign)
        Me.Name = "frmSegmentEdit"
        Me.Text = "セグメント割付"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DgvSegAssign, 0)
        CType(Me.DgvSegAssign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvSegAssign As DataGridView
    Friend WithEvents RingNo As DataGridViewTextBoxColumn
    Friend WithEvents SegmentType As DataGridViewComboBoxColumn
    Friend WithEvents SegWidth As DataGridViewTextBoxColumn
    Friend WithEvents SegmentAssembly As DataGridViewComboBoxColumn
End Class
