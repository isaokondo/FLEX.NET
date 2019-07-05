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


    Public ReadOnly Property MRRollingAdr As String


    Public ReadOnly Property LoszeroStart As String

    Public ReadOnly Property MachineComPls As String

    Public Sub New()
        Dim DB As New clsDataBase

        Dim tb As DataTable = DB.GetDtfmSQL("SELECT * FROM flexシュミレーション設定 ")
        For Each t As DataRow In tb.Rows
            Select Case t("項目")
                Case "LeftStrokeAdr"
                    _LeftStrokeAdr = t("値")
                Case "RightStrokeAdr"
                    RightStrokeAdr = t("値")
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

                Case "MRRollingAdr"
                    _MRRollingAdr = t("値")
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

                Case "MachineComPls"
                    _MachineComPls = t("値")

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

Public Class NumericUpDownColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New NumericUpDownCell)
    End Sub

    Public Overrides Property CellTemplate As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(value As DataGridViewCell)
            MyBase.CellTemplate = value
        End Set
    End Property

End Class

Public Class NumericUpDownCell
    Inherits DataGridViewTextBoxCell

    Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
        Dim ctl As NumericUpDownCellEditingControl = DataGridView.EditingControl
        If Me.Value <> Nothing Then
            ctl.Value = Decimal.Parse(Me.Value.ToString())
        End If
    End Sub

    Public Overrides ReadOnly Property EditType As Type
        Get
            'Return MyBase.EditType
            Return GetType(NumericUpDownCellEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType As Type
        Get
            'Return MyBase.ValueType
            Return GetType(Decimal)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue As Object
        Get
            'Return MyBase.DefaultNewRowValue
            Return CDec(0)
        End Get
    End Property

    Public Overrides Function ParseFormattedValue(formattedValue As Object, cellStyle As DataGridViewCellStyle, formattedValueTypeConverter As ComponentModel.TypeConverter, valueTypeConverter As ComponentModel.TypeConverter) As Object
        'Return MyBase.ParseFormattedValue(formattedValue, cellStyle, formattedValueTypeConverter, valueTypeConverter)
        Return MyBase.ParseFormattedValue(formattedValue.ToString(), cellStyle, formattedValueTypeConverter, valueTypeConverter)
    End Function

End Class

Public Class NumericUpDownCellEditingControl
    Inherits NumericUpDown
    Implements IDataGridViewEditingControl

    Private DataGridView As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndex As Integer

    Public Property EditingControlFormattedValue() As Object _
Implements IDataGridViewEditingControl.EditingControlFormattedValue

        Get
            Return MyBase.Value
        End Get

        Set(ByVal value As Object)
            Dim newValue As String = value
            If newValue <> Nothing Then
                MyBase.Value = Decimal.Parse(newValue)
            End If
        End Set
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object _
Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return EditingControlFormattedValue
    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) _
Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
    End Sub

    Public Property EditingControlRowIndex() As Integer _
Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndex 'rowindexNum?
        End Get
        Set(ByVal value As Integer)
            rowIndex = value 'rowindexNum?
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        EditingControlWantsInputKey = False
        Select Case key & Keys.KeyCode
            Case Keys.Left
            Case Keys.Up
            Case Keys.Down
            Case Keys.Right
                EditingControlWantsInputKey = True
            Case Else
                EditingControlWantsInputKey = False
        End Select
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No preparation needs to be done.
    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean _
Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    Public Property EditingControlDataGridView() As DataGridView _
Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return DataGridView
        End Get
        Set(ByVal value As DataGridView)
            DataGridView = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean _
Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set
    End Property

    Public ReadOnly Property EditingPanelCursor() As Cursor _
Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
        valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
    End Sub
End Class