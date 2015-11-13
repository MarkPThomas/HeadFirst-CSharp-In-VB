Option Strict On
Option Explicit On

Public Class Lumberjack
    Private _name As String
    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Private _meal As New Stack(Of Flapjack)

    Public ReadOnly Property FlapjackCount() As Integer
        Get
            Return _meal.Count
        End Get
    End Property

    Public Sub New(name As String)
        Me._name = name
    End Sub

    Public Sub TakeFlapJacks(food As Flapjack, howMany As Integer)
        For i = 0 To howMany - 1
            _meal.Push(food)
        Next
    End Sub

    Public Sub EatFlapjacks()
        Console.WriteLine(_name & "'s eating flapjacks")
        While _meal.Count > 0
            Console.WriteLine(Name & " ate a " & _meal.Pop().ToString().ToLower() & " flapjack.")
        End While

    End Sub
End Class
