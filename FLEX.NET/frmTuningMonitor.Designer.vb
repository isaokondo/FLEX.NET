<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTuningMonitor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTuningMonitor))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picDsp = New System.Windows.Forms.PictureBox()
        Me.tmrDspUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.barSv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.barMv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.barPv = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysTopMost = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWindow = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picDsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(417, 118)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(52, 25)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picDsp
        '
        Me.picDsp.BackColor = System.Drawing.Color.White
        Me.picDsp.Location = New System.Drawing.Point(11, 46)
        Me.picDsp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picDsp.Name = "picDsp"
        Me.picDsp.Size = New System.Drawing.Size(480, 481)
        Me.picDsp.TabIndex = 1
        Me.picDsp.TabStop = False
        '
        'tmrDspUpdate
        '
        Me.tmrDspUpdate.Enabled = True
        Me.tmrDspUpdate.Interval = 1000
        '
        'barSv
        '
        Me.barSv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barSv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barSv.Location = New System.Drawing.Point(556, 61)
        Me.barSv.Name = "barSv"
        Me.barSv.Size = New System.Drawing.Size(43, 10)
        '
        'barMv
        '
        Me.barMv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barMv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barMv.Location = New System.Drawing.Point(556, 105)
        Me.barMv.Name = "barMv"
        Me.barMv.Size = New System.Drawing.Size(43, 10)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.barPv, Me.barMv, Me.barSv})
        Me.ShapeContainer1.Size = New System.Drawing.Size(614, 560)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'barPv
        '
        Me.barPv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.barPv.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.barPv.Location = New System.Drawing.Point(556, 83)
        Me.barPv.Name = "barPv"
        Me.barPv.Size = New System.Drawing.Size(43, 10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MV"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysTopMost, Me.CloseWindow})
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem.Text = "システム"
        '
        'AlwaysTopMost
        '
        Me.AlwaysTopMost.Name = "AlwaysTopMost"
        Me.AlwaysTopMost.Size = New System.Drawing.Size(115, 22)
        Me.AlwaysTopMost.Text = "常に手前"
        '
        'CloseWindow
        '
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(115, 22)
        Me.CloseWindow.Text = "閉じる"
        '
        'frmTuningMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(614, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDsp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmTuningMonitor"
        Me.Text = "チューニングモニタ"
        CType(Me.picDsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents picDsp As PictureBox
    Friend WithEvents tmrDspUpdate As Timer
    Friend WithEvents barSv As PowerPacks.RectangleShape
    Friend WithEvents barMv As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents barPv As PowerPacks.RectangleShape
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysTopMost As ToolStripMenuItem
    Friend WithEvents CloseWindow As ToolStripMenuItem
End Class
