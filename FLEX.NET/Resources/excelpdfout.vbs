'EXCEL���������@VBS
'�������t���p�X��
'�߂�l
'0:����
'����ȊO�A�ُ�
'VB.net �ŃG�N�Z�����������ƃo�[�W�����̈Ⴂ��
'���̊���PC���ƃG���[�ɂȂ�\�ł�������̂�
'VBS�Ŏ��s����

Option Explicit
On Error Resume Next
Dim objXls
Dim objXlsBook
Set objXls = CreateObject("Excel.Application")



Dim pdfPath
'pdf�t�@�C��������
pdfPath = Replace(WScript.Arguments(0),".xlsx",".PDF")

'WScript.Echo pdfPath & "�FPDF�t�@�C����"


objXls.AutomationSecurity= 2

Set objXlsBook=objXls.WorkBooks.Open( WScript.Arguments(0), , True)

  objXlsBook.ExportAsFixedFormat 0, pdfPath

'				WScript.Echo Err.Number & "�FErrNum"

WScript.Quit (Err.Number)
objXlsBook.Close False
Set objXlsBook = Nothing
objXls.Quit
Set objXls = Nothing
