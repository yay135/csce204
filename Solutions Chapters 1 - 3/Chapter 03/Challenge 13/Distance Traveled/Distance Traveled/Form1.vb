Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for 5, 8, and 12 hours.
        Const int5_HOURS As Integer = 5
        Const int8_HOURS As Integer = 8
		Const int12_HOURS As Integer = 12
		lblStatus.Text = String.Empty

		Try
			' Get the vehicle speed from the user.
			Dim intSpeed As Integer = CInt(txtSpeed.Text)

			' Calculate the distances travelled for 5, 8, and 12 hours.
			Dim int5HourDistance As Integer = intSpeed * int5_HOURS
			Dim int8HourDistance As Integer = intSpeed * int8_HOURS
			Dim int12HourDistance As Integer = intSpeed * int12_HOURS

			' Display the results.
			lbl5HourDistance.Text = int5HourDistance.ToString()
			lbl8HourDistance.Text = int8HourDistance.ToString()
			lbl12HourDistance.Text = int12HourDistance.ToString()
		Catch
			lblStatus.Text = "Please input a number"
		End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtSpeed text box.
        txtSpeed.Clear()

        ' Set the Text in the labels to an empty string.
        lbl5HourDistance.Text = String.Empty
        lbl8HourDistance.Text = String.Empty
        lbl12HourDistance.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtSpeed.
        txtSpeed.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
