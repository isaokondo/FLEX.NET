
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

        '組立パターンのコンボボックス選択用
        For Each i In SegAsmblyData.AssenblyPtnLst
            CType(DgvSegAssign.Columns("AssemblyPtnName"), DataGridViewComboBoxColumn).Items.Add(i.Value)
        Next
        'データ読み込み
        SegAsmblyData.SegmentRingDataRead()

        SegAsmblyData.SegmentSimDataRead()

        Dim FirstSclRow As Integer '表示位置
        Dim SimDgvRow As Integer = 0
        For i As Integer = 0 To SegAsmblyData.SegmentAssenblyPtnID.Count - 1
            DgvSegAssign.Rows.Add()
            Dim RingNo As Integer = SegAsmblyData.SegmentAssenblyPtnID.Keys(i)
            DgvSegAssign("RingNo", i).Value = RingNo
            DgvSegAssign("SegmentType", i).Value = SegAsmblyData.TypeData(RingNo).TypeName 'セグメント種類
            DgvSegAssign("SegWidth", i).Value = SegAsmblyData.TypeData(RingNo).CenterWidth * 1000 'セグメント幅
            DgvSegAssign("AssemblyPtnName", i).Value = SegAsmblyData.AssemblyPtnName(RingNo) '組立パターン名

            Dim Mark As String = ""

            'シュミレーションデータに当該リングのデータが存在するか
            If SegAsmblyData.TransferDateSim.ContainsKey(RingNo) Then
                '転送日付の比較
                Dim FlgDat As Integer
                If SegAsmblyData.TransferDate.ContainsKey(RingNo) Then

                    FlgDat = Date.Compare(SegAsmblyData.TransferDate(RingNo), SegAsmblyData.TransferDateSim(RingNo))
                Else
                    FlgDat = -1
                End If

                '同じ日付は転送済み
                If FlgDat = 0 Then Mark = "●"
                    '新しいデータ
                    If FlgDat < 0 Then
                    Mark = "☓"
                    DgvSegSim.Rows.Add()
                    DgvSegSim("RingNoSim", SimDgvRow).Value = RingNo
                    DgvSegSim("SegmentTypeSim", SimDgvRow).Value = SegAsmblyData.TypeDataSim(RingNo).TypeName 'セグメント種類
                    DgvSegSim("AssemblyPtnNameSim", SimDgvRow).Value = SegAsmblyData.AssemblyPtnNameSim(RingNo) '組立パターン名
                    DgvSegSim("TransferDateSim", SimDgvRow).Value = SegAsmblyData.TransferDateSim(RingNo) '転送日
                    '表示位置の設定
                    If RingNo = PlcIf.RingNo Then
                        DgvSegSim.FirstDisplayedCell = DgvSegSim(0, SimDgvRow)
                    End If

                    SimDgvRow += 1
                End If

                End If
            DgvSegAssign("TransferSet", i).Value = Mark



            '現在のリング番号を先頭行に移動
            If RingNo = PlcIf.RingNo Then
                FirstSclRow = i
                DgvSegAssign.FirstDisplayedCell = DgvSegAssign(0, FirstSclRow)

            End If
        Next
        '表示位置の設定

        DgvSegAssign.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegAssign.Rows Where gg.Cells("RingNo").Value = PlcIf.RingNo Select gg.Cells.Item(0))(0)
        DgvSegSim.FirstDisplayedCell =
            (From gg As DataGridViewRow In DgvSegSim.Rows Where gg.Cells("RingNoSim").Value = PlcIf.RingNo Select gg.Cells.Item(0))(0)


        AddHandler DgvSegAssign.CellValueChanged, AddressOf DgvSegAssign_CellValueChanged

    End Sub
    ''' <summary>
    ''' 変更した行のデータを更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)


        For Each i In lstChangeRow.Distinct
            Dim RingNo As Integer = DgvSegAssign("RingNo", i).Value
            Dim PtName As String = DgvSegAssign("AssemblyPtnName", i).Value
            Dim TpName As String = DgvSegAssign("SegmentType", i).Value
            Dim TranferDateFromSim As DateTime = DgvSegAssign("Transferdate", i).Value
            SegAsmblyData.SegmentAsemblyDataUpdat(RingNo, PtName, TpName, TranferDateFromSim)

        Next
        Me.Close()

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

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

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
                DgvRow.Item("TransferDate").Value = DgvSegSim.Rows(i).Cells("TransferDateSim").Value
                'DgvRow.Item("TransferSet").Style.BackColor = Color.BlueViolet

                For Each jj As DataGridViewCell In DgvRow
                    jj.Style.BackColor = Color.Yellow
                Next


            End If
        Next


    End Sub
End Class