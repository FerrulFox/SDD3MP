<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSRTS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BTNSRT = New System.Windows.Forms.Button()
        Me.Sort = New System.Windows.Forms.ListBox()
        Me.Unsort = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ButtonINS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBoxSort = New System.Windows.Forms.ListBox()
        Me.ListBoxInsert = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListBoxSearch = New System.Windows.Forms.ListBox()
        Me.TextBoxBinary = New System.Windows.Forms.TextBox()
        Me.ButtonBinary = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBoxSearchLinear = New System.Windows.Forms.ListBox()
        Me.TextBoxLinear = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 435)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BTNSRT)
        Me.TabPage2.Controls.Add(Me.Sort)
        Me.TabPage2.Controls.Add(Me.Unsort)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(791, 402)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bubble Sort"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BTNSRT
        '
        Me.BTNSRT.Location = New System.Drawing.Point(317, 107)
        Me.BTNSRT.Name = "BTNSRT"
        Me.BTNSRT.Size = New System.Drawing.Size(152, 51)
        Me.BTNSRT.TabIndex = 2
        Me.BTNSRT.Text = "Bubble Sort"
        Me.BTNSRT.UseVisualStyleBackColor = True
        '
        'Sort
        '
        Me.Sort.FormattingEnabled = True
        Me.Sort.ItemHeight = 20
        Me.Sort.Location = New System.Drawing.Point(588, 42)
        Me.Sort.Name = "Sort"
        Me.Sort.Size = New System.Drawing.Size(196, 364)
        Me.Sort.TabIndex = 1
        '
        'Unsort
        '
        Me.Unsort.FormattingEnabled = True
        Me.Unsort.ItemHeight = 20
        Me.Unsort.Location = New System.Drawing.Point(6, 29)
        Me.Unsort.Name = "Unsort"
        Me.Unsort.Size = New System.Drawing.Size(196, 364)
        Me.Unsort.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ButtonINS)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.ListBoxSort)
        Me.TabPage5.Controls.Add(Me.ListBoxInsert)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(791, 402)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Insertion Sort"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ButtonINS
        '
        Me.ButtonINS.Location = New System.Drawing.Point(266, 53)
        Me.ButtonINS.Name = "ButtonINS"
        Me.ButtonINS.Size = New System.Drawing.Size(234, 116)
        Me.ButtonINS.TabIndex = 3
        Me.ButtonINS.Text = "Insert Sort"
        Me.ButtonINS.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBoxSort
        '
        Me.ListBoxSort.FormattingEnabled = True
        Me.ListBoxSort.ItemHeight = 20
        Me.ListBoxSort.Location = New System.Drawing.Point(587, 42)
        Me.ListBoxSort.Name = "ListBoxSort"
        Me.ListBoxSort.Size = New System.Drawing.Size(201, 364)
        Me.ListBoxSort.TabIndex = 1
        '
        'ListBoxInsert
        '
        Me.ListBoxInsert.FormattingEnabled = True
        Me.ListBoxInsert.ItemHeight = 20
        Me.ListBoxInsert.Location = New System.Drawing.Point(8, 42)
        Me.ListBoxInsert.Name = "ListBoxInsert"
        Me.ListBoxInsert.Size = New System.Drawing.Size(201, 364)
        Me.ListBoxInsert.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBoxSearch)
        Me.TabPage3.Controls.Add(Me.TextBoxBinary)
        Me.TabPage3.Controls.Add(Me.ButtonBinary)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(791, 402)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Binary Search"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBoxSearch
        '
        Me.ListBoxSearch.FormattingEnabled = True
        Me.ListBoxSearch.ItemHeight = 20
        Me.ListBoxSearch.Location = New System.Drawing.Point(255, 3)
        Me.ListBoxSearch.Name = "ListBoxSearch"
        Me.ListBoxSearch.Size = New System.Drawing.Size(253, 384)
        Me.ListBoxSearch.TabIndex = 2
        '
        'TextBoxBinary
        '
        Me.TextBoxBinary.Location = New System.Drawing.Point(8, 131)
        Me.TextBoxBinary.Multiline = True
        Me.TextBoxBinary.Name = "TextBoxBinary"
        Me.TextBoxBinary.Size = New System.Drawing.Size(191, 93)
        Me.TextBoxBinary.TabIndex = 1
        '
        'ButtonBinary
        '
        Me.ButtonBinary.Location = New System.Drawing.Point(8, 21)
        Me.ButtonBinary.Name = "ButtonBinary"
        Me.ButtonBinary.Size = New System.Drawing.Size(126, 62)
        Me.ButtonBinary.TabIndex = 0
        Me.ButtonBinary.Text = "Binary Search"
        Me.ButtonBinary.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBoxSearchLinear)
        Me.TabPage4.Controls.Add(Me.TextBoxLinear)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(791, 402)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Linear Search"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBoxSearchLinear
        '
        Me.ListBoxSearchLinear.FormattingEnabled = True
        Me.ListBoxSearchLinear.ItemHeight = 20
        Me.ListBoxSearchLinear.Location = New System.Drawing.Point(212, 3)
        Me.ListBoxSearchLinear.Name = "ListBoxSearchLinear"
        Me.ListBoxSearchLinear.Size = New System.Drawing.Size(247, 384)
        Me.ListBoxSearchLinear.TabIndex = 2
        '
        'TextBoxLinear
        '
        Me.TextBoxLinear.Location = New System.Drawing.Point(3, 137)
        Me.TextBoxLinear.Multiline = True
        Me.TextBoxLinear.Name = "TextBoxLinear"
        Me.TextBoxLinear.Size = New System.Drawing.Size(161, 75)
        Me.TextBoxLinear.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 78)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Linear Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 48)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Return Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(719, 489)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 48)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Quit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FRMSRTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(828, 549)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FRMSRTS"
        Me.Text = "SortsTrigger"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents BTNSRT As Windows.Forms.Button
    Friend WithEvents Sort As Windows.Forms.ListBox
    Friend WithEvents Unsort As Windows.Forms.ListBox
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Friend WithEvents TabPage5 As Windows.Forms.TabPage
    Friend WithEvents ButtonINS As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents ListBoxSort As Windows.Forms.ListBox
    Friend WithEvents ListBoxInsert As Windows.Forms.ListBox
    Friend WithEvents ButtonBinary As Windows.Forms.Button
    Friend WithEvents ListBoxSearch As Windows.Forms.ListBox
    Friend WithEvents TextBoxBinary As Windows.Forms.TextBox
    Friend WithEvents ListBoxSearchLinear As Windows.Forms.ListBox
    Friend WithEvents TextBoxLinear As Windows.Forms.TextBox
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
End Class
