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
    Private _SheetID As New Dictionary(Of Integer, Integer)


    ''' <summary>
    ''' セグメント種類No　 リング番号がKey
    ''' </summary>
    Private _TypeNo As New Dictionary(Of Integer, Short)

    ''' <summary>
    ''' セグメントローリング
    ''' </summary>
    Private _SegmentRolling As New Dictionary(Of Integer, Single)

    ''' <summary>
    ''' 反時計端側の余裕度(deg)
    ''' </summary>
    Private _AntiClockWiseSegMargin As New Dictionary(Of Integer, Single)
    ''' <summary>
    '''  時計端側の余裕度(deg)
    ''' </summary>
    Private _ClockWiseSegMargin As New Dictionary(Of Integer, Single)
    ''' <summary>
    ''' マシン後胴ローリング
    ''' </summary>
    Private _MachineRearRolling As New Dictionary(Of Integer, Single)


    ''' <summary>
    ''' セグメント組立データ  ピース番号がKey
    ''' </summary>
    Private _ProcessData As New SortedDictionary(Of Short, AsseblyProcess)


    ''' <summary>
    ''' シュミレーションデータのセグメント種類
    ''' </summary>
    Private _TypeNoSim As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' シュミレーションデータのセグメント組立パターンID
    ''' </summary>
    Private _SegmentAssenblyPtnIDSim As New Dictionary(Of Integer, Short)
    ''' <summary>
    ''' シュミレーションデータのSheetID
    ''' </summary>
    Private _SheetIDSim As New Dictionary(Of Integer, Integer)

    ''' <summary>
    ''' シュミレーションデータの指示書転送日
    ''' </summary>
    Private _TransferDate As New Dictionary(Of Integer, Date)
    ''' <summary>
    ''' ローリング考慮が有効かどうか
    ''' </summary>
    Private rollingMind As Boolean
    ''' <summary>
    ''' 各リングのローリング考慮有効か
    ''' </summary>
    Private _rollingMindEnable As New Dictionary(Of Integer, Boolean)


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
    ''' ローリング考慮有効か
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property rollingMindEnable As Dictionary(Of Integer, Boolean)
        Get
            Return _rollingMindEnable
        End Get
    End Property


    ''' <summary>
    ''' セグメントローリング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SegmentRolling As Dictionary(Of Integer, Single)
        Get
            Return _SegmentRolling
        End Get
    End Property
    ''' <summary>
    ''' 反時計端側の余裕度(deg)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AntiClockWiseSegMargin As Dictionary(Of Integer, Single)
        Get
            Return _AntiClockWiseSegMargin
        End Get
    End Property
    ''' <summary>
    ''' 時計端側の余裕度(deg)
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ClockWiseSegMargin As Dictionary(Of Integer, Single)
        Get
            Return _ClockWiseSegMargin
        End Get
    End Property
    ''' <summary>
    ''' マシン後胴ローリング
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MachineRearRolling As Dictionary(Of Integer, Single)
        Get
            Return _MachineRearRolling
        End Get
    End Property



    ''' <summary>
    ''' 掘進終了のストローク更新
    ''' </summary>
    ''' <param name="RingNo"></param>
    ''' <param name="Stroke"></param>
    Public Sub RingLastStrokeUpdate(RingNo As Integer, Stroke As Integer)
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
    ''' 組立計画ピース数
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property AssemblyPlanPieceNumber As Short

    'TODO:データベース書込
    ''' <summary>
    ''' セグメント組立パターン情報読込 ピース番号がKey
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ProcessData As SortedDictionary(Of Short, AsseblyProcess)
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
            If _AssenblyPtnDic.ContainsKey(_SegmentAssenblyPtnID(RingNo)) Then
                Return _AssenblyPtnDic(_SegmentAssenblyPtnID(RingNo))
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property SheetID() As Dictionary(Of Integer, Integer)
        Get
            Return _SheetID
        End Get
        Set(value As Dictionary(Of Integer, Integer))
            _SheetID = value
            'TODO:データベース更新作業
        End Set
    End Property


    Public ReadOnly Property TypeDataSim(ByVal RingNo As Integer) As SegmentType
        Get
            Try
                Return _TypeList(_TypeNoSim(RingNo))

            Catch ex As Exception
                Return Nothing
            End Try

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
            Try
                Return _AssenblyPtnDic(_SegmentAssenblyPtnIDSim(RingNo))
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public Property SheetIDSim() As Dictionary(Of Integer, Integer)
        Get
            Return _SheetIDSim
        End Get
        Set(value As Dictionary(Of Integer, Integer))
            _SheetIDSim = value
            'TODO:データベース更新作業
        End Set
    End Property

    Public Property TransferDate() As Dictionary(Of Integer, Date)
        Get
            Return _TransferDate
        End Get
        Set(value As Dictionary(Of Integer, Date))
            _TransferDate = value
            'TODO:データベース更新作業
        End Set
    End Property




    ''' <summary>
    ''' 組立パターンの情報を取得
    ''' </summary>
    ''' <param name="RingNo">リング番号</param>
    Public Sub AssemblyDataRead(RingNo As Integer)

        'ロスゼロのみ
        If Not InitPara.LosZeroEquip Then Exit Sub
        _AssenblyPtnDic.Clear()
        'パターンリストの取得
        Dim rsPtLst As DataTable =
            GetDtfmSQL("SELECT 組立パターンNo,組立パターン名 FROM セグメント組立パターンリスト")

        _AssenblyPtnDic =
            rsPtLst.AsEnumerable.ToDictionary(Function(n) CShort(n.Item(0)), Function(n) n.Item(1).ToString)

        Dim SheetID As DataTable =
            GetDtfmSQL($"SELECT  `flexセグメント組立データ`.`シートID` FROM `flexセグメント組立データ` LEFT OUTER JOIN `セグメント割付シュミレーション`
             ON  `セグメント割付シュミレーション`.`シートID` = `flexセグメント組立データ`.`シートID`
            WHERE `リング番号`='{RingNo}'")
        'Dim TransferDate As Object =
        'GetDtfmSQL($"SELECT DATE_FORMAT( 転送日,'%Y/%m/%d %H:%i:%S') FROM flexセグメント組立データ 
        '    WHERE リング番号='{RingNo}'").Rows(0).Item(0)

        '検索
        Dim dsSegAsm As DataTable

        If SheetID.Rows.Count = 0 OrElse IsDBNull(SheetID.Rows(0).Item(0)) Then
            dsSegAsm =
              GetDtfmSQL($"SELECT  * FROM `セグメント組立パターンリスト`  
            Inner Join `セグメント分割仕様リスト` ON `セグメント分割仕様リスト`.`分割No` = `セグメント組立パターンリスト`.`分割No` 
            WHERE `組立パターンNo` = '{_SegmentAssenblyPtnID(RingNo)}'")
        Else
            '線形管理のセグメント割付シュミレーションで転送済みの場合
            dsSegAsm =
              GetDtfmSQL($"SELECT  * FROM `セグメント割付シュミレーション`  
            Inner Join `セグメント分割仕様リスト` ON `セグメント分割仕様リスト`.`分割No` = `セグメント割付シュミレーション`.`分割No` 
            WHERE `リングＮｏ` = '{RingNo}' AND `シートID`='{SheetID.Rows(0).Item(0)}'")

        End If

        'Dim RollinEn As Boolean = dsSegAsm.Columns.Contains("時計端差異") And dsSegAsm.Columns.Contains("反時計端差異")

        _ProcessData.Clear()

        For Each dRow As DataRow In dsSegAsm.Rows

            'RollinEn = RollinEn And Not IsDBNull(dRow("SGローリング")) And
            '    Not IsDBNull(dRow("MRローリング")) And Not IsDBNull(dRow("時計端差異")) And Not IsDBNull(dRow("反時計端差異"))

            For Each Col As DataColumn In dsSegAsm.Columns
                Dim ColName As String = Col.ColumnName

                If ColName.Contains("組立順序") AndAlso Not IsDBNull(dRow(ColName)) Then



                    Dim SegDt As New AsseblyProcess '組み立手順データっｘ


                    SegDt.PatternName = dRow("組立パターン名")
                    SegDt.BoltPitch = dRow("組立ピッチ")

                    'SegDt.MarginEnable = RollinEn

                    'If SegDt.MarginEnable Then
                    '    SegDt.SegmentRolling = dRow("SGローリング")
                    '    SegDt.MachineRearRolling = dRow("MRローリング")
                    '    SegDt.ClockWiseSegMargin = dRow("時計端差異")
                    '    SegDt.AntiClockWiseSegMargin = dRow("反時計端差異")
                    'End If



                    Dim AsOrder As Short = dRow(ColName)  '組立順番

                    SegDt.AssemblyOrder = AsOrder

                    Dim PieaceNo As String = GetNum(ColName).ToString

                    If PieaceNo <= dRow("ピース数") Then


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
                        SegDt.ThrustJack = JkList(dRow($"{AsOrder}推進"))
                        SegDt.AddClosetJack = JkList(dRow($"{AsOrder}追加"))

                        _ProcessData(SegDt.AssemblyOrder) = SegDt
                    End If

                End If
            Next
        Next

        '同時施工タイプ
        If InitPara.LosZeroEquip Then

            '減圧グループの算出
            For Each PrsDt In _ProcessData

                Dim i As Short
                'リストを配列に

                '前ピースまでの引き戻しジャッキと押し込みジャッキと追加押込ジャッキをリストに
                Dim PujJ As New List(Of Short), ClosetJ As New List(Of Short)
                For Each pd In _ProcessData
                    If pd.Key < PrsDt.Key Then
                        PujJ.AddRange(pd.Value.PullBackJack)
                        ClosetJ.AddRange(pd.Value.ClosetJack)
                        ClosetJ.AddRange(pd.Value.AddClosetJack)
                    End If
                Next

                Dim PulPreJk As New List(Of Short)    '前ピースまでのの引き戻しジャッキ

                '前ピースまでのの引き戻しジャッキで押し込んでないジャッキ
                For Each pl In PujJ
                    If Not ClosetJ.Contains(pl) Then
                        PulPreJk.Add(pl)
                    End If
                Next

                '上述のジャッキの属するグループと現ピースの引き戻しジャッキの属するグループが等しい場合に
                '含める
                Dim AddRdJk As New List(Of Short)
                For Each t In PrsDt.Value.PullBackJack
                    For Each k In PulPreJk
                        If InitPara.JackGroupPos(k - 1) = InitPara.JackGroupPos(t - 1) Then
                            AddRdJk.Add(k)
                        End If
                    Next
                Next

                '減圧グループ　すべてTRUEに
                Dim Gr As Boolean() =
                    Enumerable.Repeat(Of Boolean)(True, InitPara.NumberGroup).ToArray()

                '引戻しジャッキ(Kの場合は追加押込み)から減圧グループを
                Dim rd As List(Of Short)
                If PrsDt.Value.PieceName = "K" Then

                    rd = New List(Of Short)(PrsDt.Value.ThrustJack)
                Else
                    rd = New List(Of Short)(PrsDt.Value.PullBackJack)

                End If

                For i = 1 To InitPara.NumberJack
                    If Not (rd.Contains(i) Or AddRdJk.Contains(i)) Then
                        Gr(InitPara.JackGroupPos(i - 1) - 1) = False
                    End If
                Next
                '減圧グループリスト作成
                PrsDt.Value.ReduceGroup = New List(Of Short)
                PrsDt.Value.ReduceJack = New List(Of Short)

                For i = 0 To InitPara.NumberGroup - 1
                    If Gr(i) Then
                        PrsDt.Value.ReduceGroup.Add(i + 1)
                    End If
                Next

                '減圧グループを減圧ジャッキに
                For i = 1 To InitPara.NumberJack
                    If Gr(InitPara.JackGroupPos(i - 1) - 1) Then
                        PrsDt.Value.ReduceJack.Add(i)
                    End If
                Next

                '***********減圧グループから対抗グループを算出する************** 
                If PrsDt.Value.ReduceGroup.Count <> 0 And CtlPara.LosZeroOpposeControl And CtlPara.LosZeroOpposeGroupNumber <> 0 Then

                    '減圧グループの中心角度を求める
                    Dim GpCenterAngle As New List(Of Single)
                    For Each Gp In PrsDt.Value.ReduceGroup
                        GpCenterAngle.Add(InitPara.FaiGroup(Gp - 1))
                    Next
                    '対抗グループの中心角度+180度
                    Dim OppseAngle As Single = GetDegAv(GpCenterAngle) + 180 'GpCenterAngle.Average + 180
                    If OppseAngle > 360 Then OppseAngle -= 360
                    Dim AnglDiff As New Dictionary(Of Short, Single)
                    For i = 1 To InitPara.NumberGroup
                        '各グループからの対抗グループ設定数分の平均角度を算出
                        Dim AvDg As New List(Of Single)
                        For Each g As Short In GetGpLst(i)
                            AvDg.Add(InitPara.FaiGroup(g - 1))
                        Next
                        '各グループの中心角度との絶対値差を求める
                        AnglDiff.Add(i, Math.Abs(Hoi2Hoko(GetDegAv(AvDg) - OppseAngle)))
                    Next
                    '最小値の先頭グループNoを取得
                    Dim StartG As Short = (From q In AnglDiff Order By q.Value Select q.Key).First
                    '対抗グループのリスト取得
                    PrsDt.Value.OpposeGroup = GetGpLst(StartG)
                End If
            Next

            If _ProcessData.Count = 0 Then
                'MsgBox($"{RingNo}リングの組立パターン名'{dsSegAsm.Rows(0).Item("組立パターン名")}の、組立順序が設定されてません'", vbCritical)
            Else
                '組立ピース数を取得
                _AssemblyPlanPieceNumber = (From i In _ProcessData Select i.Value.AssemblyOrder).Max
            End If

        End If

    End Sub





    ''' <summary>
    ''' ジャッキの連続した番号の表記をリスト形式に変換
    ''' 文字位置が１である場合ON
    ''' </summary>
    ''' <param name="tmpS">文字列</param>
    ''' <returns></returns>
    Overloads Function JkList(ByVal tmpS As String) As List(Of Short)

        Dim lst As New List(Of Short)

        'If TypeName(tmpS) = "DBNull" OrElse tmpS = "" Then
        '    Return lst
        'End If

        For i As Short = 0 To tmpS.Length - 1
            If tmpS.Substring(i, 1) = "1" Then
                lst.Add(i + 1)
            End If
        Next

        Return lst

    End Function

    'TODO:オーバーライドを使いたい！
    Overloads Function JkList(ByVal tmpS As DBNull) As List(Of Short)
        Return New List(Of Short)
    End Function
    ''' <summary>
    ''' データベース読込
    ''' </summary>
    Public Sub SegmentRingDataRead()

        SegmentListRead() 'セグメントリスト読込
        'ローリング考慮の場合の追加フィールド
        Dim RollAdFld As String = ""
        If rollingMind Then
            RollAdFld = ",`セグメント割付シュミレーション`.`SGローリング`,`セグメント割付シュミレーション`.`MRローリング`,
            `セグメント割付シュミレーション`.`反時計端差異`,`セグメント割付シュミレーション`.`時計端差異`"
        End If


        Dim rsData As DataTable =
            GetDtfmSQL($"select  `flexセグメント組立データ`.`シートID`, `flexセグメント組立データ`.`リング番号`, `flexセグメント組立データ`.`セグメントNo` ,
            `flexセグメント組立データ`.`組立パターンNo`,`flexセグメント組立データ`.`掘進終了ストローク`,
            `セグメント割付シュミレーション`.`セグメントNo`,`セグメント割付シュミレーション`.`組立パターンNo`  ,`セグメント割付シュミレーション`.`シートID`{RollAdFld}   
            FROM `flexセグメント組立データ`
            LEFT OUTER JOIN `セグメント割付シュミレーション` ON `flexセグメント組立データ`.`シートID`=`セグメント割付シュミレーション`.`シートID`
            AND `flexセグメント組立データ`.`リング番号`=`セグメント割付シュミレーション`.`リングＮｏ` ORDER BY `リング番号`")


        For Each tb As DataRow In rsData.Rows
            Dim RingNo As Integer = tb.Item("リング番号")

            If Not IsNumeric(tb.Item("シートID")) Or Not IsNumeric(tb.Item("シートID1")) Then
                _TypeNo(RingNo) = tb.Item("セグメントNo")

                If InitPara.LosZeroEquip Then
                    _SegmentAssenblyPtnID(RingNo) = tb.Item("組立パターンNo")
                End If

            Else
                _TypeNo(RingNo) = tb.Item("セグメントNo1")
                If InitPara.LosZeroEquip Then
                    _SegmentAssenblyPtnID(RingNo) = tb.Item("組立パターンNo1")
                    _rollingMindEnable(RingNo) =
                        rollingMind And Not IsDBNull(tb.Item("時計端差異")) And Not IsDBNull(tb.Item("反時計端差異")) And Not IsDBNull(tb.Item("MRローリング")) And Not IsDBNull(tb.Item("SGローリング"))


                    If _rollingMindEnable(RingNo) Then
                        _ClockWiseSegMargin(RingNo) = tb.Item("時計端差異")
                        _AntiClockWiseSegMargin(RingNo) = tb.Item("反時計端差異")
                        _MachineRearRolling(RingNo) = tb.Item("MRローリング")
                        _SegmentRolling(RingNo) = tb.Item("SGローリング")
                    End If

                End If
            End If
            '_TypeNo(i) = t.Item("セグメントNo")
            If Not _TypeList.ContainsKey(_TypeNo(RingNo)) Then
                MsgBox($"{RingNo}リングのセグメントNo[{_TypeNo(RingNo)}]が未登録です")
            Else
                '_SegmentWidth(i) = _SegmentTypeList(rsData.Item("セグメントNo")).CenterWidth * 1000
            End If
            If IsDBNull(tb.Item("シートID")) Then
                SheetID.Remove(RingNo)
            Else
                _SheetID(RingNo) = tb.Item("シートID")
            End If


            _RingLastStroke(RingNo) = tb.Item("掘進終了ストローク")

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
            If Not IsDBNull(t.Item("位置")) Then
                st.TaperAngle = t.Item("位置")
            End If

            _TypeList.Add(t.Item("セグメントNo"), st)

        Next


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

        '割り付けシュミレーションで転送日の最新のレコードをリング番号ごとに取得        
        Dim rsData As DataTable =
            GetDtfmSQL("SELECT リングＮｏ,セグメントNo,組立パターンNo,転送日,シートID FROM `セグメント割付シュミレーション` AS m WHERE `転送日`= (SELECT max(`転送日`)
            FROM `セグメント割付シュミレーション` AS s WHERE m.`リングＮｏ` = s.`リングＮｏ`) order by `リングＮｏ`;")


        For Each t As DataRow In rsData.Rows
            Dim RingNo As Integer = t.Item("リングＮｏ")
            _TypeNoSim(RingNo) = t.Item("セグメントNo")
            If Not IsDBNull(t.Item("組立パターンNo")) Then
                _SegmentAssenblyPtnIDSim(RingNo) = t.Item("組立パターンNo")
            End If

            If Not IsDBNull(t.Item("転送日")) Then
                _SheetIDSim(RingNo) = t.Item("シートID")
                _TransferDate(RingNo) = t.Item("転送日")
            End If

        Next

    End Sub



    Public Sub SegmentAsemblyDataUpdat(RingNo As Integer, PatternName As String, TypeName As String, SheetID As String)
        ' @(f)  
        '
        ' 機能      :データ更新
        '
        ' 返り値    :
        '
        '
        If IsNothing(SheetID) Then
            SheetID = "NULL"
        Else
            SheetID = "'" & SheetID & "'"
        End If

        ExecuteSqlCmd($"UPDATE flexセグメント組立データ 
        SET 組立パターンNo ='{GetPtNameID(PatternName)}' 
        ,セグメントNo ='{GetTypeNameId(TypeName)}'
        ,シートID ={SheetID}
        WHERE リング番号 = {RingNo};")

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
        'コラム名に情報を取得し時計端差異,反時計端差異が存在するかどうか判断し
        'ローリング考慮ありなしのセット
        Dim tt As Integer = GetDtfmSQL($"SHOW columns from `セグメント割付シュミレーション`").Select("Field='時計端差異'
            or Field='反時計端差異'").Length
        rollingMind = (tt = 2)

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

        ''''' <summary>
        ''''' 余裕度の入力あるかどうか
        ''''' </summary>
        ''''' <returns></returns>
        ''Public Property MarginEnable As Boolean


        ''''' <summary>
        ''''' 時計端側の余裕度(deg)
        ''''' </summary>
        ''''' <returns></returns>
        ''Public Property ClockWiseSegMargin As Single


        ''''' <summary>
        ''''' セグメントローリング
        ''''' </summary>
        ''''' <returns></returns>
        ''Public Property SegmentRolling As Single


        ''''' <summary>
        ''''' マシン後胴ローリング
        ''''' </summary>
        ''''' <returns></returns>
        ''Public Property MachineRearRolling As Single


        ''''' <summary>
        ''''' 反時計端側の余裕度(deg)
        ''''' </summary>
        ''''' <returns></returns>
        ''Public Property AntiClockWiseSegMargin As Single




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
        ''' 対抗グループ
        ''' </summary>
        Public Property OpposeGroup As List(Of Short)
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
        ''' 推進ジャッキ
        ''' </summary>
        ''' <returns></returns>
        Public Property ThrustJack As List(Of Short)

        ''' <summary>
        ''' 押込推進ジャッキ
        ''' 推進ジャッキから追加押込みを除外したジャッキ
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ClosetThrustJack As List(Of Short)
            Get
                Dim CloseTJ As List(Of Short) = New List(Of Short)(_ThrustJack)
                CloseTJ.RemoveAll(AddressOf AddClosetJack.Contains)
                Return CloseTJ
            End Get
        End Property

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

            '減圧グループから対抗グループを算出する
            If _ReduceGroup.Count > 0 And CtlPara.LosZeroOpposeGroupNumber > 0 Then
                '減圧グループの中心角度を求める
                Dim GpCenterAngle As New List(Of Single)
                For Each Gp In _ReduceGroup
                    GpCenterAngle.Add(InitPara.FaiGroup(Gp - 1))
                Next
                '対抗グループの中心角度+180度
                Dim OppseAngle As Single = GetDegAv(GpCenterAngle) + 180 'GpCenterAngle.Average + 180
                If OppseAngle > 360 Then OppseAngle -= 360
                Dim AnglDiff As New Dictionary(Of Short, Single)
                For i = 1 To InitPara.NumberGroup
                    '各グループからの対抗グループ設定数分の平均角度を算出
                    Dim AvDg As New List(Of Single)
                    For Each g As Short In GetGpLst(i)
                        AvDg.Add(InitPara.FaiGroup(g - 1))
                    Next
                    '各グループの中心角度との絶対値差を求める
                    AnglDiff.Add(i, Math.Abs(Hoi2Hoko(GetDegAv(AvDg) - OppseAngle)))
                Next
                '最小値の先頭グループNoを取得
                Dim StartG As Short = (From q In AnglDiff Order By q.Value Select q.Key).First
                '対抗グループのリスト取得
                _OpposeGroup = GetGpLst(StartG)
                ''対抗グループ
                '_OpposeGroup =
                '    (From q In AnglDiff Order By q.Value Descending Select q.Key).Take(CtlPara.LosZeroOpposeGroupNumber).ToList

            Else
                _OpposeGroup = New List(Of Short)
            End If



        End Sub


        ''' <summary>
        ''' 角度の平均を取得
        ''' </summary>
        ''' <param name="Dg"></param>
        ''' <returns></returns>
        Private Function GetDegAv(Dg As List(Of Single)) As Single
            Dim LstX As New List(Of Single), LstY As New List(Of Single)

            For Each EaDg In Dg
                LstX.Add(Math.Cos(EaDg * Math.PI / 180))
                LstY.Add(Math.Sin(EaDg * Math.PI / 180))
            Next
            Return Math.Atan2(LstY.Average, LstX.Average) * 180 / Math.PI
        End Function

        ''' <summary>
        ''' 開始グループからの対抗グループ数のグループのリストを取得
        ''' </summary>
        ''' <param name="StartG">開始グループ</param>
        ''' <returns>グループのリスト</returns>
        Private Function GetGpLst(StartG As Short) As List(Of Short)
            Dim GpLst As New List(Of Short)
            For g As Short = StartG To StartG + CtlPara.LosZeroOpposeGroupNumber - 1
                If g > InitPara.NumberGroup Then
                    GpLst.Add(g - InitPara.NumberGroup)
                Else
                    GpLst.Add(g)
                End If
            Next
            Return GpLst
        End Function




    End Class

    Public Function JackListDsp(t As List(Of Short)) As String
        'データないとき
        If IsNothing(t) OrElse t.Count = 0 Then
            Return "-"
            'データ１つのとき
        ElseIf t.Count = 1 Then
            Return t(0)
        Else
            '１番と最終番号のジャッキが含まれてる場合
            If t.Contains(1) And t.Contains(InitPara.NumberJack) Then
                Dim st As Integer = 1
                Do While t.Contains(st + 1)
                    st += 1
                Loop
                Dim la As Integer = InitPara.NumberJack
                Do While t.Contains(la - 1)
                    la -= 1
                Loop

                Return la & "-" & st



            Else
                Return t(0) & "-" & t(t.Count - 1)
            End If



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

    'todo:同じ処理がこのファイルのクラス内あるので共通化したい

    ''' <summary>
    ''' 角度の平均を取得
    ''' </summary>
    ''' <param name="Dg"></param>
    ''' <returns></returns>
    Private Function GetDegAv(Dg As List(Of Single)) As Single
        Dim LstX As New List(Of Single), LstY As New List(Of Single)

        For Each EaDg In Dg
            LstX.Add(Math.Cos(EaDg * Math.PI / 180))
            LstY.Add(Math.Sin(EaDg * Math.PI / 180))
        Next
        Return Math.Atan2(LstY.Average, LstX.Average) * 180 / Math.PI
    End Function

    ''' <summary>
    ''' 開始グループからの対抗グループ数のグループのリストを取得
    ''' </summary>
    ''' <param name="StartG">開始グループ</param>
    ''' <returns>グループのリスト</returns>
    Private Function GetGpLst(StartG As Short) As List(Of Short)
        Dim GpLst As New List(Of Short)
        For g As Short = StartG To StartG + CtlPara.LosZeroOpposeGroupNumber - 1
            If g > InitPara.NumberGroup Then
                GpLst.Add(g - InitPara.NumberGroup)
            Else
                GpLst.Add(g)
            End If
        Next
        Return GpLst
    End Function

End Class