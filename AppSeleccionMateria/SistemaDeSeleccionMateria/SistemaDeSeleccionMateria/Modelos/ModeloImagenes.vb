Imports MySql.Data.MySqlClient

'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class ModeloImagenes

    Public Shared Sub agregarImagen(
    id_propietario$,
    tipo_propietario$,
    url$
    )
        '---------------------------------------------

        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "insert into imagenes (id_propietario,tipo_propietario,url,registro) values(" +
        "@id_propietario,@tipo_propietario,@url,current_date()" +
        ")"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '   La fecha no se pasa como un parametro de la funcion
        '   por que sera determinada al momento de insertar la
        '   imagen.
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@id_propietario", id_propietario)
        comando.Parameters.AddWithValue("@tipo_propietario", tipo_propietario)
        comando.Parameters.AddWithValue("@url", url)
        '        comando.Parameters.AddWithValue("@registro", "current_date()")
        ' ----------------------------------------------------

        comando.ExecuteNonQuery()
        '        MessageBox.Show("hola")

        '   Se procede a cerrar la conexion.
        Conexion.CerrarConexion()
    End Sub

    Public Shared Function cargarImagen(propietario$, tipo$) As String
        'En el sql de abajo hay que tener en cuenta el tipo de entidad que se solicita la imagen.
        Dim sql = "select url from imagenes where id_propietario = '" + propietario + "' && tipo_propietario='" + tipo + "'"

        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        Dim resultado = comando.ExecuteReader()

        Dim imagen$ = ""
        While resultado.Read()
            imagen = resultado.GetString("url")
        End While

        Return imagen
    End Function

    Public Shared Sub modificarURLImagen(id_propietario$, url$)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "update imagenes set url = @url where id_propietario=@id_propietario"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '   La fecha no se pasa como un parametro de la funcion
        '   por que sera determinada al momento de insertar la
        '   imagen.
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@url", url)
        comando.Parameters.AddWithValue("@id_propietario", id_propietario)
        ' ----------------------------------------------------

        comando.ExecuteNonQuery()

        ' ----------------------------------------------------
        '   Se procede a cerrar la conexion.
        Conexion.CerrarConexion()
    End Sub
    Public Shared Sub cambiarPropietario(anterior$, nuevo$)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "update imagenes set id_propietario = @nuevo where id_propietario=@anterior"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '   La fecha no se pasa como un parametro de la funcion
        '   por que sera determinada al momento de insertar la
        '   imagen.
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@nuevo", nuevo)
        comando.Parameters.AddWithValue("@anterior", anterior)
        ' ----------------------------------------------------

        comando.ExecuteNonQuery()

        ' ----------------------------------------------------
        '   Se procede a cerrar la conexion.
        Conexion.CerrarConexion()
    End Sub
End Class
