Imports MySql.Data.Entity
Imports MySql.Data.MySqlClient


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+


Public Class Registro
    Dim conexion As New Conexion
    Public administrador As String = "usuario" 'Este codigo es para especificar al usuario si se agregara un administrador.

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles textClave.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agregarUsuario()
    End Sub

    Private Sub agregarUsuario()

        Dim fecha As String = Date.Today.Year.ToString() + "/" + Date.Today.Month.ToString() + "/" + Date.Today.Day.ToString()
        Dim ruta As String = PictureBox1.ImageLocation


        Dim sql As String =
        "insert into usuarios (nombre,apellido,sexo,cuenta,clave,tipo,activo,fecha_ingreso,imagen) " +
        "values( '" +
        textNombre.Text + "','" +
        textApellido.Text + "','" +
        textClave.Text + "', '" +
        textCuenta.Text + "','" +
        textClave.Text + "','" +
        administrador + "',true,'" +
        fecha + "','" +
        ruta + "'  )"

        Dim comando As New MySqlCommand(sql, conexion.Conectar())

        comando.ExecuteNonQuery()


        MessageBox.Show("Registrado Correctamente. Ahora puedes ingresar.")

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "C:UsersEsmarlin RosarioPictures90503.jpg"
    End Sub
End Class