Option Explicit On
Option Strict On

Public Class Form1
    Dim livingRoom As RoomWithDoor
    Dim kitchen As RoomWithDoor
    Dim diningRoom As RoomWithHidingPlace
    Dim stairs As Room
    Dim upstairsHallway As RoomWithHidingPlace
    Dim masterBedroom As RoomWithHidingPlace
    Dim secondBedroom As RoomWithHidingPlace
    Dim bathroom As RoomWithHidingPlace

    Dim frontYard As OutsideWithDoor
    Dim backYard As OutsideWithDoor
    Dim garden As OutsideWithHidingPlace
    Dim driveway As OutsideWithHidingPlace

    Dim opponent As Opponent

    Private currentLocation As Location
    Private moves As Integer
    Private currentHidingPlaceChecked As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateObjects()
        ResetGame(False)
    End Sub

    Private Sub CreateObjects()
        livingRoom = New RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob", "inside the closet")
        kitchen = New RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door", "in the cabinet")
        diningRoom = New RoomWithHidingPlace("Dining Room", "a crystal chandelier", "in the tall armoire")
        stairs = New Room("Stairs", "a wooden bannister")
        upstairsHallway = New RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet")
        masterBedroom = New RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed")
        secondBedroom = New RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed")
        bathroom = New RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower")

        frontYard = New OutsideWithDoor("Front Yard", False, "an oak door with a brass knob")
        backYard = New OutsideWithDoor("Back Yard", True, "a screen door")
        garden = New OutsideWithHidingPlace("Garden", False, "inside the shed")
        driveway = New OutsideWithHidingPlace("Driveway", False, "in the garage")

        livingRoom.Exits = New Location() {diningRoom, stairs}
        stairs.Exits = New Location() {livingRoom, upstairsHallway}
        kitchen.Exits = New Location() {diningRoom}
        diningRoom.Exits = New Location() {livingRoom, kitchen}
        upstairsHallway.Exits = New Location() {masterBedroom, secondBedroom, bathroom, stairs}
        masterBedroom.Exits = New Location() {upstairsHallway}
        secondBedroom.Exits = New Location() {upstairsHallway}
        bathroom.Exits = New Location() {upstairsHallway}

        frontYard.Exits = New Location() {backYard, garden, driveway}
        backYard.Exits = New Location() {frontYard, garden, driveway}
        garden.Exits = New Location() {frontYard, backYard}
        driveway.Exits = New Location() {frontYard, backYard}

        livingRoom.DoorLocation = frontYard
        frontYard.DoorLocation = livingRoom

        kitchen.DoorLocation = backYard
        backYard.DoorLocation = kitchen

        opponent = New Opponent(frontYard)
    End Sub

    Private Sub MoveToANewLocation(ByVal newLocation As Location)
        moves += 1
        currentLocation = newLocation

        RedrawForm()
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

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        moves += 1
        If opponent.Check(currentLocation) Then
            ResetGame(True)
        Else
            RedrawForm()
        End If
    End Sub

    Private Sub hide_Click(sender As Object, e As EventArgs) Handles opponentHide.Click
        opponentHide.Visible = False

        For i = 1 To 10
            description.Text = i & "... "
            opponent.Move()
            Application.DoEvents()
            Threading.Thread.Sleep(200)
        Next

        description.Text = "Ready or not, here I come!"
        Application.DoEvents()
        Threading.Thread.Sleep(500)

        goHere.Visible = True
        exits.Visible = True
        MoveToANewLocation(livingRoom)
    End Sub

    Private Sub RedrawForm()
        exits.Items.Clear()
        For i = 0 To currentLocation.Exits.Length - 1
            exits.Items.Add(currentLocation.Exits(i).Name)
        Next
        exits.SelectedIndex = 0

        description.Text = currentLocation.Description & vbCrLf & "(move #" & moves & ")"

        If (TypeOf currentLocation Is IHidingPlace) Then
            check.Visible = True
            Dim currentHidingPlace As IHidingPlace = TryCast(currentLocation, IHidingPlace)
            currentHidingPlaceChecked = currentHidingPlace.HidingPlaceName
            check.Text = "Check " & currentHidingPlaceChecked
        Else
            check.Visible = False
        End If

        If (TypeOf currentLocation Is IHasExteriorDoor) Then
            goThroughTheDoor.Visible = True
        Else
            goThroughTheDoor.Visible = False
        End If
    End Sub

    Private Sub ResetGame(ByVal displayMessage As Boolean)
        If displayMessage Then
            MessageBox.Show("You found me in " & moves & " moves!")
            description.Text = "You found your opponent in " & moves & " moves! He was hiding " &
                                currentHidingPlaceChecked & "."
        End If

        opponent = New Opponent(frontYard)
        moves = 0

        goHere.Visible = False
        exits.Visible = False
        goThroughTheDoor.Visible = False
        check.Visible = False

        opponentHide.Visible = True
    End Sub


End Class
