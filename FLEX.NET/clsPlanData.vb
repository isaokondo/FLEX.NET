Option Strict Off
Option Explicit On

Imports System.Data.OleDb
Imports System.Math
'計画路線読込
''' <summary>
''' 計画路線　平面、縦断共通項目
''' </summary>
''' <remarks></remarks>
Public Class clsPlanData
    Inherits clsDataBase
    Public Property ゾーン総数 As Integer         'ゾーン総数
    Public Property シフトゾーン総数 As Integer    'シフトゾーン数
    Public Property 線形 As Integer()    '線形の種類
    Public Property 前胴中心 As Double()   '前胴中心
    Public Property 後胴中心 As Double()
    Public Property 中折 As Integer()        '中折
    Public Property 中折開始 As Double()
    Public Property 戻し開始 As Double()
    Public Property 最大中折れ角 As Double()
    Public Property 姿勢変化率 As Double()
    Public Property 中心角 As Double()
    Public Property 線分長 As Double()
    Public Property シフト区間長 As Double()    'シフト区間長
    Public Property 始点シフト量 As Double()     '始点シフト量
    Public Property 終点シフト量 As Double()      '終点シフト量
    Public Property シフトゾーン距離 As Double()  'シフトゾーン距離
    Public Property シフトゾーン残距離 As Double()    'シフトゾーン残距離



    Public Overridable Sub RedimData()
        ReDim _線形(_ゾーン総数 + 1), _前胴中心(_ゾーン総数 + 1), _後胴中心(_ゾーン総数 + 1), _中折(_ゾーン総数 + 1),
            _中折開始(_ゾーン総数 + 1), _戻し開始(_ゾーン総数 + 1), _最大中折れ角(_ゾーン総数 + 1),
            _姿勢変化率(_ゾーン総数 + 1), _中心角(_ゾーン総数 + 1), _線分長(_ゾーン総数 + 1)
        ReDim _シフト区間長(_ゾーン総数 + 1), _始点シフト量(_ゾーン総数 + 1),
            _終点シフト量(_ゾーン総数 + 1), _シフトゾーン距離(_ゾーン総数 + 1), _シフトゾーン残距離(_ゾーン総数 + 1)


    End Sub


End Class



