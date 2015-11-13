Option Explicit On
Option Strict On
Imports Clowns

Public Class ScaryScary
    Inherits FunnyFunny
    Implements IScaryClown

    Private _numberOfScaryThings As Integer

    Public ReadOnly Property ScaryThingIHave As String Implements IScaryClown.ScaryThingIHave
        Get
            Return "I have " & _numberOfScaryThings & " spiders"
        End Get
    End Property

    Public Sub New(ByVal funnyThingIHave As String,
                   ByVal numberOfScaryThings As Integer)
        MyBase.New(funnyThingIHave)
        _numberOfScaryThings = numberOfScaryThings
    End Sub

    Public Sub ScareLittleChildren() Implements IScaryClown.ScareLittleChildren
        ' Would need `this.funnyThingIHave` if it were `Private` instead of `Protected`
        Console.WriteLine("You can't have my " & _funnyThingIHave)
    End Sub
End Class
