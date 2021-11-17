Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Allergen

    Private mintID As Integer
    Private mstrBezeichnung As String


    Public Property intID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property strBezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
        End Set
    End Property
End Class
