Imports MySql.Data.MySqlClient
Public Class frmTest
    Dim connection As New connection
    Private Sub btn_CerrarCnt1_Click(sender As Object, e As EventArgs) Handles btn_CerrarCnt1.Click
        cnt1.Visible = False
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        cnt1.Visible = True
        Dim query = "SELECT id, nombres, apellidos, email FROM nscasino_usuarios;"
        Dim SqlAdp As MySqlDataAdapter = New MySqlDataAdapter(query, connection.cn)
        Dim ds As New DataSet()
        If (connection.cn.State = ConnectionState.Closed) Then
            Try
                connection.cn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        End If
        SqlAdp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmNuevo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim ver As New DPFP.Verification.Verification
        frmVerify.Show()
    End Sub

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
