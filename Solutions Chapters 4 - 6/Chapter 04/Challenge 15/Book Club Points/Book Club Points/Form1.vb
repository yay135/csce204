Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the number of books in each tier.
        Const intBOOKS_PURCHASED_TIER_0 As Integer = 0      ' 0 books purchased.
        Const intBOOKS_PURCHASED_TIER_1 As Integer = 1      ' 1 book purchased.
        Const intBOOKS_PURCHASED_TIER_2 As Integer = 2      ' 2 books purchased.
        Const intBOOKS_PURCHASED_TIER_3 As Integer = 3      ' 3 books purchased.
        Const intBOOKS_PURCHASED_TIER_4 As Integer = 4      ' 4 or more books purchased.

        ' Declare named constants for the number of points in each tier.
        Const intPOINTS_AWARDED_TIER_0 As Integer = 0       ' 0 points awarded.
        Const intPOINTS_AWARDED_TIER_1 As Integer = 5       ' 5 points awarded.
        Const intPOINTS_AWARDED_TIER_2 As Integer = 15      ' 15 points awarded.
        Const intPOINTS_AWARDED_TIER_3 As Integer = 30      ' 30 points awarded.
        Const intPOINTS_AWARDED_TIER_4 As Integer = 60      ' 60 points awarded.

        ' Declare a variable to hold the number of books purchased.
        Dim intBooksPurchased As Integer

        ' Declare a variable to hold the number of points awarded.
        Dim intPointsAwarded As Integer

        ' Get the number of books purchased this month as input from the user.
        If Integer.TryParse(txtBooksPurchased.Text, intBooksPurchased) And
            IsNumeric(txtBooksPurchased.Text) And intBooksPurchased >= 0 Then

            ' Determine the points to award for books purchased this month.
            Select Case intBooksPurchased
                Case intBOOKS_PURCHASED_TIER_0
                    intPointsAwarded = intPOINTS_AWARDED_TIER_0
                Case intBOOKS_PURCHASED_TIER_1
                    intPointsAwarded = intPOINTS_AWARDED_TIER_1
                Case intBOOKS_PURCHASED_TIER_2
                    intPointsAwarded = intPOINTS_AWARDED_TIER_2
                Case intBOOKS_PURCHASED_TIER_3
                    intPointsAwarded = intPOINTS_AWARDED_TIER_3
                Case Is >= intBOOKS_PURCHASED_TIER_4
                    intPointsAwarded = intPOINTS_AWARDED_TIER_4
            End Select

            ' Display the result in the lblPointsAwarded label as output to the user.
            lblPointsAwarded.Text = intPointsAwarded.ToString("d")
        Else
            ' Display a message to the user indicating the input was invalid.
            MessageBox.Show("Books Purchased - The value must a positive number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtBooksPurchased text box.
        txtBooksPurchased.Clear()

        ' Set the Text in the lblPointsAwarded label to an empty string.
        lblPointsAwarded.Text = String.Empty

        ' Give the focus to the txtBooksPurchased text box.
        txtBooksPurchased.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
