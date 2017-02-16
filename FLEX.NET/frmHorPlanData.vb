Public Class frmHorPlanData
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        '発進、到達座標方位
        lblStartX.Text = HorPlan.起点X座標.ToString("F3")
        lblStartY.Text = (HorPlan.起点Y座標 * HorPlan.座標系).ToString("F3")
        lblStartDir.Text = HorPlan.起点方位角.ToString("F3")

        lblDepartX.Text = HorPlan.発進X座標.ToString("F3")
        lblDepartY.Text = (HorPlan.発進Y座標 * HorPlan.座標系).ToString("F3")

        lblReachX.Text = HorPlan.到達X座標.ToString("F3")
        lblReachY.Text = (HorPlan.到達Y座標 * HorPlan.座標系).ToString("F3")
        lblReachDir.Text = HorPlan.到達方位角.ToString("F3")

        ''マイナス表示は赤文字に
        'For Each c As Control In Me.Controls
        '    If (TypeOf c Is Label) AndAlso IsNumeric(DirectCast(c, Label).Text) Then
        '        If c.Text < 0 Then c.ForeColor = Color.Red
        '    End If
        'Next


        Dim ColumName As String() =
            {"ｿﾞｰﾝ№", "終点 測点名", "線形状", "線分長 (m)", "始点曲率 半径(m)",
            "終点曲率 半径(m)", "始点 ｼﾌﾄ", "終点 ｼﾌﾄ", "中折 使用", "前胴中心 (m)",
            "後胴中心 (m)", "開始点 (m)", "戻し点 (m)", "最大 中折れ角",
            "姿勢 変化率", "ｸﾛｿｲﾄﾞ ﾊﾟﾗﾒｰﾀ", "中心角", "始点 累積距離", "終点 累積距離",
            "始点 方向角", "終点 方向角", "始点 Ｘ座標", "終点 Ｘ座標", "始点 Ｙ座標", "終点 Ｙ座標",
            "始点中心 Ｘ座標", "終点中心 Ｘ座標", "始点中心 Ｙ座標", "終点中心 Ｙ座標",
            "始点構築 Ｘ座標", "終点構築 Ｘ座標", "始点構築 Ｙ座標", "終点構築 Ｙ座標"}


        For Each cName As String In ColumName
            Dim textColumn As New DataGridViewTextBoxColumn
            textColumn.SortMode = DataGridViewColumnSortMode.NotSortable
            textColumn.Name = cName
            textColumn.HeaderText = cName.Replace(" ", vbCrLf)
            dgv.Columns.Add(textColumn)
        Next

        Dim NarrowCell As Integer() = {0, 2, 8}
        For Each i In NarrowCell
            dgv.Columns(i).Width = 80
        Next




        '行数設定
        dgv.RowCount = HorPlan.ゾーン総数
        'ゾーンNoの列のみ固定
        dgv.Columns(0).Frozen = True


        For ZoneNo As Integer = 0 To HorPlan.ゾーン総数 - 1

            Dim dSet As New clsDgvSet(dgv.Rows(ZoneNo))

            dSet.setData(0, ZoneNo)

            dSet.setData(2, HorPlan.線形(ZoneNo))
            dSet.setData(3, HorPlan.線分長(ZoneNo))
            dSet.setData(4, HorPlan.始点曲率半径(ZoneNo) * HorPlan.座標系)
            dSet.setData(5, HorPlan.終点曲率半径(ZoneNo) * HorPlan.座標系)
            dSet.setData(6, HorPlan.始点シフト量(ZoneNo) * HorPlan.座標系)
            dSet.setData(7, HorPlan.終点シフト量(ZoneNo) * HorPlan.座標系)

            dSet.setData(8, HorPlan.中折(ZoneNo))
            dSet.setData(9, HorPlan.前胴中心(ZoneNo))
            dSet.setData(10, HorPlan.後胴中心(ZoneNo))

            dSet.setData(11, HorPlan.中折開始(ZoneNo))
            dSet.setData(12, HorPlan.戻し開始(ZoneNo))
            dSet.setData(13, HorPlan.最大中折れ角(ZoneNo) * HorPlan.座標系)
            dSet.setData(14, HorPlan.姿勢変化率(ZoneNo))
            dSet.setData(15, HorPlan.クロソイドパラメータ(ZoneNo))
            dSet.setData(16, Lim180(Hoko2Hoi(HorPlan.中心角(ZoneNo) * HorPlan.座標系)))
            dSet.setData(17, HorPlan.始点累積距離(ZoneNo))
            dSet.setData(18, HorPlan.終点累積距離(ZoneNo))


            dSet.setData(19, Hoko2Hoi(HorPlan.始点方向角(ZoneNo)))
            dSet.setData(20, Hoko2Hoi(HorPlan.終点方向角(ZoneNo)))

            dSet.setData(21, HorPlan.始点X座標(ZoneNo))
            dSet.setData(22, HorPlan.終点X座標(ZoneNo))

            dSet.setData(23, HorPlan.始点Y座標(ZoneNo) * HorPlan.座標系)
            dSet.setData(24, HorPlan.終点Y座標(ZoneNo) * HorPlan.座標系)

            dSet.setData(25, HorPlan.始点中心X座標(ZoneNo))
            dSet.setData(26, HorPlan.終点中心X座標(ZoneNo))

            dSet.setData(27, HorPlan.始点中心Y座標(ZoneNo) * HorPlan.座標系)
            dSet.setData(28, HorPlan.終点中心Y座標(ZoneNo) * HorPlan.座標系)

            dSet.setData(29, HorPlan.始点構築X座標(ZoneNo))
            dSet.setData(30, HorPlan.終点構築X座標(ZoneNo))

            dSet.setData(31, HorPlan.始点構築Y座標(ZoneNo) * HorPlan.座標系)
            dSet.setData(32, HorPlan.終点構築Y座標(ZoneNo) * HorPlan.座標系)


        Next




        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub


    'Private Class clsDgvSet
    '    Private dgvR As DataGridViewRow
    '    Public Sub New(r As DataGridViewRow)
    '        dgvR = r
    '    End Sub
    '    Public Sub setData(Col As Integer, DspData As Object)
    '        Dim Dspformt As String = ""
    '        If TypeOf DspData Is Double Then
    '            Dspformt = DirectCast(DspData, Double).ToString("F3")
    '        End If
    '        If TypeOf DspData Is Integer Then
    '            Dspformt = DspData.ToString
    '        End If

    '        If IsNumeric(DspData) AndAlso DspData < 0 Then
    '            dgvR.Cells(Col).Style.ForeColor = Color.Red
    '        End If
    '        'ゼロは非表示　ゾーンNo以外
    '        If Col <> 0 And DspData = 0 Then
    '            Dspformt = ""
    '        End If

    '        dgvR.Cells(Col).Value = Dspformt
    '    End Sub


    'End Class


End Class


