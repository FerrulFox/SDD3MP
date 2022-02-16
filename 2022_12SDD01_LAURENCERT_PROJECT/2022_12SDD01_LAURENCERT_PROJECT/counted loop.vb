Public Class CountedLoo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ingfactorial As Long 'possible more than 32767
        Dim intinputnbr As Integer
        Dim intloopctr As Integer

        intinputnbr = Val(InputBox("Enter A Number", "For/Next Loop"))
        Ingfactorial = 1

        For intloopctr = 1 To intinputnbr
            Ingfactorial = Ingfactorial * intloopctr
        Next
        lblfactorial.Text = Str(intinputnbr) & "!=" & Str(Ingfactorial)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        FRM_MAINMENU.Show()
    End Sub
End Class