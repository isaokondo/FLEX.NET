Imports System.ComponentModel

Public Class ucnChart2
    Inherits ucnChart

    <Browsable(True), Description("グラフ高さ（工業値)")>
    Public Overloads Property GraphHeight As Single
        Get
            Return _GraphHeight
        End Get
        Set(value As Single)
            _GraphHeight = value
            lblGraphHigh.Text = "+" & _GraphHeight.ToString
            lblGraphLow.Text = "-" & _GraphHeight.ToString
        End Set
    End Property
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
    Public Property PlanData As Single
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
            Return lblCorrection.Text
        End Get
        Set(value As Single)
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

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub picChart_Click(sender As Object, e As EventArgs) Handles picChart.Click

    End Sub
End Class
