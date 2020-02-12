Public Class Form1

    Private Sub btnDoIt_Click(sender As Object, e As EventArgs) Handles btnDoIt.Click

        lblStatus.Text = String.Empty

        Dim index As Integer = txtInputName.Text.IndexOf(",")
        If index = -1 Then
            lblStatus.Text = "Don't forget the comma!"
            Exit Sub
        End If

        Dim p As Integer
        If txtInputName.Text.Contains(" ") Then
            p = 2
        Else
            p = 1
        End If

        lblResult.Text = txtInputName.Text.Substring(index + p, txtInputName.Text.Length - index - p) _
             & " " & txtInputName.Text.Substring(0, index)

    End Sub
End Class
