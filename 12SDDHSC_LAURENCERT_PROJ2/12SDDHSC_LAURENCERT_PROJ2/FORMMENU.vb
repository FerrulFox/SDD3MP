Public Class FORMMENU
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRdWrte.Click
        Me.Visible = False
        ReadWritingFiles.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSLOF.Click
        Me.Hide()
        StreamText.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnFileTextbox.Click
        Me.Hide()
        FormFilesTextbox.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class
