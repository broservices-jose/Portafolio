
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        '------------------------------------------------
        '   SE CIERRA EL FORMULARIO ACTUAL
        '------------------------------------------------
        Me.Dispose()
        Application.Exit()
        '------------------------------------------------
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '------------------------------------------------
        '   Los eventos son detonados desde los controladores
        '   De esta manera se tiene un mayor control del flujo
        '   de los datos del programa.
        '------------------------------------------------
        '   Esta funcion se asocia al controlador de los 
        '   usuarios para confirmar que el usuario existe
        '------------------------------------------------
        ControladorLogin.confirmarUsuario()
        '------------------------------------------------
    End Sub

    Private Sub labelCancelarClick(sender As Object, e As EventArgs) Handles LinkLabel2.Click
        '------------------------------------------------
        '   SE CIERRA EL FORMULARIO ACTUAL
        '------------------------------------------------
        Me.Dispose()
        Application.Exit()
        '------------------------------------------------
    End Sub

    '----------------------------------------------------
    '   Esta clase maneja las funciones de su clase contenedora.
    '----------------------------------------------------
    Class ControladorLogin
        Public Shared Sub confirmarUsuario()

            '----------------------------------------------------
            '   Se confirmar si el usuario existe.
            '----------------------------------------------------
            Dim cuenta = Login.textCuenta.Text
            Dim clave = Login.textClave.Text
            Dim tipo$ = ""
            '----------------------------------------------------
            Dim encontrado As Boolean = ModeloUsuarios.confirmarUsuario(cuenta, clave)
            MessageBox.Show(encontrado)
            If encontrado = True Then

                VentanaPrincipal.usuarioActual = ModeloUsuarios.octenerIdPorCuenta(cuenta)

                If ModeloUsuarios.consultarTipoUsuario(cuenta) = ModeloUsuarios.ADMINISTRADOR Then
                    Login.Hide()
                    Dim ventana As New VentanaPrincipal()
                    ventana.botonEstudiantes.Hide()
                    ventana.Show()
                ElseIf ModeloUsuarios.consultarTipoUsuario(cuenta) = ModeloUsuarios.ESTUDIANTE Then
                    Login.Hide()


                    If ModeloUsuarios.octenerCarrera(cuenta) = 0 Then
                        '----------------------------------------------------
                        '   Se selecciona la cuenta para se accedida desde 
                        Dim seleccionCarrera As New SeleccionarCarrera()
                        '----------------------------------------------------
                        '   Se establece la cuenta actual en formulario de la carrera.
                        seleccionCarrera.cuenta = cuenta
                        '----------------------------------------------------
                        seleccionCarrera.Show()
                    Else
                        Dim ventana As New VentanaPrincipal()

                        ventana.botonCarreras.Hide()
                        ventana.botonGestionEmpresa.Hide()
                        ventana.botonGestionMaterias.Hide()
                        ventana.botonUsuarios.Hide()
                        ventana.botonOpciones.Hide()


                        ventana.tabControlPrincipal.SelectedIndex = 5



                        ventana.Show()
                    End If


                End If
            End If
            '----------------------------------------------------
        End Sub
    End Class

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '----------------------------------------------------
        '   Se establece que el modo de insercion sera un estudiante.
        '   Sino se establece el programa no sigue un patron consiso.
        '----------------------------------------------------
        RegistrarEstudiante.Modo = ModeloUsuarios.ESTUDIANTE
        '----------------------------------------------------
        RegistrarEstudiante.Show()

    End Sub

    Private Sub textClave_Validated(sender As Object, e As EventArgs)
        MessageBox.Show("hola")
    End Sub

    Private Sub textCuenta_TextChanged(sender As Object, e As EventArgs) Handles textCuenta.TextChanged

    End Sub
End Class