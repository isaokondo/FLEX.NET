<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.UcnJackDsp = New FLEX.NET.ucnJackDsp()
        Me.SuspendLayout()
        '
        'UcnJackDsp
        '
        Me.UcnJackDsp.AssemblyOrder = CType(resources.GetObject("UcnJackDsp.AssemblyOrder"), System.Collections.Generic.List(Of Short))
        Me.UcnJackDsp.AssemblyPieceNo = CType(0, Short)
        Me.UcnJackDsp.AutoSize = True
        Me.UcnJackDsp.BackColor = System.Drawing.Color.Transparent
        Me.UcnJackDsp.BackgroundImage = CType(resources.GetObject("UcnJackDsp.BackgroundImage"), System.Drawing.Image)
        Me.UcnJackDsp.CopyStrechSet = 10
        Me.UcnJackDsp.FaiJack = Nothing
        Me.UcnJackDsp.FlexAutoManual = False
        Me.UcnJackDsp.FlexPointR = 0!
        Me.UcnJackDsp.FlexPointSeater = 0!
        Me.UcnJackDsp.FlexPointX = 0!
        Me.UcnJackDsp.FlexPointY = 0!
        Me.UcnJackDsp.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UcnJackDsp.GroupPV = New Single() {0!}
        Me.UcnJackDsp.JackAutoOneWayLimit = False
        Me.UcnJackDsp.JackAutoPid = False
        Me.UcnJackDsp.JackGroupPos = Nothing
        Me.UcnJackDsp.JackOrgPress = 0!
        Me.UcnJackDsp.JackStatus = New Short() {CType(0, Short)}
        Me.UcnJackDsp.Location = New System.Drawing.Point(354, 112)
        Me.UcnJackDsp.Margin = New System.Windows.Forms.Padding(2)
        Me.UcnJackDsp.Name = "UcnJackDsp"
        Me.UcnJackDsp.NumberGroup = CType(0, Short)
        Me.UcnJackDsp.NumberJack = CType(0, Short)
        Me.UcnJackDsp.PieceAngle = CType(resources.GetObject("UcnJackDsp.PieceAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceCenterAngle = CType(resources.GetObject("UcnJackDsp.PieceCenterAngle"), System.Collections.Generic.List(Of Single))
        Me.UcnJackDsp.PieceName = CType(resources.GetObject("UcnJackDsp.PieceName"), System.Collections.Generic.List(Of String))
        Me.UcnJackDsp.PointRLimitOver = False
        Me.UcnJackDsp.SegmentDspEnable = False
        Me.UcnJackDsp.Size = New System.Drawing.Size(795, 731)
        Me.UcnJackDsp.TabIndex = 69
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1912, 1051)
        Me.Controls.Add(Me.UcnJackDsp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcnJackDsp As FLEX.NET.ucnJackDsp
End Class
