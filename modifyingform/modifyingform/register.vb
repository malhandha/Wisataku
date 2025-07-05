Imports MySql.Data.MySqlClient

Public Class register

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        ErrorProvider1.Clear()

        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(nama.Text) Then
            ErrorProvider1.SetError(nama, "Nama tidak boleh kosong.")
            isValid = False
        End If

        If String.IsNullOrEmpty(email.Text) Then
            ErrorProvider1.SetError(email, "Email tidak boleh kosong.")
            isValid = False
        ElseIf Not email.Text.EndsWith("@gmail.com") Then
            ErrorProvider1.SetError(email, "Email harus diakhiri dengan '@gmail.com'.")
            isValid = False
        End If

        If String.IsNullOrEmpty(sandi.Text) Then
            ErrorProvider1.SetError(sandi, "Password tidak boleh kosong.")
            isValid = False
        ElseIf sandi.Text.Length < 8 Then
            ErrorProvider1.SetError(sandi, "Password harus minimal 8 karakter.")
            isValid = False
        End If

        If sandi.Text <> ksandi.Text Then
            ErrorProvider1.SetError(ksandi, "Password tidak cocok.")
            isValid = False
        End If

        If Not isValid Then
            Exit Sub
        End If

        Try
            InsertUserToDatabase(nama.Text, email.Text, sandi.Text)
        Catch ex As ArgumentException
            ErrorProvider1.SetError(email, "Error: " & ex.Message)
        Catch ex As Exception
            ErrorProvider1.SetError(email, "General Error: " & ex.Message)
        End Try
    End Sub


    Private Sub InsertUserToDatabase(ByVal nama As String, ByVal email As String, ByVal password As String)
        ' Definisikan koneksi ke database wisataku
        Dim connString As String = "Server=localhost;Database=wisataku;Uid=root;Pwd=;" ' Ganti dengan kredensial MySQL-mu
        Dim conn As New MySqlConnection(connString)

        Try
            ' Buka koneksi
            conn.Open()

            ' Buat query untuk memasukkan data ke tabel akun
            Dim query As String = "INSERT INTO akun (email, nama, sandi) VALUES (@Email, @Nama, @Sandi)"

            ' Buat command dan tambahkan parameter
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Nama", nama)
            cmd.Parameters.AddWithValue("@Sandi", password)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Selamat akun berhasil terdaftar")
            Dim login As New login()
            login.Show()
            Me.Hide()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim login As New login()
        login.Show()
        Me.Hide()
    End Sub
End Class