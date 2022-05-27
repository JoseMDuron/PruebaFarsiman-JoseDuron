Public Class Form1
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Try
            LoginForm2.MdiParent = Me
            LoginForm2.Show()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MenuStrip1.Items(1).Enabled = False
            MenuStrip1.Items(2).Enabled = False

        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub

    Private Sub NuevoRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRegistroToolStripMenuItem.Click
        Try
            RegistroViajes.MdiParent = Me
            RegistroViajes.Show()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try

    End Sub



    Private Sub ReporteDeViajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeViajesToolStripMenuItem.Click

        Try
            Reportes.MdiParent = Me
            Reportes.Show()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try

    End Sub


End Class
