Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Get the starting balance, deposits, and 
        ' withdrawals as input from the user.
        Dim dblStartingBal As Double = CDbl(txtStartingBal.Text)
        Dim dblDeposits As Double = CDbl(txtDeposits.Text)
        Dim dblWithdrawals As Double = CDbl(txtWithdrawals.Text)

        ' Add the value of dblDeposits to dblBalance
        ' and subtract the value of dblWithdrawals.
        Dim dblBalance As Double = dblStartingBal + dblDeposits - dblWithdrawals

        ' Store the dblBalance value in lblBalance.Text
        lblBalance.Text = dblBalance.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
