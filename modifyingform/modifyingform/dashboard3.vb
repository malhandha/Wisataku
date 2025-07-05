Public Class dashboard3
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("halo")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim dashboard1 As New dashboard1

        ' Menampilkan Form3
        dashboard1.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim dashboard2 As New dashboard2

        ' Menampilkan Form3
        dashboard2.Show

        ' (Opsional) Menyembunyikan form saat ini
        Hide
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim dashboard1 As New dashboard1

        ' Menampilkan Form3
        dashboard1.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dashboard2 As New dashboard2

        ' Menampilkan Form3
        dashboard2.Show()

        ' (Opsional) Menyembunyikan form saat ini
        Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        MessageBox.Show("Bali, pulau di Indonesia yang dikenal sebagai Pulau Dewata, terkenal dengan keindahan alamnya, pantai eksotis, serta budaya Hindu yang kuat. Pulau ini kaya akan tradisi seni, tarian, dan musik, serta dipenuhi pura-pura megah seperti Pura Besakih. Upacara adat yang dilakukan secara rutin menambah daya tarik budaya Bali, menjadikannya destinasi wisata dunia untuk keindahan alam dan kekayaan budayanya.")
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
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
        Dim pemesanan As New pemesanan()
        pemesanan.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim riwayat As New riwayat
        riwayat.Show()
        Hide()
    End Sub
End Class