Public Class clsHorPanData
    Inherits clsPlanData

    Public Sub New()
        DataRead()
    End Sub

    '平面線形データ
    Public Property 発進X座標 As Double
    Public Property 発進Y座標 As Double
    Public Property 発進方位角 As Double
    Public Property 到達X座標 As Double
    Public Property 到達Y座標 As Double
    Public Property 到達方位角 As Double
    Public Property 座標系 As Short
    Public Property X軸方位角 As Double
    Public Property 起点X座標 As Double
    Public Property 起点Y座標 As Double
    Public Property 起点方位角 As Double

    Public Property 終点測点名 As String() '終点測点名
    Public Property 始点累積距離 As Double() '始点累積距離
    Public Property 終点累積距離 As Double() '終点累積距離
    Public Property 始点方向角 As Double() '始点方向角（勾配)
    Public Property 終点方向角 As Double() '終点方向角(勾配)

    'シフト対応
    Public Property 始点曲率半径 As Double()                '始点曲率半径
    Public Property 終点曲率半径 As Double()              '終点曲率半径
    Public Property 始点カント As Double()                  '始点カント
    Public Property 終点カント As Double()                '終点カント

    Public Property クロソイドパラメータ As Double()          'クロソイドパラメータ

    Public Property 始点X座標 As Double()                  '始点X座標
    Public Property 終点X座標 As Double()                '終点X座標
    Public Property 始点Y座標 As Double()                  '始点Y座標
    Public Property 終点Y座標 As Double()                '終点Y座標
    Public Property 始点中心X座標 As Double()           '始点中心X座標
    Public Property 終点中心X座標 As Double()         '終点中心X座標
    Public Property 始点中心Y座標 As Double()           '始点中心Y座標
    Public Property 終点中心Y座標 As Double()         '終点中心Y座標
    Public Property 始点構築X座標 As Double()         '始点構築X座標
    Public Property 終点構築X座標 As Double()       '終点構築X座標
    Public Property 始点構築Y座標 As Double()         '終点構築Y座標
    Public Property 終点構築Y座標 As Double()       '始点構築X座標

    Public Shadows Sub RedimData()

        MyBase.RedimData()

        ReDim _終点測点名(ゾーン総数 + 1), _始点累積距離(ゾーン総数 + 1), _終点累積距離(ゾーン総数 + 1), _始点方向角(ゾーン総数 + 1),
            _終点方向角(ゾーン総数 + 1)

        ReDim _始点曲率半径(ゾーン総数 + 1), _終点曲率半径(ゾーン総数 + 1), _始点カント(ゾーン総数 + 1), _
    _終点カント(ゾーン総数 + 1), _クロソイドパラメータ(ゾーン総数 + 1), _始点X座標(ゾーン総数 + 1), _
    _終点X座標(ゾーン総数 + 1), _始点Y座標(ゾーン総数 + 1), _終点Y座標(ゾーン総数 + 1)

        ReDim _始点中心X座標(ゾーン総数 + 1), _終点中心X座標(ゾーン総数 + 1), _始点中心Y座標(ゾーン総数 + 1), _
    _終点中心Y座標(ゾーン総数 + 1), _始点構築X座標(ゾーン総数 + 1), _終点構築X座標(ゾーン総数 + 1), _
    _始点構築Y座標(ゾーン総数 + 1), _終点構築Y座標(ゾーン総数 + 1)

    End Sub






    Public Sub DataRead()
        '計画路線の読込
        'Dim db As New AccessMdb
        'Dim tb As DataTable
        ''        Dim SheetID As Integer = 20
        'db.Connect()

        Dim tbl As DataTable =
            GetDtfmSQL($"SELECT * FROM 平面起点 WHERE シートID = {InitPara.SheetID}")

        For Each tb As DataRow In tbl.Rows
            _座標系 = tb.Item("座標系")
            _発進X座標 = tb.Item("発進X座標")
            _発進Y座標 = tb.Item("発進Y座標") * _座標系
            _到達X座標 = tb.Item("到達X座標")
            _到達Y座標 = tb.Item("到達Y座標") * _座標系
            _到達方位角 = tb.Item("到達方位角")
            _X軸方位角 = tb.Item("X軸方位角")

            '起点座標
            _起点X座標 = tb.Item("起点X座標")
            _起点Y座標 = tb.Item("起点Y座標") * _座標系
            _起点方位角 = tb.Item("起点方位角")
        Next

        'db.Disconnect()

        'ゾーン総数を求める
        'Dim tbr = ExecuteSql("SELECT MAX(`ゾーン№`) FROM 平面線形 WHERE シートID = " & InitPara.SheetID)
        'tbr.Read()
        'ゾーン総数 = tbr.Item(0)
        ''Disconnect()
        'tbr.Close()


        Dim tblHorLine As DataTable =
            GetDtfmSQL($"SELECT * FROM 平面線形 WHERE シートID = {InitPara.SheetID} ORDER BY 'ゾーン№'")



        ゾーン総数 = (From zo In tblHorLine.AsEnumerable Select zo.Item("ゾーン№")).Last


        Call RedimData()



        'Dim i As Integer

        'For i = 0 To tb.Rows.Count - 1
        For Each h As DataRow In tblHorLine.Rows
            Dim zoneNo As Integer = h.Item("ゾーン№")
            線形(zoneNo) = h.Item("線形状")
            線分長(zoneNo) = h.Item("線分長")

            If 線形(zoneNo) <> 1 Then
                _始点曲率半径(zoneNo) = CheckItemData(h.Item("始点半径")) * _座標系
                _終点曲率半径(zoneNo) = CheckItemData(h.Item("終点半径")) * _座標系
                _始点カント(zoneNo) = CheckItemData(h.Item("始点シフト")) * _座標系
                _終点カント(zoneNo) = CheckItemData(h.Item("終点シフト")) * _座標系

                中折(zoneNo) = h.Item("中折使用").ToString.ToNum
                前胴中心(zoneNo) = h.Item("前胴中心").ToString.ToNum
                後胴中心(zoneNo) = CheckItemData(h.Item("後胴中心"))
                中折開始(zoneNo) = CheckItemData(h.Item("中折開始"))
                戻し開始(zoneNo) = CheckItemData(h.Item("戻し開始"))
                最大中折れ角(zoneNo) = CheckItemData(h.Item("最大中折角")) * _座標系
                姿勢変化率(zoneNo) = CheckItemData(h.Item("姿勢変化率"))

                _クロソイドパラメータ(zoneNo) = CheckItemData(h.Item("ｸﾛｿｲﾄﾞﾊﾟﾗﾒｰﾀ"))
                中心角(zoneNo) = CheckItemData(h.Item("中心角"))
            End If
            If Not IsDBNull(h.Item("終点測点名")) Then
                _終点測点名(zoneNo) = h.Item("終点測点名")
            End If
            _始点累積距離(zoneNo) = h.Item("始点累積距離")
            _終点累積距離(zoneNo) = h.Item("終点累積距離")
            _始点方向角(zoneNo) = Hoi2Hoko(h.Item("始点方向角"))
            _終点方向角(zoneNo) = Hoi2Hoko(h.Item("終点方向角"))
            _始点X座標(zoneNo) = h.Item("始点X座標")
            _終点X座標(zoneNo) = h.Item("終点X座標")
            _始点Y座標(zoneNo) = h.Item("始点Y座標") * _座標系
            _終点Y座標(zoneNo) = h.Item("終点Y座標") * _座標系

            If Not IsDBNull(h.Item("始点中心X")) Then
                _始点中心X座標(zoneNo) = h.Item("始点中心X")
                _終点中心X座標(zoneNo) = h.Item("終点中心X")
                _始点中心Y座標(zoneNo) = h.Item("始点中心Y") * _座標系
                _終点中心Y座標(zoneNo) = h.Item("終点中心Y") * _座標系
            End If


            _始点構築X座標(zoneNo) = h.Item("始点X構築")
            _終点構築X座標(zoneNo) = h.Item("終点X構築")
            _始点構築Y座標(zoneNo) = h.Item("始点Y構築") * _座標系
            _終点構築Y座標(zoneNo) = h.Item("終点Y構築") * _座標系

        Next
        'With tblHorLine
        '        While .Read
        '            'Try
        '            Dim zoneNo As Integer = .Item("ゾーン№")
        '            線形(zoneNo) = .Item("線形状")
        '            線分長(zoneNo) = .Item("線分長")

        '            If 線形(zoneNo) <> 1 Then
        '            _始点曲率半径(zoneNo) = CheckItemData(.Item("始点半径")) * _座標系
        '            _終点曲率半径(zoneNo) = CheckItemData(.Item("終点半径")) * _座標系
        '            _始点カント(zoneNo) = CheckItemData(.Item("始点シフト")) * _座標系
        '            _終点カント(zoneNo) = CheckItemData(.Item("終点シフト")) * _座標系

        '            中折(zoneNo) = .Item("中折使用").ToString.ToNum
        '                前胴中心(zoneNo) = .Item("前胴中心").ToString.ToNum
        '            後胴中心(zoneNo) = CheckItemData(.Item("後胴中心"))
        '            中折開始(zoneNo) = CheckItemData(.Item("中折開始"))
        '            戻し開始(zoneNo) = CheckItemData(.Item("戻し開始"))
        '            最大中折れ角(zoneNo) = CheckItemData(.Item("最大中折角")) * _座標系
        '            姿勢変化率(zoneNo) = CheckItemData(.Item("姿勢変化率"))

        '            _クロソイドパラメータ(zoneNo) = CheckItemData(.Item("ｸﾛｿｲﾄﾞﾊﾟﾗﾒｰﾀ"))
        '            中心角(zoneNo) = CheckItemData(.Item("中心角"))
        '        End If
        '            _始点累積距離(zoneNo) = .Item("始点累積距離")
        '            _終点累積距離(zoneNo) = .Item("終点累積距離")
        '            _始点方向角(zoneNo) = Hoi2Hoko(.Item("始点方向角"))
        '            _終点方向角(zoneNo) = Hoi2Hoko(.Item("終点方向角"))
        '            _始点X座標(zoneNo) = .Item("始点X座標")
        '            _終点X座標(zoneNo) = .Item("終点X座標")
        '            _始点Y座標(zoneNo) = .Item("始点Y座標") * _座標系
        '            _終点Y座標(zoneNo) = .Item("終点Y座標") * _座標系

        '            If Not IsDBNull(.Item("始点中心X")) Then
        '                _始点中心X座標(zoneNo) = .Item("始点中心X")
        '                _終点中心X座標(zoneNo) = .Item("終点中心X")
        '                _始点中心Y座標(zoneNo) = .Item("始点中心Y") * _座標系
        '                _終点中心Y座標(zoneNo) = .Item("終点中心Y") * _座標系
        '            End If


        '            _始点構築X座標(zoneNo) = .Item("始点X構築")
        '            _終点構築X座標(zoneNo) = .Item("終点X構築")
        '            _始点構築Y座標(zoneNo) = .Item("始点Y構築") * _座標系
        '            _終点構築Y座標(zoneNo) = .Item("終点Y構築") * _座標系
        '            'Catch ex As InvalidCastException
        '            'Exit Try
        '            'End Try
        '        End While
        '    End With
        '    tblHorLine.Close


        'Next
        'db.Disconnect()

        'ゾーン総数を求める
        'tblHorLine = db.ExecuteSql($"SELECT MAX(`シフト№`) FROM 平面シフト WHERE シートID = {InitPara.SheetID}")
        '    tblHorLine.Read()
        '    シフトゾーン総数 = tblHorLine.Item(0)
        'db.Disconnect()
        'tblHorLine.Close()

        Dim tblHorShift As DataTable =
            GetDtfmSQL($"SELECT * FROM 平面シフト WHERE シートID = {InitPara.SheetID} ORDER BY 'シフト№'")
        'For i = 0 To tb.Rows.Count - 1
        シフトゾーン総数 = (From zo In tblHorShift.AsEnumerable Select zo("シフト№")).Last

        For Each t As DataRow In tblHorShift.Rows
            Dim shiftNo As Integer = t.Item("シフト№")
            シフト区間長(shiftNo) = t.Item("区間長")
            始点シフト量(shiftNo) = CheckItemData(t.Item("始点シフト")) * _座標系
            終点シフト量(shiftNo) = CheckItemData(t.Item("終点シフト")) * _座標系
        Next

        'With tblHorLine
        '        While .Read
        '            Dim shiftNo As Integer = .Item("シフト№")
        '            シフト区間長(shiftNo) = .Item("区間長")
        '        始点シフト量(shiftNo) = CheckItemData(.Item("始点シフト")) * _座標系
        '        終点シフト量(shiftNo) = CheckItemData(.Item("終点シフト")) * _座標系
        '    End While
        '    End With
        'Next i

        'tblHorLine.Close()

    End Sub


