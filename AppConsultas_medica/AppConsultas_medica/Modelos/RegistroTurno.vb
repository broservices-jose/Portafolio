Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroTurno

    Private did_turno As Integer

    Public Property id_turno As Integer
        Get
            Return did_turno
        End Get
        Set(value As Integer)
            did_turno = value
        End Set
    End Property

    Private dturno As String

    Public Property turno As String
        Get
            Return dturno
        End Get
        Set(value As String)
            dturno = value
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

    Private dfecha As DateTime

    Public Property fecha As DateTime
        Get
            Return dfecha
        End Get
        Set(value As DateTime)
            dfecha = value
        End Set
    End Property

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable




    Public Shared Function registra(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSERT INTO turno (turno, fecha, hora, id_cita, id_especialidad, id_medico, id_sala_medica) VALUES ('" + dato(0) + "','" + dato(1) + "','" + dato(2) + "','" + dato(3) + dato(4) + "','" + dato(5) + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return False
            End If
        Catch m As MySqlException
            MessageBox.Show(m.Message + m.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.StackTrace)
        End Try
        Return True
    End Function

    Public Shared Function consultar() As DataTable
        Try
            nombrecolumna()
            Dim query As String = "SELECT t.id_turno, t.turno, t.hora, t.id_cita, m.nombre, e.especialidad, s.sala from turno t inner join cita c on t.id_cita = c.id_cita inner join medico m on m.id_medico = t.id_medico  inner join especialidad e on e.id_especialidad = t.id_especialidad inner join sala_medica s on s.id_sala = t.id_sala_medica where t.id_cita = c.id_cita"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_turno"), leer("turno"), leer("hora"), leer("id_cita"), leer("nombre"), leer("especialidad"), leer("sala")})
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
        tabla.Columns.Add("id_turno")
        tabla.Columns.Add("Turno")
        tabla.Columns.Add("Cita")
        tabla.Columns.Add("Hora")
        tabla.Columns.Add("Medico")
        tabla.Columns.Add("Especialidad")
        tabla.Columns.Add("Sala Medica")

    End Sub

End Class
