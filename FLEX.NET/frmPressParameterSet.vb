Public Class frmPressParameterSet

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        'TODO:ダイレクト指令制御の取込

        PID_P.Value = PlcIf.減圧弁制御P定数
        PID_I.Value = PlcIf.減圧弁制御I定数
        PID_D.Value = PlcIf.減圧弁制御D定数
        DirectControlCoefficient.Value = PlcIf.DirectControlCoefficient
        DirectControlOffset.Value = PlcIf.DirectControlOffset

        PresFileterFactor.Value = CtlPara.元圧フィルタ係数
        ControlStartThrustOn.rdbtnValue = CtlPara.圧力制御開始推力値有効フラグ
        ControlStartThrustData.Value = CtlPara.圧力制御開始推力値
        PIDShiftDefl.Value = CtlPara.PIDShiftDefl
        DirectControl.rdbtnValue = CtlPara.DirectControl

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