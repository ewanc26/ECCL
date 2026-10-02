Public Class Form3

    ' ── Prototype customer "database" ─────────────────────────────────────────
    ' Entirely fictional. Place names are invented and the "QR" postcode area is
    ' not a real UK postcode area, so no record can be traced to a real address.
    Private ReadOnly customers As New Dictionary(Of String, (Name As String, Address As String)) From {
        {"user1", ("Ms Harriet Colton",
                   "Larkspur Cottage" & Environment.NewLine &
                   "Alder Lane" & Environment.NewLine &
                   "Eastmoor" & Environment.NewLine &
                   "Northshire" & Environment.NewLine &
                   "QR1 2QQ")},
        {"user2", ("Mr John Smith",
                   "42 Oak Avenue" & Environment.NewLine &
                   "Northport" & Environment.NewLine &
                   "Northshire" & Environment.NewLine &
                   "QR3 5AB")},
        {"user3", ("Mrs Emily Brown",
                   "15 Rose Street" & Environment.NewLine &
                   "Kingsmoor" & Environment.NewLine &
                   "Northshire" & Environment.NewLine &
                   "QR8 4CD")}
    }

    Private ReadOnly _username As String
    Private ReadOnly _components As List(Of (Name As String, Opt As String, Price As Integer))

    Public Sub New(username As String,
                   components As List(Of (Name As String, Opt As String, Price As Integer)))
        InitializeComponent()
        _username = username
        _components = components
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCustomer()
        PopulateComponentList()
        PopulatePaymentSummary()
    End Sub

    Private Sub PopulateCustomer()
        Dim customer As (Name As String, Address As String) = (String.Empty, String.Empty)
        If customers.TryGetValue(_username, customer) Then
            lblCustomerName.Text = customer.Name
            lblCustomerAddr.Text = customer.Address
        Else
            lblCustomerName.Text = _username
            lblCustomerAddr.Text = String.Empty
        End If
    End Sub

    Private Sub PopulateComponentList()
        ' Build component labels dynamically inside pnlComponents.
        ' Header row
        Dim lblHeader = New Label() With {
            .Text = "Component list",
            .Font = New Font("Segoe UI", 9F, FontStyle.Bold),
            .Location = New Point(5, 5),
            .AutoSize = True
        }
        pnlComponents.Controls.Add(lblHeader)

        Dim y As Integer = 28
        For Each comp In _components
            ' Left: "Name – Option"
            Dim lblName = New Label() With {
                .Text = $"{comp.Name}  –  {comp.Opt}",
                .Location = New Point(5, y),
                .Width = 280,
                .Font = New Font("Segoe UI", 9F)
            }
            ' Right: price
            Dim lblPrice = New Label() With {
                .Text = $"£{comp.Price}",
                .Location = New Point(295, y),
                .Width = 70,
                .Font = New Font("Segoe UI", 9F),
                .TextAlign = ContentAlignment.MiddleRight
            }
            pnlComponents.Controls.Add(lblName)
            pnlComponents.Controls.Add(lblPrice)
            y += 25
        Next

        ' Footer note
        y += 5
        Dim lblNote = New Label() With {
            .Text = "All components are x1",
            .Font = New Font("Segoe UI", 8F, FontStyle.Bold),
            .Location = New Point(5, y),
            .AutoSize = True
        }
        pnlComponents.Controls.Add(lblNote)
    End Sub

    Private Sub PopulatePaymentSummary()
        Dim subtotal As Integer = _components.Sum(Function(c) c.Price)
        Dim vat As Decimal = Math.Round(subtotal * 0.2D, 2)
        Dim total As Decimal = subtotal + vat
        Dim deposit As Decimal = Math.Round(total * 0.1D, 2)

        lblSubtotal.Text = $"Subtotal: £{subtotal}"
        lblVAT.Text = $"VAT (20%): £{vat:0.00}"
        lblTotal.Text = $"Total: £{total:0.00}"
        lblDeposit.Text = $"Deposit (10%): £{deposit:0.00}"
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim subtotal As Integer = _components.Sum(Function(c) c.Price)
        Dim total As Decimal = Math.Round(subtotal * 1.2D, 2)
        Dim deposit As Decimal = Math.Round(total * 0.1D, 2)

        MessageBox.Show(
            $"DEMO ONLY — no money has changed hands and no order exists." & Environment.NewLine & Environment.NewLine &
            $"A deposit of £{deposit:0.00} (10% of the £{total:0.00} total) would be payable." & Environment.NewLine & Environment.NewLine &
            $"This prototype does not process payments or store any data.",
            "Demo – No Payment Taken",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        Me.Close()
    End Sub

End Class
