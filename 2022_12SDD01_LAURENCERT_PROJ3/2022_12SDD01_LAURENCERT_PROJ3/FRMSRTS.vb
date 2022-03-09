Public Class FRMSRTS
    Private Sub BTNSRT_Click(sender As Object, e As EventArgs) Handles BTNSRT.Click
        Dim intx As Integer
        Dim inty As Integer
        Dim intSpare As Integer
        Dim intCounter As Integer
        Dim intCount2 As Integer
        Dim arrNumber(99) As Integer
        Do While intx <= 99
            Randomize()
            inty = Int(99 * Rnd() + 1)
            Unsort.Items.Add(inty)
            arrNumber(intx) = inty
            intx = intx + 1
        Loop
        intCounter = 0
        'Shuffles elements of array into two parts
        MsgBox("ListBox has random entries now it will sort ")
        'sorts the numbers smallest to largest in an array
        For intx = 0 To 100
            For intCounter = 0 To 98
                intCount2 = intCounter + 1
                If arrNumber(intCounter) > arrNumber(intCount2) Then
                    intSpare = arrNumber(intCounter)
                    arrNumber(intCounter) = arrNumber(intCount2)
                    arrNumber(intCount2) = intSpare
                End If
            Next intCounter
        Next intx
        'Clears the listbox so the numbers can be inputted
        Sort.Items.Clear()
        For inty = 0 To 99
            Sort.Items.Add(arrNumber(inty))
        Next inty
    End Sub

    Private Sub ButtonINS_Click(sender As Object, e As EventArgs) Handles ButtonINS.Click
        Dim arrNumber(999) As Integer
        Dim intx As Integer
        Dim inty As Integer
        Dim intSpare As Integer
        Dim intCounter As Integer
        Dim intShuffle As Integer
        ListBoxInsert.Items.Clear()
        Do While intx <= 999
            Randomize()
            inty = Int(1000 * Rnd() + 1)
            ListBoxInsert.Items.Add(inty)
            arrNumber(intx) = inty
            intx = intx + 1
        Loop
        intCounter = 0
        'Shuffles elements of array into two parts
        MsgBox("Sort begins now")
        Do While intCounter < 999
            If arrNumber(intCounter) > arrNumber(intCounter + 1) Then
                intSpare = arrNumber(intCounter + 1)
                intShuffle = intCounter
                Do While intShuffle >= 0 And arrNumber(intShuffle) > intSpare
                    arrNumber(intShuffle + 1) = arrNumber(intShuffle)
                    If intShuffle = 0 Then Exit Do
                    intShuffle = intShuffle - 1
                Loop
                arrNumber(intShuffle) = intSpare
            End If
            intCounter = intCounter + 1
        Loop
        'clears the listbox so the numbers can be inputted
        ListBoxSort.Items.Clear()
        'inputs the sorted numbers from array into listbox
        For inty = 0 To 999
            ListBoxSort.Items.Add(arrNumber(inty))
        Next inty
    End Sub

    Private Sub ButtonBinary_Click(sender As Object, e As EventArgs) Handles ButtonBinary.Click
        Dim inthigh As Integer
        Dim intlow As Integer
        Dim blnfound As Boolean
        Dim inttry As Integer
        Dim sName As String
        Dim strArray(10) As String

        strArray(0) = "Fred"
        strArray(1) = "George"
        strArray(2) = "Mike"
        strArray(3) = "Neal"
        strArray(4) = "Peter"
        strArray(5) = "Sam"
        'Note the array is already sorted… 

        For intx = 0 To 5
            ListBoxSearch.Items.Add(strArray(intx))
        Next
        blnfound = False
        intlow = 0
        inthigh = ListBoxSearch.Items.Count - 1
        sName = TextBoxBinary.Text
        Do While blnfound = False
            inttry = Int((inthigh + intlow) / 2)
            If sName = ListBoxSearch.Items(inttry) Then
                blnfound = True
                MsgBox(sName & " is at position " & inttry)
            ElseIf sName < ListBoxSearch.Items(inttry) Then
                inthigh = inttry - 1
            Else
                intlow = inttry + 1
            End If
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strqtr(4) As String
        Dim strsearch As String
        Dim c As Integer
        Dim strlist As String
        strqtr(0) = "Quarter 1"
        strqtr(1) = "Quarter 2"
        strqtr(2) = "Quarter 3"
        strqtr(3) = "Quarter 4"

        ListBoxSearchLinear.Items.Clear()
        For c = 0 To 3
            ListBoxSearchLinear.Items.Add(strqtr(c))
        Next c

        MsgBox("Now traversing the array")
        For c = 0 To 3
            strsearch = TextBoxLinear.Text
            strlist = ListBoxSearchLinear.Items(c)
            If strlist = strsearch Then
                MsgBox(strlist & " is at position" & c)
                Exit Sub
            Else : MsgBox("Not found at position" & c)
            End If
        Next c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formmenu As New FORMMENU
        formmenu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class