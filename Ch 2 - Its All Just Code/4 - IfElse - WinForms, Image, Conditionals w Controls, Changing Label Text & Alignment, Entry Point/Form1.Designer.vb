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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelToChange = New System.Windows.Forms.Label()
        Me.enableCheckbox = New System.Windows.Forms.CheckBox()
        Me.changeText = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(196, 11)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'labelToChange
        '
        Me.labelToChange.Location = New System.Drawing.Point(11, 56)
        Me.labelToChange.Name = "labelToChange"
        Me.labelToChange.Size = New System.Drawing.Size(460, 23)
        Me.labelToChange.TabIndex = 6
        Me.labelToChange.Text = "Press the button to change my text"
        Me.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enableCheckbox
        '
        Me.enableCheckbox.AutoSize = True
        Me.enableCheckbox.Location = New System.Drawing.Point(340, 11)
        Me.enableCheckbox.Name = "enableCheckbox"
        Me.enableCheckbox.Size = New System.Drawing.Size(131, 17)
        Me.enableCheckbox.TabIndex = 5
        Me.enableCheckbox.Text = "Enable label changing"
        Me.enableCheckbox.UseVisualStyleBackColor = True
        '
        'changeText
        '
        Me.changeText.Location = New System.Drawing.Point(12, 12)
        Me.changeText.Name = "changeText"
        Me.changeText.Size = New System.Drawing.Size(159, 23)
        Me.changeText.TabIndex = 4
        Me.changeText.Text = "Change the label if checked"
        Me.changeText.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 97)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.labelToChange)
        Me.Controls.Add(Me.enableCheckbox)
        Me.Controls.Add(Me.changeText)
        Me.Name = "Form1"
        Me.Text = "My Desktop App"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents labelToChange As Label
    Private WithEvents enableCheckbox As CheckBox
    Private WithEvents changeText As Button
End Class
