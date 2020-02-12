Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the number of cookies per bag, calories per serving, and servings per bag.
        Const intCOOKIES_PER_BAG As Integer = 40
        Const intCALORIES_PER_SERVING As Integer = 300
		Const intSERVINGS_PER_BAG As Integer = 10
		lblStatus.Text = String.Empty

		Try
			' Get the number of cookies eaten as input from the user.
			Dim intCookiesEaten As Integer = CInt(txtCookiesEaten.Text)

			' Calculate the number of calories per cookie.
			Dim dblCaloriesPerCookie As Double = intCALORIES_PER_SERVING / (intCOOKIES_PER_BAG / intSERVINGS_PER_BAG)
			' Calculate the number of calories consumed.
			Dim dblCaloriesConsumed As Double = intCookiesEaten * dblCaloriesPerCookie

			' Display the result to the user.
			lblCaloriesConsumed.Text = dblCaloriesConsumed.ToString()
		Catch
			lblStatus.Text = "Please input an integer"
		End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text box.
        txtCookiesEaten.Clear()

        ' Set the Text in the label to an empty string.
		lblCaloriesConsumed.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtCookiesEaten.
        txtCookiesEaten.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
