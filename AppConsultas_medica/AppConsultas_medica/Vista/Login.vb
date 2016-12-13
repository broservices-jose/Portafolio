Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Login

    Private cn As MySqlConnection
    Private cmd As MySqlCommand
    Private leer As MySqlDataReader

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Try
            Dim query As String = "SELECT * FROM usuario WHERE nombre ='" + Me.txtnombre.Text + "' AND permiso ='" + Me.cbpermiso.Text + "'AND clave='" + Me.txtclave.Text + "'"
            cn = Conexion.conectar()
            cn.Open()
            cmd = New MySqlCommand(query, cn)
            leer = cmd.ExecuteReader
            Dim c As Integer = 0
            While leer.Read()
                c = c + 1
            End While

            If c = 1 Then
                Me.Hide()
                MessageBox.Show("Bienvenido Al sistema de Consultas Medicas")
                Principa.Show()
            ElseIf c > 1 Then
                MessageBox.Show("Acceso denegado")

            Else
                MessageBox.Show("Nombre o Contraseña Incorrecta")
            End If
            cn.Close()
            leer.Close()

        Catch m As MySqlException
            MessageBox.Show(m.Message)
        Catch n As NullReferenceException
            MessageBox.Show(n.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbpermiso.Items.Add("Administrador")
        cbpermiso.Items.Add("Estandar")
        cbpermiso.Items.Add("Limitado")
        cbpermiso.Items.Add("Visitante")
    End Sub



End Class