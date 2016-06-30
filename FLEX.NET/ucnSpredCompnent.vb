Imports System.ComponentModel
''' <summary>
''' スプレッドシートの一行分
''' </summary>
''' <remarks>線形データ表示用</remarks>
Public Class ucnSpredCompnent
    Private _DecimalPlaces As Short = 3 '小数点桁数
    Private _Value As Double
    Private _FieldName As String    '項目名
    Private _Unit As String '単位
    Private _Dsp_Style As DspStyle  '表示形式
    Private _HeaderColor As Color   'ヘッダ色


    Public Enum DspStyle As Short   '選択方式 or 数値入力
        ''' <summary>
        ''' データ表示
        ''' </summary>
        ''' <remarks></remarks>
        DataDspType = 0
        ''' <summary>
        ''' 見出し表示
        ''' </summary>
        ''' <remarks></remarks>
        HeadDspType = 1
        ''' <summary>
        ''' サブ見出し表示
        ''' </summary>
        ''' <remarks></remarks>
        SubHeadDspType = 2
    End Enum

    <Browsable(True), Description("表示形式の選択")>
    Public Property Dsp_Style As DspStyle
        Get
            Return _Dsp_Style
        End Get
        Set(value As DspStyle)
            _Dsp_Style = value
            lblFieldName.TextAlign = _
                IIf(_Dsp_Style = DspStyle.HeadDspType, ContentAlignment.MiddleCenter, ContentAlignment.MiddleLeft)
            lblData.TextAlign = _
                IIf(_Dsp_Style = DspStyle.HeadDspType, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight)

            'ボーダースタイルの有りナシ
            Dim lblBS As Windows.Forms.BorderStyle = _
                IIf(_Dsp_Style = DspStyle.SubHeadDspType, _
                    Windows.Forms.BorderStyle.None, Windows.Forms.BorderStyle.FixedSingle)
            lblData.BorderStyle = lblBS
            lblUnit.BorderStyle = lblBS
            lblFieldName.BorderStyle = lblBS

            Select Case _Dsp_Style
                Case DspStyle.DataDspType
                Case DspStyle.HeadDspType
                    lblFieldName.Text = "項目"
                    lblData.Text = "値"
                    lblUnit.Text = "単位"
                Case DspStyle.SubHeadDspType
                    lblData.Text = ""
                    lblUnit.Text = ""

            End Select
        End Set
    End Property



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

    <Browsable(True), Description("単位")>
    Public Property Unit As String
        Get
            Return _Unit
        End Get
        Set(value As String)
            _Unit = value
            If _Dsp_Style = DspStyle.DataDspType Then
                lblUnit.Text = _Unit
            End If
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
    Public Property Value As Double
        Get
            If _Dsp_Style = DspStyle.DataDspType Then
                Return lblData.Text
            Else
                Return 0
            End If
        End Get
        Set(value As Double)
            _Value = value
            Call sbIndustrialValueSet()
        End Set
    End Property

    Public Property HeaderColor As Color
        Get
            Return _HeaderColor
        End Get
        Set(value As Color)
            _HeaderColor = value
            Dim lblBkColor As Color
            lblBkColor = IIf(Dsp_Style = DspStyle.DataDspType, Color.White, _HeaderColor)
            lblData.BackColor = lblBkColor
            lblFieldName.BackColor = lblBkColor
            lblUnit.BackColor = lblBkColor
        End Set
    End Property

    ''' <summary>
    ''' 工業値の表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sbIndustrialValueSet()
        If _Dsp_Style = DspStyle.DataDspType Then
            lblData.Text = _Value.ToString("F" & _DecimalPlaces.ToString) & " "
        End If
    End Sub

End Class
