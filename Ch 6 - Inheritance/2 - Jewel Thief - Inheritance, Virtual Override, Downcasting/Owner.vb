Option Explicit On
Option Strict On

Public Class Owner
    Private returnedContents As Jewels

    Public Sub ReceiveContents(ByVal safeContents As Jewels)
        returnedContents = safeContents
        Console.WriteLine("Thank you for returning my jewels! " & returnedContents.Sparkle)
    End Sub
End Class
