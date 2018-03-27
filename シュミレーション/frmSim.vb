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

    Private SimSet As clsSimlationSetting

    Const ELEMENT_SIZE_WORD = 10        '文字列の書込み/読出し時、シーケンサ格納データ用配列の使用要素数
    Const ELEMENT_SIZE_32BITINTEGER = 2 '32bit整数の書込み/読出し時、シーケンサ格納データ用配列の使用要素数
    Const ELEMENT_SIZE_REALNUMBER = 2   '実数の書込み/読出し時、シーケンサ格納データ用配列の使用要素数


    Private MachineAiStartAdress As String    'マシンのアナログPLCアドレスの先頭
    Private MachineAiPlcRdCount As Integer  '先頭からのアナログ読込個数

    Private MachineDiStartAdress As String    'マシンのデジタルPLCアドレスの先頭
    Private MachineDiPlcRdCount As Integer  '先頭からのデジタル読込個数

    ''' <summary>
    ''' 0.1秒ごとに加算されるストローク、速度より計算
    ''' </summary>
    Private StrokeAdd() As Single


    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim db As New clsDataBase
        'MYSQLのバージョン取得
        db.GetMySQKVersion()

        InitParm = New clsInitParameter

        SimSet = New clsSimlationSetting

        ReDim GpMvOutReal(InitParm.NumberGroup - 1)
        ReDim GpMvOutBefore(InitParm.NumberGroup - 1)
        ReDim StrokeAdd(SimSet.MesureJackNo.Count - 1)

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

    ''' <summary>
    ''' マシンの読込開始アドレスと読込個数の取得
    ''' </summary>
    Private Sub GetMachinePlcInfo()
        Dim db As New clsDataBase

        Dim dtSHape As DataTable =
            db.GetDtfmSQL("SELECT * FROM  `flexシュミレーション設定` where left(`値`,1)='W' or left(`値`,1)='B'  ")


        For Each t As DataRow In dtSHape.Rows
            If t.Item("値").ToString.Length < 5 Then
                '先頭を除いた文字に4文字になるようにゼロを左から
                Dim s As String = t.Item("値").ToString
                Dim NewVal As String = s.Substring(0, 1) & s.Remove(0, 1).PadLeft(4, "0") '整形した値
                db.ExecuteSqlCmd($"UPDATE  `flexシュミレーション設定` SET `値`='{NewVal}' WHERE `ID`='{t.Item("ID")}'")
            End If
        Next

        'マシンの読込部分
        'アナログ
        Dim dtAiAdr As DataTable =
            db.GetDtfmSQL("SELECT MIN(`値`), MAX(`値`)  from `flexシュミレーション設定` where (left(`値`,1)='W' AND `項目`<>'GpPresMV' AND `項目`<>'LosZeroStFlex' AND `項目`<>'GyairoAdr' AND `項目`<>'PitchingAdr')")
        '開始アドレスと個数の取得
        MachineAiStartAdress = dtAiAdr.Rows(0).Item(0).ToString
        MachineAiPlcRdCount = CInt(dtAiAdr.Rows(0).Item(1).ToString.Replace("W", "&H")) - CInt(MachineAiStartAdress.Replace("W", "&H")) + 1 + InitParm.NumberGroup

        'ディジタル
        Dim dtDiAdr As DataTable =
            db.GetDtfmSQL("SELECT MIN(`値`), MAX(`値`)  from `flexシュミレーション設定` where (left(`値`,1)='B')")
        '開始アドレスと個数の取得
        MachineDiStartAdress = dtDiAdr.Rows(0).Item(0).ToString
        MachineDiStartAdress = MachineDiStartAdress.Substring(0, 4) & "0"
        MachineDiPlcRdCount = CInt(dtDiAdr.Rows(0).Item(1).ToString.Replace("B", "&H")) - CInt(MachineDiStartAdress.Replace("B", "&H")) + 1 + InitParm.NumberJack

    End Sub

    ''' <summary>
    ''' マシンの読込アドレスからのオフセットを取得
    ''' </summary>
    ''' <param name="PlcAdr"></param>
    ''' <returns></returns>
    Private Function GetMachineOfAiAdr(PlcAdr As String) As Integer
        If Not IsNothing(PlcAdr) Then
            Return CInt(PlcAdr.Replace("W", "&h")) - CInt(MachineAiStartAdress.Replace("W", "&H"))
        Else
            Return 0
        End If

    End Function


    Private Function GetMachineOfDiAdr(PlcAdr As String) As Integer
        If Not IsNothing(PlcAdr) Then
            Return CInt(PlcAdr.Replace("B", "&h")) - CInt(MachineDiStartAdress.Replace("B", "&H"))
        Else
            Return 0
        End If

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


        For Each jkn In SimSet.MesureJackNo
            DgvJackStroke.Rows.Add(jkn, 0, 0)
        Next


        'フォームに情報表示
        Me.Text &= $"　論理局番=[{ComPlc.ActLogicalStationNumber}] ]"


        GetMachinePlcInfo()

        'Run()

        '  Dim timerDelegate As TimerCallback _
        '= New TimerCallback(AddressOf StrokeSim)
        '  Dim timer As Timer _
        '= New Timer(timerDelegate, Nothing, 0, 100)




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
            "B" & Convert.ToString(Convert.ToInt32(SimSet.JackSel.Substring(1), 16) + CInt(J.Text) - 1, 16)
        Dim iRet = ComPlc.SetDevice(Jadr, IIf(J.Checked, 1, 0))

    End Sub


    Private Function WordToBit(sData() As Short) As Boolean()
        'ワードデータの配列をビットデータの配列に変換
        Dim Bit(sData.Length * 16) As Boolean
        Dim i, j As Integer
        For i = 0 To sData.Length - 1
            For j = 0 To 15
                Bit(i * 16 + j) = sData(i) And 2 ^ j
            Next
        Next
        Return Bit
    End Function


    Private Sub tmrPlcWR_Tick(sender As Object, e As EventArgs) Handles tmrPlcWR.Tick
        Dim startDt As DateTime = DateTime.Now


        lblTime.Text = Now.ToLongTimeString


        Dim iRet As Long
        'アナログPLC読込
        Dim plcAiData As Integer

        Dim i As Integer


        Dim AiMachineRd(MachineAiPlcRdCount) As Integer
        iRet = ComPlc.ReadDeviceBlock(MachineAiStartAdress, MachineAiPlcRdCount, AiMachineRd(0))


        Dim plcMachineDiRd(MachineDiPlcRdCount \ 16 + 1) As Short
        'デジタルの読込
        iRet = ComPlc.ReadDeviceBlock2(MachineDiStartAdress,
                                                        MachineDiPlcRdCount \ 16 + 1,
                                                    plcMachineDiRd(0))

        Dim MachineBit() As Boolean = WordToBit(plcMachineDiRd)



        '掘進モード
        chkExecMode.Checked = MachineBit(GetMachineOfDiAdr(SimSet.ExecMode))


        'セグメントモード
        chkSegmentMode.Checked = MachineBit(GetMachineOfDiAdr(SimSet.SegmentMode))


        '掘進中
        chkExcavOn.Checked = MachineBit(GetMachineOfDiAdr(SimSet.KussinOn))

        'FLEX ON
        chkFlexOn.Checked = MachineBit(GetMachineOfDiAdr(SimSet.FlexMode))

        If InitParm.LosZeroEquip Then

            '同時施工モード
            chkLosZeroMode.Checked = MachineBit(GetMachineOfDiAdr(SimSet.LosZeroModeMachine))

            '同時施工可
            chkLosZeroEnable.Checked = MachineBit(GetMachineOfDiAdr(SimSet.LosZeroEnable))

        End If


        '元圧
        nudSoucePressure.Value = fnChangePresAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.JkPresAdr)))

        '左ストローク
        nudLeftStroke.Value = fnChangeStrokeAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.LeftStrokeAdr)))

        '右ストローク
        nudRightStroke.Value = fnChangeStrokeAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.RightStrokeAdr)))


        '左ｽﾋﾟｰﾄﾞ
        nudLeftSpeed.Value = fnChangeSpeedAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.LeftSpeedAdr)))


        '右ｽﾋﾟｰﾄﾞ
        nudRightSpeed.Value = fnChangeSpeedAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.RightSpeedAdr)))

        If Not DgvJackStroke.IsCurrentCellInEditMode Then
            '計測ジャッキの取込
            For i = 0 To SimSet.MesureJackNo.Count - 1
                DgvJackStroke.Rows(i).Cells(1).Value = fnChangeStrokeAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.MesureJackStroke(i))))
                DgvJackStroke.Rows(i).Cells(2).Value = fnChangeSpeedAnalogIn(AiMachineRd(GetMachineOfAiAdr(SimSet.MesureJackSpeed(i))))
            Next
        End If

        tmrStrokeSim.Enabled = chkExcavOn.Checked

        'ピッチング
        nudPitching.Value = AiMachineRd(GetMachineOfAiAdr(SimSet.PitchingAdr)) / 100

        nudMachinePitching.Value = AiMachineRd(GetMachineOfAiAdr(SimSet.MachinePitchingAdr))

        If InitParm.LosZeroEquip Then
            'ロスゼロ　fromマシン
            nudLosZeroStatusMachin.Value = AiMachineRd(GetMachineOfAiAdr(SimSet.LosZeroStMachine))

            'ロスゼロ　fromFLEX
            iRet = ComPlc.GetDevice2(SimSet.LosZeroStFlex, plcAiData)
            nudLosZeroStsFlex.Value = plcAiData


        End If



        Dim sharrBufferForDeviceValue(ELEMENT_SIZE_32BITINTEGER - 1) As Short   'シーケンサ用データバッファの宣言
        iRet = ComPlc.ReadDeviceBlock2(SimSet.GyairoAdr, ELEMENT_SIZE_32BITINTEGER, sharrBufferForDeviceValue(0))

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
        Dim plcGpPv(InitParm.NumberGroup) As Integer
        'iRet = ComPlc.ReadDeviceBlock(SimlationSetting.GpPresPV, InitParm.NumberGroup, plcGpPv(0))

        Dim PvOf As Integer = GetMachineOfAiAdr(SimSet.GpPresPV)

        Array.Copy(AiMachineRd, PvOf, plcGpPv, 0, InitParm.NumberGroup)

        For i = 0 To InitParm.NumberGroup - 1
            DspGpPv(i).Value = fnChangePresAnalogIn(plcGpPv(i))
        Next

        Dim plcGpMv() As Integer
        ReDim plcGpMv(InitParm.NumberGroup)
        iRet = ComPlc.ReadDeviceBlock(SimSet.GpPresMV, InitParm.NumberGroup, plcGpMv(0))
        For i = 0 To InitParm.NumberGroup - 1
            GpMvOutReal(i) =
                plcGpMv(i) * SimSet.GpMvEngScale / SimSet.GpMvPlcScale
            DspGpMv(i).Text = GpMvOutReal(i).ToString & "%"
        Next



        'ジャッキ選択
        Dim plcJacksel(InitParm.NumberJack - 1) As Boolean
        Array.Copy(MachineBit, GetMachineOfDiAdr(SimSet.JackSel), plcJacksel, 0, InitParm.NumberJack)
        For i = 0 To InitParm.NumberJack - 1


            JackSel(i).Checked = plcJacksel(i)
            JackSel(i).BackColor = IIf(JackSel(i).Checked, Color.Red, Color.Transparent)
        Next

        If InitParm.LosZeroEquip Then

            '推進／組立
            LosZeroStatusRead(SimSet.ExcavOrSegmentAdr, 1, MachineBit)
            '引戻し中
            LosZeroStatusRead(SimSet.PullBackOnAdr, 2, MachineBit)
            '引戻しANS
            LosZeroStatusRead(SimSet.PullBackAnsAdr, 3, MachineBit)
            '押込み中
            LosZeroStatusRead(SimSet.ClosetOnAdr, 4, MachineBit)
            '押込みANS
            LosZeroStatusRead(SimSet.ClosetAnsAdr, 5, MachineBit)

            '引戻し指令
            LosZeroStatusRead(SimSet.PullBackCommand, 6, MachineBit)
            '押込み指令
            LosZeroStatusRead(SimSet.ClosetCommand, 7, MachineBit)
            '追加押込み指令
            LosZeroStatusRead(SimSet.AddClosetCommand, 8, MachineBit)


            '減圧開始PBのパルス化
            If nudLosZeroStatusMachin.Value = "1" Then
                iRet = ComPlc.SetDevice(SimSet.LoszeroStart, 0)

            End If


        End If
        Dim endDt As DateTime = DateTime.Now

        Dim ts As TimeSpan = endDt - startDt ' 時間の差分を取得



        'Console.WriteLine(ts.TotalMinutes) ' 経過時間（分）
        'Console.WriteLine(ts.TotalSeconds & "秒") ' 経過時間（秒）
        'Console.WriteLine(ts.TotalMilliseconds) ' 経過時間（ミリ秒）

    End Sub

    Private Sub LosZeroStatusRead(PlcAdr As String, ColNum As Integer, BitSig() As Boolean)

        'ジャッキ選択

        Dim jkbitsts(InitParm.NumberJack - 1) As Boolean
        Array.Copy(BitSig, GetMachineOfDiAdr(PlcAdr), jkbitsts, 0, InitParm.NumberJack)


        For i = 0 To InitParm.NumberJack - 1
            DgvLosZero.Rows(i).Cells(ColNum).Value = IIf(jkbitsts(i), "●", "")
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

        Dim lngBaseAdr As Long = CLng("&H" & (Mid(SimSet.BitStartAdr, 2)))
        Return "B" & Hex(lngBaseAdr + intOffsetAdr)

    End Function
    ''' <summary>
    ''' ストロークデータ入力変換スケール
    ''' </summary>
    ''' <param name="PlcData"></param>
    ''' <returns>PLCからの    ''' データ</returns>
    Private Function fnChangeStrokeAnalogIn(PlcData As Integer) As Integer
        Return PlcData / SimSet.StrokePlcScale * SimSet.StrokeEngScale
    End Function

    Private Function fnChangeStrokeAnalogOut(OrData As Single) As Integer
        Return OrData / SimSet.StrokeEngScale * SimSet.StrokePlcScale
    End Function


    Private Function fnChangeSpeedAnalogIn(PlcData As Integer) As Single
        Return PlcData / SimSet.SpeedPlcScale * SimSet.SpeedEngScale
    End Function

    Private Function fnChangeSpeedAnalogOut(OrData As Single) As Integer
        Return OrData / SimSet.SpeedEngScale * SimSet.SpeedPlcScale
    End Function


    Private Function fnChangePresAnalogIn(PlcData As Integer) As Single
        Return PlcData / SimSet.PresPlcScale * SimSet.PresEngScale
    End Function
    Private Function fnChangePresAnalogOut(OrData As Single) As Integer
        Return OrData / SimSet.PresEngScale * SimSet.PresPlcScale
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
            PlcAdr = SimSet.FlexMode
        End If

        If sender Is chkExecMode Then
            PlcAdr = SimSet.ExecMode
        End If


        If sender Is chkSegmentMode Then
            PlcAdr = SimSet.SegmentMode
        End If

        '掘進中
        If sender Is chkExcavOn Then
            PlcAdr = SimSet.KussinOn
        End If
        '同時施工モード
        If sender Is chkLosZeroMode Then
            PlcAdr = SimSet.LosZeroModeMachine
        End If
        '同時施工可
        If sender Is chkLosZeroEnable Then
            PlcAdr = SimSet.LosZeroEnable
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
        Handles nudRightSpeed.ValueChanged, nudLeftSpeed.ValueChanged, nudPitching.ValueChanged,
        nudLosZeroStsFlex.ValueChanged, nudLosZeroStatusMachin.ValueChanged, nudMachinePitching.ValueChanged, nudSoucePressure.ValueChanged,
        nudLeftStroke.LostFocus, nudRightStroke.LostFocus

        Dim FieldName As String = New StackFrame(1).GetMethod.Name

        Dim NumObj As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim PlcAdress As String = ""
        Dim PlcWriteData As Integer
        With SimSet
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
            If SimSet.JackSel.StartsWith("M") Then
                Jadr = "M" & (SimSet.JackSel.Substring(1) + i)
            Else
                Jadr = "B" & Convert.ToString((Convert.ToInt32(SimSet.JackSel.Substring(1), 16) + i), 16)

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
        'Dim iRet As Long = ComPlc.SetDevice(SimlationSetting.JkPresAdr, JkPes)


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
        Dim iRet As Long = ComPlc.WriteDeviceBlock(SimSet.GpPresPV, InitParm.NumberGroup, GpPv(0))

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
        iReturnCode = ComPlc.WriteDeviceBlock2(SimSet.GyairoAdr,
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
                PlcWrBaseAdress = SimSet.ExcavOrSegmentAdr
            Case 2
                PlcWrBaseAdress = SimSet.PullBackOnAdr
            Case 3
                PlcWrBaseAdress = SimSet.PullBackAnsAdr
            Case 4
                PlcWrBaseAdress = SimSet.ClosetOnAdr
            Case 5
                PlcWrBaseAdress = SimSet.ClosetAnsAdr
            Case 6
                PlcWrBaseAdress = SimSet.PullBackCommand
            Case 7
                PlcWrBaseAdress = SimSet.ClosetCommand
            Case 8
                PlcWrBaseAdress = SimSet.AddClosetCommand
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
        For i As Short = 0 To SimSet.MesureJackNo.Count - 1
            Dim iRet As Long
            iRet = ComPlc.SetDevice(SimSet.MesureJackStroke(i), strokeData)
            iRet = ComPlc.SetDevice(SimSet.MesureJackSpeed(i), speedData)

        Next

    End Sub
    ''' <summary>
    ''' セル入力時にPLCへ出力
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>



    Private Sub frmSim_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        btnLoszeroStart.Visible = ((Not IsNothing(SimSet.LoszeroStart)) AndAlso SimSet.LoszeroStart.Length > 0)


    End Sub
    ''' <summary>
    ''' ロスゼロ開始（減圧開始）
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoszeroStart_Click(sender As Object, e As EventArgs) Handles btnLoszeroStart.Click
        Dim iret = ComPlc.SetDevice(SimSet.LoszeroStart, 1)

    End Sub





    Private Sub DgvJackStroke_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvJackStroke.CellEndEdit
        Dim PlcAdr As String = ""
        If e.ColumnIndex = 1 Then
            PlcAdr = SimSet.MesureJackStroke(e.RowIndex)
            Dim iret = ComPlc.SetDevice(PlcAdr, fnChangeStrokeAnalogIn(DgvJackStroke.CurrentCell.Value))

        End If
        If e.ColumnIndex = 2 Then
            PlcAdr = SimSet.MesureJackSpeed(e.RowIndex)
            Dim iret = ComPlc.SetDevice(PlcAdr, fnChangeSpeedAnalogOut(DgvJackStroke.CurrentCell.Value))

            End If
        End Sub



    Private Sub tmrStrokeSim_Tick(sender As Object, e As EventArgs) Handles tmrStrokeSim.Tick
        Dim startDt As DateTime = DateTime.Now

        For i As Short = 0 To SimSet.MesureJackNo.Count - 1
            '速度がゼロでない時
            If DgvJackStroke.Rows(i).Cells(2).Value <> 0 Then
                '0.1秒で増加するストローク量
                StrokeAdd(i) += DgvJackStroke.Rows(i).Cells(2).Value / 600

                If StrokeAdd(i) > 1 Then
                    StrokeAdd(i) = 0
                    '1mm加算したストロークを書き込み
                    Dim Stk As Integer = DgvJackStroke.Rows(i).Cells(1).Value + 1
                    If Stk < SimSet.StrokeEngScale Then
                        Dim iret = ComPlc.SetDevice(SimSet.MesureJackStroke(i), fnChangeStrokeAnalogOut(Stk))
                    End If

                End If

            End If

        Next

        Dim endDt As DateTime = DateTime.Now

        Dim ts As TimeSpan = endDt - startDt ' 時間の差分を取得
        Console.WriteLine(ts.TotalMilliseconds) ' 経過時間（ミリ秒）
        Console.WriteLine($"tmrStrokeSim_Tick :{ts.TotalMilliseconds}:{tmrStrokeSim.Interval}:NowTIme {Now.ToLongTimeString}")


    End Sub
End Class