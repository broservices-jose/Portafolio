'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class Configurando

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        Me.Hide()
        splashTimer.Stop()

        Dim ventana As New VentanaPrincipal()

        Try
            ventana.botonCarreras.Hide()
            ventana.botonGestionEmpresa.Hide()
            ventana.botonGestionMaterias.Hide()
            ventana.botonUsuarios.Hide()
            ventana.botonOpciones.Hide()

            ventana.tabControlPrincipal.SelectedIndex = 5

            '---------------------------------------------
            VentanaPrincipal.VentanaPrincipalConpartida.pictureBoxEstudiante.ImageLocation =
            ModeloImagenes.cargarImagen(VentanaPrincipal.usuarioActual, ModeloUsuarios.ESTUDIANTE)
            '---------------------------------------------
            ventana.Show()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace + ex.Message)
        End Try
        
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        splashTimer.Start()
    End Sub
End Class