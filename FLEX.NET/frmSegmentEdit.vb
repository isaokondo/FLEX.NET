
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SegAsmblyData.SegmentAsemblyDataUpdat(10, 1, 1)
    End Sub

    Private Sub DgvSegAssign_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSegAssign.CellValueChanged
        If e.RowIndex <> -1 Then
            lstChangeRow.Add(e.RowIndex)
        End If
    End Sub
End Class