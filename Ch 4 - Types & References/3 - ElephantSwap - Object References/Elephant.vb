Option Strict On
Option Explicit On

Public Class Elephant
    Public Name As String
    Public EarSize As Integer

    Public Sub WhoAmI()
        MessageBox.Show("My ears are " & EarSize & " inches tall.", Name & " says ...")
    End Sub

    Public Sub TellMe(ByVal message As String, ByVal whoSaidIt As Elephant)
        MessageBox.Show(whoSaidIt.Name & " says: " & message)
    End Sub

    Public Sub SpeakTo(ByVal whoTotalkTo As Elephant, ByVal message As String)
        whoTotalkTo.TellMe(message, Me)
    End Sub
End Class
