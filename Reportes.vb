Imports System.Data.SqlClient
Public Class Reportes

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comando As SqlCommand

        Dim datos As SqlDataReader

        Dim conexion As New SqlConnection("server=DESKTOP-DG9IUDO\JOSEMANUEL;Initial Catalog=farsiman;Integrated Security=true;")
        Dim strsql As String
        conexion.Open()
        strsql = "Select * from tblRegistroviajes "
        comando = New SqlCommand(strsql, conexion)
        datos = comando.ExecuteReader


        If datos.HasRows Then
            While datos.Read


                DataGridView1.Rows.Add(datos.GetValue(0), datos.GetValue(1), datos.GetValue(2), datos.GetValue(3), datos.GetValue(4))

            End While
            comando.Dispose()
            datos.Close()
            conexion.Close()


        Else



        End If
        comando.Dispose()
        datos.Close()
        conexion.Close()




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class