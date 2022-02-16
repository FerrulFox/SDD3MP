Public Class twodarrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cdrack(0 To 1, 0 To 3) As String
        Dim rack As Integer
        Dim band As Integer
        cdrack(0, 0) = "1:rubber soul"
        cdrack(0, 1) = "2:revolver"
        cdrack(0, 2) = "3:the white album"
        cdrack(0, 3) = "4:let it be"
        cdrack(1, 0) = "5:sticky fingers"
        cdrack(1, 1) = "6:beggars banquet"
        cdrack(1, 2) = "7:let it bleed"
        cdrack(1, 3) = "8:tattoo you"

        For band = 0 To 1
            For rack = 0 To 3
                TextBoxOutput.Text = TextBoxOutput.Text & vbNewLine & cdrack(band, rack)
            Next
        Next

    End Sub
End Class