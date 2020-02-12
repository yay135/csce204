Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants to represent the conversion 
        ' factors for Pounds, Euros, and Yen
        Const dblPOUNDS_FACTOR As Double = 0.68
        Const dblEUROS_FACTOR As Double = 0.83
        Const dblYEN_FACTOR As Double = 108.36
		lblStatus.Text = String.Empty
		Try
			' Get the amount of dollars from the user.
			Dim dblDollars As Double = CDbl(txtDollars.Text)

			' Calculate the conversions for Pounds, Euros, and Yen.
			Dim dblPounds As Double = dblDollars * dblPOUNDS_FACTOR
			Dim dblEuros As Double = dblDollars * dblEUROS_FACTOR
			Dim dblYen As Double = dblDollars * dblYEN_FACTOR

			' Display the results to the user.
			lblPounds.Text = dblPounds.ToString()
			lblEuros.Text = dblEuros.ToString()
			lblYen.Text = dblYen.ToString()
		Catch
			lblStatus.Text = "Please input a number"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtDollars text box.
        txtDollars.Clear()

        ' Set the Text in the labels to an empty string.
        lblPounds.Text = String.Empty
        lblEuros.Text = String.Empty
        lblYen.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtDollars.
        txtDollars.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
