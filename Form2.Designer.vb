<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        lblMobo = New Label()
        rbMoboAMD = New RadioButton()
        rbMoboIntel = New RadioButton()
        picMobo = New PictureBox()
        lblMoboPrice = New Label()
        lblPSU = New Label()
        rbPSU400 = New RadioButton()
        rbPSU600 = New RadioButton()
        rbPSU800 = New RadioButton()
        picPSU = New PictureBox()
        lblPSUPrice = New Label()
        lblHDD = New Label()
        rbHDD1TB = New RadioButton()
        rbHDD2TB = New RadioButton()
        rbHDD4TB = New RadioButton()
        picHDD = New PictureBox()
        lblHDDPrice = New Label()
        lblSSD = New Label()
        rbSSD256 = New RadioButton()
        rbSSD512 = New RadioButton()
        picSSD = New PictureBox()
        lblSSDPrice = New Label()
        lblCase = New Label()
        rbCaseDesktop = New RadioButton()
        rbCaseTower = New RadioButton()
        rbCaseGaming = New RadioButton()
        picCase = New PictureBox()
        lblCasePrice = New Label()
        lblRAM = New Label()
        rbRAM4GB = New RadioButton()
        rbRAM8GB = New RadioButton()
        rbRAM16GB = New RadioButton()
        picRAM = New PictureBox()
        lblRAMPrice = New Label()
        lblSubtotalLabel = New Label()
        lblSubtotalValue = New Label()
        btnContinue = New Button()
        CType(picMobo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPSU, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHDD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSSD, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCase, ComponentModel.ISupportInitialize).BeginInit()
        CType(picRAM, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblTitle
        '
        lblTitle.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTitle.Location = New Point(343, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(777, 67)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ECCL Component Selection"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        '
        ' lblMobo
        '
        lblMobo.AutoSize = True
        lblMobo.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblMobo.Location = New Point(34, 107)
        lblMobo.Name = "lblMobo"
        lblMobo.Size = New Size(117, 23)
        lblMobo.TabIndex = 1
        lblMobo.Text = "Motherboard"
        '
        ' rbMoboAMD
        '
        rbMoboAMD.AutoSize = True
        rbMoboAMD.Checked = True
        rbMoboAMD.Location = New Point(34, 147)
        rbMoboAMD.Margin = New Padding(3, 4, 3, 4)
        rbMoboAMD.Name = "rbMoboAMD"
        rbMoboAMD.Size = New Size(64, 24)
        rbMoboAMD.TabIndex = 2
        rbMoboAMD.TabStop = True
        rbMoboAMD.Text = "AMD"
        '
        ' rbMoboIntel
        '
        rbMoboIntel.AutoSize = True
        rbMoboIntel.Location = New Point(34, 180)
        rbMoboIntel.Margin = New Padding(3, 4, 3, 4)
        rbMoboIntel.Name = "rbMoboIntel"
        rbMoboIntel.Size = New Size(59, 24)
        rbMoboIntel.TabIndex = 3
        rbMoboIntel.Text = "Intel"
        '
        ' picMobo
        '
        picMobo.BorderStyle = BorderStyle.FixedSingle
        picMobo.Location = New Point(206, 107)
        picMobo.Margin = New Padding(3, 4, 3, 4)
        picMobo.Name = "picMobo"
        picMobo.Size = New Size(183, 186)
        picMobo.SizeMode = PictureBoxSizeMode.StretchImage
        picMobo.TabIndex = 4
        picMobo.TabStop = False
        '
        ' lblMoboPrice
        '
        lblMoboPrice.AutoSize = True
        lblMoboPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblMoboPrice.Location = New Point(257, 304)
        lblMoboPrice.Name = "lblMoboPrice"
        lblMoboPrice.Size = New Size(45, 20)
        lblMoboPrice.TabIndex = 5
        lblMoboPrice.Text = "£150"
        '
        ' lblPSU
        '
        lblPSU.AutoSize = True
        lblPSU.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPSU.Location = New Point(457, 107)
        lblPSU.Name = "lblPSU"
        lblPSU.Size = New Size(159, 23)
        lblPSU.TabIndex = 6
        lblPSU.Text = "Power Supply Unit"
        '
        ' rbPSU400
        '
        rbPSU400.AutoSize = True
        rbPSU400.Location = New Point(457, 147)
        rbPSU400.Margin = New Padding(3, 4, 3, 4)
        rbPSU400.Name = "rbPSU400"
        rbPSU400.Size = New Size(72, 24)
        rbPSU400.TabIndex = 7
        rbPSU400.Text = "400 W"
        '
        ' rbPSU600
        '
        rbPSU600.AutoSize = True
        rbPSU600.Checked = True
        rbPSU600.Location = New Point(457, 180)
        rbPSU600.Margin = New Padding(3, 4, 3, 4)
        rbPSU600.Name = "rbPSU600"
        rbPSU600.Size = New Size(72, 24)
        rbPSU600.TabIndex = 8
        rbPSU600.TabStop = True
        rbPSU600.Text = "600 W"
        '
        ' rbPSU800
        '
        rbPSU800.AutoSize = True
        rbPSU800.Location = New Point(457, 213)
        rbPSU800.Margin = New Padding(3, 4, 3, 4)
        rbPSU800.Name = "rbPSU800"
        rbPSU800.Size = New Size(72, 24)
        rbPSU800.TabIndex = 9
        rbPSU800.Text = "800 W"
        '
        ' picPSU
        '
        picPSU.BorderStyle = BorderStyle.FixedSingle
        picPSU.Location = New Point(640, 107)
        picPSU.Margin = New Padding(3, 4, 3, 4)
        picPSU.Name = "picPSU"
        picPSU.Size = New Size(183, 186)
        picPSU.SizeMode = PictureBoxSizeMode.StretchImage
        picPSU.TabIndex = 10
        picPSU.TabStop = False
        '
        ' lblPSUPrice
        '
        lblPSUPrice.AutoSize = True
        lblPSUPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPSUPrice.Location = New Point(697, 304)
        lblPSUPrice.Name = "lblPSUPrice"
        lblPSUPrice.Size = New Size(36, 20)
        lblPSUPrice.TabIndex = 11
        lblPSUPrice.Text = "£30"
        '
        ' lblHDD
        '
        lblHDD.AutoSize = True
        lblHDD.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblHDD.Location = New Point(891, 107)
        lblHDD.Name = "lblHDD"
        lblHDD.Size = New Size(138, 23)
        lblHDD.TabIndex = 12
        lblHDD.Text = "Hard Disk Drive"
        '
        ' rbHDD1TB
        '
        rbHDD1TB.AutoSize = True
        rbHDD1TB.Location = New Point(891, 147)
        rbHDD1TB.Margin = New Padding(3, 4, 3, 4)
        rbHDD1TB.Name = "rbHDD1TB"
        rbHDD1TB.Size = New Size(59, 24)
        rbHDD1TB.TabIndex = 13
        rbHDD1TB.Text = "1 TB"
        '
        ' rbHDD2TB
        '
        rbHDD2TB.AutoSize = True
        rbHDD2TB.Checked = True
        rbHDD2TB.Location = New Point(891, 180)
        rbHDD2TB.Margin = New Padding(3, 4, 3, 4)
        rbHDD2TB.Name = "rbHDD2TB"
        rbHDD2TB.Size = New Size(59, 24)
        rbHDD2TB.TabIndex = 14
        rbHDD2TB.TabStop = True
        rbHDD2TB.Text = "2 TB"
        '
        ' rbHDD4TB
        '
        rbHDD4TB.AutoSize = True
        rbHDD4TB.Location = New Point(891, 213)
        rbHDD4TB.Margin = New Padding(3, 4, 3, 4)
        rbHDD4TB.Name = "rbHDD4TB"
        rbHDD4TB.Size = New Size(59, 24)
        rbHDD4TB.TabIndex = 15
        rbHDD4TB.Text = "4 TB"
        '
        ' picHDD
        '
        picHDD.BorderStyle = BorderStyle.FixedSingle
        picHDD.Location = New Point(1074, 107)
        picHDD.Margin = New Padding(3, 4, 3, 4)
        picHDD.Name = "picHDD"
        picHDD.Size = New Size(183, 186)
        picHDD.SizeMode = PictureBoxSizeMode.StretchImage
        picHDD.TabIndex = 16
        picHDD.TabStop = False
        '
        ' lblHDDPrice
        '
        lblHDDPrice.AutoSize = True
        lblHDDPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHDDPrice.Location = New Point(1131, 304)
        lblHDDPrice.Name = "lblHDDPrice"
        lblHDDPrice.Size = New Size(45, 20)
        lblHDDPrice.TabIndex = 17
        lblHDDPrice.Text = "£100"
        '
        ' lblSSD
        '
        lblSSD.AutoSize = True
        lblSSD.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblSSD.Location = New Point(34, 413)
        lblSSD.Name = "lblSSD"
        lblSSD.Size = New Size(146, 23)
        lblSSD.TabIndex = 18
        lblSSD.Text = "Solid State Drive"
        '
        ' rbSSD256
        '
        rbSSD256.AutoSize = True
        rbSSD256.Location = New Point(34, 453)
        rbSSD256.Margin = New Padding(3, 4, 3, 4)
        rbSSD256.Name = "rbSSD256"
        rbSSD256.Size = New Size(77, 24)
        rbSSD256.TabIndex = 19
        rbSSD256.Text = "256 GB"
        '
        ' rbSSD512
        '
        rbSSD512.AutoSize = True
        rbSSD512.Checked = True
        rbSSD512.Location = New Point(34, 487)
        rbSSD512.Margin = New Padding(3, 4, 3, 4)
        rbSSD512.Name = "rbSSD512"
        rbSSD512.Size = New Size(77, 24)
        rbSSD512.TabIndex = 20
        rbSSD512.TabStop = True
        rbSSD512.Text = "512 GB"
        '
        ' picSSD
        '
        picSSD.BorderStyle = BorderStyle.FixedSingle
        picSSD.Location = New Point(206, 413)
        picSSD.Margin = New Padding(3, 4, 3, 4)
        picSSD.Name = "picSSD"
        picSSD.Size = New Size(183, 186)
        picSSD.SizeMode = PictureBoxSizeMode.StretchImage
        picSSD.TabIndex = 21
        picSSD.TabStop = False
        '
        ' lblSSDPrice
        '
        lblSSDPrice.AutoSize = True
        lblSSDPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblSSDPrice.Location = New Point(257, 611)
        lblSSDPrice.Name = "lblSSDPrice"
        lblSSDPrice.Size = New Size(36, 20)
        lblSSDPrice.TabIndex = 22
        lblSSDPrice.Text = "£90"
        '
        ' lblCase
        '
        lblCase.AutoSize = True
        lblCase.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCase.Location = New Point(457, 413)
        lblCase.Name = "lblCase"
        lblCase.Size = New Size(46, 23)
        lblCase.TabIndex = 23
        lblCase.Text = "Case"
        '
        ' rbCaseDesktop
        '
        rbCaseDesktop.AutoSize = True
        rbCaseDesktop.Location = New Point(457, 453)
        rbCaseDesktop.Margin = New Padding(3, 4, 3, 4)
        rbCaseDesktop.Name = "rbCaseDesktop"
        rbCaseDesktop.Size = New Size(85, 24)
        rbCaseDesktop.TabIndex = 24
        rbCaseDesktop.Text = "Desktop"
        '
        ' rbCaseTower
        '
        rbCaseTower.AutoSize = True
        rbCaseTower.Checked = True
        rbCaseTower.Location = New Point(457, 487)
        rbCaseTower.Margin = New Padding(3, 4, 3, 4)
        rbCaseTower.Name = "rbCaseTower"
        rbCaseTower.Size = New Size(70, 24)
        rbCaseTower.TabIndex = 25
        rbCaseTower.TabStop = True
        rbCaseTower.Text = "Tower"
        '
        ' rbCaseGaming
        '
        rbCaseGaming.AutoSize = True
        rbCaseGaming.Location = New Point(457, 520)
        rbCaseGaming.Margin = New Padding(3, 4, 3, 4)
        rbCaseGaming.Name = "rbCaseGaming"
        rbCaseGaming.Size = New Size(82, 24)
        rbCaseGaming.TabIndex = 26
        rbCaseGaming.Text = "Gaming"
        '
        ' picCase
        '
        picCase.BorderStyle = BorderStyle.FixedSingle
        picCase.Location = New Point(640, 413)
        picCase.Margin = New Padding(3, 4, 3, 4)
        picCase.Name = "picCase"
        picCase.Size = New Size(183, 186)
        picCase.SizeMode = PictureBoxSizeMode.StretchImage
        picCase.TabIndex = 27
        picCase.TabStop = False
        '
        ' lblCasePrice
        '
        lblCasePrice.AutoSize = True
        lblCasePrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCasePrice.Location = New Point(697, 611)
        lblCasePrice.Name = "lblCasePrice"
        lblCasePrice.Size = New Size(45, 20)
        lblCasePrice.TabIndex = 28
        lblCasePrice.Text = "£150"
        '
        ' lblRAM
        '
        lblRAM.AutoSize = True
        lblRAM.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblRAM.Location = New Point(862, 413)
        lblRAM.Name = "lblRAM"
        lblRAM.Size = New Size(206, 23)
        lblRAM.TabIndex = 29
        lblRAM.Text = "Random Access Memory"
        '
        ' rbRAM4GB
        '
        rbRAM4GB.AutoSize = True
        rbRAM4GB.Location = New Point(891, 453)
        rbRAM4GB.Margin = New Padding(3, 4, 3, 4)
        rbRAM4GB.Name = "rbRAM4GB"
        rbRAM4GB.Size = New Size(61, 24)
        rbRAM4GB.TabIndex = 30
        rbRAM4GB.Text = "4 GB"
        '
        ' rbRAM8GB
        '
        rbRAM8GB.AutoSize = True
        rbRAM8GB.Checked = True
        rbRAM8GB.Location = New Point(891, 487)
        rbRAM8GB.Margin = New Padding(3, 4, 3, 4)
        rbRAM8GB.Name = "rbRAM8GB"
        rbRAM8GB.Size = New Size(61, 24)
        rbRAM8GB.TabIndex = 31
        rbRAM8GB.TabStop = True
        rbRAM8GB.Text = "8 GB"
        '
        ' rbRAM16GB
        '
        rbRAM16GB.AutoSize = True
        rbRAM16GB.Location = New Point(891, 520)
        rbRAM16GB.Margin = New Padding(3, 4, 3, 4)
        rbRAM16GB.Name = "rbRAM16GB"
        rbRAM16GB.Size = New Size(69, 24)
        rbRAM16GB.TabIndex = 32
        rbRAM16GB.Text = "16 GB"
        '
        ' picRAM
        '
        picRAM.BorderStyle = BorderStyle.FixedSingle
        picRAM.Location = New Point(1074, 413)
        picRAM.Margin = New Padding(3, 4, 3, 4)
        picRAM.Name = "picRAM"
        picRAM.Size = New Size(183, 186)
        picRAM.SizeMode = PictureBoxSizeMode.StretchImage
        picRAM.TabIndex = 33
        picRAM.TabStop = False
        '
        ' lblRAMPrice
        '
        lblRAMPrice.AutoSize = True
        lblRAMPrice.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblRAMPrice.Location = New Point(1131, 611)
        lblRAMPrice.Name = "lblRAMPrice"
        lblRAMPrice.Size = New Size(36, 20)
        lblRAMPrice.TabIndex = 34
        lblRAMPrice.Text = "£60"
        '
        ' lblSubtotalLabel
        '
        lblSubtotalLabel.AutoSize = True
        lblSubtotalLabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblSubtotalLabel.Location = New Point(994, 693)
        lblSubtotalLabel.Name = "lblSubtotalLabel"
        lblSubtotalLabel.Size = New Size(97, 28)
        lblSubtotalLabel.TabIndex = 35
        lblSubtotalLabel.Text = "Subtotal:"
        '
        ' lblSubtotalValue
        '
        lblSubtotalValue.AutoSize = True
        lblSubtotalValue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblSubtotalValue.Location = New Point(1131, 693)
        lblSubtotalValue.Name = "lblSubtotalValue"
        lblSubtotalValue.Size = New Size(36, 28)
        lblSubtotalValue.TabIndex = 36
        lblSubtotalValue.Text = "£0"
        '
        ' btnContinue
        '
        btnContinue.Font = New Font("Segoe UI", 14.0F)
        btnContinue.Location = New Point(1177, 747)
        btnContinue.Margin = New Padding(3, 4, 3, 4)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(160, 67)
        btnContinue.TabIndex = 37
        btnContinue.Text = "Continue"
        btnContinue.UseVisualStyleBackColor = True
        '
        ' Form2
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 840)
        Controls.Add(lblTitle)
        Controls.Add(lblMobo)
        Controls.Add(rbMoboAMD)
        Controls.Add(rbMoboIntel)
        Controls.Add(picMobo)
        Controls.Add(lblMoboPrice)
        Controls.Add(lblPSU)
        Controls.Add(rbPSU400)
        Controls.Add(rbPSU600)
        Controls.Add(rbPSU800)
        Controls.Add(picPSU)
        Controls.Add(lblPSUPrice)
        Controls.Add(lblHDD)
        Controls.Add(rbHDD1TB)
        Controls.Add(rbHDD2TB)
        Controls.Add(rbHDD4TB)
        Controls.Add(picHDD)
        Controls.Add(lblHDDPrice)
        Controls.Add(lblSSD)
        Controls.Add(rbSSD256)
        Controls.Add(rbSSD512)
        Controls.Add(picSSD)
        Controls.Add(lblSSDPrice)
        Controls.Add(lblCase)
        Controls.Add(rbCaseDesktop)
        Controls.Add(rbCaseTower)
        Controls.Add(rbCaseGaming)
        Controls.Add(picCase)
        Controls.Add(lblCasePrice)
        Controls.Add(lblRAM)
        Controls.Add(rbRAM4GB)
        Controls.Add(rbRAM8GB)
        Controls.Add(rbRAM16GB)
        Controls.Add(picRAM)
        Controls.Add(lblRAMPrice)
        Controls.Add(lblSubtotalLabel)
        Controls.Add(lblSubtotalValue)
        Controls.Add(btnContinue)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "ECCL – Component Selection"
        CType(picMobo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPSU, ComponentModel.ISupportInitialize).EndInit()
        CType(picHDD, ComponentModel.ISupportInitialize).EndInit()
        CType(picSSD, ComponentModel.ISupportInitialize).EndInit()
        CType(picCase, ComponentModel.ISupportInitialize).EndInit()
        CType(picRAM, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMobo As Label
    Friend WithEvents rbMoboAMD As RadioButton
    Friend WithEvents rbMoboIntel As RadioButton
    Friend WithEvents picMobo As PictureBox
    Friend WithEvents lblMoboPrice As Label
    Friend WithEvents lblPSU As Label
    Friend WithEvents rbPSU400 As RadioButton
    Friend WithEvents rbPSU600 As RadioButton
    Friend WithEvents rbPSU800 As RadioButton
    Friend WithEvents picPSU As PictureBox
    Friend WithEvents lblPSUPrice As Label
    Friend WithEvents lblHDD As Label
    Friend WithEvents rbHDD1TB As RadioButton
    Friend WithEvents rbHDD2TB As RadioButton
    Friend WithEvents rbHDD4TB As RadioButton
    Friend WithEvents picHDD As PictureBox
    Friend WithEvents lblHDDPrice As Label
    Friend WithEvents lblSSD As Label
    Friend WithEvents rbSSD256 As RadioButton
    Friend WithEvents rbSSD512 As RadioButton
    Friend WithEvents picSSD As PictureBox
    Friend WithEvents lblSSDPrice As Label
    Friend WithEvents lblCase As Label
    Friend WithEvents rbCaseDesktop As RadioButton
    Friend WithEvents rbCaseTower As RadioButton
    Friend WithEvents rbCaseGaming As RadioButton
    Friend WithEvents picCase As PictureBox
    Friend WithEvents lblCasePrice As Label
    Friend WithEvents lblRAM As Label
    Friend WithEvents rbRAM4GB As RadioButton
    Friend WithEvents rbRAM8GB As RadioButton
    Friend WithEvents rbRAM16GB As RadioButton
    Friend WithEvents picRAM As PictureBox
    Friend WithEvents lblRAMPrice As Label
    Friend WithEvents lblSubtotalLabel As Label
    Friend WithEvents lblSubtotalValue As Label
    Friend WithEvents btnContinue As Button

End Class