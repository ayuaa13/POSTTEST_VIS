Imports System.IO

Public Class Form1
    Dim fotoPath As String = ""

    Function HanyaHuruf(input As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z ]+$")
    End Function

    Function HanyaAngka(input As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(input, "^\d+$")
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;"

        If openFile.ShowDialog() = DialogResult.OK Then
            fotoPath = openFile.FileName
            picProfile.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or txtAlamat.Text = "" Or
            (rbLaki.Checked = False And rbPerempuan.Checked = False) Or fotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not HanyaHuruf(txtNama.Text) Then
            MessageBox.Show("Nama hanya boleh berisi huruf!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not HanyaAngka(txtUmur.Text) Then
            MessageBox.Show("Umur hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not HanyaAngka(txtNoTelp.Text) Then
            MessageBox.Show("Nomor Telepon hanya boleh berisi angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jenisKelamin As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")

        Dim hobiList As String = ""
        For Each ctrl As Control In grpHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.Checked Then
                    hobiList &= chk.Text & ", "
                End If
            End If
        Next

        If hobiList.Length > 2 Then
            hobiList = hobiList.Substring(0, hobiList.Length - 2)
        End If

        Dim formKartu As New Form2
        formKartu.txtKartuNama.Text = txtNama.Text
        formKartu.txtKartuUmur.Text = txtUmur.Text & " Tahun"
        formKartu.txtKartuNoTelp.Text = txtNoTelp.Text
        formKartu.txtKartuAlamat.Text = txtAlamat.Text
        formKartu.txtKartuJK.Text = jenisKelamin
        formKartu.txtKartuTglLahir.Text = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        formKartu.txtKartuHobi.Text = hobiList

        formKartu.picKartuProfile.Image = picProfile.Image

        formKartu.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged

    End Sub
End Class
