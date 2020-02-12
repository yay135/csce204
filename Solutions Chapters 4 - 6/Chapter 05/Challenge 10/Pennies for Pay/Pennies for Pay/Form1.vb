Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intDays As Integer          ' To hold the number of days.
        Dim dblTotal As Double = 0.01   ' Total intitialized to one penny.
        ' Get the number of days as input from the user.
        If Integer.TryParse(cboDays.Text, intDays) And intDays > 0 Then
            Try
                ' Double the total for the number of days starting with the second day.
                For intDay = 2 To intDays
                    ' Double the total number of pennies.
                    dblTotal *= 2
                Next
            Catch ex As Exception
                ' Display an error message for the exception.
                MessageBox.Show(ex.Message, "Unexpected Error")
            End Try
            ' Display the total amount in the calculated label.
            lblTotal.Text = dblTotal.ToString("c")
        Else
            ' Display an error message for the number of days.
            MessageBox.Show("Value must be a whole number that is greater than zero.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the Text in the combo box.
        cboDays.ResetText()
        ' Set the Text in the label to an empty string.
        lblTotal.Text = String.Empty
        ' Give the focus to the cboDays combo box.
        cboDays.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
