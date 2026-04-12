<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Sylfaen", 10.8F)
        txtUsername.Location = New Point(105, 65)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(256, 31)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Sylfaen", 10.8F)
        txtPassword.Location = New Point(105, 146)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(256, 31)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnLogin.Font = New Font("Sylfaen", 10.8F)
        btnLogin.Location = New Point(105, 223)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(101, 36)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnClose.Font = New Font("Sylfaen", 10.8F)
        btnClose.Location = New Point(260, 223)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(101, 36)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(476, 333)
        Controls.Add(btnClose)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
End Class
