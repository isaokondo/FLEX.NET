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
        Dim recFldData As DataTable
        'コラム名のリストを取得
        If DBType() = DataBaseType.MySQL Then
            recFldData = GetDtfmSQL("show columns from  flex掘削データ ")
        End If

        If DBType() = DataBaseType.MsSQLServer Then
            recFldData =
                GetDtfmSQL("SELECT syscolumns.name as Field FROM syscolumns 
                INNER JOIN sysobjects ON sysobjects.id = syscolumns.id 
                WHERE  sysobjects.name = 'flex掘削データ'")
        End If


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

    ''' <summary>
    ''' SQL作成
    ''' </summary>
    ''' <returns></returns>
    Private Function getSqlData() As String

        Dim Data(ColumnList.Count - 1) As String

        Try
            'PLCからの読込
            With PlcIf

                Data(ColumnList.IndexOf("リング番号")) = .RingNo.ToString
                Data(ColumnList.IndexOf("掘進ストローク")) = .RealStroke.ToString
                Data(ColumnList.IndexOf("時間")) = Now.ToString

                For i As Short = 0 To InitPara.NumberGroup - 1
                    Data(ColumnList.IndexOf("グループ" & (i + 1) & "圧力")) = .GroupPv(i).ToString("F1")
                    Data(ColumnList.IndexOf("グループ" & (i + 1) & "MV")) = .GroupMV(i).ToString("F1")
                    Data(ColumnList.IndexOf("グループ" & (i + 1) & "制御フラグ")) = .GroupFlg(i).ToString
                    Data(ColumnList.IndexOf("グループ" & (i + 1) & "SV")) = .GroupSV(i).ToString("F1")
                Next

                For i As Short = 0 To InitPara.NumberJack - 1
                    Data(ColumnList.IndexOf("ジャッキステータス" & (i + 1))) = .JackStatus(i)
                Next

                Data(ColumnList.IndexOf("シールドジャッキ圧力")) = .JkPress.ToString
                Data(ColumnList.IndexOf("ジャイロ方位角")) = .Gyro.ToString
                Data(ColumnList.IndexOf("ジャイロピッチング")) = .Pitching.ToString
                Data(ColumnList.IndexOf("ジャイロローリング")) = .Rolling.ToString
                Data(ColumnList.IndexOf("マシンピッチング")) = .MachinePitching.ToString
                Data(ColumnList.IndexOf("マシン前胴ローリング")) = .MashineRolling.ToString
                'TODO:未割り当て
                'Data(ColumnList.IndexOf("マシン後胴ローリング")) = .RealStroke.ToString
                Data(ColumnList.IndexOf("中折左右角")) = .NakaoreLR.ToString
                Data(ColumnList.IndexOf("中折上下角")) = .NakaoreTB.ToString
                Data(ColumnList.IndexOf("左ジャッキストローク")) = .LeftStroke.ToString
                Data(ColumnList.IndexOf("右ジャッキストローク")) = .RightStroke.ToString
                Data(ColumnList.IndexOf("上ジャッキストローク")) = .TopStroke.ToString
                Data(ColumnList.IndexOf("下ジャッキストローク")) = .BotomStroke.ToString
                Data(ColumnList.IndexOf("左ジャッキ速度")) = .LeftSpeed.ToString
                Data(ColumnList.IndexOf("右ジャッキ速度")) = .RightSpeed.ToString
                Data(ColumnList.IndexOf("上ジャッキ速度")) = .TopSpeed.ToString
                Data(ColumnList.IndexOf("下ジャッキ速度")) = .BotomSpeed.ToString
                Data(ColumnList.IndexOf("コピー角度1")) = .CopyAngle.ToString
                Data(ColumnList.IndexOf("コピーストローク1")) = .CopyStroke1.ToString
                'TODO:未割り当て
                'Data(ColumnList.IndexOf("コピー角度2")) = .RealStroke.ToString
                'Data(ColumnList.IndexOf("コピーストローク2")) = .RealStroke.ToString

                Data(ColumnList.IndexOf("同時施工ステータス_Machine")) = .LosZeroSts_M
                Data(ColumnList.IndexOf("同時施工ステータス_FLEX")) = .LosZeroSts_FLEX

                Data(ColumnList.IndexOf("減圧弁制御Ｐ定数")) = .感度調整減圧弁制御Ｐ定数
                Data(ColumnList.IndexOf("減圧弁制御Ｉ定数")) = .感度調整減圧弁制御Ｉ定数
                'Data(ColumnList.IndexOf("ストローク管理法")) = .ストローク管理法
                'Data(ColumnList.IndexOf("掘進判定ストローク")) = .掘進判定ストローク
                'Data(ColumnList.IndexOf("終了判定ストローク")) = .終了判定ストローク
                Data(ColumnList.IndexOf("終了判定引きストローク")) = .終了判定引きストローク
                'Data(ColumnList.IndexOf("終了判定時間")) = .終了判定時間
                'Data(ColumnList.IndexOf("開始判定速度")) = .
                'Data(ColumnList.IndexOf("中断判定速度")) = .中断判定速度

                Data(ColumnList.IndexOf("圧力制御")) = IIf(.FlexControlOn, 1, 0)
                Data(ColumnList.IndexOf("同時施工モード")) = IIf(.LosZeroMode, 1, 0)
                Data(ColumnList.IndexOf("同時施工可")) = IIf(.LosZeroEnable, 1, 0)
                Data(ColumnList.IndexOf("ジャイロ異常")) = IIf(.GyiroError, 1, 0)

                Data(ColumnList.IndexOf("力点Ｘ")) = .PointX.ToString("F3")
                Data(ColumnList.IndexOf("力点Ｙ")) = .PointY.ToString("F3")

                Data(ColumnList.IndexOf("片押しγ")) = .操作強.ToString("F4")
                Data(ColumnList.IndexOf("方向θ")) = .操作角.ToString("F4")

            End With


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


            With CtlPara


                Data(ColumnList.IndexOf("測量ポイント確認リング")) = .測量ポイントリング番号
                Data(ColumnList.IndexOf("測量ポイント先端距離")) = .測量ポイント総距離

                Data(ColumnList.IndexOf("水平補正値")) = .水平入力補正値
                Data(ColumnList.IndexOf("鉛直補正値")) = .鉛直入力補正値
                Data(ColumnList.IndexOf("全開作動指令値")) = .全開作動指令値
                Data(ColumnList.IndexOf("全開作動範囲")) = .全開作動範囲
                Data(ColumnList.IndexOf("水平ジャッキ制御Ｐ定数")) = .水平ジャッキ制御P定数
                Data(ColumnList.IndexOf("水平ジャッキ制御Ｉ定数")) = .水平ジャッキ制御I定数
                Data(ColumnList.IndexOf("水平ジャッキ制御D定数")) = .水平ジャッキ制御D定数
                Data(ColumnList.IndexOf("鉛直ジャッキ制御Ｐ定数")) = .鉛直ジャッキ制御P定数
                Data(ColumnList.IndexOf("鉛直ジャッキ制御Ｉ定数")) = .鉛直ジャッキ制御D定数
                Data(ColumnList.IndexOf("鉛直ジャッキ制御D定数")) = .鉛直ジャッキ制御I定数
                'Data(ColumnList.IndexOf("制御モード切替作動範囲")) = .
                Data(ColumnList.IndexOf("片押し制限フラグ")) = IIf(.片押し制限フラグ, 1, 0)
                Data(ColumnList.IndexOf("圧力許容値")) = .圧力許容値
                'Data(ColumnList.IndexOf("全開グループ制限")) = IIf(.全開グループ制限, 1, 0)
                Data(ColumnList.IndexOf("最低全開グループ数")) = .最低全開グループ数
                'TODO:偏角許容値のエラーメッセージ未処理　音声がいいか！
                Data(ColumnList.IndexOf("偏差角許容値")) = .DevTolerance
                Data(ColumnList.IndexOf("最大全開出力時の目標圧力")) = .最大全開出力時の目標圧力
                Data(ColumnList.IndexOf("ジャッキモーメント上限値")) = .ジャッキモーメント上限値

                'TODO:復活か　このPID定数
                'Data(ColumnList.IndexOf("感度調整圧力偏差")) = CulcMoment.Thrust
                'Data(ColumnList.IndexOf("感度調整減圧弁制御P定数")) = CulcMoment.Thrust
                'Data(ColumnList.IndexOf("感度調整減圧弁制御I定数")) = CulcMoment.Thrust
                Data(ColumnList.IndexOf("減圧判断設定値")) = .ReduceJudgePress
                Data(ColumnList.IndexOf("減圧速度")) = .ReduceTime

                Data(ColumnList.IndexOf("姿勢制御自動")) = IIf(.AutoDirectionControl, 1, 0)


            End With


            Data(ColumnList.IndexOf("組立ピース")) = PlcIf.AssemblyPieceNo
            With SegAsmblyData.ProcessData(PlcIf.AssemblyPieceNo)
                'TODO:Data(ColumnList.IndexOf("組立セグメント")) = 
                Data(ColumnList.IndexOf("組立ボルトピッチ")) = .BoltPitch
                Data(ColumnList.IndexOf("組立パターン")) = .PatternName
                'TODO:Data(ColumnList.IndexOf("ローリング偏差")) = .r
                Data(ColumnList.IndexOf("引戻ジャッキ")) = LstToJoinDl(.PullBackJack)
                Data(ColumnList.IndexOf("減圧グループ")) = LstToJoinDl(.ReduceGroup)
                Data(ColumnList.IndexOf("押込ジャッキ")) = LstToJoinDl(.ClosetJack)
                'TODO:Data(ColumnList.IndexOf("押込推進ジャッキ")) = CulcMoment.Thrust
                Data(ColumnList.IndexOf("追加推進ジャッキ")) = LstToJoinDl(.AddClosetJack)
                'TODO:Data(ColumnList.IndexOf("RL考慮ジャッキ")) = CulcMoment.Thrust

            End With

            'TODO:Data(ColumnList.IndexOf("低圧推進設定値")) = CulcMoment.Thrust
            Data(ColumnList.IndexOf("掘進時間")) = ElapsedTime.ExcavationTime
            Data(ColumnList.IndexOf("同時掘進時間")) = ElapsedTime.LozeroExcavationTime
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
            Dim s As String = "'" & String.Join("','", Data) & "'"
            s = s.Replace("''", "NULL")
            Return s

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return "'" & String.Join("','", Data) & "'"
        End Try


    End Function
    ''' <summary>
    ''' リスト形式をコンマで区切った値に変換
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Private Function LstToJoinDl(t As List(Of Short)) As String
        'データないとき
        If IsNothing(t) OrElse t.Count = 0 Then
            Return ""
        Else
            Return String.Join(",", t)
        End If

    End Function





End Class