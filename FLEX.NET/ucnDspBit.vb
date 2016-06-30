Imports System.ComponentModel
Public Class ucnDspBit
    '信号の状態
    Private _BitStatus As Boolean
    '項目名
    Private _FieldName As String
    'ONした時の背景色
    Private _OnBakColor As Color = Color.FromArgb(192, 255, 192)
    'OFFした時の背景色
    Private _OffBakColor As Color = Color.LightGray

    <Browsable(True)>
    Public Property OnBackColor As Color
        Get
            Return _OnBakColor
        End Get
        Set(value As Color)
            _OnBakColor = value
            Call sbDspStatus()
        End Set
    End Property

    <Browsable(True)>
    Public Property OffBackColor As Color
        Get
            Return _OffBakColor
        End Get
        Set(value As Color)
            _OffBakColor = value
            Call sbDspStatus()
        End Set
    End Property

    <Browsable(True)>
    Public Property BitStatus As Boolean
        Get
            Return _BitStatus
        End Get
        Set(value As Boolean)
            _BitStatus = value
            Call sbDspStatus()
        End Set
    End Property

    <Browsable(True)>
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
            lblFieldName.Text = _FieldName
        End Set
    End Property

    Private Sub sbDspStatus()
        With lblFieldName
            .ForeColor = IIf(_BitStatus, Color.Black, Color.Gray)
            .BackColor = IIf(_BitStatus, _OnBakColor, _OffBakColor)
        End With
    End Sub

    Private Sub ucnDspBit_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        lblFieldName.Width = Me.Width
    End Sub
End Class

