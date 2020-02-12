Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a constant for the insurance percentage.
		Const dblINSURANCE_PERCENTAGE = 0.8	' 80% of the replacement cost
		lblStatus.Text = String.Empty

		Try
			' Get the replacement cost as input from the user.
			Dim dblReplacementCost As Double = CDbl(txtReplacementCost.Text)

			' Calculate the insurance amount.
			Dim dblInsuranceAmount As Double = dblReplacementCost * dblINSURANCE_PERCENTAGE

			' Display the result to the user.
			lblInsuranceAmount.Text = dblInsuranceAmount.ToString("c")
		Catch
			lblStatus.Text = "Please input a number"
		End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text box.
        txtReplacementCost.Clear()

        ' Set the Text in the label to an empty string.
        lblInsuranceAmount.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtReplacementCost
        txtReplacementCost.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
