Public Class frmAlleKreationen
    Private Sub dgvKreationen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKreationen.CellContentClick

    End Sub

    Private Sub btnLaden_Click(sender As Object, e As EventArgs) Handles btnLaden.Click

    End Sub

    Private Sub laden()
        Dim KreationenListe As List(Of CustomCoffeeService.Kreationen)
        Dim svc As CustomCoffeeService.ICustomCoffeeService

        svc = New CustomCoffeeService.CustomCoffeeClient

        KreationenListe = svc.GibMeineKreationen
        Me.dgvKreationen.DataSource = KreationenListe
    End Sub

End Class
