Public Class Form1

    Dim strShipSize As String
    Dim strRegion As String
    Dim strAmenities As String
    Dim strDateRange As String
    Dim strNumDays As String

    Function ValidateInput() As Boolean
        Dim dt1 As Date
        Dim dt2 As Date
        Dim minDays As Integer
        Dim maxDays As Integer
        If Not DateTime.TryParse(txtDate1.Text, dt1) Then
            lblStatus.Text = "Starting date is not valid"
            Return False
        End If
        If Not DateTime.TryParse(txtDate2.Text, dt2) Then
            lblStatus.Text = "Ending date is not valid"
            Return False
        End If
        If Not (Integer.TryParse(txtMinDays.Text, minDays) Or
            Integer.TryParse(txtMaxDays.Text, maxDays)) Then
            lblStatus.Text = "Min days and max days must be integers"
            Return False
        Else
            If minDays > maxDays Then
                lblStatus.Text = "Min days must be <= Max days"
                Return False
            End If
        End If
        Return True
    End Function


    Private Sub btnShowSummary_Click(sender As Object, e As EventArgs) Handles btnShowSummary.Click

        If Not ValidateInput() Then Exit Sub

        strShipSize = "Ship size = "

        If radSmall.Checked Then
            strShipSize &= "small"
        ElseIf radMedium.Checked Then
            strShipSize &= "medium"
        ElseIf radLarge.Checked Then
            strShipSize &= "large"
        End If

        strRegion = "Region = "
        If radAlaska.Checked Then
            strRegion &= "Alaska"
        ElseIf radBaltic.Checked Then
            strRegion &= "Baltic"
        ElseIf radCarib.Checked Then
            strRegion &= "Carribean"
        ElseIf radMed.Checked Then
            strRegion &= "Mediterranean"
        End If

        strAmenities = "Amenities = "
        If chkArt.Checked Then
            strAmenities &= "Art, "
        End If

        If chkBalcony.Checked Then
            strAmenities &= "Balcony, "
        End If

        If chkBroad.Checked Then
            strAmenities &= "Broadway shows, "
        End If

        If chkExcur.Checked Then
            strAmenities &= "Excursions, "
        End If

        If chkFreeChoice.Checked Then
            strAmenities &= "Free-choice dining,"
        End If

        If chkInternet.Checked Then
            strAmenities &= "Free Internet,"
        End If

        If chkWine.Checked Then
            strAmenities &= "Wine tasting,"
        End If

        strDateRange = "Date range = " & txtDate1.Text & " to " &
            txtDate2.Text

        strNumDays = "Min/Max days = " & txtMinDays.Text & "/" & txtMaxDays.Text
        If chkDatesFlexible.Checked Then
            strNumDays &= " (dates are flexible)"
        End If

        MessageBox.Show(strShipSize & vbCrLf & strRegion & vbCrLf & strAmenities & vbCrLf &
                        strDateRange & vbCrLf & strNumDays, "Summary")

    End Sub

    Private Sub btnClose_Click() Handles btnCloseWindow.Click
        Me.Close()
    End Sub
End Class
