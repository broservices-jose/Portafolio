Public Class Cita

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        consulta()
        controles()
        dgvcita.Columns(0).Visible = False
    End Sub

    Private Sub consulta()
        dgvcita.DataSource = RegistroCita.consultar()
    End Sub

    Dim rc As New RegistroCita

    Private Sub pasarvalor()
        rc.fecha = dtfecha.Value
        rc.id_paciente = txtpaciente.Text
        rc.hora = dthora.Value
    End Sub

    Private Sub controles()
        txtnumero.Clear()
        txtpaciente.Clear()
        txtrepresentante.Clear()
        dthora.ResetText()
        dtfecha.ResetText()

    End Sub

    Private Sub obtenerdato()
        txtnumero.Text = dgvcita.CurrentRow.Cells(0).Value
        dtfecha.Text = dgvcita.CurrentRow.Cells(1).Value
        dthora.TabIndex = dgvcita.CurrentRow.Cells(2).Value
        txtpaciente.Text = dgvcita.CurrentRow.Cells(3).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PacientesRegistrado.Show()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        pasarvalor()
        If RegistroCita.registrar(New String() {rc.id_cita, rc.fecha, rc.hora, rc.id_paciente}) Then
            MessageBox.Show("Informacion Registrada correctamente")
            consulta()
            controles()

        Else
            MessageBox.Show("Error al registrar la cita")
        End If
    End Sub
End Class
