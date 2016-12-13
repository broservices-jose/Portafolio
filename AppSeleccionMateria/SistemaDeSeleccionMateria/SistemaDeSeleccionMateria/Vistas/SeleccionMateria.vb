Imports MySql.Data.MySqlClient


'+=============================================================================+
'|                        Jose Manuel Estevez Linares                          |
'|=============================================================================+
'|                              DATE:   2016/10/13                             |
'+=============================================================================+

Public Class SeleccionarMateria

    Public cuenta As String


    Private Sub SeleccionarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim carrera = VentanaPrincipal.VentanaPrincipalConpartida.estudianteActual.carrera

        ControladorSeleccionMateria.cargarTablaMaterias(dataGridMateria, carrera)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '------------------------------------------------
        '   Se asigna el id del usuario para trabajar con la tabla materias_usuarios.
        Dim idEstudiante = VentanaPrincipal.VentanaPrincipalConpartida.estudianteActual.id

        '------------------------------------------------
        Dim idMateria = dataGridMateria.CurrentRow.Cells(0).Value
        '------------------------------------------------
        Dim nombreMateria = dataGridMateria.CurrentRow.Cells(1).Value
        '------------------------------------------------
        'El ID de la materia en seleccion es igual al id del estudiante mas el id de la materia.
        'Asi el estudiante solo puede tomar una sola materia.
        Dim id_materia_seleccion = (idEstudiante & "-" & idMateria)


        '------------------------------------------------
        '   La mayor parte de este bloque es par avitar que
        '   Se leccione una meteria con un requisito sin
        '   Estar aprovado.
        '------------------------------------------------
        '   Variable que almacena el requisito y sus datos como un objeto materia
        '   Si y solo si el valor no es 'sin requisito'
        '------------------------------------------------
        Dim requisito As Materia
        '------------------------------------------------
        '   Asi el dataGrid tomara si tiene 'sin requisito' o no.
        Dim estado_requisito = dataGridMateria.CurrentRow.Cells(2).Value

        '   Si la materia no tiene requisito pasa simplemente lo agrega.
        '   De lo contrario comprueba el requisito.

        'MessageBox.Show("estado requisito: " + estado_requisito)'debug

        If estado_requisito <> "sin requisito" Then
            '------------------------------------------------
            Dim id_requisito = dataGridMateria.CurrentRow.Cells(3).Value
            '------------------------------------------------
            Dim requisito_en_prueba = New Materia(id_requisito).id

            'MessageBox.Show("requisito: " + requisito_en_prueba)'debug
            '------------------------------------------------
            Dim estudiante = VentanaPrincipal.VentanaPrincipalConpartida.estudianteActual.id
            'MessageBox.Show("id_estudiante: " + estudiante) 'debug
            '------------------------------------------------
            Dim estado_del_requisito = ModeloMaterias.consultarEstadoMateriaEstudiante(
                estudiante,
                requisito_en_prueba
                )
            '------------------------------------------------
            'MessageBox.Show("estado: " + estado_del_requisito) 'debug
            If estado_del_requisito <> ModeloMaterias.APROVADA Then
                MessageBox.Show("No se a aprovado la materia de requisito para esta materia. requisito: " & New Materia(id_requisito).nombre)
            Else
                '------------------------------------------------
                Try
                    ModeloMaterias.insertarMateriaEstudiante(id_materia_seleccion, idEstudiante, idMateria, nombreMateria, ModeloMaterias.EN_PROCESO)
                    Me.Dispose()
                Catch ex As MySqlException
                    '------------------------------------------------
                    '   1062 en la numeracion del error: 'duplicate primary key' en mysql
                    If ex.Number = "1062" Then
                        MessageBox.Show("No puedes seleccionar la misma materia 2 veces")
                    End If
                End Try
            End If
        Else
            '------------------------------------------------
            Try
                ModeloMaterias.insertarMateriaEstudiante(id_materia_seleccion, idEstudiante, idMateria, nombreMateria, ModeloMaterias.EN_PROCESO)
                Me.Dispose()
            Catch ex As MySqlException
                '------------------------------------------------
                '   1062 en la numeracion del error: 'duplicate primary key' en mysql
                If ex.Number = "1062" Then
                    MessageBox.Show("No puedes seleccionar la misma materia 2 veces")
                End If
            End Try
        End If



    End Sub

End Class

Class ControladorSeleccionMateria
    Public Shared Sub cargarTablaMaterias(tabla As DataGridView, carrera As String)
        Try

            '----------------------------------------------------
            '           SENTENCIA SQL A EJECUTAR
            '----------------------------------------------------
            '   Se crea la materia para ser utilizada como clase de soporte para 
            '   Cargar los datos.
            Dim materia As Materia
            '----------------------------------------------------
            Dim sql =
            "select " +
            "materias.id_materia as id_materia," +
            "materias.nombre as nombre_materia," +
            "materias.requisito as requisito" +
            " from carreras join materias on carreras.id_carrera=materias.carrera where materias.carrera=@id_carrera"
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
            '   Aqui es donde se llena la tabla de las carreras a trabajar.
            '----------------------------------------------------
            '   Se limpian las filas de la tabla.
            '   Solo en caso de que este vacia.
            '----------------------------------------------------
            tabla.Rows.Clear()
            '----------------------------------------------------
            While resultado.Read
                '--------------------------------------------
                '   Se crea la instancia de la materia.
                materia = New Materia(resultado.GetString("id_materia"))

                tabla.Rows.Add(
                    resultado.GetString("id_materia"),
                    resultado.GetString("nombre_materia"),
                    materia.requisito.nombre,
                    materia.requisito.id
                )
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