Public Class Posttestmessup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_RTNTOFRM.Click
        Me.Visible = False
        Posttestloop.Show()
    End Sub

    Private Sub BTN_HOME_Click(sender As Object, e As EventArgs) Handles BTN_HOME.Click
        Me.Visible = False
        FRM_MAINMENU.Show()
    End Sub

    Private Sub BTN_MSUP_EXT_Click(sender As Object, e As EventArgs) Handles BTN_MSUP_EXT.Click
        Application.Exit()
    End Sub
End Class