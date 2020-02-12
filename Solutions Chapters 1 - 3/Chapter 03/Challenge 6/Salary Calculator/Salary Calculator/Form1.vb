﻿Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal  ' Annual salary
        Dim intPayPeriods As Integer    ' Number of pay periods
        Dim decSalary As Decimal        ' Salary per pay period

        Try
            ' Get the annual salary and number of pay periods.
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intPayPeriods = CInt(txtPayPeriods.Text)

            ' Calculate the salary per pay period.
            decSalary = decAnnualSalary / intPayPeriods

            ' Display the salary per pay period.
            lblSalary.Text = decSalary.ToString("c")
        Catch
            ' Display an error message.
            lblMessage.Text = "Error: Be sure to enter nonzero numeric values."
        End Try
    End Sub
End Class
