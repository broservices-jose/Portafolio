Imports MySql.Data.MySqlClient

'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class AgregarMateria

    Private Sub AgregarMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Este bloque se utiliza tambien en el vento click del dataGridCarreras
        ContorladorVentanaPrincipal.cargarTablaCarreras(dataGridCarreras)

        '------------------------------------------------------
        'Carrera por la cual se va a filtrar.
        Dim carrera = dataGridCarreras.CurrentRow.Cells(0).Value

        ControladorAgregarMateria.cargarTablaRequisito(dataGridRequisito, carrera)

    End Sub

    Private Sub dataGridCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCarreras.CellContentClick

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridRequisito.CellContentClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles nombreMateriaTxt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '--------------------------------------------
        '   Se inserta una nueva materia.
        '--------------------------------------------
        Dim nombre = nombreMateriaTxt.Text
        '--------------------------------------------
        Dim carrera = dataGridCarreras.CurrentRow.Cells(0).Value
        '--------------------------------------------
        Dim requisito = 0
        If dataGridRequisito.Enabled = True Then
            requisito = dataGridRequisito.CurrentRow.Cells(0).Value
        End If
        '--------------------------------------------
        ControladorAgregarMateria.crearMateria(nombre, carrera, requisito, ModeloMaterias.DISPONIBLE)
        '--------------------------------------------
        Me.Dispose()

        ContorladorVentanaPrincipal.cargarTablaMaterias(VentanaPrincipal.VentanaPrincipalConpartida.DataGridMaterias)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dataGridRequisito.Enabled = False
        Else
            dataGridRequisito.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub dataGridCarreras_Click(sender As Object, e As EventArgs) Handles dataGridCarreras.Click
        'Esto tambien se usa en el evento load
        'Solo que aqui no se carga la tabla de carreras porque ya esta cargada.
        '------------------------------------------------------
        'Carrera por la cual se va a filtrar.
        Dim carrera = dataGridCarreras.CurrentRow.Cells(0).Value

        ControladorAgregarMateria.cargarTablaRequisito(dataGridRequisito, carrera)

    End Sub
End Class

Class ControladorAgregarMateria

    Public Shared Sub cargarTablaRequisito(tabla As DataGridView, carrera$)
        '----------------------------------------------------
        '           SENTENCIA SQL A EJECUTAR
        '----------------------------------------------------
        '   Esto se utiliza para seleccionar las materias
        '   De acuerdo a la carrera actual
        '----------------------------------------------------
        Dim sql =
        "select id_materia,nombre,estado,carrera from materias where carrera=" & carrera
        '----------------------------------------------------


        '----------------------------------------------------
        '   Seccion de preparacion para el comanddo MySqlCommand
        '----------------------------------------------------
        Dim comando = New MySqlCommand(sql, Conexion.Conectar())
        comando.Prepare()
        ' ----------------------------------------------------


        '----------------------------------------------------
        '   Almacen de resultados del comando sql
        Dim resultado As MySqlDataReader = comando.ExecuteReader()
        '----------------------------------------------------


        '----------------------------------------------------
        '   Aqui es donde se llena la tabla de las carreras a trabajar.
        '----------------------------------------------------
        '   Se limpian las filas de la tabla.
        '   Solo en caso de que este vacia.
        '----------------------------------------------------
        tabla.Rows.Clear()
        '----------------------------------------------------

        While resultado.Read
            tabla.Rows.Add(
                resultado.GetString("id_materia"),
                resultado.GetString("nombre"),
                resultado.GetString("estado"),
                resultado.GetString("carrera")
            )
        End While
        '----------------------------------------------------

        '----------------------------------------------------
        ' La conexion se cierra para ahorrar recursos
        Conexion.CerrarConexion()
        '----------------------------------------------------

    End Sub


    Public Shared Sub crearMateria(nombre$, carrera$, requisito$, estado$)
        '-----------------------------------------
        '   Esta funcion es para crear materias.
        '   Y usa el modelo de las materias pra esto proposito.
        ModeloMaterias.insertarMateria(nombre, carrera, requisito, estado)


    End Sub


    Public Shared Sub clausurarMateria()

    End Sub
End Class