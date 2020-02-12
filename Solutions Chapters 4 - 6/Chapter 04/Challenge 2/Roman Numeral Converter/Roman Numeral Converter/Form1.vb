Public Class Form1

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim intDecimalInteger As Integer

        ' Get the decimal integer as input from the user.
        If Integer.TryParse(txtDecimalInteger.Text, intDecimalInteger) Then

            ' Display the Roman Numeral.
            Select Case intDecimalInteger
                Case 1
                    lblRomanNumeral.Text = "I"
                Case 2
                    lblRomanNumeral.Text = "II"
                Case 3
                    lblRomanNumeral.Text = "III"
                Case 4
                    lblRomanNumeral.Text = "IV"
                Case 5
                    lblRomanNumeral.Text = "V"
                Case 6
                    lblRomanNumeral.Text = "VI"
                Case 7
                    lblRomanNumeral.Text = "VII"
                Case 8
                    lblRomanNumeral.Text = "VIII"
                Case 9
                    lblRomanNumeral.Text = "IX"
                Case 10
                    lblRomanNumeral.Text = "X"

                    ' Display the error message.
                Case Else
                    lblRomanNumeral.Text = "Not in range 1 - 10"
            End Select

            ' Display the error message.
        Else
            lblRomanNumeral.Text = "Not in range 1 - 10"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
