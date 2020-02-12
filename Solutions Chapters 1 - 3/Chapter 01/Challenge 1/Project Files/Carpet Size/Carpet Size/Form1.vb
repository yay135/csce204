Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Get the length and width values and
        ' store them in dblLength and dblWidth.
        Dim dblLength As Double = CDbl(txtLength.Text)
        Dim dblWidth As Double = CDbl(txtWidth.Text)
        ' Multiply the value of dblLength by the value
        ' of dblWidth and store the product in dblArea.
        Dim dblArea As Double = dblLength * dblWidth
        ' Display the value of dblArea
        lblArea.Text = dblArea.ToString("n2")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
