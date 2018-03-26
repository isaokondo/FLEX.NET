Option Explicit On
''' <summary>
''' 計算ストローク　ロスゼロ時
''' </summary>
Public Class clsCalcuStroke
    '計測ジャッキ番号、値　Dictionary
    ''' <summary>
    ''' 計測ジャッキストローク
    ''' </summary>
    Private _mesureJackStroke As New Dictionary(Of Short, Integer)
    ''' <summary>
    ''' 計測ジャッキスピード
    ''' </summary>
    Private _mesureJackSpeed As New Dictionary(Of Short, Integer)
    ''' <summary>
    ''' 計算ジャッキストローク
    ''' </summary>
    Private _mesureCalcJackStroke As New Dictionary(Of Short, Integer)
    ''' <summary>
    ''' 計算平均ジャッキストローク
    ''' </summary>
    Private _mesureCalcAveJackStroke As Single

    ''' <summary>
    ''' 計測ジャッキオフセットストローク
    ''' </summary>
    Private _mesureOffsetJackStroke As New Dictionary(Of Short, Integer)


    ''' <summary>
    ''' 計算平均ジャッキオフセットストローク
    ''' </summary>
    Private _aveOffsetJackStroke As Single




    ''' <summary>
    ''' ジャッキステータス　掘進中、組立中、組み立て後の掘進中
    ''' </summary>
    Private _jackStatus As Short()

    ''' <summary>
    ''' 引き戻しジャッキ
    ''' </summary>
    Private _PullBackJack As New List(Of Short)

    ''' <summary>
    ''' 組立完了のジャッキ
    ''' </summary>
    Private _asembleFinishedJack As New List(Of Short)

    ''' <summary>
    ''' 計算から除外するジャッキ　引き戻しジャッキで押込み完了してないジャッキ
    ''' </summary>
    Private _ExclusionJack As New List(Of Short)


    ''' <summary>
    ''' 後胴部ローリング
    ''' </summary>
    Public Property rearDrumRolling As Single
    ''' <summary>
    ''' セグメントローリング
    ''' </summary>
    Public Property segmentRolling As Single

    ''' <summary>
    ''' セグメント中心幅
    ''' </summary>
    Public Property SegnebtCenterWidth As Single
    ''' <summary>
    ''' セグメントテーパー量
    ''' </summary>
    Public Property SegmentTaperValue As Single
    ''' <summary>
    ''' セグメント最大テーパー位置
    ''' </summary>
    ''' 
    Public Property SegmentMaxTaperLoc As Single

    ''' <summary>
    ''' 計測ジャッキストローク
    ''' </summary>
    Public WriteOnly Property MesureJackStroke As Dictionary(Of Short, Integer)
        Set(value As Dictionary(Of Short, Integer))
            _mesureJackStroke = value
        End Set
    End Property
    ''' <summary>
    ''' 計測ジャッキスピード
    ''' </summary>
    Public WriteOnly Property MesureJackSpeed As Dictionary(Of Short, Integer)
        Set(value As Dictionary(Of Short, Integer))
            _mesureJackSpeed = value
        End Set
    End Property
    ''' <summary>
    ''' 計算ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureCalcJackStroke As Dictionary(Of Short, Integer)
        Get
            Return _mesureCalcJackStroke
        End Get
    End Property
    ''' <summary>
    ''' 計算平均ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public Property MesureCalcAveJackStroke As Single
        Get
            Return _mesureCalcAveJackStroke
        End Get
        Set(value As Single)
            _mesureCalcAveJackStroke = value
            GetOffsetStroke() 'オフセットストロークの算出

        End Set
    End Property
    ''' <summary>
    ''' 上計算ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TopCalcStroke As Integer
        Get
            Return _mesureCalcJackStroke(InitPara.mesureJackNo(0))
        End Get
    End Property
    ''' <summary>
    ''' 右計算ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RightCalcStroke As Integer
        Get
            Return _mesureCalcJackStroke(InitPara.mesureJackNo(1))
        End Get
    End Property
    ''' <summary>
    ''' 下計算ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property BottomCalcStroke As Integer
        Get
            Return _mesureCalcJackStroke(InitPara.mesureJackNo(2))
        End Get
    End Property
    ''' <summary>
    ''' 左計算ジャッキストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LeftCalcStroke As Integer
        Get
            Return _mesureCalcJackStroke(InitPara.mesureJackNo(3))
        End Get
    End Property

    ''' <summary>
    ''' 計算から除外するジャッキ(引き戻し、押込み中）
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ExclusionJack As List(Of Short)
        Get
            Return _ExclusionJack
        End Get
    End Property


    ''' <summary>
    ''' 計算平均掘進ストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CalcAveLogicalStroke As Single

    ''' <summary>
    ''' 計算計測掘進ストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureCalcLogicalStroke As New Dictionary(Of Short, Integer)
    ''' <summary>
    ''' 計測ジャッキ平均スピード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureAveSpeed As Integer
    'Public Property StartMesureStroke As New Dictionary(Of Short, Integer)






    Public ReadOnly Property JackState As Dictionary(Of Short, String)
        Get
            Dim jk As New Dictionary(Of Short, String)
            For Each j In InitPara.MesureJackAngle.Keys
                Dim st As String = "掘進モード"
                If _asembleFinishedJack.Contains(j) Then
                    st = "組立完了"
                End If
                If _ExclusionJack.Contains(j) Then
                    st = "組立中"
                End If
                jk.Add(j, st)
            Next

            Return jk
        End Get
    End Property

    ''' <summary>
    ''' 組立ジャッキ(押込み、追加押込みジャッキ）
    ''' </summary>
    ''' <returns></returns>
    Public Property asembleFinishedJack As List(Of Short)
        Get
            Return _asembleFinishedJack
        End Get
        Set(value As List(Of Short))
            _asembleFinishedJack.AddRange(value)
        End Set
    End Property
    ''' <summary>
    ''' 引き戻しジャッキ
    ''' </summary>
    ''' <returns></returns>
    Public Property PullBackJack As List(Of Short)
        Get
            Return _PullBackJack
        End Get
        Set(value As List(Of Short))
            _PullBackJack.AddRange(value)
            GetOffsetStroke() 'オフセットストロークの算出
        End Set
    End Property



    ''' <summary>
    ''' 掘進開始
    ''' </summary>
    Public Sub ExecavStart()
        '引き戻し、組立完了ジャッキのクリア
        _asembleFinishedJack.Clear()
        _PullBackJack.Clear()
        _aveOffsetJackStroke = 0

        For Each i As Short In InitPara.MesureJackAngle.Keys
            _mesureOffsetJackStroke(i) = 0
        Next

    End Sub


    Public Sub New()
        '計算ジャッキストロークの初期化
        For Each i As Short In InitPara.MesureJackAngle.Keys
            _mesureCalcJackStroke.Add(i, 0)
            _mesureJackStroke.Add(i, 0)
            _mesureJackSpeed.Add(i, 0)
            _MesureCalcLogicalStroke.Add(i, 0)
            _mesureOffsetJackStroke.Add(i, 0)
        Next
    End Sub

    '計算方法を変更

    'Public Sub Calc()
    '    _ExclusionJack.Clear()
    '    '計測ジャッキ
    '    For Each mjJkNo As Short In InitPara.MesureJackAngle.Keys
    '        _mesureCalcJackStroke(mjJkNo) = _mesureJackStroke(mjJkNo)
    '        '組立完了ジャッキ
    '        'For Each asJkNo As Short In _asembleFinishedJack
    '        '    If mjJkNo = asJkNo Then
    '        If _PullBackJack.Contains(mjJkNo) And Not _asembleFinishedJack.Contains(mjJkNo) Then
    '            _ExclusionJack.Add(mjJkNo)
    '        End If

    '        If _asembleFinishedJack.Contains(mjJkNo) Then
    '            'セグメント幅分を加算
    '            _mesureCalcJackStroke(mjJkNo) +=
    '                _SegnebtCenterWidth +
    '                _SegmentTaperValue / 2 *
    '                Math.Cos((_SegmentMaxTaperLoc + _rearDrumRolling - _segmentRolling - InitPara.MesureJackAngle(mjJkNo)) _
    '                / 180 * Math.PI)
    '        End If

    '        '    End If
    '        'Next
    '        If PlcIf.ExcavMode AndAlso _mesureCalcJackStroke(mjJkNo) >= CtlPara.StartJackStroke(mjJkNo) Then
    '            '掘進ストローク 掘進モードのときのみ演算
    '            _MesureCalcLogicalStroke(mjJkNo) = _mesureCalcJackStroke(mjJkNo) - CtlPara.StartJackStroke(mjJkNo)
    '        End If
    '    Next
    '    '除外ジャッキのセット
    '    clsGetAvg.ExceptionJack = _ExclusionJack

    '    ''計算平均ジャッキストロークの演算
    '    Dim CalcSt As New clsGetAvg(_mesureCalcJackStroke)
    '    _mesureCalcAveJackStroke = CalcSt.AvgData

    '    ''計算平均掘進ストロークの演算
    '    If PlcIf.ExcavMode Then
    '        Dim CalcLogicalSt As New clsGetAvg(_MesureCalcLogicalStroke)
    '        _CalcAveLogicalStroke = CalcLogicalSt.AvgData
    '    Else
    '        'セグメントモードの時
    '        _CalcAveLogicalStroke = SegAsmblyData.RingLastStroke(PlcIf.RingNo) - CtlPara.StartAveStroke
    '    End If

    '    '掘進中以外はゼロ
    '    If PlcIf.ExcaStatus = cKussin Then
    '        ''平均計測ジャッキスピードの演算
    '        Dim CalcSpeed As New clsGetAvg(_mesureJackSpeed)
    '        _MesureAveSpeed = CalcSpeed.AvgData
    '    Else
    '        _MesureAveSpeed = 0
    '    End If


    'End Sub

    ''' <summary>
    ''' オフセットストロークの算出
    ''' 各計測ジャッキ及び平均ジャッキストローク
    ''' 引き戻し開始時に実行
    ''' </summary>
    Private Sub GetOffsetStroke()
        For Each mjJkNo As Short In InitPara.MesureJackAngle.Keys
            _mesureOffsetJackStroke(mjJkNo) = _mesureJackStroke(mjJkNo)
        Next
        _aveOffsetJackStroke = _mesureCalcAveJackStroke

    End Sub



    ''' <summary>
    ''' 計算ストロークの演算
    ''' </summary>
    Public Sub Calc2()
        _ExclusionJack.Clear()
        '各ストロークの伸び分
        Dim AddStroke As New List(Of Integer)
        Dim LstSpeed As New List(Of Integer)
        '計測ジャッキ
        For Each mjJkNo As Short In InitPara.MesureJackAngle.Keys

            _mesureCalcJackStroke(mjJkNo) = _mesureJackStroke(mjJkNo)

            If _asembleFinishedJack.Contains(mjJkNo) Then
                'セグメント幅分を加算
                _mesureCalcJackStroke(mjJkNo) +=
                    _SegnebtCenterWidth +
                    _SegmentTaperValue / 2 *
                    Math.Cos((_SegmentMaxTaperLoc + _rearDrumRolling - _segmentRolling - InitPara.MesureJackAngle(mjJkNo)) _
                    / 180 * Math.PI)
            End If

            If _PullBackJack.Contains(mjJkNo) And Not _asembleFinishedJack.Contains(mjJkNo) Then
                _ExclusionJack.Add(mjJkNo) '計算から除外するジャッキ
            Else
                If _mesureJackStroke(mjJkNo) - _mesureOffsetJackStroke(mjJkNo) >= 0 Then
                    '計算するジャッキの伸び分
                    AddStroke.Add(_mesureJackStroke(mjJkNo) - _mesureOffsetJackStroke(mjJkNo))
                    '計算するジャッキ速度
                    LstSpeed.Add(_mesureJackSpeed(mjJkNo))
                End If
            End If
            '    '掘進ストローク 掘進モードのときのみ演算
            _MesureCalcLogicalStroke(mjJkNo) = _mesureCalcJackStroke(mjJkNo) - CtlPara.StartJackStroke(mjJkNo)
            'End If
        Next
        If PlcIf.ExcavMode Then
            '掘進モード時は、有効ストローク増加分の平均を加算
            _mesureCalcAveJackStroke = _aveOffsetJackStroke
            If AddStroke.Count > 0 Then
                _mesureCalcAveJackStroke += AddStroke.Average
            End If
            _CalcAveLogicalStroke = _mesureCalcAveJackStroke - CtlPara.StartJackStroke.Values.Average
        Else
            _CalcAveLogicalStroke = SegAsmblyData.RingLastStroke(PlcIf.RingNo) - CtlPara.StartJackStroke.Values.Average
        End If


        '掘進中以外はゼロ
        If PlcIf.ExcaStatus = cKussin And LstSpeed.Count > 0 Then
            ''平均計測ジャッキスピードの演算
            _MesureAveSpeed = LstSpeed.Average
        Else
            _MesureAveSpeed = 0
        End If


    End Sub

    Private Class clsGetAvg
        'ジャッキ番号、データ
        Private JackData As Dictionary(Of Short, Integer)
        Public ReadOnly Property AvgData As Integer
            Get
                Dim jkD As New List(Of Integer) '合計データ
                For Each sp In JackData
                    '各ジャッキの引き戻し指令がONで引き戻し開始から押し込み中まで　のジャッキは除外 　有効ジャッキ（設定)
                    If Not ExceptionJack.Contains(sp.Key) And Not CtlPara.ExceptMesureJackNo.Contains(sp.Key) Then
                        jkD.Add(sp.Value)
                    End If
                Next
                If jkD.Count > 0 Then
                    Return jkD.Average '平均処理
                Else
                    Return 0
                End If
            End Get
        End Property

        Public Sub New(t As Dictionary(Of Short, Integer))
            JackData = t
        End Sub

        ''' <summary>
        ''' 除外ジャッキ
        ''' </summary>
        Public Shared ExceptionJack As List(Of Short)




    End Class




End Class
