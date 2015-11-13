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
        Me.costLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.healthyBox = New System.Windows.Forms.CheckBox()
        Me.fancyBox = New System.Windows.Forms.CheckBox()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'costLabel
        '
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.costLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costLabel.Location = New System.Drawing.Point(46, 96)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(81, 19)
        Me.costLabel.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(9, 97)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Cost"
        '
        'healthyBox
        '
        Me.healthyBox.AutoSize = True
        Me.healthyBox.Location = New System.Drawing.Point(11, 76)
        Me.healthyBox.Name = "healthyBox"
        Me.healthyBox.Size = New System.Drawing.Size(93, 17)
        Me.healthyBox.TabIndex = 9
        Me.healthyBox.Text = "HealthyOption"
        Me.healthyBox.UseVisualStyleBackColor = True
        '
        'fancyBox
        '
        Me.fancyBox.AutoSize = True
        Me.fancyBox.Checked = True
        Me.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fancyBox.Location = New System.Drawing.Point(12, 53)
        Me.fancyBox.Name = "fancyBox"
        Me.fancyBox.Size = New System.Drawing.Size(115, 17)
        Me.fancyBox.TabIndex = 8
        Me.fancyBox.Text = "Fancy Decorations"
        Me.fancyBox.UseVisualStyleBackColor = True
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(12, 26)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDown1.TabIndex = 7
        Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Number of People"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(164, 133)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.healthyBox)
        Me.Controls.Add(Me.fancyBox)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Party Planner"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents costLabel As Label
    Private WithEvents label2 As Label
    Private WithEvents healthyBox As CheckBox
    Private WithEvents fancyBox As CheckBox
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents label1 As Label
End Class
