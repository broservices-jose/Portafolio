Imports MySql.Data.MySqlClient


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+
Public Class ModeloUsuarios

    '=================================================================='
    '               Funcion para confirmar usuarios
    '=================================================================='
    'Esta funcion es para confirmar si existe el usuario que se introujo
    'en los parametros especificados. Esta funcion retorna un true si lo
    'encontro y false si no logra encontrar al usuario.
    'Esta funcion es estatica y puede utilizarse desde cuqlquier punto 
    'del programa donde pueda se accedida esta clase
    '<ModeloUsuarios>
    '=================================================================='


    '------------------------------------------------------------------
    '   Esta variable es estatica y hace referencia al dataGridUsuarios.
    '   La idea es que sirva para que ese data grid pueda ser utilizado\
    '   y rellenado desde cualquier punto del programa.
    '   Esta variable es como una especie de puente.
    Public Shared tablaUsuario As DataGridView
    '------------------------------------------------------------------





    '=================================================================='
    '           Constantes para trabajo de debug del programa
    '------------------------------------------------------------------
    '   Esta constante y la constantes ACTIVO son alias de si mismos.
    Public Const HABILITADO As String = "activo"

    '------------------------------------------------------------------
    '   Esta constante y la constantes HABILITADO son alias de si mismos.
    Public Const ACTIVO As String = "activo"

    '------------------------------------------------------------------
    '   Constante para deshabilitados.
    Public Const DESHABILITADO As String = "deshabilitado"


    '------------------------------------------------------------------
    '   Constante para administrador.
    Public Const ADMINISTRADOR As String = "administrador"

    '------------------------------------------------------------------
    '   Constante para estudiante.
    Public Const ESTUDIANTE As String = "estudiante"

    '=================================================================='

    Public Shared Function consultarTipoUsuario(cuenta$)
        '----------------------------------------------------
        '   Se consulta el tipo de usuario.
        '----------------------------------------------------


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select tipo from usuarios where cuenta = @cuenta"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Se ejecuta el comando
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------
        Dim tipo$ = "tipo indefinido"
        While resultado.Read
            tipo = resultado.GetString("tipo")
        End While

        Return tipo
    End Function

    Public Shared Function octenerCarrera(cuenta$) As Integer
        '----------------------------------------------------
        '   Se consulta el tipo de usuario.
        '----------------------------------------------------


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select estudiantes.carrera from usuarios join estudiantes on usuarios.id_usuario=estudiantes.id_estudiante where usuarios.cuenta = @cuenta"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Se ejecuta el comando
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------
        Dim carreraResultado = "0" 'lo que significa que la carrera no esta definida.
        While resultado.Read
            carreraResultado = resultado.GetString("carrera")
        End While

        Return carreraResultado
    End Function

    Public Shared Function octenerIdPorCuenta(cuenta$)

        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select id_usuario from usuarios where cuenta=@cuenta"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Se ejecuta el comando
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------
        Dim id$ = "carrera indefinida"
        While resultado.Read
            id = resultado.GetString("id_usuario")
        End While

        Return id
    End Function

    Public Shared Function octenerNombreCompletoPorId(id) As String

        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select nombre,apellido from usuarios where id_usuario=@id_usuario"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@id_usuario", id)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Se ejecuta el comando
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------
        Dim nombre = "sin nombre"
        Dim apellido = "sin apellido"
        While resultado.Read
            nombre = resultado.GetString("nombre")
            apellido = resultado.GetString("apellido")
        End While

        Return nombre + " " + apellido
    End Function

    Public Shared Function confirmarUsuario(cuenta$, clave$) As Boolean

        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "select cuenta,clave,tipo from usuarios where " +
        "cuenta=@cuenta && clave=@clave"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        comando.Parameters.AddWithValue("@clave", clave)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comaondo sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Variables de confirmacion.
        '   Estas variables son utilizadas para guardar los
        '   resultados del MySqlDataReader<resultad>  para
        '   mas tarde ver si son iguales a los intorducidos
        '   en los parametros de esta funcion
        '----------------------------------------------------
        Dim cuentaUsuario$ = ""
        Dim cuentaClave$ = ""
        Dim cuentaTipo$ = ""

        While resultado.Read
            cuentaUsuario = resultado.GetString("cuenta")
            cuentaClave = resultado.GetString("clave")
            cuentaTipo = resultado.GetString("tipo")
        End While
        '----------------------------------------------------


        '----------------------------------------------------
        '       Zona de confirmacion
        '----------------------------------------------------
        If cuentaUsuario = cuenta Then
            If cuentaClave = clave Then
                Return True
            End If
        End If
        '----------------------------------------------------


        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------


        '====================================================
        '----------------------------------------------------
        ' En caso de que lacondicion anterio no se cumpla
        ' El resultado sera falso por convencion.
        Return False
        '====================================================
    End Function

    Public Shared Function insertarUsuario(
    id_usuario As String,
    nombre As String,
    apellido As String,
    sexo As String,
    cuenta As String,
    clave As String,
    estado As String,
    tipo As String,
    registro$) As Boolean


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "insert into usuarios (id_usuario,nombre,apellido,sexo,cuenta,clave,estado,tipo,registro) " +
        "values (" +
        "@id_usuario,@nombre,@apellido,@sexo,@cuenta,@clave,@estado,@tipo,@registro" +
        ")"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@id_usuario", id_usuario)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@apellido", apellido)
        comando.Parameters.AddWithValue("@sexo", sexo)
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        comando.Parameters.AddWithValue("@clave", clave)
        comando.Parameters.AddWithValue("@estado", estado)
        comando.Parameters.AddWithValue("@tipo", tipo)
        comando.Parameters.AddWithValue("@registro", registro)
        ' ----------------------------------------------------
        'MessageBox.Show(comando.CommandText)
        '----------------------------------------------------
        '   se ejecuta el comando
        comando.ExecuteNonQuery()


        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------


        '====================================================
        '----------------------------------------------------
        ' En caso de que lacondicion anterio no se cumpla
        ' El resultado sera falso por convencion.
        Return False
        '====================================================
    End Function

    Public Shared Sub cambiarEstado(id_usuario$, estado$)
        '----------------------------------------------------
        '   hay que destacar que los usuario no son eliminardos
        '   de la base de datos sino que se cambia su estado a
        '   deshabilitado.
        '----------------------------------------------------
        '   A esta funcion se le pasan dos parametros que 
        '   son el usuario a cambiar el estado y el nuevo 
        '   estado que tendra.
        '----------------------------------------------------


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "update usuarios set estado = @estado where id_usuario=@id_usuario"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@id_usuario", id_usuario)
        comando.Parameters.AddWithValue("@estado", estado)
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Se ejecuta el comando
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------

    End Sub

    Public Shared Function modificarUsuario(
    id_usuario As String,
    nombre As String,
    apellido As String,
    sexo As String,
    cuenta As String,
    clave As String,
    estado As String,
    tipo As String,
    registro$,
    url As String) As Boolean


        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        Dim sql =
        "update usuarios set nombre=@nombre,apellido=@apellido,sexo=@sexo,cuenta=@cuenta,clave=@clave,estado=@estado,registro=@registro where id_usuario=@id_usuario"
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        '----------------------------------------------------
        comando.Parameters.AddWithValue("@id_usuario", id_usuario)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@apellido", apellido)
        comando.Parameters.AddWithValue("@sexo", sexo)
        comando.Parameters.AddWithValue("@cuenta", cuenta)
        comando.Parameters.AddWithValue("@clave", clave)
        comando.Parameters.AddWithValue("@estado", estado)
        ''comando.Parameters.AddWithValue("@tipo", tipo)
        comando.Parameters.AddWithValue("@registro", registro)
        ' ----------------------------------------------------

        ' ----------------------------------------------------
        '   se modifica la imagen con el ide del propietario.
        ModeloImagenes.modificarURLImagen(id_usuario, url)

        '----------------------------------------------------
        '   se ejecuta el comando
        comando.ExecuteNonQuery()


        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------


        '====================================================
        '----------------------------------------------------
        ' En caso de que lacondicion anterio no se cumpla
        ' El resultado sera falso por convencion.
        Return False
        '====================================================
    End Function
End Class
