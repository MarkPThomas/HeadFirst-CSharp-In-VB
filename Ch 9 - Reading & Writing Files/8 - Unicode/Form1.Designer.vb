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
        Me.button1 = New System.Windows.Forms.Button()
        Me.writeInHebrew = New System.Windows.Forms.Button()
        Me.bytesAsHexNumbers = New System.Windows.Forms.Button()
        Me.writeEureka = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 90)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(196, 23)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Write All To File and Read As Binary"
        Me.button1.UseVisualStyleBackColor = True
        '
        'writeInHebrew
        '
        Me.writeInHebrew.Location = New System.Drawing.Point(12, 61)
        Me.writeInHebrew.Name = "writeInHebrew"
        Me.writeInHebrew.Size = New System.Drawing.Size(181, 23)
        Me.writeInHebrew.TabIndex = 7
        Me.writeInHebrew.Text = "Write Eureka in Hebrew"
        Me.writeInHebrew.UseVisualStyleBackColor = True
        '
        'bytesAsHexNumbers
        '
        Me.bytesAsHexNumbers.Location = New System.Drawing.Point(12, 32)
        Me.bytesAsHexNumbers.Name = "bytesAsHexNumbers"
        Me.bytesAsHexNumbers.Size = New System.Drawing.Size(181, 23)
        Me.bytesAsHexNumbers.TabIndex = 6
        Me.bytesAsHexNumbers.Text = "Write Eureka Displayed As Hex Numbers"
        Me.bytesAsHexNumbers.UseVisualStyleBackColor = True
        '
        'writeEureka
        '
        Me.writeEureka.Location = New System.Drawing.Point(12, 3)
        Me.writeEureka.Name = "writeEureka"
        Me.writeEureka.Size = New System.Drawing.Size(181, 23)
        Me.writeEureka.TabIndex = 5
        Me.writeEureka.Text = "Write Eureka Displayed in Bytes"
        Me.writeEureka.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.writeInHebrew)
        Me.Controls.Add(Me.bytesAsHexNumbers)
        Me.Controls.Add(Me.writeEureka)
        Me.Name = "Form1"
        Me.Text = "Unicode"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button1 As Button
    Private WithEvents writeInHebrew As Button
    Private WithEvents bytesAsHexNumbers As Button
    Private WithEvents writeEureka As Button
End Class
