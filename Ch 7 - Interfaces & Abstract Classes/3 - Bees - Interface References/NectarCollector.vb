Option Strict On
Option Explicit On
Imports BeesInterfaceReferences

Public Class NectarCollector
    Inherits Worker
    Implements INectarCollector

    Public Property Nectar As Integer

    Public Sub New(ByVal weightMG As Double)
        MyBase.New(New String() {"Nectar Collector"}, weightMG)

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
End Class
