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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        tclDatautama = New TabPage()
        Label2 = New Label()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpTanggal = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        tclKontakinfo = New TabPage()
        Label3 = New Label()
        mtbTelepon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        tclProfil = New TabPage()
        cbTraveling = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbEditing = New CheckBox()
        cbDesign = New CheckBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbMembaca = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        btnCetak = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tclDatautama.SuspendLayout()
        tclKontakinfo.SuspendLayout()
        tclProfil.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ButtonFace
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("SimSun-ExtG", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 28)
        Label1.TabIndex = 1
        Label1.Text = "Kartu Komunitas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(35, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tclDatautama)
        TabControl1.Controls.Add(tclKontakinfo)
        TabControl1.Controls.Add(tclProfil)
        TabControl1.Location = New Point(70, 144)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(540, 271)
        TabControl1.TabIndex = 3
        ' 
        ' tclDatautama
        ' 
        tclDatautama.Controls.Add(Label2)
        tclDatautama.Controls.Add(cmbKomunitas)
        tclDatautama.Controls.Add(rbPerempuan)
        tclDatautama.Controls.Add(rbLaki)
        tclDatautama.Controls.Add(dtpTanggal)
        tclDatautama.Controls.Add(txtID)
        tclDatautama.Controls.Add(txtNama)
        tclDatautama.Location = New Point(4, 29)
        tclDatautama.Name = "tclDatautama"
        tclDatautama.Padding = New Padding(3)
        tclDatautama.Size = New Size(532, 238)
        tclDatautama.TabIndex = 0
        tclDatautama.Text = "Data Utama"
        tclDatautama.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(251, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 12)
        Label2.TabIndex = 12
        Label2.Text = "*Masukkan Tanggal Lahir Anda"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.Items.AddRange(New Object() {"Programming", "", "Design", "", "Gaming", "", "Multimedia"})
        cmbKomunitas.Location = New Point(311, 43)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(151, 28)
        cmbKomunitas.TabIndex = 11
        cmbKomunitas.Tag = ""
        cmbKomunitas.Text = "Komunitas"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(285, 172)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 10
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(97, 172)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 9
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(251, 104)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(250, 27)
        dtpTanggal.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(32, 104)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "  ID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(32, 44)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 6
        ' 
        ' tclKontakinfo
        ' 
        tclKontakinfo.Controls.Add(Label3)
        tclKontakinfo.Controls.Add(mtbTelepon)
        tclKontakinfo.Controls.Add(txtAlamat)
        tclKontakinfo.Controls.Add(txtEmail)
        tclKontakinfo.Location = New Point(4, 29)
        tclKontakinfo.Name = "tclKontakinfo"
        tclKontakinfo.Padding = New Padding(3)
        tclKontakinfo.Size = New Size(532, 238)
        tclKontakinfo.TabIndex = 1
        tclKontakinfo.Text = "Kontak & Info"
        tclKontakinfo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(49, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 12)
        Label3.TabIndex = 13
        Label3.Text = "*Masukkan Nomor HP Anda"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(49, 26)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(247, 27)
        mtbTelepon.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(49, 162)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(247, 27)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(49, 91)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(247, 27)
        txtEmail.TabIndex = 1
        ' 
        ' tclProfil
        ' 
        tclProfil.Controls.Add(cbTraveling)
        tclProfil.Controls.Add(cbOlahraga)
        tclProfil.Controls.Add(cbMusik)
        tclProfil.Controls.Add(cbEditing)
        tclProfil.Controls.Add(cbDesign)
        tclProfil.Controls.Add(cbGaming)
        tclProfil.Controls.Add(cbCoding)
        tclProfil.Controls.Add(cbMembaca)
        tclProfil.Controls.Add(GroupBox1)
        tclProfil.Controls.Add(btnBrowse)
        tclProfil.Controls.Add(picFoto)
        tclProfil.Location = New Point(4, 29)
        tclProfil.Name = "tclProfil"
        tclProfil.Padding = New Padding(3)
        tclProfil.Size = New Size(532, 238)
        tclProfil.TabIndex = 2
        tclProfil.Text = "Profil & Aktivitas"
        tclProfil.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(438, 149)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(91, 24)
        cbTraveling.TabIndex = 10
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(340, 149)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 9
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(265, 149)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 8
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbEditing
        ' 
        cbEditing.AutoSize = True
        cbEditing.Location = New Point(181, 149)
        cbEditing.Name = "cbEditing"
        cbEditing.Size = New Size(78, 24)
        cbEditing.TabIndex = 7
        cbEditing.Text = "Editing"
        cbEditing.UseVisualStyleBackColor = True
        ' 
        ' cbDesign
        ' 
        cbDesign.AutoSize = True
        cbDesign.Location = New Point(449, 119)
        cbDesign.Name = "cbDesign"
        cbDesign.Size = New Size(77, 24)
        cbDesign.TabIndex = 6
        cbDesign.Text = "Design"
        cbDesign.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(366, 119)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 5
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(281, 119)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 4
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(181, 119)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 3
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Location = New Point(187, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(322, 80)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(218, 30)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(110, 30)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.RightToLeft = RightToLeft.No
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(15, 30)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(49, 165)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.White
        picFoto.Location = New Point(32, 27)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(124, 116)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(649, 263)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(93, 53)
        btnCetak.TabIndex = 11
        btnCetak.Text = "Simpan dan Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetak)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tclDatautama.ResumeLayout(False)
        tclDatautama.PerformLayout()
        tclKontakinfo.ResumeLayout(False)
        tclKontakinfo.PerformLayout()
        tclProfil.ResumeLayout(False)
        tclProfil.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tclDatautama As TabPage
    Friend WithEvents tclKontakinfo As TabPage
    Friend WithEvents tclProfil As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbEditing As CheckBox
    Friend WithEvents cbDesign As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label3 As Label

End Class
