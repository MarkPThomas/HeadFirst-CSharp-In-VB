Option Explicit On
Option Strict On

Public MustInherit Class Location
    Public Exits() As Location

    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Private Set(value As String)
            _name = value
        End Set
    End Property

    Public Sub New(ByVal name As String)
        Me.Name = name
    End Sub


    Public Overridable ReadOnly Property Description() As String
        Get
            Dim _description As String = "You're standing in the " & Name &
                                        ". You see exits to the following places: "
            For i = 0 To Exits.Length - 1
                _description &= " " & Exits(i).Name
                If (Not i = Exits.Length - 1) Then _description &= ", "
            Next
            _description &= "."

            Return _description
        End Get
    End Property
End Class
