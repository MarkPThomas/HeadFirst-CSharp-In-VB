Option Strict On
Option Explicit On

Public Class JerseyNumber
    Private _player As String
    Public Property Player() As String
        Get
            Return _player
        End Get
        Private Set(ByVal value As String)
            _player = value
        End Set
    End Property

    Private _yearRetired As Integer
    Public Property YearRetired() As Integer
        Get
            Return _yearRetired
        End Get
        Private Set(ByVal value As Integer)
            _yearRetired = value
        End Set
    End Property

    Public Sub New(newPlayer As String, numberRetired As Integer)
        Player = newPlayer
        YearRetired = numberRetired
    End Sub
End Class
