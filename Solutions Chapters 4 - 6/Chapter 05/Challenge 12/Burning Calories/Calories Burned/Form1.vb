Public Class Form1


    Private dblCaloriesPerMinute As Double

    Private Sub btnDisplayData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click
        ' Named constant declarations
        Const intTIME_INTERVAL As Integer = 5               ' The time interval is set to 5 minutes.
        Const intTIME_BEGIN As Integer = 10                 ' The time to begin displaying ouput is set to 10 minutes.
        Const intTIME_END As Integer = 30                   ' The time to end displaying output is set to 30 minutes.

        lstOutput.Items.Clear()

        Select Case cboSpeed.Text
            Case "Low"
                dblCaloriesPerMinute = 3.5
            Case "Medium"
                dblCaloriesPerMinute = 4.5
            Case "High"
                dblCaloriesPerMinute = 6.0
        End Select

        ' Local variable declaration for the number of calories burned is 
        ' initialized to the number of calories burned after one five minute interval.
        Dim dblCaloriesBurned As Double = dblCaloriesPerMinute * intTIME_INTERVAL

        ' Calculate and display the calories burned at five minute intervals,
        ' beginning at 10 minutes and ending after 30 minutes.
        For intMinutes = intTIME_BEGIN To intTIME_END Step intTIME_INTERVAL

            ' Calculate the number of calories burned for the current time interval.
            dblCaloriesBurned += dblCaloriesPerMinute * intTIME_INTERVAL

            ' Display the output in the lstOutput list box.
            lstOutput.Items.Add("Minutes " & intMinutes.ToString() &
                                ControlChars.Tab & "Calories Burned: " &
                                dblCaloriesBurned.ToString())
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
