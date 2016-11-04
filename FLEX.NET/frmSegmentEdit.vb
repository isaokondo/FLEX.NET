
Public Class frmSegmentEdit

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()


        'セグメント種類のコンボボックス選択用
        For Each i In SegmentAssemblyData.TypeNameList
            CType(DgvSegAssign.Columns("SegmentType"), DataGridViewComboBoxColumn).Items.Add(i.Value)
        Next

        '組立パターンのコンボボックス選択用
        For Each i In SegmentAssemblyData.AssenblyPtnLst
            CType(DgvSegAssign.Columns("AssemblyPtnName"), DataGridViewComboBoxColumn).Items.Add(i.Value)
        Next

        For i As Integer = 0 To SegmentAssemblyData.SegmentAssenblyPtnID.Count - 1
            DgvSegAssign.Rows.Add()
            Dim RingNo As Integer = SegmentAssemblyData.SegmentAssenblyPtnID.Keys(i)
            DgvSegAssign("RingNo", i).Value = RingNo
            DgvSegAssign("SegmentType", i).Value = SegmentAssemblyData.TypeData(RingNo).TypeName 'セグメント種類
            DgvSegAssign("SegWidth", i).Value = SegmentAssemblyData.TypeData(RingNo).CenterWidth * 1000 'セグメント幅
            DgvSegAssign("AssemblyPtnName", i).Value = SegmentAssemblyData.AssemblyPtnName(RingNo) '組立パターン名
        Next




    End Sub
End Class