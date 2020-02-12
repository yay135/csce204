Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for quantity discounts.
        Const dblNO_DISCOUNT As Double = 1.0                ' No discount for 0 to 9 units sold
        Const dblTWENTY_PERCENT_DISCOUNT As Double = 0.8    ' 20% discount for 10 to 19 units sold
        Const dblTHIRTY_PERCENT_DISCOUNT As Double = 0.7    ' 30% discount for 20 to 49 units sold
        Const dblFORTY_PERCENT_DISCOUNT As Double = 0.6     ' 40% discount for 50 to 99 units sold
        Const dblFIFTY_PERCENT_DISCOUNT As Double = 0.5     ' 50% discount for 100 or more units sold

        ' Declare named constants for package retail prices.
        Const dblRETAIL_PRICE_PACKAGE_A As Double = 99.0    ' $  99.00 for Package A
        Const dblRETAIL_PRICE_PACKAGE_B As Double = 199.0   ' $ 199.00 for Package B
        Const dblRETAIL_PRICE_PACKAGE_C As Double = 299.0   ' $ 299.00 for Package C

        ' Declare variables to store the user input for quantities sold.
        Dim intQuantitySoldPackageA As Integer              ' Quantity sold for Package A
        Dim intQuantitySoldPackageB As Integer              ' Quantity sold for Package B
        Dim intQuantitySoldPackageC As Integer              ' Quantity sold for Package C

        ' Declare variables to store the applied discount for each package.
        Dim dblDiscountPackageA As Double                   ' Discount for Package A
        Dim dblDiscountPackageB As Double                   ' Discount for Package B
        Dim dblDiscountPackageC As Double                   ' Discount for Package C

        ' Declare variables to store the total cost of each package and the grand total.
        Dim dblTotalCostPackageA As Double                  ' Total cost for Package A
        Dim dblTotalCostPackageB As Double                  ' Total cost for Package B
        Dim dblTotalCostPackageC As Double                  ' Total cost for Package C
        Dim dblGrandTotal As Double                         ' Total cost for Grand Total

        ' Declare variables to store the output string for each package and the grand total.
        Dim strOutputPackageA As String                     ' Output string for Package A
        Dim strOutputPackageB As String                     ' Output string for Package B
        Dim strOutputPackageC As String                     ' Output string for Package C
        Dim strOutputGrandTotal As String                   ' Output string for Grand Total

        ' Get the quantity sold for Package A as input from the user.
        If Integer.TryParse(txtQuantitySoldPackageA.Text, intQuantitySoldPackageA) And
            IsNumeric(txtQuantitySoldPackageA.Text) And intQuantitySoldPackageA >= 0 Then

            ' Get the quantity sold for Package B as input from the user.
            If Integer.TryParse(txtQuantitySoldPackageB.Text, intQuantitySoldPackageB) And
                IsNumeric(txtQuantitySoldPackageB.Text) And intQuantitySoldPackageB >= 0 Then

                ' Get the quantity sold for Package C as input from the user.
                If Integer.TryParse(txtQuantitySoldPackageC.Text, intQuantitySoldPackageC) And
                    IsNumeric(txtQuantitySoldPackageC.Text) And intQuantitySoldPackageC >= 0 Then

                    ' Apply the quantity discount for Package A.
                    Select Case intQuantitySoldPackageA
                        Case 0 To 9
                            ' No discount applied.
                            dblDiscountPackageA = dblNO_DISCOUNT
                        Case 10 To 19
                            ' Apply 20% discount.
                            dblDiscountPackageA = dblTWENTY_PERCENT_DISCOUNT
                        Case 20 To 49
                            ' Apply 30% discount.
                            dblDiscountPackageA = dblTHIRTY_PERCENT_DISCOUNT
                        Case 50 To 99
                            ' Apply 40% discount.
                            dblDiscountPackageA = dblFORTY_PERCENT_DISCOUNT
                        Case Is >= 100
                            ' Apply 50% discount.
                            dblDiscountPackageA = dblFIFTY_PERCENT_DISCOUNT
                    End Select

                    ' Apply the quantity discount for Package B.
                    Select Case intQuantitySoldPackageB
                        Case 0 To 9
                            ' No discount applied.
                            dblDiscountPackageB = dblNO_DISCOUNT
                        Case 10 To 19
                            ' Apply 20% discount.
                            dblDiscountPackageB = dblTWENTY_PERCENT_DISCOUNT
                        Case 20 To 49
                            ' Apply 30% discount.
                            dblDiscountPackageB = dblTHIRTY_PERCENT_DISCOUNT
                        Case 50 To 99
                            ' Apply 40% discount.
                            dblDiscountPackageB = dblFORTY_PERCENT_DISCOUNT
                        Case Is >= 100
                            ' Apply 50% discount.
                            dblDiscountPackageB = dblFIFTY_PERCENT_DISCOUNT
                    End Select

                    ' Apply the quantity discount for Package C.
                    Select Case intQuantitySoldPackageC
                        Case 0 To 9
                            ' No discount applied.
                            dblDiscountPackageC = dblNO_DISCOUNT
                        Case 10 To 19
                            ' Apply 20% discount.
                            dblDiscountPackageC = dblTWENTY_PERCENT_DISCOUNT
                        Case 20 To 49
                            ' Apply 30% discount.
                            dblDiscountPackageC = dblTHIRTY_PERCENT_DISCOUNT
                        Case 50 To 99
                            ' Apply 40% discount.
                            dblDiscountPackageC = dblFORTY_PERCENT_DISCOUNT
                        Case Is >= 100
                            ' Apply 50% discount.
                            dblDiscountPackageC = dblFIFTY_PERCENT_DISCOUNT
                    End Select

                    ' Calculate the total cost for each package.
                    dblTotalCostPackageA = dblRETAIL_PRICE_PACKAGE_A * intQuantitySoldPackageA * dblDiscountPackageA
                    dblTotalCostPackageB = dblRETAIL_PRICE_PACKAGE_B * intQuantitySoldPackageB * dblDiscountPackageB
                    dblTotalCostPackageC = dblRETAIL_PRICE_PACKAGE_C * intQuantitySoldPackageC * dblDiscountPackageC

                    ' Calculate the grand total for all packages.
                    dblGrandTotal = dblTotalCostPackageA + dblTotalCostPackageB + dblTotalCostPackageC

                    ' Build the output string for Package A.
                    strOutputPackageA = "Package A:  " & dblTotalCostPackageA.ToString("c") & ControlChars.CrLf
                    ' Build the output string for Package B.
                    strOutputPackageB = "Package B:  " & dblTotalCostPackageB.ToString("c") & ControlChars.CrLf
                    ' Build the output string for Package C.
                    strOutputPackageC = "Package C:  " & dblTotalCostPackageC.ToString("c") & ControlChars.CrLf

                    ' Build the output string for the Grand Total.
                    strOutputGrandTotal = ControlChars.CrLf & "Grand Total: " & dblGrandTotal.ToString("c")

                    ' Display the results in the calculated label.
                    lblOutput.Text = strOutputPackageA & strOutputPackageB & strOutputPackageC & strOutputGrandTotal

                Else
                    ' Display input error message for Package C quantity sold.
                    MessageBox.Show("Package C - The quantity sold must be a positive whole number.", "Invalid Input")
                End If
            Else
                ' Display input error message for Package B quantity sold.
                MessageBox.Show("Package B - The quantity sold must be a positive whole number.", "Invalid Input")
            End If
        Else
            ' Display input error message for Package A quantity sold.
            MessageBox.Show("Package A - The quantity sold must be a positive whole number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtQuantitySoldPackageA.Clear()
        txtQuantitySoldPackageB.Clear()
        txtQuantitySoldPackageC.Clear()

        ' Set the Text in lblOutput to an empty string.
        lblOutput.Text = String.Empty

        ' Give the focus to txtQuantitySoldPackageA.
        txtQuantitySoldPackageA.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
