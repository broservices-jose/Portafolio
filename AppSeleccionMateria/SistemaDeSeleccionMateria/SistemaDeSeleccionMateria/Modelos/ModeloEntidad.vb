Imports MySql.Data.MySqlClient

'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class ModeloEntidad

    '=================================================================='
    '           Constantes para trabajo de debug del programa
    '------------------------------------------------------------------
    '   Constante para indicar que la carrera esta clausurada
    Public Const MODIFICAR As String = "modificar"

    '------------------------------------------------------------------
    '   Costante para indicar que la carrera esta disponible
    Public Const REGISTRAR As String = "registrar"


    Public Shared Sub modificarEntidad(
        id_anterior$,
        id$,
        nombre$,
        representante$,
        direccion$,
        telefono$,
        registro$,
        imagen$
        )
        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "update entidad set " +
        "id_entidad=@id_entidad,nombre=@nombre,representante=@representante,direccion=@direccion,telefono=@telefono,registro=@registro"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_entidad", id)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@representante", representante)
        comando.Parameters.AddWithValue("@direccion", direccion)
        comando.Parameters.AddWithValue("@telefono", telefono)
        comando.Parameters.AddWithValue("@registro", registro)
        '------------------------------------
        '   Se inserta la imagen.
        ModeloImagenes.modificarURLImagen(id_anterior, imagen)
        '------------------------------------
        '   Se cambia el propietario de la imagen
        ModeloImagenes.cambiarPropietario(id_anterior, id)
        '------------------------------------


        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Sub insertarEntidad(
        id$,
        nombre$,
        representante$,
        direccion$,
        telefono$,
        registro$,
        imagen$
        )

        '------------------------------------
        '   Definicion de la sentencia sql
        Dim sql = "insert into entidad (id_entidad,nombre,representante,direccion,telefono,registro) values (@id_entidad,@nombre,@representante,@direccion,@telefono,@registro)"
        '------------------------------------


        '------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        '------------------------------------
        comando.Prepare()
        '------------------------------------
        comando.Parameters.AddWithValue("@id_entidad", id)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@representante", representante)
        comando.Parameters.AddWithValue("@direccion", direccion)
        comando.Parameters.AddWithValue("@telefono", telefono)
        comando.Parameters.AddWithValue("@registro", registro)
        '------------------------------------
        '   Se inserta la imagen.
        ModeloImagenes.agregarImagen(id, "entidad", imagen)
        '------------------------------------

        '------------------------------------
        '   Ejecucion del comando.
        comando.ExecuteNonQuery()
        '------------------------------------
    End Sub

    Public Shared Function confirmarModo() As String
        '--------------------------------------------------------------
        '   Aqui se consulta si la tabla esta vacia
        '   Si la tabla esta vacia se procede a insertar.
        '   Sino es asi se procedera a modificar
        Dim sql = "select count(*) as cantidad from entidad"

        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        Dim resultado = comando.ExecuteReader()

        Dim cantidad$ = ""
        While resultado.Read()
            cantidad = resultado.GetString("cantidad")
        End While

        If cantidad > 0 Then
            Return ModeloEntidad.MODIFICAR
        ElseIf cantidad <= 0 Then
            Return ModeloEntidad.REGISTRAR
        End If

        Return "estado no conocido para la entidad"
    End Function

    Public Shared Function octenerID() As String
        '--------------------------------------------------------------
        '   Se consulta cual es el id de la entidad
        '--------------------------------------------------------------

        Dim sql = "select id_entidad from entidad"

        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        Dim resultado = comando.ExecuteReader()

        Dim id$ = ""
        While resultado.Read()
            id = resultado.GetString("id_entidad")
        End While

        Return id
    End Function
End Class
