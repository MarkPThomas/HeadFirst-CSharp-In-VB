Option Strict On
Option Explicit On

Public Class MySubclass
    Inherits MyBaseClass

    Public Sub New(ByVal baseClassneedsThis As String,
                   ByVal anotherValue As Integer)
        MyBase.New(baseClassneedsThis)
        MessageBox.Show("This is a subclass: " & baseClassneedsThis & " and " & anotherValue)
    End Sub
End Class
