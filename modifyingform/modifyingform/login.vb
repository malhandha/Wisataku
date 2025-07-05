Imports MySql.Data.MySqlClient

Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection = GetConnection()
        conn.Close()
    End Sub

    Private Function AuthenticateUser(email As String, sandi As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM akun WHERE email=@Email AND sandi=@Sandi"
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Sandi", sandi)
            Try
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0
            Catch ex As MySqlException
                MessageBox.Show("Error saat login: " & ex.Message)
                Return False
            Finally
                conn.Close()
            End Try
        End Using
    End Function

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ErrorProvider1.Clear()

        Dim email = txtUser.Text
        Dim sandi = txtPass.Text
        Dim isValid = True

        If String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(sandi) Then
            ErrorProvider1.SetError(txtUser, "Email atau Password tidak boleh kosong.")
            isValid = False
        End If

        If Not isValid Then
            Exit Sub
        End If

        If Not AuthenticateUserByEmail(email) Then
            ErrorProvider1.SetError(txtUser, "Email Tidak Terdaftar.")
            Exit Sub
        End If

        If Not AuthenticateUser(email, sandi) Then
            ErrorProvider1.SetError(txtUser, "Password Salah.")
            Exit Sub
        End If

        Hide()
        Dim dashboard As New dashboard1
        dashboard.Show()
    End Sub

    Private Function AuthenticateUserByEmail(email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM akun WHERE email=@Email"
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Email", email)
            Try
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return result > 0
            Catch ex As MySqlException
                MessageBox.Show("Error saat memeriksa email: " & ex.Message)
                Return False
            Finally
                conn.Close()
            End Try
        End Using
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim register As New register
        register.Show()
        Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim login_admin As New login_admin
        login_admin.Show()
        Hide()
    End Sub
End Class
