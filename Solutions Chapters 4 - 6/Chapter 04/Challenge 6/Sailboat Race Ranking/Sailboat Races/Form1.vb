Public Class Form1

    Private Sub btnCalculate_Click() Handles btnCalculate.Click

        Dim intSumB1 As Integer
        Dim intSumB2 As Integer
        Dim intSumB3 As Integer

        lblStatus.Text = ""
        Try
            Dim b1r1 As Integer = CInt(txtB1R1.Text)
            Dim b1r2 As Integer = CInt(txtB1R2.Text)
            Dim b1r3 As Integer = CInt(txtB1R3.Text)
            Dim b1r4 As Integer = CInt(txtB1R4.Text)

            Dim b2r1 As Integer = CInt(txtB2R1.Text)
            Dim b2r2 As Integer = CInt(txtB2R2.Text)
            Dim b2r3 As Integer = CInt(txtB2R3.Text)
            Dim b2r4 As Integer = CInt(txtB2R4.Text)
 
            Dim b3r1 As Integer = CInt(txtB3R1.Text)
            Dim b3r2 As Integer = CInt(txtB3R2.Text)
            Dim b3r3 As Integer = CInt(txtB3R3.Text)
            Dim b3r4 As Integer = CInt(txtB3R4.Text)

            ' Verify that the sum of each column is 6
            If b1r1 + b2r1 + b3r1 <> 6 Then
                lblStatus.Text = "Enter 1, 2, and 3 only for Race 1"
                Exit Sub
            End If

            If b1r2 + b2r2 + b3r2 <> 6 Then
                lblStatus.Text = "Enter 1, 2, and 3 only for Race 2"
                Exit Sub
            End If

            If b1r3 + b2r3 + b3r3 <> 6 Then
                lblStatus.Text = "Enter 1, 2, and 3 only for Race 3"
                Exit Sub
            End If

            ' Total the race points
            intSumB1 = b1r1 + b1r2 + b1r3 + b1r4
            intSumB2 = b2r1 + b2r2 + b2r3 + b2r4
            intSumB3 = b3r1 + b3r2 + b3r3 + b3r4

            ' Determine the overall rankings of the boats.
            ' It is possible to reduce the number of lines in the 
            ' following nested-IF statement, but doing so might make
            ' it more difficult to understand.

            If intSumB1 < intSumB2 Then     ' 1 < 2
                If intSumB2 < intSumB3 Then ' 1 < 2 < 3
                    lblRank_1.Text = "1"
                    lblRank_2.Text = "2"
                    lblRank_3.Text = "3"
                Else                        ' 1 < 3 < 2
                    lblRank_1.Text = "1"
                    lblRank_2.Text = "3"
                    lblRank_3.Text = "2"
                End If
                If intSumB3 < intSumB1 Then     ' 3 < 1 < 2
                    lblRank_1.Text = "3"
                    lblRank_2.Text = "1"
                    lblRank_3.Text = "2"
                End If
            ElseIf intSumB2 < intSumB1 Then     ' 2 < 1 
                If intSumB1 < intSumB3 Then     ' 2 < 1 < 3
                    lblRank_1.Text = "2"
                    lblRank_2.Text = "1"
                    lblRank_3.Text = "3"
                Else                            ' 2 < 3 < 1
                    lblRank_1.Text = "2"
                    lblRank_2.Text = "3"
                    lblRank_3.Text = "1"
                End If
                If intSumB3 < intSumB2 Then     ' 3 < 2 < 1
                    lblRank_1.Text = "3"
                    lblRank_2.Text = "2"
                    lblRank_3.Text = "1"
                End If
            End If

            ' If tie scores found, turn background color of ranks red and display 
            ' "TIE" on status strip
            If intSumB1 = intSumB2 Or intSumB1 = intSumB3 Or intSumB2 = intSumB3 Then
                lblRank_1.BackColor = Color.Red
                lblRank_2.BackColor = Color.Red
                lblRank_3.BackColor = Color.Red
                lblStatus.Text = "TIE"
            End If

            lblTotal_1.Text = intSumB1.ToString()
            lblTotal_2.Text = intSumB2.ToString()
            lblTotal_3.Text = intSumB3.ToString()

        Catch ex As Exception
            lblStatus.Text = "All entries must be integers"
            Exit Sub
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtB1R1.Clear()
        txtB1R2.Clear()
        txtB1R3.Clear()
        txtB1R4.Clear()

        txtB2R1.Clear()
        txtB2R2.Clear()
        txtB2R3.Clear()
        txtB2R4.Clear()

        txtB3R1.Clear()
        txtB3R2.Clear()
        txtB3R3.Clear()
        txtB3R4.Clear()

        lblRank_1.Text = String.Empty
        lblRank_2.Text = String.Empty
        lblRank_3.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
