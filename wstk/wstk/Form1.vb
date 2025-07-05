Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Fungsi untuk mendapatkan koneksi ke database
    Private Function GetConnection() As MySqlConnection
        Dim connString As String = "server=localhost;user id=root;password=;database=wisataku"
        Dim connection As New MySqlConnection(connString)
        Try
            connection.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error Koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return connection
    End Function

    ' Fungsi untuk menampilkan laporan berdasarkan Nomor_Tiket
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NomorTiket As String = Nomor_Tiket.Text ' Ambil nilai dari input teks

        ' Validasi input Nomor_Tiket
        If String.IsNullOrWhiteSpace(NomorTiket) Then
            MessageBox.Show("Masukkan Nomor Tiket yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' DataTable untuk menampung hasil query
        Dim dt As New DataTable()
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "
            SELECT 
                t.Nomor_Tiket, 
                t.Nama_Pembeli, 
                t.Jumlah_Tiket, 
                t.Tanggal_Berangkat, 
                t.Kode_wisata, 
                t.Total_Harga
            FROM 
                tiket t
            WHERE 
                t.Nomor_Tiket = @NomorTiket"

        Try
            ' Eksekusi query dengan parameter
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NomorTiket", NomorTiket) ' Berikan nilai untuk parameter
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            ' Periksa apakah ada data yang ditemukan
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data ditemukan untuk Nomor Tiket tersebut.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Bind data ke ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' Refresh ReportViewer
            ReportViewer1.RefreshReport()

        Catch ex As MySqlException
            MessageBox.Show("Error saat mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class
