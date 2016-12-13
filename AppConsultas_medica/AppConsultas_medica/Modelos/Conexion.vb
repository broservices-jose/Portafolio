Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Conexion

    Public Shared Function conectar() As MySqlConnection

        Dim servidor As String = "127.0.0.1"
        Dim basedatos As String = "consulta_medicas"
        Dim usuario As String = "root"
        Dim contrasenia As String = ""

        Dim cn As New MySqlConnection("Server=" + servidor + ";Database=" + basedatos + ";User=" + usuario + ";Pwd=" + contrasenia)
        Return cn

    End Function
End Class