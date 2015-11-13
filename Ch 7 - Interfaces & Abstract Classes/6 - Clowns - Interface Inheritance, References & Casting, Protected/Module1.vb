Option Explicit On
Option Strict On

Module Module1

    Sub Main()
        Dim tallGuy As New TallGuy() With {.Height = 74, .Name = "Jimmy"}
        tallGuy.TalkAboutYourself()
        tallGuy.Honk()

        Dim fingersTheClown As New ScaryScary("big shoes", 14)
        Dim someFunnyClown As FunnyFunny = fingersTheClown
        Dim someOtherScaryClown As IScaryClown = DirectCast(someFunnyClown, ScaryScary)

        'Maintains `Honk` method though IScaryClown inheriting from IClown
        someOtherScaryClown.Honk()

        Console.WriteLine(someOtherScaryClown.ScaryThingIHave)
        someOtherScaryClown.ScareLittleChildren()

        Console.ReadKey()
    End Sub

End Module
