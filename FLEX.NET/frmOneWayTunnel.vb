﻿Public Class frmOneWayTunnel
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        With CtlPara
            HorPID_P.Value = .水平ジャッキ制御P定数
            HorPID_I.Value = .水平ジャッキ制御I定数
            HorPID_D.Value = .水平ジャッキ制御I定数
            VerPID_P.Value = .鉛直ジャッキ制御P定数
            VerPID_I.Value = .鉛直ジャッキ制御I定数
            VerPID_D.Value = .鉛直ジャッキ制御I定数
        End With


    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        With CtlPara
            .水平ジャッキ制御P定数 = HorPID_P.Value
            .水平ジャッキ制御I定数 = HorPID_I.Value
            .水平ジャッキ制御I定数 = HorPID_D.Value
            .鉛直ジャッキ制御P定数 = VerPID_P.Value
            .鉛直ジャッキ制御I定数 = VerPID_I.Value
            .鉛直ジャッキ制御I定数 = VerPID_D.Value
        End With


        Me.Close()

    End Sub

    Private Sub frmOneWayTunnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class