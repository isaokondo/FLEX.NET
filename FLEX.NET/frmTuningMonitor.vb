﻿Public Class frmTuningMonitor

    Private GpData(InitPara.NumberGroup - 1) As ucnTuningComp

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmTuningMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load


        For i As Short = 0 To InitPara.NumberGroup - 1
            GpData(i) = New ucnTuningComp
            GpData(i).GpNo = i + 1
            GpData(i).PressScale = CtlPara.PresBarGraphWidt
            GpData(i).Location = New Point(0, GpData(i).Height * i)
            picDsp.Controls.Add(GpData(i))
        Next
        picDsp.Height = GpData(0).Height * InitPara.NumberGroup + 30
        Me.Height = picDsp.Top + picDsp.Height + 60

        GpUpdate() '画面更新

    End Sub

    Private Sub tmrDspUpdate_Tick(sender As Object, e As EventArgs) Handles tmrDspUpdate.Tick
        GpUpdate()
    End Sub
    ''' <summary>
    ''' 画面更新
    ''' </summary>
    Private Sub GpUpdate()
        For i As Short = 0 To InitPara.NumberGroup - 1
            GpData(i).GpPv = PlcIf.GroupPv(i)
            GpData(i).GpSv = PlcIf.GroupSV(i)
            GpData(i).GpMv = PlcIf.GroupMV(i)
            GpData(i).GpFlg = PlcIf.GroupFlg(i)
        Next
    End Sub



    Private Sub AlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub


    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        Me.Close()
    End Sub

    Private Sub AlwaysTopMost_Click(sender As Object, e As EventArgs) Handles AlwaysTopMost.Click
        AlwaysTopMost.Checked = Not AlwaysTopMost.Checked
        Me.TopMost = AlwaysTopMost.Checked
    End Sub

    Private Sub frmTuningMonitor_MenuComplete(sender As Object, e As EventArgs) Handles Me.MenuComplete

    End Sub

    Private Sub frmTuningMonitor_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub frmTuningMonitor_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class