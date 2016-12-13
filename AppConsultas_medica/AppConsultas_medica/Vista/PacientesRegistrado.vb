Public Class PacientesRegistrado
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        consultar()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DataGridView1.Columns(0).Visible = False
    End Sub

    Public Sub consultar()
        DataGridView1.DataSource = RegistroPaciente.consultar()
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        Pasar.c.txtnumero.Text = DataGridView1.CurrentRow.Cells(0).Value
        Pasar.c.txtpaciente.Text = DataGridView1.CurrentRow.Cells(1).Value
        Pasar.c.txtrepresentante.Text = DataGridView1.CurrentRow.Cells(12).Value
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Pasar.rp.Show()
    End Sub
End Class