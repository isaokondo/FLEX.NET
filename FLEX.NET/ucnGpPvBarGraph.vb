Imports System.ComponentModel
Public Class ucnGpPvBarGraph
    ''' <summary>
    ''' ジャッキ本数
    ''' </summary>
    Private _NumberGroup As Integer = 26
    ''' <summary>
    ''' グループ圧PV
    ''' </summary>
    Private _GpPv As Single()
    Private _GpFlg As Short()
    Private _PresBarGraphWidt As Single = 50

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        'PictureBox1.Size = Me.Size

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    ''' <summary>
    ''' グループ数
    ''' </summary>
    ''' <returns></returns>
    Public Property NumberGroup As Integer
        Get
            Return _NumberGroup
        End Get
        Set(value As Integer)
            _NumberGroup = value
            GpNoDsp()
        End Set
    End Property
    ''' <summary>
    ''' グループ圧PV
    ''' </summary>
    ''' <returns></returns>
    Public Property GpPv As Single()
        Get
            Return _GpPv
        End Get
        Set(value As Single())
            _GpPv = value
            If Not IsNothing(_GpPv) Then
                DspUp()
            End If
        End Set
    End Property
    ''' <summary>
    ''' グループ圧　フラグ
    ''' </summary>
    ''' <returns></returns>
    Public Property GpFlg As Short()
        Get
            Return _GpFlg
        End Get
        Set(value As Short())
            _GpFlg = value
        End Set
    End Property


    ''' <summary>
    ''' 圧力バーグラフ幅
    ''' </summary>
    ''' <returns></returns>
    Public Property PresBarGraphWidt As Single
        Get
            Return _PresBarGraphWidt
        End Get
        Set(value As Single)
            _PresBarGraphWidt = value

        End Set
    End Property

    Private Sub DspUp()

        PictureBox1.Size = Me.Size
        Dim canvas As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(Color.White)

        Dim BarStartLoc As Integer = 20
        Dim BarTopBottomMargin As Integer = 15

        Dim fnt As New Font("Arial", 8) 'ジャッキ番号、グループ番号の表示フォント

        g.DrawRectangle(New Pen(Color.Black, 1), BarStartLoc, 0, canvas.Width - BarStartLoc - 1, canvas.Height - 1)

        Dim d As Integer = (canvas.Height - BarTopBottomMargin) / (_GpPv.Count - 0) '文字間隔
        Dim i As Integer
        For i = 0 To _GpPv.Count - 1
            g.DrawString(String.Format("{0,2}", i + 1), fnt, Brushes.Black, New Point(0, d * i + BarStartLoc / 2))
            Dim BarLength As Single = _GpPv(i) / _PresBarGraphWidt * canvas.Width * 0.8

            Dim BarColor As Brush = Brushes.Red
            Select Case _GpFlg(i)
                Case cDirect    'ダイレクト指令制御
                    BarColor = Brushes.Purple
                Case cPIDOut, cFillPower    'PID制御
                    BarColor = Brushes.Red
                Case cTracking, cIgnoreOut  'トラッキング
                    BarColor = Brushes.Yellow
            End Select

            g.FillRectangle(BarColor, BarStartLoc + 1, d * i + BarTopBottomMargin, BarLength, 10)
        Next

        g.Dispose()

        PictureBox1.Image = canvas

    End Sub





    Private Sub GpNoDsp()

        Dim g As Graphics = Me.CreateGraphics
        g.Clear(Color.Transparent)

        Dim fnt As New Font("Arial", 8) 'ジャッキ番号、グループ番号の表示フォント

        Dim d As Integer = Me.Height / _NumberGroup * 0.95 '文字間隔
        Dim i As Integer
        For i = 0 To _NumberGroup - 1
            g.DrawString((i + 1).ToString, fnt, Brushes.Black, New Point(0, d * i))
        Next


    End Sub

    Private Sub ucnGpPvBarGraph_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        GpNoDsp()
    End Sub
End Class
