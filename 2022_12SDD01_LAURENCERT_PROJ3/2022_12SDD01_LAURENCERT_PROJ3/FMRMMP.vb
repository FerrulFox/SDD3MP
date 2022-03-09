Public Class FMRMMP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonFind.Click
        With OpenFileDialog1
            .Title = "Media File Browser"
            .Filter = "Media Files (*.wmv;*.avi;*.mp3)|*.wmv;*.avi;*.mp3|All Files (*.*)|*.*"
            .FileName = ""
            .CheckFileExists = True
        End With
        ' Launch the Open File dialog and play the selected media file.
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim formmenu As New FORMMENU
        formmenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class