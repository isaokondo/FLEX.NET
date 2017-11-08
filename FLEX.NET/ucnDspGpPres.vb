Imports System.ComponentModel
''' <summary>
'''グループ圧表示用
''' </summary>
''' <remarks></remarks>
Public Class ucnDspGpPres
    Private _Value As Double

    Public Event ValueClick(cName As String)


    <Browsable(True)>
    Public Property Value As Double
        Get
            Return _Value
        End Get
        Set(value As Double)
            _Value = value
            '小数点１桁に固定
            lblData.Text = _Value.ToString("F1")
        End Set
    End Property

    Public Property FontSize As Integer
        Get
            Return lblData.Font.Size
        End Get
        Set(value As Integer)
            Dim diff As Integer = lblData.Font.Size - value
            lblData.Width -= diff * 3
            Me.Width -= diff * 3
            lblData.Font = New Font(lblData.Font.FontFamily, value)
        End Set
    End Property



    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Me.Size = lblData.Size

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub lblData_Click(sender As Object, e As EventArgs) Handles lblData.Click
        RaiseEvent ValueClick(Me.Name)
    End Sub



End Class
