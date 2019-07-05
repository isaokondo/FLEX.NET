Imports System.Math

Public Class clsStrokeDevi
    ' @(h) clsGetDevi 1.0 ( '14.11.1 近藤　勲 )
    ' 偏角を求める
    'ストローク差を偏角に換算



    ''' <summary>
    ''' 開始ストローク差の角度換算値　反時計回り＋
    ''' </summary>
    Private StartAmsKanzan As Double
    ''' <summary>
    ''' 終了ストローク差の角度換算値　反時計回り＋
    ''' </summary>
    Private LastAmsKanzan As Double     ''
    ''' <summary>
    ''' ラジアン 換算現在目標方位
    ''' </summary>
    Private ConVertRealTargetDirction As Single
    ''' <summary>
    ''' 換算実測水平角 
    ''' ラジアン
    ''' </summary>
    Private ConvertSurveyHorDir As Single '
    ''' <summary>
    ''' 換算水平偏角 
    ''' ラジアン
    ''' </summary>
    Private _ConvertHorDeflection As Single
    ''' <summary>
    ''' 換算水平偏角 
    ''' 度変換
    ''' </summary>
    Public ReadOnly Property ConvertHorDeflection As Single
        Get
            Return _ConvertHorDeflection.ToDgree
        End Get
    End Property
    ''' <summary>
    ''' 開始ピッチング
    ''' </summary>
    Private StartPitching As Single     ''
    Private 現在の目標ピッチング As Single

    Private StartHoui As Single     ''開始方位
    Private 現在の目標方位 As Single


    Private StartRightStroke As Integer
    Private StartLeftStroke As Integer

    ''' <summary>
    ''' 現在の目標ストローク差
    ''' </summary>
    Private _TargetStrokeRealDiff As Single

    ''' <summary>
    ''' 上ストローク取付角度
    ''' 換算ストロークさ演算用
    ''' </summary>
    Private _topAttachDir As Single

    ''' <summary>
    ''' 水平ストローク取付角度
    ''' 換算ストロークさ演算用
    ''' </summary>
    Private _horAttachDir As Single

    ''' <summary>
    ''' 下ストローク取付角度
    ''' 換算ストロークさ演算用
    ''' </summary>
    Private _btmAttachDir As Single




    Public Const SelectHor = 0 '水平
    Public Const SelectTop = 1 '上
    Public Const SelectBtm = 2 '下

    Public Sub New()
        '換算ストローク差演算用のジャッキ取付角度取得
        If InitPara.StrokeNoTopRight <> 0 Then
            _topAttachDir = (360 - InitPara.MesureJackAngle(InitPara.StrokeNoTopRight)).ToRad
        End If
        _horAttachDir = (360 - InitPara.MesureJackAngle(InitPara.StrokeNoHorRight)).ToRad
        If InitPara.StrokeNoBtmRight <> 0 Then
            _btmAttachDir = (360 - InitPara.MesureJackAngle(InitPara.StrokeNoBtmRight)).ToRad
        End If


    End Sub



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


    End Sub


    ''' <summary>
    ''' どのストロークを制御に使用するか
    ''' 0:水平　1:上　2:下
    ''' </summary>
    Public Property StrokeSelect As Short





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

    ''' <summary>
    ''' 上ストローク換算ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertTopStrokeDiff As Single
    ''' <summary>
    ''' 水平ストローク換算ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertHorStrokeDiff As Single
    ''' <summary>
    ''' 下ストローク換算ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertBottomStrokeDiff As Single

    ''' <summary>
    ''' 制御ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ControlStrokeDiff As Single

    ''' <summary>
    ''' 上開始ストローク換算開始ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertTopStartStrokeDiff As Single
    ''' <summary>
    ''' 水平開始ストローク換算開始ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertHorStartStrokeDiff As Single
    ''' <summary>
    ''' 下開始ストローク換算開始ストローク差
    ''' </summary>
    ''' <returns></returns>
    Public Property ConVertBottomStartStrokeDiff As Single

    ''' <summary>
    ''' リング内発生ストローク量
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RingUpStroke As Single
        Get
            Return CtlPara.HorTargerStrokeDev - ConVertHorStartStrokeDiff
        End Get
    End Property



    '


    ''' <summary>
    ''' ストローク偏差
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property StrokeDiffDeflection As Single
        Get
            Return Sin(_ConvertHorDeflection) * InitPara.CntDistLRSpreader * 1000
        End Get
    End Property


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
    Public ReadOnly Property TargetStrokeRealDiff() As Single
        Get
            TargetStrokeRealDiff = _TargetStrokeRealDiff
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

        'NowAveStroke = (PlcIf.RightStroke + PlcIf.LeftStroke) / 2 / 1000

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

        Dim TotalStroke As Single = CtlPara.TargetNetStroke / 1000 ''全推進量(m)
        Dim TotalHouiDev As Single ''全方位変化量
        Dim dblRh As Double ''曲率半径

        ''掘進開始時の演算処理
        '開始ストローク差の角度換算値　反時計回り＋
        StartAmsKanzan = Math.Asin((CtlPara.StartJackStroke(InitPara.StrokeNoHorRight) - CtlPara.StartJackStroke(InitPara.StrokeNoHorLeft)) / 1000 / InitPara.CntDistLRSpreader)


        ''全ストローク差変化量の角度換算値（°）　反時計回り
        TotalHouiDev = Math.Asin(CtlPara.HorTargerStrokeDev / 1000 / InitPara.CntDistLRSpreader) - StartAmsKanzan

        If Abs(TotalHouiDev * 180 / PI) > CtlPara.horCurveMngAngle Then
            dblRh = TotalStroke / (2 * Math.Sin(TotalHouiDev / 2))
            If CalcStroke.MesureCalcAveJackStroke < CtlPara.TargetNetStroke + CtlPara.StartAveStroke Then
                ConVertRealTargetDirction = 2 * Math.Asin((CalcStroke.CalcAveLogicalStroke / 1000) / dblRh / 2) + StartAmsKanzan
            Else
                ConVertRealTargetDirction = 2 * Math.Asin((CtlPara.TargetNetStroke / 1000) / dblRh / 2) + StartAmsKanzan
            End If
        Else
            ''直線管理
            ConVertRealTargetDirction = TotalHouiDev + StartAmsKanzan
        End If

        '換算ストローク差演算
        ConVertTopStrokeDiff = (TopRighttStroke - TopLeftStroke) / Math.Cos(_topAttachDir)
        ConVertHorStrokeDiff = (HorizonRighttStroke - HorizonLefttStroke) / Math.Cos(_horAttachDir)
        ConVertBottomStrokeDiff = (BottomRighttStroke - BottomLefttStroke) / Math.Cos(_btmAttachDir)

        '換算ストローク差演算
        If InitPara.StrokeNoTopRight <> 0 Then
            ConVertTopStartStrokeDiff = (CtlPara.StartJackStroke(InitPara.StrokeNoTopRight) - CtlPara.StartJackStroke(InitPara.StrokeNoTopLeft)) / Math.Cos(_horAttachDir)
        End If
        ConVertHorStartStrokeDiff = (CtlPara.StartJackStroke(InitPara.StrokeNoHorRight) - CtlPara.StartJackStroke(InitPara.StrokeNoHorLeft)) / Math.Cos(_horAttachDir)
        If InitPara.StrokeNoBtmRight <> 0 Then
            ConVertBottomStartStrokeDiff = (CtlPara.StartJackStroke(InitPara.StrokeNoBtmRight) - CtlPara.StartJackStroke(InitPara.StrokeNoBtmLeft)) / Math.Cos(_horAttachDir)
        End If


        If Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoHorRight) And
            Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoHorLeft) Then
            StrokeSelect = SelectHor
        ElseIf Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoTopRight) And
            Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoTopLeft) Then
            StrokeSelect = SelectTop
        ElseIf Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoBtmRight) And
            Not CalcStroke.ExclusionJack.Contains(InitPara.StrokeNoBtmLeft) Then
            StrokeSelect = SelectBtm
        End If









        'どのストローク差で制御するか選択
        Select Case StrokeSelect
            Case SelectBtm
                ControlStrokeDiff = ConVertBottomStrokeDiff
            Case SelectHor
                ControlStrokeDiff = ConVertHorStrokeDiff
            Case SelectTop
                ControlStrokeDiff = ConVertTopStrokeDiff
        End Select


        ''実測水平角（角度換算）
        ConvertSurveyHorDir = Math.Asin((ControlStrokeDiff) / 1000 / InitPara.CntDistLRSpreader)

        'ストローク偏差　角度換算
        _ConvertHorDeflection = -(ConvertSurveyHorDir - ConVertRealTargetDirction)

        '現在の目標ストローク差
        _TargetStrokeRealDiff = Sin(ConVertRealTargetDirction) * InitPara.CntDistLRSpreader * 1000


    End Sub





End Class
