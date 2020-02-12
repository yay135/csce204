Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

		lblStatus.Text = String.Empty

		Try
			' Get the weight as input from the user.
			Dim intWeight As Integer = CInt(txtWeight.Text)
			' Get the height as input from the user.
			Dim intHeight As Integer = CInt(txtHeight.Text)

			' Calculate the BMI value.
			Dim dblBMI As Double = (intWeight * 703) / (intHeight * intHeight)

			' Disply the result to the user.
			lblBMI.Text = dblBMI.ToString("n2")
		Catch
			lblStatus.Text = "Please input integer values"
		End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtWeight.Clear()
        txtHeight.Clear()

        ' Set the Text in the label to an empty string.
		lblBMI.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtWeight.
        txtWeight.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
