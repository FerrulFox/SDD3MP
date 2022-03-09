<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDATGRI
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.UsrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsrTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsrAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsrName, Me.UsrTelephone, Me.UsrAddress})
        Me.DataGridView.Location = New System.Drawing.Point(19, 16)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidth = 62
        Me.DataGridView.RowTemplate.Height = 28
        Me.DataGridView.Size = New System.Drawing.Size(514, 187)
        Me.DataGridView.TabIndex = 0
        '
        'UsrName
        '
        Me.UsrName.HeaderText = "Name"
        Me.UsrName.MinimumWidth = 8
        Me.UsrName.Name = "UsrName"
        Me.UsrName.Width = 150
        '
        'UsrTelephone
        '
        Me.UsrTelephone.HeaderText = "Telephone"
        Me.UsrTelephone.MinimumWidth = 8
        Me.UsrTelephone.Name = "UsrTelephone"
        Me.UsrTelephone.Width = 150
        '
        'UsrAddress
        '
        Me.UsrAddress.HeaderText = "Address"
        Me.UsrAddress.MinimumWidth = 8
        Me.UsrAddress.Name = "UsrAddress"
        Me.UsrAddress.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Read Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 68)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Sort"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 72)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Return Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(383, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 72)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Quit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FRMDATGRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "FRMDATGRI"
        Me.Text = "FRMUBDG"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView As Windows.Forms.DataGridView
    Friend WithEvents UsrName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsrTelephone As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsrAddress As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
End Class
