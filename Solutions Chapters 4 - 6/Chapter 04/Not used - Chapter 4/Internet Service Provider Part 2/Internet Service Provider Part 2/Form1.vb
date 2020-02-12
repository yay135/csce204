Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a named constant for the maximum number of hours that can be used.
        Const dblMAX_HOURS As Double = 744.0                ' Maximum usable hours
        Const dblMIN_HOURS As Double = 0.0                  ' Minimum usable hours

        ' Declare named constants representing the purchase price of each package.
        Const dblPRICE_PACKAGE_A As Double = 9.95           ' $ 9.95 for Package A
        Const dblPRICE_PACKAGE_B As Double = 14.95          ' $14.95 for Package B
        Const dblPRICE_PACKAGE_C As Double = 19.95          ' $19.95 for Package C

        ' Declare named constants representing the hours of access provided by each package.
        Const dblHOURS_PACKAGE_A As Double = 10.0           ' 10 hours  for Package A
        Const dblHOURS_PACKAGE_B As Double = 20.0           ' 20 hours  for Package B
        Const dblHOURS_PACKAGE_C As Double = dblMAX_HOURS   ' Unlimited for Package C

        ' Declare named constants representing the rate of each additional hour for each package.
        Const dblHOUR_RATE_PACKAGE_A As Double = 2.0        ' $2.00 for Package A
        Const dblHOUR_RATE_PACKAGE_B As Double = 1.0        ' $1.00 for Package B
        Const dblHOUR_RATE_PACKAGE_C As Double = 0.0        ' $0.00 for Package C

        ' Declare named constants representing the available discounts.
        Const dblDISCOUNT_NONE As Double = 1.0              ' No discount applies.
        Const dblDISCOUNT_TWENTY_PERCENT As Double = 0.8    ' 20% off for Nonprofit Organization

        ' Delcare a variable to hold the purchase price.
        Dim dblPurchasePrice As Double

        ' Declare a variable to hold the hours of access provided.
        Dim dblHoursProvided As Double

        ' Declare a variable to hold the rate of an additional hour.
        Dim dblHourRate As Double

        ' Declare a variable to hold the cost of additional hours.
        Dim dblAdditionalCost As Double

        ' Declare a variable to hold the discount.
        Dim dblDiscount As Double

        ' Declare a variable to hold the additional hours used.
        Dim dblAdditionalHours As Double

        ' Declare a variable to hold the hours used.
        Dim dblHoursUsed As Double

        ' Declare a variable to hold the total amount due.
        Dim dblTotalAmountDue As Double

        ' Get the number of hours used as input from the user.
        If Double.TryParse(txtHoursUsed.Text, dblHoursUsed) And IsNumeric(txtHoursUsed.Text) And
            dblHoursUsed >= 0 And dblHoursUsed <= dblMAX_HOURS Then

            ' Determine the purchase price, hours provided, and rate of
            ' additional hours based on the selected package.
            If radPackageA.Checked Then
                dblPurchasePrice = dblPRICE_PACKAGE_A   ' Apply Package A price.
                dblHoursProvided = dblHOURS_PACKAGE_A   ' Apply Package A hours.
                dblHourRate = dblHOUR_RATE_PACKAGE_A    ' Apply Package A hour rate.
            ElseIf radPackageB.Checked Then
                dblPurchasePrice = dblPRICE_PACKAGE_B   ' Apply Package B price.
                dblHoursProvided = dblHOURS_PACKAGE_B   ' Apply Package B hours.
                dblHourRate = dblHOUR_RATE_PACKAGE_B    ' Apply Package B hour rate.
            ElseIf radPackageC.Checked Then
                dblPurchasePrice = dblPRICE_PACKAGE_C   ' Apply Package C price.
                dblHoursProvided = dblHOURS_PACKAGE_C   ' Apply Package C hours.
                dblHourRate = dblHOUR_RATE_PACKAGE_C    ' Apply Package C hour rate.
            End If

            ' Determine the cost of additional hours, if any.
            If dblHoursUsed > dblHoursProvided Then
                dblAdditionalHours = dblHoursUsed - dblHoursProvided  ' Determine the additional hours.
                dblAdditionalCost = dblAdditionalHours * dblHourRate  ' Determine the additional cost.
            Else
                dblAdditionalCost = 0.0 ' Apply no additional cost.
            End If

            ' Determine if any discounts should be applied.
            If chkNonprofitOrganization.Checked Then
                dblDiscount = dblDISCOUNT_TWENTY_PERCENT    ' Apply a 20% discount.
            Else
                dblDiscount = dblDISCOUNT_NONE              ' No discount applies.
            End If

            ' Calculate the total amount due.
            dblTotalAmountDue = (dblPurchasePrice + dblAdditionalCost) * dblDiscount

            ' Display the result in the lblTotalAmoutDue label.
            lblTotalAmountDue.Text = dblTotalAmountDue.ToString("c")

            ' Determine if the user would like to display potential savings.
            If chkDisplayPotentialSavings.Checked Then

                ' Declare a variable to hold the total amount due for Package B.
                Dim dblTotalAmountDuePackageB As Double

                ' Declare a variable to hold the potential savings for Package B.
                Dim dblPotentialSavingsPackageB As Double

                ' Declare a variable to hold the output string for Package B.
                Dim strOutputPackageB As String

                ' Declare a variable to hold the total amount due for Package C.
                Dim dblTotalAmountDuePackageC As Double

                ' Declare a variable to thold the potential savings for Package C.
                Dim dblPotentialSavingsPackageC As Double

                ' Declare a variable to hold the output string for Package C.
                Dim strOutputPackageC As String

                ' Delcare a variable to hold the potential savings output string.
                Dim strOutputPotentialSavings As String

                ' Determine the potential savings for Package B and Package C.
                If radPackageA.Checked Then

                    ' Apply the purchase price, hours provided, and rate of
                    ' additional hours for Package B.
                    dblPurchasePrice = dblPRICE_PACKAGE_B
                    dblHoursProvided = dblHOURS_PACKAGE_B
                    dblHourRate = dblHOUR_RATE_PACKAGE_B

                    ' Determine the cost of additional hours, if any, for Package B.
                    If dblHoursUsed > dblHoursProvided Then
                        dblAdditionalHours = dblHoursUsed - dblHoursProvided
                        dblAdditionalCost = dblAdditionalHours * dblHourRate
                    Else
                        dblAdditionalCost = 0.0
                    End If

                    ' Calculate the total amount due for Package B.
                    dblTotalAmountDuePackageB = (dblPurchasePrice + dblAdditionalCost) * dblDiscount

                    ' Calculate the potential savings for Package B.
                    dblPotentialSavingsPackageB = dblTotalAmountDue - dblTotalAmountDuePackageB

                    ' Build the output string for Package B.
                    If dblPotentialSavingsPackageB > 0 Then
                        strOutputPackageB = "Package B: " &
                            dblPotentialSavingsPackageB.ToString("c") &
                            ControlChars.CrLf
                    Else
                        strOutputPackageB = "Package B: No Savings" &
                            ControlChars.CrLf
                    End If

                    ' Apply the purchase price, hours provided, and rate of
                    ' additional hours for Package C.
                    dblPurchasePrice = dblPRICE_PACKAGE_C
                    dblHoursProvided = dblHOURS_PACKAGE_C
                    dblHourRate = dblHOUR_RATE_PACKAGE_C

                    ' Determine the cost of additional hours, if any, for Package C.
                    If dblHoursUsed > dblHoursProvided Then
                        dblAdditionalHours = dblHoursUsed - dblHoursProvided
                        dblAdditionalCost = dblAdditionalHours * dblHourRate
                    Else
                        dblAdditionalCost = 0.0
                    End If

                    ' Calculate the total amount due for Package C.
                    dblTotalAmountDuePackageC = (dblPurchasePrice + dblAdditionalCost) * dblDiscount

                    ' Calculate the potential savings for Package C.
                    dblPotentialSavingsPackageC = dblTotalAmountDue - dblTotalAmountDuePackageC

                    ' Build the output string for Package C.
                    If dblPotentialSavingsPackageC > 0 Then
                        strOutputPackageC = "Package C: " &
                            dblPotentialSavingsPackageC.ToString("c") &
                            ControlChars.CrLf
                    Else
                        strOutputPackageC = "Package C: No Savings" &
                            ControlChars.CrLf
                    End If

                    ' Build the potential savings output string.
                    strOutputPotentialSavings = strOutputPackageB & strOutputPackageC

                    ' Determine the potential savings for Package C
                ElseIf radPackageB.Checked Then
                    ' Apply the purchase price, hours provided, and rate of
                    ' additional hours for Package C.
                    dblPurchasePrice = dblPRICE_PACKAGE_C
                    dblHoursProvided = dblHOURS_PACKAGE_C
                    dblHourRate = dblHOUR_RATE_PACKAGE_C

                    ' Determine the cost of additional hours, if any, for Package C.
                    If dblHoursUsed > dblHoursProvided Then
                        dblAdditionalHours = dblHoursUsed - dblHoursProvided
                        dblAdditionalCost = dblAdditionalHours * dblHourRate
                    Else
                        dblAdditionalCost = 0.0
                    End If

                    ' Calculate the total amount due for Package C.
                    dblTotalAmountDuePackageC = (dblPurchasePrice + dblAdditionalCost) * dblDiscount

                    ' Calculate the potential savings for Package C.
                    dblPotentialSavingsPackageC = dblTotalAmountDue - dblTotalAmountDuePackageC

                    ' Build the output string for Package C.
                    If dblPotentialSavingsPackageC > 0 Then
                        strOutputPackageC = "Package C: " &
                            dblPotentialSavingsPackageC.ToString("c") &
                            ControlChars.CrLf
                    Else
                        strOutputPackageC = "Package C: No Savings" &
                            ControlChars.CrLf
                    End If

                    ' Build the potential savings output string.
                    strOutputPotentialSavings = strOutputPackageC
                Else
                    ' Potential savings are not displayed with selection of Package C.
                    strOutputPotentialSavings = String.Empty
                End If

                ' Display the result in the lblPotentialSavings label.
                lblPotentialSavings.Text = "Potential Savings:" &
                    ControlChars.CrLf & strOutputPotentialSavings
            End If
        Else
            ' Display a message box to the user indicating that the input provided for hours used is invalid.
            MessageBox.Show("Hours Used - The value must be a number between " &
                            dblMIN_HOURS.ToString("n0") & " and " &
                            dblMAX_HOURS.ToString("n0") & ".", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the radPackageA radio button.
        radPackageA.Checked = True

        ' Reset the chkNonprofitOrganization check box.
        chkNonprofitOrganization.Checked = False

        ' Reset the chkDisplayPotentialSavings check box.
        chkDisplayPotentialSavings.Checked = False

        ' Clear the Text in the txtHoursUsed text box.
        txtHoursUsed.Clear()

        ' Set the Text in the lblTotalAmountDue label to an empty string.
        lblTotalAmountDue.Text = String.Empty

        ' Set the Text in the lblPotentialSavings label to an empty string.
        lblPotentialSavings.Text = String.Empty

        ' Give txtHoursUsed the focus.
        txtHoursUsed.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
