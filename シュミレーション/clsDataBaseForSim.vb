Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Enum DataBaseType
    MySQL
    MsSQLServer
End Enum


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
            PortNo = GetIniString("DataBase", "port", IniFilePath)
        Else
            MsgBox($"FLEX.INIファイルが見つかりません。{vbCrLf}ファイルパス：{IniFilePath}",
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "初期ファイル読込不良")
            End
        End If
        GetMySQKVersion()

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
                Debug.Print(SQLCommand)
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
    Public Value As Double          '値
End Structure


Public Class clsTag
    Inherits clsDataBase

    Private _Tag() As _tag
    Private _startAddress As String  '読み込み開始アドレス
    Private _devicesize As Integer = 0   'アドレス読込個数

    Private WithEvents Htb As New clsHashtableRead


    Public ReadOnly Property TagData(ByVal strFldName As String) As _tag
        Get
            Return _Tag(Htb.GetValue(strFldName))
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
        Dim TableAndWhere As String = " " & TableName & " WHERE `アドレス` LIKE '" & PLCAdressClass & "%'"
        Dim MaxID As DataTable =
            GetDtfmSQL("SELECT COUNT(*) FROM " & TableAndWhere)
        'MaxID.Read()
        ReDim _Tag(MaxID.Rows(0).Item(0) + 1)

        Dim StartAd As DataTable = GetDtfmSQL("SELECT Min(`アドレス`) FROM" & TableAndWhere)
        'StartAd.Read()
        _startAddress = StartAd.Rows(0).Item(0)
        'ビットデータの時は、16の倍数からアドレスを介し
        If _startAddress.Substring(0, 1) = "M" Then
            _startAddress = _startAddress(0) & (CInt(_startAddress.Substring(1)) \ 16) * 16
        End If

        Dim anaTag As DataTable = GetDtfmSQL("SELECT * FROM " & TableAndWhere)

        Dim ht As Hashtable = New Hashtable

        Dim StartAdress As Integer = CInt(_startAddress.Substring(1))

        Dim i As Integer = 0 ' anaTag("ID")
        'While anaTag.Read()
        For Each t As DataRow In anaTag.Rows

                _Tag(i).FieldName = anaTag("項目名").ToString
                _Tag(i).Address = anaTag("アドレス").ToString
                If TableName = "FLEXアナログtag" Then
                    _Tag(i).DigitLoc = CInt(t("小数点位置"))
                    _Tag(i).Unit = t("単位").ToString
                    _Tag(i).EngLow = CSng(t("下限"))
                    _Tag(i).EngHight = CSng(t("上限"))
                    _Tag(i).ScaleLow = CSng(t("スケール下限"))
                    _Tag(i).ScaleHigh = CSng(t("スケール上限"))
                End If
                Dim ad As String = _Tag(i).Address 'アドレスからオフセットを算出
                If Not ad.Equals("") AndAlso IsNumeric(ad.Substring(1)) Then
                    _Tag(i).OffsetAddress = CInt(ad.Substring(1)) - StartAdress
                End If

                ht(anaTag("項目名")) = i

                'オフセットの最大値取得
                If _devicesize < _Tag(i).OffsetAddress Then _devicesize = _Tag(i).OffsetAddress
                i = i + 1
                'End If
            Next
        'If Not IsDBNull(anaTag("項目名")) Then
        'End While

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

    'Public ReadOnly Property PlanMdbPath As String
    '    Get
    '        Return _planDataMdb
    '    End Get
    'End Property
    Public Sub New()
        Dim paraDB As DataTable = GetDtfmSQL("SELECT * FROM FLEX初期パラメータ")

        Dim ht As Hashtable = New Hashtable

        Try
            'While paraDB.Read()
            For Each t As DataRow In paraDB.Rows
                ht(t("項目名称")) = t("値")

            Next
            'End While

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

        Catch ex As Exception

        End Try


    End Sub
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

