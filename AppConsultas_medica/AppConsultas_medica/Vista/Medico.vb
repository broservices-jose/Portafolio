Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Medico

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        controles()
        consultar()
        dgvmedico.Columns(0).Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub consultar()
        dgvmedico.DataSource = RegistroMedico.consultar()
    End Sub


    Private Sub filtrado(ByVal filtro As String)
        dgvmedico.DataSource = RegistroMedico.filtrar(filtro)
    End Sub


    Dim rm As New RegistroMedico
    Dim ri As New Especialidad
    Dim mi As New Imagen
    Dim id As String
    Dim abrir As New OpenFileDialog()
    Dim picture As Bitmap

    Private Sub pasarvalor()
        rm.nombre = txtnombre.Text
        rm.apellido = txtapellido.Text
        rm.direccion = txtdireccion.Text
        rm.cedula = txtcedula.Text
        rm.edad = txtedad.Text
        rm.correo = txtcorreo.Text
        rm.fecha_nacimiento = dtpfechanac.Value
        rm.hora_entraa = dtphoraent.Value
        rm.hora_salida = dtphorasal.Value
        rm.telefono = txttelefono.Text
        rm.sexo = cbsexo.Text
        ri.especialidad = txtespecialidad.Text
        mi.imagen = txtruta.Text

    End Sub

    Private Sub dameelid()
        rm.id_medico = dgvmedico.CurrentRow.Cells(0).Value
        txtid.Text = dgvmedico.CurrentRow.Cells(0).Value

    End Sub

    Private Sub obtenerdato()
        txtnombre.Text = dgvmedico.CurrentRow.Cells(1).Value
        txtapellido.Text = dgvmedico.CurrentRow.Cells(2).Value
        txtcedula.Text = dgvmedico.CurrentRow.Cells(3).Value
        txtcorreo.Text = dgvmedico.CurrentRow.Cells(4).Value
        txtedad.Text = dgvmedico.CurrentRow.Cells(5).Value
        dtphoraent.Value = dgvmedico.CurrentRow.Cells(6).Value
        dtphorasal.Value = dgvmedico.CurrentRow.Cells(7).Value
        cbsexo.Text = dgvmedico.CurrentRow.Cells(8).Value
        txtdireccion.Text = dgvmedico.CurrentRow.Cells(9).Value
        txttelefono.Text = dgvmedico.CurrentRow.Cells(10).Value
        txtespecialidad.Text = dgvmedico.CurrentRow.Cells(11).Value
        txtruta.Text = dgvmedico.CurrentRow.Cells(12).Value
        'picture = New Bitmap(txtruta.Text)
        'PictureBox1.Image = picture
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'PictureBox2.Image = picture
        'PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub obtenerdatol()
        lblnombre.Text = dgvmedico.CurrentRow.Cells(1).Value
        lblapellido.Text = dgvmedico.CurrentRow.Cells(2).Value
        lblceula.Text = dgvmedico.CurrentRow.Cells(3).Value
        lbledad.Text = dgvmedico.CurrentRow.Cells(4).Value
        lblcorreo.Text = dgvmedico.CurrentRow.Cells(5).Value
        lblhoraen.Text = dgvmedico.CurrentRow.Cells(6).Value
        lblhorasal.Text = dgvmedico.CurrentRow.Cells(7).Value
        lblsexo.Text = dgvmedico.CurrentRow.Cells(8).Value
        rtdireccion.Text = dgvmedico.CurrentRow.Cells(9).Value
        lbltelefono.Text = dgvmedico.CurrentRow.Cells(10).Value
        lblespecialidad.Text = dgvmedico.CurrentRow.Cells(11).Value
        txtruta.Text = dgvmedico.CurrentRow.Cells(12).Value
        'picture = New Bitmap(txtruta.Text)
        'PictureBox1.Image = picture
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'PictureBox2.Image = picture
        'PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub controles()
        txtid.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtcedula.Clear()
        txtcorreo.Clear()
        txtdireccion.Clear()
        txtedad.Clear()
        txtespecialidad.Clear()
        txtidespecialidd.Clear()
        PictureBox1.BackgroundImage = My.Resources.imagenu2
        PictureBox2.BackgroundImage = My.Resources.imagenu2
        txtruta.Clear()
        txttelefono.Clear()
        cbsexo.Text = ""
        dtpfechanac.ResetText()
        dtphoraent.ResetText()
        dtphorasal.ResetText()
        btnregistrar.Enabled = True
        btnlimpiar.Enabled = True

    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click

        pasarvalor()
        If RegistroMedico.registrar(New String() {rm.nombre, rm.apellido, rm.cedula, rm.edad, rm.correo, rm.fecha_nacimiento, rm.hora_entraa, rm.hora_salida, rm.sexo, rm.direccion, rm.telefono}) Then
            MessageBox.Show("Registro Insertado correctamente")
            If Imagen.registrar(txtruta.Text) Then
                MessageBox.Show("Informacion Registrada Correctamente")
                If Especialidad.insertar(txtespecialidad.Text) Then
                    MessageBox.Show("Registro Insertado correctamente")

                    controles()
                    consultar()
                Else
                    MessageBox.Show("Error al Insertar los datos en la tabla especialidad")
                End If
            Else
                MessageBox.Show("Error al Registrar la informacion")
            End If
        Else
            MessageBox.Show("Error al insertar los datos en la tabla medico")
        End If


    End Sub




    Private Sub dgvmedico_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmedico.CellDoubleClick
        obtenerdatol()
        obtenerdato()
        btneliminar.Enabled = False
        btnmodificar.Enabled = True
        btnmodificar2.Enabled = True
    End Sub

    Private Sub Medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbsexo.Items.Add("Masculino")
        cbsexo.Items.Add("Femenino")
        controles()
        consultar()
    End Sub

    Private Sub dgvmedico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmedico.CellClick
        controles()
        dameelid()
        btneliminar.Enabled = True
        btnmodificar.Enabled = False
        btnmodificar2.Enabled = False
    End Sub

    Private Sub btnruta_Click_1(sender As Object, e As EventArgs) Handles btnruta.Click
        abrir.Title = "abre mienda"
        abrir.Filter = "Jpg files (*.jpg )|*.jpg| GIF files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png"

        If abrir.ShowDialog() = DialogResult.OK Then
            mi.imagen = System.IO.Path.GetFullPath(abrir.FileName)
            Me.PictureBox1.Image = New Bitmap(mi.imagen)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            id = abrir.SafeFileName
            txtruta.Text = id
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        controles()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        controles()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        TabControl1.SelectedTab = TabPage2
        btnregistrar.Enabled = False
        btnlimpiar.Enabled = False
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        dameelid()
        If RegistroMedico.eliminar(rm.id_medico) Then
            MessageBox.Show("Registro Eliminado correctamnte")
            consultar()
        Else
            MessageBox.Show("Error Al eliminar los datos solictado")
        End If
    End Sub

    Private Sub btnsalir2_Click(sender As Object, e As EventArgs) Handles btnsalir2.Click
        Me.Close()
    End Sub

    Private Sub btnmodificar2_Click(sender As Object, e As EventArgs) Handles btnmodificar2.Click
        pasarvalor()
        dameelid()
        If RegistroMedico.actualizar(New Object() {rm.id_medico, rm.nombre, rm.apellido, rm.cedula, rm.edad, rm.correo, rm.hora_entraa, rm.hora_salida, rm.sexo, rm.direccion, rm.telefono}) Then
            MessageBox.Show("Registro Actualizado Correctamente")
            consultar()
        Else
            MessageBox.Show("Error al Actualizar los datos solictados")
        End If
        btnregistrar.Enabled = True
        btnlimpiar.Enabled = False
    End Sub

    Private Sub txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtfiltrar.TextChanged
        filtrado(txtfiltrar.Text)
    End Sub


End Class