Imports System.Runtime.InteropServices
Public Class frmNextPieceConfirm


    Private Declare Function FlashWindowEx Lib "User32" (ByRef FWInfo As FLASHWINFO) As Int32

    Private Structure FLASHWINFO
        Dim cbSize As Int32    ' FLASHWINFO構造体のサイズ
        Dim hwnd As IntPtr     ' 点滅対象のウィンドウ・ハンドル
        Dim dwFlags As Int32   ' 以下の「FLASHW_XXX」のいずれか
        Dim uCount As Int32    ' 点滅する回数
        Dim dwTimeout As Int32 ' 点滅する間隔（ミリ秒単位）
    End Structure

    ' 点滅を止める
    Private Const FLASHW_STOP As Int32 = 0
    ' タイトルバーを点滅させる
    Private Const FLASHW_CAPTION As Int32 = &H1
    ' タスクバー・ボタンを点滅させる
    Private Const FLASHW_TRAY As Int32 = &H2
    ' タスクバー・ボタンとタイトルバーを点滅させる
    Private Const FLASHW_ALL As Int32 = &H3
    ' FLASHW_STOPが指定されるまでずっと点滅させる
    Private Const FLASHW_TIMER As Int32 = &H4
    ' ウィンドウが最前面に来るまでずっと点滅させる
    Private Const FLASHW_TIMERNOFG As Int32 = &HC

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)
        PlcIf.LosZeroSts_FLEX = 1 '減圧開始
        Me.Close()
    End Sub

    ''' <summary>
    ''' 画面最小化
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim fInfo As New FLASHWINFO()
        fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo))
        fInfo.hwnd = Me.Handle
        fInfo.dwFlags = FLASHW_ALL
        fInfo.uCount = 1000         ' 点滅する回数
        fInfo.dwTimeout = 0

        FlashWindowEx(fInfo)


        Me.WindowState = FormWindowState.Minimized

    End Sub


End Class