Public Class Form1

    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        Const intNUM_TEMPS As Integer = 5
        lblStatus.Text = String.Empty

        Try
            ' Get the temperatures from the Text Boxes.
            Dim dblTemp1 As Double = CDbl(txtTemp1.Text)
            Dim dblTemp2 As Double = CDbl(txtTemp2.Text)
            Dim dblTemp3 As Double = CDbl(txtTemp3.Text)
            Dim dblTemp4 As Double = CDbl(txtTemp4.Text)
            Dim dblTemp5 As Double = CDbl(txtTemp5.Text)

            ' Get the sum of all the temperatures.
            Dim dblSum As Double = dblTemp1 + dblTemp2 + dblTemp3 +
                dblTemp4 + dblTemp5

            ' Calculate the average temperatures.
            Dim dblAverage As Double = dblSum / intNUM_TEMPS

            ' Display the average temperature in lblAverage.
            lblAverage.Text = dblAverage.ToString("n")
        Catch
            lblStatus.Text = "Please enter numeric values"
        End Try
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
