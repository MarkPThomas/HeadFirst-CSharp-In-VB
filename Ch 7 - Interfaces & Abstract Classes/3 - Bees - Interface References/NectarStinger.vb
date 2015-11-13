Option Strict On
Option Explicit On
Imports BeesInterfaceReferences

Public Class NectarStinger
    Inherits Worker
    Implements INectarCollector
    Implements IStingPatrol

    Public ReadOnly Property AlertLevel As Integer Implements IStingPatrol.AlertLevel
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property StingerLength As Integer Implements IStingPatrol.StingerLength
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub New(ByVal weightMG As Double)
        MyBase.New(New String() {"Nectar Collector", "String Patrol"}, weightMG)

    End Sub

    Public Sub FindFlowers() Implements INectarCollector.FindFlowers
        Throw New NotImplementedException()
    End Sub

    Public Sub GatherNectar() Implements INectarCollector.GatherNectar
        Throw New NotImplementedException()
    End Sub

    Public Sub ReturnToHive() Implements INectarCollector.ReturnToHive
        Throw New NotImplementedException()
    End Sub

    Public Function LookForEnemies() As Boolean Implements IStingPatrol.LookForEnemies
        Throw New NotImplementedException()
    End Function

    Public Function SharpenStinger(length As Integer) As Boolean Implements IStingPatrol.SharpenStinger
        Throw New NotImplementedException()
    End Function
End Class
