

'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+


Public Class RegistrarEstudiante

    Private Shared pModo As String
    Public Shared Property Modo As String
        Set(value As String)
            RegistrarEstudiante.pModo = value
        End Set
        Get
            Return RegistrarEstudiante.pModo
        End Get
    End Property





    Private Sub RegistrarEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picturePerfil.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If claveUsuarioTxt.Text = confirmacionClaveTxt.Text Then
            Me.insertarEstudiante()
            Me.Dispose()
        Else
            MessageBox.Show("Las claves no coinciden")
        End If


    End Sub

    Public Sub componenteParaActualizar()
        '----------------------------------------------------
        '   Este metodo es para cuando se recargar el datagridview
        '   de la ventana principal.
        '   La variable estatica ModeloUsuarios.tablaUsuarios se asigna en el controlador
        '   de la ventana principal.
        '----------------------------------------------------
        ContorladorVentanaPrincipal.cargarTablaUsuarios(ModeloUsuarios.tablaUsuario)
        '----------------------------------------------------
    End Sub

    Private Sub modificarUsuario()

    End Sub
    Private Sub insertarEstudiante()
        '----------------------------------------------------
        '   Se utiliza el modelo de las imagenes y el modelo
        '   de los usuario para registrar un nuevo usuario.
        '   Esto se hace de esta forma porque hay que afectar
        '   dos tablas.
        '----------------------------------------------------
        If Modo = ModeloUsuarios.ESTUDIANTE Then
            ModeloUsuarios.insertarUsuario(
                cedulaUsuarioTxt.Text,
                nombreUsuarioTxt.Text,
                apellidoUsuarioTxt.Text,
                sexsoUsuarioCbb.Text,
                cuentaUsuarioTxt.Text,
                claveUsuarioTxt.Text,
                ModeloUsuarios.ACTIVO,
                ModeloUsuarios.ESTUDIANTE,
                DateTime.Now.ToString("yyyy-MM-dd")
            )
            ModeloEstudiantes.insertarUsuario(cedulaUsuarioTxt.Text, "000") ' La carrera es ninguna :)
            ModeloImagenes.agregarImagen(cedulaUsuarioTxt.Text, ModeloUsuarios.ESTUDIANTE, OpenFileDialog1.FileName)
            '----------------------------------------------------
            '   No se actualiza la tablaUsuarios cuando se agrega un estudiante
            '----------------------------------------------------
        ElseIf Modo = ModeloUsuarios.ADMINISTRADOR Then
            ModeloUsuarios.insertarUsuario(
                cedulaUsuarioTxt.Text,
                nombreUsuarioTxt.Text,
                apellidoUsuarioTxt.Text,
                sexsoUsuarioCbb.Text,
                cuentaUsuarioTxt.Text,
                claveUsuarioTxt.Text,
                ModeloUsuarios.ACTIVO,
                ModeloUsuarios.ADMINISTRADOR,
                DateTime.Now.ToString("yyyy-MM-dd")
            )

            ModeloImagenes.agregarImagen(cedulaUsuarioTxt.Text, ModeloUsuarios.ADMINISTRADOR, OpenFileDialog1.FileName)
            '----------------------------------------------------
            ' se manda a actualizar la tabla de los usuarios.
            Me.componenteParaActualizar()
            '----------------------------------------------------
        ElseIf Modo = "modificar" Then
            ModeloUsuarios.modificarUsuario(
                cedulaUsuarioTxt.Text,
                nombreUsuarioTxt.Text,
                apellidoUsuarioTxt.Text,
                sexsoUsuarioCbb.Text,
                cuentaUsuarioTxt.Text,
                claveUsuarioTxt.Text,
                ModeloUsuarios.ACTIVO,
                ModeloUsuarios.ADMINISTRADOR,
                DateTime.Now.ToString("yyyy-MM-dd"),
                picturePerfil.ImageLocation
            )

            ' ModeloImagenes.agregarImagen(cedulaUsuarioTxt.Text, ModeloUsuarios.ADMINISTRADOR, OpenFileDialog1.FileName)
            '----------------------------------------------------
            ' se manda a actualizar la tabla de los usuarios.
            Me.componenteParaActualizar()
            '----------------------------------------------------
        End If
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles claveUsuarioTxt.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sexsoUsuarioCbb.SelectedIndexChanged

    End Sub
End Class