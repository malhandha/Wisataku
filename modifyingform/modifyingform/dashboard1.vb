
Public Class dashboard1
    Private Sub borobudur_Click(sender As Object, e As EventArgs)
        ' Membuat instance dari Form3
        Dim form3 As New dashboard2

        ' Menampilkan Form3
        form3.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub bali_Click(sender As Object, e As EventArgs)
        ' Membuat instance dari Form3
        Dim form4 As New dashboard2

        ' Menampilkan Form3
        form4.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim dashboard2 As New dashboard2

        ' Menampilkan Form3
        dashboard2.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dashboard3 As New dashboard3

        ' Menampilkan Form3
        dashboard3.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim dashboard2 As New dashboard2

        ' Menampilkan Form3
        dashboard2.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim dashboard3 As New dashboard3

        ' Menampilkan Form3
        dashboard3.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        MessageBox.Show("Raja Ampat adalah sebuah kepulauan yang terletak di ujung barat Papua, Indonesia, tepatnya di Provinsi Papua Barat Daya. Kepulauan ini terdiri dari lebih dari 1.500 pulau kecil, gundukan karang, dan empat pulau utama: Waigeo, Misool, Salawati, dan Batanta. Terkenal dengan keindahan alam bawah lautnya, Raja Ampat adalah salah satu destinasi menyelam terbaik di dunia, dengan terumbu karang yang masih sangat terjaga dan beragam spesies laut, termasuk ikan, karang, dan makhluk laut langka.")
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles search.Click
        Dim searchTerm As String = Guna2TextBox1.Text.Trim().ToLower()

        ' Cek nilai yang dimasukkan dan arahkan ke form yang sesuai
        Select Case searchTerm
            Case "rajaampat"
                Dim dashboard1 As New dashboard1()
                dashboard1.Show()
                Me.Hide()  ' Menyembunyikan form saat ini

            Case "borobudur"
                Dim dashboard2 As New dashboard2()
                dashboard2.Show()
                Me.Hide()  ' Menyembunyikan form saat ini

            Case "bali"
                Dim dashboard3 As New dashboard3()
                dashboard3.Show()
                Me.Hide()  ' Menyembunyikan form saat ini

            Case Else
                MessageBox.Show("Lokasi tidak ditemukan. Silakan coba lagi.")
        End Select
    End Sub

    Private Sub pesan_Click(sender As Object, e As EventArgs) Handles pesan.Click
        Dim pemesanan As New pemesanan
        pemesanan.Show()
        Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim riwayat As New riwayat
        riwayat.Show()
        Hide()
    End Sub
End Class