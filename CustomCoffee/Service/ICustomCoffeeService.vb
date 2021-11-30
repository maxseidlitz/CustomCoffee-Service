' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
<ServiceContract()>
Public Interface ICustomCoffeeService

    <OperationContract()>
    Function GibKunde(pstrBenutzername As Kunde) As List(Of Kunde) '

    <OperationContract()>
    Function GibMeineKreationen() As List(Of Kreation) 'lädt alle Kreationen des Benutzers

    <OperationContract()>
    Function GibKreation(pintID As Integer) As Kreation 'lädt nur die ausgewählte Kreation vom Server runter

    <OperationContract()>
    Function ErstelleNeueKreation(pintBasis As Integer, pintExtra1 As Integer, pintExtra2 As Integer, pintMilch As Integer, pintTopping As Integer) As Kreation 'erstellt eine neue Kreation

    <OperationContract()>
    Function ladeAlleZutaten() As List(Of Zutat) 'lädt alle Zutaten für die Auswahl im "Kreationsersteller"

    <OperationContract()>
    Function BerechneEntfernung() As Integer '

    <OperationContract()>
    Function BestelleKreation(pKreation As Kreation) As Auftrag 'Kreation soll bestellt werden und am Automaten in Auftrag genommen werden

    '<OperationContract()>
    'Function LadeAlleAllergene() As List(Of Kreation) ''auskommentiert, weil es ja Állergene ja Zutaten sind, oder?

    '<OperationContract()>
    'Function ladeAlleKreationen() As Kreation 'lädt alle Kreationen

End Interface