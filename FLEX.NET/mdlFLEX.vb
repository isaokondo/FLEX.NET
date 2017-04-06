﻿Option Explicit On

Module mdlFLEX

    Public InitPara As clsInitParameter '初期値パラメータ

    Public HorPlan As clsHorPanData '平面掘進計画線
    Public VerPlan As clsVerPlanData '縦断掘進計画線
    ''' <summary>
    ''' シールドマシン諸元
    ''' </summary>
    Public MachineSpec As clsMachinSpec

    Public SegAsmblyData As clsSegmentAssembly ''セグメント組立データ

    Public WithEvents CtlPara As clsControlParameter  '制御パラメータ

    Public CulcMoment As clsCulMoment ''モーメント、推力の演算

    Public WithEvents JackMvAuto As clsCulJackMv ''ジャッキ操作量の演算
    ''' <summary>
    ''' 推力分担率の演算
    ''' </summary>
    Public DivCul As clsThrustDiv ''
    ''' <summary>
    ''' 基準方位演算
    ''' </summary>
    Public RefernceDirection As clsCulKijun
    ''' <summary>
    ''' ジャッキ手動操作出力
    ''' </summary>
    Public WithEvents JackManual As clsJkManualOut

    'PLCインターフェース
    Public WithEvents PlcIf As clsPlcIf

    ''' <summary>
    ''' 減圧処理
    ''' </summary>
    Public WithEvents Reduce As clsReducePress
    ''' <summary>
    ''' ロスゼロ時の計算ストローク
    ''' </summary>
    Public CalcStroke As clsCalcuStroke

    ''' <summary>
    ''' ロスゼロステータス（工程表示用)
    ''' 1:減圧中　2:減圧完了　3:引き戻し中　4:引き戻し完了　5:組立中 6:組立完了
    ''' </summary>
    Public LosZeroSts As Short
    ''' <summary>
    ''' 経過時間の算出
    ''' </summary>
    Public ElapsedTime As New clsElapsedTime

    ''' <summary>
    ''' データ保存
    ''' </summary>
    Public DataSave As clsDataSave

    ''' <summary>
    ''' テーブル更新日付取得
    ''' </summary>
    Public TableUpdateConfirm As clsTableUpdateConfirm

    ''' <summary>
    ''' MP3再生
    ''' </summary>
    ''' <param name="command"></param>
    ''' <param name="buffer"></param>
    ''' <param name="bufferSize"></param>
    ''' <param name="hwndCallback"></param>
    ''' <returns></returns>
    <System.Runtime.InteropServices.DllImport("winmm.dll",
    CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Function mciSendString(ByVal command As String,
    ByVal buffer As System.Text.StringBuilder,
    ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function


    Private player As System.Media.SoundPlayer = Nothing

    ''' <summary>
    ''' リソースからWAVを再生する
    ''' </summary>
    ''' <param name="strm"></param>
    Private Sub PlaySound(strm As IO.Stream)

        '再生されているときは止める
        If Not (player Is Nothing) Then
            StopSound()
        End If

        '読み込む
        player = New System.Media.SoundPlayer(strm)
        '非同期再生する
        player.Play()


    End Sub

    '再生されている音を止める
    Private Sub StopSound()
        If Not (player Is Nothing) Then
            player.Stop()
            player.Dispose()
            player = Nothing
        End If
    End Sub


    Public Sub Main()
        'メイン画面の表示
        Application.Run(New frmMain())

    End Sub

    Private Sub PlcIf_PLCErrOccur(sender As Object, ByVale As EventArgs, ErrMsg As String, ErrCode As Long) Handles PlcIf.PLCErrOccur
        If ErrCode <> 0 Then
            Dim response = MsgBox($"PLC通信エラー:{ErrMsg}", MsgBoxStyle.AbortRetryIgnore)
            If response = MsgBoxResult.Abort Then End
        Else
            WriteEventData(ErrMsg, Color.Red)
        End If
    End Sub

    ''' <summary>
    ''' 掘進ステータス変化時
    ''' </summary>
    ''' <param name="PreStatus">変化前</param>
    ''' <param name="NowStatus">変化後</param>
    Private Sub PlcIf_ExcavationStatusChange(PreStatus As Integer, NowStatus As Integer) _
        Handles PlcIf.ExcavationStatusChange
        '組立パターンの情報を取得
        SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)
        '姿勢トレンドのデータ取得
        frmMain.DirectionChartD.DataGet()
        'TODO:最大テーパーの算出
        CalcStroke.SegmentTaperValue = SegAsmblyData.TypeData(PlcIf.RingNo).ETTaper
        'セグメント幅
        CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000

        'If PreStatus = -1 Then Exit Sub
        '待機中から掘進
        If PreStatus = cTaiki And NowStatus = cKussin Then

            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
            PlcIf.LosZeroSts_FLEX = 0
            WriteEventData($"{PlcIf.RingNo}リング 掘進開始しました", Color.CornflowerBlue)
            My.Forms.frmMain.ChartClear() 'チャート初期化
            My.Forms.frmMain.DspExcavStartDay(Now)
            ElapsedTime.Reset() '掘進時間計算開始
            CalcStroke.ExecavStart() '計算ストローク組立完了ジャッキクリア
            '掘進開始時のストローク取り込み
            CtlPara.StartJackStroke = New Dictionary(Of Short, Integer)(PlcIf.MesureJackStroke)
            FullOpenStart() '全押しスタート
        End If
        If PreStatus = cChudan And NowStatus = cKussin Then
            WriteEventData("掘進再開しました", Color.Magenta)
            ElapsedTime.ExcavationStart()
            If LosZeroSts >= 1 Then ElapsedTime.LosZeroStart()

            'Mp3Play(My.Resources.ReduceStart)


        End If
        '中断
        If NowStatus = cChudan Then
            'JackManual.ManualOn = False
            WriteEventData("掘進中断しました", Color.Black)
            ElapsedTime.ExcavationStop()
            '最終ストロークをセグメント割付データに書き込み
            SegAsmblyData.RingLastStrokeUpdate(PlcIf.RingNo, CalcStroke.MesureCalcAveJackStroke)

        End If

        '待機中
        If NowStatus = cTaiki Then

            '自動印字　出力
            ReportAutoPrintOut()


            LosZeroSts = 0
            If PreStatus <> -1 Then
                WriteEventData($"{PlcIf.RingNo}リング 待機中になりました。", Color.Blue)
            End If
            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
            PlcIf.LosZeroSts_FLEX = 0
            PlcIf.LosZeroDataWrite("減圧ジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("引戻しジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("押込みジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("押込みジャッキ②", Nothing)
            PlcIf.LosZeroEnable = False   '同時施工可OFF
            ElapsedTime.WaingStart() '経過時間の算出

            '掘進開始時のストローク取り込み
            CtlPara.StartJackStroke = New Dictionary(Of Short, Integer)(PlcIf.MesureJackStroke)


        End If
        '掘進中で手動方向制御
        If NowStatus = cKussin And CtlPara.AutoDirectionControl = False Then
            '保持してる作用点
            JackManual.PutPointXY(PlcIf.PointX, PlcIf.PointY)
        End If

        '掘進してないときは、自動方向制御停止
        If NowStatus <> cKussin Then JackMvAuto.MvAutoStop()

        If NowStatus = cKussin And CtlPara.AutoDirectionControl Then
            JackMvAuto.MvAutoStart()
        End If


        My.Forms.frmMain.SegmentDataDsp() 'セグメント組立情報表示

    End Sub

    ''' <summary>
    ''' 同時施工ステータス変化
    ''' </summary>
    ''' <param name="PreSts">変化前のステータス</param>
    ''' <param name="NowSts">変化後のステータス</param>
    ''' <param name="FromDev">True:マシン　False：FLEX</param>
    Private Sub PlcIf_LosZeroStsChange(PreSts As Short,
                                       NowSts As Short, FromDev As Boolean) Handles PlcIf.LosZeroStsChange
        'マシンからのステータス
        If FromDev Then

            With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                Select Case NowSts
                    Case 1 'マシンからの減圧開始
                        PlcIf.LosZeroSts_FLEX = 1 '1ピース目の減圧開始
                        LosZeroSts = 1
                        ElapsedTime.LosZeroStart()  '同時施工時間算出

                    Case 2
                        '引き戻しジャッキ
                        Dim PullJk As String =
                            String.Join(",", .PullBackJack)

                        WriteEventData($"No.{PullJk} のジャッキの引戻し開始しました。", Color.Blue)
                        LosZeroSts = 3
                        Reduce.LstR.Clear() '減圧グループ　クリア

                        PlaySound(My.Resources.PullStart)
                    Case 3
                        WriteEventData("ジャッキの引戻し完了しました。", Color.Magenta)
                        LosZeroSts = 4

                        PlaySound(My.Resources.PullFInish)
                    Case 4, 6
                        '押込みジャッキ
                        Dim ClosetJk As String =
                            String.Join(",", .ClosetJack)
                        WriteEventData($"No.{ClosetJk} のジャッキ押込み開始しました。", Color.Blue)
                        LosZeroSts = 5
                        'ボイスメッセージ出力
                        PlaySound(My.Resources.ClosetStart)

                    Case 5, 7

                        WriteEventData($"[{ .PieceName}] セグメント組立完了しました。", Color.Magenta)
                        PlcIf.LosZeroSts_FLEX = 3   '組立完了確認
                        LosZeroSts = 6
                        '計算ストローク用に組立ジャッキの設定
                        CalcStroke.SetAsembleJack(.ClosetJack)

                        'ボイスメッセージ出力
                        PlaySound(My.Resources.SegmentAsem)

                        'TODO:推進圧力がある程度たってから
                        '最終ピース到達前 減圧ジャッキがある場合
                        If PlcIf.AssemblyPieceNo < SegAsmblyData.AssemblyPieceNumber AndAlso
                            SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo + 1).ReduceJack.Count > 0 Then
                            If CtlPara.NextPieceConfirm Then
                                '同時施工継続メッセージ出力
                                My.Forms.frmNextPieceConfirm.Show()
                            Else
                                PlcIf.LosZeroSts_FLEX = 1 '減圧開始
                            End If
                        End If
                    Case 7
                        WriteEventData("ジャッキ押付け完了しました。", Color.Magenta)
                        PlcIf.LosZeroSts_FLEX = 4 '押し付け完了確認


                    Case 8
                        WriteEventData("Kセグメント組立完了しました。", Color.Magenta)

                End Select
            End With

        Else
            'FLEXからのステータス
            Select Case NowSts
                Case 1  '減圧開始
                    If PlcIf.LosZeroSts_M <> 1 And PlcIf.AssemblyPieceNo < SegAsmblyData.AssemblyPieceNumber Then
                        PlcIf.AssemblyPieceNo += 1  '組立ピース　更新
                    End If
                    My.Forms.frmNextPieceConfirm.Close() '継続確認画面を閉じる
                    With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                        '減圧グループ
                        WriteEventData($"{PlcIf.AssemblyPieceNo}ピース目 {String.Join(",", .ReduceGroup)}グループの減圧開始します。", Color.Blue)

                        'マシンへ指令　
                        PlcIf.LosZeroDataWrite("減圧ジャッキ", .ReduceJack)
                        PlcIf.LosZeroDataWrite("引戻しジャッキ", .PullBackJack)
                        PlcIf.LosZeroDataWrite("押込みジャッキ", .ClosetJack)
                        PlcIf.LosZeroDataWrite("押込みジャッキ②", .AddClosetJack)
                    End With
                    '減圧処理開始
                    'Reduce = New clsReducePress
                    Reduce.Start()
                    LosZeroSts = 1

                    PlaySound(My.Resources.ReduceStart) 'ボイスメッセージ

                    '計算ストローク用セグメント幅等設定
                    CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
                    'todo:テーパー量等？

                Case 2
                    WriteEventData("減圧完了しました。", Color.Magenta)
                    PlcIf.LosZeroDataWrite("減圧ジャッキ", Nothing)
                    LosZeroSts = 2

                    PlaySound(My.Resources.ReduceFinish)

            End Select

        End If

        My.Forms.frmMain.SegmentDataDsp() 'セグメント組立情報表示

    End Sub
    ''' <summary>
    ''' 同時施工モード変化
    ''' </summary>
    Private Sub PlcIf_LosZeroModeChange() Handles PlcIf.LosZeroModeChange

        LosZeroSettingInit() '同時施工データ初期化

        If PlcIf.LosZeroMode Then
            WriteEventData("同時施工モードになりました。", Color.Blue)
        Else
            WriteEventData("同時施工モードがOFFになりました", Color.Magenta)
            LosZeroSts = 0
            ElapsedTime.LosZeroStop()
        End If
    End Sub
    ''' <summary>
    ''' 同時施工キャンセル
    ''' </summary>
    Private Sub PlcIf_LosZeroCancelOn() Handles PlcIf.LosZeroCancelOn
        LosZeroSettingInit() '同時施工データ初期化
        PlcIf.DigtalPlcWrite("同時施工キャンセル", False)
        Reduce.Cancel()
        WriteEventData("同時施工キャンセルされました。", Color.Red)

    End Sub
    ''' <summary>
    ''' 計測ストロークの変化時
    ''' ステータス変化時
    ''' </summary>
    Public Sub PlcIf_MesureStrokeChange() Handles PlcIf.MesureStrokeChange, PlcIf.ExcavationStatusChange
        CalcStroke.MesureJackStroke = PlcIf.MesureJackStroke
        CalcStroke.MesureJackSpeed = PlcIf.MesureJackSpeed
        CalcStroke.Calc() '計算ストローク演算
        PlcIf.AnalogPlcWrite("掘進ストローク", CalcStroke.CalcAveLogicalStroke)
        PlcIf.AnalogPlcWrite("掘進スピード", CalcStroke.MesureAveSpeed)
        PlcIf.AnalogPlcWrite("平均ジャッキストローク", CalcStroke.MesureCalcAveJackStroke)
    End Sub



    ''' <summary>
    ''' 同時施工データ初期化
    ''' </summary>
    Private Sub LosZeroSettingInit()
        PlcIf.LosZeroSts_FLEX = 0
        PlcIf.LosZeroDataWrite("減圧ジャッキ", Nothing)
        PlcIf.LosZeroDataWrite("引戻しジャッキ", Nothing)
        PlcIf.LosZeroDataWrite("押込みジャッキ", Nothing)
        PlcIf.LosZeroDataWrite("押込みジャッキ②", Nothing)
        PlcIf.LosZeroEnable = False   '同時施工可OFF

    End Sub



    ''' <summary>
    ''' マシン先端距離の変化時の処理
    ''' </summary>
    Private Sub LineDistanceChage() Handles PlcIf.LineDistanceChage, CtlPara.ReferChnge

        '        RefernceDirection.Distance.測量ポイントリング番号
        RefernceDirection.sbCulKijun()

        My.Forms.frmMain.LineDataUpdate()

        If CtlPara.AutoDirectionControl Then
            JackMvAuto.水平偏差角 = RefernceDirection.平面偏角
            JackMvAuto.鉛直偏差角 = RefernceDirection.縦断偏角
        End If

        frmMain.DirectionChartD.DataUp()


    End Sub
    ''' <summary>
    ''' 掘進開始時に全押しスタート
    ''' </summary>
    Private Sub FullOpenStart()
        'FLEX制御、自動、全押しスタートフラグON
        If CtlPara.AutoDirectionControl And CtlPara.全押しスタート And PlcIf.FlexControlOn Then

            '手動操作の作用点を原点にし
            JackManual.PutPointXY(0, 0)
            '手動から自動制御へ移行
            ControlParameter_FlexAutoManualChange()

        End If

    End Sub

    ''' <summary>
    ''' 操作出力の処理
    ''' </summary>
    Private Sub JackManual_PointChanges() Handles PlcIf.ExcavationStatusChange, PlcIf.JkPressFilterChange,
        JackMvAuto.AutoDirectionCulc, Reduce.ReduceOn, PlcIf.LosZeroStsChange, JackManual.PointChanges

        With DivCul
            'パラメータセット
            DivCul.最低全開グループ数 = CtlPara.最低全開グループ数
            DivCul.全開作動指令値 = CtlPara.全開作動指令値
            DivCul.全開作動範囲 = CtlPara.全開作動範囲
            'DivCul.全開グループ制限 = CtlPara.全開グループ制限

            If CtlPara.AutoDirectionControl Then
                '力点自動
                DivCul.操作角 = JackMvAuto.操作角
                DivCul.操作強 = JackMvAuto.操作強
                PlcIf.PointX = JackMvAuto.PointX
                PlcIf.PointY = JackMvAuto.PointY
                PlcIf.操作角 = JackMvAuto.操作角
                PlcIf.操作強 = JackMvAuto.操作強
            Else
                '力点手動操作時

                DivCul.操作角 = JackManual.操作角
                DivCul.操作強 = JackManual.操作強
                PlcIf.操作角 = JackManual.操作角
                PlcIf.操作強 = JackManual.操作強
            End If
            'TODO:ジャッキステータスを追加するように
            '掘進モードをセット
            DivCul.OnJack = PlcIf.JackExecMode
            DivCul.sbCul() ''推力分担率の演算
            '力点の更新
            PlcIf.PointWrite()

        End With


        GroupSvOut() 'シーケンサへ圧力分担値の送出

    End Sub



    ''' <summary>
    ''' シーケンサへ圧力分担値の送出
    ''' </summary>
    Private Sub GroupSvOut()


        Dim sngGpSV(InitPara.NumberGroup - 1) As Single
        Dim intGpFl(InitPara.NumberGroup - 1) As Short



        Select Case PlcIf.ExcaStatus

            Case cKussin
                ''掘進中の処理
                '減圧中から組立完了
                If PlcIf.LosZeroSts_FLEX >= 1 And PlcIf.LosZeroSts_FLEX < 3 Then
                    Dim Gp As List(Of Short) =
                        SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo).ReduceGroup
                    For Each R As Short In Gp
                        sngGpSV(R - 1) =
                        Reduce.MvOut(R - 1) * CtlPara.最大全開出力時の目標圧力 / 100
                        intGpFl(R - 1) = cTracking
                    Next
                End If

                For i = 0 To InitPara.NumberGroup - 1
                    If intGpFl(i) <> cTracking Then
                        If DivCul.FullOpenGruop.Contains(i) Then ''全開出力
                            sngGpSV(i) = CtlPara.最大全開出力時の目標圧力
                            intGpFl(i) = cFillPower
                        Else
                            sngGpSV(i) = DivCul.分担率指令値(i) / 100 * PlcIf.FilterJkPress
                            '低圧推進の設定値 
                            'TODO:最適化は考慮してない！
                            If CtlPara.optGpEn.Contains(i + 1) AndAlso
                                sngGpSV(i) > CtlPara.optGpSv(i) Then
                                sngGpSV(i) = CtlPara.optGpSv(i)
                            End If
                            If Math.Abs(PlcIf.GroupPv(i) - PlcIf.GroupSV(i)) < CtlPara.PIDShiftDefl _
                                    Or CtlPara.DirectControl = False Then
                                intGpFl(i) = cPIDOut ''ＰＩＤ出力
                            Else
                                intGpFl(i) = cDirect  'ダイレクト指令制御
                            End If

                        End If
                    End If
                    'TODO:トラッキングの意味
                    ''01/09/20 追加
                    'If mblnTracking Then
                    '    intGpFl(i) = cTracking ''トラッキング
                    '    'frmTuningMonitor.lblPID(intCnt).Text = "T" ''チューニングモニタのステータス
                    'End If

                Next i
                    ''中断中及び待機中の処理
            Case cChudan, cTaiki
                For intCnt = 0 To InitPara.NumberGroup - 1
                    intGpFl(intCnt) = cIgnoreOut
                Next intCnt

        End Select
        ''シーケンサ出力
        PlcIf.PutSvPress(sngGpSV, intGpFl)




    End Sub




    ''' <summary>
    ''' イベントデータをデータベースに書込
    ''' </summary>
    ''' <param name="EventMsg">イベントメッセージ</param>
    ''' <param name="EventColor">表示用のイベントカラー</param>
    Public Sub WriteEventData(EventMsg As String, EventColor As Color)
        Dim Colorlng As Long = ColorTranslator.ToOle(EventColor)

        Dim db As New clsDataBase

        'Dim tb As Odbc.OdbcDataReader = 
        db.ExecuteSqlCmd _
            ($"INSERT INTO FLEXイベントデータ
            (Time,イベントデータ,イベント種類) VALUES('{Now}','{EventMsg}','{Colorlng}')")

        frmMain.EventlogUpdate()

    End Sub
    ''' <summary>
    ''' 姿勢制御自動手動の切替時の処理
    ''' </summary>
    ''' 
    Public Sub ControlParameter_FlexAutoManualChange() Handles CtlPara.FlexAutoManualChange ', PlcIf.ExcavationStatusChange
        '掘進中以外はスキップ
        'If PlcIf.ExcaStatus <> cKussin Then Exit Sub

        If PlcIf.FlexControlOn AndAlso CtlPara.AutoDirectionControl Then
            'JackManual.ManualOn = False
            If PlcIf.ExcaStatus = cKussin Then
                WriteEventData("自動方向制御開始しました。", Color.Blue)
            End If
            'tmrAutoDirect.Enabled = False
            'TODO:自動手動切替時しかPID定数が反映されてない！
            ''手動→自動切替時
            With JackMvAuto

                .水平P定数 = CtlPara.水平ジャッキ制御P定数
                .水平I定数 = CtlPara.水平ジャッキ制御I定数
                .水平D定数 = CtlPara.水平ジャッキ制御D定数
                .鉛直P定数 = CtlPara.鉛直ジャッキ制御P定数
                .鉛直I定数 = CtlPara.鉛直ジャッキ制御I定数
                .鉛直D定数 = CtlPara.鉛直ジャッキ制御D定数
                .水平偏差角 = RefernceDirection.平面偏角
                .鉛直偏差角 = RefernceDirection.縦断偏角
                ''自動から手動時のトラッキング処理
                .PointX = JackManual.PointX
                .PointY = JackManual.PointY
                .sbMnToAutTracking()
                ''自動演算開始
                .MvAutoStart()
            End With

        Else
            If PlcIf.FlexControlOn AndAlso PlcIf.ExcaStatus = cKussin Then
                WriteEventData("方向制御 手動モードに変わりました", Color.Blue)
            End If
            ''自動演算停止
            JackMvAuto.MvAutoStop()
            '                ''自動→手動切替時
            'TODO:操作権
            'If mneSosa.Checked Then
            ''自動から手動時のトラッキング処理
            ''自動時の座標を手動時の座標へ渡す
            JackManual.PutPointXY(JackMvAuto.PointX, JackMvAuto.PointY)

        End If
    End Sub

    Private Sub JackMvAuto_OneWayLimitModeChanges(Flg As Boolean) Handles JackMvAuto.OneWayLimitModeChanges
        If Flg Then
            WriteEventData("圧力調整中になりました。", Color.Magenta)
            WriteEventData("方向制御　自動に変わりました", Color.Orange)

        Else
            WriteEventData("PID制御に変わりました。", Color.Blue)
        End If
    End Sub
    ''' <summary>
    ''' リング報自動印字
    ''' </summary>
    Private Sub ReportAutoPrintOut()

        Dim RprDB As New clsReportDb

        '最新リング番号
        Dim LstRingNo As Integer = RprDB.LastRing
        'パターンリストを取得
        Dim ptLst = From i In My.Settings.ReportAutoPrintPtn.Split(",") Where IsNumeric(i)

        For Each PtnSelNo As Short In ptLst

            'テンポラリファイル名
            Dim TmpPath As String =
            $"{AppDomain.CurrentDomain.BaseDirectory}tmp\RingReport_Ptn{PtnSelNo}_Ring{LstRingNo}_{Now.ToString("yyyymmddhhmmssff")}.xlsx"

            'シートにデータ書き込み
            'テンポラリファイルにリング報保存
            RprDB.ReportSheetWrite(LstRingNo, PtnSelNo).SaveAs(TmpPath)


            '保存したエクセル（テンポラリファイル)を印刷　VBS経由で
            Dim psi As New ProcessStartInfo("WScript.exe")
            psi.Arguments =
            $"{AppDomain.CurrentDomain.BaseDirectory}Resources\excelprt.vbs {TmpPath}"

            Dim job As Process = Process.Start(psi)
            job.WaitForExit()
            If job.ExitCode <> 0 Then
                MsgBox("リング報自動印刷に失敗しました。", vbCritical)
            End If

        Next


    End Sub




    ''' <summary>
    ''' 正円を描画
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Public Sub DrawACircle(pen As Pen, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.DrawEllipse(pen, rect)

    End Sub
    ''' <summary>
    ''' 文字列の中から数値を取得
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    Public Function GetNum(st As String) As Short
        Return Val(Array.FindAll(st.ToString.ToCharArray, AddressOf IsNumeric))
    End Function



    ''' <summary>
    ''' 正円を塗りつぶし
    ''' </summary>
    ''' <param name="g">グラフィック</param>
    ''' <param name="center">中心ポイント</param>
    ''' <param name="radius">半径</param>
    Public Sub FillACircle(pen As Brush, ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)

        ' Select a pen object and make it red

        ' Create a bounding rectangle and make its center the center of our point

        ' Then make its width 2 * the radius

        ' Then draw our ellipse

        Dim rect As New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2)

        g.FillEllipse(pen, rect)

    End Sub

    Private Sub PlcIf_ExcavModeChange(Mode As Boolean) Handles PlcIf.ExcavModeChange
        WriteEventData(IIf(Mode, "掘進", "セグメント") & "モードになりました。", Color.DarkMagenta)
    End Sub
End Module