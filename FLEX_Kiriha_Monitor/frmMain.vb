Imports FLEX.NET
Public Class frmMain









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

    Private Sub tmrDataDsp_Tick(sender As Object, e As EventArgs) Handles tmrDataDsp.Tick



        'PLCからの読込表示



        DspRingNo.Text = PlcIf.RingNo 'リングNo

        'DspDirection.Value = PlcIf.Gyro              '方位角
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


        'DspMachineRolling.Value = PlcIf.MashineRolling  'マシンローリング

        'DspBottomClearance.Value = PlcIf.botomClearance
        'DspTopClearance.Value = PlcIf.topClearance
        'DspRightClearance.Value = PlcIf.rightClearance
        'DspLeftClearance.Value = PlcIf.leftClearance

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

        '力点座標数値表示
        UcnJackDsp.FlexPointX = PlcIf.PointX
        UcnJackDsp.FlexPointY = PlcIf.PointY

        UcnJackDsp.FlexPointR = PlcIf.操作強
        UcnJackDsp.FlexPointSeater = PlcIf.操作角


        ''掘進モード／セグメントモードの表示
        'lblMachineMode.Text = If(PlcIf.ExcavMode, "掘進", "セグメント") & "モード"
        'lblMachineMode.BackColor = If(PlcIf.ExcavMode, Color.Magenta, Color.Aqua)
        ''End With
        'If PlcIf.assembleSegFinish Then
        '    lblMachineMode.BackColor = Color.Yellow
        'End If


        UcnJackDsp.MakeBmp()


        DspAveStartStroke.Value = CtlPara.StartAveStroke '平均開始ストローク
        DspAveStroke.Value = CalcStroke.CalcAveLogicalStroke '計算平均ストローク
        DspExcvSpeed.Value = CalcStroke.MesureAveSpeed '計測ジャッキ平均スピード

        'DspLRStrokeDiff.Value = CalcStroke.LeftCalcStroke - CalcStroke.RightCalcStroke '左右ｽﾄﾛｰｸ差
        'If CtlPara.RightStrokeDiff Then
        '    DspLRStrokeDiff.Value = -DspLRStrokeDiff.Value
        'End If
        'DspLRStrokeDiff.FieldName = $"ｽﾄﾛｰｸ差(mm){If(CtlPara.RightStrokeDiff, "右", "左")}勝"

        ''汎用データ表示
        'For Each wu In CtlPara.WideUse
        '    Dim dd As ucnDspData = Me.Controls("DspWideUse" & wu.Key)
        '    If dd.FieldName <> "" Then
        '        dd.Value = PlcIf.EngValue(dd.FieldName)
        '    Else
        '        dd.Value = "-------"
        '    End If
        'Next

        With CtlPara
            '自動方向制御ON／OFF
            UcnJackDsp.FlexAutoManual = .AutoDirectionControl
            DspFlexAuto.BitStatus = .AutoDirectionControl
        End With

        ''圧力調整用フラグ
        'DspJackPress.Blink = JackMvAuto.圧力超
        'DspMoment.Blink = JackMvAuto.モーメント上限超
        'UcnJackDsp.PointRLimitOver = JackMvAuto.片押しR上限超

        'DspHorDev.Blink = RefernceDirection.HorDevLimitOver
        'DspVerDev.Blink = RefernceDirection.VerDevLimitOver




        ''チャートの更新
        'If PlcIf.ExcaStatus = cKussin Then
        '    'ﾓｰﾒﾝﾄ
        '    ucnHorMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentX)
        '    ucnVerMomentChart.ChartDataAdd(PlcIf.RealStroke, CulcMoment.MomentY)
        '    ucnHorDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.平面偏角)
        '    ucnVerDevChart.ChartDataAdd(PlcIf.RealStroke, RefernceDirection.縦断偏角)
        'End If

        ''同時施工用
        'ucnLosZeroMode.BitStatus = PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        'ucnLosZeroMode.Blink = Not PlcIf.LosZeroEnable And PlcIf.LosZeroMode
        ''対抗ジャッキ
        'UcnOpposeJackControl.BitStatus = CtlPara.LosZeroOpposeControl
        'UcnOpposeJackSelect.BitStatus = CtlPara.LosZeroOpposeJack

        ''同時施工ピース確認ボタンブリンク
        'btnPieceConfirm.Enabled = ucnLosZeroMode.Blink
        'If btnPieceConfirm.Enabled Then
        '    btnPieceConfirm.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
        'End If
        ''同時施工キャンセルボタン有効／無効
        'btnLossZerooCancel.Enabled = ucnLosZeroMode.BitStatus

        ''組立ピース番号
        'If ucnLosZeroMode.BitStatus Then
        '    ucnAssemblyPieceNo.FieldName = PlcIf.AssemblyPieceNo & "ピース目"
        'Else
        '    ucnAssemblyPieceNo.FieldName = "-------"
        'End If

        ''減圧中
        'ucnReduceFinish.Blink = (LosZeroSts = 1)
        ''減圧完了
        'ucnReduceFinish.BitStatus = (LosZeroSts >= 2)
        ''引戻し中
        'ucnPullBackFinish.Blink = (LosZeroSts = 3)
        ''引戻完了
        'ucnPullBackFinish.BitStatus = (LosZeroSts >= 4)
        ''組立中
        'ucnAssemblyFinish.Blink = (LosZeroSts = 5)
        ''組立完了
        'ucnAssemblyFinish.BitStatus = (LosZeroSts >= 6)

        'If ucnReduceFinish.Blink Then
        '    ucnReduceFinish.FieldName = "減圧中"
        'Else
        '    ucnReduceFinish.FieldName = "減圧完了"
        'End If

        ''減圧中から組立中は次ピース確認ボタン無効
        'If (LosZeroSts >= 1 And LosZeroSts <= 5) Or Not PlcIf.LosZeroMode Then
        '    btnLoszeroContinu.Enabled = False
        'End If
        'If btnLoszeroContinu.Enabled Then
        '    btnLoszeroContinu.ForeColor = IIf(BlinkFlg, Color.Black, Color.Red)
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

        ''点滅用フラグ
        'BlinkFlg = Not BlinkFlg
        ''ロスゼロ工程表示
        'For Each cControl As Control In pnlLosZero.Controls
        '    If TypeOf cControl Is ucnDspBit Then
        '        Dim u As ucnDspBit = DirectCast(cControl, ucnDspBit)
        '        If u.Blink Then
        '            u.BitStatus = BlinkFlg
        '        End If
        '    End If
        'Next

        'DspSegmentW.Value = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
        'DspTargetNetStroke.Value = If(CtlPara.TargetNetStroke = 0, DspSegmentW.Value, CtlPara.TargetNetStroke)


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

        'EventlogUpdate()









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