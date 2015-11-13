Option Strict On
Option Explicit On

Public Class CardComparer_byValue
    Implements IComparer(Of Card)

    Public Function Compare(x As Card, y As Card) As Integer Implements IComparer(Of Card).Compare
        If x.Value > y.Value Then
            Return 1
        ElseIf x.Value < y.Value Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
