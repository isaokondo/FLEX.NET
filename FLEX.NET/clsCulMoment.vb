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
        If PlcIf.ExcaStatus <> cKussin Then Exit Sub


        Dim i As Short
        With InitParameter
            For i = 0 To .NumberJack - 1
                If PlcIf.JackSel(i) Then
                    ''水平方向のモーメントの演算    01/09/11 変更
                    _MomentX += Cos(.FaiJack(i) / 180 * PI) * PlcIf.GroupPv(.JackGroupPos(i) - 1) / .JackMaxOilPres * .JackPower * .JackRadius
                    ''鉛直方向のモーメントの演算    01/09/11 変更
                    _MomentY += Sin(.FaiJack(i) / 180 * PI) * PlcIf.GroupPv(.JackGroupPos(i) - 1) / .JackMaxOilPres * .JackPower * .JackRadius
                    ''推力の演算
                    If PlcIf.FlexControlOn Then
                        '' 01/09/04 変更    神谷部長指摘による
                        _Thrust += PlcIf.GroupPv(.JackGroupPos(i) - 1) / .JackMaxOilPres * .JackPower
                    Else
                        ''04/05/11 FLEXモードでないときの推力演算追加
                        If PlcIf.JackSel(i) Then _Thrust += .JackPower * PlcIf.JkPress / .JackMaxOilPres

                    End If
                End If
            Next i
            '方向を掘削管理のデータと合わせる
            _MomentX = -_MomentX
            _MomentY = -_MomentY

        End With
        ''合成値の演算
        _MomentR = Sqrt(_MomentX ^ 2 + _MomentY ^ 2)


    End Sub


End Class