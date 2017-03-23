Option Strict On
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

    Private mint測量ポイントリング番号 As Short
    Private mdbl測量ポイント総距離 As Double
    Private mint現在のリング番号 As Short

    Private mdbl現リング総距離 As Double

    ''鹿島品川線より追加
    Private mblnChangeFlg As Boolean ''リング番号、測量ポイントのリング番号および総距離が変化したか？

    Private mdbl掘進総距離 As Double

    Public WriteOnly Property 現在のリング番号() As Short
        Set(ByVal Value As Short)
            mblnChangeFlg = mblnChangeFlg Or (Value <> mint現在のリング番号) ''鹿島品川線より追加
            mint現在のリング番号 = Value
        End Set
    End Property

    Public ReadOnly Property 掘進総距離() As Double
        Get

            Call sbCulDistance()
            Return mdbl掘進総距離
        End Get
    End Property

    Public Property 測量ポイント総距離() As Double
        Get
            Return mdbl測量ポイント総距離
        End Get
        Set(ByVal Value As Double)
            mblnChangeFlg = mblnChangeFlg Or (Value <> mdbl測量ポイント総距離) ''鹿島品川線より追加
            mdbl測量ポイント総距離 = Value
        End Set
    End Property

    Public WriteOnly Property 測量ポイントリング番号() As Short
        Set(ByVal Value As Short)
            mblnChangeFlg = mblnChangeFlg Or (Value <> mint測量ポイントリング番号) ''鹿島品川線より追加
            mint測量ポイントリング番号 = Value
        End Set
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



    Private Sub sbCulDistance()
        ''堀川シールドにて大幅修正　03/04/24
        ''堀川シールドにてさらに大幅修正　03/10/20

        'On Error GoTo ErrTrap

        ''掘進総距離のベース距離
        mdbl掘進総距離 = mdbl測量ポイント総距離


        Dim i As Short

        If PlcIf.ExcaStatus = cTaiki Then ''待機中

            If mint現在のリング番号 - mint測量ポイントリング番号 <= 1 Then

            Else
                ''現在のリング番号-測量リング>1　のとき
                With SegAsmblyData
                    For i = mint測量ポイントリング番号 To CShort(mint現在のリング番号 - 2)
                        'SegMakDat.RingNo = intCnt
                        mdbl掘進総距離 +=
                             GetHoseiSegmentWidth(mdbl掘進総距離, .TypeData(i).CenterWidth)
                    Next i

                    mdbl掘進総距離 -= .RingLastStroke(mint測量ポイントリング番号) / 1000 + GetHoseiSegmentWidth(mdbl掘進総距離, .RingLastStroke(CShort(mint現在のリング番号 - 1)) / 1000)

                End With
            End If

        Else
            ''掘進中or中断中
            With SegAsmblyData
                If mblnChangeFlg Then ''リング番号、測量ポイントのリング番号および総距離が変化した時のみ演算　負荷削減のため
                    For i = mint測量ポイントリング番号 To CShort(mint現在のリング番号 - 1)
                        'SegMakDat.RingNo = intCnt
                        mdbl掘進総距離 += GetHoseiSegmentWidth(mdbl掘進総距離, .TypeData(i).CenterWidth)
                    Next i
                    mdbl現リング総距離 = mdbl掘進総距離
                    mblnChangeFlg = False
                Else
                    mdbl掘進総距離 = mdbl現リング総距離
                End If

                mdbl掘進総距離 += - .RingLastStroke(mint測量ポイントリング番号) / 1000 + GetHoseiSegmentWidth(mdbl掘進総距離, CalcStroke.MesureCalcAveJackStroke / 1000)
            End With

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