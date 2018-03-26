Imports System.Text
Imports System.Threading

Public Class frmSim

    Public InitParm As clsInitParameter '初期値パラメータ

    Private WithEvents ComPlc As ACTMULTILib.ActEasyIF

    Private DspGpPv() As ucnDspGpPres
    Private DspGpMv() As Label
    Private JackSel() As CheckBox
    Private GpMvOutReal() As Integer '現在のグループ圧出力
    Private GpMvOutBefore() As Integer

    Private SimlationSetting As clsSimlationSetting

    Const ELEMENT_SIZE_WORD = 10        '文字列の書込み/読出し時、シーケンサ格納データ用配列の使用要素数
    Const ELEMENT_SIZE_32BITINTEGER = 2 '32bit整数の書込み/読出し時、シーケンサ格納データ用配列の使用要素数
    Const ELEMENT_SIZE_REALNUMBER = 2   '実数の書込み/読出し時、シーケンサ格納データ用配列の使用要素数
    ''' <summary>
    ''' ストロークのシュミレーション用カウンター
    ''' </summary>
    Private StrokeSimCounter() As Integer


    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim db As New clsDataBase
        'MYSQLのバージョン取得
        db.GetMySQKVersion()

        InitParm = New clsInitParameter

        SimlationSetting = New clsSimlationSetting

        ReDim GpMvOutReal(InitParm.NumberGroup - 1)
        ReDim GpMvOutBefore(InitParm.NumberGroup - 1)


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
            DspGpPv(i) = New ucnDspGpPres
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


        For i = 0 To InitParm.NumberJack - 1
            DgvLosZero.Rows.Add()
            DgvLosZero.Rows(i).Cells(0).Value = (i + 1).ToString
        Next


        For Each jkn In SimlationSetting.MesureJackNo
            DgvJackStroke.Rows.Add(jkn, 0, 0)
        Next

        ReDim StrokeSimCounter(SimlationSetting.MesureJackNo.Count - 1)

        'フォームに情報表示
        Me.Text &= $"　論理局番=[{ComPlc.ActLogicalStationNumber}] ]"




    End Sub


    ''' <summary>
    ''' ジャッキ選択変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub JackSelectChange(ByVal sender As Object, ByVal e As EventArgs)
        Debug.Print(DirectCast(sender, CheckBox).Text)
        Dim J As CheckBox = DirectCast(sender, CheckBox)
        Dim Jadr As String =
            "B" & Convert.ToString(Convert.ToInt32(SimlationSetting.JackSel.Substring(1), 16) + CInt(J.Text) - 1, 16)
        Dim iRet = ComPlc.SetDevice(Jadr, IIf(J.Checked, 1, 0))

    End Sub
    Private Sub tmrPlcWR_Tick(sender As Object, e As EventArgs) Handles tmrPlcWR.Tick


        lblTime.Text = Now.ToLongTimeString

        Dim startDt As DateTime = DateTime.Now


        'PLC読込
        Dim iRet As Long
        Dim plcData As Integer

        Dim i As Integer


        '掘進モード
        iRet = ComPlc.GetDevice(SimlationSetting.ExecMode, plcData)
        If iRet = 0 Then chkExecMode.Checked = plcData

        'セグメントモード
        iRet = ComPlc.GetDevice(SimlationSetting.SegmentMode, plcData)
        If iRet = 0 Then chkSegmentMode.Checked = plcData


        '掘進中
        iRet = ComPlc.GetDevice(SimlationSetting.KussinOn, plcData)
        If iRet = 0 Then chkExcavOn.Checked = plcData

        'FLEX ON
        iRet = ComPlc.GetDevice(SimlationSetting.FlexMode, plcData)
        If iRet = 0 Then chkFlexOn.Checked = plcData

        If InitParm.LosZeroEquip Then

            '同時施工モード
            iRet = ComPlc.GetDevice(SimlationSetting.LosZeroModeMachine, plcData)
            If iRet = 0 Then chkLosZeroMode.Checked = plcData

            '同時施工可
            iRet = ComPlc.GetDevice(SimlationSetting.LosZeroEnable, plcData)
            If iRet = 0 Then chkLosZeroEnable.Checked = plcData

        End If


        '元圧
        iRet = ComPlc.GetDevice(SimlationSetting.JkPresAdr, plcData)
        'nudSoucePressure.Value = fnChangePresAnalogIn(plcData)

        '左ストローク
        iRet = ComPlc.GetDevice(SimlationSetting.LeftStrokeAdr, plcData)
        nudLeftStroke.Value = fnChangeStrokeAnalogIn(plcData)

        '右ストローク
        iRet = ComPlc.GetDevice(SimlationSetting.RightStrokeAdr, plcData)
        nudRightStroke.Value = fnChangeStrokeAnalogIn(plcData)

        '左ｽﾋﾟｰﾄﾞ
        iRet = ComPlc.GetDevice(SimlationSetting.LeftSpeedAdr, plcData)
        nudLeftSpeed.Value = fnChangeSpeedAnalogIn(plcData)



        '右ｽﾋﾟｰﾄﾞ
        iRet = ComPlc.GetDevice(SimlationSetting.RightSpeedAdr, plcData)
        nudRightSpeed.Value = fnChangeSpeedAnalogIn(plcData)

        If Not DgvJackStroke.IsCurrentCellInEditMode Then
            '計測ジャッキの取込
            For i = 0 To SimlationSetting.MesureJackNo.Count - 1

                iRet = ComPlc.GetDevice(SimlationSetting.MesureJackStroke(i), plcData)
                DgvJackStroke.Rows(i).Cells(1).Value = fnChangeStrokeAnalogIn(plcData)

                iRet = ComPlc.GetDevice(SimlationSetting.MesureJackSpeed(i), plcData)
                DgvJackStroke.Rows(i).Cells(2).Value = fnChangeSpeedAnalogIn(plcData)

            Next


        End If


        tmrStrokeSim.Enabled = chkExcavOn.Checked

        'ピッチング
        iRet = ComPlc.GetDevice2(SimlationSetting.PitchingAdr, plcData)
        nudPitching.Value = plcData / 100

        iRet = ComPlc.GetDevice2(SimlationSetting.MachinePitchingAdr, plcData)
        nudMachinePitching.Value = plcData

        If InitParm.LosZeroEquip Then
            'ロスゼロ　fromマシン
            iRet = ComPlc.GetDevice2(SimlationSetting.LosZeroStMachine, plcData)
            nudLosZeroStatusMachin.Value = plcData

            'ロスゼロ　fromFLEX
            iRet = ComPlc.GetDevice2(SimlationSetting.LosZeroStFlex, plcData)
            nudLosZeroStsFlex.Value = plcData


        End If



        Dim sharrBufferForDeviceValue(ELEMENT_SIZE_32BITINTEGER - 1) As Short   'シーケンサ用データバッファの宣言
        iRet = ComPlc.ReadDeviceBlock2(SimlationSetting.GyairoAdr, ELEMENT_SIZE_32BITINTEGER, sharrBufferForDeviceValue(0))

        Dim byarrTemp() As Byte
        Dim byarrBufferByte(ELEMENT_SIZE_32BITINTEGER * 2 - 1) As Byte          '編集用バイトバッファの宣言
        'シーケンサ用データを一時的に受ける配列
        'シーケンサ用データバッファからバイト配列に変換
        For iNumber = 0 To ELEMENT_SIZE_32BITINTEGER - 1
            byarrTemp = BitConverter.GetBytes(sharrBufferForDeviceValue(iNumber))
            byarrBufferByte(iNumber * 2) = byarrTemp(0)
            byarrBufferByte(iNumber * 2 + 1) = byarrTemp(1)
        Next iNumber

        'バイト配列より32bit整数に変換してから、読出し用テキストボックスに格納
        nudGyairo.Value = BitConverter.ToInt32(byarrBufferByte, 0) / 100







        'グループ圧PV
        Dim plcGpPv() As Integer
        ReDim plcGpPv(InitParm.NumberGroup)
        iRet = ComPlc.ReadDeviceBlock(SimlationSetting.GpPresPV, InitParm.NumberGroup, plcGpPv(0))
        For i = 0 To InitParm.NumberGroup - 1
            DspGpPv(i).Value = fnChangePresAnalogIn(plcGpPv(i))
        Next

        Dim plcGpMv() As Integer
        ReDim plcGpMv(InitParm.NumberGroup)
        iRet = ComPlc.ReadDeviceBlock(SimlationSetting.GpPresMV, InitParm.NumberGroup, plcGpMv(0))
        For i = 0 To InitParm.NumberGroup - 1
            GpMvOutReal(i) =
                plcGpMv(i) * SimlationSetting.GpMvEngScale / SimlationSetting.GpMvPlcScale
            DspGpMv(i).Text = GpMvOutReal(i).ToString & "%"
        Next



        'ジャッキ選択
        'Dim plcJkData() As Integer
        'ReDim plcJkData(CInt(InitParm.NumberJack / 16) + 1)
        'iRet = ComPlc.ReadDeviceBlock(SimlationSetting.JackSel, plcJkData.Length, plcJkData(0))

        ''２進数の文字列に変更
        'Dim JkSts As String = ""
        'For i = 0 To plcJkData.Length - 1
        '    JkSts = Convert10to2(plcJkData(i)) & JkSts
        'Next
        Dim plcJacksel As Integer
        For i = 0 To InitParm.NumberJack - 1

            Dim Jadr As String =
            "B" & Convert.ToString(Convert.ToInt32(SimlationSetting.JackSel.Substring(1), 16) + i, 16)
            iRet = ComPlc.GetDevice(Jadr, plcJacksel)

            JackSel(i).Checked = (plcJacksel = 1)
            JackSel(i).BackColor = IIf(JackSel(i).Checked, Color.Red, Color.Transparent)
        Next

        If InitParm.LosZeroEquip Then

            '推進／組立
            LosZeroStatusRead(SimlationSetting.ExcavOrSegmentAdr, 1)
            '引戻し中
            LosZeroStatusRead(SimlationSetting.PullBackOnAdr, 2)
            '引戻しANS
            LosZeroStatusRead(SimlationSetting.PullBackAnsAdr, 3)
            '押込み中
            LosZeroStatusRead(SimlationSetting.ClosetOnAdr, 4)
            '押込みANS
            LosZeroStatusRead(SimlationSetting.ClosetAnsAdr, 5)

            '引戻し指令
            LosZeroStatusRead(SimlationSetting.PullBackCommand, 6)
            '押込み指令
            LosZeroStatusRead(SimlationSetting.ClosetCommand, 7)
            '追加押込み指令
            LosZeroStatusRead(SimlationSetting.AddClosetCommand, 8)


            '減圧開始PBのパルス化
            If nudLosZeroStatusMachin.Value = "1" Then
                iRet = ComPlc.SetDevice(SimlationSetting.LoszeroStart, 0)

            End If


        End If

        'Debug.Print(Now.ToLongTimeString)
         'Console.WriteLine(ts.TotalMinutes) ' 経過時間（分）
        Console.WriteLine(ts.TotalSeconds & "秒") ' 経過時間（秒）
        'Console.WriteLine(ts.TotalMilliseconds) ' 経過時間（ミリ秒）

    End Sub

    Private Sub LosZeroStatusRead(PlcAdr As String, ColNum As Integer)

        'ジャッキ選択
        Dim plcJkData(CInt(InitParm.NumberJack / 16) + 2) As Integer

        Dim FmAd As New clsBitAdressFormat(PlcAdr)

        Dim iRet As Long = ComPlc.ReadDeviceBlock(FmAd.FrmPlcAdr, plcJkData.Length, plcJkData(0))

        '２進数の文字列に変更
        Dim JkSts As String = ""
        For i = 0 To plcJkData.Length - 1
            JkSts = Convert10to2(plcJkData(i)) & JkSts
        Next

        For i = 0 To InitParm.NumberJack - 1
            Dim t As Boolean = JkSts(JkSts.Length - i - 1 - FmAd.OfAdr).Equals("1"c)
            DgvLosZero.Rows(i).Cells(ColNum).Value = IIf(t, "●", "")
            '            DgvLosZero.Rows(i).Cells(ColNum).Style.BackColor = IIf(t, Color.Red, Color.White)
            'JackSel(i).Checked = JkSts(JkSts.Length - i - 1).Equals("1"c)
            'JackSel(i).BackColor = IIf(JackSel(i).Checked, Color.Red, Color.Transparent)
        Next

    End Sub

    Private Class clsBitAdressFormat

        Public Property FrmPlcAdr As String
        Public Property OfAdr As Short
        Sub New(ByVal PlcAdr As String)

            'リンクアドレスの場合
            If PlcAdr(0) = "B" Then
                '最後の文字を０に
                _FrmPlcAdr = PlcAdr.Substring(0, PlcAdr.Length - 1) & "0"

                _OfAdr = Convert.ToInt32(PlcAdr.Substring(PlcAdr.Length - 1, 1), 16)


            Else
                _FrmPlcAdr = PlcAdr
                _OfAdr = 0

            End If





        End Sub
    End Class



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

            Dim lngBaseAdr As Long = CLng("&H" & (Mid(SimlationSetting.BitStartAdr, 2)))
            Return "B" & Hex(lngBaseAdr + intOffsetAdr)

        End Function
        ''' <summary>
        ''' ストロークデータ入力変換スケール
        ''' </summary>
        ''' <param name="PlcData"></param>
        ''' <returns>PLCからの    ''' データ</returns>
        Private Function fnChangeStrokeAnalogIn(PlcData As Integer) As Integer
            Return PlcData / SimlationSetting.StrokePlcScale * SimlationSetting.StrokeEngScale
        End Function

        Private Function fnChangeStrokeAnalogOut(OrData As Single) As Integer
            Return OrData / SimlationSetting.StrokeEngScale * SimlationSetting.StrokePlcScale
        End Function


        Private Function fnChangeSpeedAnalogIn(PlcData As Integer) As Single
            Return PlcData / SimlationSetting.SpeedPlcScale * SimlationSetting.SpeedEngScale
        End Function

        Private Function fnChangeSpeedAnalogOut(OrData As Single) As Integer
            Return OrData / SimlationSetting.SpeedEngScale * SimlationSetting.SpeedPlcScale
        End Function


        Private Function fnChangePresAnalogIn(PlcData As Integer) As Single
            Return PlcData / SimlationSetting.PresPlcScale * SimlationSetting.PresEngScale
        End Function
        Private Function fnChangePresAnalogOut(OrData As Single) As Integer
            Return OrData / SimlationSetting.PresEngScale * SimlationSetting.PresPlcScale
        End Function
        ''' <summary>
        ''' FLEXモード、掘進中　変化
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub chkChange(sender As Object, e As EventArgs) Handles chkExcavOn.CheckedChanged,
        chkFlexOn.CheckedChanged, chkLosZeroEnable.CheckedChanged, chkLosZeroMode.CheckedChanged,
        chkSegmentMode.CheckedChanged, chkExecMode.CheckedChanged


            tmrPlcWR.Enabled = False

            Dim PlcAdr As String = Nothing
            'FLEXモード
            If sender Is chkFlexOn Then
                PlcAdr = SimlationSetting.FlexMode
            End If

            If sender Is chkExecMode Then
                PlcAdr = SimlationSetting.ExecMode
            End If


            If sender Is chkSegmentMode Then
                PlcAdr = SimlationSetting.SegmentMode
            End If

            '掘進中
            If sender Is chkExcavOn Then
                PlcAdr = SimlationSetting.KussinOn
            End If
            '同時施工モード
            If sender Is chkLosZeroMode Then
                PlcAdr = SimlationSetting.LosZeroModeMachine
            End If
            '同時施工可
            If sender Is chkLosZeroEnable Then
                PlcAdr = SimlationSetting.LosZeroEnable
            End If



            Dim iRet As Long =
            ComPlc.SetDevice(PlcAdr, DirectCast(sender, CheckBox).Checked)

            tmrPlcWR.Enabled = True

        End Sub
    ''' <summary>
    ''' 元圧、ストローク、ｽﾋﾟｰﾄﾞ変化時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) _
        Handles nudRightStroke.ValueChanged,
        nudLeftStroke.ValueChanged, nudRightSpeed.ValueChanged, nudLeftSpeed.ValueChanged, nudPitching.ValueChanged,
        nudLosZeroStsFlex.ValueChanged, nudLosZeroStatusMachin.ValueChanged, nudMachinePitching.ValueChanged

        Dim FieldName As String = New StackFrame(1).GetMethod.Name
        'タイマー停止
        tmrPlcWR.Enabled = False

        Dim NumObj As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim PlcAdress As String = ""
        Dim PlcWriteData As Integer
        With SimlationSetting
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

                'Case nudSoucePressure.Name
                '    PlcAdress = .JkPresAdr
                '    If chkExcavOn.Checked Then
                '        PlcWriteData = fnChangePresAnalogOut(NumObj.Value)
                '    Else
                '        PlcWriteData = 0
                '    End If

                Case nudPitching.Name
                    PlcAdress = .PitchingAdr
                    PlcWriteData = NumObj.Value * 100

                Case nudMachinePitching.Name
                    PlcAdress = .MachinePitchingAdr
                    PlcWriteData = NumObj.Value

                Case nudLosZeroStatusMachin.Name
                    PlcAdress = .LosZeroStMachine
                    PlcWriteData = NumObj.Value

                Case nudLosZeroStsFlex.Name
                    PlcAdress = .LosZeroStFlex
                    PlcWriteData = NumObj.Value

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
                Dim Jadr As String
                If SimlationSetting.JackSel.StartsWith("M") Then
                    Jadr = "M" & (SimlationSetting.JackSel.Substring(1) + i)
                Else
                    Jadr = "B" & Convert.ToString((Convert.ToInt32(SimlationSetting.JackSel.Substring(1), 16) + i), 16)

                End If

                Dim iRet As Long = ComPlc.SetDevice(Jadr, 1)
            Next
        End Sub

        'Private Sub tmrLeftJack_Tick(sender As Object, e As EventArgs) Handles tmrLeftJack.Tick
        '    nudLeftStroke.Value += 1
        'End Sub

        'Private Sub tmrRightJack_Tick(sender As Object, e As EventArgs) Handles tmrRightJack.Tick
        '    nudRightStroke.Value += 1
        'End Sub
        ''' <summary>
        ''' グループ圧のシュミレーション
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub tmrAuto_Tick(sender As Object, e As EventArgs) Handles tmrAuto.Tick





        If GpMvOutReal Is Nothing Then Exit Sub

        Dim JkPes As Single
        If chkExcavOn.Checked Then
            JkPes = fnChangePresAnalogOut(nudSoucePressure.Value)
        End If
        Dim iRet As Long = ComPlc.SetDevice(SimlationSetting.JkPresAdr, JkPes)


        Dim GpPv(InitParm.NumberGroup - 1) As Integer

        If chkExcavOn.Checked Then

            For i As Short = 0 To InitParm.NumberGroup - 1
                If GpMvOutReal(i) = 100 Then
                    GpPv(i) = fnChangePresAnalogOut(nudSoucePressure.Value)
                Else
                    Dim jj As Single = GpMvOutReal(i) / 100 * numGpMvRate.Value / 100 * InitParm.JackMaxOilPres + numGpOffset.Value
                    If jj > nudSoucePressure.Value Then jj = nudSoucePressure.Value
                    GpPv(i) = fnChangePresAnalogOut(jj)
                End If
                'GpMvOutBefore(i) = GpMvOutReal(i)
            Next

        End If
        iRet = ComPlc.WriteDeviceBlock(SimlationSetting.GpPresPV, InitParm.NumberGroup, GpPv(0))

    End Sub

        Private Sub nudGyairo_ValueChanged(sender As Object, e As EventArgs) Handles nudGyairo.ValueChanged

            Dim iReturnCode As Integer                                              '戻り値
            Dim byarrBufferByte() As Byte                                           '編集用バイトバッファの宣言
            Dim sharrBufferForDeviceValue(ELEMENT_SIZE_32BITINTEGER - 1) As Short   'シーケンサ用バッファの宣言

            'エラー処理ルーチン先設定
            On Error GoTo CatchError

            '入力されたデータを32bit整数に変換し、バイト配列に代入(データ量は4バイト固定)
            byarrBufferByte = BitConverter.GetBytes(CInt(nudGyairo.Value * 100))

            'バイト配列からシーケンサ用データバッファに代入
            sharrBufferForDeviceValue(0) = BitConverter.ToInt16(byarrBufferByte, 0)
            sharrBufferForDeviceValue(1) = BitConverter.ToInt16(byarrBufferByte, 2)

            'D10から用意した32bit整数を書き込む
            iReturnCode = ComPlc.WriteDeviceBlock2(SimlationSetting.GyairoAdr,
                                                     ELEMENT_SIZE_32BITINTEGER,
                                                     sharrBufferForDeviceValue(0))


            '正常終了
            Exit Sub

CatchError:  '例外処理

            MsgBox(Err.Description(), MsgBoxStyle.Critical)
            End




        End Sub


        Private Sub DgvLosZero_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLosZero.CellDoubleClick

        If e.ColumnIndex = -1 Or Not InitParm.LosZeroEquip Then Exit Sub

        tmrPlcWR.Enabled = False

            'PLCのベースアドレス
            Dim PlcWrBaseAdress As String = ""
            Select Case e.ColumnIndex
                Case 1
                    PlcWrBaseAdress = SimlationSetting.ExcavOrSegmentAdr
                Case 2
                    PlcWrBaseAdress = SimlationSetting.PullBackOnAdr
                Case 3
                    PlcWrBaseAdress = SimlationSetting.PullBackAnsAdr
                Case 4
                    PlcWrBaseAdress = SimlationSetting.ClosetOnAdr
                Case 5
                    PlcWrBaseAdress = SimlationSetting.ClosetAnsAdr
                Case 6
                    PlcWrBaseAdress = SimlationSetting.PullBackCommand
                Case 7
                    PlcWrBaseAdress = SimlationSetting.ClosetCommand
                Case 8
                    PlcWrBaseAdress = SimlationSetting.AddClosetCommand
            End Select

            Dim intPlcWrBaseAdress As Integer = Convert.ToInt32(PlcWrBaseAdress.Substring(1), 16)


            If e.RowIndex <> -1 Then
                Dim PlcAdr As String = "B" & Convert.ToString(intPlcWrBaseAdress + e.RowIndex, 16)
                '現在の値をセルから取得し、反転
                Dim WrData As Boolean = (DgvLosZero.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "")

                Dim iRet = ComPlc.SetDevice(PlcAdr, WrData)
            Else
                'ヘッダーをダブルクリック
                Dim i As Integer
                For i = 0 To InitParm.NumberJack - 1
                    Dim PlcAdr As String = "B" & Convert.ToString(intPlcWrBaseAdress + i, 16)
                    'シフトキーが推されてた時は、ON
                    Dim iret = ComPlc.SetDevice(PlcAdr, (Control.ModifierKeys And Keys.Shift) = Keys.Shift)
                Next


            End If

            tmrPlcWR.Enabled = True



        End Sub



        ''' <summary>
        ''' ストローク、スピード一括設定
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnAllSet_Click(sender As Object, e As EventArgs) Handles btnAllSet.Click
            '計測ジャッキの取込
            Dim strokeData As Integer = fnChangeStrokeAnalogOut(nudSumupStroke.Value)
            Dim speedData As Integer = fnChangeSpeedAnalogOut(nudSumupSpeed.Value)
            For i As Short = 0 To SimlationSetting.MesureJackNo.Count - 1
                Dim iRet As Long
                iRet = ComPlc.SetDevice(SimlationSetting.MesureJackStroke(i), strokeData)
                iRet = ComPlc.SetDevice(SimlationSetting.MesureJackSpeed(i), speedData)

            Next

        End Sub
        ''' <summary>
        ''' セル入力時にPLCへ出力
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>



        Private Sub frmSim_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            btnLoszeroStart.Visible = ((Not IsNothing(SimlationSetting.LoszeroStart)) AndAlso SimlationSetting.LoszeroStart.Length > 0)



        End Sub
    ''' <summary>
    ''' ロスゼロ開始（減圧開始）
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoszeroStart_Click(sender As Object, e As EventArgs) Handles btnLoszeroStart.Click
        Dim iret = ComPlc.SetDevice(SimlationSetting.LoszeroStart, 1)

    End Sub


    ''' <summary>
    ''' ストローク　シュミレーション
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrStrokeSim_Tick(sender As Object, e As EventArgs) Handles tmrStrokeSim.Tick

        For i As Short = 0 To StrokeSimCounter.Count - 1
            '速度がゼロでない時
            If DgvJackStroke.Rows(i).Cells(2).Value <> 0 Then

                If StrokeSimCounter(i) = 0 Then
                    '1mm加算したストロークを書き込み
                    Dim Stk As Integer = DgvJackStroke.Rows(i).Cells(1).Value + 1
                    If Stk < SimlationSetting.StrokeEngScale Then
                        Dim iret = ComPlc.SetDevice(SimlationSetting.MesureJackStroke(i), fnChangeStrokeAnalogOut(Stk))
                        StrokeSimCounter(i) = 60 / DgvJackStroke.Rows(i).Cells(2).Value
                    End If

                Else
                    StrokeSimCounter(i) += -1
                End If
            End If





        Next


        Console.WriteLine("tmrStrokeSim_Tick " & DateTime.Now)


    End Sub

        Private Sub DgvJackStroke_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvJackStroke.CellEndEdit
            Dim PlcAdr As String = ""
            If e.ColumnIndex = 1 Then
                PlcAdr = SimlationSetting.MesureJackStroke(e.RowIndex)
                Dim iret = ComPlc.SetDevice(PlcAdr, fnChangeStrokeAnalogIn(DgvJackStroke.CurrentCell.Value))

            End If
            If e.ColumnIndex = 2 Then
                PlcAdr = SimlationSetting.MesureJackSpeed(e.RowIndex)
                Dim iret = ComPlc.SetDevice(PlcAdr, fnChangeSpeedAnalogOut(DgvJackStroke.CurrentCell.Value))

            End If
        End Sub
    End Class