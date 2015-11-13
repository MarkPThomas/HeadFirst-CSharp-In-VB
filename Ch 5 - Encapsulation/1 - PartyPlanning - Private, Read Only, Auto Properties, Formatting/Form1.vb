Option Strict On
Option Explicit On

Public Class Form1
    Dim dinnerParty As New DinnerParty

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dinnerParty = New DinnerParty(CInt(numericUpDown1.Value),
                                      healthyBox.Checked, fancyBox.Checked)
        DisplayDinnerPartyCost()
    End Sub

    Private Sub DisplayDinnerPartyCost()
        Dim Cost As Decimal = dinnerParty.Cost
        costLabel.Text = Cost.ToString("c")
    End Sub

    Private Sub numericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown1.ValueChanged
        dinnerParty.NumberOfPeople = CInt(numericUpDown1.Value)
        DisplayDinnerPartyCost()
    End Sub

    Private Sub fancyBox_CheckedChanged(sender As Object, e As EventArgs) Handles fancyBox.CheckedChanged
        dinnerParty.FancyDecorations = fancyBox.Checked
        DisplayDinnerPartyCost()
    End Sub

    Private Sub healthyBox_CheckedChanged(sender As Object, e As EventArgs) Handles healthyBox.CheckedChanged
        dinnerParty.HealthyOption = healthyBox.Checked
        DisplayDinnerPartyCost()
    End Sub
End Class
