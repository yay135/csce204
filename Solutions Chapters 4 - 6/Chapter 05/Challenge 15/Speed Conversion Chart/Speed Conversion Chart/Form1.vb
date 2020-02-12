Public Class Form1

    Private Sub btnDisplayList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayList.Click
        ' Named constant declarations
        Const dblKPH_TO_MPH As Double = 0.6214  ' KPH to MPH conversion formula value.
        Const intINCREMENT As Integer = 5       ' Increments of 5 KPH
        Const intSTART As Integer = 60          ' Start with 60 KPH
        Const intEND As Integer = 130           ' End with 130 KPH

        ' Local variable declarations
        Dim dblMPH As Double    ' Speed in miles per hour
        Dim intKPH As Integer   ' Speed in kilometers per hour

        ' Starting with 60 KPH and ending with 130 KPH, 
        ' calculate and display the conversion from KPH to MPH, 
        ' in 5 KPH increments.
        For intKPH = intSTART To intEND Step intINCREMENT

            ' Convert KPH to MPH
            dblMPH = intKPH * dblKPH_TO_MPH

            ' Display the output in the list box.
            lstOutput.Items.Add(ControlChars.Tab &
                                intKPH.ToString("d3") & " KPH" &
                                "  .........  " &
                                dblMPH.ToString("n0") & " MPH")
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
