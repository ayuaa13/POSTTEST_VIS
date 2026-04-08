Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtNama, "")
        End If

        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtID, "")
        End If

        If cmbKomunitas.Text = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(cmbKomunitas, "")
        End If

        If txtEmail.Text = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtEmail, "")
        End If

        If txtAlamat.Text = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
        Else
            ErrorProvider1.SetError(txtAlamat, "")
        End If

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format tidak lengkap")
        Else
            ErrorProvider1.SetError(mtbTelepon, "")
        End If

        Dim cek As Boolean = False

        If cbMembaca.Checked Or cbCoding.Checked Or cbGaming.Checked Or cbDesign.Checked Or cbEditing.Checked Or cbMusik.Checked Or cbOlahraga.Checked Or cbTraveling.Checked Then
            cek = True
        End If

        If cek = False Then
            MessageBox.Show("Pilih minimal 1 aktivitas")
        End If

        Dim hobi As String = ""

        If cbMembaca.Checked Then hobi &= "Membaca, "
        If cbCoding.Checked Then hobi &= "Coding, "
        If cbGaming.Checked Then hobi &= "Gaming, "
        If cbDesign.Checked Then hobi &= "Design, "
        If cbEditing.Checked Then hobi &= "Editing, "
        If cbMusik.Checked Then hobi &= "Musik, "
        If cbOlahraga.Checked Then hobi &= "Olahraga, "
        If cbTraveling.Checked Then hobi &= "Traveling, "

        Dim form2 As New FormKartu

        form2.nama = txtNama.Text
        form2.id = txtID.Text
        form2.komunitas = cmbKomunitas.Text
        form2.telepon = mtbTelepon.Text
        form2.hobby = hobi
        form2.foto = picFoto.Image

        form2.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text File|*.txt"
        SaveFileDialog1.ShowDialog()

        Dim data As String
        data = txtNama.Text & vbCrLf &
               txtID.Text & vbCrLf &
               cmbKomunitas.Text & vbCrLf &
               mtbTelepon.Text & vbCrLf &
               txtEmail.Text & vbCrLf &
               txtAlamat.Text

        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, data, False)

        MessageBox.Show("Data berhasil disimpan")
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()

        Dim isi As String
        isi = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        MessageBox.Show(isi)
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim f As New FormKartu
        f.Show()
    End Sub
End Class
