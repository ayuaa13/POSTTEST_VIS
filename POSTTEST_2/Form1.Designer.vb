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
        lstBuku = New ListBox()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        lblGenre = New Label()
        lblJudul = New Label()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        lblHapus = New Label()
        txtJudulHapus = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstBuku
        ' 
        lstBuku.BackColor = SystemColors.InactiveCaption
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(199, 254)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(391, 184)
        lstBuku.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientActiveCaption
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(lblGenre)
        GroupBox1.Controls.Add(lblJudul)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.DarkSlateGray
        GroupBox1.Location = New Point(40, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(309, 184)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.AppWorkspace
        btnTambah.Location = New Point(197, 149)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(6, 99)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(56, 20)
        lblGenre.TabIndex = 3
        lblGenre.Text = "Genre"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(6, 44)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(100, 20)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = SystemColors.InactiveBorder
        txtGenre.Location = New Point(138, 99)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(153, 28)
        txtGenre.TabIndex = 1
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BackColor = SystemColors.InactiveBorder
        txtJudulTambah.Location = New Point(138, 41)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(153, 28)
        txtJudulTambah.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.GradientActiveCaption
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(lblHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.DarkSlateGray
        GroupBox2.Location = New Point(427, 33)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(309, 184)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.AppWorkspace
        btnHapus.Location = New Point(193, 135)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' lblHapus
        ' 
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(16, 57)
        lblHapus.Name = "lblHapus"
        lblHapus.Size = New Size(100, 20)
        lblHapus.TabIndex = 4
        lblHapus.Text = "Judul Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BackColor = SystemColors.InactiveBorder
        txtJudulHapus.Location = New Point(134, 57)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(153, 28)
        txtJudulHapus.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(lstBuku)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstBuku As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblHapus As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button

End Class
