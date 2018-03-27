Option Strict On
Option Explicit On
Imports System.Math
Public Class clsLineMake
    ' @(h) clsLineMake.cls                ver 1.0 ( '01.02.15 近藤　勲 )
    ' @(h) clsLineMake.cls                ver 1.1 ( '02.09.12 近藤　勲 )
    ' シフト量の演算　京都地下鉄石田北より追加

    ' @(h) clsLineMake.cls                ver 1.2 ( '03.03.18 近藤　勲 )
    ' シフトゾーン数が０の時は演算を行わない　03/03/18

    ' @(h) clsLineMake.cls                ver 1.3 ( '04.08.11 近藤　勲 )
    ' 仮リング対応
    ' @(h) clsLineMake.cls                ver 1.4 ( '05.04.29 近藤　勲 )
    ' 仮リング対応その２


    ' @(s) 現在位置の該当する計画線ﾃﾞｰﾀを抽出するクラス
    '
    '

    Private mdbl掘進累積距離 As Double

    ''算出されるデータ
    ''平面
    Private HorZoneNo As Integer
    Private mint平面線形 As Integer
    Private mdbl平面ゾーン掘進距離 As Double
    Private mdbl平面ゾーン残距離 As Double
    Private mdbl平面シフト量 As Double

    Private mdbl平面シフト追加角 As Double ''02/09/12 追加

    Private mdbl軌道中心平面半径 As Double

    Private mdbl軌道中心方位角 As Double
    Private mdbl軌道中心X座標 As Double
    Private mdbl軌道中心Y座標 As Double

    Private mdbl構築中心方位角 As Double
    Private mdbl構築中心X座標 As Double
    Private mdbl構築中心Y座標 As Double

    ''縦断
    Private mint縦断ゾーン番号 As Integer
    Private mint縦断線形 As Integer
    Private mdbl縦断ゾーン掘進距離 As Double
    Private mdbl縦断ゾーン残距離 As Double
    Private mdbl縦断半径 As Double
    Private mdbl鉛直角 As Double
    Private mdblZ座標 As Double

    ''02/09/12 追加
    Private mdbl鉛直角軌道中心 As Double
    Private mdblZシフト座標 As Double
    Private mdbl縦断シフト量 As Double
    Private mdbl縦断シフト追加角 As Double

    Public WriteOnly Property 縦断掘進累積距離() As Double
        Set(ByVal Value As Double)
            ''縦断のみの演算を行う場合のプロパティセット用
            mdbl掘進累積距離 = Value
            Call sbCulZCor() ''Ｚ座標算出

        End Set
    End Property



    Public Property 平面計画方位 As Double

    Public Property 掘進累積距離() As Double
        Get
            掘進累積距離 = mdbl掘進累積距離
        End Get
        Set(ByVal Value As Double)

            mdbl掘進累積距離 = Value
            ''累積距離が入力されたとき路線データの演算を行う
            Call sbCulHorKijun() ''平面演算
            Call sbCulverKijun() ''縦断演算

        End Set
    End Property


    Public ReadOnly Property 構築中心X座標() As Double
        Get
            構築中心X座標 = mdbl構築中心X座標
        End Get
    End Property

    Public ReadOnly Property 構築中心Y座標() As Double
        Get
            構築中心Y座標 = mdbl構築中心Y座標 * HorPlan.座標系
        End Get
    End Property

    Public ReadOnly Property 軌道中心X座標() As Double
        Get
            軌道中心X座標 = mdbl軌道中心X座標
        End Get
    End Property

    Public ReadOnly Property 軌道中心Y座標() As Double
        Get
            軌道中心Y座標 = mdbl軌道中心Y座標 * HorPlan.座標系
        End Get
    End Property


    Public ReadOnly Property 構築中心方位角() As Double
        Get
            構築中心方位角 = mdbl構築中心方位角
        End Get
    End Property

    Public ReadOnly Property 軌道中心方位角() As Double
        Get
            軌道中心方位角 = mdbl軌道中心方位角
        End Get
    End Property

    Public ReadOnly Property 軌道中心平面半径() As Double
        Get
            軌道中心平面半径 = mdbl軌道中心平面半径 * HorPlan.座標系
        End Get
    End Property


    Public ReadOnly Property 平面シフト量() As Double
        Get
            平面シフト量 = mdbl平面シフト量
        End Get
    End Property

    ''02/09/12 追加
    Public ReadOnly Property 平面シフト追加角() As Double
        Get
            平面シフト追加角 = mdbl平面シフト追加角
        End Get
    End Property

    Public ReadOnly Property 平面ゾーン内残距離() As Double
        Get
            平面ゾーン内残距離 = mdbl平面ゾーン残距離
        End Get
    End Property

    Public ReadOnly Property 平面ゾーン掘進距離() As Double
        Get
            平面ゾーン掘進距離 = mdbl平面ゾーン掘進距離
        End Get
    End Property

    Public ReadOnly Property 平面変化点距離() As Double
        Get
            ''掘進距離と残距離の短い距離を返り値とする
            If mdbl平面ゾーン掘進距離 > mdbl平面ゾーン残距離 Then
                平面変化点距離 = mdbl平面ゾーン残距離
            Else
                平面変化点距離 = mdbl平面ゾーン掘進距離
            End If
        End Get
    End Property

    Public ReadOnly Property 平面ゾーン番号() As Integer
        Get
            平面ゾーン番号 = HorZoneNo
        End Get
    End Property
    Public ReadOnly Property 平面線形() As Integer
        Get
            平面線形 = mint平面線形
        End Get
    End Property

    Public ReadOnly Property Z座標() As Double
        Get
            Z座標 = mdblZ座標
        End Get
    End Property

    Public ReadOnly Property 鉛直角() As Double
        Get
            鉛直角 = mdbl鉛直角
        End Get
    End Property

    Public ReadOnly Property 縦断半径() As Double
        Get
            縦断半径 = mdbl縦断半径
        End Get
    End Property

    Public ReadOnly Property 縦断ゾーン内残距離() As Double
        Get
            縦断ゾーン内残距離 = mdbl縦断ゾーン残距離
        End Get
    End Property

    Public ReadOnly Property 縦断ゾーン内掘進距離() As Double
        Get
            縦断ゾーン内掘進距離 = mdbl縦断ゾーン掘進距離
        End Get
    End Property

    Public ReadOnly Property 縦断変化点距離() As Double
        Get
            ''掘進距離と残距離の短い距離を返り値とする
            If mdbl縦断ゾーン掘進距離 > mdbl縦断ゾーン残距離 Then
                縦断変化点距離 = mdbl縦断ゾーン残距離
            Else
                縦断変化点距離 = mdbl縦断ゾーン掘進距離
            End If
        End Get
    End Property

    Public ReadOnly Property 縦断ゾーン番号() As Integer
        Get
            縦断ゾーン番号 = mint縦断ゾーン番号
        End Get
    End Property
    Public ReadOnly Property 縦断線形() As Integer
        Get
            縦断線形 = mint縦断線形
        End Get
    End Property

    ''02/09/12 追加
    Public ReadOnly Property Zシフト座標() As Double
        Get
            Zシフト座標 = mdblZシフト座標
        End Get
    End Property

    ''02/09/12 追加
    Public ReadOnly Property 縦断シフト量() As Double
        Get
            縦断シフト量 = mdbl縦断シフト量
        End Get
    End Property

    ''02/09/12 追加
    Public ReadOnly Property 縦断シフト追加角() As Double
        Get
            縦断シフト追加角 = mdbl縦断シフト追加角
        End Get
    End Property

    ''02/09/12 追加
    Public ReadOnly Property 鉛直角軌道中心() As Double
        Get
            鉛直角軌道中心 = mdbl鉛直角軌道中心
        End Get
    End Property



    Private Sub sbCulHorKijun()
        ' @(f)
        '
        ' 機能      :現在位置の該当する平面計画線ﾃﾞｰﾀを抽出する。
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :仮リング対応　04/08/11



        ''線分長より現在のゾーンを求める
        Dim intZone As Integer
        Dim Sheatdash As Double
        Dim A2 As Double
        Dim L0, L1 As Double
        Dim TR1, TR0, TRC As Double
        Dim Taudash1, Taudash0, TaudashC As Double
        Dim Alfadash As Double
        Dim Xdash0, Ydash0 As Double
        Dim XdashC, YdashC As Double
        Dim Xdash, Ydash As Double
        Dim LC, rc As Double '' by Isao Kondo 01/02/15


        For intZone = 0 To HorPlan.ゾーン総数
            With HorPlan
                If mdbl掘進累積距離 >= .始点累積距離(intZone) And mdbl掘進累積距離 < .終点累積距離(intZone) Then
                    HorZoneNo = intZone
                End If
            End With
        Next

        With HorPlan

            mdbl平面ゾーン掘進距離 = mdbl掘進累積距離 - .始点累積距離(HorZoneNo)
            mdbl平面ゾーン残距離 = .終点累積距離(HorZoneNo) - mdbl掘進累積距離

            'Call sbCalcHorShift() ''02/09/12 変更　Ver1.1 シフトの演算

            Dim CulcHorShift As New clsCulcHorShift(mdbl掘進累積距離)
            mdbl平面シフト量 = CulcHorShift.平面シフト量
            mdbl平面シフト追加角 = CulcHorShift.平面シフト追加角

            mint平面線形 = .線形(HorZoneNo)
            Select Case .線形(HorZoneNo)

                Case 1 ''直線の場合
                    mdbl軌道中心平面半径 = 99999
                    mdbl軌道中心方位角 = .始点方向角(HorZoneNo)
                    '構築への補正
                    mdbl構築中心方位角 = Lim180(mdbl軌道中心方位角 + mdbl平面シフト追加角)

                    mdbl軌道中心X座標 = .始点X座標(HorZoneNo) + mdbl平面ゾーン掘進距離 * Cos(.始点方向角(HorZoneNo).ToRad)
                    mdbl軌道中心Y座標 = .始点Y座標(HorZoneNo) + mdbl平面ゾーン掘進距離 * Sin(.始点方向角(HorZoneNo).ToRad)

                    mdbl構築中心X座標 = mdbl軌道中心X座標 - mdbl平面シフト量 * Sin(.始点方向角(HorZoneNo).ToRad)
                    mdbl構築中心Y座標 = mdbl軌道中心Y座標 + mdbl平面シフト量 * Cos(.始点方向角(HorZoneNo).ToRad)

                Case 2 ''曲線の場合
                    mdbl軌道中心平面半径 = .始点曲率半径(HorZoneNo)

                    Sheatdash = mdbl平面ゾーン掘進距離 / mdbl軌道中心平面半径 * 180 / PI 'ｿﾞｰﾝ内角度
                    mdbl軌道中心方位角 = Lim180(.始点方向角(HorZoneNo) + Sheatdash)
                    mdbl構築中心方位角 = Lim180(mdbl軌道中心方位角 + mdbl平面シフト追加角)

                    mdbl軌道中心X座標 = .始点中心X座標(HorZoneNo) + mdbl軌道中心平面半径 * Sin(mdbl軌道中心方位角.ToRad)
                    mdbl軌道中心Y座標 = .始点中心Y座標(HorZoneNo) - mdbl軌道中心平面半径 * Cos(mdbl軌道中心方位角.ToRad)

                    mdbl構築中心X座標 = mdbl軌道中心X座標 - mdbl平面シフト量 * Sin(.始点方向角(HorZoneNo).ToRad)
                    mdbl構築中心Y座標 = mdbl軌道中心Y座標 + mdbl平面シフト量 * Cos(.始点方向角(HorZoneNo).ToRad)

                Case 3 ''クロソイドの場合





                    If .クロソイドパラメータ(HorZoneNo) >= 0 Then 'ｸﾛｿｲﾄﾞﾊﾟﾗﾒｰﾀの二乗（Ａ2＝LR）
                        A2 = .クロソイドパラメータ(HorZoneNo) ^ 2
                    Else
                        A2 = - .クロソイドパラメータ(HorZoneNo) ^ 2
                    End If
                    If .始点曲率半径(HorZoneNo) = 0 Then
                        TR0 = 0
                    Else
                        TR0 = 1 / .始点曲率半径(HorZoneNo)
                    End If
                    If .終点曲率半径(HorZoneNo) = 0 Then
                        TR1 = 0
                    Else
                        TR1 = 1 / .終点曲率半径(HorZoneNo)
                    End If
                    L0 = A2 * TR0 '曲線長
                    Taudash0 = L0 * TR0 / 2 * 180 / PI 'ｸﾛｿｲﾄﾞ内の接線方向角
                    Xdash0 = userFunctionF(L0, .始点曲率半径(HorZoneNo))
                    Ydash0 = userFunctionG(L0, .始点曲率半径(HorZoneNo))
                    L1 = A2 * TR1
                    Taudash1 = L1 * TR1 / 2 * 180 / PI
                    Alfadash = Lim180(.始点方向角(HorZoneNo) - Taudash0)
                    LC = mdbl平面ゾーン掘進距離 + L0
                    If LC <> 0 Then
                        rc = A2 / LC '検討位置の半径
                        TRC = 1 / rc 'その逆数
                    Else
                        rc = 0
                        TRC = 0
                    End If
                    XdashC = userFunctionF(LC, rc)
                    YdashC = userFunctionG(LC, rc)
                    TaudashC = LC * TRC / 2 * 180 / PI
                    Xdash = XdashC - Xdash0
                    Ydash = YdashC - Ydash0
                    If rc <> 0 Then
                        mdbl軌道中心平面半径 = rc
                    Else
                        mdbl軌道中心平面半径 = 0
                    End If

                    mdbl軌道中心方位角 = Lim180(Alfadash + TaudashC)

                    mdbl構築中心方位角 = Lim180(mdbl軌道中心方位角 + mdbl平面シフト追加角)

                    mdbl軌道中心X座標 = HorPlan.始点X座標(HorZoneNo) + (Xdash * Cos(Alfadash.ToRad) - Ydash * Sin(Alfadash.ToRad))
                    mdbl軌道中心Y座標 = .始点Y座標(HorZoneNo) + (Xdash * Sin(Alfadash.ToRad) + Ydash * Cos(Alfadash.ToRad))

                    mdbl構築中心X座標 = mdbl軌道中心X座標 - mdbl平面シフト量 * Sin(.始点方向角(HorZoneNo).ToRad)
                    mdbl構築中心Y座標 = mdbl軌道中心Y座標 + mdbl平面シフト量 * Cos(.始点方向角(HorZoneNo).ToRad)
                Case Else

            End Select

        End With



    End Sub

    ''' <summary>
    ''' ソーンのカント量の算出
    ''' </summary>
    Public Sub CulcZoneKant()

        For ZoneNo As Integer = 0 To HorPlan.ゾーン総数
            Dim StartCulcShft As New clsCulcHorShift(HorPlan.始点累積距離(ZoneNo))
            HorPlan.始点カント(ZoneNo) = StartCulcShft.平面シフト量
            'HorPlan.始点シフト量(ZoneNo) = StartCulcShft.平面シフト追加角


            Dim LastCulcShft As New clsCulcHorShift(HorPlan.終点累積距離(ZoneNo))
            HorPlan.終点カント(ZoneNo) = LastCulcShft.平面シフト量
            'HorPlan.終点シフト量(ZoneNo) = LastCulcShft.平面シフト追加角

        Next


    End Sub



    Public Class clsCulcHorShift

        'Private _掘進累積距離 As Double
        Private _平面シフト量 As Double
        Private _平面シフト追加角 As Double ''02/09/12 追加


        'Public WriteOnly Property 掘進累積距離 As Double
        '    Set(value As Double)
        '        _掘進累積距離 = value
        '    End Set
        'End Property

        Public ReadOnly Property 平面シフト量 As Double
            Get
                Return _平面シフト量
            End Get
        End Property

        Public ReadOnly Property 平面シフト追加角 As Double
            Get
                Return _平面シフト追加角
            End Get
        End Property


        Public Sub New(_掘進累積距離 As Double)
            ' @(f)
            '
            ' 機能      :平面シフトの演算
            '
            ' 返り値    :
            ' 　　　    :
            '
            ' 機能説明  :
            '
            ' 備考      :02/09/12 追加
            ' シフトゾーン数が０の時は演算を行わない　03/03/18

            Dim ZoneNo As Integer
            Dim ShiftZoneNo As Integer
            Dim dblZoneLen As Double
            With HorPlan

                If HorPlan.シフトゾーン総数 = 0 Then Exit Sub ''03/03/18 追加


                'intShiftZoneNo:抽出したシフトゾーン
                'dblZoneLen:シフトゾーン内の距離

                ZoneNo = 0
                Do While HorPlan.シフト区間長(ZoneNo) <> 0
                    If ZoneNo = 0 Then
                        HorPlan.シフトゾーン距離(ZoneNo) = -HorPlan.シフト区間長(ZoneNo)
                        HorPlan.シフトゾーン残距離(ZoneNo) = 0
                    Else
                        HorPlan.シフトゾーン距離(ZoneNo) = HorPlan.シフトゾーン残距離(ZoneNo - 1)
                        HorPlan.シフトゾーン残距離(ZoneNo) = HorPlan.シフトゾーン距離(ZoneNo) + HorPlan.シフト区間長(ZoneNo)
                    End If
                    If _掘進累積距離 >= HorPlan.シフトゾーン距離(ZoneNo) And _掘進累積距離 <= HorPlan.シフトゾーン残距離(ZoneNo) Then
                        ShiftZoneNo = ZoneNo
                        dblZoneLen = _掘進累積距離 - HorPlan.シフトゾーン距離(ZoneNo)
                        _平面シフト量 = HorPlan.始点シフト量(ZoneNo) + (HorPlan.終点シフト量(ZoneNo) - HorPlan.始点シフト量(ZoneNo)) * dblZoneLen / HorPlan.シフト区間長(ZoneNo)
                        _平面シフト追加角 = Atan((HorPlan.終点シフト量(ZoneNo) - HorPlan.始点シフト量(ZoneNo)) / HorPlan.シフト区間長(ZoneNo)) * 180 / PI
                        Exit Sub
                    End If
                    ZoneNo += 1
                Loop
                If HorPlan.シフト区間長(ZoneNo) = 0 Then
                    ShiftZoneNo = -1
                    dblZoneLen = _掘進累積距離 - HorPlan.シフトゾーン残距離(ZoneNo - 1)
                    _平面シフト量 = 0
                    _平面シフト追加角 = 0
                End If
            End With



        End Sub

    End Class




    Private Sub sbCalcHorShift()
        ' @(f)
        '
        ' 機能      :平面シフトの演算
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :02/09/12 追加
        ' シフトゾーン数が０の時は演算を行わない　03/03/18

        Dim intZone As Short
        Dim intShiftZoneNo As Short
        Dim dblZoneLen As Double
        With HorPlan

            If .シフトゾーン総数 = 0 Then Exit Sub ''03/03/18 追加


            'intShiftZoneNo:抽出したシフトゾーン
            'dblZoneLen:シフトゾーン内の距離

            intZone = 0
            Do While .シフト区間長(intZone) <> 0
                If intZone = 0 Then
                    .シフトゾーン距離(intZone) = - .シフト区間長(intZone)
                    .シフトゾーン残距離(intZone) = 0
                Else
                    .シフトゾーン距離(intZone) = .シフトゾーン残距離(intZone - 1)
                    .シフトゾーン残距離(intZone) = .シフトゾーン距離(intZone) + .シフト区間長(intZone)
                End If
                If mdbl掘進累積距離 >= .シフトゾーン距離(intZone) And mdbl掘進累積距離 < .シフトゾーン残距離(intZone) Then
                    intShiftZoneNo = intZone
                    dblZoneLen = mdbl掘進累積距離 - .シフトゾーン距離(intZone)
                    mdbl平面シフト量 = .始点シフト量(intZone) + (.終点シフト量(intZone) - .始点シフト量(intZone)) * dblZoneLen / .シフト区間長(intZone)
                    mdbl平面シフト追加角 = Atan((.終点シフト量(intZone) - .始点シフト量(intZone)) / .シフト区間長(intZone)) * 180 / PI
                    Exit Sub
                End If
                intZone = CShort(intZone + 1)
            Loop
            If .シフト区間長(intZone) = 0 Then
                intShiftZoneNo = -1
                dblZoneLen = mdbl掘進累積距離 - .シフトゾーン残距離(intZone - 1)
                mdbl平面シフト量 = 0
                mdbl平面シフト追加角 = 0
            End If
        End With




    End Sub


    Private Sub sbCulZCor()
        ' @(f)
        '
        ' 機能      :現在位置の該当する縦断計画線ﾃﾞｰﾀを抽出する。
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :sbCulverKijun()よりＺ座標のみ求める
        '
        ''線分長より現在のゾーンを求める
        Dim intZone As Integer

        For intZone = 0 To VerPlan.ゾーン総数
            With VerPlan
                If mdbl掘進累積距離 >= VerPlan.始点累積水平距離(intZone) And mdbl掘進累積距離 < VerPlan.終点累積累積距離(intZone) Then
                    mint縦断ゾーン番号 = intZone
                End If
            End With
        Next

        'intZone = mint縦断ゾーン番号
        With VerPlan
            mdbl縦断ゾーン掘進距離 = mdbl掘進累積距離 - .始点累積水平距離(mint縦断ゾーン番号)
            mdbl縦断ゾーン残距離 = .終点累積累積距離(mint縦断ゾーン番号) - mdbl掘進累積距離

            'Call sbCalcVerShift     ''02/09/12 変更　Ver1.1 シフトの演算


            mint縦断線形 = .線形(intZone)
            Select Case .線形(mint縦断ゾーン番号)
                Case 1 ''直線の場合
                    mdblZ座標 = .始点Z座標(mint縦断ゾーン番号) + (mdbl掘進累積距離 - .始点累積水平距離(mint縦断ゾーン番号)) * Tan(.始点勾配(mint縦断ゾーン番号).ToRad)
                Case 2 ''曲線の場合
                    mdbl鉛直角軌道中心 = Asin((mdbl掘進累積距離 - VerPlan.始点累積水平距離(mint縦断ゾーン番号)) / VerPlan.曲率半径(mint縦断ゾーン番号) + Sin(VerPlan.始点勾配(mint縦断ゾーン番号).ToRad)) * 180 / PI
                    mdblZ座標 = VerPlan.始点Z座標(mint縦断ゾーン番号) + VerPlan.曲率半径(mint縦断ゾーン番号) * (Cos(VerPlan.始点勾配(mint縦断ゾーン番号).ToRad) - Cos(mdbl鉛直角軌道中心.ToRad))
                Case Else
            End Select

        End With





    End Sub




    Private Sub sbCulverKijun()
        ' @(f)
        '
        ' 機能      :現在位置の該当する縦断計画線ﾃﾞｰﾀを抽出する。
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :仮リング対応　04/08/11



        ''線分長より現在のゾーンを求める
        Dim intZone As Integer

        For intZone = 0 To VerPlan.ゾーン総数
            With VerPlan
                If mdbl掘進累積距離 >= VerPlan.始点累積水平距離(intZone) And mdbl掘進累積距離 < VerPlan.終点累積累積距離(intZone) Then
                    mint縦断ゾーン番号 = intZone
                End If
            End With
        Next intZone

        ''04/08/11 仮リング対応
        'If mdbl掘進累積距離 < 0 Then mint縦断ゾーン番号 = 1


        'If mint縦断ゾーン番号 = 0 Then Exit Sub    ''エラー？？
        'intZone = mint縦断ゾーン番号
        With VerPlan
            mdbl縦断ゾーン掘進距離 = mdbl掘進累積距離 - .始点累積水平距離(mint縦断ゾーン番号)
            mdbl縦断ゾーン残距離 = .終点累積累積距離(mint縦断ゾーン番号) - mdbl掘進累積距離

            Call sbCalcVerShift() ''02/09/12 変更　Ver1.1 シフトの演算


            mint縦断線形 = .線形(mint縦断ゾーン番号)
            Select Case .線形(mint縦断ゾーン番号)
                Case 1 ''直線の場合
                    ''            mdbl縦断半径 = Null

                    mdbl縦断半径 = 99999 'by Isao Kondo 01/01/19
                    'mdbl鉛直角 = .始点勾配
                    mdbl鉛直角軌道中心 = .始点勾配(mint縦断ゾーン番号)
                    mdblZ座標 = .始点Z座標(mint縦断ゾーン番号) + (mdbl掘進累積距離 - .始点累積水平距離(mint縦断ゾーン番号)) * Tan(.始点勾配(mint縦断ゾーン番号).ToRad)
                Case 2 ''曲線の場合
                    mdbl縦断半径 = .曲率半径(mint縦断ゾーン番号)
                    '                                                                                       FZv→FVz ミス？
                    mdbl鉛直角軌道中心 = Asin((mdbl掘進累積距離 - VerPlan.始点累積水平距離(mint縦断ゾーン番号)) / VerPlan.曲率半径(mint縦断ゾーン番号) + Sin(VerPlan.始点勾配(mint縦断ゾーン番号).ToRad)) * 180 / PI
                    mdblZ座標 = VerPlan.始点Z座標(mint縦断ゾーン番号) + VerPlan.曲率半径(mint縦断ゾーン番号) * (Cos(VerPlan.始点勾配(mint縦断ゾーン番号).ToRad) - Cos(mdbl鉛直角軌道中心.ToRad))
                Case Else
            End Select

            ''02/09/12 変更　Ver1.1 シフトの演算
            mdbl鉛直角 = mdbl鉛直角軌道中心 + mdbl縦断シフト追加角
            mdblZシフト座標 = mdblZ座標 + mdbl縦断シフト量 * Cos(.始点勾配(mint縦断ゾーン番号).ToRad)

        End With


    End Sub



    Private Sub sbCalcVerShift()
        ' @(f)
        '
        ' 機能      :縦断シフトの演算
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :02/09/12 追加
        ' シフトゾーン数が０の時は演算を行わない　03/03/18


        Dim intZone As Integer
        Dim intShiftZoneNo As Integer
        Dim dblZoneLen As Double
        With VerPlan

            ' シフトゾーン数が０の時は演算を行わない　03/03/18
            If .シフトゾーン総数 = 0 Then Exit Sub


            'intShiftZoneNo:抽出したシフトゾーン
            'dblZoneLen:シフトゾーン内の距離

            intZone = 0
            Do While .シフト区間長(intZone) <> 0
                If intZone = 0 Then
                    .シフトゾーン距離(intZone) = - .シフト区間長(intZone)
                    .シフトゾーン残距離(intZone) = 0
                Else
                    .シフトゾーン距離(intZone) = .シフトゾーン残距離(intZone - 1)
                    .シフトゾーン残距離(intZone) = .シフトゾーン距離(intZone) + .シフト区間長(intZone)
                End If
                If mdbl掘進累積距離 >= .シフトゾーン距離(intZone) And mdbl掘進累積距離 < .シフトゾーン残距離(intZone) Then
                    intShiftZoneNo = intZone
                    dblZoneLen = mdbl掘進累積距離 - .シフトゾーン距離(intZone)
                    mdbl縦断シフト量 = .始点シフト量(intZone) + (.終点シフト量(intZone) - .始点シフト量(intZone)) * dblZoneLen / .シフト区間長(intZone)
                    mdbl縦断シフト追加角 = System.Math.Atan((.終点シフト量(intZone) - .始点シフト量(intZone)) / .シフト区間長(intZone)) * 180 / PI
                    Exit Sub
                End If
                intZone = intZone + 1
            Loop
            If .シフト区間長(intZone) = 0 Then
                intShiftZoneNo = -1
                dblZoneLen = mdbl掘進累積距離 - .シフトゾーン残距離(intZone - 1)
                mdbl縦断シフト量 = 0
                mdbl縦断シフト追加角 = 0
            End If

        End With


    End Sub


    Friend Function userFunctionG(ByVal L As Double, ByVal R As Double) As Double
        'ﾕｰｻﾞｰ関数 ｆ
        Dim Sigma As Double
        Dim LR As Double
        Dim k As Short

        If R <> 0 Then
            LR = L / (2 * R)
        Else
            LR = 0
        End If
        Sigma = 0
        For k = 1 To 5
            Sigma = Sigma + 1 / ((4 * k - 1) * Kai(2 * k - 1)) * (-1) ^ (k + 1) * LR ^ (2 * k - 1)
        Next
        Return L * Sigma

    End Function

    Friend Function userFunctionF(ByVal L As Double, ByVal R As Double) As Double
        'ﾕｰｻﾞｰ関数 ｆ
        Dim Sigma As Double
        Dim LR As Double
        Dim k As Short

        If R <> 0 Then
            LR = L / (2 * R)
        Else
            LR = 0
        End If
        Sigma = 0
        For k = 1 To 5
            Sigma = Sigma + 1 / ((4 * k - 3) * Kai(2 * k - 2)) * (-1) ^ (k + 1) * LR ^ (2 * k - 2)
        Next
        Return L * Sigma

    End Function
    Private Function Kai(ByVal N As Integer) As Double
        'Ｎの階上
        Dim i As Integer

        Kai = 1
        If N = 0 Then
            Exit Function
        End If

        For i = 1 To N
            Kai = Kai * i
        Next

    End Function

    Friend Sub sbZahyoGtoL(ByRef dblLx As Double, ByRef dblLy As Double, ByVal dblGX As Double, ByVal dblGY As Double, ByVal dblGX0 As Double, ByVal dblGY0 As Double, ByVal sngAlfa0 As Double)
        ' @(f)
        '
        ' 機能      :ローカルからグローバル座標への変換
        ' 返り値    :
        '
        '
        ' 機能説明  :
        '
        ' 備考      :
        ''

        'Lx,Ly  変換対象のローカル座標値（出力値）
        'Gx,Gy  変換対象のグローバル座標値（入力値）
        'X0,Y0  変換中心のグローバル座標値（入力値）
        'Alfa0　変換中心のグローバル座標上の方向角(deg)（入力値）

        Dim dblCT, dblST As Double

        dblCT = Cos(Lim180(sngAlfa0).ToRad)
        'dblST = Sin(Lim180(sngAlfa0) * PI / 180)
        dblST = Sin(Lim180(sngAlfa0).ToRad)
        dblLx = dblCT * (dblGX - dblGX0) + dblST * (dblGY - dblGY0)
        dblLy = -dblST * (dblGX - dblGX0) + dblCT * (dblGY - dblGY0)

    End Sub


End Class


Friend Class clsCorToDist
    ' @(h) clsCorToDist.cls                ver 1.0 ( '08.01.09 近藤　勲 )
    '' 座標から距離を求めるクラス
    '' 与えられた座標から属するｿﾞｰﾝを算出し、ｿﾞｰﾝの線形で距離を算出
    '' 鹿島品川線より追加

    Inherits clsLineMake

    Private _Xp As Double ''対象のX座標
    Private _Yp As Double ''対象のY座標
    Private _抽出Zone As Integer
    Private _累積距離 As Double

    Public Sub New(xp As Double, yp As Double)
        _Xp = xp
        _Yp = yp
        sbFindZone()
    End Sub

    Public WriteOnly Property Xp() As Double
        Set(ByVal Value As Double)
            _Xp = Value
        End Set
    End Property
    Public WriteOnly Property Yp() As Double
        Set(ByVal Value As Double)
            _Yp = Value
        End Set
    End Property
    Public ReadOnly Property 累積距離() As Double
        Get
            累積距離 = _累積距離
        End Get
    End Property


    Private Sub sbFindZone()
        ' @(f)
        '
        ' 機能      :ゾーンを抽出
        ' 返り値    :なし
        '
        '
        ' 機能説明  :
        '
        ' 備考      :
        ''

        Dim dblDeltaL As Double
        Dim intKDash As Integer
        Dim intZone As Integer
        Dim dblXDk_1, dblDum, dblXDk As Double
        Dim dblXD, dblYD As Double
        Dim dblYD_s, dblXD_s, dblLC As Double
        Dim dblXD_l, dblYD_l As Double
        Dim dblSheatC, dblEp, dblR, dblAlfaC As Double
        Dim dblXc, dblYc As Double
        Dim dblXDc, dblYDc As Double
        Dim dblA2 As Double
        Dim dblTR0, dblTR1 As Double
        Dim dblTRc, dblTauDash1, dblTauDash0, dblRc, dblTauDashC As Double
        Dim dblXdash, dblYdash As Double
        Dim dblXdash0, dblYdash0 As Double
        Dim dblXdashC, dblYdashC As Double
        Dim dblAlfadash As Double
        Dim intLL As Integer
        Dim dblL0 As Double, dblL1 As Double
        With HorPlan

            dblDeltaL = Sqrt((_Xp - .始点X座標(0)) ^ 2 + (_Yp - .始点Y座標(0)) ^ 2)

            For intZone = 1 To HorPlan.ゾーン総数
                If dblDeltaL > Sqrt((_Xp - .始点X座標(intZone)) ^ 2 + (_Yp - .始点Y座標(intZone)) ^ 2) Then
                    dblDeltaL = Sqrt((_Xp - .始点X座標(intZone)) ^ 2 + (_Yp - .始点Y座標(intZone)) ^ 2)
                    intKDash = intZone
                End If
            Next

            With HorPlan
                Call sbZahyoGtoL(dblXDk_1, dblDum, _Xp, _Yp, .始点X座標(intKDash - 1), .始点Y座標(intKDash - 1), .始点方向角(intKDash - 1))
                Call sbZahyoGtoL(dblXDk, dblDum, _Xp, _Yp, .始点X座標(intKDash), .始点Y座標(intKDash), .始点方向角(intKDash))
            End With
            If dblXDk_1 * dblXDk >= 0 Then
                _抽出Zone = intKDash
            Else
                _抽出Zone = intKDash - 1
            End If

            dblEp = 0.00001

            Select Case HorPlan.線形(_抽出Zone)

                Case 1 ''直線-----------------------------
                    Call sbZahyoGtoL(dblXD, dblYD, _Xp, _Yp, .始点X座標(_抽出Zone), .始点Y座標(_抽出Zone), .始点方向角(_抽出Zone))
                    _累積距離 = .始点累積距離(_抽出Zone) + dblXD

                Case 2 ''単曲線<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    Call sbZahyoGtoL(dblXD_s, dblYD_s, _Xp, _Yp, .始点X座標(_抽出Zone), .始点Y座標(_抽出Zone), .始点方向角(_抽出Zone))
                    Call sbZahyoGtoL(dblXD_l, dblYD_l, _Xp, _Yp, .終点X座標(_抽出Zone), .終点Y座標(_抽出Zone), .終点方向角(_抽出Zone))
                    If Abs(dblXD_s) <= dblEp Then '計測点は始点上にある（結果は始点のﾃﾞｰﾀ）
                        dblLC = 0
                    Else
                        If Abs(dblXD_l) <= dblEp Then '計測点は終点上にある（結果は終点のﾃﾞｰﾀ）
                            dblLC = .終点累積距離(_抽出Zone)
                        Else '計測点はｿﾞｰﾝ内にある（始点と終点を比較し、収束計算）
                            dblL0 = 0
                            dblL1 = .線分長(_抽出Zone)
                            dblR = .始点曲率半径(_抽出Zone)
                            intLL = 0
                            Do
                                intLL = intLL + 1 'ﾙｰﾌﾟ数ｶｳﾝﾄ
                                dblLC = (dblL0 + dblL1) * 0.5 '次の検討位置を近い側の半分へ移動（ｽﾀｰﾄ時は始点終点間の真ん中）
                                dblSheatC = dblLC / dblR * 180 / PI '検討位置の中心角
                                dblAlfaC = .始点方向角(_抽出Zone) + dblSheatC
                                dblXc = .始点中心X座標(_抽出Zone) + dblR * Sin(Lim180(dblAlfaC).ToRad)
                                dblYc = .始点中心Y座標(_抽出Zone) - dblR * Cos(Lim180(dblAlfaC).ToRad)
                                Call sbZahyoGtoL(dblXDc, dblYDc, _Xp, _Yp, dblXc, dblYc, dblAlfaC)

                                If Abs(dblXDc) <= dblEp Then '距離を検討し、きわめて近いとき
                                    Exit Do 'ここで終わり
                                End If
                                If dblXDc > 0.0# Then '＋方向にずれているので該当位置はさらに終点側にある
                                    dblL0 = dblLC
                                Else '偏差が－方向なので該当位置は始点側にある
                                    dblL1 = dblLC
                                End If
                            Loop While intLL < 300
                        End If
                    End If

                    _累積距離 = .始点累積距離(_抽出Zone) + dblLC

                Case 3 ''クロソイド<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    Call sbZahyoGtoL(dblXD_s, dblYD_s, _Xp, _Yp, .始点X座標(_抽出Zone), .始点Y座標(_抽出Zone), .始点方向角(_抽出Zone))
                    Call sbZahyoGtoL(dblXD_l, dblYD_l, _Xp, _Yp, .終点X座標(_抽出Zone), .終点Y座標(_抽出Zone), .終点方向角(_抽出Zone))
                    If .クロソイドパラメータ(_抽出Zone) >= 0 Then
                        dblA2 = .クロソイドパラメータ(_抽出Zone) ^ 2
                    Else
                        dblA2 = - .クロソイドパラメータ(_抽出Zone) ^ 2
                    End If
                    If .始点曲率半径(_抽出Zone) = 0 Then
                        dblTR0 = 0
                    Else
                        dblTR0 = 1 / .始点曲率半径(_抽出Zone)
                    End If
                    If .終点曲率半径(_抽出Zone) = 0 Then
                        dblTR1 = 0
                    Else
                        dblTR1 = 1 / .終点曲率半径(_抽出Zone)
                    End If
                    If Abs(dblXD_s) <= dblEp Then '計測点は始点上にある（結果は始点のﾃﾞｰﾀ）
                        dblLC = dblA2 * dblTR0 '曲線長
                    Else
                        If Abs(dblXD_l) <= dblEp Then '計測点は終点上にある（結果は終点のﾃﾞｰﾀ）
                            dblLC = dblA2 * dblTR1 '曲線長
                        Else '計測点はｿﾞｰﾝ内
                            dblL0 = dblA2 * dblTR0
                            dblL1 = dblA2 * dblTR1
                            dblTauDash0 = dblL0 * dblTR0 / 2 * 180 / PI
                            dblTauDash1 = dblL1 * dblTR1 / 2 * 180 / PI
                            intLL = 0

                            dblXdash0 = userFunctionF(dblL0, HorPlan.始点曲率半径(_抽出Zone))
                            dblYdash0 = userFunctionG(dblL0, HorPlan.始点曲率半径(_抽出Zone))

                            dblAlfadash = Lim180(.始点方向角(_抽出Zone) - dblTauDash0)
                            Do
                                intLL += 1 'ﾙｰﾌﾟ数ｶｳﾝﾄ
                                dblLC = (dblL0 + dblL1) * 0.5 '次の検討位置を近い側の半分へ移動（ｽﾀｰﾄ時は始点終点間の真ん中）
                                dblRc = dblA2 / dblLC '検討位置の半径
                                dblTRc = 1 / dblRc 'その逆数
                                dblXdashC = userFunctionF(dblLC, dblRc)
                                dblYdashC = userFunctionG(dblLC, dblRc)
                                dblXdash = dblXdashC - dblXdash0
                                dblYdash = dblYdashC - dblYdash0
                                dblTauDashC = dblLC * dblTRc / 2 * 180 / PI
                                dblAlfaC = Lim180(dblAlfadash + dblTauDashC)
                                dblXc = HorPlan.始点X座標(_抽出Zone) + dblXdash * Cos(dblAlfadash.ToRad) - dblYdash * Sin(dblAlfadash.ToRad)
                                dblYc = HorPlan.始点Y座標(_抽出Zone) + dblXdash * Sin(dblAlfadash.ToRad) + dblYdash * Cos(dblAlfadash.ToRad)
                                Call sbZahyoGtoL(dblXDc, dblYDc, _Xp, _Yp, dblXc, dblYc, dblAlfaC)

                                If Abs(dblXDc) <= dblEp Then '距離を検討し、きわめて近いとき
                                    Exit Do 'ここで終わり
                                End If
                                If dblXDc > 0.0# Then '＋方向にずれているので該当位置はさらに終点側にある
                                    dblL0 = dblLC
                                Else '偏差が－方向なので該当位置は始点側にある
                                    dblL1 = dblLC
                                End If
                            Loop While intLL < 300


                        End If


                    End If
                    _累積距離 = .始点累積距離(_抽出Zone) + Abs(dblLC - dblA2 * dblTR0)
            End Select

        End With

    End Sub


End Class
''以下線形管理　エクセルのVBAより（西さん作成）


