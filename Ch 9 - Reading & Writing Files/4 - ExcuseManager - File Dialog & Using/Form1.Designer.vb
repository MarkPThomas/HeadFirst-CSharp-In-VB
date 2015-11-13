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
        Me.fileDate = New System.Windows.Forms.Label()
        Me.randomExcuse = New System.Windows.Forms.Button()
        Me.open = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.results = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lastUsed = New System.Windows.Forms.DateTimePicker()
        Me.folder = New System.Windows.Forms.Button()
        Me.description = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fileDate
        '
        Me.fileDate.AutoEllipsis = True
        Me.fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fileDate.Location = New System.Drawing.Point(75, 87)
        Me.fileDate.Name = "fileDate"
        Me.fileDate.Size = New System.Drawing.Size(200, 23)
        Me.fileDate.TabIndex = 24
        '
        'randomExcuse
        '
        Me.randomExcuse.Location = New System.Drawing.Point(187, 118)
        Me.randomExcuse.Name = "randomExcuse"
        Me.randomExcuse.Size = New System.Drawing.Size(75, 23)
        Me.randomExcuse.TabIndex = 23
        Me.randomExcuse.Text = "Random"
        Me.randomExcuse.UseVisualStyleBackColor = True
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(130, 118)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(51, 23)
        Me.open.TabIndex = 22
        Me.open.Text = "Open"
        Me.open.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(73, 118)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(51, 23)
        Me.save.TabIndex = 21
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'results
        '
        Me.results.Location = New System.Drawing.Point(75, 34)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(200, 20)
        Me.results.TabIndex = 20
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 92)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "File Date"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 66)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(55, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Last Used"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 34)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Results"
        '
        'lastUsed
        '
        Me.lastUsed.Location = New System.Drawing.Point(75, 60)
        Me.lastUsed.Name = "lastUsed"
        Me.lastUsed.Size = New System.Drawing.Size(200, 20)
        Me.lastUsed.TabIndex = 16
        '
        'folder
        '
        Me.folder.Location = New System.Drawing.Point(16, 118)
        Me.folder.Name = "folder"
        Me.folder.Size = New System.Drawing.Size(51, 23)
        Me.folder.TabIndex = 15
        Me.folder.Text = "Folder"
        Me.folder.UseVisualStyleBackColor = True
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(75, 6)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(200, 20)
        Me.description.TabIndex = 14
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(42, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Excuse"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 153)
        Me.Controls.Add(Me.fileDate)
        Me.Controls.Add(Me.randomExcuse)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lastUsed)
        Me.Controls.Add(Me.folder)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Excuse Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents fileDate As Label
    Private WithEvents randomExcuse As Button
    Private WithEvents open As Button
    Private WithEvents save As Button
    Private WithEvents results As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents lastUsed As DateTimePicker
    Private WithEvents folder As Button
    Private WithEvents description As TextBox
    Private WithEvents label1 As Label
End Class
