Public Class Form1
    ' Prototype "database" of users for testing purposes
    Public dictTestUser As New Dictionary(Of String, String) From {
        {"user1", "pass1"},
        {"user2", "pass2"},
        {"user3", "pass3"}
    }

    ' Login credentials
    Dim txtLoginUserSubmission As String
    Dim txtLoginPassSubmission As String

    Private Sub txtLoginPass_TextChanged(sender As Object, e As EventArgs) Handles txtLoginPass.TextChanged
        txtLoginPassSubmission = txtLoginPass.Text
    End Sub

    Private Sub txtLoginUser_TextChanged(sender As Object, e As EventArgs) Handles txtLoginUser.TextChanged
        txtLoginUserSubmission = txtLoginUser.Text
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get current values (safer to read directly as well)
        Dim username As String = txtLoginUser.Text.Trim()
        Dim password As String = txtLoginPass.Text.Trim()

        ' Check if user exists
        If dictTestUser.ContainsKey(username) Then

            ' Use Select Case for password check
            Select Case dictTestUser(username)
                Case password
                    MessageBox.Show("Login successful!")
                    Form.ActiveForm.Hide() ' Hide the login form
                    Dim componentsDash As New Form2() ' Create an instance of the components dashboard
                    componentsDash.Show() ' Show the components dashboard
                Case Else
                    MessageBox.Show("Incorrect password.")
            End Select

        Else
            MessageBox.Show("User not found.")
        End If
    End Sub
End Class