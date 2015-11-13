Option Strict On
Option Explicit On

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

    Public Sub Add(cardToAdd As Card)
        _cards.Add(cardToAdd)
    End Sub

    Public Function Deal(index As Integer) As Card
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
End Class
