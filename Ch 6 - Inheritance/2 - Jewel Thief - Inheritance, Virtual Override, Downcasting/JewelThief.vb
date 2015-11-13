Option Explicit On
Option Strict On

Public Class JewelThief
    Inherits Locksmith

    Private stolenJewels As Jewels = Nothing

    Public Overrides Sub ReturnContents(ByVal safeContents As Jewels,
                                        ByVal owner As Owner)
        stolenJewels = safeContents
        Console.WriteLine("I'm stealing the contents! " & stolenJewels.Sparkle())
    End Sub
End Class
