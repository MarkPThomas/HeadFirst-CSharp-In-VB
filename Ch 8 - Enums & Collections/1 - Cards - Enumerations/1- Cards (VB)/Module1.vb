Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim random As New Random()
        Dim cards As New List(Of Card)
        Dim numberOfRandomCards As Integer = 10

        For i = 0 To numberOfRandomCards - 1
            Dim numberBetween0And3 As Integer = random.Next(4)
            Dim numberBetween1And13 As Integer = random.Next(1, 14)
            Dim card As New Card(CType(numberBetween0And3, Suits), CType(numberBetween1And13, Values))

            cards.Add(card)
        Next

        Console.WriteLine(numberOfRandomCards & " random cards: ")
        For Each cardItem As Card In cards
            Console.WriteLine(cardItem.Name)
        Next

        Console.ReadKey()
    End Sub

End Module
