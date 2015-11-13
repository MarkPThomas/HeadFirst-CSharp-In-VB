Option Explicit On
Option Strict On
Imports House

Public Class Form1
    Dim livingRoom As RoomWithDoor
    Dim kitchen As RoomWithDoor
    Dim diningRoom As Room

    Dim frontYard As OutsideWithDoor
    Dim backYard As OutsideWithDoor
    Dim garden As Outside

    Private currentLocation As Location

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateObjects()
        MoveToANewLocation(livingRoom)
    End Sub

    Private Sub CreateObjects()
        livingRoom = New RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob")
        kitchen = New RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door")
        diningRoom = New Room("Dining Room", "a crystal chandelier")

        frontYard = New OutsideWithDoor("Front Yard", False, "an oak door with a brass knob")
        backYard = New OutsideWithDoor("Back Yard", True, "a screen door")
        garden = New Outside("Garden", False)

        livingRoom.Exits = New Location() {diningRoom}
        kitchen.Exits = New Location() {diningRoom}
        diningRoom.Exits = New Location() {livingRoom, kitchen}

        frontYard.Exits = New Location() {backYard, garden}
        backYard.Exits = New Location() {frontYard, garden}
        garden.Exits = New Location() {frontYard, backYard}

        livingRoom.DoorLocation = frontYard
        frontYard.DoorLocation = livingRoom

        kitchen.DoorLocation = backYard
        backYard.DoorLocation = kitchen
    End Sub

    Private Sub MoveToANewLocation(ByVal newLocation As Location)
        currentLocation = newLocation

        exits.Items.Clear()
        For i = 0 To currentLocation.Exits.Length - 1
            exits.Items.Add(currentLocation.Exits(i).Name)
        Next
        exits.SelectedIndex = 0

        description.Text = currentLocation.Description

        If (TypeOf currentLocation Is IHasExteriorDoor) Then
            goThroughTheDoor.Visible = True
        Else
            goThroughTheDoor.Visible = False
        End If
    End Sub

    Private Sub goHere_Click(sender As Object, e As EventArgs) Handles goHere.Click
        Dim locationIndex As Integer = exits.SelectedIndex
        Dim nextLocation As Location = currentLocation.Exits(locationIndex)
        MoveToANewLocation(nextLocation)
    End Sub

    Private Sub goThroughTheDoor_Click(sender As Object, e As EventArgs) Handles goThroughTheDoor.Click
        Dim hasDoor As IHasExteriorDoor = TryCast(currentLocation, IHasExteriorDoor)
        MoveToANewLocation(hasDoor.DoorLocation)
    End Sub
End Class
