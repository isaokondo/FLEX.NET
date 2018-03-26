Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class clsSimlationSetting
    Inherits clsDataBase


    Public ReadOnly Property LeftStrokeAdr As String
    Public ReadOnly Property RightStrokeAdr As String
    Public ReadOnly Property JkPresAdr As String
    Public ReadOnly Property GpPresPV As String
    Public ReadOnly Property GpPresMV As String
    Public ReadOnly Property BitStartAdr As String
    Public ReadOnly Property KussinOn As String
    Public ReadOnly Property JackSel As String
    Public ReadOnly Property FlexMode As String
    Public ReadOnly Property StrokePlcScale As String
    Public ReadOnly Property StrokeEngScale As String
    Public ReadOnly Property GpMvPlcScale As String
    Public ReadOnly Property GpMvEngScale As String

    Public ReadOnly Property PresPlcScale As String
    Public ReadOnly Property PresEngScale As String

    Public ReadOnly Property SpeedPlcScale As String
    Public ReadOnly Property SpeedEngScale As String
    Public ReadOnly Property LeftSpeedAdr As String
    Public ReadOnly Property RightSpeedAdr As String
    Public ReadOnly Property PitchingAdr As String

    Public ReadOnly Property MachinePitchingAdr As String
    Public ReadOnly Property GyairoAdr As String
    Public ReadOnly Property ExcavOrSegmentAdr As String
    Public ReadOnly Property PullBackOnAdr As String
    Public ReadOnly Property PullBackAnsAdr As String
    Public ReadOnly Property ClosetOnAdr As String
    Public ReadOnly Property ClosetAnsAdr As String
    Public ReadOnly Property PullBackCommand As String
    Public ReadOnly Property ClosetCommand As String
    Public ReadOnly Property AddClosetCommand As String
    Public ReadOnly Property LosZeroStMachine As String
    Public ReadOnly Property LosZeroStFlex As String
    Public ReadOnly Property LosZeroModeMachine As String
    Public ReadOnly Property LosZeroEnable As String
    Public ReadOnly Property MesureJackStroke As New List(Of String)
    Public ReadOnly Property MesureJackSpeed As New List(Of String)
    Public ReadOnly Property MesureJackNo As New List(Of Short)

    Public ReadOnly Property ExecMode As String
    Public ReadOnly Property SegmentMode As String


    Public ReadOnly Property LoszeroStart As String


    Public Sub New()
        Dim DB As New clsDataBase

        Dim tb As DataTable = DB.GetDtfmSQL("SELECT * FROM flexシュミレーション設定 ")
        For Each t As DataRow In tb.Rows
            Select Case t("項目")
                Case "LeftStrokeAdr"
                    _LeftStrokeAdr = t("値")
                Case "RightStrokeAdr"
                    _RightStrokeAdr = t("値")
                Case "JkPresAdr"
                    _JkPresAdr = t("値")
                Case "GpPresPV"
                    _GpPresPV = t("値")
                Case "GpPresMV"
                    _GpPresMV = t("値")
                Case "BitStartAdr"
                    _BitStartAdr = t("値")
                Case "KussinOn"
                    _KussinOn = t("値")
                Case "JackSel"
                    _JackSel = t("値")
                Case "FlexMode"
                    _FlexMode = t("値")
                Case "StrokePlcScale"
                    _StrokePlcScale = t("値")
                Case "StrokeEngScale"
                    _StrokeEngScale = t("値")
                Case "PresPlcScale"
                    _PresPlcScale = t("値")
                Case "PresEngScale"
                    _PresEngScale = t("値")
                Case "GpMvPlcScale"
                    _GpMvPlcScale = t("値")
                Case "GpMvEngScale"
                    _GpMvEngScale = t("値")
                Case "SpeedPlcScale"
                    _SpeedPlcScale = t("値")
                Case "SpeedEngScale"
                    _SpeedEngScale = t("値")
                Case "LeftSpeedAdr"
                    _LeftSpeedAdr = t("値")
                Case "RightSpeedAdr"
                    _RightSpeedAdr = t("値")
                Case "PitchingAdr"
                    _PitchingAdr = t("値")
                Case "MachinePitchingAdr"
                    _MachinePitchingAdr = t("値")
                Case "GyairoAdr"
                    _GyairoAdr = t("値")
                Case "ExcavOrSegmentAdr"
                    _ExcavOrSegmentAdr = t("値")
                Case "PullBackOnAdr"
                    _PullBackOnAdr = t("値")
                Case "PullBackAnsAdr"
                    _PullBackAnsAdr = t("値")
                Case "ClosetOnAdr"
                    _ClosetOnAdr = t("値")
                Case "ClosetAnsAdr"
                    _ClosetAnsAdr = t("値")
                Case "PullBackCommand"
                    _PullBackCommand = t("値")
                Case "ClosetCommand"
                    _ClosetCommand = t("値")
                Case "AddClosetCommand"
                    _AddClosetCommand = t("値")
                Case "LosZeroStMachine"
                    _LosZeroStMachine = t("値")
                Case "LosZeroStFlex"
                    _LosZeroStFlex = t("値")
                Case "LosZeroModeMachine"
                    _LosZeroModeMachine = t("値")
                Case "LosZeroEnable"
                    _LosZeroEnable = t("値")

                Case "ExecMode"
                    _ExecMode = t("値")
                Case "SegmentMode"
                    _SegmentMode = t("値")

                Case "LoszeroStart"
                    _LoszeroStart = t("値")
            End Select
            '計測ジャッキの取込
            If t("項目").ToString.IndexOf("MesureJackStroke") >= 0 Then
                _MesureJackStroke.Add(t("値"))
                _MesureJackNo.Add(CShort(t("項目").ToString.Replace("MesureJackStroke", "")))
            End If

            If t("項目").ToString.IndexOf("MesureJackSpeed") >= 0 Then
                _MesureJackSpeed.Add(t("値"))
            End If


        Next


    End Sub



End Class

