'Option Strict On
Option Explicit On
Public Class clsControlParameter
    Inherits clsDataBase

    Public Property Name As String


    Private _最低全開グループ数 As Short
    Private _全開作動範囲 As Short
    Private _全開作動指令値 As Short

    Private _全開グループ制限 As Boolean
    Private _最大全開出力時の目標圧力 As Single
    Private _偏差角許容値 As Single ''偏差角許容値

    ''力点座標
    Private _PointX As Double ''Ｘ座標
    Private _PointY As Double ''Ｙ座標


    Private _片押しR制限 As Single
    Private _圧力許容値 As Single
    Private _片押し制限フラグ As Boolean

    Private _水平ジャッキ制御P定数 As Short
    Private _水平ジャッキ制御I定数 As Short
    Private _鉛直ジャッキ制御P定数 As Short
    Private _鉛直ジャッキ制御I定数 As Short


    Private _元圧フィルタ係数 As Short

    Private _測量ポイントリング番号 As Short ''測量ポイントリング番号
    Private _測量ポイント総距離 As Double ''測量ポイント総距離
    Private _鉛直入力補正値 As Double ''鉛直入力補正値
    Private _水平入力補正値 As Double ''水平入力補正値
    Private _ジャッキモーメント上限値 As Double ''ジャッキモーメント上限値

    Private _圧力制御開始推力値 As Double ''圧力制御開始推力値
    Private _圧力制御開始推力値有効フラグ As Boolean ''圧力制御開始推力値有効フラグ
    Private _全押しスタート As Boolean ''全押しスタート

    'パラメータに対応するPLCアドレスのハッシュテーブル
    Private htPlcAdr As Hashtable = New Hashtable



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
    Public Property PointX() As Double
        Get
            Return _PointX
        End Get
        Set(ByVal Value As Double)
            _PointX = Value
            Call sbUpdateData(Value)
        End Set
    End Property

    Public Property PointY() As Double
        Get
            Return _PointY
        End Get
        Set(ByVal Value As Double)
            _PointY = Value
            Call sbUpdateData(Value)
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

    Public Property 最大全開出力時の目標圧力() As Single
        Get
            Return _最大全開出力時の目標圧力
        End Get
        Set(ByVal Value As Single)
            _最大全開出力時の目標圧力 = Value
            Call sbUpdateData(Value)
        End Set
    End Property



    Public Property 測量ポイントリング番号() As Short
        Get
            Return _測量ポイントリング番号

        End Get
        Set(ByVal Value As Short)
            _測量ポイントリング番号 = Value
            Call sbUpdateData(Value)
        End Set

    End Property

    Public Property 測量ポイント総距離() As Double
        Get
            Return _測量ポイント総距離

        End Get
        Set(ByVal Value As Double)
            _測量ポイント総距離 = Value
            Call sbUpdateData(Value)
        End Set

    End Property
    Public Property 鉛直入力補正値() As Double
        Get
            Return _鉛直入力補正値

        End Get
        Set(ByVal Value As Double)
            _鉛直入力補正値 = Value
            Call sbUpdateData(Value)
        End Set

    End Property
    Public Property 水平入力補正値() As Double
        Get
            Return _水平入力補正値

        End Get
        Set(ByVal Value As Double)
            _水平入力補正値 = Value
            Call sbUpdateData(Value)
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

    ''' <summary>
    ''' パラメータ読み込み
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadParameter()
        Dim DB As New clsDataBase

        Dim tb As Odbc.OdbcDataReader = DB.ExecuteSql("SELECT * FROM 制御パラメータ ")
        With tb
            While tb.Read

                htPlcAdr(.Item("項目名称").ToString) = .Item("PLCアドレス")

                Select Case .Item("項目名称").ToString
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
                End Select

            End While
        End With




    End Sub

    Private Sub sbUpdateData(ByRef value As String)
        Debug.Print(New StackFrame(1).GetMethod.Name)
        '呼び出し元のプロパティをフィールド名に
        Dim FieldName As String = New StackFrame(1).GetMethod.Name.Trim("set_")
        Dim DB As New clsDataBase

        Dim tb As Odbc.OdbcDataReader = _
        DB.ExecuteSql("UPDATE 制御パラメータ SET`値`='" & value & _
                      "' WHERE `項目名称`='" & FieldName & "'")



        'TODO DBに反映させる PLCアドレスの存在する場合は、PLC書込
    End Sub

    Private Function fnBoolean(ByRef o As Object) As Boolean
        If o.ToString = "ON" Or o.ToString = "TRUE" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub New()
        Call ReadParameter()
    End Sub
End Class
