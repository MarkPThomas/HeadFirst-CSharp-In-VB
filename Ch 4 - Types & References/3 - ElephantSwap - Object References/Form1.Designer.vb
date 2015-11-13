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
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.btnLucinda = New System.Windows.Forms.Button()
        Me.btnLloyd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(11, 99)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 7
        Me.button1.Text = "Break it!"
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(11, 70)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(75, 23)
        Me.btnSwap.TabIndex = 6
        Me.btnSwap.Text = "Swap!"
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'btnLucinda
        '
        Me.btnLucinda.Location = New System.Drawing.Point(11, 41)
        Me.btnLucinda.Name = "btnLucinda"
        Me.btnLucinda.Size = New System.Drawing.Size(75, 23)
        Me.btnLucinda.TabIndex = 5
        Me.btnLucinda.Text = "Lucinda"
        Me.btnLucinda.UseVisualStyleBackColor = True
        '
        'btnLloyd
        '
        Me.btnLloyd.Location = New System.Drawing.Point(12, 12)
        Me.btnLloyd.Name = "btnLloyd"
        Me.btnLloyd.Size = New System.Drawing.Size(75, 23)
        Me.btnLloyd.TabIndex = 4
        Me.btnLloyd.Text = "Lloyd"
        Me.btnLloyd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 140)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.btnLucinda)
        Me.Controls.Add(Me.btnLloyd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Swap"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents btnSwap As Button
    Private WithEvents btnLucinda As Button
    Private WithEvents btnLloyd As Button
End Class
