'Option Strict On
Option Explicit On
Public Class clsControlParameter
    Inherits clsDataBase

    Public Property Name As String


    Private _最低全開グループ数 As Short = 3
    Private _全開作動範囲 As Short = 35
    Private _全開作動指令値 As Short

    Private _全開グループ制限 As Boolean
    Private _最大全開出力時の目標圧力 As Single
    Private _偏差角許容値 As Single ''偏差角許容値
    Private _最低制御圧力 As Single

    ''力点座標
    Private _PointX As Double = 0 ''Ｘ座標
    Private _PointY As Double = 0 ''Ｙ座標

    Private _操作角 As Double
    Private _操作強 As Double



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

    Public Property 全開グループ制限() As Boolean
        Get
            Return _全開グループ制限

        End Get
        Set(ByVal Value As Boolean)
            _全開グループ制限 = Value
            Call sbUpdateData(Value)

        End Set
    End Property
    Public Property PointX() As Single
        Get
            Return _PointX
        End Get
        Set(ByVal Value As Single)
            _PointX = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property PointY() As Single
        Get
            Return _PointY
        End Get
        Set(ByVal Value As Single)
            _PointY = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property 操作角 As Single
        Get
            Return _操作角
        End Get
        Set(value As Single)
            _操作角 = value
            Call sbUpdateData(value)
        End Set
    End Property

    Public Property 操作強 As Single
        Get
            Return _操作強
        End Get
        Set(value As Single)
            _操作強 = value
            Call sbUpdateData(value)
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


    Public Property 偏差角許容値() As Single
        Get
            Return _偏差角許容値
        End Get
        Set(ByVal Value As Single)
            _偏差角許容値 = Value
            Call sbUpdateData(Value)
        End Set
    End Property
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
            For Each v In value
                Dim tb As Odbc.OdbcDataReader =
        ExecuteSql("UPDATE FLEX制御パラメータ SET`値`='" & v.Value &
                      "' WHERE `項目名称`='開始ジャッキストローク" & v.Key & "'")
            Next
        End Set
    End Property

    Public ReadOnly Property WideUse As Dictionary(Of Short, String)
        Get
            Return _wideUse
        End Get
    End Property

    Public Sub WideUseUpdate(iKey As Short, value As String)
        _wideUse.Item(iKey) = value
        Dim tb As Odbc.OdbcDataReader =
        ExecuteSql("UPDATE FLEX制御パラメータ SET`値`='" & value &
                      "' WHERE `項目名称`='wideuse" & iKey & "'")

    End Sub





    ''' <summary>
    ''' パラメータ読み込み
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadParameter()

        _wideUse = New Dictionary(Of Short, String)

        Dim DB As New clsDataBase

        Dim tb As Odbc.OdbcDataReader = DB.ExecuteSql("SELECT * FROM FLEX制御パラメータ ")
        With tb
            While tb.Read
                Try

                    'htPlcAdr(.Item("項目名称").ToString) = .Item("PLCアドレス")
                    'Console.WriteLine(tb.Item("項目名称").ToString)

                    Select Case tb.Item("項目名称").ToString
                        Case "最低全開グループ数"
                            _最低全開グループ数 = .Item("値")
                        Case "全開作動範囲"
                            _全開作動範囲 = .Item("値")
                        Case "全開作動指令値"
                            _全開作動指令値 = .Item("値")
                        Case "全開グループ制限"
                            _全開グループ制限 = fnBoolean(.Item("値"))
                        Case "最大全開出力時の目標圧力"
                            _最大全開出力時の目標圧力 = .Item("値")
                        Case "最低制御圧力"
                            _最低制御圧力 = .Item("値")
                        Case "偏差角許容値"
                            _偏差角許容値 = .Item("値")
                        Case "PointX"
                            _PointX = .Item("値")
                        Case "PointY"
                            _PointY = .Item("値")
                        Case "片押しR制限"
                            _片押しR制限 = .Item("値")
                        Case "圧力許容値"
                            _圧力許容値 = .Item("値")
                        Case "片押し制限フラグ"
                            _片押し制限フラグ = fnBoolean(.Item("値"))
                        Case "開始時の力点位置"
                            _開始時の力点位置 = fnBoolean(.Item("値"))
                        Case "ジャッキの間引き制御"
                            _ジャッキの間引き制御 = fnBoolean(.Item("値"))
                        Case "クリアランス計"
                            _クリアランス計 = fnBoolean(.Item("値"))
                        Case "水平ジャッキ制御P定数"
                            _水平ジャッキ制御P定数 = .Item("値")
                        Case "水平ジャッキ制御I定数"
                            _水平ジャッキ制御I定数 = .Item("値")
                        Case "鉛直ジャッキ制御P定数"
                            _鉛直ジャッキ制御P定数 = .Item("値")
                        Case "鉛直ジャッキ制御I定数"
                            _鉛直ジャッキ制御I定数 = .Item("値")
                        Case "元圧フィルタ係数"
                            _元圧フィルタ係数 = .Item("値")
                        Case "測量ポイントリング番号"
                            _測量ポイントリング番号 = .Item("値")
                        Case "測量ポイント総距離"
                            _測量ポイント総距離 = .Item("値")
                        Case "鉛直入力補正値"
                            _鉛直入力補正値 = .Item("値")
                        Case "水平入力補正値"
                            _水平入力補正値 = .Item("値")
                        Case "ジャッキモーメント上限値"
                            _ジャッキモーメント上限値 = .Item("値")
                        Case "圧力制御開始推力値"
                            _圧力制御開始推力値 = .Item("値")
                        Case "圧力制御開始推力値有効フラグ"
                            _圧力制御開始推力値有効フラグ = fnBoolean(.Item("値"))
                        Case "全押しスタート"
                            _全押しスタート = fnBoolean(.Item("値"))
                        Case "AutoDirectionControl"
                            Dim Value As Boolean = fnBoolean(.Item("値"))
                            If _AutoDirectionControl <> Value Then
                                _AutoDirectionControl = Value
                                RaiseEvent FlexAutoManualChange()
                            End If
                        Case "GraphStrokeWidth"
                            _GraphStrokeWidth = .Item("値")
                        Case "HorMomentTrendWidth"
                            _HorMomentTrendWidth = .Item("値")
                        Case "VerMomentTrendWidth"
                            _VerMomentTrendWidth = .Item("値")
                        Case "HorDevDegTrendWidth"
                            _HorDevDegTrendWidth = .Item("値")
                        Case "VerDevDegTrendWidth"
                            _VerDevDegTrendWidth = .Item("値")
                        Case "LineDevStartRing"
                            _LineDevStartRing = .Item("値")
                        Case "LineDevLastRing"
                            _LineDevLastRing = .Item("値")
                        Case "PresBarGraphWidt"
                            _PresBarGraphWidt = .Item("値")
                        Case "DevTolerance"
                            _DevTolerance = .Item("値")

                        Case "LosZeroRollingTake"
                            _LosZeroRollingTake = fnBoolean(.Item("値"))
                        Case "LosZeroOpposeJack"
                            _LosZeroOpposeJack = fnBoolean(.Item("値"))
                        Case "LosZeroOpposeControl"
                            _LosZeroOpposeControl = fnBoolean(.Item("値"))

                        Case "ReduceTime"
                            _ReduceTime = .Item("値")
                        Case "ReduceJudgePress"
                            _ReduceJudgePress = .Item("値")
                        Case "NextPieceConfirm"
                            _NextPieceConfirm = .Item("値")
                        Case "PIDShiftDefl"
                            _PIDShiftDefl = .Item("値")
                        Case "DirectControl"
                            _DirectControl = fnBoolean(.Item("値"))
                    End Select

                    If .Item("項目名称").ToString.IndexOf("開始ジャッキストローク") >= 0 Then
                        _StartJackStroke(CShort(.Item("項目名称").ToString.Replace("開始ジャッキストローク", ""))) = .Item("値")
                    End If


                    If .Item("項目名称").ToString.IndexOf("wideuse") >= 0 Then
                        _wideUse(CShort(.Item("項目名称").ToString.Replace("wideuse", ""))) = .Item("値")
                    End If


                Catch ex As Exception
                    Debug.WriteLine("Err" & .Item("項目名称").ToString)
                End Try

            End While
        End With




    End Sub

    Private Sub sbUpdateData(value As Dictionary(Of Short, String))
        'TODO:これから
        MsgBox("'TODO:これから")
    End Sub

    Private Sub sbUpdateData(ByRef value As Object)
        'Debug.Print(New StackFrame(1).GetMethod.Name)
        '呼び出し元のプロパティをフィールド名に
        Dim FieldName As String = New StackFrame(1).GetMethod.Name.Replace("set_", "")
        Dim DB As New clsDataBase
        Dim WrValue As String
        If TypeOf value Is Boolean Then
            WrValue = IIf(value, "TRUE", "False")
        Else
            WrValue = value.ToString
        End If

        Dim tb As Odbc.OdbcDataReader =
        DB.ExecuteSql("UPDATE FLEX制御パラメータ SET`値`='" & WrValue &
                      "' WHERE `項目名称`='" & FieldName & "'")



        'TODO DBに反映させる PLCアドレスの存在する場合は、PLC書込
    End Sub

    Private Function fnBoolean(ByRef o As Object) As Boolean
        If String.Compare(o.ToString, "ON", True) = 0 Or String.Compare(o.ToString, "TRUE", True) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New()

        '計測ジャッキストローク　初期化
        For Each i As KeyValuePair(Of Short, Single) In InitParameter.MesureJackAngle
            _StartJackStroke.Add(i.Key, 0)
        Next
        'パラメータ読込
        ReadParameter()
        'TimerRun()
    End Sub
End Class
