Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the assessment value and property tax.
        Const dblASSESSMENT_VALUE As Double = 0.6       ' 60% of the property value
		Const dblPROPERTY_TAX_RATE As Double = 0.0064	' $0.64 for each $100.00 of the assessment value
		lblStatus.Text = String.Empty

		Try
			' Get the property value from the user.
			Dim dblPropertyValue As Double = CDbl(txtPropertyValue.Text)
			' Calculate the assessment value.
			Dim dblAssessmentValue As Double = dblPropertyValue * dblASSESSMENT_VALUE
			' Calculate the property tax.
			Dim dblPropertyTax As Double = dblAssessmentValue * dblPROPERTY_TAX_RATE

			' Display the results to the user.
			lblAssessmentValue.Text = dblAssessmentValue.ToString("c")
			lblPropertyTax.Text = dblPropertyTax.ToString("c")
		Catch
			lblStatus.Text = "Please input a number"
		End Try

	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtPropertyValue text box.
        txtPropertyValue.Clear()

        ' Set the Text in the labels to an empty string.
        lblAssessmentValue.Text = String.Empty
		lblPropertyTax.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtPropertyValue.
        txtPropertyValue.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
