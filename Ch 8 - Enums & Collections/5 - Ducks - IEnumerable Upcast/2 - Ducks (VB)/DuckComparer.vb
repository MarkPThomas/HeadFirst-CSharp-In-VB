Option Strict On
Option Explicit On

Public Class DuckComparer
    Implements IComparer(Of Duck)

    Public SortBy As SortCriteria = SortCriteria.SizeThenKind

    Public Function Compare(x As Duck, y As Duck) As Integer Implements IComparer(Of Duck).Compare
        If SortBy = SortCriteria.SizeThenKind Then
            If x.Size > y.Size Then
                Return 1
            ElseIf x.Size < y.Size Then
                Return -1
            Else
                If x.Kind > y.Kind Then
                    Return 1
                ElseIf x.Kind < y.Kind Then
                    Return -1
                Else
                    Return 0
                End If
            End If
        Else
            If x.Kind > y.Kind Then
                Return 1
            ElseIf x.Kind < y.Kind Then
                Return -1
            Else
                If x.Size > y.Size Then
                    Return 1
                ElseIf x.Size < y.Size Then
                    Return -1
                Else
                    Return 0
                End If
            End If
        End If

    End Function
End Class
