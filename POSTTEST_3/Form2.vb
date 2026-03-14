Public Class Form2

    Public nama As String
    Public umur As String
    Public telepon As String
    Public alamat As String
    Public gender As String
    Public hobby As String
    Public tanggal As String
    Public foto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = nama
        lblUmur.Text = umur
        lblTelepon.Text = telepon
        lblAlamat.Text = alamat
        lblGender.Text = gender
        lblTanggal.Text = tanggal

        pictureBoxFoto.Image = foto

        Dim hobbyList() As String = hobby.Split(",")

        Dim hasil As String = ""

        For Each h As String In hobbyList
            hasil &= "• " & h.Trim() & vbCrLf
        Next

        lblHobby.Text = hasil.Trim()

    End Sub

End Class