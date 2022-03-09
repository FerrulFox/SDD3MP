Public Class FormFilesTextbox
    Private Sub filetomsgbxbtn_Click(sender As Object, e As EventArgs) Handles filetomsgbxbtn.Click
        Using Reader As New _
        Microsoft.VisualBasic.FileIO.TextFieldParser(“C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\12SDDHSC_LAURENCERT_PROJ2\suffering.txt”)
            Reader.TextFieldType =
            Microsoft.VisualBasic.FileIO.FieldType.FixedWidth
            Reader.SetFieldWidths(49, 1)
            Dim currentrow As String()
            While Not Reader.EndOfData
                Try
                    currentrow = Reader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentrow
                        MsgBox(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Private Sub cmdAppend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxtoflebtn.Click
        Dim strWrite As String
        strWrite = TextBox1.Text + Chr(13)
        My.Computer.FileSystem.WriteAllText("C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\12SDDHSC_LAURENCERT_PROJ2\test.txt", strWrite, True)
        MsgBox("Successfully written.")
    End Sub

    Private Sub filetomsgbxbtn2_Click(sender As Object, e As EventArgs) Handles filetomsgbxbtn2.Click
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(“C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\12SDDHSC_LAURENCERT_PROJ2\test.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim CurrentField As String
                    For Each CurrentField In currentRow
                        MsgBox(CurrentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped")
                End Try
            End While
        End Using
    End Sub

    Private Sub txtbxfile2_Click(sender As Object, e As EventArgs) Handles txtbxfile2.Click
        Dim FILE_NAME As String = (“C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\12SDDHSC_LAURENCERT_PROJ2\testoutput.txt")
        Dim Name1 As String
        Name1 = TextBoxtoFile2.Text
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.WriteLine(Name1)
            objWriter.Close()
            MsgBox("Text written in file.")
        Else : MsgBox("File does not exist")
        End If
    End Sub

    Private Sub filetotxtbx_Click(sender As Object, e As EventArgs) Handles filetotxtbx.Click
        TextBoxFileTextbox.Text =
       My.Computer.FileSystem.ReadAllText(“C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\12SDDHSC_LAURENCERT_PROJ2\testoutput.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Hide()
        Dim FORMMENU As New FORMMENU
        FORMMENU.Show()
    End Sub
End Class