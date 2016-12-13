Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Especialidad

    '=================================================
    'Esta linea de codigo representa todas las declaracion
    'de las variables del formulario medico
    Private did_especialidad As Integer

    Public Property id_especialidad As Integer
        Get
            Return did_especialidad
        End Get
        Set(value As Integer)
            did_especialidad = value
        End Set
    End Property

    Private despecialidad As String

    Public Property especialidad As String
        Get
            Return despecialidad
        End Get
        Set(value As String)
            despecialidad = value
        End Set
    End Property



    '============================================================
    'Estas lineas de codigo representa las instanciancion de los
    'objetos de las clases de mysql para interactuar con la base
    'de datos como tipo statico

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    '===================================================================================================================
    'Esta funcion realiza las insercciones a la base de datos en la tabla medico desde el formulario de registro medico 

    Public Shared Function insertar(ByVal info As String) As Boolean
        Try
            Dim query As String = "INSERT INTO especialidad (especialidad) VALUES (@param1)"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@param1", info)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return True
            End If
        Catch m As MySqlException
            MessageBox.Show(m.Message + m.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.StackTrace)
        End Try
        Return False
    End Function

End Class
