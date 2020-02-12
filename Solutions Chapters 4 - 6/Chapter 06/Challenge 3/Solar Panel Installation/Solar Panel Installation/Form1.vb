Public Class Form1

    Const dblChargePerPanel As Double = 300
    Const dblBaseCharge As Double = 2000
    Const intBaseNumberOfPanels As Integer = 2
    Const dblExpressSurchargeRate = 0.05
    Private intNumPanels As Integer
    Private dblDepositAmount As Double

    Function ValidateInputs() As Boolean
        If txtFirstName.Text.Length = 0 Or
            txtLastName.Text.Length = 0 Or
            txtPhone.Text.Length = 0 Then
            MessageBox.Show("Name and phone fields cannot be blank.")
            Return False
        ElseIf Not Double.TryParse(txtDeposit.Text, dblDepositAmount) Then
            MessageBox.Show("Deposit amount must be a number.")
            Return False
        ElseIf dblDepositAmount < 1 Then
            MessageBox.Show("Deposit amount must be greater than zero.")
            Return False
        ElseIf Not Integer.TryParse(txtNumPanels.Text, intNumPanels) Then
            MessageBox.Show("Number of panels must be an integer.")
            Return False
        ElseIf intNumPanels < 1 Or intNumPanels > 1000 Then
            MessageBox.Show("Number of panels must be between 1 and 1000.")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnCalculate_Click() Handles btnCalculate.Click

        If Not ValidateInputs() Then Exit Sub

        Dim dblExtraPanelCost As Double = 0
        Dim dblTotalCost As Double = 0
        Dim dblBalanceDue As Double = 0

        If intNumPanels > intBaseNumberOfPanels Then
            ' cost of extra panels
            dblExtraPanelCost = (intNumPanels - intBaseNumberOfPanels) *
                dblChargePerPanel
        End If

        ' total cost of installation, including express service
        dblTotalCost = dblBaseCharge + dblExtraPanelCost
        If chkExpress.Checked Then
            dblTotalCost += (dblTotalCost * dblExpressSurchargeRate)
        End If

        ' balance due
        dblBalanceDue = dblTotalCost - dblDepositAmount

        ' display calculated fields
        lblDeposit.Text = dblDepositAmount.ToString("n")
        lblAdditionalPanelCost.Text = dblExtraPanelCost.ToString("n")
        lblTotalCost.Text = dblTotalCost.ToString("n")
        lblBalanceDue.Text = dblBalanceDue.ToString("n")

        gbxCharges.Visible = True
        pnlChargesBorder.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        gbxCharges.Visible = False
        pnlChargesBorder.Visible = False
        txtDeposit.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtNumPanels.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
