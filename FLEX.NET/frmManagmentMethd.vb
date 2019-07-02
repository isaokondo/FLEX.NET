Public Class frmManagmentMethd

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub



    Private Sub frmManagmentMethd_Load(sender As Object, e As EventArgs) Handles Me.Load
        HorTargetVal.rdbtnValue = CtlPara.horTargetSet
        VerTargetVal.rdbtnValue = CtlPara.verTargetSet
        HorAngleDetection.rdbtnValue = CtlPara.horAngleDetection
    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)

        CtlPara.horTargetSet = HorTargetVal.rdbtnValue
        CtlPara.verTargetSet = VerTargetVal.rdbtnValue
        CtlPara.horAngleDetection = HorAngleDetection.rdbtnValue

        Me.Close()

    End Sub



End Class