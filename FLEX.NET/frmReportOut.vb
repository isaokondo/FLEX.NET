Imports System.Data.Odbc
Imports ClosedXML.Excel
Public Class frmReportOut

    Private RprDB As New clsReportDb


    ''' <summary>
    ''' 印字項目変更時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvReportItemSet_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReportItemSet.CellValueChanged

        If e.RowIndex > 0 Then
            Dim x As New DataGridViewComboBoxCell()
            x = CType(DgvReportItemSet(1, e.RowIndex), DataGridViewComboBoxCell)
            If Not IsNothing(x.Value) Then
                RprDB.ReportSetItem(PtnSelNo() - 1)(e.RowIndex) = x.Items.IndexOf(x.Value)
            End If
        End If

    End Sub






    Private Sub frmReportOut_Load(sender As Object, e As EventArgs) Handles Me.Load

        'リング番号選択の設定
        cmbRingSel.Items.AddRange(RprDB.RingSel.ToArray)
        cmbRingSel.SelectedIndex = 0 '最新番号
        '行数の設定
        For i As Short = 0 To RprDB.RingReportRows - 1
            DgvReportItemSet.Rows.Add()
            DgvReportItemSet("ID", i).Value = i + 1
        Next

        '選択項目の設定
        Dim colPrtName As New DataGridViewComboBoxColumn()
        colPrtName = CType(DgvReportItemSet.Columns(1), DataGridViewComboBoxColumn)
        colPrtName.Items.Add("") '一行目は空白
        colPrtName.Items.AddRange(RprDB.ItemSel.ToArray)

        SelectFldSetPtn() '選択されたパターンの印字項目設定

        For Each rdBtn As RadioButton In gpxPtnSelect.Controls
            AddHandler rdBtn.Click, AddressOf SelectFldSetPtn
        Next

    End Sub

    ''' <summary>
    ''' 選択されたパターンの印字項目設定
    ''' </summary>
    Private Sub SelectFldSetPtn()

        For Each rdBtn As RadioButton In gpxPtnSelect.Controls

            For i As Short = 0 To RprDB.RingReportRows - 1
                Dim x As DataGridViewComboBoxCell
                x = CType(DgvReportItemSet(1, i), DataGridViewComboBoxCell)
                x.Value = x.Items(RprDB.ReportSetItem(PtnSelNo() - 1)(i))
            Next
        Next



    End Sub
    ''' <summary>
    ''' 選択されたパターン番号
    ''' </summary>
    ''' <returns></returns>
    Private Function PtnSelNo() As Short
        For Each rdBtn As RadioButton In gpxPtnSelect.Controls
            If rdBtn.Checked Then
                Return GetNum(rdBtn.Name)
            End If
        Next
        Return 0
    End Function

    ''' <summary>
    ''' 変更データ更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

        RprDB.PtnSave()
    End Sub




    Private Sub btnFileSave_Click(sender As Object, e As EventArgs) Handles btnFileSave.Click
        Using ReportXml As New ClosedXML.Excel.XLWorkbook("FLEXリング報.xlsx", XLEventTracking.Disabled)

            Dim sheet As ClosedXML.Excel.IXLWorksheet = ReportXml.Worksheet("FLEX掘進リング報")
            'シートにデータ書き込み
            Dim RingNo As Integer = RprDB.SelectRingNo(cmbRingSel.SelectedIndex)
            RprDB.ReportSheetWrite(sheet, RingNo, PtnSelNo)


            ReportXml.SaveAs($"report\RingReport_Ptn{PtnSelNo()}_Ring{RingNo}.xlsx")

        End Using





    End Sub













    Private Class clsReportDb
        Inherits clsDataBase


        ''' <summary>
        ''' リング報行数
        ''' </summary>
        ''' <returns></returns>
        Public Property RingReportRows As Short

        ''' <summary>
        ''' リング情報
        ''' </summary>
        Private Structure RingInfo
            Public RingNo As Integer    'リング番号
            Public StartDate As Date '掘削開始時刻
            Public Sub New(RingNo As Integer, StartDate As Date)
                Me.New()
                Me.RingNo = RingNo
                Me.StartDate = StartDate
            End Sub
        End Structure

        Private _RingData As New List(Of RingInfo)


        Private Structure ReprtItemIfo
            Public ID As Integer
            Public FeileName As String      '項目名
            Public Unit As String           '単位
            Public DicemalPlace As Short    '小数点位置
            Public SelectStr As List(Of String) '選択文字
        End Structure


        Private _ReportItem As New List(Of ReprtItemIfo)




        ''' <summary>
        ''' 各パターンごとの選択項目　ID
        ''' </summary>
        Private _ReportSetItem(2) As List(Of Integer)
        ''' <summary>
        ''' リング報パターン数分の表示項目
        ''' </summary>
        Public Property ReportSetItem As List(Of Integer)()
            Get
                Return _ReportSetItem
            End Get
            Set(value() As List(Of Integer))
                _ReportSetItem = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sheet">書き込むシート</param>
        ''' <param name="RingNo">リング番号</param>
        Public Sub ReportSheetWrite(sheet As IXLWorksheet, RingNo As Integer, PtNo As Short)

            sheet.Range("リング№").Value = RingNo

            Dim LastStroke As Integer

            Dim RingRpt As OdbcDataReader =
                ExecuteSql($"SELECT min(`時間`),max(`時間`),max(`掘進ストローク`),
                max(`平面旋回中心`+`平面発進から発旋回中心までの距離`) FROM flex掘削データ
                 WHERE `リング番号`='{RingNo}' ORDER BY 時間")
            While RingRpt.Read
                sheet.Range("掘進開始時刻").Value = RingRpt.Item(0)
                sheet.Range("掘進完了時刻").Value = RingRpt.Item(1)
                sheet.Range("掘進ストローク").Value = RingRpt.Item(2)
                sheet.Range("掘進総距離").Value = RingRpt.Item(3)
                LastStroke = RingRpt.Item(2)
            End While

            Dim StartRows As Integer = sheet.Range("データ名称").Cell(1, 1).Address.RowNumber
            Dim StartCols As Integer = sheet.Range("データ名称").Cell(1, 1).Address.ColumnNumber

            'パターンからデータ名称
            For i As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                Dim k As Integer = _ReportSetItem(PtNo - 1)(i) - 1
                If k <> -1 Then
                    sheet.Cell(i + StartRows, StartCols).Value = _ReportItem(k).FeileName '項目名
                    sheet.Cell(i + StartRows, StartCols + 1).Value = _ReportItem(k).Unit '単位
                    If _ReportItem(i).DicemalPlace <> 0 Then
                        sheet.Rows(i + StartRows).Style.NumberFormat.Format = ("0." & New String("0", _ReportItem(k).DicemalPlace))
                    End If
                    sheet.Cell(i + StartRows, StartCols - 1).Style.NumberFormat.Format = ("0")
                End If

            Next

            Dim RingRptData As OdbcDataReader =
                ExecuteSql($"SELECT * FROM flex掘削データ
                 WHERE `リング番号`='{RingNo}' ORDER BY 時間")
            Dim StdStroke As Integer = 10 '基準ストローク
            Dim Col As Integer = StartCols + 2  '開始列
            While RingRptData.Read
                Dim ExecStroke As Integer = RingRptData.Item("掘進ストローク")
                If ExecStroke >= StdStroke Or ExecStroke = LastStroke Then

                    sheet.Cell(StartRows - 2, Col).Value = ExecStroke
                    sheet.Cell(StartRows - 1, Col).Value = RingRptData.Item("時間")
                    sheet.Cell(StartRows - 1, Col).Style.DateFormat.Format = ("hh:ss")


                    'パターンからデータ名称
                    For Row As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                        Dim k As Integer = _ReportSetItem(PtNo - 1)(Row) - 1
                        If k <> -1 Then
                            sheet.Cell(Row + StartRows, Col).Value =
                                RingRptData.Item(_ReportItem(k).FeileName) 'データ
                        End If
                    Next

                    If StdStroke = 10 Then '基準ストローク加算
                        StdStroke = 100
                    Else
                        StdStroke += 100
                    End If
                    Col += 1 '列番号更新
                End If
            End While

            '平均、最大、最小の表示
            Dim CalucMethd As String() = {"AVG", "MAX", "MIN"}
            Dim StartCalcCol As Integer = sheet.Range("平均値").Cell(1, 1).Address.ColumnNumber

            For Each clm In CalucMethd
                Dim SelectItm As New List(Of String)

                'パターンからデータ名称
                For Row As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                    Dim k As Integer = _ReportSetItem(PtNo - 1)(Row) - 1
                    If k <> -1 Then
                        SelectItm.Add($"{clm}(`{_ReportItem(k).FeileName}`)")
                    Else
                        SelectItm.Add("''")
                    End If
                Next
                Dim RingRptCalcData As OdbcDataReader =
                ExecuteSql($"SELECT {String.Join(",", SelectItm)} FROM flex掘削データ
                 WHERE `リング番号`='{RingNo}'")

                While RingRptCalcData.Read
                    For i As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                        sheet.Cell(i + StartRows, StartCalcCol).Value = RingRptCalcData.Item(i)
                    Next
                    StartCalcCol += 1
                End While
            Next

        End Sub



        ''' <summary>
        ''' パターン保存
        ''' </summary>
        Public Sub PtnSave()
            For i As Short = 0 To _ReportSetItem.Count - 1
                'リング報印字項目の設定読込
                Dim RingPrtFldRd As OdbcDataReader =
                ExecuteSql($"UPDATE flex制御パラメータ SET `値`= '{String.Join(",", _ReportSetItem(i))}'
                WHERE `項目名称`='RingReporPtn{(i + 1)}'")
            Next
        End Sub


        Public Sub New()
            'リング情報読込
            Dim RingLst As OdbcDataReader =
                ExecuteSql("SELECT `リング番号`,Min(`時間`),Max(`時間`) 
                FROM `flex掘削データ` GROUP BY `リング番号` ORDER BY `リング番号` DESC")

            While RingLst.Read
                _RingData.Add(New RingInfo(RingLst.Item(0), RingLst.Item(1)))
            End While

            '項目情報読込
            Dim ItemInfo As OdbcDataReader =
                ExecuteSql("SELECT * FROM `flexリング報項目` WHERE `印字有効`='1'")

            While ItemInfo.Read
                Dim r As ReprtItemIfo
                r.ID = ItemInfo.Item("ID")
                r.FeileName = ItemInfo.Item("項目名")
                r.Unit = ItemInfo.Item("単位")
                r.DicemalPlace = ItemInfo.Item("小数点位置")
                r.SelectStr = Split(",", ItemInfo.Item("選択文字").ToString).ToList
                _ReportItem.Add(r)
            End While

            'リング報行数
            Dim RingRptRow As OdbcDataReader =
                ExecuteSql("SELECT 値 FROM flex制御パラメータ WHERE 項目名称='RingReportRows' ")
            If RingRptRow.HasRows Then
                While RingRptRow.Read
                    _RingReportRows = RingRptRow.Item(0)
                End While
            Else
                MsgBox("リング報行数 RingReportRowsが　flex制御パラメータに設定されてません", vbCritical)
            End If

            'リング報印字項目の設定読込
            Dim RingPrtFldRd As OdbcDataReader =
                ExecuteSql("SELECT * FROM flex制御パラメータ WHERE 項目名称 Like 'RingReporPtn%'")

            If RingPrtFldRd.HasRows Then
                While RingPrtFldRd.Read
                    Dim PtnNo As Short = GetNum(RingPrtFldRd.Item("項目名称"))
                    _ReportSetItem(PtnNo - 1) =
                        New List(Of Integer)((From j In RingPrtFldRd.Item("値").ToString.Split(",")
                                              Select CInt(j)).ToList)
                End While
            Else
                MsgBox("リング報印字項目の設定読込 RingReporPtn　flex制御パラメータに設定されてません", vbCritical)
            End If


        End Sub
        ''' <summary>
        ''' リング番号取得
        ''' </summary>
        ''' <param name="i"></param>
        ''' <returns></returns>
        Public ReadOnly Property SelectRingNo(i As Integer) As Integer
            Get
                Return _RingData(i).RingNo
            End Get
        End Property



        ''' <summary>
        ''' 選択用リング番号情報を返す
        ''' </summary>
        ''' <returns>リング番号、開始時刻</returns>
        Public ReadOnly Property RingSel As List(Of String)
            Get
                Return (From i In _RingData Select $"{String.Format("{0, 6}", i.RingNo)}リング {i.StartDate.ToString}").ToList
            End Get
        End Property

        ''' <summary>
        ''' 選択用項目リスト
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ItemSel As List(Of String)
            Get
                Return (From i In _ReportItem Select i.FeileName).ToList
            End Get
        End Property




    End Class

End Class