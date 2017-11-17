Imports System.Diagnostics
''' <summary>
''' 経過時間の算出
''' </summary>
Public Class clsElapsedTime
    ''' <summary>
    ''' 掘進時間ストップウォッチ
    ''' </summary>
    Private ExcavationTimeSw As New Stopwatch

    ''' <summary>
    ''' 中断時間ストップウォッチ
    ''' </summary>
    Private InterruptTimeSw As New Stopwatch



    ''' <summary>
    ''' 同時施工時間ストップウォッチ
    ''' </summary>
    Private LosZeroExcavationTimeSw As New Stopwatch
    ''' <summary>
    ''' 待機時間ストップウォッチ
    ''' </summary>
    Private WaitingTimeSw As New Stopwatch
    ''' <summary>
    ''' サイクルタイムストップウォッチ
    ''' </summary>
    Private CycleTimeSw As New Stopwatch
    ''' <summary>
    ''' 掘進時間
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ExcavationTime As Integer
        Get
            'ミリ秒を分に変換
            Return ExcavationTimeSw.ElapsedMilliseconds / 1000 / 60
        End Get
    End Property
    ''' <summary>
    ''' 中断時間
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property InterruptTime As Integer
        Get
            Return InterruptTimeSw.ElapsedMilliseconds / 1000 / 60
        End Get
    End Property


    ''' <summary>
    ''' 同時施工時間
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LozeroExcavationTime As Integer
        Get
            Return LosZeroExcavationTimeSw.ElapsedMilliseconds / 1000 / 60
        End Get
    End Property
    ''' <summary>
    ''' 待機時間
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property WatingTime As Integer
        Get
            Return WaitingTimeSw.ElapsedMilliseconds / 1000 / 60
        End Get
    End Property
    ''' <summary>
    ''' サイクルタイム
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CycleTime As Integer
        Get
            Return CycleTimeSw.ElapsedMilliseconds / 1000 / 60
        End Get
    End Property
    ''' <summary>
    ''' 時間のリセット
    ''' </summary>
    Public Sub Reset()

        WaitingTimeSw.Stop()
        LosZeroExcavationTimeSw.Reset()
        InterruptTimeSw.Reset()
        ExcavationTimeSw.Reset()
        ExcavationTimeSw.Start()
        CycleTimeSw.Reset()
    End Sub
    ''' <summary>
    ''' セグメントモード
    ''' </summary>
    Public Sub SegmentMode()
        InterruptTimeSw.Stop()
        WaitingTimeSw.Reset()
        WaitingTimeSw.Start()
    End Sub


    ''' <summary>
    ''' 掘進再開
    ''' </summary>
    Public Sub ExcavationStart()
        InterruptTimeSw.Stop()
        ExcavationTimeSw.Start()
    End Sub
    ''' <summary>
    ''' 掘進停止
    ''' </summary>
    Public Sub ExcavationStop()
        ExcavationTimeSw.Stop()
        LosZeroExcavationTimeSw.Stop()
        InterruptTimeSw.Start()

    End Sub
    ''' <summary>
    ''' 同時施工掘進時間積算開始
    ''' </summary>
    Public Sub LosZeroStart()
        LosZeroExcavationTimeSw.Start()
    End Sub
    ''' <summary>
    ''' 同時施工掘進時間積算停止
    ''' </summary>
    Public Sub LosZeroStop()
        LosZeroExcavationTimeSw.Stop()
    End Sub
    ''' <summary>
    ''' 待機時間開始
    ''' </summary>
    Public Sub WaingStart()
        WaitingTimeSw.Reset()
        WaitingTimeSw.Start()
    End Sub


End Class
