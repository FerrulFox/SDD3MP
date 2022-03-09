Imports System.Windows.Forms

Public Class FRMDATGRI
    Structure PersonInfo
        Dim Name As String
        Dim Tel As String
    End Structure
    Dim Info() As PersonInfo
    Public Sub ReadInfo()
        Dim I As Integer
        Dim N As Integer
        N = InputBox("Enter the number of people")
        ReDim Info(0 To N - 1)
        ' read info here
        For I = 0 To N - 1
            Info(I).Name = InputBox("enter the name of person")
            Info(I).Tel = InputBox("enter the telephone number")
        Next
    End Sub
    Public Sub FillDGV(ByVal DAT() As PersonInfo, DGV As DataGridView)
        DGV.Rows.Clear()
        Dim I As Integer
        For I = 0 To DAT.Length - 1
            DGV.Rows.Add(DAT(I).Name, DAT(I).Tel)
        Next
    End Sub
    Public Sub Sort(ByRef Arr() As PersonInfo)
        Dim Flg As Boolean
        Dim I As Integer
        Dim Tmp As PersonInfo
        Do
            Flg = False
            For I = 0 To Arr.Length - 2
                If Arr(I).Name > Arr(I + 1).Name Then
                    Tmp = Arr(I)
                    Arr(I) = Arr(I + 1)
                    Arr(I + 1) = Tmp
                    Flg = True
                End If
            Next
        Loop While Flg

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReadInfo()
        FillDGV(Info, DataGridView)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sort(Info)
        FillDGV(Info, DataGridView)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formmenu As New FORMMENU
        formmenu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class