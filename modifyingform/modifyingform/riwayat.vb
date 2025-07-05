Imports MySql.Data.MySqlClient

Public Class riwayat
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim dashboard1 As New dashboard1()
        dashboard1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=wisataku")
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Tidak dapat terhubung ke database: " & ex.Message)
        End Try
    End Sub

    ' Load data dari tabel tiket ke DataGridView
    Private Sub LoadData()
        Dim query As String = "SELECT * FROM tiket"
        table = New DataTable()

        Try
            cmd = New MySqlCommand(query, conn)
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            ' Menampilkan data ke DataGridView
            DataGridView1.DataSource = table
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    ' Ketika form dibuka
    Private Sub DataGridView1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=wisataku")
        Try
            conn.Open()
            LoadData()
        Catch ex As Exception
            MsgBox("Tidak dapat terhubung ke database: " & ex.Message)
        End Try
    End Sub
End Class