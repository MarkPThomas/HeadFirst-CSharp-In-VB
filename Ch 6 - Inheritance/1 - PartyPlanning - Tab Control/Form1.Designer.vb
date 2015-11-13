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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.fancyBox = New System.Windows.Forms.CheckBox()
        Me.healthyBox = New System.Windows.Forms.CheckBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.cakeWriting = New System.Windows.Forms.TextBox()
        Me.tooLongLabel = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.birthdayCost = New System.Windows.Forms.Label()
        Me.numberBirthday = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.fancyBirthday = New System.Windows.Forms.CheckBox()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        CType(Me.numberBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(0, 1)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(168, 175)
        Me.tabControl1.TabIndex = 7
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.label1)
        Me.tabPage1.Controls.Add(Me.costLabel)
        Me.tabPage1.Controls.Add(Me.numericUpDown1)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.fancyBox)
        Me.tabPage1.Controls.Add(Me.healthyBox)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(160, 149)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Dinner Party"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Number of People"
        '
        'costLabel
        '
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.costLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costLabel.Location = New System.Drawing.Point(40, 90)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(81, 19)
        Me.costLabel.TabIndex = 5
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(6, 20)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDown1.TabIndex = 1
        Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(3, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Cost"
        '
        'fancyBox
        '
        Me.fancyBox.AutoSize = True
        Me.fancyBox.Checked = True
        Me.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fancyBox.Location = New System.Drawing.Point(6, 47)
        Me.fancyBox.Name = "fancyBox"
        Me.fancyBox.Size = New System.Drawing.Size(115, 17)
        Me.fancyBox.TabIndex = 2
        Me.fancyBox.Text = "Fancy Decorations"
        Me.fancyBox.UseVisualStyleBackColor = True
        '
        'healthyBox
        '
        Me.healthyBox.AutoSize = True
        Me.healthyBox.Location = New System.Drawing.Point(5, 70)
        Me.healthyBox.Name = "healthyBox"
        Me.healthyBox.Size = New System.Drawing.Size(93, 17)
        Me.healthyBox.TabIndex = 3
        Me.healthyBox.Text = "HealthyOption"
        Me.healthyBox.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.cakeWriting)
        Me.tabPage2.Controls.Add(Me.tooLongLabel)
        Me.tabPage2.Controls.Add(Me.label4)
        Me.tabPage2.Controls.Add(Me.label3)
        Me.tabPage2.Controls.Add(Me.birthdayCost)
        Me.tabPage2.Controls.Add(Me.numberBirthday)
        Me.tabPage2.Controls.Add(Me.label5)
        Me.tabPage2.Controls.Add(Me.fancyBirthday)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(160, 149)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Birthday Party"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'cakeWriting
        '
        Me.cakeWriting.Location = New System.Drawing.Point(7, 89)
        Me.cakeWriting.Name = "cakeWriting"
        Me.cakeWriting.Size = New System.Drawing.Size(137, 20)
        Me.cakeWriting.TabIndex = 14
        Me.cakeWriting.Text = "Happy Birthday"
        '
        'tooLongLabel
        '
        Me.tooLongLabel.AutoSize = True
        Me.tooLongLabel.BackColor = System.Drawing.Color.Red
        Me.tooLongLabel.Location = New System.Drawing.Point(81, 73)
        Me.tooLongLabel.Name = "tooLongLabel"
        Me.tooLongLabel.Size = New System.Drawing.Size(63, 13)
        Me.tooLongLabel.TabIndex = 13
        Me.tooLongLabel.Text = "TOO LONG"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(7, 73)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Cake Writing"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Number of People"
        '
        'birthdayCost
        '
        Me.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.birthdayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdayCost.Location = New System.Drawing.Point(43, 122)
        Me.birthdayCost.Name = "birthdayCost"
        Me.birthdayCost.Size = New System.Drawing.Size(81, 19)
        Me.birthdayCost.TabIndex = 11
        '
        'numberBirthday
        '
        Me.numberBirthday.Location = New System.Drawing.Point(7, 20)
        Me.numberBirthday.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numberBirthday.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numberBirthday.Name = "numberBirthday"
        Me.numberBirthday.Size = New System.Drawing.Size(120, 20)
        Me.numberBirthday.TabIndex = 7
        Me.numberBirthday.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(6, 123)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(32, 13)
        Me.label5.TabIndex = 10
        Me.label5.Text = "Cost"
        '
        'fancyBirthday
        '
        Me.fancyBirthday.AutoSize = True
        Me.fancyBirthday.Checked = True
        Me.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fancyBirthday.Location = New System.Drawing.Point(7, 47)
        Me.fancyBirthday.Name = "fancyBirthday"
        Me.fancyBirthday.Size = New System.Drawing.Size(115, 17)
        Me.fancyBirthday.TabIndex = 8
        Me.fancyBirthday.Text = "Fancy Decorations"
        Me.fancyBirthday.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(171, 179)
        Me.Controls.Add(Me.tabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Party Planner 2.0"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        CType(Me.numberBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label1 As Label
    Private WithEvents costLabel As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents fancyBox As CheckBox
    Private WithEvents healthyBox As CheckBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents cakeWriting As TextBox
    Private WithEvents tooLongLabel As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents birthdayCost As Label
    Private WithEvents numberBirthday As NumericUpDown
    Private WithEvents label5 As Label
    Private WithEvents fancyBirthday As CheckBox
End Class
