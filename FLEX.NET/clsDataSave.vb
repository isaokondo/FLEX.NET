'Option Strict On
Option Explicit On
Friend Class clsDataSave
    ' @(h) clsDataSave.cls                ver 1.0 ( '01.02.15 近藤　勲 )
    ' @(h) clsDataSave.cls                ver 2.0 ( '2016.02.03 近藤　勲 ) MYSQL対応

    ' @(s) データ保存するクラス
    '
    '

    Inherits clsDataBase

    Private ColumnList As New List(Of String)

    Public Sub New()
        'コラム名のリストを取得
        Dim recFldData As DataTable = GetDtfmSQL("show columns from  flex掘削データ ")

        For Each t As DataRow In recFldData.Rows
            ColumnList.Add(t.Item("Field"))
        Next


    End Sub
    ''' <summary>
    ''' FLEX掘削データ作成
    ''' </summary>
    Public Sub Save()
        'Dim recDataSave As Odbc.OdbcDataReader =
        ExecuteSqlCmd($"REPLACE INTO FLEX掘削データ VALUES({getSqlData()})")
        'recDataSave.Close()
    End Sub

    'Private Class DataMk
    '    Private _ColumnList As List(Of String)


    '    Public Sub New(clst As List(Of String))
    '        _ColumnList = clst
    '        ReDim _SqlData(_ColumnList.Count - 1)
    '    End Sub

    '    Public Property SqlData As String()


    '    Public Sub PutData(data As String)

    '    End Sub
    '    Public Sub PutData(data As Single)

    '    End Sub



    'End Class




    ''' <summary>
    ''' SQL作成
    ''' </summary>
    ''' <returns></returns>
    Private Function getSqlData() As String

        Dim Data(ColumnList.Count - 1) As String

        Try
            'PLCからの読込

            Data(ColumnList.IndexOf("リング番号")) = PlcIf.RingNo.ToString
            Data(ColumnList.IndexOf("掘進ストローク")) = PlcIf.RealStroke.ToString
            Data(ColumnList.IndexOf("時間")) = DateTime.Now.ToString

            For i As Short = 0 To InitPara.NumberGroup - 1
                Data(ColumnList.IndexOf("グループ" & (i + 1) & "圧力")) = PlcIf.GroupPv(i).ToString("F1")
                Data(ColumnList.IndexOf("グループ" & (i + 1) & "MV")) = PlcIf.GroupMV(i).ToString("F1")
                Data(ColumnList.IndexOf("グループ" & (i + 1) & "制御フラグ")) = PlcIf.GroupFlg(i).ToString
                Data(ColumnList.IndexOf("グループ" & (i + 1) & "SV")) = PlcIf.GroupSV(i).ToString("F1")
            Next

            For i As Short = 0 To InitPara.NumberJack - 1
                Data(ColumnList.IndexOf("ジャッキステータス" & (i + 1))) = PlcIf.JackStatus(i)
            Next

            Data(ColumnList.IndexOf("シールドジャッキ圧力")) = PlcIf.JkPress.ToString
            Data(ColumnList.IndexOf("ジャイロ方位角")) = PlcIf.Gyro.ToString
            Data(ColumnList.IndexOf("ジャイロピッチング")) = PlcIf.GyroPitching.ToString
            Data(ColumnList.IndexOf("ジャイロローリング")) = PlcIf.Rolling.ToString
            Data(ColumnList.IndexOf("マシンピッチング")) = PlcIf.MachinePitching.ToString
            Data(ColumnList.IndexOf("マシン前胴ローリング")) = PlcIf.MashineRolling.ToString
            'TODO:未割り当て
            'Data(ColumnList.IndexOf("マシン後胴ローリング")) = .RealStroke.ToString
            Data(ColumnList.IndexOf("中折左右角")) = PlcIf.NakaoreLR.ToString
            Data(ColumnList.IndexOf("中折上下角")) = PlcIf.NakaoreTB.ToString
            Data(ColumnList.IndexOf("左ジャッキストローク")) = PlcIf.LeftStroke.ToString
            Data(ColumnList.IndexOf("右ジャッキストローク")) = PlcIf.RightStroke.ToString
            Data(ColumnList.IndexOf("左ジャッキ速度")) = PlcIf.LeftSpeed.ToString
            Data(ColumnList.IndexOf("右ジャッキ速度")) = PlcIf.RightSpeed.ToString
            If InitPara.topStrokeEnable Then
                Data(ColumnList.IndexOf("上ジャッキストローク")) = PlcIf.TopStroke.ToString
                Data(ColumnList.IndexOf("上ジャッキ速度")) = PlcIf.TopSpeed.ToString
            End If
            If InitPara.bottomStrokeEnable Then
                    Data(ColumnList.IndexOf("下ジャッキストローク")) = PlcIf.BotomStroke.ToString
                    Data(ColumnList.IndexOf("下ジャッキ速度")) = PlcIf.BotomSpeed.ToString
                End If
            Data(ColumnList.IndexOf("コピー角度1")) = PlcIf.CopyAngle1.ToString
            Data(ColumnList.IndexOf("コピーストローク1")) = PlcIf.CopyStroke1.ToString
            'TODO:未割り当て
            'Data(ColumnList.IndexOf("コピー角度2")) = .RealStroke.ToString
            'Data(ColumnList.IndexOf("コピーストローク2")) = .RealStroke.ToString


            Data(ColumnList.IndexOf("減圧弁制御Ｐ定数")) = PlcIf.感度調整減圧弁制御Ｐ定数
            Data(ColumnList.IndexOf("減圧弁制御Ｉ定数")) = PlcIf.感度調整減圧弁制御Ｉ定数
            'Data(ColumnList.IndexOf("ストローク管理法")) = .ストローク管理法
            'Data(ColumnList.IndexOf("掘進判定ストローク")) = .掘進判定ストローク
            'Data(ColumnList.IndexOf("終了判定ストローク")) = .終了判定ストローク
            Data(ColumnList.IndexOf("終了判定引きストローク")) = PlcIf.終了判定引きストローク
            'Data(ColumnList.IndexOf("終了判定時間")) = .終了判定時間
            'Data(ColumnList.IndexOf("開始判定速度")) = .
            'Data(ColumnList.IndexOf("中断判定速度")) = .中断判定速度

            Data(ColumnList.IndexOf("圧力制御")) = IIf(PlcIf.FlexControlOn, 1, 0)
            Data(ColumnList.IndexOf("ジャイロ異常")) = IIf(PlcIf.GyiroError, 1, 0)
            Data(ColumnList.IndexOf("力点Ｘ")) = PlcIf.PointX.ToString("F3")
            Data(ColumnList.IndexOf("力点Ｙ")) = PlcIf.PointY.ToString("F3")
            Data(ColumnList.IndexOf("片押しγ")) = PlcIf.操作強.ToString("F4")
            Data(ColumnList.IndexOf("方向θ")) = PlcIf.操作角.ToString("F4")

            Data(ColumnList.IndexOf("合成モーメント")) = CulcMoment.MomentR.ToString
            Data(ColumnList.IndexOf("水平モーメント")) = CulcMoment.MomentX.ToString
            Data(ColumnList.IndexOf("鉛直モーメント")) = CulcMoment.MomentY.ToString
            Data(ColumnList.IndexOf("水平偏角")) = RefernceDirection.平面偏角.ToString("F4")
            Data(ColumnList.IndexOf("鉛直偏角")) = RefernceDirection.縦断偏角.ToString("F4")
            Data(ColumnList.IndexOf("推力")) = CulcMoment.Thrust

            With RefernceDirection.HorZendoKijun
                Data(ColumnList.IndexOf("平面旋回中心")) = RefernceDirection.平面旋回中心.ToString("F4")
                Data(ColumnList.IndexOf("平面発進から発旋回中心までの距離")) = (.掘進累積距離 - RefernceDirection.toStartDistance).ToString("F4")
                Data(ColumnList.IndexOf("平面起点から発旋回中心までの距離")) = .掘進累積距離.ToString("F4")
                Data(ColumnList.IndexOf("平面ｿﾞｰﾝ")) = .平面ゾーン番号
                Data(ColumnList.IndexOf("平面線形")) = .平面線形
                Data(ColumnList.IndexOf("平面前方変化点距離")) = .平面ゾーン内残距離.ToString("F4")
                Data(ColumnList.IndexOf("平面後方変化点距離")) = .平面ゾーン掘進距離.ToString("F4")
                Data(ColumnList.IndexOf("平面ｼﾌﾄ量")) = .平面シフト量 * 1000
                Data(ColumnList.IndexOf("平面ｼﾌﾄ追加角")) = .平面シフト追加角
                Data(ColumnList.IndexOf("平面半径（軌道中心）")) = .軌道中心平面半径.ToString("F4")
                Data(ColumnList.IndexOf("方位角（軌道中心）")) = .軌道中心方位角.ToString("F4")
                Data(ColumnList.IndexOf("方位角（構築中心）")) = .構築中心方位角.ToString("F4")
                Data(ColumnList.IndexOf("Ｘ座標（軌道中心）")) = .軌道中心X座標.ToString("F4")
                Data(ColumnList.IndexOf("Ｙ座標（軌道中心）")) = .軌道中心Y座標.ToString("F4")

                Data(ColumnList.IndexOf("Ｘ座標（構築中心）")) = .構築中心X座標.ToString("F4")
                Data(ColumnList.IndexOf("Ｙ座標（構築中心）")) = .構築中心Y座標.ToString("F4")
                Data(ColumnList.IndexOf("前胴方位角")) = Hoko2Hoi(RefernceDirection.HorZendoKijun.軌道中心方位角 + HorPlan.X軸方位角).ToString("F4")
            End With

            Data(ColumnList.IndexOf("後胴方位角")) = Hoko2Hoi(RefernceDirection.HorKodoKijun.軌道中心方位角 + HorPlan.X軸方位角).ToString("F4")
            Data(ColumnList.IndexOf("平面姿勢角管理値")) = RefernceDirection.平面基準方位.ToString("F4")

            Data(ColumnList.IndexOf("縦断旋回中心")) = RefernceDirection.縦断旋回中心.ToString("F4")
            With RefernceDirection.VerZendoKijun
                Data(ColumnList.IndexOf("縦断発進から発旋回中心までの距離")) = (.掘進累積距離 - RefernceDirection.toStartDistance).ToString("F4")
                Data(ColumnList.IndexOf("縦断起点から発旋回中心までの距離")) = .掘進累積距離.ToString("F4")
                Data(ColumnList.IndexOf("縦断ｿﾞｰﾝ")) = .縦断ゾーン番号
                Data(ColumnList.IndexOf("縦断線形")) = .縦断線形
                Data(ColumnList.IndexOf("縦断前方変化点距離")) = .縦断ゾーン内残距離.ToString("F4")
                Data(ColumnList.IndexOf("縦断後方変化点距離")) = .縦断ゾーン内掘進距離.ToString("F4")
                Data(ColumnList.IndexOf("縦断ｼﾌﾄ量")) = .縦断シフト量 * 1000
                Data(ColumnList.IndexOf("縦断ｼﾌﾄ追加角")) = .縦断シフト追加角.ToString("F4")
                Data(ColumnList.IndexOf("縦断半径")) = .縦断半径.ToString("F4")
                Data(ColumnList.IndexOf("Z座標")) = .Z座標.ToString("F4")
                Data(ColumnList.IndexOf("前胴鉛直角")) = .鉛直角.ToString("F4")
            End With
            Data(ColumnList.IndexOf("後胴鉛直角")) = RefernceDirection.VerKodoKijun.鉛直角.ToString("F4")
            Data(ColumnList.IndexOf("縦断姿勢角管理値")) = RefernceDirection.縦断基準方位.ToString("F4")


            Data(ColumnList.IndexOf("測量ポイント確認リング")) = CtlPara.測量ポイントリング番号
            Data(ColumnList.IndexOf("測量ポイント先端距離")) = CtlPara.測量ポイント総距離

            Data(ColumnList.IndexOf("水平補正値")) = CtlPara.水平入力補正値
            Data(ColumnList.IndexOf("鉛直補正値")) = CtlPara.鉛直入力補正値
            Data(ColumnList.IndexOf("全開作動指令値")) = CtlPara.全開作動指令値
            Data(ColumnList.IndexOf("全開作動範囲")) = CtlPara.全開作動範囲
            Data(ColumnList.IndexOf("水平ジャッキ制御Ｐ定数")) = CtlPara.水平ジャッキ制御P定数
            Data(ColumnList.IndexOf("水平ジャッキ制御Ｉ定数")) = CtlPara.水平ジャッキ制御I定数
            Data(ColumnList.IndexOf("水平ジャッキ制御D定数")) = CtlPara.水平ジャッキ制御D定数
            Data(ColumnList.IndexOf("鉛直ジャッキ制御Ｐ定数")) = CtlPara.鉛直ジャッキ制御P定数
            Data(ColumnList.IndexOf("鉛直ジャッキ制御Ｉ定数")) = CtlPara.鉛直ジャッキ制御D定数
            Data(ColumnList.IndexOf("鉛直ジャッキ制御D定数")) = CtlPara.鉛直ジャッキ制御I定数
            'Data(ColumnList.IndexOf("制御モード切替作動範囲")) = .
            Data(ColumnList.IndexOf("片押し制限フラグ")) = IIf(CtlPara.片押し制限フラグ, 1, 0)
            Data(ColumnList.IndexOf("圧力許容値")) = CtlPara.圧力許容値
            'Data(ColumnList.IndexOf("全開グループ制限")) = IIf(.全開グループ制限, 1, 0)
            Data(ColumnList.IndexOf("最低全開グループ数")) = CtlPara.最低全開グループ数
            'TODO:偏角許容値のエラーメッセージ未処理　音声がいいか！
            Data(ColumnList.IndexOf("偏差角許容値")) = CtlPara.DevTolerance
            Data(ColumnList.IndexOf("最大全開出力時の目標圧力")) = CtlPara.最大全開出力時の目標圧力
            Data(ColumnList.IndexOf("ジャッキモーメント上限値")) = CtlPara.ジャッキモーメント上限値

            'TODO:復活か　このPID定数
            'Data(ColumnList.IndexOf("感度調整圧力偏差")) = CulcMoment.Thrust
            'Data(ColumnList.IndexOf("感度調整減圧弁制御P定数")) = CulcMoment.Thrust
            'Data(ColumnList.IndexOf("感度調整減圧弁制御I定数")) = CulcMoment.Thrust

            Data(ColumnList.IndexOf("姿勢制御自動")) = IIf(CtlPara.AutoDirectionControl, 1, 0)

            If InitPara.LosZeroEquip Then

                Data(ColumnList.IndexOf("同時施工モード")) = IIf(PlcIf.LosZeroMode, 1, 0)
                Data(ColumnList.IndexOf("同時施工可")) = IIf(PlcIf.LosZeroEnable, 1, 0)

                Data(ColumnList.IndexOf("同時施工ステータス_Machine")) = PlcIf.LosZeroSts_M
                Data(ColumnList.IndexOf("同時施工ステータス_FLEX")) = PlcIf.LosZeroSts_FLEX

                Data(ColumnList.IndexOf("減圧判断設定値")) = CtlPara.ReduceJudgePress
                Data(ColumnList.IndexOf("減圧速度")) = CtlPara.ReduceTime

                Data(ColumnList.IndexOf("組立ピース")) = PlcIf.AssemblyPieceNo

                If SegAsmblyData.ProcessData.ContainsKey(PlcIf.AssemblyPieceNo) Then
                    With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                        'TODO:Data(ColumnList.IndexOf("組立セグメント")) = 
                        Data(ColumnList.IndexOf("組立ボルトピッチ")) = .BoltPitch
                        Data(ColumnList.IndexOf("組立パターン")) = .PatternName
                        'TODO:Data(ColumnList.IndexOf("ローリング偏差")) = .r
                        Data(ColumnList.IndexOf("引戻ジャッキ")) = .PullBackJack.ToCommaDelmit
                        Data(ColumnList.IndexOf("減圧グループ")) = .ReduceGroup.ToCommaDelmit
                        Data(ColumnList.IndexOf("押込ジャッキ")) = .ClosetJack.ToCommaDelmit
                        'TODO:Data(ColumnList.IndexOf("押込推進ジャッキ")) = CulcMoment.Thrust
                        Data(ColumnList.IndexOf("追加推進ジャッキ")) = .AddClosetJack.ToCommaDelmit
                        'TODO:Data(ColumnList.IndexOf("RL考慮ジャッキ")) = CulcMoment.Thrust

                    End With

                End If


                Data(ColumnList.IndexOf("同時掘進時間")) = ElapsedTime.LozeroExcavationTime

            End If


            'TODO:Data(ColumnList.IndexOf("低圧推進設定値")) = CulcMoment.Thrust
            Data(ColumnList.IndexOf("掘進時間")) = ElapsedTime.ExcavationTime
            Data(ColumnList.IndexOf("待機時間")) = ElapsedTime.WatingTime
            Data(ColumnList.IndexOf("サイクル時間")) = ElapsedTime.CycleTime

            'コラムに入力されてない項目の抽出
            Dim NothingLst As New List(Of Integer)
            For i As Short = 0 To Data.Count - 1
                If Data(i) Is Nothing Then
                    NothingLst.Add(i)
                End If
            Next
            'アナログTAGにある項目を入れる
            For Each nlst In NothingLst
                If PlcIf.EngValue.ContainsKey(ColumnList(nlst)) Then
                    'tagデータより小数点位置を取得
                    Dim DigLoc As Short =
                        PlcIf.AnalogTag.TagData(ColumnList(nlst)).DigitLoc
                    Data(nlst) = PlcIf.EngValue(ColumnList(nlst)).ToString($"F{DigLoc}")

                End If
            Next

            Return $"'{String.Join("','", Data)}'".Replace("''", "NULL")

        Catch ex As Exception

            MessageBox.Show($"DataSaveでエラー  {ex.Message} {ex.StackTrace}")
            Return "'" & String.Join("','", Data) & "'"
        End Try


    End Function





End Class