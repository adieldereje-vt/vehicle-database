Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PasswordChar property to '*' for passwordTextBox
        passwordTextBox.PasswordChar = "*"c
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim username As String = usernameTextBox.Text
        Dim password As String = passwordTextBox.Text

        ' Here you would normally check against a database or other secure storage.
        ' For example purposes, using hardcoded credentials:
        If username = "customer" AndAlso password = "123" Then
            ' Customer Login Success
            Me.Hide()
            Dim mainForm As New HokieMotorSales()
            mainForm.Show()
        ElseIf username = "admin" AndAlso password = "123" Then
            ' Admin Login Success
            Me.Hide()
            Dim adminForm As New Form2()
            adminForm.Show()
        Else
            ' Login Fail
            MessageBox.Show("Invalid credentials, please try again.")
        End If
    End Sub
End Class
