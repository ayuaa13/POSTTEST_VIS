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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfile = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtNoTelp = New TextBox()
        grpJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobi = New GroupBox()
        chkHobi10 = New CheckBox()
        chkHobi9 = New CheckBox()
        chkHobi8 = New CheckBox()
        chkHobi7 = New CheckBox()
        chkHobi6 = New CheckBox()
        chkHobi5 = New CheckBox()
        chkHobi4 = New CheckBox()
        chkHobi3 = New CheckBox()
        chkHobi2 = New CheckBox()
        chkHobi1 = New CheckBox()
        btnCetak = New Button()
        dtpTanggalLahir = New DateTimePicker()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = SystemColors.Window
        picProfile.Location = New Point(44, 19)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(250, 208)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SandyBrown
        btnBrowse.Font = New Font("Simplified Arabic Fixed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(106, 244)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 38)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Info
        Label1.Font = New Font("Simplified Arabic Fixed", 9F)
        Label1.Location = New Point(344, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 21)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Info
        Label2.Font = New Font("Simplified Arabic Fixed", 9F)
        Label2.Location = New Point(344, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 21)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Info
        Label3.Font = New Font("Simplified Arabic Fixed", 9F)
        Label3.Location = New Point(344, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("Simplified Arabic Fixed", 9F)
        Label4.Location = New Point(344, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 21)
        Label4.TabIndex = 5
        Label4.Text = "No. Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Info
        Label5.Font = New Font("Simplified Arabic Fixed", 9F)
        Label5.Location = New Point(344, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 21)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Simplified Arabic Fixed", 9F)
        txtNama.Location = New Point(534, 12)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(380, 24)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("Simplified Arabic Fixed", 9F)
        txtUmur.Location = New Point(534, 49)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(380, 24)
        txtUmur.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Simplified Arabic Fixed", 9F)
        txtAlamat.Location = New Point(534, 174)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(380, 24)
        txtAlamat.TabIndex = 9
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Simplified Arabic Fixed", 9F)
        txtNoTelp.Location = New Point(534, 130)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(380, 24)
        txtNoTelp.TabIndex = 10
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.BackColor = SystemColors.Info
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Controls.Add(rbLaki)
        grpJenisKelamin.Font = New Font("Simplified Arabic Fixed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpJenisKelamin.Location = New Point(344, 229)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(570, 59)
        grpJenisKelamin.TabIndex = 12
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(434, 23)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(112, 25)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(27, 23)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(112, 25)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobi
        ' 
        grpHobi.BackColor = SystemColors.Info
        grpHobi.Controls.Add(chkHobi10)
        grpHobi.Controls.Add(chkHobi9)
        grpHobi.Controls.Add(chkHobi8)
        grpHobi.Controls.Add(chkHobi7)
        grpHobi.Controls.Add(chkHobi6)
        grpHobi.Controls.Add(chkHobi5)
        grpHobi.Controls.Add(chkHobi4)
        grpHobi.Controls.Add(chkHobi3)
        grpHobi.Controls.Add(chkHobi2)
        grpHobi.Controls.Add(chkHobi1)
        grpHobi.Font = New Font("Simplified Arabic Fixed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpHobi.Location = New Point(44, 294)
        grpHobi.Name = "grpHobi"
        grpHobi.Size = New Size(870, 134)
        grpHobi.TabIndex = 13
        grpHobi.TabStop = False
        grpHobi.Text = "Hobi"
        ' 
        ' chkHobi10
        ' 
        chkHobi10.AutoSize = True
        chkHobi10.Location = New Point(769, 88)
        chkHobi10.Name = "chkHobi10"
        chkHobi10.Size = New Size(68, 25)
        chkHobi10.TabIndex = 9
        chkHobi10.Text = "Judi"
        chkHobi10.UseVisualStyleBackColor = True
        ' 
        ' chkHobi9
        ' 
        chkHobi9.AutoSize = True
        chkHobi9.Location = New Point(769, 24)
        chkHobi9.Name = "chkHobi9"
        chkHobi9.Size = New Size(77, 25)
        chkHobi9.TabIndex = 8
        chkHobi9.Text = "Musik"
        chkHobi9.UseVisualStyleBackColor = True
        ' 
        ' chkHobi8
        ' 
        chkHobi8.AutoSize = True
        chkHobi8.Location = New Point(610, 88)
        chkHobi8.Name = "chkHobi8"
        chkHobi8.Size = New Size(86, 25)
        chkHobi8.TabIndex = 7
        chkHobi8.Text = "Racing"
        chkHobi8.UseVisualStyleBackColor = True
        ' 
        ' chkHobi7
        ' 
        chkHobi7.AutoSize = True
        chkHobi7.Location = New Point(610, 24)
        chkHobi7.Name = "chkHobi7"
        chkHobi7.Size = New Size(95, 25)
        chkHobi7.TabIndex = 6
        chkHobi7.Text = "Kuliner"
        chkHobi7.UseVisualStyleBackColor = True
        ' 
        ' chkHobi6
        ' 
        chkHobi6.AutoSize = True
        chkHobi6.Location = New Point(422, 88)
        chkHobi6.Name = "chkHobi6"
        chkHobi6.Size = New Size(122, 25)
        chkHobi6.TabIndex = 5
        chkHobi6.Text = "Fotography"
        chkHobi6.UseVisualStyleBackColor = True
        ' 
        ' chkHobi5
        ' 
        chkHobi5.AutoSize = True
        chkHobi5.Location = New Point(422, 24)
        chkHobi5.Name = "chkHobi5"
        chkHobi5.Size = New Size(104, 25)
        chkHobi5.TabIndex = 4
        chkHobi5.Text = "Otomotif"
        chkHobi5.UseVisualStyleBackColor = True
        ' 
        ' chkHobi4
        ' 
        chkHobi4.AutoSize = True
        chkHobi4.Location = New Point(223, 88)
        chkHobi4.Name = "chkHobi4"
        chkHobi4.Size = New Size(95, 25)
        chkHobi4.TabIndex = 3
        chkHobi4.Text = "Touring"
        chkHobi4.UseVisualStyleBackColor = True
        ' 
        ' chkHobi3
        ' 
        chkHobi3.AutoSize = True
        chkHobi3.Location = New Point(223, 24)
        chkHobi3.Name = "chkHobi3"
        chkHobi3.Size = New Size(95, 25)
        chkHobi3.TabIndex = 2
        chkHobi3.Text = "Memasak"
        chkHobi3.UseVisualStyleBackColor = True
        ' 
        ' chkHobi2
        ' 
        chkHobi2.AutoSize = True
        chkHobi2.Location = New Point(33, 88)
        chkHobi2.Name = "chkHobi2"
        chkHobi2.Size = New Size(104, 25)
        chkHobi2.TabIndex = 1
        chkHobi2.Text = "Olahraga"
        chkHobi2.UseVisualStyleBackColor = True
        ' 
        ' chkHobi1
        ' 
        chkHobi1.AutoSize = True
        chkHobi1.Location = New Point(33, 24)
        chkHobi1.Name = "chkHobi1"
        chkHobi1.Size = New Size(95, 25)
        chkHobi1.TabIndex = 0
        chkHobi1.Text = "Belajar"
        chkHobi1.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.SandyBrown
        btnCetak.Font = New Font("Simplified Arabic Fixed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(199, 434)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(586, 30)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Font = New Font("Simplified Arabic Fixed", 9F)
        dtpTanggalLahir.Location = New Point(534, 89)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(380, 24)
        dtpTanggalLahir.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(962, 476)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(btnCetak)
        Controls.Add(grpHobi)
        Controls.Add(grpJenisKelamin)
        Controls.Add(txtNoTelp)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(picProfile)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobi.ResumeLayout(False)
        grpHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobi As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents chkHobi1 As CheckBox
    Friend WithEvents chkHobi3 As CheckBox
    Friend WithEvents chkHobi2 As CheckBox
    Friend WithEvents chkHobi4 As CheckBox
    Friend WithEvents chkHobi5 As CheckBox
    Friend WithEvents chkHobi10 As CheckBox
    Friend WithEvents chkHobi9 As CheckBox
    Friend WithEvents chkHobi8 As CheckBox
    Friend WithEvents chkHobi7 As CheckBox
    Friend WithEvents chkHobi6 As CheckBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker

End Class
