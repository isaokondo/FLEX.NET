<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRingNoChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRingNoChange))
        Me.RingNoEdt = New FLEX.NET.ucnNumEdit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        '
        'RingNoEdt
        '
        Me.RingNoEdt.DataDspWidth = 110
        Me.RingNoEdt.DecimalPlaces = CType(0, Short)
        Me.RingNoEdt.DspFieldName = False
        Me.RingNoEdt.FieldName = Nothing
        resources.ApplyResources(Me.RingNoEdt, "RingNoEdt")
        Me.RingNoEdt.Increment = 1.0!
        Me.RingNoEdt.InputStyle = FLEX.NET.ucnNumEdit.InputMethod.NumericInputType
        Me.RingNoEdt.MaxValue = "10000"
        Me.RingNoEdt.MinValue = "-100"
        Me.RingNoEdt.Name = "RingNoEdt"
        Me.RingNoEdt.SelectItem = Nothing
        Me.RingNoEdt.Unit = "リング"
        Me.RingNoEdt.Value = 0R
        '
        'frmRingNoChange
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.RingNoEdt)
        Me.Name = "frmRingNoChange"
        Me.Controls.SetChildIndex(Me.RingNoEdt, 0)
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RingNoEdt As FLEX.NET.ucnNumEdit
End Class
