Imports System.Math

Public Class clsStrokeDevi
    ' @(h) clsGetDevi 1.0 ( '14.11.1 近藤　勲 )
    ' 偏角を求める
    'ストローク差を偏角に換算


    Private StartAveStroke As Single ''開始平均ストローク

    Private StartDevStroke As Integer ''開始ストローク差
    Private StartAmsKanzan As Double     ''開始ストローク差の角度換算値　反時計回り＋
    Private LastAmsKanzan As Double     ''終了ストローク差の角度換算値　反時計回り＋

    Private 換算現在目標方位 As Single 'ラジアン
    Private 換算実測水平角 As Single 'ラジアン
    Private 換算水平偏角 As Single  'ラジアン

    Private StartPitching As Single     ''開始ピッチング
    Private 現在の目標ピッチング As Single

    Private StartHoui As Single     ''開始方位
    Private 現在の目標方位 As Single

    Private NowAveStroke As Single ''現在の平均ストローク

    Private StartRightStroke As Integer
    Private StartLeftStroke As Integer





    '    Public Property Let 開始右ストローク(ByVal vData As Integer)
    '    mint開始右ストローク = vData
    '    Call sbStartCul ''掘進開始時の演算処理
    '    End Property
    '    Public Property Get 開始右ストローク() As Integer
    '    開始右ストローク = mint開始右ストローク
    'End Property

    '    Public Property Let 開始左ストローク(ByVal vData As Integer)
    '    mint開始左ストローク = vData
    '    Call sbStartCul ''掘進開始時の演算処理
    '    End Property
    '    Public Property Get 開始左ストローク() As Integer
    '    開始左ストローク = mint開始左ストローク
    'End Property

    Public Sub StartCul()

        ''掘進開始時の演算処理
        StartAveStroke = (PlcIf.RightStroke + PlcIf.LeftStroke) / 2 / 1000
        StartDevStroke = PlcIf.RightStroke - PlcIf.LeftStroke
        StartAmsKanzan = Math.Asin(StartDevStroke / 1000 / InitPara.CntDistLRSpreader)

    End Sub


    Public ReadOnly Property 開始平均ストローク() As Integer
        Get
            開始平均ストローク = StartDevStroke
        End Get
    End Property


    Public ReadOnly Property 開始ストローク差() As Integer
        Get
            開始ストローク差 = StartDevStroke
        End Get
    End Property

    ''' <summary>
    ''' 上左ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property TopLeftStroke As Integer

    ''' <summary>
    ''' 上左ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property TopRighttStroke As Integer


    ''' <summary>
    ''' 下右ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property BottomRighttStroke As Integer
    ''' <summary>
    ''' 下左ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property BottomLefttStroke As Integer

    ''' <summary>
    ''' 水平右ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property HorizonRighttStroke As Integer
    ''' <summary>
    ''' 水平左ストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property HorizonLefttStroke As Integer


    '    Public Property Let 開始ピッチング(ByVal vData As Single)
    '    msngStartPitching = vData
    'End Property
    '    Public Property Get 開始ピッチング() As Single
    '    開始ピッチング = msngStartPitching
    'End Property

    '    Public Property Get 現在の目標ピッチング() As Single
    '    現在の目標ピッチング = msng現在の目標ピッチング
    'End Property

    '    Public Property Get 現在の目標方位() As Single
    '    現在の目標方位 = msng現在の目標方位
    'End Property

    '    Public Property Get 換算現在目標方位() As Single
    '    換算現在目標方位 = msng換算現在目標方位 / cPI * 180
    'End Property
    Public ReadOnly Property 現在目標ストローク差() As Single
        Get
            現在目標ストローク差 = Sin(換算現在目標方位) * InitPara.CntDistLRSpreader * 1000
        End Get
    End Property


    '    Public Property Let 開始方位(ByVal vData As Single)
    '    msngStartHoui = vData
    'End Property
    '    Public Property Get 開始方位() As Single
    '    開始方位 = msngStartHoui
    'End Property

    'Public ReadOnly Property 換算水平偏角() As Single
    '    Get
    '        換算水平偏角 = 換算水平偏角 / PI * 180

    '    End Get
    'End Property


    ''' <summary>
    ''' 偏角(偏差）を求める
    ''' </summary>
    Public Sub sbGetDev()

        NowAveStroke = (PlcIf.RightStroke + PlcIf.LeftStroke) / 2 / 1000

        'Call sbGetHorDevi()   ''水平偏角を求める
        'Call sbGetVerDevi()   ''鉛直偏角を求める
        Call GetHorStrokeDevi() ''ストローク差角度換算を求める

    End Sub







    'Private Sub sbGetVerDevi()
    '    ' @(f)
    '    '
    '    ' 機能      :鉛直偏角を求める
    '    '
    '    ' 返り値    :なし
    '    ' 　　　    :
    '    '
    '    ' 機能説明  :

    '    Dim sngTotalStroke As Single ''全推進量(m)
    '    Dim sngTotalPichingDev As Single ''全ピッチング変化量
    '    Dim dblRv As Double ''曲率半径


    '    sngTotalStroke = CtlPara.鉛直達成ストローク / 1000 - StartAveStroke
    '    sngTotalPichingDev = CtlPara.鉛直目標ピッチング - StartPitching


    '    If Abs(sngTotalPichingDev) > CtlPara.鉛直曲線管理角度 Then
    '        If NowAveStroke < CtlPara.鉛直達成ストローク / 1000 Then
    '            'dblRv = sngTotalStroke / (2 * Sin(sngTotalPichingDev / 2 / 180 * cPI))
    '            dblRv = sngTotalStroke / (2 * Sin(sngTotalPichingDev.ToRad / 2))
    '            '現在の目標ピッチング = Math.Asin((NowAveStroke - StartAveStroke) / dblRv +
    '            Math.Sin(StartPitching * cPI / 180)) * 180 / cPI
    '            現在の目標ピッチング = Math.Asin((NowAveStroke - StartAveStroke) / dblRv +
    '                                   Math.Sin(StartPitching.ToRad)) * 180 / PI
    '        Else
    '            現在の目標ピッチング = CtlPara.鉛直目標ピッチング
    '        End If

    '    Else
    '        ''直線管理
    '        現在の目標ピッチング = sngTotalPichingDev + StartPitching

    '    End If


    'End Sub


    'Private Sub sbGetHorDevi()
    '    ' @(f)
    '    '
    '    ' 機能      :水平偏角を求める
    '    '
    '    ' 返り値    :なし
    '    ' 　　　    :
    '    '
    '    ' 機能説明  :

    '    Dim sngTotalStroke As Single ''全推進量(m)
    '    Dim sngTotalHouiDev As Single ''全方位変化量
    '    Dim dblRv As Double ''曲率半径

    '    sngTotalStroke = CtlPara.TargetNetStroke / 1000 - StartAveStroke
    '    sngTotalHouiDev = -CtlPara.水平目標方位角 + StartHoui
    '    'sngTotalHouiDev = fnHoko2Hoi(sngTotalHouiDev)  '左手系に変換

    '    If Abs(sngTotalHouiDev) > CtlPara.水平曲線管理角度 Then
    '        If NowAveStroke < CtlPara.TargetNetStroke / 1000 Then
    '            dblRv = sngTotalStroke / (2 * Sin(sngTotalHouiDev.ToRad / 2))
    '            現在の目標方位 = 2 * Math.Asin((NowAveStroke - StartAveStroke) / dblRv / 2) * 180 / PI + Hoko2Hoi(StartHoui)



    '            現在の目標方位 = Hoi2Hoko(現在の目標方位)
    '        Else
    '            現在の目標方位 = CtlPara.水平目標方位角

    '        End If

    '    Else
    '        ''直線管理
    '        現在の目標方位 = sngTotalHouiDev + StartHoui

    '    End If


    'End Sub

    Private Sub GetHorStrokeDevi()
        ' @(f)
        '
        ' 機能      :ストローク差（偏角換算）を求める
        '
        ' 返り値    :なし
        ' 　　　    :
        '
        ' 機能説明  :

        Dim TotalStroke As Single ''全推進量(m)
        Dim TotalHouiDev As Single ''全方位変化量
        Dim dblRh As Double ''曲率半径
        ''全推進量の取得
        TotalStroke = CtlPara.TargetNetStroke / 1000 - StartAveStroke
        ''全ストローク差変化量の角度換算値（°）　反時計回り
        TotalHouiDev = Math.Asin(CtlPara.HorTargerStrokeDev / 1000 / InitPara.CntDistLRSpreader) - StartAmsKanzan


        If Abs(TotalHouiDev * 180 / PI) > CtlPara.horCurveMngAngle Then
            dblRh = TotalStroke / (2 * Math.Sin(TotalHouiDev / 2))
            If NowAveStroke < CtlPara.TargetNetStroke / 1000 Then
                換算現在目標方位 = 2 * Math.Asin((NowAveStroke - StartAveStroke) / dblRh / 2) + StartAmsKanzan
            Else
                換算現在目標方位 = 2 * Math.Asin((CtlPara.TargetNetStroke / 1000 - StartAveStroke) / dblRh / 2) + StartAmsKanzan
            End If
        Else
            ''直線管理
            換算現在目標方位 = TotalHouiDev + StartAmsKanzan
        End If

        'With clsPlc
        ''実測水平角（角度換算）
        換算実測水平角 = Math.Asin((PlcIf.RightStroke - PlcIf.LeftStroke) / 1000 / InitPara.CntDistLRSpreader)
        '換算実測水平角 = Math.Asin((.右ストローク - .左ストローク) / 1000 / InitPara.CntDistLRSpreader) ' + mdblStartAmsKanzan

        'End With

        換算水平偏角 = -(換算実測水平角 - 換算現在目標方位)
        Debug.Print($"換算水平偏角 {換算水平偏角} 換算実測水平角 {換算実測水平角} 換算現在目標方位 {換算現在目標方位}")

    End Sub





End Class
