<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMMENU
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRdWrte = New System.Windows.Forms.Button()
        Me.BtnSLOF = New System.Windows.Forms.Button()
        Me.BtnFileTextbox = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(746, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Laurence Riordan Thompson's Project 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Main Menu!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(757, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Use one of the buttons below to select an application:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PROJECT 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnRdWrte
        '
        Me.BtnRdWrte.Location = New System.Drawing.Point(320, 166)
        Me.BtnRdWrte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRdWrte.Name = "BtnRdWrte"
        Me.BtnRdWrte.Size = New System.Drawing.Size(192, 86)
        Me.BtnRdWrte.TabIndex = 3
        Me.BtnRdWrte.Text = "Reading/Writing files"
        Me.BtnRdWrte.UseVisualStyleBackColor = True
        '
        'BtnSLOF
        '
        Me.BtnSLOF.Location = New System.Drawing.Point(320, 261)
        Me.BtnSLOF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSLOF.Name = "BtnSLOF"
        Me.BtnSLOF.Size = New System.Drawing.Size(192, 86)
        Me.BtnSLOF.TabIndex = 4
        Me.BtnSLOF.Text = "Streaming Lines of Text"
        Me.BtnSLOF.UseVisualStyleBackColor = True
        '
        'BtnFileTextbox
        '
        Me.BtnFileTextbox.Location = New System.Drawing.Point(320, 357)
        Me.BtnFileTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnFileTextbox.Name = "BtnFileTextbox"
        Me.BtnFileTextbox.Size = New System.Drawing.Size(192, 86)
        Me.BtnFileTextbox.TabIndex = 5
        Me.BtnFileTextbox.Text = "Files and Textboxes"
        Me.BtnFileTextbox.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(835, 372)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 70)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Quit"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FORMMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(947, 461)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnFileTextbox)
        Me.Controls.Add(Me.BtnSLOF)
        Me.Controls.Add(Me.BtnRdWrte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FORMMENU"
        Me.Text = "Project 2 Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRdWrte As Button
    Friend WithEvents BtnSLOF As Button
    Friend WithEvents BtnFileTextbox As Button
    Friend WithEvents BtnClose As Button
End Class
