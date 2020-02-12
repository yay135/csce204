Public Class Form1
    ' Class-level constants
    Const dblGRAVITY As Double = 9.8    ' The acceleration of a falling object on Earth is 9.8 meters per second, per second.
    Private Sub btnCalculateDistance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateDistance.Click
        Dim dblDistance As Double = 0.0 ' To hold the distance
        Dim dblTime As Double = 0.0     ' To hold the time

        ' Get the time in seconds as input from the user.
        ' Verify that the value is a postive real number.
        If Double.TryParse(txtTime.Text, dblTime) And dblTime >= 0.0 Then

            ' Calculate and display the distance as output to the user.
            dblDistance = FallingDistance(dblTime)
            lblDistance.Text = dblDistance.ToString("n")
        Else
            ' Display a message to the user indicating that the value for time in seconds is invalid.
            MessageBox.Show("The number of seconds must be a positive real number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtTime text box.
        txtTime.Clear()

        ' Set the Text in the lblDistance label to an empty string.
        lblDistance.Text = String.Empty

        ' Give the Focus to the txtTime text box.
        txtTime.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function FallingDistance(ByVal dblTime As Double) As Double
        ' This function calculates and returns the distance that 
        ' an object has fallen during the dblTime interval.
        Return 0.5 * dblGRAVITY * dblTime * dblTime
    End Function
End Class
