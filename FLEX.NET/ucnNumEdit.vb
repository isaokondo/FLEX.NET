Imports System.ComponentModel
Public Class ucnNumEdit
    Private _DecimalPlaces As Short = 0 '小数点桁数
    Private _Value As Double
    Private _FieldName As String
    Private _Unit As String '単位

    Private _MaxValue As Single '最大値
    Private _MinValue As Single '最小値

    Private _DataDspWidth As Integer = 110    'データ表示幅

    Private numUDDefPointX As Integer
    Private lblUnitDefPointX As Integer
    ''' <summary>
    ''' 項目名の表示有無
    ''' </summary>
    ''' <remarks></remarks>
    Private _DspFieldName As Boolean
    ''' <summary>
    ''' 選択するアイテム
    ''' </summary>
    ''' <remarks>区切り文字を、で
    ''' </remarks>
    Private _SelectItem As String

    ''' <summary>
    ''' ツールチップタイトル
    ''' </summary>
    Private _ttTile As String = ""
    ''' <summary>
    ''' ツールチップメッセージ
    ''' </summary>
    Private _ttMsg As String = ""

    Private toolTip As New System.Windows.Forms.ToolTip()
    <Browsable(True), Description("ツールチップタイトル")>
    Public Property ttTile As String
        Get
            Return _ttTile
        End Get
        Set(value As String)
            _ttTile = value
            ToolTipSet()
        End Set
    End Property
    <Browsable(True), Description("ツールチップメッセージ")>
    Public Property ttMsg As String
        Get
            Return _ttMsg
        End Get
        Set(value As String)
            _ttMsg = value
            ToolTipSet()
        End Set
    End Property


    Private Sub ToolTipSet()
        toolTip.IsBalloon = True
        toolTip.SetToolTip(lblFieldName, _ttMsg)
        toolTip.SetToolTip(ComboBox, _ttMsg)
        toolTip.SetToolTip(numUD, _ttMsg)
        toolTip.SetToolTip(lblUnit, _ttMsg)

    End Sub


    Public Enum InputMethod As Short   '選択方式 or 数値入力
        ''' <summary>
        ''' 数値入力
        ''' </summary>
        ''' <remarks></remarks>
        NumericInputType = 0
        ''' <summary>
        ''' 選択方式（コンボボックス)
        ''' </summary>
        ''' <remarks></remarks>
        SelectType = 1
    End Enum

    Private _InputStyle As InputMethod
    ''' <summary>
    ''' データ変化時
    ''' </summary>
    Public Event ValueChanged(sender As Object, e As EventArgs)


    <Browsable(True), Description("入力方式の選択")>
    Public Property InputStyle As InputMethod
        Get
            Return _InputStyle
        End Get
        Set(value As InputMethod)
            _InputStyle = value
            ComboBox.Visible = (_InputStyle = InputMethod.SelectType)
            numUD.Visible = (_InputStyle = InputMethod.NumericInputType)

        End Set
    End Property

    <Browsable(True), Description("UPDOWNボタンの増減値")>
    Public Property Increment As Single
        Get
            Return numUD.Increment
        End Get
        Set(value As Single)
            numUD.Increment = value
        End Set
    End Property


    <Browsable(True), Description("最大値の設定")>
    Public Property MaxValue As String
        Get
            Return _MaxValue
        End Get
        Set(value As String)
            _MaxValue = value
            numUD.Maximum = _MaxValue
        End Set
    End Property

    <Browsable(True), Description("最小値の設定")>
    Public Property MinValue As String
        Get
            Return _MinValue
        End Get
        Set(value As String)
            _MinValue = value
            numUD.Minimum = _MinValue
        End Set
    End Property
    <Browsable(True), Description("項目名の表示　あり/なし")>
    Public Property DspFieldName As Boolean
        Get
            Return _DspFieldName
        End Get
        Set(value As Boolean)
            _DspFieldName = value
            With lblFieldName
                .Visible = value
                .Text = Space(1) & _FieldName
                .Location = New Point(numUDDefPointX, numUD.Location.Y)
                Dim OffsetX As Integer = IIf(.Visible, .Width + 10, 0)
                numUD.Location = New Point(numUDDefPointX + OffsetX, numUD.Location.Y)
                lblUnit.Location = New Point(lblUnitDefPointX + OffsetX, lblUnit.Location.Y)
                ComboBox.Location = numUD.Location
            End With

        End Set
    End Property

    <Browsable(True), Description("項目名の設定")>
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _DspFieldName = (value <> "")
            lblFieldName.Visible = _DspFieldName
            _FieldName = value
            lblFieldName.Text = Space(1) & _FieldName
        End Set
    End Property

    <Browsable(True), Description("単位")>
    Public Property Unit As String
        Get
            Return _Unit
        End Get
        Set(value As String)
            _Unit = value
            lblUnit.Text = Unit
        End Set
    End Property

    <Browsable(True), Description("データ表示幅")>
    Public Property DataDspWidth As Integer
        Get
            Return _DataDspWidth

        End Get
        Set(value As Integer)
            _DataDspWidth = value
            'If _InputStyle = InputMethod.SelectType Then
            ComboBox.Width = _DataDspWidth
            'Else
            numUD.Width = _DataDspWidth
            'End If

        End Set
    End Property


    ''' <summary>
    ''' 小数点桁数の設定
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>

    <Browsable(True), Description("小数点桁数")>
    Public Property DecimalPlaces As Short
        Get
            Return _DecimalPlaces
        End Get
        Set(value As Short)
            _DecimalPlaces = value
            numUD.DecimalPlaces = _DecimalPlaces
        End Set
    End Property

    <Browsable(True)>
    Public Property Value As Double
        Get
            Select Case _InputStyle
                Case InputMethod.NumericInputType
                    Return _Value
                Case InputMethod.SelectType
                    Return ComboBox.SelectedIndex
            End Select
            Return _Value
        End Get
        Set(value As Double)
            _Value = value
            Select Case _InputStyle
                Case InputMethod.NumericInputType
                    '上下限の制限
                    If _Value > numUD.Maximum Then _Value = numUD.Maximum
                    If _Value < numUD.Minimum Then _Value = numUD.Minimum
                    numUD.Value = _Value
                Case InputMethod.SelectType
                    ComboBox.SelectedIndex = _Value
            End Select
        End Set
    End Property

    ''' <summary>
    ''' 工業値の表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sbIndustrialValueSet()
        lblUnit.Text = _Value.ToString("F" & _DecimalPlaces.ToString) & " "
    End Sub
    <Browsable(True)>
    Public Property SelectItem As String
        Get
            Return _SelectItem
        End Get
        Set(value As String)
            _SelectItem = value
            Dim SItem() As String = Split(_SelectItem, ",")
            With ComboBox.Items
                .Clear()
                Dim s As String
                For Each s In SItem
                    .Add(s)
                Next
            End With
        End Set
    End Property

    Private Sub numUD_ValueChanged(sender As Object, e As EventArgs) Handles numUD.ValueChanged
        _Value = numUD.Value
        RaiseEvent ValueChanged(sender, e)
    End Sub




    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        numUDDefPointX = numUD.Location.X
        lblUnitDefPointX = lblUnit.Location.X
        toolTip.IsBalloon = True

    End Sub




    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        If Not IsNothing(_SelectItem) Then
            RaiseEvent ValueChanged(sender, e)
        End If
    End Sub

End Class



