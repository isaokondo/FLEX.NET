Public Class frmHorPlanData
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub


    Private Class DataGet
        Inherits clsDataBase

        Sub New()
            'Dim rsData As Odbc.OdbcDataReader =
            '                ExecuteSql(String.Format("SELECT * FROM `平面線形` WHERE `シートID='{0}';", RingNo))
            'While rsData.Read
            '_DList.Add(rsData.Item("掘進ストローク"), rsData.Item(FldName))
            'End While



        End Sub





    End Class


End Class