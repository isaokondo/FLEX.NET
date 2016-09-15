Public Class ucnTuningComp

    ''' <summary>
    ''' グループ圧PV
    ''' </summary>
    Private _GpPv As Single
    ''' <summary>
    ''' グループ圧SV
    ''' </summary>
    Private _GpSv As Single
    ''' <summary>
    ''' グループ圧MV
    ''' </summary>
    Private _GpMv As Single
    ''' <summary>
    ''' グループ圧フラグ
    ''' </summary>
    Private _GpFlg As Integer
    ''' <summary>
    ''' グループ番号
    ''' </summary>
    Private _GpNo As Integer
    ''' <summary>
    ''' グループ圧PID制御ステータス
    ''' </summary>
    Private _PidSt As String
    ''' <summary>
    ''' 圧力の最大値
    ''' </summary>
    Private _PressScale As Single = 35
    ''バーグラフの最大の長さ
    Private InitBarWidth As Integer

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        InitBarWidth = barMv.Width


    End Sub

    Public Property GpPv As Single
        Get
            Return _GpPv
        End Get
        Set(value As Single)
            _GpPv = value
            lblPv.Text = _GpPv.ToString("F1") & "MPa"
            barPv.Width = _GpPv / PressScale * InitBarWidth
        End Set
    End Property
    Public Property GpSv As Single
        Get
            Return _GpSv
        End Get
        Set(value As Single)
            _GpSv = value
            lblSv.Text = _GpSv.ToString("F1") & "MPa"
            barSv.Width = _GpSv / PressScale * InitBarWidth
        End Set
    End Property
    Public Property GpMv As Single
        Get
            Return _GpMv
        End Get
        Set(value As Single)
            _GpMv = value
            lblMv.Text = _GpMv.ToString("F1") & "  % "
            barMv.Width = _GpMv / 100 * InitBarWidth
        End Set
    End Property
    Public Property GpNo As Integer
        Get
            Return _GpNo
        End Get
        Set(value As Integer)
            _GpNo = value
            lblNo.Text = "No." & _GpNo.ToString("F0")
        End Set
    End Property
    Public Property GpFlg As Integer
        Get
            Return _GpFlg
        End Get
        Set(value As Integer)
            _GpFlg = value
            Select Case _GpFlg
                Case cFillPower
                    lblPIDStatus.Text = "F"
                    lblPIDStatus.BackColor = Color.LightPink

                Case cPIDOut
                    lblPIDStatus.Text = "A"
                    lblPIDStatus.BackColor = Color.Cyan

                Case cTracking
                    lblPIDStatus.Text = "T"
                    lblPIDStatus.BackColor = Color.Magenta

                Case cDirect
                    lblPIDStatus.Text = "D"
                    lblPIDStatus.BackColor = Color.YellowGreen

            End Select
        End Set
    End Property


    Public Property PidSt As String
        Get
            Return _PidSt
        End Get
        Set(value As String)
            _PidSt = value
            lblPIDStatus.Text = _PidSt
        End Set
    End Property

    Public Property PressScale As Single
        Get
            Return _PressScale
        End Get
        Set(value As Single)
            _PressScale = value
        End Set
    End Property


End Class
