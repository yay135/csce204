Public Class Form1
    Private Sub btnDisplayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayList.Click
        ' Display the list of prime numbers as output to the user.
        For intNumber = 1 To 100
            If IsPrime(intNumber) Then
                lstOutput.Items.Add(intNumber)
            End If
        Next
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
