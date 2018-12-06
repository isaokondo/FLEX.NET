Imports System.Runtime.InteropServices
Public Class frmRollingOverAlarm

    Private blnBlinkFlg As Boolean
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub

    Private Sub frmRollingOverAlarm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        lblLoszeroRollingTolerance.Text = "ピース端部の余裕許容値 " & $" {CtlPara.LoszeroRollingTolerance.ToString("F2")} deg"
    End Sub
    Public Function GetMainWindowHandle(ByVal processName As String) As IntPtr

        Dim curProcess As Process = Process.GetCurrentProcess()
        Dim allProcesses() As Process =
          Process.GetProcessesByName(processName)

        For Each oneProcess As Process In allProcesses
            If oneProcess.MainWindowHandle <> IntPtr.Zero Then
                Return oneProcess.MainWindowHandle
            End If
        Next

        ' 指定したプロセス名のアプリケーションが見つからない！
        Return IntPtr.Zero
    End Function

    Private Sub tmrBlink_Tick(sender As Object, e As EventArgs) Handles tmrBlink.Tick
        blnBlinkFlg = Not blnBlinkFlg
        lblRollingAlarm.ForeColor = If(blnBlinkFlg, Color.Black, Color.Red)
    End Sub
End Class