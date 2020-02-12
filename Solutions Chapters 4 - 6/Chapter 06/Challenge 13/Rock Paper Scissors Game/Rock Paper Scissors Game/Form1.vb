Public Class Form1

    ' Class-level onstants for the game selections
    Const intROCK As Integer = 1
    Const intPAPER As Integer = 2
    Const intSCISSORS As Integer = 3


    Private Sub picRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRock.Click
        ' Variables
        Dim intUser As Integer      ' The user's selection
        Dim intComputer As Integer  ' The computer's selection

        ' Get the computer's choice.
        intComputer = PlayerChoice()

        ' Set the user's choice to rock.
        intUser = intROCK

        ' Update the choices on the form.
        UpdateChoices(intUser, intComputer)

        ' Determine the winner.
        DetermineWinner(intUser, intComputer)
    End Sub

    Private Sub picPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPaper.Click
        ' Variables
        Dim intUser As Integer      ' The user's selection
        Dim intComputer As Integer  ' The computer's selection

        ' Get the computer's choice.
        intComputer = PlayerChoice()

        ' Set the user's choice to paper.
        intUser = intPAPER

        ' Update the choices on the form.
        UpdateChoices(intUser, intComputer)

        ' Determine the winner.
        DetermineWinner(intUser, intComputer)
    End Sub

    Private Sub picScissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picScissors.Click
        ' Variables
        Dim intUser As Integer      ' The user's selection
        Dim intComputer As Integer  ' The computer's selection

        ' Get the computer's choice.
        intComputer = PlayerChoice()

        ' Set the user's choice to scissors.
        intUser = intSCISSORS

        ' Update the choices on the form.
        UpdateChoices(intUser, intComputer)

        ' Determine the winner.
        DetermineWinner(intUser, intComputer)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' The PlayerChoice function returns a random integer in
    ' the range of 1 through 3.
    Private Function PlayerChoice() As Integer
        ' Variable to hold a random number.
        Dim intNum As Integer

        ' Declare a Random object.
        Dim rand As New Random

        ' Get a random number in the range of 1 through 3.
        intNum = rand.Next(3) + 1

        ' Return the random number.
        Return intNum
    End Function

    ' The ChoiceName function accepts an integer representing a game
    ' selection. The return value is determined as follows:
    '   If the argument equals intROCK, the function returns "Rock"
    '   If the argument equals intPAPER, the function returns "Paper"
    '   If the argument equals intSCISSORS, the function returns "Scissors"
    '   Otherwise the function returns "Unknown"
    Private Function ChoiceName(ByVal intChoice As Integer) As String
        ' Variable to hold the return value
        Dim strChoice As String

        ' Determine the choice.
        Select Case intChoice
            Case intROCK
                strChoice = "Rock"
            Case intPAPER
                strChoice = "Paper"
            Case intSCISSORS
                strChoice = "Scissors"
            Case Else
                strChoice = "Unknown"
        End Select

        ' Return the choice.
        Return strChoice
    End Function

    ' The UpdateChoices procedure displays the player's choices
    ' on the form.
    Private Sub UpdateChoices(ByVal intUser As Integer, ByVal intComputer As Integer)
        ' Display the computer's choice.
        lblComputer.Text = ChoiceName(intComputer)

        ' Display the user's choice.
        lblUser.Text = ChoiceName(intUser)
    End Sub

    ' The DetermineWinner function accepts integer arguments for the user's
    ' selection and the computer's selection. It displays the game results
    ' in a message box.
    Private Sub DetermineWinner(ByVal intUser As Integer, ByVal intComputer As Integer)

        ' Determine the winner.
        If intUser = intROCK Then
            If intComputer = intROCK Then
                MessageBox.Show("It's a tie!")
            ElseIf intComputer = intPAPER Then
                MessageBox.Show("The computer wins! Paper wraps rock.")
            ElseIf intComputer = intSCISSORS Then
                MessageBox.Show("You win! Rock smashes scissors.")
            Else
                MessageBox.Show("ERROR! Unknown value for the computer.")
            End If

        ElseIf intUser = intPAPER Then
            If intComputer = intROCK Then
                MessageBox.Show("You win! Paper wraps rock.")
            ElseIf intComputer = intPAPER Then
                MessageBox.Show("It's a tie!")
            ElseIf intComputer = intSCISSORS Then
                MessageBox.Show("The computer wins! Scissors cut paper.")
            Else
                MessageBox.Show("ERROR! Unknown value for the computer.")
            End If

        ElseIf intUser = intSCISSORS Then
            If intComputer = intROCK Then
                MessageBox.Show("The computer wins! Rock smashes scissors.")
            ElseIf intComputer = intPAPER Then
                MessageBox.Show("You win! Scissors cut paper.")
            ElseIf intComputer = intSCISSORS Then
                MessageBox.Show("It's a tie!")
            Else
                MessageBox.Show("ERROR! Unknown value for the computer.")
            End If
        Else
            MessageBox.Show("ERROR! Unknown value for the user.")
        End If

        ' Start another game.
        lblComputer.Text = String.Empty
        lblUser.Text = String.Empty
    End Sub
End Class

