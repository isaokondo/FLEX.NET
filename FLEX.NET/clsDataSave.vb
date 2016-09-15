Option Strict On
Option Explicit On
Friend Class clsDataSave
    ' @(h) clsDataSave.cls                ver 1.0 ( '01.02.15 近藤　勲 )
    ' @(h) clsDataSave.cls                ver 2.0 ( '2016.02.03 近藤　勲 ) MYSQL対応

    ' @(s) データ保存するクラス
    '
    '

    Inherits clsDataBase

    Public Sub sbDataSave()



        Dim recDataSave As Odbc.OdbcDataReader = ExecuteSql("REPLACE INTO FLEX掘削データ VALUES(" & getSqlData() & ")")



    End Sub


    Private Function getSqlData() As String

        'Dim intCnt As Short
        getSqlData = "'" & PlcIf.RingNo & "',"

        With PlcIf
            getSqlData = getSqlData & "'" & .RealStroke & "',"
            getSqlData = getSqlData & "'" & Format(Now, "YYYY-MM-DD hh:mm:ss") & "',"

            ''グループ圧関連の書き込み
            'For intCnt = 1 To InitParameter.NumberGroup
            '    getSqlData = getSqlData & "'" & .Group(intCnt).Pv.ToString("F1") & "',"
            'Next
            'For intCnt = 1 To InitParameter.NumberGroup
            '    getSqlData = getSqlData & "'" & .Group(intCnt).Mv.ToString("F1") & "',"
            'Next
            'For intCnt = 1 To InitParameter.NumberGroup
            '    getSqlData = getSqlData & "'" & .Group(intCnt).Flg.ToString("F1") & "',"
            'Next
            'For intCnt = 1 To InitParameter.NumberGroup
            '    getSqlData = getSqlData & "'" & .Group(intCnt).Sv.ToString("F1") & "',"
            'Next

            getSqlData = getSqlData & "'" & .JkPress.ToString("F1") & "',"
            getSqlData = getSqlData & "'" & .Gyro & "',"
            getSqlData = getSqlData & "'" & .Pitching & "',"
            getSqlData = getSqlData & "'" & .Rolling & "',"
            getSqlData = getSqlData & "'" & .NakaoreLR & "',"
            getSqlData = getSqlData & "'" & .NakaoreTB & "',"
            getSqlData = getSqlData & "'" & .LeftStroke & "',"
            getSqlData = getSqlData & "'" & .RightStroke & "',"
            getSqlData = getSqlData & "'" & .TopStroke & "',"
            getSqlData = getSqlData & "'" & .BotomStroke & "',"
            getSqlData = getSqlData & "'" & .LeftStroke & "',"
            getSqlData = getSqlData & "'" & .RealStroke & "',"
            getSqlData = getSqlData & "'" & .TopSpeed & "',"
            getSqlData = getSqlData & "'" & .BotomSpeed & "',"
        End With

        With ControlParameter
            getSqlData = getSqlData & "'" & .PointX & "',"
            getSqlData = getSqlData & "'" & .PointY & "',"

            getSqlData = getSqlData & "'" & DivCul.操作強.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & DivCul.操作角.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & PlcIf.減圧弁制御P定数 & "',"
            getSqlData = getSqlData & "'" & PlcIf.減圧弁制御I定数 & "',"
            getSqlData = getSqlData & "'" & PlcIf.ストローク管理法 & "',"
            getSqlData = getSqlData & "'" & PlcIf.掘進判定ストローク & "',"
            getSqlData = getSqlData & "'" & PlcIf.終了判定ストローク & "',"
            getSqlData = getSqlData & "'" & PlcIf.終了判定引きストローク & "',"
            getSqlData = getSqlData & "'" & PlcIf.終了判定時間 & "',"
            getSqlData = getSqlData & "'" & PlcIf.中断判定速度 & "',"
            getSqlData = getSqlData & "'" & PlcIf.ストローク管理法 & "',"
            getSqlData = getSqlData & "'" & .測量ポイントリング番号 & "',"
            getSqlData = getSqlData & "'" & .測量ポイント総距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .水平入力補正値.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .鉛直入力補正値.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .偏差角許容値 & "',"
            getSqlData = getSqlData & "'" & .最大全開出力時の目標圧力 & "',"
            getSqlData = getSqlData & "'" & .ジャッキモーメント上限値 & "',"

        End With
        With CulcMoment
            getSqlData = getSqlData & "'" & .MomentX & "',"
            getSqlData = getSqlData & "'" & .MomentY & "',"
            getSqlData = getSqlData & "'" & .MomentR & "',"
            getSqlData = getSqlData & "'" & .Thrust & "',"
        End With

        With JackMvAuto
            getSqlData = getSqlData & "'" & ControlParameter.水平ジャッキ制御P定数 & "',"
            getSqlData = getSqlData & "'" & ControlParameter.水平ジャッキ制御I定数 & "',"
            getSqlData = getSqlData & "'" & ControlParameter.鉛直ジャッキ制御P定数 & "',"
            getSqlData = getSqlData & "'" & ControlParameter.鉛直ジャッキ制御I定数 & "',"
            getSqlData = getSqlData & "'" & .片押制御Flg & "',"
            getSqlData = getSqlData & "'" & ControlParameter.圧力許容値 & "',"


        End With

        With DivCul
            getSqlData = getSqlData & "'" & .全開作動指令値 & "',"
            getSqlData = getSqlData & "'" & .全開作動範囲 & "',"
            getSqlData = getSqlData & "'" & .全開グループ制限 & "',"
            getSqlData = getSqlData & "'" & .最低全開グループ数 & "',"
        End With

        With RefernceDirection.HorZendoKijun
            getSqlData = getSqlData & "'" & .掘進累積距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .平面ゾーン番号 & "',"
            getSqlData = getSqlData & "'" & .平面ゾーン掘進距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .平面ゾーン内残距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .平面シフト量.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .軌道中心平面半径.ToString("F3") & "',"

            getSqlData = getSqlData & "'" & Hoko2Hoi(.軌道中心方位角).ToString("F3") & "',"
            getSqlData = getSqlData & "'" & Hoko2Hoi(.構築中心方位角).ToString("F3") & "',"

            getSqlData = getSqlData & "'" & .軌道中心X座標.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .軌道中心Y座標.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .構築中心X座標.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .構築中心Y座標.ToString("F3") & "',"

        End With

        With RefernceDirection.VerZendoKijun
            getSqlData = getSqlData & "'" & .縦断ゾーン番号 & "',"
            getSqlData = getSqlData & "'" & .縦断ゾーン内掘進距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .縦断ゾーン内残距離.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .縦断半径.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .鉛直角.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .Z座標.ToString("F3") & "',"
        End With

        With RefernceDirection
            getSqlData = getSqlData & "'" & .平面計画方位.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & .縦断計画方位.ToString("F3") & "',"
            getSqlData = getSqlData & "'" & (PlcIf.Gyro - .平面基準方位).ToString("F3") & "',"
            getSqlData = getSqlData & "'" & (PlcIf.Pitching - .縦断基準方位).ToString("F3") & "'"
        End With




    End Function
End Class