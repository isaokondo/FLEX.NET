Imports System.Data.Odbc

Public Class frmReportOut

    Private RprDB As New clsReportDb


    Private Sub frmReportOut_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbRingSel.Items.AddRange(RprDB.RingSel.ToArray)
        cmbRingSel.SelectedIndex = 0

        Dim col1 As New DataGridViewComboBoxColumn()
        col1.Items.AddRange(RprDB.ItemSel.ToArray)
        col1 = DirectCast(DgvReportItemSet.Columns(1), DataGridViewComboBoxColumn)


        For i As Short = 0 To RprDB.RingReportRows - 1
            DgvReportItemSet.Rows.Add()
            DgvReportItemSet("ID", i).Value = i + 1
        Next

    End Sub

    Private Sub SelectFldSetPtn()

        For Each rdBtn As RadioButton In gpxPtnSelect.Controls
            If rdBtn.Checked Then
                Dim PtnNo As Short = GetNum(rdBtn.Name)
                For i As Short = 0 To RprDB.RingReportRows - 1
                    Dim x As DataGridViewComboBoxCell
                    x = DirectCast(DgvReportItemSet(1, i + 1), DataGridViewComboBoxCell)
                    x.Value = x.Items.Item(1)
                Next



            End If
        Next


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
                    Dim i As Short = GetNum(RingPrtFldRd.Item("項目名称"))
                    _ReportSetItem(i) = New List(Of Integer)
                    _ReportSetItem(i) = (From j In RingPrtFldRd.Item("値").ToString.Split(","c) Select CInt(j)).ToList
                    'For Each j In RingPrtFldRd.Item("値").ToString.Split(","c)
                    '    _ReportSetItem(i).Add(j)
                    'Next



                End While
            Else
                MsgBox("リング報印字項目の設定読込 RingReporPtn　flex制御パラメータに設定されてません", vbCritical)
            End If



        End Sub
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