﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRinguUpdateSetting
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CloseJudgePullStroke = New FLEX.NET.ucnNumEdit()
        Me.DgvJackStroke = New System.Windows.Forms.DataGridView()
        Me.JackNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JackEnable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SelectDsp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OffsetStroke = New FLEX.NET.ucnNumEdit()
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(180, 395)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(312, 396)
        '
        'CloseJudgePullStroke
        '
        Me.CloseJudgePullStroke.DataDspWidth = 110
        Me.CloseJudgePullStroke.DecimalPlaces = CType(0, Short)
        Me.CloseJudgePullStroke.DspFieldName = True
        Me.CloseJudgePullStroke.FieldName = "終了判定平均引きストローク"
        Me.CloseJudgePullStroke.Increment = 1.0!
        Me.CloseJudgePullStroke.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.CloseJudgePullStroke.Location = New System.Drawing.Point(29, 31)
        Me.CloseJudgePullStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseJudgePullStroke.MaxValue = "0"
        Me.CloseJudgePullStroke.MinValue = "0"
        Me.CloseJudgePullStroke.Name = "CloseJudgePullStroke"
        Me.CloseJudgePullStroke.SelectItem = Nothing
        Me.CloseJudgePullStroke.Size = New System.Drawing.Size(410, 39)
        Me.CloseJudgePullStroke.TabIndex = 7
        Me.CloseJudgePullStroke.ttMsg = ""
        Me.CloseJudgePullStroke.ttTile = ""
        Me.CloseJudgePullStroke.Unit = "mm"
        Me.CloseJudgePullStroke.Value = 0R
        '
        'DgvJackStroke
        '
        Me.DgvJackStroke.AllowUserToAddRows = False
        Me.DgvJackStroke.AllowUserToDeleteRows = False
        Me.DgvJackStroke.AllowUserToResizeColumns = False
        Me.DgvJackStroke.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvJackStroke.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvJackStroke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvJackStroke.ColumnHeadersHeight = 40
        Me.DgvJackStroke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvJackStroke.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JackNo, Me.Angle, Me.JackEnable, Me.SelectDsp})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJackStroke.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvJackStroke.Location = New System.Drawing.Point(29, 127)
        Me.DgvJackStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvJackStroke.MultiSelect = False
        Me.DgvJackStroke.Name = "DgvJackStroke"
        Me.DgvJackStroke.RowHeadersVisible = False
        Me.DgvJackStroke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvJackStroke.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DgvJackStroke.RowTemplate.Height = 24
        Me.DgvJackStroke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvJackStroke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvJackStroke.Size = New System.Drawing.Size(385, 249)
        Me.DgvJackStroke.TabIndex = 19
        '
        'JackNo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.JackNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.JackNo.DividerWidth = 1
        Me.JackNo.Frozen = True
        Me.JackNo.HeaderText = "計測ジャッキNo"
        Me.JackNo.Name = "JackNo"
        Me.JackNo.ReadOnly = True
        '
        'Angle
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Angle.DefaultCellStyle = DataGridViewCellStyle4
        Me.Angle.Frozen = True
        Me.Angle.HeaderText = "取付角度(deg)"
        Me.Angle.Name = "Angle"
        Me.Angle.ReadOnly = True
        Me.Angle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'JackEnable
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.NullValue = False
        Me.JackEnable.DefaultCellStyle = DataGridViewCellStyle5
        Me.JackEnable.Frozen = True
        Me.JackEnable.HeaderText = "有効"
        Me.JackEnable.Name = "JackEnable"
        Me.JackEnable.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JackEnable.Width = 50
        '
        'SelectDsp
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SelectDsp.DefaultCellStyle = DataGridViewCellStyle6
        Me.SelectDsp.Frozen = True
        Me.SelectDsp.HeaderText = "選択表示  （上下左右）"
        Me.SelectDsp.Name = "SelectDsp"
        Me.SelectDsp.ReadOnly = True
        Me.SelectDsp.Width = 90
        '
        'OffsetStroke
        '
        Me.OffsetStroke.DataDspWidth = 110
        Me.OffsetStroke.DecimalPlaces = CType(0, Short)
        Me.OffsetStroke.DspFieldName = True
        Me.OffsetStroke.FieldName = "ストローク補正値"
        Me.OffsetStroke.Increment = 1.0!
        Me.OffsetStroke.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.OffsetStroke.Location = New System.Drawing.Point(29, 74)
        Me.OffsetStroke.Margin = New System.Windows.Forms.Padding(2)
        Me.OffsetStroke.MaxValue = "3000"
        Me.OffsetStroke.MinValue = "-3000"
        Me.OffsetStroke.Name = "OffsetStroke"
        Me.OffsetStroke.SelectItem = Nothing
        Me.OffsetStroke.Size = New System.Drawing.Size(410, 39)
        Me.OffsetStroke.TabIndex = 20
        Me.OffsetStroke.ttMsg = ""
        Me.OffsetStroke.ttTile = ""
        Me.OffsetStroke.Unit = "mm"
        Me.OffsetStroke.Value = 0R
        '
        'frmRinguUpdateSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(452, 452)
        Me.Controls.Add(Me.OffsetStroke)
        Me.Controls.Add(Me.DgvJackStroke)
        Me.Controls.Add(Me.CloseJudgePullStroke)
        Me.Name = "frmRinguUpdateSetting"
        Me.Text = "リング更新設定"
        Me.Controls.SetChildIndex(Me.CloseJudgePullStroke, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.DgvJackStroke, 0)
        Me.Controls.SetChildIndex(Me.OffsetStroke, 0)
        CType(Me.DgvJackStroke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseJudgePullStroke As FLEX.NET.ucnNumEdit
    Friend WithEvents DgvJackStroke As DataGridView
    Friend WithEvents JackNo As DataGridViewTextBoxColumn
    Friend WithEvents Angle As DataGridViewTextBoxColumn
    Friend WithEvents JackEnable As DataGridViewCheckBoxColumn
    Friend WithEvents SelectDsp As DataGridViewTextBoxColumn
    Friend WithEvents OffsetStroke As ucnNumEdit
End Class
