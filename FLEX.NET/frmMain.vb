Public Class frmMain
    Inherits Windows.Forms.Form
    ''' <summary>
    ''' 姿勢トレンドデータ
    ''' </summary>
    Public Shared DirectionChartD As New DirectionChartData

    Private DspGp() As ucnDspGpPres 'グループ圧PV数値表示用
    Private BlinkFlg As Boolean '点滅フラグ
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
        With PlcIf

            DspMachinComErr.Visible = .MachineComErr 'マシン伝送異常
            DspMachinComErr.BitStatus = BlinkFlg

            DspRingNo.Text = .RingNo 'リングNo

            DspDirection.Value = .Gyro              '方位角

            DspBottomRealStroke.Value = CalcStroke.BottomCalcStroke '下ｽﾄﾛｰｸ
            DspBottomRawStroke.Value = .BotomStroke '下ｽﾄﾛｰｸ
            DspBottomSpeed.Value = .BotomSpeed      '下ｽﾋﾟｰﾄﾞ

            DspUpRealStroke.Value = CalcStroke.TopCalcStroke      '上ｽﾄﾛｰｸ
            DspUpRawStroke.Value = .TopStroke      '上ｽﾄﾛｰｸ
            DspUpSpeed.Value = .TopSpeed            '上ｽﾋﾟｰﾄﾞ

            DspRightRealStroke.Value = CalcStroke.RightCalcStroke '右ｽﾄﾛｰｸ
            DspRightRawStroke.Value = .RightStroke '右ｽﾄﾛｰｸ
            DspRightSpeed.Value = .RightSpeed       '右ｽﾋﾟｰﾄﾞ

            DspLeftRealStroke.Value = CalcStroke.LeftCalcStroke   '左ｽﾄﾛｰｸ
            DspLeftRawStroke.Value = .LeftStroke   '左ｽﾄﾛｰｸ
            DspLeftSpeed.Value = .LeftSpeed         '左ｽﾋﾟｰﾄﾞ

            DspJackPress.Value = .JkPress           'ジャッキ圧力
            DspPitching.Value = .Pitching           'ピッチング
            DspHorBroken.Value = .NakaoreLR         '中折左右
            DspVerBroken.Value = .NakaoreTB         '中折上下

            DspCopyStroke1.Value = .CopyStroke1 'コピーストローク
            DspCopyStroke2.Value = .CopyStroke2

            DspBottomClearance.Value = .botomClearance
            DspTopClearance.Value = .topClearance
            DspRightClearance.Value = .rightClearance
            DspLeftClearance.Value = .leftClearance

            DspThrust.Value = CulcMoment.Thrust '推力
            DspMoment.Value = CulcMoment.MomentR 'モーメント
            'FLEXの制御ON/OFF
            DspFlexControlOn.BitStatus = .FlexControlOn
            UcnJackDsp.FlexOn = .FlexControlOn

            '掘進ステータス　掘進中、中断中、待機中
            DspExcavingOn.BitStatus = (.ExcaStatus = cKussin)
            DspExcavingStop.BitStatus = (.ExcaStatus = cChudan)
            DspExcaWaiting.BitStatus = (.ExcaStatus = cTaiki)
            'ジャッキステータス表示
            UcnJackDsp.JackStatus = .JackStatus
            'グループ圧PV
            UcnJackDsp.GroupPV = .GroupPv
            UcnJackDsp.JackOrgPress = .JkPress
            'コピー角度、ストローク
            UcnJackDsp.CopyAngle = .CopyAngle
            UcnJackDsp.CopyStroke = .CopyStroke1
            'グループ圧バーグラフ
            UcnGpPvBarGraph.GpFlg = .GroupFlg
            UcnGpPvBarGraph.GpPv = .GroupPv
        End With

        DspAveStroke.Value = CalcStroke.CalcAveLogicalStroke '計算平均ストローク
        DspExcvSpeed.Value = CalcStroke.MesureAveSpeed '計測ジャッキ平均ストローク


        '汎用データ表示
        For Each wu In CtlParameter.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If dd.FieldName <> "" Then
                dd.Value = PlcIf.EngValue(dd.FieldName)
            Else
                dd.Value = "-------"
            End If
        Next

        With CtlParameter
            '自動方向制御ON／OFF
            UcnJackDsp.FlexAutoManual = .AutoDirectionControl
            DspFlexAuto.BitStatus = .AutoDirectionControl
            '力点座標数値表示
            UcnJackDsp.FlexPointX = .PointX
            UcnJackDsp.FlexPointY = .PointY

            UcnJackDsp.FlexPointR = .操作強
            UcnJackDsp.FlexPointSeater = .操作角
        End With

        '圧力調整用フラグ
        DspJackPress.Blink = JackMvAuto.圧力超
        DspMoment.Blink = JackMvAuto.モーメント上限超



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

        '経過時間の表示
        DspExcationElapsedTime.Value = ElapsedTime.ExcavationTime
        DspLosZeroElapsedTime.Value = ElapsedTime.LozeroExcavationTime
        DspWatingElapsedTime.Value = ElapsedTime.WatingTime
        DspCycleTime.Value = ElapsedTime.CycleTime
        lblNowDate.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")

        'TODO:線形データ画面更新　LineDistanceChage に記述したい
        'Call LineDataUpdate()


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
        InitParameter = New clsInitParameter '初期値パラメータ
        CtlParameter = New clsControlParameter  '制御パラメータ
        HorPlan = New clsHorPanData '平面掘進計画線
        VerPlan = New clsVerPlanData '縦断掘進計画線
        MachineSpec = New clsMachinSpec
        SegAsmblyData = New clsSegmentAssembly ''セグメント組立データ
        DataSave = New clsDataSave 'データ保存
        CulcMoment = New clsCulMoment ''モーメント、推力の演算
        JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        DivCul = New clsThrustDiv ''推力分担
        RefernceDirection = New clsCulKijun '基準方位演算
        JackManual = New clsJkManualOut 'ジャッキ手動操作出力
        CalcStroke = New clsCalcuStroke   'ロスゼロ時の計算ストローク
        PlcIf = New clsPlcIf 'PLCインターフェース
        Reduce = New clsReducePress 'ロスゼロ減圧処理
        TableUpdateConfirm = New clsTableUpdateConfirm    'テーブル更新によるパラメータ再取得

        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
            .NumberGroup = InitParameter.NumberGroup
            .FirstJackLoc = InitParameter.FirstJackLoc
            .FaiJack = InitParameter.FaiJack
            .JackGroupPos = InitParameter.JackGroupPos
            .NumberJack = InitParameter.NumberJack

            .FlexPointX = CtlParameter.PointX
            .FlexPointY = CtlParameter.PointY

            .FlexPointR = CtlParameter.操作強
            .FlexPointSeater = CtlParameter.操作角

            Call .DspInitBaseImg()
        End With

        '---------------チャートの設定------------------------
        '偏角、モーメントグラフ
        Dim LastRingNoGet As New ChartDataGet   '最終のリング番号を取得

        Dim HorMomentData As New ChartDataGet("水平モーメント")
        Dim VerMomentData As New ChartDataGet("鉛直モーメント")
        Dim HorDevData As New ChartDataGet("水平偏角")
        Dim VerDevData As New ChartDataGet("鉛直偏角")


        '水平モーメント
        With ucnHorMomentChart
            .StrokeWidth = CtlParameter.GraphStrokeWidth
            .ChartHighScale = CtlParameter.HorMomentTrendWidth
            .ChartList = HorMomentData.DList

        End With
        '鉛直モーメント
        With ucnVerMomentChart
            .StrokeWidth = CtlParameter.GraphStrokeWidth
            .ChartHighScale = CtlParameter.HorMomentTrendWidth
            ucnVerMomentChart.ChartList = VerMomentData.DList
        End With
        '水平偏角
        With ucnHorDevChart
            .StrokeWidth = CtlParameter.GraphStrokeWidth
            .ChartHighScale = CtlParameter.HorDevDegTrendWidth
            .ChartList = HorDevData.DList
        End With
        '鉛直偏角
        With ucnVerDevChart
            .StrokeWidth = CtlParameter.GraphStrokeWidth
            .ChartHighScale = CtlParameter.HorDevDegTrendWidth
            .ChartList = VerDevData.DList
        End With

        '
        UcnGpPvBarGraph.PresBarGraphWidt = CtlParameter.PresBarGraphWidt

        'フォームの大きさを画面

        ReDim DspGp(InitParameter.NumberGroup)
        'イベントログ更新
        EventlogUpdate()

        'PLCにグループ数、ジャッキ本数書込
        PlcIf.ParameterWrite("グループ数", InitParameter.NumberGroup)
        PlcIf.ParameterWrite("ジャッキ本数", InitParameter.NumberJack)

        '汎用データ表示項目セット
        WideDataFldSet()

    End Sub
    ''' <summary>
    ''' 汎用データ表示項目セット
    ''' </summary>
    Public Sub WideDataFldSet()
        For Each wu In CtlParameter.WideUse
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




    ''' <summary>
    ''' 線形データ画面更新
    ''' </summary>
    Public Sub LineDataUpdate()
        With RefernceDirection
            '中心の総距離
            DspDistance.Value = .HorZendoKijun.掘進累積距離
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

            UcnDspDevImg.HorDev = .平面偏角
            UcnDspDevImg.VerDev = .縦断偏角

        End With

        '姿勢角トレンドトレンド　データセット
        ucnHorLineChart.PlanData = DirectionChartD.HorPData
        ucnHorLineChart.ExecData = DirectionChartD.HorRData

        ucnVerLineChart.PlanData = DirectionChartD.VerPData
        ucnVerLineChart.ExecData = DirectionChartD.VerRData

    End Sub
    ''' <summary>
    ''' 同時施工組立パターン情報表示
    ''' </summary>
    Public Sub SegmentDataDsp()
        '組立パターン

        'Dim p As Short = 0
        If PlcIf.AssemblyPieceNo <= 0 Then PlcIf.AssemblyPieceNo = 1

        DspTypeName.Value = SegAsmblyData.TypeData(PlcIf.RingNo).TypeName 'セグメント種類

        With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
            'TODO:組立セグメント、組立ﾎﾞﾙﾄﾋﾟｯﾁの取込
            DspAssemblyPattern.Value = .PatternName '組立パターン名
            DspBoltPitch.Value = .BoltPitch '組立ボルトピッチ
            DspAssemblyPieace.Value = .PieceName  '組立ピース名称
            DspPullBackJack.Value = SegAsmblyData.JackListDsp(.PullBackJack) '引戻しジャッキ
            DspClosetJack.Value = SegAsmblyData.JackListDsp(.ClosetJack) '押込みジャッキ
            DspAddClosetThrustJack.Value = SegAsmblyData.JackListDsp(.AddClosetJack) '追加押込みジャッキ
        End With
        'MAXのピース番号内で表示
        If SegAsmblyData.AssemblyPieceNumber > PlcIf.AssemblyPieceNo Then
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

            '同時施工モード時のみ
            If PlcIf.LosZeroMode Then
                'TODO:ローリングの考慮なし　マシンメーカーへ出力
                '天を０度で時計回りに
                Dim angle As Single
                angle = 90 - pca.PieceCenterAngle
                If angle < 0 Then angle += 360

                PlcIf.AnalogPlcWrite(pca.AssemblyOrder & "ピースセグメント位置角度", angle)
            End If


        Next
        UcnJackDsp.AssemblyPieceNo = PlcIf.AssemblyPieceNo

        UcnJackDsp.SegmentPieceDsp() 'ｾｸﾞﾒﾝﾄピース表示



    End Sub


    Private Sub MenuSystem_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuSystem.ItemClicked

    End Sub

    Private Sub PlanDataSetting_Click(sender As Object, e As EventArgs) Handles PlanDataSetting.Click

    End Sub
    ''' <summary>
    ''' リング番号変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoChange_Click(sender As Object, e As EventArgs) Handles RingNoChange.Click
        frmRingNoChange.Show()
    End Sub


    ''' <summary>
    ''' リング更新設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoUpdate_Click(sender As Object, e As EventArgs) Handles RingNoUpdateSetting.Click
        frmRinguUpdateSetting.Show()
    End Sub

    Private Sub OperationRight_Click(sender As Object, e As EventArgs) Handles OperationRight.Click

    End Sub

    Private Sub InitialSetting_Click(sender As Object, e As EventArgs) Handles InitialSetting.Click

    End Sub

    Private Sub ReportOut_Click(sender As Object, e As EventArgs) Handles ReportOut.Click

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

    Private Sub SegmentEdit_Click(sender As Object, e As EventArgs) Handles SegmentEdit.Click
        My.Forms.frmSegmentEdit.Show()

    End Sub

    Private Sub AssemblyProcessEdit_Click(sender As Object, e As EventArgs) Handles AssemblyProcessEdit.Click
        My.Forms.frmAssemblyProcessEdit.Show()
    End Sub

    Private Sub CorrectionValMng_Click(sender As Object, e As EventArgs) Handles CorrectionValMng.Click
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
        With CtlParameter
            .PointX = UcnJackDsp.FlexPointX
            .PointY = UcnJackDsp.FlexPointY

            JackManual.PutPointXY(.PointX, .PointY)

        End With

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
        Else
            My.Forms.frmTuningMonitor.Show()
        End If
    End Sub

    Private Sub TuningTrend_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.DoubleClick

    End Sub



    ''' <summary>
    ''' FLEX自動方向制御ON/OFF
    ''' </summary>
    Private Sub UcnJackDsp_FlexAutoManualChange() Handles UcnJackDsp.FlexAutoManualChange
        CtlParameter.AutoDirectionControl = Not CtlParameter.AutoDirectionControl
    End Sub
    ''' <summary>
    ''' イベントログ更新
    ''' </summary>
    Public Sub EventlogUpdate()
        rtbEventLog.Clear()
        Dim DB As New clsDataBase
        Dim tb As Odbc.OdbcDataReader = DB.ExecuteSql _
            ("SELECT TIME,イベントデータ,イベント種類 FROM FLEXイベントデータ ORDER BY TIME DESC LIMIT 0,50")
        Dim i As Integer = 0
        While tb.Read()
            rtbEventLog.SelectionColor = ColorTranslator.FromOle(tb.Item(2))
            rtbEventLog.AppendText(CDate(tb.Item(0)).ToString("yyyy/MM/dd HH:mm:ss") & Space(2) & tb.Item(1).ToString & vbCrLf)

        End While
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
        PlcIf.LosZeroEnable = True '同時施工可　信号出力
    End Sub

    Private Sub ｂｔｎLossZerooCancel_Click(sender As Object, e As EventArgs) Handles btnLossZerooCancel.Click
        PlcIf.DigtalPlcWrite("同時施工キャンセル", True)
        PlcIf.LosZeroEnable = False '同時施工キャンセル
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

        Public ReadOnly Property HorPData As Dictionary(Of Integer, Single)
            Get
                Return _HorPData
            End Get
        End Property
        Public ReadOnly Property VerPData As Dictionary(Of Integer, Single)
            Get
                Return _VerPData
            End Get
        End Property


        ''' <summary>
        ''' 平面と縦断のチャートデータを取得
        ''' </summary>
        Public Sub DataGet()
            '過去の掘進データ 10mm毎
            Dim rsData As Odbc.OdbcDataReader =
                ExecuteSql($"SELECT * FROM flex掘削データ WHERE `リング番号`>=
                '{PlcIf.RingNo - CtlParameter.LineDevStartRing}
                ' AND `リング番号`<'{PlcIf.RingNo}' AND MOD(掘進ストローク,10)=0;")

            Console.WriteLine()
            _HorRData.Clear()
            _VerRData.Clear()
            Dim RingNo As Integer = Nothing
            Dim OffsetStroke As Integer = 0 'リング毎に加算する距離
            Dim TmpStrk As Integer
            Dim g As ucnChart2.gData
            Dim LastDistance As Single
            While rsData.Read
                If RingNo <> rsData.Item("リング番号") Then
                    OffsetStroke += TmpStrk
                End If
                g.RingNo = rsData("リング番号")
                g.Distance = OffsetStroke + rsData.Item("掘進ストローク")
                g.PlanDr = rsData.Item("前胴方位角")
                g.TargetDr = rsData.Item("平面姿勢角管理値")
                g.RealDr = rsData.Item("ジャイロ方位角")
                _HorRData.Add(g)

                g.PlanDr = rsData.Item("前胴鉛直角")
                g.TargetDr = rsData.Item("縦断姿勢角管理値")
                g.RealDr = rsData.Item("ジャイロピッチング")
                _VerRData.Add(g)
                RingNo = g.RingNo
                TmpStrk = rsData.Item("掘進ストローク")

                LastDistance = rsData.Item("平面発進から発旋回中心までの距離")
            End While

            'これから掘削する計画方位データ
            _HorPData.Clear()
            _VerPData.Clear()

            Dim Distance As Integer = 0 '掘進距離（単位mm)　リング分のセグメント幅を加算
            For i As Integer = PlcIf.RingNo To PlcIf.RingNo + CtlParameter.LineDevLastRing
                Distance += SegAsmblyData.TypeData(i).CenterWidth * 1000
            Next
            '線形
            Dim dis As New clsLineMake

            For i As Integer = 0 To Distance Step 10
                dis.掘進累積距離 = i / 1000 + LastDistance
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
            _DList = New Dictionary(Of Integer, Single)
            Dim rsData As Odbc.OdbcDataReader =
                ExecuteSql($"SELECT * FROM flex掘削データ WHERE `リング番号`='{RingNo}';")
            While rsData.Read
                _DList.Add(rsData.Item("掘進ストローク"), rsData.Item(FldName))
            End While
        End Sub

        Sub New()
            Dim rsData As Odbc.OdbcDataReader =
                ExecuteSql("SELECT * FROM flex掘削データ ORDER BY `時間` LIMIT 0,1")
            While rsData.Read
                RingNo = rsData.Item("リング番号")
            End While

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
        DspWideUse9.DoubleClick, DspWideUse10.DoubleClick, DspWideUse11.DoubleClick

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
        CtlParameter.WideUseUpdate(CShort(WideUse.Name.Replace("DspWideUse", "")), WideUse.FieldName)
        WideDataFldSet() '汎用データ・セット
    End Sub

    Private Sub DspWideUse0_DoubleClick(sender As Object, e As EventArgs) Handles DspWideUse9.DoubleClick, DspWideUse8.DoubleClick, DspWideUse7.DoubleClick, DspWideUse6.DoubleClick, DspWideUse5.DoubleClick, DspWideUse4.DoubleClick, DspWideUse3.DoubleClick, DspWideUse2.DoubleClick, DspWideUse11.DoubleClick, DspWideUse10.DoubleClick, DspWideUse1.DoubleClick, DspWideUse0.DoubleClick

    End Sub
End Class