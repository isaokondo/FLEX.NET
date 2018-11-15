Imports FLEX.NET
Imports System.Math
Imports System.Runtime.CompilerServices

Module mdlFlexMonitor

    Public InitPara As clsInitParameter '初期値パラメータ
    Public SegAsmblyData As clsSegmentAssembly ''セグメント組立データ

    Public HorPlan As clsHorPanData '平面掘進計画線
    Public VerPlan As clsVerPlanData '縦断掘進計画線


    Public WithEvents CtlPara As clsControlParameter  '制御パラメータ

    '''' <summary>
    '''' シールドマシン諸元
    '''' </summary>
    Public MachineSpec As clsMachinSpec

    ''Public SegAsmblyData As clsSegmentAssembly ''セグメント組立データ
    ''' <summary>
    ''' 電光掲示板表示
    ''' </summary>
    Public WithEvents LedLiner As clsLedLiner

    ''Public CulcMoment As clsCulMoment ''モーメント、推力の演算

    ''Public WithEvents JackMvAuto As clsCulJackMv ''ジャッキ操作量の演算
    '''' <summary>
    '''' 推力分担率の演算
    '''' </summary>
    'Public DivCul As clsThrustDiv ''
    ''' <summary>
    ''' 基準方位演算
    ''' </summary>
    Public RefernceDirection As clsCulKijun

    ''PLCインターフェース
    Public WithEvents PlcIf As clsPlcIf
    '''' <summary>
    '''' ジャッキ手動操作出力
    '''' </summary>
    ''Public WithEvents JackManual As clsJkManualOut
    Public CulcMoment As clsCulMoment ''モーメント、推力の演算

    '''' <summary>
    '''' 減圧処理
    '''' </summary>
    'Public WithEvents Reduce As clsReducePress
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
    ''' テーブル更新日付取得
    ''' </summary>
    Public WithEvents TableUpdateConfirm As clsTableUpdateConfirm
    ''' <summary>
    ''' 同時施工実績　算出
    ''' </summary>
    Public LosZeroPerform As New clsLosZeroPerform

    ''' <summary>
    ''' 減圧可能ストロークに達した
    ''' </summary>
    Private ReduceEnableStrokeReachFlg As Boolean


    ''' <summary>
    ''' 圧力指令値のﾀﾞｲﾚｸﾄ出力(全開）
    ''' </summary>
    Public Const cFillPower As Short = &HAAS
    ''' <summary>
    ''' PID演算開始
    ''' </summary>
    Public Const cPIDOut As Short = &HFFS ''
    Public Const cIgnoreOut As Short = &H22S ''待機中につき演算無視

    ''' <summary>
    ''' 減圧弁トラッキング 01.09.20  追加
    ''' </summary>
    Public Const cTracking As Short = &H44S ''
    ''' <summary>
    ''' ダイレクト指令制御
    ''' </summary>
    Public Const cDirect As Short = &H33S

    ''' <summary>
    ''' 減圧弁特性取得モード 増加　ダイレクト制御時のパラメータを取得
    ''' </summary>
    Public Const cReducePropertyGetAdd As Short = &H60S
    ''' <summary>
    ''' 減圧弁特性取得モード　減少　ダイレクト制御時のパラメータを取得
    ''' </summary>
    Public Const cReducePropertyGetSub As Short = &H61S


    Public Const c全押しスタート As Short = 0
    Public Const c前回値保持 As Short = 1
    Public Const c減圧前 As Short = 2


    ''掘進ステータス定数
    Public Const cTaiki As Short = 1 ''待機中
    Public Const cKussin As Short = 2 ''掘進中
    Public Const cChudan As Short = 3 ''中断中

    ''' <summary>
    ''' 文字列の中から数値を取得
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    Public Function GetNum(st As String) As Short
        Return Val(Array.FindAll(st.ToString.ToCharArray, AddressOf IsNumeric))
    End Function
    ''' <summary>
    ''' 度をラジアンに変換
    ''' </summary>
    ''' <param name="Deg"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToRad(ByVal Deg As Object) As Double
        If IsNumeric(Deg) Then
            Return Deg * PI / 180
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' 左回りを右回りに変換し、値を０～３６０に調整
    ''' </summary>
    ''' <param name="Hoko"></param>
    ''' <returns></returns>
    Function Hoko2Hoi(ByRef Hoko As Double) As Double
        ''左回り角度±１８０度を方位角に変換
        '   '01/06/28 追加
        '   Hoko = Lim180(Hoko)
        '   Hoko2Hoi = -Hoko
        '   If Hoko2Hoi < 0 Then
        '       Hoko2Hoi = Hoko2Hoi + 360
        '   End If
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        '左回りを右回りに変換し、値を０～３６０に調整
        Hoko2Hoi = -Hoko
        Do While Hoko2Hoi < 0 Or Hoko2Hoi > 360
            If Hoko2Hoi < 0 Then
                Return Hoko2Hoi + 360
            End If
            If Hoko2Hoi > 360 Then
                Return Hoko2Hoi - 360
            End If
        Loop
    End Function
    ''' <summary>
    ''' 方位角（右回り０～３６０）を左回り角度±１８０度に変換
    ''' </summary>
    ''' <param name="Hoi"></param>
    ''' <returns></returns>
    Public Function Hoi2Hoko(ByVal Hoi As Double) As Double
        '方位角（右回り０～３６０）を左回り角度±１８０度に変換

        '   Hoi2Hoko = 360 - Hoi
        '   Hoi2Hoko = Lim180(Hoi2Hoko)
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Hoi2Hoko = 360 - Hoi
        Do While Hoi2Hoko < 0 Or Hoi2Hoko > 360
            If Hoi2Hoko < 0 Then
                Hoi2Hoko = Hoi2Hoko + 360
            End If
            If Hoi2Hoko > 360 Then
                Hoi2Hoko = Hoi2Hoko - 360
            End If
        Loop

    End Function
    ''' <summary>
    ''' ０～３６０度の角度を同回りの±１８０度に変換
    ''' </summary>
    ''' <param name="Kakudo"></param>
    ''' <returns></returns>
    Public Function Lim180(ByVal Kakudo As Double) As Double
        '０～３６０度の角度を同回りの±１８０度に変換

        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Do While Kakudo > 180 Or Kakudo < -180
            If Kakudo > 180 Then
                Return Kakudo - 360
            End If
            If Kakudo < -180 Then
                Return 360 + Kakudo
            End If
        Loop
        Return Kakudo
        'Lim180 = Kakudo
        'Exit Function

    End Function

    ''' <summary>
    ''' 限りなき小さい値はゼロにする
    ''' </summary>
    ''' <param name="vData"></param>
    ''' <returns>実数判定用幅ΔCの範囲内の値の時は真</returns>
    Public Function fnNearZero(ByVal vData As Double) As Boolean
        Const cDeltaC As Double = 0.0001
        Return vData >= -cDeltaC And vData <= cDeltaC
        'If vData >= -cDeltaC And vData <= cDeltaC Then
        '    fnNearZero = True
        'Else
        '    fnNearZero = False
        'End If
    End Function



    ''' <summary>
    ''' ディグリーをパーミリへ変換
    ''' </summary>
    ''' <param name="dblDeg"></param>
    ''' <returns></returns>
    Public Function DegToPermili(ByRef dblDeg As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :
        '
        ' 引数      :
        '
        ' 備考      :02/09/11 追加

        Return Tan(dblDeg * Math.PI / 180) * 1000


    End Function

    ''' <summary>
    ''' パーミリをディグリーへ変換
    ''' </summary>
    ''' <param name="dblPermili"></param>
    ''' <returns></returns>
    Public Function PermiliToDeg(ByRef dblPermili As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :パーミリをディグリーへ変換
        '
        ' 引数      :
        '
        ' 備考      :02/10/08 追加

        Return Atan(dblPermili / 1000) / (PI / 180)


    End Function



    ''' <summary>
    ''' 文字列の数値はそのまま、それ以外は０の文字列を返す
    ''' </summary>
    ''' <param name="tmp"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToNum(ByVal tmp As String) As Double
        If IsNumeric(tmp) Then
            Return tmp.ToString
        Else
            Return 0
        End If

    End Function


    ''' <summary>
    ''' リストをコンマ区切りの文字列に
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    Public Function ToCommaDelmit(st As List(Of Short)) As String
        If st.Count <> 0 Then
            Return String.Join(",", st)
        Else
            Return ""
        End If

    End Function

    ''' <summary>
    ''' 文字列から数値を取り出す
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToGetNum(st As String) As Short
        Return Val(Array.FindAll(st.ToString.ToCharArray, AddressOf IsNumeric))
    End Function


    ''' <summary>
    ''' 計測ストロークの変化時
    ''' ステータス変化時
    ''' </summary>
    Public Sub PlcIf_MesureStrokeChange() Handles PlcIf.MesureStrokeChange, PlcIf.ExcavationStatusChange
        CalcStroke.MesureJackStroke = PlcIf.MesureJackStroke
        CalcStroke.MesureJackSpeed = PlcIf.MesureJackSpeed
        CalcStroke.Calc2() '計算ストローク演算
        If InitPara.ServerMode Then
            PlcIf.AnalogPlcWrite("掘進ストローク", CalcStroke.CalcAveLogicalStroke)
            PlcIf.AnalogPlcWrite("掘進スピード", CalcStroke.MesureAveSpeed)
            PlcIf.AnalogPlcWrite("平均ジャッキストローク", CalcStroke.MesureCalcAveJackStroke)

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
        'TODO:最大テーパーの算出
        CalcStroke.SegmentTaperValue = SegAsmblyData.TypeData(PlcIf.RingNo).ETTaper
        '最大テーパー位置
        CalcStroke.SegmentMaxTaperLoc = SegAsmblyData.TypeData(PlcIf.RingNo).TaperAngle
        'セグメント幅
        CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000

        '待機中から掘進or 中断中-----------------------------------------------------------
        If PreStatus = cTaiki Then
            My.Forms.frmMain.DspExcavStartDay(DateTime.Now)
            ElapsedTime.Reset() '掘進時間計算開始
            CalcStroke.ExecavStart() '計算ストローク組立完了ジャッキクリア
            '掘進開始時のストローク取り込み
            CtlPara.StartJackStroke = New Dictionary(Of Short, Integer)(PlcIf.MesureJackStroke)
            LedLiner.SendMsg = $"{PlcIf.RingNo}リング、掘進開始しました"
        End If
        If PreStatus = cChudan And NowStatus = cKussin Then
            ElapsedTime.ExcavationStart()
            If LosZeroSts >= 1 Then ElapsedTime.LosZeroStart()



        End If
        '中断-----------------------------------------------------------
        If NowStatus = cChudan Then
            'JackManual.ManualOn = False
            ElapsedTime.ExcavationStop()
            LedLiner.SendMsg = $"掘進停止しました"

        End If

        '待機中-----------------------------------------------------------
        If NowStatus = cTaiki Then
            'ロスゼロの実績算出
            LosZeroPerform.Caluc()
            LosZeroSts = 0
            PlcIf.AssemblyPieceNo = 1 '組立ピース　初期化
            PlcIf.LosZeroSts_FLEX = 0

            '掘進開始時のストローク取り込み
            CtlPara.StartJackStroke = New Dictionary(Of Short, Integer)(PlcIf.MesureJackStroke)
            CalcStroke.ExecavStart() '計算ストローク組立完了ジャッキクリア

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
                        LosZeroSts = 1
                        ElapsedTime.LosZeroStart()  '同時施工時間算出

                    Case 2
                        '引き戻しジャッキ

                        LosZeroSts = 3
                        LedLiner.SendMsg = $"{PlcIf.AssemblyPieceNo}ピース目、同時施工　ジャッキ引戻し中です"

                    Case 3
                        LosZeroSts = 4
                        LedLiner.SendMsg = $"{PlcIf.AssemblyPieceNo}ピース目、同時施工　ジャッキ引戻し完了です"

                    Case 4
                        LosZeroSts = 5
                        LedLiner.SendMsg = $"{PlcIf.AssemblyPieceNo}ピース目、同時施工　セグメント組立中です"

                    Case 6
                        LosZeroSts = 5

                    Case 5, 7
                        LedLiner.SendMsg = $"{PlcIf.AssemblyPieceNo}ピース目、同時施工　セグメント組立完了しました"
                        LosZeroSts = 6
                        '計算ストローク用に組立ジャッキの設定
                        CalcStroke.asembleFinishedJack = .ClosetJack '押込みジャッキ
                        CalcStroke.asembleFinishedJack = .AddClosetJack '追加押込ジャッキ
                        CalcStroke.SetOffsetStroke() 'オフセットストロークの算出

                End Select
            End With

        Else
            'FLEXからのステータス
            Select Case NowSts
                Case 1  '減圧開始
                    LosZeroSts = 1
                    LedLiner.SendMsg = $"{PlcIf.AssemblyPieceNo}ピース目、同時施工　減圧中です"
                    '計算ストローク用セグメント幅等設定
                    CalcStroke.SegnebtCenterWidth = SegAsmblyData.TypeData(PlcIf.RingNo).CenterWidth * 1000
                    'todo:テーパー量等？

                Case 2
                    LosZeroSts = 2
            End Select

        End If

        My.Forms.frmMain.SegmentDataDsp() 'セグメント組立情報表示

    End Sub

    ''' <summary>
    ''' マシン先端距離の変化時の処理
    ''' </summary>
    Private Sub LineDistanceChage() Handles PlcIf.LineDistanceChage, CtlPara.ReferChnge, TableUpdateConfirm.SegmentAsmChange

        RefernceDirection.sbCulKijun()

        My.Forms.frmMain.LineDataUpdate()

        'If CtlPara.AutoDirectionControl Then
        '    JackMvAuto.水平偏差角 = RefernceDirection.平面偏角
        '    JackMvAuto.鉛直偏差角 = RefernceDirection.縦断偏角
        'End If






    End Sub

    Private Sub LedLiner_ErrorOccur(msg As String) Handles LedLiner.ErrorOccur

    End Sub
End Module
