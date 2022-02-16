Public Class Multiway_Selection
    Private Sub Buttongrade_Click(sender As Object, e As EventArgs) Handles ButtonGrade.Click
        Dim grademark As String
        grademark = TextBoxGrade.Text
        Select Case grademark
            Case "A"
                Labelgrade.Text = "high distinction"
            Case "B"
                Labelgrade.Text = "distinction"
            Case "C"
                Labelgrade.Text = "credit"
            Case "D"
                Labelgrade.Text = "Pass"
            Case "Else"
                Labelgrade.Text = "Fail"
            Case "a"
                Labelgrade.Text = "high distinction"
            Case "b"
                Labelgrade.Text = "distinction"
            Case "c"
                Labelgrade.Text = "credit"
            Case "d"
                Labelgrade.Text = "Pass"
            Case "else"
                Labelgrade.Text = "Fail"
        End Select
    End Sub

    Private Sub ButtonNumber_Click(sender As Object, e As EventArgs) Handles ButtonNumber.Click
        Dim mark As Single
        mark = Val(TextBoxNumber.Text)
        Select Case mark
            Case Is >= 85
                LabelNumber.Text = "Excellent"
            Case Is >= 70
                LabelNumber.Text = "Good"
            Case Is >= 60
                LabelNumber.Text = "above average"
            Case Is >= 50
                LabelNumber.Text = "Average"
            Case Else
                LabelNumber.Text = "needs to work harder"
        End Select
    End Sub
End Class