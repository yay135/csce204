Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants to represent the rate of speed, in feet 
        ' per second, that a sound wave travels through air, water, and steel.
        Const dblSPEED_THROUGH_AIR As Double = 1100.0       '  1,100 feet per second.
        Const dblSPEED_THROUGH_WATER As Double = 4900.0     '  4,900 feet per second.
        Const dblSPEED_THROUGH_STEEL As Double = 16400.0    ' 16,400 feet per second.

        ' Declare a variable to store the rate of speed, in seconds, 
        ' that the sound wave will travel through the selected medium.
        Dim dblSpeed As Double

        ' Declare a variable to store the distance, in feet, that
        ' the sound wave will travel through the selected medium.
        Dim dblDistance As Double

        ' Declare a variable to store the time, in seconds, that it 
        ' takes the sound wave to travel through the selected medium.
        Dim dblTime As Double

        ' Get the distance, in feet, that the sound wave will travel as input from the user.
        If Double.TryParse(txtDistance.Text, dblDistance) And
            IsNumeric(txtDistance.Text) And dblDistance >= 0 Then

            ' Determine the rate of speed, in feet per second, that the sound 
            ' wave will travel based on the medium selected by the user.
            If radAir.Checked Then
                ' Set the speed to the rate that a sound wave travels through air.
                dblSpeed = dblSPEED_THROUGH_AIR
            ElseIf radWater.Checked Then
                ' Set the speed to the rate that a sound wave travels through water.
                dblSpeed = dblSPEED_THROUGH_WATER
            ElseIf radSteel.Checked Then
                ' Set the speed to the rate that a sound wave travels through steel.
                dblSpeed = dblSPEED_THROUGH_STEEL
            End If

            ' Calculate the time, in seconds, that it will take the sound wave 
            ' to travel the specified distance through the selected medium.
            ' Formula: time = distance / speed
            dblTime = dblDistance / dblSpeed

            ' Display the result as Text output to the user in the calculated lblTime label.
            lblTime.Text = dblTime.ToString("n2")
        Else
            ' Display a message box to the user indicating that the input for distance is invalid.
            MessageBox.Show("Distance - The value must be a positive real number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the Air radio button.
        radAir.Checked = True

        ' Clear the Text in the txtDistance text box.
        txtDistance.Clear()

        ' Set the Text in the lblTime label to an empty string.
        lblTime.Text = String.Empty

        ' Give the focus to txtDistance.
        txtDistance.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
