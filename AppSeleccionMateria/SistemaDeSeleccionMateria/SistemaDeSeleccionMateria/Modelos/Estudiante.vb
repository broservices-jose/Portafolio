Imports MySql.Data.MySqlClient

Public Class Estudiante

    Public id As String = "sin nombre"
    Public nombre As String = "sin apellido"
    Public apellido As String = "sin apellido"
    Public sexo As String = "sin sexo"
    Public cuenta As String = "sin cuenta"
    Public clave As String = "sin clave"
    Public tipo As String = "sin tipo"
    Public carrera As String = "sin carrera"
    Public nombreCarrera As String = "sin nombre en la carrera"

    Public Sub New(id_estudiante As String)
        Try

            '----------------------------------------------------
            '           SENTENCIA SQL A EJECUTAR
            '----------------------------------------------------
            Dim sql =
            "select " +
            "usuarios.id_usuario as id_usuario, " +
            "usuarios.nombre as nombre_usuario, " +
            "usuarios.apellido as apellido_usuario, " +
            "usuarios.sexo as sexo_usuario, " +
            "usuarios.cuenta as cuenta_usuario, " +
            "usuarios.clave as clave_usuario, " +
            "usuarios.tipo as tipo_usuario, " +
            "estudiantes.carrera as carrera_estudiante, " +
            "carreras.nombre as nombre_carrera " +
            " from usuarios join estudiantes on usuarios.id_usuario = estudiantes.id_estudiante join carreras on estudiantes.carrera=carreras.id_carrera where usuarios.id_usuario=@id_usuario"
            '----------------------------------------------------
            '----------------------------------------------------
            '   Seccion de preparacion para el comanddo MySqlCommand
            '----------------------------------------------------
            Dim comando = New MySqlCommand(sql, Conexion.Conectar())
            comando.Prepare()

            comando.Parameters.AddWithValue("@id_usuario", id_estudiante)
            ' ----------------------------------------------------
            '----------------------------------------------------
            '   Almacen de resultados del comando sql
            Dim resultado As MySqlDataReader = comando.ExecuteReader()
            '----------------------------------------------------

            '----------------------------------------------------

            While resultado.Read
                Me.id = resultado.GetString("id_usuario")
                Me.nombre = resultado.GetString("nombre_usuario")
                Me.apellido = resultado.GetString("apellido_usuario")
                Me.sexo = resultado.GetString("sexo_usuario")
                Me.cuenta = resultado.GetString("cuenta_usuario")
                Me.clave = resultado.GetString("clave_usuario")
                Me.tipo = resultado.GetString("tipo_usuario")
                Me.carrera = resultado.GetString("carrera_estudiante")
                Me.nombreCarrera = resultado.GetString("nombre_carrera")
                'MessageBox.Show(sexo) 'debug
            End While
            '----------------------------------------------------

            '----------------------------------------------------
            ' La conexion se cierra para ahorrar recursos
            Conexion.CerrarConexion()
            '----------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cargarDatos(id_estudiante As String)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select * from usuarios join estudiantes on usuarios.id_usuario = estudiantes.id_estudiante where usuarios.id_usuario=@id_usuario"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()

        comando.Parameters.AddWithValue("@id_usuario", id_estudiante)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------

        '----------------------------------------------------

        While resultado.Read
            Me.id = resultado.GetString("id_usuario")
            Me.nombre = resultado.GetString("nombre")
            Me.apellido = resultado.GetString("apellido")
            Me.sexo = resultado.GetString("sexo")
            Me.cuenta = resultado.GetString("cuenta")
            Me.clave = resultado.GetString("clave")
            Me.tipo = resultado.GetString("tipo")
            Me.carrera = resultado.GetString("carrera")
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub


End Class
