Option Strict On
Option Explicit On

Public Class DuckComparerBySize
    Implements IComparer(Of Duck)

    Public Function Compare(x As Duck, y As Duck) As Integer Implements IComparer(Of Duck).Compare
        If x.Size > y.Size Then
            Return 1
        ElseIf x.Size < y.Size Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
