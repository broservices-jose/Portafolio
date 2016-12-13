Imports MySql.Data.MySqlClient

Public Class Materia

    Public id As String = "inexistente"
    Public nombre As String = "sin requisito"
    Public requisito As Materia
    Public estado As String = "sin estado"
    'Metodo vacio para ayudar ala clase.
    Public Sub New()

    End Sub
    Public Sub New(id_materia As String)
        Try

            '----------------------------------------------------
            '           SENTENCIA SQL A EJECUTAR
            '----------------------------------------------------
            Dim sql =
            "select id_materia,nombre,requisito,estado from materias where id_materia=@id_materia"
            '----------------------------------------------------
            '----------------------------------------------------
            '   Seccion de preparacion para el comanddo MySqlCommand
            '----------------------------------------------------
            Dim comando = New MySqlCommand(sql, Conexion.Conectar())
            comando.Prepare()

            comando.Parameters.AddWithValue("@id_materia", id_materia)
            ' ----------------------------------------------------
            '----------------------------------------------------
            '   Almacen de resultados del comando sql
            Dim resultado As MySqlDataReader = comando.ExecuteReader()
            '----------------------------------------------------

            '----------------------------------------------------

            While resultado.Read
                Me.id = resultado.GetString("id_materia")
                Me.nombre = resultado.GetString("nombre")
                Me.requisito = New Materia(resultado.GetString("requisito")) 'se crea otra materia que es el requisito.
                Me.estado = resultado.GetString("estado")
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

    Public Sub cargarDatos(id_materia As String)
        Try

            '----------------------------------------------------
            '           SENTENCIA SQL A EJECUTAR
            '----------------------------------------------------
            Dim sql =
            "select id_materia,nombre,requisito,estado from materias where id_materia=@id_materia"
            '----------------------------------------------------
            '----------------------------------------------------
            '   Seccion de preparacion para el comanddo MySqlCommand
            '----------------------------------------------------
            Dim comando = New MySqlCommand(sql, Conexion.Conectar())
            comando.Prepare()

            comando.Parameters.AddWithValue("@id_materia", id_materia)
            ' ----------------------------------------------------
            '----------------------------------------------------
            '   Almacen de resultados del comando sql
            Dim resultado As MySqlDataReader = comando.ExecuteReader()
            '----------------------------------------------------

            '----------------------------------------------------

            While resultado.Read
                Me.id = resultado.GetString("id_materia")
                Me.nombre = resultado.GetString("nombre")
                Me.requisito = New Materia(resultado.GetString("requisito")) 'se crea otra materia que es el requisito.
                Me.estado = resultado.GetString("estado")
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


End Class
