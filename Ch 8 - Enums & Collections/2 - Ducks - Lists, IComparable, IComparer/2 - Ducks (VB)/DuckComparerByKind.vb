Option Strict On
Option Explicit On

Public Class DuckComparerByKind
    Implements IComparer(Of Duck)


    Public Function Compare(x As Duck, y As Duck) As Integer Implements IComparer(Of Duck).Compare
        If x.Kind > y.Kind Then
            Return 1
        ElseIf x.Kind < y.Kind Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
