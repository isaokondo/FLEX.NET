<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
        Me.AxAcroPDF = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxAcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF
        '
        Me.AxAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF.Enabled = True
        Me.AxAcroPDF.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF.Name = "AxAcroPDF"
        Me.AxAcroPDF.OcxState = CType(resources.GetObject("AxAcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF.Size = New System.Drawing.Size(1252, 873)
        Me.AxAcroPDF.TabIndex = 0
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 873)
        Me.Controls.Add(Me.AxAcroPDF)
        Me.Name = "frmReportViewer"
        Me.Text = "リング報表示"
        Me.TopMost = True
        CType(Me.AxAcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxAcroPDF As AxAcroPDFLib.AxAcroPDF
End Class
