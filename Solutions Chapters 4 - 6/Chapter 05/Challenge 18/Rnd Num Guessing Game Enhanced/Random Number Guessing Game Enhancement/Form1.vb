Public Class Form1

    Private Sub btnTryGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTryGuess.Click
        ' Local variable declarations
        Dim rand As New Random      ' The random number generator
        Dim intNumber As Integer    ' The number to guess
        Dim intGuess As Integer     ' The user's guess
        Dim intGuesses As Integer   ' The number of guesses.

        ' Generate a random number between 1 and 100.
        intNumber = 1 + rand.Next(99)

        ' Set the number of guesses to zero.
        intGuesses = 0

        ' Get the user's intital guess.
        Integer.TryParse(InputBox("Enter your guess.", "Guessing Game"), intGuess)

        ' Repeat the loop until the user correctly guesses the number.
        While intGuess <> intNumber

            ' Determine if the user's guess is too high or too low.
            If intGuess > intNumber Then

                ' Get anoother guess from the user, and display a message 
                ' to the user that the number they guessed was too high.
                Integer.TryParse(InputBox("Too high, try again.", "Guessing Game"), intGuess)

            ElseIf intGuess < intNumber Then

                ' Get anoother guess from the user, and display a message 
                ' to the user that the number they guessed was too low.
                Integer.TryParse(InputBox("Too low, try again.", "Guessing Game"), intGuess)
            End If
            ' Increment the number of guesses
            intGuesses += 1
        End While

        ' Display a message to the user indicating that they have correctly 
        ' guessed the number, and also display the number of guesses.
        MessageBox.Show("Great! You guessed the number." &
                        ControlChars.CrLf & ControlChars.CrLf &
                        "Total number of guesses: " &
                        intGuesses.ToString(), "Congratualtions")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
