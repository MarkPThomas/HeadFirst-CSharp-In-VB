Option Strict On
Option Explicit On

Public Class Talker
    Public Shared Function BlahBlahBlah(ByVal thingToSay As String,
                                        ByVal numberOfTimes As Integer) As Integer
        Dim finalString As String = ""
        For count = 0 To numberOfTimes - 1
            finalString = finalString & thingToSay & vbCrLf
        Next
        MessageBox.Show(finalString)

        Return finalString.Length
    End Function
End Class
