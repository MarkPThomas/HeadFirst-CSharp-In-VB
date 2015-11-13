Option Explicit On
Option Strict On
Imports Clowns

Public Class FunnyFunny
    Implements IClown

    Protected _funnyThingIHave As String
    Public ReadOnly Property FunnyThingIHave As String Implements IClown.FunnyThingIHave
        Get
            Return "Hi kides! I have " & _funnyThingIHave
        End Get
    End Property

    Public Sub New(ByVal funnyThingIHave As String)
        _funnyThingIHave = funnyThingIHave
    End Sub


    Public Sub Honk() Implements IClown.Honk
        Console.WriteLine(FunnyThingIHave)
    End Sub
End Class
