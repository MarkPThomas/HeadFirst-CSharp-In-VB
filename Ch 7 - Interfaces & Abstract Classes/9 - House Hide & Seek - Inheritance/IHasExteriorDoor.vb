Option Explicit On
Option Strict On

Public Interface IHasExteriorDoor
    ReadOnly Property DoorDescription As String

    Property DoorLocation As Location
End Interface
