Option Strict On
Option Explicit On

Public Class Form1
    Private Sub btnBaseClass_Click(sender As Object, e As EventArgs) Handles btnBaseClass.Click
        Dim myBaseClass As New MyBaseClass("Coffee!!!")
    End Sub

    Private Sub btnSubClass_Click(sender As Object, e As EventArgs) Handles btnSubClass.Click
        Dim mySubClass As New MySubclass("Candy!!!", 13)
    End Sub
End Class
