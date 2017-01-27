Imports System.Data.Odbc

Public Class clsDataBase

    ''' <summary>
    ''' ホスト名
    ''' </summary>
    Private Shared HostName As String = My.Settings.HostName
    ''' <summary>
    ''' データベース名
    ''' </summary>
    Private Shared DataBaseName As String = My.Settings.DataBaseName

    ''' <summary>
    ''' ポート番号
    ''' </summary>
    Private Shared PortNo As Integer = My.Settings.Port



    Private Shared MySQLVersion As String

    Public Sub New()


    End Sub
    ''' <summary>
    ''' MYSQLのバージョン取得
    ''' </summary>
    Public Shared Sub GetMySQKVersion()

        ' ソケット生成
        Dim objSck As New System.Net.Sockets.TcpClient
        Dim objStm As System.Net.Sockets.NetworkStream

        Try
            ' TCP/IP接続
            objSck.Connect(HostName, PortNo)
        Catch ex As System.Net.Sockets.SocketException '
            '接続出来ない場合
            MsgBox(ex.Message,
                   MsgBoxStyle.Exclamation,
                   "データベース接続エラー" & "ホスト名:" & HostName & vbCrLf & "  ポート番号:" & PortNo)
            End
        End Try

        objStm = objSck.GetStream()

            ' TCP/IP接続待ち 
            Do While objSck.Connected = False
            System.Threading.Thread.Sleep(500)
        Loop


        ' データ受信
        Do
            System.Threading.Thread.Sleep(500)
            If objSck.Available > 0 Then
                ' Byte配列にデータ受信
                Dim rdat As Byte() =
            New Byte(objSck.Available - 1) {}
                objStm.Read(rdat, 0, rdat.GetLength(0))
                ' Byte配列を文字列に変換して表示
                Dim rString As String = System.Text.Encoding.GetEncoding("SHIFT-JIS").GetString(rdat)

                If rString.Contains("4.0.25") Then
                    MySQLVersion = "4.0.25"
                End If
                If rString.Contains("MariaDB") Then
                    MySQLVersion = "MariaDB"
                End If
                If IsNothing(MySQLVersion) Then
                    MsgBox($"データベースが異常です　{rString}",,)

                End If

                Exit Do
            End If
        Loop




        ' TCP/IP切断
        objSck.Close()


    End Sub



    'データベースコネクション
    Private Function conDB() As OdbcConnection

        Dim DriverVersion As String = ""
        Select Case MySQLVersion
            Case "4.0.25"
                DriverVersion = "{MySQL ODBC 3.51 Driver}"
            Case "MariaDB"
                DriverVersion = "{MySQL ODBC 5.3 Unicode Driver}"
        End Select


        Dim ConnectionString As String =
            $"DRIVER={DriverVersion};server={HostName}; 
            database={DataBaseName}; port={PortNo}; 
            uid= toyo;pwd= yanagi;OPTION=3"

        Dim cn As New OdbcConnection(ConnectionString)
        Try
            cn.Open()

        Catch ex As OdbcException
            Dim ErrMsg As String = vbNullString
            If ex.Message.Contains("ドライバーが見つかりません") Then
                ErrMsg = "MySQL ODBC 5.3 Unicode Driver を　インストールしてください"
            End If
            If ex.Message.Contains("Unknown MySQL server host") Then
                ErrMsg = My.Settings.HostName & ":ホスト名が見つかりません！"
            End If
            If ex.Message.Contains("Unknown MySQL server host") Then
                ErrMsg = My.Settings.HostName & ":ホスト名が見つかりません！"
            End If
            MessageBox.Show("Connect Error:" & ex.Message & vbCrLf & ErrMsg, "FLEX.NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        Return cn
    End Function

    Public Function ExecuteSql(SQLCommand As String) As OdbcDataReader
        Dim cmd As New OdbcCommand(SQLCommand, conDB)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Return dr
    End Function


    Public Function CheckItemData(tmp As Object) As String
        If IsNumeric(tmp) Then
            Return tmp.ToString
        Else
            Return 0
        End If

    End Function



End Class

Public Structure _tag
    Public Address As String         'アドレス
    Public OffsetAddress As Integer  '開始アドレスからのオフセット
    Public FieldName As String      '項目名
    Public Unit As String           '単位
    Public DigitLoc As Integer      '小数点位置
    Public EngLow As Single         '工業値下限
    Public EngHight As Single       '工業値上限
    Public ScaleLow As Single       'スケール下限
    Public ScaleHigh As Single      'スケール上限
    Public EngValue As Double       '工業値
End Structure


Public Class clsTag
    Inherits clsDataBase

    Private _TagList As New List(Of _tag)
    Private tagDic As Dictionary(Of String, Short)
    Private _startAddress As String  '読み込み開始アドレス
    Private _devicesize As Integer = 0   'アドレス読込個数

    Private WithEvents Htb As New clsHashtableRead

    Public Property Tag As List(Of _tag)
        Get
            Return _TagList
        End Get
        Set(value As List(Of _tag))
            _TagList = value
        End Set
    End Property

    Public ReadOnly Property TagData(FldName As String) As _tag
        Get
            Return _TagList(tagDic(FldName))
        End Get
    End Property
    ''' <summary>
    ''' TAGがそんざいするかどうか？
    ''' </summary>
    ''' <param name="TagName"></param>
    ''' <returns></returns>
    Public ReadOnly Property TagExist(TagName As String) As Boolean
        Get
            Return tagDic.ContainsKey(TagName)
        End Get
    End Property


    Public ReadOnly Property TagEngValue(ByVal FldName As String) As Double
        Get
            Return _TagList(tagDic(FldName)).EngValue
        End Get
    End Property

    Public ReadOnly Property DeviceSize As Integer
        Get
            Return _devicesize
        End Get
    End Property

    Public ReadOnly Property StartAddress As String
        Get
            Return _startAddress
        End Get
    End Property
    ''' <summary>
    ''' テーブルよりタグ情報を取得
    ''' </summary>
    ''' <param name="TableName">取得するテーブル名</param>
    ''' <param name="PLCAdressClass">PLCアドレスの先頭文字 M or D or R</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal TableName As String, ByVal PLCAdressClass As String)
        Dim TableAndWhere As String = $" {TableName} WHERE `アドレス` LIKE '{PLCAdressClass}%'"
        Dim MaxID As OdbcDataReader = ExecuteSql($"SELECT COUNT(*) FROM {TableAndWhere}")
        MaxID.Read()
        'ReDim _TagList(MaxID.Item(0) + 1)

        Dim StartAd As OdbcDataReader = ExecuteSql($"SELECT Min(`アドレス`) FROM {TableAndWhere}")
        StartAd.Read()
        _startAddress = StartAd.Item(0)
        'ビットデータの時は、16の倍数からアドレスを介し
        If _startAddress.Substring(0, 1) = "M" Then
            _startAddress = _startAddress(0) & (CInt(_startAddress.Substring(1)) \ 16) * 16
        End If

        Dim anaTag As OdbcDataReader
        anaTag = ExecuteSql($"SELECT * FROM {TableAndWhere}")

        Dim ht As Hashtable = New Hashtable

        Dim StartAdress As Integer = CInt(_startAddress.Substring(1))

        tagDic = New Dictionary(Of String, Short)

        Dim i As Integer = 0 ' anaTag("ID")
        While anaTag.Read()
            If anaTag("項目名") <> "" Then
                Dim t As _tag
                t.FieldName = anaTag("項目名").ToString
                t.Address = anaTag("アドレス").ToString
                If TableName = "FLEXアナログtag" Then
                    t.DigitLoc = CInt(anaTag("小数点位置"))
                    t.Unit = anaTag("単位").ToString
                    t.EngLow = CSng(anaTag("下限"))
                    t.EngHight = CSng(anaTag("上限"))
                    t.ScaleLow = CSng(anaTag("スケール下限"))
                    t.ScaleHigh = CSng(anaTag("スケール上限"))
                End If
                Dim ad As String = t.Address 'アドレスからオフセットを算出
                If Not ad.Equals("") AndAlso IsNumeric(ad.Substring(1)) Then
                    t.OffsetAddress = CInt(ad.Substring(1)) - StartAdress
                End If
                _TagList.Add(t)
                tagDic.Add(t.FieldName, i)
                ht(anaTag("項目名")) = i

                'オフセットの最大値取得
                If _devicesize < t.OffsetAddress Then _devicesize = t.OffsetAddress
                i += 1
            End If
        End While

        Htb.htb = ht    'ハッシュテーブルの設定


    End Sub


    Private Sub Htb_NotFindFld(sender As Object, ByVale As EventArgs, strFld As String) Handles Htb.NotFindFld
        MsgBox("で、項目[" & strFld & "]が、見つかりませんでした。")

    End Sub