End Class

Public Class clsVerPlanData

    Inherits clsPlanData

    Public Sub New()
        DataRead()
    End Sub

    Public Property 発進Z座標 As Double           '発進Z座標
    Public Property 発進勾配 As Double          '発進勾配
    Public Property 到達Z座標 As Double                   '到達Z座標
    Public Property 到達勾配 As Double                  '到達勾配

    Public Property 線分水平距離 As Double()    '線分長
    Public Property 曲率半径 As Double()                    '曲率半径


    Public Property 始点累積水平距離 As Double() '始点累積距離
    Public Property 終点累積累積距離 As Double() '終点累積距離
    Public Property 始点勾配 As Double() '始点勾配
    Public Property 終点勾配 As Double() '終点勾配

    Public Property 始点Z座標 As Double()                 '始点Z座標
    Public Property 終点Z座標 As Double()               '終点Z座標

    Public Property 中心位置Z座標 As Double()               '中心位置Z座標
    Public Property 中心位置累積水平距離 As Double() '中心位置累積水平距離

    Public Shadows Sub RedimData()

        MyBase.RedimData()

        ReDim _線分水平距離(ゾーン総数 + 1), _曲率半径(ゾーン総数 + 1), _始点累積水平距離(ゾーン総数 + 1), _
            _終点累積累積距離(ゾーン総数 + 1)

        ReDim _始点勾配(ゾーン総数 + 1), _終点勾配(ゾーン総数 + 1), _始点Z座標(ゾーン総数 + 1), _
    _終点Z座標(ゾーン総数 + 1), _中心位置Z座標(ゾーン総数 + 1), _中心位置累積水平距離(ゾーン総数 + 1)

    End Sub


    Public Sub DataRead()

        Dim tblVerStart As DataTable =
            GetDtfmSQL($"SELECT * FROM 縦断発進 WHERE シートID = {InitPara.SheetID}")

        For Each t As DataRow In tblVerStart.Rows
            発進Z座標 = t.Item("発進Z座標")
            発進勾配 = t.Item("発進勾配")
            到達Z座標 = t.Item("到達Z座標")
            到達勾配 = t.Item("到達勾配")
        Next


        'ゾーン総数を求める
        'tblVerStart = ExecuteSql($"SELECT MAX(`ゾーン№`) FROM 縦断線形 WHERE シートID = {InitPara.SheetID}")
        'tblVerStart.Read()
        'ゾーン総数 = CInt(tblVerStart.Item(0))
        ''Disconnect()
        'tblVerStart.Close()

        Dim tblVerLine As DataTable =
            GetDtfmSQL($"SELECT * FROM 縦断線形 WHERE シートID ={InitPara.SheetID} ORDER BY 'ゾーン№'")

        ゾーン総数 = tblVerLine.Rows.Count - 1


        RedimData()

        For Each t As DataRow In tblVerLine.Rows
            Dim zoneNo As Integer = CInt(t.Item("ゾーン№"))
            線形(zoneNo) = CInt(t.Item("線形状"))
            _線分水平距離(zoneNo) = CDbl(t.Item("水平線分距離"))
            If 線形(zoneNo) <> 1 Then
                中折(zoneNo) = CheckItemData(t.Item("中折使用"))
                前胴中心(zoneNo) = CheckItemData(t.Item("前胴中心"))
                後胴中心(zoneNo) = CheckItemData(t.Item("後胴中心"))
                中折開始(zoneNo) = CheckItemData(t.Item("中折開始"))
                戻し開始(zoneNo) = CheckItemData(t.Item("戻し開始"))
                最大中折れ角(zoneNo) = CheckItemData(t.Item("最大中折角"))
                姿勢変化率(zoneNo) = CheckItemData(t.Item("姿勢変化率"))

                中心角(zoneNo) = CheckItemData(t.Item("中心角"))
            End If
            _始点累積水平距離(zoneNo) = t.Item("始点累積距離")
            _終点累積累積距離(zoneNo) = t.Item("終点累積距離")
            _始点勾配(zoneNo) = t.Item("始点勾配")
            _終点勾配(zoneNo) = t.Item("終点勾配")
            _始点Z座標(zoneNo) = t.Item("始点Z座標")
            _終点Z座標(zoneNo) = t.Item("終点Z座標")
            _中心位置Z座標(zoneNo) = CheckItemData(t.Item("中心Z"))
            _中心位置累積水平距離(zoneNo) = CheckItemData(t.Item("中心累積距離"))
        Next

        'With tblVerStart
        '    While .Read
        '        Dim zoneNo As Integer = CInt(t.item("ゾーン№"))
        '        線形(zoneNo) = CInt(t.item("線形状"))
        '        _線分水平距離(zoneNo) = CDbl(t.item("水平線分距離"))
        '        If 線形(zoneNo) <> 1 Then
        '            中折(zoneNo) = CheckItemData(t.item("中折使用"))
        '            前胴中心(zoneNo) = CheckItemData(t.item("前胴中心"))
        '            後胴中心(zoneNo) = CheckItemData(t.item("後胴中心"))
        '            中折開始(zoneNo) = CheckItemData(t.item("中折開始"))
        '            戻し開始(zoneNo) = CheckItemData(t.item("戻し開始"))
        '            最大中折れ角(zoneNo) = CheckItemData(t.item("最大中折角"))
        '            姿勢変化率(zoneNo) = CheckItemData(t.item("姿勢変化率"))

        '            中心角(zoneNo) = CheckItemData(t.item("中心角"))
        '        End If
        '        _始点累積水平距離(zoneNo) = t.item("始点累積距離")
        '        _終点累積累積距離(zoneNo) = t.item("終点累積距離")
        '        _始点勾配(zoneNo) = t.item("始点勾配")
        '        _終点勾配(zoneNo) = t.item("終点勾配")
        '        _始点Z座標(zoneNo) = t.item("始点Z座標")
        '        _終点Z座標(zoneNo) = t.item("終点Z座標")
        '        _中心位置Z座標(zoneNo) = CheckItemData(t.item("中心Z"))
        '        _中心位置累積水平距離(zoneNo) = CheckItemData(t.item("中心累積距離"))
        '    End While
        'End With
        'tblVerStart.Close()
        '       Next
        '        Disconnect()

        'ゾーン総数を求める
        'tblVerStart = ExecuteSql("SELECT MAX(`シフト№`) FROM 縦断シフト WHERE シートID = " & InitPara.SheetID)
        'tblVerStart.Read()
        'シフトゾーン総数 = tblVerStart.Item(0)
        '        Disconnect()

        Dim tblVerShift As DataTable =
            GetDtfmSQL($"SELECT * FROM 縦断シフト WHERE シートID = {InitPara.SheetID} ORDER BY 'シフト№'")

        シフトゾーン総数 = tblVerShift.Rows.Count

        For Each t As DataRow In tblVerShift.Rows
            Dim shiftNo As Integer = t.Item("シフト№")
            シフト区間長(shiftNo) = t.Item("区間長")
            始点シフト量(shiftNo) = CheckItemData(t.Item("始点シフト"))
            終点シフト量(shiftNo) = CheckItemData(t.Item("終点シフト"))
        Next


        'With tblVerStart
        '    While .Read
        '        Dim shiftNo As Integer = .Item("シフト№")
        '        シフト区間長(shiftNo) = .Item("区間長")
        '        始点シフト量(shiftNo) = CheckItemData(.Item("始点シフト"))
        '        終点シフト量(shiftNo) = CheckItemData(.Item("終点シフト"))
        '    End While
        'End With
        'Next i

    End Sub

