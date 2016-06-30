Public Class frmCorrectionValueManagement




    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        With ControlParameter
            ConfirmRingNo.Value = .測量ポイントリング番号
            TipDistance.Value = .測量ポイント総距離
            'PuchUpStroke.Value=.

        End With


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With ControlParameter
            .測量ポイントリング番号 = ConfirmRingNo.Value
            .測量ポイント総距離 = TipDistance.Value
            'PuchUpStroke.Value=.

        End With



        Me.Close()
    End Sub

    Private Sub frmCorrectionValueManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class