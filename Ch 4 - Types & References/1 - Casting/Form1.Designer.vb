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
        Me.showInteger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'showInteger
        '
        Me.showInteger.Location = New System.Drawing.Point(12, 12)
        Me.showInteger.Name = "showInteger"
        Me.showInteger.Size = New System.Drawing.Size(126, 23)
        Me.showInteger.TabIndex = 0
        Me.showInteger.Text = "Show Integer Value"
        Me.showInteger.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 52)
        Me.Controls.Add(Me.showInteger)
        Me.Name = "Form1"
        Me.Text = "Casting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents showInteger As Button
End Class
