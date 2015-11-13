Option Strict On
Option Explicit On

Public Class DinnerParty
    Public Const CostOfFoodPerPerson As Integer = 25

    Public Property NumberOfPeople As Integer
    Public Property FancyDecorations As Boolean
    Public Property HealthyOption As Boolean

    Public ReadOnly Property Cost As Decimal
        Get
            Dim totalCost As Decimal = CalculateCostOfDecorations()
            totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople)

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

    Private Function CalculateCostOfDecorations() As Decimal
        Dim costOfDecorations As Decimal
        If FancyDecorations Then
            costOfDecorations = 50D + (15D * NumberOfPeople)
        Else
            costOfDecorations = 30D + (7.5D * NumberOfPeople)
        End If

        Return costOfDecorations
    End Function

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
