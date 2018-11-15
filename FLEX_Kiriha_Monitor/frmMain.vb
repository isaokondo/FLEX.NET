Imports FLEX.NET
Public Class frmMain

    ''' <summary>
    ''' イベントログのID
    ''' </summary>
    Private EventID As Long



    Private BlinkFlg As Boolean '点滅フラグ





    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MYSQLのバージョン取得
        'clsDataBase.GetMySQKVersion()


        'インスタンス作成
        InitPara = New clsInitParameter '初期値パラメータ
        CtlPara = New clsControlParameter  '制御パラメータ
        HorPlan = New clsHorPanData '平面掘進計画線
        Dim Kant As New clsLineMake
        Kant.CulcZoneKant()

        VerPlan = New clsVerPlanData '縦断掘進計画線
        MachineSpec = New clsMachinSpec

        SegAsmblyData = New clsSegmentAssembly ''セグメント組立データ
        'DataSave = New clsDataSave 'データ保存
        CulcMoment = New clsCulMoment ''モーメント、推力の演算
        'JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        'DivCul = New clsThrustDiv ''推力分担
        RefernceDirection = New clsCulKijun '基準方位演算
        PlcIf = New clsPlcIf 'PLCインターフェース
        CalcStroke = New clsCalcuStroke   'ロスゼロ時の計算ストローク
        'JackManual = New clsJkManualOut 'ジャッキ手動操作出力
        'Reduce = New clsReducePress 'ロスゼロ減圧処理
        'TableUpdateConfirm = New clsTableUpdateConfirm    'テーブル更新によるパラメータ再取得

        LedLiner = New clsLedLiner '電光掲示板表示

        LedLiner.SendMsg = " "

        For Each ctp As Control In pnlLosZero.Controls
            Debug.Print(ctp.Name)
            If ctp.Name.Contains("ucnAssemblyPieceNo") Then
                DirectCast(ctp, ucnDspBit).FieldName = StrConv(Strings.Right(ctp.Name, 2).ToNum.ToString, VbStrConv.Wide) & "ピース目"
            End If

        Next



    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
            .NoOperation = True
            .CopyVisible = False
            .NumberGroup = InitPara.NumberGroup
            .FirstJackLoc = InitPara.FirstJackLoc
            .FaiJack = InitPara.FaiJack
            .JackGroupPos = InitPara.JackGroupPos
            .NumberJack = InitPara.NumberJack
            .MeasureJkNo = InitPara.MesureJackAngle.Keys.ToList

            '.FlexPointX = PlcIf.PointX
            '.FlexPointY = PlcIf.PointY

            '.FlexPointR = PlcIf.操作強
            '.FlexPointSeater = PlcIf.操作角

            .DspInitBaseImg()

            .SegmentDspEnable = InitPara.LosZeroEquip
            '.MaxCopyStroke = PlcIf.AnalogTag.TagData("コピーストローク1").EngHight
        End With

        '基準方位の算出
        RefernceDirection.sbCulKijun()

        '線形データ画面更新
        LineDataUpdate()

        If InitPara.LosZeroEquip Then
            '組立パターンの情報を取得
            SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)
            '同時施工組立パターン情報表示
            SegmentDataDsp()
        End If

        'ロスゼロ実績
        LosZeroPerform.Caluc()
        'ロスゼロで掘進途中に立ち上げたときのストローク処理
        StrokeSet()


        '汎用データ表示項目セット
        WideDataFldSet()


        For i As Short = 0 To 9
            Panel4.Controls("lblGpPvColor" & i).BackColor = UcnJackDsp.GpPvColor(i)
        Next



        '掘削開始時刻の取得
        DspExcavStartDay(getExcecStartTime)

        tmrDataDsp.Enabled = True

    End Sub
    Private Function getExcecStartTime() As Date
        Dim db As New clsDataBase
        Dim tb As DataTable =
             db.GetDtfmSQL($"SELECT 時間 FROM flex掘削データ 
            WHERE リング番号='{PlcIf.RingNo}' ORDER BY 時間  LIMIT 0,1")
        If tb.Rows.Count = 0 Then
            Return DateTime.Now
        Else
            Return tb.Rows(0).Item(0)
        End If

    End Function
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
    Private Sub tmrDataDsp_Tick(sender As Object, e As EventArgs) Handles tmrDataDsp.Tick



        'PLCからの読込表示



        DspRingNo.Text = PlcIf.RingNo 'リングNo

        DspDirection.Value = PlcIf.Gyro              '方位角
        'If InitPara.bottomStrokeEnable Then
        '    DspBottomRealStroke.Value = CalcStroke.BottomCalcStroke '下ｽﾄﾛｰｸ
        '    DspBottomRawStroke.Value = PlcIf.BotomStroke '下ｽﾄﾛｰｸ
        '    DspBottomSpeed.Value = PlcIf.BotomSpeed      '下ｽﾋﾟｰﾄﾞ
        'End If

        'If InitPara.topStrokeEnable Then
        '    DspUpRealStroke.Value = CalcStroke.TopCalcStroke      '上ｽﾄﾛｰｸ
        '    DspUpRawStroke.Value = PlcIf.TopStroke      '上ｽﾄﾛｰｸ
        '    DspUpSpeed.Value = PlcIf.TopSpeed            '上ｽﾋﾟｰﾄﾞ
        'End If


        'DspRightRealStroke.Value = CalcStroke.RightCalcStroke '右ｽﾄﾛｰｸ
        'DspRightRawStroke.Value = PlcIf.RightStroke '右ｽﾄﾛｰｸ
        'DspRightSpeed.Value = PlcIf.RightSpeed       '右ｽﾋﾟｰﾄﾞ

        'DspLeftRealStroke.Value = CalcStroke.LeftCalcStroke   '左ｽﾄﾛｰｸ
        'DspLeftRawStroke.Value = PlcIf.LeftStroke   '左ｽﾄﾛｰｸ
        'DspLeftSpeed.Value = PlcIf.LeftSpeed         '左ｽﾋﾟｰﾄﾞ

        DspJackPress.Value = PlcIf.JkPress           'ジャッキ圧力
        DspPitching.Value = PlcIf.Pitching           'ピッチング
        DspHorBroken.Value = PlcIf.NakaoreLR         '中折左右
        DspVerBroken.Value = PlcIf.NakaoreTB         '中折上下


        DspThrust.Value = CulcMoment.Thrust '推力
        DspMoment.Value = CulcMoment.MomentR 'モーメント
        ''FLEXの制御ON/OFF
        DspFlexControlOn.BitStatus = PlcIf.FlexControlOn
        ''常時表示に変更
        ''UcnJackDsp.FlexOn = PlcIf.FlexControlOn

        ''掘進ステータス　掘進中、中断中、待機中
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

        UcnJackDsp.FlexPointR = PlcIf.操作強
        UcnJackDsp.FlexPointSeater = PlcIf.操作角

        UcnJackDsp.FlexPointX = PlcIf.PointX
        UcnJackDsp.FlexPointY = PlcIf.PointY


        UcnJackDsp.MakeBmp()


        DspAveStartStroke.Value = CtlPara.StartAveStroke '平均開始ストローク
        DspAveStroke.Value = PlcIf.RealStroke ' CalcStroke.CalcAveLogicalStroke '計算平均ストローク
        DspExcvSpeed.Value = CalcStroke.MesureAveSpeed '計測ジャッキ平均スピード


        '汎用データ表示
        For Each wu In CtlPara.WideUse
            Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
            If dd.FieldName <> "" Then
                dd.Value = PlcIf.EngValue(dd.FieldName)
            Else
                dd.Value = "-------"
            End If
        Next

        '自動方向制御ON／OFF
        DspFlexAuto.BitStatus = CtlPara.AutoDirectionControl



        Dim DspPieceNo As New Dictionary(Of Integer, ucnDspBit)
        For Each c As Control In pnlLosZero.Controls
            If c.Name.Contains("ucnAssemblyPieceNo") Then
                DspPieceNo.Add(Strings.Right(c.Name, 2), c)
            End If
        Next

        ucnLosZeroSts.BitStatus = PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        ucnLosZeroSts.Blink = (LosZeroSts > 0)

        If PlcIf.LosZeroEnable And PlcIf.LosZeroMode Then
            ''組立ピース番号
            For Each c In DspPieceNo
                c.Value.BitStatus = (c.Key <= PlcIf.AssemblyPieceNo)
                c.Value.Blink = (c.Key = PlcIf.AssemblyPieceNo)
            Next


        Else
            For Each c As ucnDspBit In DspPieceNo.Values
                c.BitStatus = False
                c.Blink = False
            Next

        End If
        ''減圧中
        ucnReduceStart.Blink = (LosZeroSts = 1)
        ucnReduceStart.BitStatus = (LosZeroSts = 1)
        ''減圧完了
        ucnReduceFinish.BitStatus = (LosZeroSts = 2)
        ''引戻し中
        ucnPullBackStart.Blink = (LosZeroSts = 3)
        ucnPullBackStart.BitStatus = (LosZeroSts = 3)
        ''引戻完了
        ucnPullBackFinish.BitStatus = (LosZeroSts = 4)
        ''組立中
        ucnAssemblyStart.Blink = (LosZeroSts = 5)
        ucnAssemblyStart.BitStatus = (LosZeroSts = 5)
        ''組立完了
        ucnAssemblyFinish.BitStatus = (LosZeroSts >= 6)

        'If ucnReduceFinish.Blink Then
        '    ucnReduceFinish.FieldName = "減圧中"
        'Else
        '    ucnReduceFinish.FieldName = "減圧完了"
        'End If



        'If ucnPullBackFinish.Blink Then
        '    ucnPullBackFinish.FieldName = "引戻し中"
        'Else
        '    ucnPullBackFinish.FieldName = "引戻完了"
        'End If


        'If ucnAssemblyFinish.Blink Then
        '    ucnAssemblyFinish.FieldName = "組立中"
        'Else
        '    ucnAssemblyFinish.FieldName = "組立完了"
        'End If

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


        ''経過時間の表示
        DspExcationElapsedTime.Value = ElapsedTime.ExcavationTime
        DspLosZeroElapsedTime.Value = ElapsedTime.LozeroExcavationTime
        DspWatingElapsedTime.Value = ElapsedTime.WatingTime
        DspInterruptTime.Value = ElapsedTime.InterruptTime
        'DspIterruptTime.Value == ElapsedTime.InterruptTime
        'DspCycleTime.Value = ElapsedTime.CycleTime
        ''モニターモードの時はデータベースより
        'If InitPara.MonitorMode Then
        lblNowDate.Text = PlcIf.DataGetTime.ToString("yyyy/MM/dd HH:mm:ss")
        'Else
        '    lblNowDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'End If

        ''同時施工実績表示
        If InitPara.LosZeroEquip Then
            DspAveAsmPiece.Value = LosZeroPerform.AveAsmPiece
            DspSumAsmPiece.Value = LosZeroPerform.SumAsmPiece
            DspAveLoszeroTime.Value = LosZeroPerform.AveLoszeroTime
            DspSumLoszeroTime.Value = LosZeroPerform.SumLoszeroTime
        End If

        ''TODO:線形データ画面更新　LineDistanceChage に記述したい
        Call LineDataUpdate()

        EventlogUpdate()









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

            'DspHorFChangePoint.Value = .HorZendoKijun.平面ゾーン内残距離
            'DspHorRChangePoint.Value = .HorZendoKijun.平面ゾーン掘進距離
            'DspTargetDirection.Value = .平面基準方位
            DspHorDev.Value = .平面偏角

            'ucnHorLineChart.PlanNumData = .平面計画方位



            '縦断線形データ
            If .VerZendoKijun.縦断線形 = 1 Then
                DspVerLine.Value = "-------"
            Else
                DspVerLine.Value = .VerZendoKijun.縦断半径

            End If
            'DspVerFChangePoint.Value = .VerZendoKijun.縦断ゾーン内残距離
            'DspVerRChangePoint.Value = .VerZendoKijun.縦断ゾーン内掘進距離
            'DspTargetPitching.Value = .縦断基準方位
            DspVerDev.Value = .縦断偏角

            'ucnVerLineChart.PlanNumData = .縦断計画方位

            'ucnDspDevImg.HorDev = .平面偏角
            'ucnDspDevImg.VerDev = .縦断偏角




        End With


        '姿勢角トレンドトレンド　データセット
        'ucnHorLineChart.PlanData = DirectionChartD.HorPData
        'ucnHorLineChart.ExecData = DirectionChartD.HorRData
        'ucnHorLineChart.CorrectData = CtlPara.水平入力補正値
        'ucnHorLineChart.TargetData = DspTargetDirection.Value
        'ucnHorLineChart.RealData = DspDirection.Value


        'ucnVerLineChart.PlanData = DirectionChartD.VerPData
        'ucnVerLineChart.ExecData = DirectionChartD.VerRData
        'ucnVerLineChart.CorrectData = CtlPara.鉛直入力補正値
        'ucnVerLineChart.TargetData = DspTargetPitching.Value
        'ucnVerLineChart.RealData = DspPitching.Value

        'DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.軌道中心方位角) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
        'DspRingTargetDir.Value = Hoko2Hoi(RefernceDirection.RingTarget.平面計画方位) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
    End Sub

    ''' <summary>
    ''' 掘進開始日時表示
    ''' </summary>
    Public Sub DspExcavStartDay(t As Date)
        DspExcavStartDate.Value = t.ToString("yyyy/MM/dd")
        DspExcavStartTime.Value = t.ToString("HH:mm:ss")
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

        If PlcIf.AnalogTag.TagExist("ｾｸﾞﾒﾝﾄの種類信号") And InitPara.ServerMode Then
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

                If PlcIf.AnalogTag.TagExist("甲乙表示用信号") And InitPara.ServerMode Then
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
                If InitPara.ServerMode Then
                    PlcIf.AnalogPlcWrite(pca.AssemblyOrder & "ピースセグメント位置角度", angle)
                End If
            End If

            'End If


        Next
        UcnJackDsp.AssemblyPieceNo = PlcIf.AssemblyPieceNo

        UcnJackDsp.SegmentPieceDsp() 'ｾｸﾞﾒﾝﾄピース表示



    End Sub
End Class