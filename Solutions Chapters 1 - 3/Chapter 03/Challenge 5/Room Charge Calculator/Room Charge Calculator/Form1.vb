Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get today’s date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal           ' Room charges total
        Dim decAddCharges As Decimal            ' Additional charges
        Dim decSubtotal As Decimal              ' Subtotal
        Dim decTax As Decimal                   ' Tax
        Dim decTotal As Decimal                 ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D    ' Tax rate

        ' Programming Challenge: provide a unique error message for each field.
        Dim intNights As Integer
        Dim decNightlyCharge As Decimal

        Try
            intNights = CInt(txtNights.Text)
        Catch
            MessageBox.Show("Number of nights must be an integer")
        End Try

        Try
            decNightlyCharge = CDec(txtNightlyCharge.Text)
        Catch
            MessageBox.Show("Nightly charge must be numeric")
        End Try

        ' Calculate and display the room charges.
        decRoomCharges = intNights * decNightlyCharge
        lblRoomCharges.Text = decRoomCharges.ToString("c")

        Dim decRoomService As Decimal
        Dim decTelephone As Decimal
        Dim decMisc As Decimal

        Try
            decRoomService = CDec(txtRoomService.Text)
        Catch
            MessageBox.Show("Room service charge must be numeric")
        End Try

        Try
            decTelephone = CDec(txtTelephone.Text)
        Catch
            MessageBox.Show("Telephone charge must be numeric")
        End Try

        Try
            decMisc = CDec(txtMisc.Text)
        Catch
            MessageBox.Show("Miscellaneous charge must be numeric")
        End Try

        ' Calculate and display the additional charges.
        decAddCharges = decRoomService + decTelephone + decMisc
        lblAddCharges.Text = decAddCharges.ToString("c")

        ' Calculate and display the subtotal.
        decSubtotal = decRoomCharges + decAddCharges
        lblSubtotal.Text = decSubtotal.ToString("c")

        ' Calculate and display the tax.
        decTax = decSubtotal * decTAX_RATE
        lblTax.Text = decTax.ToString("c")

        ' Calculate and display the total charges.
        decTotal = decSubtotal + decTax
        lblTotal.Text = decTotal.ToString("c")

        ' Change the colors for the total charges.
        lblTotal.BackColor = Color.Blue
        lblTotal.ForeColor = Color.White
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")

        ' Reset the lblTotal control's colors.
        lblTotal.BackColor = SystemColors.Control
        lblTotal.ForeColor = SystemColors.ControlText

        ' Reset the focus to the first field.
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
