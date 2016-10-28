Imports System.ComponentModel
Imports System.Drawing
Public Class ucnDspDevImg
    Private _HorDev As Double
    Private _VerDev As Double

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    <Browsable(True)>
    Public Property HorDev As Double
        Get
            Return _HorDev
        End Get
        Set(value As Double)
            If value <> _HorDev Then
                _HorDev = value
                DspUpdate()
            End If
        End Set
    End Property
    <Browsable(True)>
    Public Property VerDev As Double
        Get
            Return _VerDev
        End Get
        Set(value As Double)
            If value <> _VerDev Then
                _VerDev = value
                DspUpdate()
            End If
        End Set
    End Property
    ''' <summary>
    ''' 偏角画面更新
    ''' </summary>
    Private Sub DspUpdate()
        'Dim g As Graphics = CreateGraphics()
        Dim g As Graphics = Me.CreateGraphics

        'g.Clear(Color.White)  '消去


        ''偏角の座標変換
        Dim X As Single = Me.Height / 2 + _HorDev * Me.Height
        Dim Y As Single = Me.Height / 2 - _VerDev * Me.Height

        If X < 0 Then X = 0
        If Y < 0 Then Y = 0
        If X > Me.Height Then X = Me.Height
        If Y > Me.Height Then Y = Me.Height

        Dim Div As Integer = 255  ''色（線）分割数

        Dim PicWd As Integer = Me.Height ''ピクチャーの大きさ（正方形）
        'intPicWd = picHensaDsp.ScaleHeight

        ''四角形描画
        For i As Short = 1 To Div
            ''色を変更　2001/05/08
            Dim LinePen As New Pen(ColorTranslator.FromOle(RGB(255 - i, 255 - i * 1, 255 - i)), 1)

            Dim p As Point() =
                 {
                 New Point(X / Div * i, Y / Div * i),
                 New Point(X / Div * i, PicWd - (PicWd - Y) / Div * i),
                 New Point(PicWd - (PicWd - X) / Div * i, PicWd - (PicWd - Y) / Div * i),
                 New Point(PicWd - (PicWd - X) / Div * i, Y / Div * i),
                 New Point(X / Div * i, Y / Div * i)
            }

            g.DrawLines(LinePen, p)

        Next

        g.Dispose()
    End Sub

    Private Sub ucnDspDevImg_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DspUpdate()
    End Sub
End Class
