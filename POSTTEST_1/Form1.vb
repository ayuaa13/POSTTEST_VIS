Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If Double.TryParse(txtIPSemester.Text, ipSemester) And ipSemester >= 0 And ipSemester <= 4 Then
            totalIP += ipSemester
            jumlahSemester += 1

            Dim ipKumulatif As Double = totalIP / jumlahSemester
            txtIPKumulatif.Text = ipKumulatif.ToString("0.00")

            ' Tampilkan predikat
            If ipKumulatif >= 3.01 Then
                lblPredikat.Text = "hoki"
            ElseIf ipKumulatif >= 2.76 Then
                lblPredikat.Text = "b aja"
            ElseIf ipKumulatif >= 2.0 Then
                lblPredikat.Text = "bodoh"
            Else
                lblPredikat.Text = "belajar kids"
            End If

            txtIPSemester.Clear()
            txtIPSemester.Focus()
        Else
            MessageBox.Show("Masukkan IP antara 0 hingga 4", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblPredikat.Text = ""
        txtIPSemester.Focus()
    End Sub

End Class