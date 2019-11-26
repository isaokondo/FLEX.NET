Imports System.ComponentModel
Public Class ucnDspData
    ''' <summary>
    ''' 小数点位置
    ''' </summary>
    ''' <remarks></remarks>
    Private _DecimalPlaces As Short
    Private _ValueData As String
    Private _FieldName As String
    Private _Unit As String
    ''' <summary>
    ''' 数値か文字列か？
    ''' </summary>
    Private _ValueType As Boolean = False
    ''' <summary>
    ''' 点滅時のカラー
    ''' </summary>
    Private _BlinkColor As Color = Color.Red
    '点滅
    Private _Blink As Boolean
    Private _TextAlign As ContentAlignment = ContentAlignment.MiddleRight

    'ブリンクフラグ
    Private flg As Boolean

    Public Shadows Event DoubleClick(sender As Object, e As EventArgs)
    '既定のフォントサイズ
    Private DefaultFiledFont As Font


    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        DefaultFiledFont = lblFieldName.Font

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    <Browsable(True), Description("データが文字列か数値　文字列：true 数値:false")>
    Public Property ValueType As Boolean
        Get
            Return _ValueType
        End Get
        Set(value As Boolean)
            _ValueType = value
        End Set
    End Property

    Public Property FieldNameWidth As Integer
        Get
            Return lblFieldName.Width
        End Get
        Set(value As Integer)
            lblFieldName.Width = value
            lblData.Left = lblFieldName.Location.X + lblFieldName.Width

            AdjustFontSiza()
            lblUnit.Left = lblData.Left + lblData.Width

        End Set
    End Property

    Private ToolTipStr As String
    <Browsable(True), Description("ToolTipの文")>
    Public Property ToolTipText As String
        Get
            Return ToolTipStr
        End Get
        Set(value As String)
            ToolTipStr = value
            ToolTip1.SetToolTip(lblFieldName, ToolTipStr)
            ToolTip1.SetToolTip(lblData, ToolTipStr)
            ToolTip1.SetToolTip(lblUnit, ToolTipStr)
        End Set
    End Property

    <Browsable(True), Description("項目名の設定")>
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
            lblFieldName.Text = Space(1) & value

            AdjustFontSiza()

        End Set
    End Property

    ''' <summary>
    ''' フォントサイズの調整
    ''' </summary>
    Private Sub AdjustFontSiza()
        With lblFieldName
            .Font = DefaultFiledFont

            '            If .Width > TextRenderer.MeasureText(.Text, DefaultFont).Width Then
            '           Else
            Do Until .Width >= TextRenderer.MeasureText(.Text, .Font).Width
                .Font = New Font(.Font.FontFamily, .Font.Size - 1, .Font.Style)
            Loop
            '          End If
        End With

    End Sub

    Public Property DataWidth As Integer
        Get
            Return lblData.Width
        End Get
        Set(value As Integer)
            lblData.Width = value
            lblUnit.Left = lblData.Left + lblData.Width
        End Set
    End Property

    <Browsable(True), Description("単位")>
    Public Property Unit As String
        Get
            Return _Unit
        End Get
        Set(value As String)
            _Unit = value
            lblUnit.Text = value
        End Set
    End Property
    <Browsable(True), Description("単位なし")>
    Public Property UnitVisible As Boolean
        Get
            Return lblUnit.Visible
        End Get
        Set(value As Boolean)
            lblUnit.Visible = value
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
            Call sbIndustrialValueSet()
        End Set
    End Property

    <Browsable(True)>
    Public Property Value As String
        Get
            Return _ValueData
        End Get
        Set(value As String)
            _ValueData = value
            Call sbIndustrialValueSet()
        End Set
    End Property

    Public Property BlinkColor As Color
        Get
            Return _BlinkColor
        End Get
        Set(value As Color)
            _BlinkColor = value
        End Set
    End Property
    <Browsable(True), Description("Data テキスト位置")>
    Public Property DataTextAlign As ContentAlignment
        Get
            '_TextAlign = lblData.TextAlign
            Return _TextAlign
        End Get
        Set(value As ContentAlignment)
            _TextAlign = value
            lblData.TextAlign = _TextAlign
        End Set
    End Property


    Public Property Blink As Boolean
        Get
            Return _Blink
        End Get
        Set(value As Boolean)
            _Blink = value
            tmrBlink.Enabled = _Blink
            If Not _Blink Then
                lblData.BackColor = Color.Black
            End If
        End Set
    End Property


    ''' <summary>
    ''' 工業値の表示 もしくは文字列
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sbIndustrialValueSet()
        If _ValueType = False And IsNumeric(_ValueData) Then
            '数値の場合は小数点付加　右寄せ
            lblData.Text = CDbl(_ValueData).ToString("F" & _DecimalPlaces.ToString)
            'lblData.TextAlign = ContentAlignment.MiddleRight
        Else
            '文字の場合はセンター
            lblData.Text = _ValueData
            'lblData.TextAlign = ContentAlignment.MiddleCenter
        End If
        lblData.TextAlign = _TextAlign
    End Sub

    Private Sub lblFieldName_Paint(sender As Object, e As PaintEventArgs) Handles lblFieldName.Paint, lblUnit.Paint, lblData.Paint
        Dim rc1 As Rectangle
        Dim lb As Label = CType(sender, Label)

        rc1 = lb.ClientRectangle


        e.Graphics.DrawRectangle(New Pen(Color.Silver, 6), rc1)
        e.Graphics.DrawRectangle(New Pen(Color.DarkGray, 3), rc1)
        e.Graphics.DrawRectangle(New Pen(Color.Gray, 1), rc1)
    End Sub

    Private Sub tmrBlink_Tick(sender As Object, e As EventArgs) Handles tmrBlink.Tick
        flg = Not flg
        lblData.BackColor = IIf(flg, Color.Black, BlinkColor)
    End Sub

    Private Sub lblFieldName_Click(sender As Object, e As EventArgs) Handles lblFieldName.Click

    End Sub

    Private Sub lblFieldName_DoubleClick(sender As Object, e As EventArgs) Handles lblFieldName.DoubleClick, lblData.DoubleClick, lblUnit.DoubleClick
        RaiseEvent DoubleClick(Me, e)
    End Sub

End Class
