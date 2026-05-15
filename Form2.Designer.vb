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
        ' ── Title ──────────────────────────────────────────────────────────────
        lblTitle = New Label()
        ' ── Motherboard ─────────────────────────────────────────────────────────
        lblMobo = New Label()
        rbMoboAMD = New RadioButton()
        rbMoboIntel = New RadioButton()
        picMobo = New PictureBox()
        lblMoboPrice = New Label()
        ' ── PSU ─────────────────────────────────────────────────────────────────
        lblPSU = New Label()
        rbPSU400 = New RadioButton()
        rbPSU600 = New RadioButton()
        rbPSU800 = New RadioButton()
        picPSU = New PictureBox()
        lblPSUPrice = New Label()
        ' ── HDD ─────────────────────────────────────────────────────────────────
        lblHDD = New Label()
        rbHDD1TB = New RadioButton()
        rbHDD2TB = New RadioButton()
        rbHDD4TB = New RadioButton()
        picHDD = New PictureBox()
        lblHDDPrice = New Label()
        ' ── SSD ─────────────────────────────────────────────────────────────────
        lblSSD = New Label()
        rbSSD256 = New RadioButton()
        rbSSD512 = New RadioButton()
        picSSD = New PictureBox()
        lblSSDPrice = New Label()
        ' ── Case ────────────────────────────────────────────────────────────────
        lblCase = New Label()
        rbCaseDesktop = New RadioButton()
        rbCaseTower = New RadioButton()
        rbCaseGaming = New RadioButton()
        picCase = New PictureBox()
        lblCasePrice = New Label()
        ' ── RAM ─────────────────────────────────────────────────────────────────
        lblRAM = New Label()
        rbRAM4GB = New RadioButton()
        rbRAM8GB = New RadioButton()
        rbRAM16GB = New RadioButton()
        picRAM = New PictureBox()
        lblRAMPrice = New Label()
        ' ── Summary ─────────────────────────────────────────────────────────────
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

        ' ── lblTitle ────────────────────────────────────────────────────────────
        lblTitle.AutoSize = False
        lblTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTitle.Location = New Point(300, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(680, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ECCL Component Selection"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        ' ══ ROW 1 ══════════════════════════════════════════════════════════════

        ' ── lblMobo ─────────────────────────────────────────────────────────────
        lblMobo.AutoSize = True
        lblMobo.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblMobo.Location = New Point(30, 80)
        lblMobo.Name = "lblMobo"
        lblMobo.TabIndex = 1
        lblMobo.Text = "Motherboard"

        ' ── rbMoboAMD ───────────────────────────────────────────────────────────
        rbMoboAMD.AutoSize = True
        rbMoboAMD.Checked = True
        rbMoboAMD.Location = New Point(30, 110)
        rbMoboAMD.Name = "rbMoboAMD"
        rbMoboAMD.TabIndex = 2
        rbMoboAMD.TabStop = True
        rbMoboAMD.Text = "AMD"

        ' ── rbMoboIntel ─────────────────────────────────────────────────────────
        rbMoboIntel.AutoSize = True
        rbMoboIntel.Location = New Point(30, 135)
        rbMoboIntel.Name = "rbMoboIntel"
        rbMoboIntel.TabIndex = 3
        rbMoboIntel.Text = "Intel"

        ' ── picMobo ─────────────────────────────────────────────────────────────
        picMobo.BorderStyle = BorderStyle.FixedSingle
        picMobo.Location = New Point(180, 80)
        picMobo.Name = "picMobo"
        picMobo.Size = New Size(160, 140)
        picMobo.SizeMode = PictureBoxSizeMode.Zoom
        picMobo.TabIndex = 4
        picMobo.TabStop = False

        ' ── lblMoboPrice ────────────────────────────────────────────────────────
        lblMoboPrice.AutoSize = True
        lblMoboPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblMoboPrice.Location = New Point(225, 228)
        lblMoboPrice.Name = "lblMoboPrice"
        lblMoboPrice.TabIndex = 5
        lblMoboPrice.Text = "£150"

        ' ── lblPSU ──────────────────────────────────────────────────────────────
        lblPSU.AutoSize = True
        lblPSU.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPSU.Location = New Point(400, 80)
        lblPSU.Name = "lblPSU"
        lblPSU.TabIndex = 6
        lblPSU.Text = "Power Supply Unit"

        ' ── rbPSU400 ────────────────────────────────────────────────────────────
        rbPSU400.AutoSize = True
        rbPSU400.Location = New Point(400, 110)
        rbPSU400.Name = "rbPSU400"
        rbPSU400.TabIndex = 7
        rbPSU400.Text = "400 W"

        ' ── rbPSU600 ────────────────────────────────────────────────────────────
        rbPSU600.AutoSize = True
        rbPSU600.Checked = True
        rbPSU600.Location = New Point(400, 135)
        rbPSU600.Name = "rbPSU600"
        rbPSU600.TabIndex = 8
        rbPSU600.TabStop = True
        rbPSU600.Text = "600 W"

        ' ── rbPSU800 ────────────────────────────────────────────────────────────
        rbPSU800.AutoSize = True
        rbPSU800.Location = New Point(400, 160)
        rbPSU800.Name = "rbPSU800"
        rbPSU800.TabIndex = 9
        rbPSU800.Text = "800 W"

        ' ── picPSU ──────────────────────────────────────────────────────────────
        picPSU.BorderStyle = BorderStyle.FixedSingle
        picPSU.Location = New Point(560, 80)
        picPSU.Name = "picPSU"
        picPSU.Size = New Size(160, 140)
        picPSU.SizeMode = PictureBoxSizeMode.Zoom
        picPSU.TabIndex = 10
        picPSU.TabStop = False

        ' ── lblPSUPrice ─────────────────────────────────────────────────────────
        lblPSUPrice.AutoSize = True
        lblPSUPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPSUPrice.Location = New Point(610, 228)
        lblPSUPrice.Name = "lblPSUPrice"
        lblPSUPrice.TabIndex = 11
        lblPSUPrice.Text = "£30"

        ' ── lblHDD ──────────────────────────────────────────────────────────────
        lblHDD.AutoSize = True
        lblHDD.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblHDD.Location = New Point(780, 80)
        lblHDD.Name = "lblHDD"
        lblHDD.TabIndex = 12
        lblHDD.Text = "Hard Disk Drive"

        ' ── rbHDD1TB ────────────────────────────────────────────────────────────
        rbHDD1TB.AutoSize = True
        rbHDD1TB.Location = New Point(780, 110)
        rbHDD1TB.Name = "rbHDD1TB"
        rbHDD1TB.TabIndex = 13
        rbHDD1TB.Text = "1 TB"

        ' ── rbHDD2TB ────────────────────────────────────────────────────────────
        rbHDD2TB.AutoSize = True
        rbHDD2TB.Checked = True
        rbHDD2TB.Location = New Point(780, 135)
        rbHDD2TB.Name = "rbHDD2TB"
        rbHDD2TB.TabIndex = 14
        rbHDD2TB.TabStop = True
        rbHDD2TB.Text = "2 TB"

        ' ── rbHDD4TB ────────────────────────────────────────────────────────────
        rbHDD4TB.AutoSize = True
        rbHDD4TB.Location = New Point(780, 160)
        rbHDD4TB.Name = "rbHDD4TB"
        rbHDD4TB.TabIndex = 15
        rbHDD4TB.Text = "4 TB"

        ' ── picHDD ──────────────────────────────────────────────────────────────
        picHDD.BorderStyle = BorderStyle.FixedSingle
        picHDD.Location = New Point(940, 80)
        picHDD.Name = "picHDD"
        picHDD.Size = New Size(160, 140)
        picHDD.SizeMode = PictureBoxSizeMode.Zoom
        picHDD.TabIndex = 16
        picHDD.TabStop = False

        ' ── lblHDDPrice ─────────────────────────────────────────────────────────
        lblHDDPrice.AutoSize = True
        lblHDDPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHDDPrice.Location = New Point(990, 228)
        lblHDDPrice.Name = "lblHDDPrice"
        lblHDDPrice.TabIndex = 17
        lblHDDPrice.Text = "£100"

        ' ══ ROW 2 ══════════════════════════════════════════════════════════════

        ' ── lblSSD ──────────────────────────────────────────────────────────────
        lblSSD.AutoSize = True
        lblSSD.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSSD.Location = New Point(30, 310)
        lblSSD.Name = "lblSSD"
        lblSSD.TabIndex = 18
        lblSSD.Text = "Solid State Drive"

        ' ── rbSSD256 ────────────────────────────────────────────────────────────
        rbSSD256.AutoSize = True
        rbSSD256.Location = New Point(30, 340)
        rbSSD256.Name = "rbSSD256"
        rbSSD256.TabIndex = 19
        rbSSD256.Text = "256 GB"

        ' ── rbSSD512 ────────────────────────────────────────────────────────────
        rbSSD512.AutoSize = True
        rbSSD512.Checked = True
        rbSSD512.Location = New Point(30, 365)
        rbSSD512.Name = "rbSSD512"
        rbSSD512.TabIndex = 20
        rbSSD512.TabStop = True
        rbSSD512.Text = "512 GB"

        ' ── picSSD ──────────────────────────────────────────────────────────────
        picSSD.BorderStyle = BorderStyle.FixedSingle
        picSSD.Location = New Point(180, 310)
        picSSD.Name = "picSSD"
        picSSD.Size = New Size(160, 140)
        picSSD.SizeMode = PictureBoxSizeMode.Zoom
        picSSD.TabIndex = 21
        picSSD.TabStop = False

        ' ── lblSSDPrice ─────────────────────────────────────────────────────────
        lblSSDPrice.AutoSize = True
        lblSSDPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSSDPrice.Location = New Point(225, 458)
        lblSSDPrice.Name = "lblSSDPrice"
        lblSSDPrice.TabIndex = 22
        lblSSDPrice.Text = "£90"

        ' ── lblCase ─────────────────────────────────────────────────────────────
        lblCase.AutoSize = True
        lblCase.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCase.Location = New Point(400, 310)
        lblCase.Name = "lblCase"
        lblCase.TabIndex = 23
        lblCase.Text = "Case"

        ' ── rbCaseDesktop ───────────────────────────────────────────────────────
        rbCaseDesktop.AutoSize = True
        rbCaseDesktop.Location = New Point(400, 340)
        rbCaseDesktop.Name = "rbCaseDesktop"
        rbCaseDesktop.TabIndex = 24
        rbCaseDesktop.Text = "Desktop"

        ' ── rbCaseTower ─────────────────────────────────────────────────────────
        rbCaseTower.AutoSize = True
        rbCaseTower.Checked = True
        rbCaseTower.Location = New Point(400, 365)
        rbCaseTower.Name = "rbCaseTower"
        rbCaseTower.TabIndex = 25
        rbCaseTower.TabStop = True
        rbCaseTower.Text = "Tower"

        ' ── rbCaseGaming ────────────────────────────────────────────────────────
        rbCaseGaming.AutoSize = True
        rbCaseGaming.Location = New Point(400, 390)
        rbCaseGaming.Name = "rbCaseGaming"
        rbCaseGaming.TabIndex = 26
        rbCaseGaming.Text = "Gaming"

        ' ── picCase ─────────────────────────────────────────────────────────────
        picCase.BorderStyle = BorderStyle.FixedSingle
        picCase.Location = New Point(560, 310)
        picCase.Name = "picCase"
        picCase.Size = New Size(160, 140)
        picCase.SizeMode = PictureBoxSizeMode.Zoom
        picCase.TabIndex = 27
        picCase.TabStop = False

        ' ── lblCasePrice ────────────────────────────────────────────────────────
        lblCasePrice.AutoSize = True
        lblCasePrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCasePrice.Location = New Point(610, 458)
        lblCasePrice.Name = "lblCasePrice"
        lblCasePrice.TabIndex = 28
        lblCasePrice.Text = "£150"

        ' ── lblRAM ──────────────────────────────────────────────────────────────
        lblRAM.AutoSize = True
        lblRAM.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblRAM.Location = New Point(780, 310)
        lblRAM.Name = "lblRAM"
        lblRAM.TabIndex = 29
        lblRAM.Text = "Random Access Memory"

        ' ── rbRAM4GB ────────────────────────────────────────────────────────────
        rbRAM4GB.AutoSize = True
        rbRAM4GB.Location = New Point(780, 340)
        rbRAM4GB.Name = "rbRAM4GB"
        rbRAM4GB.TabIndex = 30
        rbRAM4GB.Text = "4 GB"

        ' ── rbRAM8GB ────────────────────────────────────────────────────────────
        rbRAM8GB.AutoSize = True
        rbRAM8GB.Checked = True
        rbRAM8GB.Location = New Point(780, 365)
        rbRAM8GB.Name = "rbRAM8GB"
        rbRAM8GB.TabIndex = 31
        rbRAM8GB.TabStop = True
        rbRAM8GB.Text = "8 GB"

        ' ── rbRAM16GB ───────────────────────────────────────────────────────────
        rbRAM16GB.AutoSize = True
        rbRAM16GB.Location = New Point(780, 390)
        rbRAM16GB.Name = "rbRAM16GB"
        rbRAM16GB.TabIndex = 32
        rbRAM16GB.Text = "16 GB"

        ' ── picRAM ──────────────────────────────────────────────────────────────
        picRAM.BorderStyle = BorderStyle.FixedSingle
        picRAM.Location = New Point(940, 310)
        picRAM.Name = "picRAM"
        picRAM.Size = New Size(160, 140)
        picRAM.SizeMode = PictureBoxSizeMode.Zoom
        picRAM.TabIndex = 33
        picRAM.TabStop = False

        ' ── lblRAMPrice ─────────────────────────────────────────────────────────
        lblRAMPrice.AutoSize = True
        lblRAMPrice.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRAMPrice.Location = New Point(990, 458)
        lblRAMPrice.Name = "lblRAMPrice"
        lblRAMPrice.TabIndex = 34
        lblRAMPrice.Text = "£60"

        ' ══ SUMMARY ════════════════════════════════════════════════════════════

        ' ── lblSubtotalLabel ────────────────────────────────────────────────────
        lblSubtotalLabel.AutoSize = True
        lblSubtotalLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSubtotalLabel.Location = New Point(870, 520)
        lblSubtotalLabel.Name = "lblSubtotalLabel"
        lblSubtotalLabel.TabIndex = 35
        lblSubtotalLabel.Text = "Subtotal:"

        ' ── lblSubtotalValue ────────────────────────────────────────────────────
        lblSubtotalValue.AutoSize = True
        lblSubtotalValue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSubtotalValue.Location = New Point(990, 520)
        lblSubtotalValue.Name = "lblSubtotalValue"
        lblSubtotalValue.TabIndex = 36
        lblSubtotalValue.Text = "£0"

        ' ── btnContinue ─────────────────────────────────────────────────────────
        btnContinue.Font = New Font("Segoe UI", 14F)
        btnContinue.Location = New Point(1030, 560)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(140, 50)
        btnContinue.TabIndex = 37
        btnContinue.Text = "Continue"
        btnContinue.UseVisualStyleBackColor = True

        ' ── Form2 ───────────────────────────────────────────────────────────────
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 630)
        Text = "ECCL – Component Selection"

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
