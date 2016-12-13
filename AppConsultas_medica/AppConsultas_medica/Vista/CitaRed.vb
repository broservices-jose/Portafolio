Public Class CitaRed

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dgvcitareg.Columns(0).Visible = False
    End Sub
    Private Sub consulta()
        dgvcitareg.DataSource = RegistroCita.consultar()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

    End Sub
End Class