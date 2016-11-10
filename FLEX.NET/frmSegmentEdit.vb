
Public Class frmSegmentEdit

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()


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




    End Sub
End Class