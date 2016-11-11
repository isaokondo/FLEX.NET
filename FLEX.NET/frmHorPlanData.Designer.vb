<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorPlanData
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Zone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastStation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(949, 572)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1075, 574)
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Zone, Me.LastStation, Me.LineType, Me.LineLength})
        Me.dgv.Location = New System.Drawing.Point(59, 67)
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 21
        Me.dgv.Size = New System.Drawing.Size(1091, 475)
        Me.dgv.TabIndex = 9
        '
        'Zone
        '
        Me.Zone.Frozen = True
        Me.Zone.HeaderText = "ゾーンNo"
        Me.Zone.Name = "Zone"
        Me.Zone.ReadOnly = True
        '
        'LastStation
        '
        Me.LastStation.Frozen = True
        Me.LastStation.HeaderText = "終点測点名"
        Me.LastStation.Name = "LastStation"
        Me.LastStation.ReadOnly = True
        '
        'LineType
        '
        Me.LineType.Frozen = True
        Me.LineType.HeaderText = "線形状"
        Me.LineType.Name = "LineType"
        Me.LineType.ReadOnly = True
        '
        'LineLength
        '
        Me.LineLength.Frozen = True
        Me.LineLength.HeaderText = "線分長"
        Me.LineLength.Name = "LineLength"
        Me.LineLength.ReadOnly = True
        '
        'frmHorPlanData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 618)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmHorPlanData"
        Me.Text = "平面掘進計画路線"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.dgv, 0)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Zone As DataGridViewTextBoxColumn
    Friend WithEvents LastStation As DataGridViewTextBoxColumn
    Friend WithEvents LineType As DataGridViewTextBoxColumn
    Friend WithEvents LineLength As DataGridViewTextBoxColumn
End Class
