Imports MySql.Data.MySqlClient


Public Class Form1
    Public Shared userId As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbGender.Items.Add("Laki-laki")
        cbGender.Items.Add("Perempuan")

        tampilData()
        bersih()
    End Sub

    Sub tampilData()
        dgvBantuan.DataSource = GetAllData()
    End Sub


    Sub bersih()
        txtNKK.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtTelp.Clear()
        txtRekening.Clear()
        txtPendapatan.Clear()
        txtDeskripsi.Clear()
        cbGender.SelectedIndex = -1
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub
        If SimpanData(txtNKK.Text, txtNama.Text, txtAlamat.Text,
                      txtTelp.Text, txtRekening.Text, cbGender.Text,
                      Val(txtPendapatan.Text), Val(txtJumlah.Text),
                      txtDeskripsi.Text) Then

            MessageBox.Show("Data berhasil disimpan")
            tampilData()
            bersih()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Exit Sub
        If UbahData(txtNKK.Text, txtNama.Text, txtAlamat.Text,
                    txtTelp.Text, txtRekening.Text, cbGender.Text,
                    Val(txtPendapatan.Text), Val(txtJumlah.Text),
                    txtDeskripsi.Text) Then

            MessageBox.Show("Data berhasil diubah")
            tampilData()
            bersih()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNKK.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin hapus?", "Konfirmasi",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If HapusData(txtNKK.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                tampilData()
                bersih()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            tampilData()
        Else
            dgvBantuan.DataSource = SearchData(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvBantuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBantuan.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvBantuan.Rows(e.RowIndex)

            txtNKK.Text = row.Cells("nkk").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtAlamat.Text = row.Cells("alamat").Value.ToString()
            txtTelp.Text = row.Cells("no_telp").Value.ToString()
            txtRekening.Text = row.Cells("no_rekening").Value.ToString()
            cbGender.Text = row.Cells("gender").Value.ToString()
            txtPendapatan.Text = row.Cells("pendapatan").Value.ToString()
            txtJumlah.Text = row.Cells("jumlah_bantuan").Value.ToString()
            txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MessageBox.Show("Reset input?", "Konfirmasi",
                       MessageBoxButtons.YesNo) = DialogResult.Yes Then
            bersih()
            tampilData()
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()

        If txtNKK.Text = "" Then
            ErrorProvider1.SetError(txtNKK, "NKK wajib diisi")
            txtNKK.Focus()
            Return False
        End If

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Nama wajib diisi")
            txtNama.Focus()
            Return False
        End If

        If txtAlamat.Text = "" Then
            ErrorProvider1.SetError(txtAlamat, "Alamat wajib diisi")
            txtAlamat.Focus()
            Return False
        End If

        If cbGender.Text = "" Then
            ErrorProvider1.SetError(cbGender, "Pilih gender")
            cbGender.Focus()
            Return False
        End If

        Return True
    End Function
End Class


