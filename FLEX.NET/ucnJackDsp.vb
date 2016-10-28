

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
    Private _JackOrgPress As Single 'ジャッキ元圧　グループ圧との割合算出用

    ''' <summary>
    ''' 自動方向制御　Auto:True　Manual:False
    ''' </summary>
    Private _FlexAutoManual As Boolean
    Private _FlexPointX As Single
    Private _FlexPointY As Single

    Private _FlexPointR As Single
    Private _FlexPointSeater As Single


    ''' <summary>
    ''' ポイントが手動入力での変化
    ''' </summary>

    Public Event ManualPointChange()
    Public Event FlexAutoManualChange()
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
    Private GrDgree As Single()
    ''' <summary>
    ''' 各グループのジャッキ本数
    ''' </summary>
    Private GrJkNum As Integer()
    ''' <summary>
    ''' グループ圧の数値表示位置
    ''' </summary>
    Private Const GpWakuRate As Single = 0.65
    ''' <summary>
    ''' 力点表示部の全体の半径の割合
    ''' </summary>
    Private Const RadousRate As Single = 0.25
    ''' <summary>
    ''' コピー表示位置
    ''' </summary>
    Private Const CopyRadiousRate As Single = 0.9
    ''' <summary>
    ''' コピー角度
    ''' </summary>
    Private _CopyAngle As Integer
    ''' <summary>
    ''' コピーストローク
    ''' </summary>
    Private _CopyStroke As Integer
    ''' <summary>
    ''' コピー伸び表示設定
    ''' </summary>
    Private _CopyStrechSet As Integer
    ''' <summary>
    ''' コピーの表示ステータス　
    ''' 0:黒　1:コピー位置(緑) 2:コピー切った場所(赤)
    ''' 5度ピッチ
    ''' </summary>
    Private CopyStatus(72) As Boolean


    ''' <summary>
    ''' グループ圧表示コントロール
    ''' </summary>
    Private GroupPvDsp() As ucnDspGpPres
    Private _JackStatus() As Short

    Private GpPvColor(9) As Color


    Private BlinkFlag As Boolean    '点滅用フラグ

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
    <Browsable(True), Description("力点X")>
    Public Property FlexPointX As Single
        Get
            Return _FlexPointX
        End Get
        Set(value As Single)
            If value <> _FlexPointX Then
                'RaiseEvent ManualPointChange()
            End If
            _FlexPointX = value
            DspPointData()
        End Set
    End Property
    <Browsable(True), Description("力点Y")>
    Public Property FlexPointY As Single
        Get
            Return _FlexPointY
        End Get
        Set(value As Single)
            If value <> _FlexPointY Then
                'RaiseEvent ManualPointChange()
            End If
            _FlexPointY = value
            DspPointData()
        End Set
    End Property

    <Browsable(True), Description("操作強")>
    Public Property FlexPointR As Single
        Get
            Return _FlexPointR
        End Get
        Set(value As Single)
            _FlexPointR = value
            lblPointR.Text = _FlexPointR.ToString("F2")
        End Set
    End Property
    <Browsable(True), Description("操作角")>
    Public Property FlexPointSeater As Single
        Get
            Return _FlexPointSeater
        End Get
        Set(value As Single)
            _FlexPointSeater = value
            lblSeater.Text = _FlexPointSeater.ToString("F1")
        End Set
    End Property
    ''' <summary>
    ''' コピー角度
    ''' </summary>
    Public WriteOnly Property CopyAngle As Integer
        Set(value As Integer)
            _CopyAngle = value
            If _CopyAngle > 360 Then _CopyAngle = 360
            If _CopyAngle < 0 Then _CopyAngle = 0
            DspCopy()
        End Set
    End Property
    ''' <summary>
    ''' コピーストローク
    ''' </summary>
    Public WriteOnly Property CopyStroke As Integer
        Set(value As Integer)
            _CopyStroke = value
        End Set
    End Property
    <Browsable(True), Description("コピー伸び表示設定")>
    Public Property CopyStrechSet As Integer
        Get
            Return _CopyStrechSet
        End Get
        Set(value As Integer)
            _CopyStrechSet = value
            DspCopy()
        End Set
    End Property
    Public Property PieceName As New List(Of String)
    Public Property PieceAngle As New List(Of Single)
    Public Property PieceCenterAngle As New List(Of Single)
    Public Property AssemblyOrder As New List(Of Short)
    Public Property AssemblyPieceNo As Short    ''組み立てするピースの色付け用

    <Browsable(True), Description("FLEX方向制御自動/手動")>
    Public Property FlexAutoManual As Boolean
        Get
            Return _FlexAutoManual
        End Get
        Set(value As Boolean)
            '自動から手動に変化した時
            If value = False And _FlexAutoManual = True Then
                RaiseEvent ManualPointChange()
            End If

            _FlexAutoManual = value
            btnPointAutoMan.Text = IIf(_FlexAutoManual, "手動", "自動")

            imgPointXDOWN.Visible = Not _FlexAutoManual
            imgPointYDOWN.Visible = Not _FlexAutoManual
            imgPointXUP.Visible = Not _FlexAutoManual
            imgPointYUP.Visible = Not _FlexAutoManual
            btnPointCenter.Visible = Not _FlexAutoManual


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
            ReDim GrDgree(_numberGroup)
            ReDim GrJkNum(_numberGroup)
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
                GroupPvDsp(i).BringToFront()
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
            DspGpPvImg()
        End Set
    End Property
    ''' <summary>
    ''' ジャッキ元圧
    ''' </summary>
    ''' <returns></returns>
    Public Property JackOrgPress As Single
        Get
            Return _JackOrgPress
        End Get
        Set(value As Single)
            _JackOrgPress = value
            DspGpPvImg()
        End Set
    End Property

    ''' <summary>
    ''' 自動方向制御PID
    ''' </summary>
    ''' <returns></returns>
    Public Property JackAutoPid As Boolean = False
    ''' <summary>
    ''' 片押し制限中
    ''' </summary>
    ''' <returns></returns>
    Public Property JackAutoOneWayLimit = False



    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Me.DoubleBuffered = True
        Me.BackColor = Color.Transparent
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        MaxRadios = Min(Me.Width, Me.Height) / 2
        CenterPos = New Point(imgPoint.Location.X + imgPoint.Width / 2, imgPoint.Location.Y + imgPoint.Height / 2)
        MaxRadios = Min(imgPoint.Location.X + imgPoint.Width / 2, imgPoint.Location.Y + imgPoint.Height / 2)
        'MaxRadios = Min(ovsPoint.Location.X + ovsPoint.Width / 2, ovsPoint.Location.Y + ovsPoint.Height / 2)
        'CenterPos = ovsPoint.Location
        'CenterPos.Offset(ovsPoint.Width / 2, ovsPoint.Height / 2)

        'グループ圧の色設定　アプリケーション設定より読込
        GpPvColor(0) = My.Settings.GpPsColor1
        GpPvColor(1) = My.Settings.GpPsColor2
        GpPvColor(2) = My.Settings.GpPsColor3
        GpPvColor(3) = My.Settings.GpPsColor4
        GpPvColor(4) = My.Settings.GpPsColor5
        GpPvColor(5) = My.Settings.GpPsColor6
        GpPvColor(6) = My.Settings.GpPsColor7
        GpPvColor(7) = My.Settings.GpPsColor8
        GpPvColor(8) = My.Settings.GpPsColor9
        GpPvColor(9) = My.Settings.GpPsColor10

        '力点のイメージ設定
        Dim bmp As New Bitmap(My.Resources.point)
        bmp.MakeTransparent(Color.Black)
        imgPoint.BackColor = Color.Transparent
        imgPoint.Image = bmp
        picPoint.Controls.Add(imgPoint)



    End Sub



    Private Sub ucnJackDsp_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        'Dim g As Graphics = Me.CreateGraphics
        'g.DrawEllipse(Pens.Black, 0, 0, Me.Width, Me.Height)
        'g.Dispose)(
        ' Call DspBaseJack()
        If Not IsNothing(imgJackBase) Then
            'DspInitBaseImg()
            Me.BackgroundImage = imgJackBase
            DspJackStatus()
            SegmentPieceDsp()
            DspCopy()

            DspGpPvImg()
        End If


    End Sub
    ''' <summary>
    ''' ｾｸﾞﾒﾝﾄピース表示
    ''' </summary>
    Public Sub SegmentPieceDsp()

        Dim g As Graphics = Me.CreateGraphics

        Dim sWidth As Short = 20
        '外周円表示
        DrawACircle(New Pen(Color.White, sWidth), g, CenterPos, MaxRadios - sWidth / 2)
        DrawACircle(Pens.Black, g, CenterPos, MaxRadios - 1)
        DrawACircle(Pens.Black, g, CenterPos, MaxRadios - sWidth)

        'セグメント　ピース名称表示
        For i As Short = 0 To PieceName.Count - 1

            g.ResetTransform() 'ワールド座標系リセット
            '組み立てするピースの色付け
            If _AssemblyPieceNo >= _AssemblyOrder(i) Then
                Dim cl As Color
                If _AssemblyOrder(i) = _AssemblyPieceNo Then
                    cl = Color.Yellow
                Else
                    cl = Color.LightGray
                End If
                'Dim p As New Pen(IIf(_AssemblyPieceNo = _AssemblyOrder(i), Color.Yellow, Color.LightGray), 17) '幅10
                Dim p As New Pen(cl, 17)
                Dim d As Integer = MaxRadios * 0.97
                g.DrawArc(p, New RectangleF(CenterPos.X - d, CenterPos.Y - d, d * 2, d * 2),
                          _PieceCenterAngle(i) - _PieceAngle(i) / 2 - 90, _PieceAngle(i))

            End If
            Dim Rd As Integer = MaxRadios - 1

            'TODO:同じような処理が2つあるので　簡潔に！
            'セグメント区切り線
            Dim Angle As Single = (90 - _PieceAngle(i) / 2 - _PieceCenterAngle(i)) * PI / 180
            Dim pX As Integer = CenterPos.X + Rd * Cos(Angle)
            Dim pY As Integer = CenterPos.Y - Rd * Sin(Angle)
            Dim p2X As Integer = CenterPos.X + (Rd - sWidth) * Cos(Angle)
            Dim p2Y As Integer = CenterPos.Y - (Rd - sWidth) * Sin(Angle)

            g.DrawLine(Pens.Black, New Point(p2X, p2Y), New Point(pX, pY))

            Angle = (90 + _PieceAngle(i) / 2 - _PieceCenterAngle(i)) * PI / 180
            Dim pX2 As Integer = CenterPos.X + Rd * Cos(Angle)
            Dim pY2 As Integer = CenterPos.Y - Rd * Sin(Angle)
            Dim p2X2 As Integer = CenterPos.X + (Rd - 20) * Cos(Angle)
            Dim p2Y2 As Integer = CenterPos.Y - (Rd - 20) * Sin(Angle)

            g.DrawLine(Pens.Black, New Point(p2X2, p2Y2), New Point(pX2, pY2))



            Rd -= 2
            '文字回転用
            g.TranslateTransform(Rd * Cos((90 - _PieceCenterAngle(i)) * PI / 180) + CenterPos.X,
                      -Rd * Sin((90 - _PieceCenterAngle(i)) * PI / 180) + CenterPos.Y)
            g.RotateTransform(PieceCenterAngle(i))


            'Dim StColor As Brush = IIf(AssemblyPieceNo.Value = Qw.AssemblyOrder, Brushes.Red, Brushes.Black)
            Dim fnt As New Font("MS UI Gothic", 12) 'ジャッキ番号の表示フォント
            '組立順序、ピース名称表示
            g.DrawString("[" & _AssemblyOrder(i) & "] " & _PieceName(i), fnt, Brushes.Black, New Point(-_PieceName(i).Length * fnt.Size / 2, 0))


        Next




        g.Dispose()

    End Sub

    ''' <summary>
    ''' グループの分割表示（初期画面)
    ''' </summary>
    Public Sub DspInitBaseImg()

        If IsNothing(_JackGroupPos) Or IsNothing(_faiJack) Or IsNothing(GrDgree) Or IsNothing(GroupPvDsp) Then Exit Sub

        '最大半径及び中心位置

        imgJackBase = New Bitmap(Me.Width, Me.Height)

        Dim g As Graphics = Graphics.FromImage(imgJackBase)

        g.Clear(Color.Transparent)  '消去

        Dim fnt As New Font("Arial", 8) 'ジャッキ番号、グループ番号の表示フォント

        FillACircle(New SolidBrush(Color.FromArgb(224, 219, 215)), g, CenterPos, MaxRadios * 0.8)

        'グループの区切り線
        Dim i As Integer
        For i = 0 To _numberJack - 1
            ''グループの区切り線
            If _JackGroupPos(i) <> _JackGroupPos(IIf((i + 1) = _numberJack, 0, i + 1)) Then
                Dim St As Single = (_faiJack(i) - 360 / _numberJack / 2)

                Dim ps As Point() =
                    {New Point(MaxRadios * 0.8 * Cos(St * PI / 180) + CenterPos.X,
                               -MaxRadios * 0.8 * Sin(St * PI / 180) + CenterPos.Y),
                               CenterPos}
                g.DrawLines(Pens.Black, ps)

                GrDgree(_JackGroupPos(i) - 1) = St

            Else
            End If
            GrJkNum(_JackGroupPos(i) - 1) += 1

        Next

        Dim Rd As Integer = MaxRadios * 0.82
        Dim p2 As New Pen(Color.Black, 2)
        DrawACircle(p2, g, CenterPos, Rd)
        Dim p3 As New Pen(Color.DarkGray, 4)
        DrawACircle(p3, g, CenterPos, Rd - 3)
        Dim p4 As New Pen(Color.Black, 1)
        DrawACircle(p4, g, CenterPos, Rd - 5)

        Dim PointRate As Single = 0.55

        '力点数値表示の塗りつぶし
        FillACircle(New SolidBrush(Color.FromArgb(1, 36, 64)), g, CenterPos, MaxRadios * PointRate)


        'ジャッキ番号の表示,ジャッキステータスの表示
        For i = 0 To _numberJack - 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(MaxRadios * 0.85 * Cos(_faiJack(i) * PI / 180) + CenterPos.X,
                                 -MaxRadios * 0.85 * Sin(_faiJack(i) * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / _numberJack * i + IIf(_firstJackLoc = "top", 0, 360 / _numberJack / 2)) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString, fnt, Brushes.Black, IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)

        Next


        PointRate -= 0.03
        GrDgree(_numberGroup) = GrDgree(0)
        For i = 0 To _numberGroup - 1
            'グループの中心角度
            Dim j As Integer = IIf(i - 1 < 0, _numberGroup - 1, i - 1)
            Dim r As Single = IIf(GrDgree(i) < GrDgree(j), (GrDgree(j) + GrDgree(i)) / 2, (GrDgree(j) + GrDgree(i) + 360) / 2)
            'グループ圧の表示位置
            GroupPvDsp(i).Location = New Point(MaxRadios * GpWakuRate * Cos(r * PI / 180) + CenterPos.X - GroupPvDsp(i).Width / 2,
                               -MaxRadios * GpWakuRate * Sin(r * PI / 180) + CenterPos.Y - GroupPvDsp(i).Height / 2)

            GroupPvDsp(i).Value = i + 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(MaxRadios * PointRate * Cos(r * PI / 180) + CenterPos.X,
                                 -MaxRadios * PointRate * Sin(r * PI / 180) + CenterPos.Y)
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
            'g.TranslateTransform(CenterPos.X * 0.85 * Cos(_faiJack(i) * PI / 180) + CenterPos.X,
            '                     -CenterPos.Y * 0.85 * Sin(_faiJack(i) * PI / 180) + CenterPos.Y)
            g.TranslateTransform(MaxRadios * 0.85 * Cos(_faiJack(i) * PI / 180) + CenterPos.X,
                                 -MaxRadios * 0.85 * Sin(_faiJack(i) * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / _numberJack * i + IIf(_firstJackLoc = "top", 0, 360 / _numberJack / 2)) '回転

            'TODO:ロスゼロの表示色の割付
            Dim JackBrush As SolidBrush = Brushes.Black
            'If Not IsNothing(_JackStatus) Then
            'Select Case _JackStatus(i)
            '    Case 0  '非選択
            '        JackBrush = Brushes.DarkGray
            '    Case 1  '選択稼働中
            '        JackBrush = Brushes.Red
            '    Case 2  '減圧中
            '        JackBrush = IIf(BlinkFlag, Brushes.Red, Brushes.Orange)
            'End Select
            'End If
            Dim JackBit(15) As Boolean
            For j As Short = 0 To 15
                JackBit(j) = _JackStatus(i) And 2 ^ j
            Next
            JackBrush = Brushes.DarkGray
            If JackBit(0) Then  '選択
                JackBrush = Brushes.Red
            End If
            If JackBit(2) Then  '減圧中
                JackBrush = IIf(BlinkFlag, Brushes.Red, Brushes.Orange)
            End If
            'If JackBit(3) Then  '引戻し指令
            '    JackBrush = Brushes.Purple
            'End If
            If JackBit(5) Then  '引戻し中
                JackBrush = IIf(BlinkFlag, Brushes.Purple, Brushes.MediumPurple)
            End If
            If JackBit(8) Then  '押込み中
                JackBrush = IIf(BlinkFlag, Brushes.YellowGreen, Brushes.Yellow)
            End If
            If JackBit(9) Then  '対抗ジャッキ
                JackBrush = IIf(BlinkFlag, Brushes.Purple, Brushes.MediumPurple)
            End If
            If JackBit(10) Then  '押込み推進
                JackBrush = IIf(BlinkFlag, Brushes.YellowGreen, Brushes.Yellow)
            End If
            If JackBit(11) Then  'RL考慮ｼﾞｬｯｷ
                JackBrush = Brushes.Orange
            End If


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
    ''' コピー位置、ステータスの表示
    ''' </summary>
    Private Sub DspCopy()

        Dim g As Graphics = Me.CreateGraphics
        'TODO:早い回転でうまく表示されない時がある
        Dim k As Integer = CInt(_CopyAngle / 5)
        CopyStatus(k) = (_CopyStroke > _CopyStrechSet)
        Dim i As Integer
        '5度ピッチで７２分割
        For i = 0 To 71

            '円の表示ポイント
            Dim p As Point = CenterPos
            p.Offset _
                (MaxRadios * CopyRadiousRate * Cos((i * 5 - 90) * PI / 180),
                 MaxRadios * CopyRadiousRate * Sin((i * 5 - 90) * PI / 180))

            Dim Br As Brush '色の表示
            If k = i Then
                Br = Brushes.Green  'コピー位置
            Else
                If CopyStatus(i) Then
                    Br = Brushes.Red    '伸びた位置
                Else
                    Br = Brushes.Black
                End If
            End If

            FillACircle(Br, g, p, 5)

        Next



        g.Dispose()



    End Sub



    ''' <summary>
    ''' グループ圧のイメージ表示
    ''' </summary>
    Private Sub DspGpPvImg()
        If IsNothing(_JackStatus) Or IsNothing(_faiJack) Then Exit Sub

        Dim g As Graphics = Me.CreateGraphics
        '元圧とグループ圧の割合
        Dim GpColor As Color
        Dim d = MaxRadios * 0.55
        DrawACircle(Pens.Black, g, CenterPos, d + 5)

        Dim i As Integer
        For i = 0 To _numberGroup - 1
            '表示色を１０段階で取得
            Dim ColorIndex As Integer
            If _JackOrgPress <> 0 And _GpPv(i) <> 0 Then
                ColorIndex = Int(_GpPv(i) / _JackOrgPress * 10)
            Else
                ColorIndex = 0
            End If
            If ColorIndex > 9 Then ColorIndex = 9
            GpColor = GpPvColor(ColorIndex)

            Dim startAng As Single = 360 - GrDgree(i) '+ 0.5 '開始角度
            Dim endAng As Single = -GrJkNum(i) * 360 / _numberJack + 0.5　 'スイープ角度
            Dim p As Pen = New Pen(GpColor, 10) '幅10

            '描画
            g.DrawArc(p, New Rectangle(CenterPos.X - d, CenterPos.Y - d, d * 2, d * 2), startAng, endAng)

            Dim ps As Point() =
    {New Point((d + 5) * Cos(GrDgree(i) * PI / 180) + CenterPos.X,
               -(d + 5) * Sin(GrDgree(i) * PI / 180) + CenterPos.Y),
               New Point((d - 5) * Cos(GrDgree(i) * PI / 180) + CenterPos.X,
               -(d - 5) * Sin(GrDgree(i) * PI / 180) + CenterPos.Y)}
            g.DrawLines(Pens.Black, ps)
        Next

        g.Dispose()

    End Sub
    ''' <summary>
    ''' 力点手動操作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub imgPoint_Click(sender As Object, e As EventArgs) _
        Handles imgPointYUP.Click, imgPointXDOWN.Click, imgPointXUP.Click, imgPointYDOWN.Click, btnPointCenter.Click

        If sender Is imgPointYUP Then
            _FlexPointY += 0.05
        End If
        If sender Is imgPointYDOWN Then
            _FlexPointY -= 0.05
        End If
        If sender Is imgPointXUP Then
            _FlexPointX += 0.05
        End If
        If sender Is imgPointXDOWN Then
            _FlexPointX -= 0.05
        End If
        'Cボタンの処理
        If sender Is btnPointCenter And (_FlexPointX <> 0 Or _FlexPointY <> 0) Then
            Dim r As Double = Math.Abs(Math.Atan(_FlexPointX / _FlexPointY))
            _FlexPointX -= 0.05 * Math.Sin(r) * Math.Sign(_FlexPointX)
            _FlexPointY -= 0.05 * Math.Cos(r) * Math.Sign(_FlexPointY)
            If Abs(_FlexPointX) <= 0.05 Then _FlexPointX = 0
            If Abs(_FlexPointY) <= 0.05 Then _FlexPointY = 0
        End If

        DspPointData()
        RaiseEvent ManualPointChange()

    End Sub
    ''' <summary>
    ''' 力点データ表示、シンボル移動
    ''' </summary>
    Private Sub DspPointData()

        '力点表示

        'ポイントの表示
        lblPointX.Text = _FlexPointX.ToString("F2")
        lblPointY.Text = _FlexPointY.ToString("F2")
        '倍率の表示
        Dim PointDspRate As Integer = Floor(_FlexPointR) + 1
        '倍率の表示
        lblPointDspRate.Text = "☓ " & PointDspRate.ToString
        'todo:力点の座標で色変化
        Dim canvas As New Bitmap(picPoint.Width, picPoint.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)

        Dim PointRangeColor As Brush = Brushes.Black
        Select Case _FlexPointR
            Case Is < 1
                PointRangeColor = Brushes.Black
            Case 1 To 3
                PointRangeColor = Brushes.Purple
            Case Is > 3
                PointRangeColor = Brushes.Red
        End Select

        Dim PntCtr As Point
        PntCtr = New Point(picPoint.Width / 2, picPoint.Height / 2)
        Dim Rd As Integer = picPoint.Width / 2 - 1

        FillACircle(PointRangeColor, g, PntCtr, Rd)

        DrawACircle(New Pen(Color.White, 2), g, PntCtr, Rd)

        '10段階の円目盛り
        Dim p3 = New Pen(Color.Yellow, 0.1)
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
        Dim PointDia As Integer = 10
        '力点の中心座標
        Dim X As Integer = PntCtr.X + _FlexPointX / PointDspRate * canvas.Width / 2
        Dim Y As Integer = PntCtr.Y - _FlexPointY / PointDspRate * canvas.Width / 2
        'イメージの左端の座標を取得
        Dim p As New Point(X, Y)

        '力点の色設定
        Dim Pcl As Brush
        Pcl = IIf(BlinkFlag, Brushes.Blue, Brushes.Red)
        If _FlexAutoManual = False Then Pcl = Brushes.Blue
        FillACircle(Pcl, g, p, PointDia)
        DrawACircle(New Pen(Color.White, 1), g, p, PointDia)

        PointDia += 3
        'クロス線
        g.DrawLine(New Pen(Color.White, 3),
                   New Point(p.X - PointDia, p.Y),
                   New Point(p.X + PointDia, p.Y))
        g.DrawLine(New Pen(Color.White, 3),
                   New Point(p.X, p.Y - PointDia),
                   New Point(p.X, p.Y + PointDia))

        g.Dispose()

        picPoint.Image = canvas
    End Sub
    ''' <summary>
    ''' 自動方向ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPointAutoMan_Click(sender As Object, e As EventArgs) Handles btnPointAutoMan.Click
        '_FlexAutoManual = Not _FlexAutoManual '自動手動　反転
        RaiseEvent FlexAutoManualChange()
    End Sub

    Private Sub tmrCenter_Tick(sender As Object, e As EventArgs) Handles tmrCenter.Tick
        _FlexPointX = 0
        _FlexPointY = 0
        DspPointData()
        RaiseEvent ManualPointChange()

    End Sub

    Private Sub btnPointCenter_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPointCenter.MouseDown
        tmrCenter.Enabled = True
    End Sub

    Private Sub btnPointCenter_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPointCenter.MouseUp
        tmrCenter.Enabled = False
    End Sub

    Private Sub imgPoint_Click_1(sender As Object, e As EventArgs) Handles imgPoint.Click

    End Sub



    Private Sub ucnJackDsp_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged

    End Sub
    ''' <summary>
    ''' ポイントの白枠の表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lblPoint(sender As Object, e As PaintEventArgs) Handles lblPointR.Paint, lblPointX.Paint, lblPointY.Paint, lblSeater.Paint

        Dim rc1 As Rectangle
        Dim lb As Label = CType(sender, Label)

        rc1 = lb.ClientRectangle

        e.Graphics.DrawRectangle(New Pen(Color.White, 1), rc1)
    End Sub

    Private Sub tmrBlink_Tick(sender As Object, e As EventArgs) Handles tmrBlink.Tick
        BlinkFlag = Not BlinkFlag
    End Sub
End Class
