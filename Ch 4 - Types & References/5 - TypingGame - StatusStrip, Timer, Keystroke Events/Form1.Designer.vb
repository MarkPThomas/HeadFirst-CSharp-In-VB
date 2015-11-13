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
        Me.components = New System.ComponentModel.Container()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.correctLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.missedLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.accuracyLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.difficultyProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 108
        Me.listBox1.Location = New System.Drawing.Point(0, 0)
        Me.listBox1.MultiColumn = True
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(860, 136)
        Me.listBox1.TabIndex = 1
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.correctLabel, Me.missedLabel, Me.totalLabel, Me.accuracyLabel, Me.toolStripStatusLabel1, Me.difficultyProgressBar})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 114)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(860, 22)
        Me.statusStrip1.SizingGrip = False
        Me.statusStrip1.TabIndex = 2
        Me.statusStrip1.Text = "statusStrip1"
        '
        'correctLabel
        '
        Me.correctLabel.Name = "correctLabel"
        Me.correctLabel.Size = New System.Drawing.Size(58, 17)
        Me.correctLabel.Text = "Correct: 0"
        '
        'missedLabel
        '
        Me.missedLabel.Name = "missedLabel"
        Me.missedLabel.Size = New System.Drawing.Size(56, 17)
        Me.missedLabel.Text = "Missed: 0"
        '
        'totalLabel
        '
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(46, 17)
        Me.totalLabel.Text = "Total: 0"
        '
        'accuracyLabel
        '
        Me.accuracyLabel.Name = "accuracyLabel"
        Me.accuracyLabel.Size = New System.Drawing.Size(81, 17)
        Me.accuracyLabel.Text = "Accuracy:  0%"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(502, 17)
        Me.toolStripStatusLabel1.Spring = True
        Me.toolStripStatusLabel1.Text = "Difficulty"
        Me.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'difficultyProgressBar
        '
        Me.difficultyProgressBar.Maximum = 701
        Me.difficultyProgressBar.Name = "difficultyProgressBar"
        Me.difficultyProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 800
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 136)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.listBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hit the Keys!"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox1 As ListBox
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents correctLabel As ToolStripStatusLabel
    Private WithEvents missedLabel As ToolStripStatusLabel
    Private WithEvents totalLabel As ToolStripStatusLabel
    Private WithEvents accuracyLabel As ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents difficultyProgressBar As ToolStripProgressBar
    Private WithEvents Timer1 As Timer
End Class
