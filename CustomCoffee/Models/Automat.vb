Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Automat

    Private mID As Integer
    Private mStandort As String
    Private mSeriennumer As String
    Private mSoftwareversion As String

    'parameterloser Konstruktor
    Public Sub New()
        mID = -1
        mStandort = String.Empty
        mSeriennumer = String.Empty
        mSoftwareversion = String.Empty
    End Sub

    'TODO: parameter-Konstruktor



    Public Property ID As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Standort As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Seriennummer As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Softwareversion As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property ZutatenVorraete As List(Of ZutatenVorrat)
        Get
            Return Nothing
        End Get
        Set(value As List(Of ZutatenVorrat))
        End Set
    End Property
End Class
