Public Class Form1

    Private Sub btnDisplayResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayResults.Click
        ' Declare named constants for the boiling points
        ' of the substances in degrees Fahrenheit.
        Const dblBOILING_POINT_ETHYL_ALCOHOL As Double = 172.0      ' Ethyl Alcohol boils at 172.0 degrees Fahrenheit.
        Const dblBOILING_POINT_MERCURY As Double = 676.0            ' Mercury boils at 676.0 degrees Fahrenheit.
        Const dblBOILING_POINT_OXYGEN As Double = -306.0            ' Oxygen  boils at -306.0 degrees Fahrenheit.
        Const dblBOILING_POINT_WATER As Double = 212.0              ' Water boils at 212.0 degrees Fahrenheit.

        ' Declare named constants for the freezing points
        ' of the substances in degrees Fahrenheit.
        Const dblFREEZING_POINT_ETHYL_ALCOHOL As Double = -173.0    ' Ethyl Alcohol freezes at -173.0 degrees Fahrenheit.
        Const dblFREEZING_POINT_MERCURY As Double = -38.0           ' Mercury freezes at -38.0 degrees Fahrenheit.
        Const dblFREEZING_POINT_OXYGEN As Double = -362.0           ' Oxygen freezes at -362.0 degrees Fahrenheit.
        Const dblFREEZING_POINT_WATER As Double = 32.0              ' Water freezes at 32.0 degrees Fahrenheit.

        ' Declare a variable to hold the temperature in degrees Fahrenheit.
        Dim dblTemperature As Double

        ' Declare variables to hold the boiling status of each substance.
        Dim blnBoilingEthylAlcohol As Boolean
        Dim blnBoilingMercury As Boolean
        Dim blnBoilingOxygen As Boolean
        Dim blnBoilingWater As Boolean

        ' Declare variables to hold the freezing status of each substance.
        Dim blnFreezingEthylAlcohol As Boolean
        Dim blnFreezingMercury As Boolean
        Dim blnFreezingOxygen As Boolean
        Dim blnFreezingWater As Boolean

        ' Get the temperature in degrees Fahrenheit as input from the user.
        If Double.TryParse(txtTemperature.Text, dblTemperature) And
            IsNumeric(txtTemperature.Text) Then

            ' Determine the status of the Ethyl Alcohol based on the temperature.
            If dblTemperature >= dblBOILING_POINT_ETHYL_ALCOHOL Then
                ' The Ethyl Alcohol is at or above the boiling point.
                blnBoilingEthylAlcohol = True
            ElseIf dblTemperature <= dblFREEZING_POINT_ETHYL_ALCOHOL Then
                ' The Ethyl Alcohol is at or below the freezing point.
                blnFreezingEthylAlcohol = True
            Else
                ' The Ethyl Alcohol is not boiling or freezing.
                blnBoilingEthylAlcohol = False
                blnFreezingEthylAlcohol = False
            End If

            ' Determine the status of the Mercury based on the temperature.
            If dblTemperature >= dblBOILING_POINT_MERCURY Then
                ' The Mercury is at or above the boiling point.
                blnBoilingMercury = True
            ElseIf dblTemperature <= dblFREEZING_POINT_MERCURY Then
                ' The Mercury is at or below the freezing point.
                blnFreezingMercury = True
            Else
                ' The Mercury is not boiling or freezing.
                blnBoilingMercury = False
                blnFreezingMercury = False
            End If

            ' Determine the status of the Oxygen based on the temperature.
            If dblTemperature >= dblBOILING_POINT_OXYGEN Then
                ' The Oxygen is at or above the boiling point.
                blnBoilingOxygen = True
            ElseIf dblTemperature <= dblFREEZING_POINT_OXYGEN Then
                ' The Oxygen is at or below the freezing point.
                blnFreezingOxygen = True
            Else
                ' The Oxygen is not boiling or freezing.
                blnBoilingOxygen = False
                blnFreezingOxygen = False
            End If

            ' Determine the status of the Water based on the temperature.
            If dblTemperature >= dblBOILING_POINT_WATER Then
                ' The Water is at or above the boiling point.
                blnBoilingWater = True
            ElseIf dblTemperature <= dblFREEZING_POINT_WATER Then
                ' The Water is at or below the freezing point.
                blnFreezingWater = True
            Else
                ' The Water is not boiling or freezing.
                blnBoilingWater = False
                blnFreezingWater = False
            End If

            ' Display the results in the calculated labels as output to the user.
            lblBoilingEthylAlcohol.Text = blnBoilingEthylAlcohol.ToString
            lblFreezingEthylAlcohol.Text = blnFreezingEthylAlcohol.ToString
            lblBoilingMercury.Text = blnBoilingMercury.ToString
            lblFreezingMercury.Text = blnFreezingMercury.ToString
            lblBoilingOxygen.Text = blnBoilingOxygen.ToString
            lblFreezingOxygen.Text = blnFreezingOxygen.ToString
            lblBoilingWater.Text = blnBoilingWater.ToString
            lblFreezingWater.Text = blnFreezingWater.ToString
        Else
            ' Display a message box to the user indicating the input for temperature was invalid.
            MessageBox.Show("Temperature - The value must be a number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtTemperature text box.
        txtTemperature.Clear()

        ' Set the Text in the calculated labels to an empty string.
        lblBoilingEthylAlcohol.Text = String.Empty
        lblBoilingMercury.Text = String.Empty
        lblBoilingOxygen.Text = String.Empty
        lblBoilingWater.Text = String.Empty
        lblFreezingEthylAlcohol.Text = String.Empty
        lblFreezingMercury.Text = String.Empty
        lblFreezingOxygen.Text = String.Empty
        lblFreezingWater.Text = String.Empty

        ' Give the focus to txtTemperature.
        txtTemperature.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
