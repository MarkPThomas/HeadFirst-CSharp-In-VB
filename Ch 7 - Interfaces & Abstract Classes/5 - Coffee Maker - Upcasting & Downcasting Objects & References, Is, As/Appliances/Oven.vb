Option Explicit On
Option Strict On
Imports Appliances

Public Class Oven
    Inherits Appliance
    Implements ICooksFood

    Public Property Capacity As Double Implements ICooksFood.Capacity
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Double)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub Preheat()

    End Sub

    Public Sub HeatUp() Implements ICooksFood.HeatUp
        Throw New NotImplementedException()
    End Sub

    Public Sub Reheat() Implements ICooksFood.Reheat
        Throw New NotImplementedException()
    End Sub
End Class
