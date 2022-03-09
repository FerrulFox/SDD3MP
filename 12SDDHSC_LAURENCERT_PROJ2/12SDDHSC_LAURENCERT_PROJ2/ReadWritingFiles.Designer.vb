<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadWritingFiles
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
        Me.TextBoxBig = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonWrite = New System.Windows.Forms.Button()
        Me.Buttonhome = New System.Windows.Forms.Button()
        Me.Buttonquit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxBig
        '
        Me.TextBoxBig.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxBig.Multiline = True
        Me.TextBoxBig.Name = "TextBoxBig"
        Me.TextBoxBig.Size = New System.Drawing.Size(531, 334)
        Me.TextBoxBig.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 362)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(340, 24)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Overwrite if file exists (will append otherwise"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(198, 398)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxSearch.TabIndex = 2
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(12, 438)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(154, 55)
        Me.ButtonRead.TabIndex = 3
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonWrite
        '
        Me.ButtonWrite.Location = New System.Drawing.Point(377, 438)
        Me.ButtonWrite.Name = "ButtonWrite"
        Me.ButtonWrite.Size = New System.Drawing.Size(154, 55)
        Me.ButtonWrite.TabIndex = 5
        Me.ButtonWrite.Text = "Write"
        Me.ButtonWrite.UseVisualStyleBackColor = True
        '
        'Buttonhome
        '
        Me.Buttonhome.Location = New System.Drawing.Point(12, 530)
        Me.Buttonhome.Name = "Buttonhome"
        Me.Buttonhome.Size = New System.Drawing.Size(154, 55)
        Me.Buttonhome.TabIndex = 6
        Me.Buttonhome.Text = "Return Home"
        Me.Buttonhome.UseVisualStyleBackColor = True
        '
        'Buttonquit
        '
        Me.Buttonquit.Location = New System.Drawing.Point(377, 530)
        Me.Buttonquit.Name = "Buttonquit"
        Me.Buttonquit.Size = New System.Drawing.Size(154, 55)
        Me.Buttonquit.TabIndex = 7
        Me.Buttonquit.Text = "Quit Project"
        Me.Buttonquit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filename (No extension)"
        '
        'ReadWritingFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(559, 599)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonquit)
        Me.Controls.Add(Me.Buttonhome)
        Me.Controls.Add(Me.ButtonWrite)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBoxBig)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReadWritingFiles"
        Me.Text = "Reading And Writing Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxBig As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonWrite As Button
    Friend WithEvents Buttonhome As Button
    Friend WithEvents Buttonquit As Button
    Friend WithEvents Label1 As Label
End Class
