Public Class frmSim

    Public InitParm As New FLEX.NET.clsInitParameter '初期値パラメータ

    Private WithEvents ComPlc As ACTMULTILib.ActEasyIF

    Private DspGpPv() As FLEX.NET.ucnDspGpPres
    Private DspGpMv() As Label
    Private JackSel() As CheckBox



    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        ComPlc = New ACTMULTILib.ActEasyIF
        ComPlc.ActLogicalStationNumber = InitParm.ActLogicalStationNumber   'PLC論理局


        Dim iRet As Long = PLC_Open() 'オープン処理
        If iRet <> 0 Then
            MsgBox("シーケンサと通信出来ません！" & vbCrLf _
                   & "論理局番：" & ComPlc.ActLogicalStationNumber.ToString, MsgBoxStyle.Exclamation)
            End
        End If



    End Sub

#Region " Open処理 "

    Private Function PLC_Open() As Long

        Dim iReturnCode As Long              'Actコントロールのメソッドの戻り値

        'Open関数処理
        '
        Try
            'Open関数処理の実行
            iReturnCode = ComPlc.Open()

            '例外処理
        Catch exception As Exception
            MessageBox.Show(exception.Message, "PLC_OPEN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
            Exit Function
        End Try

        'Actコントロールのメソッドの戻り値の表示(8桁の16進数)
        '        txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode)
        Return iReturnCode
    End Function

    Private Sub frmSimlation_Load(sender As Object, e As EventArgs) Handles Me.Load

        tmrPlcWR.Enabled = True

        ReDim DspGpPv(InitParm.NumberGroup)
        ReDim DspGpMv(InitParm.NumberGroup)
        ReDim JackSel(InitParm.NumberJack)

        Dim i As Integer
        'ジャッキ選択
        For i = 0 To InitParm.NumberJack
            Dim Deg As Single = (i * 360 / InitParm.NumberJack - 90) / 180 * Math.PI
            JackSel(i) = New CheckBox
            JackSel(i).Text = (i + 1).ToString
            JackSel(i).Location =
                New Point(Me.Height / 2 + 380 * Math.Cos(Deg),
                          Me.Height / 2 + 380 * Math.Sin(Deg))
            JackSel(i).Size = New Size(45, 18)
            Me.Controls.Add(JackSel(i))
            AddHandler JackSel(i).Click, AddressOf Me.JackSelectChange
        Next



        For i = 0 To InitParm.NumberGroup - 1
            DspGpPv(i) = New FLEX.NET.ucnDspGpPres
            DspGpMv(i) = New Label
            Dim Deg As Single = (i * 360 / InitParm.NumberGroup - 90) / 180 * Math.PI
            DspGpPv(i).Location =
                New Point(Me.Height / 2 + 270 * Math.Cos(Deg),
                          Me.Height / 2 + 270 * Math.Sin(Deg))
            DspGpMv(i).Location =
            New Point(DspGpPv(i).Location.X,
                      DspGpPv(i).Location.Y + DspGpPv(i).Height)
            DspGpMv(i).Size = DspGpPv(i).Size
            DspGpMv(i).BackColor = Color.Transparent
            DspGpMv(i).TextAlign = ContentAlignment.MiddleRight
            Me.Controls.Add(DspGpPv(i))
            Me.Controls.Add(DspGpMv(i))
        Next


    End Sub

    ''' <summary>
    ''' ジャッキ選択変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub JackSelectChange(ByVal sender As Object, ByVal e As EventArgs)
        Debug.Print(DirectCast(sender, CheckBox).Text)
        Dim J As CheckBox = DirectCast(sender, CheckBox)
        Dim iRet = ComPlc.SetDevice(fnGetBitAdr(My.Settings.JackSel + CInt(J.Text) - 1), IIf(J.Checked, 1, 0))

    End Sub
    Private Sub tmrPlcWR_Tick(sender As Object, e As EventArgs) Handles tmrPlcWR.Tick

        'PLC読込
        Dim iRet As Long
        Dim plcData As Integer

        '掘進中
        iRet = ComPlc.GetDevice(fnGetBitAdr(My.Settings.KussinOn), plcData)
        If iRet = 0 Then chkExcavOn.Checked = plcData

        'FLEX ON
        iRet = ComPlc.GetDevice(fnGetBitAdr(My.Settings.FlexMode), plcData)
        If iRet = 0 Then chkFlexOn.Checked = plcData

        '元圧
        iRet = ComPlc.GetDevice(My.Settings.JkPresAdr, plcData)
        nudSoucePressure.Value = fnChangePresAnalogIn(plcData)

        '左ストローク
        iRet = ComPlc.GetDevice(My.Settings.LeftStrokeAdr, plcData)
        nudLeftStroke.Value = fnChangeStrokeAnalogIn(plcData)

        '右ストローク
        iRet = ComPlc.GetDevice(My.Settings.RightStrokeAdr, plcData)
        nudRightStroke.Value = fnChangeStrokeAnalogIn(plcData)

        '左ｽﾋﾟｰﾄﾞ
        iRet = ComPlc.GetDevice(My.Settings.LeftSpeedAdr, plcData)
        nudLeftSpeed.Value = fnChangeSpeedAnalogIn(plcData)

        '右ｽﾋﾟｰﾄﾞ
        iRet = ComPlc.GetDevice(My.Settings.RightSpeedAdr, plcData)
        nudRightSpeed.Value = fnChangeSpeedAnalogIn(plcData)
        Dim i As Integer

        'グループ圧PV
        Dim plcGpPv() As Integer
        ReDim plcGpPv(InitParm.NumberGroup)
        iRet = ComPlc.ReadDeviceBlock(My.Settings.GpPresPV, InitParm.NumberGroup, plcGpPv(0))
        For i = 0 To InitParm.NumberGroup - 1
            DspGpPv(i).Value = fnChangePresAnalogIn(plcGpPv(i))
        Next

        Dim plcGpMv() As Integer
        ReDim plcGpMv(InitParm.NumberGroup)
        iRet = ComPlc.ReadDeviceBlock(My.Settings.GpPresMV, InitParm.NumberGroup, plcGpMv(0))
        For i = 0 To InitParm.NumberGroup - 1
            DspGpMv(i).Text = (fnChangePresAnalogIn(plcGpMv(i)) / My.Settings.PresEngScale * 100).ToString & "%"
        Next



        'ジャッキ選択
        Dim plcJkData() As Integer
        ReDim plcJkData(CInt(InitParm.NumberJack / 16) + 1)
        iRet = ComPlc.ReadDeviceBlock(fnGetBitAdr(My.Settings.JackSel), plcJkData.Length, plcJkData(0))

        '２進数の文字列に変更
        Dim JkSts As String = ""
        For i = 0 To plcJkData.Length - 1
            JkSts = Convert10to2(plcJkData(i)) & JkSts
        Next

        For i = 0 To InitParm.NumberJack - 1
            JackSel(i).Checked = JkSts(JkSts.Length - i - 1).Equals("1"c)
            JackSel(i).BackColor = IIf(JackSel(i).Checked, Color.Red, Color.Transparent)
        Next





    End Sub

#End Region
    ''' <summary>
    ''' 機能：10進数を2進数に変換する。
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    Public Function Convert10to2(Value As Integer) As String

        Dim strData As String = ""

        Dim i As Integer
        For i = 0 To 15
            If (Value And 2 ^ i) <> 0 Then
                strData = "1" & strData
            Else
                strData = "0" & strData
                End If
            Next

        Return strData

    End Function


    Private Function fnGetBitAdr(intOffsetAdr) As String

        Dim lngBaseAdr As Long = CLng("&H" & (Mid(My.Settings.BitStartAdr, 2)))
        Return "B" & Hex(lngBaseAdr + intOffsetAdr)

    End Function
    ''' <summary>
    ''' ストロークデータ入力変換スケール
    ''' </summary>
    ''' <param name="PlcData"></param>
    ''' <returns>PLCからの    ''' データ</returns>
    Private Function fnChangeStrokeAnalogIn(PlcData As Integer) As Single
        Return PlcData / My.Settings.StrokePlcScale * My.Settings.StrokeEngScale
    End Function

    Private Function fnChangeStrokeAnalogOut(OrData As Single) As Integer
        Return OrData / My.Settings.StrokeEngScale * My.Settings.StrokePlcScale
    End Function


    Private Function fnChangeSpeedAnalogIn(PlcData As Integer) As Single
        Return PlcData / My.Settings.SpeedPlcScale * My.Settings.SpeedEngScale
    End Function

    Private Function fnChangeSpeedAnalogOut(OrData As Single) As Integer
        Return OrData / My.Settings.SpeedEngScale * My.Settings.SpeedPlcScale
    End Function


    Private Function fnChangePresAnalogIn(PlcData As Integer) As Single
        Return PlcData / My.Settings.PresPlcScale * My.Settings.PresEngScale
    End Function
    Private Function fnChangePresAnalogOut(OrData As Single) As Integer
        Return OrData / My.Settings.PresEngScale * My.Settings.PresPlcScale
    End Function
    ''' <summary>
    ''' FLEXモード、掘進中　変化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkChange(sender As Object, e As EventArgs) Handles chkExcavOn.CheckedChanged, chkFlexOn.CheckedChanged
        tmrPlcWR.Enabled = False
        Dim OffsetAdr As Integer
        'FLEXモード
        If sender Is chkFlexOn Then
            OffsetAdr = My.Settings.FlexMode
        End If
        '掘進中
        If sender Is chkExcavOn Then
            OffsetAdr = My.Settings.KussinOn
        End If
        '屈伸してない時は、
        If Not chkExcavOn.Checked Then
            nudLeftSpeed.Value = 0
            nudRightSpeed.Value = 0
        End If


        Dim iRet As Long =
            ComPlc.SetDevice(fnGetBitAdr(OffsetAdr), DirectCast(sender, CheckBox).Checked)

        tmrPlcWR.Enabled = True

    End Sub
    ''' <summary>
    ''' 元圧、ストローク、ｽﾋﾟｰﾄﾞ変化時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) _
        Handles nudSoucePressure.ValueChanged, nudRightStroke.ValueChanged,
        nudLeftStroke.ValueChanged, nudRightSpeed.ValueChanged, nudLeftSpeed.ValueChanged

        Dim FieldName As String = New StackFrame(1).GetMethod.Name
        'タイマー停止
        tmrPlcWR.Enabled = False

        Dim NumObj As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim PlcAdress As String = ""
        Dim PlcWriteData As Integer
        With My.Settings
            Select Case NumObj.Name
                Case nudLeftStroke.Name
                    PlcAdress = .LeftStrokeAdr
                    PlcWriteData = fnChangeStrokeAnalogOut(NumObj.Value)
                Case nudRightStroke.Name
                    PlcAdress = .RightStrokeAdr
                    PlcWriteData = fnChangeStrokeAnalogOut(NumObj.Value)

                Case nudLeftSpeed.Name
                    PlcAdress = .LeftSpeedAdr
                    PlcWriteData = fnChangeSpeedAnalogOut(NumObj.Value)
                Case nudRightSpeed.Name
                    PlcAdress = .RightSpeedAdr
                    PlcWriteData = fnChangeSpeedAnalogOut(NumObj.Value)


                Case nudSoucePressure.Name
                    PlcAdress = .JkPresAdr
                    PlcWriteData = fnChangePresAnalogOut(NumObj.Value)
            End Select
        End With

        Dim iRet As Long = ComPlc.SetDevice(PlcAdress, PlcWriteData)

        tmrPlcWR.Enabled = True

    End Sub


    ''' <summary>
    ''' ジャッキ全選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnJackAllSelect_Click(sender As Object, e As EventArgs) Handles btnJackAllSelect.Click
        Dim i As Integer
        For i = 0 To InitParm.NumberJack - 1
            Dim iRet = ComPlc.SetDevice(fnGetBitAdr(My.Settings.JackSel + i), 1)
        Next
    End Sub
End Class