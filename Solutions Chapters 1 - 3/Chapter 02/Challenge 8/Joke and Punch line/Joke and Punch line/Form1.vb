Public Class Form1
    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        ' Display the setup.
        lblJoke.Text = "How many programmers does it take to change a light bulb?"
    End Sub

    Private Sub btnPunchLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchLine.Click
        ' Display the punch line.
        lblJoke.Text = "None. That's a hardware problem."
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
