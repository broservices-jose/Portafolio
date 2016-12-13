Public Class SalaReg

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        cosnulta()
        Pasar.tr = New TurnoReg()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cosnulta()
        dgvsalareg.DataSource = RegistroSala.consultar()
    End Sub
    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click


    End Sub
End Class