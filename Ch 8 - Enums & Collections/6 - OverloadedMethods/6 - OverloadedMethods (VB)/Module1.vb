Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim cardToCheck As Card = New Card(Suits.Clubs, Values.Three)
        Dim doesItMatch As Boolean = Card.DoesCardMatch(cardToCheck, Suits.Hearts)
        Console.WriteLine(doesItMatch)

        Console.ReadKey()
    End Sub

End Module
