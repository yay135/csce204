Public Class Form1
    Private Sub btnAddWorkshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWorkshop.Click
        ' Named constants for workshop index values.
        Const intWORKSHOP_A As Integer = 0  ' Index for Handling Stress workshop.
        Const intWORKSHOP_B As Integer = 1  ' Index for Time Management workshop.
        Const intWORKSHOP_C As Integer = 2  ' Index for Supervision Skills workshop.
        Const intWORKSHOP_D As Integer = 3  ' Index for Negotiation workshop.
        Const intWORKSHOP_E As Integer = 4  ' Index for How to Interview workshop.

        ' Named constants for workshop number of days.
        Const intDAYS_A As Integer = 3      ' Number of days for Handling Stress workshop.
        Const intDAYS_B As Integer = 3      ' Number of days for Time Management workshop.
        Const intDAYS_C As Integer = 3      ' Number of days for Supervision workshop.
        Const intDAYS_D As Integer = 5      ' Number of days for Negotiation workshop.
        Const intDAYS_E As Integer = 1      ' Number of days for How to Interview workshop.

        ' Named constants for workshop registration fees.
        Const dblFEE_A As Double = 595.0    ' Registration fee for Handling Stress workshop.
        Const dblFEE_B As Double = 695.0    ' Registration fee for Time Management workshop.
        Const dblFEE_C As Double = 995.0    ' Registration fee for Supervision Skills workshop.
        Const dblFEE_D As Double = 1295.0   ' Registration fee for Negotation workshop.
        Const dblFEE_E As Double = 395.0    ' Registration fee for How to Interview workshop.

        ' Named constants for location index values.
        Const intLOCATION_1 As Integer = 0  ' Index for Austin location.
        Const intLOCATION_2 As Integer = 1  ' Index for Chicago location.
        Const intLOCATION_3 As Integer = 2  ' Index for Dallas location.
        Const intLOCATION_4 As Integer = 3  ' Index for Orlando location.
        Const intLOCATION_5 As Integer = 4  ' Index for Phoenix locaton.
        Const intLOCATION_6 As Integer = 5  ' Index for Raleigh location.

        ' Named constants for location fees per day.
        Const dblFEE_1 As Double = 95.0     ' Lodging fee per day for Austin location.
        Const dblFEE_2 As Double = 125.0    ' Lodging fee per day for Chicago location.
        Const dblFEE_3 As Double = 110.0    ' Lodging fee per day for Dallas location.
        Const dblFEE_4 As Double = 100.0    ' Lodging fee per day for Orlando location.
        Const dblFEE_5 As Double = 92.0     ' Lodging fee per day for Phoenix locaton.
        Const dblFEE_6 As Double = 90.0     ' Lodging fee per day for Raleigh location.

        ' Local variable declarations
        Dim dblRegistrationFee As Double = 0.0  ' To hold the workshop registration fee.
        Dim intNumberOfDays As Integer = 0      ' To hold the number of days.
        Dim dblLogdgingFee As Double = 0.0      ' To hold the location lodging fee.
        Dim dblCost As Double = 0.0             ' To hold the workshop cost.

        ' Set the registration fee and number of days based on 
        ' the selected index of the lstWorkshop list box.
        Select Case lstWorkshop.SelectedIndex
            Case intWORKSHOP_A
                intNumberOfDays = intDAYS_A
                dblRegistrationFee = dblFEE_A
            Case intWORKSHOP_B
                intNumberOfDays = intDAYS_B
                dblRegistrationFee = dblFEE_B
            Case intWORKSHOP_C
                intNumberOfDays = intDAYS_C
                dblRegistrationFee = dblFEE_C
            Case intWORKSHOP_D
                intNumberOfDays = intDAYS_D
                dblRegistrationFee = dblFEE_D
            Case intWORKSHOP_E
                intNumberOfDays = intDAYS_E
                dblRegistrationFee = dblFEE_E
            Case Else
                ' Display a message to select a workshop.
                MessageBox.Show("Select a Workshop", "Input Needed")
        End Select

        ' Set the logding fee per day based on 
        ' the selected index of the lstLocation list box.
        Select Case lstLocation.SelectedIndex
            Case intLOCATION_1
                dblLogdgingFee = dblFEE_1
            Case intLOCATION_2
                dblLogdgingFee = dblFEE_2
            Case intLOCATION_3
                dblLogdgingFee = dblFEE_3
            Case intLOCATION_4
                dblLogdgingFee = dblFEE_4
            Case intLOCATION_5
                dblLogdgingFee = dblFEE_5
            Case intLOCATION_6
                dblLogdgingFee = dblFEE_6
            Case Else
                ' Display a message to select a location.
                MessageBox.Show("Select a Location", "Input Needed")
        End Select

        ' Calculate the workshop cost.
        dblCost = dblRegistrationFee + dblLogdgingFee * intNumberOfDays

        ' Only add costs that are greater than zero.
        If dblCost > 0.0 Then
            lstCosts.Items.Add(dblCost.ToString("c"))
        End If

    End Sub

    Private Sub btnCalculateTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateTotal.Click
        Dim intItemIndex As Integer         ' To hold the item index.
        Dim dblTotalCost As Double = 0.0    ' To hold the total cost.

        ' Make sure the lstCosts list box is not empty.
        If lstCosts.Items.Count > 0 Then
            ' Step through all the items in the lstCosts list box.
            For intItemIndex = 0 To lstCosts.Items.Count - 1
                ' Keep a running total for the cost of each workshop.
                dblTotalCost += CDec(lstCosts.Items(intItemIndex))
            Next
        Else
            ' Display a message to add a workshop.
            MessageBox.Show("Add a Workshop.", "Input Needed")
        End If
        ' Only dislay the total cost if the value is greater than zero.
        If dblTotalCost > 0.0 Then
            lblTotalCost.Text = dblTotalCost.ToString("c")
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Deselect the items from lstWorkshop and lstLocation list boxes.
        lstWorkshop.ClearSelected()
        lstLocation.ClearSelected()

        ' Clear the items from the lstCosts list box.
        lstCosts.Items.Clear()

        ' Set the Text in the lblTotalCost label to an empty string.
        lblTotalCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
