<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Posttestloop
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
        Me.BTN_INPTPW = New System.Windows.Forms.Button()
        Me.BTN_QUIT = New System.Windows.Forms.Button()
        Me.BTN_RTRN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotxt_IV25", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input your password!"
        '
        'BTN_INPTPW
        '
        Me.BTN_INPTPW.Location = New System.Drawing.Point(234, 107)
        Me.BTN_INPTPW.Name = "BTN_INPTPW"
        Me.BTN_INPTPW.Size = New System.Drawing.Size(135, 81)
        Me.BTN_INPTPW.TabIndex = 1
        Me.BTN_INPTPW.Text = "Enter your password!"
        Me.BTN_INPTPW.UseVisualStyleBackColor = True
        '
        'BTN_QUIT
        '
        Me.BTN_QUIT.Location = New System.Drawing.Point(523, 277)
        Me.BTN_QUIT.Name = "BTN_QUIT"
        Me.BTN_QUIT.Size = New System.Drawing.Size(117, 55)
        Me.BTN_QUIT.TabIndex = 3
        Me.BTN_QUIT.Text = "Quit"
        Me.BTN_QUIT.UseVisualStyleBackColor = True
        '
        'BTN_RTRN
        '
        Me.BTN_RTRN.Location = New System.Drawing.Point(12, 274)
        Me.BTN_RTRN.Name = "BTN_RTRN"
        Me.BTN_RTRN.Size = New System.Drawing.Size(117, 55)
        Me.BTN_RTRN.TabIndex = 5
        Me.BTN_RTRN.Text = "Return To Main Menu"
        Me.BTN_RTRN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 48)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "(The password is: CoyoteBand2021)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     ((yes, it is case-sensitive))" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Posttestloop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 344)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_RTRN)
        Me.Controls.Add(Me.BTN_QUIT)
        Me.Controls.Add(Me.BTN_INPTPW)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Posttestloop"
        Me.Text = "Post Test Loop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_INPTPW As Button
    Friend WithEvents BTN_QUIT As Button
    Friend WithEvents BTN_RTRN As Button
    Friend WithEvents Label2 As Label
End Class
