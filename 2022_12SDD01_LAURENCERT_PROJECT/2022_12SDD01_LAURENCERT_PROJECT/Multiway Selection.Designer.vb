<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiway_Selection
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
        Me.ButtonGrade = New System.Windows.Forms.Button()
        Me.ButtonNumber = New System.Windows.Forms.Button()
        Me.TextBoxGrade = New System.Windows.Forms.TextBox()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.Labelgrade = New System.Windows.Forms.Label()
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonGrade
        '
        Me.ButtonGrade.Location = New System.Drawing.Point(82, 226)
        Me.ButtonGrade.Name = "ButtonGrade"
        Me.ButtonGrade.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGrade.TabIndex = 0
        Me.ButtonGrade.Text = "Button1"
        Me.ButtonGrade.UseVisualStyleBackColor = True
        '
        'ButtonNumber
        '
        Me.ButtonNumber.Location = New System.Drawing.Point(448, 237)
        Me.ButtonNumber.Name = "ButtonNumber"
        Me.ButtonNumber.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNumber.TabIndex = 1
        Me.ButtonNumber.Text = "Button2"
        Me.ButtonNumber.UseVisualStyleBackColor = True
        '
        'TextBoxGrade
        '
        Me.TextBoxGrade.Location = New System.Drawing.Point(73, 183)
        Me.TextBoxGrade.Name = "TextBoxGrade"
        Me.TextBoxGrade.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGrade.TabIndex = 2
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(448, 183)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumber.TabIndex = 3
        '
        'Labelgrade
        '
        Me.Labelgrade.AutoSize = True
        Me.Labelgrade.Location = New System.Drawing.Point(70, 155)
        Me.Labelgrade.Name = "Labelgrade"
        Me.Labelgrade.Size = New System.Drawing.Size(0, 13)
        Me.Labelgrade.TabIndex = 4
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.Location = New System.Drawing.Point(456, 167)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(79, 13)
        Me.LabelNumber.TabIndex = 5
        Me.LabelNumber.Text = "Enter a number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter a letter"
        '
        'Multiway_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelNumber)
        Me.Controls.Add(Me.Labelgrade)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.TextBoxGrade)
        Me.Controls.Add(Me.ButtonNumber)
        Me.Controls.Add(Me.ButtonGrade)
        Me.Name = "Multiway_Selection"
        Me.Text = "Multiway_Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGrade As Button
    Friend WithEvents ButtonNumber As Button
    Friend WithEvents TextBoxGrade As TextBox
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents Labelgrade As Label
    Friend WithEvents LabelNumber As Label
    Friend WithEvents Label2 As Label
End Class
