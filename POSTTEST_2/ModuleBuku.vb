Public Module ModuleBuku

    'array menyimpan buku
    Public daftarBuku(99, 1) As String

    'jumlah buku
    Public jumlahBuku As Integer = 0

    'procedure tambah buku
    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    'function mencari buku
    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower = judul.ToLower Then
                Return i
            End If
        Next

        Return -1
    End Function

End Module