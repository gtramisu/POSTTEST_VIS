Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double
        ipSemester = Val(txtIpSemester.Text)

        totalIP += ipSemester
        jumlahSemester += 1

        Dim ipk As Double
        ipk = totalIP / jumlahSemester

        txtIPK.Text = Format(ipk, "0.00")

        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = "-"
        End If

        txtIpSemester.Clear()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPK.Clear()
        lblPredikat.Text = "-"
    End Sub

    Private Sub lblPredikat_Click(sender As Object, e As EventArgs) Handles lblPredikat.Click

    End Sub
End Class