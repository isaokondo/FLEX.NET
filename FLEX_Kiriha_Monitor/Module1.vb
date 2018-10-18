Imports FLEX.NET
Module Module1

    'Public InitPara As clsInitParameter '初期値パラメータ
    'Public SegAsmblyData As clsSegmentAssembly ''セグメント組立データ

    'Public HorPlan As clsHorPanData '平面掘進計画線
    'Public VerPlan As clsVerPlanData '縦断掘進計画線


    'Public WithEvents CtlPara As clsControlParameter  '制御パラメータ

    '''' <summary>
    '''' シールドマシン諸元
    '''' </summary>
    'Public MachineSpec As clsMachinSpec

    ''Public SegAsmblyData As clsSegmentAssembly ''セグメント組立データ


    ''Public CulcMoment As clsCulMoment ''モーメント、推力の演算

    ''Public WithEvents JackMvAuto As clsCulJackMv ''ジャッキ操作量の演算
    '''' <summary>
    '''' 推力分担率の演算
    '''' </summary>
    'Public DivCul As clsThrustDiv ''
    ''''' <summary>
    ''''' 基準方位演算
    ''''' </summary>
    ''Public RefernceDirection As clsCulKijun

    ''PLCインターフェース
    'Public WithEvents PlcIf As clsPlcIf

    ''''' <summary>
    ''''' 減圧処理
    ''''' </summary>
    ''Public WithEvents Reduce As clsReducePress
    '''' <summary>
    '''' ロスゼロ時の計算ストローク
    '''' </summary>
    'Public CalcStroke As clsCalcuStroke

    '''' <summary>
    '''' ロスゼロステータス（工程表示用)
    '''' 1:減圧中　2:減圧完了　3:引き戻し中　4:引き戻し完了　5:組立中 6:組立完了
    '''' </summary>
    'Public LosZeroSts As Short
    '''' <summary>
    '''' 経過時間の算出
    '''' </summary>
    'Public ElapsedTime As New clsElapsedTime


    '''' <summary>
    '''' テーブル更新日付取得
    '''' </summary>
    'Public WithEvents TableUpdateConfirm As clsTableUpdateConfirm
    '''' <summary>
    '''' 同時施工実績　算出
    '''' </summary>
    'Public LosZeroPerform As New clsLosZeroPerform

    '''' <summary>
    '''' 減圧可能ストロークに達した
    '''' </summary>
    'Private ReduceEnableStrokeReachFlg As Boolean

End Module
