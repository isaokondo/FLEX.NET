Imports System
Imports System.IO.Ports
Imports System.Text

Public Class QsSerial

    Public Shared Cmod As Integer '送信モード（0：ﾒｲﾝ　1：ｻﾌﾞ）
    Public Shared Amod As Integer '返信モード
    Public Shared Send As String '送信データ
    Public Shared Stok As String '送信データ（一時待避）
    Public Shared Recv As String '受信データ
    Public Shared Rstk As String '受信持ち越しデータ
    Public Shared Acnt As Integer 'ACK受信回数
    Public Shared Rchk As Boolean '受信完了
    Public Shared Wrcv As Integer '受信待ち回数
    Public Shared Rtry As Integer '追尾リトライ回数
    Public Shared Data As List(Of String) '測定結果
    Public Shared cont As Integer '連続計測カウント
    Public Shared Schf As Boolean 'サーチタイマーの動作切り替え

    Public Shared Safe As Boolean '保護機能有効フラグ
    Public Shared Wsec As Integer 'ウェイト時間
    Public Shared Wint As Integer 'インターバル
    Public Shared Wtim As Integer 'ウェイト・インターバル共通タイマー
    Public Shared Wmod As Integer 'ウェイト返信モード

    Public Function modeAngZ10(ByVal str As String) As List(Of String)

        '角度測定モード（Z10、Z12、Z13、Z20）のデータ抽出

        Dim _mes As New List(Of String)

        If Asc(Mid(str, 1, 1)) = 39 Then

            '1秒精度の本体で最小角表示がONの時の形式：'08520300+12030400+01270d
            _mes.Add("") '0 斜距離（ｍ） データ無し
            _mes.Add(Mid(str, 2, 3)) '1 鉛直角（度）
            _mes.Add(Mid(str, 5, 2)) '2 鉛直角（分）
            _mes.Add(Mid(str, 7, 2) & "." & Mid(str, 9, 1)) '3 鉛直角（秒）
            _mes.Add(Mid(str, 10, 4)) '4 水平角（度）
            _mes.Add(Mid(str, 14, 2)) '5 水平角（分）
            _mes.Add(Mid(str, 16, 2) & "." & Mid(str, 18, 1)) '6 水平角（秒）
            _mes.Add(Mid(str, 19, 3)) '7 チルト(分）
            _mes.Add(Mid(str, 22, 2) & "." & Mid(str, 24, 1)) '8 チルト(秒）
            _mes.Add("") '9 水平距離（m）データ無し
            _mes.Add("") '10 鉛直角傾斜補正 データ無し
            _mes.Add("") '11 EDM 反射光レベル データ無し
            _mes.Add("") '12 EDM 気象補正値 データ無し
            _mes.Add("") '13 プリズム定数 データ無し
            _mes.Add(Mid(str, 25, 1)) '14 バッテリーレベル
            _mes.Add(Mid(str, 26, 1)) '15 EDMモード
            _mes.Add(Mid(str, 27, 1)) '16 追尾モード
            _mes.Add(Mid(str, 28, 1)) '17 フェイス
            _mes.Add(Mid(str, 29, 1)) '18 チルト補正

        ElseIf Asc(Mid(str, 1, 1)) = 60 Then

            '1秒精度の本体で最小角表示がOFFの時の形式：<0862405+1745545+0127d
            _mes.Add("") '0 斜距離（ｍ） データ無し
            _mes.Add(Mid(str, 2, 3)) '1 鉛直角（度）
            _mes.Add(Mid(str, 5, 2)) '2 鉛直角（分）
            _mes.Add(Mid(str, 7, 2)) '3 鉛直角（秒）
            _mes.Add(Mid(str, 9, 4)) '4 水平角（度）
            _mes.Add(Mid(str, 13, 2)) '5 水平角（分）
            _mes.Add(Mid(str, 15, 2)) '6 水平角（秒）
            _mes.Add(Mid(str, 17, 3)) '7 チルト(分）
            _mes.Add(Mid(str, 20, 2)) '8 チルト(秒）
            _mes.Add("") '9 水平距離（m）データ無し
            _mes.Add("") '10 鉛直角傾斜補正 データ無し
            _mes.Add("") '11 EDM 反射光レベル データ無し
            _mes.Add("") '12 EDM 気象補正値 データ無し
            _mes.Add("") '13 プリズム定数 データ無し
            _mes.Add(Mid(str, 23, 1)) '14 バッテリーレベル
            _mes.Add(Mid(str, 24, 1)) '15 EDMモード
            _mes.Add(Mid(str, 25, 1)) '16 追尾モード
            _mes.Add(Mid(str, 26, 1)) '17 フェイス
            _mes.Add(Mid(str, 27, 1)) '18 チルト補正

        End If

        Return _mes

    End Function

    Public Function modeDisZ30(ByVal str As String) As List(Of String)

        '斜距離測定モード（Z30）のデータ抽出

        Dim _mes As New List(Of String)

        If Asc(Mid(str, 1, 1)) = 40 Then
            '                                                            123456789012345678901234567890123456789012345678901234
            'Z32～35コマンドに対する測定データ形式（精密測距ONの場合）：'(+011784812m08520300+12030400d+011745724t15+0000+025** BCC ETX CR LF
            _mes.Add(Mid(str, 2, 6) & "." & Mid(str, 8, 4)) '0 斜距離（m）
            _mes.Add(Mid(str, 13, 3)) '1 鉛直角（度）
            _mes.Add(Mid(str, 16, 2)) '2 鉛直角（分）
            _mes.Add(Mid(str, 18, 2) & "." & Mid(str, 20, 1)) '3 鉛直角（秒）
            _mes.Add(Mid(str, 21, 4)) '4 水平角（度）
            _mes.Add(Mid(str, 25, 2)) '5 水平角（分）
            _mes.Add(Mid(str, 27, 2) & "." & Mid(str, 29, 1)) '6 水平角（秒）
            _mes.Add("") '7 チルト（分）データ無し
            _mes.Add("") '8 チルト（秒）データ無し
            _mes.Add(Mid(str, 31, 6) & "." & Mid(str, 37, 4)) '9 水平距離（m）
            _mes.Add(Mid(str, 41, 1)) '10 鉛直角傾斜補正
            _mes.Add(Mid(str, 42, 2)) '11 EDM 反射光レベル
            _mes.Add(Mid(str, 44, 4) & "." & Mid(str, 48, 1)) '12 EDM 気象補正値
            _mes.Add(Mid(str, 49, 3) & "." & Mid(str, 52, 1)) '13 プリズム定数
            _mes.Add(Mid(str, 53, 1)) '14 バッテリーレベル
            _mes.Add(Mid(str, 54, 1)) '15 EDMモード
            _mes.Add(Mid(str, 55, 1)) '16 追尾モード
            _mes.Add(Mid(str, 56, 1)) '17 フェイス
            _mes.Add(Mid(str, 57, 1)) '18 チルト補正

        ElseIf Asc(Mid(str, 1, 1)) = 63 Then
            '                                                             123456789012345678901234567890123456789012345678901234
            'Z32～35コマンドに対する測定データ形式（精密測距OFFの場合）：'?+01178481m0852030+1203040d+01174572t15+00+25141rt BCC ETX CR LF
            _mes.Add(Mid(str, 2, 6) & "." & Mid(str, 8, 3)) '0 斜距離（m）
            _mes.Add(Mid(str, 12, 3)) '1 鉛直角（度）
            _mes.Add(Mid(str, 15, 2)) '2 鉛直角（分）
            _mes.Add(Mid(str, 17, 2)) '3 鉛直角（秒）
            _mes.Add(Mid(str, 19, 4)) '4 水平角（度）
            _mes.Add(Mid(str, 23, 2)) '5 水平角（分）
            _mes.Add(Mid(str, 25, 2)) '6 水平角（秒）
            _mes.Add("") '7 チルト（分）データ無し
            _mes.Add("") '8 チルト（秒）データ無し
            _mes.Add(Mid(str, 28, 6) & "." & Mid(str, 34, 3)) '9 水平距離（m）
            _mes.Add(Mid(str, 37, 1)) '10 鉛直角傾斜補正
            _mes.Add(Mid(str, 38, 2)) '11 EDM 反射光レベル
            _mes.Add(Mid(str, 40, 3)) '12 EDM 気象補正値
            _mes.Add(Mid(str, 43, 3)) '13 プリズム定数
            _mes.Add(Mid(str, 46, 1)) '14 バッテリーレベル
            _mes.Add(Mid(str, 47, 1)) '15 EDMモード
            _mes.Add(Mid(str, 48, 1)) '16 追尾モード
            _mes.Add(Mid(str, 49, 1)) '17 フェイス
            _mes.Add(Mid(str, 50, 1)) '18 チルト補正

        ElseIf Asc(Mid(str, 1, 1)) = 68 Then
            '                                                         123456789012345678901234567890123456789012345678901234
            'Z31コマンドに対する測定データ形式（CRS 10mm 連続出力）：'?+01178481m141rt BCC ETX CR LF
            _mes.Add(Mid(str, 2, 6) & "." & Mid(str, 8, 3)) '0 斜距離（m）
            _mes.Add("") '1 鉛直角（度）データ無し
            _mes.Add("") '2 鉛直角（分）データ無し
            _mes.Add("") '3 鉛直角（秒）データ無し
            _mes.Add("") '4 水平角（度）データ無し
            _mes.Add("") '5 水平角（分）データ無し
            _mes.Add("") '6 水平角（秒）データ無し
            _mes.Add("") '7 チルト（分）データ無し
            _mes.Add("") '8 チルト（秒）データ無し
            _mes.Add("") '7 水平距離（m）データ無し
            _mes.Add("") '8 鉛直角傾斜補正 データ無し
            _mes.Add("") '9 EDM 反射光レベル データ無し
            _mes.Add("") '10 EDM 気象補正値 データ無し
            _mes.Add("") '11 プリズム定数 データ無し
            _mes.Add(Mid(str, 11, 1)) '12 バッテリーレベル
            _mes.Add(Mid(str, 12, 1)) '13 EDMモード
            _mes.Add(Mid(str, 13, 1)) '14 追尾モード
            _mes.Add(Mid(str, 14, 1)) '15 フェイス
            _mes.Add(Mid(str, 15, 1)) '16 チルト補正
        End If

        Return _mes

    End Function


    Private _tmg As List(Of Integer)

    Public Function MakeSendCmd(ByRef Cmd As String) As List(Of Byte)

        'コマンドからTS電文を作成する。
        'Cmd：コマンド（文字型変数、文字列）
        '返値：List変数（バイト型LIST配列、アスキーコード）

        'テキストボックスから、送信するテキストを取り出す.
        Dim _bcc As String
        Dim _bccvl As Integer = 0
        Dim _txd As New List(Of Byte)
        Dim i As Integer

        'コマンド作成
        If Cmd = "ACK" Then
            _txd.Add(CByte("&H06")) 'ACKのアスキーコード
            _bccvl = _bccvl Xor _txd(0)
        Else
            For i = 1 To Cmd.Length
                _txd.Add(Asc(Mid(Cmd, i, 1)))
                _bccvl = _bccvl Xor _txd(i - 1) 'BCCを排他的論理和で算出
            Next
        End If

        'BCC作成
        _bcc = CStr(_bccvl)
        _bcc = StrNumLeft0(_bcc, 3, 0) '左を0で埋めた3桁の数値文字に変換
        For i = 1 To _bcc.Length
            _txd.Add(Asc(Mid(_bcc, i, 1)))
        Next

        'ETXを付加
        _txd.Add(CByte("&H03")) 'ETXのアスキーコード

        Return _txd

    End Function

    Public Function StrNumLeft0(ByVal str As String, ByVal value As Integer, ByVal flg As Integer) As String

        '桁未定の数値文字を左側を0で埋めた指定桁数の数値文字にして返す。
        '±を表示する場合は指定桁数+1桁とし、左側に付加する。
        '桁未定の数値文字：str
        '指定桁数：value
        '±の付加:flg  0 付加しない　1 指定桁数+1にして左側に付加する

        Dim _St As String = ""
        Dim _n As Integer
        Dim _nS As String = ""
        Dim _fugou As Boolean = True
        Dim i As Integer

        For i = 1 To str.Length
            '入力値の±をチェックして符号を外す
            If Mid(str, i, 1) = "-" Then
                _fugou = False
            ElseIf Mid(str, i, 1) <> "+" Then
                _St = _St & Mid(str, i, 1)
            End If
        Next

        '不足桁分の0を作成する
        _n = value - _St.Length
        For i = 1 To _n
            _nS = _nS & "0"
        Next

        '指定桁を作成
        _St = _nS & _St

        '符号を付加する
        If flg = 1 Then
            If _fugou = True Then
                _St = "+" & _St
            Else
                _St = "-" & _St
            End If
        End If

        Return _St

    End Function

    Public Function TxttoAsc(ByVal Str As String) As String

        '文字列を「空白を入れたアスキーコード」ににして返す。

        Dim _st As String = ""
        Dim i As Integer

        For i = 1 To Str.Length
            If i = 1 Then
                _st = _st & Format(Asc(Mid(Str, i, 1)), "00")
            Else
                _st = _st & " " & Format(Asc(Mid(Str, i, 1)), "00")
            End If
        Next

        Return _st


    End Function


    Public Function AsctoTxt(ByRef Asc As List(Of Byte)) As String

        'List型変数に保存されたアスキーコードを「空白を入れたコードの文字列」にして返す。

        Dim _st As String = ""

        _st = _st & CType(Asc(0), String)

        For i As Integer = 1 To Asc.Count - 1
            _st = _st & " " & CType(Asc(i), String)
        Next

        Return _st

    End Function


End Class
