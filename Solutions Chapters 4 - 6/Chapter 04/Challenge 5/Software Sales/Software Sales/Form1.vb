Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim softwareLicense As Double
        Dim optionCosts As Double

        If radYearly.Checked Then
            softwareLicense = 5000
        ElseIf radOneTime.Checked Then
            softwareLicense = 20000
        End If

        If chkBackup.Checked Then
            optionCosts += 300
        End If

        If chkLevel3Support.Checked Then
            optionCosts += 3500
        End If

        If chkTraining.Checked Then
            optionCosts += 2000
        End If

        lblOptionalFeatures.Text = optionCosts.ToString("n")
        lblSoftwareLicense.Text = softwareLicense.ToString("n")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radOneTime.Checked = False
        radYearly.Checked = False
        chkBackup.Checked = False
        chkLevel3Support.Checked = False
        chkTraining.Checked = False
        lblOptionalFeatures.Text = String.Empty
        lblSoftwareLicense.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
