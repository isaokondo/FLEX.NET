
Public Class frmSegmentEdit
    ''' <summary>
    ''' 更新した行
    ''' </summary>
    Private lstChangeRow As New List(Of Integer)

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

        For i As Integer = 0 To SegAsmblyData.SegmentAssenblyPtnID.Count - 1
            DgvSegAssign.Rows.Add()
            Dim RingNo As Integer = SegAsmblyData.SegmentAssenblyPtnID.Keys(i)
            DgvSegAssign("RingNo", i).Value = RingNo
            DgvSegAssign("SegmentType", i).Value = SegAsmblyData.TypeData(RingNo).TypeName 'セグメント種類
            DgvSegAssign("SegWidth", i).Value = SegAsmblyData.TypeData(RingNo).CenterWidth * 1000 'セグメント幅
            DgvSegAssign("AssemblyPtnName", i).Value = SegAsmblyData.AssemblyPtnName(RingNo) '組立パターン名
        Next


        DgvSegAssign.FirstDisplayedScrollingRowIndex = PlcIf.RingNo


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
            SegAsmblyData.SegmentAsemblyDataUpdat(RingNo, PtName, TpName)

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

    Private Sub frmSegmentEdit_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub
End Class