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
objXls.AutomationSecurity= 2
Set objXlsBook=objXls.WorkBooks.Open( WScript.Arguments(0), , True)
objXlsBook.PrintOut 1 , 1
WScript.Quit (Err.Number)
objXlsBook.Close False
Set objXlsBook = Nothing
objXls.Quit
Set objXls = Nothing
