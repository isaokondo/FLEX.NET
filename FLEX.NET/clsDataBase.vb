Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient




Public Class clsDataBase

    ''' <summary>
    ''' ホスト名
    ''' </summary>
    Private Shared HostName As String
    ''' <summary>
    ''' データベース名
    ''' </summary>
    Private Shared DataBaseName As String

    ''' <summary>
    ''' ポート番号
    ''' </summary>
    Private Shared PortNo As Integer

    'Private cn As OdbcConnection


    Public Shared MySQLVersion As String

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileString(
    ByVal lpAppName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer,
    ByVal lpFileName As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function WritePrivateProfileString(
    ByVal lpApplicationName As String,
    ByVal lpKeyName As String,
    ByVal lpString As String,
    ByVal lpFileName As String) As Long
    End Function

    'iniファイルから取得する
    Public Function GetIniString(ByVal lpSection As String, ByVal lpKeyName As String, ByVal lpFileName As String) As String
        Dim strValue As System.Text.StringBuilder = New System.Text.StringBuilder(1024)

        Dim sLen = GetPrivateProfileString(lpSection, lpKeyName, "", strValue, 1024, lpFileName)
        Dim str As String = strValue.ToString()

        Return str
    End Function



    Public Sub New()
        'FLEX.INI より　HOST名、DB名　PORT番号を読込
        Dim IniFilePath As String =
           AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FLEX.INI"

        If IO.File.Exists(IniFilePath) Then
            HostName = GetIniString("DataBase", "HostName", IniFilePath)
            DataBaseName = GetIniString("DataBase", "DataBaseName", IniFilePath)
            'HostName名に「:」がありその後の文字が整数であればそれをポート番号とする
            Dim dlmt As Integer = HostName.IndexOf(":")
            If dlmt > 0 AndAlso IsNumeric(HostName.Substring(dlmt + 1)) Then
                PortNo = HostName.Substring(dlmt + 1)
                HostName = HostName.Substring(0, dlmt)
            Else

                PortNo = GetIniString("DataBase", "port", IniFilePath)

            End If






        Else
            MsgBox($"FLEX.INIファイルが見つかりません。{vbCrLf}ファイルパス：{IniFilePath}",
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "初期ファイル読込不良")
            End
        End If


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
                   "データベース接続エラー" & "ホスト名:    " & HostName & vbCrLf & "  ポート番号:" & PortNo)
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
    Private Function conMYSQLDB() As OdbcConnection

        Dim DriverVersion As String = ""
        DriverVersion = "{MySQL ODBC 3.51 Driver}"

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
                ErrMsg = $"{DriverVersion} を　インストールしてください   {ConnectionString}"
            End If
            If ex.Message.Contains("Unknown MySQL server host") Then
                ErrMsg = HostName & ":ホスト名が見つかりません！  {ConnectionString}"
            End If

            MsgBox($"Connect Error:{ex.Message & vbCrLf & ErrMsg} FLEX.NET",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        Return cn
    End Function

    Public Sub ExecuteSqlCmd(SQLCommand As String)



        If MySQLVersion = "4.0.25" Then
                Dim cmd As New OdbcCommand(SQLCommand, conMYSQLDB)
                Dim dr As OdbcDataReader = cmd.ExecuteReader

                If dr.RecordsAffected = 0 Then
                'Debug.Print(SQLCommand)
            End If

                dr.Close()
                conMYSQLDB.Close()
                conMYSQLDB.Dispose()
            End If

        If MySQLVersion = "MariaDB" Then

            Dim Builder = New MySqlConnectionStringBuilder()
            ' データベースに接続するために必要な情報をBuilderに与える
            Builder.Server = HostName
            Builder.Port = PortNo
            Builder.UserID = "toyo"
            Builder.Password = "yanagi"
            Builder.Database = DataBaseName
            Dim ConStr = Builder.ToString()

            Dim con As New MySqlConnection
            con.ConnectionString = ConStr
            con.Open()

            Dim cmd As New MySqlCommand(SQLCommand, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader

            'If dr.RecordsAffected = 0 Then
            'End If

            dr.Close()
            con.Close()
            con.Dispose()

        End If








    End Sub




    ''' <summary>
    ''' SQLよりデータテーブルを取得
    ''' </summary>
    ''' <param name="SQLCommand"></param>
    ''' <returns>SQL文</returns>
    Public Function GetDtfmSQL(SQLCommand As String) As DataTable

        Dim ds As New DataSet
        Try

            If MySQLVersion = "4.0.25" Then
                    Dim Adpter = New OdbcDataAdapter(SQLCommand, conMYSQLDB)
                    Adpter.Fill(ds)
                    Adpter.Dispose()
                    conMYSQLDB.Close()
                    conMYSQLDB.Dispose()

                End If

            If MySQLVersion = "MariaDB" Then

                Dim Builder = New MySqlConnectionStringBuilder()
                ' データベースに接続するために必要な情報をBuilderに与える
                Builder.Server = HostName
                Builder.Port = PortNo
                Builder.UserID = "toyo"
                Builder.Password = "yanagi"
                Builder.Database = DataBaseName
                Builder.ConnectionTimeout = 600
                Builder.DefaultCommandTimeout = 300
                Dim ConStr = Builder.ToString()
                Dim con As New MySqlConnection
                con.ConnectionString = ConStr

                con.Open()

                Dim adpter As New MySqlDataAdapter(SQLCommand, con)

                adpter.Fill(ds)
                adpter.Dispose()


                con.Close()
                con.Dispose()
            End If



            Return ds.Tables(0)

        Catch ex As System.Data.Odbc.OdbcException
            MsgBox($"データベース読込エラー
            {ex.Message}{vbCrLf}{SQLCommand}{vbCrLf}　FLEXを終了します  ", vbCritical)
            Application.Exit()
            Return Nothing
        End Try
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
    Private _LosZeroEquip As Boolean = True    '同時施工あり（環境設定テーブルより

    Private _ClientMode As Boolean = False  'クライアントモード　データ保存なし、グループ操作出力なしのモード
    Private _MonitorMode As Boolean = False  'モニタモード　データ保存なし、PLC書き込みなし　　グループ操作出力なしのモード

    Private _OpposeJackEnable As Boolean = False '対抗ジャッキの機能が使用可（鹿島、飛島以外のJVでは仕様不可)

    Private _DistanceInputMethod As Boolean = False 'False:発進からの入力　True:起点からの入力


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
    ''' <summary>
    ''' ロスゼロ装備
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LosZeroEquip As Boolean
        Get
            Return _LosZeroEquip
        End Get
    End Property

    ''' <summary>
    ''' 対抗ジャッキの機能使用可（特許の関係で鹿島、飛島以外のJVでは使用不可)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property OpposeJackEnable As Boolean
        Get
            Return _OpposeJackEnable
        End Get
    End Property

    ''' <summary>
    ''' クライアントモード
    ''' </summary>
    ''' <returns></returns>
    Public Property ClientMode As Boolean
        Get
            Return _ClientMode
        End Get
        Set(value As Boolean)
            _ClientMode = value
        End Set
    End Property
    ''' <summary>
    ''' モニタモード
    ''' </summary>
    ''' <returns></returns>
    Public Property MonitorMode As Boolean
        Get
            Return _MonitorMode
        End Get
        Set(value As Boolean)
            _MonitorMode = value
        End Set
    End Property
    ''' <summary>
    ''' 測量距離入力方法
    ''' </summary>
    ''' <returns>Flase:発進から
    ''' True:起点から
    ''' </returns>
    Public Property DistanceInputMethod As Boolean
        Get
            Return _DistanceInputMethod
        End Get
        Set(value As Boolean)
            _DistanceInputMethod = value
        End Set
    End Property


    ''' <summary>
    ''' サーバーモード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ServerMode As Boolean
        Get
            Return Not (_MonitorMode Or _ClientMode)
        End Get
    End Property

    Public ReadOnly Property ModeName As String
        Get
            If _MonitorMode Then
                Return "MonitorMode"
            ElseIf _ClientMode Then
                Return "ClientMode"
            Else
                Return "ServerMode"
            End If


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

            For Each mj As String In ht.Keys
                If mj.Contains("計測ジャッキNo") Then
                    _mesureJackAngle.Add(mj.Replace("計測ジャッキNo", ""), ht(mj))
                End If
            Next

            '計測ジャッキ番号
            For Each JkNo In ht("計測ジャッキ上右下左").ToString.Split(",")
                _mesureJackNo.Add(JkNo)
            Next
            '上下のストローク計の有無
            _topStrokeEnable = (_mesureJackNo(0) <> 0)
            _bottomStrokeEnable = (_mesureJackNo(2) <> 0)


            If ht.ContainsKey("測量距離入力") Then
                _DistanceInputMethod = (ht("測量距離入力").IndexOf("起点") >= 0)
            End If



        Catch ex As Exception

        End Try

        '工事名の取得,同時施工あり／なし
        Dim ConNameLosZero As DataTable =
            GetDtfmSQL($"SELECT 工事名,施工方法 FROM 環境設定 WHERE シートID='10'")
        If ConNameLosZero.Rows.Count <> 0 Then
            _constructionName = ConNameLosZero.Rows(0).Item(0)
            _LosZeroEquip = (ConNameLosZero.Rows(0).Item(1) = 1)
            _OpposeJackEnable =
                _LosZeroEquip And (_constructionName.IndexOf("鹿島") >= 0 Or _constructionName.IndexOf("飛島") >= 0)


        End If

        'モニタモード、クライアントモードの設定読み込み
        'FLEX.INIより読込
        Dim IniFilePath As String =
           AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FLEX.INI"

        _ClientMode = (GetIniString("MODE", "ClientMode", IniFilePath) = "True")
        _MonitorMode = (GetIniString("MODE", "MonitorMode", IniFilePath) = "True")

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
        sngStartLoc = If(_firstJackLoc.ToLower = "top", 90, 90 - 360 / _numberJack / 2)

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

