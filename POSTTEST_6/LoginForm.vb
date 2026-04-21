Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "123" Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username dan Password Salah")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
