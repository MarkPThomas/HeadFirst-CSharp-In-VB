Option Strict On
Option Explicit On

<Serializable>
Public Class Guy
    Public Name As String
    Public Cash As Integer

    Public Function GiveCash(ByVal amount As Integer) As Integer
        If (amount <= Cash AndAlso amount > 0) Then
            Cash -= amount
            Return amount
        Else
            MessageBox.Show(
                "I don't have enough cash to give you " & amount,
                Name & " says ...")
            Return 0
        End If
    End Function

    Public Function ReceiveCash(ByVal amount As Integer) As Integer
        If amount > 0 Then
            Cash += amount
            Return amount
        Else
            MessageBox.Show(
            amount & " isn't an amount I'll take",
            Name & " says ...")
            Return 0
        End If
    End Function
End Class
