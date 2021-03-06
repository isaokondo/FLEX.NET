﻿Imports System.ComponentModel
Public Class ucnDspDataMin
    ''' <summary>
    ''' 小数点位置
    ''' </summary>
    ''' <remarks></remarks>
    Private _DecimalPlaces As Short = 0
    Private _Value As Double
    Private _FieldName As String
    Private _Unit As String

    <Browsable(True), Description("項目名の設定")>
    Public Property FieldName As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
            lblFieldName.Text = _FieldName
            lblFieldName.Text = lblFieldName.Text & "(" & _Unit & ")"
        End Set
    End Property

    <Browsable(True), Description("単位")>
    Public Property Unit As String
        Get
            Return _Unit
        End Get
        Set(value As String)
            _Unit = value
            lblFieldName.Text = _FieldName
            lblFieldName.Text = lblFieldName.Text & "(" & _Unit & ")"
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
            Return lblData.Text
        End Get
        Set(value As Double)
            _Value = value
            Call sbIndustrialValueSet()
        End Set
    End Property
    ''' <summary>
    ''' テキストの表示
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    Public Property Text As String
        Get
            Return lblData.Text
        End Get
        Set(value As String)
            '_Value = value
            lblData.Text = value
        End Set
    End Property

    ''' <summary>
    ''' 工業値の表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sbIndustrialValueSet()
        lblData.Text = _Value.ToString("F" & _DecimalPlaces.ToString) & " "
    End Sub






    Private Sub ucnDspDataMin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
