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

        If e.RowIndex >= 0 Then
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


        '自動印字パターン読込、表示
        For Each chkPtn As CheckBox In gpxAutoPrtPtn.Controls
            For Each Ptn In Split(My.Settings.ReportAutoPrintPtn, ",")
                If chkPtn.Text = "パターン" & Ptn Then
                    chkPtn.Checked = True
                End If
            Next
            AddHandler chkPtn.Click, AddressOf SelectAutoPrintPtn
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
    ''' 自動印字パターン変更時　設定を反映
    ''' </summary>
    Private Sub SelectAutoPrintPtn()

        Dim Lst As New List(Of Short)
        For Each chkPtn As CheckBox In gpxAutoPrtPtn.Controls
            If chkPtn.Checked Then
                Lst.Add(GetNum(chkPtn.Name))
            End If
        Next
        My.Settings.ReportAutoPrintPtn = String.Join(",", Lst)
        My.Settings.Save()


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



    ''' <summary>
    ''' リング報ファイル保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFileSave_Click(sender As Object, e As EventArgs) Handles btnFileSave.Click
        '選択されたリング番号を取得
        Dim RingNo As Integer = RprDB.SelectRingNo(cmbRingSel.SelectedIndex)

        '名前をつけて保存のダイアログ表示
        Dim sfd As New SaveFileDialog

        sfd.FileName = $"RingReport_Ptn{PtnSelNo()}_Ring{RingNo}.xlsx"
        sfd.InitialDirectory = My.Settings.ReportFolder
        sfd.Filter = "EXCELファイル|*.xlsx"
        sfd.Title = "保存先のファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        sfd.RestoreDirectory = True

        'ダイアログを表示する
        If sfd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            'シートにデータ書き込み,保存する

            RprDB.ReportSheetWrite(RingNo, PtnSelNo).SaveAs(sfd.FileName)

            My.Settings.ReportFolder = System.IO.Path.GetDirectoryName(sfd.FileName)

        End If

    End Sub
    ''' <summary>
    '''リング報印刷
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrintOut_Click(sender As Object, e As EventArgs) Handles btnPrintOut.Click
        'VB.net でエクセルを印刷するとバージョンの違いで
        '他の環境のPCだとエラーになる可能でしがあるので
        'VBSで実行する
        '選択されたリング番号を取得
        Dim RingNo As Integer = RprDB.SelectRingNo(cmbRingSel.SelectedIndex)
        'テンポラリファイル名
        Dim TmpPath As String =
            $"{AppDomain.CurrentDomain.BaseDirectory}tmp\RingReport_Ptn{PtnSelNo()}_Ring{RingNo}_{Now.ToString("yyyymmddhhmmssff")}.xlsx"

        'シートにデータ書き込み
        'テンポラリファイルにリング報保存
        RprDB.ReportSheetWrite(RingNo, PtnSelNo).SaveAs(TmpPath)


        '保存したエクセル（テンポラリファイル)を印刷　VBS経由で
        Dim psi As New ProcessStartInfo("WScript.exe")
        psi.Arguments =
            $"{AppDomain.CurrentDomain.BaseDirectory}Resources\excelprt.vbs {TmpPath}"

        Dim job As Process = Process.Start(psi)
        job.WaitForExit()
        If job.ExitCode <> 0 Then
            MsgBox("リング報印刷に失敗しました。", vbCritical)
        End If



    End Sub
    ''' <summary>
    ''' 印刷プレビュー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim RingNo As Integer = RprDB.SelectRingNo(cmbRingSel.SelectedIndex)
        'テンポラリファイル名
        Dim TmpPath As String =
            $"{AppDomain.CurrentDomain.BaseDirectory}tmp\RingReport_Ptn{PtnSelNo()}_Ring{RingNo}_{Now.ToString("yyyymmddhhmmssff")}.xlsx"

        'シートにデータ書き込み
        'テンポラリファイルにリング報保存
        RprDB.ReportSheetWrite(RingNo, PtnSelNo).SaveAs(TmpPath)


        '保存したエクセル（テンポラリファイル)を印刷　VBS経由で
        Dim psi As New ProcessStartInfo("WScript.exe")
        psi.Arguments =
            $"{AppDomain.CurrentDomain.BaseDirectory}Resources\excelpdfout.vbs {TmpPath}"

        Dim job As Process = Process.Start(psi) '("excelprt.vbs", TmpPath)
        job.WaitForExit()
        If job.ExitCode <> 0 Then
            MsgBox("リング報ファイル作成に失敗しました。", vbCritical)
        End If
        Dim RpV As New frmReportViewer(Replace(TmpPath, "xlsx", "pdf"))
        RpV.Show()


    End Sub
