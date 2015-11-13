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
        Me.report = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.workerBeeJob = New System.Windows.Forms.ComboBox()
        Me.assignJob = New System.Windows.Forms.Button()
        Me.shifts = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.nextShift = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.shifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'report
        '
        Me.report.Location = New System.Drawing.Point(12, 119)
        Me.report.Multiline = True
        Me.report.Name = "report"
        Me.report.Size = New System.Drawing.Size(383, 172)
        Me.report.TabIndex = 11
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.workerBeeJob)
        Me.groupBox1.Controls.Add(Me.assignJob)
        Me.groupBox1.Controls.Add(Me.shifts)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(253, 100)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Worker Bee Assignments"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(6, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Job"
        '
        'workerBeeJob
        '
        Me.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.workerBeeJob.FormattingEnabled = True
        Me.workerBeeJob.Items.AddRange(New Object() {"Nectar Collector", "Honey Manufacturing", "Egg Care", "Baby Bee Tutoring", "Hive Maintenance", "Sting Patrol"})
        Me.workerBeeJob.Location = New System.Drawing.Point(6, 32)
        Me.workerBeeJob.Name = "workerBeeJob"
        Me.workerBeeJob.Size = New System.Drawing.Size(162, 21)
        Me.workerBeeJob.TabIndex = 3
        '
        'assignJob
        '
        Me.assignJob.Location = New System.Drawing.Point(6, 59)
        Me.assignJob.Name = "assignJob"
        Me.assignJob.Size = New System.Drawing.Size(235, 23)
        Me.assignJob.TabIndex = 5
        Me.assignJob.Text = "Assign this Job to a Bee"
        Me.assignJob.UseVisualStyleBackColor = True
        '
        'shifts
        '
        Me.shifts.Location = New System.Drawing.Point(174, 33)
        Me.shifts.Name = "shifts"
        Me.shifts.Size = New System.Drawing.Size(69, 20)
        Me.shifts.TabIndex = 4
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(171, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Shifts"
        '
        'nextShift
        '
        Me.nextShift.Location = New System.Drawing.Point(271, 13)
        Me.nextShift.Name = "nextShift"
        Me.nextShift.Size = New System.Drawing.Size(127, 100)
        Me.nextShift.TabIndex = 9
        Me.nextShift.Text = "Work the Next Shift"
        Me.nextShift.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 299)
        Me.Controls.Add(Me.report)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.nextShift)
        Me.Name = "Form1"
        Me.Text = "Beehive Management System"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.shifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents report As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents workerBeeJob As ComboBox
    Private WithEvents assignJob As Button
    Private WithEvents shifts As NumericUpDown
    Private WithEvents label3 As Label
    Private WithEvents nextShift As Button
End Class
