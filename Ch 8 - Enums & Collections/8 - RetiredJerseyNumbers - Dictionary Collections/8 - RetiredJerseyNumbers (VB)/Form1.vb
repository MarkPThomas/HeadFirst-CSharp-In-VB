Option Strict On
Option Explicit On

Public Class Form1
    Private retiredNumbers As New Dictionary(Of Integer, JerseyNumber) From {
            {3, New JerseyNumber("Babe Ruth", 1948)},
            {4, New JerseyNumber("Lou Gehrig", 1939)},
            {5, New JerseyNumber("Joe DiMaggio", 1952)},
            {7, New JerseyNumber("Mickey Mantle", 1969)},
            {8, New JerseyNumber("Yogi Berra", 1972)},
            {10, New JerseyNumber("Phil Rizzuto", 1985)},
            {23, New JerseyNumber("Don Mattingly", 1997)},
            {42, New JerseyNumber("Jackie Robinson", 1993)},
            {44, New JerseyNumber("Reggie Jackson", 1993)}
        }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameLabel.Text = ""
        yearLabel.Text = ""

        For Each key As Integer In retiredNumbers.Keys
            number.Items.Add(key)
        Next
    End Sub

    Private Sub number_SelectedIndexChanged(sender As Object, e As EventArgs) Handles number.SelectedIndexChanged
        Dim jerseyNumber As JerseyNumber = retiredNumbers(CType(number.SelectedItem, Integer))
        nameLabel.Text = jerseyNumber.Player
        yearLabel.Text = jerseyNumber.YearRetired.ToString()
    End Sub
End Class
