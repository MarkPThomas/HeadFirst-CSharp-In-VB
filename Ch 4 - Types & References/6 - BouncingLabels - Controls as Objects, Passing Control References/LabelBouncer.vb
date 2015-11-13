Option Strict On
Option Explicit On

Public Class LabelBouncer
    Public MyLabel As Label
    Public GoingForward As Boolean = True

    Public Sub Move()
        If Not IsNothing(MyLabel) Then
            If GoingForward Then
                MyLabel.Left += 5
                If MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width Then
                    GoingForward = False
                End If
            Else
                MyLabel.Left -= 5
                If MyLabel.Left <= 0 Then
                    GoingForward = True
                End If
            End If
        End If
    End Sub

End Class
