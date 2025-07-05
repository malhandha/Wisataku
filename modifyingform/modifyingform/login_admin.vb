Imports MySql.Data.MySqlClient

Public Class login_admin
    Private Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=wisataku")
    End Function

    Private Function AuthenticateUser(email_admin As String, password_admin As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM admin WHERE email_admin=@Email_admin AND password_admin=@Password_admin"
        Using conn As MySqlConnection = GetConnection()
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Email_admin", email_admin)
                command.Parameters.AddWithValue("@Password_admin", password_admin)
                Try
                    conn.Open()
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return result > 0
                Catch ex As MySqlException
                    MessageBox.Show("Error saat login: " & ex.Message)
                    Return False
                Finally
                    conn.Close()
                End Try
            End Using
        End Using
    End Function

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ErrorProvider1.Clear()

        Dim email_admin = emailadmin.Text
        Dim password_admin = passadmin.Text

        If String.IsNullOrEmpty(email_admin) Or String.IsNullOrEmpty(password_admin) Then
            ErrorProvider1.SetError(emailadmin, "Email atau Password tidak boleh kosong.")
            Return
        End If

        If Not AuthenticateUser(email_admin, password_admin) Then
            ErrorProvider1.SetError(passadmin, "Email atau Password salah.")
            Return
        End If

        Hide()
        Dim adminakun As New adminakun
        adminakun.Show()
    End Sub
End Class
