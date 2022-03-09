Imports System
Imports System.IO
Imports System.Collections
Public Class FormWonders
    Public Shared wondersPictures() As Image
    Public Shared wondersText() As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub FormWonders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        ReDim FormWonders.wondersPictures(7)
        wondersPictures(0) = My.Resources.Pyramid
        wondersPictures(1) = My.Resources.Gardens
        wondersPictures(2) = My.Resources.Temple
        wondersPictures(3) = My.Resources.Statue
        wondersPictures(4) = My.Resources.Mausoleum
        wondersPictures(5) = My.Resources.Colossus
        wondersPictures(6) = My.Resources.Lighthouse
        ReDim FormWonders.wondersText(7)
        Dim myFileDir, myfilenameandpath As String
        Dim myfile As StreamReader
        myFileDir =
System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        myfilenameandpath = myFileDir & "\7wonders.txt"
        If File.Exists(myfilenameandpath) = True Then
            myfile = File.OpenText(myfilenameandpath)
            For i = 0 To 6
                wondersText(i) = (myfile.ReadLine)
            Next
            myfile.Close()
        Else
            MsgBox("No File")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = wondersPictures(ListBox1.SelectedIndices(0))
        TextBox1.Text = wondersText(ListBox1.SelectedIndices(0))
    End Sub
End Class