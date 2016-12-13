Public Class MedRegistrado

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        consultar()
        dgvmedregistrado.Columns(0).Visible = False
        ' Add any initialization after the InitializeComponent() call.
        Pasar.t = New Turno
    End Sub

    Private Sub consultar()
        dgvmedregistrado.DataSource = RegistroMedico.consultar()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        Pasar.t.id_medico = dgvmedregistrado.CurrentRow.Cells(0).Value
        Pasar.t.txtmedico = dgvmedregistrado.CurrentRow.Cells(1).Value

        Me.Hide()
        Pasar.tr.Show()
    End Sub

    Private Sub obtenerdato()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Pasar.rm.Show()
    End Sub
End Class