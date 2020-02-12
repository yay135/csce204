Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

		lblStatus.Text = String.Empty

		Try
			' Get the temperature in Celsius from the user.
			Dim dblCelsius As Double = CDbl(txtCelsius.Text)

			' Calculate the temperature in Fahrenheit.
			Dim dblFahrenheit As Double = 1.8 * dblCelsius + 32.0

			' Disply the result in lblFahrenheit.
			lblFahrenheit.Text = dblFahrenheit.ToString("n1")
		Catch
			lblStatus.Text = "Please enter a number"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text from the text box txtCelsius.
        txtCelsius.Clear()

        ' Set the Text of label lblFahrenheit to an empty string.
        lblFahrenheit.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtCelsius.
        txtCelsius.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
