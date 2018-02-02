Imports System.ComponentModel
Public Class ucnRdBtn
    ''' <summary>
    ''' 項目名
    ''' </summary>
    Private _FieldName As String
    ''' <summary>
    ''' 選択可能か？
    ''' </summary>
    Private _selectable As Boolean = True
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Me.BackColor = Color.Transparent
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub
    '    Private _rdbtnValue As Boolean
    <Browsable(True), Description("項目名の設定")>
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
            lblFieldName.Text = _FieldName
        End Set
    End Property
    <Browsable(True), Description("左の選択項目名")>
    Public Property SlectNoName As String
        Get
            Return rdbtnNo.Text
        End Get
        Set(value As String)
            rdbtnNo.Text = value
        End Set
    End Property
    <Browsable(True), Description("右の選択項目名")>
    Public Property SlectYesName As String
        Get
            Return rdbtnYes.Text
        End Get
        Set(value As String)
            rdbtnYes.Text = value
        End Set
    End Property

    Public Property Selectable As Boolean
        Get
            Return _selectable
        End Get
        Set(value As Boolean)
            rdbtnNo.Enabled = value
            rdbtnYes.Enabled = value
            lblFieldName.ForeColor = If(value, Color.White, Color.DarkGray)
        End Set
    End Property


    Public Property rdbtnValue As Boolean
        Get
            Return rdbtnNo.Checked
        End Get
        Set(value As Boolean)
            rdbtnNo.Checked = value
            'rdbtnNo.Checked = _rdbtnValue
        End Set
    End Property


End Class
