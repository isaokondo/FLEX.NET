Public Class frmRinguUpdateSetting
    Private NumEditCon As New Collection
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        CloseJudgePullStroke.MinValue =
                PlcIf.ParameterTag.TagData("終了判定引きストローク").EngLow
        CloseJudgePullStroke.MaxValue =
                PlcIf.ParameterTag.TagData("終了判定引きストローク").EngHight

        CloseJudgePullStroke.Value = PlcIf.終了判定引きストローク


        OffsetStroke.Value = CtlPara.OffsetStroke


    End Sub



    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        PlcIf.終了判定引きストローク = CloseJudgePullStroke.Value

        Dim ExceptJk As New List(Of Short)
        For Each dv As DataGridViewRow In DgvJackStroke.Rows
            If Not dv.Cells(JackEnable.Index).Value Then
                ExceptJk.Add(dv.Cells(JackNo.Index).Value)
            End If
        Next

        If ExceptJk.Count = InitPara.MesureJackAngle.Count Then
            MessageBox.Show("すべてのジャッキを無効にすることは出来ません")

        Else
            CtlPara.ExceptMesureJackNo = ExceptJk
            CtlPara.OffsetStroke = OffsetStroke.Value
            Me.Close()

        End If




    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        'Dim ExceptJk As New List(Of Short)
        'For Each dv As DataGridViewRow In DgvJackStroke.Rows
        '    If Not dv.Cells(JackEnable.Index).Value Then
        '        ExceptJk.Add(dv.Cells(JackNo.Index).Value)
        '    End If
        'Next

        'CtlPara.ExceptMesureJackNo = ExceptJk

        'Me.Close()
    End Sub

    Private Sub frmRinguUpdateSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim StrokeLoc As String() = {"上", "右", "下", "左"}
        For Each i In InitPara.MesureJackAngle
            '計測ジャッキ番号

            Dim JkLc As String = ""
            If InitPara.mesureJackNo.IndexOf(i.Key) >= 0 Then
                JkLc = StrokeLoc(InitPara.mesureJackNo.IndexOf(i.Key))
            End If
            DgvJackStroke.Rows.Add(i.Key, i.Value, Not CtlPara.ExceptMesureJackNo.Contains(i.Key), JkLc)
        Next

    End Sub
End Class