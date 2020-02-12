Public Class Form1
    Private Sub btnSinister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinister.Click
        ' Display Left.
        lblEnglishTranslation.Text = "Left"
        ' Align text middle left.
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedium.Click
        'Display Middle.
        lblEnglishTranslation.Text = "Middle"
        ' Align text middle center.
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnDexter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDexter.Click
        ' Display Right.
        lblEnglishTranslation.Text = "Right"
        ' Align text middle right.
        lblEnglishTranslation.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
