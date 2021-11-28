' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC-Datei und der Konfigurationsdatei ändern.
' HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.vb im Projektmappen-Explorer aus, und starten Sie das Debuggen.
Imports CustomCoffee

Public Class CustomCoffeeService
    Implements ICustomCoffeeService
    'DB implementieren
    Private db As CustomCoffeeDBEntities = New CustomCoffeeDBEntities

    Function GibMeineKreationen() As List(Of Kreation) Implements ICustomCoffeeService.GibMeineKreationen
        Dim kreListe As List(Of Kreation)
        Dim kre As Kreation
        Dim kreEntity As KreationEntity

        kreListe = New List(Of Kreation)

        For Each kreEntity In db.tblKreationen.ToList
            kre = New Kreation(kreEntity)
            kreListe.Add(kre)
        Next

        Return kreListe
    End Function

    Function ErstelleNeueKreation(pKreation) As Kreation Implements ICustomCoffeeService.ErstelleNeueKreation
        Dim kre As Kreation

        kre = pKreation
        Call Kreation.UmwandelnInKreationEntity(kre)

        'kre = New KreationEntity

    End Function

    Public Function GibKunde() As List(Of Kunde) Implements ICustomCoffeeService.GibKunde
        Throw New NotImplementedException()
    End Function

    Public Function GibKreation() As Kreation Implements ICustomCoffeeService.GibKreation
        Throw New NotImplementedException()
    End Function

    Public Function ladeAlleZutaten() As List(Of Zutat) Implements ICustomCoffeeService.ladeAlleZutaten
        Throw New NotImplementedException()
    End Function

    Public Function BerechneEntfernung() As Integer Implements ICustomCoffeeService.BerechneEntfernung
        Throw New NotImplementedException()
    End Function

End Class
