Option Strict On
Option Explicit On

<Serializable>
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


    Public Sub New(suit As Suits, value As Values)
        Me._suit = suit
        Me._value = value
    End Sub

    Public Shared Function DoesCardMatch(cardToCheck As Card, suit As Suits) As Boolean
        If cardToCheck.Suit = suit Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function DoesCardMatch(cardToCheck As Card, value As Values) As Boolean
        If cardToCheck.Value = value Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function Plural(value As Values) As String
        If value = Values.Six Then
            Return "Sixes"
        Else
            Return value.ToString() & "s"
        End If
    End Function
End Class
