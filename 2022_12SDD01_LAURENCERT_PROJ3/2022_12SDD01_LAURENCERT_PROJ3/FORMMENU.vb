Public Class FORMMENU
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Dim SRTFLDER As New FRMSRTS()
        SRTFLDER.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Form2 As New FRMSTRUCT
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim FRMDEBUG As New FRMDEBUG
        FRMDEBUG.Show()
    End Sub

    Private Sub BRKPNTSBTN_Click(sender As Object, e As EventArgs) Handles BRKPNTSBTN.Click
        Me.Hide()
        Dim FRMBRKPNTS As New FRMBRKPNTS
        FRMBRKPNTS.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim FRMTRYNCTCHERRROR As New FRMTRYNCTCHERROR
        FRMTRYNCTCHERRROR.Show()
    End Sub

    Private Sub BTNMMP_Click(sender As Object, e As EventArgs) Handles BTNMMP.Click
        Me.Hide()
        Dim FMRMMP As New FMRMMP
        FMRMMP.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim FRMDATGRI As New FRMDATGRI
        FRMDATGRI.Show()
    End Sub
End Class