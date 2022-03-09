Public Class StreamText
    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        Dim txt As String
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim stream As New System.IO.FileStream(OpenFileDialog1.FileName, System.IO.FileMode.Open)
            Dim reader As New System.IO.StreamReader(stream)
            txt = reader.ReadToEnd()
            reader.Dispose() : stream.Dispose()
            TextBox1.Text = txt
        End If

    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim txt As String
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        If PrintDialog1.ShowDialog =
                Windows.Forms.DialogResult.OK Then
            If txt <> "" Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim FORMMENU As New FORMMENU
        FORMMENU.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class