Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for calories in fat and 
        ' percentage that qualifies food to be low in fat.
        Const intCALORIES_IN_GRAM_OF_FAT As Integer = 9     ' 9 calories per gram of fat
        Const dblLOW_FAT_FOOD_PERCENTAGE As Double = 0.3    ' Low fat food is less than 30%

        ' Declare variables to store input from the user.
        Dim dblCaloriesInFood As Double
        Dim dblGramsOfFat As Double

        ' Get the calories and grams of fat as input from the user.
        If Double.TryParse(txtCaloriesInFood.Text, dblCaloriesInFood) And
            IsNumeric(txtCaloriesInFood.Text) And dblCaloriesInFood >= 0 Then

            If Double.TryParse(txtGramsOfFat.Text, dblGramsOfFat) And
                IsNumeric(txtGramsOfFat.Text) And dblGramsOfFat >= 0 And
                dblGramsOfFat <= dblCaloriesInFood / intCALORIES_IN_GRAM_OF_FAT Then

                ' Calculate the percentage of calories from fat.
                Dim dblCaloriesFromFat As Double =
                    dblGramsOfFat * intCALORIES_IN_GRAM_OF_FAT / dblCaloriesInFood

                ' Display the results to the user.
                lblCaloriesFromFat.Text = dblCaloriesFromFat.ToString("p")

                ' Check if the food is low in fat - less than 30%.
                If dblCaloriesFromFat < dblLOW_FAT_FOOD_PERCENTAGE Then
                    lblMessage.Text = "The food is low in fat."
                Else
                    lblMessage.Text = String.Empty
                End If

                ' Display the error message.
            Else
                lblMessage.Text = "Enter a valid number for grams of fat."
            End If

            ' Display the error message.
        Else
            lblMessage.Text = "Enter a valid number for calories in food."
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtCaloriesInFood.Clear()
        txtGramsOfFat.Clear()

        ' Set the Text in the labels to an empty string.
        lblCaloriesFromFat.Text = String.Empty
        lblMessage.Text = String.Empty

        ' Give the focus to txtCaloriesInFood.
        txtCaloriesInFood.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
