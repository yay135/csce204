Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Constant for revenue percentage the theater keeps.
		Const dblREVENUE_PERCENTAGE As Double = 0.2R
		lblStatus.Text = String.Empty

		Try
			' Get ticket price and number sold for children and adults.
			Dim dblAdultPrice As Double = CDbl(txtAdultPrice.Text)
			Dim intAdultSold As Integer = CInt(txtAdultSold.Text)
			Dim dblChildPrice As Double = CDbl(txtChildPrice.Text)
			Dim intChildSold As Integer = CInt(txtChildSold.Text)

			' Calculate the gross revenue for children and adult ticket sales.
			Dim dblGrossAdult As Double = CDbl(dblAdultPrice * intAdultSold)
			Dim dblGrossChild As Double = CDbl(dblChildPrice * intChildSold)
			Dim dblGrossRevenue As Double = dblGrossAdult + dblGrossChild

			' Calculate the net revenue for children and adult ticket sales.
			Dim dblNetAdult As Double = dblGrossAdult * dblREVENUE_PERCENTAGE
			Dim dblNetChild As Double = dblGrossChild * dblREVENUE_PERCENTAGE
			Dim dblNetRevenue As Double = dblNetAdult + dblNetChild

			' Display the gross ticket revenue.
			lblGrossAdultSales.Text = dblGrossAdult.ToString("c")
			lblGrossChildSales.Text = dblGrossChild.ToString("c")
			lblGrossRevenue.Text = dblGrossRevenue.ToString("c")

			' Display the net ticket revenue.
			lblNetAdultSales.Text = dblNetAdult.ToString("c")
			lblNetChildSales.Text = dblNetChild.ToString("c")
			lblNetRevenue.Text = dblNetRevenue.ToString("c")
		Catch
			lblStatus.Text = "Please enter numeric values"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear Text Boxes and Labels
        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()
        lblGrossAdultSales.Text = String.Empty
        lblGrossChildSales.Text = String.Empty
        lblGrossRevenue.Text = String.Empty
        lblNetAdultSales.Text = String.Empty
        lblNetChildSales.Text = String.Empty
        lblNetRevenue.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtAdultPrice
        txtAdultPrice.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
