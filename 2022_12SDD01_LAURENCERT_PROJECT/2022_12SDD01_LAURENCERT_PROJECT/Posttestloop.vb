Public Class Posttestloop
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_QUIT.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTN_RTRN.Click
        Me.Visible = False
        FRM_MAINMENU.Show()
    End Sub

    Private Sub BTN_INPTPW_Click(sender As Object, e As EventArgs) Handles BTN_INPTPW.Click
        Dim strPassWord As String
        Dim strUserTry As String
        Dim intNumTries As Integer
        strPassWord = "CoyoteBand2021"
        intNumTries = 0
        Do
            strUserTry = InputBox("Enter password: ")
            intNumTries = intNumTries + 1
            If intNumTries = 3 Then MsgBox("that is the wrong password!")
            If intNumTries = 3 = True Then Posttestmessup.Show()
        Loop Until strUserTry = strPassWord Or intNumTries = 3
    End Sub
End Class