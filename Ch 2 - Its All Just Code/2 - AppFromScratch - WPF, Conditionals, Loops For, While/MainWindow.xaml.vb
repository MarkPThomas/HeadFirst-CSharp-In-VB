Option Strict On
Option Explicit On

Class MainWindow
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs)
        Dim name As String = "Quentin"

        Dim x As Integer = 3
        x = x * 17

        Dim d As Double = Math.PI / 2
        myLabel.Text = "name is" & name & vbCrLf &
                        "x is " & x & vbCrLf &
                        "d is " & d
    End Sub


    Private Sub button2_Click(sender As Object, e As RoutedEventArgs)
        Dim x As Integer = 5
        If x = 10 Then
            myLabel.Text = "x must be 10"
        Else
            myLabel.Text = "x isn't 10"
        End If
    End Sub

    Private Sub button3_Click(sender As Object, e As RoutedEventArgs)
        Dim someValue As Integer = 4
        Dim name As String = "Bobbo Jr."

        If (someValue = 3 AndAlso name = "Joe") Then
            myLabel.Text = "x is 3 and the name is Joe"
        End If
    End Sub


    Private Sub button4_Click(sender As Object, e As RoutedEventArgs)
        Dim count As Integer = 0

        While count < 10
            count = count + 1
        End While

        For i = 0 To 4
            count = count - 1
        Next

        myLabel.Text = "The answer is " & count
    End Sub
End Class
