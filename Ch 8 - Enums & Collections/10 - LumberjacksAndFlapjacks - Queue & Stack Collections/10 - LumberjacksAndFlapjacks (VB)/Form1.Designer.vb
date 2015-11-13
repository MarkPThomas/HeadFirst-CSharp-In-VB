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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.howMany = New System.Windows.Forms.NumericUpDown()
        Me.nextLumberjack = New System.Windows.Forms.Button()
        Me.banana = New System.Windows.Forms.RadioButton()
        Me.crispy = New System.Windows.Forms.RadioButton()
        Me.browned = New System.Windows.Forms.RadioButton()
        Me.nextInLine = New System.Windows.Forms.Label()
        Me.soggy = New System.Windows.Forms.RadioButton()
        Me.addFlapjacks = New System.Windows.Forms.Button()
        Me.addLumberjack = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.ListBox()
        Me.customerName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        CType(Me.howMany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.howMany)
        Me.groupBox1.Controls.Add(Me.nextLumberjack)
        Me.groupBox1.Controls.Add(Me.banana)
        Me.groupBox1.Controls.Add(Me.crispy)
        Me.groupBox1.Controls.Add(Me.browned)
        Me.groupBox1.Controls.Add(Me.nextInLine)
        Me.groupBox1.Controls.Add(Me.soggy)
        Me.groupBox1.Controls.Add(Me.addFlapjacks)
        Me.groupBox1.Location = New System.Drawing.Point(112, 59)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(138, 255)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Feed a Lumberjack"
        '
        'howMany
        '
        Me.howMany.Location = New System.Drawing.Point(7, 19)
        Me.howMany.Name = "howMany"
        Me.howMany.Size = New System.Drawing.Size(63, 20)
        Me.howMany.TabIndex = 10
        '
        'nextLumberjack
        '
        Me.nextLumberjack.Location = New System.Drawing.Point(7, 226)
        Me.nextLumberjack.Name = "nextLumberjack"
        Me.nextLumberjack.Size = New System.Drawing.Size(117, 23)
        Me.nextLumberjack.TabIndex = 9
        Me.nextLumberjack.Text = "Next Lumberjack"
        Me.nextLumberjack.UseVisualStyleBackColor = True
        '
        'banana
        '
        Me.banana.AutoSize = True
        Me.banana.Location = New System.Drawing.Point(7, 114)
        Me.banana.Name = "banana"
        Me.banana.Size = New System.Drawing.Size(62, 17)
        Me.banana.TabIndex = 13
        Me.banana.Text = "Banana"
        Me.banana.UseVisualStyleBackColor = True
        '
        'crispy
        '
        Me.crispy.AutoSize = True
        Me.crispy.Checked = True
        Me.crispy.Location = New System.Drawing.Point(7, 45)
        Me.crispy.Name = "crispy"
        Me.crispy.Size = New System.Drawing.Size(53, 17)
        Me.crispy.TabIndex = 2
        Me.crispy.TabStop = True
        Me.crispy.Text = "Crispy"
        Me.crispy.UseVisualStyleBackColor = True
        '
        'browned
        '
        Me.browned.AutoSize = True
        Me.browned.Location = New System.Drawing.Point(7, 91)
        Me.browned.Name = "browned"
        Me.browned.Size = New System.Drawing.Size(67, 17)
        Me.browned.TabIndex = 12
        Me.browned.Text = "Browned"
        Me.browned.UseVisualStyleBackColor = True
        '
        'nextInLine
        '
        Me.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nextInLine.Location = New System.Drawing.Point(10, 163)
        Me.nextInLine.Name = "nextInLine"
        Me.nextInLine.Size = New System.Drawing.Size(117, 56)
        Me.nextInLine.TabIndex = 6
        '
        'soggy
        '
        Me.soggy.AutoSize = True
        Me.soggy.Location = New System.Drawing.Point(7, 68)
        Me.soggy.Name = "soggy"
        Me.soggy.Size = New System.Drawing.Size(55, 17)
        Me.soggy.TabIndex = 11
        Me.soggy.Text = "Soggy"
        Me.soggy.UseVisualStyleBackColor = True
        '
        'addFlapjacks
        '
        Me.addFlapjacks.Location = New System.Drawing.Point(7, 137)
        Me.addFlapjacks.Name = "addFlapjacks"
        Me.addFlapjacks.Size = New System.Drawing.Size(120, 23)
        Me.addFlapjacks.TabIndex = 8
        Me.addFlapjacks.Text = "Add Flapjacks"
        Me.addFlapjacks.UseVisualStyleBackColor = True
        '
        'addLumberjack
        '
        Me.addLumberjack.Location = New System.Drawing.Point(12, 30)
        Me.addLumberjack.Name = "addLumberjack"
        Me.addLumberjack.Size = New System.Drawing.Size(195, 23)
        Me.addLumberjack.TabIndex = 19
        Me.addLumberjack.Text = "Add Lumberjack"
        Me.addLumberjack.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 59)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Breakfast Line"
        '
        'line
        '
        Me.line.FormattingEnabled = True
        Me.line.Location = New System.Drawing.Point(12, 78)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(94, 238)
        Me.line.TabIndex = 17
        '
        'customerName
        '
        Me.customerName.Location = New System.Drawing.Point(107, 4)
        Me.customerName.Name = "customerName"
        Me.customerName.Size = New System.Drawing.Size(100, 20)
        Me.customerName.TabIndex = 16
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(93, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Lumberjack Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 325)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.addLumberjack)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.customerName)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Breakfast for Lumberjacks"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.howMany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents howMany As System.Windows.Forms.NumericUpDown
    Private WithEvents nextLumberjack As System.Windows.Forms.Button
    Private WithEvents banana As System.Windows.Forms.RadioButton
    Private WithEvents crispy As System.Windows.Forms.RadioButton
    Private WithEvents browned As System.Windows.Forms.RadioButton
    Private WithEvents nextInLine As System.Windows.Forms.Label
    Private WithEvents soggy As System.Windows.Forms.RadioButton
    Private WithEvents addFlapjacks As System.Windows.Forms.Button
    Private WithEvents addLumberjack As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents line As System.Windows.Forms.ListBox
    Private WithEvents customerName As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
