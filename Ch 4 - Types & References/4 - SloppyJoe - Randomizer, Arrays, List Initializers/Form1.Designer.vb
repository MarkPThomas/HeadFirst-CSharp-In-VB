﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(11, 131)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 13)
        Me.label6.TabIndex = 11
        Me.label6.Text = "label6"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(11, 107)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 13)
        Me.label5.TabIndex = 10
        Me.label5.Text = "label5"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(11, 84)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(35, 13)
        Me.label4.TabIndex = 9
        Me.label4.Text = "label4"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 58)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(11, 33)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 170)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Sloppy Joe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
