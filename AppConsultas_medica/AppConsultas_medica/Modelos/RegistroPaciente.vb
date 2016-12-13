Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroPaciente

    'Aqui se encuentran las variables que estan encapsulado


    '*======================================================*
    '
    Private bid_paciente As Integer

    Public Property id_paciente() As Integer
        Get
            Return bid_paciente
        End Get
        Set(value As Integer)
            bid_paciente = value
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

    Private dbcedula As String

    Public Property cedula() As String
        Get
            Return dbcedula

        End Get
        Set(value As String)
            dbcedula = value
        End Set
    End Property

    Private dbsexo As String

    Public Property sexo() As String
        Get
            Return dbsexo

        End Get
        Set(value As String)
            dbsexo = value
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

    Private dbtelefono As String

    Public Property telefono() As String
        Get
            Return dbtelefono

        End Get
        Set(value As String)
            dbtelefono = value
        End Set
    End Property

    Private dbdireccion As String

    Public Property direccion() As String
        Get
            Return dbdireccion
        End Get
        Set(value As String)
            dbdireccion = value
        End Set
    End Property

    Private dbcorreo As String

    Public Property correo() As String
        Get
            Return dbcorreo
        End Get
        Set(value As String)
            dbcorreo = value
        End Set
    End Property

    Private dbfecha_nac As DateTime

    Public Property fecha_nac() As DateTime
        Get
            Return dbfecha_nac

        End Get
        Set(value As DateTime)
            dbfecha_nac = value
        End Set
    End Property


    Private dbpeso As String

    Public Property peso() As String
        Get
            Return dbpeso

        End Get
        Set(value As String)
            dbpeso = value
        End Set
    End Property

    Private dbtelrepresenta As String

    Public Property telrepresenta() As String
        Get
            Return dbtelrepresenta
        End Get
        Set(value As String)
            dbtelrepresenta = value
        End Set
    End Property

    Private dbrepresentante As String

    Public Property representante() As String
        Get
            Return dbrepresentante
        End Get
        Set(value As String)
            dbrepresentante = value
        End Set
    End Property
    '==============================================================*
    'Este codigo representa la instanciancion de los objetos para 
    'interactuar con la base de datos

    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    Public Shared Function registrar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSERT INTO paciente (nombre, apellido, cedula, " +
                                  " sexo, edad, telefono, direccion, correo, " +
                                  "fecha_nacimiento, Peso, telrepresenta, representante " +
                                  ") VALUES ('" + dato(0) + "','" + dato(1) + "','" +
                                  dato(2) + "','" + dato(3) + "','" + dato(4) + "','" + dato(5) +
                                  "','" + dato(6) + "','" + dato(7) + "','" + dato(8) + "','" +
                                  dato(9) + "','" + dato(10) + "','" + dato(11) +
                                  "')"
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
    'de datos consulta_medicas que existen en la tabla paciente

    Public Shared Function consultar() As DataTable
        Try
            nombrecolumna()
            Dim query As String = "SELECT p.id_paciente, p.nombre, p.apellido, p.cedula, p.sexo, p.edad, p.telefono, p.direccion, p.correo, p.peso, p.telrepresenta, p.representante, i.imagen FROM paciente p , imagen i WHERE p.id_imagen = i.id_imagen"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_paciente"), leer("nombre"), leer("apellido"), leer("cedula"),
                                             leer("sexo"), leer("edad"), leer("telefono"), leer("direccion"), leer("correo"),
                                              leer("Peso"), leer("telrepresenta"),
                                             leer("representante"), leer("imagen")})
            End While
            Return tabla
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + "0" + ex.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + "1" + n.StackTrace)
        Catch t As Exception
            MessageBox.Show(t.Message + "2" + t.StackTrace)

        End Try
        Return tabla
    End Function

    '======================================================*
    'Este codigo realiza la funcion de editar los nombres de
    'las columnas del datagridview del formulario de paciente

    Private Shared Sub nombrecolumna()
        tabla = New DataTable()
        tabla.Columns.Add("id_paciente")
        tabla.Columns.Add("Nombre")
        tabla.Columns.Add("Apellido")
        tabla.Columns.Add("Cedula")
        tabla.Columns.Add("Sexo")
        tabla.Columns.Add("Edad")
        tabla.Columns.Add("Telefono")
        tabla.Columns.Add("Direccion")
        tabla.Columns.Add("Correo")
        tabla.Columns.Add("Peso")
        tabla.Columns.Add("Telefono_Representa")
        tabla.Columns.Add("Representa")
        tabla.Columns.Add("Ruta Imagen")
    End Sub


    '*============================================================================================*
    'Este codigo realiza la funcion de filtrar las informacion socilitada por el nombre del registro
    Public Shared Function filtrar(ByVal filtro As String) As DataTable
        Try
            nombrecolumna()
            Dim miomio As String = "SELECT p.id_paciente, p.nombre, p.apellido, p.cedula, p.sexo, p.edad, p.telefono, p.direccion, p.correo, p.peso, p.telrepresenta, p.representante, i.imagen FROM paciente p , imagen i WHERE p.id_paciente OR p.nombre OR p.apellido OR p.cedula OR p.sexo OR p.edad OR p.telefono OR p.direccion OR p.correo OR p.peso OR p.telrepresenta OR p.representante OR i.imagen LIKE '" + filtro + "%'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(miomio, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_paciente"), leer("nombre"), leer("apellido"), leer("cedula"),
                                             leer("sexo"), leer("edad"), leer("telefono"), leer("direccion"), leer("correo"),
                                              leer("Peso"), leer("telrepresenta"),
                                             leer("representante"), leer("imagen")})
            End While
            leer.Close()
            cn.Close()
            Return tabla
        Catch m As MySqlException
            MessageBox.Show(m.Message + m.StackTrace)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.StackTrace)

        End Try
        Return tabla
    End Function

    '*============================================================================================*
    'Este codigo realiza la funcion de filtrar las informacion socilitada por el nombre del registro

    Public Shared Function eliminar(ByVal id As Integer) As Boolean
        Try
            Dim elimina As String = "DELETE p, i FROM paciente AS p inner join imagen AS i ON i.id_imagen = p.id_imagen where p.id_paciente = '" + id + "'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(elimina, cn)
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

    '=======================================================================================*
    'Esta funcion realiza las actualizaciones en la base de datos de la tabla usuario desde
    'el formulario de registro de usuario

    Public Shared Function actualizar(dato() As Object) As Boolean
        Try
            Dim miquery As String = "UPDATE paciente AS p INNER JOIN imagen AS i ON p.id_imagen = i.id_imagen  SET p.nombre = '" + dato(1) + "', p.apellido = '" + dato(2) + "', p.cedula = '" + dato(3) + "', p.sexo = '" + dato(4) + "', p.edad = '" + dato(5) + "', p.telefono = '" + dato(6) + "', p.direccion = '" + dato(6) + "', p.correo = '" + dato(6) + "', p.fecha_nacimiento = '" + dato(6) + "', p.peso = '" + dato(6) + "', p.telrepresenta = '" + dato(6) + "', p.representante = '" + dato(6) + "', p.imagen = '" + dato(6) + "'    WHERE p.id_paciente =" + dato(0)
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