End Class

''' <summary>
''' リング報関連のデータベース処理クラス
''' </summary>
Public Class clsReportDb
    Inherits clsDataBase

    ''' <summary>
    ''' リング報のフルパス
    ''' </summary>
    Private _RingRptPath As String =
        $"{System.AppDomain.CurrentDomain.BaseDirectory}Resources\FLEXリング報.xlsx"


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
    ''' <summary>
    ''' 最新リング番号
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property LastRing As Integer
        Get
            Dim LastRingNo As DataTable =
                GetDtfmSQL("Select リング番号 FROM flex掘削データ ORDER BY 時間 DESC LIMIT 0,1")
            If LastRingNo.Rows.Count = 0 Then
                Return 0
            Else
                Return LastRingNo.Rows(0).Item(0)
            End If
            'If LastRingNo.HasRows Then
            '    While LastRingNo.Read
            '        Return LastRingNo.GetInt32(0)
            '    End While
            'End If
            'Return 0
        End Get
    End Property



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
    ''' <param name="RingNo">リング番号</param>
    Public Function ReportSheetWrite(RingNo As Integer, PtNo As Short) As ClosedXML.Excel.XLWorkbook

        Dim ReportXml As New ClosedXML.Excel.XLWorkbook(_RingRptPath, XLEventTracking.Disabled)

        Dim sheet As ClosedXML.Excel.IXLWorksheet = ReportXml.Worksheet("FLEX掘進リング報")


        sheet.Range("リング№").Value = RingNo

        Dim LastStroke As Integer '最終ストローク
        Dim ExecTime As Integer '掘進時間（中断時間含む)


        Dim RingRpt As DataTable =
                GetDtfmSQL($"Select min(時間),max(時間),max(掘進ストローク),
                max(平面旋回中心+平面発進から発旋回中心までの距離),
                SUM(CASE WHEN 圧力制御='0' THEN 1 ELSE 0 END) AS JKSELMODE,
                SUM(CASE WHEN 圧力制御='1' THEN 1 ELSE 0 END)  AS FLEXMODE,
                SUM(CASE WHEN 同時施工モード='1' THEN 1 ELSE 0 END) AS LOSZEROMODE 
                FROM flex掘削データ  WHERE リング番号='{RingNo}' ORDER BY 時間")

        sheet.Range("掘進開始時刻").Value = RingRpt.Rows(0).Item(0)
        sheet.Range("掘進完了時刻").Value = RingRpt.Rows(0).Item(1)
            sheet.Range("掘進ストローク").Value = RingRpt.Rows(0).Item(2)
            sheet.Range("掘進総距離").Value = RingRpt.Rows(0).Item(3)
            LastStroke = RingRpt.Rows(0).Item(2)
        '掘進時間の算出（中断時間を含めない）単位（分）
        Dim tStt As DateTime = DateTime.Parse(RingRpt.Rows(0).Item(0))
        Dim tLst As DateTime = DateTime.Parse(RingRpt.Rows(0).Item(1))
        ExecTime = tLst.Subtract(tStt).TotalMinutes
            'TODO:ビット演算子を使いたい
            Dim ModeFg As Short
            Dim ExecFrom As String() = {"ジャッキ選択", "FLEX推進", "ジャッキ選択/FLEX推進", "同時施工"}
        If RingRpt.Rows(0).Item("JKSELMODE") > 0 And RingRpt.Rows(0).Item("FLEXMODE") > 0 Then
            ModeFg = 2
        End If

        If RingRpt.Rows(0).Item("JKSELMODE") = 0 And RingRpt.Rows(0).Item("FLEXMODE") > 0 Then
            ModeFg = 1
        End If

        If RingRpt.Rows(0).Item("JKSELMODE") > 0 And RingRpt.Rows(0).Item("FLEXMODE") = 0 Then
            ModeFg = 0
        End If

        If RingRpt.Rows(0).Item("LOSZEROMODE") > 0 Then
            ModeFg = 3
        End If

        sheet.Range("掘進形態").Value = ExecFrom(ModeFg)

        'End While
        '組立開始、完了時刻及び組立時間の取得
        '

        If ModeFg <> 3 Then
            'ロスゼロ以外の時
            '組立完了時刻は、次リングの待機中になった時間
            Dim NextRingWaintgTime As DataTable =
                GetDtfmSQL($"SELECT TIME FROM flexイベントデータ 
                WHERE (イベントデータ LIKE '%{RingNo + 1}リング%') 
                AND (イベントデータ LIKE '%待機中%') ")
            If NextRingWaintgTime.Rows.Count <> 0 Then
                sheet.Range("組立完了時刻").Value = NextRingWaintgTime.Rows(0).Item(0)

                Dim StartSegmentAsem As DataTable =
                    GetDtfmSQL($"SELECT TIME FROM flexイベントデータ 
                    WHERE イベントデータ LIKE '%セグメントモード%' AND 
                    TIME>'{RingRpt.Rows(0).Item(1)}' AND TIME<'{NextRingWaintgTime.Rows(0).Item(0)}'")
                If StartSegmentAsem.Rows.Count <> 0 Then
                    sheet.Range("組立開始時刻").Value = StartSegmentAsem.Rows(0).Item(0)

                    '組立時間の算出(分)
                    sheet.Range("組立時間").Value =
                        (DateTime.Parse(NextRingWaintgTime.Rows(0).Item(0)) - DateTime.Parse(StartSegmentAsem.Rows(0).Item(0))).TotalMinutes
                    'サイクル時間
                    sheet.Range("サイクル時間").Value =
                        (DateTime.Parse(NextRingWaintgTime.Rows(0).Item(0)) - DateTime.Parse(RingRpt.Rows(0).Item(0))).TotalMinutes


                End If

            End If
        End If


        Dim StartRows As Integer = sheet.Range("データ名称").Cell(1, 1).Address.RowNumber
        Dim StartCols As Integer = sheet.Range("データ名称").Cell(1, 1).Address.ColumnNumber

        'パターンからデータ名称
        For i As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
            Dim k As Integer = _ReportSetItem(PtNo - 1)(i) - 1
            If k <> -1 Then
                sheet.Cell(i + StartRows, StartCols).Value = _ReportItem(k).FeileName '項目名
                sheet.Cell(i + StartRows, StartCols + 1).Value = _ReportItem(k).Unit '単位
                If _ReportItem(k).DicemalPlace <> 0 Then
                    sheet.Rows(i + StartRows).Style.NumberFormat.Format = ("0." & New String("0", _ReportItem(k).DicemalPlace))
                End If
                sheet.Cell(i + StartRows, StartCols - 1).Style.NumberFormat.Format = ("0")
            End If

        Next

        Dim RingRptData As DataTable =
                GetDtfmSQL($"SELECT * FROM flex掘削データ
                 WHERE リング番号='{RingNo}' ORDER BY 時間")
        Dim StdStroke As Integer = 10 '基準ストローク
        Dim Col As Integer = StartCols + 2  '開始列
        'While RingRptData.Read
        For Each t As DataRow In RingRptData.Rows
            Dim ExecStroke As Integer = t.Item("掘進ストローク")
            If ExecStroke >= StdStroke Or ExecStroke = LastStroke Then

                sheet.Cell(StartRows - 2, Col).Value = ExecStroke
                sheet.Cell(StartRows - 1, Col).Value = t.Item("時間")
                sheet.Cell(StartRows - 1, Col).Style.DateFormat.Format = ("hh:ss")

                'パターンからデータ名称
                For Row As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                    Dim k As Integer = _ReportSetItem(PtNo - 1)(Row) - 1
                    If k <> -1 Then
                        sheet.Cell(Row + StartRows, Col).Value =
                                t.Item(_ReportItem(k).FeileName) 'データ
                    End If
                Next

                If StdStroke = 10 Then '基準ストローク加算
                    StdStroke = 100
                Else
                    StdStroke += 100
                End If
                Col += 1 '列番号更新
            End If
            If ExecStroke = LastStroke Then

                '最終ストローク
                sheet.Range("平面線形").Value =
                    t.Item("平面半径（軌道中心）")
                'パーミリに変換　一応
                sheet.Range("縦断勾配").Value =
                    DegToPermili(t.Item("縦断線形")).ToString("F0")
                sheet.Range("掘進時間").Value =
                    t.Item("掘進時間")
                sheet.Range("掘進中断時間").Value =
                    ExecTime - t.Item("掘進時間")

            End If


        Next
        'End While

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
            Dim RingRptCalcData As DataTable =
                GetDtfmSQL($"SELECT {String.Join(",", SelectItm)} FROM flex掘削データ
                 WHERE リング番号='{RingNo}'")

            'While RingRptCalcData.Read
            For Each t In RingRptCalcData.Rows
                    For i As Short = 0 To _ReportSetItem(PtNo - 1).Count - 1
                    sheet.Cell(i + StartRows, StartCalcCol).Value = t.Item(i)
                Next
                Next
                StartCalcCol += 1
            'End While
        Next

        Return ReportXml

    End Function



    ''' <summary>
    ''' パターン保存
    ''' </summary>
    Public Sub PtnSave()
        For i As Short = 0 To _ReportSetItem.Count - 1
            'リング報印字項目の設定読込
            'Dim RingPrtFldRd As OdbcDataReader =
            ExecuteSqlCmd($"UPDATE flex制御パラメータ SET 値= '{String.Join(",", _ReportSetItem(i))}'
                WHERE 項目名称='RingReporPtn{(i + 1)}'")
        Next
    End Sub


    Public Sub New()
        'リング情報読込
        Dim RingLst As DataTable =
                GetDtfmSQL("SELECT リング番号,Min(時間),Max(時間) 
                FROM flex掘削データ GROUP BY リング番号 ORDER BY リング番号 DESC")

        'While RingLst.Read
        For Each t In RingLst.Rows
            If Not IsDBNull(t.item(1)) And Not IsDBNull(t.item(0)) Then
                _RingData.Add(New RingInfo(t.Item(0), t.Item(1)))
            End If
        Next
        'End While

        '項目情報読込
        Dim ItemInfo As DataTable =
                GetDtfmSQL("SELECT * FROM flexリング報項目 WHERE 印字有効='1'")

        'While ItemInfo.Read
        For Each t In ItemInfo.Rows
            Dim r As ReprtItemIfo
            r.ID = t.Item("ID")
            r.FeileName = t.Item("項目名")
            r.Unit = t.Item("単位")
            r.DicemalPlace = t.Item("小数点位置")
            r.SelectStr = Split(",", t.Item("選択文字").ToString).ToList
            _ReportItem.Add(r)


        Next
        'End While

        'リング報行数
        Dim RingRptRow As DataTable =
                GetDtfmSQL("SELECT 値 FROM flex制御パラメータ WHERE 項目名称='RingReportRows' ")
        If RingRptRow.Rows.Count <> 0 Then
            'While RingRptRow.Read
            _RingReportRows = RingRptRow.Rows(0).Item(0)
            'End While
        Else
            MsgBox("リング報行数 RingReportRowsが　flex制御パラメータに設定されてません", vbCritical)
        End If

        'リング報印字項目の設定読込
        Dim RingPrtFldRd As DataTable =
                GetDtfmSQL("SELECT * FROM flex制御パラメータ WHERE 項目名称 Like 'RingReporPtn%'")

        If RingPrtFldRd.Rows.Count <> 0 Then
            'While RingPrtFldRd.Read
            For Each t As DataRow In RingPrtFldRd.Rows
                Dim PtnNo As Short = GetNum(t.Item("項目名称"))
                _ReportSetItem(PtnNo - 1) =
                        New List(Of Integer)((From j In t.Item("値").ToString.Split(",")
                                              Select CInt(j)).ToList)
            Next
            'End While
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
            Return (From i In _RingData
                    Select $"{String.Format("{0, 6}", i.RingNo)} リング {i.StartDate.ToString("yyyy/MM/dd hh:mm:ss")}").ToList
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
