Imports MySql.Data.MySqlClient


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+


Public Class VentanaPrincipal

    Public Shared usuarioActual = "ninguno"
    Public estudianteActual As Estudiante


    Public Shared VentanaPrincipalConpartida As VentanaPrincipal

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabUsuarios.Click

    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContorladorVentanaPrincipal.cargarTablaUsuarios(dataGridUsuarios)

        VentanaPrincipalConpartida = Me

        Dim idUsuario = VentanaPrincipal.usuarioActual

        ' Se asigna el estudiante actual mediante us id.
        estudianteActual = New Estudiante(VentanaPrincipal.usuarioActual)

        pictureBoxEstudiante.ImageLocation = ModeloImagenes.cargarImagen(idUsuario, "estudiante")
        labelNombreCompleto.Text = ModeloUsuarios.octenerNombreCompletoPorId(idUsuario)

        labelCarrera.Text = estudianteActual.nombreCarrera
        labelId.Text = estudianteActual.id

        labelSexo.Text = estudianteActual.sexo

        ContorladorVentanaPrincipal.cargarTablaEstadoMateriasEstudiantes(dataGridPendientes, idUsuario, ModeloMaterias.EN_PROCESO)
        ContorladorVentanaPrincipal.cargarTablaEstadoMateriasEstudiantes(dataGridAprovadas, idUsuario, ModeloMaterias.APROVADA)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub NelsonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NelsonToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTiempo.Text = DateTime.Now.ToString()
        'MessageBox.Show(Timer1.Enabled
        '                )
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonUsuarios.Click

        '-----------------------------------------
        '   Se llena selecciona el index 0 que concuerda con el tab que tiene los usuarios
        tabControlPrincipal.SelectedIndex = 0
        '-----------------------------------------

        '-----------------------------------------
        '   Se llena la tabla de los usuarios
        ContorladorVentanaPrincipal.cargarTablaUsuarios(dataGridUsuarios)
        '-----------------------------------------
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonCarreras.Click
        '-----------------------------------------
        '   Se selecciona el panel de las carreras
        tabControlPrincipal.SelectedIndex = 3

        '-----------------------------------------
        '   Se llena la tabla de las carreras.
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
        '-----------------------------------------
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUsuarios.CellContentClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '-----------------------------------
        '   Se que el modo en que se va a insertar en un administrador
        '   Y no un usuario.
        '-----------------------------------
        RegistrarEstudiante.Modo = ModeloUsuarios.ADMINISTRADOR
        '-----------------------------------
        RegistrarEstudiante.Show()
    End Sub

    Private Sub dataGridUsuarios_Click(sender As Object, e As EventArgs) Handles dataGridUsuarios.Click

        '-----------------------------------
        '   Se selecciona la celda 0 porque es el id del usuario.
        '   Luego esta es trabajada por la funcion del controlador de testa ventana.
        '-----------------------------------
        Dim idUsuario As String = dataGridUsuarios.CurrentRow.Cells(0).Value
        '-----------------------------------
        '   Se consulta tambien el tipo de usuario. esto esta en la fila 4.
        Dim tipoUsuario As String = dataGridUsuarios.CurrentRow.Cells(4).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.cargarInformacionUsuario(Me, idUsuario)
        '-----------------------------------
        '   Se llama al metodo asignar imagen del controlador.
        '-----------------------------------
        ContorladorVentanaPrincipal.asignarImagenPictureBox(picturePerfil, idUsuario, tipoUsuario)
        '-----------------------------------
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '-----------------------------------
        '   Metodo para deshabilitar usuario.
        '-----------------------------------
        '   Se selecciona la celda 0 porque es el id del usuario.
        '-----------------------------------
        Dim idUsuario As String = dataGridUsuarios.CurrentRow.Cells(0).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.deshabilitarUsuario(idUsuario)
        '-----------------------------------
        '   Se actuliza la tabla de los usuarios.
        ContorladorVentanaPrincipal.cargarTablaUsuarios(dataGridUsuarios)
        '-----------------------------------
        MessageBox.Show("Se Deshabilito el usuario: " + idUsuario)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '-----------------------------------
        '   Metodo para habilitar usuarios
        '-----------------------------------
        '   Se selecciona la celda 0 porque es el id del usuario.
        '-----------------------------------
        Dim idUsuario As String = dataGridUsuarios.CurrentRow.Cells(0).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.habilitarUsuario(idUsuario)
        '-----------------------------------
        '   Se actuliza la tabla de los usuarios.
        ContorladorVentanaPrincipal.cargarTablaUsuarios(dataGridUsuarios)
        '-----------------------------------
        MessageBox.Show("Se habilito el usuario: " + idUsuario)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        '-----------------------------------
        '   Se selecciona la celda 0 porque es el id del usuario.
        '-----------------------------------
        Dim idUsuario As String = dataGridUsuarios.CurrentRow.Cells(0).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.llenarModificarUsuario(idUsuario)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        '-----------------------------------
        '   Nombre de la materia que se va agregar
        '-----------------------------------
        Dim nombreMateria = carreraTxtAlterar.Text
        '-----------------------------------
        ContorladorVentanaPrincipal.agregarCarrera(nombreMateria, ModeloCarreras.DISPONIBLE)
        '-----------------------------------
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
        '-----------------------------------

    End Sub

    Private Sub dataGridCarreras_Click(sender As Object, e As EventArgs) Handles dataGridCarreras.Click
        '-----------------------------------
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '-----------------------------------
        '   id de la carrera que se va a clausurar
        '-----------------------------------
        Dim idCarrera = dataGridCarreras.CurrentRow.Cells(0).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.deshabilitarCarrera(idCarrera)
        '-----------------------------------
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '-----------------------------------
        '   id de la materia que se va a rehabilitar
        '-----------------------------------
        Dim idCarrera = dataGridCarreras.CurrentRow.Cells(0).Value
        '-----------------------------------
        ContorladorVentanaPrincipal.habilitarCarrera(idCarrera)
        '-----------------------------------
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '-----------------------------------
        '   id de la materia que se va a rehabilitar
        '-----------------------------------
        Dim idCarrera = dataGridCarreras.CurrentRow.Cells(0).Value
        '-----------------------------------
        '   Aqui me salte lo del controlador por utilizar el modelo direcctamente.
        ModeloCarreras.eliminarPermanente(idCarrera)
        '-----------------------------------
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles botonGestionEmpresa.Click
        '-----------------------------------
        '   Se selecciona el tab de la empresa.
        tabControlPrincipal.SelectedIndex = 1
        '-----------------------------------
        If ModeloEntidad.confirmarModo() = ModeloEntidad.MODIFICAR Then
            ContorladorVentanaPrincipal.cargarDatosEntidad(Me)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button19.Click
        '------------------------------------------------
        '   El modo confirma que se desea hacer con la entidad.
        '   Si se va a insertar una nueva entidad nunca registrada.
        '   O si se va a modificar la entidad que se registro.

        If ModeloEntidad.confirmarModo() = ModeloEntidad.REGISTRAR Then
            '------------------------------------------------
            '   Se llama al controlador para insertar la imagen
            ContorladorVentanaPrincipal.registrarEntidad(Me)
            '------------------------------------------------
        ElseIf ModeloEntidad.confirmarModo() = ModeloEntidad.MODIFICAR Then
            ContorladorVentanaPrincipal.modificarEntidad(Me)
            ContorladorVentanaPrincipal.cargarDatosEntidad(Me)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureBoxEntidad.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles botonGestionMaterias.Click
        '-----------------------------------------------
        '   Se el tab de las materias
        tabControlPrincipal.SelectedIndex = 4
        '-----------------------------------------------
        '   Se cargan los datos a la tabla de las materias.
        ContorladorVentanaPrincipal.cargarTablaMaterias(DataGridMaterias)
        '-----------------------------------------------
        ContorladorVentanaPrincipal.cargarNombresCombo(comboCarreras)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles botonOpciones.Click

    End Sub

    Private Sub TabGestionEmpresa_Click(sender As Object, e As EventArgs) Handles TabGestionEmpresa.Click

    End Sub

    Private Sub pictureBoxEntidad_Click(sender As Object, e As EventArgs) Handles pictureBoxEntidad.Click

    End Sub


    Private Sub TabCarreras_Click(sender As Object, e As EventArgs) Handles TabCarreras.Click

    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '--------------------------------------------
        '   Funcion par alterar la materia
        Dim materia = DataGridMaterias.CurrentRow.Cells(0).Value
        '--------------------------------------------

        ModeloMaterias.cambiarEstadoMateria(materia, ModeloMaterias.CLAUSURADA)

        '--------------------------------------------
        '   Se actualizan la tabla de las materias
        ContorladorVentanaPrincipal.cargarTablaMaterias(DataGridMaterias)
        '--------------------------------------------
    End Sub

    Private Sub idEmpresaTxt_TextChanged(sender As Object, e As EventArgs) Handles idEmpresaTxt.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TabMateria_Click(sender As Object, e As EventArgs) Handles TabMateria.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AgregarMateria.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '--------------------------------------------
        '   Funcion par alterar la materia
        Dim materia = DataGridMaterias.CurrentRow.Cells(0).Value
        '--------------------------------------------
        ModeloMaterias.eliminarMateria(materia)
        '--------------------------------------------
        '   Se actualizan la tabla de las materias
        ContorladorVentanaPrincipal.cargarTablaMaterias(DataGridMaterias)
        '--------------------------------------------
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '--------------------------------------------
        '   Funcion par alterar la materia
        Dim materia = DataGridMaterias.CurrentRow.Cells(0).Value
        '--------------------------------------------

        ModeloMaterias.cambiarEstadoMateria(materia, ModeloMaterias.DISPONIBLE)

        '--------------------------------------------
        '   Se actualizan la tabla de las materias
        ContorladorVentanaPrincipal.cargarTablaMaterias(DataGridMaterias)
        '--------------------------------------------
    End Sub

    Private Sub botonEstudiantes_Click(sender As Object, e As EventArgs) Handles botonEstudiantes.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SeleccionarMateria.Show()
    End Sub

    Private Sub labelTiempo_Click(sender As Object, e As EventArgs) Handles labelTiempo.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ContorladorVentanaPrincipal.cargarTablaUsuariosFiltro(dataGridUsuarios, comboFiltro.Text, txtBusqueda.Text)
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub comboMaterias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCarreras.SelectedIndexChanged
        ContorladorVentanaPrincipal.cargarTablaMateriasFiltro(DataGridMaterias, comboCarreras.Text)
    End Sub
