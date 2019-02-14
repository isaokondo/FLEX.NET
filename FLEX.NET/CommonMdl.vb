Imports System.Math
Imports System.Runtime.CompilerServices

Module CommonMdl
    ''' <summary>
    ''' 圧力指令値のﾀﾞｲﾚｸﾄ出力(全開）
    ''' </summary>
    Public Const cFillPower As Short = &HAAS
    ''' <summary>
    ''' PID演算開始
    ''' </summary>
    Public Const cPIDOut As Short = &HFFS ''
    Public Const cIgnoreOut As Short = &H22S ''待機中につき演算無視

    ''' <summary>
    ''' 減圧弁トラッキング 01.09.20  追加
    ''' </summary>
    Public Const cTracking As Short = &H44S ''
    ''' <summary>
    ''' ダイレクト指令制御
    ''' </summary>
    Public Const cDirect As Short = &H33S

    ''' <summary>
    ''' 減圧弁特性取得モード 増加　ダイレクト制御時のパラメータを取得
    ''' </summary>
    Public Const cReducePropertyGetAdd As Short = &H60S
    ''' <summary>
    ''' 減圧弁特性取得モード　減少　ダイレクト制御時のパラメータを取得
    ''' </summary>
    Public Const cReducePropertyGetSub As Short = &H61S


    Public Const c全押しスタート As Short = 0
    Public Const c前回値保持 As Short = 1
    Public Const c減圧前 As Short = 2


    ''掘進ステータス定数
    Public Const cTaiki As Short = 1 ''待機中
    Public Const cKussin As Short = 2 ''掘進中
    Public Const cChudan As Short = 3 ''中断中

    'TODO:データベースより読み込むように変更
    'Public gdblToStartDistance As Double ''起点から発進座標までの累積距離

    ''' <summary>
    ''' プロジェクトのバージョン番号
    ''' </summary>
    ''' <returns></returns>
    Public Function GetVersionNo() As String
        Return $" {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}.{My.Application.Info.Version.Revision}"
    End Function




    ''' <summary>
    ''' 左回りを右回りに変換し、値を０～３６０に調整
    ''' </summary>
    ''' <param name="Hoko"></param>
    ''' <returns></returns>
    Function Hoko2Hoi(ByRef Hoko As Double) As Double
        ''左回り角度±１８０度を方位角に変換
        '   '01/06/28 追加
        '   Hoko = Lim180(Hoko)
        '   Hoko2Hoi = -Hoko
        '   If Hoko2Hoi < 0 Then
        '       Hoko2Hoi = Hoko2Hoi + 360
        '   End If
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        '左回りを右回りに変換し、値を０～３６０に調整
        Hoko2Hoi = -Hoko
        Do While Hoko2Hoi < 0 Or Hoko2Hoi > 360
            If Hoko2Hoi < 0 Then
                Return Hoko2Hoi + 360
            End If
            If Hoko2Hoi > 360 Then
                Return Hoko2Hoi - 360
            End If
        Loop
    End Function
    ''' <summary>
    ''' 方位角（右回り０～３６０）を左回り角度±１８０度に変換
    ''' </summary>
    ''' <param name="Hoi"></param>
    ''' <returns></returns>
    Public Function Hoi2Hoko(ByVal Hoi As Double) As Double
        '方位角（右回り０～３６０）を左回り角度±１８０度に変換

        '   Hoi2Hoko = 360 - Hoi
        '   Hoi2Hoko = Lim180(Hoi2Hoko)
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Hoi2Hoko = 360 - Hoi
        Do While Hoi2Hoko < 0 Or Hoi2Hoko > 360
            If Hoi2Hoko < 0 Then
                Hoi2Hoko = Hoi2Hoko + 360
            End If
            If Hoi2Hoko > 360 Then
                Hoi2Hoko = Hoi2Hoko - 360
            End If
        Loop

    End Function
    ''' <summary>
    ''' ０～３６０度の角度を同回りの±１８０度に変換
    ''' </summary>
    ''' <param name="Kakudo"></param>
    ''' <returns></returns>
    Public Function Lim180(ByVal Kakudo As Double) As Double
        '０～３６０度の角度を同回りの±１８０度に変換

        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Do While Kakudo > 180 Or Kakudo < -180
            If Kakudo > 180 Then
                Return Kakudo - 360
            End If
            If Kakudo < -180 Then
                Return 360 + Kakudo
            End If
        Loop
        Return Kakudo
        'Lim180 = Kakudo
        'Exit Function

    End Function

    ''' <summary>
    ''' 限りなき小さい値はゼロにする
    ''' </summary>
    ''' <param name="vData"></param>
    ''' <returns>実数判定用幅ΔCの範囲内の値の時は真</returns>
    Public Function fnNearZero(ByVal vData As Double) As Boolean
        Const cDeltaC As Double = 0.0001
        Return vData >= -cDeltaC And vData <= cDeltaC
        'If vData >= -cDeltaC And vData <= cDeltaC Then
        '    fnNearZero = True
        'Else
        '    fnNearZero = False
        'End If
    End Function
    ''' <summary>
    ''' 360°の値を５度ピッチに四捨五入
    ''' </summary>
    ''' <param name="Deg"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToRound5(ByVal Deg As Short) As Short
        If IsNumeric(Deg) Then
            Dim t As Short = Round(Deg / 5) * 5
            If t > 360 Then t = t - 360
            Return t
        Else
            Return 0
        End If

    End Function




    ''' <summary>
    ''' ディグリーをパーミリへ変換
    ''' </summary>
    ''' <param name="dblDeg"></param>
    ''' <returns></returns>
    Public Function DegToPermili(ByRef dblDeg As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :
        '
        ' 引数      :
        '
        ' 備考      :02/09/11 追加

        Return Tan(dblDeg * Math.PI / 180) * 1000


    End Function

    ''' <summary>
    ''' パーミリをディグリーへ変換
    ''' </summary>
    ''' <param name="dblPermili"></param>
    ''' <returns></returns>
    Public Function PermiliToDeg(ByRef dblPermili As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :パーミリをディグリーへ変換
        '
        ' 引数      :
        '
        ' 備考      :02/10/08 追加

        Return Atan(dblPermili / 1000) / (PI / 180)


    End Function


    ''' <summary>
    ''' 度をラジアンに変換
    ''' </summary>
    ''' <param name="Deg"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToRad(ByVal Deg As Object) As Double
        If IsNumeric(Deg) Then
            Return Deg * PI / 180
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' 文字列の数値はそのまま、それ以外は０の文字列を返す
    ''' </summary>
    ''' <param name="tmp"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToNum(ByVal tmp As String) As Double
        If IsNumeric(tmp) Then
            Return tmp.ToString
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' 文字列から数値を取り出す
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToGetNum(st As String) As Short
        Return Val(Array.FindAll(st.ToString.ToCharArray, AddressOf IsNumeric))
    End Function

    ''' <summary>
    ''' リストをコンマ区切りの文字列に
    ''' </summary>
    ''' <param name="st"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToCommaDelmit(st As List(Of Short)) As String
        If st.Count <> 0 Then
            Return String.Join(",", st)
        Else
            Return ""
        End If

    End Function





End Module
