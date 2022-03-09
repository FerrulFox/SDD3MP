Imports System
Imports System.IO
Imports System.Collections
Public Class FRMSTRUCT
    Structure Unitstruct
        Public ValueOne As String
        Public ValueTwo As String
        Public ValueThree As String
        Public Sub New(rawValue As String)
            Dim values() As String = Split(rawValue, ";")
            ValueOne = values(0)
            ValueTwo = values(1)
            ValueThree = values(2)
        End Sub
    End Structure
    Dim Units(3) As Unitstruct

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label5.Text = Units(ListBox1.SelectedIndex).ValueOne
        Label6.Text = Units(ListBox1.SelectedIndex).ValueThree
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = "C:\Users\gpoop\Documents\SDD3MP-main\2022_12SDD01_LAURENCERT_PROJ3\units.txt"
        Dim reader As New System.IO.StreamReader(path)
        Dim Index As Integer = -1
        While Index < 3
            Index += 1
            Dim Current As String = reader.ReadLine
            Dim fields() As String = Current.Split(";"c)

            Units(Index).ValueOne = fields(0)
            Units(Index).ValueTwo = fields(1)
            Units(Index).ValueThree = fields(2)

            ListBox1.Items.Add(Units(Index).ValueTwo)
        End While

        LBL1.Text = Units(Index).ValueOne
        LBL2.Text = Units(Index).ValueTwo
        LBL3.Text = Units(Index).ValueThree
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim formmenu As New FORMMENU
        formmenu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class