Public Class Form1

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click

        ' Step 1: change "." at the end to a comma
        Dim str As String = txtSentence.Text
        Dim len As Integer = str.Length
        If str.Substring(len - 1, 1) = "." Then
            str = str.Substring(0, len - 1) & ","
        End If

        'Steps 2, 3, and 4: Move the first word to the end.
        Dim p As Integer = str.IndexOf(" ")
        Dim word As String = ""
        If p <> -1 Then
            word = str.Substring(0, p)
            str = str.Substring(p + 1, len - p - 1) & " " & word
        End If

        ' Step 4: remove any leading comma
        len = str.Length
        If str.IndexOf(",") = 0 Then
            str = str.Substring(1, len - 1)
        End If

        'Step 6: Capitalize the first letter, the rest must be lowercase.
        len = str.Length
        str = str.Substring(0, 1).ToUpper & str.Substring(1, len - 1).ToLower

        txtSentence.Text = str
    End Sub
End Class
