Option Strict On
Option Explicit On

Public Class DinnerParty
    Inherits Party

    Public Property HealthyOption As Boolean

    Public Overrides ReadOnly Property Cost As Decimal
        Get
            Dim totalCost As Decimal = MyBase.Cost
            totalCost += (CalculateCostOfBeveragesPerPerson() * NumberOfPeople)

            If HealthyOption Then
                totalCost *= 0.95D
            End If

            Return totalCost
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal numberOfPeople As Integer,
                   ByVal fancyDecorations As Boolean,
                   ByVal healthyOption As Boolean)
        Me.NumberOfPeople = numberOfPeople
        Me.FancyDecorations = fancyDecorations
        Me.HealthyOption = healthyOption
    End Sub

    Private Function CalculateCostOfBeveragesPerPerson() As Decimal
        Dim costOfBeveragesPerPerson As Decimal
        If HealthyOption Then
            costOfBeveragesPerPerson = 5D
        Else
            costOfBeveragesPerPerson = 20D
        End If

        Return costOfBeveragesPerPerson
    End Function
End Class
