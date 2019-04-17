Imports Microsoft.Office.Interop
Public Class clsExcelToDtGrd

    Private oXls As Excel.Application = Nothing ' Excelオブジェクト
    Private oWBook As Excel.Workbook = Nothing ' Workbookオブジェクト
    Private olWBooks As Excel.Workbooks = Nothing
    Private oSheet As Excel.Worksheet = Nothing ' Workbookオブジェクト


    Private AutoSurveyingExcelPath As String = Application.StartupPath & "\自動測量Ver1.xlsm"
    'Private AutoSurveyingExcelPath As String = Application.StartupPath & "\Book1.xlsm"


    Private CellData As Object(,)


    ''' <summary>
    ''' 計算実行し、シートデータを2次元配列に取得
    ''' </summary>
    Public Sub Culc()

        oXls.Run("Cul_NewVMachine")

        CellData = DirectCast(oWBook.ActiveSheet.Range("A1:BA76").value, Object(,))
    End Sub


    Public ReadOnly Property Cell(row As Integer, col As Integer, digitloc As Short) As String
        Get
            Dim cellStr As String = CellData(row + 1, col + 1)
            If IsNumeric(cellStr) Then
                Return Val(cellStr).ToString($"F{digitloc}")
            Else
                Return cellStr
            End If

        End Get
    End Property

    Public ReadOnly Property Cell(rngName As String, digitloc As Short) As String
        Get
            Dim cellStr As String = oWBook.ActiveSheet.Range(rngName).value
            If IsNumeric(cellStr) Then
                Return Val(cellStr).ToString($"F{digitloc}")
            Else
                Return cellStr
            End If

        End Get
    End Property


    Public Sub Caluc()
        oXls.Run("Cul_NewVMachine")
    End Sub




    Public ReadOnly Property Range(rngName As String) As Excel.Range
        Get
            Return oWBook.ActiveSheet.Range(rngName)
        End Get
    End Property

    Public Property rang(rowl As Integer, col As Integer) As Excel.Range
        Get
            Return DirectCast(oSheet.Cells(1, 1), Excel.Range)
        End Get
        Set(value As Excel.Range)

        End Set
    End Property

    ' 指定されたワークシート名のインデックスを返すメソッド
    Private Function getSheetIndex(ByVal sheetName As String, ByVal shs As Excel.Sheets) As Integer
        Dim i As Integer = 0
        For Each sh As Microsoft.Office.Interop.Excel.Worksheet In shs
            If sheetName = sh.Name Then
                Return i + 1
            End If
            i += 1
        Next
        Return 0
    End Function
    Public Sub New()

        oXls = New Excel.Application()
        oXls.Visible = True ' 確認のためExcelのウィンドウを表示する

        olWBooks = oXls.Workbooks
        oWBook = olWBooks.Open(AutoSurveyingExcelPath)


        ' Excelファイルをオープンする
        '      oWBook = DirectCast((oXls.Workbooks.Open(
        '        AutoSurveyingExcelPath)),
        '        Excel.Workbook)

        '      oSheet = DirectCast(oWBook.Sheets(
        'getSheetIndex("ﾏｼﾝ座標6", oWBook.Sheets)), Excel.Worksheet)


    End Sub

    Public Sub ExcelClose()
        ReleaseCOMObject(oSheet)

        oWBook.Close(False)

        ReleaseCOMObject(oWBook)
        ReleaseCOMObject(olWBooks)

        oXls.Quit()
        ReleaseCOMObject(oXls)

    End Sub



    Protected Overrides Sub Finalize()


        MyBase.Finalize()
    End Sub

    '■====================================================■
    '■ COMオブジェクトの解放
    '■====================================================■
    Public Shared Sub ReleaseCOMObject(Of T As Class)(ByRef objCom As T)

        'オブジェクトが空の場合処理を抜ける
        If objCom Is Nothing Then
            Return
        End If

        Try
            'パラメタがCOMオブジェクトかチェック
            If System.Runtime.InteropServices.Marshal.IsComObject(objCom) Then

                'Runtime Callable Wrapperの解放を行う
                Dim cntRCW As Integer = System.Runtime.InteropServices.Marshal.FinalReleaseComObject(objCom)

                If cntRCW <> 0 Then
                    '解放しきれていない場合、メッセージを出力
                    MessageBox.Show("解放エラー")
                End If

            End If

        Finally
            objCom = Nothing
        End Try

    End Sub
End Class
