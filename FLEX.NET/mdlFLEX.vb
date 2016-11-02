Option Explicit On

Module mdlFLEX

    Public InitParameter As clsInitParameter '初期値パラメータ

    Public HorPlan As clsHorPanData '平面掘進計画線
    Public VerPlan As clsVerPlanData '縦断掘進計画線
    ''' <summary>
    ''' シールドマシン諸元
    ''' </summary>
    Public MachineSpec As clsMachinSpec

    Public SegmentAssemblyData As clsSegmentAssembly ''セグメント組立データ

    Public WithEvents ControlParameter As clsControlParameter  '制御パラメータ

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
            Dim response = MsgBox("PLC通信エラー:" & ErrMsg, MsgBoxStyle.AbortRetryIgnore)
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
        SegmentAssemblyData.SegmentAssemblyDataRead(PlcIf.RingNo)

        'If PreStatus = -1 Then Exit Sub
        '待機中から掘進
        If PreStatus = cTaiki And NowStatus = cKussin Then
            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
            PlcIf.LosZeroSts_FLEX = 0
            WriteEventData(PlcIf.RingNo & "リング 掘進開始しました", Color.CornflowerBlue)
            My.Forms.frmMain.ChartClear() 'チャート初期化
            My.Forms.frmMain.DspExcavStartDay(Now)
            ElapsedTime.Reset() '掘進時間計算開始
        End If
        If PreStatus = cChudan And NowStatus = cKussin Then
            WriteEventData("掘進再開しました", Color.Magenta)
            ElapsedTime.ExcavationStart()
            If LosZeroSts >= 1 Then ElapsedTime.LosZeroStart()

            'Mp3Play(My.Resources.ReduceStart)


        End If
        '中断
        If NowStatus = cChudan Then
            WriteEventData("掘進中断しました", Color.Black)
            ElapsedTime.ExcavationStop()
        End If
        '待機中
        If NowStatus = cTaiki Then

            LosZeroSts = 0
            If PreStatus <> -1 Then
                WriteEventData("待機中になりました。", Color.Blue)
            End If
            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
            PlcIf.LosZeroSts_FLEX = 0
            PlcIf.LosZeroDataWrite("減圧ジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("引戻しジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("押込みジャッキ", Nothing)
            PlcIf.LosZeroDataWrite("押込みジャッキ②", Nothing)
            PlcIf.LosZeroEnable = False   '同時施工可OFF
            ElapsedTime.WaingStart()
        End If
        '掘進中で手動方向制御
        If NowStatus = cKussin And ControlParameter.AutoDirectionControl = False Then
            '保持してる作用点
            JackManual.PutPointXY(ControlParameter.PointX, ControlParameter.PointY)
        End If

        '掘進してないときは、自動方向制御停止
        If NowStatus <> cKussin Then JackMvAuto.MvAutoStop()

        If NowStatus = cKussin And ControlParameter.AutoDirectionControl Then
            'JackMvAuto.MvAutoStart()
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

            With SegmentAssemblyData.SegmentProcessData(PlcIf.AssemblyPieceNo)
                Select Case NowSts
                    Case 1 'マシンからの減圧開始
                        PlcIf.LosZeroSts_FLEX = 1 '1ピース目の減圧開始
                        LosZeroSts = 1
                        ElapsedTime.LosZeroStart()  '同時施工時間算出

                    Case 2
                        '引き戻しジャッキ
                        Dim PullJk As String =
                            String.Join(",", .PullBackJack)

                        WriteEventData("No." & PullJk & " のジャッキの引戻し開始しました。", Color.Blue)
                        LosZeroSts = 3

                        PlaySound(My.Resources.PullStart)
                    Case 3
                        WriteEventData("ジャッキの引戻し完了しました。", Color.Magenta)
                        LosZeroSts = 4

                        PlaySound(My.Resources.PullFInish)
                    Case 4, 6
                        '押込みジャッキ
                        Dim ClosetJk As String =
                            String.Join(",", .ClosetJack)
                        WriteEventData("No." & ClosetJk & " のジャッキ押込み開始しました。", Color.Blue)
                        LosZeroSts = 5

                        PlaySound(My.Resources.ClosetStart)

                    Case 5

                        WriteEventData("[" & .PieceName & "] セグメント組立完了しました。", Color.Magenta)
                        PlcIf.LosZeroSts_FLEX = 3   '組立完了確認
                        LosZeroSts = 6

                        PlaySound(My.Resources.SegmentAsem)

                        'TODO:推進圧力がある程度たってから
                        If PlcIf.AssemblyPieceNo < SegmentAssemblyData.AssemblyPieceNumber Then '最終ピース到達前
                            If ControlParameter.NextPieceConfirm Then
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
                    If PlcIf.LosZeroSts_M <> 1 And PlcIf.AssemblyPieceNo < SegmentAssemblyData.AssemblyPieceNumber Then
                        PlcIf.AssemblyPieceNo += 1  '組立ピース　更新
                    End If
                    My.Forms.frmNextPieceConfirm.Close() '継続確認画面を閉じる
                    With SegmentAssemblyData.SegmentProcessData(PlcIf.AssemblyPieceNo)
                        '減圧グループ
                        WriteEventData(PlcIf.AssemblyPieceNo & "ピース目 " & String.Join(",", .ReduceGroup) & "グループの減圧開始します。", Color.Blue)

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

                    PlaySound(My.Resources.ReduceStart)


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
    Private Sub LineDistanceChage() Handles PlcIf.LineDistanceChage, ControlParameter.ReferChnge

        '        RefernceDirection.Distance.測量ポイントリング番号
        Call RefernceDirection.sbCulKijun()

        My.Forms.frmMain.LineDataUpdate()

        If ControlParameter.AutoDirectionControl Then
            JackMvAuto.水平偏差角 = RefernceDirection.平面偏角
            JackMvAuto.鉛直偏差角 = RefernceDirection.縦断偏角
        End If



    End Sub
    ''' <summary>
    ''' 操作点手動操作時の処理
    ''' </summary>
    Private Sub JackManual_PointChanges() Handles JackManual.PointChanges,
        PlcIf.ExcavationStatusChange, JackMvAuto.AutoDirectionCulc, Reduce.ReduceOn, PlcIf.LosZeroStsChange

        With DivCul
            'パラメータセット
            .最低全開グループ数 = ControlParameter.最低全開グループ数
            .全開作動指令値 = ControlParameter.全開作動指令値
            .全開作動範囲 = ControlParameter.全開作動範囲
            .全開グループ制限 = ControlParameter.全開グループ制限

            If ControlParameter.AutoDirectionControl Then
                .操作角 = JackMvAuto.操作角
                .操作強 = JackMvAuto.操作強
                ControlParameter.PointX = JackMvAuto.PointX
                ControlParameter.PointY = JackMvAuto.PointY
                ControlParameter.操作角 = JackMvAuto.操作角
                ControlParameter.操作強 = JackMvAuto.操作強
            Else
                .操作角 = JackManual.操作角
                .操作強 = JackManual.操作強
                ControlParameter.操作角 = JackManual.操作角
                ControlParameter.操作強 = JackManual.操作強
            End If

            .sbCul() ''推力分担率の演算


        End With

        GroupSvOut() 'シーケンサへ圧力分担値の送出

    End Sub



    ''' <summary>
    ''' シーケンサへ圧力分担値の送出
    ''' </summary>
    Private Sub GroupSvOut()

        With DivCul

            Dim sngGpSV(InitParameter.NumberGroup - 1) As Single
            Dim intGpFl(InitParameter.NumberGroup - 1) As Short



            Select Case PlcIf.ExcaStatus

                Case cKussin
                    ''掘進中の処理
                    '減圧中から組立完了
                    If PlcIf.LosZeroSts_FLEX >= 1 And PlcIf.LosZeroSts_FLEX < 3 Then
                        Dim Gp As List(Of Short) =
                        SegmentAssemblyData.SegmentProcessData(PlcIf.AssemblyPieceNo).ReduceGroup
                        For Each R As Short In Gp
                            sngGpSV(R - 1) =
                        Reduce.MvOut(R - 1) * ControlParameter.最大全開出力時の目標圧力 / 100
                            intGpFl(R - 1) = cTracking
                        Next
                    End If

                    For i = 0 To InitParameter.NumberGroup - 1
                        If intGpFl(i) <> cTracking Then
                            If .分担率指令値(i) > 99 Then ''全開出力
                                sngGpSV(i) = ControlParameter.最大全開出力時の目標圧力
                                intGpFl(i) = cFillPower
                            Else
                                sngGpSV(i) = .分担率指令値(i) / 100 * PlcIf.FilterJkPress
                                If Math.Abs(PlcIf.GroupPv(i) - PlcIf.GroupSV(i)) < ControlParameter.PIDShiftDefl _
                                    Or ControlParameter.DirectControl = False Then
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
                    For intCnt = 0 To InitParameter.NumberGroup - 1
                        intGpFl(intCnt) = cIgnoreOut
                    Next intCnt

            End Select
            ''シーケンサ出力
            PlcIf.PutSvPress(sngGpSV, intGpFl)
        End With




    End Sub
    ''' <summary>
    ''' PLC読込イベント
    ''' </summary>
    Private Sub PlcIf_PLCRead() Handles PlcIf.PLCRead
        'モーメント推力の演算
        CulcMoment.MomentCul()



    End Sub




    ''' <summary>
    ''' イベントデータをデータベースに書込
    ''' </summary>
    ''' <param name="EventMsg">イベントメッセージ</param>
    ''' <param name="EventColor">表示用のイベントカラー</param>
    Public Sub WriteEventData(EventMsg As String, EventColor As Color)
        Dim Colorlng As Long = ColorTranslator.ToOle(EventColor)

        Dim db As New clsDataBase

        Dim tb As Odbc.OdbcDataReader = db.ExecuteSql _
            ("INSERT INTO FLEXイベントデータ(Time,イベントデータ,イベント種類) VALUES('" _
             & Now & "','" & EventMsg & "','" & Colorlng & "')")

        My.Forms.frmMain.EventlogUpdate()

    End Sub
    ''' <summary>
    ''' 姿勢制御自動手動の切替時の処理
    ''' </summary>
    ''' 
    Private Sub ControlParameter_FlexAutoManualChange() Handles ControlParameter.FlexAutoManualChange ', PlcIf.ExcavationStatusChange
        '掘進中以外はスキップ
        'If PlcIf.ExcaStatus <> cKussin Then Exit Sub

        If ControlParameter.AutoDirectionControl Then
            If PlcIf.ExcaStatus = cKussin Then
                WriteEventData("自動方向制御開始しました。", Color.Orange)
            End If
            'tmrAutoDirect.Enabled = False
            'TODO:自動手動切替時しかPID定数が反映されてない！
            ''手動→自動切替時
            With JackMvAuto

                .水平P定数 = ControlParameter.水平ジャッキ制御P定数
                .水平I定数 = ControlParameter.水平ジャッキ制御I定数
                .水平D定数 = ControlParameter.水平ジャッキ制御D定数
                .鉛直P定数 = ControlParameter.鉛直ジャッキ制御P定数
                .鉛直I定数 = ControlParameter.鉛直ジャッキ制御I定数
                .鉛直D定数 = ControlParameter.鉛直ジャッキ制御D定数
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
            If PlcIf.ExcaStatus = cKussin Then
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

End Module