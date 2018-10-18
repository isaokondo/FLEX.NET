Imports FLEX.NET
Public Class frmMain









    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MYSQLのバージョン取得
        clsDataBase.GetMySQKVersion()


        'インスタンス作成
        InitPara = New FLEX.NET.clsInitParameter '初期値パラメータ
        CtlPara = New FLEX.NET.clsControlParameter  '制御パラメータ

        'SegAsmblyData = New clsSegmentAssembly ''セグメント組立データ
        'DataSave = New clsDataSave 'データ保存
        'CulcMoment = New clsCulMoment ''モーメント、推力の演算
        'JackMvAuto = New clsCulJackMv ''ジャッキ操作量の演算
        'DivCul = New clsThrustDiv ''推力分担
        'RefernceDirection = New clsCulKijun '基準方位演算
        PlcIf = New FLEX.NET.clsPlcIf 'PLCインターフェース
        'CalcStroke = New clsCalcuStroke   'ロスゼロ時の計算ストローク
        'JackManual = New clsJkManualOut 'ジャッキ手動操作出力
        'Reduce = New clsReducePress 'ロスゼロ減圧処理
        'TableUpdateConfirm = New clsTableUpdateConfirm    'テーブル更新によるパラメータ再取得

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        'ジャッキ稼働画面の初期データ
        With UcnJackDsp
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
    End Sub
End Class