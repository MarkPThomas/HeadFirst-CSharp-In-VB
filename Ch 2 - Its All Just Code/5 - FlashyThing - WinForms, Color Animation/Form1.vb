Option Strict On
Option Explicit On


Imports System.Threading

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        While Visible
            For c = 0 To 255
                If Not Visible Then Exit For
                Me.BackColor = Color.FromArgb(c, 255 - c, c)
                Application.DoEvents()
                Thread.Sleep(3)
            Next
            For c = 255 To 0 Step -1
                If Not Visible Then Exit For
                Me.BackColor = Color.FromArgb(c, 255 - c, c)
                Application.DoEvents()
                Thread.Sleep(3)
            Next
        End While
    End Sub
End Class
