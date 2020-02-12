Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the county and state tax rates.
        Const dblCOUNTY_TAX_RATE As Double = 0.02
		Const dblSTATE_TAX_RATE As Double = 0.04
		lblStatus.Text = String.Empty

		Try
			' Get the total monthly sales from the user.
			Dim dblTotalMonthlySales As Double = CDbl(txtTotalMonthlySales.Text)

			' Calculate the county sales tax.
			Dim dblCountySalesTax As Double = dblTotalMonthlySales * dblCOUNTY_TAX_RATE
			' Calculate the state sales tax.
			Dim dblStateSalesTax As Double = dblTotalMonthlySales * dblSTATE_TAX_RATE
			' Calculate the total sales tax.
			Dim dblTotalSalesTax As Double = dblCountySalesTax + dblStateSalesTax

			' Display the results to the user.
			lblCountySalesTax.Text = dblCountySalesTax.ToString("c")
			lblStateSalesTax.Text = dblStateSalesTax.ToString("c")
			lblTotalSalesTax.Text = dblTotalSalesTax.ToString("c")
		Catch
			lblStatus.Text = "Please input a number"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtTotalMonthlySales text box.
        txtTotalMonthlySales.Clear()

        ' Set the Text in the labels to an empty string.
        lblCountySalesTax.Text = String.Empty
        lblStateSalesTax.Text = String.Empty
		lblTotalSalesTax.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtTotalMonthlySales.
        txtTotalMonthlySales.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
