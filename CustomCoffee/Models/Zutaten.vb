Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Zutat
    Private mID As Integer
    Private mBezeichnung As String
    Private mKategorie As Kategorie



    'parameterloser Konstruktor
    Public Sub New()
        mID = -1
        mBezeichnung = String.Empty
        mKategorie = Nothing
    End Sub

    'TODO: Parameter-Konstruktor



    Public Property ID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Bezeichnung As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Kategorie As Kategorie
        Get
            Return Nothing
        End Get
        Set(value As Kategorie)
        End Set
    End Property
End Class
