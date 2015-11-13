Option Strict On
Option Explicit On

Public Class Bee
    Public Const HoneyUnitsConsumedPerMg As Double = 0.25

    Private _weightMG As Double
    Public Property WeightMg As Double
        Get
            Return _weightMG
        End Get
        Private Set(value As Double)
            _weightMG = value
        End Set
    End Property

    Public Sub New(ByVal weightMG As Double)
        Me.WeightMg = weightMG
    End Sub

    Public Overridable Function HoneyConsumptionRate() As Double
        Return WeightMg * HoneyConsumptionRate
    End Function
End Class
