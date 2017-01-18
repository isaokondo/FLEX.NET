Public Class frmVerPlanData
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '発進、到達座標方位
        lblStartZ.Text = VerPlan.発進Z座標.ToString("F3")
        lblStartSlope.Text = VerPlan.発進勾配.ToString("F3")

        lblReachZ.Text = VerPlan.到達Z座標.ToString("F3")
        lblReachSlope.Text = VerPlan.到達勾配.ToString("F3")



        Dim ColumName As String() =
             {"ｿﾞｰﾝ№", "線形", "線分水平距離 (m)", "半径(m)",
              "始点 ｼﾌﾄ", "終点 ｼﾌﾄ", "中折 使用", "前胴中心 (m)",
             "後胴中心 (m)", "開始点 (m)", "戻し点 (m)", "最大 中折れ角",
             "姿勢 変化率", "中心角", "始点累積 水平距離", "終点累積 水平距離",
             "始点 勾配", "終点 勾配", "始点 Z座標", "終点 Z座標",
             "中心位置 Z座標", "始点構築 Z座標", "終点構築 Z座標", "中心位置累積水平距離"}

        SetColum(ColumName)


        Dim NarrowCell As Integer() = {0, 1, 6}
        For Each i In NarrowCell
            dgv.Columns(i).Width = 80
        Next

        '行数設定
        dgv.RowCount = VerPlan.ゾーン総数 + 1


        For ZoneNo As Integer = 0 To VerPlan.ゾーン総数

            Dim dSet As New clsDgvSet(dgv.Rows(ZoneNo))

            dSet.setData(0, ZoneNo)

            dSet.setData(1, VerPlan.線形(ZoneNo))
            dSet.setData(2, VerPlan.線分水平距離(ZoneNo))
            dSet.setData(3, VerPlan.曲率半径(ZoneNo))
            dSet.setData(4, VerPlan.始点シフト量(ZoneNo))
            dSet.setData(5, VerPlan.終点シフト量(ZoneNo))

            dSet.setData(6, VerPlan.中折(ZoneNo))
            dSet.setData(7, VerPlan.前胴中心(ZoneNo))
            dSet.setData(8, VerPlan.後胴中心(ZoneNo))

            dSet.setData(9, VerPlan.中折開始(ZoneNo))
            dSet.setData(10, VerPlan.戻し開始(ZoneNo))
            dSet.setData(11, VerPlan.最大中折れ角(ZoneNo))
            dSet.setData(12, VerPlan.姿勢変化率(ZoneNo))
            dSet.setData(13, VerPlan.中心角(ZoneNo))
            dSet.setData(14, VerPlan.始点累積水平距離(ZoneNo))
            dSet.setData(15, VerPlan.終点累積累積距離(ZoneNo))


            dSet.setData(16, VerPlan.始点勾配(ZoneNo))
            dSet.setData(17, VerPlan.終点勾配(ZoneNo))
            'TODO:構築は未処理
            dSet.setData(18, VerPlan.始点Z座標(ZoneNo))
            dSet.setData(19, VerPlan.終点Z座標(ZoneNo))

            dSet.setData(20, VerPlan.中心位置累積水平距離(ZoneNo))
        Next





    End Sub
End Class