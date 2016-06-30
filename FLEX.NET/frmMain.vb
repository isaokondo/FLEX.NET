Public Class frmMain
    Inherits Windows.Forms.Form



    Private DspGp() As ucnDspGpPres

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()



    End Sub

    Private Sub tmrDataDsp_Tick(sender As Object, e As EventArgs) Handles tmrDataDsp.Tick



        'PLCからの読込表示
        With PlcIf
            DspRingNo.Text = .リング番号 'リングNo

            DspAveStroke.Value = .RealStroke        '平均ストローク

            DspDirection.Value = .Gyro              '方位角

            DspRealBottomStroke.Value = .BotomStroke '下ｽﾄﾛｰｸ
            DspBottomSpeed.Value = .BotomSpeed      '下ｽﾋﾟｰﾄﾞ

            DspUpRealStroke.Value = .TopStroke      '上ｽﾄﾛｰｸ
            DspUpSpeed.Value = .TopSpeed            '上ｽﾋﾟｰﾄﾞ

            DspRightRealStroke.Value = .RightStroke '右ｽﾄﾛｰｸ
            DspRightSpeed.Value = .RightSpeed       '右ｽﾋﾟｰﾄﾞ

            DspLeftRealStroke.Value = .LeftStroke   '左ｽﾄﾛｰｸ
            DspLeftSpeed.Value = .LeftSpeed         '左ｽﾋﾟｰﾄﾞ

            DspJackPress.Value = .JkPress           'ジャッキ圧力

            DspPitching.Value = .Pitching           'ピッチング
            DspHorBroken.Value = .NakaoreLR         '中折左右
            DspVerBroken.Value = .NakaoreTB         '中折上下

            DspFlexControlOn.BitStatus = .FlexControlOn 'FLEXの制御ON/OFF

            '掘進ステータス　掘進中、中断中、待機中
            DspExcavingOn.BitStatus = (.ExcaStatus = cKussin)
            DspExcavingStop.BitStatus = (.ExcaStatus = cChudan)
            DspExcaWaiting.BitStatus = (.ExcaStatus = cTaiki)

            'ジャッキステータス表示
            UcnJackDsp.JackStatus = .JackStatus

            'グループ圧PV
            UcnJackDsp.GroupPV = .GroupPv


        End With
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        With UcnJackDsp
            .NumberGroup = InitParameter.NumberGroup
            .FirstJackLoc = InitParameter.FirstJackLoc
            .FaiJack = InitParameter.FaiJack
            .JackGroupPos = InitParameter.JackGroupPos
            .NumberJack = InitParameter.NumberJack
            Call .DspInitBaseImg()
        End With
        'フォームの大きさを画面

        ReDim DspGp(InitParameter.NumberGroup)


    End Sub

  
    Private Sub MenuSystem_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuSystem.ItemClicked

    End Sub

    Private Sub PlanDataSetting_Click(sender As Object, e As EventArgs) Handles PlanDataSetting.Click

    End Sub
    ''' <summary>
    ''' リング番号変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoChange_Click(sender As Object, e As EventArgs) Handles RingNoChange.Click
        frmRingNoChange.Show()
    End Sub


    ''' <summary>
    ''' リング更新設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RingNoUpdate_Click(sender As Object, e As EventArgs) Handles RingNoUpdateSetting.Click
        frmRinguUpdateSetting.Show()
    End Sub

    Private Sub OperationRight_Click(sender As Object, e As EventArgs) Handles OperationRight.Click

    End Sub

    Private Sub InitialSetting_Click(sender As Object, e As EventArgs) Handles InitialSetting.Click

    End Sub

    Private Sub ReportOut_Click(sender As Object, e As EventArgs) Handles ReportOut.Click

    End Sub

    Private Sub ExcavEnforceStart_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStart.Click

    End Sub

    Private Sub ExcavEnforceStop_Click(sender As Object, e As EventArgs) Handles ExcavEnforceStop.Click

    End Sub

    Private Sub SystemEnd_Click(sender As Object, e As EventArgs) Handles SystemEnd.Click
        If MsgBox("FLEXシステムを終了します。", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "FLEX") = MsgBoxResult.Ok Then
            End
        End If

    End Sub

    Private Sub DspSetting_Click(sender As Object, e As EventArgs) Handles DspSetting.Click

    End Sub

    Private Sub ScaleSetting_Click(sender As Object, e As EventArgs) Handles ScaleSetting.Click

    End Sub

    Private Sub PressParameter_Click(sender As Object, e As EventArgs) Handles PressParameter.Click

    End Sub

    Private Sub OneDirectionParameter_Click(sender As Object, e As EventArgs) Handles OneDirectionParameter.Click

    End Sub

    Private Sub OneDirectionLimit_Click(sender As Object, e As EventArgs) Handles OneDirectionLimit.Click

    End Sub

    Private Sub PresBlock_Click(sender As Object, e As EventArgs) Handles PresBlock.Click

    End Sub

    Private Sub ManagmentMethd_Click(sender As Object, e As EventArgs) Handles ManagmentMethd.Click

    End Sub

    Private Sub LossZeroConcern_Click(sender As Object, e As EventArgs) Handles LossZeroConcern.Click

    End Sub

    Private Sub OterSetting_Click(sender As Object, e As EventArgs) Handles OterSetting.Click

    End Sub

    Private Sub ReloadPlanData_Click(sender As Object, e As EventArgs) Handles ReloadPlanData.Click

    End Sub

    Private Sub SegmentEdit_Click(sender As Object, e As EventArgs) Handles SegmentEdit.Click

    End Sub

    Private Sub AssemblyProcessEdit_Click(sender As Object, e As EventArgs) Handles AssemblyProcessEdit.Click

    End Sub

    Private Sub CorrectionValMng_Click(sender As Object, e As EventArgs) Handles CorrectionValMng.Click
        frmCorrectionValueManagement.Show()
    End Sub

    Private Sub RingCloseValueMng_Click(sender As Object, e As EventArgs) Handles RingCloseValueMng.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Call UcnJackDsp.DspBaseJack()
    End Sub
End Class