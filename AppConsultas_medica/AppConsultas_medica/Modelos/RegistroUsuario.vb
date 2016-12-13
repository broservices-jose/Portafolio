Imports MySql.Data.MySqlClient
Imports System.Data

Public Class RegistroUsuario

    Private did_usuario As Integer

    Public Property id_usuario As String
        Get
            Return did_usuario
        End Get
        Set(value As String)
            did_usuario = value
        End Set
    End Property

    Private dnombre As String

    Public Property nombre As String
        Get
            Return dnombre
        End Get
        Set(value As String)
            dnombre = value
        End Set
    End Property

    Private dpermiso As String
    Public Property permiso As String
        Get
            Return dpermiso
        End Get
        Set(value As String)
            dpermiso = value
        End Set
    End Property

    Private dclave As String

    Public Property clave As String
        Get
            Return dclave
        End Get
        Set(value As String)
            dclave = value
        End Set
    End Property
    Private darea As String

    Private dregistro_inicios As DateTime

    Public Property registro_inicios As DateTime
        Get
            Return dregistro_inicios
        End Get
        Set(value As DateTime)
            dregistro_inicios = value
        End Set
    End Property

    Private dregistro_cierres As DateTime

    Public Property registro_cierres As DateTime
        Get
            Return dregistro_cierres
        End Get
        Set(value As DateTime)
            dregistro_cierres = value
        End Set
    End Property

    Private larea As String

    Public Property area As String
        Get
            Return larea
        End Get
        Set(value As String)
            larea = value
        End Set
    End Property



    Shared cn As MySqlConnection
    Shared cmd As MySqlCommand
    Shared leer As MySqlDataReader
    Shared tabla As DataTable


    '===========================================================================================*
    'Esta funcion realiza las insercciones a la tabla usuario de la base de datos

    Public Shared Function registrar(ByVal dato() As String) As Boolean
        Try
            Dim query As String = "INSERT INTO usuario ( nombre, permiso, clave, Registro_inicio_sesion, " +
                                  "Registro_cierre_sesion, area) VALUES ('" + dato(0) + "','" + dato(1) +
                                  "','" + dato(2) + "','" + dato(3) + "','" + dato(4) + "','" + dato(5) + "')"
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


    '=============================================================================================*
    'Esta funcion realiza las consultas de la informaciones que se encuentran en la base de datos
    'de la tabla usuario

    Public Shared Function consultar() As DataTable
        Try
            nombrecolumna()
            Dim query As String = "SELECT u.id_usuario, u.nombre, u.permiso, u.clave, u.Registro_inicio_sesion, " +
                "u.Registro_cierre_sesion, u.area, i.imagen FROM usuario u, imagen i WHERE u.id_imagen = i.id_imagen"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_usuario"), leer("nombre"), leer("permiso"), leer("clave"),
                                             leer("Registro_inicio_sesion"), leer("Registro_cierre_sesion"), leer("area"),
                                             leer("imagen")})
            End While
            Return tabla
            leer.Close()
            cn.Close()
        Catch m As MySqlException
            MessageBox.Show(m.Message)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return tabla
    End Function

    '======================================================*
    'Este codigo realiza la funcion de editar los nombres de
    'las columnas del datagridview del formulario de usuario

    Private Shared Sub nombrecolumna()
        tabla = New DataTable()
        tabla.Columns.Add("Id_usuario")
        tabla.Columns.Add("Nombre")
        tabla.Columns.Add("Permiso")
        tabla.Columns.Add("Clave")
        tabla.Columns.Add("Registro Inicio Sesion")
        tabla.Columns.Add("Registro Cierre Sesion")
        tabla.Columns.Add("Area")
        tabla.Columns.Add("Ruta Imagen")
    End Sub

    '==================================================================================*
    'Esta funcion realiza los filtros de busquedad que solictan desde el formulario de 
    'de usuario

    Public Shared Function filtrar(filtro As String) As DataTable
        Try
            Dim query As String = "SELECT u.id_usuario, u.nombre, u.permiso, u.clave, u.Registro_inicio_sesion, u.Registro_cierre_sesion, u.area, i.imagen FROM usuario u, imagen i WHERE u.nombre LIKE '" + filtro + "%'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader()
            While leer.Read()
                tabla.Rows.Add(New Object() {leer("id_usuario"), leer("nombre"), leer("permiso"), leer("clave"), leer("Registro_inicio_sesion"), leer("Registro_cierre_sesion"), leer("area"), leer("imagen")})
            End While
            leer.Close()
            cn.Close()
            Return tabla
        Catch m As MySqlException
            MessageBox.Show(m.Message)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message + n.StackTrace)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return tabla
    End Function

    '=======================================================================================*
    'Esta funcion realiza las actualizaciones en la base de datos de la tabla usuario desde
    'el formulario de registro de usuario

    Public Shared Function actualizar(dato As Object()) As Boolean
        Try
            Dim miquery As String = "UPDATE usuario AS u INNER JOIN imagen AS g ON u.id_imagen = g.id_imagen  SET u.nombre = '" + dato(1) + "', u.permiso = '" + dato(2) + "', u.clave = '" + dato(3) + "', u.Registro_inicio_sesion = '" + dato(4) + "', u.Registro_cierre_sesion = '" + dato(5) + "', u.area = '" + dato(6) + "', g.imagen ='" + dato(7) + "' WHERE u.id_usuario ='" + dato(0) + "'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(miquery, cn)
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
        Return False
    End Function



    '=================================================================================================*
    'Esta funcion realiza la eliminacion de los datos solicitados desde el formulario del usuario 

    Public Shared Function eliminar(id As Integer) As Boolean
        Try
            Dim miquery As String = "DELETE u, i FROM usuario AS u INNER JOIN imagen AS i ON i.id_imagen = u.id_imagen WHERE u.id_usuario  ='" + id
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(miquery, cn)
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
End Class
