Public Class frmMain
    Inherits Windows.Forms.Form



    Private DspGp() As ucnDspGpPres
    Private BlinkFlg As Boolean
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

            DspAveStroke.Value = .RealStroke        '平均ストローク

            DspDirection.Value = .Gyro              '方位角

            DspRealBottomStroke.Value = .BotomStroke '下ｽﾄﾛｰｸ
            DspBottomSpeed.Value = .BotomSpeed      '下ｽﾋﾟｰﾄﾞ

            DspUpRealStroke.Value = .TopStroke      '上ｽﾄﾛｰｸ
            DspUpSpeed.Value = .TopSpeed            '上ｽﾋﾟｰﾄﾞ

            DspRightRealStroke.Value = .RightStroke '右ｽﾄﾛｰｸ
            DspRightSpeed.Value = .RightSpeed       '右ｽﾋﾟｰﾄﾞ

            DspLeftRealStroke.Value = .LeftStroke   '左ｽﾄﾛｰｸ
            DspLeftSpeed.Value = .LeftSpeed         '左ｽﾋﾟｰﾄﾞ

            DspJackPress.Value = .JkPress           'ジャッキ圧力
            'TODO:取り敢えず、左右の平均を算出
            DspExcvSpeed.Value = (.RightSpeed + .LeftSpeed) / 2


            DspPitching.Value = .Pitching           'ピッチング
            DspHorBroken.Value = .NakaoreLR         '中折左右
            DspVerBroken.Value = .NakaoreTB         '中折上下


            DspThrust.Value = CulcMoment.Thrust
            DspMoment.Value = CulcMoment.MomentR


            DspFlexControlOn.BitStatus = .FlexControlOn 'FLEXの制御ON/OFF



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
            UcnJackDsp.CopyStroke = .CopyStroke


            UcnGpPvBarGraph.GpFlg = .GroupFlg
            UcnGpPvBarGraph.GpPv = .GroupPv


        End With
        With ControlParameter
            UcnJackDsp.FlexAutoManual = .AutoDirectionControl
            DspFlexAuto.BitStatus = .AutoDirectionControl

            UcnJackDsp.FlexPointX = .PointX
            UcnJackDsp.FlexPointY = .PointY

            UcnJackDsp.FlexPointR = .操作強
            UcnJackDsp.FlexPointSeater = .操作角
        End With


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


        'TODO:線形データ画面更新　LineDistanceChage に記述したい
        'Call LineDataUpdate()


    End Sub
    ''' <summary>
    ''' 偏角、モーメントのチャート初期化
    ''' 待機中から掘進中の時に実行
    ''' </summary>
    Public Sub ChartClear()
        ucnHorMomentChart.ChartClear()
        ucnVerMomentChart.ChartClear()
        ucnHorDevChart.ChartClear()
        ucnVerDevChart.ChartClear()
    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        InitParameter = New clsInitParameter '初期値パラメータ
        ControlParameter = New clsControlParameter  '制御パラメータ

        HorPlan = New clsHorPanData '平面掘進計画線
        VerPlan = New clsVerPlanData '縦断掘進計画線

        MachineSpec = New clsMachinSpec

        SegmentAssembly = New clsSegmentAssembly ''セグメント組立データ

        DataSave = New clsDataSave 'データ保存

        CulcMoment = New clsCulMoment ''モーメント、推力の演算

        JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        DivCul = New clsThrustDiv ''
        RefernceDirection = New clsCulKijun
        JackManual = New clsJkManualOut

        'PLCインターフェース
        PlcIf = New clsPlcIf

        Reduce = New clsReducePress


        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
            .NumberGroup = InitParameter.NumberGroup
            .FirstJackLoc = InitParameter.FirstJackLoc
            .FaiJack = InitParameter.FaiJack
            .JackGroupPos = InitParameter.JackGroupPos
            .NumberJack = InitParameter.NumberJack

            .FlexPointX = ControlParameter.PointX
            .FlexPointY = ControlParameter.PointY

            .FlexPointR = ControlParameter.操作強
            .FlexPointSeater = ControlParameter.操作角

            Call .DspInitBaseImg()
        End With

        'チャートの設定
        With ucnHorMomentChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorMomentTrendWidth
        End With
        With ucnVerMomentChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorMomentTrendWidth
        End With
        With ucnHorDevChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorDevDegTrendWidth
        End With
        With ucnVerDevChart
            .StrokeWidth = ControlParameter.GraphStrokeWidth
            .GraphHeight = ControlParameter.HorDevDegTrendWidth
        End With

        '
        UcnGpPvBarGraph.PresBarGraphWidt = ControlParameter.PresBarGraphWidt

        'フォームの大きさを画面

        ReDim DspGp(InitParameter.NumberGroup)
        'イベントログ更新
        EventlogUpdate()

        'PLCにグループ数、ジャッキ本数書込
        PlcIf.ParameterWrite("グループ数", InitParameter.NumberGroup)
        PlcIf.ParameterWrite("ジャッキ本数", InitParameter.NumberJack)



    End Sub
    ''' <summary>
    ''' 線形データ画面更新
    ''' </summary>
    Public Sub LineDataUpdate()
        With RefernceDirection
            '中心の総距離
            DspDistance.Value = .HorZendoKijun.掘進累積距離
            '平面線形データ
            If .HorKodoKijun.平面線形 = 1 Then
                DspHorLine.Value = "-------"
            Else
                DspHorLine.Value = .HorZendoKijun.軌道中心平面半径
            End If

            DspHorFChangePoint.Value = .HorZendoKijun.平面ゾーン掘進距離
            DspHorRChangePoint.Value = .HorZendoKijun.平面ゾーン内残距離
            DspTargetDirection.Value = .平面基準方位
            DspHorDev.Value = .平面偏角

            '縦断線形データ
            If .VerZendoKijun.縦断線形 = 1 Then
                DspVerLine.Value = "-------"
            Else
                DspVerLine.Value = .VerZendoKijun.縦断半径

            End If
            DspVerFChangePoint.Value = .VerZendoKijun.縦断ゾーン内掘進距離
            DspVerRChangePoint.Value = .VerZendoKijun.縦断ゾーン内残距離
            DspTargetPitching.Value = .縦断基準方位
            DspVerDev.Value = .縦断偏角

            UcnDspDevImg.HorDev = .平面偏角
            UcnDspDevImg.VerDev = .縦断偏角


            ucnHorLineChart.PlanData = .平面計画方位
            ucnHorLineChart.CorrectData = ControlParameter.水平入力補正値
            ucnHorLineChart.TargetData = DspTargetDirection.Value
            ucnHorLineChart.RealData = DspDirection.Value


            ucnVerLineChart.PlanData = .縦断計画方位
            ucnVerLineChart.CorrectData = ControlParameter.鉛直入力補正値
            ucnVerLineChart.TargetData = DspTargetPitching.Value
            ucnVerLineChart.RealData = DspPitching.Value




        End With
    End Sub
    ''' <summary>
    ''' 同時施工組立パターン情報表示
    ''' </summary>
    Public Sub SegmentDataDsp()
        '組立パターン

        'Dim p As Short = 0
        If PlcIf.AssemblyPieceNo <= 0 Then PlcIf.AssemblyPieceNo = 1
        With SegmentAssembly.SegmentProcessData(PlcIf.AssemblyPieceNo)
            'TODO:組立セグメント、組立ﾎﾞﾙﾄﾋﾟｯﾁの取込
            DspAssemblyPattern.Value = .PatternName '組立パターン名
            DspBoltPitch.Value = .BoltPitch '組立ボルトピッチ
            DspAssemblyPieace.Value = .PieceName  '組立ピース名称
            DspPullBackJack.Value = SegmentAssembly.JackListDsp(.PullBackJack) '引戻しジャッキ
            DspClosetJack.Value = SegmentAssembly.JackListDsp(.ClosetJack) '押込みジャッキ
            DspAddClosetThrustJack.Value = SegmentAssembly.JackListDsp(.AddClosetJack) '追加押込みジャッキ

        End With
        'MAXのピース番号内で表示
        If SegmentAssembly.AssemblyPieceNumber > PlcIf.AssemblyPieceNo Then
            DspNextPieceName.Value =
            SegmentAssembly.SegmentProcessData(PlcIf.AssemblyPieceNo + 1).PieceName '組立次ピース名称
        Else
            DspNextPieceName.Value = "-------"
        End If
        '全ピース　名称表示
        UcnJackDsp.PieceAngle.Clear()
        UcnJackDsp.PieceCenterAngle.Clear()
        UcnJackDsp.PieceName.Clear()
        UcnJackDsp.AssemblyOrder.Clear()

        For Each pca As clsSegmentAssembly.AsseblyProcess
                                        In SegmentAssembly.SegmentProcessData.Values
            UcnJackDsp.PieceName.Add(pca.PieceName)
            UcnJackDsp.PieceAngle.Add(pca.PieceAngle)
            UcnJackDsp.PieceCenterAngle.Add(pca.PieceCenterAngle)
            UcnJackDsp.AssemblyOrder.Add(pca.AssemblyOrder)
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
            'Application.Exit()
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

    Private Sub ReloadPlanData_Click(sender As Object, e As EventArgs) Handles ReloadPlanData.Click

    End Sub

    Private Sub SegmentEdit_Click(sender As Object, e As EventArgs) Handles SegmentEdit.Click

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
        With ControlParameter
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

        If MsgBox(MsgText & "よろしいですか?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, MsgText) = MsgBoxResult.Ok Then
            PlcIf.DigtalPlcWrite(MsgText, True) 'PLC書込
            WriteEventData(MsgText & "されました。", Color.BlueViolet)
        End If

    End Sub

    Private Sub TuningMonitorClicｋ_Click(sender As Object, e As EventArgs) Handles TuningMonitorClicｋ.Click
        My.Forms.frmTuningMonitor.Show()
    End Sub
    ''' <summary>
    ''' FLEX自動方向制御ON/OFF
    ''' </summary>
    Private Sub UcnJackDsp_FlexAutoManualChange() Handles UcnJackDsp.FlexAutoManualChange
        ControlParameter.AutoDirectionControl = Not ControlParameter.AutoDirectionControl
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
End Class