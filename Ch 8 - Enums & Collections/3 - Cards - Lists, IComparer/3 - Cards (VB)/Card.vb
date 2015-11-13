Option Strict On
Option Explicit On

Public Class Card
    Private _suit As Suits
    Public Property Suit() As Suits
        Get
            Return _suit
        End Get
        Set(ByVal value As Suits)
            _suit = value
        End Set
    End Property

    Private _value As Values
    Public Property Value() As Values
        Get
            Return _value
        End Get
        Set(ByVal value As Values)
            _value = value
        End Set
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return Value.ToString() & " of " & Suit.ToString()
        End Get
    End Property


    Sub New(suit As Suits, value As Values)
        Me._suit = suit
        Me._value = value
    End Sub

End Class
