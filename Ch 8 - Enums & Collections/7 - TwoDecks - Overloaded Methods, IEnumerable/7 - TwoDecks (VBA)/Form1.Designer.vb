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
        Me.labelDeck2 = New System.Windows.Forms.Label()
        Me.labelDeck1 = New System.Windows.Forms.Label()
        Me.shuffle2 = New System.Windows.Forms.Button()
        Me.reset2 = New System.Windows.Forms.Button()
        Me.shuffle1 = New System.Windows.Forms.Button()
        Me.reset1 = New System.Windows.Forms.Button()
        Me.moveToDeck1 = New System.Windows.Forms.Button()
        Me.deckList2 = New System.Windows.Forms.ListBox()
        Me.moveToDeck2 = New System.Windows.Forms.Button()
        Me.deckList1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'labelDeck2
        '
        Me.labelDeck2.AutoSize = True
        Me.labelDeck2.Location = New System.Drawing.Point(185, 4)
        Me.labelDeck2.Name = "labelDeck2"
        Me.labelDeck2.Size = New System.Drawing.Size(49, 13)
        Me.labelDeck2.TabIndex = 19
        Me.labelDeck2.Text = "Deck #2"
        '
        'labelDeck1
        '
        Me.labelDeck1.AutoSize = True
        Me.labelDeck1.Location = New System.Drawing.Point(12, 4)
        Me.labelDeck1.Name = "labelDeck1"
        Me.labelDeck1.Size = New System.Drawing.Size(49, 13)
        Me.labelDeck1.TabIndex = 18
        Me.labelDeck1.Text = "Deck #1"
        '
        'shuffle2
        '
        Me.shuffle2.Location = New System.Drawing.Point(188, 244)
        Me.shuffle2.Name = "shuffle2"
        Me.shuffle2.Size = New System.Drawing.Size(119, 22)
        Me.shuffle2.TabIndex = 17
        Me.shuffle2.Text = "Shuffle Deck #2"
        Me.shuffle2.UseVisualStyleBackColor = True
        '
        'reset2
        '
        Me.reset2.Location = New System.Drawing.Point(188, 215)
        Me.reset2.Name = "reset2"
        Me.reset2.Size = New System.Drawing.Size(119, 22)
        Me.reset2.TabIndex = 16
        Me.reset2.Text = "Reset Deck #2"
        Me.reset2.UseVisualStyleBackColor = True
        '
        'shuffle1
        '
        Me.shuffle1.Location = New System.Drawing.Point(11, 244)
        Me.shuffle1.Name = "shuffle1"
        Me.shuffle1.Size = New System.Drawing.Size(120, 22)
        Me.shuffle1.TabIndex = 15
        Me.shuffle1.Text = "Shuffle Deck #1"
        Me.shuffle1.UseVisualStyleBackColor = True
        '
        'reset1
        '
        Me.reset1.Location = New System.Drawing.Point(11, 215)
        Me.reset1.Name = "reset1"
        Me.reset1.Size = New System.Drawing.Size(120, 22)
        Me.reset1.TabIndex = 14
        Me.reset1.Text = "Reset Deck #1"
        Me.reset1.UseVisualStyleBackColor = True
        '
        'moveToDeck1
        '
        Me.moveToDeck1.Location = New System.Drawing.Point(138, 90)
        Me.moveToDeck1.Name = "moveToDeck1"
        Me.moveToDeck1.Size = New System.Drawing.Size(43, 22)
        Me.moveToDeck1.TabIndex = 13
        Me.moveToDeck1.Text = "<<"
        Me.moveToDeck1.UseVisualStyleBackColor = True
        '
        'deckList2
        '
        Me.deckList2.FormattingEnabled = True
        Me.deckList2.Location = New System.Drawing.Point(188, 23)
        Me.deckList2.Name = "deckList2"
        Me.deckList2.Size = New System.Drawing.Size(119, 186)
        Me.deckList2.TabIndex = 12
        '
        'moveToDeck2
        '
        Me.moveToDeck2.Location = New System.Drawing.Point(138, 61)
        Me.moveToDeck2.Name = "moveToDeck2"
        Me.moveToDeck2.Size = New System.Drawing.Size(43, 22)
        Me.moveToDeck2.TabIndex = 11
        Me.moveToDeck2.Text = ">>"
        Me.moveToDeck2.UseVisualStyleBackColor = True
        '
        'deckList1
        '
        Me.deckList1.FormattingEnabled = True
        Me.deckList1.Location = New System.Drawing.Point(12, 23)
        Me.deckList1.Name = "deckList1"
        Me.deckList1.Size = New System.Drawing.Size(119, 186)
        Me.deckList1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 275)
        Me.Controls.Add(Me.labelDeck2)
        Me.Controls.Add(Me.labelDeck1)
        Me.Controls.Add(Me.shuffle2)
        Me.Controls.Add(Me.reset2)
        Me.Controls.Add(Me.shuffle1)
        Me.Controls.Add(Me.reset1)
        Me.Controls.Add(Me.moveToDeck1)
        Me.Controls.Add(Me.deckList2)
        Me.Controls.Add(Me.moveToDeck2)
        Me.Controls.Add(Me.deckList1)
        Me.Name = "Form1"
        Me.Text = "Two Decks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents labelDeck2 As System.Windows.Forms.Label
    Private WithEvents labelDeck1 As System.Windows.Forms.Label
    Private WithEvents shuffle2 As System.Windows.Forms.Button
    Private WithEvents reset2 As System.Windows.Forms.Button
    Private WithEvents shuffle1 As System.Windows.Forms.Button
    Private WithEvents reset1 As System.Windows.Forms.Button
    Private WithEvents moveToDeck1 As System.Windows.Forms.Button
    Private WithEvents deckList2 As System.Windows.Forms.ListBox
    Private WithEvents moveToDeck2 As System.Windows.Forms.Button
    Private WithEvents deckList1 As System.Windows.Forms.ListBox

End Class
