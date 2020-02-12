Public Class Form1

    Dim intTotalRoomsOccupied As Integer = 0    ' To hold the total number of rooms occupied on all floors.
    Const intROOMS As Integer = 30                          ' Number of rooms per floor.
    Const intFLOORS As Integer = 8                          ' Number of floors.
    Const intTOTAL_ROOMS As Integer = intFLOORS * intROOMS  ' Total number of rooms on all floors.
    Dim dblOverallOccupancyRate As Double = 0.0 ' To hold the overall occupancy rate for all rooms on all floors.

    Private Sub btnRestart_Click() Handles btnClear.Click
        ' Clear the list box items.
        lstFloorOccupancyData.Items.Clear()

        ' Set the Text of the labels to an empty string.
        lblTotalRoomsOccupied.Text = String.Empty
        lblOverallOccupancyRate.Text = String.Empty
        cboFloor.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
 
    Private Sub btnSave_Click() Handles btnSave.Click
        Dim intRoomsOccupied As Integer
        Dim dblOccupancyRate As Double

        If Integer.TryParse(txtOccupied.Text, intRoomsOccupied) Then
            intTotalRoomsOccupied += intRoomsOccupied
            dblOccupancyRate = intRoomsOccupied / intROOMS

            lstFloorOccupancyData.Items.Add("Floor: " & cboFloor.Text &
                                " Rooms Occupied: " & intRoomsOccupied.ToString &
                                " Occupancy Rate: " & dblOccupancyRate.ToString("p"))

            ' Calculate the overall occupancy rate for all floors.
            dblOverallOccupancyRate = intTotalRoomsOccupied / intTOTAL_ROOMS

            ' Display the results to the user.
            lblTotalRoomsOccupied.Text = intTotalRoomsOccupied.ToString()
            lblOverallOccupancyRate.Text = dblOverallOccupancyRate.ToString("p")
            If cboFloor.SelectedIndex < intFLOORS - 1 Then
                cboFloor.SelectedIndex += 1
            End If
             txtOccupied.Clear()
        Else
            MessageBox.Show("Please enter an integer value")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFloor.SelectedIndex = 0
    End Sub
End Class
