Public Class Usuario

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Es recomendable tener separado por comentarios el initializecomponet() con los 
        'metodos necesarios para que este formulario trabaje
        consultar()
        controles()
        dgvusuario.Columns(0).Visible = False

    End Sub
    Dim ur As New RegistroUsuario()
    Dim ir As New Imagen()
    Dim abrir As New OpenFileDialog()
    Private picture As Bitmap
    Private id As String

    Private Sub filtrado(filtro As String)
        dgvusuario.DataSource = RegistroUsuario.filtrar(filtro)
    End Sub


    Private Sub consultar()
        dgvusuario.DataSource = RegistroUsuario.consultar()
    End Sub


    Private Sub dameelid()
        ur.id_usuario = dgvusuario.CurrentRow.Cells(0).Value
        txtidusuario.Text = dgvusuario.CurrentRow.Cells(0).Value
        lblid.Text = dgvusuario.CurrentRow.Cells(0).Value

    End Sub

    Private Sub obtenerdatot()
        lblnombre.Text = dgvusuario.CurrentRow.Cells(1).Value
        lblpermiso.Text = dgvusuario.CurrentRow.Cells(2).Value
        lblclave.Text = dgvusuario.CurrentRow.Cells(3).Value
        lblinicio.Text = dgvusuario.CurrentRow.Cells(4).Value
        lblcierre.Text = dgvusuario.CurrentRow.Cells(5).Value
        lblarea.Text = dgvusuario.CurrentRow.Cells(6).Value
    End Sub

    Private Sub obtenerdato()
        txtnombre.Text = dgvusuario.CurrentRow.Cells(1).Value
        cbpermiso.Text = dgvusuario.CurrentRow.Cells(2).Value
        txtclave.Text = dgvusuario.CurrentRow.Cells(3).Value
        dtpinicio.Text = dgvusuario.CurrentRow.Cells(4).Value
        dtpcierre.Text = dgvusuario.CurrentRow.Cells(5).Value
        txtarea.Text = dgvusuario.CurrentRow.Cells(6).Value
        txtruta.Text = dgvusuario.CurrentRow.Cells(7).Value
    End Sub

    Public Sub pasarvalor()
        ur.nombre = txtnombre.Text
        ur.permiso = cbpermiso.Text
        ur.clave = txtclave.Text
        ur.area = txtarea.Text
        ur.registro_cierres = dtpcierre.Value
        ur.registro_inicios = dtpinicio.Value
        ir.imagen = txtruta.Text
    End Sub


    Public Sub controles()
        txtarea.Clear()
        txtnombre.Clear()
        txtclave.Clear()
        txtidusuario.Clear()
        cbpermiso.Text = ""
        dtpcierre.Text = ""
        dtpinicio.Text = ""
        btnmodificar.Enabled = False
        btneliminar.Enabled = False
        btnreigstrar.Enabled = True
        btnlimpiar.Enabled = True
    End Sub

    Private Sub btnreigstrar_Click(sender As Object, e As EventArgs) Handles btnreigstrar.Click
        pasarvalor()

        If RegistroUsuario.registrar(New String() {ur.nombre, ur.permiso, ur.clave, ur.registro_inicios, ur.registro_cierres, ur.area}) Then
            MessageBox.Show("Informacion Registrada Correctamente")

            If Imagen.registrar(ir.imagen) Then
                MessageBox.Show("Informacion Registrada correctamente")

            Else
                MessageBox.Show("Error al registrar Esta informacion")
            End If

        Else
            MessageBox.Show("Error al Registrar esta informacion")
        End If

        consultar()
        controles()


    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbpermiso.Items.Add("Administrador")
        cbpermiso.Items.Add("Estandar")
        cbpermiso.Items.Add("Limitado")
        cbpermiso.Items.Add("Visitante")
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        abrir.Title = "abre mienda"
        abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png"

        If abrir.ShowDialog() = DialogResult.OK Then
            ir.imagen = System.IO.Path.GetFullPath(abrir.FileName)
            pictureBox1.Image = New Bitmap(ir.imagen)
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            id = abrir.SafeFileName
            txtruta.Text = id
            'Bitmap picture = New Bitmap(ma.Imagen1)
            'pictureBox1.Image = (Image)picture
            'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'id = abrir.SafeFileName;
            'txtruta.Text = id;
        Else

        End If
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        filtrado(txtfiltrar.Text)
    End Sub

    Private Sub dgvusuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuario.CellClick
        dameelid()
        btneliminar.Enabled = True
        btnmodificar.Enabled = False
    End Sub

    Private Sub dgvusuario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuario.CellDoubleClick
        dameelid()
        obtenerdato()
        obtenerdatot()
        btneliminar.Enabled = False
        btnmodificar.Enabled = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        controles()
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If RegistroUsuario.eliminar(ur.id_usuario) Then
            MessageBox.Show("Registro eliminado Correctamente")
        Else
            MessageBox.Show("Error al eliminar los datos solicitado")
        End If
        consultar()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        TabControl1.SelectedTab = TabPage2
        btnreigstrar.Enabled = False

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnmodificar2_Click(sender As Object, e As EventArgs) Handles btnmodificar2.Click
        pasarvalor()
        If RegistroUsuario.actualizar(New Object() {ur.id_usuario, ur.nombre, ur.permiso, ur.clave, ur.registro_inicios, ur.registro_cierres, ur.area, ir.imagen}) Then
            MessageBox.Show("Registro Actualizado correctamente")
        Else
            MessageBox.Show("Error al actualizar los datos solicatado")
        End If
        consultar()
        controles()
        btnreigstrar.Enabled = True
        btnlimpiar.Enabled = True
    End Sub
End Class