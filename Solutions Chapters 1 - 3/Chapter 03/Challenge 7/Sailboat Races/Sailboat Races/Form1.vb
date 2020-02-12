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

            intSumB1 = b1r1 + b1r2 + b1r3 + b1r4
            intSumB2 = b2r1 + b2r2 + b2r3 + b2r4
            intSumB3 = b3r1 + b3r2 + b3r3 + b3r4
        Catch ex As Exception
            lblStatus.Text = "All entries must be integers"
            Exit Sub
        End Try

        lblTotal_1.Text = intSumB1.ToString()
        lblTotal_2.Text = intSumB2.ToString()
        lblTotal_3.Text = intSumB3.ToString()
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

        lblTotal_1.Text = String.Empty
        lblTotal_2.Text = String.Empty
        lblTotal_3.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
