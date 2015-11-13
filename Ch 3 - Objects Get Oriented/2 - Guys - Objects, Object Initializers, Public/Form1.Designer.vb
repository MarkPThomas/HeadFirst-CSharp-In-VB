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
        Me.bobGivesToJoe = New System.Windows.Forms.Button()
        Me.joeGivesToBob = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.bankCashLabel = New System.Windows.Forms.Label()
        Me.bobsCashLabel = New System.Windows.Forms.Label()
        Me.joesCashLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bobGivesToJoe
        '
        Me.bobGivesToJoe.Location = New System.Drawing.Point(93, 136)
        Me.bobGivesToJoe.Name = "bobGivesToJoe"
        Me.bobGivesToJoe.Size = New System.Drawing.Size(75, 37)
        Me.bobGivesToJoe.TabIndex = 13
        Me.bobGivesToJoe.Text = "Bob gives $5 to Joe"
        Me.bobGivesToJoe.UseVisualStyleBackColor = True
        '
        'joeGivesToBob
        '
        Me.joeGivesToBob.Location = New System.Drawing.Point(12, 136)
        Me.joeGivesToBob.Name = "joeGivesToBob"
        Me.joeGivesToBob.Size = New System.Drawing.Size(75, 37)
        Me.joeGivesToBob.TabIndex = 12
        Me.joeGivesToBob.Text = "Joe gives $10 to  Bob"
        Me.joeGivesToBob.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(93, 93)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 37)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Receive $5 from Bob"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 93)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 37)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Give $10 to Joe"
        Me.button1.UseVisualStyleBackColor = True
        '
        'bankCashLabel
        '
        Me.bankCashLabel.AutoSize = True
        Me.bankCashLabel.Location = New System.Drawing.Point(12, 65)
        Me.bankCashLabel.Name = "bankCashLabel"
        Me.bankCashLabel.Size = New System.Drawing.Size(35, 13)
        Me.bankCashLabel.TabIndex = 9
        Me.bankCashLabel.Text = "label3"
        '
        'bobsCashLabel
        '
        Me.bobsCashLabel.AutoSize = True
        Me.bobsCashLabel.Location = New System.Drawing.Point(12, 40)
        Me.bobsCashLabel.Name = "bobsCashLabel"
        Me.bobsCashLabel.Size = New System.Drawing.Size(35, 13)
        Me.bobsCashLabel.TabIndex = 8
        Me.bobsCashLabel.Text = "label2"
        '
        'joesCashLabel
        '
        Me.joesCashLabel.AutoSize = True
        Me.joesCashLabel.Location = New System.Drawing.Point(12, 9)
        Me.joesCashLabel.Name = "joesCashLabel"
        Me.joesCashLabel.Size = New System.Drawing.Size(35, 13)
        Me.joesCashLabel.TabIndex = 7
        Me.joesCashLabel.Text = "label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 188)
        Me.Controls.Add(Me.bobGivesToJoe)
        Me.Controls.Add(Me.joeGivesToBob)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.bankCashLabel)
        Me.Controls.Add(Me.bobsCashLabel)
        Me.Controls.Add(Me.joesCashLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents bobGivesToJoe As Button
    Private WithEvents joeGivesToBob As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents bankCashLabel As Label
    Private WithEvents bobsCashLabel As Label
    Private WithEvents joesCashLabel As Label
End Class
