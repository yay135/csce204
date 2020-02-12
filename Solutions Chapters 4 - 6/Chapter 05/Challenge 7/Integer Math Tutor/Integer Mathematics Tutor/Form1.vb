Public Class Form1

    Const MAXRANGE As Integer = 100
    Const MINVAL As Integer = 20
    Dim answer As Integer = 0

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim userAnswer As Integer = 0
        If Integer.TryParse(txtAnswer.Text, userAnswer) Then
            If answer = userAnswer Then
                lblFeedback.ForeColor = Color.Green
                lblFeedback.Text = "Correct answer!"
            Else
                lblFeedback.ForeColor = Color.Red
                lblFeedback.Text = "Sorry, but the answer should have been " & answer.ToString
            End If
        Else
            lblFeedback.ForeColor = Color.Red
            lblFeedback.Text = "Please enter a valid integer."
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim rand As New Random
        txtAnswer.Clear()
        lblFeedback.Text = ""
        Dim op1 As Integer = rand.Next(MAXRANGE) + MINVAL
        Dim op2 As Integer = rand.Next(MAXRANGE) + MINVAL

        If radAddition.Checked Then
            lblProblem.Text = op1.ToString & " + " & op2.ToString & " = "
            answer = op1 + op2
        ElseIf radSubtraction.Checked Then
            lblProblem.Text = op1.ToString & " - " & op2.ToString & " = "
            answer = op1 - op2
        ElseIf radMultiplication.Checked Then
            ' adjust the sizes
            op1 = op1 \ 2
            op2 = op2 \ 2
            lblProblem.Text = op1.ToString & " * " & op2.ToString & " = "
            answer = op1 * op2
        ElseIf radDivision.Checked Then
            ' adjust so the quotient is always even
            Do
                op2 = rand.Next(50) + 1
            Loop Until op1 Mod op2 = 0 And op2 < op1
            lblProblem.Text = op1.ToString & " / " & op2.ToString & " = "
            answer = op1 \ op2
        End If
        Label1.Text = "Please type in your answer to the following math problem. Integer answers only:"
    End Sub
End Class
