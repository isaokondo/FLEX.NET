Option Strict Off
Option Explicit On
Imports System.Math

Friend Class clsCulMoment
    ' @(h) clsCulMoment.cls               ver 1.0 ( '01.03.29 近藤　勲 )
    ' @(h) clsCulMoment.cls               ver 1.1 ( '01.09.04 近藤　勲 )
    ' @(h) clsCulMoment.cls               ver 1.2 ( '01.09.11 近藤　勲 )
    '   推力演算パラメータを変更
    ' @(s) モーメントを求めるクラス
    '
    '
    Private _MomentX As Single ''Ｘ軸方向モーメント
    Private _MomentY As Single ''Ｙ軸方向モーメント
    Private _MomentR As Single ''合成モーメント
    Private _Thrust As Single ''推力
    Private _ThrustOnTime As Single ''掘削時の推力

    '入力
    Private _GroupPv As Single()
    Private _JackSel As Boolean()
    Private _FlexControlOn As Boolean
    Private _JkPress As Single
    Private _ExcaStatus As Integer

    Public WriteOnly Property GroupPv As Single()
        Set(value As Single())
            _GroupPv = value
        End Set
    End Property
    Public WriteOnly Property JackSel As Boolean()
        Set(value As Boolean())
            _JackSel = value
        End Set
    End Property

    Public WriteOnly Property FlexControlOn As Boolean
        Set(value As Boolean)
            _FlexControlOn = value
        End Set
    End Property
    Public WriteOnly Property JkPress As Single
        Set(value As Single)
            _JkPress = value
        End Set
    End Property
    Public WriteOnly Property ExcaStatus As Integer
        Set(value As Integer)
            _ExcaStatus = value
        End Set
    End Property


    Public ReadOnly Property MomentX() As Single
        Get
            MomentX = _MomentX
        End Get
    End Property
    Public ReadOnly Property MomentY() As Single
        Get
            MomentY = _MomentY
        End Get
    End Property
    Public ReadOnly Property MomentR() As Single
        Get
            MomentR = _MomentR
        End Get
    End Property
    Public ReadOnly Property Thrust() As Single
        Get
            Thrust = _Thrust
        End Get
    End Property

    Public ReadOnly Property ThrustOnTime As Single
        Get
            ThrustOnTime = _ThrustOnTime
        End Get
    End Property


    Public Sub MomentCul()
        ' @(f)
        '
        ' 機能      :モーメント、推力の計算
        '
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :
        _MomentX = 0
        _MomentY = 0
        _MomentR = 0

        _Thrust = 0

        ''掘進中以外は０に
        If _ExcaStatus <> cKussin Then Exit Sub


        Dim i As Short
        For i = 0 To InitPara.NumberJack - 1
            If _JackSel(i) Then
                'FLEX未使用時のモーメント演算用　ジャッキ選択時は元圧を使用
                Dim GpPv As Single = If(_FlexControlOn, _GroupPv(InitPara.JackGroupPos(i) - 1), PlcIf.JkPress)
                ''水平方向のモーメントの演算    01/09/11 変更
                _MomentX +=
                    Cos(InitPara.FaiJack(i).ToRad) * GpPv / InitPara.JackMaxOilPres * InitPara.JackPower * InitPara.JackRadius
                ''鉛直方向のモーメントの演算    01/09/11 変更
                _MomentY +=
                    Sin(InitPara.FaiJack(i).ToRad) * GpPv / InitPara.JackMaxOilPres * InitPara.JackPower * InitPara.JackRadius
                ''推力の演算
                If _FlexControlOn Then
                    '' 01/09/04 変更    神谷部長指摘による
                    _Thrust +=
                        GpPv / InitPara.JackMaxOilPres * InitPara.JackPower
                Else
                    ''04/05/11 FLEXモードでないときの推力演算追加
                    If _JackSel(i) Then
                        _Thrust +=
                            InitPara.JackPower * _JkPress / InitPara.JackMaxOilPres
                    End If

                End If
            End If
        Next i
        '方向を掘削管理のデータと合わせる
        _MomentX = -_MomentX
        _MomentY = -_MomentY

        ''合成値の演算
        _MomentR = Sqrt(_MomentX ^ 2 + _MomentY ^ 2)

        _ThrustOnTime = _Thrust

    End Sub


End Class