Option Explicit On
Option Strict On

Public MustInherit Class PlanetMission
    Public RocketFuelPerMile As Long
    Public RocketSpeedMPH As Long
    Public MilesToPlanet As Integer

    Public Function UnitsOfFuelNeeded() As Long
        Return MilesToPlanet * RocketFuelPerMile
    End Function

    Public Function TimeNeeded() As Integer
        Return CInt(MilesToPlanet / RocketSpeedMPH)
    End Function

    Public Function FuelNeeded() As String
        Return "You'll need " &
            MilesToPlanet * RocketFuelPerMile &
            " units of fuel to get there. It'll take " &
            TimeNeeded() & " hours."
    End Function
End Class
