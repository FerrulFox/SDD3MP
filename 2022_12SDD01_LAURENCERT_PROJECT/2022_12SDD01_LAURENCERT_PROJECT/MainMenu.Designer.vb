<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAINMENU
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
        Me.LBL_MAINMENU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_PTLOOP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTN_MULWAYLOOP = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_MAINMENU
        '
        Me.LBL_MAINMENU.AutoSize = True
        Me.LBL_MAINMENU.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MAINMENU.Location = New System.Drawing.Point(167, 9)
        Me.LBL_MAINMENU.Name = "LBL_MAINMENU"
        Me.LBL_MAINMENU.Size = New System.Drawing.Size(503, 48)
        Me.LBL_MAINMENU.TabIndex = 0
        Me.LBL_MAINMENU.Text = "Welcome to Laurence Riordan Thompson's Project 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Main Menu!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Use one of the buttons below to select an application:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(310, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pre-Test Loop w/ Sentinel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PROJECT 1"
        '
        'BTN_PTLOOP
        '
        Me.BTN_PTLOOP.Location = New System.Drawing.Point(310, 175)
        Me.BTN_PTLOOP.Name = "BTN_PTLOOP"
        Me.BTN_PTLOOP.Size = New System.Drawing.Size(174, 60)
        Me.BTN_PTLOOP.TabIndex = 4
        Me.BTN_PTLOOP.Text = "Post Test Loop"
        Me.BTN_PTLOOP.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 60)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Counted Loop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTN_MULWAYLOOP
        '
        Me.BTN_MULWAYLOOP.Location = New System.Drawing.Point(310, 307)
        Me.BTN_MULWAYLOOP.Name = "BTN_MULWAYLOOP"
        Me.BTN_MULWAYLOOP.Size = New System.Drawing.Size(174, 60)
        Me.BTN_MULWAYLOOP.TabIndex = 6
        Me.BTN_MULWAYLOOP.Text = "Mulitway Selection"
        Me.BTN_MULWAYLOOP.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(310, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 60)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Two Dimensional Arrays"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FRM_MAINMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 488)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BTN_MULWAYLOOP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_PTLOOP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_MAINMENU)
        Me.Name = "FRM_MAINMENU"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_MAINMENU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_PTLOOP As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BTN_MULWAYLOOP As Button
    Friend WithEvents Button3 As Button
End Class
