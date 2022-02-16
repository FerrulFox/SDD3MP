Public Class Pretestsentinel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblnumber As Double
        Dim dbltotal As Double

        dblnumber = Val(InputBox("enter a number(999 to quit):", "input loop"))

        Do While dblnumber <> 999
            dbltotal = dbltotal + dblnumber
            dblnumber = Val(InputBox("enter a number (999 to quit)", "inputloop"))
        Loop

        lbltotal.text = "the total input was:" & Str(dbltotal)
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        FRM_MAINMENU.Show()
    End Sub

    Private Sub Pretestsentinel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class