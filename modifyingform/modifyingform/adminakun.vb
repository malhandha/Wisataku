Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class adminakun
    Private dataAdapter As MySqlDataAdapter
    Private dataSet As DataSet

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim query As String = "INSERT INTO akun (email, nama, sandi) VALUES ('" & email.Text & "','" & nama.Text & "','" & sandi.Text & "')"
        Dim selectQuery As String = "SELECT * FROM akun"

        ' Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(query, conn)
        dataSet = New DataSet()

        Try
            dataAdapter.Fill(dataSet, "akun")
            MsgBox("Data berhasil disimpan")
            dataSet.Clear()
            dataAdapter = New MySqlDataAdapter(selectQuery, conn)
            dataAdapter.Fill(dataSet, "akun")
            DataGridView1.DataSource = dataSet.Tables("akun").DefaultView
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            ' Pastikan koneksi ditutup
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            email.Text = row.Cells("email").Value.ToString()
            nama.Text = row.Cells("nama").Value.ToString()
            sandi.Text = row.Cells("sandi").Value.ToString()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Sub LoadData()
        Dim selectQuery As String = "SELECT * FROM akun"
        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(selectQuery, conn)
        dataSet = New DataSet()

        Try
            dataAdapter.Fill(dataSet, "akun")
            DataGridView1.DataSource = dataSet.Tables("akun")
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Ubah_Click(sender As Object, e As EventArgs) Handles ubah.Click
        Dim query As String = "UPDATE akun SET nama = '" & nama.Text & "', sandi = '" & sandi.Text & "' WHERE email = '" & email.Text & "'"
        Dim selectQuery As String = "SELECT * FROM akun"

        ' Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(query, conn)
        dataSet = New DataSet()

        Try
            dataAdapter.Fill(dataSet, "akun")
            MsgBox("Data berhasil diupdate")
            dataSet.Clear()
            dataAdapter = New MySqlDataAdapter(selectQuery, conn)
            dataAdapter.Fill(dataSet, "akun")
            DataGridView1.DataSource = dataSet.Tables("akun").DefaultView
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Dim query As String = "DELETE FROM akun WHERE email = '" & email.Text & "'"
        Dim selectQuery As String = "SELECT * FROM akun"

        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(query, conn)
        dataSet = New DataSet()

        Try
            dataAdapter.Fill(dataSet, "akun")
            MsgBox("Data berhasil dihapus")
            dataSet.Clear()
            dataAdapter = New MySqlDataAdapter(selectQuery, conn)
            dataAdapter.Fill(dataSet, "akun")
            DataGridView1.DataSource = dataSet.Tables("akun").DefaultView
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim login As New login()
        login.Show()
        Me.Hide()
    End Sub
End Class
