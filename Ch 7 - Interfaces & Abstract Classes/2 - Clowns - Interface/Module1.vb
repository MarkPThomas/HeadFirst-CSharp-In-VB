Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim tallGuy As New TallGuy() With {.Height = 74, .Name = "Jimmy"}
        tallGuy.TalkAboutYourself()
        tallGuy.Honk()

        Console.ReadKey()
    End Sub

End Module
