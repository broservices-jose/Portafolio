Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Imagen

    Public id_imagen As Integer

    Public imagen As String


    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    Public Shared Function registrar(ByVal ruta As String) As Boolean
        Try
            Dim squery As String = "INSERT INTO imagen (imagen) VALUES (@param1)"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(squery, cn)
            cmd.Parameters.AddWithValue("@param1", ruta)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return True
            End If
        Catch m As MySqlException
            MessageBox.Show(m.Message + "0" + m.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + "1" + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message + "2" + ex.StackTrace)
        End Try
        Return False
    End Function

End Class
