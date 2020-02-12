Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Get the maximum credit and credit used and
        ' store the values in dblMaxCredit and dblCreditUsed.
        Dim dblMaxCredit As Double = CDbl(txtMaxCredit.Text)
        Dim dblCreditUsed As Double = CDbl(txtCreditUsed.Text)
        ' Subtract the dblMaxCredit value by the dblCreditUsed value
        ' and store the difference in dblAvailable.
        Dim dblAvailable As Double = dblMaxCredit - dblCreditUsed

        ' Display the available credit.
        lblAvailable.Text = dblAvailable.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
