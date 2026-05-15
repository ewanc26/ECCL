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
        Me.lblTitle = New System.Windows.Forms.Label()

        ' Component Containers (GroupBoxes)
        Me.gbMobo = New System.Windows.Forms.GroupBox()
        Me.rbMoboAMD = New System.Windows.Forms.RadioButton()
        Me.rbMoboIntel = New System.Windows.Forms.RadioButton()
        Me.picMobo = New System.Windows.Forms.PictureBox()
        Me.lblMoboPrice = New System.Windows.Forms.Label()

        Me.gbPSU = New System.Windows.Forms.GroupBox()
        Me.rbPSU400 = New System.Windows.Forms.RadioButton()
        Me.rbPSU600 = New System.Windows.Forms.RadioButton()
        Me.rbPSU800 = New System.Windows.Forms.RadioButton()
        Me.picPSU = New System.Windows.Forms.PictureBox()
        Me.lblPSUPrice = New System.Windows.Forms.Label()

        Me.gbHDD = New System.Windows.Forms.GroupBox()
        Me.rbHDD1TB = New System.Windows.Forms.RadioButton()
        Me.rbHDD2TB = New System.Windows.Forms.RadioButton()
        Me.rbHDD4TB = New System.Windows.Forms.RadioButton()
        Me.picHDD = New System.Windows.Forms.PictureBox()
        Me.lblHDDPrice = New System.Windows.Forms.Label()

        Me.gbSSD = New System.Windows.Forms.GroupBox()
        Me.rbSSD256 = New System.Windows.Forms.RadioButton()
        Me.rbSSD512 = New System.Windows.Forms.RadioButton()
        Me.picSSD = New System.Windows.Forms.PictureBox()
        Me.lblSSDPrice = New System.Windows.Forms.Label()

        Me.gbCase = New System.Windows.Forms.GroupBox()
        Me.rbCaseDesktop = New System.Windows.Forms.RadioButton()
        Me.rbCaseTower = New System.Windows.Forms.RadioButton()
        Me.rbCaseGaming = New System.Windows.Forms.RadioButton()
        Me.picCase = New System.Windows.Forms.PictureBox()
        Me.lblCasePrice = New System.Windows.Forms.Label()

        Me.gbRAM = New System.Windows.Forms.GroupBox()
        Me.rbRAM4GB = New System.Windows.Forms.RadioButton()
        Me.rbRAM8GB = New System.Windows.Forms.RadioButton()
        Me.rbRAM16GB = New System.Windows.Forms.RadioButton()
        Me.picRAM = New System.Windows.Forms.PictureBox()
        Me.lblRAMPrice = New System.Windows.Forms.Label()

        Me.lblSubtotalLabel = New System.Windows.Forms.Label()
        Me.lblSubtotalValue = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()

        CType(Me.picMobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPSU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.gbMobo.SuspendLayout()
        Me.gbPSU.SuspendLayout()
        Me.gbHDD.SuspendLayout()
        Me.gbSSD.SuspendLayout()
        Me.gbCase.SuspendLayout()
        Me.gbRAM.SuspendLayout()
        Me.SuspendLayout()

        '
        ' lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(343, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(777, 67)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ECCL Component Selection"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '======================================================
        ' gbMobo
        '======================================================
        Me.gbMobo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbMobo.Location = New System.Drawing.Point(34, 100)
        Me.gbMobo.Name = "gbMobo"
        Me.gbMobo.Size = New System.Drawing.Size(380, 260)
        Me.gbMobo.TabIndex = 1
        Me.gbMobo.TabStop = False
        Me.gbMobo.Text = "Motherboard"

        Me.gbMobo.Controls.Add(Me.rbMoboAMD)
        Me.gbMobo.Controls.Add(Me.rbMoboIntel)
        Me.gbMobo.Controls.Add(Me.picMobo)
        Me.gbMobo.Controls.Add(Me.lblMoboPrice)

        Me.rbMoboAMD.AutoSize = True
        Me.rbMoboAMD.Checked = True
        Me.rbMoboAMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbMoboAMD.Location = New System.Drawing.Point(15, 40)
        Me.rbMoboAMD.Name = "rbMoboAMD"
        Me.rbMoboAMD.Size = New System.Drawing.Size(64, 24)
        Me.rbMoboAMD.TabIndex = 2
        Me.rbMoboAMD.TabStop = True
        Me.rbMoboAMD.Text = "AMD"

        Me.rbMoboIntel.AutoSize = True
        Me.rbMoboIntel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbMoboIntel.Location = New System.Drawing.Point(15, 75)
        Me.rbMoboIntel.Name = "rbMoboIntel"
        Me.rbMoboIntel.Size = New System.Drawing.Size(59, 24)
        Me.rbMoboIntel.TabIndex = 3
        Me.rbMoboIntel.Text = "Intel"

        Me.picMobo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMobo.Location = New System.Drawing.Point(170, 25)
        Me.picMobo.Name = "picMobo"
        Me.picMobo.Size = New System.Drawing.Size(183, 186)
        Me.picMobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMobo.TabIndex = 4
        Me.picMobo.TabStop = False

        Me.lblMoboPrice.AutoSize = True
        Me.lblMoboPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoboPrice.Location = New System.Drawing.Point(235, 225)
        Me.lblMoboPrice.Name = "lblMoboPrice"
        Me.lblMoboPrice.Size = New System.Drawing.Size(45, 20)
        Me.lblMoboPrice.TabIndex = 5
        Me.lblMoboPrice.Text = "£150"

        '======================================================
        ' gbPSU
        '======================================================
        Me.gbPSU.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbPSU.Location = New System.Drawing.Point(450, 100)
        Me.gbPSU.Name = "gbPSU"
        Me.gbPSU.Size = New System.Drawing.Size(380, 260)
        Me.gbPSU.TabIndex = 6
        Me.gbPSU.TabStop = False
        Me.gbPSU.Text = "Power Supply Unit"

        Me.gbPSU.Controls.Add(Me.rbPSU400)
        Me.gbPSU.Controls.Add(Me.rbPSU600)
        Me.gbPSU.Controls.Add(Me.rbPSU800)
        Me.gbPSU.Controls.Add(Me.picPSU)
        Me.gbPSU.Controls.Add(Me.lblPSUPrice)

        Me.rbPSU400.AutoSize = True
        Me.rbPSU400.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbPSU400.Location = New System.Drawing.Point(15, 40)
        Me.rbPSU400.Name = "rbPSU400"
        Me.rbPSU400.Size = New System.Drawing.Size(72, 24)
        Me.rbPSU400.TabIndex = 7
        Me.rbPSU400.Text = "400 W"

        Me.rbPSU600.AutoSize = True
        Me.rbPSU600.Checked = True
        Me.rbPSU600.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbPSU600.Location = New System.Drawing.Point(15, 75)
        Me.rbPSU600.Name = "rbPSU600"
        Me.rbPSU600.Size = New System.Drawing.Size(72, 24)
        Me.rbPSU600.TabIndex = 8
        Me.rbPSU600.TabStop = True
        Me.rbPSU600.Text = "600 W"

        Me.rbPSU800.AutoSize = True
        Me.rbPSU800.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbPSU800.Location = New System.Drawing.Point(15, 110)
        Me.rbPSU800.Name = "rbPSU800"
        Me.rbPSU800.Size = New System.Drawing.Size(72, 24)
        Me.rbPSU800.TabIndex = 9
        Me.rbPSU800.Text = "800 W"

        Me.picPSU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPSU.Location = New System.Drawing.Point(170, 25)
        Me.picPSU.Name = "picPSU"
        Me.picPSU.Size = New System.Drawing.Size(183, 186)
        Me.picPSU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPSU.TabIndex = 10
        Me.picPSU.TabStop = False

        Me.lblPSUPrice.AutoSize = True
        Me.lblPSUPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPSUPrice.Location = New System.Drawing.Point(235, 225)
        Me.lblPSUPrice.Name = "lblPSUPrice"
        Me.lblPSUPrice.Size = New System.Drawing.Size(36, 20)
        Me.lblPSUPrice.TabIndex = 11
        Me.lblPSUPrice.Text = "£30"

        '======================================================
        ' gbHDD
        '======================================================
        Me.gbHDD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbHDD.Location = New System.Drawing.Point(866, 100)
        Me.gbHDD.Name = "gbHDD"
        Me.gbHDD.Size = New System.Drawing.Size(380, 260)
        Me.gbHDD.TabIndex = 12
        Me.gbHDD.TabStop = False
        Me.gbHDD.Text = "Hard Disk Drive"

        Me.gbHDD.Controls.Add(Me.rbHDD1TB)
        Me.gbHDD.Controls.Add(Me.rbHDD2TB)
        Me.gbHDD.Controls.Add(Me.rbHDD4TB)
        Me.gbHDD.Controls.Add(Me.picHDD)
        Me.gbHDD.Controls.Add(Me.lblHDDPrice)

        Me.rbHDD1TB.AutoSize = True
        Me.rbHDD1TB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbHDD1TB.Location = New System.Drawing.Point(15, 40)
        Me.rbHDD1TB.Name = "rbHDD1TB"
        Me.rbHDD1TB.Size = New System.Drawing.Size(59, 24)
        Me.rbHDD1TB.TabIndex = 13
        Me.rbHDD1TB.Text = "1 TB"

        Me.rbHDD2TB.AutoSize = True
        Me.rbHDD2TB.Checked = True
        Me.rbHDD2TB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbHDD2TB.Location = New System.Drawing.Point(15, 75)
        Me.rbHDD2TB.Name = "rbHDD2TB"
        Me.rbHDD2TB.Size = New System.Drawing.Size(59, 24)
        Me.rbHDD2TB.TabIndex = 14
        Me.rbHDD2TB.TabStop = True
        Me.rbHDD2TB.Text = "2 TB"

        Me.rbHDD4TB.AutoSize = True
        Me.rbHDD4TB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbHDD4TB.Location = New System.Drawing.Point(15, 110)
        Me.rbHDD4TB.Name = "rbHDD4TB"
        Me.rbHDD4TB.Size = New System.Drawing.Size(59, 24)
        Me.rbHDD4TB.TabIndex = 15
        Me.rbHDD4TB.Text = "4 TB"

        Me.picHDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHDD.Location = New System.Drawing.Point(170, 25)
        Me.picHDD.Name = "picHDD"
        Me.picHDD.Size = New System.Drawing.Size(183, 186)
        Me.picHDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHDD.TabIndex = 16
        Me.picHDD.TabStop = False

        Me.lblHDDPrice.AutoSize = True
        Me.lblHDDPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHDDPrice.Location = New System.Drawing.Point(235, 225)
        Me.lblHDDPrice.Name = "lblHDDPrice"
        Me.lblHDDPrice.Size = New System.Drawing.Size(45, 20)
        Me.lblHDDPrice.TabIndex = 17
        Me.lblHDDPrice.Text = "£100"

        '======================================================
        ' gbSSD
        '======================================================
        Me.gbSSD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbSSD.Location = New System.Drawing.Point(34, 400)
        Me.gbSSD.Name = "gbSSD"
        Me.gbSSD.Size = New System.Drawing.Size(380, 260)
        Me.gbSSD.TabIndex = 18
        Me.gbSSD.TabStop = False
        Me.gbSSD.Text = "Solid State Drive"

        Me.gbSSD.Controls.Add(Me.rbSSD256)
        Me.gbSSD.Controls.Add(Me.rbSSD512)
        Me.gbSSD.Controls.Add(Me.picSSD)
        Me.gbSSD.Controls.Add(Me.lblSSDPrice)

        Me.rbSSD256.AutoSize = True
        Me.rbSSD256.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbSSD256.Location = New System.Drawing.Point(15, 40)
        Me.rbSSD256.Name = "rbSSD256"
        Me.rbSSD256.Size = New System.Drawing.Size(77, 24)
        Me.rbSSD256.TabIndex = 19
        Me.rbSSD256.Text = "256 GB"

        Me.rbSSD512.AutoSize = True
        Me.rbSSD512.Checked = True
        Me.rbSSD512.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbSSD512.Location = New System.Drawing.Point(15, 75)
        Me.rbSSD512.Name = "rbSSD512"
        Me.rbSSD512.Size = New System.Drawing.Size(77, 24)
        Me.rbSSD512.TabIndex = 20
        Me.rbSSD512.TabStop = True
        Me.rbSSD512.Text = "512 GB"

        Me.picSSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSSD.Location = New System.Drawing.Point(170, 25)
        Me.picSSD.Name = "picSSD"
        Me.picSSD.Size = New System.Drawing.Size(183, 186)
        Me.picSSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSSD.TabIndex = 21
        Me.picSSD.TabStop = False

        Me.lblSSDPrice.AutoSize = True
        Me.lblSSDPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSSDPrice.Location = New System.Drawing.Point(235, 225)
        Me.lblSSDPrice.Name = "lblSSDPrice"
        Me.lblSSDPrice.Size = New System.Drawing.Size(36, 20)
        Me.lblSSDPrice.TabIndex = 22
        Me.lblSSDPrice.Text = "£90"

        '======================================================
        ' gbCase
        '======================================================
        Me.gbCase.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbCase.Location = New System.Drawing.Point(450, 400)
        Me.gbCase.Name = "gbCase"
        Me.gbCase.Size = New System.Drawing.Size(380, 260)
        Me.gbCase.TabIndex = 23
        Me.gbCase.TabStop = False
        Me.gbCase.Text = "Case"

        Me.gbCase.Controls.Add(Me.rbCaseDesktop)
        Me.gbCase.Controls.Add(Me.rbCaseTower)
        Me.gbCase.Controls.Add(Me.rbCaseGaming)
        Me.gbCase.Controls.Add(Me.picCase)
        Me.gbCase.Controls.Add(Me.lblCasePrice)

        Me.rbCaseDesktop.AutoSize = True
        Me.rbCaseDesktop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbCaseDesktop.Location = New System.Drawing.Point(15, 40)
        Me.rbCaseDesktop.Name = "rbCaseDesktop"
        Me.rbCaseDesktop.Size = New System.Drawing.Size(85, 24)
        Me.rbCaseDesktop.TabIndex = 24
        Me.rbCaseDesktop.Text = "Desktop"

        Me.rbCaseTower.AutoSize = True
        Me.rbCaseTower.Checked = True
        Me.rbCaseTower.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbCaseTower.Location = New System.Drawing.Point(15, 75)
        Me.rbCaseTower.Name = "rbCaseTower"
        Me.rbCaseTower.Size = New System.Drawing.Size(70, 24)
        Me.rbCaseTower.TabIndex = 25
        Me.rbCaseTower.TabStop = True
        Me.rbCaseTower.Text = "Tower"

        Me.rbCaseGaming.AutoSize = True
        Me.rbCaseGaming.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbCaseGaming.Location = New System.Drawing.Point(15, 110)
        Me.rbCaseGaming.Name = "rbCaseGaming"
        Me.rbCaseGaming.Size = New System.Drawing.Size(82, 24)
        Me.rbCaseGaming.TabIndex = 26
        Me.rbCaseGaming.Text = "Gaming"

        Me.picCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCase.Location = New System.Drawing.Point(170, 25)
        Me.picCase.Name = "picCase"
        Me.picCase.Size = New System.Drawing.Size(183, 186)
        Me.picCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCase.TabIndex = 27
        Me.picCase.TabStop = False

        Me.lblCasePrice.AutoSize = True
        Me.lblCasePrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCasePrice.Location = New System.Drawing.Point(235, 225)
        Me.lblCasePrice.Name = "lblCasePrice"
        Me.lblCasePrice.Size = New System.Drawing.Size(45, 20)
        Me.lblCasePrice.TabIndex = 28
        Me.lblCasePrice.Text = "£150"

        '======================================================
        ' gbRAM
        '======================================================
        Me.gbRAM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbRAM.Location = New System.Drawing.Point(866, 400)
        Me.gbRAM.Name = "gbRAM"
        Me.gbRAM.Size = New System.Drawing.Size(380, 260)
        Me.gbRAM.TabIndex = 29
        Me.gbRAM.TabStop = False
        Me.gbRAM.Text = "Random Access Memory"

        Me.gbRAM.Controls.Add(Me.rbRAM4GB)
        Me.gbRAM.Controls.Add(Me.rbRAM8GB)
        Me.gbRAM.Controls.Add(Me.rbRAM16GB)
        Me.gbRAM.Controls.Add(Me.picRAM)
        Me.gbRAM.Controls.Add(Me.lblRAMPrice)

        Me.rbRAM4GB.AutoSize = True
        Me.rbRAM4GB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbRAM4GB.Location = New System.Drawing.Point(15, 40)
        Me.rbRAM4GB.Name = "rbRAM4GB"
        Me.rbRAM4GB.Size = New System.Drawing.Size(61, 24)
        Me.rbRAM4GB.TabIndex = 30
        Me.rbRAM4GB.Text = "4 GB"

        Me.rbRAM8GB.AutoSize = True
        Me.rbRAM8GB.Checked = True
        Me.rbRAM8GB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbRAM8GB.Location = New System.Drawing.Point(15, 75)
        Me.rbRAM8GB.Name = "rbRAM8GB"
        Me.rbRAM8GB.Size = New System.Drawing.Size(61, 24)
        Me.rbRAM8GB.TabIndex = 31
        Me.rbRAM8GB.TabStop = True
        Me.rbRAM8GB.Text = "8 GB"

        Me.rbRAM16GB.AutoSize = True
        Me.rbRAM16GB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbRAM16GB.Location = New System.Drawing.Point(15, 110)
        Me.rbRAM16GB.Name = "rbRAM16GB"
        Me.rbRAM16GB.Size = New System.Drawing.Size(69, 24)
        Me.rbRAM16GB.TabIndex = 32
        Me.rbRAM16GB.Text = "16 GB"

        Me.picRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRAM.Location = New System.Drawing.Point(170, 25)
        Me.picRAM.Name = "picRAM"
        Me.picRAM.Size = New System.Drawing.Size(183, 186)
        Me.picRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRAM.TabIndex = 33
        Me.picRAM.TabStop = False

        Me.lblRAMPrice.AutoSize = True
        Me.lblRAMPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRAMPrice.Location = New System.Drawing.Point(235, 225)
        Me.lblRAMPrice.Name = "lblRAMPrice"
        Me.lblRAMPrice.Size = New System.Drawing.Size(36, 20)
        Me.lblRAMPrice.TabIndex = 34
        Me.lblRAMPrice.Text = "£60"

        '======================================================
        ' Subtotal & Continue Button
        '======================================================
        Me.lblSubtotalLabel.AutoSize = True
        Me.lblSubtotalLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubtotalLabel.Location = New System.Drawing.Point(994, 693)
        Me.lblSubtotalLabel.Name = "lblSubtotalLabel"
        Me.lblSubtotalLabel.Size = New System.Drawing.Size(97, 28)
        Me.lblSubtotalLabel.TabIndex = 35
        Me.lblSubtotalLabel.Text = "Subtotal:"

        Me.lblSubtotalValue.AutoSize = True
        Me.lblSubtotalValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubtotalValue.Location = New System.Drawing.Point(1131, 693)
        Me.lblSubtotalValue.Name = "lblSubtotalValue"
        Me.lblSubtotalValue.Size = New System.Drawing.Size(36, 28)
        Me.lblSubtotalValue.TabIndex = 36
        Me.lblSubtotalValue.Text = "£0"

        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.btnContinue.Location = New System.Drawing.Point(1086, 747)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(160, 67)
        Me.btnContinue.TabIndex = 37
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True

        '======================================================
        ' Form2
        '======================================================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 840)

        ' Add GroupBoxes and other root controls to the form
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gbMobo)
        Me.Controls.Add(Me.gbPSU)
        Me.Controls.Add(Me.gbHDD)
        Me.Controls.Add(Me.gbSSD)
        Me.Controls.Add(Me.gbCase)
        Me.Controls.Add(Me.gbRAM)
        Me.Controls.Add(Me.lblSubtotalLabel)
        Me.Controls.Add(Me.lblSubtotalValue)
        Me.Controls.Add(Me.btnContinue)

        Me.Name = "Form2"
        Me.Text = "ECCL – Component Selection"

        CType(Me.picMobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPSU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).EndInit()

        Me.gbMobo.ResumeLayout(False)
        Me.gbMobo.PerformLayout()
        Me.gbPSU.ResumeLayout(False)
        Me.gbPSU.PerformLayout()
        Me.gbHDD.ResumeLayout(False)
        Me.gbHDD.PerformLayout()
        Me.gbSSD.ResumeLayout(False)
        Me.gbSSD.PerformLayout()
        Me.gbCase.ResumeLayout(False)
        Me.gbCase.PerformLayout()
        Me.gbRAM.ResumeLayout(False)
        Me.gbRAM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label

    Friend WithEvents gbMobo As GroupBox
    Friend WithEvents rbMoboAMD As RadioButton
    Friend WithEvents rbMoboIntel As RadioButton
    Friend WithEvents picMobo As PictureBox
    Friend WithEvents lblMoboPrice As Label

    Friend WithEvents gbPSU As GroupBox
    Friend WithEvents rbPSU400 As RadioButton
    Friend WithEvents rbPSU600 As RadioButton
    Friend WithEvents rbPSU800 As RadioButton
    Friend WithEvents picPSU As PictureBox
    Friend WithEvents lblPSUPrice As Label

    Friend WithEvents gbHDD As GroupBox
    Friend WithEvents rbHDD1TB As RadioButton
    Friend WithEvents rbHDD2TB As RadioButton
    Friend WithEvents rbHDD4TB As RadioButton
    Friend WithEvents picHDD As PictureBox
    Friend WithEvents lblHDDPrice As Label

    Friend WithEvents gbSSD As GroupBox
    Friend WithEvents rbSSD256 As RadioButton
    Friend WithEvents rbSSD512 As RadioButton
    Friend WithEvents picSSD As PictureBox
    Friend WithEvents lblSSDPrice As Label

    Friend WithEvents gbCase As GroupBox
    Friend WithEvents rbCaseDesktop As RadioButton
    Friend WithEvents rbCaseTower As RadioButton
    Friend WithEvents rbCaseGaming As RadioButton
    Friend WithEvents picCase As PictureBox
    Friend WithEvents lblCasePrice As Label

    Friend WithEvents gbRAM As GroupBox
    Friend WithEvents rbRAM4GB As RadioButton
    Friend WithEvents rbRAM8GB As RadioButton
    Friend WithEvents rbRAM16GB As RadioButton
    Friend WithEvents picRAM As PictureBox
    Friend WithEvents lblRAMPrice As Label

    Friend WithEvents lblSubtotalLabel As Label
    Friend WithEvents lblSubtotalValue As Label
    Friend WithEvents btnContinue As Button

End Class