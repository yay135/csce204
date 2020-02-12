Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' This prodecure calculates the miles that a car can travel 
        ' per gallon of gas and displays the result.

        ' Variables
        Dim dblMiles As Double      ' Miles driven on full tank of gas.
        Dim dblGallons As Double    ' Number of gallons the tank holds.
        Dim dblMPG As Double        ' Miles traveled per gallon of gas.

		Try
			lblStatus.Text = String.Empty
			' Get the miles driven on a full tank of gas and the number of 
			' gallons the tank holds that has been entered by the user.
			dblMiles = CDbl(txtMiles.Text)
			dblGallons = CDbl(txtGallons.Text)

			' Calculate the miles that a car can travel per gallon of gas.
			dblMPG = dblMiles / dblGallons

			' Display the miles that a car can travel per gallon of gas.
			lblMPG.Text = dblMPG.ToString("n2")
		Catch
			lblStatus.Text = "Please enter numeric values"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the text.
        txtGallons.Text = String.Empty
        txtMiles.Text = String.Empty
        lblMPG.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Reset the focus.
        txtGallons.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
