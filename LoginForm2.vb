Imports System.Data.SqlClient
Public Class LoginForm2

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim comando As SqlCommand
            Dim datos As SqlDataReader
            Dim conexion As New SqlConnection("server=DESKTOP-DG9IUDO\JOSEMANUEL;Initial Catalog=farsiman;Integrated Security=true;")
            Dim strsql As String = ""

            conexion.Open()

            strsql = "select * from tblUsuarios where username = '" & UsernameTextBox.Text & "' and clave = '" & PasswordTextBox.Text & "'"

            comando = New SqlCommand(strsql, conexion)


            datos = comando.ExecuteReader
            If datos.HasRows Then
                usuarioname = UsernameTextBox.Text
                HabilitarOpcionesMenuPrincipal()

                MsgBox("Bienvenido al sistema")
                Me.Close()
            Else
                MsgBox("Usuario / Password incorrecto")
            End If

            conexion.Close()
            datos.Close()
            comando.Dispose()

        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
    Private Sub HabilitarOpcionesMenuPrincipal()
        Form1.MenuStrip1.Items(1).Enabled = True
        Form1.MenuStrip1.Items(2).Enabled = True

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

