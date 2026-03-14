Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim open As New OpenFileDialog

        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            pictureBoxFoto.Image = Image.FromFile(open.FileName)
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress

        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub


    Private Function cekHobby() As Boolean

        For Each c As Control In GroupBoxHobby.Controls
            If TypeOf c Is CheckBox Then
                If CType(c, CheckBox).Checked Then
                    Return True
                End If
            End If
        Next

        Return False

    End Function


    Private Function ambilHobby() As String

        Dim listHobby As New List(Of String)

        For Each c As Control In GroupBoxHobby.Controls

            If TypeOf c Is CheckBox Then

                Dim cb As CheckBox = CType(c, CheckBox)

                If cb.Checked Then
                    listHobby.Add(cb.Text)
                End If

            End If

        Next

        Return String.Join(", ", listHobby)

    End Function



    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or
           txtUmur.Text = "" Or
           txtTelepon.Text = "" Or
           txtAlamat.Text = "" Or
           pictureBoxFoto.Image Is Nothing Or
           Not (RbLaki.Checked Or rbPerempuan.Checked) Or
           cekHobby() = False Then

            MessageBox.Show("Inputan tidak boleh kosong")

            Exit Sub

        End If


        Dim gender As String

        If RbLaki.Checked Then
            gender = "Laki-laki"
        Else
            gender = "Perempuan"
        End If


        Dim hasil As New Form2

        hasil.nama = txtNama.Text
        hasil.umur = txtUmur.Text
        hasil.telepon = txtTelepon.Text
        hasil.alamat = txtAlamat.Text
        hasil.gender = gender
        hasil.hobby = ambilHobby()
        hasil.tanggal = dtpTanggal.Text
        hasil.foto = pictureBoxFoto.Image

        hasil.Show()

    End Sub

End Class