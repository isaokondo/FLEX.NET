'Option Strict On
Option Explicit On
Friend Class clsSegmentAssembly
    ' @(h) clsSegmentMakeData.cls                ver 2.2 ( '06/04/11 近藤　勲 )

    ' @(h) clsSegmentMakeData.cls                ver 1.0 ( '02.10.23 近藤　勲 )
    ''半同時施工のために追加

    ' @(h) clsSegmentMakeData.cls                ver 2.1 ( '04/08/11 近藤　勲 )
    ' 仮リング対応

    Inherits clsDataBase

    Private mintRingno As Short
    ''' <summary>
    ''' セグメント幅
    ''' </summary>
    Private _SegmentWidth As New Dictionary(Of Integer, Short)()
    ''' <summary>
    ''' 掘進終了時のストローク
    ''' </summary>
    Private _RingLastStroke As New Dictionary(Of Integer, Short)()
    ''' <summary>
    ''' セグメント組立パターンID
    ''' </summary>
    Private _SegmentAssenblyPtnID As New Dictionary(Of Integer, Short)()
    ''' <summary>
    ''' セグメント組立パターン
    ''' </summary>
    Private _SegmentAssenblyPtn As New Dictionary(Of Integer, String)()

    ''' <summary>
    ''' セグメント組立データ
    ''' </summary>
    Private _SegmentProcessData As New Dictionary(Of Short, AsseblyProcess)


    ''' <summary>
    ''' セグメント幅
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentWidth As Dictionary(Of Integer, Short)
        Get
            Return _SegmentWidth
        End Get
    End Property
    ''' <summary>
    ''' 掘進終了時のストローク
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RingLastStroke As Dictionary(Of Integer, Short)
        Get
            Return _RingLastStroke
        End Get
        'Set(ByVal Value As Short)
        '    ''更新クエリー実行
        '    Dim rsData As Odbc.OdbcDataReader =
        '        ExecuteSql("UPDATE セグメント組立データ " &
        '             "SET 掘進終了ストローク = " & Value &
        '             " WHERE リング番号 = " & intRingNo & ";")
        'End Set
    End Property
    Public ReadOnly Property SegmentAssenblyPtn As Dictionary(Of Integer, String)
        Get
            Return _SegmentAssenblyPtn
        End Get
    End Property
    ''' <summary>
    ''' 組立ピース数
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AssemblyPieceNumber As Short

    'TODO:データベース書込
    ''' <summary>
    ''' セグメント組立パターン情報読込
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentProcessData As Dictionary(Of Short, AsseblyProcess)
        Get
            Return _SegmentProcessData
        End Get
    End Property
    ''' <summary>
    ''' セグメント組立パターンリスト
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentAssemblyPatternList As New List(Of String)
    ''' <summary>
    ''' セグメント種類リスト
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentTypeList As New List(Of String)
    ''' <summary>
    ''' 組立パターンの情報を取得
    ''' </summary>
    ''' <param name="RingNo">リング番号</param>
    Public Sub sbSegmentAssemblyDataRead(RingNo As Integer)
        '当該リングのセグメント組立IDを取得
        Dim Id As Short = _SegmentAssenblyPtnID(RingNo)
        '検索
        'Dim rsData As Odbc.OdbcDataReader =
        'ExecuteSql("SELECT * FROM `flexセグメント組立手順` WHERE `ID`='" & Id & "' ORDER BY `組立順序`")
        Dim rsData As Odbc.OdbcDataReader =
            ExecuteSql("SELECT * FROM `セグメント分割仕様リスト` " &
            "Inner Join `セグメント組立パターンベース` ON `セグメント分割仕様リスト`.`分割No` = `セグメント組立パターンベース`.`分割No`" &
            " Inner Join `セグメント組立パターンリスト` ON `セグメント組立パターンベース`.`組立パターンNo` = `セグメント組立パターンリスト`.`組立パターンNo` ORDER BY `組立順序`")
        _AssemblyPieceNumber = 0
        _SegmentProcessData.Clear()
        'データ読込
        While rsData.Read()
            Dim SegDat As New AsseblyProcess

            Dim PieaceNo As String = rsData.Item("ピースNo")
            If PieaceNo = "1" Then
                PieaceNo = "K"
            End If

            SegDat.AssemblyOrder = rsData.Item("組立順序")
            SegDat.PieceName = rsData.Item("ピース名")
            'SegDat.PieceAngle = rsData.Item("ピース角度")
            SegDat.PieceAngle = rsData.Item(PieaceNo & "スパン")
            'SegDat.PieceCenterAngle = rsData.Item("組立ピース中心角")
            If PieaceNo = "K" Then
                SegDat.PieceCenterAngle = rsData.Item("基本位置")
            Else
                SegDat.PieceCenterAngle = rsData.Item(PieaceNo & "中心")
            End If
            SegDat.PieceCenterAngle = 90 - SegDat.PieceCenterAngle
            SegDat.PullBackJack = JkList(rsData.Item("引戻"))
            'SegDat.OpposeJack = JkList(rsData.Item("対抗ジャッキ"))
            SegDat.ClosetJack = JkList(rsData.Item("押込"))
            SegDat.AddClosetJack = JkList(rsData.Item("追加"))
            'SegDat.RightRollingClosetJack = JkList(rsData.Item("右ローリング押込ジャッキ"))
            'SegDat.LeftRollingClosetJack = JkList(rsData.Item("左ローリング押込ジャッキ"))
            _SegmentProcessData(rsData.Item("組立順序")) = SegDat
            _AssemblyPieceNumber += 1   '組立ピース数
        End While

    End Sub
    ''' <summary>
    ''' ジャッキの連続した番号の表記をリスト形式に変換
    ''' </summary>
    ''' <param name="tmpS">文字列</param>
    ''' <returns></returns>
    Private Function JkList(ByVal tmpS As Object) As List(Of Short)

        Dim lst As New List(Of Short)

        If TypeName(tmpS) = "DBNull" Then
            Return lst
        End If

        If tmpS.IndexOf(",") > 0 Then
            Dim i As Integer
            Dim j As String() = tmpS.Split(",")
            '数値に変更可能か
            If IsNumeric(j(0)) And IsNumeric(j(1)) Then
                Dim St, Lt As Integer
                St = CShort(j(0))
                Lt = CShort(j(1))
                If Lt > St Then
                    For i = St To Lt
                        lst.Add(i)
                    Next
                Else
                    '天端ジャッキを含む場合
                    For i = St To InitParameter.NumberJack
                        lst.Add(i)
                    Next
                    For i = 1 To Lt
                        lst.Add(i)
                    Next
                End If
            End If
        Else
            '数値ひとつの場合
            If IsNumeric(tmpS) Then
                lst.Add(CShort(tmpS))
            End If
        End If

        Return lst

    End Function

    'TODO:オーバーライドを使いたい！
    'Private Function JkList(ByVal tmpS As DBNull) As List(Of Short)
    '    Return New List(Of Short)
    'End Function
    ''' <summary>
    ''' データベース読込
    ''' </summary>
    Public Sub sbSegmentRingDataRead()


        Dim rsData As Odbc.OdbcDataReader

        rsData = ExecuteSql _
            ("SELECT * FROM `セグメント組立データ` INNER Join `flexセグメント組立パターン` ON `組立パターンID` = `ID`;")

        With rsData
            While rsData.Read()
                Dim i As Integer = .Item("リング番号")
                _SegmentWidth(i) = .Item("セグメント幅")
                'データが不正の場合はセグメント幅とする
                If IsDBNull(.Item("掘進終了ストローク")) OrElse .Item("掘進終了ストローク") = 0 Then
                    _RingLastStroke(i) = _SegmentWidth(i)
                Else
                    _RingLastStroke(i) = .Item("掘進終了ストローク")
                End If
                If IsDBNull("組立パターンID") Then
                    _SegmentAssenblyPtnID(i) = 0
                    _SegmentAssenblyPtn(i) = ""
                Else
                    _SegmentAssenblyPtnID(i) = .Item("組立パターンID")
                    _SegmentAssenblyPtn(i) = .Item("組立パターン")
                End If

            End While
        End With

        SegmentAssemblyPatternListRead() 'セグメント組立パターンリスト読込
    End Sub
    ''' <summary>
    ''' セグメント組立パターン、種類読込
    ''' </summary>
    Private Sub SegmentAssemblyPatternListRead()

        _SegmentAssemblyPatternList.Clear()

        Dim rsData As Odbc.OdbcDataReader

        rsData = ExecuteSql _
            ("SELECT * FROM `flexセグメント組立パターン` ORDER BY `ID`")

        While rsData.Read()
            _SegmentAssemblyPatternList.Add(rsData.Item("組立パターン"))
        End While

        _SegmentTypeList.Clear()

        rsData = ExecuteSql("SELECT * FROM `flexセグメント種類` ORDER BY `ID`")
        While rsData.Read
            _SegmentTypeList.Add(rsData.Item("セグメント種類"))
        End While


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


        Dim rsData As Odbc.OdbcDataReader =
            ExecuteSql("UPDATE セグメント組立データ SET セグメント幅 = " & _SegmentWidth(mintRingno) &
                 " WHERE リング番号 = " & mintRingno & ";")


        '
    End Sub







    ''' <summary>
    ''' 掘進最終ストロークをDBより求める
    ''' </summary>
    ''' <param name="intRingNo">リング番号</param>
    ''' <returns></returns>
    Private Function fnGetKussinLastStroke(ByRef intRingNo As Integer) As Integer
        ' @(f)
        '
        ' 機能      :掘進最終ストロークをDBより求める
        '
        ' 03/04/30 追加


        ''選択クエリー実行
        Dim rsData As Odbc.OdbcDataReader = ExecuteSql("SELECT * FROM  セグメント組立データ WHERE リング番号 = " & intRingNo & ";")

        rsData.Read()
        ''掘進終了ストロークが0の場合はそのリングのセグメント幅にする
        If Not IsDBNull(rsData.Item("掘進終了ストローク")) And CShort(rsData.Item("掘進終了ストローク")) <> 0 Then
            Return rsData.Item("掘進終了ストローク")
        Else
            ''更新クエリー実行
            rsData = ExecuteSql("UPDATE セグメント組立データ SET 掘進終了ストローク = セグメント幅 WHERE リング番号 = " & intRingNo & ";")

            Return rsData.Item("セグメント幅")
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


        Call sbSegmentRingDataRead() ''データベース読込

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    ''' <summary>
    ''' 組立手順データ
    ''' </summary>
    Public Class AsseblyProcess



        Dim _PullBackJack As List(Of Short)
        ''' <summary>
        ''' 組立順序
        ''' </summary>
        ''' <returns></returns>
        Public Property AssemblyOrder As Short

        ''' <summary>
        ''' ピース名称
        ''' </summary>
        Public Property PieceName As String
        ''' <summary>
        ''' ピース角度
        ''' </summary>
        Public Property PieceAngle As Double
        ''' <summary>
        ''' 組立ピース中心
        ''' </summary>
        Public Property PieceCenterAngle As Double
        ''' <summary>
        ''' 対抗ジャッキ
        ''' </summary>
        Public Property OpposeJack As List(Of Short)
        ''' <summary>
        ''' 引戻しジャッキ
        ''' </summary>
        Public Property PullBackJack As List(Of Short)
            Get
                Return _PullBackJack
            End Get
            Set(value As List(Of Short))
                _PullBackJack = value
                GetReduceJackAndGr()
            End Set
        End Property
        ''' <summary>
        ''' 押込みジャッキ
        ''' </summary>
        Public Property ClosetJack As List(Of Short)
        ''' <summary>
        ''' 追加押込みジャッキ
        ''' </summary>
        Public Property AddClosetJack As List(Of Short)
        ''' <summary>
        ''' 右ローリング押込みジャッキ
        ''' </summary>
        Public Property RightRollingClosetJack As List(Of Short)
        ''' <summary>
        ''' 左ローリング押込みジャッキ
        ''' </summary>
        Public Property LeftRollingClosetJack As List(Of Short)
        ''' <summary>
        ''' 減圧ジャッキ
        ''' </summary>
        ''' <returns></returns>
        Public Property ReduceJack As List(Of Short)
        Public Property ReduceGroup As List(Of Short)

        ''' <summary>
        ''' 引戻しジャッキから
        ''' 減圧グループと減圧ジャッキを演算
        ''' </summary>
        Private Sub GetReduceJackAndGr()
            _ReduceJack = New List(Of Short)
            _ReduceGroup = New List(Of Short)

            Dim Gr As Boolean() = Enumerable.Repeat(Of Boolean)(True, InitParameter.NumberGroup).ToArray()
            Dim Jk(InitParameter.NumberJack - 1) As Boolean
            Dim i As Short
            'リストを配列に
            For i = 0 To _PullBackJack.Count - 1
                Jk(_PullBackJack(i) - 1) = True
            Next
            '引戻しジャッキから減圧グループを
            For i = 0 To InitParameter.NumberJack - 1
                If Not Jk(i) Then
                    Gr(InitParameter.JackGroupPos(i) - 1) = False
                End If
            Next
            '減圧グループリスト作成
            For i = 0 To InitParameter.NumberGroup - 1
                If Gr(i) Then
                    _ReduceGroup.Add(i + 1)
                End If
            Next
            '減圧グループを減圧ジャッキに
            For i = 0 To InitParameter.NumberJack - 1
                If Gr(InitParameter.JackGroupPos(i) - 1) Then
                    _ReduceJack.Add(i + 1)
                End If
            Next


        End Sub



    End Class

    Public Function JackListDsp(t As List(Of Short)) As String
        'データないとき
        If t.Count = 0 Then
            Return "-"
        Else
            Return t(0) & "-" & t(t.Count - 1)

        End If
    End Function



End Class