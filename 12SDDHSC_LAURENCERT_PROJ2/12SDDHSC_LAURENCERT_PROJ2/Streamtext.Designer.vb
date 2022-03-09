<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StreamText
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.OpenBtn = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 229)
        Me.TextBox1.TabIndex = 0
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(232, 247)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(101, 73)
        Me.PrintBtn.TabIndex = 1
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'OpenBtn
        '
        Me.OpenBtn.Location = New System.Drawing.Point(12, 247)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(101, 73)
        Me.OpenBtn.TabIndex = 2
        Me.OpenBtn.Text = "Open"
        Me.OpenBtn.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 76)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 76)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StreamText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OpenBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "StreamText"
        Me.Text = "Streaming Lines Of Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintBtn As Button
    Friend WithEvents OpenBtn As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
