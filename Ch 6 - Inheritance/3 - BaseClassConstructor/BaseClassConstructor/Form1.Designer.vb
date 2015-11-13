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
        Me.btnSubClass = New System.Windows.Forms.Button()
        Me.btnBaseClass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubClass
        '
        Me.btnSubClass.Location = New System.Drawing.Point(12, 41)
        Me.btnSubClass.Name = "btnSubClass"
        Me.btnSubClass.Size = New System.Drawing.Size(75, 23)
        Me.btnSubClass.TabIndex = 3
        Me.btnSubClass.Text = "Sub Class"
        Me.btnSubClass.UseVisualStyleBackColor = True
        '
        'btnBaseClass
        '
        Me.btnBaseClass.Location = New System.Drawing.Point(12, 12)
        Me.btnBaseClass.Name = "btnBaseClass"
        Me.btnBaseClass.Size = New System.Drawing.Size(75, 23)
        Me.btnBaseClass.TabIndex = 2
        Me.btnBaseClass.Text = "Base Class"
        Me.btnBaseClass.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 80)
        Me.Controls.Add(Me.btnSubClass)
        Me.Controls.Add(Me.btnBaseClass)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSubClass As Button
    Private WithEvents btnBaseClass As Button
End Class
