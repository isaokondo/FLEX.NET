
Option Explicit On
Friend Class clsCulcDistance
    ' @(h) clsCulcDistance.cls                ver 1.2 ( '03.10.20 近藤　勲 )
    ' 掘進総距離の演算変更

    ' @(h) clsCulcDistance.cls                ver 1.1 ( '03.04.24 近藤　勲 )
    ' 飛島堀川より修正
    ' セグメント幅が異なるときのバグがあり！！
    ' 他現場にも反映

    ' @(h) clsCulcDistance.cls                ver 1.0 ( '01.02.15 近藤　勲 )

    ' @(s) 掘進総距離を求めるクラス
    '
    '

    Private _測量ポイントリング番号 As Short
    Private _測量ポイント総距離 As Double
    Private _NowRingNo As Short

    Private _現リング総距離 As Double

    ''鹿島品川線より追加
    'Private mblnChangeFlg As Boolean ''リング番号、測量ポイントのリング番号および総距離が変化したか？

    Private _掘進総距離 As Double

    Private _SegWdAddDist As Double 'セグメント追加距離
    ''' <summary>
    ''' 押し上がりストロークの差
    ''' </summary>
    Private _LastStrokeDiff As Double
    ''' <summary>
    ''' 当リングの始点の先端距離
    ''' </summary>
    Private _StartThisRingDist As Double
    ''' <summary>
    ''' 現在のリング番号
    ''' </summary>
    Public WriteOnly Property NowRingNo() As Short
        Set(ByVal Value As Short)
            _NowRingNo = Value
        End Set
    End Property

    Public ReadOnly Property 掘進総距離() As Double
        Get

            Call sbCulDistance()
            Return _掘進総距離
        End Get
    End Property

    Public Property 測量ポイント総距離() As Double
        Get
            Return _測量ポイント総距離
        End Get
        Set(ByVal Value As Double)
            _測量ポイント総距離 = Value
        End Set
    End Property

    Public WriteOnly Property 測量ポイントリング番号() As Short
        Set(ByVal Value As Short)
            _測量ポイントリング番号 = Value
        End Set
    End Property

    ''' <summary>
    ''' セグメント幅の追加距離
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegWdAddDist As Double
        Get
            Return _SegWdAddDist
        End Get
    End Property
    ''' <summary>
    ''' 押し上がりストロークの差
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LastStrokeDiff As Double
        Get
            Return _LastStrokeDiff
        End Get
    End Property

    ''' <summary>
    ''' 当リングの始点の先端距離
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property StartThisRingDist As Double
        Get
            Return _StartThisRingDist
        End Get
    End Property


    Private Function GetHoseiSegmentWidth(ByVal dblStartDis As Double, ByVal dblLastDis As Double) As Double
        ' @(f)
        '
        ' 機能      :セグメント幅の補正
        '
        ' 返り値    :なし
        ' 　　　    :
        '
        ' 機能説明  :縦断勾配よりセグメント幅の水平距離を換算する
        '
        ' 備考      :鹿島品川線より

        Dim dblStartZ As Double ''Ｚ座標初め
        Dim dblLastZ As Double ''Ｚ座標終わり

        Dim SegmentKijun As New clsLineMake
        SegmentKijun = New clsLineMake
        SegmentKijun.縦断掘進累積距離 = dblStartDis
        dblStartZ = SegmentKijun.Z座標
        SegmentKijun.縦断掘進累積距離 = dblStartDis + dblLastDis
        dblLastZ = SegmentKijun.Z座標

        Dim dblDeltaZ As Double ''２点のレベル差
        dblDeltaZ = dblStartZ - dblLastZ
        Return System.Math.Sqrt(dblLastDis ^ 2 - dblDeltaZ ^ 2)

    End Function


    ''' <summary>
    ''' 掘進総距離の演算
    ''' </summary>
    Private Sub sbCulDistance()
        ''堀川シールドにて大幅修正　03/04/24
        ''堀川シールドにてさらに大幅修正　03/10/20

        'On Error GoTo ErrTrap

        ''掘進総距離のベース距離
        _掘進総距離 = _測量ポイント総距離


        Dim i As Short

        If PlcIf.ExcaStatus = cTaiki Then ''待機中

            If _NowRingNo - _測量ポイントリング番号 <= 1 Then

            Else
                ''現在のリング番号-測量リング>1　のとき
                For i = _測量ポイントリング番号 To _NowRingNo - 2
                    _掘進総距離 +=
                         GetHoseiSegmentWidth(_掘進総距離, SegAsmblyData.TypeData(i).CenterWidth)
                Next i
                _SegWdAddDist = _掘進総距離 - _測量ポイント総距離
                _LastStrokeDiff =
                    -SegAsmblyData.RingLastStroke(_測量ポイントリング番号) / 1000 + GetHoseiSegmentWidth(_掘進総距離, SegAsmblyData.RingLastStroke(_NowRingNo - 1) / 1000)
                _掘進総距離 += _LastStrokeDiff
                _StartThisRingDist = _掘進総距離
            End If

        Else
            ''掘進中or中断中
            For i = _測量ポイントリング番号 To _NowRingNo - 1
                _掘進総距離 +=
                    GetHoseiSegmentWidth(_掘進総距離, SegAsmblyData.TypeData(i).CenterWidth)
            Next i
            _現リング総距離 = _掘進総距離
            _SegWdAddDist = _掘進総距離 - _測量ポイント総距離
            _StartThisRingDist = _掘進総距離 - SegAsmblyData.RingLastStroke(_測量ポイントリング番号) / 1000 + CtlPara.StartAveStroke / 1000
            If PlcIf.SegmentMode Then
                _LastStrokeDiff =
                -SegAsmblyData.RingLastStroke(_測量ポイントリング番号) / 1000 + GetHoseiSegmentWidth(_掘進総距離, SegAsmblyData.RingLastStroke(_NowRingNo) / 1000)
            Else

                _LastStrokeDiff =
                -SegAsmblyData.RingLastStroke(_測量ポイントリング番号) / 1000 + GetHoseiSegmentWidth(_掘進総距離, CalcStroke.MesureCalcAveJackStroke / 1000)
            End If
            _掘進総距離 += _LastStrokeDiff

        End If

        Exit Sub
ErrTrap:
        If Err.Number = 9 Then
            'MsgBox ("リング番号に０が入力されてます。確認してください")
        Else
            MsgBox(Err.Description)
        End If
    End Sub
End Class