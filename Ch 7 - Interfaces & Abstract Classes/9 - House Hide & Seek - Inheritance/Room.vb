Option Explicit On
Option Strict On

Public Class Room
    Inherits Location

    Private decoration As String

    Public Overrides ReadOnly Property Description As String
        Get
            Return MyBase.Description & " You see " & decoration & "."
        End Get
    End Property

    Public Sub New(ByVal name As String,
                   ByVal decoration As String)
        MyBase.New(name)
        Me.decoration = decoration
    End Sub

End Class
