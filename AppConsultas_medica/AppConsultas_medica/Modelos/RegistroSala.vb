Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroSala

    Private did_sala As Integer

    Public Property id_sala As Integer
        Get
            Return did_sala
        End Get
        Set(value As Integer)
            did_sala = value
        End Set
    End Property

    Private dsala As String

    Public Property sala As String
        Get
            Return dsala
        End Get
        Set(value As String)
            dsala = value
        End Set
    End Property

    Private dubicacion As String

    Public Property ubicacion As String
        Get
            Return dubicacion
        End Get
        Set(value As String)
            dubicacion = value
        End Set
    End Property

    Private ddescripcion As String

    Public Property descripcion As String
        Get
            Return ddescripcion
        End Get
        Set(value As String)
            ddescripcion = value
        End Set
    End Property

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    Public Shared Function consultar() As DataTable
        Try
            nombrecolumna()
            Dim query As String = "SELECT c.id_cita, c.fecha, c.hora, p.nombre, p.representante FROM cita c, paciente p WHERE  p.id_paciente = c.id_paciente"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_cita"), leer("fecha"), leer("hora"), leer("nombre"), leer("representante")})
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + ex.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch t As Exception
            MessageBox.Show(t.Message + t.StackTrace)

        End Try
        Return tabla
    End Function

    Public Shared Sub nombrecolumna()
        tabla = New DataTable()
        tabla.Columns.Add("Numero")
        tabla.Columns.Add("Fecha")
        tabla.Columns.Add("Hora")
        tabla.Columns.Add("Paciente")
        tabla.Columns.Add("Representante")

    End Sub
End Class
