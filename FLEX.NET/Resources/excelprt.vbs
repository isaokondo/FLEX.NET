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
objXls.AutomationSecurity= 2
Set objXlsBook=objXls.WorkBooks.Open( WScript.Arguments(0), , True)
objXlsBook.PrintOut 1 , 1
WScript.Quit (Err.Number)
objXlsBook.Close False
Set objXlsBook = Nothing
objXls.Quit
Set objXls = Nothing
