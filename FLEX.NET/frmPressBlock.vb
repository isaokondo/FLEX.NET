Public Class frmPressBlock

    'todo:全開指令の中央値の語句はこれでいいか
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        With CtlParameter
            FullPowerMinimumEnable.rdbtnValue = .全開グループ制限
            MinimumFullPowerBlock.Value = .最低全開グループ数
            FullPowerValue.Value = .全開作動指令値
            FullPowerRange.Value = .全開作動範囲
            MinimumContorolPress.Value = .最低制御圧力
            MaxContorolPress.Value = .最大全開出力時の目標圧力

        End With

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        With CtlParameter
            .全開グループ制限 = FullPowerMinimumEnable.rdbtnValue
            .最低全開グループ数 = MinimumFullPowerBlock.Value
            .全開作動指令値 = FullPowerValue.Value
            .全開作動範囲 = FullPowerRange.Value

            'todo:最低制御については、未プログラム
            .最低制御圧力 = MinimumContorolPress.Value
            .最大全開出力時の目標圧力 = MaxContorolPress.Value
        End With

    End Sub



End Class