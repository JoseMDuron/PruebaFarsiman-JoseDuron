Imports System.Data.SqlClient
Public Class RegistroViajes
    Public punto As Boolean = True
    Private Sub Bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click


        Try
            Dim comando As SqlCommand

            Dim conexion As New SqlConnection("server=DESKTOP-DG9IUDO\JOSEMANUEL;Initial Catalog=farsiman;Integrated Security=true;")
            Dim strsql As String
            conexion.Open()

            If txt_nombresucursal.Text = Nothing Or cbSucursales.SelectedIndex = -1 Or NumericUpDown1.Value = 0 Or txt_nombretransportista.Text = Nothing Then

                MsgBox("Debe ingresar todos los datos")
            Else


                strsql = "insert into tblRegistroviajes values('" & txt_nombresucursal.Text & "'," & "'" & cbSucursales.SelectedItem & "'" & "," & NumericUpDown1.Value & "," & "'" & txt_nombretransportista.Text & "'" & "," & txt_precio.Text & ")"
                comando = New SqlCommand(strsql, conexion)


                comando.ExecuteNonQuery()

                MsgBox("Datos agregados con exito")
                conexion.Close()

                comando.Dispose()


            End If

        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub RegistroViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class