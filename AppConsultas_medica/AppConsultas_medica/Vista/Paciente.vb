Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Paciente

    Public Sub New()
        '==============================================='
        'Este es el constructor de mi formulario para llamar el InitializeComponent()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        consultar()
        controles()
        dgvpaciente.Columns(0).Visible = False

    End Sub

    '*==========================================================*
    'Este codigo en adelante representa la declaracion de variable
    ' y Instanciacion de los objetos para imagencenar la ruta   de
    'la imagen de los picturebox


    Dim abrir As New OpenFileDialog()
    Dim picture As Bitmap
    Private id As String
    Dim pc As New RegistroPaciente()
    Dim pi As New Imagen()


    Private Sub consultar()
        dgvpaciente.DataSource = RegistroPaciente.consultar()

    End Sub

    Private Sub Fnombre(ByVal filtro As String)
        dgvpaciente.DataSource = RegistroPaciente.filtrar(filtro)
    End Sub



    Private Sub controles()
        txtapellido.Clear()
        txtnombre.Clear()
        txtcedula.Clear()
        txtdireccion.Clear()
        txtcorreo.Clear()
        txtedad.Clear()
        txtid.Clear()
        txtpeso.Clear()
        txtrepresentante.Clear()
        txttelefono.Clear()
        txttelrepresenta.Clear()
        cbsexo.Text = ""
        dtpfechanac.ResetText()
        txtruta.Clear()
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        btnregistrar.Enabled = True
        btnlimpiar.Enabled = True
    End Sub

    Private Sub obtenerid()
        pc.id_paciente = Convert.ToInt32(dgvpaciente.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub obtenerdatost()
        obtenerid()
        txtnombre.Text = dgvpaciente.CurrentRow.Cells(1).Value
        txtapellido.Text = dgvpaciente.CurrentRow.Cells(2).Value
        txtcedula.Text = dgvpaciente.CurrentRow.Cells(3).Value
        cbsexo.Text = dgvpaciente.CurrentRow.Cells(4).Value
        txtedad.Text = dgvpaciente.CurrentRow.Cells(5).Value
        txttelefono.Text = dgvpaciente.CurrentRow.Cells(6).Value
        txtdireccion.Text = dgvpaciente.CurrentRow.Cells(7).Value
        txtcorreo.Text = dgvpaciente.CurrentRow.Cells(8).Value
        dtpfechanac.Text = dgvpaciente.CurrentRow.Cells(9).Value
        txtpeso.Text = dgvpaciente.CurrentRow.Cells(10).Value
        txttelrepresenta.Text = dgvpaciente.CurrentRow.Cells(11).Value
        txtrepresentante.Text = dgvpaciente.CurrentRow.Cells(12).Value
        txtruta.Text = dgvpaciente.CurrentRow.Cells(13).Value
        picture = New Bitmap(txtruta.Text)
        PictureBox1.Image = picture
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub obtenerdatosl()
        obtenerid()
        lblnombre.Text = dgvpaciente.CurrentRow.Cells(1).Value
        lblapellido.Text = dgvpaciente.CurrentRow.Cells(2).Value
        lblcedula.Text = dgvpaciente.CurrentRow.Cells(3).Value
        lblsexo.Text = dgvpaciente.CurrentRow.Cells(4).Value
        lbledad.Text = dgvpaciente.CurrentRow.Cells(5).Value
        lbltelefono.Text = dgvpaciente.CurrentRow.Cells(6).Value
        rtdireccion.Text = dgvpaciente.CurrentRow.Cells(7).Value
        lblcorreo.Text = dgvpaciente.CurrentRow.Cells(8).Value
        lblnacimiento.Text = dgvpaciente.CurrentRow.Cells(9).Value
        lblpeso.Text = dgvpaciente.CurrentRow.Cells(10).Value
        lbltelrepresetna.Text = dgvpaciente.CurrentRow.Cells(11).Value
        lblrepresentate.Text = dgvpaciente.CurrentRow.Cells(12).Value
        txtruta.Text = dgvpaciente.CurrentRow.Cells(13).Value
        picture = New Bitmap(txtruta.Text)
        PictureBox1.Image = picture
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.Image = picture
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub pasarvalor()

        pc.nombre = txtnombre.Text
        pc.apellido = txtapellido.Text
        pc.cedula = txtcedula.Text
        pc.correo = txtcorreo.Text
        pc.direccion = txtdireccion.Text
        pc.edad = txtedad.Text
        pc.fecha_nac = dtpfechanac.Value
        pc.peso = txtpeso.Text
        pc.representante = txtrepresentante.Text
        pc.sexo = cbsexo.Text
        pc.telefono = txttelefono.Text
        pc.telrepresenta = txttelrepresenta.Text
    End Sub



    Private Sub Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbsexo.Items.Add("Masculino")
        cbsexo.Items.Add("Femenino")
        controles()
        consultar()
    End Sub

    Private Sub btnruta_Click(sender As Object, e As EventArgs) Handles btnruta.Click
        abrir.Title = "abre mienda"
        abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png"

        If abrir.ShowDialog() = DialogResult.OK Then
            pi.imagen = System.IO.Path.GetFullPath(abrir.FileName)
            PictureBox1.Image = New Bitmap(pi.imagen)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

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

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        pasarvalor()
        If RegistroPaciente.registrar(New String() {pc.nombre, pc.apellido, pc.cedula, pc.sexo, pc.edad, pc.telefono, pc.direccion, pc.correo, pc.fecha_nac, pc.peso, pc.telrepresenta, pc.representante}) Then
            MessageBox.Show("Registro registrado correctamente")
            'txtnombre.Text, txtapellido.Text, txtcedula.Text, cbsexo.Text, txtedad.Text, txttelefono.Text, txtdireccion.Text, txtcorreo.Text, dtpfechanac.Text, txtpeso.Text, txttelrepresenta.Text, txtrepresentante.Text
            '
            If Imagen.registrar(txtruta.Text) Then
                MessageBox.Show("Informacion Registrada Correctamente")
                consultar()
                controles()
            Else
                MessageBox.Show("Error al Registrar la informacion")
            End If
        Else
            MessageBox.Show("Error al registrar los datos en persona")
        End If




    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        controles()
    End Sub

    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If RegistroPaciente.eliminar(pc.id_paciente) Then
            MessageBox.Show("Registro Eliminado correctamente")
            consultar()
            controles()
        Else
            MessageBox.Show("Error Al eliminar los datos solicitado")
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        TabControl1.SelectedTab = TabPage2
        btnlimpiar.Enabled = False
        btnregistrar.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        controles()
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        Fnombre(Me.txtfiltrar.Text)
    End Sub

    Private Sub dgvpaciente_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpaciente.CellClick
        controles()
        obtenerid()
        btneliminar.Enabled = True
        btnmodificar.Enabled = False
        btnmodificar2.Enabled = False
    End Sub

    Private Sub dgvpaciente_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpaciente.CellDoubleClick
        obtenerdatosl()
        obtenerdatost()
        btneliminar.Enabled = False
        btnmodificar.Enabled = True
        btnmodificar2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmodificar2.Click
        pasarvalor()
        If RegistroPaciente.actualizar(New Object() {txtnombre.Text, txtapellido.Text, txtcedula.Text, cbsexo.Text, txtedad.Text, txttelefono.Text, txtdireccion.Text, txtcorreo.Text, dtpfechanac.Text, txtpeso.Text, txttelrepresenta.Text, txtrepresentante.Text}) Then
            MessageBox.Show("Registro Actualizado correctamente")
            consultar()
            controles()
        Else
            MessageBox.Show("Error al actualizar la informacion del paciente")
        End If
        btnregistrar.Enabled = True
        btnlimpiar.Enabled = True
    End Sub
End Class