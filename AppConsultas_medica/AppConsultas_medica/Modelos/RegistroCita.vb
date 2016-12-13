Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroCita
    '=============================================================
    'Este linea de codigo representa todas las variables delcarada
    'Para su utilizacion

    Private did_cita As Integer

    Public Property id_cita As Integer
        Get
            Return did_cita
        End Get
        Set(value As Integer)
            did_cita = value
        End Set
    End Property

    Private dfecha As DateTime

    Public Property fecha As DateTime
        Get
            Return dfecha
        End Get
        Set(value As DateTime)
            dfecha = value
        End Set
    End Property

    Private dhora As DateTime

    Public Property hora As DateTime
        Get
            Return dhora
        End Get
        Set(value As DateTime)
            dhora = value
        End Set
    End Property

    Private did_paciente As Integer

    Public Property id_paciente As Integer
        Get
            Return did_paciente
        End Get
        Set(value As Integer)
            did_paciente = value
        End Set
    End Property

    '============================================================
    'Esta linea de codigo representa las instanciaciones de
    'los objetos que nos permiten interactuan con la base de Datos

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    '=========================================================================================================*
    'Esta funcion realiza todas las insercciones de la informacion de las citas creadas en la base de datos 
    'en la tabla cita


    Public Shared Function registrar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSERT INTO cita (Fecha, hora, id_paciente) VALUES ('" + dato(0) + "','" + dato(1) + "','" + dato(2) + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return True
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + ex.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch t As Exception
            MessageBox.Show(t.Message + t.StackTrace)

        End Try
        Return False
    End Function

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

    Public Shared Function actualizar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "UPDATE  cita as c INNER JOIN paciente as p ON c.id_paciente = p.id_paciente SET c.fecha = '" + dato(1) + "', c.hora = '" + dato(2) + "', p.id_paciente ='" + dato(3) + " where c.id_cita ='" + dato(0) + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
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

    Public Shared Function eliminar(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE cita FROM cita  INNER JOIN paciente on cita.id_paciente = paciente.id_paciente WHERE id_cita = 002" + id + "'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
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
