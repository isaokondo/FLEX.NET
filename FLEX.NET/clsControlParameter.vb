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



    Private _片押しR制限 As Single = 2
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


    Private _LosZeroRollingTake As Boolean  '同時施工：ローリング考慮
    Private _LosZeroOpposeJack As Boolean '対抗ジャッキ選択
    Private _LosZeroOpposeControl As Boolean '対抗圧制御

    Private _ReduceTime As Integer '減圧時間（単位：SEC）
    Private _ReduceJudgePress As Single '減圧完了判断圧力(Mpa)
    Private _NextPieceConfirm As Boolean    '次ピース組立確認

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
                ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET`値`='{_optGpSv(i)}'
                    WHERE `項目名称`='OptinalGroupSetValue{i + 1}'")
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
            ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET`値`='{String.Join(",", _optGpEn.ToArray)}'
                WHERE `項目名称`='OptinalGroupSetNumber'")
        End Set
    End Property

    Public Property ExceptMesureJackNo As List(Of Short)
        Get
            Return _ExceptMesureJackNo
        End Get
        Set(value As List(Of Short))
            _ExceptMesureJackNo = value

            'Dim tb As Odbc.OdbcDataReader =
            ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET`値`='{String.Join(",", _ExceptMesureJackNo.ToArray)}'
                WHERE `項目名称`='ExceptMesureJackNo'")
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

    'Public Property 全開グループ制限() As Boolean
    '    Get
    '        Return _全開グループ制限

    '    End Get
    '    Set(ByVal Value As Boolean)
    '        _全開グループ制限 = Value
    '        Call sbUpdateData(Value)

    '    End Set
    'End Property
    'todo:力点と操作角、操作強を同時に更新したい！
    'Public Property PointX() As Single
    '    Get
    '        Return _PointX
    '    End Get
    '    Set(ByVal Value As Single)
    '        _PointX = Value
    '        Call sbUpdateData(Value)
    '    End Set
    'End Property

    'Public Property PointY() As Single
    '    Get
    '        Return _PointY
    '    End Get
    '    Set(ByVal Value As Single)
    '        _PointY = Value
    '        Call sbUpdateData(Value)
    '    End Set
    'End Property

    'Public Property 操作角 As Single
    '    Get
    '        Return _操作角
    '    End Get
    '    Set(value As Single)
    '        _操作角 = value
    '        Call sbUpdateData(value)
    '    End Set
    'End Property

    'Public Property 操作強 As Single
    '    Get
    '        Return _操作強
    '    End Get
    '    Set(value As Single)
    '        _操作強 = value
    '        Call sbUpdateData(value)
    '    End Set
    'End Property

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
    Public Property 片押しR制限() As Single
        Get
            Return _片押しR制限

        End Get
        Set(ByVal Value As Single)
            _片押しR制限 = Value
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

    Public Property クリアランス計 As Boolean
        Get
            Return _クリアランス計
        End Get
        Set(value As Boolean)
            _クリアランス計 = value
            Call sbUpdateData(value)
        End Set
    End Property
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
    ''' 対抗圧制御
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
    ''' 掘進開始時の平均ストローク
    ''' </summary>
    Private _StartAveJackStroke As Integer

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
                ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET`値`='{v.Value}' 
        WHERE `項目名称`='開始ジャッキストローク{v.Key}'")
                'tb.Close()
            Next
            '平均開始ストロークの算出
            '_StartAveJackStroke =
            '    (From i In _StartJackStroke Where Not _ExceptMesureJackNo.Contains(i.Key) Select (i.Value)).Average
        End Set
    End Property


    Public ReadOnly Property StartAveStroke As Integer
        Get
            Return _StartAveJackStroke
        End Get
    End Property



    Public ReadOnly Property WideUse As Dictionary(Of Short, String)
        Get
            Return _wideUse
        End Get
    End Property

    Public Sub WideUseUpdate(iKey As Short, value As String)
        _wideUse.Item(iKey) = value
        'Dim tb As Odbc.OdbcDataReader =
        ExecuteSqlCmd($"UPDATE FLEX制御パラメータ SET`値`='{value}' WHERE `項目名称`='wideuse{iKey}'")
        'tb.Close()

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
        _片押しR制限 = chk.GetValue("片押しR制限値")
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
        _LosZeroRollingTake = fnBoolean(chk.GetValue("LosZeroRollingTake"))
        _LosZeroOpposeJack = fnBoolean(chk.GetValue("LosZeroOpposeJack"))
        _LosZeroOpposeControl = fnBoolean(chk.GetValue("LosZeroOpposeControl"))
        _ReduceTime = chk.GetValue("ReduceTime")
        _ReduceJudgePress = chk.GetValue("ReduceJudgePress")
        _NextPieceConfirm = chk.GetValue("NextPieceConfirm")
        _PIDShiftDefl = chk.GetValue("PIDShiftDefl")
        _DirectControl = fnBoolean(chk.GetValue("DirectControl"))

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
                OptGpSv(k.Key.ToGetNum - 1) = k.Value
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


        'Dim tb As Odbc.OdbcDataReader =
        ExecuteSqlCmd("UPDATE FLEX制御パラメータ SET`値`='" & WrValue &
                      "' WHERE `項目名称`='" & FieldName & "'")

        'tb.Close()

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
            Dim tbchk As DataTable =
                GetDtfmSQL($"SELECT * FROM FLEX制御パラメータ WHERE `項目名称`='開始ジャッキストローク{i.Key}'")
            If tbchk.Rows.Count = 0 Then
                MsgBox($"項目名　開始ジャッキストローク{i.Key}が、存在しません。{vbCrLf}テーブル「FLEX制御パラメータ」に追加してください", vbExclamation)
            End If
            'Dim tbchk As Odbc.OdbcDataReader =
            '    ExecuteSql($"SELECT * FROM FLEX制御パラメータ WHERE `項目名称`='開始ジャッキストローク{i.Key}'")
            'If Not tbchk.HasRows Then
            '    MsgBox($"項目名　開始ジャッキストローク{i.Key}が、存在しません。{vbCrLf}テーブル「FLEX制御パラメータ」に追加してください", vbExclamation)
            'End If
            'tbchk.Close()

        Next


        'パラメータ読込
        ReadParameter()
        'TimerRun()
    End Sub
End Class
