
Public Class frmSegmentEdit
    ''' <summary>
    ''' 更新した行
    ''' </summary>
    Private lstChangeRow As New List(Of Integer)
    'コピーするリング番号の最初と最後
    Private CopyStartRing As Integer
    Private CopyLastRing As Integer

    Public Sub New()


        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        RemoveHandler DgvSegAssign.CellValueChanged, AddressOf DgvSegAssign_CellValueChanged

        'セグメント種類のコンボボックス選択用
        For Each i In SegAsmblyData.TypeNameList
            CType(DgvSegAssign.Columns("SegmentType"), DataGridViewComboBoxColumn).Items.Add(i.Value)
        Next

        'If InitPara.LosZeroMode Then
        '組立パターンのコンボボックス選択用
        For Each i In SegAsmblyData.AssenblyPtnLst
                CType(DgvSegAssign.Columns("AssemblyPtnName"), DataGridViewComboBoxColumn).Items.Add(i.Value)
            Next
        'End If

        'データ読み込み
        SegAsmblyData.SegmentRingDataRead()
        'セグメントシュミレーションデータ読込
        SegAsmblyData.SegmentSimDataRead()

        Dim SimDgvRow As Integer = 0
        For i As Integer = 0 To SegAsmblyData.TypeNo.Count - 1
            DgvSegAssign.Rows.Add()
            Dim RingNo As Integer = SegAsmblyData.TypeNo.Keys(i)
            DgvSegAssign("RingNo", i).Value = RingNo
            If Not IsNothing(SegAsmblyData.TypeData(RingNo)) Then
                DgvSegAssign("SegmentType", i).Value = SegAsmblyData.TypeData(RingNo).TypeName 'セグメント種類
                DgvSegAssign("SegWidth", i).Value = SegAsmblyData.TypeData(RingNo).CenterWidth * 1000 'セグメント幅
            End If
            If InitPara.LosZeroEquip Then
                DgvSegAssign("AssemblyPtnName", i).Value = SegAsmblyData.AssemblyPtnName(RingNo) '組立パターン名
            End If


            'シュミレーションデータに当該リングのデータが存在するか
            If SegAsmblyData.SheetIDSim.ContainsKey(RingNo) Then
                'SheetIDの比較

                If SegAsmblyData.SheetID.ContainsKey(RingNo) AndAlso
                    SegAsmblyData.SheetID(RingNo) = SegAsmblyData.SheetIDSim(RingNo) Then
                    '同じ日付は転送済み
                    DgvSegAssign("TransferSet", i).Value = "●"
                Else
                    '新しいデータ
                    DgvSegAssign("TransferSet", i).Value = "☓"
                    DgvSegSim.Rows.Add()
                    DgvSegSim("RingNoSim", SimDgvRow).Value = RingNo
                    If Not IsNothing(SegAsmblyData.TypeDataSim(RingNo)) Then
                        DgvSegSim("SegmentTypeSim", SimDgvRow).Value =
                        SegAsmblyData.TypeDataSim(RingNo).TypeName 'セグメント種類

                    End If
                    If InitPara.LosZeroEquip Then
                        DgvSegSim("AssemblyPtnNameSim", SimDgvRow).Value =
                            SegAsmblyData.AssemblyPtnNameSim(RingNo) '組立パターン名
                    End If

                    DgvSegSim("SheetIDSim", SimDgvRow).Value = SegAsmblyData.SheetIDSim(RingNo) 'SheetID
                    DgvSegSim("TransferDate", SimDgvRow).Value = SegAsmblyData.TransferDate(RingNo).ToString("MM月dd日") 'SheetID
                    DgvSegSim("TransferDate", SimDgvRow).ToolTipText = SegAsmblyData.TransferDate(RingNo).ToString("yyyy年MM月dd日thh時mm分ss秒") 'SheetID

                    SimDgvRow += 1
                End If
            End If

        Next

        '表示位置の設定
        DgvSegAssign.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegAssign.Rows Where gg.Cells("RingNo").Value = PlcIf.RingNo Select gg.Cells.Item(0))(0)
        DgvSegSim.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegSim.Rows Where gg.Cells("RingNoSim").Value >= PlcIf.RingNo Select gg.Cells.Item(0))(0)

        AddHandler DgvSegAssign.CellValueChanged, AddressOf DgvSegAssign_CellValueChanged

    End Sub
    ''' <summary>
    ''' 変更した行のデータを更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnApply.Click


        For Each i In lstChangeRow.Distinct
            Dim RingNo As Integer = DgvSegAssign("RingNo", i).Value
            Dim PtName As String = DgvSegAssign("AssemblyPtnName", i).Value
            Dim TpName As String = DgvSegAssign("SegmentType", i).Value
            Dim SheetID As String = DgvSegAssign("SheetID", i).Value
            SegAsmblyData.SegmentAsemblyDataUpdat(RingNo, PtName, TpName, SheetID)

        Next

        If sender Is btnApply Then
            DspUp()
        Else

            Me.Close()
        End If

    End Sub
    ''' <summary>
    ''' 適用時の画面更新
    ''' </summary>
    Private Sub DspUp()

        SegAsmblyData.SegmentRingDataRead()

        Dim SimDgvRow As Integer = 0
        DgvSegSim.Rows.Clear()

        For i As Integer = 0 To SegAsmblyData.TypeNo.Count - 1
            Dim RingNo As Integer = SegAsmblyData.TypeNo.Keys(i)
            DgvSegAssign("RingNo", i).Value = RingNo
            DgvSegAssign("SegmentType", i).Value = SegAsmblyData.TypeData(RingNo).TypeName 'セグメント種類
            DgvSegAssign("SegWidth", i).Value = SegAsmblyData.TypeData(RingNo).CenterWidth * 1000 'セグメント幅
            If InitPara.LosZeroEquip Then
                DgvSegAssign("AssemblyPtnName", i).Value = SegAsmblyData.AssemblyPtnName(RingNo) '組立パターン名
            End If

            'シュミレーションデータに当該リングのデータが存在するか
            If SegAsmblyData.SheetIDSim.ContainsKey(RingNo) Then
                'SheetIDの比較

                If SegAsmblyData.SheetID.ContainsKey(RingNo) AndAlso
                    SegAsmblyData.SheetID(RingNo) = SegAsmblyData.SheetIDSim(RingNo) Then
                    '同じ日付は転送済み
                    DgvSegAssign("TransferSet", i).Value = "●"
                Else
                    '新しいデータ
                    DgvSegAssign("TransferSet", i).Value = "☓"
                    DgvSegSim.Rows.Add()
                    DgvSegSim("RingNoSim", SimDgvRow).Value = RingNo
                    DgvSegSim("SegmentTypeSim", SimDgvRow).Value =
                        SegAsmblyData.TypeDataSim(RingNo).TypeName 'セグメント種類
                    If InitPara.LosZeroEquip Then
                        DgvSegSim("AssemblyPtnNameSim", SimDgvRow).Value =
                            SegAsmblyData.AssemblyPtnNameSim(RingNo) '組立パターン名
                    End If

                    DgvSegSim("SheetIDSim", SimDgvRow).Value = SegAsmblyData.SheetIDSim(RingNo) 'SheetID
                    DgvSegSim("TransferDate", SimDgvRow).Value = SegAsmblyData.TransferDate(RingNo).ToString("MM月dd日") 'SheetID
                    DgvSegSim("TransferDate", SimDgvRow).ToolTipText = SegAsmblyData.TransferDate(RingNo).ToString("yyyy年MM月dd日thh時mm分ss秒") 'SheetID

                    SimDgvRow += 1
                End If
            End If

        Next

        '表示位置の設定
        DgvSegAssign.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegAssign.Rows Where gg.Cells("RingNo").Value = PlcIf.RingNo Select gg.Cells.Item(0))(0)
        DgvSegSim.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegSim.Rows Where gg.Cells("RingNoSim").Value >= PlcIf.RingNo Select gg.Cells.Item(0))(0)

    End Sub


    Private Sub DgvSegAssign_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSegAssign.CellValueChanged, DgvSegAssign.CellClick

        If e.RowIndex <> -1 Then
            '変更した行をリストに追加
            lstChangeRow.Add(e.RowIndex)
            'セグメント幅を更新
            If e.ColumnIndex = 1 Then
                DgvSegAssign("SegWidth", e.RowIndex).Value =
                    SegAsmblyData.GetSegmentType(DgvSegAssign(e.ColumnIndex, e.RowIndex).Value).CenterWidth * 1000
            End If
        End If
    End Sub

    Private Sub DgvSegAssign_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvSegAssign.CurrentCellDirtyStateChanged
        'combbox変更時にCellValueChangedイベントが発生するようにする
        DgvSegAssign.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub frmSegmentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' コピーする範囲の行インデックスを取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmCopy_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click

        CopyStartRing =
            (From i As DataGridViewRow In DgvSegAssign.SelectedRows Select i.Index).Min
        CopyLastRing =
            (From i As DataGridViewRow In DgvSegAssign.SelectedRows Select i.Index).Max


        tsmPaste.Enabled = True
        tsmPtternPaste.Enabled = True

    End Sub
    ''' <summary>
    ''' コピーしたデータを貼り付け
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmPaste_Click(sender As Object, e As EventArgs) Handles tsmPaste.Click
        'コピーするデータを取得
        Dim PtName As New List(Of String), TypeName As New List(Of String)
        For i As Integer = CopyStartRing To CopyLastRing
            TypeName.Add(DgvSegAssign("SegmentType", i).Value)
            PtName.Add(DgvSegAssign("AssemblyPtnName", i).Value)
        Next
        '貼り付けする位置を取得
        Dim PasetPos As Integer =
            (From i As DataGridViewRow In DgvSegAssign.SelectedRows Select i.Index).Min
        'データ貼り付け
        For i As Integer = 0 To PtName.Count - 1
            DgvSegAssign("SegmentType", PasetPos).Value = TypeName(i) 'セグメント種類
            DgvSegAssign("AssemblyPtnName", PasetPos).Value = PtName(i)  'セグメント種類
            PasetPos += 1
        Next

    End Sub
    ''' <summary>
    ''' パターン貼り付け
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmPtternPaste_Click(sender As Object, e As EventArgs) Handles tsmPtternPaste.Click
        'コピーするデータを取得
        Dim PtName As New List(Of String), TypeName As New List(Of String)
        For i As Integer = CopyStartRing To CopyLastRing
            TypeName.Add(DgvSegAssign("SegmentType", i).Value)
            PtName.Add(DgvSegAssign("AssemblyPtnName", i).Value)
        Next

        Dim PasteStartLoc As Integer =
            (From i As DataGridViewRow In DgvSegAssign.SelectedRows Select i.Index).Min
        Dim PasteLastLoc As Integer =
            (From i As DataGridViewRow In DgvSegAssign.SelectedRows Select i.Index).Max

        Dim j As Integer = 0
        For i As Integer = PasteStartLoc To PasteLastLoc
            DgvSegAssign("SegmentType", i).Value = TypeName(j) '
            DgvSegAssign("AssemblyPtnName", i).Value = PtName(j)  '
            j += 1
            If j = TypeName.Count Then j = 0
        Next

    End Sub
    ''' <summary>
    ''' 全選択,全選択解除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btlAllSelectorCancel_Click(sender As Object, e As EventArgs) Handles btnAllSelect.Click, btnSelectCancel.Click

        For i As Integer = 0 To DgvSegSim.RowCount - 1
            ' チェックボックスの列番号を指定して、チェックをつける
            DgvSegSim("TrasferEnabl", i).Value = (sender Is btnAllSelect)
        Next

    End Sub
    ''' <summary>
    ''' 選択した範囲を選択or 解除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tsmSelectorCansel_Click(sender As Object, e As EventArgs) Handles tsmSelect.Click, tsmCancel.Click

        For Each dgvrw As DataGridViewRow In DgvSegSim.SelectedRows
            dgvrw.Cells("TrasferEnabl").Value = (sender Is tsmSelect)
        Next


    End Sub
    ''' <summary>
    ''' 転送
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        For i As Integer = 0 To DgvSegSim.RowCount - 1
            If DgvSegSim.Rows(i).Cells("TrasferEnabl").Value Then
                Dim SelRingNo As Integer = DgvSegSim.Rows(i).Cells("RingNoSim").Value
                '同じリング番号のセルを取得
                Dim DgvRow =
                    (From ro As DataGridViewRow In DgvSegAssign.Rows Where ro.Cells("RingNo").Value = SelRingNo Select ro.Cells).First
                DgvRow.Item("SegmentType").Value = DgvSegSim.Rows(i).Cells("SegmentTypeSim").Value
                DgvRow.Item("AssemblyPtnName").Value = DgvSegSim.Rows(i).Cells("AssemblyPtnNameSim").Value
                DgvRow.Item("SheetID").Value = DgvSegSim.Rows(i).Cells("SheetIDSim").Value
                'DgvRow.Item("TransferSet").Style.BackColor = Color.BlueViolet

                For Each jj As DataGridViewCell In DgvRow
                    jj.Style.BackColor = Color.Yellow
                Next


            End If
        Next


    End Sub

    Private EdtValue As String
    ''' <summary>
    ''' 編集開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvSegAssign_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DgvSegAssign.CellBeginEdit
        EdtValue = DgvSegAssign.CurrentCell.Value
    End Sub
    ''' <summary>
    ''' 編集終了
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvSegAssign_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSegAssign.CellEndEdit
        If EdtValue <> DgvSegAssign.CurrentCell.Value Then
            DgvSegAssign("SheetID", e.RowIndex).Value = Nothing
            DgvSegAssign("TransferSet", e.RowIndex).Value = "☓"
        End If



    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Sub DgvSegAssign_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSegAssign.CellContentClick

    End Sub
End Class