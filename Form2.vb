Public Class Form2

    Private ReadOnly _username As String

    ' ── Prices (£) ────────────────────────────────────────────────────────────
    ' Motherboard
    Private Const PriceMoboAMD As Integer = 150
    Private Const PriceMoboIntel As Integer = 90
    ' PSU
    Private Const PricePSU400 As Integer = 25
    Private Const PricePSU600 As Integer = 30
    Private Const PricePSU800 As Integer = 45
    ' HDD
    Private Const PriceHDD1TB As Integer = 55
    Private Const PriceHDD2TB As Integer = 100
    Private Const PriceHDD4TB As Integer = 170
    ' SSD
    Private Const PriceSSD256 As Integer = 55
    Private Const PriceSSD512 As Integer = 90
    ' Case
    Private Const PriceCaseDesktop As Integer = 80
    Private Const PriceCaseTower As Integer = 150
    Private Const PriceCaseGaming As Integer = 200
    ' RAM
    Private Const PriceRAM4GB As Integer = 30
    Private Const PriceRAM8GB As Integer = 60
    Private Const PriceRAM16GB As Integer = 100

    Public Sub New(username As String)
        InitializeComponent()
        _username = username
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAllPrices()
    End Sub

    ' ── Subtotal ───────────────────────────────────────────────────────────────

    Private Function GetMoboPrice() As Integer
        If rbMoboAMD.Checked Then Return PriceMoboAMD
        Return PriceMoboIntel
    End Function

    Private Function GetPSUPrice() As Integer
        If rbPSU400.Checked Then Return PricePSU400
        If rbPSU600.Checked Then Return PricePSU600
        Return PricePSU800
    End Function

    Private Function GetHDDPrice() As Integer
        If rbHDD1TB.Checked Then Return PriceHDD1TB
        If rbHDD2TB.Checked Then Return PriceHDD2TB
        Return PriceHDD4TB
    End Function

    Private Function GetSSDPrice() As Integer
        If rbSSD256.Checked Then Return PriceSSD256
        Return PriceSSD512
    End Function

    Private Function GetCasePrice() As Integer
        If rbCaseDesktop.Checked Then Return PriceCaseDesktop
        If rbCaseTower.Checked Then Return PriceCaseTower
        Return PriceCaseGaming
    End Function

    Private Function GetRAMPrice() As Integer
        If rbRAM4GB.Checked Then Return PriceRAM4GB
        If rbRAM8GB.Checked Then Return PriceRAM8GB
        Return PriceRAM16GB
    End Function

    Private Sub UpdateAllPrices()
        lblMoboPrice.Text = $"£{GetMoboPrice()}"
        lblPSUPrice.Text = $"£{GetPSUPrice()}"
        lblHDDPrice.Text = $"£{GetHDDPrice()}"
        lblSSDPrice.Text = $"£{GetSSDPrice()}"
        lblCasePrice.Text = $"£{GetCasePrice()}"
        lblRAMPrice.Text = $"£{GetRAMPrice()}"

        Dim subtotal As Integer = GetMoboPrice() + GetPSUPrice() + GetHDDPrice() +
                                   GetSSDPrice() + GetCasePrice() + GetRAMPrice()
        lblSubtotalValue.Text = $"£{subtotal}"
    End Sub

    ' ── Radio button event handlers ────────────────────────────────────────────

    Private Sub rbMoboAMD_CheckedChanged(sender As Object, e As EventArgs) Handles rbMoboAMD.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbMoboIntel_CheckedChanged(sender As Object, e As EventArgs) Handles rbMoboIntel.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbPSU400_CheckedChanged(sender As Object, e As EventArgs) Handles rbPSU400.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbPSU600_CheckedChanged(sender As Object, e As EventArgs) Handles rbPSU600.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbPSU800_CheckedChanged(sender As Object, e As EventArgs) Handles rbPSU800.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbHDD1TB_CheckedChanged(sender As Object, e As EventArgs) Handles rbHDD1TB.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbHDD2TB_CheckedChanged(sender As Object, e As EventArgs) Handles rbHDD2TB.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbHDD4TB_CheckedChanged(sender As Object, e As EventArgs) Handles rbHDD4TB.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbSSD256_CheckedChanged(sender As Object, e As EventArgs) Handles rbSSD256.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbSSD512_CheckedChanged(sender As Object, e As EventArgs) Handles rbSSD512.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbCaseDesktop_CheckedChanged(sender As Object, e As EventArgs) Handles rbCaseDesktop.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbCaseTower_CheckedChanged(sender As Object, e As EventArgs) Handles rbCaseTower.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbCaseGaming_CheckedChanged(sender As Object, e As EventArgs) Handles rbCaseGaming.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbRAM4GB_CheckedChanged(sender As Object, e As EventArgs) Handles rbRAM4GB.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbRAM8GB_CheckedChanged(sender As Object, e As EventArgs) Handles rbRAM8GB.CheckedChanged
        UpdateAllPrices()
    End Sub

    Private Sub rbRAM16GB_CheckedChanged(sender As Object, e As EventArgs) Handles rbRAM16GB.CheckedChanged
        UpdateAllPrices()
    End Sub

    ' ── Continue button ────────────────────────────────────────────────────────

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Build the selected components list to hand to the invoice form
        Dim components As New List(Of (Name As String, Opt As String, Price As Integer)) From {
            ("Motherboard", If(rbMoboAMD.Checked, "AMD", "Intel"), GetMoboPrice()),
            ("Power Supply Unit", If(rbPSU400.Checked, "400 W", If(rbPSU600.Checked, "600 W", "800 W")), GetPSUPrice()),
            ("Hard Disk Drive", If(rbHDD1TB.Checked, "1 TB", If(rbHDD2TB.Checked, "2 TB", "4 TB")), GetHDDPrice()),
            ("Solid State Drive", If(rbSSD256.Checked, "256 GB", "512 GB"), GetSSDPrice()),
            ("Case", If(rbCaseDesktop.Checked, "Desktop", If(rbCaseTower.Checked, "Tower", "Gaming")), GetCasePrice()),
            ("Random Access Memory", If(rbRAM4GB.Checked, "4 GB", If(rbRAM8GB.Checked, "8 GB", "16 GB")), GetRAMPrice())
        }

        Using invoice As New Form3(_username, components)
            invoice.ShowDialog()
        End Using
    End Sub

End Class
