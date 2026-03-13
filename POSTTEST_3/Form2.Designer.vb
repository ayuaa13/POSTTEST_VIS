<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        picKartuProfile = New PictureBox()
        txtKartuNama = New TextBox()
        txtKartuUmur = New TextBox()
        txtKartuNoTelp = New TextBox()
        txtKartuHobi = New TextBox()
        txtKartuTglLahir = New TextBox()
        txtKartuAlamat = New TextBox()
        txtKartuJK = New TextBox()
        lblHobi = New Label()
        lblNoTelp = New Label()
        lblTanggalLahir = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        lblAlamat = New Label()
        lblJeisKelamin = New Label()
        Label8 = New Label()
        CType(picKartuProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picKartuProfile
        ' 
        picKartuProfile.BackColor = SystemColors.Window
        picKartuProfile.Location = New Point(83, 145)
        picKartuProfile.Name = "picKartuProfile"
        picKartuProfile.Size = New Size(236, 247)
        picKartuProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picKartuProfile.TabIndex = 1
        picKartuProfile.TabStop = False
        ' 
        ' txtKartuNama
        ' 
        txtKartuNama.Location = New Point(542, 119)
        txtKartuNama.Name = "txtKartuNama"
        txtKartuNama.Size = New Size(328, 27)
        txtKartuNama.TabIndex = 8
        ' 
        ' txtKartuUmur
        ' 
        txtKartuUmur.Location = New Point(542, 163)
        txtKartuUmur.Name = "txtKartuUmur"
        txtKartuUmur.Size = New Size(328, 27)
        txtKartuUmur.TabIndex = 9
        ' 
        ' txtKartuNoTelp
        ' 
        txtKartuNoTelp.Location = New Point(542, 210)
        txtKartuNoTelp.Name = "txtKartuNoTelp"
        txtKartuNoTelp.Size = New Size(328, 27)
        txtKartuNoTelp.TabIndex = 10
        ' 
        ' txtKartuHobi
        ' 
        txtKartuHobi.Location = New Point(542, 256)
        txtKartuHobi.Name = "txtKartuHobi"
        txtKartuHobi.Size = New Size(328, 27)
        txtKartuHobi.TabIndex = 11
        ' 
        ' txtKartuTglLahir
        ' 
        txtKartuTglLahir.Location = New Point(542, 300)
        txtKartuTglLahir.Name = "txtKartuTglLahir"
        txtKartuTglLahir.Size = New Size(328, 27)
        txtKartuTglLahir.TabIndex = 12
        ' 
        ' txtKartuAlamat
        ' 
        txtKartuAlamat.Location = New Point(542, 349)
        txtKartuAlamat.Name = "txtKartuAlamat"
        txtKartuAlamat.Size = New Size(328, 27)
        txtKartuAlamat.TabIndex = 13
        ' 
        ' txtKartuJK
        ' 
        txtKartuJK.Location = New Point(542, 394)
        txtKartuJK.Name = "txtKartuJK"
        txtKartuJK.Size = New Size(328, 27)
        txtKartuJK.TabIndex = 14
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = SystemColors.Info
        lblHobi.Font = New Font("Simplified Arabic Fixed", 9F)
        lblHobi.Location = New Point(356, 262)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(55, 21)
        lblHobi.TabIndex = 19
        lblHobi.Text = "Hobi:"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = SystemColors.Info
        lblNoTelp.Font = New Font("Simplified Arabic Fixed", 9F)
        lblNoTelp.Location = New Point(356, 216)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(109, 21)
        lblNoTelp.TabIndex = 18
        lblNoTelp.Text = "No. Telpon:"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.BackColor = SystemColors.Info
        lblTanggalLahir.Font = New Font("Simplified Arabic Fixed", 9F)
        lblTanggalLahir.Location = New Point(356, 306)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(136, 21)
        lblTanggalLahir.TabIndex = 17
        lblTanggalLahir.Text = "Tanggal Lahir:"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = SystemColors.Info
        lblUmur.Font = New Font("Simplified Arabic Fixed", 9F)
        lblUmur.Location = New Point(356, 169)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(55, 21)
        lblUmur.TabIndex = 16
        lblUmur.Text = "Umur:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = SystemColors.Info
        lblNama.Font = New Font("Simplified Arabic Fixed", 9F)
        lblNama.Location = New Point(356, 125)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(55, 21)
        lblNama.TabIndex = 15
        lblNama.Text = "Nama:"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = SystemColors.Info
        lblAlamat.Font = New Font("Simplified Arabic Fixed", 9F)
        lblAlamat.Location = New Point(356, 355)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(73, 21)
        lblAlamat.TabIndex = 20
        lblAlamat.Text = "Alamat:"
        ' 
        ' lblJeisKelamin
        ' 
        lblJeisKelamin.AutoSize = True
        lblJeisKelamin.BackColor = SystemColors.Info
        lblJeisKelamin.Font = New Font("Simplified Arabic Fixed", 9F)
        lblJeisKelamin.Location = New Point(356, 400)
        lblJeisKelamin.Name = "lblJeisKelamin"
        lblJeisKelamin.Size = New Size(136, 21)
        lblJeisKelamin.TabIndex = 21
        lblJeisKelamin.Text = "Jenis Kelamin:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.BackColor = Color.SandyBrown
        Label8.Font = New Font("Simplified Arabic Fixed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(0, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(984, 65)
        Label8.TabIndex = 22
        Label8.Text = "Kartu Komunitas"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(983, 466)
        Controls.Add(Label8)
        Controls.Add(lblJeisKelamin)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobi)
        Controls.Add(lblNoTelp)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(txtKartuJK)
        Controls.Add(txtKartuAlamat)
        Controls.Add(txtKartuTglLahir)
        Controls.Add(txtKartuHobi)
        Controls.Add(txtKartuNoTelp)
        Controls.Add(txtKartuUmur)
        Controls.Add(txtKartuNama)
        Controls.Add(picKartuProfile)
        Name = "Form2"
        Text = "Form2"
        CType(picKartuProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picKartuProfile As PictureBox
    Friend WithEvents txtKartuNama As TextBox
    Friend WithEvents txtKartuUmur As TextBox
    Friend WithEvents txtKartuNoTelp As TextBox
    Friend WithEvents txtKartuHobi As TextBox
    Friend WithEvents txtKartuTglLahir As TextBox
    Friend WithEvents txtKartuAlamat As TextBox
    Friend WithEvents txtKartuJK As TextBox
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJeisKelamin As Label
    Friend WithEvents Label8 As Label
End Class
