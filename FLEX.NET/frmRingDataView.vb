Imports System.Text.RegularExpressions
Public Class frmRingDataView

    Private RptView As New clsReportDb
    Private RptView2 As New clsRingDb
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()


    End Sub

    Private Sub frmRingDataView_Load(sender As Object, e As EventArgs) Handles Me.Load
        'リング番号選択の設定
        cmbRingSel.Items.AddRange(RptView.RingSel.ToArray)
        cmbRingSel.SelectedIndex = 0 '最新番号


        'For Each cName As String In RptView2.ColList
        '    Dim textColumn As New DataGridViewTextBoxColumn
        '    textColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        '    textColumn.Name = cName
        '    textColumn.HeaderText = cName.Replace(" ", vbCrLf)
        '    dgv.Columns.Add(textColumn)

        'Next
        DspRingData()
        AddHandler cmbRingSel.SelectedIndexChanged, AddressOf DspRingData
    End Sub

    ''' <summary>
    ''' データ表示
    ''' </summary>
    Private Sub DspRingData()
        Dim RingNo As Integer = RptView.SelectRingNo(cmbRingSel.SelectedIndex)

        dgv.DataSource = RptView2.GetData(RingNo)
        'Dim i As Integer = 0
        'For Each col As DataGridViewColumn In dgv.Columns
        '    col.Name &= vbCrLf & RptView2.Unit(i)
        '    i += 1
        'Next
        dgv.Columns(1).Frozen = True

    End Sub

    Private Sub frmRingDataView_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

        dgv.Width = Me.Width - 100
        dgv.Height = Me.Height - 120


    End Sub
    ''' <summary>
    ''' クリップボードにデータをコピー
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCpyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCpyToClipboard.Click
        dgv.SelectAll()
        Clipboard.SetDataObject(dgv.GetClipboardContent)
        dgv.ClearSelection()
    End Sub

    Private Class clsRingDb
        Inherits clsDataBase

        Private _ColList As New List(Of String)

        Public ReadOnly Property ColList As List(Of String)
            Get
                Return _ColList
            End Get
        End Property
        ''' <summary>
        ''' 各コラムの単位
        ''' </summary>
        ''' <returns></returns>
        Public Property Unit As List(Of String)
        ''' <summary>
        ''' 各コラムの小数点位置
        ''' </summary>
        ''' <returns></returns>
        Public Property DigitLoc As List(Of Short)




        Public Sub New()

            ' flex掘削データの最新データを取得
            'NULL以外のデータを表示
            Dim clLst As DataTable = GetDtfmSQL("select * from flex掘削データ ORDER BY 時間 DESC LIMIT 0,1;")

            Dim cl As List(Of String) = (From cc As DataColumn In clLst.Columns Select cc.ColumnName).ToList

            For Each r As DataRow In clLst.Rows
                For Each cName In cl

                    If Not IsDBNull(r.Item(cName)) Then
                        If cName = "時間" Then
                            cName = "DATE_FORMAT(`時間`,' %k:%i:%s' ) AS 時間"
                        End If

                        'アナログTAGより単位を取得
                        If PlcIf.AnalogTag.TagExist(cName) Then
                            Dim Unit As String = PlcIf.AnalogTag.TagData(cName).Unit
                            'Dim Dc As Short = PlcIf.AnalogTag.TagData(cName).DigitLoc

                            Dim fName As String = $"round({cName},{PlcIf.AnalogTag.TagData(cName).DigitLoc + 1})"
                            If Unit <> "" Then
                                cName = $"{fName} AS `{cName}{vbCrLf}({Unit})`"
                            End If
                        End If
                        _ColList.Add(cName)
                    End If
                Next
            Next

        End Sub


        Public Function GetData(RingNo As Integer) As DataTable

            '_ColList.Remove("リング番号")

            Dim dt As DataTable =
                GetDtfmSQL($"SELECT {String.Join(",", _ColList)}  FROM flex掘削データ WHERE リング番号='{RingNo}'")
            Return dt




        End Function






    End Class

End Class