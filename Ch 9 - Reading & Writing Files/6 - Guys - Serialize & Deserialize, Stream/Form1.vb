﻿Option Strict On
Option Explicit On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Dim joe As Guy
    Dim bob As Guy
    Dim bank As Integer = 100

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        joe = New Guy() With {.Cash = 50, .Name = "Joe"}
        bob = New Guy() With {.Cash = 50, .Name = "Bob"}

        UpdateForm()
    End Sub

    Public Sub UpdateForm()
        joesCashLabel.Text = joe.Name & " has $" & joe.Cash
        bobsCashLabel.Text = bob.Name & " has $" & bob.Cash
        bankCashLabel.Text = "The bank has $" & bank
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If bank >= 10 Then
            bank -= joe.ReceiveCash(10)
            UpdateForm()
        Else
            MessageBox.Show("The bank is out of money")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        bank += bob.GiveCash(5)
        UpdateForm()
    End Sub

    Private Sub joeGivesToBob_Click(sender As Object, e As EventArgs) Handles joeGivesToBob.Click
        bob.ReceiveCash(joe.GiveCash(10))
        UpdateForm()
    End Sub

    Private Sub bobGivesToJoe_Click(sender As Object, e As EventArgs) Handles bobGivesToJoe.Click
        joe.ReceiveCash(bob.GiveCash(5))
        UpdateForm()
    End Sub

    Private Sub saveJoe_Click(sender As Object, e As EventArgs) Handles saveJoe.Click
        Using output As Stream = File.Create("Guy_File.dat")
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(output, joe)
        End Using
    End Sub

    Private Sub loadJoe_Click(sender As Object, e As EventArgs) Handles loadJoe.Click
        Using input As Stream = File.OpenRead("Guy_File.dat")
            Dim formatter As New BinaryFormatter()
            joe = DirectCast(formatter.Deserialize(input), Guy)
        End Using
        UpdateForm()
    End Sub
End Class
