'Option Strict On
Option Explicit On
Friend Class clsCulKijun
    ' @(h) clsCulKijun.cls                ver 1.0 ( '01.02.16 近藤　勲 )
    ' @(h) clsCulKijun.cls                ver 1.1 ( '01.06.25 近藤　勲 )
    ' @(h) clsCulKijun.cls                ver 1.2 ( '02.10.04 近藤　勲 )
    ' @(h) clsCulKijun.cls                ver 1.3 ( '03.10.20 近藤　勲 )
    ' 掘進総距離の演算場所の変更　clsCulcDistanceへ移動


    ' @(s) 基準方位の算出
    '
    ' ver 1.1 中折れ演算修正のため


    ''鹿島品川線対応 08/01/08
    Public StartKijun As clsLineMake ''発進位置

    Public HorSentanKijun As clsLineMake ''先端位置
    Public HorKodoKijun As clsLineMake ''後胴中心
    Public NakaoreKijun As clsLineMake ''中折位置



    ''平面
    Public HorZendoKijun As clsLineMake ''前銅中心
    Public HorNakaKodo As clsCulNakaore1 ''中折れ演算（後胴中心で検討）
    Public HorNakaCul As clsCulNakaore2 ''中折れ計算2（構築中心の方向角で検討）

    ''縦断
    Public VerSentanKijun As clsLineMake ''先端位置
    Public VerKodoKijun As clsLineMake ''後胴中心
    Public VerZendoKijun As clsLineMake ''前銅中心
    Public VerNakaKodo As clsCulNakaore1 ''中折れ演算（後胴中心で検討）
    Public VerNakaCul As clsCulNakaore2 ''中折れ計算2（構築中心の方向角で検討）

    Private mdbl平面基準方位 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private mdbl縦断基準方位 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ

    ''02/10/04 追加
    Private mdbl平面計画方位 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ
    Private mdbl縦断計画方位 As Double 'ﾛｰｶﾙ ｺﾋﾟｰ

    ''鹿島品川線対応 08/01/08　中折れ対応
    Private mdbl平面中折角度 As Double
    Private mdbl平面旋回中心 As Double
    Private mdbl縦断中折角度 As Double
    Private mdbl縦断旋回中心 As Double

    Private mdbl平面後胴中心 As Double
    Private mdbl縦断後胴中心 As Double

    Private _平面偏角 As Double
    Private _縦断偏角 As Double



    ''掘進総距離取得用クラスをモジュール変数に変更　鹿島品川線より
    ''' <summary>
    ''' 掘進総距離取得用クラスの設定
    ''' </summary>
    Public Distance As clsCulcDistance ''





    Public Property 縦断基準方位() As Double
        Get
            Return mdbl縦断基準方位
        End Get
        Set(ByVal Value As Double)
            mdbl縦断基準方位 = Value
        End Set
    End Property


    Public Property 平面基準方位() As Double
        Get
            Return mdbl平面基準方位
        End Get
        Set(ByVal Value As Double)
            mdbl平面基準方位 = Value
        End Set
    End Property

    '02/10/04追加
    Public ReadOnly Property 縦断計画方位() As Double
        Get
            Return mdbl縦断計画方位
        End Get
    End Property

    Public ReadOnly Property 平面計画方位() As Double
        Get
            '平面計画方位 = Hoi2Hoko(mdbl平面計画方位 + clsPlanLine.HorPlan.X軸方位角)
            Return (mdbl平面計画方位 + HorPlan.X軸方位角)  'clsPlanLine.HorPlan.X軸方位角)
        End Get
    End Property
    ''鹿島品川線対応
    Public ReadOnly Property 平面中折角度() As Double
        Get
            Return mdbl平面中折角度
        End Get
    End Property
    Public ReadOnly Property 平面旋回中心() As Double
        Get
            Return mdbl平面旋回中心
        End Get
    End Property
    Public ReadOnly Property 縦断中折角度() As Double
        Get
            Return mdbl縦断中折角度
        End Get
    End Property
    Public ReadOnly Property 縦断旋回中心() As Double
        Get
            Return mdbl縦断旋回中心
        End Get
    End Property

    Public ReadOnly Property 平面偏角 As Double
        Get
            Return Lim180(PlcIf.Gyro - mdbl平面基準方位)
        End Get
    End Property

    Public ReadOnly Property 縦断偏角 As Double
        Get
            Return PlcIf.Pitching - mdbl縦断基準方位
        End Get
    End Property



    ''' <summary>
    ''' 基準方位の算出
    ''' </summary>
    Public Sub sbCulKijun()
        ' @(f)
        '
        ' 機能      :基準方位の算出
        '
        ' 返り値    :なし
        ' 　　　    :
        '
        ' 機能説明  :
        '
        ' 備考      :鹿島品川線より大幅変更

        'Dim clsDistance As clsCulcDistance      ''掘進総距離取得用クラスの設定
        'Set clsDistance = New clsCulcDistance

        Dim dbl後胴長 As Double

        dbl後胴長 = MachineSpec.KodoLen

        Dim clsSetKoudouC As clsSet_KoudouC ''後胴中心を抽出する
        clsSetKoudouC = New clsSet_KoudouC


        Dim dblSentanDistance As Double ''先端距離

        Dim dblKodoMae As Double
        dblKodoMae = MachineSpec.HorKodoCenter - MachineSpec.HorZendoCenter

        With ControlParameter
            If PlcIf.RingNo <> 0 Then
                Distance.現在のリング番号 = PlcIf.RingNo
                Distance.測量ポイントリング番号 = .測量ポイントリング番号
                Distance.測量ポイント総距離 = .測量ポイント総距離

                'dblSentanDistance = clsDistance.掘進総距離
                ''鹿島品川線対応　 計画線起点、発進点に伴う変更
                dblSentanDistance = Distance.掘進総距離 '+ gdblToStartDistance

            End If
        End With




        'Set clsDistance = Nothing

        HorSentanKijun = New clsLineMake
        HorKodoKijun = New clsLineMake
        HorZendoKijun = New clsLineMake

        HorNakaKodo = New clsCulNakaore1
        HorNakaCul = New clsCulNakaore2

        mdbl平面後胴中心 = MachineSpec.HorKodoCenter


        Dim HorKodoCenTmp As clsLineMake
        If MachineSpec.ShieldTypeHor = 1 Then 'Then 'ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの平面中折れ使用（0:使用しない 1:使用する）を調べ、処理を選択
            If MachineSpec.HorSel = 1 Then '修正080906　姿勢・中折れ角の計算ロジックを計算方法別に完全分離
                '計画線ｿﾞｰﾝ毎の中折れﾃﾞｰﾀを採用
                '○先端位置
                '品川線対応変更　07/12/08 計画線起点、発進点に伴う変更
                HorSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance

                '○後胴中心位置の抽出（中折れ点位置より計画線データから最も近い位置の後胴中心設定データを探す）
                '        HorKodoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 _
                '- (initParameter.ZendoLen + initParameter.KodoLen)

                ''中折位置（後銅中心の抽出のみに使用） 08/08/25
                NakaoreKijun = New clsLineMake
                '○後胴中心位置の抽出（中折れ点位置より計画線データから最も近い位置の後胴中心設定データを探す）
                '      NakaoreKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - initParameter.ZendoLen
                '        dblKodoMae = fnGetKodoCenter - initParameter.ZendoLen

                '○後胴中心位置の抽出（中折れ点位置より計画線データから最も近い位置の後胴中心設定データを探す）
                HorKodoCenTmp = New clsLineMake
                HorKodoCenTmp.掘進累積距離 = HorSentanKijun.掘進累積距離 - MachineSpec.ZendoLen

                clsSetKoudouC.ゾーン番号 = HorKodoCenTmp.平面ゾーン番号
                clsSetKoudouC.ゾーン掘進距離 = HorKodoCenTmp.掘進累積距離
                clsSetKoudouC.ゾーン残距離 = HorKodoCenTmp.平面ゾーン内残距離
                clsSetKoudouC.ゾーン総数 = HorPlan.ゾーン総数
                clsSetKoudouC.線形 = CType(HorPlan.線形.Clone, Integer())
                clsSetKoudouC.中折 = HorPlan.中折.Clone
                clsSetKoudouC.前胴中心 = HorPlan.前胴中心.Clone
                clsSetKoudouC.後胴中心 = HorPlan.後胴中心.Clone
                clsSetKoudouC.線分長 = HorPlan.線分長.Clone
                clsSetKoudouC.sbCul()
                If clsSetKoudouC.抽出フラグ = 1 And clsSetKoudouC.抽出ゾーン掘進距離 <= MachineSpec.MachiLength Then
                    mdbl平面後胴中心 = clsSetKoudouC.抽出後胴中心
                End If
                dbl後胴長 = mdbl平面後胴中心 - MachineSpec.ZendoLen

                '○後胴位置
                HorKodoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - (MachineSpec.ZendoLen + dbl後胴長)



                '2010/4/7 修正
                ' HorZendoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - initParameter.HorZendoCenter
                '        HorKodoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 _
                '- (initParameter.ZendoLen + dblKodoMae)


                ''------平面----------

                '中折れ計算１（後胴中心で検討）
                With HorNakaKodo
                    .ZoneNo = HorKodoKijun.平面ゾーン番号
                    .ゾーン掘進距離 = HorKodoKijun.平面ゾーン掘進距離
                    .ゾーン残距離 = HorKodoKijun.平面ゾーン内残距離
                    .前胴長 = MachineSpec.ZendoLen
                    '               .後胴前 = dblKodoMae 'initParameter.HorZendoCenter 'initParameter.KodoLen
                    .後胴前 = dbl後胴長 'initParameter.HorZendoCenter 'MachineSpec
                    .ディフォルト旋回中心 = MachineSpec.HorSenkaiCyuushin
                    .sbCulNakaore1(HorPlan)
                End With
                ' End If
                '2010/4/7 修正
                HorZendoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - HorNakaKodo.現旋回中心


                '中折れ計算2（構築中心の方向角で検討）
                With HorNakaCul
                    '        .前胴中心姿勢角 = HorZendoKijun.構築中心方位角
                    '        .後胴中心姿勢角 = KodoKijun.構築中心方位角

                    ''以下　追加　 01.06.25 by Isao Kondo
                    .前胴中心姿勢角 = HorZendoKijun.軌道中心方位角
                    .後胴中心姿勢角 = HorKodoKijun.軌道中心方位角
                    .前胴中心姿勢角カント補正 = HorZendoKijun.構築中心方位角
                    .後胴中心姿勢角カント補正 = HorKodoKijun.構築中心方位角

                    .現中折計算区分 = HorNakaKodo.現中折計算区分
                    .現姿勢変化率 = HorNakaKodo.現姿勢変化率
                    .現中折角度 = HorNakaKodo.現中折角度
                    .sbCul_Nakaore2()
                    mdbl平面中折角度 = .中折角度 'HorNakaKodo.現中折角度
                    mdbl平面計画方位 = Hoko2Hoi(.基準方位)
                End With
            Else
                'ｼｰﾙﾄﾞ機諸元ﾃﾞｰﾀを採用

                '○先端位置
                HorSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance

                '○後胴位置 '後胴前長さ（平面後胴中心－前胴長）
                HorKodoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - (MachineSpec.ZendoLen + (MachineSpec.HorKodoCenter - MachineSpec.ZendoLen))

                '○前胴位置（旋回中心）
                '品川線変更　07/12/08 前胴の旋回中心をシールド機データのデータベースより取得
                HorZendoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - MachineSpec.HorZendoCenter
                mdbl平面計画方位 = Hoko2Hoi((HorZendoKijun.軌道中心方位角))
                mdbl平面中折角度 = HorZendoKijun.軌道中心方位角 - HorKodoKijun.軌道中心方位角
            End If

        Else
            '単胴ｼｰﾙﾄﾞの場合
            '○先端位置
            '品川線対応変更　07/12/08 計画線起点、発進点に伴う変更
            HorSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance

            '○単胴時旋回中心位置
            HorZendoKijun.掘進累積距離 = HorSentanKijun.掘進累積距離 - MachineSpec.HorSenkaiCyuushin
            mdbl平面計画方位 = HorZendoKijun.軌道中心方位角

            '○単胴ｼｰﾙﾄﾞでは不要なﾃﾞｰﾀの後始末
            mdbl平面中折角度 = 0 '当然0
            '後胴中心関連表示の中止

        End If

        '01/06/28 修正
        'mdbl平面基準方位 = Hoi2Hoko(mdbl平面計画方位 + PlcIf.水平入力補正値 + clsPlanLine.HorPlan.X軸方位角)
        mdbl平面基準方位 = (mdbl平面計画方位 + ControlParameter.水平入力補正値 + HorPlan.X軸方位角)
        mdbl平面旋回中心 = HorSentanKijun.掘進累積距離 - HorZendoKijun.掘進累積距離



        ''------縦断----------
        VerSentanKijun = New clsLineMake
        VerKodoKijun = New clsLineMake
        VerZendoKijun = New clsLineMake
        VerZendoKijun = New clsLineMake ''前銅中心
        VerNakaKodo = New clsCulNakaore1 ''中折れ演算（後胴中心で検討）
        VerNakaCul = New clsCulNakaore2 ''中折れ計算2（構築中心の方向角で検討）

        mdbl縦断後胴中心 = MachineSpec.VerKodoCenter

        Dim VerKodoCenTmp As clsLineMake
        If MachineSpec.ShieldTypeVer = 1 Then 'Then 'ｼｰﾙﾄﾞ諸元ﾃﾞｰﾀの縦断中折れ使用（0:使用しない 1:使用する）を調べ、処理を選択
            If MachineSpec.VerSel = 1 Then '修正080906　姿勢・中折れ角の計算ロジックを計算方法別に完全分離

                '計画線ｿﾞｰﾝ毎の中折れﾃﾞｰﾀを採用
                '○先端位置
                VerSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance '品川線対応変更　07/12/08 計画線起点、発進点に伴う変更

                '○後胴中心位置の抽出（中折れ点位置より計画線データから最も近い位置の後胴中心設定データを探す）
                VerKodoCenTmp = New clsLineMake
                VerKodoCenTmp.掘進累積距離 = VerSentanKijun.掘進累積距離 - MachineSpec.ZendoLen

                clsSetKoudouC.ゾーン番号 = VerKodoCenTmp.縦断ゾーン番号
                clsSetKoudouC.ゾーン掘進距離 = VerKodoCenTmp.掘進累積距離
                clsSetKoudouC.ゾーン残距離 = VerKodoCenTmp.縦断ゾーン内残距離
                clsSetKoudouC.sbCul()
                If clsSetKoudouC.抽出フラグ = 1 And clsSetKoudouC.抽出ゾーン掘進距離 <= MachineSpec.MachiLength Then
                    mdbl縦断後胴中心 = clsSetKoudouC.抽出後胴中心
                End If
                dbl後胴長 = mdbl縦断後胴中心 - MachineSpec.ZendoLen

                '○後胴位置
                VerKodoKijun.掘進累積距離 = VerSentanKijun.掘進累積距離 - (MachineSpec.ZendoLen + dbl後胴長)


                '中折れ計算１（後胴中心で検討）
                With VerNakaKodo
                    .ZoneNo = VerKodoKijun.縦断ゾーン番号
                    .ゾーン掘進距離 = VerKodoKijun.縦断ゾーン内掘進距離
                    .ゾーン残距離 = VerKodoKijun.縦断ゾーン内残距離
                    .前胴長 = MachineSpec.ZendoLen
                    '            .後胴前 = initParameter.VerKodoCenter - initParameter.ZendoLen
                    .後胴前 = dbl後胴長
                    .ディフォルト旋回中心 = MachineSpec.HorSenkaiCyuushin
                    .sbCulNakaore1(VerPlan)
                End With

                ''前胴中心の計算
                VerZendoKijun.掘進累積距離 = dblSentanDistance - VerNakaKodo.現旋回中心
                '
                '中折れ計算2（構築中心の方向角で検討）
                With VerNakaCul
                    .前胴中心姿勢角 = VerZendoKijun.鉛直角
                    .後胴中心姿勢角 = VerKodoKijun.鉛直角
                    ''以下　追加　 01.06.25 by Isao Kondo
                    .前胴中心姿勢角カント補正 = VerZendoKijun.鉛直角
                    .後胴中心姿勢角カント補正 = VerKodoKijun.鉛直角

                    .現中折計算区分 = VerNakaKodo.現中折計算区分
                    .現中折角度 = VerNakaKodo.現中折角度
                    .現姿勢変化率 = VerNakaKodo.現姿勢変化率
                    .sbCul_Nakaore2()
                    ''02/10/04 追加
                    mdbl縦断計画方位 = .基準方位
                    mdbl縦断中折角度 = VerNakaCul.中折角度
                    ''補正値の換算
                    mdbl縦断基準方位 = .基準方位 + ControlParameter.鉛直入力補正値
                End With

            Else
                '○先端位置
                VerSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance

                '○後胴位置（ｴﾚｸﾀｰ中心）
                VerKodoKijun.掘進累積距離 = VerSentanKijun.掘進累積距離 - MachineSpec.VerKodoCenter

                '○前胴位置（旋回中心）
                VerZendoKijun.掘進累積距離 = VerSentanKijun.掘進累積距離 - MachineSpec.VerZendoCenter


                mdbl縦断計画方位 = VerZendoKijun.鉛直角
                mdbl縦断中折角度 = VerZendoKijun.鉛直角 - VerKodoKijun.鉛直角

            End If
        Else
            '単胴ｼｰﾙﾄﾞの場合
            '○先端位置
            VerSentanKijun.掘進累積距離 = dblSentanDistance + gdblToStartDistance

            '○単胴時旋回中心位置
            VerZendoKijun.掘進累積距離 = VerSentanKijun.掘進累積距離 - MachineSpec.VerSenkaiCyuushin

            mdbl縦断計画方位 = VerZendoKijun.鉛直角
            mdbl縦断中折角度 = 0

        End If
        mdbl縦断基準方位 = mdbl縦断計画方位 + ControlParameter.鉛直入力補正値
        mdbl縦断旋回中心 = VerSentanKijun.掘進累積距離 - VerZendoKijun.掘進累積距離

    End Sub
    'Private Function fnGetNowStroke()
    '' @(f)
    ''
    '' 機能      :現在の生ストロークを求める
    ''
    '' 返り値    :なし
    '' 　　　    :
    ''
    '' 機能説明  :
    ''
    '' 備考      :
    '
    'With PlcIf
    '    Select Case .ストローク管理法
    '        Case 0  ''MAX
    '            If .右ジャッキストローク > .左ジャッキストローク Then
    '                fnGetNowStroke = .右ジャッキストローク
    '            End If
    '            If .上ジャッキストローク > fnGetNowStroke Then
    '                fnGetNowStroke = .上ジャッキストローク
    '            End If
    '        Case 1  ''右
    '            fnGetNowStroke = .右ジャッキストローク
    '        Case 2  ''左
    '            fnGetNowStroke = .左ジャッキストローク
    '        Case 3  ''上
    '            fnGetNowStroke = .上ジャッキストローク
    '        Case 4  ''平均
    '            fnGetNowStroke = (.左ジャッキストローク + .右ジャッキストローク) / 2
    '
    '
    '
    '
    '    End Select
    'End With
    '
    '
    '
    'End Function
    '







    'UPGRADE_NOTE: Class_Initialize は Class_Initialize_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Initialize_Renamed()

        Distance = New clsCulcDistance

        StartKijun = New clsLineMake
        With HorPlan
            StartKijun.掘進累積距離 = System.Math.Sqrt((.発進X座標 - .起点X座標) ^ 2 + (.発進Y座標 - .起点Y座標) ^ 2)


        End With
        'Debug.Print StartKijun.平面ゾーン掘進距離

    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    Private Function fnGetKodoCenter() As Double
        ' @(f)
        '
        ' 機能      :後胴中心の抽出
        '
        ' 返り値    :後銅中心位置
        ' 　　　    :
        '
        ' 機能説明  :中折れ点位置のｿﾞｰﾝ番号、ｿﾞｰﾝ内掘進距離、ｿﾞｰﾝ内残距離を引き渡し、後胴中心を抽出する。
        '
        ' 備考      :08/08/25 追加


        Dim dblNL0 As Double = 0, dblNL1 As Double = 0
        Dim intFd0 As Short = 1, intFd1 As Short = 0
        Dim dblKc0, dblKc1 As Double

        'dblNL0 = 0 : dblNL1 = 0 : intFd0 = 1 : intFd1 = 0

        Dim intCnt As Integer '中折れの有無あり？ '過去ｿﾞｰﾝのチェック
        With NakaoreKijun
            Select Case HorPlan.線形(.平面ゾーン番号) '中折れ点位置の線形状は？
                Case 1 '' '直線の場合（中折れ施工を選択している曲線ｿﾞｰﾝの近い方の後胴中心を採用）

                    '過去のｿﾞｰﾝ
                    dblNL0 = .平面ゾーン掘進距離 'まずｿﾞｰﾝ内掘進距離を加算
                    If .平面ゾーン番号 <= 1 Then '現在のｿﾞｰﾝが1以下か？
                        '1以下のときは過去ｿｰﾝ側にはない
                        intFd0 = 0
                    Else
                        '2以上のとき
                        For intCnt = CShort(.平面ゾーン番号 - 1) To 1 Step -1
                            If HorPlan.中折(intCnt) <> 1 Then
                                dblNL0 = dblNL0 + HorPlan.線分長(intCnt) '中折れ有無なしのときそのｿﾞｰﾝの距離加算
                                intFd0 = 0 '中折れありのｿﾞｰﾝがまだ見つからない
                            Else
                                dblKc0 = HorPlan.後胴中心(intCnt) 'そのｿﾞｰﾝの後胴中心を候補として採用
                                intFd0 = 1 '過去側一応見つかりました
                                Exit For
                            End If
                        Next
                    End If

                    '未来のｿﾞｰﾝ
                    dblNL1 = .平面ゾーン内残距離 'まずｿﾞｰﾝ内残距離を加算
                    If .平面ゾーン番号 >= HorPlan.ゾーン総数 Then '現在のｿﾞｰﾝが最終ｿﾞｰﾝ以上か？
                        '最終ｿﾞｰﾝ以上のときは未来ｿｰﾝ側にはない
                        intFd1 = 0
                    Else
                        'HVk-1以下のとき
                        For intCnt = .平面ゾーン番号 + 1 To HorPlan.ゾーン総数 '未来ｿﾞｰﾝのチェック
                            If HorPlan.中折(intCnt) <> 1 Then '中折れの有無あり？
                                dblNL1 = dblNL1 + HorPlan.線分長(intCnt) '中折れ有無なしのときそのｿﾞｰﾝの距離加算
                                intFd1 = 0 '中折れありのｿﾞｰﾝがまだ見つからない
                            Else
                                dblKc1 = HorPlan.後胴中心(intCnt) 'そのｿﾞｰﾝの後胴中心を候補として採用
                                intFd1 = 1 '未来側一応見つかりました
                                Exit For
                            End If
                        Next
                    End If

                    If intFd0 = 0 Then
                        If intFd1 = 0 Then
                            'どちらにも中折れありのﾃﾞｰﾀが発見できなかったとき
                            Return 0 '後胴中心はとりあえず０にしておく
                        Else
                            '未来側に中折れありがあったので未来側のﾃﾞｰﾀを採用します。
                            Return dblKc1
                        End If
                    Else
                        If intFd1 = 0 Then
                            '過去側に中折れありがあったので過去側のﾃﾞｰﾀを採用します。
                            Return dblKc0
                        Else
                            'どちらにも中折れありのﾃﾞｰﾀがあるので近い方を採用
                            If dblNL0 <= dblNL1 Then
                                '過去側が近いか等しいとき
                                Return dblKc0
                            Else
                                Return dblKc1
                            End If
                        End If
                    End If


                Case 2, 3 '単曲線,緩和曲線 の場合（現ｿﾞｰﾝの後胴中心を採用）
                    Return HorPlan.後胴中心(.平面ゾーン番号)

                Case Else

            End Select
        End With

    End Function


    'UPGRADE_NOTE: Class_Terminate は Class_Terminate_Renamed にアップグレードされました。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"' をクリックしてください。
    Private Sub Class_Terminate_Renamed()
        'UPGRADE_NOTE: オブジェクト HorZendoKijun をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        HorZendoKijun = Nothing
        'UPGRADE_NOTE: オブジェクト HorNakaKodo をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        HorNakaKodo = Nothing
        'UPGRADE_NOTE: オブジェクト HorNakaCul をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        HorNakaCul = Nothing

        'UPGRADE_NOTE: オブジェクト VerZendoKijun をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        VerZendoKijun = Nothing
        'UPGRADE_NOTE: オブジェクト VerNakaKodo をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        VerNakaKodo = Nothing
        'UPGRADE_NOTE: オブジェクト VerNakaCul をガベージ コレクトするまでこのオブジェクトを破棄することはできません。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"' をクリックしてください。
        VerNakaCul = Nothing

    End Sub
    Protected Overrides Sub Finalize()
        Class_Terminate_Renamed()
        MyBase.Finalize()
    End Sub


    Private Class clsSet_KoudouC
        ' @(h) clsSet_KoudouC.cls                ver 1.0 ( '11/03/15 近藤　勲 )

        '現在の中折れ点のｿﾞｰﾝ番号、ｿﾞｰﾝ内掘進距離、ｿﾞｰﾝ内残距離を引き渡し、計画線ﾃﾞｰﾀ（基本、掘進選択後の）を参照し、後胴中心を抽出する。

        'HVk=        総ｿﾞｰﾝ数
        'mintゾーン番号=         現在のｿﾞｰﾝ番号
        'mdblゾーン掘進距離=        現在のｿﾞｰﾝ内掘進距離(m)
        'mdblゾーン残距離=        現在のｿﾞｰﾝ内残距離(m)

        'Sh()=       iｿﾞｰﾝの線形状（1:直線、2:単曲線、3:緩和曲線）
        'Nn()=       iｿﾞｰﾝの中折れの有無(1:あり）
        'NKc()=　　　iｿﾞｰﾝの後胴の旋回中心(m)

        'mdbl抽出後胴中心=        抽出した後胴中心
        'mint抽出ゾーン番号=        抽出したｿﾞｰﾝ№
        'mdbl抽出ゾーン掘進距離=        抽出ｿﾞｰﾝまでの距離
        'mint抽出フラグ=        抽出フラグ（0:非抽出 1:抽出）


        Inherits clsPlanData
        ''入力項目
        Private mintゾーン番号 As Integer
        Private mdblゾーン掘進距離 As Double
        Private mdblゾーン残距離 As Double


        ''演算出力項目
        Private mdbl抽出後胴中心 As Double
        Private mint抽出ゾーン番号 As Integer
        Private mdbl抽出ゾーン掘進距離 As Double
        Private mint抽出フラグ As Short '抽出フラグ（0:非抽出 1:抽出）


        Public WriteOnly Property ゾーン番号() As Integer
            Set(ByVal Value As Integer)
                mintゾーン番号 = Value
            End Set
        End Property

        Public WriteOnly Property ゾーン残距離() As Double
            Set(ByVal Value As Double)
                mdblゾーン残距離 = Value
            End Set
        End Property

        Public WriteOnly Property ゾーン掘進距離() As Double
            Set(ByVal Value As Double)
                mdblゾーン掘進距離 = Value
            End Set
        End Property

        Public ReadOnly Property 抽出後胴中心() As Double
            Get
                抽出後胴中心 = mdbl抽出後胴中心
            End Get
        End Property

        Public ReadOnly Property 抽出ゾーン番号() As Integer
            Get
                抽出ゾーン番号 = mint抽出ゾーン番号
            End Get
        End Property


        Public ReadOnly Property 抽出ゾーン掘進距離() As Double
            Get
                抽出ゾーン掘進距離 = mdbl抽出ゾーン掘進距離
            End Get
        End Property

        Public ReadOnly Property 抽出フラグ() As Short
            Get
                抽出フラグ = mint抽出フラグ
            End Get
        End Property


        Public Sub sbCul()


            Dim dblLkc0, dblLkc1 As Double
            Dim dblDkc0, dblDkc1 As Double
            Dim intFkc0, intFkc1 As Short
            Dim intZkc0, intZkc1 As Integer

            Dim intZone As Integer

            dblLkc0 = 0
            dblLkc1 = 0
            intFkc0 = 0
            intFkc1 = 0



            '過去のｿﾞｰﾝ
            If mintゾーン番号 <= 1 Then '現在のｿﾞｰﾝが1以下か？
                '1以下のときは過去ｿｰﾝ側にはない
                intFkc0 = 0
            Else
                '2以上のとき
                For intZone = mintゾーン番号 To 1 Step -1 '過去に向かってチェック
                    'UPGRADE_WARNING: オブジェクト objSenkei.後胴中心 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    'UPGRADE_WARNING: オブジェクト objSenkei.中折 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    'UPGRADE_WARNING: オブジェクト objSenkei.線形 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    If (線形(intZone) = 2 Or 線形(intZone) = 3) And 中折(intZone) = 1 And 後胴中心(intZone) <> 0 Then '線形状、中折れ有無、後胴中心ﾃﾞｰﾀ有無のﾁｪｯｸ
                        '曲線区間であり、なおかつ中折れ使用、後胴中心にデータあり
                        'UPGRADE_WARNING: オブジェクト objSenkei_後胴中心 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS_VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                        dblDkc0 = 後胴中心(intZone) 'そのｿﾞｰﾝの後胴中心を候補として採用
                        intZkc0 = intZone '採用したｿﾞｰﾝ番号
                        intFkc0 = 1 '過去側一応見つかりました
                        Exit For
                    Else
                        '中折れでない　または後胴中心データが０
                        If intZone = mintゾーン番号 Then
                            dblLkc0 = mdblゾーン掘進距離 'ｿﾞｰﾝ内距離を初期値
                        Else
                            'UPGRADE_WARNING: オブジェクト objSenkei.線分長 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                            dblLkc0 = dblLkc0 + 線分長(intZone) 'ｿﾞｰﾝ距離を加算
                        End If
                        intFkc0 = 0 '中折れありのｿﾞｰﾝがまだ見つからない
                    End If
                Next
            End If

            '未来のｿﾞｰﾝ
            'UPGRADE_WARNING: オブジェクト objSenkei.ゾーン総数 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS_VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
            If mintゾーン番号 >= MyBase.ゾーン総数 Then '現在のｿﾞｰﾝが最終ｿﾞｰﾝ以上か？
                '最終ｿﾞｰﾝ以上のときは未来ｿｰﾝ側にはない
                intFkc1 = 0
            Else
                'HVk-1以下のとき
                'UPGRADE_WARNING: オブジェクト objSenkei.ゾーン総数 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                For intZone = mintゾーン番号 To ゾーン総数 '未来に向かってチェック
                    'UPGRADE_WARNING: オブジェクト objSenkei.後胴中心 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    'UPGRADE_WARNING: オブジェクト objSenkei.中折 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    'UPGRADE_WARNING: オブジェクト objSenkei.線形 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                    If (線形(intZone) = 2 Or 線形(intZone) = 3) And 中折(intZone) = 1 And 後胴中心(intZone) <> 0 Then '線形状、中折れ有無、後胴中心ﾃﾞｰﾀ有無のﾁｪｯｸ
                        '曲線区間であり、なおかつ中折れ使用、後胴中心にデータあり
                        'UPGRADE_WARNING: オブジェクト objSenkei.後胴中心 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                        dblDkc1 = 後胴中心(intZone) 'そのｿﾞｰﾝの後胴中心を候補として採用
                        intZkc1 = intZone '採用したｿﾞｰﾝ番号
                        intFkc1 = 1 '未来側一応見つかりました
                        Exit For
                    Else
                        '中折れでない　または後胴中心データが０
                        If intZone = mintゾーン番号 Then
                            dblLkc1 = mdblゾーン残距離 'ｿﾞｰﾝ内残距離を初期値
                        Else
                            'UPGRADE_WARNING: オブジェクト objSenkei.線分長 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                            dblLkc1 = dblLkc1 + 線分長(intZone) 'ｿﾞｰﾝ距離を加算
                        End If
                        intFkc1 = 0 '中折れありのｿﾞｰﾝがまだ見つからない
                    End If
                Next
            End If

            If intFkc0 = 0 Then
                If intFkc1 = 0 Then
                    'どちらにも中折れありのﾃﾞｰﾀが発見できなかったとき
                    mdbl抽出後胴中心 = -1 '後胴中心に-1を設定
                    mint抽出ゾーン番号 = -1 'ｿﾞｰﾝ番号に-1
                    mdbl抽出ゾーン掘進距離 = -1 '距離に-1
                    mint抽出フラグ = 0 '0:未抽出
                Else
                    '未来側に中折れありがあったので未来側のﾃﾞｰﾀを採用します。
                    mdbl抽出後胴中心 = dblDkc1
                    mint抽出ゾーン番号 = intZkc1
                    mdbl抽出ゾーン掘進距離 = dblLkc1
                    mint抽出フラグ = 1
                End If
            Else
                If intFkc1 = 0 Then
                    '過去側に中折れありがあったので過去側のﾃﾞｰﾀを採用します。
                    mdbl抽出後胴中心 = dblDkc0
                    mint抽出ゾーン番号 = intZkc0
                    mdbl抽出ゾーン掘進距離 = dblLkc0
                    mint抽出フラグ = 1
                Else
                    'どちらにも中折れありのﾃﾞｰﾀがあるので近い方を採用
                    If dblLkc0 <= dblLkc1 Then
                        '過去側が近いか等しいとき
                        mdbl抽出後胴中心 = dblDkc0
                        mint抽出ゾーン番号 = intZkc0
                        mdbl抽出ゾーン掘進距離 = dblLkc0
                        mint抽出フラグ = 1
                    Else
                        mdbl抽出後胴中心 = dblDkc1
                        mint抽出ゾーン番号 = intZkc1
                        mdbl抽出ゾーン掘進距離 = dblLkc1
                        mint抽出フラグ = 1
                    End If
                End If
            End If


        End Sub
    End Class

    Friend Class clsCulNakaore1
        ' @(h) clsCulNakaore.cls                ver 1.0 ( '01.02.16 近藤　勲 )
        ' @(h) clsCulNakaore.cls                ver 1.1 ( '01.09.10 近藤　勲 )
        ' @(h) clsCulNakaore.cls                ver 1.2 ( '03.04.17 近藤　勲 )
        ' @(h) clsCulNakaore.cls                ver 1.3 ( '05.01.20 近藤　勲 )
        ''03/04/17 修正

        ' @(s) 中折れ演算クラス その１
        '
        'ver 1.1 中折れ最大角の取得位置変更
        'ver 1.3 旋回中心の演算　次ゾーンがクロソイドの時の旋回中心は前胴中心に

        Inherits clsPlanData
        ''入力項目
        Private _ZoneNo As Integer
        Private mdblゾーン掘進距離 As Double
        Private mdblゾーン残距離 As Double

        Private mdbl前胴長 As Double
        Private mdbl後胴前 As Double
        Private mdblディフォルト旋回中心 As Double

        Private mint線形() As Integer
        Private mdbl前胴中心() As Double
        Private mint中折() As Integer
        Private mdbl中折開始() As Double
        Private mdbl戻し開始() As Double
        Private mdbl最大中折角() As Double
        Private mdbl姿勢変化率() As Double


        ''演算出力項目
        Private mdbl現最大中折角 As Double
        Private mdbl現姿勢変化率 As Double
        Private mdbl現旋回中心 As Double
        Private mdbl現中折開始 As Double
        Private mdbl現中折角度 As Double
        Private mint現中折計算区分 As Short
        Private mdbl現戻し開始 As Double



        'Public WriteOnly Property 線形 As Integer()
        '    Set(value As Integer())
        '        mint線形 = CType(value.Clone, Integer())
        '    End Set
        'End Property
        'Public WriteOnly Property 前胴中心 As Double()
        '    Set(value As Double())
        '        mdbl前胴中心 = CType(value.Clone, Double())
        '    End Set
        'End Property
        'Public WriteOnly Property 中折 As Integer()
        '    Set(value As Integer())
        '        mint中折 = CType(value.Clone, Integer())
        '    End Set
        'End Property
        'Public WriteOnly Property 中折開始 As Double()
        '    Set(value As Double())
        '        mdbl中折開始 = CType(value.Clone, Double())
        '    End Set
        'End Property
        'Public WriteOnly Property 戻し開始 As Double()
        '    Set(value As Double())
        '        mdbl戻し開始 = CType(value.Clone, Double())
        '    End Set
        'End Property

        Public WriteOnly Property 最大中折角 As Double()
            Set(value As Double())
                mdbl最大中折角 = CType(value.Clone, Double())
            End Set
        End Property
        'Public WriteOnly Property 姿勢変化率 As Double()
        '    Set(value As Double())
        '        mdbl姿勢変化率 = CType(value.Clone, Double())
        '    End Set
        'End Property

        Public ReadOnly Property 現戻し開始() As Double
            Get
                現戻し開始 = mdbl現戻し開始
            End Get
        End Property

        Public ReadOnly Property 現中折計算区分() As Short
            Get
                現中折計算区分 = mint現中折計算区分
            End Get
        End Property

        Public ReadOnly Property 現中折角度() As Double
            Get
                現中折角度 = mdbl現中折角度
            End Get
        End Property

        Public ReadOnly Property 現中折開始() As Double
            Get
                現中折開始 = mdbl現中折開始
            End Get
        End Property

        Public ReadOnly Property 現旋回中心() As Double
            Get
                現旋回中心 = mdbl現旋回中心
            End Get
        End Property

        Public ReadOnly Property 現姿勢変化率() As Double
            Get
                現姿勢変化率 = mdbl現姿勢変化率
            End Get
        End Property

        Public ReadOnly Property 現最大中折角() As Double
            Get
                現最大中折角 = mdbl現最大中折角
            End Get
        End Property


        Public WriteOnly Property 前胴長() As Double
            Set(ByVal Value As Double)
                mdbl前胴長 = Value
            End Set
        End Property


        Public WriteOnly Property 後胴前() As Double
            Set(ByVal Value As Double)
                mdbl後胴前 = Value
            End Set
        End Property

        Public WriteOnly Property ディフォルト旋回中心() As Double
            Set(ByVal Value As Double)
                mdblディフォルト旋回中心 = Value
            End Set
        End Property

        Public WriteOnly Property ZoneNo() As Integer
            Set(ByVal Value As Integer)
                _ZoneNo = Value
            End Set
        End Property

        Public WriteOnly Property ゾーン残距離() As Double
            Set(ByVal Value As Double)
                mdblゾーン残距離 = Value
            End Set
        End Property

        Public WriteOnly Property ゾーン掘進距離() As Double
            Set(ByVal Value As Double)
                mdblゾーン掘進距離 = Value
            End Set
        End Property


        ''' <summary>
        ''' 中折計算1
        ''' </summary>
        ''' <param name="LineData">
        ''' 線形データクラス　水平、鉛直
        ''' </param>
        Public Sub sbCulNakaore1(LineData As Object)
            ' @(f)
            '
            ' 機能      :中折れ演算１
            '
            ' 引数　    :objSenkei→　平面、縦断
            ' 　　　    :
            ' 　　　    :ゾーン掘進距離,    ゾーン残距, 前胴長, 後胴前,
            ' 　　　    :旋回中心,          線形,       中折,   前胴中心
            ' 　　　    :中折開始,          戻し開始,   最大中折れ角,   姿勢変化率
            ' 　　　    :
            ' 　　　    :
            ' 返り値    :なし
            ' 　　　    :
            '
            ' 機能説明  :
            '
            ' 備考      :

            'Sub Cal_naka1(_ZoneNo, mdbl平面ゾーン掘進距離, mdblゾーン残距離, L1, L2, Lch, .Hor線形(), .Hor中折(), .Hor前胴中心(), .Hor中折開始(), .Hor戻し開始(), .Hor最大中折れ角(), .Hor姿勢変化率(), Mc, Ns, Ms, Max, Kh, Nk, Fnk)

            '現在のｿﾞｰﾝ番号、ｿﾞｰﾝ内掘進距離、ｿﾞｰﾝ内残距離を引き渡し、現在の中折れ角と、中折れﾃﾞｰﾀ、および計算の区分を返す。

            '_ZoneNo=         現在のｿﾞｰﾝ番号
            'mdbl平面ゾーン掘進距離=        現在のｿﾞｰﾝ内掘進距離(m)
            'mdblゾーン残距離=        現在のｿﾞｰﾝ内残距離(m)

            'L1=         前胴長(m)
            'L2=         後胴前(m)
            'Lch=        旋回中心（ﾃﾞﾌｫﾙﾄ）(m)

            '.Hor線形(i)=      iｿﾞｰﾝの線形状(1:直線、2:単曲線、3:緩和曲線）
            '.Hor中折(i)=      iｿﾞｰﾝの中折れの有無(1:あり）
            '.Hor前胴中心(i)=     iｿﾞｰﾝの前胴の旋回中心(m)
            '.Hor中折開始(i)=     iｿﾞｰﾝの中折れ開始位置(m)
            '.Hor戻し開始(i)=     iｿﾞｰﾝの中折れ戻し開始位置(m)
            '.Hor最大中折れ角(i)=    iｿﾞｰﾝの最大中折れ角(m)
            '.Hor姿勢変化率(i)=     iｿﾞｰﾝの姿勢変化率

            'Ns=         現在の中折れ開始位置(m)
            'Ms=         現在の戻り開始位置(m)
            'Max=        現在の最大中折れ角(deg)
            'Kh=         現在の姿勢変化率
            'Nk=         現在の中折れ角度(deg)
            'Fnk=        現在の中折れ計算区分（0:中折れなし 1:通常の中折れ計算　2:EC、BC付近の計算）

            'Dim Cer As Short

            With DirectCast(LineData, clsPlanData)

                Select Case .線形(_ZoneNo)
                    Case 1 '後胴が直線（中折れ計算は次ｿﾞｰﾝが対象）
                        mdbl現中折開始 = .中折開始(_ZoneNo + 1) '中折れ開始位置
                        mdbl現戻し開始 = .戻し開始(_ZoneNo + 1) '中折れ戻し開始位置
                        mdbl現最大中折角 = .最大中折れ角(_ZoneNo + 1) '最大中折れ角
                        mdbl現姿勢変化率 = .姿勢変化率(_ZoneNo + 1) '姿勢変化率
                        If .中折(_ZoneNo + 1) = 1 Then '次ｿﾞｰﾝ中折れ施工
                            If .線形(_ZoneNo + 1) = 2 Then '次ｿﾞｰﾝ単曲線
                                '                            mdbl現旋回中心 = (mdbl前胴長 + mdbl後胴前) - .前胴中心(_ZoneNo + 1) '旋回中心は次ｿﾞｰﾝの前胴中心
                                ''03/04/17 修正 堀川より
                                mdbl現旋回中心 = .前胴中心(_ZoneNo + 1) '旋回中心は次ｿﾞｰﾝの前胴中心
                                If mdblゾーン残距離 <= (mdbl前胴長 + mdbl後胴前) - mdbl現中折開始 Then
                                    mint現中折計算区分 = 2 '特殊処理
                                    '??????????????↓０のはず
                                    mdbl現中折角度 = mdbl現最大中折角 * (1 - mdblゾーン残距離 / ((mdbl前胴長 + mdbl後胴前) - mdbl現中折開始)) '中折れ角
                                Else
                                    mint現中折計算区分 = 1 '通常の中折れ処理
                                    mdbl現中折角度 = 0 '中折れ不定
                                End If
                            Else
                                mint現中折計算区分 = 1 '通常の中折れ処理
                                '                            mdbl現旋回中心 = (mdbl前胴長 + mdbl後胴前) - .前胴中心(_ZoneNo + 1) '旋回中心は次ｿﾞｰﾝの前胴中心
                                'UPGRADE_WARNING: オブジェクト objSenkei.前胴中心 の既定プロパティを解決できませんでした。 詳細については、'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"' をクリックしてください。
                                mdbl現旋回中心 = .前胴中心(_ZoneNo + 1) '旋回中心は次ｿﾞｰﾝの前胴中心05/01/20 修正
                                mdbl現中折角度 = 0 '中折れ不定
                            End If
                        Else

                            mint現中折計算区分 = 0 '中折れなし
                            mdbl現旋回中心 = mdblディフォルト旋回中心 '旋回中心は次ｿﾞｰﾝのマシン中心
                            mdbl現中折角度 = 0 '中折れ角は0
                        End If

                    Case 2 '後胴が単曲線（中折れ計算は現ｿﾞｰﾝが対象）
                        mdbl現中折開始 = .中折開始(_ZoneNo) '中折れ開始位置
                        mdbl現戻し開始 = .戻し開始(_ZoneNo) '中折れ戻し開始位置
                        mdbl現最大中折角 = .最大中折れ角(_ZoneNo) '最大中折れ角
                        mdbl現姿勢変化率 = .姿勢変化率(_ZoneNo) '姿勢変化率
                        If .中折(_ZoneNo) = 1 Then '現ｿﾞｰﾝ中折れ施工
                            If .線形(_ZoneNo + 1) = 1 Then '次が直線
                                mdbl現旋回中心 = .前胴中心(_ZoneNo) '旋回中心は次ｿﾞｰﾝの前胴中心

                                If mdblゾーン残距離 <= (mdbl前胴長 + mdbl後胴前) - mdbl現中折開始 Then
                                    mint現中折計算区分 = 2 '特殊処理
                                    mdbl現中折角度 = mdbl現最大中折角 * mdblゾーン残距離 / ((mdbl前胴長 + mdbl後胴前) - mdbl現中折開始) '中折れ角
                                Else
                                    mint現中折計算区分 = 1 '通常の中折れ処理
                                    mdbl現中折角度 = 0
                                End If
                            Else
                                mint現中折計算区分 = 1 '通常の中折れ処理
                                mdbl現旋回中心 = .前胴中心(_ZoneNo + 1) '旋回中心は次ｿﾞｰﾝの前胴中心　05/01/20 修正
                                mdbl現中折角度 = 0 '中折れ不定
                            End If
                        Else
                            mint現中折計算区分 = 0 '中折れなし
                            mdbl現旋回中心 = mdblディフォルト旋回中心 '旋回中心は現ｿﾞｰﾝのマシン中心
                            mdbl現中折角度 = 0 '中折れ角は０
                        End If

                    Case 3 '後胴が緩和曲線（中折れ処理は現ｿﾞｰﾝが対象）
                        mdbl現中折開始 = .中折開始(_ZoneNo) '中折れ開始位置
                        mdbl現戻し開始 = .戻し開始(_ZoneNo) '中折れ戻し開始位置
                        mdbl現最大中折角 = .最大中折れ角(_ZoneNo) '最大中折れ角
                        mdbl現姿勢変化率 = .姿勢変化率(_ZoneNo) '姿勢変化率
                        If .中折(_ZoneNo) = 1 Then '現ｿﾞｰﾝ中折れ施工
                            mint現中折計算区分 = 1 '通常の中折れ処理
                            mdbl現旋回中心 = .前胴中心(_ZoneNo) '旋回中心は現ｿﾞｰﾝの前胴中心　05/01/20 修正
                            mdbl現中折角度 = 0 '中折れ不定
                        Else
                            mint現中折計算区分 = 0 '中折れなし
                            mdbl現旋回中心 = mdblディフォルト旋回中心 '旋回中心は現ｿﾞｰﾝのマシン中心
                            mdbl現中折角度 = 0 '中折れ角は０
                        End If

                    Case Else

                End Select
            End With

        End Sub
    End Class
    Friend Class clsCulNakaore2
        ' @(h) clsCulNakaore1.cls                ver 1.0 ( '01.02.22 近藤　勲 )
        ' @(h) clsCulNakaore1.cls                ver 1.1 ( '01.06.25 近藤　勲 )
        ' @(h) clsCulNakaore1.cls                ver 1.2 ( '03.03.19 近藤　勲 )
        'sbCul_Nakaore2を修正　飛島堀川より

        ' @(s) 中折れ演算クラス その２
        '
        '


        ''入力項目

        Private mdbl前胴中心姿勢角 As Double ''軌道中心
        Private mdbl後胴中心姿勢角 As Double ''軌道中心

        ''構築中心
        Private mdbl前胴中心姿勢角カント補正 As Double ''ver 1.1 01.06.25 追加
        Private mdbl後胴中心姿勢角カント補正 As Double ''ver 1.1 01.06.25 追加

        Private mint現中折計算区分 As Short
        Private mdbl現中折角度 As Double
        Private mdbl現姿勢変化率 As Double

        'Private mdbl姿勢変化率 As Double

        ''演算出力項目
        Private mdbl中折角度 As Double
        Private mdbl基準方位 As Double


        Public WriteOnly Property 前胴中心姿勢角() As Double
            Set(ByVal Value As Double)
                mdbl前胴中心姿勢角 = Value
            End Set
        End Property

        Public WriteOnly Property 後胴中心姿勢角() As Double
            Set(ByVal Value As Double)
                mdbl後胴中心姿勢角 = Value
            End Set
        End Property


        Public WriteOnly Property 前胴中心姿勢角カント補正() As Double
            Set(ByVal Value As Double)
                ''ver 1.1 01.06.25 追加
                mdbl前胴中心姿勢角カント補正 = Value
            End Set
        End Property

        Public WriteOnly Property 後胴中心姿勢角カント補正() As Double
            Set(ByVal Value As Double)
                ''ver 1.1 01.06.25 追加
                mdbl後胴中心姿勢角カント補正 = Value
            End Set
        End Property



        Public ReadOnly Property 中折角度() As Double
            Get
                中折角度 = mdbl中折角度 ' * clsPlanLine.HorPlan.座標系
            End Get
        End Property
        Public ReadOnly Property 基準方位() As Double
            Get
                基準方位 = mdbl基準方位
            End Get
        End Property


        Public WriteOnly Property 現中折計算区分() As Short
            Set(ByVal Value As Short)
                mint現中折計算区分 = Value
            End Set
        End Property


        Public WriteOnly Property 現中折角度() As Double
            Set(ByVal Value As Double)
                mdbl現中折角度 = Value
            End Set
        End Property

        'Public Property Let 姿勢変化率(ByVal vData As Double)
        '    mdbl姿勢変化率 = vData
        'End Property

        Public WriteOnly Property 現姿勢変化率() As Double
            Set(ByVal Value As Double)
                mdbl現姿勢変化率 = Value
            End Set
        End Property



        Public Sub sbCul_Nakaore2()
            'Sub Cal_naka2(Fnk, Nk, Kh, mdbl前胴中心姿勢角, mdbl後胴中心姿勢角, Naka, Kijun)
            '中折れ計算区分、中折れ角度（入力値）、姿勢変化率、前胴・後胴姿勢角を引き渡し、中折れ角度、基準姿勢角を返す）

            'Fnk=        中折れ計算区分（0:中折れなし 1:通常の中折れ計算　2:EC、BC付近の計算）
            'Nk=         処理前の中折れ角度(deg)
            'Kh=         姿勢変化率
            'mdbl前胴中心姿勢角=      前胴中心の姿勢角(deg)
            'mdbl後胴中心姿勢角=      後胴中心の姿勢角(deg)
            'Naka=       処理後の中折れ角度(deg)
            'Kijun=      基準方向角(deg)

            Select Case mint現中折計算区分

                Case 0 ''中折れなし（中折れは0度、基準姿勢は前胴の姿勢角）
                    mdbl中折角度 = 0

                    '            mdbl基準方位 = mdbl前胴中心姿勢角 ''ver 1.1 01.06.25 修正
                    mdbl基準方位 = mdbl前胴中心姿勢角カント補正

                Case 1 ''中折れあり（中折れ角は前胴中心と後胴中心の方向差、基準姿勢は前胴の姿勢）
                    '            mdbl中折角度 = mdbl前胴中心姿勢角 - mdbl後胴中心姿勢角 Ver1.2 03/03/19 修正
                    mdbl中折角度 = Lim180(mdbl前胴中心姿勢角 - mdbl後胴中心姿勢角)

                    '            mdbl基準方位 = mdbl前胴中心姿勢角 ''ver 1.1 01.06.25 修正
                    mdbl基準方位 = mdbl前胴中心姿勢角カント補正

                Case 2 ''ＥＣ、ＢＣ付近の中折れあり（中折れ角は中折れ変更中の計算値、基準姿勢は姿勢変化率を考慮した特殊計算値）
                    mdbl中折角度 = mdbl現中折角度 ''中折れ角
                    '            mdbl基準方位 = (mdbl後胴中心姿勢角 + mdbl現中折角度 - mdbl前胴中心姿勢角) * mdbl現姿勢変化率 _
                    '+ mdbl前胴中心姿勢角''ver 1.1 01.06.25 修正
                    '            mdbl基準方位 = (mdbl後胴中心姿勢角カント補正 + mdbl現中折角度 - mdbl前胴中心姿勢角カント補正) * mdbl現姿勢変化率 _
                    '+ mdbl前胴中心姿勢角カント補正
                    '           Ver 1.2 03/03/19 追加
                    mdbl基準方位 = Lim180(mdbl後胴中心姿勢角カント補正 + mdbl現中折角度 - mdbl前胴中心姿勢角カント補正) * mdbl現姿勢変化率 + mdbl前胴中心姿勢角カント補正

            End Select


        End Sub
    End Class

End Class
