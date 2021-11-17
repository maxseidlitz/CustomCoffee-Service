Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Kreation

    Private mintID As Integer
    Private mstrBezeichnung As String
    Private mKunde As Kunde
    Private mstrBasis As Zutat
    Private mstrExtra1 As Zutat
    Private mstrExtra2 As Zutat
    Private mstrMilch As Zutat
    Private mstrTopping As Zutat
    Private mintLikeAnzahl As Integer
    Private mdblPreis As Double

    'parameterloser Konstruktor
    Public Sub New()
        mintID = -1
        mstrBasis = Nothing
        mstrExtra1 = Nothing
        mstrExtra2 = Nothing
        mstrMilch = Nothing
        mstrTopping = Nothing
        mintLikeAnzahl = -1
        mKunde = Nothing
    End Sub

    'Parameter-Konstruktor
    Public Sub New(pID As Integer, pBasis As Zutat, pExtra1 As Zutat, pExtra2 As Zutat, pMilch As Zutat, pTopping As Zutat, pLikeAnzahl As Integer)
        mintID = pID
        mstrBasis = pBasis
        mstrExtra1 = pExtra1
        mstrExtra2 = pExtra2
        mstrMilch = pMilch
        mstrTopping = pTopping
        mintLikeAnzahl = pLikeAnzahl
    End Sub

    'hier liegt ein Problem mit der Datentypvergabe vor, habe ich einen falschen Gedanken mit dem Klassendiagramm gehabt? // MS; 14h, 31.10.21
    Public Sub New(pKreationEntity As KreationEntity)
        mintID = pKreationEntity.kreID
        mstrBasis = pKreationEntity.krezutBasis
        mstrExtra1 = pKreationEntity.krezutExtra1
        mstrExtra2 = pKreationEntity.krezutExtra2
        mstrMilch = pKreationEntity.krezutMilch
        mstrTopping = pKreationEntity.krezutTopping
        mintLikeAnzahl = pKreationEntity.kreLikeAnzahl
    End Sub

    Public Function gibalsEntity() As KreationEntity
        Dim kreEntity As KreationEntity

        kreEntity = New KreationEntity
        kreEntity.kreID = ID
        kreEntity.kreBezeichnung = Bezeichnung
        kreEntity.krezutBasis = Basis
        kreEntity.krezutExtra1 = Extra1
        kreEntity.krezutExtra2 = Extra2
        kreEntity.krezutMilch = Milch
        kreEntity.krezutTopping = Topping
        kreEntity.kreLikeAnzahl = LikeAnzahl


    End Function

    Public Property ID As Integer
        Get
            Return mintID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Bezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property LikeAnzahl As Integer
        Get
            Return mintLikeAnzahl
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Kunde As Kunde
        Get
            Return mKunde
        End Get
        Set(value As Kunde)
        End Set
    End Property

    Public Property Preis As Double
        Get
            Return mdblPreis
        End Get
        Set(value As Double)
        End Set
    End Property

    Public Property Basis As Zutat
        Get
            Return mstrBasis
        End Get
        Set(value As Zutat)
        End Set
    End Property

    Public Property Extra1 As Zutat
        Get
            Return mstrExtra1
        End Get
        Set(value As Zutat)
        End Set
    End Property

    Public Property Extra2 As Zutat
        Get
            Return mstrExtra2
        End Get
        Set(value As Zutat)
        End Set
    End Property

    Public Property Topping As Zutat
        Get
            Return mstrTopping
        End Get
        Set(value As Zutat)
        End Set
    End Property

    Public Property Milch As Zutat
        Get
            Return mstrMilch
        End Get
        Set(value As Zutat)
        End Set
    End Property
End Class
