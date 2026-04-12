<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvData = New DataGridView()
        txtSearch = New TextBox()
        Label1 = New Label()
        btnSimpan = New Button()
        txtPendapatan = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtBantuan = New TextBox()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtNKK = New TextBox()
        cbGender = New ComboBox()
        txtTelp = New MaskedTextBox()
        txtRek = New TextBox()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnKeluar = New Button()
        Label11 = New Label()
        txtDeskripsi = New TextBox()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(12, 418)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.Size = New Size(1085, 184)
        dgvData.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Sylfaen", 10.2F)
        txtSearch.Location = New Point(694, 368)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search"
        txtSearch.Size = New Size(403, 30)
        txtSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 10.2F)
        Label1.Location = New Point(692, 343)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 22)
        Label1.TabIndex = 2
        Label1.Text = "Cari Data"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.FlatAppearance.BorderColor = Color.SandyBrown
        btnSimpan.FlatAppearance.CheckedBackColor = Color.SandyBrown
        btnSimpan.FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.SandyBrown
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Sylfaen", 10.2F)
        btnSimpan.Location = New Point(571, 140)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 43)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Font = New Font("Sylfaen", 10.2F)
        txtPendapatan.Location = New Point(174, 314)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.PlaceholderText = "Pendapatan per bulan"
        txtPendapatan.Size = New Size(377, 30)
        txtPendapatan.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 10.2F)
        Label2.Location = New Point(12, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 22)
        Label2.TabIndex = 5
        Label2.Text = "NKK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sylfaen", 10.2F)
        Label3.Location = New Point(12, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 22)
        Label3.TabIndex = 6
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 10.2F)
        Label4.Location = New Point(307, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 22)
        Label4.TabIndex = 7
        Label4.Text = "No Rek"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 10.2F)
        Label5.Location = New Point(12, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 22)
        Label5.TabIndex = 8
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 10.2F)
        Label6.Location = New Point(12, 368)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 22)
        Label6.TabIndex = 9
        Label6.Text = "Jumlah Nominal"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sylfaen", 10.2F)
        Label7.Location = New Point(12, 317)
        Label7.Name = "Label7"
        Label7.Size = New Size(143, 22)
        Label7.TabIndex = 10
        Label7.Text = "Pendapatan/bulan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sylfaen", 10.2F)
        Label8.Location = New Point(12, 265)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 22)
        Label8.TabIndex = 11
        Label8.Text = "No.HP"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.BurlyWood
        Label9.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(-2, 1)
        Label9.Name = "Label9"
        Label9.Size = New Size(1120, 92)
        Label9.TabIndex = 12
        Label9.Text = "BLT Samarinda"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sylfaen", 10.2F)
        Label10.Location = New Point(322, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 22)
        Label10.TabIndex = 13
        Label10.Text = "Gender"
        ' 
        ' txtBantuan
        ' 
        txtBantuan.Font = New Font("Sylfaen", 10.2F)
        txtBantuan.Location = New Point(174, 368)
        txtBantuan.Name = "txtBantuan"
        txtBantuan.PlaceholderText = "Nominal"
        txtBantuan.Size = New Size(377, 30)
        txtBantuan.TabIndex = 14
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Sylfaen", 10.2F)
        txtNama.Location = New Point(174, 156)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(377, 30)
        txtNama.TabIndex = 15
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Sylfaen", 10.2F)
        txtAlamat.Location = New Point(174, 206)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(377, 30)
        txtAlamat.TabIndex = 16
        ' 
        ' txtNKK
        ' 
        txtNKK.Font = New Font("Sylfaen", 10.2F)
        txtNKK.Location = New Point(174, 108)
        txtNKK.Name = "txtNKK"
        txtNKK.PlaceholderText = "Nomor KK"
        txtNKK.Size = New Size(139, 30)
        txtNKK.TabIndex = 17
        ' 
        ' cbGender
        ' 
        cbGender.Font = New Font("Sylfaen", 10.2F)
        cbGender.FormattingEnabled = True
        cbGender.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        cbGender.Location = New Point(400, 107)
        cbGender.Name = "cbGender"
        cbGender.Size = New Size(151, 30)
        cbGender.TabIndex = 18
        ' 
        ' txtTelp
        ' 
        txtTelp.Font = New Font("Sylfaen", 10.2F)
        txtTelp.Location = New Point(174, 265)
        txtTelp.Mask = "0000-0000-0000"
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(125, 30)
        txtTelp.TabIndex = 19
        ' 
        ' txtRek
        ' 
        txtRek.Font = New Font("Sylfaen", 10.2F)
        txtRek.Location = New Point(376, 268)
        txtRek.Name = "txtRek"
        txtRek.PlaceholderText = "Nomor Rekening"
        txtRek.Size = New Size(175, 30)
        txtRek.TabIndex = 20
        ' 
        ' btnUbah
        ' 
        btnUbah.FlatAppearance.BorderColor = Color.SandyBrown
        btnUbah.FlatAppearance.CheckedBackColor = Color.SandyBrown
        btnUbah.FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod
        btnUbah.FlatAppearance.MouseOverBackColor = Color.SandyBrown
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Sylfaen", 10.2F)
        btnUbah.Location = New Point(571, 243)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 44)
        btnUbah.TabIndex = 21
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.FlatAppearance.BorderColor = Color.SandyBrown
        btnHapus.FlatAppearance.CheckedBackColor = Color.SandyBrown
        btnHapus.FlatAppearance.MouseDownBackColor = Color.DarkGoldenrod
        btnHapus.FlatAppearance.MouseOverBackColor = Color.SandyBrown
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Sylfaen", 10.2F)
        btnHapus.Location = New Point(571, 336)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 40)
        btnHapus.TabIndex = 22
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.FlatAppearance.BorderColor = Color.Maroon
        btnBatal.FlatAppearance.MouseDownBackColor = Color.Maroon
        btnBatal.FlatAppearance.MouseOverBackColor = Color.Red
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Sylfaen", 10.8F)
        btnBatal.Location = New Point(743, 268)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(128, 46)
        btnBatal.TabIndex = 23
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.FlatAppearance.BorderColor = Color.Maroon
        btnKeluar.FlatAppearance.MouseDownBackColor = Color.Maroon
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.Red
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Sylfaen", 10.8F)
        btnKeluar.Location = New Point(925, 268)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(128, 46)
        btnKeluar.TabIndex = 24
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sylfaen", 10.2F)
        Label11.Location = New Point(694, 113)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 22)
        Label11.TabIndex = 25
        Label11.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(694, 138)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(403, 98)
        txtDeskripsi.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(1111, 614)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label11)
        Controls.Add(btnKeluar)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(txtRek)
        Controls.Add(txtTelp)
        Controls.Add(cbGender)
        Controls.Add(txtNKK)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(txtBantuan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPendapatan)
        Controls.Add(btnSimpan)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(dgvData)
        Name = "Form1"
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBantuan As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNKK As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents txtTelp As MaskedTextBox
    Friend WithEvents txtRek As TextBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDeskripsi As TextBox

End Class
