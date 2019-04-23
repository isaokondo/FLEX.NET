Imports System.IO.Ports
Imports System.Text

Public Module common
    ''掘進ステータス定数
    Public Const cTaiki As Short = 1 ''待機中
    Public Const cKussin As Short = 2 ''掘進中
    Public Const cChudan As Short = 3 ''中断中



    Public ExcelLink As clsExcelToDtGrd



End Module

Public Class frmMain



    Private saveTs As Boolean
    Private saveWaitSecond As Int16
    Private saveWaitInterval As Int16
    Public WithEvents PlcIF As New clsPLC

    Private DataSave As New clsDataSave

    Private Sub Settings_SettingSaving(ByVal sender As Object,
        ByVal e As System.ComponentModel.PropertyChangedEventArgs)
        '変更しようとしている設定が"Text"のとき
        If e.PropertyName.Contains("Hor") Then
            ucnHorDevChart.ChartHighScale = My.Settings.HorDevChartHigh
            ucnHorDevChart.ChartLowScale = My.Settings.HorDevChartLow
            ucnHorDevChart.StrokeWidth = My.Settings.ChartStrokeWidth
            ucnHorDevChart.ChartUp()
        End If
        If e.PropertyName.Contains("Ver") Then
            ucnVerDevChart.ChartHighScale = My.Settings.VerDevChartHigh
            ucnVerDevChart.ChartLowScale = My.Settings.VerDevChartLow
            ucnVerDevChart.StrokeWidth = My.Settings.ChartStrokeWidth
            ucnVerDevChart.ChartUp()
        End If

        If e.PropertyName.Contains("DevImg") Then
            UcnDevImgDsp.DevScale = My.Settings.DevImgScale


        End If



        My.Settings.Save()
    End Sub


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler My.Settings.PropertyChanged, AddressOf Settings_SettingSaving

        With SerialPort1

            'オープンするシリアルポートをコンボボックスから取り出す.
            .PortName = "COM1"

            'ボーレートをコンボボックスから取り出す.
            .BaudRate = 9600

            'データビットをセットする. (データビット = 8ビット)
            SerialPort1.DataBits = 8

            'パリティビットをセットする. (パリティビット = なし)
            .Parity = Parity.None

            'ストップビットをセットする. (ストップビット = 1ビット)
            .StopBits = StopBits.One

            'フロー制御をコンボボックスから取り出す.
            .Handshake = Handshake.None

            .NewLine = Chr(&H3)

            '文字コードをセットする.
            .Encoding = Encoding.Unicode

            'シリアルポートをオープンする.
            .Open()

        End With

        PlcIF = New clsPLC

        ExcelLink = New clsExcelToDtGrd

        ChartStart()

        UcnDevImgDsp.DevScale = My.Settings.DevImgScale


        UcnDevImgDsp.DspUp()

    End Sub

    ''' <summary>
    ''' 偏差グラフの立ち上げ時の表示設定
    ''' </summary>
    Private Sub ChartStart()

        ucnHorDevChart.ChartHighScale = My.Settings.HorDevChartHigh
        ucnHorDevChart.ChartLowScale = My.Settings.HorDevChartLow
        ucnHorDevChart.StrokeWidth = My.Settings.ChartStrokeWidth

        ucnVerDevChart.ChartHighScale = My.Settings.VerDevChartHigh
        ucnVerDevChart.ChartLowScale = My.Settings.VerDevChartLow
        ucnVerDevChart.StrokeWidth = My.Settings.ChartStrokeWidth


        Dim dt As New clsGetDevChartData(PlcIF.RingNo)

        For Each t As KeyValuePair(Of Integer, Single) In dt.HorData
            ucnHorDevChart.ChartDataAdd(t.Key, t.Value)
        Next

        For Each t As KeyValuePair(Of Integer, Single) In dt.VerData
            ucnVerDevChart.ChartDataAdd(t.Key, t.Value)
        Next

        UcnDevImgDsp.DevPointX = ucnHorDevChart.LastData
        UcnDevImgDsp.DevPointY = ucnVerDevChart.LastData


    End Sub


    ''' <summary>
    ''' 偏差グラフのデータクリア
    ''' </summary>
    Private Sub ChartClear() Handles PlcIF.ToWaiting
        ucnHorDevChart.ChartClear()
        ucnVerDevChart.ChartClear()
    End Sub







    Private Sub TBClr1()

        'コマンド欄の消去
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub TBClr2()

        '計測欄の消去
        Tb_batt.Clear()
        Tb_edm.Clear()
        Tb_fac.Clear()
        Tb_had.Clear()
        Tb_ham.Clear()
        Tb_has.Clear()
        Tb_hl.Clear()
        Tb_light.Clear()
        Tb_prism.Clear()
        Tb_sea.Clear()
        Tb_sl.Clear()
        Tb_th.Clear()
        Tb_tm.Clear()
        Tb_ts.Clear()
        Tb_vad.Clear()
        Tb_vam.Clear()
        Tb_vas.Clear()
        Tb_vl.Clear()
        Tb_weath.Clear()

    End Sub
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        'シリアルポートをオープンしている場合、クローズする.
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Tm_Protocol.Enabled = False
        End If

        If Not IsNothing(ExcelLink) Then
            ExcelLink.ExcelClose()
        End If


    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click

        TBClr1()

    End Sub

    Private Sub Bt_Fine_Click(sender As Object, e As EventArgs) Handles Bt_Fine.Click

        'Z34（ファイン測距測角計測）の連続計測。
        Dim qs As New QsSerial()
        Dim CmdA As New List(Of Byte)

        'シリアルポートをオープンしていない場合、処理を行わない.
        If SerialPort1.IsOpen = False Then
            Return
        End If

        ContiSend("Z34", 10, 10)

    End Sub

    Private Sub Bt_Crs1_Click(sender As Object, e As EventArgs) Handles Bt_Crs1.Click

        'Z32（CRS1測距測角計測）の連続計測。
        Dim qs As New QsSerial()
        Dim CmdA As New List(Of Byte)

        'シリアルポートをオープンしていない場合、処理を行わない.
        If SerialPort1.IsOpen = False Then
            Return
        End If

        ContiSend("Z32", 10, 10)


    End Sub

    Private Sub ContiSend(str As String, tm1 As Integer, Tm2 As Integer)

        '送信データをセット
        QsSerial.Send = str 'CRS1 N回測定
        QsSerial.cont = 0 '計測数
        QsSerial.Rtry = 0 '追尾リトライ数
        QsSerial.Amod = 0 '受信モード 0
        Me.Tm_Interval.Interval = Tm2 '計測のインターバル
        Me.Tm_Protocol.Interval = tm1 '送受信のインターバル
        Me.Tm_Interval.Enabled = True '計測スタート

    End Sub

    Private Sub Bt_Endmes_Click(sender As Object, e As EventArgs) Handles Bt_Endmes.Click

        Endmes() '計測停止

    End Sub

    Private Sub Endmes()

        Tm_Interval.Interval = 10 '計測のインターバル（初期化）
        Tm_Protocol.Interval = 10 '送受信のインターバル（初期化）
        Tm_Search.Interval = 10 'サーチのインターバル（初期化）
        Tm_Search.Enabled = False 'サーチタイマー停止
        Tm_Interval.Enabled = False '計測タイマー停止
        Tm_Protocol.Enabled = False '送受信タイマー停止

    End Sub


    Private Sub Bt_Sendmes_Click(sender As Object, e As EventArgs) Handles Bt_Sendmes.Click

        '送信データをセット
        QsSerial.Send = TextBox1.Text　'コマンド入力
        OneCmdOneSend() '１コマンドを１回送信

    End Sub
    Private Sub OneCmdOneSend()

        '1コマンドを1回送信
        'テキストボックス1に入力したコマンドをTSに送信する。
        Dim qs As New QsSerial()
        Dim CmdA As New List(Of Byte)

        'シリアルポートをオープンしていない場合、処理を行わない.
        If SerialPort1.IsOpen = False Then
            Return
        End If

        '送信データをセット
        QsSerial.Amod = 0 '受信モード 0
        Me.Tm_Protocol.Interval = 50
        Me.Tm_Protocol.Enabled = True 'タイマー受信スタート

    End Sub

    Private Sub SendCmd(）

        Dim qs As New QsSerial()
        Dim CmdA As New List(Of Byte)

        CmdA = qs.MakeSendCmd(QsSerial.Send) 'コマンド電文作成（コマンド＋BCC＋ETX）

        Debug.WriteLine("SendCmd: " & qs.Send)

        SerialPort1.Write(CmdA.ToArray, 0, CmdA.Count) '電文を送信

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Dim _txd As Byte() = New Byte(SerialPort1.BytesToRead - 1) {} '受信バッファ内のデータのバイト数分
        SerialPort1.Read(_txd, 0, _txd.GetLength(0)) 'SerialPort1の入力バッファからバイト数を読み取り
        Dim str As String = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetString(_txd) '受信バイト配列を文字列に変換

        QsSerial.Recv = "" '受信データ初期化
        QsSerial.Rchk = False '受信データOK　リセット
        Dim i As Integer, l As Integer
        For i = 1 To str.Length
            QsSerial.Rstk = QsSerial.Rstk & Mid(str, i, 1)
            'LFをチェック
            l = Asc(Mid(str, i, 1))
            If Asc(Mid(str, i, 1)) = 10 Then
                QsSerial.Recv = QsSerial.Rstk '受信データ
                QsSerial.Rstk = "" '受信データ一時保管クリア
                QsSerial.Rchk = True '受信データOK セット

                Debug.WriteLine("SerialPortReceive: " & QsSerial.Recv)
            End If
        Next

    End Sub


    Private Sub SerialPortCmdSend(ByVal Cmd As String)

        'シリアルポートをオープンしていない場合、処理を行わない.
        If SerialPort1.IsOpen = False Then
            Return
        End If

        'テキストボックスから、送信するテキストを取り出す.
        Dim _bcc As String
        Dim _bccvl As Integer
        Dim _txd(100) As Byte
        'Dim _txd(20) As Byte
        Dim i As Integer, _lgt As Integer

        _bccvl = 0 'BCC初期値0

        '送信するテキストがない場合、データ送信は行わない.
        If String.IsNullOrEmpty(Cmd) Then
            Return
        End If

        Debug.WriteLine("SerialPortCmdSend: " & Cmd.ToString())

        'Try
        'コマンド作成
        _lgt = 0
        If Cmd = "ACK" Then
            _txd(_lgt) = CByte("&H06") 'ACKのアスキーコード
            'SerialPort1.Write(Hex(_value)) 'アスキーコード（16進数）を送信
            _bccvl = _bccvl Xor _txd(0)
            _lgt = _lgt + 1

        Else
            For i = 1 To Cmd.Length
                _txd(_lgt) = Asc(Mid(Cmd, i, 1))
                _bccvl = _bccvl Xor _txd(i - 1) 'BCCを排他的論理和で算出
                _lgt = _lgt + 1
            Next
        End If

        'BCC作成
        _bcc = CStr(_bccvl)
        If _bcc.Length < 2 Then
            _bcc = "00" & _bcc
        ElseIf _bcc.Length < 3 Then
            _bcc = "0" & _bcc
        End If

        For i = 1 To _bcc.Length
            _txd(_lgt) = Asc(Mid(_bcc, i, 1))
            _lgt = _lgt + 1
        Next

        'ETXを付加
        _txd(_lgt) = CByte("&H03") 'ETXのアスキーコード

        'コマンド送信
        SerialPort1.Write(_txd, 0, _lgt + 1)


    End Sub

    Private Sub Tm_protocol_Tick(sender As Object, e As EventArgs) Handles Tm_Protocol.Tick

        Dim qs As New QsSerial()
        Dim CmdA As New List(Of Byte)

        '現在時刻カウント
        Dim now = Environment.TickCount
        '保護モード
        If QsSerial.Safe Then
            Dim Comt = New List(Of Integer) From {50, 300, 100, 4000, 30, 350} '角度測定（①50ms以内、②100ms以上推奨、③50ms以内、④2～3秒、⑤50ms以内、⑥350ms）

            Select Case QsSerial.Wmod
                Case 0
                    'ウェイト時間のチェック
                    If QsSerial.Amod = 0 And QsSerial.Wtim <> 0 And QsSerial.Wtim <= now Then
                        'タイマー初期化
                        QsSerial.Wtim = 0
                        QsSerial.Wrcv = 0
                        QsSerial.Wmod = 1
                    End If

                Case 1
                    'スタンバイモードへ
                    SerialPortCmdSend("T30")
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Wmod = 2

                Case 2
                    'Ack受信のチェック
                    If QsSerial.Rchk = True Then
                        'インターバルタイマーセット
                        QsSerial.Wtim = now + QsSerial.Wint
                        QsSerial.Wmod = 3
                    Else
                        '再送
                        QsSerial.Wmod = 1
                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 3 Then
                            QsSerial.Wmod = 0

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("通信応答なし")
                            Exit Sub
                        End If
                    End If

                Case 3
                    'インターバル経過待ち
                    If QsSerial.Wtim <> 0 And QsSerial.Wtim <= now Then
                        'タイマー初期化   
                        QsSerial.Wtim = 0
                        QsSerial.Wrcv = 0
                        QsSerial.Wmod = 4
                    End If

                Case 4
                    '指定角への旋回動作
                    Dim _st As New List(Of String)
                    _st.Add("TTA")
                    _st.Add(qs.StrNumLeft0(Tb_vod.Text, 3, 1))
                    _st.Add(qs.StrNumLeft0(Tb_vom.Text, 2, 0))
                    _st.Add(qs.StrNumLeft0(Tb_vos.Text, 2, 0))
                    _st.Add(qs.StrNumLeft0(Tb_hod.Text, 3, 1))
                    _st.Add(qs.StrNumLeft0(Tb_hom.Text, 2, 0))
                    _st.Add(qs.StrNumLeft0(Tb_hos.Text, 2, 0))
                    _st.Add("d")

                    Dim str = String.Join(Nothing, _st)
                    SerialPortCmdSend(str)
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Wmod = 5

                Case 5
                    'Ack受信のチェック
                    If QsSerial.Rchk = True Then
                        'サーチ動作へ
                        QsSerial.Wrcv = 0
                        QsSerial.Wmod = 6
                    Else
                        '再送
                        QsSerial.Wmod = 4
                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 3 Then
                            QsSerial.Wmod = 0

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("通信応答なし")
                            Exit Sub
                        End If
                    End If

                Case 6
                    'サーチ
                    SerialPortCmdSend("T31")
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Wmod = 7

                Case 7
                    'Ack受信のチェック
                    If QsSerial.Rchk = True Then
                        '通常動作へ戻す
                        QsSerial.Wmod = 0
                        'ウェイト発動タイマーをセット 旋回後に追尾できない場合を考慮
                        QsSerial.Wtim = now + QsSerial.Wsec
                    Else
                        '再送
                        QsSerial.Wmod = 6
                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 3 Then
                            QsSerial.Wmod = 0

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("通信応答なし")
                            Exit Sub
                        End If
                    End If

            End Select

            If QsSerial.Wmod > 0 Then
                '保護モード中は通常処理を行わない
                Exit Sub
            End If
        End If

        If Mid(QsSerial.Send, 1, 2) = "Z1" Or Mid(QsSerial.Send, 1, 2) = "Z2" Then '角度測定データグループ

            Dim Comt = New List(Of Integer) From {50, 350, 100, 150, 200, 300} '角度測定（①100ms以内、②300ms以上推奨、③100ms以内、④200ms以内、⑤300ms以内）

            Select Case QsSerial.Amod

                Case 0

                    'コマンド送信
                    TBClr1()
                    TBClr2()
                    QsSerial.Recv = "" '受信データ（空白）
                    'QsSerial.Rstk = "" '一時保管（空白）
                    QsSerial.Rchk = False '受信完了（未）
                    QsSerial.Wrcv = 0 '受信待ち回数（0）
                    QsSerial.Acnt = 1 'ACK回数（1）
                    QsSerial.Amod = 1 '受信モード1（Case1 1回目のACK確認処理へ）
                    CmdA = qs.MakeSendCmd(QsSerial.Send) '送信電文作成（コマンド＋BCC＋ETX）
                    TextBox6.Text = qs.AsctoTxt(CmdA) 'テキストボックス6に送信電文表示
                    SendCmd(） '送信
                    Tm_Protocol.Interval = Comt(0) 'インターバル　①100m秒以内

                Case 1

                    'ACKの処理（受信データOKで先頭文字がACKの場合）

                    If QsSerial.Rchk = True Then '受信データOK（終端文字がLF）

                        If Asc(Mid(QsSerial.Recv, 1, 1)) = 6 Then 'ACKの時

                            If QsSerial.Acnt = 1 Then '1回目

                                'インターバルを②300m秒以上にセットしてデータ要求コマンドを送信する
                                TextBox2.Text = QsSerial.Recv '受信データを表示
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1 'ACKの受信回数を加算
                                QsSerial.Amod = 2 'Case2（データ要求コマンド送信）へ
                                Tm_Protocol.Interval = Comt(1) 'インターバル　②300m秒以上を推奨 に設定

                            ElseIf QsSerial.Acnt = 2 Then

                                '2回目（インターバルを④200m秒以内にセットして測定データを読み込む）
                                TextBox3.Text = QsSerial.Recv
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1
                                QsSerial.Amod = 3
                                QsSerial.Wrcv = 0
                                Tm_Protocol.Interval = Comt(3) 'インターバル　④200m秒以内

                            End If

                        End If

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 20 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("ACK応答なし（無効コマンドまたは通信不良）")
                            Exit Sub

                        End If

                    End If

                Case 2

                    'データ要求コマンドの送信（要求コマンドを送信してインターバルを③100m秒以内にセットし、2回目のACK確認へ）
                    SerialPortCmdSend("C") 'データ要求コマンドを送信
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Amod = 1 'Case1（ACK確認の2回目）へ

                Case 3

                    '測定データの読み込み

                    '受信チェック
                    If QsSerial.Rchk = True Then

                        '受信あり
                        TextBox4.Text = QsSerial.Recv
                        QsSerial.Data = qs.modeAngZ10(QsSerial.Recv) '角度測定モード（Z10、Z20）の計測データ
                        showMeasure(QsSerial.Data) '測定データの表示
                        QsSerial.Amod = 4

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 20 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("測定値応答なし")
                            'SerialPortCmdSend("C")
                            Exit Sub
                        End If

                    End If

                Case 4

                    'ACKの返信
                    SerialPortCmdSend("ACK")
                    TextBox5.Text &= qs.TxttoAsc(QsSerial.Recv)
                    QsSerial.Recv = ""
                    QsSerial.Rchk = False
                    QsSerial.Acnt = 1
                    QsSerial.Amod = 0
                    Tm_Protocol.Enabled = False

                Case Else

            End Select

            Exit Sub

        End If

        If Mid(QsSerial.Send, 1, 2) = "Z3" Or Mid(QsSerial.Send, 1, 2) = "Z4" Or Mid(QsSerial.Send, 1, 2) = "Z5" Or
           Mid(QsSerial.Send, 1, 2) = "Z6" Then '距離測定データグループ

            Dim Comt = New List(Of Integer) From {50, 300, 100, 4000, 30, 350} '角度測定（①50ms以内、②100ms以上推奨、③50ms以内、④2～3秒、⑤50ms以内、⑥350ms）

            Select Case QsSerial.Amod

                Case 0

                    'コマンド送信
                    TBClr1()
                    TBClr2()
                    QsSerial.Recv = "" '受信データ（空白）
                    QsSerial.Rstk = "" '一時保管（空白）
                    QsSerial.Rchk = False '受信完了（未）
                    QsSerial.Wrcv = 0 '受信待ち回数（0）
                    QsSerial.Acnt = 1 'ACK回数（1）
                    QsSerial.Amod = 1 '受信モード1（Case1 1回目のACK確認処理へ）
                    CmdA = qs.MakeSendCmd(QsSerial.Send) '送信電文作成（コマンド＋BCC＋ETX）
                    TextBox6.Text = qs.AsctoTxt(CmdA) 'テキストボックス6に送信電文表示
                    SendCmd(） '送信
                    Tm_Protocol.Interval = Comt(0) 'インターバル　①

                Case 1

                    'ACKの処理（受信データOKで先頭文字がACKの場合）

                    If QsSerial.Rchk = True Then '受信データOK（終端文字がLF）

                        If Asc(Mid(QsSerial.Recv, 1, 1)) = 6 Then 'ACKの時

                            If QsSerial.Acnt = 1 Then '1回目

                                'インターバルを②300m秒以上にセットしてデータ要求コマンドを送信する
                                TextBox2.Text = QsSerial.Recv　'受信データを表示
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1 'ACKの受信回数を加算
                                QsSerial.Amod = 2 'Case2（データ要求コマンド送信）へ
                                Tm_Protocol.Interval = Comt(1) 'インターバル　②300m秒以上を推奨 に設定

                            ElseIf QsSerial.Acnt = 2 Then

                                '2回目（インターバルを④200m秒以内にセットして測定データを読み込む）
                                TextBox3.Text = QsSerial.Recv
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1
                                QsSerial.Amod = 3
                                QsSerial.Wrcv = 0
                                Tm_Protocol.Interval = Comt(3) 'インターバル　④

                            End If

                        End If

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 20 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("ACK応答なし（無効コマンドまたは通信不良）")
                            Exit Sub

                        End If

                    End If

                Case 2

                    'データ要求コマンドの送信（要求コマンドを送信してインターバルを③100m秒以内にセットし、2回目のACK確認へ）
                    SerialPortCmdSend("C") 'データ要求コマンドを送信
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③
                    QsSerial.Amod = 1 'Case1（ACK確認の2回目）へ

                Case 3

                    '測定データの読み込み

                    '受信チェック
                    If QsSerial.Rchk = True Then

                        '受信あり
                        TextBox4.Text = QsSerial.Recv
                        QsSerial.Data = qs.modeDisZ30(QsSerial.Recv) '斜距離測定モード（Z30）の計測データ
                        showMeasure(QsSerial.Data) '測定データの表示
                        ExcellRun() 'ｴｸｾﾙ計算の更新

                        If Tb_sea.Text = "追尾" Then

                            DataSave.Save() 'データベース保存
                            '偏差グラフ更新
                            ucnHorDevChart.ChartDataAdd(PlcIF.realStroke, lb_AvDh.Text)
                            ucnVerDevChart.ChartDataAdd(PlcIF.realStroke, lb_AvDv.Text)

                            UcnDevImgDsp.DevPointX = lb_AvDh.Text
                            UcnDevImgDsp.DevPointY = lb_AvDv.Text




                        End If


                        QsSerial.Amod = 4
                        QsSerial.Wrcv = 0
                        Tm_Protocol.Interval = Comt(4) 'インターバル　⑤
                        If QsSerial.Safe Then
                            'ウェイト発動タイマーの更新
                            QsSerial.Wtim = now + QsSerial.Wsec
                            '保護モードの初期化
                            QsSerial.Wmod = 0
                        End If

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 3 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("測定値応答なし")
                            'SerialPortCmdSend("C")
                            Exit Sub
                        End If

                    End If

                Case 4

                    'ACKの返信
                    SerialPortCmdSend("ACK")
                    TextBox5.Text &= qs.TxttoAsc(QsSerial.Recv)
                    Tm_Protocol.Interval = Comt(5) 'インターバル　⑥
                    QsSerial.Amod = 0 'Case1（ACK確認の2回目）へ
                    Tm_Protocol.Enabled = False

                Case Else

            End Select

            Exit Sub

        End If

        If Mid(QsSerial.Send, 1, 2) = "LS" Or Mid(QsSerial.Send, 1, 3) = "PMS" Or Mid(QsSerial.Send, 1, 2) = "ZA" Or Mid(QsSerial.Send, 1, 3) = "ZH0" Or
           Mid(QsSerial.Send, 1, 2) = "ZB" Or Mid(QsSerial.Send, 1, 3) = "ZSE" Or Mid(QsSerial.Send, 1, 3) = "ZD6" Or Mid(QsSerial.Send, 1, 1) = "J" Or
           Mid(QsSerial.Send, 1, 1) = "K" Or Mid(QsSerial.Send, 1, 1) = "I" Or Mid(QsSerial.Send, 1, 2) = "T3" Or Mid(QsSerial.Send, 1, 2) = "TF" Or
           Mid(QsSerial.Send, 1, 2) = "TC" Or Mid(QsSerial.Send, 1, 2) = "TT" Or Mid(QsSerial.Send, 1, 2) = "TL" Or Mid(QsSerial.Send, 1, 2) = "TS" Or
           Mid(QsSerial.Send, 1, 3) = "TOV" Then '内部機能設定コマンド、旋回追尾命令

            Dim Comt = New List(Of Integer) From {50, 250} '内部機能設定（①100ms以内、②200ms以上推奨）

            Select Case QsSerial.Amod

                Case 0

                    'コマンド送信
                    TBClr1()
                    QsSerial.Recv = "" '受信データ（空白）
                    'QsSerial.Rstk = "" '一時保管（空白）
                    QsSerial.Rchk = False '受信完了（未）
                    QsSerial.Wrcv = 0 '受信待ち回数（0）
                    QsSerial.Acnt = 1 'ACK回数（1）
                    QsSerial.Amod = 1 '受信モード1（Case1 1回目のACK確認処理へ）
                    CmdA = qs.MakeSendCmd(QsSerial.Send) '送信電文作成（コマンド＋BCC＋ETX）
                    TextBox6.Text = qs.AsctoTxt(CmdA) 'テキストボックス6に送信電文表示
                    SendCmd(） '送信
                    Tm_Protocol.Interval = Comt(0) 'インターバル　①100m秒以内

                Case 1

                    'ACKの処理（受信データOKで先頭文字がACKの場合）

                    If QsSerial.Rchk = True Then '受信データOK（終端文字がLF）

                        If Asc(Mid(QsSerial.Recv, 1, 1)) = 6 Then 'ACKの時

                            If QsSerial.Acnt = 1 Then '1回目

                                'ACKを確認したら終了
                                TextBox2.Text = QsSerial.Recv '受信データを表示
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1 'ACKの受信回数を加算
                                QsSerial.Amod = 4 'ACK返信へ
                                Tm_Protocol.Interval = Comt(1) 'インターバル　②300m秒以上を推奨 に設定

                            ElseIf QsSerial.Acnt = 2 Then

                                '2回目（インターバルを④200m秒以内にセットして測定データを読み込む）
                                TextBox3.Text = QsSerial.Recv
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1
                                QsSerial.Amod = 3
                                QsSerial.Wrcv = 0
                                Tm_Protocol.Interval = Comt(3) 'インターバル　④200m秒以内

                            End If

                        End If

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 20 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("ACK応答なし（無効コマンドまたは通信不良）")
                            Exit Sub

                        End If

                    End If

                Case 2

                    'データ要求コマンドの送信（要求コマンドを送信してインターバルを③100m秒以内にセットし、2回目のACK確認へ）
                    SerialPortCmdSend("C") 'データ要求コマンドを送信
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Amod = 1 'Case1（ACK確認の2回目）へ

                Case 3

                    '測定データの読み込み

                    '受信チェック
                    If QsSerial.Rchk = True Then

                        '受信あり
                        TextBox4.Text = QsSerial.Recv
                        QsSerial.Amod = 4

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 3 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("測定値応答なし")
                            'SerialPortCmdSend("C")
                            Exit Sub
                        End If


                    End If

                Case 4

                    'ACKの返信
                    SerialPortCmdSend("ACK")
                    TextBox5.Text &= qs.TxttoAsc(QsSerial.Recv)
                    QsSerial.Recv = ""
                    QsSerial.Rchk = False
                    QsSerial.Acnt = 1
                    QsSerial.Amod = 0
                    Tm_Protocol.Enabled = False
                    Exit Sub

                Case Else

            End Select

            Exit Sub

        End If

        If Mid(QsSerial.Send, 1, 2) = "LR" Or Mid(QsSerial.Send, 1, 3) = "PMR" Or Mid(QsSerial.Send, 1, 1) = "L" Or Mid(QsSerial.Send, 1, 3) = "TMS" Then '内部機能呼び出しコマンド

            Dim Comt = New List(Of Integer) From {50, 600, 200} '呼び出し（①100ms以内、②500ms以内、③200ms以上）

            Select Case QsSerial.Amod

                Case 0

                    'コマンド送信
                    TBClr1()
                    QsSerial.Recv = "" '受信データ（空白）
                    'QsSerial.Rstk = "" '一時保管（空白）
                    QsSerial.Rchk = False '受信完了（未）
                    QsSerial.Wrcv = 0 '受信待ち回数（0）
                    QsSerial.Acnt = 1 'ACK回数（1）
                    QsSerial.Amod = 1 '受信モード1（Case1 1回目のACK確認処理へ）
                    CmdA = qs.MakeSendCmd(QsSerial.Send) '送信電文作成（コマンド＋BCC＋ETX）
                    TextBox6.Text = qs.AsctoTxt(CmdA) 'テキストボックス6に送信電文表示
                    SendCmd(） '送信
                    Tm_Protocol.Interval = Comt(0) 'インターバル　①100m秒以内

                Case 1

                    'ACKの処理（受信データOKで先頭文字がACKの場合）

                    If QsSerial.Rchk = True Then '受信データOK（終端文字がLF）

                        If Asc(Mid(QsSerial.Recv, 1, 1)) = 6 Then 'ACKの時

                            If QsSerial.Acnt = 1 Then '1回目

                                'インターバルを②にセットしてデータ要求コマンドを送信する
                                TextBox2.Text = QsSerial.Recv '受信データを表示
                                QsSerial.Recv = "" '受信データクリア
                                QsSerial.Rchk = False '受信データOKをリセット
                                QsSerial.Acnt = QsSerial.Acnt + 1 'ACKの受信回数を加算
                                QsSerial.Amod = 3 'Case3（データ読み込み）へ
                                Tm_Protocol.Interval = Comt(1) 'インターバル　②に設定

                            ElseIf QsSerial.Acnt = 2 Then

                                '2回目（インターバルを④200m秒以内にセットして測定データを読み込む）
                                TextBox3.Text = QsSerial.Recv
                                QsSerial.Recv = ""
                                QsSerial.Rchk = False
                                QsSerial.Acnt = QsSerial.Acnt + 1
                                QsSerial.Amod = 3
                                Tm_Protocol.Interval = Comt(3) 'インターバル　④200m秒以内

                            End If

                        End If

                    Else

                        QsSerial.Wrcv = QsSerial.Wrcv + 1
                        If QsSerial.Wrcv > 10 Then

                            Tm_Protocol.Enabled = False
                            MessageBox.Show("応答なし（無効コマンドまたは通信不良）")
                            Exit Sub

                        End If

                    End If

                Case 2

                    'データ要求コマンドの送信（要求コマンドを送信してインターバルを③100m秒以内にセットし、2回目のACK確認へ）
                    SerialPortCmdSend("C") 'データ要求コマンドを送信
                    Tm_Protocol.Interval = Comt(2) 'インターバル　③100m秒以内 に変更
                    QsSerial.Amod = 1 'Case1（ACK確認の2回目）へ

                Case 3

                    '設定データの読み込み

                    '受信チェック
                    If QsSerial.Rchk = True Then

                        '受信あり
                        TextBox4.Text = QsSerial.Recv
                        QsSerial.Amod = 4
                        Tm_Protocol.Interval = Comt(2) 'インターバル　③

                    End If

                Case 4

                    'ACKの返信
                    SerialPortCmdSend("ACK")
                    TextBox5.Text &= qs.TxttoAsc(QsSerial.Recv)
                    QsSerial.Recv = ""
                    QsSerial.Rchk = False
                    QsSerial.Acnt = 1
                    QsSerial.Amod = 0
                    Tm_Protocol.Enabled = False 'タイマー処理停止

                Case Else

            End Select

            Exit Sub

        End If

        Tm_Protocol.Enabled = False 'タイマー処理停止
        MessageBox.Show("無効なコマンドです")
        Exit Sub

    End Sub

    Private Sub Tm_Interval_Tick(sender As Object, e As EventArgs) Handles Tm_Interval.Tick

        Dim _tmp As String
        Dim _value As Integer

        If QsSerial.cont > 1 Then
            If QsSerial.Data.Count = 0 Then
                Exit Sub
            End If


            '2回目以降
            _tmp = QsSerial.Data(16)
            If _tmp = Nothing Then
                'なにもしない
            End If
            If _tmp = "1" Then

                '追尾状態になったらリトライ数をリセットして計測
                QsSerial.Rtry = 0 '追尾リトライ数を0にする


            Else

                QsSerial.Rtry = QsSerial.Rtry + 1
                '追尾リトライ数の制限
                _value = CType(Tb_rtry.Text, Integer)
                If QsSerial.Rtry >= _value Then

                    Endmes() '計測、プロトコルタイマー停止
                    'MessageBox.Show("追尾動作を" & _value & "回繰り返しましたが視準できませんでした。ターゲットプリズムが障害物等で遮られていないか確認してください。")
                    Exit Sub

                End If

                '追尾リトライ数を超えたらWait
                Endmes() '計測停止
                Tm_Interval.Enabled = False '計測タイマー停止
                Tm_Protocol.Enabled = False '送受信タイマー停止

                QsSerial.Schf = True 'サーチモードをTrueに設定
                Tm_Search.Interval = 10 'サーチタイマーを即起動
                Tm_Search.Enabled = True 'サーチタイマー起動

            End If

            QsSerial.Amod = 0 '受信モード 0
            Me.Tm_Interval.Interval = CType(Tb_interval.Text, Integer) * 1000 '連続計測のインターバル設定
            Me.Tm_Protocol.Enabled = True 'データ送受信開始
            QsSerial.cont = QsSerial.cont + 1
            Tb_count.Text = QsSerial.cont
            Tb_rtcnt.Text = QsSerial.Rtry

        Else

            '初回
            QsSerial.Amod = 0 '受信モード 0
            Me.Tm_Interval.Interval = CType(Tb_interval.Text, Integer) * 1000 '連続計測のインターバル設定
            Me.Tm_Protocol.Enabled = True 'データ送受信開始
            QsSerial.cont = QsSerial.cont + 1
            Tb_count.Text = QsSerial.cont
            Tb_rtcnt.Text = QsSerial.Rtry

        End If

    End Sub

    Private Sub Tm_Search_Tick(sender As Object, e As EventArgs) Handles Tm_Search.Tick

        If QsSerial.Schf = True Then

            'サーチモードがTrueの時
            QsSerial.Schf = False 'サーチモードをFalse
            Tm_Search.Interval = 2000 'サーチインターバルを2秒に設定

            QsSerial.Stok = QsSerial.Send　'正規コマンドを一時退避
            QsSerial.Send = "T32" 'コマンドをウェイトに設定
            OneCmdOneSend() '１コマンドを１回送信

        Else

            Tm_Search.Enabled = False 'サーチタイマーを停止する
            QsSerial.Send = QsSerial.Stok '正規のコマンドに戻す
            ContiSend(QsSerial.Send, 10, 10)　'連続計測を再起動する

        End If

    End Sub

    Private Sub showMeasure(txt As List(Of String))

        If txt.Count = 0 Then
            Exit Sub
        End If

        Dim _d As Double

        '斜距離測定モード（Z30）の表示

        'TBClr2() '計測欄の消去

        If Double.TryParse(txt(0), _d) Then Tb_sl.Text = _d '0 斜距離（ｍ） _dにdouble型数値を代入している

        If Double.TryParse(txt(1), _d) Then Tb_vad.Text = _d '1 鉛直角（度）
        If Double.TryParse(txt(2), _d) Then Tb_vam.Text = _d '2 鉛直角（分）
        If Double.TryParse(txt(3), _d) Then Tb_vas.Text = _d '3 鉛直角（秒）
        If Double.TryParse(txt(4), _d) Then Tb_had.Text = _d '4 水平角（度）
        If Double.TryParse(txt(5), _d) Then Tb_ham.Text = _d '5 水平角（分）
        If Double.TryParse(txt(6), _d) Then Tb_has.Text = _d '6 水平角（秒）

        If Double.TryParse(txt(1), _d) Then Tb_vod.Text = _d '1 鉛直角（度）
        If Double.TryParse(txt(2), _d) Then Tb_vom.Text = _d '2 鉛直角（分）
        If Double.TryParse(txt(3), _d) Then Tb_vos.Text = _d '3 鉛直角（秒）
        If Double.TryParse(txt(4), _d) Then Tb_hod.Text = _d '4 水平角（度）
        If Double.TryParse(txt(5), _d) Then Tb_hom.Text = _d '5 水平角（分）
        If Double.TryParse(txt(6), _d) Then Tb_hos.Text = _d '6 水平角（秒）

        If Double.TryParse(txt(7), _d) Then Tb_tm.Text = _d '7 ﾁﾙﾄ（分）
        If Double.TryParse(txt(8), _d) Then Tb_ts.Text = _d '8 ﾁﾙﾄ（秒）
        If Double.TryParse(txt(9), _d) Then Tb_hl.Text = _d '9 水平距離（ｍ）
        If txt(10) = "t" Then　'10 鉛直角傾斜補正（ﾁﾙﾄ有り/無し）
            Tb_th.Text = "補正有り"
        ElseIf txt(10) = "*" Then
            Tb_th.Text = "補正無し"
        Else
            Tb_th.Text = "ﾁﾙﾄｵｰﾊﾞ"
        End If
        If Double.TryParse(txt(11), _d) Then
            Tb_light.Text = CType(txt(11), Double) '11 EDM 反射光ﾚﾍﾞﾙ 数値変換
        Else
            Tb_light.Text = txt(11) '11 EDM 反射光ﾚﾍﾞﾙ　変換せず
        End If
        If Double.TryParse(txt(12), _d) Then Tb_weath.Text = _d '12 EDM 気象補正値
        If Double.TryParse(txt(13), _d) Then Tb_prism.Text = _d '13 ﾌﾟﾘｽﾞﾑ定数
        If Double.TryParse(txt(14), _d) Then
            Select Case CType(txt(14), Double) '14 ﾊﾞｯﾃﾘｰﾚﾍﾞﾙ
                Case 0
                    Tb_batt.Text = "100%"
                Case 1
                    Tb_batt.Text = "75%"
                Case 2
                    Tb_batt.Text = "50%"
                Case 3
                    Tb_batt.Text = "25%"
            End Select
        End If
        If Double.TryParse(txt(15), _d) Then
            Select Case CType(txt(15), Double) '15 EDMﾓｰﾄﾞ
                Case 1
                    Tb_edm.Text = "ｺｰｽ1mm"
                Case 2
                    Tb_edm.Text = "ｺｰｽ10mm"
                Case 3
                    Tb_edm.Text = "ﾌｧｲﾝ0.2mm"
                Case 4
                    Tb_edm.Text = "ﾌｧｲﾝ1mm"
            End Select
        End If
        If Double.TryParse(txt(16), _d) Then
            Select Case CType(txt(16), Double) '16 追尾ﾓｰﾄﾞ
                Case 0
                    Tb_sea.Text = "ｽﾀﾝﾊﾞｲ"
                Case 1
                    Tb_sea.Text = "追尾"
                Case 2
                    Tb_sea.Text = "ｻｰﾁ"
                Case 3
                    Tb_sea.Text = "ｳｪｲﾄ"
                Case 5
                    Tb_sea.Text = "旋回中"
            End Select
        End If
        If txt(17) = "r" Then '17 ﾌｪｲｽ
            Tb_fac.Text = "正"
        Else
            Tb_fac.Text = "反"
        End If
        'If txt(18) = "t" Then　'18 ﾁﾙﾄ有り/無し
        'Tb_th.Text = "補正有り"
        'ElseIf txt(18) = "*" Then
        'Tb_th.Text = "補正無し"
        'Else
        'Tb_th.Text = "ﾁﾙﾄｵｰﾊﾞ"
        'End If


    End Sub

    Private Sub Bt_serch_Click(sender As Object, e As EventArgs) Handles Bt_serch.Click

        '送信データをセット
        QsSerial.Send = "T31"　'追尾をサーチ状態にする T34と同一？
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_Weit_Click(sender As Object, e As EventArgs) Handles Bt_Weit.Click

        '送信データをセット
        QsSerial.Send = "T32"　'追尾をウェイト状態にする
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_stop_Click(sender As Object, e As EventArgs) Handles Bt_stop.Click

        '送信データをセット
        QsSerial.Send = "T30"　'追尾や旋回を中止する
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_circleab_Click(sender As Object, e As EventArgs) Handles Bt_circleab.Click

        Dim qs As New QsSerial()
        Dim _st As New List(Of String)
        Dim _str As String = ""

        '送信コマンドの作成
        _st.Add("TTA")
        _st.Add(qs.StrNumLeft0(Tb_vod.Text, 3, 1))
        _st.Add(qs.StrNumLeft0(Tb_vom.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_vos.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_hod.Text, 3, 1))
        _st.Add(qs.StrNumLeft0(Tb_hom.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_hos.Text, 2, 0))
        _st.Add("d")

        For i As Integer = 0 To 7
            _str = _str & _st(i)
        Next

        '送信データをセット
        QsSerial.Send = _str　'入力した絶対角度で旋回する。
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_circlerl_Click(sender As Object, e As EventArgs) Handles Bt_circlerl.Click

        Dim qs As New QsSerial()
        Dim _st As New List(Of String)
        Dim _str As String = ""

        '送信コマンドの作成
        _st.Add("TTR")
        _st.Add(qs.StrNumLeft0(Tb_vod.Text, 3, 1))
        _st.Add(qs.StrNumLeft0(Tb_vom.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_vos.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_hod.Text, 3, 1))
        _st.Add(qs.StrNumLeft0(Tb_hom.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_hos.Text, 2, 0))
        _st.Add("d")

        For i As Integer = 0 To 7
            _str = _str & _st(i)
        Next

        '送信データをセット
        QsSerial.Send = _str　'入力した絶対角度で旋回する。
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_SetAng_Click(sender As Object, e As EventArgs) Handles Bt_SetAng.Click

        Dim qs As New QsSerial()
        Dim _st As New List(Of String)
        Dim _str As String = ""

        '送信コマンドの作成
        _st.Add("J")
        _st.Add(qs.StrNumLeft0(Tb_Shd.Text, 3, 1))
        _st.Add(qs.StrNumLeft0(Tb_Shm.Text, 2, 0))
        _st.Add(qs.StrNumLeft0(Tb_Shs.Text, 2, 0))
        _st.Add("d")

        For i As Integer = 0 To 4
            _str = _str & _st(i)
        Next

        '送信データをセット
        QsSerial.Send = _str　'入力した絶対角度で旋回する。
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_Tron_Click(sender As Object, e As EventArgs) Handles Bt_Tron.Click

        '送信データをセット
        QsSerial.Send = "ZA1"　'ポイントガイド/トラッキングインジケータをONにする
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_Troff_Click(sender As Object, e As EventArgs) Handles Bt_Troff.Click

        '送信データをセット
        QsSerial.Send = "ZA0"　'ポイントガイド/トラッキングインジケータをOFFにする
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_Lzon_Click(sender As Object, e As EventArgs) Handles Bt_Lzon.Click

        '送信データをセット
        QsSerial.Send = "ZH01"　'レーザーポインターをONにする
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Bt_Lzoff_Click(sender As Object, e As EventArgs) Handles Bt_Lzoff.Click


        '送信データをセット
        QsSerial.Send = "ZH00"　'ポイントガイド/トラッキングインジケータをOFFにする
        OneCmdOneSend() '１コマンドを１回送信

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '保護機能セット
        QsSerial.Safe = Cb_safe.Checked
        QsSerial.Wsec = Integer.Parse(Tb_wait.Text) * 1000
        QsSerial.Wint = Integer.Parse(Tb_waititv.Text) * 1000

    End Sub

    Private Sub Tm_PlcCom_Tick(sender As Object, e As EventArgs) Handles Tm_PlcCom.Tick

        lb_RinNo.Text = PlcIF.RingNo
        lb_RealSt.Text = PlcIF.realStroke
        lb_frDir.Text = PlcIF.gyro.ToString("F2")
        lb_frPitch.Text = PlcIF.machinePitching.ToString("F2")

        lb_rrRolling.Text = PlcIF.mashineRearRolling.ToString("F2")


        lb_NkLDSt.Text = PlcIF.LeftDownNkStroke
        lb_NkLUSt.Text = PlcIF.LeftUpNkStroke
        lb_NkRUSt.Text = PlcIF.RightUpNkStroke
        lb_NkRDSt.Text = PlcIF.RightDownNkStroke



        Select Case PlcIF.excaStatus
            Case cKussin
                lb_ExecSts.Text = "掘進中"
                lb_ExecSts.BackColor = Color.Red
            Case cChudan
                lb_ExecSts.Text = "中断"
                lb_ExecSts.BackColor = Color.Yellow
            Case cTaiki
                lb_ExecSts.Text = "待機中"
                lb_ExecSts.BackColor = Color.Cyan
        End Select

        lb_PlcComDate.Text = PlcIF.DataGetTime.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ExcellRun()

    End Sub

    Private Sub ExcellRun()

        'TS 鉛直角
        ExcelLink.Range("Z3").Value = Tb_vad.Text
        ExcelLink.Range("AA3").Value = Tb_vam.Text
        ExcelLink.Range("AB3").Value = Tb_vas.Text
        'TS 水平角
        ExcelLink.Range("Z4").Value = Tb_had.Text
        ExcelLink.Range("AA4").Value = Tb_ham.Text
        ExcelLink.Range("AB4").Value = Tb_has.Text

        ExcelLink.Range("Z5").Value = Tb_hl.Text
        ExcelLink.Range("AB5").Value = Tb_sea.Text
        If Tb_sea.Text = "追尾" Then　'追尾時のみ時刻設定
            ExcelLink.Range("Y2").Value = Now
        End If




        ExcelLink.Range("Z6").Value = PlcIF.gyro '方位角転送

        ExcelLink.Range("Z7").Value = PlcIF.machinePitching '前胴ﾋﾟｯﾁﾝｸﾞ
        ExcelLink.Range("Z8").Value = PlcIF.mashineRearRolling '後胴ﾛｰﾘﾝｸﾞ

        ExcelLink.Range("Z9").Value = PlcIF.RightUpNkStroke '中折st（右上)
        ExcelLink.Range("Z10").Value = PlcIF.RightDownNkStroke '中折st（右下)
        ExcelLink.Range("Z11").Value = PlcIF.LeftDownNkStroke '中折st（左下)
        ExcelLink.Range("Z12").Value = PlcIF.LeftUpNkStroke '中折st（左上)

        ExcelLink.Range("AB9").Value = PlcIF.RingNo 'ﾘﾝｸﾞNo
        ExcelLink.Range("AB10").Value = PlcIF.realStroke '推進量
        Select Case PlcIF.excaStatus
            Case cKussin
                ExcelLink.Range("AB11").Value = "掘進中"
            Case cChudan
                ExcelLink.Range("AB11").Value = "中断"
            Case cTaiki
                ExcelLink.Range("AB11").Value = "待機中"
        End Select



        'エクセル演算
        ExcelLink.Culc()

        'ターゲット、マシン座標等の表更新
        For Each resltcell In Me.Controls

            If resltcell.Name.StartsWith("lb_ResltR") Then
                Dim Row As Integer = CInt(resltcell.Name.Substring(9, 1))
                Dim Col As Integer = CInt(resltcell.Name.Substring(11))

                Select Case Col
                    Case 6, 7, 20, 35   '偏差、線形状等
                        resltcell.Text = ExcelLink.Cell(Row + 40, Col + 4, 0)
                    Case Else '座標等
                        resltcell.Text = ExcelLink.Cell(Row + 40, Col + 4, 3)
                End Select
            End If
        Next

        lb_AvDh.Text = ExcelLink.Cell("S2", 0) '平面平均偏差
        lb_AvDv.Text = ExcelLink.Cell("T2", 0) '縦断平均偏差
        lb_rrDir.Text = ExcelLink.Cell("F39", 2) '後胴方位角
        lb_NkLR.Text = ExcelLink.Cell("F7", 3) '中折左右
        lb_NkUD.Text = ExcelLink.Cell("G7", 3) '中折左右
        lb_rrPitch.Text = ExcelLink.Cell("G9", 3) '後胴ピッチング

        lb_TgmX.Text = ExcelLink.Cell("E14", 3) 'ターゲットm座標系
        lb_TgmY.Text = ExcelLink.Cell("F14", 3) '
        lb_TgmZ.Text = ExcelLink.Cell("G14", 3) '



        'lb_ResltR0C0.Text = ExcelLink.Cell(41, 5)
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles lb_ResltR6C4.Click

    End Sub

    Private Sub Label92_Click(sender As Object, e As EventArgs) Handles lb_ResltR6C35.Click

    End Sub

    Private Sub ucnHorDevChart_Load(sender As Object, e As EventArgs) Handles ucnHorDevChart.Load

    End Sub

    Private Sub ucnHorDevChart_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles ucnHorDevChart.ContextMenuStripChanged

    End Sub

    Private Sub ucnHorDevChart_Click(sender As Object, e As EventArgs) Handles ucnHorDevChart.Click, btnHorScaleChange.Click

        Dim frmHorScaleChange As New frmGraphScaleChange(True)
        frmHorScaleChange.ShowDialog(Me)

    End Sub

    Private Sub ucnVerDevChart_Click(sender As Object, e As EventArgs) Handles ucnVerDevChart.Click, btnVerScaleChange.Click

        Dim frmVerScaleChange As New frmGraphScaleChange(False)
        frmVerScaleChange.ShowDialog(Me)


    End Sub

    Private Sub btnDevImgScaleChange_Click(sender As Object, e As EventArgs) Handles btnDevImgScaleChange.Click
        Dim frmDevImgScaleChange As New frmDevImgScaleChange
        frmDevImgScaleChange.ShowDialog(Me)

    End Sub
End Class