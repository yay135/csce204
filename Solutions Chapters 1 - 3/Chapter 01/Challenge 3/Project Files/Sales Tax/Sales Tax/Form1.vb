Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Get the amount and tax rate values
        ' and store them in dblAmount and dblTaxRate.
        Dim dblAmount As Double = CDbl(txtAmount.Text)
        Dim dblTaxRate As Double = CDbl(txtTaxRate.Text)

        ' Multiply the value of dblTaxRate by the value
        ' of dblAmount and store the product in dblTax.
        Dim dblTax As Double = dblTaxRate * dblAmount

        ' Add the value of dblAmount to the value of
        ' dblTax and store the sum in dblTotal.
        Dim dblTotal As Double = dblAmount + dblTax

        ' Store the value of dblTax and
        ' dblTotal in lblTax.Text and lblTotal.Text.
        lblTax.Text = dblTax.ToString("c")
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
