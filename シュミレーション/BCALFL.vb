Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("BCALFL")>
Partial Public Class BCALFL
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Number As Integer

    Public Property A As Single?

    Public Property Gandei As Single?

    Public Property q As Single?

    Public Property G As Single?

    Public Property C1V As Single?

    Public Property C1W As Single?

    Public Property L1 As Single?

    Public Property L2 As Single?

    Public Property L3 As Single?

    Public Property Hsv As Single?

    <MaxLength(8)>
    Public Property upsize_ts As Byte()
End Class
