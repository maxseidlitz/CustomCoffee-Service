' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC-Datei und der Konfigurationsdatei ändern.
' HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.vb im Projektmappen-Explorer aus, und starten Sie das Debuggen.
Imports CustomCoffee

Public Class CustomCoffeeService
    Implements ICustomCoffeeService
    'DB implementieren
    Private db As CustomCoffeeDBEntities = New CustomCoffeeDBEntities




    '''_________________________________________________________________________________________________________________
    Function GibMeineKreationen() As List(Of Kreation) Implements ICustomCoffeeService.GibMeineKreationen
        Dim kreListe As List(Of Kreation)
        Dim kre As Kreation
        Dim kreEntity As KreationEntity

        kreListe = New List(Of Kreation)

        For Each kreEntity In db.tblKreationen.ToList 'Lesen der Datenbank
            kre = New Kreation(kreEntity)
            kreListe.Add(kre) 'Alle Bestellungen der Liste hinzufügen [Add]
        Next

        Return kreListe
    End Function
    '''_________________________________________________________________________________________________________________!



    Function ErstelleNeueKreation(pintBasis As Integer, pintExtra1 As Integer, pintExtra2 As Integer, pintMilch As Integer, pintTopping As Integer) As Kreation Implements ICustomCoffeeService.ErstelleNeueKreation
        Throw New NotImplementedException()

    End Function

    Public Function GibKunde(pstrBenutzername As Kunde) As List(Of Kunde) Implements ICustomCoffeeService.GibKunde
        Throw New NotImplementedException()
    End Function

    Public Function GibKreation(pintID As Integer) As Kreation Implements ICustomCoffeeService.GibKreation
        Throw New NotImplementedException()
    End Function

    Public Function ladeAlleZutaten() As List(Of Zutat) Implements ICustomCoffeeService.ladeAlleZutaten
        Throw New NotImplementedException()
    End Function

    Public Function BerechneEntfernung() As Integer Implements ICustomCoffeeService.BerechneEntfernung
        Throw New NotImplementedException()
    End Function

    Public Function BestelleKreation(pKreation As Kreation) As Auftrag Implements ICustomCoffeeService.BestelleKreation
        Throw New NotImplementedException()
    End Function



End Class
