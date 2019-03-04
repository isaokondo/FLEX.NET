'Option Strict On
Option Explicit On
Public Class clsControlParameter
    Inherits clsDataBase

    Public Property Name As String


    Private _最低全開グループ数 As Short = 3
    Private _全開作動範囲 As Short = 35
    Private _全開作動指令値 As Short

    'Private _全開グループ制限 As Boolean
    Private _最大全開出力時の目標圧力 As Single
    'Private _偏差角許容値 As Single ''偏差角許容値
    Private _最低制御圧力 As Single

    '力点座標
    'Private _PointX As Double = 0 ''Ｘ座標
    'Private _PointY As Double = 0 ''Ｙ座標

    'Private _操作角 As Double
    'Private _操作強 As Double

    '組み立てピース数
    Private _AssemblyPieceNumber As Integer = 0


    Private _OffsetStroke As Integer = 0 'ストローク補正値

    Private _片押しR制限値 As Single = 2
    Private _圧力許容値 As Single = 35
    Private _片押し制限フラグ As Boolean = True

    Private _単位当r引き戻し量 As Single
    Private _引き戻し実施間隔 As Single


    Private _開始時の力点位置 As Boolean = True
    Private _ジャッキの間引き制御 As Boolean = False
    Private _クリアランス計 As Boolean = False
    ''' <summary>
    ''' ダイレクト指令制御　使用／未使用
    ''' </summary>
    Private _DirectControl As Boolean
    ''' <summary>
    ''' PID移行偏差（ダイレクト指令制御→PID）　単位：Mpa
    ''' </summary>
    Private _PIDShiftDefl As Single

    Private _水平ジャッキ制御P定数 As Short = 120
    Private _水平ジャッキ制御I定数 As Short = 20
    Private _水平ジャッキ制御D定数 As Short = 20
    Private _鉛直ジャッキ制御P定数 As Short = 120
    Private _鉛直ジャッキ制御I定数 As Short = 20
    Private _鉛直ジャッキ制御D定数 As Short = 20


    Private _元圧フィルタ係数 As Short

    Private _測量ポイントリング番号 As Short = 0 ''測量ポイントリング番号
    Private _測量ポイント総距離 As Double = 0 ''測量ポイント総距離
    Private _鉛直入力補正値 As Double = 0 ''鉛直入力補正値
    Private _水平入力補正値 As Double = 0 ''水平入力補正値
    Private _ジャッキモーメント上限値 As Double ''ジャッキモーメント上限値

    Private _圧力制御開始推力値 As Double ''圧力制御開始推力値
    Private _圧力制御開始推力値有効フラグ As Boolean ''圧力制御開始推力値有効フラグ
    Private _全押しスタート As Boolean ''全押しスタート
    ''' <summary>
    ''' 自動方向制御
    ''' </summary>
    Private _AutoDirectionControl As Boolean
    ''' <summary>
    ''' FLEX姿勢制御の自動手動の切り替わり
    ''' </summary>
    Public Event FlexAutoManualChange()


    Private _GraphStrokeWidth As Integer    'グラフ横軸幅
    Private _HorMomentTrendWidth As Integer '水平モーメントトレンド幅
    Private _VerMomentTrendWidth As Integer '鉛直モーメントトレンド幅	
    Private _HorDevDegTrendWidth As Single  '水平偏角トレンド幅	
    Private _VerDevDegTrendWidth As Single  '鉛直偏角トレンド幅
    Private _LineDevStartRing As Integer    '姿勢角トレンド始点リング
    Private _LineDevLastRing As Integer     '姿勢角トレンド終点リング
    Private _PresBarGraphWidt As Integer    '圧力バーグラフ幅
    Private _DevTolerance As Single         '偏角許容値


    Private _LosZeroNlp As Integer  '同時施工 最適化ループ回数
    Private _LosZeroEmp As Single   'モーメント偏差許容値
    Private _LoszerorStep As Single '1ループの演算の力点変化量

    Private _LosZeroRollingTake As Boolean  '同時施工：ローリング考慮
    Private _LoszeroRollingTolerance As Single 'ピース端部の余裕許容値
    Private _LosZeroOpposeJack As Boolean '対抗ジャッキ選択
    Private _LosZeroOpposeControl As Boolean '対抗圧制御
    Private _LosZeroOpposeGroupNumber As Short '対抗ジャッキ制御グループ数
    Private _LosZeroOpposeManualSV As Single '対抗ジャッキ制御手動設定圧
    Private _ReduceReachStrokeDiff As Integer = 0 '減圧開始可能ストロークの設定（ストロークがセグメント幅＋この設定以上でサウンド出力）

    Private _LosZeroOpposeJackExcept As Boolean  '平均ジャッキストロークで引きストロークの対抗ジャッキのストロークを除外する

    Private _aveOffsetJackStroke As Single '計算平均ジャッキオフセットストローク

    Private _mesureOffsetJackStroke As New Dictionary(Of Short, Integer) '計測ジャッキオフセットストローク


    Private _ReduceTime As Integer '減圧時間（単位：SEC）
    Private _ReduceJudgePress As Single '減圧完了判断圧力(Mpa)
    Private _NextPieceConfirm As Boolean    '次ピース組立確認
    Private _NextPieceConfirmTime As Integer    '組立確認後の減圧開始確認タイマ

    Private _MomentRdductionRateOnReduce As Short   '減圧開始時のモーメント低減率
    Private _MomentRdductionRateOnOnewayLimit As Short '片押し調整時のモーメント低減率


    Private _PitchingSel As Integer = 0 'ピッチングの選択　0:ジャイロ　1:マシン

    Private _RightStrokeDiff As Boolean = True    'ストローク差　右勝ちでTRUE　左勝ちでFLASE


    Private _TargetNetStroke As Integer = 0   'ネットストローク　セグメント幅が変更になった時にリング目標値を開始よりこの値を距離を目標に

    Private _TargetStrokeOverRate As Integer = 100   'ストローク超えでリング更新メッセージ出すタイミングの割合



    ''' <summary>
    ''' パラメータに対応するPLCアドレスのハッシュテーブル
    ''' </summary>
    Private htPlcAdr As Hashtable = New Hashtable
    ''' <summary>
    ''' 汎用データ表示設定
    ''' </summary>
    Private _wideUse As Dictionary(Of Short, String)

    ''' <summary>
    ''' 任意圧力設定有効グループ
    ''' </summary>
    Private _optGpEn As List(Of Short)

    ''' <summary>
    ''' 任意圧力設定
    ''' </summary>
    Private _optGpSv(InitPara.NumberGroup - 1) As Single

    ''' <summary>
    ''' 任意圧力設定グループとその圧力設定
    ''' </summary>
    Private _OptGpSvDic As Dictionary(Of Short, Single)

    ''' <summary>
    ''' 自動方向制御でも手動操作が可能とする
    ''' </summary>
    Private _SemiAuto As Boolean

    ''' <summary>
    ''' コピーカッタの数
    ''' 'コピーカッタの数　MAX２個まで対応
    ''' </summary>
    ''' <returns></returns>
    Public Property CopyNumber As Short = 1



    ''' <summary>
    ''' コピーストローク表示
    ''' コピーカッタの色表示が有効になるストローク
    ''' </summary>
    Private _CopyCutEnableStroke As Integer
    ''' <summary>
    ''' ジャッキ表示の周りのコピーの表示番号
    ''' </summary>
    Private _CopySelect As Short


    ''' <summary>
    ''' ストローク演算で除外する計測ジャッキ
    ''' </summary>
    Private _ExceptMesureJackNo As List(Of Short)

    ''' <summary>
    ''' 線形が変化した時
    ''' </summary>
    Public Event ReferChnge()


    'Private Event UpdateData(ByVal sender As Object, ByVale As EventArgs, ByVal Value As Double)

    'Public Sub TimerRun()

    '    'TODO:テーブルの更新時のみ読みこむようにしたい
    '    Dim timer As Timer = New Timer()
    '    AddHandler timer.Tick, New EventHandler(AddressOf ReadParameter)
    '    timer.Interval = 1000   '1秒ごとの処理
    '    timer.Enabled = True ' timer.Start()と同じ

    'End Sub
    Public Property 最低全開グループ数() As Short
        Get
            Return _最低全開グループ数

        End Get
        Set(ByVal Value As Short)
            _最低全開グループ数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property optGpSv As Single()
        Get
            Return _optGpSv
        End Get
        Set(value() As Single)
            _optGpSv = value

            For i As Short = 0 To _optGpSv.Count - 1
                'Dim tb As Odbc.OdbcDataReader =
                ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{_optGpSv(i)}'
                    WHERE 項目名称='OptinalGroupSetValue{i + 1}'")
            Next

        End Set
    End Property


    ''' <summary>
    ''' 任意圧力設定有効グループ
    ''' </summary>
    ''' <returns></returns>
    Public Property optGpEn As List(Of Short)
        Get
            Return _optGpEn
        End Get
        Set(value As List(Of Short))
            _optGpEn = value

            'Dim tb As Odbc.OdbcDataReader =
            ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{String.Join(",", _optGpEn.ToArray)}'
                WHERE 項目名称='OptinalGroupSetNumber'")
        End Set
    End Property

    ''' <summary>
    ''' 任意設定有効グループとその設定値
    ''' </summary>
    ''' <returns></returns>
    Public Property OptGpSvDic As Dictionary(Of Short, Single)
        Get
            Return _OptGpSvDic
        End Get
        Set(value As Dictionary(Of Short, Single))
            _OptGpSvDic = value
        End Set
    End Property

    Public Property ExceptMesureJackNo As List(Of Short)
        Get
            Return _ExceptMesureJackNo
        End Get
        Set(value As List(Of Short))
            _ExceptMesureJackNo = value

            'Dim tb As Odbc.OdbcDataReader =
            ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{String.Join(",", _ExceptMesureJackNo.ToArray)}'
                WHERE 項目名称 ='ExceptMesureJackNo'")
        End Set
    End Property



    Public Property 全開作動範囲() As Short
        Get
            Return _全開作動範囲

        End Get
        Set(ByVal Value As Short)
            _全開作動範囲 = Value
            Call sbUpdateData(Value)
        End Set
    End Property
    Public Property 全開作動指令値() As Short
        Get
            Return _全開作動指令値

        End Get
        Set(ByVal Value As Short)
            _全開作動指令値 = Value
            Call sbUpdateData(Value)
        End Set
    End Property



    Public Property 片押し制限フラグ As Boolean
        Get
            Return _片押し制限フラグ
        End Get
        Set(value As Boolean)
            _片押し制限フラグ = value
            'todo:ビットのデータベース更新
            Call sbUpdateData(value)
        End Set
    End Property
    Public Property 片押しR制限値() As Single
        Get
            Return _片押しR制限値

        End Get
        Set(ByVal Value As Single)
            _片押しR制限値 = Value
            Call sbUpdateData(Value)
        End Set

    End Property

    Public Property 開始時の力点位置 As Boolean
        Get
            Return _開始時の力点位置
        End Get
        Set(value As Boolean)
            _開始時の力点位置 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property ジャッキの間引き制御 As Boolean
        Get
            Return _ジャッキの間引き制御
        End Get
        Set(value As Boolean)
            _ジャッキの間引き制御 = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 右テールクリアランス計あり　
    ''' アナログTagにあるかどうか
    ''' </summary>
    ''' <returns></returns>
    Public Property TaleClrMeasurRExist As Boolean

    ''' <summary>
    ''' 左テールクリアランス計あり
    '''アナログTagにあるかどうか
    ''' </summary>
    ''' <returns></returns>
    Public Property TaleClrMeasurLExist As Boolean

    ''' <summary>
    ''' 上テールクリアランス計あり
    ''' アナログTagにあるかどうか
    ''' </summary>
    ''' <returns></returns>
    Public Property TaleClrMeasurUExist As Boolean

    ''' <summary>
    ''' 下テールクリアランス計あり
    ''' アナログTagにあるかどうか
    ''' </summary>
    ''' <returns></returns>
    Public Property TaleClrMeasurBExist As Boolean


    ''' <summary>
    ''' 後胴ローリングあり
    ''' </summary>
    ''' <returns></returns>
    Public Property MachineRearRollingExist As Boolean


    ''' <summary>
    ''' FLEXからの速度割合あり
    ''' </summary>
    ''' <returns></returns>
    Public Property SpeedRateExist As Boolean

    'Public Property クリアランス計 As Boolean
    '    Get
    '        Return _クリアランス計
    '    End Get
    '    Set(value As Boolean)
    '        _クリアランス計 = value
    '        Call sbUpdateData(value)
    '    End Set
    'End Property
    Public Property 最大全開出力時の目標圧力() As Single
        Get
            Return _最大全開出力時の目標圧力
        End Get
        Set(ByVal Value As Single)
            _最大全開出力時の目標圧力 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 最低制御圧力 As Single
        Get
            Return _最低制御圧力
        End Get
        Set(value As Single)
            _最低制御圧力 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 測量ポイントリング番号() As Short
        Get
            Return _測量ポイントリング番号

        End Get
        Set(ByVal Value As Short)
            _測量ポイントリング番号 = Value
            Call sbUpdateData(Value)
            RaiseEvent ReferChnge()
        End Set

    End Property

    Public Property 測量ポイント総距離() As Double
        Get
            Return _測量ポイント総距離

        End Get
        Set(ByVal Value As Double)
            _測量ポイント総距離 = Value
            Call sbUpdateData(Value)
            RaiseEvent ReferChnge()

        End Set

    End Property
    Public Property 鉛直入力補正値() As Double
        Get
            Return _鉛直入力補正値

        End Get
        Set(ByVal Value As Double)
            _鉛直入力補正値 = Value
            Call sbUpdateData(Value)
            RaiseEvent ReferChnge()

        End Set

    End Property
    Public Property 水平入力補正値() As Double
        Get
            Return _水平入力補正値

        End Get
        Set(ByVal Value As Double)
            _水平入力補正値 = Value
            Call sbUpdateData(Value)
            RaiseEvent ReferChnge()

        End Set

    End Property
    Public Property ジャッキモーメント上限値() As Double
        Get
            Return _ジャッキモーメント上限値

        End Get
        Set(ByVal Value As Double)
            _ジャッキモーメント上限値 = Value
            Call sbUpdateData(Value)
        End Set

    End Property

    ''' <summary>
    ''' ピッチングの選択　0:ジャイロ　1:マシン
    ''' </summary>
    ''' <returns></returns>
    Public Property PitchingSel As Integer
        Get
            Return _PitchingSel
        End Get
        Set(value As Integer)
            _PitchingSel = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' ストローク差　右勝ちでTRUE　左勝ちでFLASE
    ''' </summary>
    ''' <returns></returns>
    Public Property RightStrokeDiff As Boolean
        Get
            Return _RightStrokeDiff
        End Get
        Set(value As Boolean)
            _RightStrokeDiff = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 'ネットストローク　セグメント幅が変更になった時に
    ''' リング目標値を開始よりこの値を距離を目標に
    ''' </summary>
    ''' <returns>単位mm</returns>
    Public Property TargetNetStroke As Integer
        Get
            Return _TargetNetStroke
        End Get
        Set(value As Integer)
            _TargetNetStroke = value
            Call sbUpdateData(value)
            RaiseEvent ReferChnge()
        End Set
    End Property

    ''' <summary>
    ''' 'ストローク超えでリング更新メッセージ出すタイミングの割合
    ''' </summary>
    ''' <returns></returns>
    Public Property TargetStrokeOverRate As Integer
        Get
            Return _TargetStrokeOverRate
        End Get
        Set(value As Integer)
            _TargetStrokeOverRate = value
            Call sbUpdateData(value)
        End Set
    End Property




    'Public Property 偏差角許容値() As Single
    '    Get
    '        Return _偏差角許容値
    '    End Get
    '    Set(ByVal Value As Single)
    '        _偏差角許容値 = Value
    '        Call sbUpdateData(Value)
    '    End Set
    'End Property
    ''' <summary>
    ''' ダイレクト指令制御　使用／未使用
    ''' </summary>
    ''' <returns></returns>
    Public Property DirectControl As Boolean
        Get
            Return _DirectControl
        End Get
        Set(value As Boolean)
            _DirectControl = value
            sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' PID移行偏差（ダイレクト指令制御→PID）　単位：Mpa
    ''' </summary>
    ''' <returns></returns>
    Public Property PIDShiftDefl As Single
        Get
            Return _PIDShiftDefl
        End Get
        Set(value As Single)
            _PIDShiftDefl = value
            Call sbUpdateData(value)
        End Set
    End Property



    Public Property 水平ジャッキ制御P定数() As Short
        Get
            Return _水平ジャッキ制御P定数

        End Get
        Set(ByVal Value As Short)
            _水平ジャッキ制御P定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 水平ジャッキ制御I定数() As Short
        Get
            Return _水平ジャッキ制御I定数

        End Get
        Set(ByVal Value As Short)
            _水平ジャッキ制御I定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 水平ジャッキ制御D定数() As Short
        Get
            Return _水平ジャッキ制御D定数

        End Get
        Set(ByVal Value As Short)
            _水平ジャッキ制御D定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 鉛直ジャッキ制御P定数() As Short
        Get
            Return _鉛直ジャッキ制御P定数

        End Get
        Set(ByVal Value As Short)
            _鉛直ジャッキ制御P定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 鉛直ジャッキ制御I定数() As Short
        Get
            Return _鉛直ジャッキ制御I定数

        End Get
        Set(ByVal Value As Short)
            _鉛直ジャッキ制御I定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property


    Public Property 鉛直ジャッキ制御D定数() As Short
        Get
            Return _鉛直ジャッキ制御D定数

        End Get
        Set(ByVal Value As Short)
            _鉛直ジャッキ制御D定数 = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 元圧フィルタ係数 As Short
        Get
            Return _元圧フィルタ係数
        End Get
        Set(value As Short)
            _元圧フィルタ係数 = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 自動方向制御
    ''' </summary>
    ''' <returns></returns>
    Public Property AutoDirectionControl As Boolean
        Get
            Return _AutoDirectionControl
        End Get
        Set(value As Boolean)
            If value <> _AutoDirectionControl Then
                _AutoDirectionControl = value
                RaiseEvent FlexAutoManualChange()
                Call sbUpdateData(value)
            End If
        End Set
    End Property

    Public Property 単位当r引き戻し量 As Single
        Get
            Return _単位当r引き戻し量
        End Get
        Set(value As Single)
            _単位当r引き戻し量 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 引き戻し実施間隔 As Single
        Get
            Return _引き戻し実施間隔
        End Get
        Set(value As Single)
            _引き戻し実施間隔 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 圧力許容値 As Single
        Get
            Return _圧力許容値
        End Get
        Set(value As Single)
            _圧力許容値 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 圧力制御開始推力値 As Double
        Get
            Return _圧力制御開始推力値
        End Get
        Set(value As Double)
            _圧力制御開始推力値 = value
            Call sbUpdateData(value)
        End Set
    End Property
    Public Property 圧力制御開始推力値有効フラグ As Boolean
        Get
            Return _圧力制御開始推力値有効フラグ
        End Get
        Set(value As Boolean)
            _圧力制御開始推力値有効フラグ = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 全押しスタート As Boolean
        Get
            Return _全押しスタート
        End Get
        Set(value As Boolean)
            _全押しスタート = value
            Call sbUpdateData(value)
        End Set
    End Property



    ''' <summary>
    ''' グラフ横軸幅
    ''' </summary>
    ''' <returns></returns>
    Public Property GraphStrokeWidth As Integer
        Get
            Return _GraphStrokeWidth
        End Get
        Set(value As Integer)
            _GraphStrokeWidth = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 水平モーメントトレンド幅
    ''' </summary>
    ''' <returns></returns>
    Public Property HorMomentTrendWidth As Integer
        Get
            Return _HorMomentTrendWidth
        End Get
        Set(value As Integer)
            _HorMomentTrendWidth = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 鉛直モーメントトレンド幅
    ''' </summary>
    ''' <returns></returns>
    Public Property VerMomentTrendWidth As Integer
        Get
            Return _VerMomentTrendWidth
        End Get
        Set(value As Integer)
            _VerMomentTrendWidth = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 水平偏角トレンド幅
    ''' </summary>
    ''' <returns></returns>
    Public Property HorDevDegTrendWidth As Single
        Get
            Return _HorDevDegTrendWidth
        End Get
        Set(value As Single)
            _HorDevDegTrendWidth = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 鉛直偏角トレンド幅
    ''' </summary>
    ''' <returns></returns>
    Public Property VerDevDegTrendWidth As Single
        Get
            Return _VerDevDegTrendWidth
        End Get
        Set(value As Single)
            _VerDevDegTrendWidth = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 姿勢角トレンド始点リング
    ''' </summary>
    ''' <returns></returns>
    Public Property LineDevStartRing As Integer
        Get
            Return _LineDevStartRing
        End Get
        Set(value As Integer)
            _LineDevStartRing = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 姿勢角トレンド終点リング
    ''' </summary>
    ''' <returns></returns>
    Public Property LineDevLastRing As Integer
        Get
            Return _LineDevLastRing
        End Get
        Set(value As Integer)
            _LineDevLastRing = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 圧力バーグラフ幅
    ''' </summary>
    ''' <returns></returns>
    Public Property PresBarGraphWidt As Integer
        Get
            Return _PresBarGraphWidt
        End Get
        Set(value As Integer)
            _PresBarGraphWidt = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 偏角許容値
    ''' </summary>
    ''' <returns></returns>
    Public Property DevTolerance As Single
        Get
            Return _DevTolerance
        End Get
        Set(value As Single)
            _DevTolerance = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 同時施工 最適化ループ回数
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroNlp As Integer
        Get
            Return _LosZeroNlp
        End Get
        Set(value As Integer)
            _LosZeroNlp = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' モーメント偏差許容値
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroEmp As Single
        Get
            Return _LosZeroEmp
        End Get
        Set(value As Single)
            _LosZeroEmp = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 1ループの演算の力点変化量
    ''' </summary>
    ''' <returns></returns>
    Public Property LoszerorStep As Single
        Get
            Return _LoszerorStep
        End Get
        Set(value As Single)
            _LoszerorStep = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 同時施工：ローリング考慮
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroRollingTake As Boolean
        Get
            Return _LosZeroRollingTake
        End Get
        Set(value As Boolean)
            _LosZeroRollingTake = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 同時施工：ピース端部の余裕許容値
    ''' </summary>
    ''' <returns></returns>
    Public Property LoszeroRollingTolerance As Single
        Get
            Return _LoszeroRollingTolerance
        End Get
        Set(value As Single)
            _LoszeroRollingTolerance = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 対抗ジャッキ選択
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroOpposeJack As Boolean
        Get
            Return _LosZeroOpposeJack
        End Get
        Set(value As Boolean)
            _LosZeroOpposeJack = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 対抗圧制御　有効
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroOpposeControl As Boolean
        Get
            Return _LosZeroOpposeControl
        End Get
        Set(value As Boolean)
            _LosZeroOpposeControl = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 対抗ジャッキ制御グループ数
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroOpposeGroupNumber As Short
        Get
            Return _LosZeroOpposeGroupNumber
        End Get
        Set(value As Short)
            _LosZeroOpposeGroupNumber = value
            Call sbUpdateData(value)

        End Set
    End Property

    ''' <summary>
    ''' 対抗ジャッキ制御手動設定圧
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroOpposeManualSV As Single
        Get
            Return _LosZeroOpposeManualSV
        End Get
        Set(value As Single)
            _LosZeroOpposeManualSV = value
            Call sbUpdateData(value)

        End Set
    End Property

    ''' <summary>
    ''' '平均ジャッキストロークで引きストロークの
    ''' 対抗ジャッキのストロークを除外する
    ''' </summary>
    ''' <returns></returns>
    Public Property LosZeroOpposeJackExcept As Boolean
        Get
            Return _LosZeroOpposeJackExcept
        End Get
        Set(value As Boolean)
            _LosZeroOpposeJackExcept = value
            Call sbUpdateData(value)

        End Set
    End Property




    ''' <summary>
    ''' 減圧時間（単位：SEC）
    ''' </summary>
    ''' <returns></returns>
    Public Property ReduceTime As Integer
        Get
            Return _ReduceTime
        End Get
        Set(value As Integer)
            _ReduceTime = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 減圧完了判断圧力(Mpa)
    ''' </summary>
    ''' <returns></returns>
    Public Property ReduceJudgePress As Single
        Get
            Return _ReduceJudgePress
        End Get
        Set(value As Single)
            _ReduceJudgePress = value
            Call sbUpdateData(value)
        End Set
    End Property
    Public Property NextPieceConfirm As Boolean
        Get
            Return _NextPieceConfirm
        End Get
        Set(value As Boolean)
            _NextPieceConfirm = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 組立確認後の減圧開始確認タイマ
    ''' </summary>
    ''' <returns></returns>
    Public Property NextPieceConfirmTime As Integer
        Get
            Return _NextPieceConfirmTime
        End Get
        Set(value As Integer)
            _NextPieceConfirmTime = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 自動方向制御でも手動操作が可能とする
    ''' </summary>
    ''' <returns></returns>
    Public Property SemiAuto As Boolean
        Get
            Return _SemiAuto
        End Get
        Set(value As Boolean)
            _SemiAuto = value
            Call sbUpdateData(value)
        End Set
    End Property



    ''' <summary>
    ''' コピーストローク表示
    ''' コピーカッタの色表示が有効になるストローク
    ''' </summary>
    Public Property CopyCutEnableStroke As Integer
        Get
            Return _CopyCutEnableStroke
        End Get
        Set(value As Integer)
            _CopyCutEnableStroke = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' ジャッキ表示の周りのコピーの表示番号
    ''' </summary>
    Public Property CopySelect As Short
        Get
            Return _CopySelect
        End Get
        Set(value As Short)
            _CopySelect = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 減圧開始時のモーメント低減率
    ''' </summary>
    ''' <returns></returns>

    Public Property MomentRdductionRateOnReduce As Short
        Get
            Return _MomentRdductionRateOnReduce
        End Get
        Set(value As Short)
            _MomentRdductionRateOnReduce = value
            Call sbUpdateData(value)
        End Set
    End Property
    ''' <summary>
    ''' 片押し調整時のモーメント低減率
    ''' </summary>
    ''' <returns></returns>
    Public Property MomentRdductionRateOnOnewayLimit As Short
        Get
            Return _MomentRdductionRateOnOnewayLimit
        End Get
        Set(value As Short)
            _MomentRdductionRateOnOnewayLimit = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 組み立てピース数
    ''' </summary>
    ''' <returns></returns>
    Public Property AssemblyPieceNumber As Integer
        Get
            Return _AssemblyPieceNumber
        End Get
        Set(value As Integer)
            _AssemblyPieceNumber = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' ストローク補正値
    ''' ジャッキストローク演算にエラーが有った場合の補正値
    ''' リング更新でリセット
    ''' </summary>
    ''' <returns></returns>
    Public Property OffsetStroke As Integer
        Get
            Return _OffsetStroke
        End Get
        Set(value As Integer)
            _OffsetStroke = value
            Call sbUpdateData(value)
        End Set
    End Property

    ''' <summary>
    ''' 掘進開始時の平均ストローク
    ''' </summary>
    Private _StartAveJackStroke As Single

    Private _StartJackStroke As New Dictionary(Of Short, Integer)

    ''' <summary>
    ''' 掘進開始時の計測ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property StartJackStroke As Dictionary(Of Short, Integer)
        Get
            Return _StartJackStroke
        End Get
        Set(value As Dictionary(Of Short, Integer))
            _StartJackStroke = value

            For Each v In value
                'Dim tb As Odbc.OdbcDataReader =
                ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{v.Value}' 
        WHERE 項目名称='開始ジャッキストローク{v.Key}'")
                'tb.Close()
            Next
            '平均開始ストロークの算出
            _StartAveJackStroke =
                (From i In _StartJackStroke Where Not _ExceptMesureJackNo.Contains(i.Key) Select (i.Value)).Average
        End Set
    End Property


    Public ReadOnly Property StartAveStroke As Single
        Get
            Return _StartAveJackStroke
        End Get
    End Property


    Public ReadOnly Property WideUse As Dictionary(Of Short, String)
        Get
            Return _wideUse
        End Get
    End Property
    ''' <summary>
    ''' 減圧開始可能ストロークの設定
    ''' ストロークがセグメント幅＋この設定以上でサウンド出力
    ''' </summary>
    ''' <returns></returns>
    Public Property ReduceReachStrokeDiff As Integer
        Get
            Return _ReduceReachStrokeDiff
        End Get
        Set(value As Integer)
            _ReduceReachStrokeDiff = value
            Call sbUpdateData(value)

        End Set
    End Property

    ''' <summary>
    ''' 計算平均ジャッキオフセットストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property aveOffsetJackStroke As Integer
        Get
            Return _aveOffsetJackStroke
        End Get
        Set(value As Integer)
            _aveOffsetJackStroke = value
            Call sbUpdateData(value)

        End Set
    End Property
    ''' <summary>
    ''' 計測ジャッキオフセットストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property mesureOffsetJackStroke As Dictionary(Of Short, Integer)
        Get
            _mesureOffsetJackStroke = New Dictionary(Of Short, Integer)

            Dim OffsetJk As DataTable =
            GetDtfmSQL($"SELECT * FROM FLEX制御パラメータ  WHERE 項目名称 LIKE 'mesureOffsetJackStroke%'")
            If OffsetJk.Rows.Count = 0 Then
                For Each JkNo As Short In InitPara.MesureJackAngle.Keys
                    _mesureOffsetJackStroke.Add(JkNo, 0)
                Next
            Else
                '制御パラメータの値を読み込み
                For Each t As DataRow In OffsetJk.Rows
                    Dim jkNo As Short = t.Item("項目名称").ToString.Replace("mesureOffsetJackStroke", "")
                    If Not _mesureOffsetJackStroke.ContainsKey(jkNo) Then   '重複チェク
                        _mesureOffsetJackStroke.Add(jkNo, t.Item("値"))
                    End If
                Next
            End If
            Return _mesureOffsetJackStroke
        End Get

        Set(value As Dictionary(Of Short, Integer))
            _mesureOffsetJackStroke = value
            'Call sbUpdateData(value.ToString)
            If InitPara.ServerMode Then
                For Each fds As KeyValuePair(Of Short, Integer) In _mesureOffsetJackStroke
                    ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{fds.Value}' WHERE 項目名称 ='mesureOffsetJackStroke{fds.Key}'")
                Next
            End If
        End Set
    End Property




    Public Sub WideUseUpdate(iKey As Short, value As String)
        _wideUse.Item(iKey) = value

        Dim WdUsDtExist As DataTable =
            GetDtfmSQL($"SELECT * FROM FLEX制御パラメータ  WHERE 項目名称 ='wideuse{iKey}'")
        '存在しなかった場合
        If WdUsDtExist.Rows.Count <> 0 Then
            ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値='{value}' WHERE 項目名称 ='wideuse{iKey}'")
        Else
            ExecuteSqlCmd($"INSERT INTO FLEX制御パラメータ (`項目名称`,`値`) VALUES ('wideuse{iKey}','{value}') ")
        End If


    End Sub





    ''' <summary>
    ''' パラメータ読み込み
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadParameter()

        _wideUse = New Dictionary(Of Short, String)


        Dim OptGSetNum As New List(Of String)　'任意圧力設定グループ
        Dim OptGpSv As New Dictionary(Of Short, Single) '任意圧力設定値　グループ番号をkey
        'データテーブルの作成
        Dim CtlDt As DataTable =
            GetDtfmSQL("SELECT * FROM FLEX制御パラメータ ")

        Dim tb As New Dictionary(Of String, String)

        For Each dt As DataRow In CtlDt.Rows
            tb(dt("項目名称")) = dt("値")
        Next

        Dim chk As New clsCheckDictionary(tb, "FLEX制御パラメータ")


        _最低全開グループ数 = chk.GetValue("最低全開グループ数")
        _全開作動範囲 = chk.GetValue("全開作動範囲")
        _全開作動指令値 = chk.GetValue("全開作動指令値")
        '_全開グループ制限 = fnBoolean(chk.GetValue("全開グループ制限"))
        _最大全開出力時の目標圧力 = chk.GetValue("最大全開出力時の目標圧力")
        _最低制御圧力 = chk.GetValue("最低制御圧力")
        '_偏差角許容値 = chk.GetValue("偏差角許容値")
        '_PointX = chk.GetValue("PointX")
        '_PointY = chk.GetValue("PointY")
        _片押しR制限値 = chk.GetValue("片押しR制限値")
        _圧力許容値 = chk.GetValue("圧力許容値")
        _片押し制限フラグ = fnBoolean(chk.GetValue("片押し制限フラグ"))
        '_開始時の力点位置 = fnBoolean(chk.GetValue("開始時の力点位置"))
        '_ジャッキの間引き制御 = fnBoolean(chk.GetValue("ジャッキの間引き制御"))
        '_クリアランス計 = fnBoolean(chk.GetValue("クリアランス計"))
        _水平ジャッキ制御P定数 = chk.GetValue("水平ジャッキ制御P定数")
        _水平ジャッキ制御I定数 = chk.GetValue("水平ジャッキ制御I定数")
        _鉛直ジャッキ制御P定数 = chk.GetValue("鉛直ジャッキ制御P定数")
        _鉛直ジャッキ制御I定数 = chk.GetValue("鉛直ジャッキ制御I定数")
        _元圧フィルタ係数 = chk.GetValue("元圧フィルタ係数")
        _測量ポイントリング番号 = chk.GetValue("測量ポイントリング番号")
        _測量ポイント総距離 = chk.GetValue("測量ポイント総距離")
        _鉛直入力補正値 = chk.GetValue("鉛直入力補正値")
        _水平入力補正値 = chk.GetValue("水平入力補正値")
        _ジャッキモーメント上限値 = chk.GetValue("ジャッキモーメント上限値")
        _圧力制御開始推力値 = chk.GetValue("圧力制御開始推力値")
        _圧力制御開始推力値有効フラグ = fnBoolean(chk.GetValue("圧力制御開始推力値有効フラグ"))
        _全押しスタート = fnBoolean(chk.GetValue("全押しスタート"))

        _単位当r引き戻し量 = chk.GetValue("単位当r引き戻し量")
        _引き戻し実施間隔 = chk.GetValue("引き戻し実施間隔")

        _PitchingSel = chk.GetValue("PitchingSel")

        _RightStrokeDiff = fnBoolean(chk.GetValue("RightStrokeDiff", "True"))

        _TargetNetStroke = chk.GetValue("TargetNetStroke", 0)
        _TargetStrokeOverRate = chk.GetValue("TargetStrokeOverRate", 100)

        Dim Value As Boolean = fnBoolean(chk.GetValue("AutoDirectionControl"))
        If _AutoDirectionControl <> Value Then
            _AutoDirectionControl = Value
            RaiseEvent FlexAutoManualChange()
        End If

        _GraphStrokeWidth = chk.GetValue("GraphStrokeWidth")
        _HorMomentTrendWidth = chk.GetValue("HorMomentTrendWidth")
        _VerMomentTrendWidth = chk.GetValue("VerMomentTrendWidth")
        _HorDevDegTrendWidth = chk.GetValue("HorDevDegTrendWidth")
        _VerDevDegTrendWidth = chk.GetValue("VerDevDegTrendWidth")
        _LineDevStartRing = chk.GetValue("LineDevStartRing")
        _LineDevLastRing = chk.GetValue("LineDevLastRing")
        _PresBarGraphWidt = chk.GetValue("PresBarGraphWidt")
        _DevTolerance = chk.GetValue("DevTolerance")

        _LosZeroNlp = chk.GetValue("LosZeroNlp")
        _LosZeroEmp = chk.GetValue("LosZeroEmp")
        _LoszerorStep = chk.GetValue("LoszerorStep")

        _LosZeroRollingTake = fnBoolean(chk.GetValue("LosZeroRollingTake"))
        _LoszeroRollingTolerance = chk.GetValue("LoszeroRollingTolerance", "0.05")
        _LosZeroOpposeJackExcept = fnBoolean(chk.GetValue("LosZeroOpposeJackExcept", "False"))

        If InitPara.OpposeJackEnable Then
            _LosZeroOpposeJack = fnBoolean(chk.GetValue("LosZeroOpposeJack"))
            _LosZeroOpposeControl = fnBoolean(chk.GetValue("LosZeroOpposeControl"))
            _LosZeroOpposeGroupNumber = chk.GetValue("LosZeroOpposeGroupNumber")
            _LosZeroOpposeManualSV = chk.GetValue("LosZeroOpposeManualSV")
        Else
            _LosZeroOpposeJack = False
            _LosZeroOpposeControl = False
            _LosZeroOpposeGroupNumber = 0
        End If

        _ReduceTime = chk.GetValue("ReduceTime")
        _ReduceJudgePress = chk.GetValue("ReduceJudgePress")
        _NextPieceConfirm = chk.GetValue("NextPieceConfirm", "TRUE")
        _NextPieceConfirmTime = chk.GetValue("NextPieceConfirmTime", 5)
        _PIDShiftDefl = chk.GetValue("PIDShiftDefl")
        _DirectControl = fnBoolean(chk.GetValue("DirectControl"))
        _ReduceReachStrokeDiff = chk.GetValue("ReduceReachStrokeDiff", 0)

        _aveOffsetJackStroke = chk.GetValue("aveOffsetJackStroke", 0)

        _SemiAuto = chk.GetValue("SemiAuto", "FALSE")
        _CopyCutEnableStroke = chk.GetValue("CopyCutEnableStroke", 5)
        _CopySelect = chk.GetValue("CopySelect", 1)

        '減圧開始時のモーメント低減率
        _MomentRdductionRateOnReduce = chk.GetValue("MomentRdductionRateOnReduce", "80")
        '片押し調整時のモーメント低減率
        _MomentRdductionRateOnOnewayLimit = chk.GetValue("MomentRdductionRateOnOnewayLimit", "80")

        '組み立てピース数
        _AssemblyPieceNumber = chk.GetValue("AssemblyPieceNumber", "0")
        'ストローク補正値
        _OffsetStroke = chk.GetValue("OffsetStroke", "0")

        _optGpEn =
            (From k In Split(chk.GetValue("OptinalGroupSetNumber"), ",") Where IsNumeric(k) Select CShort(k)).ToList

        _ExceptMesureJackNo =
                            (From k In Split(chk.GetValue("ExceptMesureJackNo"), ",") Where IsNumeric(k) Select CShort(k)).ToList

        'Dim Numb As Short = chk.GetValue("項目名称").ToGetNum

        For Each k In tb
            If k.Key.Contains("開始ジャッキストローク") Then
                _StartJackStroke(k.Key.ToGetNum) = k.Value
            End If
            If k.Key.Contains("wideuse") Then
                _wideUse(k.Key.ToGetNum) = k.Value
            End If
            If k.Key.Contains("OptinalGroupSetValue") Then
                If k.Key.ToGetNum <= InitPara.NumberGroup Then
                    _optGpSv(k.Key.ToGetNum - 1) = k.Value
                End If
            End If
        Next

        '平均開始ストロークの算出
        _StartAveJackStroke =
                (From i In _StartJackStroke Where Not _ExceptMesureJackNo.Contains(i.Key) Select (i.Value)).Average

        '
        RaiseEvent ReferChnge()

    End Sub


    Private Sub sbUpdateData(ByRef value As Object)
        '呼び出し元のプロパティをフィールド名に
        Dim FieldName As String = New StackFrame(1).GetMethod.Name.Replace("set_", "")
        Dim WrValue As String
        If TypeOf value Is Boolean Then
            WrValue = IIf(value, "TRUE", "False")
        Else
            WrValue = value.ToString
        End If

        '現在の値と異なる場合のみUPDATE
        Dim NowVal As DataTable =
            GetDtfmSQL($"SELECT 値 FROM FLEX制御パラメータ WHERE 項目名称='{FieldName}'")
        If NowVal.Rows.Count = 0 Then
            ExecuteSqlCmd($"INSERT INTO FLEX制御パラメータ (`項目名称`,`値`) values('{FieldName}','{WrValue}')")
        Else
            If NowVal.Rows(0).Item(0) <> WrValue Then
                ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET 値 ='{WrValue}' WHERE 項目名称='{FieldName}'")
            End If
        End If

        Debug.WriteLine($"WrValue={WrValue} FieldName={FieldName}")

        'TODO DBに反映させる PLCアドレスの存在する場合は、PLC書込
    End Sub

    Private Function fnBoolean(ByRef o As Object) As Boolean
        If Not IsNothing(o) AndAlso (String.Compare(o.ToString, "ON", True) = 0 Or String.Compare(o.ToString, "TRUE", True) = 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New()

        '計測ジャッキストローク　初期化,フィールドの存在チェック
        For Each i As KeyValuePair(Of Short, Single) In InitPara.MesureJackAngle
            _StartJackStroke.Add(i.Key, 0)
            Dim tbchk1 As DataTable =
                GetDtfmSQL($"SELECT * FROM FLEX制御パラメータ WHERE 項目名称='開始ジャッキストローク{i.Key}'")
            If tbchk1.Rows.Count = 0 Then
                ExecuteSqlCmd($"INSERT INTO FLEX制御パラメータ (`項目名称`,`値`) VALUES ('開始ジャッキストローク{i.Key}','0') ")
            End If

            Dim tbchk2 As DataTable =
                GetDtfmSQL($"SELECT * FROM FLEX制御パラメータ WHERE 項目名称='mesureOffsetJackStroke{i.Key}'")
            If tbchk2.Rows.Count = 0 Then
                ExecuteSqlCmd($"INSERT INTO FLEX制御パラメータ (`項目名称`,`値`) VALUES ('mesureOffsetJackStroke{i.Key}','0') ")
            End If


        Next


        'パラメータ読込
        ReadParameter()
        'TimerRun()
    End Sub
End Class
