<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataEntryScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.txtPetSpecies = New System.Windows.Forms.TextBox()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblPetSpecies = New System.Windows.Forms.Label()
        Me.chkOfficeVisit = New System.Windows.Forms.CheckBox()
        Me.chkSpecimenExam = New System.Windows.Forms.CheckBox()
        Me.chkXRay = New System.Windows.Forms.CheckBox()
        Me.chkVaccination = New System.Windows.Forms.CheckBox()
        Me.grpUser = New System.Windows.Forms.GroupBox()
        Me.chkHigh = New System.Windows.Forms.CheckBox()
        Me.chkLow = New System.Windows.Forms.CheckBox()
        Me.grpPetInfomation = New System.Windows.Forms.GroupBox()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.grpVaccineOptions = New System.Windows.Forms.GroupBox()
        Me.chkAntibaV = New System.Windows.Forms.CheckBox()
        Me.chkKennelCough = New System.Windows.Forms.CheckBox()
        Me.chkRabies = New System.Windows.Forms.CheckBox()
        Me.txtPetWeight = New System.Windows.Forms.TextBox()
        Me.lblPetWeight = New System.Windows.Forms.Label()
        Me.grpAntibaVPetInfo = New System.Windows.Forms.GroupBox()
        Me.chkMedium = New System.Windows.Forms.CheckBox()
        Me.chkLarge = New System.Windows.Forms.CheckBox()
        Me.chkSmall = New System.Windows.Forms.CheckBox()
        Me.BtnTotal = New System.Windows.Forms.Button()
        Me.grpReceiptScreen = New System.Windows.Forms.GroupBox()
        Me.txtReceipt = New System.Windows.Forms.RichTextBox()
        Me.grpUser.SuspendLayout()
        Me.grpPetInfomation.SuspendLayout()
        Me.grpServices.SuspendLayout()
        Me.grpVaccineOptions.SuspendLayout()
        Me.grpAntibaVPetInfo.SuspendLayout()
        Me.grpReceiptScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(200, 67)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(245, 38)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(200, 199)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(245, 38)
        Me.txtLastName.TabIndex = 1
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Location = New System.Drawing.Point(200, 131)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(245, 38)
        Me.txtMiddleInitial.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(15, 73)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(152, 32)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(15, 137)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(175, 32)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.Text = "Middle Initial"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(15, 205)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(151, 32)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(200, 314)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(245, 38)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(15, 320)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(164, 32)
        Me.lblPhoneNumber.TabIndex = 7
        Me.lblPhoneNumber.Text = "Phone Num"
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(206, 54)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(245, 38)
        Me.txtPetName.TabIndex = 8
        '
        'txtPetSpecies
        '
        Me.txtPetSpecies.Location = New System.Drawing.Point(206, 124)
        Me.txtPetSpecies.Name = "txtPetSpecies"
        Me.txtPetSpecies.Size = New System.Drawing.Size(245, 38)
        Me.txtPetSpecies.TabIndex = 9
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Location = New System.Drawing.Point(21, 60)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(140, 32)
        Me.lblPetName.TabIndex = 10
        Me.lblPetName.Text = "Pet Name"
        '
        'lblPetSpecies
        '
        Me.lblPetSpecies.AutoSize = True
        Me.lblPetSpecies.Location = New System.Drawing.Point(21, 127)
        Me.lblPetSpecies.Name = "lblPetSpecies"
        Me.lblPetSpecies.Size = New System.Drawing.Size(167, 32)
        Me.lblPetSpecies.TabIndex = 11
        Me.lblPetSpecies.Text = "Pet Species"
        '
        'chkOfficeVisit
        '
        Me.chkOfficeVisit.AutoSize = True
        Me.chkOfficeVisit.Location = New System.Drawing.Point(17, 48)
        Me.chkOfficeVisit.Name = "chkOfficeVisit"
        Me.chkOfficeVisit.Size = New System.Drawing.Size(190, 36)
        Me.chkOfficeVisit.TabIndex = 14
        Me.chkOfficeVisit.Text = "Office Visit"
        Me.chkOfficeVisit.UseVisualStyleBackColor = True
        '
        'chkSpecimenExam
        '
        Me.chkSpecimenExam.AutoSize = True
        Me.chkSpecimenExam.Location = New System.Drawing.Point(416, 48)
        Me.chkSpecimenExam.Name = "chkSpecimenExam"
        Me.chkSpecimenExam.Size = New System.Drawing.Size(259, 36)
        Me.chkSpecimenExam.TabIndex = 15
        Me.chkSpecimenExam.Text = "Specimen Exam"
        Me.chkSpecimenExam.UseVisualStyleBackColor = True
        '
        'chkXRay
        '
        Me.chkXRay.AutoSize = True
        Me.chkXRay.Location = New System.Drawing.Point(254, 48)
        Me.chkXRay.Name = "chkXRay"
        Me.chkXRay.Size = New System.Drawing.Size(131, 36)
        Me.chkXRay.TabIndex = 16
        Me.chkXRay.Text = "X-Ray"
        Me.chkXRay.UseVisualStyleBackColor = True
        '
        'chkVaccination
        '
        Me.chkVaccination.AutoSize = True
        Me.chkVaccination.Location = New System.Drawing.Point(695, 48)
        Me.chkVaccination.Name = "chkVaccination"
        Me.chkVaccination.Size = New System.Drawing.Size(202, 36)
        Me.chkVaccination.TabIndex = 17
        Me.chkVaccination.Text = "Vaccination"
        Me.chkVaccination.UseVisualStyleBackColor = True
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.chkHigh)
        Me.grpUser.Controls.Add(Me.chkLow)
        Me.grpUser.Controls.Add(Me.txtFirstName)
        Me.grpUser.Controls.Add(Me.txtLastName)
        Me.grpUser.Controls.Add(Me.txtMiddleInitial)
        Me.grpUser.Controls.Add(Me.lblFirstName)
        Me.grpUser.Controls.Add(Me.lblMiddleName)
        Me.grpUser.Controls.Add(Me.lblLastName)
        Me.grpUser.Controls.Add(Me.txtPhoneNumber)
        Me.grpUser.Controls.Add(Me.lblPhoneNumber)
        Me.grpUser.Location = New System.Drawing.Point(61, 65)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(485, 489)
        Me.grpUser.TabIndex = 22
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User Information"
        '
        'chkHigh
        '
        Me.chkHigh.AutoSize = True
        Me.chkHigh.Location = New System.Drawing.Point(231, 410)
        Me.chkHigh.Name = "chkHigh"
        Me.chkHigh.Size = New System.Drawing.Size(211, 36)
        Me.chkHigh.TabIndex = 9
        Me.chkHigh.Text = "High Income"
        Me.chkHigh.UseVisualStyleBackColor = True
        '
        'chkLow
        '
        Me.chkLow.AutoSize = True
        Me.chkLow.Location = New System.Drawing.Point(21, 410)
        Me.chkLow.Name = "chkLow"
        Me.chkLow.Size = New System.Drawing.Size(204, 36)
        Me.chkLow.TabIndex = 8
        Me.chkLow.Text = "Low Income"
        Me.chkLow.UseVisualStyleBackColor = True
        '
        'grpPetInfomation
        '
        Me.grpPetInfomation.Controls.Add(Me.txtPetSpecies)
        Me.grpPetInfomation.Controls.Add(Me.txtPetName)
        Me.grpPetInfomation.Controls.Add(Me.lblPetName)
        Me.grpPetInfomation.Controls.Add(Me.lblPetSpecies)
        Me.grpPetInfomation.Location = New System.Drawing.Point(61, 606)
        Me.grpPetInfomation.Name = "grpPetInfomation"
        Me.grpPetInfomation.Size = New System.Drawing.Size(485, 195)
        Me.grpPetInfomation.TabIndex = 23
        Me.grpPetInfomation.TabStop = False
        Me.grpPetInfomation.Text = "Pet Infomation"
        '
        'grpServices
        '
        Me.grpServices.Controls.Add(Me.chkVaccination)
        Me.grpServices.Controls.Add(Me.chkOfficeVisit)
        Me.grpServices.Controls.Add(Me.chkSpecimenExam)
        Me.grpServices.Controls.Add(Me.chkXRay)
        Me.grpServices.Location = New System.Drawing.Point(737, 65)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(903, 100)
        Me.grpServices.TabIndex = 24
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Services"
        '
        'grpVaccineOptions
        '
        Me.grpVaccineOptions.Controls.Add(Me.chkAntibaV)
        Me.grpVaccineOptions.Controls.Add(Me.chkKennelCough)
        Me.grpVaccineOptions.Controls.Add(Me.chkRabies)
        Me.grpVaccineOptions.Location = New System.Drawing.Point(737, 220)
        Me.grpVaccineOptions.Name = "grpVaccineOptions"
        Me.grpVaccineOptions.Size = New System.Drawing.Size(290, 233)
        Me.grpVaccineOptions.TabIndex = 25
        Me.grpVaccineOptions.TabStop = False
        Me.grpVaccineOptions.Text = "Vaccine Options"
        Me.grpVaccineOptions.Visible = False
        '
        'chkAntibaV
        '
        Me.chkAntibaV.AutoSize = True
        Me.chkAntibaV.Location = New System.Drawing.Point(17, 159)
        Me.chkAntibaV.Name = "chkAntibaV"
        Me.chkAntibaV.Size = New System.Drawing.Size(163, 36)
        Me.chkAntibaV.TabIndex = 2
        Me.chkAntibaV.Text = "Antiba-V"
        Me.chkAntibaV.UseVisualStyleBackColor = True
        '
        'chkKennelCough
        '
        Me.chkKennelCough.AutoSize = True
        Me.chkKennelCough.Location = New System.Drawing.Point(17, 105)
        Me.chkKennelCough.Name = "chkKennelCough"
        Me.chkKennelCough.Size = New System.Drawing.Size(234, 36)
        Me.chkKennelCough.TabIndex = 1
        Me.chkKennelCough.Text = "Kennel Cough"
        Me.chkKennelCough.UseVisualStyleBackColor = True
        '
        'chkRabies
        '
        Me.chkRabies.AutoSize = True
        Me.chkRabies.Location = New System.Drawing.Point(17, 50)
        Me.chkRabies.Name = "chkRabies"
        Me.chkRabies.Size = New System.Drawing.Size(142, 36)
        Me.chkRabies.TabIndex = 0
        Me.chkRabies.Text = "Rabies"
        Me.chkRabies.UseVisualStyleBackColor = True
        '
        'txtPetWeight
        '
        Me.txtPetWeight.Location = New System.Drawing.Point(189, 125)
        Me.txtPetWeight.Name = "txtPetWeight"
        Me.txtPetWeight.Size = New System.Drawing.Size(130, 38)
        Me.txtPetWeight.TabIndex = 3
        '
        'lblPetWeight
        '
        Me.lblPetWeight.AutoSize = True
        Me.lblPetWeight.Location = New System.Drawing.Point(19, 128)
        Me.lblPetWeight.Name = "lblPetWeight"
        Me.lblPetWeight.Size = New System.Drawing.Size(154, 32)
        Me.lblPetWeight.TabIndex = 4
        Me.lblPetWeight.Text = "Pet Weight"
        '
        'grpAntibaVPetInfo
        '
        Me.grpAntibaVPetInfo.Controls.Add(Me.chkMedium)
        Me.grpAntibaVPetInfo.Controls.Add(Me.chkLarge)
        Me.grpAntibaVPetInfo.Controls.Add(Me.chkSmall)
        Me.grpAntibaVPetInfo.Controls.Add(Me.lblPetWeight)
        Me.grpAntibaVPetInfo.Controls.Add(Me.txtPetWeight)
        Me.grpAntibaVPetInfo.Location = New System.Drawing.Point(1080, 220)
        Me.grpAntibaVPetInfo.Name = "grpAntibaVPetInfo"
        Me.grpAntibaVPetInfo.Size = New System.Drawing.Size(554, 233)
        Me.grpAntibaVPetInfo.TabIndex = 26
        Me.grpAntibaVPetInfo.TabStop = False
        Me.grpAntibaVPetInfo.Text = "Antiba-V Pet Infomation"
        Me.grpAntibaVPetInfo.Visible = False
        '
        'chkMedium
        '
        Me.chkMedium.AutoSize = True
        Me.chkMedium.Location = New System.Drawing.Point(202, 65)
        Me.chkMedium.Name = "chkMedium"
        Me.chkMedium.Size = New System.Drawing.Size(154, 36)
        Me.chkMedium.TabIndex = 29
        Me.chkMedium.Text = "Medium"
        Me.chkMedium.UseVisualStyleBackColor = True
        '
        'chkLarge
        '
        Me.chkLarge.AutoSize = True
        Me.chkLarge.Location = New System.Drawing.Point(393, 65)
        Me.chkLarge.Name = "chkLarge"
        Me.chkLarge.Size = New System.Drawing.Size(126, 36)
        Me.chkLarge.TabIndex = 28
        Me.chkLarge.Text = "Large"
        Me.chkLarge.UseVisualStyleBackColor = True
        '
        'chkSmall
        '
        Me.chkSmall.AutoSize = True
        Me.chkSmall.Location = New System.Drawing.Point(25, 65)
        Me.chkSmall.Name = "chkSmall"
        Me.chkSmall.Size = New System.Drawing.Size(125, 36)
        Me.chkSmall.TabIndex = 27
        Me.chkSmall.Text = "Small"
        Me.chkSmall.UseVisualStyleBackColor = True
        '
        'BtnTotal
        '
        Me.BtnTotal.Location = New System.Drawing.Point(737, 475)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(897, 53)
        Me.BtnTotal.TabIndex = 29
        Me.BtnTotal.Text = "Total"
        Me.BtnTotal.UseVisualStyleBackColor = True
        '
        'grpReceiptScreen
        '
        Me.grpReceiptScreen.Controls.Add(Me.txtReceipt)
        Me.grpReceiptScreen.Location = New System.Drawing.Point(737, 567)
        Me.grpReceiptScreen.Name = "grpReceiptScreen"
        Me.grpReceiptScreen.Size = New System.Drawing.Size(903, 453)
        Me.grpReceiptScreen.TabIndex = 28
        Me.grpReceiptScreen.TabStop = False
        Me.grpReceiptScreen.Text = "Receipt Screen"
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Courier New", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(17, 52)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(880, 395)
        Me.txtReceipt.TabIndex = 0
        Me.txtReceipt.Text = ""
        '
        'frmDataEntryScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1704, 1048)
        Me.Controls.Add(Me.BtnTotal)
        Me.Controls.Add(Me.grpReceiptScreen)
        Me.Controls.Add(Me.grpAntibaVPetInfo)
        Me.Controls.Add(Me.grpVaccineOptions)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.grpPetInfomation)
        Me.Controls.Add(Me.grpUser)
        Me.Name = "frmDataEntryScreen"
        Me.Text = "Vets 'R' Us "
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.grpPetInfomation.ResumeLayout(False)
        Me.grpPetInfomation.PerformLayout()
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.grpVaccineOptions.ResumeLayout(False)
        Me.grpVaccineOptions.PerformLayout()
        Me.grpAntibaVPetInfo.ResumeLayout(False)
        Me.grpAntibaVPetInfo.PerformLayout()
        Me.grpReceiptScreen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents txtPetSpecies As TextBox
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblPetSpecies As Label
    Friend WithEvents chkOfficeVisit As CheckBox
    Friend WithEvents chkSpecimenExam As CheckBox
    Friend WithEvents chkXRay As CheckBox
    Friend WithEvents chkVaccination As CheckBox
    Friend WithEvents grpUser As GroupBox
    Friend WithEvents grpPetInfomation As GroupBox
    Friend WithEvents grpServices As GroupBox
    Friend WithEvents grpVaccineOptions As GroupBox
    Friend WithEvents chkAntibaV As CheckBox
    Friend WithEvents chkKennelCough As CheckBox
    Friend WithEvents chkRabies As CheckBox
    Friend WithEvents txtPetWeight As TextBox
    Friend WithEvents lblPetWeight As Label
    Friend WithEvents grpAntibaVPetInfo As GroupBox
    Friend WithEvents chkMedium As CheckBox
    Friend WithEvents chkLarge As CheckBox
    Friend WithEvents chkSmall As CheckBox
    Friend WithEvents chkHigh As CheckBox
    Friend WithEvents chkLow As CheckBox
    Friend WithEvents BtnTotal As Button
    Friend WithEvents grpReceiptScreen As GroupBox
    Friend WithEvents txtReceipt As RichTextBox
End Class
