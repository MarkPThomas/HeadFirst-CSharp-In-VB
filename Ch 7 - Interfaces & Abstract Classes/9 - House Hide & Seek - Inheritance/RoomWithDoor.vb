Option Explicit On
Option Strict On

Public Class RoomWithDoor
    Inherits RoomWithHidingPlace
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

    Public Sub New(ByVal name As String,
                   ByVal decoration As String,
                   ByVal doorDescription As String,
                   ByVal hidingPlaceName As String)
        MyBase.New(name, decoration, hidingPlaceName)
        Me.DoorDescription = doorDescription
    End Sub
End Class
