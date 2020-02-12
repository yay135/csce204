Public Class Form1

    ' Store the calculated historical prices.
    Dim strHistoricalPrices As String = "History"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decOriginalPrice As Decimal = 0 ' Original Price
        Dim decDiscountRate As Decimal = 0  ' Discount Rate
        Dim decPrice As Decimal = 0         ' Final Price
        Try
            ' Gather the original price from text box original price.
            decOriginalPrice = CDec(txtOriginalPrice.Text)
            ' Gather the discount rate from text box discount percentage.
            decDiscountRate = CDec(txtDiscountPercentage.Text) / 100
        Catch
            MessageBox.Show("Error: Invalid Input!")
        End Try

        ' Perform price calculation.
        decPrice = decOriginalPrice - decOriginalPrice * decDiscountRate

        ' Display the price to user.
        lblPrice.Text = decPrice.ToString("c")

        strHistoricalPrices = strHistoricalPrices & "," & decPrice.ToString("c")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnShowHistory_Click(sender As Object, e As EventArgs) Handles btnShowHistory.Click
        MessageBox.Show(strHistoricalPrices)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimeDate.Text = Now.ToString("D") & vbCrLf & Now.ToString("T")
    End Sub
End Class
