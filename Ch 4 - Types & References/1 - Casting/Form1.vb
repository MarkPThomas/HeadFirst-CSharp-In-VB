Option Strict On
Option Explicit On

Public Class Form1
    Private Sub showInteger_Click(sender As Object, e As EventArgs) Handles showInteger.Click
        Dim myDecimalValue As Decimal = 10
        Dim myIntValue As Integer = CType(myDecimalValue, Integer)

        MessageBox.Show("The myIntValue is " & myIntValue)
    End Sub
End Class
