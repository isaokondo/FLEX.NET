Option Strict Off
Option Explicit On
Friend Class clsEstmateValeu
    ' @(h) clsEstmateValeu              ver 1.0 ( '01.07.11 近藤　勲 )
    ' @(h) clsEstmateValeu              ver 1.1 ( '01.09.18 近藤　勲 )
    'mdbl元圧予測の予測値の演算修正
    ' @(h) clsEstmateValeu              ver 1.2 ( '01.09.19 近藤　勲 )
    'mdblモーメントの予測値の演算修正
    ' @(s)
    'mdblモーメントの予測値の演算修正　　　ver 1.3('02.05.31 近藤　勲）
    ' @(s)
    '１グループのジャッキが一番ジャッキより前の番号の場合グループの中心角度の
    '算出方法にバグがあった。そのためモーメント予測値が正しく演算されなかった。
    '南住吉で発見！！！
    '
    'mdblモーメントの予測値の演算修正　　　ver 1.4('02.11.05 近藤　勲）
    ' @(s)
    ' グループの中心角度を求める個所にバグあり。
    '次回よりFEXL.INIに記述するぞ！

    'mdblモーメントの予測値の演算修正　　　ver 1.5('04.10.26 近藤　勲）

    '稼働ジャッキのみの条件を追加

    Private mdbl分担率指令値() As Double

    Private mdblジャッキ圧 As Double
    Private mdbl元圧予測 As Double
    Private mdblモーメント予測 As Double

    Public ReadOnly Property 元圧予測() As Double
        Get
            元圧予測 = mdbl元圧予測
        End Get
    End Property

    Public ReadOnly Property モーメント予測() As Double
        Get
            モーメント予測 = mdblモーメント予測
        End Get
    End Property


    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()
        ''配列の初期化
        'UPGRADE_WARNING: 配列 mdbl分担率指令値 の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim mdbl分担率指令値(InitParameter.NumberGroup)
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub


    Public Sub sbCulc()
        ' @(f)
        '
        ' 機能      :推力分担率の計算
        '
        ' 返り値    :なし
        ' 　　　    :
        '
        ' 機能説明  :元圧、ﾓｰﾒﾝﾄの予測値の演算
        '
        ' 備考      :


        Dim intCnt As Short ''カウンター
        Dim intGpJk() As Short
        Dim sngFaiGp() As Single
        Dim dblEachThrust() As Double ''各グループの推力
        Dim dblHosePres() As Double
        Dim dblEachJkThrust() As Double


        Dim dblMaxBuntan As Double ''分担率最大値
        ''分担率の最大値を求める
        For intCnt = 1 To InitParameter.NumberGroup

            ''分担指令値の取り込み
            mdbl分担率指令値(intCnt) = DivCul.分担率指令値(intCnt)

            If dblMaxBuntan < mdbl分担率指令値(intCnt) Then
                dblMaxBuntan = mdbl分担率指令値(intCnt)
            End If
            '    Debug.Print intCnt, mdbl分担率指令値(intCnt)
        Next intCnt

        ''各グループ毎のジャッキ本数を求める
        'UPGRADE_WARNING: 配列 intGpJk の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim intGpJk(InitParameter.NumberGroup) ''各グループ毎のジャッキ本数

        '稼働ジャッキのみの条件を追加
        For intCnt = 1 To InitParameter.NumberJack
            If PlcIf.JackSel(intCnt) Then
                intGpJk(InitParameter.JackGroupPos(intCnt)) = intGpJk(InitParameter.JackGroupPos(intCnt)) + 1
            End If
        Next intCnt
        If dblMaxBuntan = 0 Then Exit Sub

        ''②その分担率の最大推力を計算する。
        'UPGRADE_WARNING: 配列 dblEachThrust の下限が 1 から 0 に変更されました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"' をクリックしてください。
        ReDim dblEachThrust(InitParameter.NumberGroup) ''各グループの推力
        Dim dblMaxThrust As Double ''最大推力
        For intCnt = 1 To InitParameter.NumberGroup
            mdbl分担率指令値(intCnt) = mdbl分担率指令値(intCnt) / dblMaxBuntan

            dblEachThrust(intCnt) = mdbl分担率指令値(intCnt) * InitParameter.JackPower * intGpJk(intCnt)

            ''最大推力の加算
            dblMaxThrust = dblMaxThrust + dblEachThrust(intCnt)

        Next intCnt


        'mdbl元圧予測 = frmFLEX.clsMoment.推力 / dblMaxThrust * initParameter.PresScale
        ''01/09/18 修正
        mdbl元圧予測 = CulcMoment.推力 / dblMaxThrust * InitParameter.JackMaxOilPres

        ''圧力補正の算出
        ''⑤最低ジャッキ圧力を考慮してI欄の圧力を補正する｡
        ''⑥圧力補正から各ジャッキ推力を計算する。
        ''⑦このジャッキ推力からﾓｰﾒﾝﾄを計算する。

        Dim intJkNumber As Short
        Dim sngStartRad As Single
        Dim dblMomentX As Double
        Dim dblMomentY As Double ''グループの終了角度 ''グループの開始角度
        With InitParameter
            ReDim sngFaiGp(.NumberGroup)

            ''02/05/31 追加　Ver 1.3
            If .JackGroupPos(.NumberJack) = 1 Then
                intJkNumber = .NumberJack
                Do While .JackGroupPos(intJkNumber - 1) = 1
                    intJkNumber = intJkNumber - 1
                Loop
            Else
                intJkNumber = 1
            End If

            '    intJkNumber = 1
            ''各グループごとの中心角度を求める
            For intCnt = 1 To .NumberGroup
                sngStartRad = .FaiJack(intJkNumber)
                Do
                    '02/11/05 追加　Ver 1.4
                    ''飛島石田北対応、次回の現場よりはINIファイルにセットする
                    ''飛島高井田で追加　03/08/18
                    If intJkNumber = .NumberJack Then intJkNumber = 1
                    intJkNumber = intJkNumber + 1
                    ''02/05/31 追加　Ver 1.3
                    'intJkNumber = IIf(intJkNumber = .NumberJack, 1, intJkNumber + 1)
                Loop While intCnt = .JackGroupPos(intJkNumber)
                ''開始と終了の平均を求める
                If sngStartRad >= .FaiJack(intJkNumber - 1) Then
                    sngFaiGp(intCnt) = (sngStartRad + .FaiJack(intJkNumber - 1)) / 2
                Else
                    '            sngFaiGp(intCnt) = (sngStartRad + 360 - .FaiJack(intJkNumber - 1)) / 2
                    'ver 1.3('02.05.31 近藤　勲）
                    'バグ　02/05/31発見　修正
                    sngFaiGp(intCnt) = (sngStartRad - 360 + .FaiJack(intJkNumber - 1)) / 2
                End If
            Next intCnt
            ReDim dblHosePres(.NumberGroup)
            ReDim dblEachJkThrust(.NumberGroup)

            For intCnt = 1 To .NumberGroup
                ''圧力補正を求める
                dblHosePres(intCnt) = mdbl元圧予測 * mdbl分担率指令値(intCnt)
                ''最低ジャッキ圧力を考慮
                If dblHosePres(intCnt) <= 2 Then dblHosePres(intCnt) = 2
                ''各ジャッキ推力を計算する。
                '        dblEachJkThrust(intCnt) = _
                'dblHosePres(intCnt) / .PresScale * .JackPower * intGpJk(intCnt)
                ''01/09/19 修正
                dblEachJkThrust(intCnt) = dblHosePres(intCnt) / .JackMaxOilPres * .JackPower * intGpJk(intCnt)

                ''X方向モーメント計算,各グループ毎の加算
                dblMomentX = dblMomentX - dblEachJkThrust(intCnt) * .JackRadius * System.Math.Cos(sngFaiGp(intCnt) * cPI / 180)
                ''Y方向モーメント計算,各グループ毎の加算
                dblMomentY = dblMomentY + dblEachJkThrust(intCnt) * .JackRadius * System.Math.Sin(sngFaiGp(intCnt) * cPI / 180)


            Next intCnt
        End With

        mdblモーメント予測 = System.Math.Sqrt(dblMomentX ^ 2 + dblMomentY ^ 2)

        'Debug.Print "モーメント予測 =" & Format(mdblモーメント予測, "0#.##")
        'Debug.Print "元圧予測 =" & Format(mdbl元圧予測, "0#.#")
    End Sub
End Class