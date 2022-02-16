Public Class FRM_MAINMENU
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Pretestsentinel.Show()
    End Sub

    Private Sub BTN_PTLOOP_Click(sender As Object, e As EventArgs) Handles BTN_PTLOOP.Click
        Me.Visible = False
        Posttestloop.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        CountedLoo.Show()
    End Sub

    Private Sub BTN_MULWAYLOOP_Click(sender As Object, e As EventArgs) Handles BTN_MULWAYLOOP.Click
        Me.Visible = False
        Multiway_Selection.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        twodarrays.Show()
    End Sub
End Class
