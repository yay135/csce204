Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim val1 As Integer = 1
        Dim val2 As Integer = 1
        lstValues.Items.Add(val1.ToString())
        lstValues.Items.Add(val2.ToString())

        For i = 1 To 98
            Dim val3 = val1 + val2
            lstValues.Items.Add(val3.ToString())
            val1 = val2
            val2 = val3
        Next

    End Sub
End Class
