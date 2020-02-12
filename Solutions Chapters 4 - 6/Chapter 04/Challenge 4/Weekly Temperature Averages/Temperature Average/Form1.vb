Public Class Form1

    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        Const intNUM_TEMPS As Integer = 5
        lblStatus.Text = String.Empty

        Dim dblTemp1 As Double
        Dim dblTemp2 As Double
        Dim dblTemp3 As Double
        Dim dblTemp4 As Double
        Dim dblTemp5 As Double

        '************ Check Temperature 1 *********************
        If Not Double.TryParse(txtTemp1.Text, dblTemp1) Then
            lblStatus.Text = "Temperature #1 must be numeric"
            txtTemp1.Focus()
            txtTemp1.SelectAll()
            Exit Sub
        End If

        If dblTemp1 < -50 Or dblTemp1 > 130 Then
            lblStatus.Text = "Temperature #1 must be between -50 and +130"
            txtTemp1.Focus()
            txtTemp1.SelectAll()
            Exit Sub
        End If

        '************ Check Temperature 2 *********************

        If Not Double.TryParse(txtTemp2.Text, dblTemp2) Then
            lblStatus.Text = "Temperature #2 must be numeric"
            txtTemp2.Focus()
            txtTemp2.SelectAll()
            Exit Sub
        End If

        If dblTemp2 < -50 Or dblTemp2 > 130 Then
            lblStatus.Text = "Temperature #2 must be between -50 and +130"
            txtTemp2.Focus()
            txtTemp2.SelectAll()
            Exit Sub
        End If

        '************ Check Temperature 3 *********************

        If Not Double.TryParse(txtTemp3.Text, dblTemp3) Then
            lblStatus.Text = "Temperature #3 must be numeric"
            txtTemp3.Focus()
            txtTemp3.SelectAll()
            Exit Sub
        End If

        If dblTemp3 < -50 Or dblTemp3 > 130 Then
            lblStatus.Text = "Temperature #3 must be between -50 and +130"
            txtTemp3.Focus()
            txtTemp3.SelectAll()
            Exit Sub
        End If

        '************ Check Temperature 4 *********************

        If Not Double.TryParse(txtTemp4.Text, dblTemp1) Then
            lblStatus.Text = "Temperature #4 must be numeric"
            txtTemp4.Focus()
            txtTemp4.SelectAll()
            Exit Sub
        End If

        If dblTemp4 < -50 Or dblTemp4 > 130 Then
            lblStatus.Text = "Temperature #4 must be between -50 and +130"
            txtTemp4.Focus()
            txtTemp4.SelectAll()
            Exit Sub
        End If

        '************ Check Temperature 5 *********************

        If Not Double.TryParse(txtTemp5.Text, dblTemp1) Then
            lblStatus.Text = "Temperature #5 must be numeric"
            txtTemp5.Focus()
            txtTemp5.SelectAll()
            Exit Sub
        End If

        If dblTemp5 < -50 Or dblTemp5 > 130 Then
            lblStatus.Text = "Temperature #5 must be between -50 and +130"
            txtTemp5.Focus()
            txtTemp5.SelectAll()
            Exit Sub
        End If

        ' Get the sum of all the temperatures.
        Dim dblSum As Double = dblTemp1 + dblTemp2 + dblTemp3 +
            dblTemp4 + dblTemp5

        ' Calculate the average temperatures.
        Dim dblAverage As Double = dblSum / intNUM_TEMPS

        ' Display the average temperature in lblAverage.
        lblAverage.Text = dblAverage.ToString("n")

    End Sub

    Private Sub btnClear_Click() Handles btnClear.Click
        ' Clear the Text Boxes and lblAverage
        txtTemp1.Clear()
        txtTemp2.Clear()
        txtTemp3.Clear()
        txtTemp4.Clear()
        txtTemp5.Clear()
        lblAverage.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Give the focus to txtTemp1
        txtTemp1.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
