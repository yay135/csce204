Public Class Form1

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim str As String = txtInputVal.Text
        Dim len As Integer = str.Length
        Dim p As Integer

        ' First comma
        p = str.IndexOf(",", 0)
        If p <> -1 Then
            str = str.Substring(0, p) & str.Substring(p + 1, len - p - 1)
        End If
        len -= 1

        ' Second comma
        p = str.IndexOf(",", 0)
        If p <> -1 Then
            str = str.Substring(0, p) & str.Substring(p + 1, len - p - 1)
        End If
        len -= 1

        ' Third comma
        p = str.IndexOf(",", 0)
        If p <> -1 Then
            str = str.Substring(0, p) & str.Substring(p + 1, len - p - 1)
        End If
        len -= 1


        lblResult.Text = str
    End Sub
End Class
