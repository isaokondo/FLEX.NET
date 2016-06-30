Option Strict Off
Option Explicit On
Friend Class clsJkManualOut

    ' @(h) clsJkManualOut.cls                ver 1.0 ( '01.03.7 近藤　勲 )

    ' @(s)ジャッキ操作量の手動出力
    '

    Private mdblPointX As Double 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private mdblPointY As Double 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private mdbl操作角 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private mdbl操作強 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ

    ''ポイント座標が入力されたイベント
    Public Event ValueChanges()

    Public ReadOnly Property 操作強() As Double
        Get
            操作強 = mdbl操作強
        End Get
    End Property

    Public ReadOnly Property 操作角() As Double
        Get
            操作角 = mdbl操作角
        End Get
    End Property


    Public Property PointY() As Double
        Get
            PointY = mdblPointY
        End Get
        Set(ByVal Value As Double)
            mdblPointY = Value
            Call sbCul() ''操作強、操作角度算出

        End Set
    End Property



    Public Property PointX() As Double
        Get
            PointX = mdblPointX
        End Get
        Set(ByVal Value As Double)
            mdblPointX = Value
            Call sbCul() ''操作強、操作角度算出
        End Set
    End Property

    Public Sub sbPutPointXY(ByVal dblPointX As Double, ByVal dblPointY As Double)
        ' @(f)
        '
        ' 機能      :ポイント座標ＸＹ入力時
        '
        ' 備考      :

        mdblPointX = dblPointX
        mdblPointY = dblPointY
        Call sbCul() ''操作強、操作角度算出
    End Sub



    Public Sub sbCul()
        ' @(f)
        '
        ' 機能      :操作強、操作角度算出
        '
        ' 備考      :



        If fnNearZero(mdblPointX) And fnNearZero(mdblPointY) Then
            mdbl操作角 = 0
            mdbl操作強 = 0
        Else
            If fnNearZero(mdblPointX) And mdblPointY > 0 Then
                mdbl操作角 = 90
            ElseIf fnNearZero(mdblPointX) And mdblPointY < 0 Then
                mdbl操作角 = 270
            Else
                If mdblPointX > 0 And mdblPointY >= 0 Then
                    mdbl操作角 = System.Math.Atan(mdblPointY / mdblPointX) * 180 / cPI
                ElseIf mdblPointX > 0 And mdblPointY < 0 Then
                    mdbl操作角 = System.Math.Atan(mdblPointY / mdblPointX) * 180 / cPI + 360
                Else
                    mdbl操作角 = System.Math.Atan(mdblPointY / mdblPointX) * 180 / cPI + 180
                End If
            End If
        End If
        mdbl操作強 = System.Math.Sqrt(mdblPointX ^ 2 + mdblPointY ^ 2)

        ''ポイント座標が入力され演算完了したイベント
        RaiseEvent ValueChanges()

    End Sub
End Class