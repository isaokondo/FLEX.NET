Public Class frmGraphScaleChange
    '水平or鉛直 True:水平　False：鉛直
    Private _HorVer As Boolean

    Public Sub New(Value As Boolean)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        _HorVer = Value

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    'Public Property HorVer As Boolean
    '    Get
    '        Return _HorVer
    '    End Get
    '    Set(value As Boolean)
    '        _HorVer = value
    '    End Set
    'End Property

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click, btnOK.Click

        If _HorVer Then
            My.Settings.HorDevChartHigh = nudHighScale.Value
            My.Settings.HorDevChartLow = nudLowScale.Value
        Else
            My.Settings.VerDevChartHigh = nudHighScale.Value
            My.Settings.VerDevChartLow = nudLowScale.Value
        End If



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmGraphScaleChange_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If _HorVer Then
            nudHighScale.Value = My.Settings.HorDevChartHigh
            nudLowScale.Value = My.Settings.HorDevChartLow

        Else
            nudHighScale.Value = My.Settings.VerDevChartHigh
            nudLowScale.Value = My.Settings.VerDevChartLow


        End If

    End Sub



End Class