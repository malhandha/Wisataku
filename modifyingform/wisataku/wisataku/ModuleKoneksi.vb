Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    'Deklarasi variabel koneksi string untuk digunakan dalam seluruh aplikasi
    Private connectionString As String = "server=localhost;user id=root;" & "password=;database=wisataku;"
    ' Fungsi untuk mendapatkan objek MySqlConnection
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            ' Buka koneksi
            conn.Open()
        Catch ex As MySqlException
            'Jika gagal koneksi, tampilkan pesan error
            MessageBox.Show("Error: " & ex.Message)
        End Try
        'Kembalikan objek koneksi yang sudah dibuka
        Return conn
    End Function
End Module
