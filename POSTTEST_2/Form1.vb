Public Class FormBuku
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String
        Dim genre As String

        judul = txtJudul.Text
        genre = txtGenre.Text

        TambahBuku(judul, genre)

        lstBuku.Items.Add(judul & " (" & genre & ")")

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer

        index = CariBuku(txtHapus.Text)

        If index <> -1 Then

            lstBuku.Items.RemoveAt(index)

            For i As Integer = index To jumlahBuku - 2

                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)

            Next

            jumlahBuku -= 1

        Else

            MessageBox.Show("Buku tidak ditemukan")

        End If

    End Sub
End Class
