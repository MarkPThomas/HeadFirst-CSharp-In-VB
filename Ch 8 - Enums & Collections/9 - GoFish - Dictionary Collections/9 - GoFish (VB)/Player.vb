Option Strict On
Option Explicit On

Public Class Player
    Private _name As String
    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Private _random As Random
    Private _cards As Deck
    Private _textBoxOnForm As TextBox

    Public ReadOnly Property CardCount() As Integer
        Get
            Return _cards.Count
        End Get
    End Property

    Public Sub New(name As String, random As Random, textBoxOnForm As TextBox)
        Me._name = name
        Me._random = random
        Me._textBoxOnForm = textBoxOnForm
        Me._cards = New Deck(New Card() {})

        _textBoxOnForm.Text &= _name + " has just joined the game." & vbCrLf
    End Sub

    Public Function PullOutBooks() As IEnumerable(Of Values)
        Dim books As New List(Of Values)

        For i = 1 To 13
            Dim value As Values = CType(i, Values)
            Dim howMany As Integer = 0

            For card = 0 To _cards.Count - 1
                If _cards.Peek(card).Value = value Then howMany += 1
            Next

            If howMany = 4 Then
                books.Add(value)
                _cards.PullOutValues(value)
            End If
        Next

        Return books
    End Function

    Public Function GetRandomValue() As Values
        Dim randomCard As Card = _cards.Peek(_random.Next(_cards.Count))
        Return randomCard.Value
    End Function

    Public Function DoYouHaveAny(value As Values) As Deck
        Dim cardsIHave As Deck = _cards.PullOutValues(value)
        _textBoxOnForm.Text &= Name & " has " & cardsIHave.Count & " " & Card.Plural(value) & "." & vbCrLf

        Return cardsIHave
    End Function

    Public Overloads Sub AskForACard(players As IEnumerable(Of Player),
                                     myIndex As Integer,
                                     stock As Deck)
        Dim _players As New List(Of Player)
        _players = CType(players, List(Of Player))

        ' Round is only played if the stock still has cards.
        If stock.Count > 0 Then
            ' Player asking must have at least one card.'Player asking must have at least one card.
            If _cards.Count = 0 Then _cards.Add(stock.Deal())
            AskForACard(players, myIndex, stock, GetRandomValue())

            ' As long as the stock still has cards after the last move, if the human player must have at least one card.
            ' This is needed for the next round to be started. Cases of the AIs running out of cards is handled when they are asking for cards, above.
            If (stock.Count > 0 AndAlso _players(0).CardCount = 0) Then
                _players(0)._cards.Add(stock.Deal())
            End If
        End If
    End Sub
    Public Overloads Sub AskForACard(players As IEnumerable(Of Player),
                                     myIndex As Integer,
                                     stock As Deck,
                                     value As Values)
        Dim _players As List(Of Player) = CType(players, List(Of Player))

        _textBoxOnForm.Text &= Name & " asks if anyone has a " & value & "." & vbCrLf

        Dim cardsAdded As Integer = 0
        For playerIndex = 0 To _players.Count - 1
            If Not playerIndex = myIndex Then
                Dim cardsGiven As Deck = _players(playerIndex).DoYouHaveAny(value)
                If cardsGiven.Count > 0 Then
                    While cardsGiven.Count > 0
                        _cards.Add(cardsGiven.Deal())
                        cardsAdded += 1
                    End While
                End If
            End If
        Next
        _textBoxOnForm.Text &= vbCrLf

        If (cardsAdded = 0 AndAlso stock.Count > 0) Then
            _textBoxOnForm.Text &= Name & " has to draw from the stock." & vbCrLf
            _cards.Add(stock.Deal())
        End If
    End Sub

    Public Sub TakeCard(card As Card)
        _cards.Add(card)
    End Sub

    Public Function GetCardNames() As IEnumerable(Of String)
        Return _cards.GetCardNames()
    End Function

    Public Function Peek(cardNumber As Integer) As Card
        Return _cards.Peek(cardNumber)
    End Function

    Public Sub SortHand()
        _cards.SortByValue()
    End Sub
End Class
