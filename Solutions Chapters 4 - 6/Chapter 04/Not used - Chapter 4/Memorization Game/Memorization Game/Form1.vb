Public Class Form1

    'This would be much easier with an array of Button objects

    Dim count As Integer = 0
    Dim buttonA As Button
    Dim buttonB As Button

    Private Sub btnCheck_Click() Handles btnCheck.Click
        count = 0
        If buttonA.Tag <> buttonB.Tag Then
            buttonA.Text = String.Empty
            buttonB.Text = String.Empty
        End If
    End Sub

    Private Sub Button1_Click() Handles Button1.Click
        Button1.Text = Button1.Tag
        If count = 0 Then
            buttonA = Button1
            count += 1
        Else
            buttonB = Button1
        End If
    End Sub

    Private Sub Button2_Click() Handles Button2.Click
        Button2.Text = Button2.Tag
        If count = 0 Then
            buttonA = Button2
            count += 1
        Else
            buttonB = Button2
        End If
    End Sub

    Private Sub Button3_Click() Handles Button3.Click
        Button3.Text = Button3.Tag
        If count = 0 Then
            buttonA = Button3
            count += 1
        Else
            buttonB = Button3
        End If
    End Sub

    Private Sub Button4_Click() Handles Button4.Click
        Button4.Text = Button4.Tag
        If count = 0 Then
            buttonA = Button4
            count += 1
        Else
            buttonB = Button4
        End If
    End Sub

    Private Sub Button5_Click() Handles Button5.Click
        Button5.Text = Button5.Tag
        If count = 0 Then
            buttonA = Button5
            count += 1
        Else
            buttonB = Button5
        End If
    End Sub

    Private Sub Button6_Click() Handles Button6.Click
        Button6.Text = Button6.Tag
        If count = 0 Then
            buttonA = Button6
            count += 1
        Else
            buttonB = Button6
        End If
    End Sub

    Private Sub Button7_Click() Handles Button7.Click
        Button7.Text = Button7.Tag
        If count = 0 Then
            buttonA = Button7
            count += 1
        Else
            buttonB = Button7
        End If
    End Sub

    Private Sub Button8_Click() Handles Button8.Click
        Button8.Text = Button8.Tag
        If count = 0 Then
            buttonA = Button8
            count += 1
        Else
            buttonB = Button8
        End If
    End Sub


End Class
