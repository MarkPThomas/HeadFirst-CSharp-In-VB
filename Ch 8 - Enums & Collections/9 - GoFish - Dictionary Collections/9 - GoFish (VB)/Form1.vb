Option Strict On
Option Explicit On

Public Class Form1

    Private _game As Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeNewGame()
    End Sub

    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click
        If String.IsNullOrEmpty(textName.Text) Then
            MessageBox.Show("Please enter your name", "Can't start the game yet")
        Else
            _game = New Game(textName.Text, New List(Of String) From {"Joe", "Bob"}, textProgress)
            buttonStart.Enabled = False
            textName.Enabled = False
            buttonAsk.Enabled = True
            listHand.Enabled = True
            textProgress.Text = ""
            textBooks.Text = ""

            UpdateForm()
        End If
    End Sub

    Private Sub buttonAsk_Click(sender As Object, e As EventArgs) Handles buttonAsk.Click, listHand.DoubleClick
        textProgress.Text = ""
        If listHand.SelectedIndex < 0 Then
            MessageBox.Show("Please select a card")
            Exit Sub
        End If

        If _game.PlayOneRound(listHand.SelectedIndex) Then
            textProgress.Text &= "The winner is... " & _game.GetWinnerName()
            textBooks.Text = _game.DescribeBooks()

            InitializeNewGame()
        Else
            UpdateForm()
        End If
    End Sub

    Private Sub InitializeNewGame()
        buttonStart.Enabled = True
        textName.Enabled = True

        buttonAsk.Enabled = False
        listHand.Enabled = False
    End Sub

    Private Sub UpdateForm()
        listHand.Items.Clear()
        For Each cardName As String In _game.GetPlayerCardNames()
            listHand.Items.Add(cardName)
        Next
        textBooks.Text = _game.DescribeBooks()
        textProgress.Text &= _game.DescribePlayerHands() & vbCrLf
        textProgress.SelectionStart = textProgress.Text.Length
        textProgress.ScrollToCaret()
    End Sub
End Class
