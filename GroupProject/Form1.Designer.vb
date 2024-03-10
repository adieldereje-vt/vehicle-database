<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        usernameTextBox = New TextBox()
        passwordTextBox = New TextBox()
        loginButton = New Button()
        username = New Label()
        password = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(76, 175)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(248, 23)
        usernameTextBox.TabIndex = 0
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(75, 235)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(248, 23)
        passwordTextBox.TabIndex = 1
        ' 
        ' loginButton
        ' 
        loginButton.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        loginButton.ForeColor = Color.Maroon
        loginButton.Location = New Point(76, 293)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(248, 28)
        loginButton.TabIndex = 2
        loginButton.Text = "Log in"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        username.Location = New Point(76, 157)
        username.Name = "username"
        username.Size = New Size(65, 14)
        username.TabIndex = 3
        username.Text = "Username:"
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        password.Location = New Point(75, 217)
        password.Name = "password"
        password.Size = New Size(62, 14)
        password.TabIndex = 4
        password.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(65, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 29)
        Label1.TabIndex = 5
        Label1.Text = "Hokie Motor Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(74, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 6
        Label2.Text = "Log in"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(74, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(263, 14)
        Label3.TabIndex = 7
        Label3.Text = "Begin your car journey with Hokie Motor Sales."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(424, 412)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(loginButton)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameTextBox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
