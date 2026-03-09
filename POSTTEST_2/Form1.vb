Public Class Form1
    Function FormatBuku(judul As String, genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Sub TambahBuku(ByRef judul As String, ByVal genre As String)
        daftarBuku(indeks) = FormatBuku(judul, genre)
        lstBuku.Items.Add(daftarBuku(indeks))
        indeks += 1
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulTambah.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        If judul <> "" And genre <> "" Then
            TambahBuku(judul, genre)
            txtJudulTambah.Clear()
            txtGenre.Clear()
        Else
            MessageBox.Show("Judul dan Genre harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtJudulHapus.Text.Trim()
        Dim ditemukan As Boolean = False

        For i As Integer = 0 To indeks - 1
            If daftarBuku(i) IsNot Nothing AndAlso daftarBuku(i).StartsWith(judulHapus & " ") Then
                lstBuku.Items.Remove(daftarBuku(i))
                daftarBuku(i) = Nothing
                ditemukan = True
                Exit For
            End If
        Next

        If Not ditemukan Then
            MessageBox.Show("Buku tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtJudulHapus.Clear()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lblHapus_Click(sender As Object, e As EventArgs) Handles lblHapus.Click

    End Sub
End Class
