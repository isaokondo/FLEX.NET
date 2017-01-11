Public Class frmTuningTrend
    ''' <summary>
    ''' データ個数（１秒１つ）
    ''' </summary>
    Private NumberData As Integer = 360
    Dim tmrData As Timer

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

        GroupSelect.MaxValue = InitParameter.NumberGroup

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

        'Debug.Print("MVの最後       " & LstGroupPress(LstGroupPress.Count - 1).Mv(0))
        'Debug.Print("MVの最後-100   " & LstGroupPress(LstGroupPress.Count - 100).Mv(0))

        'Debug.Print("SVの最後       " & LstGroupPress(LstGroupPress.Count - 1).Sv(0))
        'Debug.Print("SVの最後-100   " & LstGroupPress(LstGroupPress.Count - 100).Sv(0))

        '時刻の表示
        lblNowTime.Text = Now.ToLongTimeString

        lbl5minBefore.Text = Now.AddMinutes(-5).ToLongTimeString

        ChartUp()


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
            x += picChart.Width / NumberData

            Dim y As Integer
            y = (1 - gp.Sv(GroupSelect.Value) / InitParameter.JackMaxOilPres) * picChart.Height
            psSv.Add(New Point(x, y))

            y = (1 - gp.Pv(GroupSelect.Value) / InitParameter.JackMaxOilPres) * picChart.Height
            psPv.Add(New Point(x, y))

            y = (1 - gp.JkPress / InitParameter.JackMaxOilPres) * picChart.Height
            psPress.Add(New Point(x, y))

            y = (1 - gp.Mv(GroupSelect.Value) / 100) * picChart.Height
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




    Private Sub frmTuningTrend_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblHighPress.Text = InitParameter.JackMaxOilPres.ToString("F1") & " Mpa"


        TimerRun()
    End Sub

    Private Sub frmTuningTrend_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tmrData.Stop()
    End Sub
End Class