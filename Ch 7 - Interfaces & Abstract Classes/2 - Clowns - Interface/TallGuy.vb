Option Explicit On
Option Strict On

Public Class TallGuy
    Implements IClown

    Public Name As String
    Public Height As Integer

    Public ReadOnly Property FunnyThingIHave As String Implements IClown.FunnyThingIHave
        Get
            Return "big shoes"
        End Get
    End Property

    Public Sub TalkAboutYourself()
        Console.WriteLine("My name is " & Name & " and I'm " & Height & " inches tall.")
    End Sub

    Public Sub Honk() Implements IClown.Honk
        Console.WriteLine("Honk honk!")
    End Sub
End Class
