' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
<ServiceContract()>
Public Interface ICustomCoffeeService

    <OperationContract()>
    Function GibMeineKreationen() As List(Of Kreation)

    <OperationContract()>
    Function HinzufuegenNeueKreation() As Kreation

End Interface