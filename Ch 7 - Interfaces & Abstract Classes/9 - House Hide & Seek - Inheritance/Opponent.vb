Option Explicit On
Option Strict On

Public Class Opponent
    Private myLocation As Location
    Private random As New Random()

    Public Sub New(ByVal startingLocation As Location)
        myLocation = startingLocation
    End Sub

    Public Sub Move()
        Dim hidden As Boolean = False

        While Not hidden
            If (TypeOf myLocation Is IHasExteriorDoor) Then
                Dim nextLocation As IHasExteriorDoor = TryCast(myLocation, IHasExteriorDoor)
                myLocation = nextLocation.DoorLocation
            End If

            myLocation = myLocation.Exits(random.Next(myLocation.Exits.Length))
            If (TypeOf myLocation Is IHidingPlace) Then hidden = True
        End While
    End Sub

    Public Function Check(ByVal location As Location) As Boolean
        If location.Name = myLocation.Name Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
