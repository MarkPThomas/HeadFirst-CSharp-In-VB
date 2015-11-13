Option Explicit On
Option Strict On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Dim random As New Random()
    Private Const fileDeck1 As String = "Deck1.dat"
    Private Const fileDeck2 As String = "Deck2.dat"
    Private Const fileThreeClubs As String = "three-c.dat"
    Private Const fileSixHearts As String = "six-h.dat"
    Private Const fileKingSpades As String = "king-s.dat"

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
        Using output As Stream = File.Create(fileDeck1)
            Dim bf As New BinaryFormatter()
            bf.Serialize(output, deckToWrite)
        End Using
        DealCards(deckToWrite, "What I just wrote to the file:")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Using input As Stream = File.OpenRead(fileDeck1)
            Dim bf As New BinaryFormatter()
            Dim deckFromFile As Deck = CType(bf.Deserialize(input), Deck)
            DealCards(deckFromFile, "What I read from the file:")
        End Using
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Using output As Stream = File.Create(fileDeck2)
            Dim bf As New BinaryFormatter()
            For i = 0 To 5
                Dim deckToWrite As Deck = RandomDeck(random.Next(1, 10))
                bf.Serialize(output, deckToWrite)
                DealCards(deckToWrite, "Deck #" & i & " written:")
            Next
        End Using
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Using input As Stream = File.OpenRead(fileDeck2)
            Dim bf As New BinaryFormatter()
            For i = 0 To 5
                Dim deckToRead As Deck = CType(bf.Deserialize(input), Deck)
                DealCards(deckToRead, "Deck #" & i & " read:")
            Next
        End Using
    End Sub

    Private Sub serializeThreeOfClubs_Click(sender As Object, e As EventArgs) Handles serializeThreeOfClubs.Click
        Dim threeClubs As New Card(Suits.Clubs, Values.Three)

        Using output As Stream = File.Create(fileThreeClubs)
            Dim bf As New BinaryFormatter()
            bf.Serialize(output, threeClubs)
        End Using
    End Sub

    Private Sub serializeSixOfHearts_Click(sender As Object, e As EventArgs) Handles serializeSixOfHearts.Click
        Dim sixHearts As New Card(Suits.Hearts, Values.Six)

        Using output As Stream = File.Create(fileSixHearts)
            Dim bf As New BinaryFormatter()
            bf.Serialize(output, sixHearts)
        End Using
    End Sub

    Private Sub compareBinary_Click(sender As Object, e As EventArgs) Handles compareBinary.Click
        Dim firstFile() As Byte = File.ReadAllBytes(fileThreeClubs)
        Dim secondFile() As Byte = File.ReadAllBytes(fileSixHearts)
        For i = 0 To firstFile.Length - 1
            If Not firstFile(i) = secondFile(i) Then
                Console.WriteLine("Byte #{0}: {1} versues {2}",
                                  i, firstFile(i), secondFile(i))
            End If
        Next
    End Sub

    Private Sub binaryKingOfSpades_Click(sender As Object, e As EventArgs) Handles binaryKingOfSpades.Click
        Dim firstFile() As Byte = File.ReadAllBytes(fileThreeClubs)
        Dim secondFile() As Byte = File.ReadAllBytes(fileSixHearts)

        ' First byte that differed in method "compareBinary"
        firstFile(283) = CType(Suits.Spades, Byte)

        ' Second byte that differed in method "compareBinary"
        firstFile(343) = CType(Values.King, Byte)

        File.Delete(fileKingSpades)
        File.WriteAllBytes(fileKingSpades, firstFile)

        Using input As Stream = File.OpenRead(fileKingSpades)
            Dim bf As New BinaryFormatter()
            Dim cardToRead As Card = DirectCast(bf.Deserialize(input), Card)
            Console.WriteLine("Card {0}", cardToRead.Name)
        End Using
    End Sub
End Class