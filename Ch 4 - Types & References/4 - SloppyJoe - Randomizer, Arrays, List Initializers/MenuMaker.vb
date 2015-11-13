Option Strict On
Option Explicit On

Public Class MenuMaker
    Public randomizer As Random
    Dim Meats As String() = {"Roast Beef", "Salami", "Turkey", "Ham", "Pastrami"}
    Dim Condiments As String() = {"Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo", "Relish", "French Dressing"}
    Dim Breads As String() = {"Rye", "White", "Wheat", "Pumpernickle", "Italian Bread", "A Roll"}

    Public Function GetMenuItem() As String
        Dim randomMeat As String = Meats(randomizer.Next(Meats.Length))
        Dim randomCondiment As String = Condiments(randomizer.Next(Condiments.Length))
        Dim randomBread As String = Breads(randomizer.Next(Breads.Length))

        Return randomMeat & " with " & randomCondiment & " on " & randomBread
    End Function

End Class
