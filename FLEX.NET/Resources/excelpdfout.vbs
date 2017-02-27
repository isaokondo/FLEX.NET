'EXCELを印刷する　VBS
'引数をフルパスで
'戻り値
'0:正常
'それ以外、異常
'VB.net でエクセルを印刷するとバージョンの違いで
'他の環境のPCだとエラーになる可能でしがあるので
'VBSで実行する

Option Explicit
On Error Resume Next
Dim objXls
Dim objXlsBook
Set objXls = CreateObject("Excel.Application")



Dim pdfPath
'pdfファイル名生成
pdfPath = Replace(WScript.Arguments(0),".xlsx",".PDF")

'WScript.Echo pdfPath & "：PDFファイル名"


objXls.AutomationSecurity= 2

Set objXlsBook=objXls.WorkBooks.Open( WScript.Arguments(0), , True)

  objXlsBook.ExportAsFixedFormat 0, pdfPath

'				WScript.Echo Err.Number & "：ErrNum"

WScript.Quit (Err.Number)
objXlsBook.Close False
Set objXlsBook = Nothing
objXls.Quit
Set objXls = Nothing
