Public Class Form1

    Private Sub btnDisplayResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayResults.Click
        ' Declare a named constant for the minimum and maximum values.
        Const intMIN_MONTH As Integer = 1       ' 1 is the minimum Month value.
        Const intMAX_MONTH As Integer = 12      ' 12 is the maximum Month value.

        Const intMIN_DAY As Integer = 1         ' 1 is the minimum Day value.
        Const intMAX_DAY As Integer = 31        ' 31 is the maximum Day value.

        Const intMIN_YEAR As Integer = 0        ' 0 is the minimum Year value.
        Const intMAX_YEAR As Integer = 99       ' 99 is the maximum Year value.

        ' Declare a variable to hold the month.
        Dim intMonth As Integer

        ' Declare a variable to hold the day.
        Dim intDay As Integer

        ' Declare a variable to hold the year.
        Dim intYear As Integer

        ' Declare a variable to hold the message.
        Dim strMessage As String

        ' Get the Month as input from the user.
        If Integer.TryParse(txtMonth.Text, intMonth) And IsNumeric(txtMonth.Text) And
            intMonth >= intMIN_MONTH And intMonth <= intMAX_MONTH Then

            ' Get the Day as input from the user.
            If Integer.TryParse(txtDay.Text, intDay) And IsNumeric(txtDay.Text) And
                intDay >= intMIN_DAY And intDay <= intMAX_DAY Then

                ' Get the year as input from the user.
                If Integer.TryParse(txtYear.Text, intYear) And IsNumeric(txtYear.Text) And
                    intYear >= intMIN_YEAR And intYear <= intMAX_YEAR Then

                    ' Determine if the date is magic.
                    ' Magic if the Month multiplied by the Day equals the Year.
                    Select Case intMonth * intDay
                        Case intYear
                            strMessage = "The Date is Magic!"       ' It's Magic!
                        Case Else
                            strMessage = "The Date is Not Magic."   ' Not Magic.
                    End Select

                    ' Display the result in the lblMessage label as output to the user.
                    lblMessage.Text = strMessage
                Else
                    ' Display a message to the user indicating the year value is invalid.
                    MessageBox.Show("Year - The value must be a number between " &
                                    intMIN_YEAR.ToString("d") & " and " &
                                    intMAX_YEAR.ToString("d") & ".", "Invalid Input")
                End If
            Else
                ' Display a message to the user indicating the day value is invalid.
                MessageBox.Show("Day - The value must be a number between " &
                                intMIN_DAY.ToString("d") & " and " &
                                intMAX_DAY.ToString("d") & ".", "Invalid Input")
            End If
        Else
            ' Display a message to the user indicating the month value is invalid.
            MessageBox.Show("Month - The value must be a number between " &
                            intMIN_MONTH.ToString("d") & " and " &
                            intMAX_MONTH.ToString("d") & ".", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtMonth.Clear()
        txtDay.Clear()
        txtYear.Clear()

        ' Set the Text in the lblMessage label to an empty string.
        lblMessage.Text = String.Empty

        ' Give the focus to the txtMonth text box.
        txtMonth.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
