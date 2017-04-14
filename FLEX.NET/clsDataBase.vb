Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Enum DataBaseType
    MySQL
    MsSQLServer
End Enum

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

    'Private cn As OdbcConnection


    Public Shared MySQLVersion As String

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


    Private Function conMsSqlSvDb() As SqlClient.SqlConnection


        Dim CoonectSql As String =
            "Server=127.0.0.1\SQLEXPRESS;Initial Catalog=flex鹿島外環test;User ID=sa;Password=yanagi;"

        Dim cn As SqlConnection = New SqlConnection(CoonectSql)
        cn.Open()

        Return cn


    End Function




    'データベースコネクション
    Private Function conMYSQLDB() As OdbcConnection

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

        Dim cn As OdbcConnection =
            New OdbcConnection(ConnectionString)

        Try
            cn.Open()

        Catch ex As OdbcException
            Dim ErrMsg As String = vbNullString
            If ex.Message.Contains("ドライバーが見つかりません") Then
                ErrMsg = "MySQL ODBC 5.3 Unicode Driver を　インストールしてください"
            End If
            If ex.Message.Contains("Unknown MySQL server host") Then
                ErrMsg = HostName & ":ホスト名が見つかりません！"
            End If
            If ex.Message.Contains("Unknown MySQL server host") Then
                ErrMsg = HostName & ":ホスト名が見つかりません！"
            End If
            MsgBox($"Connect Error:{ex.Message & vbCrLf & ErrMsg} FLEX.NET",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        Return cn
    End Function

    Public Sub ExecuteSqlCmd(SQLCommand As String)
        If My.Settings.DataBaseType.IndexOf("MYSQL", StringComparison.OrdinalIgnoreCase) = 0 Then
            Dim cmd As New OdbcCommand(SQLCommand, conMYSQLDB)
            Dim dr As OdbcDataReader = cmd.ExecuteReader

            If dr.RecordsAffected = 0 Then
                Debug.Print(SQLCommand)
            End If

            dr.Close()
            conMYSQLDB.Close()
            conMYSQLDB.Dispose()

        End If

        If My.Settings.DataBaseType.IndexOf("MSSQL", StringComparison.OrdinalIgnoreCase) = 0 Then
            Dim cmd As New SqlCommand(SQLCommand, conMsSqlSvDb)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            If dr.RecordsAffected = 0 Then
                Debug.Print(SQLCommand)
            End If
            dr.Close()
            conMsSqlSvDb.Close()
            conMsSqlSvDb.Dispose()
        End If

    End Sub

    Public Function DBType() As DataBaseType
        If My.Settings.DataBaseType.IndexOf("MYSQL", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return DataBaseType.MySQL
        End If
        If My.Settings.DataBaseType.IndexOf("MSSQL", StringComparison.OrdinalIgnoreCase) = 0 Then
            Return DataBaseType.MsSQLServer
        End If

    End Function


    ''' <summary>
    ''' SQLよりデータテーブルを取得
    ''' </summary>
    ''' <param name="SQLCommand"></param>
    ''' <returns>SQL文</returns>
    Public Function GetDtfmSQL(SQLCommand As String) As DataTable

        Dim ds As New DataSet
        Try
            If DBType() = DataBaseType.MySQL Then
                Dim Adpter = New OdbcDataAdapter(SQLCommand, conMYSQLDB)
                Adpter.Fill(ds)
                Adpter.Dispose()
                conMYSQLDB.Close()
                conMYSQLDB.Dispose()
            End If

            If DBType() = DataBaseType.MsSQLServer Then

                SqlStrToMsType(SQLCommand)


                Dim Adpter = New SqlDataAdapter(SQLCommand, conMsSqlSvDb)
                Adpter.Fill(ds)
                Adpter.Dispose()
                conMsSqlSvDb.Close()
                conMsSqlSvDb.Dispose()

            End If
            Return ds.Tables(0)

        Catch ex As System.Data.Odbc.OdbcException
            MsgBox($"データベース読込エラー
            {ex.Message}{vbCrLf}{SQLCommand}{vbCrLf}　FLEXを終了します  ", vbCritical)
            Application.Exit()
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' MYSQLの特殊文字をMicrosoSQLServer用に変更
    ''' </summary>
    ''' <param name="SqlString"></param>
    Private Sub SqlStrToMsType(ByRef SqlString As String)
        '文字列にLIMITの位置を取得
        Dim LimitLoc As Short = SqlString.IndexOf("LIMIT")
        Dim GetNum As Short = 0
        If LimitLoc > 0 Then
            'LIMITのあとの　コンマの後の数値を取得
            Dim Konma As Short = SqlString.IndexOf(",", LimitLoc)
            GetNum = SqlString.Substring(Konma + 1).ToNum
            SqlString = SqlString.Remove(LimitLoc)
        End If

        SqlString = SqlString.Replace(" `", " [")
        SqlString = SqlString.Replace("` ", "] ")
        SqlString = SqlString.Replace("`.`", "].[")



    End Sub



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
            Try
                Return _TagList(tagDic(FldName))
            Catch ex As System.Collections.Generic.KeyNotFoundException
                MsgBox($"{FldName}がTAGに見つかりません。設定をしてください{vbCrLf}{ex.Message}{vbCrLf}{ex.StackTrace}プログラムを終了します。", vbCritical)
                Application.Exit()
                Return Nothing
            End Try
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
        Dim TableAndWhere As String = $" {TableName} WHERE アドレス LIKE '{PLCAdressClass}%'"
        'Dim MaxID As OdbcDataReader = ExecuteSql($"SELECT COUNT(*) FROM {TableAndWhere}")
        'MaxID.Read()
        'ReDim _TagList(MaxID.Item(0) + 1)

        _startAddress =
            GetDtfmSQL($"SELECT Min(アドレス) FROM {TableAndWhere}").Rows(0).Item(0)
        'StartAd.Close()
        'ビットデータの時は、16の倍数からアドレスを介し
        If _startAddress.Substring(0, 1) = "M" Then
            _startAddress = _startAddress(0) & (CInt(_startAddress.Substring(1)) \ 16) * 16
        End If

        Dim anaTag As DataTable =
            GetDtfmSQL($"SELECT * FROM {TableAndWhere}")

        Dim ht As Hashtable = New Hashtable

        Dim StartAdress As Integer = CInt(_startAddress.Substring(1))

        tagDic = New Dictionary(Of String, Short)

        Dim i As Integer = 0 ' anaTag("ID")

        'While anaTag.Read()
        For Each t As DataRow In anaTag.Rows
            If t("項目名") <> "" Then
                Dim tag As New _tag
                tag.FieldName = t("項目名")
                tag.Address = t("アドレス")
                If TableName = "FLEXアナログtag" Then
                    tag.DigitLoc = CInt(t("小数点位置"))
                    tag.Unit = t("単位")
                    tag.EngLow = t("下限")
                    tag.EngHight = t("上限")
                    tag.ScaleLow = t("スケール下限")
                    tag.ScaleHigh = t("スケール上限")
                End If
                Dim ad As String = tag.Address 'アドレスからオフセットを算出
                If Not ad.Equals("") AndAlso IsNumeric(ad.Substring(1)) Then
                    tag.OffsetAddress = CInt(ad.Substring(1)) - StartAdress
                End If
                _TagList.Add(tag)
                tagDic.Add(tag.FieldName, i)
                ht(t("項目名")) = i

                'オフセットの最大値取得
                If _devicesize < tag.OffsetAddress Then _devicesize = tag.OffsetAddress
                i += 1
            End If
        Next

        'If anaTag("項目名") <> "" Then
        '        Dim tag As New _tag
        '        tag.FieldName = anaTag("項目名")
        '        tag.Address = anaTag("アドレス")
        '        If TableName = "FLEXアナログtag" Then
        '            tag.DigitLoc = CInt(anaTag("小数点位置"))
        '            tag.Unit = anaTag("単位")
        '            tag.EngLow = anaTag("下限")
        '            tag.EngHight = anaTag("上限")
        '            tag.ScaleLow = anaTag("スケール下限")
        '            tag.ScaleHigh = anaTag("スケール上限")
        '        End If
        '        Dim ad As String = tag.Address 'アドレスからオフセットを算出
        '        If Not ad.Equals("") AndAlso IsNumeric(ad.Substring(1)) Then
        '            tag.OffsetAddress = CInt(ad.Substring(1)) - StartAdress
        '        End If
        '        _TagList.Add(tag)
        '        tagDic.Add(tag.FieldName, i)
        '        ht(anaTag("項目名")) = i

        '        'オフセットの最大値取得
        '        If _devicesize < tag.OffsetAddress Then _devicesize = tag.OffsetAddress
        '        i += 1
        '    End If
        'End While
        'anaTag.Close()
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

    Private _mesureJackNo As New List(Of Short) '計測ジャッキ番号 上右下左の順番

    Private _topStrokeEnable As Boolean     '上ストローク計あり
    Private _bottomStrokeEnable As Boolean '下ストローク計あり


    Private _constructionName As String '工事名（環境設定テーブルより

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

    Public ReadOnly Property topStrokeEnable As Boolean
        Get
            Return _topStrokeEnable
        End Get
    End Property
    Public ReadOnly Property bottomStrokeEnable As Boolean
        Get
            Return _bottomStrokeEnable
        End Get
    End Property


    Public ReadOnly Property ConstructionName As String
        Get
            Return _constructionName
        End Get
    End Property

    Public Sub New()

        Dim paraDB As DataTable =
            GetDtfmSQL("SELECT * FROM FLEX初期パラメータ")

        Try
            Dim ht As New Dictionary(Of String, String)

            For Each dt As DataRow In paraDB.Rows
                ht(dt("項目名称")) = dt("値")
            Next

            _numberJack = ht("使用ジャッキ本数")
            _numberGroup = ht("グループ数")
            _jackPower = ht("ジャッキ能力")
            _jackRadius = ht("ジャッキ取付半径")
            _JackMaxOilPres = ht("ジャッキの最大油圧")
            _actLogicalStationNumber = ht("PLC論理局")
            _firstJackLoc = ht("No1ジャッキの位置")
            _sheetID = ht("SheetID")
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
                _JackGroupPos(i) = ht("所属するジャッキグループの番号" & (i + 1))
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
            'Dim test As Single = 0
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
            For Each JkNo In ht("計測ジャッキ上右下左").ToString.Split(",")
                _mesureJackNo.Add( JkNo)
            Next
            _topStrokeEnable = (_mesureJackNo(0) <> 0)
            _bottomStrokeEnable = (_mesureJackNo(2) <> 0)


        Catch ex As Exception

        End Try

        '工事名の取得
        'Dim ConName As DataTable = GetDtfmSQL($"SELECT 工事名 FROM 環境設定 WHERE シートID='{_sheetID}'")
        Dim ConName As DataTable = GetDtfmSQL($"SELECT 工事名 FROM 環境設定 WHERE シートID='10'")
        If ConName.Rows.Count <> 0 Then
            _constructionName = ConName.Rows(0).Item(0)
        End If



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
''' リング報に関するDB
''' </summary>
Public Class clsRingReport
    Inherits clsDataBase
    ''' <summary>
    ''' テーブル「flexリング報項目}のチェック
    ''' </summary>
    Public Sub CheckRingItem()
        'テーブル　flex掘削データより　フィールドの存在チェック
        Dim FldLstRd As DataTable =
            GetDtfmSQL("SHOW COLUMNS FROM flex掘削データ")

        Dim FldLst As List(Of String) = (From g As DataRow In FldLstRd.Rows Select (Function(j) j.ToString))

        'While FldLstRd.Read
        '    FldLst.Add(FldLstRd.Item("Field"))
        'End While
        'FldLstRd.Close()

        Dim i As Integer = 0

        For Each fName In FldLst
            '除外Field名
            Dim ExceptFld() As String = {"リング番号", "掘進ストローク", "時間"}

            If Not ExceptFld.Contains(fName) Then
                Dim ExitFld As DataTable =
                GetDtfmSQL($"SELECT * FROM flexリング報項目 WHERE 項目名='{fName}'")

                If ExitFld.Rows.Count = 0 Then
                    ExecuteSqlCmd($"INSERT INTO flexリング報項目(ID,項目名) VALUES({i},'{fName}')")
                End If

                'アナログTAGより小数点、単位を更新
                Dim AnaTag As DataTable =
                        GetDtfmSQL($"SELECT * FROM flexアナログtag WHERE 項目名='{fName}'")
                If AnaTag.Rows.Count <> 0 Then
                    'Dim UpFld As OdbcDataReader =
                    ExecuteSqlCmd($"UPDATE flexリング報項目 SET 小数点位置='{AnaTag.Rows(0).Item("小数点位置")}'
                        ,単位='{AnaTag.Rows(0).Item("単位")}' WHERE  項目名='{fName}'")
                End If
                i += 1
            End If
        Next
        'TODO:ERROR 1040 (HY000): Too many connectionsが発生するので
        'mysql> set global max_connections=500;を設定する必要がある！初期で自動で設定できないか！

    End Sub







End Class





''' <summary>
''' テーブルの更新イベント
''' </summary>
Public Class clsTableUpdateConfirm
    Inherits clsDataBase

    Dim tbTime As Dictionary(Of String, Date)
    Private MisamTable() As String =
        {"flexアナログtag", "flexデジタルtag", "flex初期パラメータ",
        "flex制御パラメータ", "flexセグメント組立データ", "セグメント割付シュミレーション",
    "セグメント組立パターンリスト", "セグメント分割仕様リスト", "セグメントリスト"}

    Public Sub New()
        If DBType() = DataBaseType.MySQL And clsDataBase.MySQLVersion = "4.0.25" Then
            'MyISAMのチェック


            CheckMisam()
        End If
        '更新時刻の取得
        tbTime = GetUpdateTIme()

        TimerRun()

    End Sub

    Public Sub TimerRun()


        Dim timer As Timer = New Timer()
        AddHandler timer.Tick, New EventHandler(AddressOf TableUpdateTimeGet)
        timer.Interval = 5000   '5秒ごとの処理
        timer.Enabled = False ' timer.Start()と同じ

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
                        CtlPara.ReadParameter()
                        My.Forms.frmMain.WideDataFldSet() '汎用データの更新

                End Select

                If t.Key.Contains("セグメント") Then
                    SegAsmblyData.SegmentRingDataRead()
                    '組立パターンの情報を取得
                    SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)

                    My.Forms.frmMain.SegmentDataDsp() 'セグメント組立情報表示

                End If



            End If
        Next
        '現在の更新時刻を保持
        tbTime = New Dictionary(Of String, Date)(NewUpTime)

    End Sub


    Private Function GetUpdateTIme() As Dictionary(Of String, Date)
        '更新時間を取得　MISAMのみ

        If DBType() = DataBaseType.MySQL And clsDataBase.MySQLVersion = "4.0.25" Then
            Dim tableUpTime As DataTable =
            GetDtfmSQL("show table status;")

            Dim k =
            From i In tableUpTime.AsEnumerable Where i("TYPE") = "MyISAM"

            Return k.ToDictionary(Function(n) n("name").ToString, Function(n) CDate(n("Update_time")))

        End If


    End Function
    ''' <summary>
    ''' テーブルがMyISAMかどうか、チェック！
    ''' </summary>
    Private Sub CheckMisam()
        Dim misamTb As DataTable =
            GetDtfmSQL("show table status;")
        'misamTb = ExecuteSql("flush tables;show table status;")
        'misamTb = ExecuteSql("show table status;")

        For Each t As DataRow In misamTb.Rows

            For Each tb In MisamTable
                If tb = t.Item("Name") Then
                    If t.Item("TYPE") <> "MyISAM" Then
                        'Dim ChangeEngine As OdbcDataReader =
                        ExecuteSqlCmd($"ALTER TABLE {tb} ENGINE=MyISAM;")
                    End If
                End If
            Next
        Next
    End Sub

End Class
''' <summary>
''' dictionaryのキー存在チェックし、値を返すクラス
''' 
''' </summary>
Public Class clsCheckDictionary
    Private _dic As Dictionary(Of String, String)
    Private _tableName As String
    Sub New(_dic As Dictionary(Of String, String), _talbeName As String)
        Me._dic = _dic
        Me._tableName = _tableName
    End Sub

    Public Function GetValue(tKey As String) As String
        If _dic.ContainsKey(tKey) Then
            Return _dic(tKey)
        Else
            MsgBox($"テーブル'{_tableName}'に,'{tKey}'が見つかりません！", vbCritical)
            Return Nothing
        End If
    End Function





End Class

