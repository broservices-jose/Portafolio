Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroConsulta

    Private dnum_consulta As Integer

    Public Property num_consulta As Integer
        Get
            Return dnum_consulta
        End Get
        Set(value As Integer)
            dnum_consulta = value
        End Set
    End Property

    Private dtipo As String

    Public Property tipo As String
        Get
            Return dtipo
        End Get
        Set(value As String)
            dtipo = value
        End Set
    End Property
    Private dmotivo As String

    Public Property motivo As String
        Get
            Return dmotivo
        End Get
        Set(value As String)
            dmotivo = value
        End Set
    End Property
    Private denfermedad As String

    Public Property enfermedad As String
        Get
            Return denfermedad
        End Get
        Set(value As String)
            denfermedad = value
        End Set
    End Property
    Private dexamen As String

    Public Property examen As String
        Get
            Return dexamen
        End Get
        Set(value As String)
            dexamen = value
        End Set
    End Property
    Private dfecha As DateTime

    Public Property fecha As String
        Get
            Return dfecha
        End Get
        Set(value As String)
            dfecha = value
        End Set
    End Property

    Private ddiagnostico As String

    Public Property diagnostico As String
        Get
            Return ddiagnostico
        End Get
        Set(value As String)
            ddiagnostico = value
        End Set
    End Property

    Private dreceta As String

    Public Property receta As String
        Get
            Return dreceta
        End Get
        Set(value As String)
            dreceta = value
        End Set
    End Property

    Private dobservacio As String

    Public Property observacion As String
        Get
            Return dobservacio
        End Get
        Set(value As String)
            dobservacio = value
        End Set
    End Property

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable

    Public Shared Function registrar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSET INTO consultas (tipo_consulta, Motivo, Enfermedad, Examen, Fecha, Diagnostico, Receta, observacion, id_turno) VALUES ('" + dato(0) + "','" + dato(1) + "','" + dato(2) + "','" + dato(3) + "','" + dato(4) + "','" + dato(5) + "','" + dato(6) + "','" + dato(7) + "','" + dato(8) + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return False
            End If
        Catch m As MySqlException
            MessageBox.Show(m.Message)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function consultar() As DataTable
        Try
            Dim query As String = "SELECT c.num_consulta, c.tipo_consulta, c.Motivo, c.Enfermedad, c.Examen, c.Fecha, c.Diagnostico, c.Receta, c.observacion, t.turno  FROM consultas c, turno t WHERE t.id_turno = c.id_turno"
            cn = Conexion.conectar
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("num_consulta"), leer("tipo_consulta"), leer("Motivo"), leer("Enfermedad"), leer("Examen"), leer("Fecha"), leer("Diagnostico"), leer("Receta"), leer("observacion"), leer("turno")})
            End While
            Return tabla
        Catch m As MySqlException
            MessageBox.Show(m.Message)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return tabla
    End Function

End Class
