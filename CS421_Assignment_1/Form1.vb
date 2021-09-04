Public Class frmDataEntryScreen

    'Number of Customer counter
    Public intTotal As Integer = 0

    'Array of customers starting at 0
    Public arrCustomers(intTotal) As String

    '------------------------------------------------------------
    '-                Subprogram Name: BtnTotal_Click           -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user finish his order -
    '- and clicked the total button                             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- receipt - the string contain all the order text          -
    '- total - double containing the sum of all order price     -
    '------------------------------------------------------------
    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click

        'Resetting the String to blank
        Dim receipt As String = ""

        'Resetting total to 0
        Dim total As Double = 0

        'Printing off a neat header text
        receipt = receipt + ("---------------Vets 'R' Us-----------------") + vbCrLf

        'Customer information on top of there purhcase
        receipt = receipt + ("Customer : " + txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text) + vbCrLf

        'Checking too if the user selected office visit to add the cost to our total
        If (chkOfficeVisit.Checked) Then

            'String is formated to display 2 neat columns 
            receipt = receipt + (String.Format("{0, -30}{1,10}", "Office Visit", "$25.00")) + vbCrLf

            total += 25.0

        End If

        'Checking too if the user selected X-Ray to add the cost to our total
        If (chkXRay.Checked) Then

            receipt = receipt + (String.Format("{0, -30}{1,10}", "X-Ray", "$15.00")) + vbCrLf

            total += 25.0

        End If

        'Checking too if the user selected Exam to add the cost to our total
        If (chkSpecimenExam.Checked) Then

            receipt = receipt + (String.Format("{0, -30}{1, 10}", "Specimen Examination", "$12.50")) + vbCrLf

            total += 12.5
        End If

        'Checking too if the user selected Vaccination to add the cost to our total
        If (chkVaccination.Checked And chkRabies.Checked) Then

            receipt = receipt + (String.Format("{0, -30}{1, 10}", "Vaccine Rabies", "$8.00")) + vbCrLf

            total += 8.0

        End If

        'Checking too if the user selected Vaccine and KennelCough to add the cost to our total
        If (chkVaccination.Checked And chkKennelCough.Checked) Then

            receipt = receipt + (String.Format("{0, -30}{1, 10}", "Vaccine Kennel Cough", "$6.00")) + vbCrLf

            total += 6.0

        End If

        'Checking too if the user selected Vaccine and AntibaV to add the cost to our total
        If (chkVaccination.Checked And chkAntibaV.Checked) Then

            'Cost of the AntibaV using the formula provided base on animal weight
            Dim dose As Double

            If (chkSmall.Checked) Then

                dose = Double.Parse(txtPetWeight.Text) / 10

                receipt = receipt + (String.Format("{0, -30}{1, 10}", "Vaccine Antiba-V", "$" + dose.ToString)) + vbCrLf

                total += dose

            ElseIf (chkMedium.Checked) Then

                dose = Double.Parse(txtPetWeight.Text) / 50

                receipt = receipt + (String.Format("{0, -30}{1, 10}", "Vaccine Antiba-V", "$" + dose.ToString)) + vbCrLf

                total += dose

            ElseIf (chkLarge.Checked) Then

                dose = Double.Parse(txtPetWeight.Text) / 100

                receipt = receipt + (String.Format("{0, -30}{1, 10}", "Vaccine Antiba-V", "$" + dose.ToString)) + vbCrLf

                total += dose

            End If

        End If

        'If low income is checked we will give them a 10% discount
        If (chkLow.Checked) Then

            'applying 10% discount
            total = total - (total * 0.1)

        End If

        'If the customer has mutiple pets we will give them a 10% discount
        If (intTotal = 0) Then

            arrCustomers(intTotal) = txtPhoneNumber.Text

        Else
            For Each item As String In arrCustomers

                If (item = (txtPhoneNumber.Text)) Then

                    'applying 10% discount
                    total = total - (total * 0.1)

                End If
            Next

            'Adding the customers phone number to our record
            arrCustomers(intTotal) = txtPhoneNumber.Text

        End If

        'adding Michigan tax of 1.06
        total = total * 1.06

        receipt = receipt + vbCrLf + (String.Format("{0, -30}{1, 10}", "Total", "$" + total.ToString)) + vbCrLf

        receipt = receipt + vbCrLf + (String.Format("{0, -30}{1, 10}", "Have a nice day! :)", " ")) + vbCrLf

        'Print rhe receipt into our rich text box
        txtReceipt.Text = receipt

        intTotal += 1

        'increasing the size of array to add our new phone number
        ReDim Preserve arrCustomers(intTotal)

        'resetting everything, I couldve done a window control loop all, but was having issues
        txtFirstName.Clear()
        txtMiddleInitial.Clear()
        txtLastName.Clear()
        txtPhoneNumber.Clear()
        txtPetName.Clear()
        txtPetSpecies.Clear()
        txtPetWeight.Clear()

        chkLow.Checked = False
        chkHigh.Checked = False
        chkOfficeVisit.Checked = False
        chkXRay.Checked = False
        chkSpecimenExam.Checked = False
        chkVaccination.Checked = False
        chkRabies.Checked = False
        chkKennelCough.Checked = False
        chkAntibaV.Checked = False
        chkSmall.Checked = False
        chkMedium.Checked = False
        chkLarge.Checked = False

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkLow_CheckedChanged    -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkLow is changed         -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkLow_CheckedChanged(sender As Object, e As EventArgs) Handles chkLow.CheckedChanged

        If (chkLow.Checked) Then

            chkHigh.Checked = False

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkHigh_CheckedChanged   -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkHight is changed       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkHigh_CheckedChanged(sender As Object, e As EventArgs) Handles chkHigh.CheckedChanged

        If (chkHigh.Checked) Then

            chkLow.Checked = False

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkSmall_CheckedChanged  -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkSmall is changed       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkSmall_CheckedChanged(sender As Object, e As EventArgs) Handles chkSmall.CheckedChanged

        If (chkSmall.Checked) Then

            chkMedium.Checked = False
            chkLarge.Checked = False

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkMedium_CheckedChanged -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkMedium is changed      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkMedium_CheckedChanged(sender As Object, e As EventArgs) Handles chkMedium.CheckedChanged

        If (chkMedium.Checked) Then

            chkSmall.Checked = False
            chkLarge.Checked = False

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkLarge_CheckedChanged  -
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkLarge is changed       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkLarge_CheckedChanged(sender As Object, e As EventArgs) Handles chkLarge.CheckedChanged

        If (chkLarge.Checked) Then

            chkMedium.Checked = False
            chkSmall.Checked = False

        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: chkAntibaV_CheckedChanged-
    '------------------------------------------------------------
    '-                Written By: Terry Chen                    -
    '-                Written On: September 9, 2020             -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when chkAntibaV is changed     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender - Identifies which particular control raised the  -
    '-          click event                                     -
    '- e - Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- none                                                     -
    '------------------------------------------------------------
    Private Sub chkAntibaV_CheckedChanged(sender As Object, e As EventArgs) Handles chkAntibaV.CheckedChanged

        If (chkAntibaV.Checked) Then

            grpAntibaVPetInfo.Visible = True


        Else
            grpAntibaVPetInfo.Visible = False

        End If

    End Sub

    Private Sub chkVaccination_CheckedChanged(sender As Object, e As EventArgs) Handles chkVaccination.CheckedChanged

        If (chkVaccination.Checked) Then

            grpVaccineOptions.Visible = True

            If (chkAntibaV.Checked) Then
                grpAntibaVPetInfo.Visible = True

            End If

        Else
            grpVaccineOptions.Visible = False
            grpAntibaVPetInfo.Visible = False

        End If

    End Sub

End Class
