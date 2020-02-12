Public Class Form1

    Private Sub btnDisplayData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click
        ' Named constant declarations
        Const dblYEARLY_RISE As Double = 1.5            ' Ocean's rise at about 1.5 millimeters per year.

        ' Local variable declarations
        Dim dblAmountRisen As Double = dblYEARLY_RISE   ' Initialize the amount risen to 1.5 millimeters.

        ' Calculate and display the yearly ocean rise for the next 10 years.
        For intYear = 1 To 10

            ' Display the amount risen for the current year.
            lstOutput.Items.Add("Year " & intYear.ToString() &
                                ControlChars.Tab & "Amount Risen: " &
                                dblAmountRisen.ToString() & " millimeters")

            ' Calculate the amount risen for the next year.
            dblAmountRisen += dblYEARLY_RISE
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
