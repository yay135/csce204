Public Class Form1

    Private Sub btnCalculateKineticEnergy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateKineticEnergy.Click
        Dim dblMass As Double           ' To hold the mass
        Dim dblVelocity As Double       ' To hold the velocity
        Dim dblKineticEnergy As Double  ' To hold the kinetic energy

        ' Get the object's mass as input from the user.
        ' Verify that the value is a positive real number.
        If Double.TryParse(txtMass.Text, dblMass) And dblMass >= 0.0 Then

            ' Get the object's velocity as input from the user.
            ' Verify that the value is a positive real number.
            If Double.TryParse(txtVelocity.Text, dblVelocity) And dblVelocity >= 0.0 Then

                ' Calculate and display the object's kinetic energy as output to the user.
                dblKineticEnergy = KineticEnergy(dblMass, dblVelocity)
                lblKineticEnergy.Text = dblKineticEnergy.ToString("n")
            Else
                ' Display a message box to the user indicating that the value for the object's velocity is invalid.
                MessageBox.Show("The object's velocity must be a positive real number.", "Invaid Input")
            End If
        Else
            ' Display a message box to the user indicating that the value for the object's mass is invalid.
            MessageBox.Show("The object's mass must be a positive real number.", "Invaid Input")
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtMass.Clear()
        txtVelocity.Clear()

        ' Set the Text in the lblKineticEnergy label to an empty string.
        lblKineticEnergy.Text = String.Empty

        ' Give the Focus to the txtMass text box.
        txtMass.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function KineticEnergy(ByVal dblMass As Double, ByVal dblVelocity As Double) As Double
        ' This function calculates and returns the amount of kinetic energy 
        ' that an object has based on the object's mass and velocity.
        Return 0.5 * dblMass * dblVelocity * dblVelocity
    End Function
End Class
