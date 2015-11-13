Option Explicit On
Option Strict On

Public Class Locksmith
    Private writtenDownCombination As String = ""

    Public Sub WriteDownCombination(ByVal combination As String)
        writtenDownCombination = combination
    End Sub

    Public Sub OpenSafe(ByVal safe As Safe,
                        ByVal owner As Owner)
        safe.PickLock(Me)
        Dim safeContents As Jewels = safe.Open(writtenDownCombination)
        ReturnContents(safeContents, owner)
    End Sub

    Public Overridable Sub ReturnContents(ByVal safeContents As Jewels,
                                          ByVal owner As Owner)
        owner.ReceiveContents(safeContents)
    End Sub
End Class
