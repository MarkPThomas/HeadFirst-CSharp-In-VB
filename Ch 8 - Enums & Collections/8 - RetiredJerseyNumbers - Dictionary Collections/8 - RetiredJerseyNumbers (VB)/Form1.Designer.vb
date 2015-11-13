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
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'yearLabel
        '
        Me.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.yearLabel.Location = New System.Drawing.Point(353, 9)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(98, 18)
        Me.yearLabel.TabIndex = 12
        Me.yearLabel.Text = "yearLabel"
        '
        'number
        '
        Me.number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.number.FormattingEnabled = True
        Me.number.Location = New System.Drawing.Point(57, 6)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(41, 21)
        Me.number.TabIndex = 11
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(279, 9)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 10
        Me.label4.Text = "and retired in"
        '
        'nameLabel
        '
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nameLabel.Location = New System.Drawing.Point(175, 8)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(98, 18)
        Me.nameLabel.TabIndex = 9
        Me.nameLabel.Text = "nameLabel"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(103, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 8
        Me.label2.Text = "was worn by"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 41)
        Me.Controls.Add(Me.yearLabel)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Retired Jersey Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents yearLabel As System.Windows.Forms.Label
    Private WithEvents number As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents nameLabel As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
