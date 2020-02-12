Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a variable to hold the string input for the speed in miles per hour.
        Dim strSpeed As String = InputBox("Enter the speed of the vehicle in miles per hour", "Input Needed")

        ' Declare a variable to hold the user input for speed as an integer.
        Dim intSpeed As Integer

        ' Determine if the speed value input by the user is valid.
        If Integer.TryParse(strSpeed, intSpeed) And
            IsNumeric(strSpeed) And intSpeed >= 0 Then

            ' Declare a variable to hold the string input for the time in hours.
            Dim strTime As String = InputBox("Enter the number of hours the vehicle has traveled", "Input Needed")

            ' Declare a variable to hold the user input for time as an integer.
            Dim intTime As Integer

            ' Determine if the time value input by the user is valid.
            If Integer.TryParse(strTime, intTime) And
                IsNumeric(strTime) And intTime >= 0 Then

                ' Declare a variable to hold the distance the vehicle has traveled.
                Dim intDistance As Integer

                ' Display the static information in the lstOutput list box.
                lstOutput.Items.Add("Vehicle Speed: " & strSpeed & " MPH")
                lstOutput.Items.Add("Time Traveled: " & strTime & " hours")
                lstOutput.Items.Add("Hours " & vbTab & "Distance Traveled")
                lstOutput.Items.Add("---------------------------------------------")

                ' Use a For loop to display the distance the vehicle has
                ' traveled for each hour of the time period.
                For intHour As Integer = 1 To intTime

                    ' Calculate the distance for each hour traveled.
                    intDistance = intSpeed * intHour

                    ' Display the results for each hour in the lstOutput list box.
                    lstOutput.Items.Add(intHour.ToString("d") & vbTab & intDistance.ToString("d"))

                Next

                ' Display the total distance traveled in the lstOutput list box.
                lstOutput.Items.Add("Total Distance: " & intDistance.ToString("d"))

            Else
                ' Display a message to the user indicating that the input for time was invalid.
                MessageBox.Show("Hours Traveled - The value must be a positive number.", "Invalid Input")
            End If
        Else
            ' Display a message to the user indicating that the input for speed was invalid.
            MessageBox.Show("Vehicle Speed - The value must be a positive number.", "Invalid Input")
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
