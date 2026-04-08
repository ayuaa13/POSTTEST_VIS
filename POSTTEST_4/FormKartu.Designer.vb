<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        picFotoCetak = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblTelepon = New Label()
        lblHobby = New Label()
        Label6 = New Label()
        CType(picFotoCetak, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFotoCetak
        ' 
        picFotoCetak.BackColor = SystemColors.Info
        picFotoCetak.Location = New Point(43, 96)
        picFotoCetak.Name = "picFotoCetak"
        picFotoCetak.Size = New Size(184, 179)
        picFotoCetak.SizeMode = PictureBoxSizeMode.Zoom
        picFotoCetak.TabIndex = 1
        picFotoCetak.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.Font = New Font("Simplified Arabic Fixed", 12F)
        lblNama.Location = New Point(263, 96)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(416, 36)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        lblNama.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblID
        ' 
        lblID.Font = New Font("Simplified Arabic Fixed", 12F)
        lblID.Location = New Point(263, 132)
        lblID.Name = "lblID"
        lblID.Size = New Size(416, 36)
        lblID.TabIndex = 3
        lblID.Text = "ID"
        lblID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.Font = New Font("Simplified Arabic Fixed", 12F)
        lblKomunitas.Location = New Point(263, 168)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(416, 36)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Komunitas"
        lblKomunitas.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTelepon
        ' 
        lblTelepon.Font = New Font("Simplified Arabic Fixed", 12F)
        lblTelepon.Location = New Point(263, 204)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(416, 36)
        lblTelepon.TabIndex = 5
        lblTelepon.Text = "Telepon"
        lblTelepon.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblHobby
        ' 
        lblHobby.Font = New Font("Simplified Arabic Fixed", 12F)
        lblHobby.Location = New Point(263, 240)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(416, 36)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby"
        lblHobby.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.Info
        Label6.Font = New Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(-1, -5)
        Label6.Name = "Label6"
        Label6.Size = New Size(680, 64)
        Label6.TabIndex = 7
        Label6.Text = "Kartu Komunitas"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(678, 311)
        Controls.Add(Label6)
        Controls.Add(lblHobby)
        Controls.Add(lblTelepon)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(picFotoCetak)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(picFotoCetak, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picFotoCetak As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label6 As Label
End Class
