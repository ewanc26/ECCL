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
        lblLoginTitle = New Label()
        lblLoginUser = New Label()
        lblLoginPassword = New Label()
        btnLogin = New Button()
        txtLoginUser = New TextBox()
        txtLoginPass = New TextBox()
        lblDemoNote = New Label()
        SuspendLayout()
        ' 
        ' lblLoginTitle
        ' 
        lblLoginTitle.AutoSize = True
        lblLoginTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLoginTitle.Location = New Point(108, 43)
        lblLoginTitle.Name = "lblLoginTitle"
        lblLoginTitle.Size = New Size(92, 45)
        lblLoginTitle.TabIndex = 0
        lblLoginTitle.Text = "ECCL"
        lblLoginTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLoginUser
        ' 
        lblLoginUser.AutoSize = True
        lblLoginUser.Location = New Point(37, 146)
        lblLoginUser.Name = "lblLoginUser"
        lblLoginUser.Size = New Size(60, 15)
        lblLoginUser.TabIndex = 1
        lblLoginUser.Text = "Username"
        ' 
        ' lblLoginPassword
        ' 
        lblLoginPassword.AutoSize = True
        lblLoginPassword.Location = New Point(37, 221)
        lblLoginPassword.Name = "lblLoginPassword"
        lblLoginPassword.Size = New Size(57, 15)
        lblLoginPassword.TabIndex = 2
        lblLoginPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(78, 273)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(150, 68)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtLoginUser
        ' 
        txtLoginUser.Location = New Point(100, 138)
        txtLoginUser.Name = "txtLoginUser"
        txtLoginUser.Size = New Size(100, 23)
        txtLoginUser.TabIndex = 4
        ' 
        ' txtLoginPass
        ' 
        txtLoginPass.Location = New Point(100, 213)
        txtLoginPass.Name = "txtLoginPass"
        txtLoginPass.Size = New Size(100, 23)
        txtLoginPass.TabIndex = 5
        ' 
        ' lblDemoNote
        ' 
        lblDemoNote.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDemoNote.Location = New Point(25, 350)
        lblDemoNote.Name = "lblDemoNote"
        lblDemoNote.Size = New Size(259, 85)
        lblDemoNote.TabIndex = 6
        lblDemoNote.Text = "DEMO PROJECT" & vbCrLf & _
            "No real orders, payments or data storage." & vbCrLf & vbCrLf & _
            "Sign in with user1 / pass1" & vbCrLf & _
            "(or user2 / pass2, user3 / pass3)"
        lblDemoNote.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 450)
        Controls.Add(lblDemoNote)
        Controls.Add(txtLoginPass)
        Controls.Add(txtLoginUser)
        Controls.Add(btnLogin)
        Controls.Add(lblLoginPassword)
        Controls.Add(lblLoginUser)
        Controls.Add(lblLoginTitle)
        Name = "Form1"
        Text = "ECCL – Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents lblLoginUser As Label
    Friend WithEvents lblLoginPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLoginUser As TextBox
    Friend WithEvents txtLoginPass As TextBox
    Friend WithEvents lblDemoNote As Label

End Class
