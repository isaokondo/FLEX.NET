﻿Public Class frmRingNoChange
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub frmRingNoChange_Load(sender As Object, e As EventArgs) Handles Me.Load
        RingNoEdt.Value = PlcIf.RingNo
    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        '設定変更を反映
        PlcIf.RingNo = RingNoEdt.Value
        Me.Close()
    End Sub

    Private Sub RingNoEdt_Load(sender As Object, e As EventArgs) Handles RingNoEdt.Load

    End Sub
End Class