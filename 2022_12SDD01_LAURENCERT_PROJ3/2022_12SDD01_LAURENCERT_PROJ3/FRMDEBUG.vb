Public Class FRMDEBUG
    Function square(ByVal num As Integer)
        num = num * num
        Return num
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)  'i can, within reason, combine step-over and step into to read the logic progress. However, the variable insight is completely unavailable. Oh well!
        Dim i As Integer
        Dim pass As Integer = 0
        Dim base As Integer = 2
        For i = 1 To 2
            pass = pass + 1
            base = square(base)
        Next
    End Sub

    Private Sub FRMDEBUG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formmenu As New FORMMENU
        formmenu.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class