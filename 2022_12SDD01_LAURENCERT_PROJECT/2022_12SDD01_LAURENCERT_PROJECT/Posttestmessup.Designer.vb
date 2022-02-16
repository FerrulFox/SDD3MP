<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Posttestmessup
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
        Me.BTN_RTNTOFRM = New System.Windows.Forms.Button()
        Me.BTN_HOME = New System.Windows.Forms.Button()
        Me.BTN_MSUP_EXT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You have entered the wrong" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " password (3) times! please try again!"
        '
        'BTN_RTNTOFRM
        '
        Me.BTN_RTNTOFRM.Location = New System.Drawing.Point(48, 54)
        Me.BTN_RTNTOFRM.Name = "BTN_RTNTOFRM"
        Me.BTN_RTNTOFRM.Size = New System.Drawing.Size(99, 55)
        Me.BTN_RTNTOFRM.TabIndex = 1
        Me.BTN_RTNTOFRM.Text = "Return To Form"
        Me.BTN_RTNTOFRM.UseVisualStyleBackColor = True
        '
        'BTN_HOME
        '
        Me.BTN_HOME.Location = New System.Drawing.Point(48, 115)
        Me.BTN_HOME.Name = "BTN_HOME"
        Me.BTN_HOME.Size = New System.Drawing.Size(99, 55)
        Me.BTN_HOME.TabIndex = 2
        Me.BTN_HOME.Text = "Return To Main Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTN_HOME.UseVisualStyleBackColor = True
        '
        'BTN_MSUP_EXT
        '
        Me.BTN_MSUP_EXT.Location = New System.Drawing.Point(48, 176)
        Me.BTN_MSUP_EXT.Name = "BTN_MSUP_EXT"
        Me.BTN_MSUP_EXT.Size = New System.Drawing.Size(99, 55)
        Me.BTN_MSUP_EXT.TabIndex = 3
        Me.BTN_MSUP_EXT.Text = "Call It A Day"
        Me.BTN_MSUP_EXT.UseVisualStyleBackColor = True
        '
        'Posttestmessup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 255)
        Me.Controls.Add(Me.BTN_MSUP_EXT)
        Me.Controls.Add(Me.BTN_HOME)
        Me.Controls.Add(Me.BTN_RTNTOFRM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Posttestmessup"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_RTNTOFRM As Button
    Friend WithEvents BTN_HOME As Button
    Friend WithEvents BTN_MSUP_EXT As Button
End Class
