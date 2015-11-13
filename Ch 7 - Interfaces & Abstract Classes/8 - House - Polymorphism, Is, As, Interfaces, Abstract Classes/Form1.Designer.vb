<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.exits = New System.Windows.Forms.ComboBox()
        Me.goThroughTheDoor = New System.Windows.Forms.Button()
        Me.goHere = New System.Windows.Forms.Button()
        Me.description = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'exits
        '
        Me.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.exits.FormattingEnabled = True
        Me.exits.Location = New System.Drawing.Point(87, 163)
        Me.exits.Name = "exits"
        Me.exits.Size = New System.Drawing.Size(191, 21)
        Me.exits.TabIndex = 7
        '
        'goThroughTheDoor
        '
        Me.goThroughTheDoor.Location = New System.Drawing.Point(6, 190)
        Me.goThroughTheDoor.Name = "goThroughTheDoor"
        Me.goThroughTheDoor.Size = New System.Drawing.Size(272, 23)
        Me.goThroughTheDoor.TabIndex = 6
        Me.goThroughTheDoor.Text = "Go through the door"
        Me.goThroughTheDoor.UseVisualStyleBackColor = True
        '
        'goHere
        '
        Me.goHere.Location = New System.Drawing.Point(6, 161)
        Me.goHere.Name = "goHere"
        Me.goHere.Size = New System.Drawing.Size(75, 23)
        Me.goHere.TabIndex = 5
        Me.goHere.Text = "Go Here:"
        Me.goHere.UseVisualStyleBackColor = True
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(6, 6)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(272, 149)
        Me.description.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 217)
        Me.Controls.Add(Me.exits)
        Me.Controls.Add(Me.goThroughTheDoor)
        Me.Controls.Add(Me.goHere)
        Me.Controls.Add(Me.description)
        Me.Name = "Form1"
        Me.Text = "Explore the House"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents exits As ComboBox
    Private WithEvents goThroughTheDoor As Button
    Private WithEvents goHere As Button
    Private WithEvents description As TextBox
End Class
