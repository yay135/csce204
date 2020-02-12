Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim str As String = "Locations: "

        If chkBastille.Checked Then
            str &= "Bastille, "
        End If
        If chkChamps.Checked Then
            str &= "Champs-Elysees, "
        End If
        If chkLatin.Checked Then
            str &= "Latin Quartier, "
        End If
        If chkSacre.Checked Then
            str &= "Sacre-Coeur, "
        End If
        If chkMarais.Checked Then
            str &= "Marais, "
        End If
        If chkLesHalles.Checked Then
            str &= "Les Halles, "
        End If

        str &= " Type of lodging: "

        If chkBoutique.Checked Then
            str &= "Boutique, "
        End If
        If chkLargeHotel.Checked Then
            str &= "Large hotel, "
        End If
        If chkOneBed.Checked Then
            str &= "One bed apt, "
        End If
        If chkTwoBed.Checked Then
            str &= "Two bed apt, "
        End If
        If chkStudio.Checked Then
            str &= "Studio"
        End If

        lblSelections.Text = str

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
