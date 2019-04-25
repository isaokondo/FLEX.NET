Public Class ucnDevImgDsp
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。






    End Sub

    Private _DevScale As Integer = 50


    Public Property P1DevPointX As Single
    Public Property P1DevPointY As Single
    Public Property P3DevPointX As Single
    Public Property P3DevPointY As Single

    Public Property DevScale As Integer
        Get
            Return _DevScale
        End Get
        Set(value As Integer)
            _DevScale = value
            lblGraphHighX.Text = value
            lblGraphHighY.Text = value
            lblGraphLowX.Text = -value
            lblGraphLowY.Text = -value
            DspUp()
        End Set
    End Property


    ''' <summary>
    ''' 正円を塗りつぶし
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Public Sub FillACircle(pen As Brush, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.FillEllipse(pen, rect)

    End Sub
    ''' <summary>
    ''' 正円を描画
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Public Sub DrawACircle(pen As Pen, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.DrawEllipse(pen, rect)

    End Sub



    Public Sub DspUp()


        Dim canvas As New Bitmap(picPoint.Width, picPoint.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)


        Dim PntCtr As Point
        PntCtr = New Point(picPoint.Width / 2, picPoint.Height / 2)
        Dim Rd As Integer = picPoint.Width / 2 - 1

        Dim PointRangeColor As Brush = Brushes.White


        FillACircle(PointRangeColor, g, PntCtr, Rd)

        DrawACircle(New Pen(Color.Black, 2), g, PntCtr, Rd)

        '10段階の円目盛り
        Dim p3 = New Pen(Color.Green, 0.1)
        For i = 1 To 9
            DrawACircle(p3, g, PntCtr, Rd / 10 * i)
        Next
        'クロス線
        g.DrawLine(p3,
                   New Point(PntCtr.X - Rd, PntCtr.Y),
                   New Point(PntCtr.X + Rd, PntCtr.Y))
        g.DrawLine(p3,
                   New Point(PntCtr.X, PntCtr.Y - Rd),
                   New Point(PntCtr.X, PntCtr.Y + Rd))

        '力点イメージの表示

        '力点の半径
        Dim PointDia As Integer = 7

        'P1
        '力点の中心座標
        Dim X As Integer = PntCtr.X + P1DevPointX / _DevScale * canvas.Width / 2
        Dim Y As Integer = PntCtr.Y - P1DevPointY / _DevScale * canvas.Width / 2
        'イメージの左端の座標を取得
        Dim p As New Point(X, Y)

        '力点の色設定
        FillACircle(New SolidBrush(lblP1Col.BackColor), g, p, PointDia)
        DrawACircle(New Pen(Color.White, 1), g, p, PointDia)

        PointDia += 3
        'クロス線
        g.DrawLine(New Pen(Color.Green, 1),
                   New Point(p.X - PointDia, p.Y),
                   New Point(p.X + PointDia, p.Y))
        g.DrawLine(New Pen(Color.Green, 1),
                   New Point(p.X, p.Y - PointDia),
                   New Point(p.X, p.Y + PointDia))


        PointDia = 7

        '力点の中心座標
        X = PntCtr.X + P3DevPointX / _DevScale * canvas.Width / 2
        Y = PntCtr.Y - P3DevPointY / _DevScale * canvas.Width / 2
        'イメージの左端の座標を取得
        p = New Point(X, Y)

        '力点の色設定
        FillACircle(New SolidBrush(lblP3Col.BackColor), g, p, PointDia)
        DrawACircle(New Pen(Color.White, 1), g, p, PointDia)

        PointDia += 3
        'クロス線
        g.DrawLine(New Pen(Color.Green, 1),
                   New Point(p.X - PointDia, p.Y),
                   New Point(p.X + PointDia, p.Y))
        g.DrawLine(New Pen(Color.Green, 1),
                   New Point(p.X, p.Y - PointDia),
                   New Point(p.X, p.Y + PointDia))








        g.Dispose()

        picPoint.Image = canvas

    End Sub



End Class
