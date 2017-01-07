


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+



Public Class SeleccionarCarrera

    Public cuenta As String


    Private Sub SeleccionarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '--------------------------------------------
        '   La cuenta se le pasa cuando se abre la ventana desde el login.
        '--------------------------------------------
        Dim carrera
        Try
            carrera = dataGridCarreras.CurrentRow.Cells(0).Value
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace + ex.Message)
        End Try

            '--------------------------------------------


            ModeloEstudiantes.establecerCarreraa(
                ModeloUsuarios.octenerIdPorCuenta(cuenta),
                carrera
            )
            VentanaPrincipal.usuarioActual = ModeloUsuarios.octenerIdPorCuenta(cuenta)

            Me.Hide()
            Configurando.Show()
    End Sub
End Class