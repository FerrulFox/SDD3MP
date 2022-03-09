Public Class FRMTRYNCTCHERROR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num1 As Integer = Val(TextBox1.Text)
            Dim num2 As Integer = Val(TextBox2.Text)
            ResultLabel.Text = num1 + num2
        Catch ex As OverflowException
            MsgBox("Only numbers up to 2 Billion are allowed")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim FORMMENU As New FORMMENU
        FORMMENU.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class