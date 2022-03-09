<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilesTextbox
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
        Me.filetomsgbxbtn = New System.Windows.Forms.Button()
        Me.txtbxtoflebtn = New System.Windows.Forms.Button()
        Me.filetomsgbxbtn2 = New System.Windows.Forms.Button()
        Me.txtbxfile2 = New System.Windows.Forms.Button()
        Me.filetotxtbx = New System.Windows.Forms.Button()
        Me.TextBoxtoFile2 = New System.Windows.Forms.TextBox()
        Me.TextBoxFileTextbox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'filetomsgbxbtn
        '
        Me.filetomsgbxbtn.Location = New System.Drawing.Point(358, 12)
        Me.filetomsgbxbtn.Name = "filetomsgbxbtn"
        Me.filetomsgbxbtn.Size = New System.Drawing.Size(610, 55)
        Me.filetomsgbxbtn.TabIndex = 0
        Me.filetomsgbxbtn.Text = "Read Text File and Display in Messagebox"
        Me.filetomsgbxbtn.UseVisualStyleBackColor = True
        '
        'txtbxtoflebtn
        '
        Me.txtbxtoflebtn.Location = New System.Drawing.Point(358, 73)
        Me.txtbxtoflebtn.Name = "txtbxtoflebtn"
        Me.txtbxtoflebtn.Size = New System.Drawing.Size(610, 55)
        Me.txtbxtoflebtn.TabIndex = 1
        Me.txtbxtoflebtn.Text = "Append text in textbox on left to existing comma delimited file called text.txt"
        Me.txtbxtoflebtn.UseVisualStyleBackColor = True
        '
        'filetomsgbxbtn2
        '
        Me.filetomsgbxbtn2.Location = New System.Drawing.Point(358, 134)
        Me.filetomsgbxbtn2.Name = "filetomsgbxbtn2"
        Me.filetomsgbxbtn2.Size = New System.Drawing.Size(610, 55)
        Me.filetomsgbxbtn2.TabIndex = 2
        Me.filetomsgbxbtn2.Text = "read pre-existing file called text.txt with comma delimiters and display in msgbo" &
    "x"
        Me.filetomsgbxbtn2.UseVisualStyleBackColor = True
        '
        'txtbxfile2
        '
        Me.txtbxfile2.Location = New System.Drawing.Point(358, 195)
        Me.txtbxfile2.Name = "txtbxfile2"
        Me.txtbxfile2.Size = New System.Drawing.Size(610, 55)
        Me.txtbxfile2.TabIndex = 3
        Me.txtbxfile2.Text = "write textbox on the left to an existing file called test output"
        Me.txtbxfile2.UseVisualStyleBackColor = True
        '
        'filetotxtbx
        '
        Me.filetotxtbx.Location = New System.Drawing.Point(358, 256)
        Me.filetotxtbx.Name = "filetotxtbx"
        Me.filetotxtbx.Size = New System.Drawing.Size(610, 55)
        Me.filetotxtbx.TabIndex = 4
        Me.filetotxtbx.Text = "read from existing file called testoutput.txt and write to textbox on left"
        Me.filetotxtbx.UseVisualStyleBackColor = True
        '
        'TextBoxtoFile2
        '
        Me.TextBoxtoFile2.Location = New System.Drawing.Point(12, 195)
        Me.TextBoxtoFile2.Multiline = True
        Me.TextBoxtoFile2.Name = "TextBoxtoFile2"
        Me.TextBoxtoFile2.Size = New System.Drawing.Size(340, 55)
        Me.TextBoxtoFile2.TabIndex = 5
        '
        'TextBoxFileTextbox
        '
        Me.TextBoxFileTextbox.Location = New System.Drawing.Point(12, 256)
        Me.TextBoxFileTextbox.Multiline = True
        Me.TextBoxFileTextbox.Name = "TextBoxFileTextbox"
        Me.TextBoxFileTextbox.Size = New System.Drawing.Size(340, 55)
        Me.TextBoxFileTextbox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 73)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(340, 55)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(974, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "File To Messagebox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(974, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Textbox To File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(974, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "File to Messagebox"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(974, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Textbox to file"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(974, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "File to textbox"
        '
        'BtnReturn
        '
        Me.BtnReturn.Location = New System.Drawing.Point(12, 394)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(114, 68)
        Me.BtnReturn.TabIndex = 13
        Me.BtnReturn.Text = "Return Home"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Location = New System.Drawing.Point(1010, 394)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(114, 68)
        Me.BtnQuit.TabIndex = 14
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'FormFilesTextbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1136, 474)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxFileTextbox)
        Me.Controls.Add(Me.TextBoxtoFile2)
        Me.Controls.Add(Me.filetotxtbx)
        Me.Controls.Add(Me.txtbxfile2)
        Me.Controls.Add(Me.filetomsgbxbtn2)
        Me.Controls.Add(Me.txtbxtoflebtn)
        Me.Controls.Add(Me.filetomsgbxbtn)
        Me.Name = "FormFilesTextbox"
        Me.Text = "Files and Textboxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filetomsgbxbtn As Button
    Friend WithEvents txtbxtoflebtn As Button
    Friend WithEvents filetomsgbxbtn2 As Button
    Friend WithEvents txtbxfile2 As Button
    Friend WithEvents filetotxtbx As Button
    Friend WithEvents TextBoxtoFile2 As TextBox
    Friend WithEvents TextBoxFileTextbox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnQuit As Button
End Class
