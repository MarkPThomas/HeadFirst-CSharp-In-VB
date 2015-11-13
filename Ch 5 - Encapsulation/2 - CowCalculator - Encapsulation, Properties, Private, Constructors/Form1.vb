Option Strict On
Option Explicit On

Public Class Form1
    Dim farmer As New Farmer()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        farmer = New Farmer(15, 30)
    End Sub

    Private Sub numericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown1.ValueChanged
        farmer.NumberOfCows = CInt(numericUpDown1.Value)
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Console.WriteLine("I need {0} bags of feed for {1} cows",
                          farmer.BagsOfFeed, farmer.NumberOfCows)
    End Sub
End Class
