Imports MySql.Data.MySqlClient

'+=============================================================================+
'|                      Jose Manuel Estevez Linares                            |
'|=============================================================================+
'|                              DATE:   2016/10/17                             |
'+=============================================================================+

Public Class ModeloMaterias



    '=================================================================='
    '           Constantes para trabajo de debug del programa
    '------------------------------------------------------------------
    '   Constante para indicar que la materia esta clausurada
    Public Const CLAUSURADA As String = "clausurada"

    '------------------------------------------------------------------
    '   Costante para indicar que la materia esta disponible
    Public Const DISPONIBLE As String = "disponible"

    '------------------------------------------------------------------
    '   Costante para indicar que la materia esta reprovada
    Public Const REPROVADA As String = "reprovada"

    '------------------------------------------------------------------
    '   Costante para indicar que la materia esta pendiente
    Public Const PENDIENTE As String = "pendiente"
    '------------------------------------------------------------------
    '   Costante para indicar que la materia esta en proceso
    Public Const EN_PROCESO As String = "en proceso"
    '------------------------------------------------------------------
    '   Costante para indicar que la materia esta en proceso
    Public Const APROVADA As String = "aprovada"


    Public Shared Sub insertarMateria(nombre$, carrera$, requisito$, estado$)

        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "insert into materias (nombre,carrera,requisito,estado,registro) values (@nombre,@carrera,@requisito,@estado,current_date())"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@carrera", carrera)
        comando.Parameters.AddWithValue("@requisito", requisito)
        comando.Parameters.AddWithValue("@estado", estado)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub cambiarEstadoMateria(id_materia$, estado$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "update materias set estado=@estado where id_materia=@id_materia"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_materia", id_materia)
        comando.Parameters.AddWithValue("@estado", estado)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub
    Public Shared Sub eliminarMateria(id_materia$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "delete from materias where id_materia = @id_materia"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_materia", id_materia)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub insertarMateriaEstudiante(id$, id_estudiante$, id_materia$, nombre_materia$, estado$)

            '------------------------------------
            '   Definicion de la sentencia sql
            Dim sql = "insert into materias_estudiantes (id,id_estudiante,id_materia,nombre_materia,estado) values (@id,@id_estudiante,@id_materia,@nombre_materia,@estado)"
            '------------------------------------


            '------------------------------------
            Dim comando = New MySqlCommand(sql, Conexion.Conectar())
            '------------------------------------
            comando.Prepare()
            '------------------------------------
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@id_estudiante", id_estudiante)
            comando.Parameters.AddWithValue("@id_materia", id_materia)
            comando.Parameters.AddWithValue("@nombre_materia", nombre_materia)
            comando.Parameters.AddWithValue("@estado", estado)
            '------------------------------------

            '------------------------------------
            '   Ejecucion del comando.
            comando.ExecuteNonQuery()
            '------------------------------------
    End Sub

    Public Shared Function consultarEstadoMateriaEstudiante(id_estudiante$, id_materia$)

        '------------------------------------
        '   Definicion de la sentencia sql
        'MessageBox.Show(id_estudiante & " " & id_materia) 'debug
        Dim sql = "select estado from materias_estudiantes where id=" & id_estudiante & " && id_materia=" & id_materia & ""
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        'comando.Parameters.AddWithValue("@id_estudiante", Convert.ToString(id_estudiante))
        'comando.Parameters.AddWithValue("@id_materia", Convert.ToString(id_materia
        '))
        '------------------------------------
        'MessageBox.Show(comando.CommandText) 'debug
        Dim resultado As MySqlDataReader = comando.ExecuteReader()

        Dim estado$ = "sin estadoo"
        While resultado.Read()
            estado = resultado.GetString("estado")
        End While

        '------------------------------------
        Return estado
        '------------------------------------
    End Function
End Class
