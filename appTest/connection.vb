Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class connection
    Public cn As MySqlConnection = New MySqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ToString())
    Public Sub Conectar()
        Try
            If (cn.State <> ConnectionState.Open) Then
                cn.Open()
                MsgBox("Conexion establecida")
            End If
        Catch ex As Exception
            MsgBox("A ocurrido un error!!!")
        End Try
    End Sub
    Public Sub CerraConexion()
        If (cn.State <> ConnectionState.Closed) Then
            cn.Close()
        End If
    End Sub
End Class
