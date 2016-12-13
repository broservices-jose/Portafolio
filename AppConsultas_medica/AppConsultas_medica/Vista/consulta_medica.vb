Public Class consulta_medica

    Dim rcon As New RegistroConsulta

    Sub pasarvalor()
        rcon.num_consulta = txtnumero.Text
        rcon.tipo = txttipo.Text
        rcon.motivo = txtmotivo.Text
        rcon.observacion = rtobservacion.Text
        rcon.diagnostico = rtdiagnositco.Text
        rcon.enfermedad = txtenfermedad.Text
        rcon.examen = txtexamen.Text
        rcon.fecha = dtfecha.Text
        rcon.receta = txtreceta.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Receta.Show()
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TurnoReg.Show()
    End Sub
End Class