End Class




Public Class clsInitParameter
    Inherits clsDataBase

    Private _numberJack As Short            '使用ジャッキ本数
    Private _numberGroup As Short          '分割数
    Private _faiJack() As Single             'ジャッキ取付位置(演算)
    Private _JackGroupPos() As Short              '所属グループ番号
    Private _faiGroup() As Single           '各グループの中心角度
    Private _numberJackOfGroup As Short()   '各グループのジャッキ本数
    Private _jackPower As Single             'ジャッキ能力
    Private _jackRadius As Single           'ジャッキ取付半径
    Private _JackMaxOilPres As Single        'ジャッキの最大油圧
    Private _actLogicalStationNumber As Short 'PLC論理局
    Private _firstJackLoc As String            'No1ジャッキの位置 top or left
    Private _sheetID As Integer = 20                 ''計画路線のシートID（10:計画路線　20:掘進計画線)
    'Private _planDataMdb As String '計画路線（線形データ）のファイルパス

    Private _mesureJackAngle As New SortedDictionary(Of Short, Single) '計測ジャッキの角度

    Private _mesureJackNo As New List(Of Short) '計測ジャッキ番号

    Private WithEvents Htb As New clsHashtableRead
    ''' <summary>
    ''' ジャッキ本数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public ReadOnly Property NumberJack As Short
        Get
            Return _numberJack
        End Get
    End Property
    ''' <summary>
    ''' グループ数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NumberGroup As Short
        Get
            Return _numberGroup
        End Get
    End Property
    ''' <summary>
    ''' 計画路線のシートID（10:計画路線　20:掘進計画線)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SheetID As Integer
        Get
            Return _sheetID
        End Get
    End Property


    ''' <summary>
    ''' ジャッキ取付位置
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FaiJack() As Single()
        Get
            Return _faiJack
        End Get
    End Property
    ''' <summary>
    ''' ジャッキの所属グループ番号
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property JackGroupPos() As Short()
        Get
            Return _JackGroupPos
        End Get
    End Property

    ''' <summary>
    ''' 各グループの中心角度
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property FaiGroup() As Single()
        Get
            Return _faiGroup
        End Get
    End Property

    Public ReadOnly Property JackPower As Single
        Get
            Return _jackPower
        End Get
    End Property
    Public ReadOnly Property JackMaxOilPres As Single
        Get
            Return _JackMaxOilPres
        End Get
    End Property
    Public ReadOnly Property JackRadius As Single
        Get
            Return _jackRadius
        End Get
    End Property
    Public ReadOnly Property ActLogicalStationNumber
        Get
            Return _actLogicalStationNumber
        End Get
    End Property
    Public ReadOnly Property FirstJackLoc As String
        Get
            Return _firstJackLoc
        End Get
    End Property
    ''' <summary>
    ''' 計測ジャッキ　角度
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MesureJackAngle As SortedDictionary(Of Short, Single)
        Get
            Return _mesureJackAngle
        End Get
    End Property
    ''' <summary>
    ''' 計測ジャッキ番号
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property mesureJackNo As List(Of Short)
        Get
            Return _mesureJackNo
        End Get
    End Property


    Public Sub New()
        Dim paraDB As OdbcDataReader
        paraDB = ExecuteSql("SELECT * FROM FLEX初期パラメータ")

        Dim ht As Hashtable = New Hashtable

        Try
            While paraDB.Read()
                ht(paraDB("項目名称")) = paraDB("値")
            End While

            Htb.htb = ht
            _numberJack = Htb.GetValue("使用ジャッキ本数")
            _numberGroup = Htb.GetValue("グループ数")
            _jackPower = Htb.GetValue("ジャッキ能力")
            _jackRadius = Htb.GetValue("ジャッキ取付半径")
            _JackMaxOilPres = Htb.GetValue("ジャッキの最大油圧")
            _actLogicalStationNumber = Htb.GetValue("PLC論理局")
            _firstJackLoc = Htb.GetValue("No1ジャッキの位置")
            _sheetID = Htb.GetValue("SheetID")
            '_planDataMdb = Htb.GetValue("PlanDataMdb")
            ''絶対パスに変換
            'If Not (System.IO.Path.IsPathRooted(_planDataMdb)) Then
            '    _planDataMdb = System.Windows.Forms.Application.StartupPath & "\" & _planDataMdb
            'End If
            ReDim _faiJack(_numberJack - 1)
            ReDim _JackGroupPos(_numberJack - 1)

            ReDim _numberJackOfGroup(_numberGroup - 1)

            Dim i As Integer
            For i = 0 To _numberJack - 1
                '_faiJack(i) = Htb.GetValue("ジャッキ取付位置" & (i + 1))
                _JackGroupPos(i) = Htb.GetValue("所属するジャッキグループの番号" & (i + 1))
                _numberJackOfGroup(_JackGroupPos(i) - 1) += 1
            Next
            'ジャッキ取付角度の演算(degree)
            Call CalucFaiJack()


            'グループの中心角度の計算
            ReDim _faiGroup(_numberGroup - 1)

            For i = 0 To _numberJack - 1
                _faiGroup(_JackGroupPos(i) - 1) += _faiJack(i)
                Dim j As Integer
                If j = _numberJack - 1 Then
                    j = 0
                Else
                    j = i + 1
                End If
                '次のグループが同じグループで角度が大きい時
                If _faiJack(i) < _faiJack(j) And _JackGroupPos(i) = _JackGroupPos(j) Then
                    _faiGroup(_JackGroupPos(i) - 1) += 360
                End If

            Next
            Dim test As Single = 0
            For i = 0 To _numberGroup - 1
                _faiGroup(i) = _faiGroup(i) / _numberJackOfGroup(i)
            Next
            '計測ジャッキの番号と角度を取得
            'Dim _mJ As New Dictionary(Of Short, Single) '計測ジャッキの角度

            For Each mj As String In ht.Keys
                If mj.Contains("計測ジャッキNo") Then
                    _mesureJackAngle.Add(mj.Replace("計測ジャッキNo", ""), ht(mj))
                End If
            Next



            '計測ジャッキ番号
            For Each JkNo In Htb.GetValue("計測ジャッキ上右下左").ToString.Split(",")
                _mesureJackNo.Add(JkNo)
            Next



        Catch ex As Exception

        End Try


    End Sub
    Function KeySelector(ByVal pair As KeyValuePair(Of String, Integer)) As String
        ' 並べ替えの際のキーにKeyの値を使用する
        Return pair.Key
    End Function
    ''' <summary>
    ''' ジャッキ取付角度の演算(degree)
    ''' </summary>
    Private Sub CalucFaiJack()

        Dim sngStartLoc As Single
        sngStartLoc = IIf(_firstJackLoc.ToLower = "top", 90, 90 - 360 / _numberJack / 2)

        ReDim _faiJack(_numberJack)

        Dim i As Integer

        For i = 0 To _numberJack - 1

            _faiJack(i) = sngStartLoc - 360 / _numberJack * i

            If _faiJack(i) < 0 Then _faiJack(i) = 360 + _faiJack(i)




        Next i


    End Sub



    Private Sub Htb_NotFindFld(sender As Object, ByVale As EventArgs, strFld As String) Handles Htb.NotFindFld
        MsgBox("初期値パラメータで、項目[" & strFld & "]が、見つかりませんでした。")
    End Sub
End Class
Public Class clsHashtableRead

    Public Event NotFindFld(ByVal sender As Object, ByVale As EventArgs, ByVal strFld As String) '


    Private ht As Hashtable
    Public WriteOnly Property htb As Hashtable
        Set(value As Hashtable)
            ht = value
        End Set

    End Property

    Public Function GetValue(strFld As String) As Object
        Dim obj As Object = ht(strFld)
        If IsNothing(obj) Then
            RaiseEvent NotFindFld(Me, New EventArgs, strFld)
            Return Nothing
        Else
            Return obj
        End If
    End Function



End Class
''' <summary>
''' テーブルの更新イベント
''' </summary>
Public Class clsTableUpdateConfirm
    Inherits clsDataBase

    Dim tbTime As Dictionary(Of String, Date)
    Private MisamTable() As String =
        {"flexアナログtag", "flexデジタルtag", "flex初期パラメータ", "flex制御パラメータ", "flexセグメント組立データ"}

    Public Sub New()
        'MyISAMのチェック
        CheckMisam()
        '更新時刻の取得
        tbTime = GetUpdateTIme()

        TimerRun()

    End Sub

    Public Sub TimerRun()


        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf TableUpdateTimeGet)
        timer.Interval = 5000   '5秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ

    End Sub

    Private Sub TableUpdateTimeGet()
        '更新時刻を取得
        Dim NewUpTime As Dictionary(Of String, Date) = GetUpdateTIme()

        For Each t In NewUpTime
            If t.Value <> tbTime(t.Key) Then '更新時刻が変化
                Select Case t.Key
                    Case "flexアナログtag", "flexデジタルtag"
                        PlcIf.TagRead()
                    Case "flex初期パラメータ"
                        InitPara = New clsInitParameter
                    Case "flex制御パラメータ"
                        CtlParameter.ReadParameter()
                        My.Forms.frmMain.WideDataFldSet() '汎用データの更新
                    Case "flexセグメント組立データ"
                        SegAsmblyData.SegmentRingDataRead()
                End Select
            End If
        Next
        '現在の更新時刻を保持
        tbTime = New Dictionary(Of String, Date)(NewUpTime)

    End Sub


    Private Function GetUpdateTIme() As Dictionary(Of String, Date)
        '更新時間を取得　MISAMのみ
        Dim tableUpTime As OdbcDataReader
        Dim gup As New Dictionary(Of String, Date)
        tableUpTime = ExecuteSql("flush tables")
        tableUpTime = ExecuteSql("show table status;")

        While tableUpTime.Read
            If tableUpTime.Item("TYPE") = "MyISAM" Then
                gup.Add(tableUpTime.Item("Name").ToString, CDate(tableUpTime.Item("Update_time")))
            End If

        End While

        Return gup

    End Function
    ''' <summary>
    ''' テーブルがMyISAMかどうか、チェック！
    ''' </summary>
    Private Sub CheckMisam()
        Dim misamTb As OdbcDataReader
        misamTb = ExecuteSql("flush tables")
        misamTb = ExecuteSql("show table status;")

        While misamTb.Read
            For Each tb In MisamTable
                If tb = misamTb.Item("Name") Then
                    If misamTb.Item("TYPE") <> "MyISAM" Then
                        MsgBox($"テーブル {tb} を　エンジンMyISAMにしてください。", vbCritical)
                    End If
                End If
            Next
        End While
    End Sub

End Class
