Option Strict On
Option Explicit On

Public Class Form1
    Private _random As New Random
    Public deck1 As New Deck
    Public deck2 As New Deck

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetDeck(1)
        ResetDeck(2)

        RedrawDeck(1)
        RedrawDeck(2)
    End Sub

    Private Sub moveToDeck2_Click(sender As Object, e As EventArgs) Handles moveToDeck2.Click
        Dim drawnCardDeck1 As Integer = deckList1.SelectedIndex
        Dim drawnCard As Card = deck1.Deal(drawnCardDeck1)

        If Not IsNothing(drawnCard) Then
            deck2.Add(drawnCard)
            RedrawDeck(1)
            RedrawDeck(2)
        End If
    End Sub

    Private Sub moveToDeck1_Click(sender As Object, e As EventArgs) Handles moveToDeck1.Click
        Dim drawnCardDeck2 As Integer = deckList2.SelectedIndex
        Dim drawnCard As Card = deck2.Deal(drawnCardDeck2)

        If Not IsNothing(drawnCard) Then
            deck1.Add(drawnCard)
            RedrawDeck(1)
            RedrawDeck(2)
        End If
    End Sub

    Private Sub reset1_Click(sender As Object, e As EventArgs) Handles reset1.Click
        ResetDeck(1)
        RedrawDeck(1)
    End Sub

    Private Sub reset2_Click(sender As Object, e As EventArgs) Handles reset2.Click
        ResetDeck(2)
        RedrawDeck(2)
    End Sub

    Private Sub shuffle1_Click(sender As Object, e As EventArgs) Handles shuffle1.Click
        deck1.Shuffle()
        RedrawDeck(1)
    End Sub

    Private Sub shuffle2_Click(sender As Object, e As EventArgs) Handles shuffle2.Click
        deck2.Shuffle()
        RedrawDeck(2)
    End Sub

    Private Sub ResetDeck(deckNumber As Integer)
        If deckNumber = 1 Then
            Dim numberOfCards As Integer = _random.Next(1, 11)
            Dim cards As New List(Of Card)

            For i = 0 To numberOfCards - 1
                cards.Add(New Card(CType(_random.Next(4), Suits), CType(_random.Next(1, 14), Values)))
            Next
            deck1 = New Deck(cards)
            deck1.Sort()
        Else
            deck2 = New Deck()
        End If
    End Sub

    Private Sub RedrawDeck(deckNumber As Integer)
        If deckNumber = 1 Then
            deckList1.Items.Clear()
            For Each cardName As String In deck1.GetCardNames()
                deckList1.Items.Add(cardName)
            Next
            labelDeck1.Text = "Deck #1 (" & deck1.Count & " cards)"
        Else
            deckList2.Items.Clear()
            For Each cardName As String In deck2.GetCardNames()
                deckList2.Items.Add(cardName)
            Next
            labelDeck2.Text = "Deck #2 (" & deck2.Count & " cards)"
        End If
    End Sub

End Class
