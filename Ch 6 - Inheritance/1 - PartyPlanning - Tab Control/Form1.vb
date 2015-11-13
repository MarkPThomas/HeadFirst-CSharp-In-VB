Public Class Form1
    Dim dinnerParty As New DinnerParty()
    Dim birthdayParty As New BirthdayParty()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dinnerParty = New DinnerParty(CInt(numericUpDown1.Value),
                                      fancyBox.Checked, healthyBox.Checked)
        DisplayDinnerPartyCost()

        birthdayParty = New BirthdayParty(CInt(numberBirthday.Value),
                                          fancyBirthday.Checked, cakeWriting.Text)
        DisplayBirthdayPartyCost()
    End Sub

    Private Sub DisplayBirthdayPartyCost()
        tooLongLabel.Visible = birthdayParty.CakeWritingTooLong
        Dim cost As Decimal = birthdayParty.Cost
        birthdayCost.Text = cost.ToString("c")
    End Sub

    Private Sub DisplayDinnerPartyCost()
        Dim cost As Decimal = dinnerParty.Cost
        costLabel.Text = cost.ToString("c")
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

    Private Sub numberBirthday_ValueChanged(sender As Object, e As EventArgs) Handles numberBirthday.ValueChanged
        birthdayParty.NumberOfPeople = CInt(numberBirthday.Value)
        DisplayBirthdayPartyCost()
    End Sub

    Private Sub fancyBirthday_CheckedChanged(sender As Object, e As EventArgs) Handles fancyBirthday.CheckedChanged
        birthdayParty.FancyDecorations = fancyBirthday.Checked
        DisplayBirthdayPartyCost()
    End Sub

    Private Sub cakeWriting_TextChanged(sender As Object, e As EventArgs) Handles cakeWriting.TextChanged
        birthdayParty.CakeWriting = cakeWriting.Text
        DisplayBirthdayPartyCost()
    End Sub
End Class
