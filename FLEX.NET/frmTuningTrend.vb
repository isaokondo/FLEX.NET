Public Class frmTuningTrend
    ''' <summary>
    ''' データ個数（１秒１つ）
    ''' </summary>
    Private NumberData As Integer = 360
    Dim tmrData As Timer
    Private ID As Integer

    Private Structure GroupPress
        Dim SmplTime As Date    '時刻
        Dim JkPress As Single 'シールド圧
        Dim Sv() As Single    '設定値
        Dim Pv() As Single    '測定値
        Dim Mv() As Single    '操作出力
    End Structure

    Private LstGroupPress As New List(Of GroupPress)
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        GroupSelect.MaxValue = InitPara.NumberGroup


    End Sub



    Private Sub TimerRun()

        tmrData = New Timer()
        AddHandler tmrData.Tick, New EventHandler(AddressOf DataUpdate)
        tmrData.Interval = 1000   '1秒ごとの処理
        tmrData.Enabled = True ' timer.Start()と同じ

    End Sub

    Private Sub DataUpdate()
        'グループ圧の取り込み
        Dim GpNo As Short = GroupSelect.Value
        DspGroupMV.Value = PlcIf.GroupMV(GpNo - 1)
        DspGroupPV.Value = PlcIf.GroupPv(GpNo - 1)
        DspGroupSV.Value = PlcIf.GroupSV(GpNo - 1)

        DspJackPress.Value = PlcIf.JkPress

        'グラフ表示分のデータ保持
        Dim GpData As GroupPress
        GpData.SmplTime = Now
        GpData.JkPress = PlcIf.JkPress
        GpData.Sv = PlcIf.GroupSV.Clone
        GpData.Pv = PlcIf.GroupPv.Clone
        GpData.Mv = PlcIf.GroupMV.Clone

        'データ個数をチャート表示のみ
        LstGroupPress.Add(GpData)
        If LstGroupPress.Count > NumberData Then
            LstGroupPress.RemoveAt(0)
        End If


        '時刻の表示
        lblNowTime.Text = Now.ToLongTimeString

        lbl5minBefore.Text = Now.AddMinutes(-5).ToLongTimeString


        '        データグリッドに表示
        For i As Short = 0 To InitPara.NumberGroup - 1
            DgvGroup.Rows(i).Cells(1).Value = PlcIf.GroupSV(i).ToString("F1")
            DgvGroup.Rows(i).Cells(2).Value = PlcIf.GroupPv(i).ToString("F1")
            DgvGroup.Rows(i).Cells(3).Value = PlcIf.GroupMV(i).ToString("F1")
        Next


        ChartUp() 'チャート表示
        'データ保存識別用ID

        Dim dsave As New clsDataSave(ID, GpData)

        ID += 1


    End Sub
    ''' <summary>
    ''' チャートの更新
    ''' </summary>
    Private Sub ChartUp()
        Dim canvas As New Bitmap(picChart.Width, picChart.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(picChart.BackColor)

        Dim psPv As New List(Of Point)
        Dim psMv As New List(Of Point)
        Dim psSv As New List(Of Point)
        Dim psPress As New List(Of Point)


        Dim x As Single = picChart.Width * (1 - LstGroupPress.Count / NumberData)
        For Each gp In LstGroupPress
            Dim gpNo As Short = GroupSelect.Value - 1

            x += picChart.Width / NumberData

            Dim y As Integer
            y = (1 - gp.Sv(gpNo) / InitPara.JackMaxOilPres) * picChart.Height
            psSv.Add(New Point(x, y))

            y = (1 - gp.Pv(gpNo) / InitPara.JackMaxOilPres) * picChart.Height
            psPv.Add(New Point(x, y))

            y = (1 - gp.JkPress / InitPara.JackMaxOilPres) * picChart.Height
            psPress.Add(New Point(x, y))

            y = (1 - gp.Mv(gpNo) / 100) * picChart.Height
            psMv.Add(New Point(x, y))


        Next

        If LstGroupPress.Count > 1 Then

            g.DrawLines(New Pen(barSv.BackColor, 1), psSv.ToArray)
            g.DrawLines(New Pen(barMv.BackColor, 1), psMv.ToArray)
            g.DrawLines(New Pen(barPv.BackColor, 1), psPv.ToArray)
            g.DrawLines(New Pen(Color.White, 1), psPress.ToArray)
        End If


        g.Dispose()
        picChart.Image = canvas

    End Sub

    ''' <summary>
    ''' テストデータの保存
    ''' </summary>
    Private Sub DataSave()





    End Sub



    Private Sub frmTuningTrend_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblHighPress.Text = InitPara.JackMaxOilPres.ToString("F1") & " Mpa"


        For i = 0 To InitPara.NumberGroup - 1
            DgvGroup.Rows.Add()
            DgvGroup.Rows(i).Cells(0).Value = (i + 1).ToString
        Next

        nudMVUpDownTime.Value = PlcIf.減圧弁特性増減時間

        DgvGroup.CurrentCell = Nothing

        ID = 1


        TimerRun()
    End Sub

    Private Sub frmTuningTrend_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        PlcIf.減圧弁特性増減時間 = nudMVUpDownTime.Value

        tmrData.Stop()
    End Sub

    Private Sub nudMVUpDownTime_ValueChanged(sender As Object, e As EventArgs) Handles nudMVUpDownTime.ValueChanged
    End Sub
    ''' <summary>
    ''' 増圧開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMvUpStart_Click(sender As Object, e As EventArgs) Handles btnMvUpStart.Click, btnDownStart.Click

        If Not PlcIf.FlexControlOn Then
            MessageBox.Show("FLEX制御ONにしてください")
            Exit Sub
        End If


        CtlPara.AutoDirectionControl=True

        PlcIf.減圧弁特性増減時間 = nudMVUpDownTime.Value
        Dim OutFlg As Integer
        'Select Case sender.GetType
        '    Case btnMvUpStart
        '        OutFlg = &H60
        '    Case btnDownStart
        '        OutFlg = &H61
        'End Select
        If sender Is btnMvUpStart Then
            OutFlg = &H60
        End If
        If sender Is btnDownStart Then
            OutFlg = &H61
        End If
        '増圧のフラグをPLCへ出力
        PlcIf.AnalogPlcWrite($"グループ{GroupSelect.Value}制御フラグ", OutFlg)
    End Sub

    'Private Sub btnDownStart_Click(sender As Object, e As EventArgs) Handles btnDownStart.Click
    '    PlcIf.減圧弁特性増減時間 = nudMVUpDownTime.Value
    '    '減圧のフラグをPLCへ出力
    '    PlcIf.AnalogPlcWrite($"グループ{GroupSelect.Value}制御フラグ", &H61)

    'End Sub


    Private Class clsDataSave
        Inherits clsDataBase

        Public Sub New(id As Integer, GpData As GroupPress)
            Dim LstColumn As New List(Of String)
            Dim LstData As New List(Of String)

            LstData.Add(id)
            LstData.Add($"'{GpData.SmplTime}'")


            For i As Short = 1 To InitPara.NumberGroup
                LstColumn.Add($"`ｸﾞﾙｰﾌﾟ{i}圧力`")
                LstColumn.Add($"`ｸﾞﾙｰﾌﾟ{i}SV`")
                LstColumn.Add($"`ｸﾞﾙｰﾌﾟ{i}MV`")

                LstData.Add($"'{GpData.Pv(i - 1)}'")
                LstData.Add($"'{GpData.Sv(i - 1)}'")
                LstData.Add($"'{GpData.Mv(i - 1)}'")

            Next
            LstColumn.Add("`シールドジャッキ圧力`")
            LstData.Add($"'{GpData.JkPress}'")


            'Dim recDataSave As Odbc.OdbcDataReader =
            ExecuteSqlCmd($"REPLACE INTO flex減圧弁テストデータ (`ID`,`時間`,{String.Join(",", LstColumn.ToArray)  }) VALUES({String.Join(",", LstData.ToArray)}  )")

        End Sub
    End Class

End Class