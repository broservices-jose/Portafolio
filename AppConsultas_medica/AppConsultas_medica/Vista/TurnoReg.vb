Public Class TurnoReg

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub consultar()
        dgvsalareg.DataSource = RegistroTurno.consultar()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

    End Sub
End Class