Imports System.ComponentModel

Public Class ucnChart
    ''' <summary>
    ''' 小数点位置
    ''' </summary>
    ''' <remarks></remarks>
    Friend _DecimalPlaces As Short = 0
    Protected _StrokeWidth As Integer = 1500
    Friend _ChartHeight As Single = 1000
    ''' <summary>
    ''' チャート背景色
    ''' </summary>
    Private _ChartBakColor As Color = Color.White
    ''' <summary>
    ''' チャート　ペンの色
    ''' </summary>
    Private _ChartPenColor As Color = Color.Red

    Private _CenterColor As Color = Color.Black

    Public ChartList As New Dictionary(Of Integer, Single)

    Private Pt0 As Point = Nothing

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ChartClear()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    <Browsable(True), Description("凡例文字列")>
    Public Property FieldName As String
        Get
            Return lblLegend.Text
        End Get
        Set(value As String)
            lblLegend.Text = value
        End Set
    End Property
    <Browsable(True), Description("グラフ幅（ストロークmm）")>
    Public Property StrokeWidth As Integer
        Get
            Return _StrokeWidth
        End Get
        Set(value As Integer)
            _StrokeWidth = value
        End Set
    End Property
    <Browsable(True), Description("小数点桁数")>
    Public Property DecimalPlaces As Short
        Get
            Return _DecimalPlaces
        End Get
        Set(value As Short)
            _DecimalPlaces = value
        End Set
    End Property
    <Browsable(True), Description("グラフ高さ（工業値)")>
    Public Property ChartHighScale As Single
        Get
            Return _ChartHeight
        End Get
        Set(value As Single)
            _ChartHeight = value
            lblGraphHigh.Text = "+" & _ChartHeight.ToString
            lblGraphLow.Text = "-" & _ChartHeight.ToString
        End Set
    End Property
    <Browsable(True), Description("チャート背景色")>
    Public Property ChartBakColor As Color
        Get
            Return _ChartBakColor
        End Get
        Set(value As Color)
            _ChartBakColor = value
            ChartClear()
        End Set
    End Property
    <Browsable(True), Description("チャート　ペンカラー")>
    Public Property ChartPenColor As Color
        Get
            Return _ChartPenColor
        End Get
        Set(value As Color)
            _ChartPenColor = value
            ChartClear()
        End Set
    End Property
    <Browsable(True), Description("チャート　センターカラー")>
    Public Property CenterColor As Color
        Get
            Return _CenterColor
        End Get
        Set(value As Color)
            _CenterColor = value
            ChartClear()
        End Set
    End Property
    ''' <summary>
    ''' チャートデータ
    ''' </summary>
    ''' <param name="Stroke">ストローク</param>
    ''' <param name="Value">データ</param>
    Public Sub ChartDataAdd(ByVal Stroke As Integer, ByVal Value As Single)
        lblData.Text = Value.ToString("F" & _DecimalPlaces)

        ChartList(Stroke) = Value
        ChartUp()
    End Sub
    ''' <summary>
    ''' チャート更新
    ''' </summary>
    Protected Overridable Sub ChartUp()
        Dim canvas As New Bitmap(picChart.Width, picChart.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(ChartBakColor)
        g.DrawLine(New Pen(CenterColor, 2), New Point(0, picChart.Height / 2), New Point(picChart.Width, picChart.Height / 2))
        Pt0 = Nothing
        For Each p In ChartList
            Dim pt2 As Point
            pt2.X = p.Key / _StrokeWidth * picChart.Width
            pt2.Y = -p.Value / (_ChartHeight * 2) * picChart.Height + picChart.Height / 2
            If ChartList.Count > 1 And Pt0 <> New Point(0, 0) And pt2.X >= Pt0.X Then
                g.DrawLine(New Pen(ChartPenColor, 2), Pt0, pt2)
            End If
            Pt0 = pt2

        Next


        g.Dispose()
        picChart.Image = canvas

    End Sub
    ''' <summary>
    ''' チャート初期化
    ''' </summary>
    Public Sub ChartClear()
        ChartList.Clear()
        Pt0 = Nothing
        ChartUp()
    End Sub



End Class
