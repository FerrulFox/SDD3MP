Imports System
Imports System.IO
Imports System.Collections
Public Class ReadWritingFiles

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click 'reads the file from the filepath seen below
        Dim myobjectread As StreamReader
        Dim filecontents, myfilename, myfilepath, myfilenameandpath As String
        myfilename = "TestText"
        If Len(TextBoxSearch.Text) Then myfilename = TextBoxSearch.Text & ".txt"

        myfilepath = ":\Users\gpoop\CDocuments\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2"
        myfilenameandpath = myfilepath & myfilename
        If File.Exists(myfilenameandpath) = True Then
            myobjectread = File.OpenText(myfilenameandpath)
            filecontents = myobjectread.ReadToEnd
            myobjectread.Close()
            TextBoxBig.Text = filecontents
        Else
            MsgBox("sorry this file does not exist." & vbCrLf & myfilenameandpath)
        End If
    End Sub

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click 'writes a file based on user input
        Dim myobjectwrite As StreamWriter
        Dim mytext, myfilename, myfilepath, myfilenameandpath As String
        myfilename = "TestWrite"
        If Len(TextBoxSearch.Text) > 1 Then
            myfilename = TextBoxSearch.Text & ".txt"
        End If
        myfilepath = "C:\Users\gpoop\Documents\SDD3MP-main\12SDDHSC_LAURENCERT_PROJ2\TEXT FILES\"
        myfilenameandpath = myfilepath & myfilename
        If Not CheckBox1.Checked And File.Exists(myfilenameandpath) Then
            myobjectwrite = File.AppendText(myfilenameandpath)
        Else
            myobjectwrite = File.CreateText(myfilenameandpath)
        End If
        mytext = TextBoxBig.Text
        myobjectwrite.WriteLine(mytext)
        myobjectwrite.Close()
        TextBoxBig.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Buttonhome.Click
        Me.Hide()
        FORMMENU.Show()

    End Sub

    Private Sub Buttonquit_Click(sender As Object, e As EventArgs) Handles Buttonquit.Click
        Application.Exit()
    End Sub



End Class