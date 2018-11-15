Public Class clsLedLiner


    Public Event ErrorOccur(msg As String)


    Private _sendMsg As String

    Private _HostEnable As Boolean 'IPアドレス、ポート名　有効化

    Private _Scroll As Boolean = True

    Public Sub New()
        _HostEnable = True

        Dim ipAd As Net.IPAddress = Nothing

        _HostEnable = Net.IPAddress.TryParse(InitPara.LedLinerHostName, ipAd)


    End Sub

    Public Property SendMsg As String
        Get
            Return _sendMsg
        End Get
        Set(value As String)
            _sendMsg = value
            LedCom
        End Set
    End Property
    ''' <summary>
    ''' 文字をすくルールさせるか
    ''' </summary>
    ''' <returns></returns>
    Private Property Scroll As Boolean
        Get
            Return _Scroll
        End Get
        Set(value As Boolean)
            value = _Scroll
        End Set
    End Property


    Private Sub LedCom()

        '何も入力されなかった時は終了
        If _sendMsg Is Nothing OrElse _sendMsg.Length = 0 Or Not _HostEnable Then
            Return
        End If

        'サーバーのIPアドレス（または、ホスト名）とポート番号
        Dim ipOrHost As String = InitPara.LedLinerHostName
        Dim port As Integer = InitPara.LedLinerPortNo

        Dim tcp As System.Net.Sockets.TcpClient


        'TcpClientを作成し、サーバーと接続する
        Try
            tcp = New System.Net.Sockets.TcpClient(ipOrHost, port)
        Catch ex As Exception
            RaiseEvent ErrorOccur($"LEDLinerからの応答がありません。IPアドレス {ipOrHost} port {port}")
            Exit Sub
        End Try
        Console.WriteLine("サーバー({0}:{1})と接続しました({2}:{3})。",
            DirectCast(tcp.Client.RemoteEndPoint, System.Net.IPEndPoint).Address,
            DirectCast(tcp.Client.RemoteEndPoint, System.Net.IPEndPoint).Port,
            DirectCast(tcp.Client.LocalEndPoint, System.Net.IPEndPoint).Address,
            DirectCast(tcp.Client.LocalEndPoint, System.Net.IPEndPoint).Port)

        'NetworkStreamを取得する
        Dim ns As System.Net.Sockets.NetworkStream = tcp.GetStream()

        '読み取り、書き込みのタイムアウトを10秒にする
        'デフォルトはInfiniteで、タイムアウトしない
        '(.NET Framework 2.0以上が必要)
        ns.ReadTimeout = 10000
        ns.WriteTimeout = 10000

        'サーバーにデータを送信する
        '文字列をByte型配列に変換
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
        Dim sendBytes As Byte() = enc.GetBytes("2:" & _sendMsg & ControlChars.CrLf)
        'データを送信する
        ns.Write(sendBytes, 0, sendBytes.Length)

        'サーバーから送られたデータを受信する
        Dim ms As New System.IO.MemoryStream()
        Dim resBytes As Byte() = New Byte(255) {}
        Dim resSize As Integer = 0
        Do
            'データの一部を受信する
            resSize = ns.Read(resBytes, 0, resBytes.Length)
            'Readが0を返した時はサーバーが切断したと判断
            If resSize = 0 Then
                RaiseEvent ErrorOccur("LEDLinerからの応答がありません！！")
                Exit Do
            End If
            '受信したデータを蓄積する
            ms.Write(resBytes, 0, resSize)
            'まだ読み取れるデータがあるか、データの最後が\nでない時は、
            ' 受信を続ける
        Loop While ns.DataAvailable OrElse
            resBytes(resSize - 1) <> AscW(ControlChars.Lf)
        '受信したデータを文字列に変換
        Dim resMsg As String = enc.GetString(ms.GetBuffer(), 0, CInt(ms.Length))
        If resMsg <> "OK" Then
            RaiseEvent ErrorOccur("受信データ　異常です！！")
        End If



        ms.Close()
        '末尾の\nを削除
        resMsg = resMsg.TrimEnd(ControlChars.Lf)

        '閉じる
        ns.Close()
        tcp.Close()
    End Sub


End Class
