Option Strict On
Option Explicit On

Public Class Form1
    Dim bouncers(3) As LabelBouncer

    Private Sub ToggleBouncing(ByVal index As Integer,
                               ByVal labelToBounce As Label)
        If IsNothing(bouncers(index)) Then
            bouncers(index) = New LabelBouncer()
            bouncers(index).MyLabel = labelToBounce
        Else
            bouncers(index) = Nothing
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ToggleBouncing(0, label1)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ToggleBouncing(1, label2)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ToggleBouncing(2, label3)
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        For i = 0 To 2
            If Not IsNothing(bouncers(i)) Then
                bouncers(i).Move()
            End If
        Next
    End Sub
End Class
