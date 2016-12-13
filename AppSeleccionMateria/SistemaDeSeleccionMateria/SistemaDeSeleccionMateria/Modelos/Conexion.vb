Imports MySql.Data.Entity
Imports MySql.Data.MySqlClient
Public Class Conexion

    Private Sub Conexion()

    End Sub

    Private Shared conector As MySqlConnection

    Public Shared Function Conectar() As MySqlConnection

        Dim servidor As String = "127.0.0.1"
        Dim basedatos As String = "sistema_estudiantes"
        Dim usuario As String = "root"
        Dim contrasenia As String = ""

        Try
            conector = New MySqlConnection("Server=" + servidor + ";Database=" + basedatos + ";User=" + usuario + ";Pwd=" + contrasenia)
            conector.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar" + ex.StackTrace)
        End Try

        Return conector
    End Function

    Public Shared Sub CerrarConexion()
        conector.Close()
    End Sub


End Class
