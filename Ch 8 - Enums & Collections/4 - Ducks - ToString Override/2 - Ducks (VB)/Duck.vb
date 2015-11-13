Option Strict On
Option Explicit On

Public Class Duck
    Implements IComparable(Of Duck)

    Public Size As Integer
    Public Kind As KindsOfDucks


    Public Function CompareTo(other As Duck) As Integer Implements IComparable(Of Duck).CompareTo
        If Me.Size > other.Size Then
            Return 1
        ElseIf Me.Size < other.Size Then
            Return -1
        Else
            Return 0
        End If
    End Function

    Public Overrides Function ToString() As String
        Return "A size " & Size.ToString() & " inch " & Kind.ToString()
    End Function
End Class
