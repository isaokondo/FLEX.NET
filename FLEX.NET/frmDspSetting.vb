Public Class frmDspSetting
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'numCopyNo.Value = CtlPara.CopySelect
        numCopyCutEnableStroke.Value = CtlPara.CopyCutEnableStroke

        RightStrokeDiff.rdbtnValue = Not CtlPara.RightStrokeDiff

    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click

        'CtlPara.CopySelect = numCopyNo.Value
        CtlPara.CopyCutEnableStroke = numCopyCutEnableStroke.Value

        CtlPara.RightStrokeDiff = Not RightStrokeDiff.rdbtnValue


        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class