﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnDspDataMin2
    'Inherits System.Windows.Forms.UserControl
    Inherits ucnDspDataMin

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
        Me.SuspendLayout()
        '
        'lblData
        '
        Me.lblData.Location = New System.Drawing.Point(112, 0)
        '
        'lblFieldName
        '
        Me.lblFieldName.Location = New System.Drawing.Point(-2, 9)
        Me.lblFieldName.Size = New System.Drawing.Size(105, 12)
        Me.lblFieldName.Text = "余掘 1 "
        '
        'ucnDspDataMin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucnDspDataMin2"
        Me.Size = New System.Drawing.Size(200, 51)
        Me.ResumeLayout(False)

    End Sub

End Class
