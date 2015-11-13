Option Strict On
Option Explicit On

Public Class Game
    Private _players As New List(Of Player)
    Private _books As New Dictionary(Of Values, Player)
    Private _stock As Deck
    Private _textBoxOnForm As TextBox

    Public Sub New(playerName As String,
                   opponentNames As IEnumerable(Of String),
                   textBoxOnForm As TextBox)
        Dim random As New Random()
        Me._textBoxOnForm = textBoxOnForm
        _players = New List(Of Player)
        _players.Add(New Player(playerName, random, textBoxOnForm))
        _books = New Dictionary(Of Values, Player)
        _stock = New Deck()

        For Each opponentName As String In opponentNames
            _players.Add(New Player(opponentName, random, textBoxOnForm))
        Next

        Deal()
        _players(0).SortHand()
    End Sub

    Private Sub Deal()
        _stock.Shuffle()

        For Each player As Player In _players
            DrawHand(player)
            PullOutBooks(player)
        Next
    End Sub

    Private Sub DrawHand(player As Player)
        For i = 0 To Math.Min(5, _stock.Count) - 1
            player.TakeCard(_stock.Deal())
        Next
    End Sub

    Public Function PlayOneRound(selectedPlayerCard As Integer) As Boolean
        For playerIndex = 0 To _players.Count - 1
            If playerIndex = 0 Then
                ' Ask for the human player's selected value
                Dim valuePeeked As Values = _players(0).Peek(selectedPlayerCard).Value
                _players(0).AskForACard(_players, 0, _stock, valuePeeked)
            Else
                ' Other players ask for their values
                _players(playerIndex).AskForACard(_players, playerIndex, _stock)
            End If

            If PullOutBooks(_players(playerIndex)) Then
                _textBoxOnForm.Text &= _players(playerIndex).Name & " drew a new hand." & vbCrLf
                DrawHand(_players(playerIndex))
            End If

            ' Sort the human player's hand
            _players(0).SortHand()

            If _stock.Count = 0 Then
                _textBoxOnForm.Text = "The stock is out of cards. Game over!" & vbCrLf
                Return True
            End If
        Next

        Return False
    End Function

    Public Function PullOutBooks(player As Player) As Boolean
        Dim booksPulled As IEnumerable(Of Values) = player.PullOutBooks()

        For Each value As Values In booksPulled
            _books.Add(value, player)
        Next

        If player.CardCount = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DescribeBooks() As String
        Dim whoHasWhichBooks As String = ""

        For Each value As Values In _books.Keys
            Dim player As Player = _books(value)
            whoHasWhichBooks &= player.Name & " has a book of " & Card.Plural(value) & "." & vbCrLf
        Next

        Return whoHasWhichBooks
    End Function

    Public Function GetWinnerName() As String
        Dim winners As New Dictionary(Of String, Integer)

        For Each value As Values In _books.Keys
            Dim name As String = _books(value).Name
            If winners.ContainsKey(name) Then
                winners(name) += 1
            Else
                winners.Add(name, 1)
            End If
        Next

        Dim mostBooks As Integer = 0
        For Each name As String In winners.Keys
            If winners(name) > mostBooks Then mostBooks = winners(name)
        Next

        Dim tie As Boolean = False
        Dim winnerList As String = ""
        For Each name As String In winners.Keys
            If winners(name) = mostBooks Then
                If Not String.IsNullOrEmpty(winnerList) Then
                    winnerList &= " and "
                    tie = True
                End If
                winnerList &= name
            End If
        Next
        winnerList &= " with " & mostBooks & " book"
        If mostBooks > 1 Then winnerList &= "s"
        winnerList &= "."
        If tie Then
            Return "A tie between " & winnerList
        Else
            Return winnerList
        End If
    End Function

    Public Function GetPlayerCardNames() As IEnumerable(Of String)
        Return _players(0).GetCardNames()
    End Function

    Public Function DescribePlayerHands() As String
        Dim description As String = ""

        For i = 0 To _players.Count - 1
            description &= _players(i).Name & " has " & _players(i).CardCount
            If _players(i).CardCount = 1 Then
                description &= " card." & vbCrLf
            Else
                description &= " cards." & vbCrLf
            End If

        Next
        description &= "The stock has " & _stock.Count & " cards left."

        Return description
    End Function
End Class
