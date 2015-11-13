Option Explicit On
Option Strict On

Public Class OutsideWithHidingPlace
    Inherits Outside
    Implements IHidingPlace

    Private _hidingPlaceName As String
    Public Property HidingPlaceName As String Implements IHidingPlace.HidingPlaceName
        Get
            Return _hidingPlaceName
        End Get
        Private Set(value As String)
            _hidingPlaceName = value
        End Set
    End Property

    Public Overrides ReadOnly Property Description As String
        Get
            Return MyBase.Description & " Someone could hide " & HidingPlaceName & "."
        End Get
    End Property

    Public Sub New(ByVal name As String,
                   ByVal hot As Boolean,
                   ByVal hidingPlaceName As String)
        MyBase.New(name, hot)
        Me.HidingPlaceName = hidingPlaceName
    End Sub
End Class
