Option Strict On
Option Explicit On

Public Class Stats
    Public Total As Integer = 0
    Public Missed As Integer = 0
    Public Correct As Integer = 0
    Public Accuracy As Integer = 0

    Public Sub Update(ByVal correctKey As Boolean)
        Total += 1

        If Not correctKey Then
            Missed += 1
        Else
            Correct += 1
        End If

        Accuracy = CInt(100 * Correct / Total)
    End Sub
End Class
