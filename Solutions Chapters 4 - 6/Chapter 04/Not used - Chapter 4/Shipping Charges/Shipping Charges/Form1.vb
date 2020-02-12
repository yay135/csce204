Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the shipping rates.
        Const dblRATE_A As Double = 0.01    ' $0.010 per mile for 2kg or less.
        Const dblRATE_B As Double = 0.015   ' $0.015 per mile for over  2kg, but not more than  6kg.
        Const dblRATE_C As Double = 0.02    ' S0.020 per mile for over  6kg, but not more than 10kg.
        Const dblRATE_D As Double = 0.025   ' S0.025 per mile for over 10kg, but not more than 20kg.

        ' Declare named constants for minimum and maximum weight and shipping distance values.
        Const dblMIN_WEIGHT As Double = 0.0         ' Weight must be greater than 0kg.
        Const dblMAX_WEIGHT As Double = 20.0        ' Weight must not be greater than 20kg.
        Const dblMIN_DISTANCE As Double = 10.0      ' Distance must be at least 10 miles.
        Const dblMAX_DISTANCE As Double = 3000.0    ' Distance must not be greater than 3,000 miles.

        ' Declare a variable to hold the weight (in kilograms) of the package.
        Dim dblWeight As Double

        ' Declare a variable to hold the shipping distance (in miles) of the package.
        Dim dblDistance As Double

        ' Delcare a variable to hold the shipping rate of the package.
        Dim dblRate As Double

        ' Declare a variable to hold the total cost.
        Dim dblTotalCost As Double

        ' Get the weight of the package (in kilograms) as input from the user.
        If Double.TryParse(txtWeight.Text, dblWeight) And IsNumeric(txtWeight.Text) And
            dblWeight > dblMIN_WEIGHT And dblWeight <= dblMAX_WEIGHT Then

            ' Get the shipping distance of the package (in miles) as input from the user.
            If Double.TryParse(txtDistance.Text, dblDistance) And IsNumeric(txtDistance.Text) And
                dblDistance >= dblMIN_DISTANCE And dblDistance <= dblMAX_DISTANCE Then

                ' Determine shipping rates based on weight.
                Select Case dblWeight
                    Case Is < 2.0
                        ' The rate is $0.01 cents per mile.
                        dblRate = dblRATE_A ' Rate A is the one cent rate.
                    Case 2.0 To 6.0
                        ' The rate is $0.015 cents per mile.
                        dblRate = dblRATE_B ' Rate B is the one and a half cent rate.
                    Case 6.0 To 10.0
                        ' The rate is $0.2 cents per mile.
                        dblRate = dblRATE_C ' Rate C is the two cent rate.
                    Case 10.0 To 20.0
                        ' The rate is $0.25 cents per mile.
                        dblRate = dblRATE_D ' Rate D is the two and a half cent rate.
                End Select

                ' Calculate the total cost.
                dblTotalCost = dblDistance * dblRate

                ' Display the total cost as output to the user.
                lblTotalCost.Text = dblTotalCost.ToString("c")
            Else
                ' Display a message box to the user indicating the distance entered is invalid.
                MessageBox.Show("Distance - The value must be a real number between 10 and 3000.", "Invalid Input")
            End If
        Else
            ' Display a message box to the user indicating the weight entered is invalid.
            MessageBox.Show("Weight - The value must be a real number greater than zero and less than 20.", "Invalid Input")
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtWeight.Clear()
        txtDistance.Clear()

        ' Set the Text in lblTotalCost to an empty string.
        lblTotalCost.Text = String.Empty

        ' Give the focus to txtWeight.
        txtWeight.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
