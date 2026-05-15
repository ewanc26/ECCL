Public Class Form1

    ' Prototype "database"
    Private ReadOnly users As New Dictionary(Of String, String) From {
        {"user1", "pass1"},
        {"user2", "pass2"},
        {"user3", "pass3"}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoginPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtLoginUser.Text.Trim()
        Dim password = txtLoginPass.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Dim storedPassword As String = Nothing

        If users.TryGetValue(username, storedPassword) Then
            If storedPassword = password Then
                Me.Hide()
                Using dashboard As New Form2(username)
                    dashboard.ShowDialog()
                End Using
                Me.Show()
            Else
                MessageBox.Show("Incorrect password.")
            End If
        Else
            MessageBox.Show("User not found.")
        End If
    End Sub

End Class
