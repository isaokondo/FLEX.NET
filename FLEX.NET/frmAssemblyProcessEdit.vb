Imports System.Math
Public Class frmAssemblyProcessEdit
    Private SegAsbly As New clsSegmentAssembly ''セグメント組立データ

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        ConfirmRingNo.Value = PlcIf.RingNo
        OperattionJackSel.SelectItem = "引戻,押込,押込推進,追加推進,RL考慮"
        StartJackNo.MaxValue = InitParameter.NumberJack
        LastJackNo.MaxValue = InitParameter.NumberJack
        OperattionJackSel.ComboBox.SelectedIndex = 0    '未選択時の処理

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub ConfirmRingNo_ValueChanged(sender As Object, e As EventArgs) Handles ConfirmRingNo.ValueChanged,
        AssemblyPieceNo.ValueChanged, OperattionJackSel.ValueChanged

        If IsNothing(OperattionJackSel.SelectItem) Then Exit Sub

        '入力されたリング番号より組立パターン読込
        SegAsbly.sbSegmentAssemblyDataRead(ConfirmRingNo.Value)

        AssemblyPatternSel.SelectItem =
            String.Join(",", SegAsbly.SegmentAssemblyPatternList) '組立パターンリスト　選択用
        AssemblySegmentSel.SelectItem =
            String.Join(",", SegAsbly.SegmentTypeList) 'セグメント種別　選択用

        '組立パターンの表示
        AssemblyPatternSel.ComboBox.Text = SegAsbly.SegmentAssenblyPtn(ConfirmRingNo.Value)
        DspAssemblyPattern.Value = SegAsbly.SegmentAssenblyPtn(ConfirmRingNo.Value)

        With SegAsbly.SegmentProcessData(AssemblyPieceNo.Value)
            'TODO:組立セグメント、組立ﾎﾞﾙﾄﾋﾟｯﾁの取込
            DspAssemblyPieace.Value = .PieceName  '組立ピース名称
            DspPullBackJack.Value = SegmentAssembly.JackListDsp(.PullBackJack) '引戻しジャッキ
            DspClosetJack.Value = SegmentAssembly.JackListDsp(.ClosetJack) '押込みジャッキ
            DspAddClosetThrustJack.Value = SegmentAssembly.JackListDsp(.AddClosetJack) '追加押込みジャッキ


            AssemblyPieceNo.MaxValue = SegAsbly.AssemblyPieceNumber '組立ピース番号MAX値設定

            '作動ジャッキの表示
            If OperattionJackSel.ComboBox.SelectedIndex = -1 Then
                OperattionJackSel.ComboBox.SelectedIndex = 0    '未選択時の処理
            End If
            Dim jkLst As New List(Of Short)
            Select Case OperattionJackSel.ComboBox.SelectedItem
                Case "引戻"
                    jkLst = .PullBackJack
                Case "押込"
                    jkLst = .ClosetJack
                Case "押込推進"
                    'DspStartLastJack()
                Case "追加推進"
                    jkLst = .AddClosetJack
                Case "RL考慮"
                    'TODO:左右のローリングの区別　DBへの反映をどうするか？
            End Select
            DspStartLastJack(jkLst)
            ImgDsp(jkLst)


        End With
        'MAXのピース番号内で表示
        If SegmentAssembly.AssemblyPieceNumber > AssemblyPieceNo.Value Then
            DspNextPieceName.Value =
            SegmentAssembly.SegmentProcessData(AssemblyPieceNo.Value + 1).PieceName '組立次ピース名称
        Else
            DspNextPieceName.Value = "-------"
        End If



    End Sub


    Private Sub DspStartLastJack(t As List(Of Short))
        Dim j(1) As Short

        Select Case t.Count
            Case 0
                j(0) = 0 : j(1) = 0
            Case 1
                j(0) = t(0) : j(1) = t(0)
            Case Is > 1
                j(0) = t(0)
                j(1) = t(t.Count - 1)
        End Select

        StartJackNo.Value = j(0)
        LastJackNo.Value = j(1)
    End Sub

    ''' <summary>
    ''' 組立パターン、順序の
    ''' イメージ表示
    ''' </summary>
    ''' <param name="t"></param>
    Private Sub ImgDsp(t As List(Of Short))

        Dim canvas As New Bitmap(picAssemblySeg.Width, picAssemblySeg.Height)

        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(Color.White)  '消去

        Dim fnt As New Font("Arial", 8) 'ジャッキ番号の表示フォント

        Dim CenterPos As Point =
            New Point(picAssemblySeg.Width / 2,
                       picAssemblySeg.Height / 2)
        Dim MaxRadios As Integer = picAssemblySeg.Width / 2 - 1


        'DrawACircle(Pens.Black, g, CenterPos, MaxRadios - 1)
        'DrawACircle(Pens.Black, g, CenterPos, MaxRadios * 0.95)
        'FillACircle(New SolidBrush(Color.FromArgb(224, 219, 215)), g, CenterPos, MaxRadios * 0.8)


        Dim Rd As Integer = MaxRadios * 0.95
        Dim p2 As New Pen(Color.Black, 1)
        DrawACircle(p2, g, CenterPos, Rd)
        Dim p4 As New Pen(Color.Black, 1)
        DrawACircle(p4, g, CenterPos, Rd - 20)




        'ジャッキ番号の表示
        For i = 0 To InitParameter.NumberJack - 1

            Dim FaiJ As Single = InitParameter.FaiJack(i)

            'ワールド座標系リセット
            g.ResetTransform()

            'ジャッキ○の中心位置
            Dim CircleCenter As Point = New Point(MaxRadios * 0.8 * Cos(FaiJ * PI / 180) + CenterPos.X,
                                 -MaxRadios * 0.8 * Math.Sin(FaiJ * PI / 180) + CenterPos.Y)

            '選択時ジャッキを黄色塗るつぶし
            For Each k As Short In t
                If i = k - 1 Then
                    FillACircle(Brushes.Yellow, g, CircleCenter, 10)
                End If
            Next
            'ジャッキ外枠
            DrawACircle(p4, g, CircleCenter, 10)

            '文字回転用
            '移動
            g.TranslateTransform(MaxRadios * 0.7 * Cos(FaiJ * PI / 180) + CenterPos.X,
                                 -MaxRadios * 0.7 * Sin(FaiJ * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / InitParameter.NumberJack * i + IIf(InitParameter.FirstJackLoc = "top",
                                                                       0, 360 / InitParameter.NumberJack / 2)) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString,
                         fnt, Brushes.Black,
                         IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)

        Next


        'セグメント　ピース名称表示
        For Each Qw As clsSegmentAssembly.AsseblyProcess
                                        In SegAsbly.SegmentProcessData.Values



            g.ResetTransform() 'ワールド座標系リセット

            If AssemblyPieceNo.Value = Qw.AssemblyOrder Then
                Dim p As New Pen(Color.Cyan, 17) '幅10
                Dim d As Integer = Rd * 0.957
                g.DrawArc(p, New RectangleF(CenterPos.X - d, CenterPos.Y - d, d * 2, d * 2),
                          Qw.PieceCenterAngle - Qw.PieceAngle / 2 - 90, Qw.PieceAngle)

            End If

            Dim Angle As Single = (90 - Qw.PieceAngle / 2 - Qw.PieceCenterAngle) * PI / 180
            Dim pX As Integer = CenterPos.X + Rd * Cos(Angle)
            Dim pY As Integer = CenterPos.Y - Rd * Sin(Angle)
            Dim p2X As Integer = CenterPos.X + (Rd - 20) * Cos(Angle)
            Dim p2Y As Integer = CenterPos.Y - (Rd - 20) * Sin(Angle)

            g.DrawLine(Pens.Black, New Point(p2X, p2Y), New Point(pX, pY))
            '文字回転用
            g.TranslateTransform(Rd * 0.98 * Cos((90 - Qw.PieceCenterAngle) * PI / 180) + CenterPos.X,
                      -Rd * 0.98 * Sin((90 - Qw.PieceCenterAngle) * PI / 180) + CenterPos.Y)
            g.RotateTransform(Qw.PieceCenterAngle)




            Dim StColor As Brush = IIf(AssemblyPieceNo.Value = Qw.AssemblyOrder, Brushes.Red, Brushes.Black)

            'ピース名称表示
            g.DrawString(Qw.PieceName, fnt, StColor, New Point(-Qw.PieceName.Length * fnt.Size / 2, 0))


        Next




        g.Dispose()
        picAssemblySeg.BackgroundImage = canvas

    End Sub





End Class