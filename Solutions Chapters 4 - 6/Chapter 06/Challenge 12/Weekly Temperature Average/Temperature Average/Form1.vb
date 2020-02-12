Public Class Form1

    Private dblTemp1 As Double
    Private dblTemp2 As Double
    Private dblTemp3 As Double
    Private dblTemp4 As Double
    Private dblTemp5 As Double
    Const intNUM_TEMPS As Integer = 5

    ''' <summary>
    ''' Verify that the temperature is numeric, and if it falls within a given range.
    ''' </summary>
    ''' <param name="txtBox">TextBox control used for input</param>
    ''' <param name="dblTemp">variable to hold the temperature</param>
    ''' <param name="id">temperature ID number (1-4)</param>
    ''' <returns>True if the temperature is valid; False otherwise</returns>
    Function CheckTemperature(txtBox As TextBox, dblTemp As Double, id As String) As Boolean
        If Not Double.TryParse(txtBox.Text, dblTemp) Then
            lblStatus.Text = "Temperature #" + id + " must be numeric"
            txtBox.Focus()
            txtBox.SelectAll()
            Return False
        End If

        If dblTemp < -50 Or dblTemp > 130 Then
            lblStatus.Text = "Temperature #" + id + " must be between -50 and +130"
            txtTemp1.Focus()
            txtTemp1.SelectAll()
            Return False
        End If
        Return True
    End Function

    Sub CalculateResults()
        ' Get the sum of all the temperatures.
        Dim dblSum As Double = dblTemp1 + dblTemp2 + dblTemp3 +
            dblTemp4 + dblTemp5

        ' Calculate the average temperatures.
        Dim dblAverage As Double = dblSum / intNUM_TEMPS

        ' Display the average temperature in lblAverage.
        lblAverage.Text = dblAverage.ToString("n")
    End Sub

    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        lblStatus.Text = String.Empty

        If Not (CheckTemperature(txtTemp1, dblTemp1, "1") And
            CheckTemperature(txtTemp2, dblTemp2, "2") And
            CheckTemperature(txtTemp3, dblTemp3, "3") And
            CheckTemperature(txtTemp4, dblTemp4, "4") And
            CheckTemperature(txtTemp5, dblTemp5, "5")) Then
            Exit Sub
        End If

        CalculateResults()
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
