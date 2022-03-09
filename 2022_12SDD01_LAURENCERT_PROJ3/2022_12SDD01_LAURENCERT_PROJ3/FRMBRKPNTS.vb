Public Class FRMBRKPNTS
    Private Sub FRMBRKPNTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j, k As Integer
        Dim pass As Integer = 0
        For i = 1 To 3
            For j = 1 To 3
                For k = 1 To 3
                    pass = pass + 1 'Watching this using the watch algorithm gives technically infinite response-- a matter of my coding or the reference?
                Next k
            Next j
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim formmenu As New FORMMENU
        formmenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class