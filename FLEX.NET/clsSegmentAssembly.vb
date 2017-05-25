'Option Strict On
Option Explicit On
Friend Class clsSegmentAssembly
    ' @(h) clsSegmentMakeData.cls                ver 2.2 ( '06/04/11 近藤　勲 )

    ' @(h) clsSegmentMakeData.cls                ver 1.0 ( '02.10.23 近藤　勲 )
    ''半同時施工のために追加

    ' @(h) clsSegmentMakeData.cls                ver 2.1 ( '04/08/11 近藤　勲 )
    ' 仮リング対応

    Inherits clsDataBase


    ''' <summary>
    ''' 掘進終了時のストローク
    ''' </summary>
    Private _RingLastStroke As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' セグメント組立パターンID リング番号がKey
    ''' </summary>
    Private _SegmentAssenblyPtnID As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' セグメント組立パターン Key:パターンNo Value:パターン名
    ''' </summary>
    Private _AssenblyPtnDic As New Dictionary(Of Short, String)

    ''' <summary>
    ''' セグメントシュミレーションデータより転送した日付
    ''' </summary>
    Private _TransferDate As New Dictionary(Of Integer, DateTime)


    ''' <summary>
    ''' セグメント種類No　 リング番号がKey
    ''' </summary>
    Private _TypeNo As New Dictionary(Of Integer, Short)

    ''' <summary>
    ''' セグメント組立データ  ピース番号がKey
    ''' </summary>
    Private _ProcessData As New Dictionary(Of Short, AsseblyProcess)


    ''' <summary>
    ''' シュミレーションデータのセグメント種類
    ''' </summary>
    Private _TypeNoSim As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' シュミレーションデータのセグメント組立パターンID
    ''' </summary>
    Private _SegmentAssenblyPtnIDSim As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' シュミレーションデータの指示書転送日
    ''' </summary>
    Private _TransferDateSim As New Dictionary(Of Integer, DateTime)


    ''' <summary>
    ''' セグメント種類（タイプ）データ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TypeData(ByVal RingNo As Integer) As SegmentType
        Get
            'If RingNo <> 0 Then
                Return _TypeList(_TypeNo(RingNo))
            'Else
            '    Return New SegmentType
            'End If


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
    ''' <summary>
    ''' 掘進終了のストローク更新
    ''' </summary>
    ''' <param name="RingNo"></param>
    ''' <param name="Stroke"></param>
    Public Sub RingLastStrokeUpdate(RingNo As Integer, Stroke As Short)

        _RingLastStroke(RingNo) = Stroke
        ExecuteSqlCmd($"UPDATE flexセグメント組立データ SET 掘進終了ストローク ='{Stroke}'
            WHERE リング番号 = '{RingNo}'")
    End Sub

    Public ReadOnly Property AssenblyPtnLst As Dictionary(Of Short, String)
        Get
            Return _AssenblyPtnDic
        End Get
    End Property
    ''' <summary>
    ''' 組立ピース数
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AssemblyPieceNumber As Short

    'TODO:データベース書込
    ''' <summary>
    ''' セグメント組立パターン情報読込 ピース番号がKey
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ProcessData As Dictionary(Of Short, AsseblyProcess)
        Get
            Return _ProcessData
        End Get
    End Property
    ''' <summary>
    ''' セグメント種類リスト
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TypeList As New Dictionary(Of Short, SegmentType)


    Public Property SegmentAssenblyPtnID() As Dictionary(Of Integer, Short)
        Get
            Return _SegmentAssenblyPtnID
        End Get
        Set(value As Dictionary(Of Integer, Short))
            _SegmentAssenblyPtnID = value
            'TODO:データベース更新作業
        End Set
    End Property
    ''' <summary>
    ''' 組立パターン名
    ''' </summary>
    ''' <param name="RingNo">リング番号をキーに</param>
    ''' <returns></returns>
    Public ReadOnly Property AssemblyPtnName(RingNo As Integer) As String
        Get
            Return _AssenblyPtnDic(_SegmentAssenblyPtnID(RingNo))
        End Get
    End Property

    Public Property TransferDate() As Dictionary(Of Integer, DateTime)
        Get
            Return _TransferDate
        End Get
        Set(value As Dictionary(Of Integer, DateTime))
            _TransferDate = value
            'TODO:データベース更新作業
        End Set
    End Property


    Public ReadOnly Property TypeDataSim(ByVal RingNo As Integer) As SegmentType
        Get
            Return _TypeList(_TypeNoSim(RingNo))

        End Get
    End Property


    Public ReadOnly Property TypeNo As Dictionary(Of Integer, Short)
        Get
            Return _TypeNo
        End Get
    End Property


    ''' <summary>
    ''' セグメント種類名の列挙　選択用
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TypeNameList As Dictionary(Of Short, String)
        Get
            Dim sLst As New Dictionary(Of Short, String)
            For Each v In _TypeList
                sLst.Add(v.Key, v.Value.TypeName)
            Next
            Return sLst

        End Get
    End Property

    Public Property SegmentAssenblyPtnISim() As Dictionary(Of Integer, Short)
        Get
            Return _SegmentAssenblyPtnIDSim
        End Get
        Set(value As Dictionary(Of Integer, Short))
            _SegmentAssenblyPtnIDSim = value
        End Set
    End Property

    Public ReadOnly Property AssemblyPtnNameSim(RingNo As Integer) As String
        Get
            Return _AssenblyPtnDic(_SegmentAssenblyPtnIDSim(RingNo))
        End Get
    End Property

    Public Property TransferDateSim() As Dictionary(Of Integer, DateTime)
        Get
            Return _TransferDateSim
        End Get
        Set(value As Dictionary(Of Integer, DateTime))
            _TransferDateSim = value
            'TODO:データベース更新作業
        End Set
    End Property

    ''' <summary>
    ''' 組立パターンの情報を取得
    ''' </summary>
    ''' <param name="RingNo">リング番号</param>
    Public Sub AssemblyDataRead(RingNo As Integer)
        _AssenblyPtnDic.Clear()
        'パターンリストの取得
        Dim rsPtLst As DataTable =
            GetDtfmSQL("SELECT 組立パターンNo,組立パターン名 FROM セグメント組立パターンリスト")
        'While rsPtLst.Read
        '    _AssenblyPtnDic.Add(rsPtLst.Item("組立パターンNo"), rsPtLst.Item("組立パターン名"))
        'End While
        'rsPtLst.Close()
        _AssenblyPtnDic =
            rsPtLst.AsEnumerable.ToDictionary(Function(n) CShort(n.Item(0)), Function(n) n.Item(1).ToString)


        ''当該リングのセグメント組立IDを取得
        Dim Id As Short = _SegmentAssenblyPtnID(RingNo)
        '検索

        Dim dsSegAsm As DataTable =
            GetDtfmSQL($"SELECT  * FROM `セグメント組立パターンリスト`  
            Inner Join `セグメント分割仕様リスト` ON `セグメント分割仕様リスト`.`分割No` = `セグメント組立パターンリスト`.`分割No` 
            WHERE `組立パターンNo` = '{Id}'")

        _ProcessData.Clear()

        For Each dRow As DataRow In dsSegAsm.Rows

            For Each Col As DataColumn In dsSegAsm.Columns
                Dim ColName As String = Col.ColumnName

                If ColName.Contains("組立順序") AndAlso Not IsDBNull(dRow(ColName)) Then

                    Dim SegDt As New AsseblyProcess '組み立手順データ

                    SegDt.PatternName = dRow("組立パターン名")
                    SegDt.BoltPitch = dRow("組立ピッチ")


                    Dim AsOrder As Short = dRow(ColName)  '組立順番

                    SegDt.AssemblyOrder = AsOrder

                    Dim PieaceNo As String = GetNum(ColName).ToString
                    If PieaceNo = "1" Then
                        PieaceNo = "K"
                        SegDt.PieceCenterAngle = dRow("基本位置")
                    Else
                        SegDt.PieceCenterAngle = dRow(PieaceNo & "中心")
                    End If

                    SegDt.PieceName = dRow($"{PieaceNo}名称")

                    SegDt.PieceAngle = dRow(PieaceNo & "スパン")

                    SegDt.PieceCenterAngle -= 360 / dRow("ﾎﾞﾙﾄ  数") * dRow("組立ピッチ")

                    'If SegDt.PieceName <> "" Then
                    SegDt.PullBackJack = JkList(dRow($"{AsOrder}引戻"))
                    SegDt.ClosetJack = JkList(dRow($"{AsOrder}押込"))
                    SegDt.AddClosetJack = JkList(dRow($"{AsOrder}追加"))

                    _ProcessData(SegDt.AssemblyOrder) = SegDt

                End If

            Next

        Next

        If _ProcessData.Count = 0 Then
            MsgBox($"{RingNo}リングの組立パターン名'{dsSegAsm.Rows(0).Item("組立パターン名")}の、
組立順序が設定されてません'", vbCritical)
        Else
            '組立ピース数を取得
            _AssemblyPieceNumber = (From i In _ProcessData Select i.Value.AssemblyOrder).Max
        End If






    End Sub
    ''' <summary>
    ''' ジャッキの連続した番号の表記をリスト形式に変換
    ''' 文字位置が１である場合ON
    ''' </summary>
    ''' <param name="tmpS">文字列</param>
    ''' <returns></returns>
    Private Function JkList(ByVal tmpS As String) As List(Of Short)

        Dim lst As New List(Of Short)

        If TypeName(tmpS) = "DBNull" OrElse tmpS = "" Then
            Return lst
        End If

        For i As Short = 0 To tmpS.Length - 1
            If tmpS.Substring(i, 1) = "1" Then
                lst.Add(i + 1)
            End If
        Next

        'Dim i As String() = tmpS.split(",")
        'For Each k As Short In i
        '    lst.Add(k)
        'Next

        Return lst

    End Function

    'TODO:オーバーライドを使いたい！
    'Private Function JkList(ByVal tmpS As DBNull) As List(Of Short)
    '    Return New List(Of Short)
    'End Function
    ''' <summary>
    ''' データベース読込
    ''' </summary>
    Public Sub SegmentRingDataRead()


        Dim rsData As DataTable =
            GetDtfmSQL("SELECT * FROM flexセグメント組立データ order by リング番号")

        'rsData = ExecuteSql _
        '("SELECT * FROM flexセグメント組立データ Inner Join セグメント組立パターンベース")

        For Each t As DataRow In rsData.Rows
            Dim i As Integer = t.Item("リング番号")
            _TypeNo(i) = t.Item("セグメントNo")
            If Not _TypeList.ContainsKey(_TypeNo(i)) Then
                MsgBox($"{i}リングのセグメントNoが未登録です")
            Else
                '_SegmentWidth(i) = _SegmentTypeList(rsData.Item("セグメントNo")).CenterWidth * 1000
            End If
            _RingLastStroke(i) = t.Item("掘進終了ストローク")
            _SegmentAssenblyPtnID(i) = t.Item("組立パターンNo")
            If Not IsDBNull(t.Item("転送日")) Then
                _TransferDate(i) = t.Item("転送日")
            End If
            '_SegmentAssenblyPtn(i) = rsData.Item("組立パターン")

        Next


    End Sub

    ''' <summary>
    ''' セグメント種類読込
    ''' </summary>
    Private Sub SegmentListRead()
        'TODO:データベース更新時に読込
        _TypeList.Clear()

        Dim rsData As DataTable =
            GetDtfmSQL("SELECT * FROM セグメントリスト WHERE 中心幅 IS NOT NULL")

        For Each t As DataRow In rsData.Rows
            Dim st As New SegmentType
            st.TypeName = t.Item("種類")
            st.CenterWidth = t.Item("中心幅")
            st.ETTaper = t.Item("坑口")
            st.TFTaper = t.Item("テーパー量切羽")
            'st.Note = rsData.Item("備考")
            st.OuterDiameter = t.Item("外径")
            st.TaperAngle = t.Item("位置")

            _TypeList.Add(t.Item("セグメントNo"), st)

        Next

        'While rsData.Read
        '    Dim st As New SegmentType
        '    'Dim i As Short = rsData.Item("セグメントNo")
        '    st.TypeName = rsData.Item("種類")
        '    st.CenterWidth = rsData.Item("中心幅")
        '    st.ETTaper = rsData.Item("坑口")
        '    st.TFTaper = rsData.Item("テーパー量切羽")
        '    'st.Note = rsData.Item("備考")
        '    st.OuterDiameter = rsData.Item("外径")
        '    st.TaperAngle = rsData.Item("位置")

        '    _TypeList.Add(rsData.Item("セグメントNo"), st)

        'End While

        'rsData.Close()



    End Sub
    ''' <summary>
    ''' セグメント種類名から情報を取得
    ''' </summary>
    ''' <param name="TpName"></param>
    ''' <returns></returns>
    Public ReadOnly Property GetSegmentType(TpName As String) As SegmentType
        Get
            For Each t In _TypeList
                If t.Value.TypeName = TpName Then Return t.Value
            Next
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' セグメントシュミレーションデータ読込
    ''' </summary>
    Public Sub SegmentSimDataRead()


        Dim rsData As DataTable =
            GetDtfmSQL("SELECT  distinct( リングＮｏ) as  リング番号,組立パターンNo,max(転送日) as 転送日,セグメントNo 
            ,組立パターンNo from `セグメント割付シュミレーション`  group by リングＮｏ order by リングＮｏ asc;")

        'rsData = ExecuteSql _
        '("SELECT * FROM flexセグメント組立データ Inner Join セグメント組立パターンベース")

        For Each t As DataRow In rsData.Rows
            Dim i As Integer = t.Item("リング番号")
            _TypeNoSim(i) = t.Item("セグメントNo")

            _SegmentAssenblyPtnIDSim(i) = t.Item("組立パターンNo")
            If Not IsDBNull(t.Item("転送日")) Then
                _TransferDateSim(i) = t.Item("転送日")
            End If

        Next

    End Sub



    Public Sub SegmentAsemblyDataUpdat(RingNo As Integer, PatternName As String, TypeName As String)
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


        'Dim rsData As Odbc.OdbcDataReader =
        ExecuteSqlCmd($"UPDATE flexセグメント組立データ 
        SET 組立パターンNo ='{GetPtNameID(PatternName)}' 
        ,セグメントNo ='{GetTypeNameId(TypeName)}' WHERE リング番号 = {RingNo};")

        '
    End Sub

    Private Function GetTypeNameId(TpName As String) As Short
        For Each nM In _TypeList
            If nM.Value.TypeName = TpName Then
                Return nM.Key
            End If
        Next
        Return 0
    End Function



    Private Function GetPtNameID(PtName As String) As Short
        For Each pT In _AssenblyPtnDic
            If pT.Value = PtName Then
                Return pT.Key
            End If
        Next
        Return 0
    End Function



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
        Dim rsData As DataTable =
            GetDtfmSQL($"SELECT * FROM  セグメント組立データ WHERE リング番号 = {intRingNo};")

        'rsData.Read()
        ''掘進終了ストロークが0の場合はそのリングのセグメント幅にする
        If Not IsNothing(rsData.Rows(0).Item("掘進終了ストローク")) AndAlso rsData.Rows(0).Item("掘進終了ストローク") <> 0 Then
            Return rsData.Rows(0).Item("掘進終了ストローク")
        Else
            ''更新クエリー実行
            'Dim rsQ As Odbc.OdbcDataReader =
            ExecuteSqlCmd($"UPDATE セグメント組立データ SET 掘進終了ストローク = セグメント幅 WHERE リング番号 = {intRingNo}")

            Return rsData.Rows(0).Item("セグメント幅")
        End If


    End Function



    Private Sub sbPutKussinLastStroke(ByRef intRingNo As Short, ByRef intLastStroke As Short)
        ' @(f)
        '
        ' 機能      :掘進最終ストロークを更新
        '
        ' 03/04/30 追加





    End Sub



    Public Sub New()

        SegmentListRead() 'セグメントリスト読込
        SegmentRingDataRead() ''データベース読込

    End Sub

    ''' <summary>
    ''' 組立手順データ
    ''' </summary>
    Public Class AsseblyProcess
        ''' <summary>
        ''' 組立パターン名
        ''' </summary>
        ''' <returns></returns>
        Public Property PatternName As String
        ''' <summary>
        ''' 組立ボルトピッチ
        ''' </summary>
        ''' <returns></returns>
        Public Property BoltPitch As Single

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
        ''' 甲組乙組の識別
        ''' </summary>
        ''' <returns>０:甲組　１:乙組 どちらでもないとき　-1</returns>
        Public ReadOnly Property PatternKouOtuID As Short
            Get
                If _PatternName.Contains("甲") Then
                    Return 0
                ElseIf _PatternName.Contains("乙") Then
                    Return 1
                Else
                    Return -1
                End If
            End Get
        End Property


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

            Dim Gr As Boolean() = Enumerable.Repeat(Of Boolean)(True, InitPara.NumberGroup).ToArray()
            Dim Jk(InitPara.NumberJack - 1) As Boolean
            Dim i As Short
            'リストを配列に
            For i = 0 To InitPara.NumberJack - 1
                Jk(i) = _PullBackJack.Contains(i + 1)
            Next

            '引戻しジャッキから減圧グループを
            For i = 0 To InitPara.NumberJack - 1
                If Not Jk(i) Then
                    Gr(InitPara.JackGroupPos(i) - 1) = False
                End If
            Next
            '減圧グループリスト作成
            For i = 0 To InitPara.NumberGroup - 1
                If Gr(i) Then
                    _ReduceGroup.Add(i + 1)
                End If
            Next
            '減圧グループを減圧ジャッキに
            For i = 0 To InitPara.NumberJack - 1
                If Gr(InitPara.JackGroupPos(i) - 1) Then
                    _ReduceJack.Add(i + 1)
                End If
            Next


        End Sub



    End Class

    Public Function JackListDsp(t As List(Of Short)) As String
        'データないとき
        If IsNothing(t) OrElse t.Count = 0 Then
            Return "-"
            'データ１つのとき
        ElseIf t.Count = 1 Then
            Return t(0)
        Else
            Return t(0) & "-" & t(t.Count - 1)

        End If
    End Function

    ''' <summary>
    ''' セグメント種類
    ''' </summary>
    Public Class SegmentType
        ''' <summary>
        ''' セグメン種類名称
        ''' </summary>
        ''' <returns></returns>
        Public Property TypeName As String
        ''' <summary>
        ''' セグメント種類ID
        ''' </summary>
        ''' <returns>０:RC１:合成 ２:スチール(鋼)</returns>
        Public ReadOnly Property TypeNameID As Short
            Get
                If _TypeName.Contains("RC") Then
                    Return 0
                ElseIf _TypeName.Contains("合成") Then
                    Return 1
                ElseIf _TypeName.IndexOfAny(New Char() {"鋼", "ST"}) >= 0 Then
                    Return 2
                Else
                    Return -1
                End If
            End Get
        End Property


        ''' <summary>
        ''' セグメント中心幅(m)
        ''' </summary>
        ''' <returns></returns>
        Public Property CenterWidth As Single
        ''' <summary>
        ''' 外径(m)
        ''' </summary>
        ''' <returns></returns>
        Public Property OuterDiameter As Single
        ''' <summary>
        ''' 切羽側テーパー量
        ''' </summary>
        ''' <returns></returns>
        Public Property TFTaper As Single
        ''' <summary>
        ''' 抗口側テーパー量
        ''' </summary>
        ''' <returns></returns>
        Public Property ETTaper As Single
        ''' <summary>
        ''' テーパー位置（dgree)
        ''' </summary>
        ''' <returns></returns>
        Public Property TaperAngle As Single
        ''' <summary>
        ''' 備考
        ''' </summary>
        ''' <returns></returns>
        Public Property Note As String
    End Class




End Class