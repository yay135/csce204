Public Class Form1
    ' Class-level declarations
    Const decOIL_CHANGE As Decimal = 36D            ' The oil change charge
    Const decLUBE_JOB As Decimal = 28D              ' The lube job charge
    Const decRADIATOR_FLUSH As Decimal = 50D        ' The radiator flush charge
    Const decTRANSMISSION_FLUSH As Decimal = 120D    ' The transmission flush charge
    Const decINSPECTION As Decimal = 15D            ' The inspection charge
    Const decMUFFLER_REPLACEMENT As Decimal = 200D  ' The muffler replacement charge
    Const decTIRE_ROTATION As Decimal = 20D         ' The tire rotation charge
    Const decLABOR_PER_MIN As Decimal = 1D          ' The labor charge per minute
    Const decSALES_TAX As Decimal = 0.06D           ' The sales tax for parts
    Private decPartsCharge As Decimal               ' Parts charge
    Private intMinutesOfLabor As Integer            ' Hours of labor
    Private decTotalTaxCharges As Decimal           ' Tax on parts total
    Private decTotalServicesAndLabor As Decimal     ' The total of all services and labor.
    Private decTotalCharges As Decimal              ' Total of all charges

    ' Verify that the two input values are valid
    ' numbers and neither is less than zero.
    Function ValidateInputs() As Boolean
        If Not Decimal.TryParse(txtParts.Text, decPartsCharge) Or decPartsCharge < 0D Then
            MessageBox.Show("The cost of parts must be a postive real number.", "Invalid Input")
            Return False
        ElseIf Not Integer.TryParse(txtLabor.Text, intMinutesOfLabor) Or intMinutesOfLabor < 0 Then
            MessageBox.Show("Labor minutes must be a positive integer.", "Invalid Input")
            Return False
        Else
            Return True
        End If
    End Function

    ' Calculate and display the total charges, including
    ' labor, parts, and services.
    Sub CalculateTotalCharges()
        Dim decTotalOilAndLubeCharges As Decimal    ' Oil and lube total
        Dim decTotalFlushCharges As Decimal         ' Flushes total
        Dim decTotalMiscCharges As Decimal          ' Miscellaneous total
        Dim decLaborCharges As Decimal

        If Not ValidateInputs() Then
            Exit Sub
        End If

        ' Calculate each of the charges.
        decTotalOilAndLubeCharges = CalcOilLubeCharges()
        decTotalFlushCharges = CalcFlushCharges()
        decTotalMiscCharges = CalcMiscCharges()
        decLaborCharges = intMinutesOfLabor * decLABOR_PER_MIN
        decTotalTaxCharges = decPartsCharge * decSALES_TAX

        ' Calcuate the total of all services and labor.
        decTotalServicesAndLabor = decTotalOilAndLubeCharges +
            decTotalFlushCharges + decTotalMiscCharges +
            decLaborCharges

        ' Calculate the total charges.
        decTotalCharges = decTotalOilAndLubeCharges + decTotalFlushCharges +
          decTotalMiscCharges + decLaborCharges + decPartsCharge + decTotalTaxCharges

    End Sub

    Private Sub btnCalculateTotal_Click() Handles btnCalculateTotal.Click

        CalculateTotalCharges()

        ' Display the summary.
        lblServicesAndLabor.Text = decTotalServicesAndLabor.ToString("c")
        lblParts.Text = decPartsCharge.ToString("c")
        lblTaxOnParts.Text = decTotalTaxCharges.ToString("c")
        lblTotalFees.Text = decTotalCharges.ToString("c")

    End Sub

    Private Sub btnClear_Click() Handles btnClear.Click
        ' This procedure resets the controls to default values.
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    ' Calculate all Oil and Lube charges
    Function CalcOilLubeCharges() As Decimal
        ' Initialize the total oil and lube charges to zero.
        Dim decTotalOilAndLubeCharges As Decimal = 0D

        ' Determine if oil change was checked.
        If chkOilChange.Checked Then
            ' Apply the oil change charge.
            decTotalOilAndLubeCharges += decOIL_CHANGE
        End If

        ' Determine if lube job was checked.
        If chkLubeJob.Checked Then
            ' Apply the lube job charge.
            decTotalOilAndLubeCharges += decLUBE_JOB
        End If

        ' Return the oil and lube charges.
        Return decTotalOilAndLubeCharges
    End Function

    'Calculate radiator and transmission flush charges.
    Function CalcFlushCharges() As Decimal
        ' Initialize the total flush charges to zero.
        Dim decTotalFlushCharges As Decimal = 0D

        ' Determine if radiator flush was checked.
        If chkRadiatorFlush.Checked Then
            ' Apply the radiator flush charge.
            decTotalFlushCharges += decRADIATOR_FLUSH
        End If

        ' Determine if transmission flush was checked.
        If chkTransmissionFlush.Checked Then
            ' Apply the transmission flush charge.
            decTotalFlushCharges += decTRANSMISSION_FLUSH
        End If

        ' Return the total flush charges.
        Return decTotalFlushCharges
    End Function

    ' Calculate inspection, muffler, and tire rotation charges.
    Function CalcMiscCharges() As Decimal
        ' Intitalize the total miscelaneous charges to zero.
        Dim decTotalMiscCharges As Decimal = 0D

        ' Determine if inspection was checked.
        If chkInspection.Checked Then
            ' Apply the inspection charge.
            decTotalMiscCharges += decINSPECTION
        End If

        ' Determine if muffler replacement was checked.
        If chkReplaceMuffler.Checked Then
            ' Apply the muffler replacement charge.
            decTotalMiscCharges += decMUFFLER_REPLACEMENT
        End If

        ' Determine if tire rotation was checked.
        If chkTireRotation.Checked Then
            ' Apply the tire rotation charge.
            decTotalMiscCharges += decTIRE_ROTATION
        End If

        ' Return the total micelaneous charges.
        Return decTotalMiscCharges
    End Function

    ' Clear the oil change and lube job check boxes.
    Sub ClearOilLube()
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    ' Clear the radiator and transmission flush check boxes.
    Sub ClearFlushes()
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    ' Clear the inspection, muffler replacement, and tire rotation check boxes.
    Sub ClearMisc()
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    ' Clear the parts and labor check boxes.
    Sub ClearOther()
        txtParts.Clear()
        txtLabor.Clear()
    End Sub

    ' Set the text in the summary labels to an empty string.
    Sub ClearFees()
        lblServicesAndLabor.Text = String.Empty
        lblParts.Text = String.Empty
        lblTaxOnParts.Text = String.Empty
        lblTotalFees.Text = String.Empty
    End Sub

End Class
