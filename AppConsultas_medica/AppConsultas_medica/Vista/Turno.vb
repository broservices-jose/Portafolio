Public Class Turno

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        consulta()
        dgvturno.Columns(0).Visible = False
        ' Add any initialization after the InitializeComponent() call.
        Pasar.tr = New TurnoReg
    End Sub

    Dim rt As RegistroTurno

    Public id_cita As Integer

    Public id_especialidad As Integer

    Public id_medico As Integer

    Public id_sala_medica As Integer


    Private Sub consulta()
        dgvturno.DataSource = RegistroTurno.consultar()
    End Sub

    Private Sub pasarvalor()
        rt.hora = dtphora.Value
        rt.fecha = dtfecha.Value
        rt.turno = txtturno.Text
        id_cita = txtcita.Text
        id_especialidad = txtespecialidad.Text
        id_medico = txtmedico.Text
        id_sala_medica = txtsala.Text
    End Sub

    Public Sub obtenerdato()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnsala.Click
        SalaReg.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncita.Click
        CitaRed.Show()
    End Sub

    Private Sub btnmedico_Click(sender As Object, e As EventArgs) Handles btnmedico.Click
        Dim frm2 As MedRegistrado = CType(Me.ActiveMdiChild, MedRegistrado)
        MedRegistrado.Show()
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If RegistroTurno.registra(New String() {rt.turno, rt.hora, rt.fecha, id_cita.ToString(), id_especialidad.ToString(), id_medico.ToString(), id_medico.ToString()}) Then
            MessageBox.Show("Informacion Registrada Correctamente")
        Else
            MessageBox.Show("Error al Registrar los datos solicitado")
        End If

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class