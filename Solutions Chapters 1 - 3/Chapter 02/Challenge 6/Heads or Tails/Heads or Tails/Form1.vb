Public Class Form1
    Private Sub btnHeads_Click(sender As Object, e As EventArgs) Handles btnHeads.Click
        picHeads.Visible = True
        picTails.Visible = False
    End Sub

    Private Sub btnTails_Click(sender As Object, e As EventArgs) Handles btnTails.Click
        picHeads.Visible = False
        picTails.Visible = True
    End Sub
End Class
