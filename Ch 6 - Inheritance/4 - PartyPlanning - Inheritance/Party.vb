Option Strict On
Option Explicit On

Public Class Party
    Public Const CostOfFoodPerPerson As Integer = 25

    Public Property NumberOfPeople As Integer
    Public Property FancyDecorations As Boolean


    Private Function CalculateCostOfDecorations() As Decimal
        Dim costOfDecorations As Decimal
        If FancyDecorations Then
            costOfDecorations = 50D + (15D * NumberOfPeople)
        Else
            costOfDecorations = 30D + (7.5D * NumberOfPeople)
        End If

        Return costOfDecorations
    End Function

    Public Overridable ReadOnly Property Cost As Decimal
        Get
            Dim totalCost As Decimal = CalculateCostOfDecorations()
            totalCost += (CostOfFoodPerPerson * NumberOfPeople)
            If NumberOfPeople > 12 Then totalCost += 100D

            Return totalCost
        End Get
    End Property


End Class
