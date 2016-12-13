Imports MySql.Data.MySqlClient

'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class ModeloCarreras



    '=================================================================='
    '           Constantes para trabajo de debug del programa
    '------------------------------------------------------------------
    '   Constante para indicar que la carrera esta clausurada
    Public Const CLAUSURADA As String = "clausurada"

    '------------------------------------------------------------------
    '   Costante para indicar que la carrera esta disponible
    Public Const DISPONIBLE As String = "disponible"






    Public Shared Sub insertarCarrera(nombre$, estado$)

        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "insert into carreras (nombre,estado,registro) values (@nombre,@estado,current_date())"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@estado", estado)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub modificarCarrera(id_carrera$, nombre$, estado$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "update carreras set nombre=@nombre,estado=@estado) where id_carrera=@id_carrera"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@estado", estado)
        comando.Parameters.AddWithValue("@id_carrera", id_carrera)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub
    Public Shared Sub cambiarEstado(id_carrera$, estado$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "update carreras set estado=@estado where id_carrera=@id_carrera "
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@estado", estado)
        comando.Parameters.AddWithValue("@id_carrera", id_carrera)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub eliminarPermanente(id_carrera$)
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "delete from carreras where id_carrera=@id_carrera "
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_carrera", id_carrera)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub
End Class
