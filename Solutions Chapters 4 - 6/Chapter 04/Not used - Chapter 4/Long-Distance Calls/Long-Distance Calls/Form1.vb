Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the long distance rates.
        Const dblRATE_DAYTIME As Double = 0.07  ' $0.07 per minute for the daytime rate.
        Const dblRATE_EVENING As Double = 0.12  ' $0.12 per minute for the evening rate.
        Const dblRATE_OFF_PEAK As Double = 0.05 ' $0.05 per minute for the off-peak rate.

        ' Declare a variable to hold the minutes of the call.
        Dim dblMinutes As Double

        ' Declare a variable to hold the selected rate of the call.
        Dim dblRate As Double

        ' Declare a variable to hold the total charge of the call.
        Dim dblTotalCharge As Double

        ' Get the number of minutes of the call as input from the user.
        If Double.TryParse(txtMinutes.Text, dblMinutes) And
            IsNumeric(txtMinutes.Text) And dblMinutes > 0.0 Then

            ' Determine which rate was selected by the user.
            If radDaytime.Checked Then
                dblRate = dblRATE_DAYTIME   ' The daytime rate was selected.
            ElseIf radEvening.Checked Then
                dblRate = dblRATE_EVENING   ' The evening rate was selected.
            ElseIf radOffPeak.Checked Then
                dblRate = dblRATE_OFF_PEAK  ' The off-peak rate was selected.
            End If

            ' Calcuate the total charge by multiplying the minutes by the rate.
            dblTotalCharge = dblMinutes * dblRate

            ' Display the result to the user in the lblTotalCharge label.
            lblTotalCharge.Text = dblTotalCharge.ToString("c")
        Else
            ' Display a message box to the user indicating the input entered for the minutes is invalid.
            MessageBox.Show("Minutes - The value must be a number greater than zero.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the radDaytime radio button.
        radDaytime.Checked = True

        ' Clear the Text in the txtMinutes text box.
        txtMinutes.Clear()

        ' Set the Text in the lblTotalCharge label to an empty string.
        lblTotalCharge.Text = String.Empty

        ' Give the focus to txtMinutes.
        txtMinutes.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
