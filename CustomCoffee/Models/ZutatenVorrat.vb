Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class ZutatenVorrat
    Public Property Menge As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Zutat As Zutat
        Get
            Return Nothing
        End Get
        Set(value As Zutat)
        End Set
    End Property
End Class