End Class


'===========================================================================
'   Controlador de la ventana principal.
'===========================================================================
Public Class ContorladorVentanaPrincipal

    Public Shared Sub cargarTablaUsuarios(tabla As DataGridView)

            ModeloUsuarios.tablaUsuario = tabla


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_usuario,nombre,apellido,cuenta,tipo,estado from usuarios"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comaondo sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de los usuarios a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_usuario"),
                resultado.GetString("nombre"),
                resultado.GetString("apellido"),
                resultado.GetString("cuenta"),
                resultado.GetString("tipo"),
                resultado.GetString("estado")
            )
        End While
    End Sub
    Public Shared Sub cargarTablaUsuariosFiltro(tabla As DataGridView, tipo_filtro$, busqueda$)

        ModeloUsuarios.tablaUsuario = tabla


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_usuario,nombre,apellido,cuenta,tipo,estado from usuarios where " + tipo_filtro + " like lower('%" + busqueda + "%')"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()

        'Esta sentencia se monto y no quiere funcionar...
        'comando.Parameters.AddWithValue("@tipo_filtro", tipo_filtro)
        'comando.Parameters.AddWithValue("@busqueda", busqueda)
        ' ----------------------------------------------------

        'MessageBox.Show(comando.CommandText)'debug
        '----------------------------------------------------
        '   Almacen de resultados del comaondo sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de los usuarios a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_usuario"),
                resultado.GetString("nombre"),
                resultado.GetString("apellido"),
                resultado.GetString("cuenta"),
                resultado.GetString("tipo"),
                resultado.GetString("estado")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub


    
    Public Shared Sub cargarTablaCarreras(tabla As DataGridView)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_carrera,nombre,estado,registro from carreras"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_carrera"),
                resultado.GetString("nombre"),
                resultado.GetString("estado"),
                resultado.GetString("registro")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub

    Public Shared Sub asignarImagenPictureBox(pictureBox As PictureBox, propietario$, tipo$)

        pictureBox.ImageLocation = ModeloImagenes.cargarImagen(propietario, tipo)

    End Sub

    Public Shared Sub deshabilitarUsuario(usuario$)
        '----------------------------------------------------
        '   Esta funcion es para deshabilitar usuarios
        '----------------------------------------------------
        '   Usa el modelo de los usuarios para llevar a cabo su
        '   proposito
        '----------------------------------------------------
        ModeloUsuarios.cambiarEstado(usuario, ModeloUsuarios.DESHABILITADO)
        '----------------------------------------------------
    End Sub

    Public Shared Sub habilitarUsuario(usuario$)
        '----------------------------------------------------
        '   Esta funcion es para habilitar usuarios
        '----------------------------------------------------
        '   Usa el modelo de los usuarios para llevar a cabo su
        '   proposito
        '----------------------------------------------------
        ModeloUsuarios.cambiarEstado(usuario, ModeloUsuarios.ACTIVO)
        '----------------------------------------------------
    End Sub

    Public Shared Sub llenarModificarUsuario(usuario As String)


        Dim registro As New RegistrarEstudiante()
        RegistrarEstudiante.Modo = "modificar"
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_usuario,nombre,apellido,sexo,cuenta,clave,estado,tipo from usuarios where id_usuario='" + usuario + "'"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        ' ----------------------------------------------------
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------

        While resultado.Read
            registro.cedulaUsuarioTxt.Text = resultado.GetString("id_usuario")
            registro.nombreUsuarioTxt.Text = resultado.GetString("nombre")
            registro.apellidoUsuarioTxt.Text = resultado.GetString("apellido")
            registro.sexsoUsuarioCbb.Text = resultado.GetString("sexo")
            registro.cuentaUsuarioTxt.Text = resultado.GetString("cuenta")
            registro.claveUsuarioTxt.Text = resultado.GetString("clave")

            registro.picturePerfil.ImageLocation = ModeloImagenes.cargarImagen(
                resultado.GetString("id_usuario"),
                resultado.GetString("tipo")
            )
        End While

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------
        registro.Show()
        '====================================================
    End Sub

    Public Shared Sub cargarInformacionUsuario(ventana As VentanaPrincipal, id_usuario As String)


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_usuario,nombre,apellido,cuenta,tipo,estado,sexo,registro from usuarios where id_usuario='" + id_usuario + "'"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        ' ----------------------------------------------------
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------

        While resultado.Read
            ventana.informacionTextID.Text = resultado.GetString("id_usuario")
            ventana.informacionTextNombre.Text = resultado.GetString("nombre")
            ventana.informacionTextApellido.Text = resultado.GetString("apellido")
            ventana.informacionTextCuenta.Text = resultado.GetString("cuenta")
            ventana.informacionTextTipo.Text = resultado.GetString("tipo")
            ventana.informacionTextEstado.Text = resultado.GetString("estado")
            ventana.informacionTextSexo.Text = resultado.GetString("sexo")
            'ventana.informacionTextRegistro.Text = resultado.GetString("registro")
        End While

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()

    End Sub

    Public Shared Sub agregarCarrera(nombre$, estado$)
        ModeloCarreras.insertarCarrera(nombre$, estado$)
    End Sub

    Public Shared Sub deshabilitarCarrera(id_carrera$)
        ModeloCarreras.cambiarEstado(id_carrera, ModeloCarreras.CLAUSURADA)
    End Sub

    Public Shared Sub habilitarCarrera(id_carrera$)

        ModeloCarreras.cambiarEstado(id_carrera, ModeloCarreras.DISPONIBLE)

    End Sub

    Public Shared Sub registrarEntidad(ventana As VentanaPrincipal)

        '------------------------------------------------
        '   Aqui se inserta la entidad.
        '------------------------------------------------
        ModeloEntidad.insertarEntidad(
            ventana.idEmpresaTxt.Text,
            ventana.nombreEmpresaTxt.Text,
            ventana.representanteEmpresaTxt.Text,
            ventana.direccionEmpresaTxt.Text,
            ventana.telefonoEmpresaTxt.Text,
            ventana.registroEmpresaDatePicker.Value.ToString("yyyy-MM-dd"),
            ventana.OpenFileDialog1.FileName
        )
        '------------------------------------------------
    End Sub

    Public Shared Sub modificarEntidad(ventana As VentanaPrincipal)

        '------------------------------------------------
        '   Aqui se inserta la entidad.
        '------------------------------------------------
        ModeloEntidad.modificarEntidad(
            ModeloEntidad.octenerID,
            ventana.idEmpresaTxt.Text,
            ventana.nombreEmpresaTxt.Text,
            ventana.representanteEmpresaTxt.Text,
            ventana.direccionEmpresaTxt.Text,
            ventana.telefonoEmpresaTxt.Text,
            ventana.registroEmpresaDatePicker.Value.ToString("yyyy-MM-dd"),
            ventana.OpenFileDialog1.FileName
        )
        '------------------------------------------------
    End Sub

    Public Shared Sub cargarDatosEntidad(ventana As VentanaPrincipal)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "select id_entidad,nombre,representante,direccion,telefono,registro from entidad"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '------------------------------------
        While resultado.Read()
            ventana.idEmpresaTxt.Text = resultado.GetString("id_entidad")
            ventana.nombreEmpresaTxt.Text = resultado.GetString("nombre")
            ventana.representanteEmpresaTxt.Text = resultado.GetString("representante")
            ventana.direccionEmpresaTxt.Text = resultado.GetString("direccion")
            ventana.telefonoEmpresaTxt.Text = resultado.GetString("telefono")
            ventana.pictureBoxEntidad.ImageLocation =
                ModeloImagenes.cargarImagen(resultado.GetString("id_entidad"), "entidad")
        End While

        '------------------------------------
        '   Ejecucion del comando.
        '------------------------------------
        Conexion.CerrarConexion()
    End Sub

    Public Shared Sub cargarTablaMaterias(tabla As DataGridView)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_materia,nombre,estado,requisito,carrera from materias"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_materia"),
                resultado.GetString("nombre"),
                resultado.GetString("estado"),
                resultado.GetString("requisito"),
                resultado.GetString("carrera")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub
    Public Shared Sub cargarTablaMateriasFiltro(tabla As DataGridView, nombre_carrera As String)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select  " &
        "materias.id_materia," &
        "materias.nombre," &
        "materias.estado," &
        "materias.requisito, " &
        "materias.carrera from " &
        "materias join carreras on carreras.id_carrera=materias.carrera " &
        "where carreras.nombre=@nombre"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------
        comando.Parameters.AddWithValue("@nombre", nombre_carrera)



        MessageBox.Show(comando.CommandText)
        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_materia"),
                resultado.GetString("nombre"),
                resultado.GetString("estado"),
                resultado.GetString("requisito"),
                resultado.GetString("carrera")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub

    Public Shared Sub agregarMateriaEstudiante()

    End Sub

    Public Shared Sub cargarTablaMateriaEstudiantes(tabla As DataGridView, id_estudiante As string)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_materia,nombre,estado,carrera from materias"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_materia"),
                resultado.GetString("nombre"),
                resultado.GetString("estado"),
                resultado.GetString("carrera")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub

    Public Shared Sub cargarTablaEstadoMateriasEstudiantes(tabla As DataGridView, id_estudiante As String, estado$)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_materia,nombre_materia,estado from materias_estudiantes where " &
        "id_estudiante=@id_estudiante and estado=@estado "
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())

        comando.Prepare()
        ' ----------------------------------------------------
        comando.Parameters.AddWithValue("@id_estudiante", id_estudiante)
        comando.Parameters.AddWithValue("@estado", estado)
        ' ----------------------------------------------------

        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_materia"),
                resultado.GetString("nombre_materia"),
                resultado.GetString("estado")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub

    Public Shared Sub cargarNombresCombo(combo As ComboBox)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select nombre from carreras"
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------
        combo.Items.Clear()
        '----------------------------------------------------

        While resultado.Read
            combo.Items.Add(resultado.GetString("nombre"))
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
    End Sub
End Class
'===========================================================================