End Class

Public Class AccessMdb
    ''' <summary>
    ''' SQLコネクション
    ''' </summary>
    Private _con As OleDbConnection = Nothing

    ''' <summary>
    ''' トランザクション・オブジェクト
    ''' </summary>
    ''' <remarks></remarks>
    Private _trn As OleDbTransaction = Nothing


    'Public Sub Connect(Optional ByVal dsn As String = "db1.mdb", _
    '                   Optional ByVal tot As Integer = -1)

    '    Try
    '        If _con Is Nothing Then
    '            _con = New OleDbConnection
    '        End If

    '        Dim cst As String = ""
    '        cst = cst & "Provider=Microsoft.Jet.OLEDB.4.0"
    '        cst = cst & ";Data Source=" & InitParameter.PlanMdbPath
    '        ' データベースパスワードが設定されている場合
    '        ' cst = cst & ";Jet OLEDB:Database Password=xxxxx"
    '        If tot > -1 Then
    '            '_con.ConnectionTimeout = tot
    '            cst = cst & ";Connect Timeout=" & tot.ToString
    '        End If
    '        _con.ConnectionString = cst

    '        _con.Open()
    '    Catch ex As System.Data.OleDb.OleDbException
    '        MsgBox("計画線" & ex.Message & vbCrLf & "プログラムを終了します。", MsgBoxStyle.Exclamation)
    '        End
    '        System.Console.WriteLine(ex.Message)
    '        'Throw New Exception("Connect Error", ex)
    '    End Try
    'End Sub

    ''' <summary>
    ''' DB切断
    ''' </summary>
    Public Sub Disconnect()
        Try
            _con.Close()
        Catch ex As Exception
            Throw New Exception("Disconnect Error", ex)
        End Try
    End Sub


    Public Function CheckItemData(tmp As Object) As String
        If IsNumeric(tmp) Then
            Return tmp.ToString
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' SQLの実行
    ''' </summary>
    ''' <param name="sql">SQL文</param>
    ''' <param name="tot">タイムアウト値</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteSql(ByVal sql As String, _
                               Optional ByVal tot As Integer = -1) As DataTable
        Dim dt As New DataTable

        Try
            Dim sqlCommand As New OleDbCommand(sql, _con, _trn)

            If tot > -1 Then
                sqlCommand.CommandTimeout = tot
            End If

            Dim adapter As New OleDbDataAdapter(sqlCommand)

            adapter.Fill(dt)
            adapter.Dispose()
            sqlCommand.Dispose()
        Catch ex As Exception
            Throw New Exception("ExecuteSql Error", ex)
        End Try

        Return dt
    End Function

    ''' <summary>
    ''' トランザクション開始
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub BeginTransaction()
        Try
            _trn = _con.BeginTransaction()
        Catch ex As Exception
            Throw New Exception("BeginTransaction Error", ex)
        End Try
    End Sub

    ''' <summary>
    ''' コミット
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CommitTransaction()
        Try
            If _trn Is Nothing = False Then
                _trn.Commit()
            End If
        Catch ex As Exception
            Throw New Exception("CommitTransaction Error", ex)
        Finally
            _trn = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' ロールバック
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RollbackTransaction()
        Try
            If _trn Is Nothing = False Then
                _trn.Rollback()
            End If
        Catch ex As Exception
            Throw New Exception("RollbackTransaction Error", ex)
        Finally
            _trn = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' ファイナライズ
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overrides Sub Finalize()
        Disconnect()
        MyBase.Finalize()
    End Sub
End Class



