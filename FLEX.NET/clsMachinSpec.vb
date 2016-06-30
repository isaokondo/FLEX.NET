Option Strict On
Option Explicit On
Public Class clsMachinSpec
    Inherits clsDataBase

    Private msng機長 As Single

    Private msngZendoLen As Single ''前胴長(m)
    Private msngKodoLen As Single ''後胴前(m)

    Private msngHorSenkaiCyuushin As Single ''中折れ特殊計算をしない時の旋回位置（平面）
    Private msngVerSenkaiCyuushin As Single ''中折れ特殊計算をしない時の旋回位置（縦断）


    Private mintShieldTypeHor As Short 'ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの平面中折れ使用（0:使用しない 1:使用する）
    Private mintShieldTypeVer As Short ''ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの縦断中折れ使用（0:使用しない 1:使用する）

    Private msngHorZendoCenter As Single ''前胴中心(m)
    Private msngHorKodoCenter As Single ''後胴中心(m)
    Private mintHorSel As Short ''平面設定方法（中折計算の方法）

    Private msngVerZendoCenter As Single ''前胴中心(m)
    Private msngVerKodoCenter As Single ''後胴中心(m)
    Private mintVerSel As Short ''縦断設定方法（中折計算の方法）

    Public ReadOnly Property 機長() As Single
        Get
            Return msng機長
        End Get
    End Property


    Public ReadOnly Property ZendoLen As Single
        Get
            Return msngZendoLen
        End Get
    End Property


    Public ReadOnly Property KodoLen As Single
        Get
            Return msngKodoLen
        End Get
    End Property

    Public ReadOnly Property HorSenkaiCyuushin As Single
        Get
            Return msngHorSenkaiCyuushin
        End Get
    End Property

    Public ReadOnly Property VerSenkaiCyuushin As Single
        Get
            Return msngVerSenkaiCyuushin
        End Get
    End Property

    Public ReadOnly Property ShieldTypeHor As Short
        Get
            Return mintShieldTypeHor
        End Get
    End Property

    Public ReadOnly Property ShieldTypeVer As Short
        Get
            Return mintShieldTypeVer
        End Get
    End Property
    Public ReadOnly Property HorZendoCenter As Single
        Get
            Return msngHorZendoCenter
        End Get
    End Property

    Public ReadOnly Property HorKodoCenter As Single
        Get
            Return msngHorKodoCenter
        End Get
    End Property

    Public ReadOnly Property VerZendoCenter As Single
        Get
            Return msngVerZendoCenter
        End Get
    End Property

    Public ReadOnly Property VerKodoCenter As Single
        Get
            Return msngVerKodoCenter
        End Get
    End Property

    Public ReadOnly Property HorSel As Short
        Get
            Return mintHorSel
        End Get
    End Property

    Public ReadOnly Property VerSel As Short
        Get
            Return mintVerSel
        End Get
    End Property

    'TODO:線形管理　マシンデータより読み込み処理

End Class
