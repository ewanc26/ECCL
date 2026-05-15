<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblCompanyName = New Label()
        lblCompanyAddr = New Label()
        lblCustomerName = New Label()
        lblCustomerAddr = New Label()
        pnlComponents = New Panel()
        lblPaymentDue = New Label()
        lblSubtotal = New Label()
        lblVAT = New Label()
        lblTotal = New Label()
        lblDeposit = New Label()
        btnPay = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.Location = New Point(0, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(869, 60)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ECCL Invoice"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.AutoSize = True
        lblCompanyName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCompanyName.Location = New Point(23, 107)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(188, 20)
        lblCompanyName.TabIndex = 1
        lblCompanyName.Text = "Eye Crash Computers Ltd."
        ' 
        ' lblCompanyAddr
        ' 
        lblCompanyAddr.AutoSize = True
        lblCompanyAddr.Font = New Font("Segoe UI", 9F)
        lblCompanyAddr.Location = New Point(23, 133)
        lblCompanyAddr.Name = "lblCompanyAddr"
        lblCompanyAddr.Size = New Size(218, 100)
        lblCompanyAddr.TabIndex = 2
        lblCompanyAddr.Text = "Unit 3, Fenland Technology Park" & vbCrLf & "Stukeley Road" & vbCrLf & "Huntingdon" & vbCrLf & "Cambridgeshire" & vbCrLf & "PE99 7XZ"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCustomerName.Location = New Point(640, 107)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(0, 20)
        lblCustomerName.TabIndex = 3
        ' 
        ' lblCustomerAddr
        ' 
        lblCustomerAddr.AutoSize = True
        lblCustomerAddr.Font = New Font("Segoe UI", 9F)
        lblCustomerAddr.Location = New Point(640, 133)
        lblCustomerAddr.Name = "lblCustomerAddr"
        lblCustomerAddr.Size = New Size(0, 20)
        lblCustomerAddr.TabIndex = 4
        ' 
        ' pnlComponents
        ' 
        pnlComponents.BorderStyle = BorderStyle.FixedSingle
        pnlComponents.Location = New Point(247, 103)
        pnlComponents.Margin = New Padding(3, 4, 3, 4)
        pnlComponents.Name = "pnlComponents"
        pnlComponents.Size = New Size(372, 377)
        pnlComponents.TabIndex = 5
        ' 
        ' lblPaymentDue
        ' 
        lblPaymentDue.AutoSize = True
        lblPaymentDue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPaymentDue.Location = New Point(663, 377)
        lblPaymentDue.Name = "lblPaymentDue"
        lblPaymentDue.Size = New Size(139, 28)
        lblPaymentDue.TabIndex = 6
        lblPaymentDue.Text = "Payment Due"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 10F)
        lblSubtotal.Location = New Point(663, 424)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(101, 23)
        lblSubtotal.TabIndex = 7
        lblSubtotal.Text = "Subtotal: £0"
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Font = New Font("Segoe UI", 10F)
        lblVAT.Location = New Point(663, 457)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(113, 23)
        lblVAT.TabIndex = 8
        lblVAT.Text = "VAT (20%): £0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotal.Location = New Point(663, 497)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(94, 28)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total: £0"
        ' 
        ' lblDeposit
        ' 
        lblDeposit.AutoSize = True
        lblDeposit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblDeposit.Location = New Point(663, 537)
        lblDeposit.Name = "lblDeposit"
        lblDeposit.Size = New Size(154, 23)
        lblDeposit.TabIndex = 10
        lblDeposit.Text = "Deposit (10%): £0"
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Segoe UI", 14F)
        btnPay.Location = New Point(663, 573)
        btnPay.Margin = New Padding(3, 4, 3, 4)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(137, 60)
        btnPay.TabIndex = 11
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 667)
        Controls.Add(lblTitle)
        Controls.Add(lblCompanyName)
        Controls.Add(lblCompanyAddr)
        Controls.Add(lblCustomerName)
        Controls.Add(lblCustomerAddr)
        Controls.Add(pnlComponents)
        Controls.Add(lblPaymentDue)
        Controls.Add(lblSubtotal)
        Controls.Add(lblVAT)
        Controls.Add(lblTotal)
        Controls.Add(lblDeposit)
        Controls.Add(btnPay)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "ECCL – Invoice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCompanyAddr As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerAddr As Label
    Friend WithEvents pnlComponents As Panel
    Friend WithEvents lblPaymentDue As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents btnPay As Button

End Class
