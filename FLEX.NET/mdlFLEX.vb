Option Explicit On
Imports System.Math
Module mdlFLEX

    Public InitParameter As New clsInitParameter '初期値パラメータ
    'Public clsPlanLine As clsPlanLineRead ''計画路線読みこみ
    Public HorPlan As New clsHorPanData '平面掘進計画線
    Public VerPlan As New clsVerPlanData '縦断掘進計画線

    Public MachineSpec As New clsMachinSpec 'シールドマシン諸元

    Public clsSegMakDat As clsSegmentMakeData ''セグメント組立データ

    Public clsEstValue As clsEstmateValeu ''元圧とモーメントの予測値 04/09/21

    Public ControlParameter As New clsControlParameter  '制御パラメータ

    Public CulcMoment As New clsCulMoment ''モーメント、推力の演算

    Public WithEvents JackMvAuto As clsCulJackMv ''ジャッキ操作量の演算

    Public DivCul As New clsThrustDiv ''推力分担率の演算

    Public clsKijunHoui As clsCulKijun ''基準方位演算

    Private WithEvents JackManual As clsJkManualOut ''ジャッキ手動操作出力

    'PLCインターフェース
    Public WithEvents PlcIf As New clsPlcIf

    Public Const cPI = 3.14159265358979     ''円周率

    Public Const cDirectOut As Short = &HAAS ''圧力指令値のﾀﾞｲﾚｸﾄ出力
    Public Const cPIDOut As Short = &HFFS ''PID演算開始
    Public Const cIgnoreOut As Short = &H22S ''待機中につき演算無視
    ''01.09.20  追加
    Public Const cTracking As Short = &H44S ''減圧弁トラッキング

    Public Const c全押しスタート As Short = 0
    Public Const c前回値保持 As Short = 1
    Public Const c減圧前 As Short = 2

    Public Const cMAX_Ring As Short = 10000

    ''04/08/11 仮リング対応
    Public Const cStart_Ring As Short = -10

    Public Const cMAX_SegType As Short = 50 ''02/10/24 追加

    Public Const cMaxJackNum As Short = 60 ''最大ジャッキ本数　03/01/10 追加

    Public gblnNoPlc As Boolean ''ＰＬＣなしの場合のモード（デモバージョン）

    ''掘進ステータス定数
    Public Const cTaiki As Short = 1 ''待機中
    Public Const cKussin As Short = 2 ''掘進中
    Public Const cChudan As Short = 3 ''中断中

    Public gdblToStartDistance As Double ''起点から発進座標までの累積距離


    Public Sub Main()
        'ControlParameter.ストローク管理法 = 1
        Dim intSheetID As Integer = 20
        HorPlan.DataRead(intSheetID)
        VerPlan.DataRead(intSheetID)
        Application.Run(New frmMain())
    End Sub

    Private Sub PlcIf_PLCErrOccur(sender As Object, ByVale As EventArgs, ErrMsg As String) Handles PlcIf.PLCErrOccur
        Dim response = MsgBox("PLC通信エラー:" & ErrMsg, MsgBoxStyle.AbortRetryIgnore)
        If response = MsgBoxResult.Abort Then End
    End Sub


    Private Sub PLCIF_PLCRead(sender As Object, ByVale As EventArgs) Handles PlcIf.PLCRead

    End Sub
    

  
  


    Public Function Arcsin(ByRef x As Double) As Double
        ''アークサイン

        If x <= -1 Then
            Arcsin = -cPI / 2
            Exit Function
        End If
        If x >= 1 Then
            Arcsin = cPI / 2
            Exit Function
        End If

        Arcsin = Atan(x / Sqrt(-x * x + 1))

    End Function
    Function Hoko2Hoi(ByRef Hoko As Double) As Double
        ''左回り角度±１８０度を方位角に変換
        '   '01/06/28 追加
        '   Hoko = Lim180(Hoko)
        '   Hoko2Hoi = -Hoko
        '   If Hoko2Hoi < 0 Then
        '       Hoko2Hoi = Hoko2Hoi + 360
        '   End If
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        '左回りを右回りに変換し、値を０～３６０に調整
        Hoko2Hoi = -Hoko
        Do While Hoko2Hoi < 0 Or Hoko2Hoi > 360
            If Hoko2Hoi < 0 Then
                Hoko2Hoi = Hoko2Hoi + 360
            End If
            If Hoko2Hoi > 360 Then
                Hoko2Hoi = Hoko2Hoi - 360
            End If
        Loop
    End Function

    Public Function Hoi2Hoko(ByVal Hoi As Double) As Double
        '方位角（右回り０～３６０）を左回り角度±１８０度に変換

        '   Hoi2Hoko = 360 - Hoi
        '   Hoi2Hoko = Lim180(Hoi2Hoko)
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Hoi2Hoko = 360 - Hoi
        Do While Hoi2Hoko < 0 Or Hoi2Hoko > 360
            If Hoi2Hoko < 0 Then
                Hoi2Hoko = Hoi2Hoko + 360
            End If
            If Hoi2Hoko > 360 Then
                Hoi2Hoko = Hoi2Hoko - 360
            End If
        Loop

    End Function
    Public Function Lim180(ByVal Kakudo As Double) As Double
        '０～３６０度の角度を同回りの±１８０度に変換

        '   If Kakudo > 180 Then
        '       Lim180 = Kakudo - 360
        '   Exit Function
        '   End If
        '
        '   If Kakudo < -180 Then
        '       Lim180 = 360 + Kakudo
        '   Exit Function
        '   End If
        '
        '   Lim180 = Kakudo
        '**<<変更履歴>> 方位計算異常の修正(2003/03/18)
        Do While Kakudo > 180 Or Kakudo < -180
            If Kakudo > 180 Then
                Kakudo = Kakudo - 360
            End If
            If Kakudo < -180 Then
                Kakudo = 360 + Kakudo
            End If
        Loop
        Lim180 = Kakudo
        Exit Function

    End Function


    Public Function fnNearZero(ByVal vData As Double) As Boolean
        ' @(f)
        '
        ' 機能      :限りなき小さい値はゼロにする
        '
        '
        ' 返り値    :ゼロかどうか？
        ' 　　　    :
        '
        ' 機能説明  :実数判定用幅ΔCの範囲内の値の時は真
        '
        ' 備考      :


        Const cDeltaC As Double = 0.0001

        If vData >= -cDeltaC And vData <= cDeltaC Then
            fnNearZero = True
        Else
            fnNearZero = False
        End If





    End Function




    Public Function fnDegToPermili(ByRef dblDeg As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :ディグリーをパーミリへ変換
        '
        ' 引数      :
        '
        ' 備考      :02/09/11 追加

        Return Tan(dblDeg * cPI / 180) * 1000


    End Function


    Public Function fnPermiliToDeg(ByRef dblPermili As Double) As Double
        ' @(f)
        '
        ' 機能      :単位の変換
        '
        ' 機能説明  :パーミリをディグリーへ変換
        '
        ' 引数      :
        '
        ' 備考      :02/10/08 追加

        Return Atan(dblPermili / 1000) / (cPI / 180)


    End Function


    
    Private Sub JackMvAuto_制御モードフラグChanges(intMode As Short) Handles JackMvAuto.制御モードフラグChanges

    End Sub



    Public Sub sbZahyoGtoL(ByRef dblLx As Double, ByRef dblLy As Double, ByVal dblGX As Double, ByVal dblGY As Double, ByVal dblGX0 As Double, ByVal dblGY0 As Double, ByVal sngAlfa0 As Double)
        ' @(f)
        '
        ' 機能      :ローカルからグローバル座標への変換
        ' 返り値    :
        '
        '
        ' 機能説明  :
        '
        ' 備考      :
        ''

        'Lx,Ly  変換対象のローカル座標値（出力値）
        'Gx,Gy  変換対象のグローバル座標値（入力値）
        'X0,Y0  変換中心のグローバル座標値（入力値）
        'Alfa0　変換中心のグローバル座標上の方向角(deg)（入力値）

        Dim dblCT, dblST As Double

        dblCT = Cos(Lim180(sngAlfa0) * cPI / 180)
        dblST = Sin(Lim180(sngAlfa0) * cPI / 180)
        dblLx = dblCT * (dblGX - dblGX0) + dblST * (dblGY - dblGY0)
        dblLy = -dblST * (dblGX - dblGX0) + dblCT * (dblGY - dblGY0)

    End Sub



    Private Function Kai(ByVal N As Integer) As Double
        'Ｎの階上
        Dim i As Integer

        Kai = 1
        If N = 0 Then
            Exit Function
        End If

        For i = 1 To N
            Kai = Kai * i
        Next

    End Function


    Public Function f(ByVal L As Double, ByVal R As Double) As Double
        'ﾕｰｻﾞｰ関数 ｆ
        Dim Sigma As Double
        Dim LR As Double
        Dim k As Short

        If R <> 0 Then
            LR = L / (2 * R)
        Else
            LR = 0
        End If
        Sigma = 0
        For k = 1 To 5
            Sigma = Sigma + 1 / ((4 * k - 3) * Kai(2 * k - 2)) * (-1) ^ (k + 1) * LR ^ (2 * k - 2)
        Next
        Return L * Sigma

    End Function


    Public Function g(ByVal L As Double, ByVal R As Double) As Double
        'ﾕｰｻﾞｰ関数 ｆ
        Dim Sigma As Double
        Dim LR As Double
        Dim k As Short

        If R <> 0 Then
            LR = L / (2 * R)
        Else
            LR = 0
        End If
        Sigma = 0
        For k = 1 To 5
            Sigma = Sigma + 1 / ((4 * k - 1) * Kai(2 * k - 1)) * (-1) ^ (k + 1) * LR ^ (2 * k - 1)
        Next
        g = L * Sigma

    End Function
End Module