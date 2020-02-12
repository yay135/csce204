Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblLanguageCost As Double = 0.0
        Dim dblSectionCost As Double = 0.0
        Dim strLanguage As String = ""
        Dim strSections As String = ""
 
        If radArabic.Checked Then
            dblLanguageCost = 5
            strLanguage = radArabic.Text
        ElseIf radChinese.Checked Then
            dblLanguageCost = 5
            strLanguage = radChinese.Text
        ElseIf radEnglish.Checked Then
            dblLanguageCost = 3
            strLanguage = radEnglish.Text
        ElseIf radFrench.Checked Then
            dblLanguageCost = 4
            strLanguage = radFrench.Text
        ElseIf radGerman.Checked Then
            dblLanguageCost = 6
            strLanguage = radGerman.Text
        End If

        If chkAncientEurope.Checked Then
            dblSectionCost += 2
            strSections &= chkAncientEurope.Text + ", "
        End If

        If chkChina.Checked Then
            dblSectionCost += 2
            strSections &= chkChina.Text + ", "
        End If

        If chkEgypt.Checked Then
            dblSectionCost += 4
            strSections &= chkEgypt.Text + ", "
        End If

        If chkMedievalEurope.Checked Then
            dblSectionCost += 2
            strSections &= chkMedievalEurope.Text + ", "
        End If

        If chkMeso.Checked Then
            dblSectionCost += 3
            strSections &= chkMeso.Text + ", "
        End If

        MessageBox.Show("You have selected the following museum sections to be guided in the " &
                        strLanguage & " language:" & vbCrLf & vbCrLf &
                        strSections & vbCrLf & vbCrLf &
                        "The total tour cost is " & (dblLanguageCost + dblSectionCost).ToString("c"))

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
