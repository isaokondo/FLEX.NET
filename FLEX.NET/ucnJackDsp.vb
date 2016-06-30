

Imports System.ComponentModel
Imports System.Drawing
Imports System.Math

''' <summary>
''' ジャッキ状態表rm示
''' </summary>
''' <remarks></remarks>
Public Class ucnJackDsp
    Private _numberJack As Short = 16           '使用ジャッキ本数
    Private _numberGroup As Short = 5         '分割数

    ''' <summary>
    ''' ジャッキ取付位置(degree)
    ''' </summary>
    Private _faiJack() As Single
    Private _JackGroupPos() As Short              'ジャッキの所属するグループ番号
    Private _firstJackLoc As String = "right"            'No1ジャッキの位置 top or left
    Private _GpPv() As Single       'グループ圧力

    'Private _JackStatus() As Short    'ジャッキステータス表示 0:非選択　1:選択

    ''' <summary>
    ''' 初期画面
    ''' </summary>
    Private imgJackBase As Image = Nothing
    ''' <summary>
    ''' ジャッキのステータス表示（選択、非選択、等の情報表示)
    ''' </summary>

    Private MaxRadios As Integer    ''描画の最大半径
    ''' <summary>
    ''' 描画領域の中心位置
    ''' </summary>
    Private CenterPos As Point
    ''' <summary>
    ''' グループの開始角度
    ''' </summary>
    Private GrRad As Single()
    ''' <summary>
    ''' グループ圧の数値表示位置
    ''' </summary>
    Private Const GpWakuRate As Single = 0.65
    ''' <summary>
    ''' グループ圧表示コントロール
    ''' </summary>
    Private GroupPvDsp() As ucnDspGpPres
    Private _JackStatus() As Short

    ''' <summary>
    ''' ジャッキの状態表示
    ''' </summary>
    ''' <returns></returns>
    Public Property JackStatus As Short()
        Get
            Return _JackStatus
        End Get
        Set(value As Short())
            'todo:値がへんかしたときのみ描画するように
            'If value.Equals(_JackStatus) = False Then
            _JackStatus = value
            Call DspJackStatus()
            'End If
        End Set
    End Property

    <Browsable(True), Description("使用ジャッキ本数"), DefaultValue(16)>
    Public Property NumberJack As Short
        Get
            Return _numberJack
        End Get
        Set(value As Short)
            _numberJack = value
            ReDim _JackStatus(_numberJack)
        End Set
    End Property

    <Browsable(True), Description("分割数"), DefaultValue(5)>
    Public Property NumberGroup As Short
        Get
            Return _numberGroup
        End Get
        Set(value As Short)
            _numberGroup = value
            ReDim GrRad(_numberGroup)
            ReDim _GpPv(_numberGroup)
            'コントロールがある場合は消去
            Dim c As Control
            For Each c In Me.Controls
                If TypeOf c Is ucnDspGpPres Then
                    Me.Controls.Remove(c)
                End If
            Next

            ReDim GroupPvDsp(_numberGroup)

            Dim i As Short
            For i = 0 To _numberGroup - 1
                GroupPvDsp(i) = New ucnDspGpPres
                GroupPvDsp(i).Visible = True
                GroupPvDsp(i).Name = "GroupPvDsp" & i
                Me.Controls.Add(GroupPvDsp(i))
            Next

            Me.Refresh()

        End Set
    End Property

    <Browsable(True), Description("ジャッキ取付位置")>
    Public Property FaiJack As Single()
        Get
            Return _faiJack
        End Get
        Set(value As Single())
            _faiJack = value
        End Set
    End Property

    <Browsable(True), Description("ジャッキの所属するグループ番号")>
    Public Property JackGroupPos As Short()
        Get
            Return _JackGroupPos
        End Get
        Set(value As Short())
            _JackGroupPos = value
            Me.Refresh()

        End Set
    End Property

    <Browsable(True), Description("No1ジャッキの位置"), DefaultValue("right")>
    Public Property FirstJackLoc As String
        Get
            Return _firstJackLoc
        End Get
        Set(value As String)
            _firstJackLoc = value
            Me.Refresh()

        End Set
    End Property

    ''' <summary>
    ''' グループ圧PVの表示
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True), Description("グループ圧力PV")>
    Public Property GroupPV As Single()
        Get
            Return _GpPv
        End Get
        Set(value As Single())
            _GpPv = value
        End Set
    End Property

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        MaxRadios = Min(Me.Width, Me.Height) - 2
        CenterPos = New Point(MaxRadios, MaxRadios)

    End Sub

    Private Sub ucnJackDsp_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        'Dim g As Graphics = Me.CreateGraphics
        'g.DrawEllipse(Pens.Black, 0, 0, Me.Width, Me.Height)
        'g.Dispose)(
        ' Call DspBaseJack()
        If Not IsNothing(imgJackBase) Then
            Me.BackgroundImage = imgJackBase
            Call DspJackStatus()
        End If


    End Sub


    ''' <summary>
    ''' グループの分割表示（初期画面)
    ''' </summary>
    Public Sub DspInitBaseImg()

        If IsNothing(_JackGroupPos) Or IsNothing(_faiJack) Or IsNothing(GrRad) Or IsNothing(GroupPvDsp) Then Exit Sub

        '最大半径及び中心位置
        MaxRadios = Min(Me.Width, Me.Height) / 2
        CenterPos = New Point(MaxRadios, MaxRadios)

        imgJackBase = New Bitmap(Me.Width, Me.Height)

        Dim g As Graphics = Graphics.FromImage(imgJackBase)

        g.Clear(Color.Transparent)  '消去

        Dim fnt As New Font("Arial", 8) 'ジャッキ番号、グループ番号の表示フォント


        'グループの区切り線
        Dim i As Integer
        For i = 0 To _numberJack - 1
            ''グループの区切り線
            If _JackGroupPos(i) <> _JackGroupPos(IIf((i + 1) = _numberJack, 0, i + 1)) Then
                Dim St As Single = (_faiJack(i) - 360 / _numberJack / 2)
                Dim ps As Point() =
                    {New Point(CenterPos.X * 0.8 * Cos(St * PI / 180) + CenterPos.X,
                               -CenterPos.Y * 0.8 * Sin(St * PI / 180) + CenterPos.Y),
                               CenterPos}
                g.DrawLines(Pens.Black, ps)


                GrRad(_JackGroupPos(i) - 1) = St
            End If

        Next

        DrawACircle(Pens.Black, g, CenterPos, MaxRadios - 1)
        DrawACircle(Pens.Black, g, CenterPos, MaxRadios * 0.95)

        Dim p2 As New Pen(Color.Black, 2)
        DrawACircle(p2, g, CenterPos, MaxRadios * 0.8)
        '1,30,64

        FillACircle(Brushes.MidnightBlue, g, CenterPos, MaxRadios * 0.5)

        FillACircle(Brushes.Black, g, CenterPos, MaxRadios * 0.25)

        DrawACircle(Pens.White, g, CenterPos, MaxRadios * 0.25)

        'ジャッキ番号の表示,ジャッキステータスの表示
        For i = 0 To _numberJack - 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(CenterPos.X * 0.85 * Cos(_faiJack(i) * PI / 180) + CenterPos.X,
                                 -CenterPos.Y * 0.85 * Sin(_faiJack(i) * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / _numberJack * i + IIf(_firstJackLoc = "top", 0, 360 / _numberJack / 2)) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString, fnt, Brushes.Black, IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)


        Next



        GrRad(_numberGroup) = GrRad(0)
        For i = 0 To _numberGroup - 1
            'グループの中心角度
            Dim j As Integer = IIf(i - 1 < 0, _numberGroup - 1, i - 1)
            Dim r As Single = IIf(GrRad(i) < GrRad(j), (GrRad(j) + GrRad(i)) / 2, (GrRad(j) + GrRad(i) + 360) / 2)
            'グループ圧の表示位置
            GroupPvDsp(i).Location = New Point(CenterPos.X * GpWakuRate * Cos(r * PI / 180) + CenterPos.X - GroupPvDsp(i).Width / 2,
                               -CenterPos.Y * GpWakuRate * Sin(r * PI / 180) + CenterPos.Y - GroupPvDsp(i).Height / 2)

            GroupPvDsp(i).Value = i + 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(CenterPos.X * 0.45 * Cos(r * PI / 180) + CenterPos.X,
                                 -CenterPos.Y * 0.45 * Sin(r * PI / 180) + CenterPos.Y)
            g.RotateTransform(90 - r) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString, fnt, Brushes.White, IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)
            'ジャッキステータス（色識別の表示)



        Next

        fnt.Dispose()
        g.Dispose()


        Me.Invalidate()
    End Sub

    ''' <summary>
    ''' ジャッキステータスの表示
    ''' </summary>
    Public Sub DspJackStatus()

        If IsNothing(_JackStatus) Or IsNothing(_faiJack) Then Exit Sub

        Dim g As Graphics = Me.CreateGraphics


        'ジャッキステータスの表示
        Dim i As Short
        For i = 0 To _numberJack - 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(CenterPos.X * 0.85 * Cos(_faiJack(i) * PI / 180) + CenterPos.X,
                                 -CenterPos.Y * 0.85 * Sin(_faiJack(i) * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / _numberJack * i + IIf(_firstJackLoc = "top", 0, 360 / _numberJack / 2)) '回転

            Dim JackBrush As SolidBrush = Brushes.Black
            'If Not IsNothing(_JackStatus) Then
            Select Case _JackStatus(i)
                    Case 0  '非選択
                        JackBrush = Brushes.DarkGray
                    Case 1  '選択稼働中
                        JackBrush = Brushes.Red

                End Select
            'End If
            'ジャッキステータス（色識別の表示)
            g.FillRectangle(JackBrush, -12, 20, 24, 15) '四角形の中心を０

        Next

        g.Dispose()

        'グループ圧の表示
        For i = 0 To _numberGroup - 1
            GroupPvDsp(i).Value = _GpPv(i)
        Next



    End Sub




    ''' <summary>
    ''' 正円を描画
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Private Sub DrawACircle(pen As Pen, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.DrawEllipse(pen, rect)

    End Sub

    ''' <summary>
    ''' 正円を塗りつぶし
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Private Sub FillACircle(pen As Brush, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.FillEllipse(pen, rect)

    End Sub




End Class
