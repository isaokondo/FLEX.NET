Public Class frmCorrectionValueManagement




    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' データ更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click, btnCLose.Click

        CtlPara.測量ポイントリング番号 = ConfirmRingNo.Value
        '起点入力の場合は、起点から発進までの距離を減算
        CtlPara.測量ポイント総距離 =
                TipDistance.Value - IIf(InitPara.DistanceInputMethod, RefernceDirection.toStartDistance, 0)
        'PuchUpStroke.Value=.
        CtlPara.水平入力補正値 = HorCorrentionValue.Value
        CtlPara.鉛直入力補正値 = VerCorrentionValue.Value
        CtlPara.HorTargerStrokeDev=HorLastTargetVal.Value
        '押し上がりストロークの更新
        SegAsmblyData.RingLastStrokeUpdate(ConfirmRingNo.Value, PuchUpStroke.Value)

        DspUpdate()

        If sender Is btnCLose Then
            Me.Close()
        End If

    End Sub

    Private Sub frmCorrectionValueManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        NowRing.Value = PlcIf.RingNo
        ConfirmRingNo.Value = CtlPara.測量ポイントリング番号
        TipDistance.Value = CtlPara.測量ポイント総距離
        '起点入力
        If InitPara.DistanceInputMethod Then
            TipDistance.FieldName = TipDistance.FieldName.Replace("発進", "起点") '文字変更
            TipDistance.Value += RefernceDirection.toStartDistance '起点から発進までの距離加算
        End If

        HorCorrentionValue.Value = CtlPara.水平入力補正値
        VerCorrentionValue.Value = CtlPara.鉛直入力補正値

        DspUpdate()
        'ストローク差制御有りのバージョン
        If InitPara.StrokeDiffControlEnable Then
            HorLastTargetVal.Visible = True
            VerLastTargetVal.Visible = True
            Label3.Visible = True
            If CtlPara.horAngleDetection = StrokeDiffDetciotn Then
                HorLastTargetVal.Unit = "mm"
                HorLastTargetVal.FieldName = "目標ストローク差"
                HorLastTargetVal.DecimalPlaces = 0
                HorLastTargetVal.Value = CtlPara.HorTargerStrokeDev
            End If
            If CtlPara.horAngleDetection = GyroDetciotn Then
                HorLastTargetVal.Unit = "deg"
                HorLastTargetVal.FieldName = "目標方位角"
                HorLastTargetVal.DecimalPlaces = 2
            End If



            'ボタン位置変更
            For Each btn As Control In Me.Controls
                    If TypeOf btn Is Button Then
                        btn.Top += 120

                    End If
                Next

            End If






    End Sub

    ''' <summary>
    ''' 測量関係画面更新
    ''' </summary>
    Private Sub DspUpdate()
        Dim o As Control

        For Each o In Me.Controls
            If o.GetType Is GetType(ucnSpredCompnent) Then
                Dim p As ucnSpredCompnent = DirectCast(o, ucnSpredCompnent)

                '水平のデータ
                With RefernceDirection

                    If p.Name.IndexOf("PlanCommon") >= 0 Then
                        Select Case p.FieldName
                            Case "現在の先端距離（発進から）"
                                p.Value = .Distance.掘進総距離
                            Case "確認リングの先端総距離"
                                p.Value = .Distance.測量ポイント総距離
                            Case "セグメント幅の追加距離"
                                p.Value = .Distance.SegWdAddDist
                            Case "押し上がりストロークの差"
                                p.Value = .Distance.LastStrokeDiff

                        End Select
                    End If


                    If p.Name.IndexOf("HorPlan") >= 0 Then

                        Select Case p.FieldName
                            Case "旋回中心"
                                p.Value = .平面旋回中心
                            Case "発進から旋回中心までの距離"
                                p.Value = .HorZendoKijun.掘進累積距離 - .toStartDistance
                            Case "起点から旋回中心までの距離"
                                p.Value = .HorZendoKijun.掘進累積距離
                            Case "ゾーン"
                                p.Value = .HorZendoKijun.平面ゾーン番号
                            Case "線形(1:直線　２：単曲線　3:緩和)"
                                p.Value = .HorZendoKijun.平面線形
                            Case "曲率半径"
                                p.Value = .HorZendoKijun.軌道中心平面半径
                            Case "前方変化点距離"
                                p.Value = .HorZendoKijun.平面ゾーン内残距離
                            Case "後方変化点距離"
                                p.Value = .HorZendoKijun.平面ゾーン掘進距離
                            Case "X座標"
                                p.Value = .HorZendoKijun.軌道中心X座標
                            Case "Y座標"
                                p.Value = .HorZendoKijun.軌道中心Y座標
                            Case "シフト"
                                p.Value = .HorZendoKijun.平面シフト量 * 1000 * HorPlan.座標系
                            Case "シフト追加角"
                                p.Value = .HorZendoKijun.平面シフト追加角
                            Case "水平中折角"
                                p.Value = .平面中折角度 * HorPlan.座標系
                                'todo:演算はクラス内で処理
                            Case "前胴部の方位角"
                                p.Value = Hoko2Hoi(.HorZendoKijun.軌道中心方位角 + HorPlan.X軸方位角)
                            Case "後胴部の方位角"
                                p.Value = Hoko2Hoi(.HorKodoKijun.軌道中心方位角 + HorPlan.X軸方位角)
                            Case "姿勢角管理値"
                                p.Value = .平面基準方位
                            Case "現リング目標方向角"
                                'p.Value = Hoko2Hoi(RefernceDirection.RingTarget.軌道中心方位角) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
                                p.Value = Hoko2Hoi(RefernceDirection.RingTarget.平面計画方位) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
                            Case "次リング目標方向角"
                                p.Value = Hoko2Hoi(RefernceDirection.NextRingTarget.平面計画方位) + CtlPara.水平入力補正値 + HorPlan.X軸方位角
                        End Select
                    End If


                    '鉛直のデータ
                    If p.Name.IndexOf("VerPlan") >= 0 Then

                        Select Case p.FieldName

                            Case "旋回中心"
                                p.Value = .縦断旋回中心
                            Case "発進から旋回中心までの距離"
                                p.Value = .VerZendoKijun.掘進累積距離 - .toStartDistance
                            Case "起点から旋回中心までの距離"
                                p.Value = .VerZendoKijun.掘進累積距離
                            Case "ゾーン"
                                p.Value = .VerZendoKijun.縦断ゾーン番号
                            Case "線形(1:直線　２：単曲線)"
                                p.Value = .VerZendoKijun.縦断線形
                            Case "曲率半径"
                                p.Value = .VerZendoKijun.縦断半径
                            Case "前方変化点距離"
                                p.Value = .VerZendoKijun.縦断ゾーン内残距離
                            Case "後方変化点距離"
                                p.Value = .VerZendoKijun.縦断ゾーン内掘進距離
                            Case "Z座標"
                                p.Value = .VerZendoKijun.Z座標
                            Case "シフト"
                                p.Value = .VerZendoKijun.縦断シフト量 * 1000
                            Case "シフト追加角"
                                p.Value = .VerZendoKijun.縦断シフト追加角
                            Case "鉛直中折角"
                                p.Value = .縦断中折角度
                                'todo:演算はクラス内で処理
                            Case "前胴部の鉛直角"
                                p.Value = .VerZendoKijun.鉛直角
                            Case "後胴部の鉛直角"
                                p.Value = .VerKodoKijun.鉛直角
                            Case "姿勢角管理値"
                                p.Value = .縦断基準方位
                        End Select
                    End If

                End With
            End If
        Next

    End Sub
    ''' <summary>
    ''' 平均ストローク
    ''' </summary>
    Private AveStroke As Integer

    Private Sub tmrLineUpdate_Tick(sender As Object, e As EventArgs) Handles tmrLineUpdate.Tick
        '常時更新するように変更

        'If PlcIf.ExcaStatus = cKussin Then

        DspUpdate()
        'End If

    End Sub

    Private Sub ConfirmRingNo_ValueChanged(sender As Object, e As EventArgs) Handles ConfirmRingNo.ValueChanged
        If SegAsmblyData.RingLastStroke.ContainsKey(ConfirmRingNo.Value) Then
            PuchUpStroke.Value = SegAsmblyData.RingLastStroke(ConfirmRingNo.Value)
        End If
    End Sub
End Class