Class frmMain
    Inherits Windows.Forms.Form
    ''' <summary>
    ''' 姿勢トレンドデータ
    ''' </summary>
    Public Shared DirectionChartD As New DirectionChartData

    Private DspGp() As ucnDspGpPres 'グループ圧PV数値表示用
    Private BlinkFlg As Boolean '点滅フラグ
    ''' <summary>
    ''' イベントログのID
    ''' </summary>
    Private EventID As Long
    ''' <summary>
    ''' バックアップした日付
    ''' </summary>
    Private BackUpDate As Date

    'Private WideUse As New List(Of ucnDspData) '汎用データ表示用
    'Private WideUseDsp() As ucnDspData
    ''' <summary>
    ''' 画面のちらつきをなくす
    ''' </summary>
    ''' <returns></returns>
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            '拡張ウィンドウスタイルにWS_EX_COMPOSITEDを追加する
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        'TODO:My.Forms.frmMainを使うとNewが呼び出される？ので、以下をloadに移動　なぜか？
        'InitParameter = New clsInitParameter '初期値パラメータ
        'ControlParameter = New clsControlParameter  '制御パラメータ

        'HorPlan = New clsHorPanData '平面掘進計画線
        'VerPlan = New clsVerPlanData '縦断掘進計画線

        'MachineSpec = New clsMachinSpec

        'SegmentAssembly = New clsSegmentAssembly ''セグメント組立データ


        'CulcMoment = New clsCulMoment ''モーメント、推力の演算

        'JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        'DivCul = New clsThrustDiv ''
        'RefernceDirection = New clsCulKijun
        'JackManual = New clsJkManualOut

        ''PLCインターフェース
        'PlcIf = New clsPlcIf

        'Reduce = New clsReducePress


    End Sub

    Private Sub tmrDataDsp_Tick(sender As Object, e As EventArgs) Handles tmrDataDsp.Tick



        'PLCからの読込表示
        'With PlcIf

        DspMachinComErr.Visible = PlcIf.MachineComErr 'マシン伝送異常
        DspMachinComErr.BitStatus = BlinkFlg

        DspGyiroError.Visible = PlcIf.GyiroError
        DspGyiroError.BitStatus = BlinkFlg
        DspDirection.Blink = PlcIf.GyiroError



        DspRingNo.Text = PlcIf.RingNo 'リングNo

        DspDirection.Value = PlcIf.Gyro              '方位角
        If InitPara.bottomStrokeEnable Then
            DspBottomRealStroke.Value = CalcStroke.BottomCalcStroke '下ｽﾄﾛｰｸ
            DspBottomRawStroke.Value = PlcIf.BotomStroke '下ｽﾄﾛｰｸ
            DspBottomSpeed.Value = PlcIf.BotomSpeed      '下ｽﾋﾟｰﾄﾞ
        End If

        If InitPara.topStrokeEnable Then
            DspUpRealStroke.Value = CalcStroke.TopCalcStroke      '上ｽﾄﾛｰｸ
            DspUpRawStroke.Value = PlcIf.TopStroke      '上ｽﾄﾛｰｸ
            DspUpSpeed.Value = PlcIf.TopSpeed            '上ｽﾋﾟｰﾄﾞ
        End If


        DspRightRealStroke.Value = CalcStroke.RightCalcStroke '右ｽﾄﾛｰｸ
        DspRightRawStroke.Value = PlcIf.RightStroke '右ｽﾄﾛｰｸ
        DspRightSpeed.Value = PlcIf.RightSpeed       '右ｽﾋﾟｰﾄﾞ

        DspLeftRealStroke.Value = CalcStroke.LeftCalcStroke   '左ｽﾄﾛｰｸ
        DspLeftRawStroke.Value = PlcIf.LeftStroke   '左ｽﾄﾛｰｸ
        DspLeftSpeed.Value = PlcIf.LeftSpeed         '左ｽﾋﾟｰﾄﾞ

        DspJackPress.Value = PlcIf.JkPress           'ジャッキ圧力
        DspPitching.Value = PlcIf.Pitching           'ピッチング
        DspHorBroken.Value = PlcIf.NakaoreLR         '中折左右
        DspVerBroken.Value = PlcIf.NakaoreTB         '中折上下

        Select Case CtlPara.CopySelect
            Case 1
                DspCopyStroke.Value = PlcIf.CopyStroke1 'コピーストローク
            Case 2
                DspCopyStroke.Value = PlcIf.CopyStroke2 'コピーストローク

        End Select

        DspMachineRolling.Value = PlcIf.MashineRolling  'マシンローリング

        DspBottomClearance.Value = PlcIf.botomClearance
        DspTopClearance.Value = PlcIf.topClearance
        DspRightClearance.Value = PlcIf.rightClearance
        DspLeftClearance.Value = PlcIf.leftClearance

        DspThrust.Value = CulcMoment.Thrust '推力
        DspMoment.Value = CulcMoment.MomentR 'モーメント
        'FLEXの制御ON/OFF
        DspFlexControlOn.BitStatus = PlcIf.FlexControlOn
        '常時表示に変更
        'UcnJackDsp.FlexOn = PlcIf.FlexControlOn

        '掘進ステータス　掘進中、中断中、待機中
        DspExcavingOn.BitStatus = (PlcIf.ExcaStatus = cKussin)
        DspExcavingStop.BitStatus = (PlcIf.ExcaStatus = cChudan)
        DspExcaWaiting.BitStatus = (PlcIf.ExcaStatus = cTaiki)
        'ジャッキステータス表示
        UcnJackDsp.JackStatus = PlcIf.JackStatus
        'グループ圧PV
        UcnJackDsp.GroupPV = PlcIf.GroupPv
        UcnJackDsp.JackOrgPress = PlcIf.JkPress
        'コピー角度、ストローク
        UcnJackDsp.CopyAngle = PlcIf.CopyAngle
        UcnJackDsp.CopyStroke = PlcIf.CopyStroke1
        UcnJackDsp.CopyCutEnableStroke = CtlPara.CopyCutEnableStroke
        'グループ圧バーグラフ
        UcnGpPvBarGraph.GpFlg = PlcIf.GroupFlg
        UcnGpPvBarGraph.GpPv = PlcIf.GroupPv

        '力点座標数値表示
        UcnJackDsp.FlexPointX = PlcIf.PointX
        UcnJackDsp.FlexPointY = PlcIf.PointY

        UcnJackDsp.FlexPointR = PlcIf.操作強
        UcnJackDsp.FlexPointSeater = PlcIf.操作角


        '掘進モード／セグメントモードの表示
        lblMachineMode.Text = If(PlcIf.ExcavMode, "掘進", "セグメント") & "モード"
        lblMachineMode.BackColor = If(PlcIf.ExcavMode, Color.Magenta, Color.Aqua)
        'End With
        If PlcIf.assembleSegFinish Then
            lblMachineMode.BackColor = Color.Yellow
        End If


        UcnJackDsp.MakeBmp()


        DspAveStartStroke.Value = CtlPara.StartAveStroke '平均開始ストローク
        DspAveStroke.Value = CalcStroke.CalcAveLogicalStroke '計算平均ストローク
        DspExcvSpeed.Value = CalcStroke.MesureAveSpeed '計測ジャッキ平均スピード

        DspLRStrokeDiff.Value = CalcStroke.LeftCalcStroke - CalcStroke.RightCalcStroke '左右ｽﾄﾛｰｸ差
        If CtlPara.RightStrokeDiff Then
            DspLRStrokeDiff.Value = -DspLRStrokeDiff.Value
        End If
        DspLRStrokeDiff.FieldName = $"ｽﾄﾛｰｸ差(mm){If(CtlPara.RightStrokeDiff, "右", "左")}勝"

        '汎用データ表示
        For Each wu In CtlPara.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If dd.FieldName <> "" Then
                dd.Value = PlcIf.EngValue(dd.FieldName)
            Else
                dd.Value = "-------"
            End If
        Next

        With CtlPara
            '自動方向制御ON／OFF
            UcnJackDsp.FlexAutoManual = .AutoDirectionControl
            DspFlexAuto.BitStatus = .AutoDirectionControl
        End With

        '圧力調整用フラグ
        DspJackPress.Blink = JackMvAuto.圧力超
        DspMoment.Blink = JackMvAuto.モーメント上限超
        UcnJackDsp.PointRLimitOver = JackMvAuto.片押しR上限超

        DspHorDev.Blink = RefernceDirection.HorDevLimitOver
        DspVerDev.Blink = RefernceDirection.VerDevLimitOver




        'チャートの更新
        If PlcIf.ExcaStatus = cKussin Then
            'ﾓｰﾒﾝﾄ
            ucnHorMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentX)
            ucnVerMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentY)
            ucnHorDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.平面偏角)
            ucnVerDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.縦断偏角)
        End If

        '同時施工用
        ucnLosZeroMode.BitStatus = PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        ucnLosZeroMode.Blink = Not PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        '対抗ジャッキ
        UcnOpposeJackControl.BitStatus = CtlPara.LosZeroOpposeControl
        UcnOpposeJackSelect.BitStatus = CtlPara.LosZeroOpposeJack

        '同時施工ピース確認ボタンブリンク
        btnPieceConfirm.Enabled = ucnLosZeroMode.Blink
        If btnPieceConfirm.Enabled Then
            btnPieceConfirm.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
        End If
        '同時施工キャンセルボタン有効／無効
        btnLossZerooCancel.Enabled = ucnLosZeroMode.BitStatus

        '組立ピース番号
        If ucnLosZeroMode.BitStatus Then
            ucnAssemblyPieceNo.FieldName = PlcIf.AssemblyPieceNo & "ピース目"
        Else
            ucnAssemblyPieceNo.FieldName = "-------"
        End If

        '減圧中
        ucnReduceFinish.Blink = (LosZeroSts = 1)
        '減圧完了
        ucnReduceFinish.BitStatus = (LosZeroSts >= 2)
        '引戻し中
        ucnPullBackFinish.Blink = (LosZeroSts = 3)
        '引戻完了
        ucnPullBackFinish.BitStatus = (LosZeroSts >= 4)
        '組立中
        ucnAssemblyFinish.Blink = (LosZeroSts = 5)
        '組立完了
        ucnAssemblyFinish.BitStatus = (LosZeroSts >= 6)

        If ucnReduceFinish.Blink Then
            ucnReduceFinish.FieldName = "減圧中"
        Else
            ucnReduceFinish.FieldName = "減圧完了"
        End If

        '減圧中から組立中は次ピース確認ボタン無効
        If LosZeroSts >= 1 And LosZeroSts <= 5 Then
            btnLoszeroContinu.Enabled = False
        End If
        If btnLoszeroContinu.Enabled Then
            btnLoszeroContinu.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
        End If



        If ucnPullBackFinish.Blink Then
            ucnPullBackFinish.FieldName = "引戻し中"
        Else
            ucnPullBackFinish.FieldName = "引戻完了"
        End If


        If ucnAssemblyFinish.Blink Then
            ucnAssemblyFinish.FieldName = "組立中"
        Else
            ucnAssemblyFinish.FieldName = "組立完了"
        End If

        '点滅用フラグ
        BlinkFlg = Not BlinkFlg
        'ロスゼロ工程表示
        For Each cControl As Control In pnlLosZero.Controls
            If TypeOf cControl Is ucnDspBit Then
                Dim u As ucnDspBit = DirectCast(cControl, ucnDspBit)
                If u.Blink Then
                    u.BitStatus = BlinkFlg
                End If
            End If
        Next

        DspSegmentW.Value = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
        DspTargetNetStroke.Value = If(CtlPara.TargetNetStroke = 0, DspSegmentW.Value, CtlPara.TargetNetStroke)


        '経過時間の表示
        DspExcationElapsedTime.Value = ElapsedTime.ExcavationTime
        DspLosZeroElapsedTime.Value = ElapsedTime.LozeroExcavationTime
        DspWatingElapsedTime.Value = ElapsedTime.WatingTime
        DspInterruptTime.Value = ElapsedTime.InterruptTime
        'DspIterruptTime.Value == ElapsedTime.InterruptTime
        'DspCycleTime.Value = ElapsedTime.CycleTime
        'モニターモードの時はデータベースより
        If InitPara.MonitorMode Then
            lblNowDate.Text = PlcIf.DataGetTime.ToString("yyyy/MM/dd HH:mm:ss")
        Else
            lblNowDate.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
        End If

        '同時施工実績表示
        If InitPara.LosZeroEquip Then
            DspAveAsmPiece.Value = LosZeroPerform.AveAsmPiece
            DspSumAsmPiece.Value = LosZeroPerform.SumAsmPiece
            DspAveLoszeroTime.Value = LosZeroPerform.AveLoszeroTime
            DspSumLoszeroTime.Value = LosZeroPerform.SumLoszeroTime
        End If

        '定期バックアップの実行
        If InitPara.ServerMode AndAlso Date.Compare(Now.Date, BackUpDate.Date) <> 0 AndAlso
            TimeSpan.Parse(Now.ToLongTimeString).TotalMinutes = InitPara.BackUpTime.TotalMinutes Then
            BackUpDate = Now
            Dim DailyBackup = New clsDBBackUp
            DailyBackup.DailyBackup()
        End If

        'TODO:線形データ画面更新　LineDistanceChage に記述したい
        'Call LineDataUpdate()

        EventlogUpdate()
    End Sub
    ''' <summary>
    ''' 偏角、モーメントのチャート初期化
    ''' 待機中から掘進中の時に実行
    ''' </summary>
    Public Sub ChartClear()
        ucnHorMomentChart.ChartList.Clear()
        ucnVerMomentChart.ChartList.Clear()
        ucnHorDevChart.ChartList.Clear()
        ucnVerDevChart.ChartList.Clear()
    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MYSQLのバージョン取得
        clsDataBase.GetMySQKVersion()


        'インスタンス作成
        InitPara = New clsInitParameter '初期値パラメータ
        CtlPara = New clsControlParameter  '制御パラメータ
        HorPlan = New clsHorPanData '平面掘進計画線
        Dim Kant As New clsLineMake
        Kant.CulcZoneKant()

        VerPlan = New clsVerPlanData '縦断掘進計画線
        MachineSpec = New clsMachinSpec
        SegAsmblyData = New clsSegmentAssembly ''セグメント組立データ
        DataSave = New clsDataSave 'データ保存
        CulcMoment = New clsCulMoment ''モーメント、推力の演算
        JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        DivCul = New clsThrustDiv ''推力分担
        RefernceDirection = New clsCulKijun '基準方位演算
        PlcIf = New clsPlcIf 'PLCインターフェース
        CalcStroke = New clsCalcuStroke   'ロスゼロ時の計算ストローク
        JackManual = New clsJkManualOut 'ジャッキ手動操作出力
        Reduce = New clsReducePress 'ロスゼロ減圧処理
        TableUpdateConfirm = New clsTableUpdateConfirm    'テーブル更新によるパラメータ再取得

        CalcStroke.MesureJackStroke = PlcIf.MesureJackStroke
        'CalcStroke.MesureCalcAveJackStroke = PlcIf.MesureCalcAveJackStroke '平均ジャッキストロークのセット

        'TODO:画面ナロータイプを作成したい
        'If InitPara.DisplayNarrowMode Then
        '    Me.WindowState = FormWindowState.Normal
        '    Me.Size = New Size(1280, 1078)
        'End If
        JackMvAuto.PointX = PlcIf.PointX
        JackMvAuto.PointY = PlcIf.PointY
        JackMvAuto.水平P定数 = CtlPara.水平ジャッキ制御P定数
        JackMvAuto.水平I定数 = CtlPara.水平ジャッキ制御I定数
        JackMvAuto.水平D定数 = CtlPara.水平ジャッキ制御D定数
        JackMvAuto.鉛直P定数 = CtlPara.鉛直ジャッキ制御P定数
        JackMvAuto.鉛直I定数 = CtlPara.鉛直ジャッキ制御I定数
        JackMvAuto.鉛直D定数 = CtlPara.鉛直ジャッキ制御D定数



    End Sub
    ''' <summary>
    ''' 汎用データ表示項目セット
    ''' </summary>
    Public Sub WideDataFldSet()
        For Each wu In CtlPara.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If wu.Value <> "" Then
                If PlcIf.AnalogTag.TagExist(wu.Value) Then
                    dd.FieldName = wu.Value
                    dd.Unit = PlcIf.AnalogTag.TagData(wu.Value).Unit
                    dd.DecimalPlaces = PlcIf.AnalogTag.TagData(wu.Value).DigitLoc
                End If
            End If
        Next

    End Sub

    Private Function getExcecStartTime() As Date
        Dim db As New clsDataBase
        Dim tb As DataTable =
             db.GetDtfmSQL($"SELECT 時間 FROM flex掘削データ 
            WHERE リング番号='{PlcIf.RingNo}' ORDER BY 時間  LIMIT 0,1")
        If tb.Rows.Count = 0 Then
            Return Now
        Else
            Return tb.Rows(0).Item(0)
        End If

    End Function


    ''' <summary>
    ''' 線形データ画面更新
    ''' </summary>
    Public Sub LineDataUpdate()
        With RefernceDirection
            '中心の総距離
            DspDistance.Value = .HorZendoKijun.掘進累積距離 - .toStartDistance
            '平面線形データ
            If .HorZendoKijun.平面線形 = 1 Then
                DspHorLine.Value = "-------"
            Else
                DspHorLine.Value = .HorZendoKijun.軌道中心平面半径
            End If

            DspHorFChangePoint.Value = .HorZendoKijun.平面ゾーン内残距離
            DspHorRChangePoint.Value = .HorZendoKijun.平面ゾーン掘進距離
            DspTargetDirection.Value = .平面基準方位
            DspHorDev.Value = .平面偏角

            ucnHorLineChart.PlanNumData = .平面計画方位



            '縦断線形データ
            If .VerZendoKijun.縦断線形 = 1 Then
                DspVerLine.Value = "-------"
            Else
                DspVerLine.Value = .VerZendoKijun.縦断半径

            End If
            DspVerFChangePoint.Value = .VerZendoKijun.縦断ゾーン内残距離
            DspVerRChangePoint.Value = .VerZendoKijun.縦断ゾーン内掘進距離
            DspTargetPitching.Value = .縦断基準方位
            DspVerDev.Value = .縦断偏角

            ucnVerLineChart.PlanNumData = .縦断計画方位

            UcnDspDevImg.HorDev = .平面偏角
            UcnDspDevImg.VerDev = .縦断偏角




        End With


        '姿勢角トレンドトレンド　データセット
        ucnHorLineChart.PlanData = DirectionChartD.HorPData
        ucnHorLineChart.ExecData = DirectionChartD.HorRData
        ucnHorLineChart.CorrectData = CtlPara.水平入力補正値
        ucnHorLineChart.TargetData = DspTargetDirection.Value
        ucnHorLineChart.RealData = DspDirection.Value


        ucnVerLineChart.PlanData = DirectionChartD.VerPData
        ucnVerLineChart.ExecData = DirectionChartD.VerRData
        ucnVerLineChart.CorrectData = CtlPara.鉛直入力補正値
        ucnVerLineChart.TargetData = DspTargetPitching.Value
        ucnVerLineChart.RealData = DspPitching.Value

        'DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.軌道中心方位角) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
        DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.平面計画方位) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
    End Sub
    ''' <summary>
    ''' 同時施工組立パターン情報表示
    ''' </summary>
    Public Sub SegmentDataDsp()
        '組立パターン

        If Not InitPara.LosZeroEquip Then Exit Sub

        'Dim p As Short = 0
        If PlcIf.AssemblyPieceNo <= 0 Then PlcIf.AssemblyPieceNo = 1

        DspTypeName.Value = SegAsmblyData.TypeData(PlcIf.RingNo).TypeName 'セグメント種類
        DspAssemblyPattern.Value = SegAsmblyData.AssemblyPtnName(PlcIf.RingNo) '組立パターン名

        If PlcIf.AnalogTag.TagExist("ｾｸﾞﾒﾝﾄの種類信号") Then
            PlcIf.AnalogPlcWrite("ｾｸﾞﾒﾝﾄの種類信号", SegAsmblyData.TypeData(PlcIf.RingNo).TypeNameID) 'セグメント種類
        End If

        If SegAsmblyData.ProcessData.Count <> 0 Then

            With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                'TODO:組立セグメント、組立ﾎﾞﾙﾄﾋﾟｯﾁの取込
                DspBoltPitch.Value = .BoltPitch '組立ボルトピッチ
                DspAssemblyPieace.Value = .PieceName  '組立ピース名称
                DspPullBackJack.Value = SegAsmblyData.JackListDsp(.PullBackJack) '引戻しジャッキ
                DspClosetJack.Value = SegAsmblyData.JackListDsp(.ClosetJack) '押込みジャッキ
                DspClosetThrustJack.Value = SegAsmblyData.JackListDsp(.ClosetThrustJack) '押込み推進ジャッキ
                DspAddClosetThrustJack.Value = SegAsmblyData.JackListDsp(.AddClosetJack) '追加押込みジャッキ

                If PlcIf.AnalogTag.TagExist("甲乙表示用信号") Then
                    PlcIf.AnalogPlcWrite("甲乙表示用信号", .PatternKouOtuID)
                End If

            End With


        Else
            DspBoltPitch.Value = "-" '組立ボルトピッチ
            DspAssemblyPieace.Value = "-----"  '組立ピース名称
            DspPullBackJack.Value = "-" '引戻しジャッキ
            DspClosetJack.Value = "-" '押込みジャッキ
            DspAddClosetThrustJack.Value = "-" '追加押込みジャッキ


        End If
        'MAXのピース番号内で表示
        If SegAsmblyData.AssemblyPieceNumber > PlcIf.AssemblyPieceNo AndAlso SegAsmblyData.ProcessData.Count <> 0 Then
            DspNextPieceName.Value =
            SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo + 1).PieceName '組立次ピース名称
        Else
            DspNextPieceName.Value = "-------"
        End If
        '全ピース　名称表示
        UcnJackDsp.PieceAngle.Clear()
        UcnJackDsp.PieceCenterAngle.Clear()
        UcnJackDsp.PieceName.Clear()
        UcnJackDsp.AssemblyOrder.Clear()

        For Each pca As clsSegmentAssembly.AsseblyProcess
                                        In SegAsmblyData.ProcessData.Values
            UcnJackDsp.PieceName.Add(pca.PieceName)
            UcnJackDsp.PieceAngle.Add(pca.PieceAngle)
            UcnJackDsp.PieceCenterAngle.Add(pca.PieceCenterAngle)
            UcnJackDsp.AssemblyOrder.Add(pca.AssemblyOrder)

            '同時施工モード時のみ　同時施工に関係なしに
            'If PlcIf.LosZeroMode Then
            'TODO:ローリングの考慮なし　マシンメーカーへ出力
            '天を０度で時計回りに
            If PlcIf.AnalogTag.TagExist(pca.AssemblyOrder & "ピースセグメント位置角度") Then
                Dim angle As Single
                angle = 90 - pca.PieceCenterAngle
                If angle < 0 Then angle += 360

                PlcIf.AnalogPlcWrite(pca.AssemblyOrder & "ピースセグメント位置角度", angle)
            End If

            'End If


        Next
        UcnJackDsp.AssemblyPieceNo = PlcIf.AssemblyPieceNo

        UcnJackDsp.SegmentPieceDsp() 'ｾｸﾞﾒﾝﾄピース表示



    End Sub



    ''' <summary>
    ''' リング番号変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoChange_Click(sender As Object, e As EventArgs) Handles RingNoChange.Click, DspRingNo.Click
        frmRingNoChange.Show()
    End Sub


    ''' <summary>
    ''' リング更新設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoUpdate_Click(sender As Object, e As EventArgs) Handles RingNoUpdateSetting.Click,
        DspAveStartStroke.DoubleClick, DspAveStroke.DoubleClick, DspExcvSpeed.DoubleClick
        frmRinguUpdateSetting.Show()
    End Sub

    Private Sub OperationRight_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitialSetting_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportOut_Click(sender As Object, e As EventArgs) Handles ReportOut.Click
        '帳票出力
        frmReportOut.Show()

    End Sub

    Private Sub ExcavEnforceStart_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStart.Click

    End Sub

    Private Sub ExcavEnforceStop_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStop.Click

    End Sub

    Private Sub SystemEnd_Click(sender As Object, e As EventArgs) Handles SystemEnd.Click
        If MsgBox("FLEXシステムを終了します。", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "FLEX") = MsgBoxResult.Ok Then
            Me.Close()
        End If

    End Sub

    Private Sub DspSetting_Click(sender As Object, e As EventArgs) Handles DspSetting.Click
        My.Forms.frmDspSetting.Show()
    End Sub

    Private Sub ScaleSetting_Click(sender As Object, e As EventArgs) Handles ScaleSetting.Click
        My.Forms.frmScaleSet.Show()
    End Sub

    Private Sub PressParameter_Click(sender As Object, e As EventArgs) Handles PressParameter.Click
        My.Forms.frmPressParameterSet.Show()
    End Sub
    ''' <summary>
    ''' 片押しパラメータ　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OneDirectionParameter_Click(sender As Object, e As EventArgs) Handles OneDirectionParameter.Click
        My.Forms.frmOneWayTunnel.Show()
    End Sub
    ''' <summary>
    ''' 片押し制限パラメータ　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OneDirectionLimit_Click(sender As Object, e As EventArgs) Handles OneDirectionLimit.Click
        My.Forms.frmOneWayTunnelLimit.Show()
    End Sub
    ''' <summary>
    ''' 圧力ブロック　サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PresBlock_Click(sender As Object, e As EventArgs) Handles PresBlock.Click
        My.Forms.frmPressBlock.Show()
    End Sub

    Private Sub ManagmentMethd_Click(sender As Object, e As EventArgs) Handles ManagmentMethd.Click

    End Sub

    Private Sub LossZeroConcern_Click(sender As Object, e As EventArgs) Handles LossZeroConcern.Click
        My.Forms.frmLosZeroSetting.Show()

    End Sub
    ''' <summary>
    ''' その他の設定サブウィンドウ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OterSetting_Click(sender As Object, e As EventArgs) Handles OterSetting.Click
        My.Forms.frmOtherSetting.Show()
    End Sub

    Private Sub ReloadPlanData_Click(sender As Object, e As EventArgs) Handles PlanDataView.Click
        My.Forms.frmHorPlanData.Show()
    End Sub

    Private Sub SegmentEdit_Click(sender As Object, e As EventArgs) Handles SegmentEdit.Click, DspSegmentW.DoubleClick
        My.Forms.frmSegmentEdit.Show()

    End Sub
    ''' <summary>
    ''' セグメント組立の編集
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AssemblyProcessEdit_Click(sender As Object, e As EventArgs) Handles AssemblyProcessEdit.Click, DspTypeName.DoubleClick,
        DspAssemblyPattern.DoubleClick, DspAssemblyPieace.DoubleClick, DspPullBackJack.DoubleClick,
        DspClosetJack.DoubleClick, DspClosetThrustJack.DoubleClick, DspAddClosetThrustJack.DoubleClick, DspNextPieceName.DoubleClick
        If InitPara.LosZeroEquip Then
            My.Forms.frmAssemblyProcessEdit.Show()
        End If

    End Sub
    ''' <summary>
    ''' 補正値管理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CorrectionValMng_Click(sender As Object, e As EventArgs) Handles CorrectionValMng.Click, DspTargetDirection.DoubleClick,
        DspTargetPitching.DoubleClick, DspHorFChangePoint.DoubleClick, DspDistance.DoubleClick, DspHorLine.DoubleClick, DspHorFChangePoint.DoubleClick,
        DspHorRChangePoint.DoubleClick, DspVerLine.DoubleClick, DspVerFChangePoint.DoubleClick, DspVerRChangePoint.DoubleClick

        frmCorrectionValueManagement.Show()

    End Sub

    Private Sub RingCloseValueMng_Click(sender As Object, e As EventArgs) Handles RingCloseValueMng.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Call UcnJackDsp.DspBaseJack()
    End Sub
    ''' <summary>
    ''' ポイント座標が入力され演算完了したイベント
    ''' </summary>
    Private Sub UcnJackDsp_ManualPointChange() Handles UcnJackDsp.ManualPointChange
        PlcIf.PointX = UcnJackDsp.FlexPointX
        PlcIf.PointY = UcnJackDsp.FlexPointY

        JackManual.PutPointXY(PlcIf.PointX, PlcIf.PointY)

        PlcIf.PointWrite()

    End Sub
    ''' <summary>
    ''' 掘進強制終了、強制開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExcavingStatusEnfoce(sender As Object, e As EventArgs) Handles ExcavEnforceStart.Click, ExcavEnforceStop.Click
        Dim MsgText As String = ""
        Select Case sender.Name
            Case "ExcavEnforceStart"
                MsgText = "掘進強制開始"
            Case "ExcavEnforceStop"
                MsgText = "掘進強制終了"
        End Select

        If MsgBox($"{MsgText}よろしいですか?",
                  MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, MsgText) = MsgBoxResult.Ok Then
            PlcIf.DigtalPlcWrite(MsgText, True) 'PLC書込
            WriteEventData(MsgText & "されました。", Color.BlueViolet)
        End If

    End Sub

    Private Sub TuningMonitorClicｋ_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.Click
        If (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
            My.Forms.frmTuningTrend.Show() 'シフトキーが押されてたときは、チューニングトレンド画面を出す
        ElseIf (Control.ModifierKeys And Keys.Control) = Keys.Control Then
            My.Forms.frmDirControlChek.Show() 'コントロールキーが押されてたときは、姿勢制御確認画面を出す
        Else

            My.Forms.frmTuningMonitor.Show()
            My.Forms.frmTuningMonitor.TopMost = True
        End If
    End Sub

    Private Sub TuningTrend_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.DoubleClick

    End Sub



    ''' <summary>
    ''' FLEX自動方向制御ON/OFF
    ''' </summary>
    Private Sub UcnJackDsp_FlexAutoManualChange() Handles UcnJackDsp.FlexAutoManualChange
        CtlPara.AutoDirectionControl = Not CtlPara.AutoDirectionControl
    End Sub
    ''' <summary>
    ''' イベントログ更新
    ''' </summary>
    Private Sub EventlogUpdate()
        '最新のIDを比較
        Dim DB As New clsDataBase
        Dim tbEvID As DataTable = DB.GetDtfmSQL _
            ($"SELECT ID FROM FLEXイベントデータ 
             ORDER BY ID DESC LIMIT 0,1")
        'IDが更新されてれば表示更新
        If tbEvID.Rows.Count <> 0 Then
            If EventID <> tbEvID.Rows(0).Item(0) Then
                rtbEventLog.Clear()
                Dim tb As DataTable = DB.GetDtfmSQL _
            ($"SELECT TIME,イベントデータ,イベント種類 FROM FLEXイベントデータ 
            WHERE イベント種類 <> '{ColorTranslator.ToOle(Color.White)}' ORDER BY TIME DESC LIMIT 0,50")

                For Each t As DataRow In tb.Rows
                    rtbEventLog.SelectionColor =
                ColorTranslator.FromOle(t.Item(2))
                    rtbEventLog.AppendText(CDate(t.Item(0)).ToString("yyyy/MM/dd HH:mm:ss") & Space(2) & t.Item(1).ToString & vbCrLf)

                Next

            End If
            EventID = tbEvID.Rows(0).Item(0)
        End If

    End Sub
    ''' <summary>
    ''' 掘進開始日時表示
    ''' </summary>
    Public Sub DspExcavStartDay(t As Date)
        DspExcavStartDate.Value = t.ToString("yyyy/MM/dd")
        DspExcavStartTime.Value = t.ToString("HH:mm:ss")
    End Sub


    Private Sub UcnJackDsp_Load(sender As Object, e As EventArgs) Handles UcnJackDsp.Load

    End Sub

    Private Sub btnPieceConfirm_Click(sender As Object, e As EventArgs) Handles btnPieceConfirm.Click

        If SegAsmblyData.ProcessData.Count = 0 Then
            MsgBox($"{PlcIf.RingNo}リングの'{SegAsmblyData.AssemblyPtnName(PlcIf.RingNo)}'の、組立順序が設定されてません'", vbCritical)
        Else
            PlcIf.LosZeroEnable = True '同時施工可　信号出力
            '組立ピース確認
            WriteEventData("同時施工　組立ピース確認しました。", Color.Blue)

        End If


    End Sub

    Private Sub ｂｔｎLossZerooCancel_Click(sender As Object, e As EventArgs) Handles btnLossZerooCancel.Click
        PlcIf.DigtalPlcWrite("同時施工キャンセル", True)
        PlcIf.LosZeroEnable = False '同時施工キャンセル
        PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
    End Sub

    Private Sub StrokeMonitor_Click(sender As Object, e As EventArgs) Handles StrokeMonitor.Click
        My.Forms.frmCalcStrokeConfirm.Show()
    End Sub

    ''' <summary>
    ''' 姿勢トレンドのデータ取得
    ''' </summary>
    Public Class DirectionChartData
        Inherits clsDataBase
        '掘進データ
        Private _HorRData As New List(Of ucnChart2.gData)
        Private _VerRData As New List(Of ucnChart2.gData)
        '計画データ
        Private _HorPData As New Dictionary(Of Integer, Single)
        Private _VerPData As New Dictionary(Of Integer, Single)

        ''' <summary>
        ''' 平面掘進データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HorRData As List(Of ucnChart2.gData)
            Get
                Return _HorRData
            End Get
        End Property
        ''' <summary>
        ''' 縦断掘進データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property VerRData As List(Of ucnChart2.gData)
            Get
                Return _VerRData
            End Get
        End Property
        ''' <summary>
        ''' これから掘進する平面計画データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HorPData As Dictionary(Of Integer, Single)
            Get
                Return _HorPData
            End Get
        End Property
        ''' <summary>
        ''' これから掘進する縦断計画データ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property VerPData As Dictionary(Of Integer, Single)
            Get
                Return _VerPData
            End Get
        End Property

        ''' <summary>
        ''' チャートデータ更新
        ''' </summary>
        Public Sub DataUp()
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT リング番号,平面起点から発旋回中心までの距離,前胴方位角,水平偏角,
                平面姿勢角管理値,縦断起点から発旋回中心までの距離,前胴鉛直角,縦断姿勢角管理値,鉛直偏角 
                FROM flex掘削データ WHERE リング番号 =
               '{PlcIf.RingNo}' ORDER BY 掘進ストローク DESC LIMIT 0,1")

            Dim g As ucnChart2.gData

            If rsData.Rows.Count <> 0 Then
                Dim t As DataRow = rsData.Rows(0)
                g.RingNo = t("リング番号")
                g.Distance = t.Item("平面起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴方位角")
                g.TargetDr = t.Item("平面姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("水平偏角") ' t.Item("ジャイロ方位角")
                _HorRData.Add(g)

                g.Distance = t.Item("縦断起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴鉛直角")
                g.TargetDr = t.Item("縦断姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("鉛直偏角") '  t.Item("ジャイロピッチング")
                _VerRData.Add(g)

            End If

        End Sub




        ''' <summary>
        ''' 平面と縦断のチャートデータを取得
        ''' </summary>
        Public Sub DataGet()
            '過去の掘進データ 10mm毎
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT リング番号,平面起点から発旋回中心までの距離,前胴方位角,水平偏角,
                平面姿勢角管理値, 縦断起点から発旋回中心までの距離, 前胴鉛直角, 縦断姿勢角管理値, 鉛直偏角  FROM flex掘削データ WHERE リング番号 >=
                '{PlcIf.RingNo - CtlPara.LineDevStartRing}'
                AND リング番号<='{PlcIf.RingNo}' AND 掘進ストローク%10 =0;")

            _HorRData.Clear()
            _VerRData.Clear()

            If rsData.Rows.Count = 0 Then Exit Sub

            Dim RingNo As Integer = Nothing
            Dim g As ucnChart2.gData

            For Each t As DataRow In rsData.Rows

                g.RingNo = t("リング番号")
                g.Distance = t.Item("平面起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴方位角")
                g.TargetDr = t.Item("平面姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("水平偏角") ' t.Item("ジャイロ方位角")
                _HorRData.Add(g)

                g.Distance = t.Item("縦断起点から発旋回中心までの距離") * 1000
                g.PlanDr = t.Item("前胴鉛直角")
                g.TargetDr = t.Item("縦断姿勢角管理値")
                g.RealDr = g.TargetDr + t.Item("鉛直偏角") '  t.Item("ジャイロピッチング")
                _VerRData.Add(g)
                RingNo = g.RingNo

            Next

            'これから掘削する計画方位データ
            _HorPData.Clear()
            _VerPData.Clear()

            Dim Distance As Integer = 0 '掘進距離（単位mm)　リング分のセグメント幅を加算
            For i As Integer = PlcIf.RingNo To PlcIf.RingNo + CtlPara.LineDevLastRing
                Distance += SegAsmblyData.TypeData(i).CenterWidth * 1000
            Next
            '線形
            Dim dis As New clsLineMake

            For i As Integer = 0 To Distance Step 10
                dis.掘進累積距離 = (i + _HorRData.Last.Distance) / 1000
                'todo:軌道中心方位角でなく平面計画方位を演算　中折演算を加味
                _HorPData.Add(i, Hoko2Hoi(dis.軌道中心方位角 + HorPlan.X軸方位角))
                _VerPData.Add(i, dis.鉛直角)
            Next

        End Sub
    End Class

    ''' <summary>
    ''' 偏角、モーメントのトレンドグラフのデータを取得
    ''' 立ち上げ時の表示用
    ''' </summary>
    Private Class ChartDataGet
        Inherits clsDataBase

        Public Shared RingNo As Integer
        Private _DList As Dictionary(Of Integer, Single)
        Sub New(FldName As String)
            '_DList = New Dictionary(Of Integer, Single)
            Dim rsData As DataTable =
                GetDtfmSQL($"SELECT 掘進ストローク,{FldName} FROM flex掘削データ WHERE リング番号='{RingNo}';")
            'While rsData.Read
            '    _DList.Add(rsData.Item("掘進ストローク"), rsData.Item(FldName))
            'End While
            _DList =
                rsData.AsEnumerable.ToDictionary(Function(n) CInt(n.Item(0)), Function(n) CSng(n.Item(1)))

        End Sub

        Sub New()
            Dim rsData As DataTable =
                GetDtfmSQL("SELECT リング番号 FROM flex掘削データ ORDER BY 時間 DESC LIMIT 0,1")

            If rsData.Rows.Count <> 0 Then
                RingNo = rsData.Rows(0).Item(0)
            End If

        End Sub

        Public ReadOnly Property DList As Dictionary(Of Integer, Single)
            Get
                Return _DList
            End Get
        End Property


    End Class

    ''' <summary>
    ''' 汎用データ項目変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DspWideUse0_DoubleClick(sender As ucnDspData, e As EventArgs) _
        Handles DspWideUse0.DoubleClick, DspWideUse1.DoubleClick, DspWideUse2.DoubleClick,
        DspWideUse3.DoubleClick, DspWideUse4.DoubleClick, DspWideUse5.DoubleClick,
        DspWideUse6.DoubleClick, DspWideUse7.DoubleClick, DspWideUse8.DoubleClick,
        DspWideUse9.DoubleClick, DspWideUse10.DoubleClick, DspWideUse11.DoubleClick, DspWideUse12.DoubleClick

        cmbWideSelct.Tag = sender
        cmbWideSelct.Visible = True
        '選択用アイテムをセット
        cmbWideSelct.Items.Clear()
        'アナログtagより項目名を列挙
        cmbWideSelct.Items.AddRange((From n In PlcIf.AnalogTag.Tag Select n.FieldName).ToArray)
        cmbWideSelct.Text = sender.FieldName
        '位置を調整
        cmbWideSelct.Top = sender.Top + 5


    End Sub
    ''' <summary>
    ''' 項目名が変更された時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbWideSelct_Click(sender As Object, e As EventArgs) Handles cmbWideSelct.SelectionChangeCommitted
        cmbWideSelct.Visible = False
        Dim WideUse As ucnDspData = DirectCast(cmbWideSelct.Tag, ucnDspData)
        WideUse.FieldName = cmbWideSelct.SelectedItem
        CtlPara.WideUseUpdate(CShort(WideUse.Name.Replace("DspWideUse", "")), WideUse.FieldName)
        WideDataFldSet() '汎用データ・セット
    End Sub

    Private Sub DspWideUse0_DoubleClick(sender As Object, e As EventArgs) Handles DspWideUse9.DoubleClick, DspWideUse8.DoubleClick, DspWideUse7.DoubleClick, DspWideUse6.DoubleClick, DspWideUse5.DoubleClick, DspWideUse4.DoubleClick, DspWideUse3.DoubleClick, DspWideUse2.DoubleClick, DspWideUse11.DoubleClick, DspWideUse10.DoubleClick, DspWideUse1.DoubleClick, DspWideUse0.DoubleClick, DspWideUse12.DoubleClick

    End Sub

    Private Sub 平面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 平面ToolStripMenuItem.Click
        frmHorPlanData.Show()
    End Sub

    Private Sub 縦断ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 縦断ToolStripMenuItem.Click
        frmVerPlanData.Show()
    End Sub

    Private Sub ｌｂｌMachineMode_Click(sender As Object, e As EventArgs) Handles lblMachineMode.Click

    End Sub


    ''' <summary>
    ''' 閉じるボタンを無効　Win32 APIによる方法
    ''' </summary>
    ''' <param name="hWnd"></param>
    ''' <param name="bRevert"></param>
    ''' <returns></returns>
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function GetSystemMenu(ByVal hWnd As IntPtr,
        ByVal bRevert As Boolean) As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function GetMenuItemCount(ByVal hMenu As IntPtr) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function DrawMenuBar(ByVal hWnd As IntPtr) As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function RemoveMenu(ByVal hMenu As IntPtr,
        ByVal uPosition As Integer,
        ByVal uFlags As Integer) As Boolean
    End Function

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        Const MF_BYPOSITION As Int32 = &H400
        Const MF_REMOVE As Int32 = &H1000

        Dim menu As IntPtr = GetSystemMenu(Me.Handle, False)
        Dim menuCount As Integer = GetMenuItemCount(menu)
        If menuCount > 1 Then
            'メニューの「閉じる」とセパレータを削除
            RemoveMenu(menu, menuCount - 1, MF_BYPOSITION Or MF_REMOVE)
            RemoveMenu(menu, menuCount - 2, MF_BYPOSITION Or MF_REMOVE)
            DrawMenuBar(Me.Handle)
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim ReportTbl As New clsRingReport
        '        ReportTbl.CheckRingItem()
        'フォームのタイトル
        Me.Text += $"{GetVersionNo()} [{InitPara.ConstructionName}] "

        Me.Text += InitPara.ModeName


        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
            .NumberGroup = InitPara.NumberGroup
            .FirstJackLoc = InitPara.FirstJackLoc
            .FaiJack = InitPara.FaiJack
            .JackGroupPos = InitPara.JackGroupPos
            .NumberJack = InitPara.NumberJack
            .MeasureJkNo = InitPara.MesureJackAngle.Keys.ToList

            .FlexPointX = PlcIf.PointX
            .FlexPointY = PlcIf.PointY

            .FlexPointR = PlcIf.操作強
            .FlexPointSeater = PlcIf.操作角

            .DspInitBaseImg()

            .SegmentDspEnable = InitPara.LosZeroEquip
            .MaxCopyStroke = PlcIf.AnalogTag.TagData("コピーストローク1").EngHight
        End With

        '---------------チャートの設定------------------------
        '偏角、モーメントグラフ
        Dim LastRingNoGet As New ChartDataGet   '最終のリング番号を取得

        Dim HorMomentData As New ChartDataGet("水平モーメント")
        Dim VerMomentData As New ChartDataGet("鉛直モーメント")
        Dim HorDevData As New ChartDataGet("水平偏角")
        Dim VerDevData As New ChartDataGet("鉛直偏角")


        '水平モーメント
        ucnHorMomentChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnHorMomentChart.ChartHighScale = CtlPara.HorMomentTrendWidth
        ucnHorMomentChart.ChartList = HorMomentData.DList
        ucnHorMomentChart.ChartClear()

        '鉛直モーメント
        ucnVerMomentChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnVerMomentChart.ChartHighScale = CtlPara.HorMomentTrendWidth
        ucnVerMomentChart.ChartList = VerMomentData.DList
        ucnVerMomentChart.ChartClear()
        '水平偏角
        ucnHorDevChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnHorDevChart.ChartHighScale = CtlPara.HorDevDegTrendWidth
        ucnHorDevChart.ChartList = HorDevData.DList
        ucnHorDevChart.ChartClear()
        '鉛直偏角
        ucnVerDevChart.StrokeWidth = CtlPara.GraphStrokeWidth
        ucnVerDevChart.ChartHighScale = CtlPara.HorDevDegTrendWidth
        ucnVerDevChart.ChartList = VerDevData.DList
        ucnVerDevChart.ChartClear()
        '
        UcnGpPvBarGraph.PresBarGraphWidt = CtlPara.PresBarGraphWidt

        'フォームの大きさを画面
        ReDim DspGp(InitPara.NumberGroup)

        'イベントログ更新
        EventlogUpdate()

        'PLCにグループ数、ジャッキ本数書込
        PlcIf.ParameterWrite("グループ数", InitPara.NumberGroup)
        PlcIf.ParameterWrite("ジャッキ本数", InitPara.NumberJack)

        '汎用データ表示項目セット
        WideDataFldSet()

        '基準方位の算出
        RefernceDirection.sbCulKijun()

        DirectionChartD.DataGet()

        '線形データ画面更新
        LineDataUpdate()
        If InitPara.LosZeroEquip Then
            '組立パターンの情報を取得
            SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)
            '同時施工組立パターン情報表示
            SegmentDataDsp()
        End If
        '同時施工モードのメニュー有効
        LossZeroConcern.Enabled = InitPara.LosZeroEquip
        AssemblyProcessEdit.Enabled = InitPara.LosZeroEquip

        btnLoszeroContinu.Visible = InitPara.LosZeroEquip
        btnPieceConfirm.Visible = InitPara.LosZeroEquip
        btnLossZerooCancel.Visible = InitPara.LosZeroEquip


        DspUpRealStroke.Visible = InitPara.LosZeroEquip
        DspRightRealStroke.Visible = InitPara.LosZeroEquip
        DspLeftRealStroke.Visible = InitPara.LosZeroEquip
        DspBottomRealStroke.Visible = InitPara.LosZeroEquip

        DspUpRawStroke.FieldName = "上ストローク"
        DspRightRawStroke.FieldName = "右ストローク"
        DspLeftRawStroke.FieldName = "左ストローク"
        DspBottomRawStroke.FieldName = "下ストローク"




        DspWideUse12.Visible = Not InitPara.LosZeroEquip

        '掘削開始時刻の取得
        DspExcavStartDay(getExcecStartTime)
        '姿勢制御自動手動の切替時の処理
        FlexAutoManualChange()


        '上下ストローク計の有無で表示設定

        DspBottomRawStroke.Visible = InitPara.bottomStrokeEnable
        DspBottomRealStroke.Visible = InitPara.bottomStrokeEnable And InitPara.LosZeroEquip
        DspBottomSpeed.Visible = InitPara.bottomStrokeEnable


        DspUpRawStroke.Visible = InitPara.topStrokeEnable
        DspUpRealStroke.Visible = InitPara.topStrokeEnable And InitPara.LosZeroEquip
        DspUpSpeed.Visible = InitPara.topStrokeEnable

        'テールクリアランスの表示
        DspTopClearance.Visible = CtlPara.TaleClrMeasurUExit
        DspLeftClearance.Visible = CtlPara.TaleClrMeasurLExit
        DspRightClearance.Visible = CtlPara.TaleClrMeasurRExit
        DspBottomClearance.Visible = CtlPara.TaleClrMeasurBExit

        ParameterCheck()

        'ロスゼロ実績
        LosZeroPerform.Caluc()
        'ロスゼロで掘進途中に立ち上げたときのストローク処理
        StrokeSet()

        '計算ストローク演算
        PlcIf_MesureStrokeChange()

        '立ち上がったイベントを表示

        Dim db As New clsDataBase

        db.ExecuteSqlCmd _
            ($"INSERT INTO FLEXイベントデータ
            (Time,イベントデータ,イベント種類) VALUES('{Now}','Flex Start [{System.Net.Dns.GetHostName()}] [{InitPara.ModeName}]','0')")

    End Sub
    ''' <summary>
    ''' ロスゼロで掘進途中に立ち上げたときのストローク処理
    ''' </summary>
    Private Sub StrokeSet()
        If PlcIf.ExcaStatus <> cTaiki AndAlso PlcIf.LosZeroEnable Then
            'TODO:最大テーパーの算出
            CalcStroke.SegmentTaperValue = SegAsmblyData.TypeData(PlcIf.RingNo).ETTaper
            '最大テーパー位置
            CalcStroke.SegmentMaxTaperLoc = SegAsmblyData.TypeData(PlcIf.RingNo).TaperAngle
            'セグメント幅
            CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
            '引き戻し中から押込み中の間は引き戻しｼﾞｬｯｷをセット
            If PlcIf.LosZeroSts_M >= 2 And PlcIf.LosZeroSts_M <= 4 Then
                CalcStroke.PullBackJack = SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo).PullBackJack
            End If

            For Pieace As Short = 1 To PlcIf.AssemblyPieceNo
                If Pieace < PlcIf.AssemblyPieceNo Or (Pieace = PlcIf.AssemblyPieceNo And PlcIf.LosZeroSts_M = 5) Then
                    CalcStroke.asembleFinishedJack = SegAsmblyData.ProcessData(Pieace).ClosetJack
                    CalcStroke.asembleFinishedJack = SegAsmblyData.ProcessData(Pieace).AddClosetJack
                    'CalcStroke.MesureCalcAveJackStroke = PlcIf.MesureCalcAveJackStroke
                End If
            Next
            '計測ジャッキオフセットストロークの読込
            CalcStroke.mesureOffsetJackStroke = CtlPara.mesureOffsetJackStroke

        End If

    End Sub




    ''' <summary>
    ''' パラメータのチェック
    ''' </summary>
    Private Sub ParameterCheck()

        If PlcIf.DirectControlCoefficient = 0 Then
            PlcIf.DirectControlCoefficient = 1
        End If

        If PlcIf.減圧弁制御P定数 = 0 Or PlcIf.減圧弁制御I定数 = 0 Then
            frmPressParameterSet.Show()
        End If
    End Sub

    Private Sub RingDataViewer_Click(sender As Object, e As EventArgs) Handles RingDataViewer.Click

        frmRingDataView.Show()

    End Sub
    ''' <summary>
    ''' 次ピース確認画面
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLoszeroContinu_Click(sender As Object, e As EventArgs) Handles btnLoszeroContinu.Click
        frmNextPieceConfirm.Show()
        btnLoszeroContinu.Enabled = False 'ボタン無効
    End Sub

    Private Sub DspExcationElapsedTime_Load(sender As Object, e As EventArgs) Handles DspExcationElapsedTime.Load

    End Sub

    Private Sub DspRingTargetDir_Load(sender As Object, e As EventArgs) Handles DspRingTargetDir.Load

    End Sub

    ''' <summary>
    ''' 目標推進量の入力
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NetStrokeChange_Click(sender As Object, e As EventArgs) Handles NetStrokeChange.Click, DspTargetNetStroke.DoubleClick, DspRingTargetDir.DoubleClick
        frmNetStrokeChange.Show()
    End Sub
End Class