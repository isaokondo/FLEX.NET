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
    Private _mesureCalcAveJackStroke As Integer
    ''' <summary>
    ''' 後胴部ローリング
    ''' </summary>
    Private _rearDrumRolling As Single
    ''' <summary>
    ''' セグメントローリング
    ''' </summary>
    Private _segmentRolling As Single
    ''' <summary>
    ''' ジャッキステータス　掘進中、組立中、組み立て後の掘進中
    ''' </summary>
    Private _jackStatus As Short()
    ''' <summary>
    ''' セグメント中心幅
    ''' </summary>
    Private _segnebtCenterWidth As Single
    ''' <summary>
    ''' セグメントテーパー量
    ''' </summary>
    Private _segmentTaperValue As Single
    ''' <summary>
    ''' セグメント最大テーパー位置
    ''' </summary>
    Private _segmentMaxTaperLoc As Single
    ''' <summary>
    ''' 組立完了のジャッキ
    ''' </summary>
    Private asembleFinishedJack As New List(Of Short)
    ''' <summary>
    ''' 計測ジャッキストローク
    ''' </summary>
    Public WriteOnly Property MesureJackStroke As Dictionary(Of Short, Integer)
        Set(value As Dictionary(Of Short, Integer))
            _mesureCalcJackStroke = value
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
    Public ReadOnly Property MesureCalcAveJackStroke As Integer
        Get
            Return _mesureCalcAveJackStroke
        End Get
    End Property
    ''' <summary>
    ''' 組立完了ジャッキのセット
    ''' </summary>
    Public Sub SetAsembleJack(jk As List(Of Short))
        For Each i In jk
            asembleFinishedJack.Add(i)
        Next
    End Sub
    ''' <summary>
    ''' 掘進開始
    ''' </summary>
    Public Sub ExecavStart()
        '組立完了ジャッキのクリア
        asembleFinishedJack.Clear()
    End Sub


    Public Sub New()
        '計算ジャッキストロークの初期化
        For Each i As Short In InitParameter.MesureJack.Keys
            _mesureCalcJackStroke.Add(i, 0)
        Next
    End Sub

    ''' <summary>
    ''' 計算ストロークの演算
    ''' </summary>
    Public Sub Calc()
        '計測ジャッキ
        For Each mjJkNo As Short In InitParameter.MesureJack.Keys
            _mesureCalcJackStroke(mjJkNo) = _mesureJackStroke(mjJkNo)
            '組立完了ジャッキ
            For Each asJkNo As Short In asembleFinishedJack
                If mjJkNo = asJkNo Then
                    'セグメント幅分を加算
                    _mesureCalcJackStroke(mjJkNo) +=
                    _segnebtCenterWidth +
                    _segmentTaperValue / 2 *
                    Math.Cos((_segmentMaxTaperLoc + _rearDrumRolling - _segmentRolling - InitParameter.MesureJack(mjJkNo)) _
                    / 180 * Math.PI)
                End If
            Next
        Next
        '計算平均ジャッキストロークの演算
        Dim cnt As Short = 0
        Dim st As Integer = 0
        For i As Short = 0 To InitParameter.NumberJack - 1
            If PlcIf.JackStatus(i) And 1 Then   '掘進モードのみ
                For Each s In _mesureCalcJackStroke
                    If s.Key = i + 1 Then
                        cnt += 1
                        st += s.Value
                    End If
                Next
            End If
        Next
        If cnt <> 0 Then
            _mesureCalcAveJackStroke = st / cnt
        End If



    End Sub



End Class
