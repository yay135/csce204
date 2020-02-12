Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Input and Validate all the weekly PPQ inputs 

        Dim numClicks As Integer
        Dim revenue As Double
        Dim costOfAdvertising As Double
        lblStatus.Text = String.Empty

        If Not Double.TryParse(txtAdvertisingCost.Text, costOfAdvertising) Then
            lblStatus.Text = "Cost of Advertising must be numeric"
            Exit Sub
        End If

        '**** This section Repeats *******************************
        If Not Integer.TryParse(txtWeek1.Text, numClicks) Then
            lblStatus.Text = "PPQ for week 1 must be an integer"
            Exit Sub
        End If

        ' Calculate the revenue for the current week
        revenue = 0
        If numClicks > 0 Then
            revenue = costOfAdvertising / numClicks
        End If
        lblRevenue1.Text = revenue.ToString("n")

        '**** This section Repeats *******************************
        If Not Integer.TryParse(txtWeek2.Text, numClicks) Then
            lblStatus.Text = "PPQ for week 2 must be an integer"
            Exit Sub
        End If

        ' Calculate the revenue for the current week
        revenue = 0
        If numClicks > 0 Then
            revenue = costOfAdvertising / numClicks
        End If
        lblRevenue2.Text = revenue.ToString("n")

        '**** This section Repeats *******************************
        If Not Integer.TryParse(txtWeek3.Text, numClicks) Then
            lblStatus.Text = "PPQ for week 3 must be an integer"
            Exit Sub
        End If

        ' Calculate the revenue for the current week
        revenue = 0
        If numClicks > 0 Then
            revenue = costOfAdvertising / numClicks
        End If
        lblRevenue3.Text = revenue.ToString("n")

        '**** This section Repeats *******************************
        If Not Integer.TryParse(txtWeek4.Text, numClicks) Then
            lblStatus.Text = "PPQ for week 4 must be an integer"
            Exit Sub
        End If

        ' Calculate the revenue for the current week
        revenue = 0
        If numClicks > 0 Then
            revenue = costOfAdvertising / numClicks
        End If
        lblRevenue4.Text = revenue.ToString("n")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdvertisingCost.Clear()
        txtWeek1.Clear()
        txtWeek2.Clear()
        txtWeek3.Clear()
        txtWeek4.Clear()
        lblRevenue1.Text = String.Empty
        lblRevenue2.Text = String.Empty
        lblRevenue3.Text = String.Empty
        lblRevenue4.Text = String.Empty
    End Sub
End Class
