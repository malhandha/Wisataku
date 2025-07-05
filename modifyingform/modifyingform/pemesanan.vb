Imports MySql.Data.MySqlClient

Public Class Pemesanan
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub EnsureConnectionOpen()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection("server=localhost;user id=root;password=;database=wisataku")
            End If
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
        Catch ex As MySqlException
            MsgBox("Gagal membuka koneksi: " & ex.Message)
        End Try
    End Sub

    Private Sub EnsureConnectionClose()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Function GenerateNomor() As String
        Dim nomorBaru As String
        Dim lastNomor As String = ""
        Dim lastNumberPart As Integer = 0
        EnsureConnectionOpen()
        Dim query As String = "SELECT nomor_tiket FROM tiket ORDER BY nomor_tiket DESC LIMIT 1"
        cmd = New MySqlCommand(query, conn)

        Try
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                lastNomor = reader("nomor_tiket").ToString()
                lastNumberPart = CInt(Mid(lastNomor, 5))
            End If
        Catch ex As MySqlException
            MsgBox("Error saat mengambil nomor terakhir: " & ex.Message)
        Finally
            reader.Close()
        End Try

        lastNumberPart += 1
        nomorBaru = "WSTK" & lastNumberPart.ToString("D3")
        Return nomorBaru
    End Function

    Private Sub AutoGenerateNomor()
        txtNomor.Text = GenerateNomor()
    End Sub

    Private Sub HitungTotalHarga()
        Dim harga As Integer = 0
        Dim jumlah As Integer = 0

        If kode_wisata.Text <> "" Then
            EnsureConnectionOpen()
            Dim query As String = "SELECT Harga FROM wisata WHERE Kode_Wisata = @kode_wisata"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode_wisata", kode_wisata.Text)

            Try
                reader = cmd.ExecuteReader()
                If reader.Read() Then
                    harga = Convert.ToInt64(reader("Harga"))
                End If
            Catch ex As MySqlException

            Finally
                reader.Close()
            End Try
        End If

        If txtJumlah.Text <> "" AndAlso IsNumeric(txtJumlah.Text) Then
            jumlah = Convert.ToInt64(txtJumlah.Text)
        End If

        Dim totalHarga As Integer = harga * jumlah
        txtTotal.Text = totalHarga.ToString("N2")
    End Sub

    Private Sub InsertData()
        Dim nomorGenerated As String = txtNomor.Text
        Dim nama As String = txtNama.Text
        Dim jumlah As String = txtJumlah.Text
        Dim tanggal As String = dtpTanggal.Value.ToString("yyyy-MM-dd")
        Dim kodeWisata As String = kode_wisata.Text
        Dim totalHarga As Integer = txtTotal.Text

        EnsureConnectionOpen()
        Dim query As String = "INSERT INTO tiket (nomor_tiket, nama_pembeli, kode_wisata, jumlah_tiket, tanggal_berangkat, total_harga) " &
                              "VALUES (@nomor_tiket, @nama_pembeli, @kode_wisata, @jumlah_tiket, @tanggal_berangkat, @total_harga)"
        cmd = New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@nomor_tiket", nomorGenerated)
        cmd.Parameters.AddWithValue("@nama_pembeli", nama)
        cmd.Parameters.AddWithValue("@kode_wisata", kodeWisata)
        cmd.Parameters.AddWithValue("@jumlah_tiket", jumlah)
        cmd.Parameters.AddWithValue("@tanggal_berangkat", tanggal)
        cmd.Parameters.AddWithValue("@total_harga", totalHarga)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan dengan nomor: " & nomorGenerated)
            AutoGenerateNomor()
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or kode_wisata.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Mohon lengkapi semua field.")
        Else
            InsertData()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            EnsureConnectionOpen()
            AutoGenerateNomor()
            LoadTujuanComboBox()
        Catch ex As Exception
            MsgBox("Error saat memuat form: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTujuanComboBox()
        Dim query As String = "SELECT Nama_Wisata FROM wisata"
        cmd = New MySqlCommand(query, conn)

        Try
            reader = cmd.ExecuteReader()
            While reader.Read()
                tujuan.Items.Add(reader("Nama_Wisata").ToString())
            End While
        Catch ex As MySqlException
            MsgBox("Error loading tujuan: " & ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Private Sub tujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tujuan.SelectedIndexChanged
        Dim selectedTujuan As String = tujuan.SelectedItem.ToString()
        Dim query As String = "SELECT Kode_Wisata FROM wisata WHERE Nama_Wisata = @nama_wisata"

        EnsureConnectionOpen()
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama_wisata", selectedTujuan)

        Try
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                kode_wisata.Text = reader("Kode_Wisata").ToString()
            End If
        Catch ex As MySqlException
            MsgBox("Error retrieving kode wisata: " & ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub

    Private Sub kembali_Click() Handles kembali.Click
        Dim dashboard1 As New dashboard1()
        dashboard1.Show()
        Me.Hide()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotalHarga()
    End Sub

    Private Sub kode_wisata_TextChanged(sender As Object, e As EventArgs) Handles kode_wisata.TextChanged
        HitungTotalHarga()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        EnsureConnectionClose()
    End Sub
End Class
