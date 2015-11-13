Option Strict On
Option Explicit On

Public Class Form1
    Private Sub changeText_Click(sender As Object, e As EventArgs) Handles changeText.Click
        If enableCheckbox.Checked Then
            If labelToChange.Text = "Right" Then
                labelToChange.Text = "Left"
                labelToChange.TextAlign = ContentAlignment.MiddleLeft
            Else
                labelToChange.Text = "Right"
                labelToChange.TextAlign = ContentAlignment.MiddleRight
            End If
        Else
            labelToChange.Text = "Text changing is disabled"
            labelToChange.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

End Class
