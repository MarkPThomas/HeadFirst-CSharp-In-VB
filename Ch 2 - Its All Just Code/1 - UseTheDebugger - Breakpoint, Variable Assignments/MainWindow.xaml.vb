Option Strict On
Option Explicit On

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim number As Integer = 15
        number = number + 10
        number = 36 * 15
        number = CInt(12 - (42 / 7))
        number += 10
        number *= 3
        number = CInt(71 / 3)

        Dim count As Integer = 0
        count += 1
        count -= 1

        Dim result As String = "hello"
        result &= " again " & result
        Console.WriteLine(result)
        result = "the value is: " & count
        result = ""

        For index = 1 To 10

        Next

        If True Then

        End If

    End Sub
End Class
