Imports MySql.Data.Entity
Imports MySql.Data.MySqlClient


Class Conexion
    Public Function Conectar() As MySqlConnection
        Dim conexion As New MySqlConnection("Server = localhost;Database=sistema_estudiantes;Uid=root;Pwd=2222")
        conexion.Open()
        Return conexion
    End Function
End Class

Public Class Form1

    Dim conexion As New Conexion

    REM hola como estas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim comando As New MySqlCommand("select cuenta from usuarios", conexion.Conectar())
        Dim adapatador As MySqlDataReader = comando.ExecuteReader()

        While adapatador.Read()
            adapatador.GetString(0)
        End While
    End Sub

    Private Sub timerSplash_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        Dim login As New Login()
        login.Show()
        Me.Hide()
        timerSplash.Stop()
    End Sub
End Class
