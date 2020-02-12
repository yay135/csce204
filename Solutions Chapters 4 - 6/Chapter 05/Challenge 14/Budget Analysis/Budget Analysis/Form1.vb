Public Class Form1

    Private Sub btnEnterExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterExpenses.Click
        ' Declare local variables
        Dim dblMonthlyBudget As Double  ' The budget amount for the month
        Dim dblTotalExpenses As Double  ' The total amount of expenses
        Dim dblSingleExpense As Double  ' The amount of a single expense
        Dim dblDifference As Double     ' The amount over or under budget

        ' Get the budget amount as input from the user.
        If Double.TryParse(txtBudget.Text, dblMonthlyBudget) Then

            ' Loop until the value is invaid or the input box's cancel button is clicked.
            Do Until Not (Double.TryParse(InputBox("Enter an amount for the expense." &
                                                   ControlChars.CrLf & ControlChars.CrLf &
                                                   "Click the Cancel button to exit.",
                                                   "Monthly Expenses"), dblSingleExpense))
                ' Keep a running total of expenses.
                dblTotalExpenses += dblSingleExpense

            Loop

            ' Calculate the difference in the budget and total expenses.
            dblDifference = dblMonthlyBudget - dblTotalExpenses

            ' Display the result to the user in the calculated label.
            lblDifference.Text = dblDifference.ToString("c")
        Else
            ' Display an error message for the budget amount.
            MessageBox.Show("The monthly budget amount must be a postive real number .", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the text box.
        txtBudget.Clear()

        ' Set the Text in the label to an empty string.
        lblDifference.Text = String.Empty

        ' Give the focus to the txtBudget text box.
        txtBudget.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
