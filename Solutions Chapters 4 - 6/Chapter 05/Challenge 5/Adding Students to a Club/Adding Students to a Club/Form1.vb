Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lstGeneral.SelectedIndex = -1 Then Exit Sub

        Dim name As String = lstGeneral.SelectedItem.ToString()
        If Not lstMembers.Items.Contains(name) Then
            lstMembers.Items.Add(lstGeneral.SelectedItem)
            lblCount.Text = lstMembers.Items.Count.ToString() & " members"
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim index As Integer = lstMembers.SelectedIndex
        If index <> -1 Then
            lstMembers.Items.RemoveAt(index)
        End If

        lblCount.Text = lstMembers.Items.Count.ToString() & " members"
    End Sub
End Class
