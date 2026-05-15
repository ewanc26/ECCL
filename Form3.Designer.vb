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
        ' Company address
        lblCompanyName = New Label()
        lblCompanyAddr = New Label()
        ' Customer address
        lblCustomerName = New Label()
        lblCustomerAddr = New Label()
        ' Component list panel
        pnlComponents = New Panel()
        ' Payment section
        lblPaymentDue = New Label()
        lblSubtotal = New Label()
        lblVAT = New Label()
        lblTotal = New Label()
        lblDeposit = New Label()
        ' Pay button
        btnPay = New Button()
        SuspendLayout()

        ' ── lblTitle ─────────────────────────────────────────────────────────────
        lblTitle.AutoSize = False
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.Location = New Point(0, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(760, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ECCL Invoice"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        ' ── lblCompanyName ───────────────────────────────────────────────────────
        lblCompanyName.AutoSize = True
        lblCompanyName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCompanyName.Location = New Point(20, 80)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.TabIndex = 1
        lblCompanyName.Text = "Eye Crash Computers Ltd."

        ' ── lblCompanyAddr ───────────────────────────────────────────────────────
        lblCompanyAddr.AutoSize = True
        lblCompanyAddr.Font = New Font("Segoe UI", 9F)
        lblCompanyAddr.Location = New Point(20, 100)
        lblCompanyAddr.Name = "lblCompanyAddr"
        lblCompanyAddr.TabIndex = 2
        lblCompanyAddr.Text = "Unit 3, Fenland Technology Park" & Environment.NewLine &
                               "Stukeley Road" & Environment.NewLine &
                               "Huntingdon" & Environment.NewLine &
                               "Cambridgeshire" & Environment.NewLine &
                               "PE99 7XZ"

        ' ── lblCustomerName ──────────────────────────────────────────────────────
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCustomerName.Location = New Point(560, 80)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.TabIndex = 3
        lblCustomerName.Text = ""   ' populated in code

        ' ── lblCustomerAddr ──────────────────────────────────────────────────────
        lblCustomerAddr.AutoSize = True
        lblCustomerAddr.Font = New Font("Segoe UI", 9F)
        lblCustomerAddr.Location = New Point(560, 100)
        lblCustomerAddr.Name = "lblCustomerAddr"
        lblCustomerAddr.TabIndex = 4
        lblCustomerAddr.Text = ""   ' populated in code

        ' ── pnlComponents ────────────────────────────────────────────────────────
        pnlComponents.BorderStyle = BorderStyle.FixedSingle
        pnlComponents.Location = New Point(80, 250)
        pnlComponents.Name = "pnlComponents"
        pnlComponents.Size = New Size(380, 230)
        pnlComponents.TabIndex = 5

        ' ── lblPaymentDue ────────────────────────────────────────────────────────
        lblPaymentDue.AutoSize = True
        lblPaymentDue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPaymentDue.Location = New Point(440, 250)
        lblPaymentDue.Name = "lblPaymentDue"
        lblPaymentDue.TabIndex = 6
        lblPaymentDue.Text = "Payment Due"

        ' ── lblSubtotal ──────────────────────────────────────────────────────────
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 10F)
        lblSubtotal.Location = New Point(440, 285)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.TabIndex = 7
        lblSubtotal.Text = "Subtotal: £0"

        ' ── lblVAT ───────────────────────────────────────────────────────────────
        lblVAT.AutoSize = True
        lblVAT.Font = New Font("Segoe UI", 10F)
        lblVAT.Location = New Point(440, 310)
        lblVAT.Name = "lblVAT"
        lblVAT.TabIndex = 8
        lblVAT.Text = "VAT (20%): £0"

        ' ── lblTotal ─────────────────────────────────────────────────────────────
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotal.Location = New Point(440, 340)
        lblTotal.Name = "lblTotal"
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total: £0"

        ' ── lblDeposit ───────────────────────────────────────────────────────────
        lblDeposit.AutoSize = True
        lblDeposit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblDeposit.Location = New Point(440, 370)
        lblDeposit.Name = "lblDeposit"
        lblDeposit.TabIndex = 10
        lblDeposit.Text = "Deposit (10%): £0"

        ' ── btnPay ───────────────────────────────────────────────────────────────
        btnPay.Font = New Font("Segoe UI", 14F)
        btnPay.Location = New Point(580, 430)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(120, 45)
        btnPay.TabIndex = 11
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = True

        ' ── Form3 ────────────────────────────────────────────────────────────────
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 500)
        Text = "ECCL – Invoice"

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
