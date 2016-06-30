Option Strict On
Option Explicit On
Friend Class clsSegmentMakeData
    ' @(h) clsSegmentMakeData.cls                ver 2.2 ( '06/04/11 近藤　勲 )
    ' MYSQL　対応 篠原幹線より

    ' @(h) clsSegmentMakeData.cls                ver 1.3 ( '04.01.16 近藤　勲 )
    '推進ジャッキを追加

    ' @(h) clsSegmentMakeData.cls                ver 1.3 ( '04.01.16 近藤　勲 )
    'データ更新の部分を改善

    ' @(h) clsSegmentMakeData.cls                ver 1.3 ( '03.06.16 近藤　勲 )
    ''sbSegPtnRead()で３２本以上のジャッキに対応

    ' @(h) clsSegmentMakeData.cls                ver 1.2 ( '03.04.30 近藤　勲 )
    ''掘進終了ストローク追加
    ' @(h) clsSegmentMakeData.cls                ver 1.1 ( '03.04.21 近藤　勲 )
    ''データベース構造変更のため

    ' @(h) clsSegmentMakeData.cls                ver 1.0 ( '02.10.23 近藤　勲 )
    ''半同時施工のために追加

    ' @(h) clsSegmentMakeData.cls                ver 2.1 ( '04/08/11 近藤　勲 )
    ' 仮リング対応

    Inherits clsDataBase

    Private mintRingno As Short
    'Private mintセグメント幅(cMAX_Ring) As Integer 04/08/11 仮リング対応
    'UPGRADE_WARNING: 配列 mintセグメント幅 の下限が cStart_Ring から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
    'UPGRADE_WARNING: オブジェクト cMAX_Ring の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
    'UPGRADE_WARNING: オブジェクト cStart_Ring の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
    Private mintセグメント幅(cMAX_Ring) As Short
    Private mintセグメント幅種類() As Short ''コンマで区切られた文字列

    ''03/04/30追加
    'Private mint掘進終了ストローク(cMAX_Ring) As Integer


    Public WriteOnly Property RingNo() As Short
        Set(ByVal Value As Short)
            mintRingno = Value
            '    Call sbSegPtnRead   ''セグメント組立パターン読込
        End Set
    End Property
    'Public ReadOnly Property セグメント幅種類Tab() As String
    '    Get
    '        ''スプレッドシートのコンボボックスの選択データの作成用
    '        Dim intCnt As Short
    '        For intCnt = 1 To CShort(UBound(mintセグメント幅種類))
    '            セグメント幅種類Tab = セグメント幅種類Tab & mintセグメント幅種類(intCnt) & vbTab
    '        Next intCnt
    '        Return セグメント幅種類Tab
    '    End Get
    'End Property







    Public Property セグメント幅() As Short
        Get
            Return mintセグメント幅(mintRingno)
        End Get
        Set(ByVal Value As Short)
            mintセグメント幅(mintRingno) = Value
        End Set
    End Property


    Public Property 掘進終了ストローク(ByVal intRingNo As Short) As Short
        Get
            Return fnGetKussinLastStroke(intRingNo)
        End Get
        Set(ByVal Value As Short)
            ''更新クエリー実行
            Dim rsData As Odbc.OdbcDataReader = _
                ExecuteSql("UPDATE セグメント組立データ " & _
                     "SET 掘進終了ストローク = " & Value & _
                     " WHERE リング番号 = " & intRingNo & ";")
        End Set
    End Property





    Public Sub sbDataRead()
        ' @(f)
        '
        ' 機能      :データベース読込
        '
        ' 返り値    :
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :



        Dim rsData As Odbc.OdbcDataReader

        rsData = ExecuteSql("SELECT * FROM セグメント組立データ")

        With rsData


            While rsData.Read()
                mintRingno = CShort(.Item("リング番号"))
                If mintRingno >= cStart_Ring And mintRingno <= cMAX_Ring Then
                    mintセグメント幅(mintRingno) = CShort(.Item("セグメント幅"))
                End If


            End While
        End With
        'TODO:セグメント幅の種類を作成;
        ' ''データベース構造変更のため 03/04/21
        'rsData = fnConnect.Execute("SELECT DISTINCT セグメント幅 FROM セグメント組立データ")

        'Dim intCnt As Short
        'intCnt = 1
        'With rsData
        '    ReDim mintセグメント幅種類(50)

        '    .MoveFirst()
        '    Do While Not .EOF
        '        mintセグメント幅種類(intCnt) = .Item("セグメント幅").Value
        '        intCnt = intCnt + 1
        '        .MoveNext()
        '    Loop
        '    ReDim Preserve mintセグメント幅種類(intCnt - 1)
        '    .Close()
        'End With
    End Sub


    Public Sub sbDataUpdat()
        ' @(f)
        '
        ' 機能      :データ更新
        '
        ' 返り値    :
        '
        '
        ' 機能説明  :04/01/16 修正
        '
        ' 備考      :Findだとパフォーマンスが不足のため変更




        'Dim rsData As New ADODB.Recordset


        Dim rsData As Odbc.OdbcDataReader = _
            ExecuteSql("UPDATE セグメント組立データ SET セグメント幅 = " & mintセグメント幅(mintRingno) & _
                 " WHERE リング番号 = " & mintRingno & ";")


        '
    End Sub








    Private Function fnGetKussinLastStroke(ByRef intRingNo As Short) As Short
        ' @(f)
        '
        ' 機能      :掘進最終ストロークをDBより求める
        '
        ' 03/04/30 追加

        'Dim rsData As New ADODB.Recordset

        ''選択クエリー実行
        Dim rsData As Odbc.OdbcDataReader = ExecuteSql("SELECT * FROM  セグメント組立データ WHERE リング番号 = " & intRingNo & ";")


        ''掘進終了ストロークが0の場合はそのリングのセグメント幅にする
        If Not IsDBNull(rsData.Item("掘進終了ストローク")) And CShort(rsData.Item("掘進終了ストローク")) <> 0 Then
            Return CShort(rsData.Item("掘進終了ストローク"))
        Else
            Return CShort(rsData.Item("セグメント幅"))

            ''更新クエリー実行
            rsData = ExecuteSql("UPDATE セグメント組立データ SET 掘進終了ストローク = セグメント幅 WHERE リング番号 = " & intRingNo & ";")

        End If


    End Function



    Private Sub sbPutKussinLastStroke(ByRef intRingNo As Short, ByRef intLastStroke As Short)
        ' @(f)
        '
        ' 機能      :掘進最終ストロークを更新
        '
        ' 03/04/30 追加





    End Sub








    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()

        'ReDim mbln減圧G(1 To initParameter.NumberGroup, 1 To cMax_Piece)
        'ReDim mbln引き戻しJ(1 To initParameter.NumberJack, 1 To cMax_Piece)
        'ReDim mbln同調J(1 To initParameter.NumberJack, 1 To cMax_Piece)
        'ReDim mbln伸長J(1 To initParameter.NumberJack, 1 To cMax_Piece)
        'ReDim mbln推進J(1 To initParameter.NumberJack, 1 To cMax_Piece)  ''04/09/03 追加
        '

        Call sbDataRead() ''データベース読込

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class