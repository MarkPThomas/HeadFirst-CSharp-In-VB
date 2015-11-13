Option Explicit On
Option Strict On
Imports House

Public Class OutsideWithDoor
    Inherits Outside
    Implements IHasExteriorDoor

    Private _doorDescription As String
    Public Property DoorDescription As String Implements IHasExteriorDoor.DoorDescription
        Get
            Return _doorDescription
        End Get
        Private Set(value As String)
            _doorDescription = value
        End Set
    End Property

    Public Property DoorLocation As Location Implements IHasExteriorDoor.DoorLocation

    Public Overrides ReadOnly Property Description As String
        Get
            Return MyBase.Description & " You see " & DoorDescription & "."
        End Get
    End Property

    Public Sub New(ByVal name As String,
                   ByVal hot As Boolean,
                   ByVal doorDescription As String)
        MyBase.New(name, hot)
        Me.DoorDescription = doorDescription
    End Sub

End Class