Public Class clsLosZeroPerform
    Inherits clsDataBase

    Private _AveAsmPiece As Single '平均組立ピース数
    Private _SumAsmPiece As Integer '累計組立ピース数

    Private _AveLoszeroTime As Single '同時施工平均時間
    Private _SumLoszeroTime As Integer '同時施工累積時間



    Public ReadOnly Property AveAsmPiece As Single
        Get
            Return _AveAsmPiece
        End Get
    End Property
    Public ReadOnly Property SumAsmPiece As Integer
        Get
            Return _SumAsmPiece
        End Get
    End Property


    Public ReadOnly Property AveLoszeroTime As Integer
        Get
            Return _AveLoszeroTime
        End Get
    End Property

    Public ReadOnly Property SumLoszeroTime As Integer
        Get
            Return _SumLoszeroTime
        End Get
    End Property




    ''' <summary>
    ''' 組立ピース数の算出
    ''' </summary>
    Public Async Sub Caluc()

        If InitPara.LosZeroEquip Then
            Dim PieceLst As New List(Of Integer)
            Dim RingLoszeroTime As New List(Of Integer)

            Dim anaTag As New DataTable

            Dim task As Task = Task.Run(
        Sub()

            anaTag =
            GetDtfmSQL("select max(`組立ピース`),max(`同時掘進時間`) from `flex掘削データ`
            where `同時施工ステータス_Machine`='5'  group by `リング番号`")

            For Each t As DataRow In anaTag.Rows
                PieceLst.Add(t(0))
                RingLoszeroTime.Add(t(1))
            Next

            If PieceLst.Count <> 0 Then
                _AveAsmPiece = PieceLst.Average
                _SumAsmPiece = PieceLst.Sum

                _AveLoszeroTime = RingLoszeroTime.Average
                _SumLoszeroTime = RingLoszeroTime.Sum
            End If



        End Sub)

            Await task







        End If

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

    'MariaDB Trigger用
    Dim tbUpdateTime As Date

    'セグメント組立データが変更されたイベント
    Public Event SegmentAsmChange()


    Public Sub New()
        If clsDataBase.MySQLVersion = "4.0.25" Then
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
        timer.Interval = 2000   '5秒ごとの処理
        timer.Enabled = True ' timer.Start()と同じ

        Dim td As DataTable = GetDtfmSQL("SELECT TIME FROM updatetable ORDER BY TIME DESC")
        If td.Rows.Count <> 0 Then
            tbUpdateTime = td.Rows(0).Item(0)


        End If

    End Sub

    Private Sub TableUpdateTimeGet()

        If clsDataBase.MySQLVersion = "4.0.25" Then
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

        End If

        'MariaDBのときは、triggerを利用
        If clsDataBase.MySQLVersion = "MariaDB" Then
            Dim tableUpDt As DataTable =
            GetDtfmSQL($"SELECT * FROM updatetable WHERE TIME>'{tbUpdateTime.ToString}' ORDER BY TIME DESC")

            If tableUpDt.Rows.Count <> 0 Then
                tbUpdateTime = tableUpDt.Rows(0).Item("TIME")
            End If

            For i As Integer = 0 To tableUpDt.Rows.Count - 1
                Select Case tableUpDt.Rows(i).Item("TableName")
                    Case "flex制御パラメータ"
                        CtlPara.ReadParameter()
                        My.Forms.frmMain.WideDataFldSet() '汎用データの更新
                    Case "flexアナログtag", "flexデジタルtag"
                        PlcIf.TagRead()
                    Case "flex初期パラメータ"
                        InitPara = New clsInitParameter
                    Case "flexセグメント組立データ"
                        SegAsmblyData.SegmentRingDataRead()
                        '組立パターンの情報を取得
                        SegAsmblyData.AssemblyDataRead(PlcIf.RingNo)


                        My.Forms.frmMain.SegmentDataDsp() 'セグメント組立情報表示

                        RaiseEvent SegmentAsmChange()


                End Select

            Next






        End If















    End Sub


    Private Function GetUpdateTIme() As Dictionary(Of String, Date)
        '更新時間を取得　MISAMのみ

        If clsDataBase.MySQLVersion = "4.0.25" Then
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
    Sub New(dic As Dictionary(Of String, String), tbName As String)
        Me._dic = dic
        Me._tableName = tbName
    End Sub

    Public Function GetValue(tKey As String) As String
        If _dic.ContainsKey(tKey) Then
            Return _dic(tKey)
        Else
            MsgBox($"テーブル'{_tableName}'に,'{tKey}'が見つかりません！", vbCritical)
            Return Nothing
        End If
    End Function

    Public Function GetValue(tKey As String, DefaltVal As String) As String
        If _dic.ContainsKey(tKey) Then
            Return _dic(tKey)
        Else
            Dim db As New clsDataBase
            db.ExecuteSqlCmd($"INSERT INTO flex制御パラメータ(`項目名称`,`値`) VALUES('{tKey}','{DefaltVal}')")
            Return DefaltVal
        End If
    End Function




End Class

