Option Explicit On
Option Strict On

Public Class Safe
    Private contents As New Jewels
    Private safeCombination As String = "12345"


    Public Function Open(ByVal writtenDownCombination As String) As Jewels
        If writtenDownCombination = safeCombination Then
            Return contents
        Else
            Return Nothing
        End If
    End Function


    Public Sub PickLock(ByVal locksmith As Locksmith)
        locksmith.WriteDownCombination(safeCombination)
    End Sub
End Class
