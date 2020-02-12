Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the number of seconds in a minute, hour, and day.
        Const intSECONDS_MINUTE As Integer = 60    ' 60 seconds in a minute.
        Const intSECONDS_HOUR As Integer = 3600    ' 3,600 seconds in an hour.
        Const intSECONDS_DAY As Integer = 86400    ' 86,400 seconds in a day.

        ' Declare a variable to hold the days.
        Dim intDays As Integer = 0
        ' Declare a variable to hold the hours.
        Dim intHours As Integer = 0
        ' Declare a variable to hold the minutes.
        Dim intMinutes As Integer = 0
        ' Declare a variable to hold the seconds.
        Dim intSeconds As Integer = 0
        ' Declare a variable to hold the output string.
        Dim strMessage As String = String.Empty

        ' Get the number of seconds as input from the user.
        If Integer.TryParse(txtSeconds.Text, intSeconds) And
            IsNumeric(txtSeconds.Text) And intSeconds >= 0 Then

            ' Determine if there are enough seconds to calculate the number of days.
            If intSeconds >= intSECONDS_DAY Then
                ' Calculate the number of days.
                intDays = intSeconds \ intSECONDS_DAY
                ' Calculate the remaining seconds.
                intSeconds = intSeconds Mod intSECONDS_DAY
                ' Add the number of days to the output string.
                strMessage &= intDays.ToString("d") & " days "
            End If

            ' Determine if there are enough seconds to calculate the number of hours.
            If intSeconds >= intSECONDS_HOUR Then
                ' Calculate the number of hours.
                intHours = intSeconds \ intSECONDS_HOUR
                ' Calculate the remaining seconds.
                intSeconds = intSeconds Mod intSECONDS_HOUR
                ' Add the number of hours to the output string.
                strMessage &= intHours.ToString("d") & " hours "
            End If

            ' Determine if there are enough seconds to calculate the number of minutes.     
            If intSeconds >= intSECONDS_MINUTE Then
                ' Calculate the number of minutes.
                intMinutes = intSeconds \ intSECONDS_MINUTE
                ' Calculate the remaining seconds.
                intSeconds = intSeconds Mod intSECONDS_MINUTE
                ' Add the number of minutes to the output string.
                strMessage &= intMinutes.ToString("d") & " minutes "
            End If

            ' Determine if there are any seconds remaining.
            If intSeconds > 0 Then
                ' Add the number of seconds remaining to the output string.
                strMessage &= intSeconds.ToString("d") & " seconds "
            End If

            ' Display the result in the lblOutput label.
            lblOuput.Text = strMessage
        Else
            ' Display a message to the user indicating the input for seconds is invalid.
            lblOuput.Text = "The value entered must be a positive whole number."
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtSeconds text box.
        txtSeconds.Clear()

        ' Set the Text in the lblOutput label to an empty string.
        lblOuput.Text = String.Empty

        ' Give the focus to the txtSeconds text box.
        txtSeconds.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
