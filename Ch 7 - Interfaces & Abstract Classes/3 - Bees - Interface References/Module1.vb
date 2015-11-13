Option Strict On
Option Explicit On

Module Module1
    Public Sub Main()
        Dim biff As New StingPatrol(72)
        Dim bertha As New NectarCollector(45)

        ' Defender can reference biff since they implement the same interface
        ' Defender itself cannot be initialized since it Is only an interface, but it can point to the 'biff' object
        Dim defender As IStingPatrol = biff
        Dim cutiePie As INectarCollector = bertha

        ' Biff's object remains since the defender still references it
        biff = Nothing

        ' Assigning an object straight to an interface reference variable
        Dim gatherer As INectarCollector = New NectarStinger(90)

        ' In the following, the array can include several different class types as they all inherit from 'Worker'.
        ' Bee 0 & bee 2 will be assigned the job as they both inherit the INectarCollector
        Dim bees(2) As Worker
        bees(0) = New NectarCollector(40)
        bees(1) = New StingPatrol(60)
        bees(2) = New NectarStinger(85)

        For i = 0 To bees.Length - 1
            If (TypeOf bees(i) Is INectarCollector) Then
                bees(i).DoThisJob("Nectar Collector", 3)
            End If
        Next
    End Sub

End Module
