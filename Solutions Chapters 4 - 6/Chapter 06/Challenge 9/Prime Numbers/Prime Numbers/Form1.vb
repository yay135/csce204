Public Class Form1
    Private Sub btnDisplayResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayResult.Click
        Dim intNumber As Integer    ' To hold the number

        ' Get the number as input from the user.
        ' Verify that the value is a whole number that is greater than zero.
        If Integer.TryParse(txtNumber.Text, intNumber) And intNumber > 0 Then

            ' Determine if the number entered by the user is prime or not.
            If IsPrime(intNumber) Then
                'Display a message box to the user indicating that the number is prime.
                MessageBox.Show(intNumber.ToString() & " is a prime number.", "Prime")
            Else
                'Display a message box to the user indicating that the number is composite.
                MessageBox.Show(intNumber.ToString() & " is a composite number.", "Composite")
            End If
        Else
            ' Display a message box to the user indicating that the number is invalid.
            MessageBox.Show("The value must be a whole number that is greater than zero.", "Invaid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtNumber text box.
        txtNumber.Clear()

        ' Give the Focus to the txtNumber text box.
        txtNumber.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function IsPrime(ByVal intNumber As Integer) As Boolean
        ' This function returns True if the number is a prime, otherwise it returns False.
        Dim intDivisors As Integer = 0      ' To hold the number of divisors, initialized to 0
        Dim blnStatus As Boolean = False    ' To hold the return value, initialized to False

        ' Starting with the number 1, divide the number by 
        ' all the values that are less than or equal to itself.
        For intCount = 1 To intNumber
            ' Determine if the values can be divided evenly.
            Select Case intNumber Mod intCount
                Case 0
                    ' Increment the number of divisors.
                    intDivisors += 1
            End Select
        Next
        ' If the number of divisors is 2, then the number is a prime.
        If intDivisors = 2 Then
            blnStatus = True
        End If
        Return blnStatus
    End Function

End Class
