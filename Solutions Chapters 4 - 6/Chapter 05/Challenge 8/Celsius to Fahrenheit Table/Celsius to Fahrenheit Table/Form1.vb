Public Class Form1

    Private Sub btnDisplayTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTable.Click
        ' Declare local variables.
        Dim intCelsius As Integer   ' Holds the temperature in Celsius.
        Dim dblFahrenheit As Double ' Holds the temperature in Fahrenheit.

        ' Display the Celsius temperatures 0 through 20
        ' and their Fahrenheit equivalents.
        For intCelsius = 0 To 20

            ' Calculate the temperature in Fahrenheit.
            dblFahrenheit = 1.8 * intCelsius + 32.0

            ' Display the output string in the lstOuput list box.
            lstOutput.Items.Add(ControlChars.Tab & intCelsius.ToString("D2") &
                                " C  ..............................  " &
                                dblFahrenheit.ToString("F2") & " F")
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
