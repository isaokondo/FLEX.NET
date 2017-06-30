Imports System.Math
Public Class frmPressBlock


    Private GroupOptionSvDsp(InitPara.NumberGroup - 1) As NumericUpDown
    Private GroupOptionSvCheck(InitPara.NumberGroup - 1) As CheckBox

    'todo:全開指令の中央値の語句はこれでいいか
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。


        With CtlPara
            'FullPowerMinimumEnable.rdbtnValue = .全開グループ制限
            MinimumFullPowerBlock.Value = .最低全開グループ数
            FullPowerValue.Value = .全開作動指令値
            FullPowerRange.Value = .全開作動範囲
            MinimumContorolPress.Value = .最低制御圧力
            MaxContorolPress.Value = .最大全開出力時の目標圧力

        End With

        DspGruopBlock()

    End Sub

    Friend Overrides Sub btnOK_Click(sender As Object, e As EventArgs)

        'CtlPara.全開グループ制限 = FullPowerMinimumEnable.rdbtnValue
        CtlPara.最低全開グループ数 = MinimumFullPowerBlock.Value
        CtlPara.全開作動指令値 = FullPowerValue.Value
        CtlPara.全開作動範囲 = FullPowerRange.Value

        'todo:最低制御については、未プログラム
        CtlPara.最低制御圧力 = MinimumContorolPress.Value
            CtlPara.最大全開出力時の目標圧力 = MaxContorolPress.Value

        CtlPara.optGpSv =
            (From k In GroupOptionSvDsp Select CSng(k.Value)).ToArray

        CtlPara.optGpEn =
            (From j In GroupOptionSvCheck Where j.Checked Select CShort(GetNum(j.Name) + 1)).ToList

        CtlPara.OptGpSvDic.Clear()
        For i As Short = 0 To InitPara.NumberGroup - 1
            If GroupOptionSvCheck(i).Checked Then
                CtlPara.OptGpSvDic.Add(i + 1, GroupOptionSvDsp(i).Value)
            End If
        Next



        Me.Close()
    End Sub


    ''' <summary>
    ''' 任意圧力設定のグループが変更
    ''' </summary>
    Private Sub GroupCheckChange(sender As Object, e As EventArgs)

        Dim chkBx As CheckBox = CType(sender, CheckBox)
        'チェックボックスのインデックス
        Dim ix As Short = GetNum(chkBx.Name)
        GroupOptionSvDsp(ix).Enabled = chkBx.Checked
        GroupOptionSvDsp(ix).BackColor = IIf(chkBx.Checked, Color.Cyan, Color.LightGray)

    End Sub



    Private Sub DspGruopBlock()


        For i As Integer = 0 To InitPara.NumberGroup - 1
            GroupOptionSvDsp(i) = New NumericUpDown
            GroupOptionSvDsp(i).Visible = True
            GroupOptionSvDsp(i).Size = New Size(58, 22)
            GroupOptionSvDsp(i).DecimalPlaces = 1
            GroupOptionSvDsp(i).Font = New Font("MS UI Gothic", 14, FontStyle.Regular)


            GroupOptionSvDsp(i).TextAlign = HorizontalAlignment.Right
            GroupOptionSvDsp(i).Enabled = False
            GroupOptionSvDsp(i).Visible = True

            GroupOptionSvDsp(i).Name = "GroupPvDsp" & i
            picPressBlock.Controls.Add(GroupOptionSvDsp(i))

            GroupOptionSvCheck(i) = New CheckBox
            GroupOptionSvCheck(i).AutoSize = False
            GroupOptionSvCheck(i).Size = New Size(10, 10)
            GroupOptionSvCheck(i).Name = "GroupOptionSvCheck" & i

            picPressBlock.Controls.Add(GroupOptionSvCheck(i))
            AddHandler GroupOptionSvCheck(i).CheckedChanged, AddressOf GroupCheckChange

        Next


        '最大半径及び中心位置
        Dim canvas As New Bitmap(picPressBlock.Width, picPressBlock.Height)

        Dim g As Graphics = Graphics.FromImage(canvas)

        g.Clear(Color.Transparent)  '消去

        Dim MaxRadios As Integer = Math.Min(picPressBlock.Width, picPressBlock.Height) / 2
        Dim CenterPos As Point = New Point(MaxRadios, MaxRadios)


        Dim fnt As New Font("Arial", 8) 'グループ番号の表示フォント

        Dim GrDgree(InitPara.NumberGroup) As Single ' グループの開始角度


        FillACircle(New SolidBrush(Color.FromArgb(224, 219, 215)), g, CenterPos, MaxRadios * 0.8)
        'グループの区切り線
        For i As Integer = 0 To InitPara.NumberJack - 1
            ''グループの区切り線
            If InitPara.JackGroupPos(i) <> InitPara.JackGroupPos(IIf((i + 1) = InitPara.NumberJack, 0, i + 1)) Then
                Dim St As Single = (InitPara.FaiJack(i) - 360 / InitPara.NumberJack / 2)

                Dim ps As Point() =
                    {New Point(MaxRadios * 0.8 * Cos(St * PI / 180) + CenterPos.X,
                               -MaxRadios * 0.8 * Sin(St * PI / 180) + CenterPos.Y),
                               CenterPos}
                g.DrawLines(Pens.Black, ps)

                GrDgree(InitPara.JackGroupPos(i) - 1) = St

            Else
            End If
            'GrJkNum(InitPara.JackGroupPos(i) - 1) += 1

        Next

        Dim Rd As Integer = MaxRadios * 0.82
        Dim p2 As New Pen(Color.Black, 2)
        DrawACircle(p2, g, CenterPos, Rd)
        Dim p3 As New Pen(Color.DarkGray, 4)
        DrawACircle(p3, g, CenterPos, Rd - 3)
        Dim p4 As New Pen(Color.Black, 1)
        DrawACircle(p4, g, CenterPos, Rd - 5)

        Dim PointRate As Single = 0.55

        '力点数値表示の塗りつぶし
        FillACircle(New SolidBrush(Color.FromArgb(1, 36, 64)), g, CenterPos, MaxRadios * PointRate)


        'ジャッキ番号の表示,ジャッキステータスの表示
        For i = 0 To InitPara.NumberJack - 1
            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(MaxRadios * 0.85 * Cos(InitPara.FaiJack(i) * PI / 180) + CenterPos.X,
                                 -MaxRadios * 0.85 * Sin(InitPara.FaiJack(i) * PI / 180) + CenterPos.Y)
            g.RotateTransform(360 / InitPara.NumberJack * i + IIf(InitPara.FirstJackLoc = "top", 0, 360 / InitPara.NumberJack / 2)) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString, fnt, Brushes.Black, IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)

        Next

        Dim GpWakuRate As Single = 0.7

        PointRate -= 0.03
        'GrDgree(InitPara.NumberGroup) = GrDgree(0)
        For i = 0 To InitPara.NumberGroup - 1
            'グループの中心角度
            Dim j As Integer = IIf(i - 1 < 0, InitPara.NumberGroup - 1, i - 1)
            Dim r As Single = IIf(GrDgree(i) < GrDgree(j), (GrDgree(j) + GrDgree(i)) / 2, (GrDgree(j) + GrDgree(i) + 360) / 2)
            'グループ圧の表示位置
            GroupOptionSvDsp(i).Location = New Point(MaxRadios * GpWakuRate * Cos(r * PI / 180) + CenterPos.X - GroupOptionSvDsp(i).Width / 2,
            -MaxRadios * GpWakuRate * Sin(r * PI / 180) + CenterPos.Y - GroupOptionSvDsp(i).Height / 2)
            GroupOptionSvDsp(i).BringToFront()


            'グループ圧のcheckBoxの表示位置
            GroupOptionSvCheck(i).Location = New Point(MaxRadios * (GpWakuRate - 0.25) * Cos(r * PI / 180) + CenterPos.X - GroupOptionSvCheck(i).Width / 2,
            -MaxRadios * (GpWakuRate - 0.25) * Sin(r * PI / 180) + CenterPos.Y - GroupOptionSvCheck(i).Height / 2)
            'データ読み込み
            GroupOptionSvCheck(i).Checked = CtlPara.optGpEn.Contains(i + 1)
            GroupOptionSvDsp(i).Value = CtlPara.optGpSv(i)

            GroupOptionSvCheck(i).BringToFront()


            ''グループ圧の表示が重なるときは縦位置を調整する
            'If i > 0 Then
            '    If Math.Abs(GroupOptionSvDsp(i).Top - GroupOptionSvDsp(i - 1).Top) < 4 Then
            '        GroupOptionSvDsp(i).Top = GroupOptionSvDsp(i - 1).Top + GroupOptionSvDsp(i - 1).Height + 2
            '    End If

            'End If

            'ワールド座標系リセット
            g.ResetTransform()
            '移動
            g.TranslateTransform(MaxRadios * PointRate * Cos(r * PI / 180) + CenterPos.X,
                                 -MaxRadios * PointRate * Sin(r * PI / 180) + CenterPos.Y)
            g.RotateTransform(90 - r) '回転
            'ジャッキ番号の表示
            g.DrawString((i + 1).ToString, fnt, Brushes.White, IIf(i + 1 >= 10, -fnt.Size, -fnt.Size / 2), -fnt.Size / 2)
            'ジャッキステータス（色識別の表示)


        Next

        picPressBlock.BackgroundImage = canvas


        fnt.Dispose()
        g.Dispose()


    End Sub


End Class