Option Explicit On
Option Strict On

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim mars As New Mars()
        MessageBox.Show(mars.FuelNeeded())
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim venus As New Venus()
        MessageBox.Show(venus.FuelNeeded())
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' The lines below will Not compile for an abstract class.
        ' If the class were Not an abstract class, then there will be a divide-by-zero error
        ' as the class does Not have the fuel property initialized.

        ' This class, as an abstract class, can be inherited by `Mars` And `Venus` but can never
        ' itself be instantiated.

        ' Dim PlanetMission As New PlanetMission()
        ' MessageBox.Show(PlanetMission.FuelNeeded())
    End Sub
End Class
