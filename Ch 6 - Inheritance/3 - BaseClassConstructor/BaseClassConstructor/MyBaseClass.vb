Option Strict On
Option Explicit On

Public Class MyBaseClass
    Public Sub New(ByVal baseClassNeedsThis As String)
        MessageBox.Show("This is the base class: " & baseClassNeedsThis)
    End Sub
End Class
