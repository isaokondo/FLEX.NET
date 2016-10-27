Imports FLEX.NET

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




    Public Sub New()
        Dim DB As New clsDataBase

         Dim tb As Odbc.OdbcDataReader = DB.ExecuteSql("SELECT * FROM flexシュミレーション設定 ")
        With tb
            While tb.Read
                Select Case .Item("項目")
                    Case "LeftStrokeAdr"
                        _LeftStrokeAdr = .Item("値")
                    Case "RightStrokeAdr"
                        _RightStrokeAdr = .Item("値")
                    Case "JkPresAdr"
                        _JkPresAdr = .Item("値")
                    Case "GpPresPV"
                        _GpPresPV = .Item("値")
                    Case "GpPresMV"
                        _GpPresMV = .Item("値")
                    Case "BitStartAdr"
                        _BitStartAdr = .Item("値")
                    Case "KussinOn"
                        _KussinOn = .Item("値")
                    Case "JackSel"
                        _JackSel = .Item("値")
                    Case "FlexMode"
                        _FlexMode = .Item("値")
                    Case "StrokePlcScale"
                        _StrokePlcScale = .Item("値")
                    Case "StrokeEngScale"
                        _StrokeEngScale = .Item("値")
                    Case "PresPlcScale"
                        _PresPlcScale = .Item("値")
                    Case "PresEngScale"
                        _PresEngScale = .Item("値")
                    Case "GpMvPlcScale"
                        _GpMvPlcScale = .Item("値")
                    Case "GpMvEngScale"
                        _GpMvEngScale = .Item("値")
                    Case "SpeedPlcScale"
                        _SpeedPlcScale = .Item("値")
                    Case "SpeedEngScale"
                        _SpeedEngScale = .Item("値")
                    Case "LeftSpeedAdr"
                        _LeftSpeedAdr = .Item("値")
                    Case "RightSpeedAdr"
                        _RightSpeedAdr = .Item("値")
                    Case "PitchingAdr"
                        _PitchingAdr = .Item("値")
                    Case "GyairoAdr"
                        _GyairoAdr = .Item("値")
                    Case "ExcavOrSegmentAdr"
                        _ExcavOrSegmentAdr = .Item("値")
                    Case "PullBackOnAdr"
                        _PullBackOnAdr = .Item("値")
                    Case "PullBackAnsAdr"
                        _PullBackAnsAdr = .Item("値")
                    Case "ClosetOnAdr"
                        _ClosetOnAdr = .Item("値")
                    Case "ClosetAnsAdr"
                        _ClosetAnsAdr = .Item("値")
                    Case "PullBackCommand"
                        _PullBackCommand = .Item("値")
                    Case "ClosetCommand"
                        _ClosetCommand = .Item("値")
                    Case "AddClosetCommand"
                        _AddClosetCommand = .Item("値")
                    Case "LosZeroStMachine"
                        _LosZeroStMachine = .Item("値")
                    Case "LosZeroStFlex"
                        _LosZeroStFlex = .Item("値")
                    Case "LosZeroModeMachine"
                        _LosZeroModeMachine = .Item("値")
                    Case "LosZeroEnable"
                        _LosZeroEnable = .Item("値")

                End Select
            End While
        End With


    End Sub



End Class
