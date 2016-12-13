Imports MySql.Data.MySqlClient


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+
Public Class ModeloEstudiantes





    Public Shared Sub insertarUsuario(id_estudiante$, carrera$)

        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "insert into estudiantes (id_estudiante,carrera) values (@id_estudiante,@carrera)"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_estudiante", id_estudiante)
        comando.Parameters.AddWithValue("@carrera", carrera)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub establecerCarreraa(id_estudiante$, carrera$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "update estudiantes set carrera=@carrera where id_estudiante=@id_estudiante"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@carrera", carrera)
        comando.Parameters.AddWithValue("@id_estudiante", id_estudiante)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Function octenerCarreraPorId(id As String, carrera As String)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select carrera from estudiante join materias on carreras.id_carrera=materia.id_materia where carreras.id_carrera=@id_carrera"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()

        comando.Parameters.AddWithValue("@id_carrera", carrera)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------

        '----------------------------------------------------

        While resultado.Read

        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------
    End Function
End Class
