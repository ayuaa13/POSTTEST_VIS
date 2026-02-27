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
        lblIPS = New Label()
        lblIPK = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPKumulatif = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(218, 176)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(86, 20)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(218, 259)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(89, 20)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(339, 173)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(162, 27)
        txtIPSemester.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(339, 206)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(78, 30)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(423, 206)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(78, 30)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(339, 256)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.Size = New Size(162, 27)
        txtIPKumulatif.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.ForeColor = Color.Red
        lblPredikat.Location = New Point(339, 317)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 20)
        lblPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPKumulatif)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPKumulatif As TextBox
    Friend WithEvents lblPredikat As Label

End Class
