Option Strict Off
Option Explicit On
Imports System.Math

Friend Class clsJkManualOut

    ' @(h) clsJkManualOut.cls                ver 1.0 ( '01.03.7 近藤　勲 )

    ' @(s)ジャッキ操作量の手動出力
    '

    Private _PointX As Single 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private _PointY As Single 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private _操作角 As Single 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private _操作強 As Single 'ﾛｰｶﾙ ｺﾋﾟｰ

    Private timer As Timer = New Timer()


    Public Sub New()
        '初期値はデータベースより
        _PointX = PlcIf.PointX
        _PointY = PlcIf.PointY
        '手動操作時は、1秒ごとに演算
        AddHandler Timer.Tick, New EventHandler(AddressOf sbCul)
        Timer.Interval = 1000   '1秒ごとの処理

    End Sub
    ''' <summary>
    ''' 手動操作演算ON
    ''' </summary>
    ''' <returns></returns>
    Public Property ManualOn As Boolean
        Get
            Return timer.Enabled
        End Get
        Set(value As Boolean)
            timer.Enabled = value
        End Set
    End Property


    ''ポイント座標が入力されたイベント
    Public Event PointChanges()

    Public ReadOnly Property 操作強() As Single
        Get
            操作強 = _操作強
        End Get
    End Property

    Public ReadOnly Property 操作角() As Single
        Get
            操作角 = _操作角
        End Get
    End Property


    Public ReadOnly Property PointY() As Single
        Get
            PointY = _PointY
        End Get
    End Property



    Public ReadOnly Property PointX() As Single
        Get
            PointX = _PointX
        End Get
    End Property

    Public Sub PutPointXY(ByVal dblPointX As Single, ByVal dblPointY As Single)
        ' @(f)
        '
        ' 機能      :ポイント座標ＸＹ入力時
        '
        ' 備考      :

        _PointX = dblPointX
        _PointY = dblPointY
        Call sbCul() ''操作強、操作角度算出
        timer.Enabled = True
    End Sub



    Private Sub sbCul()
        ' @(f)
        '
        ' 機能      :操作強、操作角度算出
        '
        ' 備考      :



        If fnNearZero(_PointX) And fnNearZero(_PointY) Then
            _操作角 = 0
            _操作強 = 0
        Else
            If fnNearZero(_PointX) And _PointY > 0 Then
                _操作角 = 90
            ElseIf fnNearZero(_PointX) And _PointY < 0 Then
                _操作角 = 270
            Else
                If _PointX > 0 And _PointY >= 0 Then
                    _操作角 = Atan(_PointY / _PointX) * 180 / PI
                ElseIf _PointX > 0 And _PointY < 0 Then
                    _操作角 = Atan(_PointY / _PointX) * 180 / PI + 360
                Else
                    _操作角 = Atan(_PointY / _PointX) * 180 / PI + 180
                End If
            End If
        End If
        _操作強 = Sqrt(_PointX ^ 2 + _PointY ^ 2)

        ''ポイント座標が入力され演算完了したイベント
        RaiseEvent PointChanges()

    End Sub
End Class