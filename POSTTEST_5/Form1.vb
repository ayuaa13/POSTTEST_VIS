Imports MySql.Data.MySqlClient


Public Class Form1
    Public Shared userId As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        cbGender.Items.AddRange(New String() {"Laki-Laki", "Perempuan"})
        tampilData()
    End Sub

    Sub tampilData()
        da = New MySqlDataAdapter("SELECT * FROM penerima_bantuan", conn)
        ds = New DataSet()
        da.Fill(ds, "penerima_bantuan")
        dgvData.DataSource = ds.Tables("penerima_bantuan")
    End Sub

    Sub bersih()
        txtNKK.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtTelp.Clear()
        txtRek.Clear()
        txtPendapatan.Clear()
        txtDeskripsi.Clear()
        cbGender.SelectedIndex = -1
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        Dim sql = "INSERT INTO penerima_bantuan VALUES (@nkk, @nama, @alamat, @telp, @rekening, @gender, @pendapatan, @bantuan, @deskripsi)"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@nkk", txtNKK.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@telp", txtTelp.Text)
        cmd.Parameters.AddWithValue("@rekening", txtRek.Text)
        cmd.Parameters.AddWithValue("@gender", cbGender.Text)
        cmd.Parameters.AddWithValue("@pendapatan", Val(txtPendapatan.Text))
        cmd.Parameters.AddWithValue("@bantuan", Val(txtBantuan.Text))
        cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil disimpan")
        tampilData()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        koneksi()
        Dim updateQuery As String = "UPDATE tb_penerima SET nama=@nama, alamat=@alamat, gender=@gender, Telp=@no_telp, Rek=@no_rek, pendapatan=@pendapatan, jumlah_nominal=@nominal, deskripsi=@deskripsi WHERE nkk=@nkk"
        cmd = New MySqlCommand(updateQuery, conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@gender", cbGender.Text)
        cmd.Parameters.AddWithValue("@no_telp", txtTelp.Text)
        cmd.Parameters.AddWithValue("@no_rek", txtRek.Text)
        cmd.Parameters.AddWithValue("@pendapatan", txtPendapatan.Text)
        cmd.Parameters.AddWithValue("@nominal", txtBantuan.Text)
        cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
        cmd.Parameters.AddWithValue("@nkk", txtNKK.Text)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah.")
            ' Panggil ulang fungsi tampilData() jika ada
        Catch ex As Exception
            MsgBox("Gagal ubah data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNKK.Text = "" Then
            MsgBox("Silakan pilih data yang ingin dihapus.")
            Exit Sub
        End If

        If MsgBox("Yakin ingin menghapus data ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                Call koneksi()
                Dim hapus As String = "DELETE FROM penerima_bantuan WHERE nkk='" & txtNKK.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus.")
                Call tampilData() ' tampil ulang datanya
                Call bersih() ' kosongkan form
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtNKK.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtTelp.Clear()
        txtRek.Clear()
        txtPendapatan.Clear()
        txtBantuan.Clear()
        txtDeskripsi.Clear()
        cbGender.SelectedIndex = -1
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvData.Rows(e.RowIndex)
            txtNKK.Text = row.Cells("nkk").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtAlamat.Text = row.Cells("alamat").Value.ToString()
            txtTelp.Text = row.Cells("telp").Value.ToString()
            txtRek.Text = row.Cells("no_rekening").Value.ToString()
            cbGender.Text = row.Cells("gender").Value.ToString()
            txtPendapatan.Text = row.Cells("pendapatan").Value.ToString()
            txtBantuan.Text = row.Cells("jumlah_nominal").Value.ToString()
            txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()
        End If
    End Sub

End Class
