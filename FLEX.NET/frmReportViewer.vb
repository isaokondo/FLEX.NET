Public Class frmReportViewer
    ''' <summary>
    ''' 帳票をPDFで表示　Acrobatを利用
    ''' 
    ''' </summary>
    Private _pdfPath As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="PDFF">PDFファイルパス</param>
    Public Sub New(PDFF As String)

        _pdfPath = PDFF

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()


    End Sub

    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

        AxAcroPDF.setShowToolbar(True) 'ツールバー表示
        AxAcroPDF.LoadFile(_pdfPath)
    End Sub
End Class