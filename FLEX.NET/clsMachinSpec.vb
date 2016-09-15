'Option Strict On
Option Explicit On
Public Class clsMachinSpec
    Inherits clsDataBase

    Private _MachineLength As Single

    Private _ZendoLen As Single ''前胴長(m)
    Private _KodoLen As Single ''後胴前(m)

    Private _HorSenkaiCyuushin As Single ''中折れ特殊計算をしない時の旋回位置（平面）
    Private _VerSenkaiCyuushin As Single ''中折れ特殊計算をしない時の旋回位置（縦断）


    Private _ShieldTypeHor As Short 'ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの平面中折れ使用（0:使用しない 1:使用する）
    Private _ShieldTypeVer As Short ''ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの縦断中折れ使用（0:使用しない 1:使用する）

    Private _HorZendoCenter As Single ''前胴中心(m)
    Private _HorKodoCenter As Single ''後胴中心(m)
    Private _HorSel As Short ''平面設定方法（中折計算の方法）

    Private _VerZendoCenter As Single ''前胴中心(m)
    Private _VerKodoCenter As Single ''後胴中心(m)
    Private _VerSel As Short ''縦断設定方法（中折計算の方法）

    Public Sub New()
        DataRead()
    End Sub

    Public ReadOnly Property MachiLength() As Single
        Get
            Return _MachineLength
        End Get
    End Property


    Public ReadOnly Property ZendoLen As Single
        Get
            Return _ZendoLen
        End Get
    End Property


    Public ReadOnly Property KodoLen As Single
        Get
            Return _KodoLen
        End Get
    End Property

    Public ReadOnly Property HorSenkaiCyuushin As Single
        Get
            Return _HorSenkaiCyuushin
        End Get
    End Property

    Public ReadOnly Property VerSenkaiCyuushin As Single
        Get
            Return _VerSenkaiCyuushin
        End Get
    End Property

    Public ReadOnly Property ShieldTypeHor As Short
        Get
            Return _ShieldTypeHor
        End Get
    End Property

    Public ReadOnly Property ShieldTypeVer As Short
        Get
            Return _ShieldTypeVer
        End Get
    End Property
    Public ReadOnly Property HorZendoCenter As Single
        Get
            Return _HorZendoCenter
        End Get
    End Property

    Public ReadOnly Property HorKodoCenter As Single
        Get
            Return _HorKodoCenter
        End Get
    End Property

    Public ReadOnly Property VerZendoCenter As Single
        Get
            Return _VerZendoCenter
        End Get
    End Property

    Public ReadOnly Property VerKodoCenter As Single
        Get
            Return _VerKodoCenter
        End Get
    End Property

    Public ReadOnly Property HorSel As Short
        Get
            Return _HorSel
        End Get
    End Property

    Public ReadOnly Property VerSel As Short
        Get
            Return _VerSel
        End Get
    End Property
    ''' <summary>
    ''' マシンデータより諸元読込
    ''' </summary>
    Public Sub DataRead()
        ''選択クエリー実行
        Dim rsData As Odbc.OdbcDataReader = ExecuteSql("SELECT * FROM シールド機データ３;")
        With rsData
            .Read()
            _ZendoLen = .Item("前胴長")
            _KodoLen = .Item("後胴長")
            _MachineLength = .Item("機長")
            ''08/08/27 追加

            _ShieldTypeHor = .Item("平面中折れ使用")
            _HorSenkaiCyuushin = .Item("平面旋回中心")
            _HorSel = .Item("平面設定方法")
            _HorZendoCenter = .Item("平面前胴中心")
            _HorKodoCenter = .Item("平面後胴中心")

            _ShieldTypeVer = .Item("縦断中折れ使用")
            _VerSenkaiCyuushin = .Item("縦断旋回中心")
            _VerSel = .Item("縦断設定方法")
            _VerZendoCenter = .Item("縦断前胴中心")
            _VerKodoCenter = .Item("縦断後胴中心")
            .Close()
        End With
    End Sub

End Class
