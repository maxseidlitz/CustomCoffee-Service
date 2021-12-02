Public Class frmAlleKreationen
    Private Sub dgvKreationen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKreationen.CellContentClick

    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click
        Call laden()
    End Sub

    Private Sub laden()
        Dim KreationenListe As List(Of CustomCoffeeServiceReference.Kreationen)
        Dim svc As CustomCoffeeServiceReference.ICustomCoffeeService
        svc = New CustomCoffeeServiceReference.CustomCoffeeClient
        KreationenListe = svc.GibMeineKreationen
        Me.dgvKreationen.DataSource = KreationenListe
    End Sub

    Private Sub ErstelleNeueKreation()

    End Sub
End Class
