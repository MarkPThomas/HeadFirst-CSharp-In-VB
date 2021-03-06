﻿Option Strict On
Option Explicit On

Public Class BirthdayParty
    Inherits Party

    Public Property CakeWriting As String = ""

    Private ReadOnly Property ActualLength As Integer
        Get
            If CakeWriting.Length > MaxWritingLength() Then
                Return MaxWritingLength()
            Else
                Return CakeWriting.Length
            End If
        End Get
    End Property

    Public ReadOnly Property CakeWritingTooLong() As Boolean
        Get
            If CakeWriting.Length > MaxWritingLength() Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Overrides ReadOnly Property Cost As Decimal
        Get
            Dim totalCost As Decimal = MyBase.Cost

            Dim cakeCost As Decimal
            If CakeSize() = 8 Then
                cakeCost = 40D + ActualLength * 0.25D
            Else
                cakeCost = 75D + ActualLength * 0.25D
            End If

            Return totalCost + cakeCost
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal numberOfPeople As Integer,
                   ByVal fancyDecorations As Boolean,
                   ByVal cakeWriting As String)
        Me.NumberOfPeople = numberOfPeople
        Me.FancyDecorations = fancyDecorations
        Me.CakeWriting = cakeWriting
    End Sub

    Private Function CakeSize() As Integer
        If NumberOfPeople <= 4 Then
            Return 8
        Else
            Return 16
        End If
    End Function

    Private Function MaxWritingLength() As Integer
        If CakeSize() = 8 Then
            Return 16
        Else
            Return 40
        End If
    End Function

End Class
