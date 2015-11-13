Option Strict On
Option Explicit On

Public Class Farmer
    Private _bagsOfFeed As Integer
    Public Property BagsOfFeed() As Integer
        Get
            Return _bagsOfFeed
        End Get
        ' Private Set only allows property to be set during initialization
        Private Set(ByVal value As Integer)
            _bagsOfFeed = value
        End Set
    End Property

    Private _feedMultiplier As Integer
    Public ReadOnly Property FeedMultiplier() As Integer
        Get
            Return _feedMultiplier
        End Get
    End Property

    Private _numberOfCows As Integer
    Public Property NumberOfCows() As Integer
        Get
            Return _numberOfCows
        End Get
        Set(ByVal value As Integer)
            _numberOfCows = value
            BagsOfFeed = NumberOfCows * FeedMultiplier
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal numberOfCows As Integer,
                   ByVal feedMultiplier As Integer)
        Me._feedMultiplier = feedMultiplier
        Me.NumberOfCows = numberOfCows
    End Sub

End Class
