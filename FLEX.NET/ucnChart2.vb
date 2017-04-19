Imports System.ComponentModel

Public Class ucnChart2
    Inherits ucnChart
    ''' <summary>
    ''' 計画方向のペン色
    ''' </summary>
    Private _ChartPlanPenColor As Color = Color.AliceBlue
    ''' <summary>
    ''' 目標方向のペン色
    ''' </summary>
    Private _ChartTargetPenColor As Color = Color.Green

    ''' <summary>
    ''' チャートの中心の値
    ''' </summary>
    Private _ChartCenterValue As Single

    ''' <summary>
    ''' チャートの中心からの絶対値
    ''' </summary>
    Private _ChartCenAbsValue As Single = 0.2

    ''' <summary>
    ''' 補正値
    ''' </summary>
    Private _CorrectData As Single
    ''' <summary>
    ''' 掘進完了のデータ
    ''' </summary>
    Public Structure gData
        Dim RingNo As Integer   'リング番号
        Dim Distance As Integer '起点から旋回中心までの距離
        Dim PlanDr As Single '計画方向
        Dim TargetDr As Single '目標方位
        Dim RealDr As Single '実測方位
    End Structure
    ''' <summary>
    ''' 掘削データ
    ''' </summary>
    Private _ExecData As List(Of gData)
    ''' <summary>
    ''' 計画線データ
    ''' </summary>
    Private _PlanData As Dictionary(Of Integer, Single)
    ''' <summary>
    ''' 掘削データ
    ''' </summary>
    Public WriteOnly Property ExecData As List(Of gData)
        Set(value As List(Of gData))
            _ExecData = value
            ChartUp() 'グラフ更新
        End Set
    End Property

    Public WriteOnly Property PlanData As Dictionary(Of Integer, Single)
        Set(value As Dictionary(Of Integer, Single))
            _PlanData = value
        End Set
    End Property



    <Browsable(True), Description("計画方向　ペンカラー")>
    Public Property ChartPanPenColor As Color
        Get
            Return _ChartPlanPenColor
        End Get
        Set(value As Color)
            _ChartPlanPenColor = value
            lblPlanColor.BackColor = value
        End Set
    End Property
    <Browsable(True), Description("目標方向　ペンカラー")>
    Public Property ChartTargetPenColor As Color
        Get
            Return _ChartTargetPenColor
        End Get
        Set(value As Color)
            _ChartTargetPenColor = value
            lblTargetColor.BackColor = value
        End Set
    End Property



    '<Browsable(True), Description("グラフ高さ（工業値)")>
    'Public Overrides Property ChartHeight As Single
    '    Get
    '        Return _ChartHeight
    '    End Get
    '    Set(value As Single)
    '        _ChartHeight = value
    '        lblGraphHigh.Text = "+" & _ChartHeight.ToString
    '        lblGraphLow.Text = "-" & _ChartHeight.ToString
    '    End Set
    'End Property
    <Browsable(True), Description("グラフの縦幅")>
    Public Property ChartHeight As Integer
        Get
            Return picChart.Height
        End Get
        Set(value As Integer)
            picChart.Height = value
            ChartClear()
        End Set
    End Property
    ''' <summary>
    ''' 計画データの数値表示
    ''' </summary>
    ''' <returns></returns>
    ''' 
    <Browsable(True), Description("計画データの数値表示")>
    Public Property PlanNumData As Single
        Get
            Return lblPlan.Text
        End Get
        Set(value As Single)
            lblPlan.Text = value.ToString("F" & _DecimalPlaces)
        End Set
    End Property
    ''' <summary>
    ''' 補正値の数値表示
    ''' </summary>
    ''' <returns></returns>
    ''' 
    <Browsable(True), Description("補正値の数値表示")>
    Public Property CorrectData As Single
        Get
            Return _CorrectData
        End Get
        Set(value As Single)
            _CorrectData = value
            lblCorrection.Text = value.ToString("F" & _DecimalPlaces)
        End Set
    End Property
    ''' <summary>
    ''' 目標値の数値表示
    ''' </summary>
    ''' <returns></returns>
    ''' 
    <Browsable(True), Description("目標値の数値表示")>
    Public Property TargetData As Single
        Get
            Return lblTarget.Text
        End Get
        Set(value As Single)
            lblTarget.Text = value.ToString("F" & _DecimalPlaces)
            _ChartCenterValue = Math.Round(value, 1)
            DspScale()
        End Set
    End Property
    ''' <summary>
    ''' 実測値の数値表示
    ''' </summary>
    ''' <returns></returns>
    ''' 
    <Browsable(True), Description("実測値の数値表示")>
    Public Property RealData As Single
        Get
            Return lblReal.Text
        End Get
        Set(value As Single)
            lblReal.Text = value.ToString("F" & _DecimalPlaces)
        End Set
    End Property
    ''' <summary>
    ''' チャートの中心の値
    ''' </summary>
    Public Property ChartCenterValue As Single
        Get
            Return _ChartCenterValue
        End Get
        Set(value As Single)
            _ChartCenterValue = value
            DspScale()
        End Set
    End Property

    ''' <summary>
    ''' チャートの中心からの絶対値
    ''' </summary>
    <Browsable(True), Description("チャートの中心からの絶対値")>
    Public Property ChartCenAbsValue As Single
        Get
            Return _ChartCenAbsValue
        End Get
        Set(value As Single)
            _ChartCenAbsValue = value
            DspScale()
        End Set
    End Property
    ''' <summary>
    ''' 目盛りの表示
    ''' </summary>
    Private Sub DspScale()
        '少数一桁表示
        lblGraphHigh.Text = (_ChartCenterValue + _ChartCenAbsValue).ToString("F1")
        lblCenter.Text = _ChartCenterValue.ToString("F1")
        lblGraphLow.Text = (_ChartCenterValue - _ChartCenAbsValue).ToString("F1")

        lblCenter.Top = picChart.Top + picChart.Height / 2 - lblCenter.Font.Size
        lblGraphLow.Top = picChart.Top + picChart.Height - lblCenter.Font.Size * 2

    End Sub


    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    ''' <summary>
    ''' チャート更新
    ''' </summary>
    Protected Overrides Sub ChartUp()
        Dim canvas As New Bitmap(picChart.Width, picChart.Height)
        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(_ChartBakColor)
        '中心線
        g.DrawLine(New Pen(_CenterColor, 1), New Point(0, picChart.Height / 2), New Point(picChart.Width, picChart.Height / 2))

        If IsNothing(_ExecData) OrElse _ExecData.Count < 2 Then
            g.Dispose()
            picChart.Image = canvas
            Exit Sub
        End If

        Dim st(2) As List(Of Point)   'ストロークから距離を
        st(0) = New List(Of Point)
        st(1) = New List(Of Point)
        st(2) = New List(Of Point)
        Dim stInit As Integer = _ExecData(0).Distance
        Dim StRingNo As Integer = _ExecData(0).RingNo
        '_StrokeWidth = _GraphData(_GraphData.Count - 1).Distance

        Dim stMax As Integer = _ExecData.Last.Distance - stInit + _PlanData.Last.Key '最終値の掘進距離をMAX
        '最終目標値を中心値に
        _ChartCenterValue = Math.Round(_ExecData.Last.TargetDr, 1)
        Dim tarMax As Single = _ExecData.Max(Function(gdata) gdata.TargetDr)
        Dim tarMin As Single = _ExecData.Min(Function(gdata) gdata.TargetDr)
        If _ChartCenAbsValue < Math.Abs(tarMax - _ChartCenterValue) Then
            _ChartCenAbsValue = Math.Abs(tarMax - _ChartCenterValue)
        End If
        If _ChartCenAbsValue < Math.Abs(tarMin - _ChartCenterValue) Then
            _ChartCenAbsValue = Math.Abs(tarMin - _ChartCenterValue)
        End If
        _ChartCenAbsValue = Math.Round(_ChartCenAbsValue, 1)
        DspScale()
        PlanNumData = _ExecData.Last.PlanDr
        TargetData = _ExecData.Last.TargetDr
        RealData = _ExecData.Last.RealDr
        CorrectData = _ExecData.Last.PlanDr - _ExecData.Last.TargetDr

        Dim Bunbo As Single = 1 / (_ChartCenAbsValue * 2) * picChart.Height

        '掘進済みデータのグラフ表示
        For Each eData In _ExecData

            Dim pt As Point
            pt.X = (eData.Distance - stInit) / stMax * picChart.Width
            pt.Y = (-eData.PlanDr + _ChartCenterValue + _ChartCenAbsValue) * Bunbo
            st(0).Add(pt) '計画方向
            pt.Y = (-eData.TargetDr + _ChartCenterValue + _ChartCenAbsValue) * Bunbo
            st(1).Add(pt) '目標方向
            pt.Y = (-eData.RealDr + _ChartCenterValue + _ChartCenAbsValue) * Bunbo
            st(2).Add(pt) '実測方向
        Next
        '計画方向
        Dim p0 As Point = st(0).First
        For Each p In st(0)
            g.DrawLine(New Pen(_ChartPlanPenColor, 2), p0, p)
            p0 = New Point(p)
        Next
        '目標方向
        p0 = st(1).First
        For Each p In st(1)
            g.DrawLine(New Pen(_ChartTargetPenColor, 2), p0, p)
            p0 = New Point(p)
        Next
        '実測方向
        p0 = st(2).First
        For Each p In st(2)
            g.DrawLine(New Pen(ChartPenColor, 2), p0, p)
            p0 = New Point(p)
        Next

        p0 = st(0).Last
        '計画方向の表示（これから掘削する指定リング先まで）
        For Each pData In _PlanData
            Dim pt As Point
            pt.X = st(0).Last.X + (pData.Key) / stMax * picChart.Width
            pt.Y = (-pData.Value + _ChartCenterValue + _ChartCenAbsValue) * Bunbo
            g.DrawLine(New Pen(_ChartPlanPenColor, 2), p0, pt)
            p0 = New Point(pt)
        Next

        p0 = st(1).Last
        '目標方向の表示（これから掘削する指定リング先まで）
        For Each pData In _PlanData
            Dim pt As Point
            pt.X = st(0).Last.X + (pData.Key) / stMax * picChart.Width
            '計画方向から補正値を引いた値
            pt.Y = (-(pData.Value - CorrectData) + _ChartCenterValue + _ChartCenAbsValue) * Bunbo
            g.DrawLine(New Pen(_ChartTargetPenColor, 2), p0, pt)
            p0 = New Point(pt)
        Next

        g.Dispose()
        picChart.Image = canvas

    End Sub

    Private Class ChartD
        Public Property pColor As Color
        Public Property Pt As Point
    End Class

    Private Sub picChart_Click(sender As Object, e As EventArgs) Handles picChart.Click

    End Sub
End Class
