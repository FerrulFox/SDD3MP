<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSTRUCT
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.LBL2 = New System.Windows.Forms.Label()
        Me.LBL3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(3, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(429, 284)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(429, 66)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click to open txt file and load array of structures"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Location = New System.Drawing.Point(438, 12)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(57, 20)
        Me.LBL1.TabIndex = 2
        Me.LBL1.Text = "Label1"
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Location = New System.Drawing.Point(438, 44)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(57, 20)
        Me.LBL2.TabIndex = 3
        Me.LBL2.Text = "Label2"
        '
        'LBL3
        '
        Me.LBL3.AutoSize = True
        Me.LBL3.Location = New System.Drawing.Point(438, 75)
        Me.LBL3.Name = "LBL3"
        Me.LBL3.Size = New System.Drawing.Size(57, 20)
        Me.LBL3.TabIndex = 4
        Me.LBL3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(619, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(619, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(619, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Label6"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 56)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Return Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(841, 483)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 56)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FRMSTRUCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(975, 551)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBL3)
        Me.Controls.Add(Me.LBL2)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "FRMSTRUCT"
        Me.Text = "Structures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents LBL1 As Windows.Forms.Label
    Friend WithEvents LBL2 As Windows.Forms.Label
    Friend WithEvents LBL3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
End Class
