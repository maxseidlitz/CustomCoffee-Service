'------------------------------------------------------------------------------
' <auto-generated>
'    Dieser Code wurde aus einer Vorlage generiert.
'
'    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
'    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ZutatEntity
    Public Property zutID As Integer
    Public Property zutBezeichnung As String
    Public Property zutkatKategorie As Integer

    Public Overridable Property tblKategorien As KategorieEntity
    Public Overridable Property tblKreationen As ICollection(Of KreationEntity) = New HashSet(Of KreationEntity)
    Public Overridable Property tblKreationen1 As ICollection(Of KreationEntity) = New HashSet(Of KreationEntity)
    Public Overridable Property tblKreationen2 As ICollection(Of KreationEntity) = New HashSet(Of KreationEntity)
    Public Overridable Property tblKreationen3 As ICollection(Of KreationEntity) = New HashSet(Of KreationEntity)
    Public Overridable Property tblKreationen4 As ICollection(Of KreationEntity) = New HashSet(Of KreationEntity)
    Public Overridable Property tblKunden As ICollection(Of KundeEntity) = New HashSet(Of KundeEntity)

End Class