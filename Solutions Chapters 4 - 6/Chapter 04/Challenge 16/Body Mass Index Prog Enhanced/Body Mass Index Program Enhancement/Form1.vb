Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the minimum and maximum optimal BMI values.
        Const dblMIN_OPTIMAL_BMI As Double = 18.5   ' A BMI of 18.5 is the minimum optimal value.
        Const dblMAX_OPTIMAL_BMI As Double = 25.0   ' A BMI of 25.0 is the maximum optimal value.

        ' Declare a variable to store the weight.
        Dim dblWeight As Double

        ' Declare a variable to store the height.
        Dim dblHeight As Double

        ' Declare a variable to store the BMI.
        Dim dblBMI As Double

        ' Declare a variable to hold the message.
        Dim strMessage As String

        ' Get the weight in pounds as input from the user.
        If Double.TryParse(txtWeight.Text, dblWeight) And IsNumeric(txtWeight.Text) And dblWeight > 0.0 Then

            ' Get the height in inches as input from the user.
            If Double.TryParse(txtHeight.Text, dblHeight) And IsNumeric(txtHeight.Text) And dblHeight > 0.0 Then

                ' Calculate the BMI value.
                dblBMI = (dblWeight * 703.0) / (dblHeight * dblHeight)

                ' Determine the message to display based on the BMI value.
                If dblBMI >= dblMIN_OPTIMAL_BMI And dblBMI <= dblMAX_OPTIMAL_BMI Then
                    strMessage = "Optimal Weight"

                ElseIf dblBMI < dblMIN_OPTIMAL_BMI Then
                    strMessage = "Underweight"

                ElseIf dblBMI > dblMAX_OPTIMAL_BMI Then
                    strMessage = "Overweight"

                Else
                    strMessage = String.Empty
                End If

                ' Disply the results in the labels as output to the user.
                lblBMI.Text = dblBMI.ToString("n2")
                lblMessage.Text = strMessage.ToString
            Else
                ' Display a message to the user indicating the input value for height is invalid.
                MessageBox.Show("Height - The value must be a number greater than zero.", "Invalid Input")
            End If
        Else
            ' Display a message to the user indicating the input value for weight is invalid.
            MessageBox.Show("Weight - The value must be a number greater than zero.", "Invalid Input")
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtWeight.Clear()
        txtHeight.Clear()

        ' Set the Text in the labels to an empty string.
        lblBMI.Text = String.Empty
        lblMessage.Text = String.Empty

        ' Give the focus to txtWeight.
        txtWeight.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
