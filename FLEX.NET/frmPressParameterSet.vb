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
            DirectControlCoefficient.Value = .DirectControlCoefficient
            DirectControlOffset.Value = .DirectControlOffset

        End With

        With CtlPara
            PresFileterFactor.Value = .元圧フィルタ係数
            ControlStartThrustOn.rdbtnValue = .圧力制御開始推力値有効フラグ
            ControlStartThrustData.Value = .圧力制御開始推力値
            PIDShiftDefl.Value = .PIDShiftDefl
            DirectControl.rdbtnValue = .DirectControl
        End With

    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PlcIf.減圧弁制御P定数 = PID_P.Value
        PlcIf.減圧弁制御I定数 = PID_I.Value
            PlcIf.減圧弁制御D定数 = PID_D.Value
        PlcIf.DirectControlCoefficient = DirectControlCoefficient.Value
        PlcIf.DirectControlOffset = DirectControlOffset.Value

        CtlPara.元圧フィルタ係数 = PresFileterFactor.Value
        CtlPara.圧力制御開始推力値有効フラグ = ControlStartThrustOn.rdbtnValue
            CtlPara.圧力制御開始推力値 = ControlStartThrustData.Value
            CtlPara.PIDShiftDefl = PIDShiftDefl.Value
            CtlPara.DirectControl = DirectControl.rdbtnValue


        Me.Close()
    End Sub




End Class