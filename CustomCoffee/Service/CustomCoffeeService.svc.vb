' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC-Datei und der Konfigurationsdatei ändern.
' HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts Service1.svc oder Service1.svc.vb im Projektmappen-Explorer aus, und starten Sie das Debuggen.
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

    Public Function HinzufuegenNeueKreation() As Kreation Implements ICustomCoffeeService.HinzufuegenNeueKreation
        Throw New NotImplementedException()
    End Function
End Class
