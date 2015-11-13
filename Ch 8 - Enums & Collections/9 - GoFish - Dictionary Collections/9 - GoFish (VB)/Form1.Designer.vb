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
        Me.buttonAsk = New System.Windows.Forms.Button()
        Me.textBooks = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textProgress = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.buttonStart = New System.Windows.Forms.Button()
        Me.listHand = New System.Windows.Forms.ListBox()
        Me.textName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonAsk
        '
        Me.buttonAsk.Location = New System.Drawing.Point(259, 428)
        Me.buttonAsk.Name = "buttonAsk"
        Me.buttonAsk.Size = New System.Drawing.Size(120, 23)
        Me.buttonAsk.TabIndex = 19
        Me.buttonAsk.Text = "Ask for a card"
        Me.buttonAsk.UseVisualStyleBackColor = True
        '
        'textBooks
        '
        Me.textBooks.Location = New System.Drawing.Point(15, 365)
        Me.textBooks.Multiline = True
        Me.textBooks.Name = "textBooks"
        Me.textBooks.ReadOnly = True
        Me.textBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBooks.Size = New System.Drawing.Size(238, 86)
        Me.textBooks.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 349)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Books"
        '
        'textProgress
        '
        Me.textProgress.Location = New System.Drawing.Point(15, 80)
        Me.textProgress.Multiline = True
        Me.textProgress.Name = "textProgress"
        Me.textProgress.ReadOnly = True
        Me.textProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textProgress.Size = New System.Drawing.Size(238, 258)
        Me.textProgress.TabIndex = 16
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Game Progress"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(256, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Your Hand"
        '
        'buttonStart
        '
        Me.buttonStart.Location = New System.Drawing.Point(155, 25)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Size = New System.Drawing.Size(98, 23)
        Me.buttonStart.TabIndex = 13
        Me.buttonStart.Text = "Start the game!"
        Me.buttonStart.UseVisualStyleBackColor = True
        '
        'listHand
        '
        Me.listHand.Enabled = False
        Me.listHand.FormattingEnabled = True
        Me.listHand.Location = New System.Drawing.Point(259, 28)
        Me.listHand.Name = "listHand"
        Me.listHand.Size = New System.Drawing.Size(120, 394)
        Me.listHand.TabIndex = 12
        '
        'textName
        '
        Me.textName.Location = New System.Drawing.Point(15, 28)
        Me.textName.Name = "textName"
        Me.textName.Size = New System.Drawing.Size(134, 20)
        Me.textName.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Your Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 466)
        Me.Controls.Add(Me.buttonAsk)
        Me.Controls.Add(Me.textBooks)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textProgress)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.listHand)
        Me.Controls.Add(Me.textName)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Go Fish"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents buttonAsk As System.Windows.Forms.Button
    Private WithEvents textBooks As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textProgress As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents buttonStart As System.Windows.Forms.Button
    Private WithEvents listHand As System.Windows.Forms.ListBox
    Private WithEvents textName As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
