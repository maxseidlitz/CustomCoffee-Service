Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Auftrag
    Private mID As Integer
    Private mKreation As Kreation
    Private mBenutzername As String
    Private mAutomat As Automat

    'parameterloser Konstruktor
    Public Sub New()
        mID = -1
        mKreation = Nothing
        mBenutzername = String.Empty
        mAutomat = Nothing
    End Sub

    'TODO: parameter-Konstruktor


    Public Property ID As Integer
        Get
            Return mID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Kreation As Kreation
        Get
            Return mKreation
        End Get
        Set(value As Kreation)
        End Set
    End Property

    Public Property Automat As Automat
        Get
            Return mAutomat
        End Get
        Set(value As Automat)
        End Set
    End Property

    Public Property Kunde As Kunde
        Get
            Return Nothing
        End Get
        Set(value As Kunde)
        End Set
    End Property
End Class
