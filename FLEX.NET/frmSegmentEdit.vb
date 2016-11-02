
Public Class frmSegmentEdit

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'DataGridViewComboBoxColumnを作成
        Dim column As New DataGridViewComboBoxColumn
        'ComboBoxのリストに表示する項目を設定する
        'Dim bs = New BindingSource

        column.Items.Add(("日曜日"))
        column.Items.Add(("火曜日"))
        column.Items.Add(("水曜日"))

        column = DgvSegAssign.Columns(1)


        'DataGridView1に現在存在しているWeek列と
        '　今作成したDataGridViewComboBoxColumnを入れ替える
        '表示する列の名前を設定する
        'column.DataSource = bs
        'column.DataPropertyName = DgvSegAssign.Columns(1).DataPropertyName
        'DgvSegAssign.Columns(1)

        For i As Integer = 0 To SegmentAssemblyData.SegmentAssenblyPtnID.Count - 1
            DgvSegAssign.Rows.Add()
            Dim RingNo As Integer = SegmentAssemblyData.SegmentAssenblyPtnID.Keys(i)
            DgvSegAssign.Rows(i).Cells(0).Value = RingNo
            'DgvSegAssign.Rows(i).Cells(1).Value = SegmentAssemblyData.SegmentTypeData(RingNo).TypeName
            DgvSegAssign.Rows(i).Cells(2).Value = SegmentAssemblyData.SegmentTypeData(RingNo).CenterWidth * 1000
        Next




    End Sub
End Class