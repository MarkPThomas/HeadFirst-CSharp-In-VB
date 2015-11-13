Option Strict On
Option Explicit On

Public Class Form1
    Dim startingMileage As Integer
    Dim endingMileage As Integer
    Dim milesTraveled As Double
    Dim reimburseRate As Double = 0.39
    Dim amountOwed As Double

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        label4.Text = ""
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        startingMileage = CType(numericUpDown1.Value, Integer)
        endingMileage = CType(numericUpDown2.Value, Integer)

        If startingMileage < endingMileage Then
            milesTraveled = endingMileage - startingMileage
            amountOwed = milesTraveled * reimburseRate
            label4.Text = "$" & amountOwed
        Else
            MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate Mileage")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        MessageBox.Show(milesTraveled & " miles", "Miles Traveled")
    End Sub
End Class
