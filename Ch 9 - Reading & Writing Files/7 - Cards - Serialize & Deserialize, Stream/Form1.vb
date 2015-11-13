Option Explicit On
Option Strict On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Dim random As New Random()

    Private Function RandomDeck(ByVal number As Integer) As Deck
        Dim myDeck As New Deck(New Card() {})

        For i = 0 To number - 1
            myDeck.Add(New Card(
                       CType(random.Next(4), Suits),
                       CType(random.Next(1, 14), Values)))
        Next

        Return myDeck
    End Function

    Private Sub DealCards(ByVal deckToDeal As Deck,
                          ByVal title As String)
        Console.WriteLine(title)
        While deckToDeal.Count > 0
            Dim nextCard As Card = deckToDeal.Deal(0)
            Console.WriteLine(nextCard.Name)
        End While
        Console.WriteLine("------------------")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim deckToWrite As Deck = RandomDeck(5)
        Using output As Stream = File.Create("Deck1.dat")
            Dim bf As New BinaryFormatter()
            bf.Serialize(output, deckToWrite)
        End Using
        DealCards(deckToWrite, "What I just wrote to the file:")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Using input As Stream = File.OpenRead("Deck1.dat")
            Dim bf As New BinaryFormatter()
            Dim deckFromFile As Deck = CType(bf.Deserialize(input), Deck)
            DealCards(deckFromFile, "What I read from the file:")
        End Using
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Using output As Stream = File.Create("Deck2.dat")
            Dim bf As New BinaryFormatter()
            For i = 0 To 5
                Dim deckToWrite As Deck = RandomDeck(random.Next(1, 10))
                bf.Serialize(output, deckToWrite)
                DealCards(deckToWrite, "Deck #" & i & " written:")
            Next
        End Using
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Using input As Stream = File.OpenRead("Deck2.dat")
            Dim bf As New BinaryFormatter()
            For i = 0 To 5
                Dim deckToRead As Deck = CType(bf.Deserialize(input), Deck)
                DealCards(deckToRead, "Deck #" & i & " read:")
            Next
        End Using
    End Sub
End Class