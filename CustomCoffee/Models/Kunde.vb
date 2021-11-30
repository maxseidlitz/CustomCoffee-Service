Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Kunde

    Private mstrBenutzername As String
    Private mstrName As String
    Private mstrVorname As String
    Private mdatGebDat As Date
    Private mAllergen1 As Allergen
    Private mAllergen2 As Allergen
    Private mAllergen3 As Allergen
    Private mAllergen4 As Allergen
    Private mAllergen5 As Allergen
    Private mLieblingsmilch As Zutat
    Private mAuftraege As List(Of Auftrag)


    'parameterloser Konstruktor
    Public Sub New()
        mstrBenutzername = String.Empty
        mstrName = String.Empty
        mstrVorname = String.Empty
        mdatGebDat = Nothing
        mAllergen1 = Nothing
        mAllergen2 = Nothing
        mAllergen3 = Nothing
        mAllergen4 = Nothing
        mAllergen5 = Nothing
        mLieblingsmilch = Nothing
        mAuftraege = Nothing
    End Sub


    Public Property strBenutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strName As String
        Get
            Return mstrName
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property strVorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property datGebDat As Date
        Get
            Return mdatGebDat
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property Lieblingsmilch As Zutat
        Get
            Return mLieblingsmilch
        End Get
        Set(value As Zutat)
        End Set
    End Property

    Public Property Auftraege As List(Of Auftrag)
        Get
            Return Nothing
        End Get
        Set(value As List(Of Auftrag))
        End Set
    End Property

    Public Property Allergen1 As Allergen
        Get
            Return mAllergen1
        End Get
        Set(value As Allergen)
        End Set
    End Property

    Public Property Allergen2 As Allergen
        Get
            Return mAllergen2
        End Get
        Set(value As Allergen)
        End Set
    End Property

    Public Property Allergen3 As Allergen
        Get
            Return mAllergen3
        End Get
        Set(value As Allergen)
        End Set
    End Property

    Public Property Allergen4 As Allergen
        Get
            Return mAllergen4
        End Get
        Set(value As Allergen)
        End Set
    End Property

    Public Property Allergen5 As Allergen
        Get
            Return mAllergen5
        End Get
        Set(value As Allergen)
        End Set
    End Property
End Class
