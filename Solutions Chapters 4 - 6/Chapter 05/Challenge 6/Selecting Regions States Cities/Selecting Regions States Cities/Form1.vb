Public Class Form1

    Private Sub cboRegion_SelectedIndexChanged() Handles cboRegion.SelectedIndexChanged

        lblRegion.Text = cboRegion.SelectedItem.ToString()
        cboState.Items.Clear()
        cboState.Text = String.Empty
        cboCity.Items.Clear()
        cboCity.Text = String.Empty
        lblCity.Text = String.Empty
        lblState.Text = String.Empty

        Select Case cboRegion.SelectedItem.ToString()
            Case "NorthEast"
                cboState.Items.Add("New York")
                cboState.Items.Add("Massachusetts")
            Case "SouthEast"
                cboState.Items.Add("Georgia")
                cboState.Items.Add("Florida")
            Case "NorthWest"
                cboState.Items.Add("Washington")
                cboState.Items.Add("Oregon")
        End Select

    End Sub

    Private Sub cboState_SelectedIndexChanged() Handles cboState.SelectedIndexChanged

        lblState.Text = cboState.SelectedItem.ToString()
        cboCity.Items.Clear()
        cboCity.Text = String.Empty
        lblCity.Text = String.Empty

        Select Case cboState.SelectedItem.ToString()

            Case "New York"
                cboCity.Items.Add("New York City")
                cboCity.Items.Add("Rochester")
            Case "Massachusetts"
                cboCity.Items.Add("Boston")
                cboCity.Items.Add("Concord")

            Case "Georgia"
                cboCity.Items.Add("Atlanta")
                cboCity.Items.Add("Macon")

            Case "Florida"
                cboCity.Items.Add("Tallahassee")
                cboCity.Items.Add("Gainesville")
                cboCity.Items.Add("Miami")

            Case "Washington"
                cboCity.Items.Add("Seattle")
                cboCity.Items.Add("Olympia")

            Case "Oregon"
                cboCity.Items.Add("Portland")
 
        End Select


    End Sub

    Private Sub cboCity_SelectedIndexChanged() Handles cboCity.SelectedIndexChanged

        lblCity.Text = cboCity.SelectedItem.ToString()
    End Sub
End Class
