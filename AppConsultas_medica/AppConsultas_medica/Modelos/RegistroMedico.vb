Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroMedico

    Private dbid_medico As Integer


    Public Property id_medico() As Integer
        Get
            Return dbid_medico
        End Get
        Set(value As Integer)
            dbid_medico = value
        End Set
    End Property

    Private dcorreo As String

    Public Property correo As String
        Get
            Return dcorreo
        End Get
        Set(value As String)
            dcorreo = value
        End Set
    End Property

    Private dbnombre As String

    Public Property nombre() As String
        Get
            Return dbnombre
        End Get
        Set(value As String)
            dbnombre = value
        End Set
    End Property


    Private dbapellido As String

    Public Property apellido() As String
        Get
            Return dbapellido
        End Get
        Set(value As String)
            dbapellido = value
        End Set
    End Property

    Private dbedad As String

    Public Property edad() As String
        Get
            Return dbedad

        End Get
        Set(value As String)
            dbedad = value
        End Set
    End Property

    Private dbcedula As String

    Public Property cedula As String
        Get
            Return dbcedula
        End Get
        Set(value As String)
            dbcedula = value
        End Set
    End Property

    Private dfecha_nacimiento As DateTime

    Public Property fecha_nacimiento() As DateTime
        Get
            Return dfecha_nacimiento
        End Get
        Set(value As DateTime)
            dfecha_nacimiento = value
        End Set
    End Property

    Private dbhora_entrada As DateTime
    Public Property hora_entraa() As DateTime
        Get
            Return dbhora_entrada
        End Get
        Set(value As DateTime)
            dbhora_entrada = value
        End Set
    End Property

    Private dbhora_salida As DateTime
    Public Property hora_salida() As DateTime
        Get
            Return dbhora_entrada
        End Get
        Set(value As DateTime)
            dbhora_salida = value
        End Set
    End Property

    Private dbsexo As String

    Public Property sexo As String
        Get
            Return dbsexo
        End Get
        Set(value As String)
            dbsexo = value
        End Set
    End Property

    Private dbdireccion As String
    Public Property direccion As String
        Get
            Return dbdireccion
        End Get
        Set(value As String)
            dbdireccion = value
        End Set
    End Property

    Private dbtelefono As String

    Public Property telefono As String
        Get
            Return dbtelefono
        End Get
        Set(value As String)
            dbtelefono = value
        End Set
    End Property

    Private dbid_especialidad As Integer

    Public Property id_especialidad As Integer
        Get
            Return dbid_especialidad
        End Get
        Set(value As Integer)
            dbid_especialidad = value
        End Set
    End Property

    Private dbid_imagen As Integer
    Public Property id_imagen As Integer
        Get
            Return dbid_imagen
        End Get
        Set(value As Integer)
            dbid_imagen = value
        End Set
    End Property


    '===================================================================*
    'Este codigo representa las instancioaciones de los objetos que van
    'a permitir trabajar con la base de datos


    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    '=========================================================================================================*
    'Esta funcion realiza todas las insercciones de la informacion de los medicos en la base de datos 
    'en la tabla medico

    Public Shared Function registrar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSERT INTO medico (nombre, apellido, cedula, edad, " +
                                  " correo, fecha_nacimiento, hora_entrada, hora_salida , sexo,  direccion, " +
                                  "telefono) VALUES ('" + dato(0) + "','" +
                                  dato(1) + "','" + dato(2) + "','" + dato(3) + "','" + dato(4) + "','" + dato(5) +
                                  "','" + dato(6) + "','" + dato(7) + "','" + dato(8) + "','" + dato(9) + "','" + dato(10) + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return True
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + "0" + ex.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + "1" + n.StackTrace)
        Catch t As Exception
            MessageBox.Show(t.Message + "2" + t.StackTrace)

        End Try
        Return False
    End Function

    '=============================================================================================*
    'Este codigo realiza la funcion de consultar y mostrar todos los datos almacenados en la base
    'de datos consulta_medicas que existen en la tabla medico

    Public Shared Function consultar() As DataTable
        Try
            nombrecolumna()
            Dim query As String = "SELECT m.id_medico, m.nombre, m.apellido, m.cedula, m.edad, m.correo, m.hora_entrada, m.hora_salida, m.sexo, m.direccion, m.telefono, e.especialidad, i.imagen from medico m, especialidad e, imagen i where m.id_imagen = i.id_imagen and m.id_especialidad = e.id_especialidad"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_medico"), leer("nombre"), leer("apellido"),
                                                             leer("cedula"), leer("edad"), leer("correo"), leer("hora_entrada"), leer("hora_salida"),
                                                             leer("sexo"), leer("direccion"), leer("telefono"),
                                                             leer("especialidad"), leer("imagen")})
            End While
            Return tabla
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + "0")
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + "1" + n.StackTrace)
        Catch t As Exception
            MessageBox.Show(t.Message + "2")

        End Try
        Return tabla
    End Function

    '=======================================================================================================================
    'Esta funcion realiza la consulta del ultimo id generado y le suma uno para inidicar el proximo id del nuevo registro



    '======================================================*
    'Este codigo realiza la funcion de editar los nombres de
    'las columnas del datagridview del formulario de medico

    Private Shared Sub nombrecolumna()
        tabla = New DataTable()
        tabla.Columns.Add("id_medico")
        tabla.Columns.Add("Nombre")
        tabla.Columns.Add("Apellido")
        tabla.Columns.Add("Cedula")
        tabla.Columns.Add("Edad")
        tabla.Columns.Add("Correo")
        tabla.Columns.Add("Hora Entrada")
        tabla.Columns.Add("Hora Salida")
        tabla.Columns.Add("Sexo")
        tabla.Columns.Add("Direccion")
        tabla.Columns.Add("Telefono")
        tabla.Columns.Add("Especialidad")
        tabla.Columns.Add("Ruta Imagen")
    End Sub


    '*============================================================================================*
    'Este codigo realiza la funcion de filtrar las informacion socilitada por el nombre del registro
    'que existen en la tabla medico
    Public Shared Function filtrar(ByVal filtro As String) As DataTable
        Try
            Dim miomio As String = "SELECT m.id_medico, m.nombre, m.apellido, m.cedula, m.edad, m.correo, m.hora_entrada, m.hora_salida, m.sexo, m.direccion, m.telefono, e.especialidad, i.imagen from medico m, especialidad e, imagen i where m.id_imagen = i.id_imagen and m.id_especialidad = e.id_especialidad WHERE m.id_medico OR m.nombre OR m.apellido OR m.cedula OR m.hora_entrada OR hora_salida OR m.sexo OR m.direccion OR m.telefono OR e.especialidad OR i.imagen LIKE '" + filtro + "')"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(miomio, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_medico"), leer("nombre"), leer("apellido"),
                                             leer("cedula"), leer("edad"), leer("correo"), leer("hora_entrada"), leer("hora_salida"),
                                             leer("sexo"), leer("direccion"), leer("telefono"),
                                             leer("especialidad"), leer("imagen")})
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

    '*============================================================================================*
    'Este codigo realiza la funcion de filtrar las informacion socilitada por el nombre del registro

    Public Shared Function eliminar(ByVal id As Integer) As Boolean
        Try
            Dim elimina As String = "DELETE  m, i, e from medico AS m inner join imagen AS i ON i.id_imagen = m.id_imagen inner join especialidad as e on e.id_especialidad = m.id_especialidad where m.id_medico = " + id + "'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(elimina, cn)
            If cmd.ExecuteNonQuery() > 0 Then
                cn.Close()
                Return True
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

    '=======================================================================================*
    'Esta funcion realiza las actualizaciones en la base de datos de la tabla usuario desde
    'el formulario de registro de usuario

    Public Shared Function actualizar(dato As Object()) As Boolean
        Try
            Dim miquery As String = "UPDATE medico AS m INNER JOIN imagen AS i ON m.id_imagen = i.id_imagen INNER JOIN especialidad AS e ON m.id_especialidad = e.id_especialidad SET m.nombre = '" + dato(1) + "', m.apellido = '" + dato(2) + ", m.cedula = '" + dato(3) + ",m.edad=' " + dato(4) + ", m.correo  = '" + dato(5) + ", m.hora_entrada = '" + dato(6) + ", m.hora_salida = '" + dato(7) + ", m.sexo = '" + dato(8) + ", m.direccion = '" + dato(9) + ", m.telefono = '" + dato(10) + "', e.especialidad = '" + dato(11) + "', i.imagen = '" + " where m.id_medico ='" + dato(0)
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(miquery, cn)
            If cmd.ExecuteNonQuery() > -0 Then
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

End Class
