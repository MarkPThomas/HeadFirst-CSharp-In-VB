Option Explicit On
Option Strict On

Public Class Outside
    Inherits Location

    Private hot As Boolean
    Public Overrides ReadOnly Property Description As String
        Get
            Dim outsideDescription As String = MyBase.Description
            If hot Then outsideDescription &= " It's very hot here."

            Return outsideDescription
        End Get
    End Property



    Public Sub New(ByVal name As String,
                   ByVal hot As Boolean)
        MyBase.New(name)
        Me.hot = hot
    End Sub
End Class
