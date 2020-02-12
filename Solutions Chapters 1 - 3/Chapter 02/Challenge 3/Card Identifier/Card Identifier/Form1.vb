Public Class Form1
    Private Sub picEight_Click(sender As Object, e As EventArgs) Handles picEight.Click
        lblResult.Text = "Eight of Diamonds"
    End Sub

    Private Sub picTwo_Click(sender As Object, e As EventArgs) Handles picTwo.Click
        lblResult.Text = "Two of Clubs"
    End Sub

    Private Sub picKing_Click(sender As Object, e As EventArgs) Handles picKing.Click
        lblResult.Text = "King of Spades"
    End Sub

    Private Sub picAce_Click(sender As Object, e As EventArgs) Handles picAce.Click
        lblResult.Text = "Ace of Spades"
    End Sub

    Private Sub picJoker_Click(sender As Object, e As EventArgs) Handles picJoker.Click
        lblResult.Text = "Joker"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
