<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMMENU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BRKPNTSBTN = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTNMMP = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Structures"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Sorts"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(228, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Debugging"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BRKPNTSBTN
        '
        Me.BRKPNTSBTN.Location = New System.Drawing.Point(343, 130)
        Me.BRKPNTSBTN.Name = "BRKPNTSBTN"
        Me.BRKPNTSBTN.Size = New System.Drawing.Size(102, 60)
        Me.BRKPNTSBTN.TabIndex = 4
        Me.BRKPNTSBTN.Text = "Breakpoints"
        Me.BRKPNTSBTN.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 81)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Try And Catch Errors"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BTNMMP
        '
        Me.BTNMMP.Location = New System.Drawing.Point(120, 196)
        Me.BTNMMP.Name = "BTNMMP"
        Me.BTNMMP.Size = New System.Drawing.Size(102, 81)
        Me.BTNMMP.TabIndex = 6
        Me.BTNMMP.Text = "Multimedia Player"
        Me.BTNMMP.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(228, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 81)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Unbound Data Grid"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FORMMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(559, 486)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BTNMMP)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BRKPNTSBTN)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMMENU"
        Me.Text = "FORMMENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents BRKPNTSBTN As Windows.Forms.Button
    Friend WithEvents Button5 As Windows.Forms.Button
    Friend WithEvents BTNMMP As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
End Class
