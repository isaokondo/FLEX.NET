Public Class frmPressParameterSet

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込
        With PlcIf
            PID_P.Value = .減圧弁制御P定数
            PID_I.Value = .減圧弁制御I定数
            PID_D.Value = .減圧弁制御D定数

        End With

        With CtlParameter
            PresFileterFactor.Value = .元圧フィルタ係数
            ControlStartThrustOn.rdbtnValue = .圧力制御開始推力値有効フラグ
            ControlStartThrustData.Value = .圧力制御開始推力値
            PIDShiftDefl.Value = .PIDShiftDefl
            DirectControl.rdbtnValue = .DirectControl
        End With

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        With PlcIf
            PlcIf.減圧弁制御P定数 = PID_P.Value
            PlcIf.減圧弁制御I定数 = PID_I.Value
            PlcIf.減圧弁制御D定数 = PID_D.Value
        End With

        With CtlParameter
            .元圧フィルタ係数 = PresFileterFactor.Value
            .圧力制御開始推力値有効フラグ = ControlStartThrustOn.rdbtnValue
            .圧力制御開始推力値 = ControlStartThrustData.Value
            .PIDShiftDefl = PIDShiftDefl.Value
            .DirectControl = DirectControl.rdbtnValue
        End With


    End Sub




End Class