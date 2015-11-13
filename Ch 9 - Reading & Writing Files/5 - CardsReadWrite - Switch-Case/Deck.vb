Option Strict On
Option Explicit On

Imports System.IO

Public Class Deck
    Private _cards As New List(Of Card)
    Private _random As New Random

    Public ReadOnly Property Count() As Integer
        Get
            Return _cards.Count
        End Get
    End Property


    Public Sub New()
        _cards = New List(Of Card)

        For suit = 0 To 3
            For value = 1 To 13
                _cards.Add(New Card(CType(suit, Suits), CType(value, Values)))
            Next
        Next
    End Sub
    Public Sub New(initialCards As IEnumerable(Of Card))
        _cards = New List(Of Card)(initialCards)
    End Sub
    Public Sub New(ByVal fileName As String)
        _cards = New List(Of Card)
        Using reader As New StreamReader(fileName)
            While Not reader.EndOfStream
                Dim invalidCard As Boolean = False
                Dim nextCard As String = reader.ReadLine
                Dim cardParts() As String = nextCard.Split(New Char() {Chr(32)})    'Chr(32) is the space character

                Dim value As Values = Values.Ace
                Select Case cardParts(0)
                    Case "Ace" : value = Values.Ace
                    Case "Two" : value = Values.Two
                    Case "Three" : value = Values.Three
                    Case "Four" : value = Values.Four
                    Case "Five" : value = Values.Five
                    Case "Six" : value = Values.Six
                    Case "Seven" : value = Values.Seven
                    Case "Eight" : value = Values.Eight
                    Case "Nine" : value = Values.Nine
                    Case "Ten" : value = Values.Ten
                    Case "Jack" : value = Values.Jack
                    Case "Queen" : value = Values.Queen
                    Case "King" : value = Values.King
                    Case Else : invalidCard = True
                End Select

                Dim suit As Suits = Suits.Clubs
                Select Case cardParts(2)
                    Case "Spades" : suit = Suits.Spades
                    Case "Clubs" : suit = Suits.Clubs
                    Case "Hearts" : suit = Suits.Hearts
                    Case "Diamonds" : suit = Suits.Diamonds
                    Case Else : invalidCard = True
                End Select

                If Not invalidCard Then _cards.Add(New Card(suit, value))
            End While
        End Using
    End Sub


    Public Sub Add(cardToAdd As Card)
        _cards.Add(cardToAdd)
    End Sub

    Public Overloads Function Deal() As Card
        Return Deal(0)
    End Function
    Public Overloads Function Deal(index As Integer) As Card
        If (index >= 0 AndAlso index < _cards.Count) Then
            Dim CardToDeal As Card = _cards(index)
            _cards.RemoveAt(index)
            Return CardToDeal
        Else
            Return Nothing
        End If
    End Function

    Public Sub Shuffle()
        Dim shuffledCards As New List(Of Card)

        While _cards.Count > 0
            Dim drawnCard As Card = Deal(_random.Next(_cards.Count))
            shuffledCards.Add(drawnCard)
        End While

        _cards = shuffledCards
    End Sub

    Public Function GetCardNames() As IEnumerable(Of String)
        Dim CardNames(_cards.Count - 1) As String

        For i = 0 To _cards.Count - 1
            CardNames(i) = _cards(i).Name
        Next

        Return CardNames
    End Function

    Public Sub Sort()
        _cards.Sort(New CardComparer_bySuit())
    End Sub

    Public Function Peek(cardNumber As Integer) As Card
        Return _cards(cardNumber)
    End Function

    Public Function ContainsValue(value As Values) As Boolean
        For Each card As Card In _cards
            If card.Value = value Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function PullOutValues(value As Values) As Deck
        Dim deckToReturn As New Deck(New Card() {})

        For i = _cards.Count - 1 To 0 Step -1
            If _cards(i).Value = value Then
                deckToReturn.Add(Deal(i))
            End If
        Next

        Return deckToReturn
    End Function

    Public Function HasBook(value As Values) As Boolean
        Dim numberOfCards As Integer = 0

        For Each card As Card In _cards
            If card.Value = value Then numberOfCards += 1
        Next

        If numberOfCards = 4 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SortByValue()
        _cards.Sort(New CardComparer_byValue())
    End Sub
End Class
