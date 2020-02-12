Public Class Form1

    Private Sub btnEnterNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterNumbers.Click
        ' Declare a variable to store the user input string from the input box.
        Dim strInputString As String = InputBox("Enter a positive integer value.", "Input Needed", "10")

        ' Declare a variable to store the user input as an integer value.
        Dim intInputNumber As Integer

        ' Declare a variable to store the sum of numbers, intitialized to zero.
        Dim intSum As Integer = 0

        ' Make sure the value input by the user is a positive number.
        If Integer.TryParse(strInputString, intInputNumber) And
            IsNumeric(strInputString) And intInputNumber >= 0 Then

            ' Use a For loop to sum of all the integers from 
            ' 1 through the value entered by the user.
            For intCounter As Integer = 1 To intInputNumber
                intSum += intCounter
            Next

            ' Display a message to the user indicating the sum of numbers.
            MessageBox.Show("The sum of numbers 1 through " &
                            strInputString & " is " &
                            intSum.ToString("d"), "Sum of Numbers")
        Else
            ' Display a message to the user indicating that the input was invalid.
            MessageBox.Show("Enter a positive integer value.", "Invalid Input")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
