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
            Dim clLst As DataTable = GetDtfmSQL("show columns from flex掘削データ;")

            Dim cl As List(Of String) = (From cc As DataColumn In clLst.Columns Select cc.ColumnName).ToList

            For Each r As DataRow In clLst.Rows
                'For Each cName In cl
                Dim cName As String = r.Item("Field")
                If Not IsDBNull(r.Item("Field")) Then
                    If r.Item("Field") = "時間" Then
                        _ColList.Add("DATE_FORMAT(`時間`,' %k:%i:%s' ) AS 時間")
                    End If

                    If GetGroupNameEnable(cName) Then
                        If cName.IndexOf("MV") > 0 Then
                            _ColList.Add($"`{cName}` AS `{cName}{vbCrLf}(%)`")
                        End If
                        If cName.IndexOf("SV")>0 Or cName.IndexOf("圧力")>0 Then
                            _ColList.Add($"`{cName}` AS `{cName}{vbCrLf}(MPa)`")
                        End If
                        If cName.IndexOf("制御フラグ") > 0 Then
                            _ColList.Add($"`{cName}` AS `{cName}`")
                        End If

                    Else

                            'アナログTAGより単位を取得
                            If PlcIf.AnalogTag.TagExist(cName) Then
                            Dim Unit As String = PlcIf.AnalogTag.TagData(cName).Unit
                            'Dim Dc As Short = PlcIf.AnalogTag.TagData(cName).DigitLoc

                            Dim fName As String = $"round(`{cName}`,{PlcIf.AnalogTag.TagData(cName).DigitLoc + 1})"
                            If Unit <> "" Then
                                cName = $"{fName} AS `{cName}{vbCrLf}({Unit})`"
                            End If
                            _ColList.Add(cName)
                        End If
                    End If

                End If
                'Next
            Next

        End Sub

        ''' <summary>
        ''' コラム名でグループと言う文字が含まれていて
        ''' 番号がグループ番号内
        ''' </summary>
        ''' <param name="Gstr"></param>
        ''' <returns></returns>
        Private Function GetGroupNameEnable(Gstr As String) As Boolean
            'グループと言う文字が含まれるか？
            Dim tmpBl As Boolean = Gstr.IndexOf("グループ") >= 0
            Dim GrNo As Integer = 999
            If tmpBl Then
                '数値を取得
                Dim tt As String = System.Text.RegularExpressions.Regex.Replace(Gstr, "[^0-9]", "")
                If tt <> "" Then
                    GrNo = CInt(System.Text.RegularExpressions.Regex.Replace(Gstr, "[^0-9]", ""))
                End If
            End If
            Return tmpBl And GrNo <= InitPara.NumberGroup

        End Function



        Public Function GetData(RingNo As Integer) As DataTable

            '_ColList.Remove("リング番号")

            Dim dt As DataTable =
                GetDtfmSQL($"SELECT {String.Join(",", _ColList)}  FROM flex掘削データ WHERE リング番号='{RingNo}'")
            Return dt




        End Function






    End Class

End Class